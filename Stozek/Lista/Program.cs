using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> gatunki = new List<string>();

            Console.WriteLine("Gatunki zwierząt: ",gatunki.Capacity);

            gatunki.Add("Pies");
            gatunki.Add("Kot");
            gatunki.Add("Mysz");
            gatunki.Add("Krowa");
            gatunki.Add("Koń");

            foreach(string gatunek in gatunki)
            {
                Console.WriteLine(gatunek);
            }
            Console.WriteLine();
            gatunki.Remove("Kot");
            gatunki.Remove("Koń");
            foreach (string gatunek in gatunki)
            {
                Console.WriteLine(gatunek);
            }
            Console.WriteLine();
            gatunki.Insert(3, "mucha");
            gatunki.Insert(1, "gazela");
            foreach (string gatunek in gatunki)
            {
                Console.WriteLine(gatunek);
            }
            gatunki.Remove("gazela");
            Console.WriteLine();

            foreach (string gatunek in gatunki)
            {
                Console.WriteLine(gatunek);
            }
            Console.WriteLine(gatunki.IndexOf("mucha"));
            Console.WriteLine();
            gatunki.Reverse();
            foreach (string gatunek in gatunki)
            {
                Console.WriteLine(gatunek);
            }
            Console.WriteLine();
            gatunki.Sort();
            foreach (string gatunek in gatunki)
            {
                Console.WriteLine(gatunek);
            }
            Console.WriteLine();

            //gatunki.Sort(Comparison<string>.);


        }
    }
}
