#Polecenie Zadania 

Twoim zadaniem jest napisanie w języku C# programu szacującego objętość (V) stożka obrotowego prostego o zadanym promieniu (R) i tworzącej (L).

W sytuacji błędnych danych, uniemożliwiających stworzenie stożka, program ma zwrócić stosowną informację o błędzie (patrz specyfikacja).

Wejście:
Dwie liczby całkowite, kolejno R oraz L z zakresu od -106 do 106, oddzielone spacją.

Wyjście:
Dwie nieujemne liczby całkowite a, b oddzielone spacją takie, że:

0 ≤ a ≤ b
a jest dolnym ograniczeniem V, czyli największą liczbą całkowitą nie większą niż V
b jest górnym ograniczeniem V, czyli najmniejszą liczbą całkowitą nie mniejszą niż V
Jeśli którykolwiek z zadanych argumentów jest liczbą ujemną, zamiast przedziału program zwraca tekst: ujemny argument.

Jeśli argumenty uniemożliwiają geometryczne skonstruowanie stożka, zamiast przedziału program zwraca tekst: obiekt nie istnieje.

Przyjmujemy możliwość istnienia stożka "trywialnego" (sprowadzonego do punktu, odcinka, koła, ...) o objętości 0.

Weryfikowane umiejętności:
odczyt i zapis - standardowe wejście/wyjście
budowanie formuł matematycznych, wykorzystanie matematycznych funkcji bibliotecznych
dobieranie właściwych typów danych do realizowanych obliczeń, konwersje, rzutowania
wnioskowanie, warunkowy wybór
przechwytywanie (zgłaszanie) wyjątków
Ocenianie:
Ocena końcowa jest % zaliczonych testów.
UWAGA: część testów jest ukrytych i w przypadku nie zaliczenia ich nie zostaną wyświetlone. Sam musisz, poprzez być może wielokrotne próby, dotrzeć do przyczyny nie zaliczenia programu w 100%. Podpowiedź: błąd reprezentacji, błędy zaokrągleń, overflow, ....

For example:

Input	Result
3 4 | 
24 25 ;

4 3 |
obiekt nie istnieje ;

-1 2 |
ujemny argument;

2 2 | 
0 0 ;

