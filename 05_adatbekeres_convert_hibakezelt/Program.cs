using System;

namespace _05_adatbekeres_convert_hibakezelt
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

            try
            {
                Console.WriteLine("A bekért szám +1: {0}", Convert.ToInt32(sor) + 1);
                Console.WriteLine("A bekért lebegőpontos szám osztva 2-vel: {0}", Convert.ToDouble(sor2) / 2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba történt!! Nem megfelelő a bevitt adat.");
                Console.WriteLine("A hiba leirasa: {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("töltöttkáposzta");
            }
        }
    }
}
