using ConveyorSystem;
using Permutations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timetable;

namespace Genetic
{
    static public class MainAlgorythm
    {
        private static Random rnd = null;
        private static int totalCount = 1;
        private static int count = 0;
        public static Result Run(Conveyor conveyor, int populationCount = 10, float crossoverProbability = 1f, float mutationProbability = 0.1f, int steps = 1000) 
        {
            
            if (conveyor == null) throw new ArgumentNullException("conveyor");
            if (populationCount < 1) throw new ArgumentOutOfRangeException("populationCount");
            if (crossoverProbability <= 0f || crossoverProbability > 1f) throw new ArgumentOutOfRangeException("crossoverProbability");
            if (mutationProbability < 0f || mutationProbability > 1f) throw new ArgumentOutOfRangeException("mutationProbability");

            if(rnd == null) rnd = new Random(Environment.TickCount);
            totalCount = steps;
            var jobs = conveyor.GetJobs();
            Encoding[] population = FirstPopulationGenerator.Generate(populationCount, jobs.Count, rnd);

            for (int i = 0; i < steps; i++) 
            {
                
                Encoding[] children = BornAlgorythm.Born(population, rnd, crossoverProbability);
                MutationAlgorythm.Run(children, rnd, mutationProbability);

                population = SelectionAlgorythm.Run(conveyor, population, children, rnd);
                count = i + 1;
            }

            List<Encoding> temp = population.ToList();
            temp.Sort(new EncodingComparer(conveyor));
            temp.Reverse();
            Permutation<Job> permutation = temp[0].ToPermutation(conveyor);
            int criterion = TimetableAlgorythm.Run(permutation, conveyor);
            return new Result(permutation, criterion);

        }

        public static float GetProgress() => (float)count / totalCount;

    }
}
