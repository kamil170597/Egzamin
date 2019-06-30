using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdwroconeN
{
    class Program
    {
        static void N_Lustrzane(int n)
        {
            {
                for (int i = 0; i < n; i++)
                {
                    if (i == 0)
                    {
                        Console.Write("*");
                    }
                    else if (i == n - 1)
                    {
                        Console.WriteLine("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                for (int b = 0; b < n - 1; b++)
                {
                    for (int j = 0; j < n; j++)
                    {

                        if (j == 0)
                        {
                            Console.Write("*");
                        }
                        else if (j == n - 2 - b)
                        {
                            Console.Write("*");
                        }
                        else if (j == n - 1)
                        {
                            Console.WriteLine("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
            }
        }
        static void Main()
        {
            Console.WriteLine("Wprowadz parametr: ");
            int parametr = Convert.ToInt32(Console.ReadLine());

            N_Lustrzane(parametr);
            Console.ReadLine();
        }
    }
}
