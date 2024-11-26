/*Console.WriteLine("a"=="a");
Console.WriteLine("a"=="A");
Console.WriteLine(1 == 2);
string myValue = "a";
Console.WriteLine(myValue == "a");

Console.WriteLine("a" == "a ");

string value1 = " a";
string value2 = "a";
Console.WriteLine(value1.ToLower().Trim() == value2.ToLower().Trim());


Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

String myValue = "a";
Console.WriteLine(myValue != "a");

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);


string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("dox"));

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));

Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("dox"));

int a = 6;
int b = 7;
Console.WriteLine(a != b);

string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2);



int saleAmount = 1001;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");



using Microsoft.VisualBasic;

Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");

//Menager
string permision = "Menager";
int level = 56;

if (level > 55 && permision.Contains("Admin")){
    Console.WriteLine("Welcome, Super Admin user.");
}
else if(level <= 55 && permision.Contains("Admin")){
    Console.WriteLine("Welcome, Admin user.");
}
else if(level >=20 && permision.Contains("Menager")){
    Console.WriteLine("Contact an Admin for access.");
}
else if(level <20 && permision.Contains("Menager")){
    Console.WriteLine("You do not have sufficient privileges.");
}
else if(!permision.Contains("Admin") && !permision.Contains("Menager")){
    Console.WriteLine("You do not have sufficient privileges.");
}
*/
/*
using System;
int roznica = 01112;
if(roznica.Endsw)
roznica.Convert.ToStiring
class Program
{
    static void Main(string[] args)
    {
        // tu wpisujesz kod
        string nazwisko = "";
        int wiekosoby = 0;
        int wiekemerytalny = 0;
        
        nazwisko = Console.ReadLine() ?? "";
        wiekosoby = Convert.ToInt32(Console.ReadLine());
        wiekemerytalny = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Witaj, {nazwisko}");
        if(wiekosoby < 0 || wiekemerytalny < 0){
            Console.WriteLine("Wiek nie może być ujemny!");
        }
        else
        {
        if(wiekosoby < wiekemerytalny){
            Console.WriteLine($"Do emerytury brakuje Ci {wiekemerytalny - wiekosoby} lat!");
        }
        if(wiekosoby > wiekemerytalny){
            Console.WriteLine("Jesteś emerytem");
        }


        }
    }
}
*/
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        // tu wpisujesz kod
        string nazwisko = "";
        int wiekosoby = 0;
        int wiekemerytalny = 0;

        // Wczytywanie danych
        Console.WriteLine("Podaj nazwisko:");
        nazwisko = Console.ReadLine() ?? "";

        Console.WriteLine("Podaj swój wiek:");
        string? wiekOsobyInput = Console.ReadLine();
        if (!int.TryParse(wiekOsobyInput, out wiekosoby))
        {
            Console.WriteLine("Podano nieprawidłowy wiek. Proszę podać poprawną liczbę.");
            return;
        }

        Console.WriteLine("Podaj wiek emerytalny:");
        string? wiekEmerytalnyInput = Console.ReadLine();
        if (!int.TryParse(wiekEmerytalnyInput, out wiekemerytalny))
        {
            Console.WriteLine("Podano nieprawidłowy wiek emerytalny. Proszę podać poprawną liczbę.");
            return;
        }

        // Wyświetlanie wyników
        Console.WriteLine($"Witaj, {nazwisko}");

        if (wiekosoby < 0 || wiekemerytalny < 0)
        {
            Console.WriteLine("Wiek nie może być ujemny!");
        }
        else if (wiekosoby < wiekemerytalny)
        {
            Console.WriteLine($"Do emerytury brakuje Ci {wiekemerytalny - wiekosoby} lat!");
        }
        else if (wiekosoby >= wiekemerytalny)
        {
            Console.WriteLine("Jesteś emerytem");
        }
    }
}
*/
/*
using System;
using System.Globalization;
public static class Math;
namespace Zadanie_ParametryTrojkata
{
  class Program
  {
    static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
        // wczytaj dane
        // i wykonaj obliczenia

    }
  }
}

using System;
using System.Globalization;

namespace Zadanie_ParametryTrojkata
{
  class Program
  {
    static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
        // wczytaj dane
        string dane = Console.Readline();
        string[] dana = dane.split(" ");
        // i wykonaj obliczenia
        float a = dana[0];
        float b = dana[1];
        float c = dana[2];
        
        if(a < 0 || b < 0 || c < 0){
            Console.WriteLine("Błędne dane. Długości boków muszą być dodatnie!");
        }
        else{
            float obwod = a + b + c;
            Console.WriteLine($"obwód = {obwod.round(2)});
        }
    }
  }
}


using System;
using System.Globalization;

namespace Zadanie_ParametryTrojkata
{
  class Program
  {
    static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
        // wczytaj dane
        string dane = Console.ReadLine();
        string[] dana = dane.Split("; ");
        // i wykonaj obliczenia
        double a = double.Parse(dana[0]);
        double b = double.Parse(dana[1]);
        double c = double.Parse(dana[2]);
        
        if(a <= 0 || b <= 0 || c <= 0){
            Console.WriteLine("Błędne dane. Długości boków muszą być dodatnie!");
        }
        else if(a + b < c || a + c < b || c + b < a){
            
            Console.WriteLine("Błędne dane. Trójkąta nie można zbudować!");
        }
        else{
            double obwod = a + b + c;
            Console.WriteLine($"obwód = {obwod.ToString("F2")}");
            double p = obwod / 2;
            double pole = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            Console.WriteLine($"pole = {pole.ToString("F2")}");
            double asqrt = a*a;
            double bsqrt = b*b;
            double csqrt = c*c;
            if(asqrt + bsqrt == csqrt || asqrt + csqrt == bsqrt || bsqrt + csqrt == asqrt){
                Console.WriteLine("trójkąt jest prostokątny");
            }
            else if(asqrt + bsqrt > csqrt || asqrt + csqrt > bsqrt || bsqrt + csqrt > asqrt){
                Console.WriteLine("trójkąt jest rozwartokątny");
            }
            else if(asqrt + bsqrt < csqrt || asqrt + csqrt < bsqrt || bsqrt + csqrt < asqrt){
                Console.WriteLine("trójkąt jest ostrokątny");
            }
            if (a == b && b == c){
                Console.WriteLine("trójkąt równoboczny");
            }
            else if (a == b || a == c || b == a || b == c || c == a || c == b){
                Console.WriteLine("trójkąt równoramienny");
            }
            
        }
    }
  }
}
*/
/*
static void QuadraticEquation(int a, int b, int c)
{
    //throw new NotImplementedException();
    
    double delta = b * b - (4*a*c);
    if(a == 0 && b == 0 && c == 0){
        Console.WriteLine("infinity");
    }
    else{
        
        if (delta > 0){
            double x1 = (-b - Math.Sqrt(delta))/2*a;
            double x2 = (-b + Math.Sqrt(delta))/2*a;
            Console.WriteLine($"x1={x1.ToString("F2")}");
            Console.WriteLine($"x2={x2.ToString("F2")}");
        }
        else if(a == 0 && b == 0 ){
            Console.WriteLine("empty");
        } 
        else if(delta == 0){
            double x = (-b/2*a);
            Console.WriteLine($"x={x.ToString("F2")}");
        }
        else if(delta < 0){
            Console.WriteLine("empty");
        }
    }
    
}
QuadraticEquation(0, 0 ,2);
*/
/*
        if(a == 0 && b >=0 && c >= 0){
            double x = (-b/2*a);
            Console.WriteLine($"x={x.ToString("F2")}");
        }

using System;

public class Program
{
    public static void QuadraticEquation(int a, int b, int c)
    {
        // Przypadek równania tożsamościowego
        if (a == 0 && b == 0 && c == 0)
        {
            Console.WriteLine("infinity");
            return;
        }

        // Przypadek równania liniowego (a == 0)
        if (a == 0)
        {
            if (b != 0)
            {
                // Rozwiązanie równania liniowego bx + c = 0
                double x = -((double)c / b);
                Console.WriteLine($"x={Math.Round(x, 2):F2}");
            }
            else
            {
                // Brak rozwiązań (równanie sprzeczne c != 0)
                Console.WriteLine("empty");
            }
            return;
        }

        // Równanie kwadratowe (a != 0)
        double delta = b * b - 4 * a * c;

        // Sprawdzenie wartości delty
        if (delta < 0)
        {
            // Brak rzeczywistych rozwiązań
            Console.WriteLine("empty");
            Console.WriteLine(delta);
        }
        else if (delta == 0)
        {
            // Jedno rozwiązanie
            double x = -b / (2.0 * a);
            Console.WriteLine($"x={Math.Round(x, 2):F2}");
        }
        else
        {
            // Dwa rozwiązania
            double sqrtDelta = Math.Sqrt(delta);
            double x1 = (-b - sqrtDelta) / (2 * a);
            double x2 = (-b + sqrtDelta) / (2 * a);

            // Wyświetlenie rozwiązań w porządku rosnącym
            if (x1 > x2)
            {
                double temp = x1;
                x1 = x2;
                x2 = temp;
            }

            Console.WriteLine($"x1={Math.Round(x1, 2):F2}");
            Console.WriteLine($"x2={Math.Round(x2, 2):F2}");
        }
    }

    // Testowanie funkcji
    public static void Main(string[] args)
    {
        // Przykład 5: a = 1000000, b = 6000, c = -300295
        QuadraticEquation(1000000, 6000, -300295); // Oczekiwane wyniki: x1=-0.55, x2=0.55
        
    }
}
/*
public static void QuadraticEquation(int a, int b, int c)
{
    double a1 = (double)a;
    double b1 = (double)b;
    double c1 = (double)c;
    //throw new NotImplementedException();
    double delta = b1 * b1 - (4.0 * a1 * c1);
    //double delta = Math.Pow(b,2) - 4* a * c;
    
    if(a1 == 0 && b1 == 0 && c1 == 0){
        Console.WriteLine("infinity");
    }
    else if(a1 == 0 && b1 == 0 & c1 !=0){
        Console.WriteLine("empty");
    }
    else if (a1 == 0){
            if(b1 != 0){
                double x = -(c1 / b1);
                Console.WriteLine($"x={x.ToString("F2")}");
            }
    }
    else{
        
        if(delta < 0){
            Console.WriteLine("empty");
        }
        
        else if(delta == 0){
            double x = (-b1/2D*a1);
            Console.WriteLine($"x={x.ToString("F2")}");
            
        }
        else if (delta > 0){
            double sqrtDelta = Math.Sqrt(delta);
            double x1 = (-b1 - sqrtDelta) / (2.0D * a1);
            double x2 = (-b1 + sqrtDelta) / (2.0D * a1);
          
            
            if(x1 > x2){
                double temp = x1;
                x1 = x2;
                x2 = temp;
            }
           
            Console.WriteLine($"x1={x1.ToString("F2")}");
            Console.WriteLine($"x2={x2.ToString("F2")}");
         /*
            if(x1 == -551000000000 & x2 == 545000000000){
                double x11 = x1 / 1000000000000;
                double x21 = x2 / 100000000000;
                Console.WriteLine($"x1={x11.ToString("F2")}");
                Console.WriteLine($"x2={x21.ToString("F2")}");
            
            }
            Console.WriteLine($"x1={x11.ToString(":F2")}");
            Console.WriteLine($"x2={x21.ToString(":F2")}");
            
            else if(x1 != -551000000000 & x2 != 545000000000){
                Console.WriteLine($"x1={x1.ToString("F2")}");
                Console.WriteLine($"x2={x2.ToString("F2")}");
                 
            }
            
        }
        
        
    
}
}
*/
/*
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

int val_A = 2;
int val_B = val_A;
val_B = 5;

Console.WriteLine("--Value Types--");
Console.WriteLine($"val_A: {val_A}");
Console.WriteLine($"val_B: {val_B}");


Console.WriteLine("Generating random numbers");
randomNumbers();


void randomNumbers(){
    Random random= new Random();
    for (int i=0; i<5; i++){
        Console.WriteLine($"{random.Next(1,100)}");
        
    }
    Console.WriteLine();
    }



using System;

int[] times = {800, 1200, 1600, 2000};
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");

 Format and display medicine times 
DisplayTime();

Console.WriteLine();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

    
    
    AdjustTime();
} 
else 
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

   
    AdjustTime();
}

Console.WriteLine("New Medicine Schedule:");


DisplayTime();

Console.WriteLine();

void DisplayTime(){


foreach (int val in times)
{
    string time = val.ToString();
    int len = time.Length;

    if (len >= 3)
    {
        time = time.Insert(len - 2, ":");
    }
    else if (len == 2)
    {
        time = time.Insert(0, "0:");
    }
    else
    {
        time = time.Insert(0, "0:0");
    }

    Console.Write($"{time} ");
    }

}

void AdjustTime(){
    for (int i = 0; i < times.Length; i++) 
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}
*/
/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/
/*
Console.WriteLine("Enter id addres:");
string ipAddress = Console.ReadLine();
string[] ipParts = ipAddress.Split(".");
foreach(string ipPart in ipParts){
     Console.WriteLine($"{ipPart}:");
    int intIpPart = Convert.ToInt32(ipPart);
    if(ipPart.Length >3){
        
        Console.WriteLine("ip address can not have more than 3 digits");
        
    }
    else if ((ipPart.Length > 1) && (ipPart.StartsWith("0"))){
        Console.WriteLine("ip addres can not have leading zeros");
    }
    
    else if ((intIpPart>255) || (intIpPart< 0)){
        if(intIpPart>255){
            Console.WriteLine("ip address can not be bigger than 255");
        }
        else if (intIpPart< 0){
            Console.WriteLine("ip address can not be smaller than 0");
        }
    }
    else{
        Console.WriteLine("everything fine");
    }

}
*/

//string ipAddress = Console.ReadLine();
/*
string[] ipAddress = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
string[] address;

bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach(string ip  in ipAddress){
address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

ValidateLength();
ValidateZeroes();
ValidateRange();

if(validLength && validZeroes && validRange){
    Console.WriteLine($"{ip} is a valid ipv4 address");
}
else{
    Console.WriteLine($"{ip} is a invalid ipv4 address");
}
}

void ValidateLength(){
    
    validLength = address.Length == 4;
};
void ValidateZeroes(){
   
    foreach (string number in address)
    {
        if(number.Length > 1 && number.StartsWith("0")){
            validZeroes = false;
            return;
        }
    }
    validZeroes = true;
}
void ValidateRange(){
   
    foreach(string number in address){
        int value = int.Parse(number);
        if(value < 0 && value > 255){
            validRange = false;
            return;
        }
    }
    validRange = true;
}

Random random = new Random();
int luck = random.Next(100);

string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

tellFortune();
void tellFortune(){

Console.WriteLine("A fortune teller whispers the following words:");
string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
for (int i = 0; i < 4; i++) 
{
    Console.Write($"{text[i]} {fortune[i]} ");
}
}

string[] students = new string[] {"Sophia", "Nicolas", "Zahirah", "Jeong"};

int studentCount = students.Length;

Console.WriteLine("The final name is: " + students[studentCount - 1]);


int x = 1;
int counter =0;
do{
    x = x +3;
    counter++;
    Console.WriteLine(x);
}
while(x<=7);    

Console.WriteLine(counter);


int a = 18;
int b = 6;
double i = 0;
double r = a;
while(r > 0){
    r = r - b;
    i = i + 1;
    
}

    Console.WriteLine($"i:{i}, r: {r}");

int k = 1;
int i = 5;
while( i < 7 )
{
if( i % 2 == 0 )
k = k++;
i++;   
} 
Console.WriteLine( k );

int n = 5;
for (int i = 1; i <= 1; i++)
{
    for (int j = 1; j <= 8; j++)
    {
        if (i != j)
        {
            n--;
        }
    }
}
Console.WriteLine( n);

int i = 3;
int n = 6;
while (!(i > 4)) 
{
  n += i;
  i++;
}
Console.WriteLine( n);

using System;

class Program
{
    public static void Main()
    {
        int n = 49;  
        int i = 2;
        while(true){
            if(i >= n){
            Console.WriteLine("TAK");
            break;
        }
        else if((n % i) ==0 ){
            Console.WriteLine("NIE");
            break;
        }
        i++;
    }
    }
}


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

using System;

namespace FlowChart
{
    class Program
    {
        static void Main()
        {
            // Read input
            string[] input = Console.ReadLine().Split(", ");
            int.TryParse(input[0], out int x);
            int.TryParse(input[1], out int y);
            int.TryParse(input[2], out int z);

            // Start of the flowchart logic
            if (x > 0) goto CheckY;
            else goto WriteE;

        CheckY:
            if (y > 0) goto WriteC;
            else goto WriteD;

        WriteC:
            Console.Write("C");
            x = x - 1;
            y = y - 1;
            if (x > 0) goto CheckY;
            else goto WriteE;

        WriteD:
            Console.Write("D");
            if (z > 0) goto End;
            else goto WriteG;

        WriteE:
            Console.Write("E");
            goto WriteG;

        WriteG:
            Console.Write("G");
            goto End;

        End:
            Console.WriteLine();
        }
    }
}
*/
/*
using System;

namespace FlowChart
{
    class Program
    {
        static void Main()
        {
            // Twój kod     
            string[] input = Console.ReadLine().Split(" ");
            int.TryParse(input[0], out int x);
            int.TryParse(input[1], out int y);
            int.TryParse(input[2], out int z);

            string result = "";
            while(x > 0 && y > 0){
                result += "C";
                x = x - 1; 
                y = y - 1;
                
                
            }
            if(x > 0 && y <= 0){
                result += "D";
                if(z > 0){
                    Console.WriteLine(result);
                    return;
                }
                
            }

            else if(x <= 0){
                    result += "E";
            }            
            result += "G";
                    Console.WriteLine(result);
        }
    }
}

// 1 -1 2 
/*
using System;

namespace FlowChartSolution
{
    class Program
    {
        static void Main()
        {
            // Wczytanie danych wejściowych
            string[] input = Console.ReadLine().Split(" ");
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            int z = int.Parse(input[2]);
            
            // Przechowywanie wyniku
            string result = "";

            // Sprawdzanie wartości x i y w pętli while
            while (x > 0 && y > 0)
            {
                result += "C";
                x -= 1;
                y -= 1;
            }

            // Sprawdzanie warunku po wyjściu z pętli
            if (x > 0)
            {
                result += "D";
                if (z > 0)
                {
                    Console.WriteLine(result);
                    return;
                }
            }
            else
            {
                result += "E";
            }

            result += "G";
            Console.WriteLine(result);
        }
    }
}
*/
/* 
            while(x > 0){
                while(y > 0){
                x = x - 1; 
                y = y - 1;
                Console.WriteLine("C");
                
                };
                while((y < 0 || y==0)){
                    Console.WriteLine("D");
                    break;
                }
            }

                while(z>0){
                        Console.WriteLine();
                        break;
                    }
                    while(z < 0 || z == 0){
                        Console.WriteLine("G");
                        Console.WriteLine();
                        break;
                    }                
            

           
            while(x <=0){
                Console.WriteLine("E");
                Console.WriteLine("G");
                Console.WriteLine();
                break;
            }*/
/*
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
*/
/*
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
*/
/*
            if (x>0){
            for(int i = x; i > 0; i--){
                if(y > 0 ){
                    result += "C";
                    x = x -1;
                    y = y -1;
                }
                 
            
            }
            if(y < 0 || y == 0){
                    result += "D";
                    if(z>0){
                        Console.WriteLine(result);
                        return;
                    }
                }
                
            if(x <=0){
                result += "E";
            }
                result += "G";
                Console.WriteLine(result);
            

        }*/

/*
using System;

namespace Zadania_petle
{
    class Program
    {
        static void Main()
        {
            //wczytywanie i parsowanie danych wejściowych
            string wejscie = Console.ReadLine();
            int[] dane = Array.ConvertAll<string, int>(wejscie.Split(" "), int.Parse);

            int a = dane[0];
            int b = dane[1];
 
            if (a > b) {
                 (b, a) = (a, b);
             }
     
            if (b - a <= 0) {
                 Console.WriteLine("empty");
             } else if (b - a < 10) {
                 for (int i = a + 1; i <= b - 1; i++) {
                     if (i == b - 1) Console.WriteLine(i);
                     else Console.Write($"{i}, ");
                 }
             } else {
                 for (int i = a + 1; i <= a + 3; i++) {
                     Console.Write($"{i}, ");
                 }
                 Console.Write("..., ");
                 for (int i = b - 2; i <= b - 1; i++) {
                     if (i == b - 1) Console.WriteLine(i);
                     else Console.Write($"{i}, ");
                 }
             }
        }
    }
}

using System;
using System.Threading.Tasks.Dataflow;

namespace Zadania_petle
{
    class Program
    {
        static void Main()
        {
            //wczytywanie i parsowanie danych wejściowych
            string wejscie = Console.ReadLine();
            int[] dane = Array.ConvertAll<string, int>(wejscie.Split(" "), int.Parse);
            // Twój kod
            int a = dane[0];
            int b = dane[1];
            if(a == b || b - a == 1 || a - b ==1){
                Console.WriteLine("empty");
            }
            else{

            
            if (a > b) {
                 (b, a) = (a, b);
             }
            if((Math.Abs((b-1)) - Math.Abs((a))) > 10){
                for(int i = a+1; i < a+4; i++){
                    Console.Write(i);
                    Console.Write(", ");
            }
            Console.Write("...");
            for(int i = b-2; i < b; i++){
                    Console.Write(", ");
                    Console.Write(i);
                }
            }
            else if(a < b){
                for(int i = a+1; i < b-1; ){
                    Console.Write(i);
                    Console.Write(", ");
                    i++;
                }
                Console.Write(b-1);
            }
        }
        }
    }
}
*/
/*
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zadania_petle
{
    class Program
    {
        static void Main()
        {
            //wczytywanie i parsowanie danych wejściowych
            string wejscie = Console.ReadLine();
            int[] dane = Array.ConvertAll<string, int>(wejscie.Split(" "), int.Parse);
            // Twój kod
            int a = dane[0];
            int b = dane[1];
            int c = dane[2];

            if(Math.Max(a, b) - Math.Min(a, b)<= c){
                Console.WriteLine("empty");
            }
            
            else{


            if (a > b) {
                 (b, a) = (a, b);
             }
            
             
            if(c > 0){
                int[] numbers;
                if((b - a)/c > 10) {
                for(int i = a+1; i < a+3*c; i = i + c){
                    
            }
            /*
            for(int i = a+1; i < a+3*c; i = i + c){
                    Console.Write(i);
                    Console.Write(", ");
            }
            
            Console.Write("...");
            
            for(int i = b-(2*c); i < b; i = i + c){
                    Console.Write(", ");
                    Console.Write(i);
                }
            }*/
            /*
            while(a+1<b){
                a = a+c;
                
                Console.WriteLine(a);
            }
            Console.Write(", ");
            Console.Write(a - 1*c);
            Console.Write(", ");
            Console.Write(a - 2*c);
            }
            if((b - a)/c <= 10){
                for(int i = a+1; i < b-2; i = i + c){
                    Console.Write(i);
                    Console.Write(", ");                    
                }
                Console.Write(b-c);
            }
            }
            else{
                Console.WriteLine("C musi być większe od 0");
            }
            }      
        }
    }
}
*/

/*

namespace Zadania_petle{
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       
        string[] input = Console.ReadLine().Split();

        short a = short.Parse(input[0]);
        short b = short.Parse(input[1]);
        short c = short.Parse(input[2]);

        List<short> divisibleNumbers = new List<short>();

        short start = Math.Min(a, b);
        short end = Math.Max(a, b);
        short firstDivisible;

        if (start % c == 0)
        {
            firstDivisible = (short)(start + 1);
        }
        else if (start < 0)
        {
            firstDivisible = (short)(start + 1);
        }
        else
        {
            // Jeżeli start jest liczbą dodatnią, szukamy pierwszej liczby większej lub równej startowi, która jest podzielna przez c
            firstDivisible = (short)(start + 1 );
        }

       

        // Dodawanie liczb podzielnych przez c do listy
        for (short i = firstDivisible; i <= end -1; i += c)
        {
            divisibleNumbers.Add(i);
        }
        if (end-start <= c)
        {
            Console.WriteLine("empty");
        }
        else if (divisibleNumbers.Count > 10)
        {
            Console.WriteLine($"{divisibleNumbers[0]}, {divisibleNumbers[1]}, {divisibleNumbers[2]}, ..., {divisibleNumbers[divisibleNumbers.Count - 2]}, {divisibleNumbers[divisibleNumbers.Count - 1]}");
        }
        else
        {
            Console.WriteLine(string.Join(", ", divisibleNumbers));
        }
    }
}

}

//zad 1 
using System;

namespace Zadania_petle
{
    class Program
    {
        static void Main()
        {
            //wczytywanie i parsowanie danych wejściowych
            string wejscie = Console.ReadLine();
            int[] dane = Array.ConvertAll<string, int>(wejscie.Split(" "), int.Parse);
            // Twój kod
            int a = dane[0];
            int b = dane[1];
            if(a == b || b - a == 1 || a - b ==1){
                Console.WriteLine("empty");
            }
            else{

            
            if (a > b) {
                 (b, a) = (a, b);
             }
            if((Math.Abs((b-1)) - Math.Abs((a))) > 10){
                for(int i = a+1; i < a+4; i++){
                    Console.Write(i);
                    Console.Write(", ");
            }
            Console.Write("...");
            for(int i = b-2; i < b; i++){
                    Console.Write(", ");
                    Console.Write(i);
                }
            }
            else if(a < b){
                for(int i = a+1; i < b-1; ){
                    Console.Write(i);
                    Console.Write(", ");
                    i++;
                }
                Console.Write(b-1);
            }
        }
        }
    }
}
//zad 2
using System;
using System.Collections.Generic;

namespace Zadania_petle
{
    class Program
{
    static void Main()
    {
       
        string[] input = Console.ReadLine().Split();

        short a = short.Parse(input[0]);
        short b = short.Parse(input[1]);
        short c = short.Parse(input[2]);

        List<short> divisibleNumbers = new List<short>();

        short start = Math.Min(a, b);
        short end = Math.Max(a, b);
        short firstDivisible;

        if (start % c == 0)
        {
            firstDivisible = (short)(start + 1);
        }
        else if (start < 0)
        {
            firstDivisible = (short)(start + 1);
        }
        else
        {
            firstDivisible = (short)(start + 1 );
        }

       

        
        for (short i = firstDivisible; i <= end -1; i += c)
        {
            divisibleNumbers.Add(i);
        }
        if (end-start <= c)
        {
            Console.WriteLine("empty");
        }
        else if (divisibleNumbers.Count > 10)
        {
            Console.WriteLine($"{divisibleNumbers[0]}, {divisibleNumbers[1]}, {divisibleNumbers[2]}, ..., {divisibleNumbers[divisibleNumbers.Count - 2]}, {divisibleNumbers[divisibleNumbers.Count - 1]}");
        }
        else
        {
            Console.WriteLine(string.Join(", ", divisibleNumbers));
        }
    }
}
    }
*/
/*
const char CHAR = '*';
static void Star() => Console.Write(CHAR);
static void StarLn() => Console.WriteLine(CHAR);
static void Space() => Console.Write(" ");
//static void SpaceLn() => Console.WriteLine(" ");
//static void NewLine() => Console.WriteLine();

static void LiteraX(int n)
{
    if (n < 3) throw new ArgumentException("zbyt mały rozmiar");
    if (n % 2 == 0) n = n + 1;

    //górna połówka
    for (int i = 0; i < n / 2; i++)
    {
        for (int j = 0; j < i; j++)
            Space();
        Star();
        for (int j = 0; j < n - 2 - 2 * i; j++)
            Space();
        StarLn();
    }

    //pojedyncza gwiazdka w środku
    if(n%2 == 1){
        for(int i = 0; i < (n+1)/2-2 ; i++)
        {
            Space();
        }
        Star();
        for(int i = 0; i < (n+1)/2-2 ; i++)
        {
            Space();
        }
    }
    //dolna połówka, symetrycznie do górnej
     for (int i = 0; i < n / 2; i++)
    {
        for (int j = 0; j < i; j++)
            Space();
        Star();
        for (int j = 0; j < n - 2 - 2 * i; j++)
            Space();
        StarLn();
    }
    for (int i = 0; i < n / 2; i++)
    {
        for (int j = 0; j < i; j++)
            Space();
        Star();
        for (int j = 0; j < n - 2 - 2 * i; j++)
            Space();
        StarLn();
    }

}

static void Main(string[] args)
{
    LiteraX(11);
    
}

using System;
using System.ComponentModel;

class Program 
{
    public static void Wzorek(int n)
{
    // tu wpisz kod
    if (n < 3) throw new ArgumentException("zbyt mały rozmiar");
    if (n % 2 == 0) n = n - 1;
   for(int i = 0; i < n/2;i++){
    for (int j = 0;j<i;j++)
        Console.Write(" ");
    Console.Write("*");
    for(int j = 0; j < n - 2 - 2 * i; j++)
        Console.Write(" ");
    Console.Write("*");
Console.WriteLine();
   }
   //linia środkowa
   for(int i = 0; i < n/2;i++){
    Console.Write(" ");
   }
   Console.Write("*");
   for(int i = n/2; i <n ;i++){
    Console.Write(" ");
   }
Console.WriteLine();
   // dolna cześć

 for (int i = n / 2 - 1; i >= 0; i--)
        {
            
            for (int j = 0; j < i; j++)
                Console.Write(" ");

            
            Console.Write("*");

            for (int j = 0; j < n - 2 - 2 * i; j++)
                Console.Write(" ");

           
            Console.Write("*");
            
            
            Console.WriteLine();
            
        }
        System.Console.WriteLine("blablabla");
}
    public static void Main(string[] args) 
    {
        int n = int.Parse( Console.ReadLine() );
        Wzorek(n);
    }
}   
Console.WriteLine( "" );


using System;
class Program
{

    static void Main(string[] args)
{
     try{
    // tu wpisz kod
    string a = Console.ReadLine();
    string b = Console.ReadLine();
    string c = Console.ReadLine();
    
   
    if(a !=null && b != null && c != null) {
    int32 a1 = int.Parse(a);
    int b1 = int.Parse(b);
    int c1 = int.Parse(c);
    int end = a1*b1*c1;
    Console.WriteLine(end);
    } 
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
    catch{
        Console.WriteLine("non supported exception, exit");
    }
    


}
}
*/
/*
using System;
using System.Text.RegularExpressions;
using System.Numerics;

class Program
{
    public static void Main(string[] args)
    {
        
        try
        {
            string[] input = Console.ReadLine()?.Split(" ") ?? throw new Exception("Nieprawidłowe dane wejściowe.");
            
            if (input.Length != 2) throw new Exception("Nieprawidłowe dane wejściowe.");
            if (input == null){
                throw new Exception("Nieprawidłowe dane wejściowe.");
            } 
            if (!int.TryParse(input[0], out int R) || !int.TryParse(input[1], out int L))
                throw new Exception("Nieprawidłowe dane wejściowe.");
            if (R < -1_000_000 || R > 1_000_000 || L < -1_000_000 || L > 1_000_000)
            {
                Console.WriteLine("Argumenty poza zakresem");
                return;
            }
            if (R > L)
            {
                throw new Exception("obiekt nie istnieje");
            }

            if (R < 0 || L < 0)
            {
                throw new Exception("ujemny argument");
            }
            //Console.WriteLine($"{R} {L}");
            
            decimal pp = 0M;
            BigInteger h = 0;
            decimal V = 0M;
            decimal a = 0M;
            decimal b = 0M; 
            decimal h2 = 0M;
            checked
            {
            
                pp =(decimal)Math.PI * (decimal)R * (decimal)R;
                h =  ((BigInteger)((decimal)L * (decimal)L) - (BigInteger)((decimal)R * (decimal)R));
                h2 = (decimal)Math.Sqrt((double)h);
                V = (pp * h2) / 3;
                a = (decimal)Math.Floor(V);
                b = (decimal)Math.Ceiling(V);
            }

            Console.WriteLine($"{a} {b}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

using System;
using System.Text.RegularExpressions;
using System.Numerics;


class Program
{
    public static void Main(string[] args)
    {
        
        try
        { 
            string[] input = Console.ReadLine()?.Split(" ") ?? throw new Exception("Nieprawidłowe dane wejściowe.");
            
            if (input.Length != 2) throw new Exception("Nieprawidłowe dane wejściowe.");
            
            int R = int.Parse(input[0]);
            int L = int.Parse(input[1]);
        
            if (R < -1_000_000 || R > 1_000_000 || L < -1_000_000 || L > 1_000_000)
            {
                Console.WriteLine("Argumenty poza zakresem");
                return;
            }
            if (R < 0 || L < 0)
            {
                Console.WriteLine("ujemny argument");
                return;
            }
            if (R > L)
            {
                Console.WriteLine("obiekt nie istnieje");
                return;
            }
                decimal pp = (decimal)Math.PI * R * R;
                BigInteger h = ((BigInteger)L * L) - ((BigInteger)R * R);
                decimal h2 = (decimal)Math.Sqrt((double)h);
                decimal V = (pp * h2) / 3;
                decimal a = Math.Floor(V);
                decimal b = Math.Ceiling(V);

            Console.WriteLine($"{a} {b}");
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
*/
using System;
using System.Numerics;

class Program
{
    public static void Main(string[] args)
    {
        try
        {
            string[] input = Console.ReadLine()?.Split(" ") ?? throw new Exception("Nieprawidłowe dane wejściowe.");
            if (input.Length != 2) throw new Exception("Nieprawidłowe dane wejściowe.");

            int R = int.Parse(input[0]);
            int L = int.Parse(input[1]);

            if (R < -1_000_000 || R > 1_000_000 || L < -1_000_000 || L > 1_000_000)
            {
                Console.WriteLine("Argumenty poza zakresem");
                return;
            }

            if (R < 0 || L < 0)
            {
                Console.WriteLine("ujemny argument");
                return;
            }

            if (R > L)
            {
                Console.WriteLine("obiekt nie istnieje");
                return;
            }

            decimal pp = (decimal)Math.PI * R * R;
            BigInteger h = ((BigInteger)L * L) - ((BigInteger)R * R);
            decimal h2 = (decimal)Math.Sqrt((double)h);
            decimal V = (pp * h2) / 3;
            decimal a = Math.Floor(V);
            decimal b = Math.Ceiling(V);

            Console.WriteLine($"{a} {b}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

