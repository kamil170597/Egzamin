using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabMaxWiersz
{
    class Program
    {
        static void Main(string[] args)
        {


            int a;
            Console.WriteLine("Podaj rozmair tablicy: ");
            a= Convert.ToInt32(Console.ReadLine());
            int[,] tablica = new int[a, a];

            Wypisanie(tablica,a);
            



        }

        static void Wypisanie(int [,] arr,int rozmiar)
        {
            int IndexMax=0;
            Random zmienna = new Random();

            for (int i = 0; i < rozmiar; i++)
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    arr[i,j] = zmienna.Next(1, 100);
                }
            }

            for (int i = 0; i < rozmiar; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < rozmiar; j++)
                {
                    Console.Write($"{arr[i, j]} ");

                }

            }
            Console.WriteLine("");
            Console.ReadLine();

            int Max = arr[0, 0];

            for (int i = 0; i < rozmiar; i++)
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    if(arr[i,j]>Max)
                    {
                        Max = arr[i, j];
                        IndexMax = i;
                    }
                    
                }
            }

            Console.WriteLine($"Max Wynosi: {Max}\nIndexMax={IndexMax}");
            Console.ReadLine();

        }
    }
}
