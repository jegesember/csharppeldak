using System;
using System.Collections.Generic;

namespace _13_tarolok
{
    class Program
    {
        /// <summary>
        /// A Program fő függvénye
        /// </summary>
        /// <param name="args">parancssori argumentumok</param>
        static void Main(string[] args)
        {
            //100db elemnek előfoglalunk helyet, így gyorsabb a működés később
            List<int> lista = new List<int>(100);
            VeletlenElemek(lista);

            foreach (var elem in lista)
            {
                Console.WriteLine(elem);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// 100Db véletlen számot generál
        /// </summary>
        /// <param name="lista">Egy Lista objektum, amibe az elemek kerülnek</param>
        static void VeletlenElemek(List<int> lista)
        {
            //véletlen számgenerátor
            Random r = new Random();

            //100db véletlen szám generálása
            for (int i=0; i<100; i++)
            {
                lista.Add(r.Next());
            }
        }
    }
}
