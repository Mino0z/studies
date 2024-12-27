#Polecenie zadania

Napisz program, który wczyta ze standardowego wejścia prostokątną tablicę liczb całkowitych, a następnie wypisze indeks kolumny o największej sumie. Jeśli kolumn z największą sumą będzie więcej, wypisze indeks najmniejszy. Przyjmujemy 0-based indexing.

Na wejściu, w kolejnych liniach (wartość nieokreślona) podane będą jednakowej długości ciągi liczb całkowitych (liczby jednocyfrowe, oddzielone jedną spacją).
Na wyjściu: jedna liczba całkowita określająca indeks kolumny o największej sumie (pierwszy).

Podpowiedź:

1) ponieważ nie wiesz, ile wierszy będzie liczyła tablica danych, musisz skorzystać z dynamicznej struktury danych. Najwygodniejszą wydaje się lista tablic List<int[]>, której później można używać w podobny sposób, jak dla tablic dwuwymiarowych. Odczytując kolejne wiersze możesz je splitować do tablicy liczb całkowitych, a następnie tę tablicę doklejać do listy (Add). Gdy wczytasz wszystkie dane możesz odwoływać się do jej konkretnych elementów za pomocą indeksowania [i][j].

2) innym sposobem rozwiązania problemu może być wykorzystanie koncepcji jagged_array oraz metody Array.Resize().

For example:

Input	Result
1 2 3 4
1 1 1 1
|
3
|
1 3
3 2
|
1
|
1
2
3
|
0