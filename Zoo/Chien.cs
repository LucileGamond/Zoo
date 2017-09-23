using System;

namespace Zoo
{
    public class Chien : Animal
    {
        //membres
        private int mNbPattes { get; set; }
        private mRegimeAlimentaire mRegime { get; set; }

        // constructeur
        public Chien(string prenom, int age) : base(prenom, age)
        {
            mNbPattes = 4;
            mRegime = mRegimeAlimentaire.omnivore;
        }
        
        // methodes 

        public override void sePresenter()
        {
            base.sePresenter();
            Console.WriteLine(", je suis {0}.\n", mRegime);
        }
        public override void Crier()
        {
            Console.WriteLine("Wouaf Wouaf");
        }

        public override void SeDeplacer()
        {
            Console.WriteLine("Je marche sur mes {0} pattes.", mNbPattes);
        }

        public override void Manger()
        {
        }


    }
}
