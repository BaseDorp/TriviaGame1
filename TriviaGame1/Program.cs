using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Made by Sam Hirsch 2/11/2019

namespace TriviaGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Triva Game 1 by Sam Hirsch";

            User User = new User();
            Topics Topics = new Topics();

            Console.ResetColor();
            Console.WriteLine("\n\nPress any key to continue ...");
            Console.ReadKey();
        }
    }
}
