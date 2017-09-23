using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Chien monChien1 = new Chien ("Coco", 12);
            monChien1.sePresenter();
            monChien1.Crier();
            monChien1.Manger();

            Lion monLion1 = new Lion ("TAB", 6);
            monLion1.sePresenter();
            monLion1.Crier();
            monLion1.SeDeplacer();

            Enclos enclosLion = new Enclos(6);
            enclosLion.Put(monLion1);
            Console.ReadLine();
        }
    }
}
