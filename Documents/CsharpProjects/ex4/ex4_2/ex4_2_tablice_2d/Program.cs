using System;

class Program{
    public static void Main(){
        PrintArray();
    }
    public static void PrintArray(){
        string[] input = Console.ReadLine().Split(" ");
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        
        
        int[,] a;
        a = new int[n, m];
        int index = 0;
        for (int i = 0; i < a.GetLength(0); i++){
            string[] input2 = Console.ReadLine().Split(" ");
            for(int j = 0 ; j < a.GetLength(1); j++){
                if (index < a.Length)
                {
                    a[i, j] = int.Parse(input2[j]);
                    index++;
                }
                
            }
        }
        Console.WriteLine("Array: transponowana");
        for (int i = 0; i < a.GetLength(1); i++) 
        {
            for (int j = 0; j < a.GetLength(0); j++) 
            {
                Console.Write(a[j, i] + " ");
            }
            Console.WriteLine();
        }

    }
}