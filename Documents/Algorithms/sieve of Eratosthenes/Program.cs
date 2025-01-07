using System;

class SieveOfEratosthenes
{
    public static void Sieve(int n)
    {
        
        bool[] isPrime = new bool[n + 1];
        for (int i = 0; i <= n; i++)
        {
            isPrime[i] = true;
        }

        
        isPrime[0] = isPrime[1] = false;

       
        for (int i = 2; i * i <= n; i++)
        {
            if (isPrime[i])  
            {
                for (int j = i * i; j <= n; j += i)  
                {
                    isPrime[j] = false;
                }
            }
        }

        Console.WriteLine("Liczby pierwsze mniejsze niż " + n + ":");
        for (int i = 2; i <= n; i++)
        {
            if (isPrime[i])
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        int n = 100;
        Sieve(n);
    }
}
