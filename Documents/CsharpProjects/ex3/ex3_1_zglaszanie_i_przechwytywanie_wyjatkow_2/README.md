#Polecenie Zadania 

Napisz program, który:

ze standardowego wejścia wczyta 3 napisy, podane w oddzielnych liniach,
przekonwertuje te napisy na liczby całkowite (typu int)
obliczy iloczyn tych trzech liczb całkowitych (działanie w typie int) i wypisze wynik na standardowe wyjście (o ile nie zostaną zgłoszone wyjątki).
Twój program nie może zostać przerwany z powodu wyjątków, które mogą zostać zgłoszone podczas jego działania. Przechwyć je i wypisz na standardowe wyjście stosowny komunikat:

gdy zgłoszony zostanie inny wyjątek niż podane poniżej, wypisz tekst non supported exception, exit
gdy zgłoszony zostanie wyjątek FormatException wypisz tekst format exception, exit
gdy zgłoszony zostanie wyjątek ArgumentException wypisz tekst argument exception, exit
gdy zgłoszony zostanie wyjątek OverflowException wypisz tekst overflow exception, exit
For example:
Input	Result
2
3
4 |
24 ;
1
2
|
argument exception, exit ;
2.1
1
2 |
format exception, exit;
1127531753753751275371253
2
3 |
overflow exception, exit ;
00234
1
2 |
468 ;
2,234
1
2 |
format exception, exit
