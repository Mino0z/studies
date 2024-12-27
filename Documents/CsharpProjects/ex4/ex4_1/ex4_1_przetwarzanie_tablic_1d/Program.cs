using System;

class Program{
public static void Main(){
    int[] a1 = { -2, -1, 0, 1, 4 };
    int[] b1 = { -3, -2, -1, 1, 2};
        Print(a1, b1);
}

public static void Print(int[] a, int[] b)
{
    string result = "";
    for(int i = 0; i < a.Length; i++)
    {
        bool found = false;
        for(int j =0; j < b.Length; j++)
        {
            if(a[i] == b[j])
            {
                found = true;
                break;
            }
            
        }
        if(!found && !result.Contains(a[i].ToString()))
        {
            result += a[i] + " ";
        }
  }
  if(string.IsNullOrEmpty(result))
  {
      Console.WriteLine("empty");
  }
  else
  {
      Console.WriteLine(result.Trim());

}
}
}
