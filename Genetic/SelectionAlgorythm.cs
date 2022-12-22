using ConveyorSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Genetic
{
    internal static class SelectionAlgorythm
    {
        private static EncodingComparer comparer;
        private static Random rnd;
        public static Encoding[] Run(Conveyor conveyor, Encoding[] population, Encoding[] children, Random random) 
        {
            rnd = random;
            Encoding[] new_generation = new Encoding[population.Length];
            int g = rnd.Next(1, population.Length);

            ///Элитарная стратегия
            comparer = new EncodingComparer(conveyor); 
            List<Encoding> parentTemp = population.ToList();
            parentTemp.Sort(comparer);
            parentTemp.Reverse();
            List<Encoding> childTemp = children.ToList();
            childTemp.Sort(comparer);
            childTemp.Reverse();

            if (comparer.Compare(parentTemp[0], childTemp[0]) > 0)
            {
                new_generation[0] = parentTemp[0];
                parentTemp = population.ToList();
                parentTemp.Remove(new_generation[0]);
                population = parentTemp.ToArray();
            }
            else 
            {
                new_generation[0] = childTemp[0];
                childTemp = children.ToList();
                childTemp.Remove(new_generation[0]);
                children = childTemp.ToArray();
            }


            double[] probabilities = new double[population.Length];
            for (int i = 0; i < population.Length; i++) probabilities[i] = 1d / population.Length;

            Encoding[] good_parents = Roulette(population, probabilities, population.Length - g);
            for (int i = 1; i <= population.Length - g; i++) 
            {
                new_generation[i] = good_parents[i-1];
            }

            Encoding[] good_children = Tournament(children, g);
            for (int i = population.Length - g + 1; i < new_generation.Length; i++) 
            {
                new_generation[i] = good_children[i - population.Length + g - 1];
            }

            return new_generation;

        }

        private static Encoding[] Roulette(Encoding[] population, double[] probabilities, int count) 
        {
            Encoding[] encodings = new Encoding[count];

            for (int i = 0; i < count; i++)
            {
                
                double ksi = rnd.NextDouble() * probabilities.Sum();
                double probability_sum = 0d;
                for (int j = 0; j < population.Length; j++)
                {
                    if (ksi >= probability_sum && ksi < probability_sum + probabilities[j])
                    {
                        encodings[i] = population[j];
                        probabilities[j] = 0d;
                        break;
                    }
                    probability_sum += probabilities[j];
                }
            }

            return encodings;
        }

        private static Encoding[] Tournament(Encoding[] children, int count) 
        {
            Encoding[] winners = new Encoding[count];

            for (int i = 0; i < count; i++) 
            {
                double[] probabilities = new double[children.Length];
                for (int j = 0; j < children.Length; j++) probabilities[j] = 1d / children.Length;
                int betta = Math.Min(children.Length, count);

                Encoding[] members = Roulette(children, probabilities, betta);
                List<Encoding> temp = members.ToList();
                temp.Sort(comparer);
                temp.Reverse();
                Encoding winner = temp[0];
                winners[i] = winner;
                
                temp = children.ToList();
                temp.Remove(winner);
                children = temp.ToArray();


            }

            return winners;

        }
    }
}
