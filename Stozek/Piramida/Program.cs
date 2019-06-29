using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramida
{
    class Program
    {
        static void Main(string[] args)
        {
            double dlugosc, krawedz;

            Console.WriteLine("Podaj długość podstawy: ");
            dlugosc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj długość krawędzi: ");
            krawedz = Convert.ToDouble(Console.ReadLine());
            if (dlugosc >= 0 || krawedz >= 0)
            {
                if (WysokoscFigury(dlugosc,krawedz) > 0)
                {
                    double ObjetosFigury = Objetosc(dlugosc, WysokoscFigury(dlugosc, krawedz));

                    Console.WriteLine($"Objesosc wynosi: {ObjetosFigury}");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Nie spełniono warunku na powstanie trojakata!!!");
                }

            }
            else
            {
                Console.WriteLine("Podane wartosci nie mogą być ujemne !!!");
            }

        }

        static double WysokoscFigury(double a,double b)
        {
            double wynik;
            double przekatna = (a*Math.Sqrt(2)) / 2;
            double tmp = ((Math.Pow(przekatna, 2)) - (Math.Pow(b, 2))) * (-1); 
            if (tmp + Math.Pow(przekatna, 2) == Math.Pow(b, 2))
            {
                wynik = Math.Sqrt(tmp);
                return wynik;
            }
            else
            {
                return -1;
            }
        }

        static double Objetosc(double a,double h)
        {
            double wynik;
            wynik = (Math.Pow(a, 2) * h);

            return wynik;
        }

    }
}
