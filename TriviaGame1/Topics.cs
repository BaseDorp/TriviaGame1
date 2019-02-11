using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame1
{
    class Topics : Quiz
    {
        // What topic did the player choose
        int Topic;
        string answer;
        string[] Repeat = { "", "", "", "" };

        public Topics()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("What topic would you like to do trivia on?\n1. Dinosaurs\n2. League of Legends\n3. Programming");
            Topic = Convert.ToInt32(Console.ReadLine());
            while (Topic < 1 || Topic > 3)
            {
                Console.WriteLine("This is not a valid answer. Please try again:");
                Topic = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();

            switch (Topic)
            {
                case 1:
                    Topic = 1;
                    Quiz(Qs1, Ans1);
                    break;
                case 2:
                    Topic = 2;
                    Quiz(Qs2, Ans2);
                    break;
                case 3:
                    Topic = 3;
                    Quiz(Qs3, Ans3);
                    break;
            }
            Console.ResetColor();
            Console.Clear();

            Console.WriteLine("Congratulations! You got " + User.AnsCorrect + " out of " + User.Answers.Length);
            switch (Topic)
            {
                case 1:
                    PrintQs(Qs1, Ans1);
                    break;
                case 2:
                    PrintQs(Qs2, Ans2);
                    break;
                case 3:
                    PrintQs(Qs3, Ans3);
                    break;
            }
            Console.WriteLine("Your answers:");
            int n = 1;
            for (int i = 0; i < User.Answers.Length; i++)
            {
                Console.WriteLine(n + ". " + User.Answers[i]);
            }
        }

        void Quiz(List<string> _q, List<string> _a)
        {
            Random random = new Random();
            for (int i = 0; i < _q.Count; i++)
            {
                // Questions that have already been used are marked as q
                int n;
                do
                {
                    n = random.Next(_q.Count);
                } while (Repeat[n] == "Q");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(_q[n]);
                Repeat[n] = "Q";
                Console.ForegroundColor = ConsoleColor.White;
                //Inputs
                answer = Console.ReadLine();
                answer = answer.ToLower();
                User.Answers[n] = answer;
                if (answer == _a[n])
                {
                    User.AddScore();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(answer);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(_a[n]);
                }
            }
        }

        void PrintQs(List<string> _q, List<string> _a)
        {
            for (int i = 0; i < _q.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(_q[i]);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(_a[i]);
            }
            Console.ResetColor();
        }
    }
}
