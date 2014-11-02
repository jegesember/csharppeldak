using System;

namespace _12_tomb_indexer
{
    class TombIndexer
    {
        public string this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: return "Nulla";
                    case 1: return "Egy";
                    case 2: return "Kettő";
                    case 3: return "Három";
                    case 4: return "Négy";
                    case 5: return "Öt";
                    case 6: return "Hat";
                    default: return "Sok";
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TombIndexer teszt = new TombIndexer();
            for (int i=0; i<7; i++)
            {
                Console.WriteLine(teszt[i]);
            }
            Console.ReadKey();
        }
    }
}
