#Polecenie Zadania
Klasa Czas24h

Jesteś praktykantem w firmie informatycznej. Otrzymałeś zadanie zmodyfikowania klasy Czas24h napisanej w języku C#.

Obiekty klasy Czas24h reprezentują czas, t.j.: godzinę, minutę i sekundę w zapisie 24-godzinnym, w formacie h:mm:ss (np. 2:20:05). 

Wewnętrznie czas jest zapamiętany jako liczba sekund, które upłynęły od godziny początkowej 0:00:00 - w prywatnym polu liczbaSekund (patrz kod).

Twoim zadaniem jest zmodyfikować załączony kod klasy Czas24h tak, aby:

w konstruktorze nie dopuścić do utworzenia obiektu - zgłaszając wyjątek ArgumentException - w sytuacji przekazania niewłaściwych danych. Dopuszczalne wartości parametrów to: 0..59 dla sekund i minut, 0..23 dla godzin,
obiekty klasy Czas24h były zmiennicze (mutable) poprzez poprawne zdefiniowanie properties typu set dla godzin, minut i sekund (patrz kod).

nie wolno modyfikować istniejącego kodu - jedynie uzupełniasz brakujące fragmenty (wskazane komentarzem).

Poniżej załączono kod klasy Czas24h, który będziesz modyfikować.

public class Czas24h
{
    private int liczbaSekund;

    public int Sekunda
    {
        get => liczbaSekund - Godzina * 60 * 60 - Minuta * 60;
        // uzupełnij kod - zdefiniuj setters'a
    }

    public int Minuta
    {
        get => (liczbaSekund / 60) % 60;
        // uzupełnij kod - zdefiniuj setters'a
    }

    public int Godzina
    {
        get => liczbaSekund / 3600;
        // uzupełnij kod - zdefiniuj setters'a
    }

    public Czas24h(int godzina, int minuta, int sekunda)
    {
        // uzupełnij kod zgłaszając wyjątek ArgumentException
        // w sytuacji niepoprawnych danych

        liczbaSekund = sekunda + 60 * minuta + 3600 * godzina;
    }

    public override string ToString() => $"{Godzina}:{Minuta:D2}:{Sekunda:D2}";
}

Specyfikacja wypisywanego wyniku
w przypadku wczytania niepoprawnych danych (przy tworzeniu obiektu typu Czas24h lub przy jego modyfikacji), program wypisuje tekst error. Twoim zadaniem jest tylko zgłosić wyjątek ArgumentException.

w przypadku poprawnych danych program wypisuje aktualny czas po wykonaniu wszystkich poleceń testowych, w formacie h:mm:ss.

Weryfikowane umiejętności
czytanie/analizowanie kodu
arytmetyka modulo
konwersje typów, rzutowanie
Ocenianie
Ocena końcowa jest % liczby poprawnie zaliczonych testów.

For example:
Test	Result
// Test 1
var t = new Czas24h(2, 15, 37);
t.Minuta = 20;
t.Godzina = 1;
t.Sekunda = 26;
Console.WriteLine(t);
1:20:26
// Test 2
var t = new Czas24h(2, 15, 37);
t.Minuta = 20;
t.Godzina = 24;
Console.WriteLine(t);
error
// Test 3
var t = new Czas24h(2, 15, 37);
t.Minuta = -20;
t.Godzina = 23;
Console.WriteLine(t);
error
// Test 4
var t = new Czas24h(2, 15, 37);
t.Minuta = 20;
t.Godzina = 23;
t.Godzina = 1;
t.Sekunda = 15;
t.Minuta = 10;
t.Sekunda = 23;
t.Sekunda = 1;
t.Minuta = 12;
Console.WriteLine(t);
1:12:01
// Test 5
var t = new Czas24h(24, 15, 37);
t.Minuta = 20;
t.Godzina = 23;
t.Godzina = 1;
Console.WriteLine(t);