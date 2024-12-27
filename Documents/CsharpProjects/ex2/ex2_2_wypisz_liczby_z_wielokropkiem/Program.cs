using System;

namespace Zadania_petle
{
    class Program
    {
        static void Main()
        {
            //wczytywanie i parsowanie danych wejściowych
            string wejscie = Console.ReadLine();
            int[] dane = Array.ConvertAll<string, int>(wejscie.Split(" "), int.Parse);
            // Twój kod
            int a = dane[0];
            int b = dane[1];
            if(a == b || b - a == 1 || a - b ==1){
                Console.WriteLine("empty");
            }
            else{

            
            if (a > b) {
                 (b, a) = (a, b);
             }
            if((Math.Abs((b-1)) - Math.Abs((a))) > 10){
                for(int i = a+1; i < a+4; i++){
                    Console.Write(i);
                    Console.Write(", ");
            }
            Console.Write("...");
            for(int i = b-2; i < b; i++){
                    Console.Write(", ");
                    Console.Write(i);
                }
            }
            else if(a < b){
                for(int i = a+1; i < b-1; ){
                    Console.Write(i);
                    Console.Write(", ");
                    i++;
                }
                Console.Write(b-1);
            }
        }
        }
    }
}
