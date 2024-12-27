using System;

class Program{

    public static void Main(){
        char[][] jagged = ReadJaggedArrayFromStdInput();
        PrintJaggedArrayToStdOutput(jagged);
        jagged = TransposeJaggedArray(jagged);
        Console.WriteLine();
        PrintJaggedArrayToStdOutput(jagged);
    }
    static char[][] ReadJaggedArrayFromStdInput(){
        int input = int.Parse(Console.ReadLine());
        char[][] jaggedArray = new char[input][];
        for (int i = 0; i < input; i++){
            string[] inputArr = Console.ReadLine().Split(" ");
            jaggedArray[i] = new char[inputArr.Length];
            for (int j = 0; j < inputArr.Length; j++){
                char inputChar = char.Parse(inputArr[j]);
                jaggedArray[i][j] = inputChar;
            }
        }
        return jaggedArray;
    }
    static void PrintJaggedArrayToStdOutput(char[][] jaggedArray){
        for (int i = 0; i < jaggedArray.Length; i++){
            for (int j = 0; j < jaggedArray[i].Length; j++){
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
    static char[][] TransposeJaggedArray(char[][] jaggedArray){
        int maxLength = 0;
        foreach(var row in jaggedArray){
            if (row.Length > maxLength){
                maxLength = row.Length;
            }
        }
            char[][] transposedArray = new char[maxLength][];
            for(int i = 0; i < maxLength; i++){
                transposedArray[i] = new char[jaggedArray.Length];
                for(int j = 0; j < jaggedArray.Length; j++){
                    if (i < jaggedArray[j].Length){
                        transposedArray[i][j] = jaggedArray[j][i];
                    }
                    else{
                        transposedArray[i][j] = ' ';
                    }
                }
            }
        
    return transposedArray;
}
}