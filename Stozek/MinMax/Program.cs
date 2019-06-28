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
            int rozmiar;
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

            int[] min = new int[rozmiar];
            int[] max = new int[rozmiar];       

            for(int i=0;i<rozmiar;i++)
            {
                min[i] = tab[0,i];
            }

            for (int i = 0; i < rozmiar; i++)
            {
                for (int j = 0; j < rozmiar; j++)
                {
                  

                    if (tab[i, j] > max[j])
                    {
                        max[j] = tab[i, j];
                    }

                    if(tab[i,j]< min[j])
                    {
                        min[j] = tab[i, j];
                    }
                   
                }
            }
            Console.WriteLine();

            for(int i=0;i<rozmiar;i++)
            {
                Console.Write(max[i]+" ");
            }
            Console.WriteLine();

            for (int i = 0; i < rozmiar; i++)
            {
                Console.Write(min[i] + " ");
            }


            Console.ReadLine();

        }
    }
}
