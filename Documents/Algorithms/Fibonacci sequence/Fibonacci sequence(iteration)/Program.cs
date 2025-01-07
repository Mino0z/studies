using System;

class Program{

    static void Main(){
        int n = 10;  
        int result = FibonacciIterative(n);
        Console.WriteLine(result);  
    }
    public static int FibonacciIterative(int n)
    {
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;

        int a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }
}