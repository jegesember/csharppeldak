using System;

namespace _04_adatbekeres_convert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bekérés és konvertálás példa");

            Console.Write("Írj be egy számot: ");
            string sor = Console.ReadLine();

            Console.Write("Írj be egy lebegőpontos számot: ");
            string sor2 = Console.ReadLine();

            Console.WriteLine("A bekért szám +1: {0}", Convert.ToInt32(sor) + 1);
            Console.WriteLine("A bekért lebegőpontos szám osztva 2-vel: {0}", Convert.ToDouble(sor2) / 2);

        }
    }
}
