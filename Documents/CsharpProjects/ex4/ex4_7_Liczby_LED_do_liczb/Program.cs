using System; 
using System.Collections.Generic;
class Program{

    public static void Main(){
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();
        string input3 = Console.ReadLine();

        string[] numbers = {input1, input2, input3};

        int maxChunks = 0;
        foreach(var number in numbers){
            maxChunks = Math.Max(maxChunks, (number.Length+2) / 3);
        }
        string[, ] result = new string[numbers.Length, maxChunks];
        for (int i = 0; i < numbers.Length; i++){
            string currentNumber = numbers[i];
            for(int j = 0; j < (currentNumber.Length + 2) / 3; j++){
                int startindex = j*3;
                int length = Math.Min(3, currentNumber.Length - startindex);
                result[i, j] = currentNumber.Substring(startindex, length);
            }
        }
        string resultNumber = "";
        for (int i = 0; i < result.GetLength(0); i++){
            for (int j = 0; j< result.GetLength(1); j++){
                if(result[i,j]== " _ " && result[i+1,j]== "| |" && result[i+2,j]== "|_|"){
                    resultNumber += "0";
                }
                else if(result[i,j]== "   " && result[i+1,j]== "  |" && result[i+2,j]== "  |"){
                    resultNumber += "1";
                }
                else if(result[i,j]== " _ " && result[i+1,j]== " _|" && result[i+2,j]== "|_ "){
                    resultNumber += "2";
                }
                else if(result[i,j]== " _ " && result[i+1,j]== " _|" && result[i+2,j]== " _|"){
                    resultNumber += "3";
                }
                else if(result[i,j]== "   " && result[i+1,j]== "|_|" && result[i+2,j]== "  |"){
                    resultNumber += "4";
                }
                else if(result[i,j]== " _ " && result[i+1,j]== "|_ " && result[i+2,j]== " _|"){
                    resultNumber += "5";
                }
                else if(result[i,j]== " _ " && result[i+1,j]== "|_ " && result[i+2,j]== "|_|"){
                    resultNumber += "6";
                }
                else if(result[i,j]== " _ " && result[i+1,j]== "  |" && result[i+2,j]== "  |"){
                    resultNumber += "7";
                }
                else if(result[i,j]== " _ " && result[i+1,j]== "|_|" && result[i+2,j]== "|_|"){
                    resultNumber += "8";
                }
                else if(result[i,j]== " _ " && result[i+1,j]== "|_|" && result[i+2,j]== "  |"){
                    resultNumber += "9";
                }
            }
        }
        Console.WriteLine(resultNumber);
    }

}
