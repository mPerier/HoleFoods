using System.Collections.Generic;
/**
 *
 * ------------- MODEL ----------------
 * 
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
            this.nosProduits.Add(produit);
        }

        public double getPrixPanier()
        {
            double totalPrix = 0;

            foreach (Produit currentProduit in this.nosProduits)
            {
                totalPrix += currentProduit.getPrix();
            }

            return totalPrix;
        }
    }
}