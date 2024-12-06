using System;
using System.Linq;

class Program{

    public static void Main(){
        int[,] tab;
        tab = new int[9,9];
        for (int i = 0; i < 9; i++){
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            for (int j = 0; j < 9; j++){
                tab[i, j] = input[j];
                
            }
        }
        SprawdzSudoku(tab);
    }
    public static void SprawdzSudoku(int[,] tab){
        bool result = true;

        //sprawdzanie kwadratów
        for (int boxRow=0 ; boxRow < 3 ; boxRow++){
            for (int boxCol = 0; boxCol < 3 ; boxCol++){
                int[] tabA= new int[9];
                int counter = 0;
                for(int i =0 ; i < 3 ; i++){
                    for(int j = 0; j < 3; j++){
                        tabA[counter] = tab[boxRow*3 + i, boxCol*3 + j];
                        counter++;
                    }   
                    
                }
                if(!tabA.OrderBy(x => x).SequenceEqual(Enumerable.Range(1, 9))){
                        result = false;
                    }
            }
        }
        //sprawdzanie wierszy
            for(int j = 0; j< 9; j++){
                int[] row = new int[9];
                for(int k = 0; k < 9; k++){
                    row [k] = tab[j, k];
                }
                if(!row.OrderBy(x => x).SequenceEqual(Enumerable.Range(1, 9))){
                        result = false;
                        break;
                }
            }
        //sprawdzanie kolumn
            for(int j = 0; j < 9; j++){
                int[] col = new int[9];
                for(int k = 0; k < 9; k++){
                    col[k] = tab[k, j];
                }
                if(!col.OrderBy(x => x).SequenceEqual(Enumerable.Range(1, 9))){
                        result = false;
                        break;
                    }
            }
        if(result){
            Console.WriteLine("yes");
        }
        else{
            Console.WriteLine("no");
        }
    }

}