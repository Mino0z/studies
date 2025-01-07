using System;

class Program{

    static void Main(){
        int n = 5;
        int result = Factorial(n);
        Console.WriteLine(result);
    }
    public static int Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * Factorial(n - 1);
    }

}