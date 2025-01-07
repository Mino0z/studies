using System;

class EuclideanAlgorithm
{
    public static int GCD(int a, int b)
    {
        // Algorytm Euklidesa
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public static void Main(string[] args)
    {
        int a = 56;
        int b = 98;

        int gcd = GCD(a, b);
        Console.WriteLine($"NWD({a}, {b}) = {gcd}");
    }
}
