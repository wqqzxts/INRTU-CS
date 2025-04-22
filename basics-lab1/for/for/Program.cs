using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
Дана последовательность натуральных чисел, в котором все цифры различны.
Определить, какая цифра расположена в ней левее: максимальная или минимальная.
*/
namespace @for {
    public class userInterface
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Sequence of natural numbers withous spaces: ");
            bool f = false;
            string Sequence;
            int k = 0;
            do {
                Sequence = Console.ReadLine();
                if (Logic.inputValidation(Sequence)) {
                    f = true;
                } else { Console.WriteLine("Input error"); }
                if (k != 0) {
                    Sequence = "";
                }
                k++;
            } while (!f);
            string Output = Logic.definePosition(Sequence);
            Console.WriteLine(Output);
            Console.Read();
        }
    }

    public class Logic
    {
        public static string definePosition(string Sequence)
        {
            int minDigit = 9;
            int maxDigit = 0;
            int minPosition = 0;
            int maxPosition = 0;

            for (int i = 0; i < Sequence.Length; i++)
            {
                int currentDigit = Sequence[i] - '0';
                if (currentDigit > maxDigit)
                {
                    maxDigit = currentDigit;
                    maxPosition = i;
                }
                else if (currentDigit < minDigit)
                {
                    minDigit = currentDigit;
                    minPosition = i;
                }
            }

            if (maxPosition < minPosition)
            {
                return "The maximum digit is to the left of the minimum digit";

            }
            else
            {
                return "The maximum digit is to the right of the minimum digit";
            }
        }

        public static bool inputValidation(string Sequence)
        {
            HashSet<char> Digits = new HashSet<char>();
            foreach (char c in Sequence)
            {
                if (!(char.IsDigit(c) && Digits.Add(c)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
