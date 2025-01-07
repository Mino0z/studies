using System;

class Program{
    static void Main(){
        double[] coefficients = { 3, 2, 1, 4 };
        double x = 2;
        double result = HornerMethod(coefficients, x);
        Console.WriteLine(result);
    }
    public static double HornerMethod(double[] coefficients, double x)
    {
        double result = coefficients[0];
        
        for (int i = 1; i < coefficients.Length; i++)
        {
            result = result * x + coefficients[i];
        }

        return result;
    }

}