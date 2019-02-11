using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame1
{
    class Quiz
    {
        public static List<string> Qs1 = new List<string>()
        {
            ("How many horns does a Triceritops have?"),
            ("What is the name of the biggest T-rex found?"),
            ("A ____ killed the dinosaurs."),
            ("The dinosaurs died __ million years ago")
        };

        public static List<string> Qs2 = new List<string>()
        {
            ("How many abilities does each character have? (Not including passive)"),
            ("What does ADC stand for?"),
            ("You have to destroy the other team's _____ to beat the game."),
            ("What role is not tied to a lane?")
        };

        public static List<string> Qs3 = new List<string>()
        {
            ("A true or false value."),
            ("The front door of a program"),
            ("An array or characters."),
            ("Cats or Dogs?"),
        };

        public static List<string> Ans1 = new List<string>()
        {
            ("3"),
            ("sue"),
            ("meteor"),
            ("65"),
        };

        public static List<string> Ans2 = new List<string>()
        {
            ("4"),
            ("attack damage carry"),
            ("nexus"),
            ("jungle"),
        };

        public static List<string> Ans3 = new List<string>()
        {
            ("bool"),
            ("main"),
            ("string"),
            ("dogs"),
        };
    }
}
