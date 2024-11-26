
using System;
using System.Text.RegularExpressions;
using System.Numerics;


class Program
{
    public static void Main(string[] args)
    {
        
        try
        { 
            string[] input = Console.ReadLine()?.Split(" ") ?? throw new Exception("Nieprawidłowe dane wejściowe.");
            
            if (input.Length != 2) throw new Exception("Nieprawidłowe dane wejściowe.");
            
            int R = int.Parse(input[0]);
            int L = int.Parse(input[1]);
        
            if (R < -1_000_000 || R > 1_000_000 || L < -1_000_000 || L > 1_000_000)
            {
                Console.WriteLine("Argumenty poza zakresem");
                return;
            }
            if (R < 0 || L < 0)
            {
                Console.WriteLine("ujemny argument");
                return;
            }
            if (R > L)
            {
                Console.WriteLine("obiekt nie istnieje");
                return;
            }
                decimal pp = (decimal)Math.PI * R * R;
                BigInteger h = ((BigInteger)L * L) - ((BigInteger)R * R);
                decimal h2 = (decimal)Math.Sqrt((double)h);
                decimal V = (pp * h2) / 3;
                decimal a = Math.Floor(V);
                decimal b = Math.Ceiling(V);

            Console.WriteLine($"{a} {b}");
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}