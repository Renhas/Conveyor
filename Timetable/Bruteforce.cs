using ConveyorSystem;
using Permutations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable
{
    public static class Bruteforce
    {
        public static Result Run(Conveyor conveyor) 
        {
            int min = int.MaxValue;
            Permutation<Job> minPermutation = new Permutation<Job>();
            Permutation<Job> startPermutation = new Permutation<Job>();
            foreach (var job in conveyor.GetJobs()) startPermutation.Values.Add(job);
            PermutationGenerator<Job>.Generate(SearchMin, startPermutation);
            void SearchMin(Permutation<Job> permutation) 
            {
                int current = TimetableAlgorythm.Run(permutation, conveyor);
                if (current < min) 
                {
                    min = current;
                    minPermutation = permutation.Copy();
                }
                    
            }
            return new Result(minPermutation, min);
        }
    }
}
