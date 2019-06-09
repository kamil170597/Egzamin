using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stozek
{
    class Program
    {

        static void Main(string[] args)
        {
            Double R, L;
            double Pi = 3.14;
            double H;
            Console.WriteLine("Podaj R: ");
            R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj L: ");
            L = Convert.ToDouble(Console.ReadLine());

            if(R<=1000000 && R>=-1000000 && L<=1000000 && L>=-1000000)
            {
                if(R<0 || L<0)
                {
                    Console.WriteLine("Ujemny argument");
                }
                else
                {
                    H = pitagoras(R, L);
                    Console.WriteLine($"H= {Convert.ToDouble(pitagoras(R,L))}");
                }
            }
            else
            {
                Console.WriteLine("Liczby poza zakresem ");
            }


        }
        static public double pitagoras(double a, double b)
        {
            double wynik;
            double tmp = (Math.Pow(a,2)-Math.Pow(b,2));
            wynik= Math.Sqrt(tmp);

            return wynik;
        }
    }
}
