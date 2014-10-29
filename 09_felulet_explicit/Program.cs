using System;

namespace _09_felulet_explicit
{
    interface Elso
    {
        void Bemutatkozik();
    }

    interface Masodik
    {
        void Bemutatkozik();
    }

    class Test: Elso, Masodik
    {
        public void Bemutatkozik()
        {
            Console.WriteLine("Én az első felület metódusa vagyok");
            Console.WriteLine("Engem implicit módon deklaráltak");
            Console.WriteLine("Ezért én vagyok az alapértelmezett");
            Console.WriteLine("Ha a Bemutatkozik() metódust hívják");
            Console.WriteLine();
        }

        void Masodik.Bemutatkozik()
        {
            Console.WriteLine("Én a második felület metódusa vagyok");
            Console.WriteLine("Ezért engem csak explicit módon lehetett implementálni");
            Console.WriteLine("Illetve engem csak típus konverzió után lehet meghívni");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test teszt = new Test();
            teszt.Bemutatkozik();
            (teszt as Masodik).Bemutatkozik();
            Console.ReadKey();
        }
    }
}
