using ConveyorSystem;
using Permutations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable
{
    public static class Heuristic
    {

        public static Result Upper(Conveyor conveyor) 
        {
            Permutation<Job> permutation = SortUpper(conveyor);
            return new Result(permutation, TimetableAlgorythm.Run(permutation, conveyor));
        }

        public static Result Lower(Conveyor conveyor) 
        {
            Permutation<Job> permutation = SortUpper(conveyor);
            permutation.Values.Reverse();
            return new Result(permutation, TimetableAlgorythm.Run(permutation, conveyor));
        }

        public static Result Tanaev(Conveyor conveyor, Permutation<Job> permutation = null) 
        {
            if(permutation == null) permutation = SortUpper(conveyor);
            
            int criterion = TimetableAlgorythm.Run(permutation, conveyor);
            int badId = CheckJobs(permutation);
            if (badId == -1) return new Result(permutation, criterion);

            Conveyor tempConveyor = conveyor.Copy();
            Permutation<Job> tempPermutation = permutation.Copy();
            Job job = permutation.Values[badId];
            for (int i = 0; i < badId; i++) 
            {
                if (permutation.Values[i].TotalTime() > job.TotalTime())
                    job = permutation.Values[i];
            }

            tempConveyor.DeleteJob(job);
            tempPermutation.Values.Remove(job);

            Tanaev(tempConveyor, tempPermutation);

            tempConveyor.AddJob(job);
            tempPermutation.Values.Add(job);

            criterion = TimetableAlgorythm.Run(tempPermutation, tempConveyor);
            return new Result(tempPermutation, criterion);
        }

        private static int CheckJobs(Permutation<Job> permutation) 
        {
            for (int i = 0; i < permutation.Values.Count(); i++)
                if (permutation.Values[i].CalculateTotalPenalty() > 0) return i;
            return -1;
        }

        private static Permutation<Job> SortUpper(Conveyor conveyor) 
        {
            Permutation<Job> permutation = new Permutation<Job>();
            foreach (var job in conveyor.GetJobs()) permutation.Values.Add(job);
            permutation.Sort();
            return permutation;
        }
    }
}
