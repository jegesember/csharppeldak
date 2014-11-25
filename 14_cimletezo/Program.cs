using System;
using System.Collections.Generic;

namespace _14_cimletezo
{

    /// <summary>
    /// Kiegészítő függvények
    /// </summary>
    static class Kiegeszitok
    {
        /// <summary>
        /// Szótár objektumhoz fűz hozzá egy elemet. Ha az elem létezik a megadott kulcsal, akkor értéket cserél
        /// </summary>
        /// <typeparam name="TKey">A kulcs típusa</typeparam>
        /// <typeparam name="TValue">Az érték típusa</typeparam>
        /// <param name="dictionary">A szótár</param>
        /// <param name="key">A kulcs</param>
        /// <param name="value">Az érték</param>
        public static void AddEditItem<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            if (dictionary.ContainsKey(key)) dictionary[key] = value;
            else dictionary.Add(key, value);
        }
    }

    class Program
    {
        /// <summary>
        /// Kerekítés szabályainak megfelelően kerekíti a bemeneti összeget
        /// </summary>
        /// <param name="bemenet">Bemeneti összeg</param>
        /// <returns>Kerekített kimenet</returns>
        private static long kerekit(long bemenet)
        {
            long kimenet = bemenet;
            long maradek = bemenet % 10;
            if (maradek >= 8) kimenet += (10 - maradek);
            else if (maradek >= 6 && maradek <= 7) kimenet -= (maradek - 5);
            else if (maradek >= 3 && maradek <= 4) kimenet += (5 - maradek);
            else if (maradek >= 1 && maradek <= 2) kimenet -= maradek;
            return kimenet;
        }

        /// <summary>
        /// A megadott összeget címletekre bontja fel
        /// </summary>
        /// <param name="osszeg">a felbontandó összeg</param>
        private static void Cimletez(long osszeg)
        {
            long hatravan = osszeg;
            int[] cimletek = { 20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5 };
            Dictionary<int, long> cimletezett = new Dictionary<int, long>();
            foreach (var cimlet in cimletek)
            {
                if (hatravan < cimlet) continue;
                long mennyi = hatravan / cimlet;
                hatravan -= mennyi * cimlet;
                cimletezett.AddEditItem(cimlet, mennyi);
                if (hatravan == 0) break;
            }

            Console.WriteLine("Az összeg címletezezve:");
            foreach (var cimlet in cimletezett)
            {
                Console.WriteLine("{0} db {1} Ft-os", cimlet.Value, cimlet.Key);
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Címletező program");
                Console.WriteLine("--------------------------------------------------");
                Console.Write("Add meg a címletezendő összeget: ");
                long input = Convert.ToInt64(Console.ReadLine());
                input = kerekit(input);
                Console.WriteLine("A cimletezeshez a kerekitett osszeg: {0}\n", input);
                Cimletez(input);
                Console.WriteLine("Nyomj egy gombot a kilepeshez...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba Történt!");
                Console.WriteLine("A hiba leírása: {0}", ex.Message);
            }
        }
    }
}
