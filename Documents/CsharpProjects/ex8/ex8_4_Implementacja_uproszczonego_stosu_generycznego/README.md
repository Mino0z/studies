#Polecienie Zadania
Dane są: interfejs IStos<T> oraz klasa opisująca własny wyjątek StosEmptyException.

namespace StrukturaStos
{
    /// <summary>
    /// Interfejs stosu (generyczny)
    /// </summary>
    /// <remarks>
    /// Założenia:
    /// 1. Po utworzeniu stos jest pusty
    /// 2. Stos jest pojemnikiem o nieograniczonej pojemności
    /// 3. Próba zdjęcia lub odczytania szczytowego elementu ze stosu pustego zgłasza wyjątek
    /// 4. Push oraz Pop są czynnościami wzajemnie odwrotnymi
    /// </remarks>
    /// <typeparam name="T">dowolny typ wartościowy lub referencyjny</typeparam>
    public interface IStos<T>
    {
        //w interfejsie nie deklaruje się konstruktora

        //wstawia element typu T na stos
        void Push(T value);

        //zwraca szczytowy element stosu
        T Peek { get; }

        //zdejmuje szczytowy element ze stosu i go zwraca
        T Pop();

        //zwraca liczbę elementów na stosie
        int Count { get; }

        //zwraca true, jeśli stos jest pusty, a false w przeciwnym przypadku
        bool IsEmpty { get; }

        //opróżnia stos
        void Clear();

        //kopiuje (klonuje, płytka kopia) i eksportuje stos do tablicy
        T[] ToArray();
    }
}
using System;

namespace StrukturaStos
{
    public class StosEmptyException : Exception
    {
        public StosEmptyException() { }
        public StosEmptyException(string message) : base(message) { }
        public StosEmptyException(string message, Exception inner) : base(message, inner) { }
    }
}
Nie kopiuj tego kodu, będzie dołączany do kompilacji!

Zaimplementuj klasę generyczną Stos<T>, implementującą interfejs IStos<T> i spełniającą następujące założenia:

Po utworzeniu stos jest pusty
Stos jest pojemnikiem o nieograniczonej pojemności
Próba zdjęcia lub odczytania szczytowego elementu ze stosu pustego zgłasza wyjątek StosEmptyException
Push oraz Pop są czynnościami wzajemnie odwrotnymi
Peek zwraca element szczytowy
W implementacji wykorzystaj kolekcję List<T> lub tablicę T[].

For example:

Test	Result
var s = new Stos<string>();
s.Push("aaa");
s.Push("bbb");
s.Push("ccc");
foreach( var x in s.ToArray() )
{
  Console.WriteLine(x);
}
Console.WriteLine($"na szczycie jest: {s.Peek}");
Console.WriteLine($"liczba elementów na stosie: {s.Count}");
while(!s.IsEmpty)
{
  Console.WriteLine( $"zdejmuje: {s.Pop()}");
}
if( s.IsEmpty )
  Console.WriteLine( "stos jest pusty" );
aaa
bbb
ccc
na szczycie jest: ccc
liczba elementów na stosie: 3
zdejmuje: ccc
zdejmuje: bbb
zdejmuje: aaa
stos jest pusty