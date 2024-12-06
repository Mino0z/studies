using System;
using System.Collections.Generic;
using System.Linq;

class Program{
    public static void Main(){
        PrintArray();
    }
    public static void PrintArray(){
        List<int[]> listaTablic = new List<int[]>();
        string input;
        do{
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;
            
            int[] tablica = input
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
            
            listaTablic.Add(tablica);
        }
        while(!string.IsNullOrEmpty(input));
        List<int> resultTab = new List<int>();
        for(int i = 0; i< listaTablic[0].Length; i++){
            int result =  0; 
            for(int j = 0; j < listaTablic.Count; j++){
                result += listaTablic[j][i];
            }
            resultTab.Add(result);
        }
        int maxIndex = resultTab.IndexOf(resultTab.Max());
        Console.WriteLine(maxIndex);
    }
}

