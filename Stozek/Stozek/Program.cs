﻿using System;
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
                   
                    if ((Math.Pow(R, 2) + Math.Pow(H, 2)) == Math.Pow(L, 2))
                    {
                        Console.WriteLine($"H= {(Pitagoras(R, L))}");
                        Console.WriteLine($"H= {H}");
                        Console.WriteLine($"V={Objetosc(R, Pitagoras(R, L))}");
                        Console.WriteLine($"V={Math.Floor(Objetosc(R, Pitagoras(R, L)))}");
                        Console.WriteLine($"V={Math.Round(Objetosc(R, Pitagoras(R, L)),1)}");
                    }
                    else
                    {
                        Console.WriteLine("Obiekt nie istnieje");
                    }
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
            objetosc_wynik =((Math.Pow(p, 2)) * 3.14 * h)/3;


            return objetosc_wynik;
        }
    }
}
