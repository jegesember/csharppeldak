using System;
using System.Text;

namespace _16_bovitometodus
{
    public static class Bovit
    {
        public static string Caesar(this string Bemenet)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var karakter in Bemenet)
            {
                //UTF-16 miatt minden karakter short szám
                short ertek = (short)karakter;
                //ha a karakter értéke 33 alatti, akkor nem nyomtatható
                //ezért kihagyjuk a titkosítási folyamatból, mert csak bezavarna
                if (ertek < 33) sb.Append(karakter);
                else
                {
                    ertek += 3; //3 pozícióval eltolunk
                    if (ertek > short.MaxValue)
                    {
                        //ha az érték túlmutatna a kódtáblán
                        //akkor kivonjuk a maximális értéket
                        ertek -= short.MaxValue;
                        //majd elcsúsztatjuk 32 pozícióval, hogy nyomtatható
                        //karaktert kapjunk
                        ertek += 32;
                    }
                    //karakterré konvertálunk és hozzá fűzünk
                    sb.Append((char)ertek);
                }
            }
            return sb.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string eredeti = "Ez egy példa szöveg, amit caesar titkosítunk mindjárt";
            Console.WriteLine("Az eredeti szöveg:");
            Console.WriteLine(eredeti);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("A titkosított szöveg:");
            //bővítő metódus hívása az eredeti string objektumon keresztül
            Console.WriteLine(eredeti.Caesar());
            Console.ReadKey();
        }
    }
}
