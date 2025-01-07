using System;

class EuclideanAlgorithm
{
    public static int GCD(int a, int b)
{
    if (b == 0)
        return a;
    return GCD(b, a % b);
}

    public static void Main(string[] args)
    {
        int a = 56;
        int b = 98;

        int gcd = GCD(a, b);
        Console.WriteLine($"NWD({a}, {b}) = {gcd}");
    }
}
