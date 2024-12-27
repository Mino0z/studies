using System;

namespace FlowChart
{
    class Program
    {
        static void Main()
        {
            // Read input and split by comma
            string inputs = Console.ReadLine();
            string[] input = inputs.Split(", ");
            int x = Convert.ToInt32(input[0]);
            int y = Convert.ToInt32(input[1]);  
            int z = Convert.ToInt32(input[2]);    

            first_If: 
            if (x > 0)
            {
                if (y > 0)
                {
                    x = x - 1;
                    y = y - 1;
                    Console.WriteLine("C");
                    goto first_If; 
                }
                else
                {
                    Console.WriteLine("D");
                    if (z > 0)
                    {
                        goto ending_WriteLine;
                    }
                    else
                    {
                        goto write_G;
                    }
                }
            }
            else
            {
                Console.WriteLine("E");
                goto write_G;
            }

            write_G: 
            Console.WriteLine("G");

            ending_WriteLine: 
            Console.WriteLine();
        }
    }
}