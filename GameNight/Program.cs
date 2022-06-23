using System;


namespace GameNight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Game Night";


            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(MainMenu.Logo);
                Console.WriteLine("\n\n");
                Console.WriteLine("\tWelcome and Select a Game!\n");
                Console.WriteLine("\tDice Game: Choose 'high' or 'low'; Beat your highscore! Play Solo\n");
                Console.WriteLine("\t\tOR\n");
                Console.WriteLine("\tTrivia Game: Pick from many categories! Play with Friends\n");
                Console.WriteLine("\t\tChoose one!");
                Console.ResetColor();

                string userResponse = Console.ReadLine().Trim().ToLower(); ;
                if (userResponse == "dice game")
                {
                    var DiceGame = new DiceGame();
                    DiceGame.Start();
                }
                else if (userResponse == "trivia game")
                {
                    var triviaGame = new TriviaGame();
                    triviaGame.Start();
                }
                else
                {
                    Console.WriteLine("I didn't quite get that!");
                }
            } while (true);
        }





        public readonly string Logo = @"
                  ________                            _______   .__          .__       __   
                 /  _____/ _____     _____    ____    \      \  |__|   ____  |  |__  _/  |_ 
                /   \  ___ \__  \   /     \ _/ __ \   /   |   \ |  |  / ___\ |  |  \ \   __\
                \    \_\  \ / __ \_|  Y Y  \\  ___/  /    |    \|  | / /_/  >|   Y  \ |  |  
                 \______  /(____  /|__|_|  / \___  > \____|__  /|__| \___  / |___|  / |__|  
                        \/      \/       \/      \/          \/     /_____/       \/        ";
    }
}
