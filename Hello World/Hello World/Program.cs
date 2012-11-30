using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
                Console.WriteLine("Hello World!");
            else
            {
                foreach (string s in args)
                    Console.WriteLine("Hello {0}", s);
            }
            for (int x = 0; x < 100; x++)
            {
                //yay for pointless loops
            }
            Console.ReadLine();
        }
    }
}
