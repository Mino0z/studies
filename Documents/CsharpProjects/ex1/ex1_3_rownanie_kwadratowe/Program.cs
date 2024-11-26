using System;

public class Program
{
    public static void QuadraticEquation(int a, int b, int c)
    {
        // Przypadek równania tożsamościowego
        if (a == 0 && b == 0 && c == 0)
        {
            Console.WriteLine("infinity");
            return;
        }

        // Przypadek równania liniowego (a == 0)
        if (a == 0)
        {
            if (b != 0)
            {
                // Rozwiązanie równania liniowego bx + c = 0
                double x = -((double)c / b);
                Console.WriteLine($"x={Math.Round(x, 2):F2}");
            }
            else
            {
                // Brak rozwiązań (równanie sprzeczne c != 0)
                Console.WriteLine("empty");
            }
            return;
        }

        // Równanie kwadratowe (a != 0)
        double delta = b * b - 4 * a * c;

        // Sprawdzenie wartości delty
        if (delta < 0)
        {
            // Brak rzeczywistych rozwiązań
            Console.WriteLine("empty");
            Console.WriteLine(delta);
        }
        else if (delta == 0)
        {
            // Jedno rozwiązanie
            double x = -b / (2.0 * a);
            Console.WriteLine($"x={Math.Round(x, 2):F2}");
        }
        else
        {
            // Dwa rozwiązania
            double sqrtDelta = Math.Sqrt(delta);
            double x1 = (-b - sqrtDelta) / (2 * a);
            double x2 = (-b + sqrtDelta) / (2 * a);

            // Wyświetlenie rozwiązań w porządku rosnącym
            if (x1 > x2)
            {
                double temp = x1;
                x1 = x2;
                x2 = temp;
            }

            Console.WriteLine($"x1={Math.Round(x1, 2):F2}");
            Console.WriteLine($"x2={Math.Round(x2, 2):F2}");
        }
    }

    // Testowanie funkcji
    public static void Main(string[] args)
    {
        QuadraticEquation(1000000, 6000, -300295);
        
    }
}