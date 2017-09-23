using System;
using System.Collections.Generic;



namespace Zoo
{
    public class Enclos : Contenant
    {

        // constructeur
        public Enclos(int maxAnimaux): base(maxAnimaux)
        {
        }

        //methode
        public override void Put(Animal unAnimal)
        {
            
            if (mListeAnimaux.Count >= mCapacity)
            {

                //if rep == 
                //mListeAnimaux.Add(unAnimal);
                //mCapacity += 1;

            }
            else
                mListeAnimaux.Add(unAnimal);
        }



    }
}
