using System;
using System.Globalization;

namespace Zadanie_ParametryTrojkata
{
  class Program
  {
    static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
        // wczytaj dane
        string dane = Console.ReadLine();
        string[] dana = dane.Split("; ");
        // i wykonaj obliczenia
        double a = double.Parse(dana[0]);
        double b = double.Parse(dana[1]);
        double c = double.Parse(dana[2]);
        
        if(a <= 0 || b <= 0 || c <= 0){
            Console.WriteLine("Błędne dane. Długości boków muszą być dodatnie!");
        }
        else if(a + b < c || a + c < b || c + b < a){
            
            Console.WriteLine("Błędne dane. Trójkąta nie można zbudować!");
        }
        else{
            double obwod = a + b + c;
            Console.WriteLine($"obwód = {obwod.ToString("F2")}");
            double p = obwod / 2;
            double pole = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            Console.WriteLine($"pole = {pole.ToString("F2")}");
            double asqrt = a*a;
            double bsqrt = b*b;
            double csqrt = c*c;
            if(asqrt + bsqrt == csqrt || asqrt + csqrt == bsqrt || bsqrt + csqrt == asqrt){
                Console.WriteLine("trójkąt jest prostokątny");
            }
            else if(asqrt + bsqrt > csqrt || asqrt + csqrt > bsqrt || bsqrt + csqrt > asqrt){
                Console.WriteLine("trójkąt jest rozwartokątny");
            }
            else if(asqrt + bsqrt < csqrt || asqrt + csqrt < bsqrt || bsqrt + csqrt < asqrt){
                Console.WriteLine("trójkąt jest ostrokątny");
            }
            if (a == b && b == c){
                Console.WriteLine("trójkąt równoboczny");
            }
            else if (a == b || a == c || b == a || b == c || c == a || c == b){
                Console.WriteLine("trójkąt równoramienny");
            }
            
        }
    }
  }
}