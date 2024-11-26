using System;

class Program
{
    static void Main(string[] args)
    {
        // tu wpisz kod
        try{
    string a = Console.ReadLine();
    string b = Console.ReadLine();
    string c = Console.ReadLine();
    
    
    
    int a1 = int.Parse(a);
    int b1 = int.Parse(b);
    int c1 = int.Parse(c);
    checked{
        int end = a1*b1*c1;
        Console.WriteLine(end);
    }
    /*
    int end = a1*b1*c1;
    if(end > int.MaxValue || end > int.MinValue){
        throw new OverflowException("overflow exception, exit");
    }
    else{
    Console.WriteLine(end);
    } 
    */
    }
    catch(FormatException){
        Console.WriteLine("format exception, exit");
    }
    catch(ArgumentException){
        Console.WriteLine("argument exception, exit");
    }
    catch(OverflowException){
        Console.WriteLine("overflow exception, exit");
    }
    catch(Exception){
        Console.WriteLine("non supported exception, exit");
    }
        
    }
}