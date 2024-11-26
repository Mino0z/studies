using System;

namespace FlowChart
{
    class Program
    {
        static void Main()
        {
            // Twój kod
            string[] input = Console.ReadLine().Split(" ");
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            int z = int.Parse(input[2]);  

            string result = "";

            for(; x >0 && y >0; x--, y--){
                result += "C";
            }
            if(x >0 && y <= 0){
                result += "D";
                if(z>0){
                    Console.WriteLine(result);
                    return;
                }
            }
            else if(x <= 0){
                result +="E";
            }
            result +="G";
            Console.WriteLine(result);
            
    }
}
}