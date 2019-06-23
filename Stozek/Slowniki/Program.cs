using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slowniki
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> Zwierzeta =new Dictionary<string, string>();

            Zwierzeta.Add("Kot","4");
            Zwierzeta.Add("Korwa", "4");
            Zwierzeta.Add("Pies", "4");
            Zwierzeta.Add("Wąż", "0");
            Zwierzeta.Add("Mysz", "4");

            foreach(KeyValuePair<string,string> zwierze in Zwierzeta)
            {
                Console.WriteLine($"{zwierze.Key}:{zwierze.Value}");
            }
            Console.WriteLine();

            string test;
            Console.WriteLine(Zwierzeta.ContainsKey("Pies"));
            if(Zwierzeta.TryGetValue("Pies",out test))
            {
                Console.WriteLine(test);
            }

            Console.WriteLine(Zwierzeta.ContainsKey("6"));
            Zwierzeta.Add("Pająk", "6");
            foreach (KeyValuePair<string, string> zwierze in Zwierzeta)
            {
                Console.WriteLine($"{zwierze.Key}:{zwierze.Value}");
            }
            Console.WriteLine();

            foreach (KeyValuePair<string, string> zwierze in Zwierzeta)
            {
                Console.WriteLine($"{zwierze.Key}");
            }
            Console.WriteLine();

            foreach (KeyValuePair<string, string> zwierze in Zwierzeta)
            {
                Console.WriteLine($"{zwierze.Value}");
            }
            Console.WriteLine();

            foreach (KeyValuePair<string, string> zwierze in Zwierzeta)
            {
                if(zwierze.Value=="4")
                Console.WriteLine($"{zwierze.Key}:{zwierze.Value}");
            }
            Console.WriteLine();
            int suma = 0;
            foreach (KeyValuePair<string, string> zwierze in Zwierzeta)
            {
                suma = suma + Convert.ToInt32(zwierze.Value);
            }
            Console.WriteLine();
            Console.WriteLine($"Suma nóg:{suma}");
            Zwierzeta.Remove("Pająk");

            foreach (KeyValuePair<string, string> zwierze in Zwierzeta)
            {
               
                    Console.WriteLine($"{zwierze.Key}:{zwierze.Value}");
            }




        }
    }
}
