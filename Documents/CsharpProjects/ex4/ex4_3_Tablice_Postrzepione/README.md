#Polecenie Zadania
Zadanie dotyczy tablic postrzępionych w C# (jagged arrays).

Napisz metody (nie program) o sygnaturach:

static char[][] ReadJaggedArrayFromStdInput() - z pierwszej linii standardowego wejścia wczytuje liczbę wierszy (<10), następnie wczytuje kolejne wiersze składające się ze znaków oddzielonych pojedynczą spacją. Jako wynik swojego działania zwraca wczytane dane w formie tablicy postrzępionej (patrz sygnatura),
static char[][] TransposeJaggedArray(char[][] tab) - transponuje tablicę, zwracając nową, w której kolumny stają się wierszami, zaś wiersze kolumnami,
static void PrintJaggedArrayToStdOutput(char[][] tab) - wypisuje na standardowe wyjście tablicę wierszami w kolejnych liniach.

Przy implementacji sugeruj się podanymi przykładami.

Możesz utworzyć inne metody, które uznasz za pomocne, ale musisz zaprogramować podane powyżej dokładnie z taką sygnaturą.

Twoje implementacje metod testowane będą w metodzie Main (nie pisz jej!!) w następujący sposób:

static void Main(string[] args)
{
    char[][] jagged = ReadJaggedArrayFromStdInput();
    PrintJaggedArrayToStdOutput(jagged);
    jagged = TransposeJaggedArray(jagged);
    Console.WriteLine();
    PrintJaggedArrayToStdOutput(jagged);
}
For example:

Input	Result
3
a b c d e
a b
a b c
a b c d e
a b
a b c

a a a
b b b
c   c
d
e
