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
            int IndexMax = 0, IndexMin = 0, MaxSuma = 0;
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
            int Min = arr[0, 0];
            for (int i = 0; i < rozmiar; i++)
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    if(arr[i,j]>Max)
                    {
                        Max = arr[i, j];
                        IndexMax = i;
                    }
                    if(arr[i,j]<Min)
                    {
                        Min = arr[i, j];
                        IndexMin = i;
                    }
                    
                }
            }

            int[] TabSuma = new int[rozmiar];
            for (int i = 0; i < rozmiar; i++)
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    TabSuma[i] += arr[i, j];

                }
            }

            
                for(int j=0;j<rozmiar;j++)
                {
                    Console.Write(TabSuma[j]+" ");
                    if(TabSuma[j]>MaxSuma)
                    {
                        MaxSuma = TabSuma[j];
                    }

                }
                Console.WriteLine();
            


            Console.WriteLine($"Max Wynosi: {Max}\nIndexMax={IndexMax}");
            Console.WriteLine($"Max Suma w wierszu wynosi: {MaxSuma}");
            Console.ReadLine();

        }
    }
}
