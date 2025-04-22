using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
В тексте удалить каждое слово с четным числом символов, продублировать каждое слово с нечетным числом символов,
заменив все вхождения букв ‘d’ на букву ‘t’
*/
namespace @string {
    public static class userInterface {
        public static void Main(string[] args) {
            Console.WriteLine("Enter text");
            string userInput = Console.ReadLine();
            string Result = Logic.processText(userInput);
            Console.WriteLine($"Processed text: {Result}");
            Console.ReadLine();
        }                
    }

    public static class Logic { 
        public static string processText (string Input) {
            string[] Words = Input.Split(new char[] {' ', '.', ',', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder SB = new StringBuilder();
            foreach (string Word in Words) {
                if (Word.Length % 2 != 0) {
                    string doubledWord = Word + " " + Word;
                    string modifiedWord = doubledWord.Replace('d', 't');
                    SB.Append(modifiedWord + " ");
                }   
            }
            return SB.ToString();
        }
    }
}