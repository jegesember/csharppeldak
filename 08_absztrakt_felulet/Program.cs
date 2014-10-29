using System;

namespace _08_absztrakt_felulet
{
    public abstract class AbsztraktOsztaly
    {
        public abstract void Bemutatkozas();
    }

    public interface IFelulet
    {
        string FeluletNeve();
    }

    public class Implementacio: AbsztraktOsztaly, IFelulet
    {

        public override void Bemutatkozas()
        {
            Console.WriteLine("Ez egy absztrakt osztályból örököltetett Implementáció");
        }

        public string FeluletNeve()
        {
            return "Az implentáció megvalósítja az IFelület felületet";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Implementacio teszt = new Implementacio();
            teszt.Bemutatkozas();
            Console.WriteLine(teszt.FeluletNeve());
            Console.ReadKey();
        }
    }
}
