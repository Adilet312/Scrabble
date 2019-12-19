using System;

namespace Score.Models
{
    public class Score
    {
        public string Word { get; set; } 
        public Score(string word) 
        {
            Word = word;
        } 

        public int CalculateScore()
        {   
            int totalPoints = 0;
            Word = Word.ToUpper();
            for (int i = 0; i < Word.Length; i++)
            {
               if (Word[i] == 'A' || Word[i] == 'E' || Word[i] == 'I' || Word[i] == 'O' || Word[i] == 'U' || Word[i] == 'L' || Word[i] == 'N' || Word[i] == 'R' || Word[i] == 'S' || Word[i] == 'T')
               {
                   totalPoints++;
               }
               else if (Word[i] == 'D' || Word[i] == 'G')
               {
                   totalPoints += 2;
               }
               else if (Word[i] == 'B' || Word[i] == 'C' || Word[i] == 'M' || Word[i] == 'P')
               {
                   totalPoints += 3;
               }
               else if (Word[i] == 'F' || Word[i] == 'H' || Word[i] == 'V' || Word[i] == 'W' || Word[i] == 'Y')
               {
                   totalPoints += 4;
               }
               else if (Word[i] == 'K')
               {
                   totalPoints += 5;
               }
               else if (Word[i] == 'J' || Word[i] == 'X')
               {
                   totalPoints += 8;
               }
               else if (Word[i] == 'Q' || Word[i] == 'Z')
               {
                   totalPoints += 10;
               }
            }
            return totalPoints; 
        }

        public string PrintWordAndPoints()
        {
            string result = $"The Word: {Word}, Points: {CalculateScore()}";
            return result;
        }

    }
}

