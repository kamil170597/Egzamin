using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int rozmiar,Min=0,Max=0;
            Random zmienna = new Random();
            Console.WriteLine("Podaj rozmair tablicy: ");
            rozmiar=Convert.ToInt32(Console.ReadLine());
            int[,] tab = new int[rozmiar,rozmiar];

            for (int i = 0; i < rozmiar; i++)
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    tab[i, j] = zmienna.Next(1, 100);
                }
            }

            for (int i = 0; i < rozmiar; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < rozmiar; j++)
                {
                    Console.Write($"{tab[i, j]} ");

                }

            }
            Console.WriteLine("");










        }
    }
}
