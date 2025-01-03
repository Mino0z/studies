#Polecenie Zadania

Jesteś poproszony o zamodelowanie klas dla aplikacji przechowującej dane osób. Musisz przewidzieć, że będziesz przechowywał informacje na temat osób dorosłych i dzieci. Dzieci dziedziczą pewne cechy od swoich rodziców.

Tworzysz:

klasę Person – będąca klasą bazową z której pozostałe klasy dziedziczą.
Osoba ma imię (FirstName) i nazwisko (FamilyName).

Imię i nazwisko są pojedynczymi wyrazami (nie zawierają spacji), składają się wyłącznie z liter, zaczynają się od dużej litery, zaś pozostałe są literami małymi. Stosowne korekty wprowadź w chwili przypisywania wartości (usuń spacje, skoryguj format "duża litera-małe litery"). Jeśli napis miałby zawierać znaki, które nie są literami, lub byłby pusty zgłoś wyjątek typu ArgumentException z komunikatem "Wrong name!".

Wiek osoby nie może być ujemny (zgłoś wyjątek ArgumentException z komunikatem "Age must be positive!").

Zdefiniuj właściwości FirstName, FamilyName oraz Age w klasie Person, publiczne do odczytu i chronione do zapisu (dostępne tylko z poziomu klasy i klas dziedziczących).
Zdefiniuj konstruktor, akceptujący parametry firstName, familyName oraz age.

Zdefiniuj tekstową reprezentację obiektu, zwracającą napis w formacie {firstName} {familyName} ({age})
Zdefiniuj metody modyfikujące imię, nazwisko oraz wiek, o dostępie publicznym i o nazwach: modifyFirstName, modifyFamilyName, modifyAge.

klasę Child - będącą klasą dziedziczącą z klasy Person i dodatkowo spełniającą warunki:
Zawiera referencje na rodziców: matkę (mother) oraz ojca (father). Referencje te ustawiane są w momencie konstrukcji obiektu i nie mogą być już nigdy zmienione. Jeśli nie są znani rodzice dziecka, przypisz referencjom null.

Dziecko nie może mieć wieku większego niż 15 lat (zgłoś wyjątek ArgumentException z komunikatem "Child’s age must be less than 15!").

Modyfikacja wieku dziecka możliwa jedynie w zakresie od 0 do 15 lat.

Tekstowa reprezentacja obiektu:
w pierwszej linii jak dla klasy Person

w drugiej linii dane matki w formacie "mother: {firstName} {FamilyName} ({age})". Jeśli matka nie jest znana "mother: no data"

w trzeciej linii dane ojca w formacie "father: {firstName} {FamilyName} ({age})". Jeśli ojciec nie jest znany "father: no data"

Pozostałe wymagania odczytasz z przypadków testowych. Musisz zapisać kod tak, aby każdy z przypadków się kompilował oraz produkował oczekiwane wyniki.

UWAGA: Do oceny przesyłasz kod klas Person oraz Child, ewentualnie poprzedzony dyrektywami using. Nie umieszczasz go w żadnej przestrzeni nazw. 
Twój kod (STUDENT_ANSWER) zostanie osadzony w podanym szkielecie, następnie całość zostanie skompilowana i uruchomiona - dla każdego przypadku testowego oddzielnie:
using System;
namespace MyProg 
{
  // STUDENT_ANSWER

  public class Program
  {
    public static void Main(string[] args) 
    {
      // TEST.testcode
    }
  }
}
For example:
Test	Result
/* Test: poprawne tworzenie obiektu Person, dane poprawne */
try
{
    Person p = new Person(familyName: "Molenda", firstName: "Krzysztof", age: 18);
    Console.WriteLine(p);
}
catch( Exception e)
{
    Console.WriteLine(e.Message);
}
Krzysztof Molenda (18)
/* Test: poprawne tworzenie obiektu Person, 
   błędne imię lub nazwisko, pierwsza duża pozostałe małe */
try
{
    Person p = new Person(familyName: "MOlenda", firstName: "krzysztof", age: 18);
    Console.WriteLine(p);
}
catch( Exception e)
{
    Console.WriteLine(e.Message);
}
Krzysztof Molenda (18)
/* Test: poprawne tworzenie obiektu Person, 
   błędne imię lub nazwisko, niewłaściwy wiek */
try
{
    Person p = new Person(familyName: "MOlenda", firstName: "krzysztof", age: -18);
    Console.WriteLine(p);
}
catch( Exception e)
{
    Console.WriteLine(e.Message);
}
Age must be positive!
/* Test: modyfikacja obiektu */
try
{
    Person p = new Person(familyName: "Molenda", firstName: "Krzysztof", age: 18);
    p.modifyFirstName(" Ja n");
    p.modifyFamilyName("kolenda ");
    p.modifyAge(35);
    Console.WriteLine(p);
}
catch( Exception e)
{
    Console.WriteLine(e.Message);
}
Jan Kolenda (35)
/* Test: tworzenie obiektu Child */
try
{
    Person o = new Person(familyName: "Molenda", firstName: "Krzysztof", age: 30);
    Person m = new Person(familyName: "Molenda", firstName: "Ewa", age: 29);
    Child d = new Child(familyName: "Molenda", firstName: "Anna", age: 10, 
                        mother: m, father: o);
    Console.WriteLine(d);
}
catch( Exception e)
{
    Console.WriteLine(e.Message);
}
Anna Molenda (10)
mother: Ewa Molenda (29)
father: Krzysztof Molenda (30)
/* Test: tworzenie obiektu Child 
   brak rodziców */
try
{
    Child d = new Child(familyName: "Molenda", firstName: "Anna", age: 14);

    Console.WriteLine(d);
}
catch( Exception e)
{
    Console.WriteLine(e.Message);
}
Anna Molenda (14)
mother: No data
father: No data
/* Test: tworzenie obiektu Child 
   brak jednego z rodziców */
try
{
    Person o = new Person(familyName: "Molenda", firstName: "Krzysztof", age: 30);
    Person m = new Person(familyName: "Molenda", firstName: "Ewa", age: 29);
    Child d = new Child(familyName: "Molenda", firstName: "Anna", age: 14, father: o);
    Console.WriteLine(d);
    d = new Child(familyName: "Molenda", firstName: "Anna", age: 14, mother: m);
    Console.WriteLine(d);
}
catch( Exception e)
{
    Console.WriteLine(e.Message);
}