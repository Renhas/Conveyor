using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ConveyorSystem
{
    public class Job : IComparable<Job>, IComparable
    {
        readonly public int Id;
        readonly public int Directive;
        readonly public int Penalty;
        readonly public int[] Tacts;
        public int[] StartTimes { get; private set; }
        public Job(int id, int[] tacts, int directive, int penalty)
        {
            if (id < 1 || directive < 1 || penalty < 1) throw new ArgumentOutOfRangeException();
            Id = id;
            Directive = directive;
            Penalty = penalty;
            Tacts = new int[tacts.Length];
            tacts.CopyTo(Tacts, 0);
            StartTimes = new int[tacts.Length];
            for (int i = 0; i < StartTimes.Length; i++) StartTimes[i] = 0;
        }
        public int CalculateTotalPenalty() 
        {
            int lastTime = StartTimes[StartTimes.Length - 1] + Tacts[Tacts.Length - 1];
            return Penalty * Math.Max(0, lastTime - Directive);
        }
        public int TotalTime() 
        {
            int sum = 0;
            foreach (var tact in Tacts) sum += tact;
            return sum;
        }
        public int CompareTo(Job other)
        {
            if (other == null) throw new ArgumentNullException();
            return Directive.CompareTo(other.Directive);
        }
        public int CompareTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException();
            if (!(obj is Job)) throw new ArgumentException("Not Job!");

            return CompareTo(obj as Job);
        }
        public static bool operator <(Job first, Job second) => first.Directive < second.Directive;
        public static bool operator >(Job first, Job second) => first.Directive > second.Directive;
        public override string ToString()
        {
            string str = $"{Id}: Директивный срок = {Directive}, времена работы = [";
            foreach (int i in Tacts) str += $"{i}, ";
            str = str.Remove(str.Length - 2) + "]";
            return str + $", штраф {Penalty}";

        }
    }
}
