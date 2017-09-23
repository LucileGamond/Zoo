using System;

namespace Zoo
{
    
    public abstract class Animal
    {
        // membres
        public string mPrenom { get; protected set; }
        public int mAge { get; protected set; }
        protected enum mRegimeAlimentaire
	    { 
	        carnivore, herbivore, omnivore
	    } 

        // constructeur
        public Animal(string prenom, int age)
        {
            mPrenom = prenom;
            mAge = age;
        }


        // methodes
        public virtual void sePresenter()
        {
            Console.Write("Bonjour, je m'appelle {0}, j'ai {1} ans", mPrenom, mAge);
        }

        public abstract void Crier();

        public abstract void SeDeplacer();

        public abstract void Manger();



    }
}
