using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbior
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(1);
            A.Add(3);
            A.Add(5);
            A.Add(2);
            A.Add(7);
            A.Add(8);

            B.Add(2);
            B.Add(1);
            B.Add(5);
            B.Add(3);
            B.Add(9);
            B.Add(6);

            foreach(int cyfry in A)
            {
                Console.WriteLine(cyfry);
            }
            Console.WriteLine();

            foreach (int cyfry in B)
            {
                Console.WriteLine(cyfry);
            }
            Console.WriteLine();

            HashSet<int> C = new HashSet<int>();

            C.UnionWith(A);
            C.UnionWith(B);

            int[] tab;

            tab = C.ToArray();
            Array.Sort(tab);
            Array.Reverse(tab);
            C.Clear();
            C.UnionWith(tab);
            foreach (int cyfry in C)
            {
                Console.WriteLine(cyfry);
            }
            Console.WriteLine();

            int suma = 0;
            foreach (int cyfry in C)
            {
                suma += cyfry;
            }
            Console.WriteLine();

            int srednia = 0;
            srednia = suma / C.Count;
            Console.WriteLine($"Średnia zbioru C:{srednia}");

            A.IntersectWith(B);

            foreach (int cyfry in A)
            {
                Console.WriteLine(cyfry); 
            }
            Console.WriteLine();

            


        }

    }
}
