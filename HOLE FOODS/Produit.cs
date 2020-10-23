using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            //Bananes - 4 kg : 7,90 €

            return this.nomProduit+" -  " + this.poids + " kg :  " + this.prix;

        }
    }
}