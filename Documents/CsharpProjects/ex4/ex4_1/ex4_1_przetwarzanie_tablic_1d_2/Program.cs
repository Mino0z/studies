using System;

class Program
{
    public static void Main()
    {
        int[] a1 = { 0, 1, 1, 2, 3, 3, 3 };
        int[] b1 = { 1, 2, 2, 3, 4 };
        Print(a1, b1);
    }

    public static void Print(int[] a, int[] b)
    {
        string result = "";
        int lastAdded = int.MinValue;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == lastAdded)
            {
                continue; 
            }

            bool found = false;
            for (int j = 0; j < b.Length; j++)
            {
                if (a[i] == b[j])
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                result += a[i] + " ";
                lastAdded = a[i];
            }
        }

        if (string.IsNullOrEmpty(result))
        {
            Console.WriteLine("empty");
        }
        else
        {
            Console.WriteLine(result.Trim());
        }
    }
}