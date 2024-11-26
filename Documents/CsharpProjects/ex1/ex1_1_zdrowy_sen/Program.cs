using System;

public class Program
{
    public static void Main()
    {
        // wczytanie danych
        string[] input = Console.ReadLine().Split();
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        int H = int.Parse(input[2]);

        // wnioskowanie
        if(A < H && B < H){
            Console.WriteLine("Nadmiar");

        }
        else if(A > H && B > H){
            Console.WriteLine("Niedobór");
        }
        else if(A <= H && B >= H){
            Console.WriteLine("Normalny");
        }
    }
}

