using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConveyorSystem
{
    public class Conveyor
    {
        public readonly int Machines;
        public int JobCount { get { return Jobs.Count; } }
        private List<Job> Jobs { get; set; }
        public Conveyor(int machines) 
        {
            Machines = machines;
            Jobs = new List<Job>();
        }
        public Job this[int id] 
        {
            get 
            {
                if (id < 0 || id > Jobs.Count) throw new ArgumentOutOfRangeException();
                return Jobs[id];
            }
        }
        public void AddJob(Job job) 
        {
            if (job.Tacts.Length == Machines) Jobs.Add(job);
        }
        public void DeleteJob(Job job) => Jobs.Remove(job);
        public List<Job> GetJobs() 
        {
            List<Job> list = new List<Job>();
            foreach(var job in Jobs) list.Add(job);
            return list;
        }   
        public int CalculateCriterion()
        {
            int result = 0;
            foreach (var job in Jobs) result += job.CalculateTotalPenalty();
            return result;
        }
        public int[,] TimetableMatrix(int totalTacts)
        {

            int[,] matrix = new int[Machines, totalTacts];

            for (int i = 0; i < Machines; i++)
                for (int j = 0; j < totalTacts; j++)
                    SetCell(matrix, i, j);
            return matrix;
                
        }
        private void SetCell(int[,] matrix, int row, int column) 
        {
            int tact = column + 1;
            foreach (var job in Jobs) 
            {
                int startTime = job.StartTimes[row];
                int endTime = startTime + job.Tacts[row] - 1;
                if (startTime <= tact && tact <= endTime) 
                {
                    matrix[row, column] = job.Id;
                    return;
                }
            }
            matrix[row, column] = 0;
        }
        public Conveyor Copy() 
        {
            Conveyor conveyor = new Conveyor(Machines);
            foreach (var job in Jobs) conveyor.AddJob(job);
            return conveyor;
        }
        public override string ToString()
        {
            string str = "";
            foreach (var job in Jobs) str += $"{job}\n";
            return str;
        }

        
    }
}
