#Polecenie Zadania

Zaprojektuj klasę Person spełniającą następujące założenia:

Dane:

FamilyName : string, nazwisko, tylko litery (co najmniej dwie), pierwsza litera duża, pozostałe małe; możliwość nazwiska dwuczłonowego - wtedy człony połączone łącznikiem (znak -), każdy człon z dużej litery, pozostałe z małych (człon nazwiska składa się z co najmniej 2. liter). Próba zapamiętania wartości niezgodnej z wytycznymi skutkuje zgłoszeniem wyjątku ArgumentException z komunikatem Incorrect data for FamilyName. Spacje na początku i końcu należy usunąć.

FirstName : string, imię, tylko litery (co najmniej dwie), pierwsza litera duża, pozostałe małe. Próba zapamiętania wartości niezgodnej z wytycznymi skutkuje zgłoszeniem wyjątku ArgumentException z komunikatem Incorrect data for FirstName. Spacje na początku i końcu należy usunąć.

Birthday : DateTime, data urodzenia, nie później niż dzisiaj. Próba zapamiętania wartości niezgodnej z wytycznymi skutkuje zgłoszeniem wyjątku ArgumentException z komunikatem Incorrect data for Birthday.
Dane obiektu są read/write oraz obligatoryjne, zrealizuj je jako właściwości (properties).

Zachowanie:

metoda ToString() wypisująca dane o osobie w formacie {FirstName} {FamilyName} ({Birthday}), data urodzenia w formacie yyyy-MM-dd.

Uwagi

Postaraj się zapisać kod klasy używając jak najmniejszej liczby linii kodu - np. wykorzystuj metody klasy string, jeśli kod miałby się powtarzać - zdefiniuj metodę prywatną, którą wykorzystasz wielokrotnie.
Do oceny przesyłasz kod klasy Person, ewentualnie poprzedzony dyrektywami using. Nie umieszczasz go w żadnej przestrzeni nazw. Twój kod (STUDENT_ANSWER) zostanie osadzony w podanym szkielecie, następnie całość zostanie skompilowana i uruchomiona - dla każdego przypadku testowego oddzielnie:

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