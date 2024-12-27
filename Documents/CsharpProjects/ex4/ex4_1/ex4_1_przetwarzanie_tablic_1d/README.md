#Polecenie zadania 

Dane są dwie niepuste tablice liczb całkowitych int[] a oraz int[] b. Liczby zapamiętane w tych tablicach są posortowane w porządku niemalejącym.

Napisz procedurę o sygnaturze

public static void Print(int[] a, int[] b)

wypisującą na standardowe wyjście, w porządku rosnącym, te liczby z tablicy a, których nie ma w tablicy b.

Nie wypisuj duplikatów.

Liczby wypisz w jednej linii, oddzielając je pojedynczą spacją.

W przypadku braku liczb spełniających warunki zadania wypisz słowo empty.

⚠️ Rozwiąż zadanie wykorzystując metody przeglądania tablic. Zabronione jest używanie kolekcji oraz technologii LINQ.

For example:

Input	Result
a = new int[] {-2, -1, 0, 1, 4};
b = new int[] {-3, -2, -1, 1, 2, 3};
| 
0 4 ;

a = new int[] {-2, -1, 0, 1, 4};
b = new int[] {-2, -1, 0, 1, 4, 5, 6};
|
empty