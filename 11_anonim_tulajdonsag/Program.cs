using System;

namespace _11_anonim_tulajdonsag
{
    class NemAnonim
    {
        private int _ertek;

        public NemAnonim()
        {
            _ertek = 33;
        }

        public int Tulajdonsag
        {
            get
            {
                return _ertek;
            }
        }
    }

    public class Anonim
    {
        public int Tulajdonsag
        {
            get;
            private set;
        }

        public Anonim()
        {
            Tulajdonsag = 33;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NemAnonim n = new NemAnonim();
            Anonim a = new Anonim();
            Console.WriteLine(n.Tulajdonsag);
            Console.WriteLine(a.Tulajdonsag);
            Console.ReadKey();
        }
    }
}
