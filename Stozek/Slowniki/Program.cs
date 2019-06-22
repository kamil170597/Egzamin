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

        }
    }
}
