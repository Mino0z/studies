using System;

class Program{
    public static void Main(){
        PrintArray();
    }
    public static void PrintArray(){
        string[] input = Console.ReadLine().Split(" ");
        int n1 = int.Parse(input[0]);
        int m1 = int.Parse(input[1]);

        int[,] a;
        a = new int[n1, m1];
        
        string[] input2 = Console.ReadLine().Split(" ");
        int countera = 0;
        for(int i = 0; i < a.GetLength(0); i++){
            for(int j = 0; j < a.GetLength(1); j++){
                a[i,j] = int.Parse(input2[countera]);
                countera++;
            }
        }
        /*
        for(int i = 0; i < a.GetLength(0); i++){
            for(int j = 0; j< a.GetLength(1); j++){
                Console.Write(a[i,j] + " ");
            }
            Console.WriteLine();
        }
        */

        string[] input3 = Console.ReadLine().Split(" ");
        int n2 = int.Parse(input3[0]);
        int m2 = int.Parse(input3[1]);

        int[,] b;
        b = new int[n2, m2];
        
        string[] input4 = Console.ReadLine().Split(" ");
        int counterb = 0;
        for(int i = 0; i < b.GetLength(0); i++){
            for(int j = 0; j < b.GetLength(1); j++){
                b[i,j] = int.Parse(input4[counterb]);
                counterb++;
            }
        }
        /*
        for(int i = 0; i < b.GetLength(0); i++){
            for(int j = 0; j< b.GetLength(1); j++){
                Console.Write(b[i,j] + " ");
            }
            Console.WriteLine();
        }
        */
        
        if(m1 == n2){
            int[,] c;
            c = new int[n1, m2];
            
            for (int i = 0; i < n1; i++)
        {
            for (int j = 0; j < m2; j++)
            {
                
                for (int k = 0; k < m1; k++)
                {
                    c[i, j] += a[i, k] * b[k, j];
                }
            }
        }
            for(int i = 0; i < c.GetLength(0); i++){
            for(int j = 0; j < c.GetLength(1); j++){
                Console.Write(c[i,j] + " ");
            }
            Console.WriteLine();
        }
        }
        
        if(m1 != n2){
            Console.WriteLine("impossible");
        }
        
    }



}