using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNight

{
    public class TriviaGame
    {
        public string Logo = @"
                ___________        .__        .__            ________                          
                \__    ___/_______ |__|___  __|__|_____     /  _____/ _____     _____    ____  
                  |    |   \_  __ \|  |\  \/ /|  |\__  \   /   \  ___ \__  \   /     \ _/ __ \ 
                  |    |    |  | \/|  | \   / |  | / __ \_ \    \_\  \ / __ \_|  Y Y  \\  ___/ 
                  |____|    |__|   |__|  \_/  |__|(____  /  \______  /(____  /|__|_|  / \___  >
                                                       \/          \/      \/       \/      \/ 
                ";
        public TriviaGame()
        {
            Console.Clear();
            Console.WriteLine(Logo);
            Console.WriteLine("It's Trivia Night! Lets see how good you are!");
            Console.WriteLine("Pick a category to Start!\n\n");
            Console.WriteLine("\tCategories");
            Console.WriteLine("General, Sports, Food, Countries, Colors");
            Console.ReadLine();


        }

        public void Start()
        {

        }

        public void Win()
        {

        }
        public void Lose()
        {

        }
    }
}
