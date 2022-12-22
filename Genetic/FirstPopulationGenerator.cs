using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic
{
    
    internal static class FirstPopulationGenerator
    {
        public static Encoding[] Generate(int populationLenght, int encodingLenght, Random random) 
        {
            Encoding[] population = new Encoding[populationLenght];

            for (int i = 0; i < populationLenght; i++) 
            {
                population[i] = Encoding.CreateRandom(encodingLenght, random);
            }

            return population;
        }
    }
}
