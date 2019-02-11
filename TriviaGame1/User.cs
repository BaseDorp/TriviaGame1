using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame1
{
    class User
    {
        string Username;
        static public int AnsCorrect = 0;
        public static string[] Answers = { "", "", "", "" };

        public User()
        {
            Console.WriteLine("What is your name?");
            Username = Console.ReadLine();
        }

        public static void AddScore()
        {
            AnsCorrect++;
        }
    }
}
