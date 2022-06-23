using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNight
{
    public class DiceGame
    {
        public readonly string Logo = @"
    
            ________   .__                    ________                          
            \______ \  |__|  ____    ____    /  _____/ _____     _____    ____  
             |   \|  \ |  |_/ ___\ _/ __ \  /   \  ___ \__  \   /     \ _/ __ \ 
             |    `   \|  |\  \___ \  ___/  \    \_\  \ / __ \_|  Y Y  \\  ___/ 
            /_______  /|__| \___  > \___  >  \______  /(____  /|__|_|  / \___  >
                    \/          \/      \/          \/      \/       \/      \/ 
            ";
        public string Roll1 = @"
    +---------+
    |         |
    |    o    |
    |         |
    +---------+";
        public string Roll2 = @"
    +---------+
    | o       |
    |         |
    |       o |
    +---------+";
        public string Roll3 = @"
    +---------+
    | o       |
    |    o    |
    |       o |
    +---------+";
        public string Roll4 = @"
    +---------+
    | o     o |
    |         |
    | o     o |
    +---------+";
        public string Roll5 = @"
    +---------+
    | o     o |
    |    o    |
    | o     o |
    +---------+";
        public string Roll6 = @"
    +---------+
    | o     o |
    | o     o |
    | o     o |
    +---------+";
        private int Score;
        private int HighScore;
        private Random RandomGenerator;

        public DiceGame()
        {

            Score = 0;
            HighScore = 0;
            RandomGenerator = new Random();


        }

        public void Start()
        {

            bool cont = false;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(Logo);
                Console.ResetColor();
                Console.WriteLine("Welcome to Dice Game!");
                Console.WriteLine("I'm going to roll one time every round.");
                Console.WriteLine("Guess 'High' or 'Low'correctly to gain points!");

                Console.WriteLine("Are you ready to play? Yes or No?");

                var userAnswer = Console.ReadLine()!.Trim().ToLower();
                if (userAnswer == "yes")
                {
                    Console.WriteLine("Great let's get started!");
                    PlayRound();
                    cont = true;

                }
                else if (userAnswer == "no")
                {
                    Console.WriteLine("Okay thanks for stopping by!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("I didnt quite get that!");
                    Console.Clear();
                }
            } while (!cont);
        }

        private void PlayRound()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(Logo);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"I'm about to roll... ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"
                +---------+
                | ?     ? |
                | ?  ?  ? |
                | ?     ? |
                +---------+                             ");
            Console.ResetColor();

            Console.WriteLine("Is it going to be 'high' [4, 5, 6] or 'low' [1, 2, 3] ?");
            int randomNumber = RandomGenerator.Next(1, 7);
            string answer;
            int rollNumber = randomNumber;
            if (randomNumber <= 3)
            {
                answer = "low";
            }
            else answer = "high";

            var cont = false;
            string userAnswer = "";
            do
            {
                var tempAnswer = Console.ReadLine()!.Trim().ToLower();
                if (tempAnswer == "high" || tempAnswer == "low")
                {
                    cont = true;
                    userAnswer = tempAnswer;
                }
                else
                {
                    Console.WriteLine("Type: High or Low");
                }
            } while (!cont);

            GetRollNumberPrint(rollNumber);
            

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"It was {answer.ToUpper()}");
            Console.WriteLine($"Your response was {userAnswer}");
            Console.ResetColor();

            


                if (userAnswer == answer)
                {
                    Win();


                }
                else if (userAnswer != answer)
                {
                    Lost();
                }
                else
                {
                    Console.WriteLine("Type: Yes or No ");
                }
            


            Console.ReadLine();



        }

        private void Win()
        {

            Score++;
            if (Score > HighScore)
            {
                HighScore = Score;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Congrats you got it right!");
            Console.WriteLine($"Score: {Score}| Highscore: {HighScore} ");
            Console.WriteLine("Well Done! Press any key to continue");
            Console.ReadKey();
            Console.ResetColor();
            PlayRound();
        }

        private void Lost()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Score--;
            Console.WriteLine("I'm sorry wrong answer..try again!");
            Console.WriteLine($"Your score is: {Score} ");
            Console.WriteLine("Try and get a better score!");
            Console.ReadLine();
            Console.ResetColor();

            AskToPlayAgain();
        }

        private void AskToPlayAgain()
        {
            Console.WriteLine("Would you like to play another round? Yes or No?");
            var userAnswer = Console.ReadLine()!.Trim().ToLower();
            if (userAnswer == "yes")
            {
                PlayRound();
            }
            else if (userAnswer == "no")
            {
                Console.WriteLine("Thanks for stopping by!");
                Console.WriteLine($"You ended with a score of {Score}");
                Console.ReadKey();
            }
            else
            {
                AskToPlayAgain();
            }


        }
        private void GetRollNumberPrint(int rollNumber)
        {
            switch (rollNumber)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(Roll1); Console.ResetColor();
                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine(Roll2); Console.ResetColor();
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(Roll3); Console.ResetColor();
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine(Roll4); Console.ResetColor();
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(Roll5); Console.ResetColor();
                    break;

                case 6:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine(Roll6); Console.ResetColor();
                    break;

                default: Console.WriteLine("Generator broke"); break;
            }


        }
    }
}
