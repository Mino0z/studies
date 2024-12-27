using System;
using System.Linq;
class Program{
    public static void Main(){
        string dim = Console.ReadLine();
        string[] dimTab = dim.Split();
        int n = int.Parse(dimTab[0]);
        int m = int.Parse(dimTab[1]);
        int counter = 0;
        char[,] lineTab = new char[n, m];
        while (counter < n)
        {
            string line = Console.ReadLine();
            char[] charElements = line.ToCharArray();
            for (int i = 0; i < m; i++)
            {
                lineTab[counter, i] = charElements[i];
            }

            counter++;
        }
        OdslonPlansze(lineTab);
    }
    public static void OdslonPlansze(char[,] tab){
        for(int i = 0; i < tab.GetLength(0); i++){
            for(int j = 0; j < tab.GetLength(1); j++){
                int counter = 0;
                if (tab[i,j] == '*'){
                    Console.Write('*');
                    continue;
                }
                for(int x = -1; x <= 1; x++){
                    for(int y = -1; y <= 1; y++){
                        if(x == 0 && y == 0){
                            continue;
                        }
                        int neighbourRow = i + x;
                        int neighbourCol = j + y; 
                        
                        if (neighbourRow >= 0 && neighbourRow < tab.GetLength(0) && neighbourCol >= 0 && neighbourCol < tab.GetLength(1) && tab[neighbourRow, neighbourCol] == '*'){
                            counter++;
                        }

                    }
                }
                if(counter == 0 ){
                    Console.Write(".");
                }
                else{
                    Console.Write(counter);
                }
            }
            
            Console.WriteLine();
        }
        

    }


}