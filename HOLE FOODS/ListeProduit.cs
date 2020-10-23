using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
// La classe ListeProduit contient un dicitonnaire représentant la totalité des produits que l'utilisateur peut sélectionner, ainsi que leur prix unitaire
*/

namespace HOLE_FOODS
{
    public class ListeProduit
    {
        // Le dictionnaire content <nomProduit,prixProduit>
        private Dictionary<String,double> dicProduits;

        public ListeProduit(String csvFilePath)
        {
            // à l'instanciation d'une Liste de Produits, on utilise le fichier CSV à l'emplacement précisé dans csvFilePath pour remplir dicProduits
        }

        public String[] getListeProduit()
        {
            // Retourne un tableau de Strings qui sera utilisé nottament pour mettre à jour le ListBox Produit_LB
        }

        public double getPrix(double nomProduit)
        {
            // Retourne le prix associé à la clé "nomProduit"
        }
    }
}