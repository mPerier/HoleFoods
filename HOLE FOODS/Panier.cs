using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
* La classe Panier à pour objectif principal de stocker les produits et les quantités sélectionnées. 
*/

namespace HOLE_FOODS
{
    public class Panier
    {
        private List<Produit> nosProduits; // Liste des produits du panier

        public Panier()
        {
            this.nosProduits = new List<Produit>(); // On initialise la liste à la création d'un nouveau panier
        }

        public void ajouterPanier(Produit produit)
        {

        }

        public double getPanier()
        {
            // Retourne la liste des produits du panier.
            return ;
        }
    }
}