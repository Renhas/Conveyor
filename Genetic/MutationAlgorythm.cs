using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic
{
    internal static class MutationAlgorythm
    {
        private static Random rnd;
        public static void Run(Encoding[] children, Random random, float mutationProbability = 0.1f) 
        {
            rnd = random;
            for(int i = 0; i < children.Length; i++)
            {
                if (rnd.NextDouble() > mutationProbability) continue;

                switch (rnd.Next(3)) 
                {
                    case 0:
                        GenMutation(children[i]);
                        break;
                    case 1:
                        MacroMutation(children[i]);
                        break;
                    case 2:
                        children[i] = Encoding.CreateRandom(children[i].Lenght, rnd);
                        break;
                }
            }


        }

        private static void GenMutation(Encoding child) 
        {
            int id = rnd.Next(child.Lenght);
            int offset;
            if (id == 0) offset = 1;
            else if (id == child.Lenght - 1) offset = -1;
            else if (rnd.Next(2) == 0) offset = -1;
            else offset = 1;

            (child[id], child[id + offset]) = (child[id + offset], child[id]);
        }

        private static void MacroMutation(Encoding child) 
        {
            int id = rnd.Next(child.Lenght);
            int second_id, direction;
            
            if (id < 2) direction = 1;
            else if (id > child.Lenght - 3) direction = -1;
            else if (rnd.Next(2) == 0) direction = -1;
            else direction = 1;

            if (direction == 1) second_id = rnd.Next(id + 2, child.Lenght);
            else second_id = rnd.Next(id - 1);

            (child[id], child[second_id]) = (child[second_id], child[id]);
        }
    }
}
