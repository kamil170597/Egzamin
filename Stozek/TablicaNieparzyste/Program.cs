using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablicaNieparzyste
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[5, 2] { { 1, 2 }, { -2, -3 }, { 2, -5 }, { -3, 4 }, { -6, 6 } };

            Console.WriteLine("Srednia:"+ srednia(a));
            
            Console.ReadLine();
        }
        static double srednia(int [,] tab)
        {
            int suma = 0;
            double srednia = 0;
            int licznik = 0;
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<2;j++)
                {
                    if(tab[i,j]%2!=0)
                    {
                        suma += tab[i, j];
                        licznik++;
                    }
                }
            }



            return srednia = suma / licznik;

        }
    }
}
