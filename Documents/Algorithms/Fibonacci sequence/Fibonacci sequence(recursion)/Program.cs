using System;

class Program{

    static void Main(){
        int n = 10;  
        int result = FibonacciRecursive(n);
        Console.WriteLine(result);  
    }
    public static int FibonacciRecursive(int n)
    {
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

}