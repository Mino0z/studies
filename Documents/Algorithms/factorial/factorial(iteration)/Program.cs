using System;

class Program{

    static void Main(){
        int n = 5;
        int result = Factorial(n);
        Console.WriteLine(result);
    }
    public static int Factorial(int n)
{
    int wynik = 1;
    for (int i = 1; i <= n; i++)
    {
        wynik *= i;
    }
    return wynik;
}

}