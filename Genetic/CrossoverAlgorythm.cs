using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic
{
    internal static class CrossoverAlgorythm
    {

        public static Encoding Run(Encoding first_parent, Encoding second_parent, Random rnd) 
        {
            int first_alpha = rnd.Next(1, first_parent.Lenght - 1);
            int second_alpha = rnd.Next(first_alpha + 1, first_parent.Lenght);
            switch (rnd.Next(3))
            {
                case 0: return OXAlgorythm(first_parent, second_parent, first_alpha, second_alpha);
                case 1: return PMXAlgorythm(first_parent, second_parent, first_alpha, second_alpha);
                case 2: return CXAlgorythm(first_parent, second_parent);
                default: return null;
            }

        }

        private static Encoding OXAlgorythm(Encoding first, Encoding second, int first_alpha, int second_alpha) 
        {
            Encoding child = new Encoding(first.Lenght);
            List<int> encoding_elements = new List<int>();

            for (int i = first_alpha; i < second_alpha; i++) 
            {
                child[i] = first[i];
                encoding_elements.Add(first[i]);
            }
            for (int parent_id = second_alpha, child_id = second_alpha; child_id < first_alpha || child_id >= second_alpha; parent_id++) 
            {
                if (parent_id == second.Lenght) parent_id = 0;
                if (child_id == child.Lenght) child_id = 0;

                if (!encoding_elements.Contains(second[parent_id])) 
                {
                    encoding_elements.Add(second[parent_id]);
                    child[child_id] = second[parent_id];
                    child_id++;
                }

                
                
            }

            return child;
        }

        private static Encoding PMXAlgorythm(Encoding first, Encoding second, int first_alpha, int second_alpha)
        {
            Encoding child = new Encoding(first.Lenght);
            List<int[]> encoding_elements = new List<int[]>();

            for (int i = first_alpha; i < second_alpha; i++)
            {
                child[i] = first[i];
                encoding_elements.Add(new int[] { first[i], second[i] });
            }
            for (int parent_id = 0, child_id = 0; child_id < child.Lenght; parent_id++, child_id++) 
            {
                if (child_id == first_alpha) 
                {
                    child_id = second_alpha;
                    parent_id = second_alpha;
                }
                int id = second[parent_id];
                while (child.GetEncoding().Contains(id)) 
                {
                    foreach (var element in encoding_elements) 
                    {
                        if (element[0] == id) id = element[1];
                    }
                }
                child[child_id] = id;
            }
            return child;
        }

        private static Encoding CXAlgorythm(Encoding first, Encoding second)
        {
            List<int[]> cycles = new List<int[]>();
            List<int> firstList = first.GetEncoding().ToList();
            List<int> visited_elements = new List<int>();

            for (int count = 0; count < first.Lenght; count++) 
            {
                if (visited_elements.Contains(count)) continue;
                visited_elements.Add(count);
                int[] cycle = new int[first.Lenght];
                int first_element = first[count];
                cycle[count] = 1;
                int element = second[count];
                while (element != first_element) 
                {
                    int id = firstList.IndexOf(element);
                    cycle[id] = 1;
                    visited_elements.Add(id);
                    element = second[id];
                }
                cycles.Add(cycle);
            }

            Encoding child = new Encoding(first.Lenght);
            bool mode = true;

            foreach (var cycle in cycles) 
            {
                for (int i = 0; i < cycle.Length; i++) 
                {
                    if (cycle[i] == 0) continue;
                    if (mode) child[i] = first[i];
                    else child[i] = second[i];
                }
                mode = !mode;
            }
            return child;
        }

    }
}
