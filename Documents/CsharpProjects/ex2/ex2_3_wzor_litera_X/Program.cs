using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Wzorek(n);
    }
public static void Wzorek(int n)
{
    // tu wpisz kod
     if (n < 3) throw new ArgumentException("zbyt mały rozmiar");
    if (n % 2 == 0) n = n - 1;
   for(int i = 0; i < n/2;i++){
    for (int j = 0;j<i;j++)
        Console.Write(" ");
    Console.Write("*");
    for(int j = 0; j < n - 2 - 2 * i; j++)
        Console.Write(" ");
    Console.Write("*");
Console.WriteLine();
   }
   //linia środkowa
   for(int i = 0; i < n/2;i++){
    Console.Write(" ");
   }
   Console.Write("*");
   for(int i = n/2; i <n ;i++){
    Console.Write(" ");
   }
Console.WriteLine();
   // dolna cześć

 for (int i = n / 2 - 1; i >= 0; i--)
        {
            
            for (int j = 0; j < i; j++)
                Console.Write(" ");

            
            Console.Write("*");

            for (int j = 0; j < n - 2 - 2 * i; j++)
                Console.Write(" ");

           
            Console.Write("*");
            
            
            Console.WriteLine();
        }
}
}