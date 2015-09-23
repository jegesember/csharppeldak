using System;

namespace _17_brainfuck
{
    class Program
    {
        //statikus szál modell alkalmazása.
        //ha ez nincs itt akkor a vágólapot nem tudja elérni
        //a konzol alkalmazásunk
        [STAThread]
        static void Main(string[] args)
        {

            BrainFuck bf = new BrainFuck();
            ConsoleKeyInfo key;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("BrainFuck#");
                Console.WriteLine("1.   Program futtatás vágólapról");
                Console.WriteLine("2.   Program futtatása fájlból");
                Console.WriteLine("ESC  Kilépés");
                Console.WriteLine("---------------------------------------");
                Console.Write("Válasz: ");
                key = Console.ReadKey();

                //esc gombra kilépés
                if (key.Key == ConsoleKey.Escape) break;

                bf.Reset();
                switch (key.KeyChar)
                {
                    case '1':
                        bf.LoadClipboard();
                        break;
                    case '2':
                        bf.LoadFromFile();
                        break;
                    default:
                        continue;
                }
                
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("A program kimenete:");
                    bf.Run();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hiba történt a futtatásnál: " + ex.Message);
                }
                Console.WriteLine();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("A folytatáshoz nyomj egy gombot...");
                Console.ReadKey();

            }
        }
    }
}
