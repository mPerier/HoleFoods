using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

/*
// La classe ListeProduit contient un dicitonnaire représentant la totalité des produits que l'utilisateur peut sélectionner, ainsi que leur prix unitaire
*/

namespace HOLE_FOODS
{
    public class ListeProduit
    {
        // Le dictionnaire contient <nomProduit,prixProduit>
        private Dictionary<String,double> dicProduits;

        public ListeProduit(String csvFilePath)
        {
            // à l'instanciation d'une Liste de Produits, on utilise le fichier CSV à l'emplacement précisé dans csvFilePath pour remplir dicProduits

            dicProduits = new Dictionary<string, double>();
            StreamReader sr;
            sr = new StreamReader(csvFilePath);
            String[] readedLine;
            Boolean noErrors = true;
            int lineIterator = 1;

            // Tant que l'on n'atteint pas la fin du fichier
            while (!sr.EndOfStream)
            {
                try
                {
                    // On essaie de séparer les caractères lus grâce au point virgule
                    readedLine = sr.ReadLine().Split(';');

                    try
                    {
                        // Puis on essaie d'ajouter le résultat au tableau
                        dicProduits.Add(readedLine[0], Convert.ToDouble(readedLine[1]));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Format incorrect ligne " + lineIterator + " Erreur: " + e);
                        noErrors = false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Impossible de séparer les membres du fichier d'entrée ligne " + lineIterator + " Erreur: "+e);
                    noErrors = false;
                }

                // Si des erreurs se sont produites, on en informe l'utilisateur
                if (noErrors == false)
                {
                    if (dicProduits.Count < 1)
                    {
                        MessageBox.Show("[ERREUR] Impossible d'importer les données du fichier CSV");
                    }
                    else
                    {
                        MessageBox.Show("[ALERTE] Erreurs lors de l'import de la liste des produits");
                    }
                }


                lineIterator++;
            }
                
        }

        public String[] getListeProduit()
        {
            // Retourne un tableau de Strings qui sera utilisé nottament pour mettre à jour le ListBox Produit_LB
            String[] outputString = new String[dicProduits.Count];
            int entryIterator = 0;

            // On parcourt le tableau des produits pour en extraire les clés dans outputString
            foreach (KeyValuePair<String,double> dicEntry in dicProduits)
            {
                outputString[entryIterator] = dicEntry.Key.ToString();
                entryIterator++;
            }

            return outputString;
        }

        public double getPrix(String nomProduit)
        {
            double outValue;
             dicProduits.TryGetValue(nomProduit, out outValue);
            return outValue;


        }
    }
}