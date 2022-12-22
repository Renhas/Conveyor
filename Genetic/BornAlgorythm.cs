using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic
{
    internal static class BornAlgorythm
    {
        private static Random rnd;
        public static Encoding[] Born(Encoding[] parents, Random random, float crossoverProbability = 1f) 
        {
            rnd = random;
            if (parents.Length < 3) throw new ArgumentOutOfRangeException("parents");
            int childrenCount = parents.Length * 2;
            Encoding[] children = new Encoding[childrenCount];

            for(int i = 0; i < childrenCount; i++)
            {
                if (rnd.NextDouble() > crossoverProbability) continue;
                Encoding first_parent = parents[rnd.Next(0, parents.Length)];
                Encoding second_parent = ParentSearch(parents, first_parent,
                    rnd.Next(0, 2) == 0 ? false : true);

                children[i] = CrossoverAlgorythm.Run(first_parent, second_parent, rnd);
            }
            return children;    
        }

        private static Encoding ParentSearch(Encoding[] parents, Encoding first_parent, bool mode) 
        {
            Encoding second_parent = null;
            int d = parents.Length * parents.Length / 2;

            while (second_parent == null) 
            {
                List<Encoding> correct_parent = new List<Encoding>();
                foreach (Encoding parent in parents) 
                {
                    if (parent == first_parent) continue;
                    if (mode && first_parent.Distance(parent) <= d) correct_parent.Add(parent);
                    else if (!mode && first_parent.Distance(parent) > d) correct_parent.Add(parent);
                }
                if (correct_parent.Any())
                {
                    second_parent = correct_parent[rnd.Next(correct_parent.Count)];
                }
                else 
                {
                    _ = mode ? d++ : d--;
                }
            }

            return second_parent;
        }

        
    }
}
