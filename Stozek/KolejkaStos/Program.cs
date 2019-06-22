using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolejkaStos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> cyfry = new Stack<string>();
            Queue<string> litery = new Queue<string>();

            cyfry.Push("1");
            cyfry.Push("2");
            cyfry.Push("3");
            cyfry.Push("4");


            litery.Enqueue("a");
            litery.Enqueue("b");
            litery.Enqueue("c");
            litery.Enqueue("d");

            
            foreach(string cyfra in cyfry)
            {
                Console.WriteLine(cyfra);
            }
            Console.WriteLine();
            foreach(string litera in litery)
            {
                Console.WriteLine(litera);
            }
            Console.WriteLine();

            litery.Enqueue(cyfry.Pop());
            litery.Enqueue(cyfry.Pop());

            foreach (string litera in litery)
            {
                Console.WriteLine(litera);
            }
            Console.WriteLine();

            Console.WriteLine(cyfry.Peek());
            Console.WriteLine(litery.Peek());

            cyfry.Pop();
            cyfry.Pop();

            litery.Enqueue("e");

            foreach (string cyfra in cyfry)
            {
                Console.WriteLine(cyfra);
            }
            Console.WriteLine();


            foreach (string litera in litery)
            {
                Console.WriteLine(litera);
            }
            Console.WriteLine();

            litery.Enqueue(cyfry.Pop());

            foreach (string litera in litery)
            {
                Console.WriteLine(litera);
            }
            Console.WriteLine();

        }
    }
}
