using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_Simon_Says;

namespace SimonSaysUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Simon simon = new Simon();
            string input = Console.ReadLine();
            Console.WriteLine(simon.Echo(input));
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(simon.Shout(input));
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
