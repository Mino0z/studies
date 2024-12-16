using System;

namespace LedNumbers
{
    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int[] numbers = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i].ToString());
            }
            string firstRow = "";
            string secondRow = "";
            string thirdRow = "";
            foreach (int number in numbers)
            {
                if (number == 0)
                {
                    firstRow += " _ ";
                    secondRow += "| |";
                    thirdRow += "|_|";
                }
                else if (number == 1)
                {
                    firstRow += "   ";
                    secondRow += "  |";
                    thirdRow += "  |";
                }
                else if (number == 2)
                {
                    firstRow += " _ ";
                    secondRow += " _|";
                    thirdRow += "|_ ";
                }
                else if (number == 3)
                {
                    firstRow += " _ ";
                    secondRow += " _|";
                    thirdRow += " _|";
                }
                else if (number == 4)
                {
                    firstRow += "   ";
                    secondRow += "|_|";
                    thirdRow += "  |";
                }
                else if (number == 5)
                {
                    firstRow += " _ ";
                    secondRow += "|_ ";
                    thirdRow += " _|";
                }
                else if (number == 6)
                {
                    firstRow += " _ ";
                    secondRow += "|_ ";
                    thirdRow += "|_|";
                }
                else if (number == 7)
                {
                    firstRow += " _ ";
                    secondRow += "  |";
                    thirdRow += "  |";
                }
                else if (number == 8)
                {
                    firstRow += " _ ";
                    secondRow += "|_|";
                    thirdRow += "|_|";
                }
                else if (number == 9)
                {
                    firstRow += " _ ";
                    secondRow += "|_|";
                    thirdRow += "  |";
                }
            }
            Console.WriteLine(firstRow);
            Console.WriteLine(secondRow);
            Console.WriteLine(thirdRow);
        }
    }
}
