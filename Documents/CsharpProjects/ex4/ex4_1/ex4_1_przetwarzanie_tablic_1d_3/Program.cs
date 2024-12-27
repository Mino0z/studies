using System;

class Program
{
    public static void Main()
    {
        int[] a1 = { -2, -1, 0, 1, 4 };
        int[] b1 = { -3, -2, -1, 1, 2, 3 };
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
        if (!found)
        {
            result += a[i] + " ";
            lastAdded = a[i];
        }
    }

    lastAdded = int.MinValue;
    for (int i = 0; i < b.Length; i++)
    {
        if (b[i] == lastAdded)
        {
            continue;
        }
        bool found = false;
        for (int j = 0; j < a.Length; j++)
        {
            if (b[i] == a[j])
            {
                found = true;
                break;
            }
        }
        if (!found)
        {
            result += b[i] + " ";
            lastAdded = b[i];
        }
    }

    if (string.IsNullOrEmpty(result))
    {
        Console.WriteLine("empty");
    }
    else
    {
        string[] resultText = result.Trim().Split(' ');
        int[] resultTab = new int[resultText.Length];
        for (int i = 0; i < resultText.Length; i++)
        {
            resultTab[i] = int.Parse(resultText[i]);
        }
        Array.Sort(resultTab);
        Console.WriteLine(string.Join(" ", resultTab));
    }
}
}