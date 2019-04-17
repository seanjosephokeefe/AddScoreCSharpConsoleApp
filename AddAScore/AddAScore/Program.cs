using System;
using System.Collections.Generic;

namespace AddAScore
{
    class Program
    {

        public static List<ScoreClass> scores = new List<ScoreClass>();

        static void Main(string[] args)
        {
            String input;
            do{
                Console.Clear();
                Console.WriteLine("Scores Adding Application\n");
                Console.WriteLine("A to Add");
                Console.WriteLine("V to View All");
                Console.WriteLine("Q to Quit\n");
                Console.Write("Enter your selection: ");
                input = Console.ReadLine();
                switch (input.ToUpper())
                {
                    case "A":
                        AddScore();
                        break;
                    case "V":
                        DisplayScores();
                        break;
                }
            }while(input.ToUpper()!="Q");
        }

        static void DisplayScores()
        {
            Console.Clear();
            Console.WriteLine("List of Scores\n");
            if (scores.Count==0)
                Console.WriteLine("\nThere are currently no score records entered.");
            else
            {
                Console.Write("\nDate".PadRight(30, ' '));
                Console.Write("Sport".PadRight(31, ' '));
                Console.Write("Team".PadRight(30,' '));
                Console.WriteLine("Score".PadRight(30, ' '));
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
                for (int i = 0; i < scores.Count; i++)
                {
                    Console.Write(scores[i].Date.PadRight(30, ' '));
                    Console.Write(scores[i].Sport.PadRight(30, ' '));
                    Console.Write(scores[i].Team.PadRight(30, ' '));                    
                    Console.WriteLine(scores[i].Score.ToString().PadRight(30, ' '));
                }
            }
            Console.Write("\n\nPress any key to continue...");
            Console.ReadKey();
        }

        static void AddScore()
        {
            Console.WriteLine();
            scores.Add(new ScoreClass(GetInputString("the date of the event"), GetInputString("the type of sport"), GetInputString("the team name"), GetInputNumber("the score")));
            Console.Write("\n\nPress any key to continue...");
            Console.ReadKey();
        }

        static String GetInputString(String prompt)
        {
            String input;
            Boolean valid;
            do
            {
                valid = true;
                Console.Write("Enter {0}: ", prompt);
                input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    valid = false;
                    Console.WriteLine("\nYour input can't be empty. Please try again.\n");
                }
            } while (!valid);
            return (input);
        }

        static Int16 GetInputNumber(String prompt)
        {
            Int16 number;
            Boolean valid;
            do
            {
                valid = true;
                String input = GetInputString(prompt); 
                if (!Int16.TryParse(input,out number))
                {
                    valid = false;
                    Console.WriteLine("\nYour score must be a number. Please try again.\n");
                }
                else
                {
                    if (number < 0)
                    {
                        valid = false;
                        Console.WriteLine("\nYour score must be zero or greater. Please try again.\n");
                    }
                }                
            } while (!valid);
            return (number);
        }

    }
}
