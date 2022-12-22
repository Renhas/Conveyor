using ConveyorSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timetable;

namespace Genetic
{
    internal class EncodingComparer : IComparer<Encoding>
    {
        private readonly Conveyor conveyor;
        public EncodingComparer(Conveyor conveyor) 
        {
            this.conveyor = conveyor;
        }
        public int Compare(Encoding x, Encoding y)
        {
            int first = TimetableAlgorythm.Run(x.ToPermutation(conveyor), conveyor);
            int second = TimetableAlgorythm.Run(y.ToPermutation(conveyor), conveyor);
            return (first - second) * -1;
        }
    }
}
