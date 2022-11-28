using ConveyorSystem;
using Permutations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable
{
    public static class h_StepAlgorythm
    {
        public static Result Run(int h, Conveyor conveyor) 
        {
            if (h > conveyor.JobCount || h < 1) throw new ArgumentOutOfRangeException("h");
            Permutation<Job> firstPermutation = new Permutation<Job>();
            for (int i = 0; i < h; i++) 
            {
                firstPermutation.Values.Add(conveyor[i]);
            }

            Result result = new Result(new Permutation<Job>(), int.MaxValue);
            PermutationGenerator<Job>.Generate(FirstH, firstPermutation);
            void FirstH(Permutation<Job> permutation) 
            {
                Permutation<Job> temp = permutation.Copy();
                for (int i = h; i < conveyor.JobCount; i++)
                {
                    temp.Values.Add(conveyor[i]);
                }
                int criterion = TimetableAlgorythm.Run(temp, conveyor);
                if (criterion < result.Criterion) 
                {
                    result.Criterion = criterion;
                    result.Permutation = temp;
                }

            }
            return result;
        }
    }
}
