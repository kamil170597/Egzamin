using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObwodRombu
{
    class Program
    {
        static void Main(string[] args)
        {
            double PierwszaPrzekatna;
            double DrugaPrzekatna;
            Console.WriteLine("Podaj Pierwsza przekatna:");
            PierwszaPrzekatna=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj Druga Przekatna:");
            DrugaPrzekatna = Convert.ToDouble(Console.ReadLine());
            if(PierwszaPrzekatna<=0 || DrugaPrzekatna<=0)
            {
                Console.WriteLine("Podane dlugosci nie moga być ujemne !!!");
            }else
            {
                Console.WriteLine($"Obwód Rombu wynosi:{Obwodrombu(PierwszaPrzekatna, DrugaPrzekatna)}");
                Console.ReadLine();
            }


            
        }

        public static double Obwodrombu(double przekatna1, double przekatna2)
        {
            double wynik;
            double bok= Math.Pow(przekatna1 / 2, 2) + Math.Pow(przekatna2 / 2, 2);
            double BokFinalnie = Math.Sqrt(bok);

            wynik = 4 * BokFinalnie;



            return wynik;
        }
    }
}
