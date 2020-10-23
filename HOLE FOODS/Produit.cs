using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
* La classe Produit représente un produit par son nom, son prix et son poids.
*/

namespace HOLE_FOODS
{
    public class Produit
    {
        private String nomProduit;
        private Double prix;
        private Double poids;

        public Produit()
        {

        }

        public Produit(string nomProduit, Double Prix, Double Poids)        
        {
            // Les attributs du produit sont définis à son instanciation
            this.nomProduit = nomProduit;
            this.prix = Prix;
            this.poids = Poids;
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public String extraireString()
        {
            //Retourne la chaine de caractères à écrire dans le ticket, par exemple:
            //  "Bananes - 4 kg : 7,90 €"

            return this.nomProduit+" -  " + this.poids + " kg :  " + this.prix;
        }
    }
}