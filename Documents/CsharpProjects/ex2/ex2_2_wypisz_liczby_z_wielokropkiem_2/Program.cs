using System;
using System.Collections.Generic;

namespace Zadania_petle
{
    class Program
{
    static void Main()
    {
       
        string[] input = Console.ReadLine().Split();

        short a = short.Parse(input[0]);
        short b = short.Parse(input[1]);
        short c = short.Parse(input[2]);

        List<short> divisibleNumbers = new List<short>();

        short start = Math.Min(a, b);
        short end = Math.Max(a, b);
        short firstDivisible;

        if (start % c == 0)
        {
            firstDivisible = (short)(start + 1);
        }
        else if (start < 0)
        {
            firstDivisible = (short)(start + 1);
        }
        else
        {
            firstDivisible = (short)(start + 1 );
        }

       

        
        for (short i = firstDivisible; i <= end -1; i += c)
        {
            divisibleNumbers.Add(i);
        }
        if (end-start <= c)
        {
            Console.WriteLine("empty");
        }
        else if (divisibleNumbers.Count > 10)
        {
            Console.WriteLine($"{divisibleNumbers[0]}, {divisibleNumbers[1]}, {divisibleNumbers[2]}, ..., {divisibleNumbers[divisibleNumbers.Count - 2]}, {divisibleNumbers[divisibleNumbers.Count - 1]}");
        }
        else
        {
            Console.WriteLine(string.Join(", ", divisibleNumbers));
        }
    }
}
    }
