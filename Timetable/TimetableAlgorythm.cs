using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ConveyorSystem;
using Permutations;

namespace Timetable
{
    public static class TimetableAlgorythm
    {
        public static int Run(Permutation<Job> permutation, Conveyor conveyor)
        {
            if (permutation.Values.Count() != conveyor.JobCount) 
                throw new ArgumentException("Некорректный список работ");
            if (permutation == null || conveyor == null) 
                throw new ArgumentNullException();

            List<Job> jobs = permutation.Values;

            SetTimes(jobs[0]);

            for (int jobId = 1; jobId < conveyor.JobCount; jobId++) 
            {
                Job currentJob = jobs[jobId];
                Job prevJob = jobs[jobId - 1];
                SetTimes(currentJob, prevJob);
            }

            return conveyor.CalculateCriterion();
        }

        private static void SetTimes(Job currentJob, Job prevJob) 
        {
            if (currentJob == null) return;
            if (prevJob == null) SetTimes(currentJob);
            currentJob.StartTimes[0] = prevJob.StartTimes[0] + prevJob.Tacts[0];
            for (int machineId = 1; machineId < currentJob.Tacts.Length; machineId++)
            {
                int currentEndTime = currentJob.StartTimes[machineId - 1] + currentJob.Tacts[machineId - 1];
                int prevEndTime = prevJob.StartTimes[machineId] + prevJob.Tacts[machineId];
                currentJob.StartTimes[machineId] = Math.Max(currentEndTime, prevEndTime);
            }

        }

        private static void SetTimes(Job currentJob) 
        {
            currentJob.StartTimes[0] = 1;
            for (int machineId = 1; machineId < currentJob.Tacts.Length; machineId++)
            {
                currentJob.StartTimes[machineId] = currentJob.StartTimes[machineId - 1] + currentJob.Tacts[machineId - 1];
            }
        }

    }
}
