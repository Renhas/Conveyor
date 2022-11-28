using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConveyorSystem
{
    public static class MyReader
    {
        public static Conveyor Read(string filePath) 
        {
            string[] lines = File.ReadAllLines(filePath);
            int[,] matrix = CreateMatrix(lines);

            int machineCount = matrix.GetUpperBound(0) - 1;
            Conveyor conveyor = new Conveyor(machineCount);

            for (int jobId = 0; jobId < matrix.GetUpperBound(1) + 1; jobId++) 
            {
                int[] tacts = new int[machineCount];
                for (int machineId = 0; machineId < machineCount; machineId++) 
                {
                    tacts[machineId] = matrix[machineId, jobId];
                }

                Job job = new Job(jobId + 1, tacts, matrix[machineCount, jobId], matrix[machineCount + 1, jobId]);
                conveyor.AddJob(job);
            }

            return conveyor;
        }

        private static int[,] CreateMatrix(string[] lines) 
        {
            char[] badChars = { ' ', '|', ',', '.' };
            int n = lines.Count();
            int m = lines[0].Split(badChars, StringSplitOptions.RemoveEmptyEntries).Count();
            int[,] matrix = new int[n,m];

            for (int i = 0; i < n; i++) 
            {
                string[] ints = lines[i].Split(badChars, StringSplitOptions.RemoveEmptyEntries);
                if (ints.Count() != m) throw new ArgumentException($"Некорректные входные данные: размерность строки {i}");
                for (int j = 0; j < m; j++) matrix[i, j] = int.Parse(ints[j]);
            }
            return matrix;
        }
    }
}
