using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraniaTrojkatny
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double podstawa,H;

            Console.Write("Podaj długość ściany podstawy: ");
            podstawa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wysokość graniastosłupa: ");
            H = Convert.ToDouble(Console.ReadLine());
            if (podstawa > 0 && H > 0 )
            {
                double PC = PoleBoczne(podstawa, H) + PolePodsawy(podstawa);
                if(PoleBoczne(podstawa,H)>0)
                {
                    Console.WriteLine($"Pole podstawy wynosi:{Math.Round(PolePodsawy(podstawa))}");
                    Console.WriteLine($"Pole boczne figury wynosi: {Math.Round(PoleBoczne(podstawa, H))}");
                    Console.WriteLine($"Pole całkowite wynosi:{Math.Round(PC)}");
                    Console.WriteLine($"Objetosc wynosi:{Math.Round(Objetosc(PolePodsawy(podstawa),H))}");
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Nie został spełniony warunek na powstanie trójkąta !!!");
                }
            }
            else
            {
                Console.WriteLine("Podane wartosci nie moga być ujemne !!!");
            }
        }

        static double PolePodsawy(double a)
        {
            double Podstawa;

            Podstawa = (Math.Pow(a, 2) * Math.Sqrt(3)) / 4;


            return Podstawa;
        }
        static double PoleBoczne(double a, double h)
        {
            double b = a / 3;
            double tmp = Math.Pow(b, 2) + Math.Pow(h, 2);
            double WysokoscSciany = Math.Sqrt(tmp);
            double PoleBoczneWynik;
            if (Math.Pow(WysokoscSciany,2)==tmp)
            {
                double PoleScianyBocznej = (a * WysokoscSciany) / 2;
                
                return PoleBoczneWynik= PoleScianyBocznej * 3;
            }
            else
            {
                return -1;
            }

            
        }

        static double Objetosc(double PP, double H)
        {
            double V;
            return V= (PP * H)/3; 
        }
    }
}
