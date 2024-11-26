#Polecenie Zadania 

Napisz procedurę, o sygnaturze public static void Wzorek(int n)

która dla zadanego argumentu, wypisze na konsoli wzorek podany jako przykład. Procedura ma mieć własność „skalowalności”, tzn. dla różnych wartości parametrów ma wypisywać różnej wielkości, ale poprawnie wyglądające wzorki.

Przyjmij, że argument n jest nie mniejszy niż 3. Jeśli n jest parzyste, przyjmij wartość o 1 mniejszą (wtedy n będzie liczbą nieparzystą).

⚠️ W kodzie nie możesz wykorzystać struktur tablicowych (a więc nawiasów kwadratowych [ oraz ]). Próba ich wykorzystania przerwie kompilację.

⚠️ Nie piszesz programu, tylko treść procedury! Możesz (ale nie musisz) umieścić kod pomocniczy, który można wykorzystać w procedurze Wzorek. Twój kod zostanie "wstrzyknięty" w kod klasy Program zawierającej już metodę Main, na przykład tak:

using System;

class Program 
{
    {{ STUDENT_ANSWER }}
    public static void Main(string[] args) 
    {
        int n = int.Parse( Console.ReadLine() );
        Wzorek(n);
    }
} 
For example:

Input	Result
7

*     *
 *   *
  * *
   *
  * *
 *   *
*     *

8

*     *
 *   *
  * *
   *
  * *
 *   *
*     *

3

* *
 *
* *