using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabJednoMinMax
{
    class Program
    {
        static void Main(string[] args)
        {

            int rozmiar, min, max, IndexMin, IndexMax, suma = 0,srednia=0 ;
            Console.Write("Podaj rozmiar tablicy:");
            rozmiar = Convert.ToInt32(Console.ReadLine());
            Random zmienna = new Random();

            int[] tab = new int[rozmiar];

            for (int i = 0; i < rozmiar; i++)
            {
                
                
                    tab[i] = zmienna.Next(1, 100);
                
            }

            for (int i = 0; i < rozmiar; i++)
            {
                Console.WriteLine("\n");
                
                    Console.Write($"{tab[i]} ");

                

            }

            min = tab[0];
            max = tab[0];
            IndexMax = 0;
            IndexMin = 0;

            for(int i=0;i<rozmiar;i++)
            {
                if(tab[i]<min)
                {
                    min = tab[i];
                    IndexMin = i;
                }
                if(tab[i]>max)
                {
                    max = tab[i];
                    IndexMax = i;
                }
            }
            Console.WriteLine();
         
                Console.WriteLine($"Max: {max}Index: {IndexMax}");
                Console.WriteLine($"Min: {min}Index: {IndexMin}");

            Console.WriteLine();

            for(int i=0;i<rozmiar;i++)
            {
                suma += tab[i];
            }

            srednia = suma / rozmiar;

            Console.WriteLine($"Suma elementów tablicy wynosi:{suma}");
            Console.WriteLine($"Średnia elemmentów tablicy wynosi:{srednia}");

            Console.ReadLine();


        }
    }
}
