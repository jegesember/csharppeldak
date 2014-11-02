using System;

namespace _10_tulajdonsag
{
    public class Tulajdonsag
    {
        private int _ertek;

        public int Ertek
        {
            get
            {
                Console.WriteLine("Az erteket lekerdeztek");
                return _ertek;
            }
            set
            {
                _ertek = value;
                Console.WriteLine("Az erteket beallitottak");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Tulajdonsag teszt = new Tulajdonsag();
            teszt.Ertek = 55;
            Console.WriteLine(teszt.Ertek);
            Console.ReadKey();
        }
    }
}
