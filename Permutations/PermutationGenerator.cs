using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{
    public static class PermutationGenerator<T>
    {
        public delegate void PermutationAction(Permutation<T> permutation);

        public static void Generate(PermutationAction action, Permutation<T> permutation) 
        {
            if(permutation == null) throw new ArgumentNullException("lenght");
            if(action == null) throw new ArgumentNullException("action");

            Recursiv(0);
            void Recursiv(int done)
            {
                if (done == permutation.Values.Count)
                    action(permutation);

                for (int j = done; j < permutation.Values.Count; j++)
                {
                    permutation.Swap(j, done);
                    Recursiv(done + 1);
                    permutation.Swap(j, done);
                }
            }
        }
    }
}
