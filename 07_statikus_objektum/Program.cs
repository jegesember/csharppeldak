using System;

namespace _07_statikus_objektum
{
    static class Statikus
    {
        private static int Ertek; 

        static Statikus()
        {
            Ertek = 44;
        }

        public static void Fuggveny()
        {
            Console.WriteLine("Statikus függvény, statikus osztályban. A tárolt érték: {0}", Ertek);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Statikus.Fuggveny();
            Console.ReadKey();
        }
    }
}
