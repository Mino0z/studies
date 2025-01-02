using System;
class Program{
    public static void Main(){
     
        var t = new Czas24h(2, 15, 37);
        t.Minuta = 20;
        t.Godzina = 24;
        Console.WriteLine(t);
        }
public class Czas24h
{
    private int liczbaSekund;
 
    public int Sekunda
    {
        get => liczbaSekund - Godzina * 60 * 60 - Minuta * 60;
        set {
            if(value < 0 || value > 59)
                throw new ArgumentException("error");
            liczbaSekund = value + 60 * Minuta + 3600 * Godzina;
        }
    }   
    public int Minuta
    {
        get => (liczbaSekund / 60) % 60;
        set{
        if(value < 0 || value > 59)
            throw new ArgumentException("error");
        liczbaSekund = Sekunda + 60 * value + 3600 * Godzina;
        }
    }
 
    public int Godzina
    {
        get => liczbaSekund / 3600;
        set{
        if(value < 0 || value > 23)
            throw new ArgumentException("error");
        liczbaSekund = Sekunda + 60 * Minuta + 3600 * value;
        }
   }
 
    public Czas24h(int godzina, int minuta, int sekunda)
    {
        if (godzina < 0 || godzina > 23)
            throw new ArgumentException("error");
        if (minuta < 0 || minuta > 59)
            throw new ArgumentException("error");
        if (sekunda < 0 || sekunda > 59)
            throw new ArgumentException("error");
        liczbaSekund = sekunda + 60 * minuta + 3600 * godzina;
        if(liczbaSekund < 0 || liczbaSekund > 86399)
            throw new ArgumentException("error");
    }
    public override string ToString() => $"{Godzina}:{Minuta:D2}:{Sekunda:D2}";
} 

}