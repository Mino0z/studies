using System;

namespace FlowChartSolution
{
    class Program
    {
        static void Main()
        {
            
            string[] input = Console.ReadLine().Split();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            int z = int.Parse(input[2]);
            
           
            string result = "";

           
            while (x > 0 && y > 0)
            {
                result += "C";
                x -= 1;
                y -= 1;
            }

            
            if (x > 0 && y <= 0)
            {
                result += "D";
                if (z > 0)
                {
                    Console.WriteLine(result);
                    return;  
                }
            }
            else if (x <= 0)
            {
                result += "E";
            }

            
            result += "G";
            Console.WriteLine(result);
        }
    }
}