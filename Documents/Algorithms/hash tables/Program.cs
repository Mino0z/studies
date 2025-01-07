using System;
using System.Collections;

class Program{
    static void Main(){
        Hashtable hashtable = new Hashtable();

       
        hashtable.Add("klucz1", "wartość1");
        hashtable["klucz2"] = "wartość2";

        Console.WriteLine(hashtable["klucz1"]); 

        if (hashtable.ContainsKey("klucz2"))
        {
            Console.WriteLine("Klucz2 istnieje!");
        }
    }
}