using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{
    public class Permutation<T>
    {
        public List<T> Values { get; private set; }
        public Permutation() 
        {
            Values = new List<T>();
        }
        public void Swap(int first, int second) 
        {
            if (first < 0 || first >= Values.Count ||
                second < 0 || second >= Values.Count) return;
            (Values[second], Values[first]) = (Values[first], Values[second]);
        }
        public void Sort() => Values.Sort();
        public void Sort(IComparer<T> comparer) => Values.Sort(comparer);
        public Permutation<T> Copy() 
        {
            Permutation<T> permutation = new Permutation<T>();
            foreach (var item in Values) permutation.Values.Add(item);
            return permutation;
        }
        public override string ToString()
        {
            string str = $"Перестановка: ";
            for (int i = 0; i < Values.Count; i++) str += $"{Values[i]}, ";

            return str.Remove(str.Length - 2);
        }
    }


    
}
