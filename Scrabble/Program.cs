using System;

namespace Score.Models
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a word.");
            string userInput = Console.ReadLine();

            Score usersWord = new Score(userInput);
            Console.WriteLine(usersWord.PrintWordAndPoints());

            
            
        }
    }
    
}