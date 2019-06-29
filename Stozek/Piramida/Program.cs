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
            double ObjetosFigury = Objetosc(dlugosc, WysokoscFigury(dlugosc, krawedz));

            Console.WriteLine($"Objesosc wynosi: {ObjetosFigury}");
            Console.ReadLine();


        }

        static double WysokoscFigury(double a,double b)
        {
            double wynik;
            double przekatna = (a*Math.Sqrt(2)) / 2;
            //double tmp = ((Math.Pow(przekatna, 2)) - (Math.Pow(b, 2))) * (-1);
            double tmp= (Math.Pow(b, 2))-(Math.Pow(przekatna, 2));
            wynik = Math.Sqrt(tmp);

            return wynik;
        }

        static double Objetosc(double a,double h)
        {
            double wynik;
            wynik = (Math.Pow(a, 2) * h);

            return wynik;
        }

    }
}
