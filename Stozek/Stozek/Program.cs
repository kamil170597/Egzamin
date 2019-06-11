using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stozek
{
    class Program
    {
        double Pi = 3.14;
        static void Main(string[] args)
        {
            Double R, L;
            
            double H;
            Console.WriteLine("Podaj R: ");
            R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj L: ");
            L = Convert.ToDouble(Console.ReadLine());

            if(R<=1000000 && R>=-1000000 && L<=1000000 && L>=-1000000)
            {
                if (R < 0 || L < 0)
                {
                    Console.WriteLine("Ujemny argument");
                }
                else
                {
                    H = Pitagoras(R, L);
                    Console.WriteLine($"H= {(Pitagoras(R, L))}");
                    Console.WriteLine($"H= {H}");
                    Console.WriteLine($"V={Objetosc(R, Pitagoras(R, L))}");
                }
            }
            else
            {
                Console.WriteLine("Liczby poza zakresem ");
            }


        }
        static public double Pitagoras(double a, double b)
        {
            double wynik;
            double tmp = ((Math.Pow(a,2))-(Math.Pow(b,2)))*(-1);
            wynik= Math.Sqrt(tmp);

            return wynik;
        }
        static public double Objetosc(double p,double h)
        {
            double objetosc_wynik;
            objetosc_wynik = 1 / 3 * ((Math.Pow(p, 2)) * 3.14 * h);


            return objetosc_wynik;
        }
    }
}
