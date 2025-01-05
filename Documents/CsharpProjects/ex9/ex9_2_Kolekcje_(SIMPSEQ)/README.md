#Polecenie Zadania

Dane są dwie niepuste tablice liczb całkowitych int[] a oraz int[] b. Liczby zapamiętane w tych tablicach są posortowane w porządku niemalejącym.

Napisz procedurę o sygnaturze

public static void Print(int[] a, int[] b)
wypisującą na standardowe wyjście, w porządku rosnącym, te liczby z tablicy a, które również są w tablicy b.

Nie wypisuj duplikatów.
Liczby wypisz w jednej linii, oddzielając je pojedynczą spacją.
W przypadku braku liczb spełniających warunki zadania wypisz słowo empty.
⚠️ Rozwiąż zadanie wykorzystując standardowe kolekcje z przestrzeni nazw System.Collections.Generic. Zabronione jest używanie pętli (for, foreach, while) oraz technologii LINQ. Aby przygotować wynik do wydruku użyj metody string.Join().

For example:

Input	Result
a = new int[] {-2, -1, 0, 1, 4};
b = new int[] {-3, -2, -1, 1, 2, 3};
-2 -1 1
a = new int[] {1, 2, 3};
b = new int[] {-3, -2, -1};
empty
