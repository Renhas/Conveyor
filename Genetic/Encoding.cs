using ConveyorSystem;
using Permutations;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic
{
    internal class Encoding
    {
        private int[] ids; 
        public readonly int Lenght;
        public Encoding(int lenght) 
        {
            Lenght= lenght;
            ids = new int[lenght];
            for(int i = 0; i < lenght; i++) ids[i] = 0;
        }

        public int this[int id] 
        {
            get { return ids[id]; }
            set { ids[id] = value; }
        }

        public int[] GetEncoding() 
        {
            int[] temp = new int[ids.Length];
            ids.CopyTo(temp, 0);
            return temp;
        }

        public int Distance(Encoding other) 
        {
            if (other.Lenght != Lenght) throw new ArgumentException("Невозможно вычислить расстояние");

            int result = 0;
            for (int i = 0; i < Lenght; i++) 
            {
                result += Math.Abs(other[i] - ids[i]);
            }

            return result;
        }

        public static Encoding CreateRandom(int lenght, Random rnd) 
        {
            if(rnd == null) rnd = new Random(Environment.TickCount);
            Encoding encoding = new Encoding(lenght);
            List<int> free = new List<int>();
            for (int i = 0; i < lenght; i++) free.Add(i + 1);

            for (int j = 0; j < lenght; j++)
            {
                int id = rnd.Next(free.Count);
                encoding.ids[j] = free[id];
                free.RemoveAt(id);
            }
            
            return encoding;
        }

        public Permutation<Job> ToPermutation(Conveyor conveyor) 
        {
            if (conveyor.JobCount != Lenght) throw new ArgumentOutOfRangeException();
            
            Permutation<Job> permutation= new Permutation<Job>();
            foreach (int id in ids) permutation.Values.Add(conveyor[id - 1]);
            return permutation;
        }

        public override string ToString()
        {
            string str = "[";
            for(int i = 0; i < Lenght - 1; i++) str += $"{ids[i]}, ";
            str += $"{ids[Lenght-1]}]";
            return str;
        }

    }
}
