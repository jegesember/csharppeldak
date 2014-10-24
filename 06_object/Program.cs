using System;

namespace _06_object
{
    class Ojjektum
    {
        public int Ertek;

        public Ojjektum(int value)
        {
            Ertek = value;
        }

        public override string ToString()
        {
            return "Én egy ojjektum vagyok. Értékem: " + Ertek.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is Ojjektum) return obj.GetHashCode() == this.GetHashCode(); //return (obj as Ojjektum).Ertek == this.Ertek;
            return false;
        }

        public override int GetHashCode()
        {
            return Ertek.GetHashCode();
        }

        public virtual void izé() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ojjektum a = new Ojjektum(4);
            Ojjektum b = new Ojjektum(5);
            Ojjektum c = new Ojjektum(4);

            Console.WriteLine("Ojjektum a: {0}", a);
            Console.WriteLine("Ojjektum b: {0}", b);
            Console.WriteLine("Ojjektum c: {0}", c);

            Console.WriteLine("Ojjektum a és b egyenlősége: {0}", a.Equals(b));
            Console.WriteLine("Ojjektum a és c egyenlősége: {0}", a.Equals(c));
            Console.WriteLine("Ojjektum b és c egyenlősége: {0}", b.Equals(c));

            Console.ReadKey();
        }
    }
}
