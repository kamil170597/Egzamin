using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            int rozmiar;
            Console.Write("Podaj rozmiar tablicy:");
            rozmiar = Convert.ToInt32(Console.ReadLine());
            Random zmienna = new Random();

            int[,] tab = new int[rozmiar,rozmiar]; 

            for(int i=0;i<rozmiar;i++)
            {
                for(int j=0;j<rozmiar;j++)
                {
                    tab[i,j]= zmienna.Next(1, 100);
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

            int[] suma = new int[rozmiar];
            int srednia = 0;

            for (int i = 0; i < rozmiar; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < rozmiar; j++)
                {
                    suma[j] = suma[j] + tab[i, j];               
                }

            }

              Console.WriteLine("\n");
                for (int j = 0; j < rozmiar; j++)
                {
                    Console.Write($"{suma[j]} ");

                }
            Console.WriteLine("\n");
            for (int j = 0; j < rozmiar; j++)
            {
                suma[j] = suma[j] / rozmiar;
                Console.Write($"{suma[j]} ");

            }

            Console.WriteLine("\n");
            for (int j = 0; j < rozmiar; j++)
            {
                Console.Write($"Średnia: {suma[j]} ");

            }

            Console.WriteLine("\n");
            srednia = suma[0];
            for (int j = 0; j < rozmiar; j++)
            {
                if(suma[j]<srednia)
                {
                    srednia = suma[j];
                }

            }
            Console.WriteLine($"Najmniejsza srednia:{srednia}");
        }
    }
}
