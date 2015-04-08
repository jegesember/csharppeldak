using System;

namespace _15_statikusosztaly
{

    //statikus, mivel static kulcszóval jelöltük meg
    public static class StatikusPelda
    {
        public static int StatikusSzam
        {
            get;
            private set; //privát írható
        }

        //statikus osztály konstruktora is statikus
        //elérés módosító itt nem használható
        static StatikusPelda()
        {
            //érték beállítása
            StatikusSzam = 42;
        }

        //egy egyszerű statikus függvény
        public static void Test()
        {
            Console.WriteLine("Ez egy statikus metódus");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A statikus szám értéke: {0}", StatikusPelda.StatikusSzam);
            StatikusPelda.Test();
            Console.ReadKey();
        }
    }
}
