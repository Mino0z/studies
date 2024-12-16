#Polecenie Zadania

Napisz program, który wczyta ze standardowego wejścia prostokątną planszę gry Saper (ang. minswepper), a następnie wprowadzi do odpowiednich komórek planszy liczby określające liczbę przylegających min.

Przyjmujemy, że plansza jest prostokątem o zadanych rozmiarach (nie większych niż 8) składającym się z komórek, do których wprowadzone są znaki:

kropki . oznaczającej pole nieodsłonięte,
gwiazdki * oznaczającej minę,
cyfry oznaczającej liczbę przylegających min.
Twoim zadaniem jest "odsłonić" całą planszę. Przyjmujemy, że jeśli komórka nie przylega do żadnej miny, pozostawiamy znak kropki. Sugeruj się podanymi przykładami.

Na wejściu, w pierwszym wierszu podane są dwie liczby oddzielone jedną spacją, określające wymiary planszy: liczbę wierszy i liczbę kolumn odpowiednio
W kolejnych wierszach "narysowana" jest plansza gry za pomocą kropek i gwiazdek
Na wyjściu wypisana jest plansza, zapełniona w odpowiedni sposób liczbami.
For example:

Input	Result
4 5
.*.*.
..*..
..*..
.....
|
1*3*1
13*31
.2*2.
.111.
|
4 4
|
*...
....
.*..
....
|
*1..
221.
1*1.
111.
|
3 5
|
**...
.....
.*...
|
**1..
332..
1*1..