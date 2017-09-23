using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class  Contenant
    {
        //membres
        public int mCapacity { get; protected set; }
        public List<Animal> mListeAnimaux { get; protected set; }

        //constructeur
        public Contenant(int maxAnimaux)
        {
            mCapacity = maxAnimaux;
            mListeAnimaux = new List<Animal>();
        }

        //methodes
        public abstract void Put(Animal unAnimal);

    }
}
