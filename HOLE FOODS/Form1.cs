using System;
using System.IO;
using System.Windows.Forms;

/*
*
* ------------- CONTROLLER ----------------
*
*/

namespace HOLE_FOODS
{
    public partial class Form1 : Form
    {
        // Les objets propres à l'application
        Panier nosProduits;
        Ticket ticketActuel;
        ListeProduit listeProduit;
        Chemins chemins;


        public Form1()
        {
            InitializeComponent();
            chemins = new Chemins(); // On vérifie que les chemins d'accès en C:\Users\userName\AppData\Local sont corrects, ou alors on les importe
        }

        private void NVPanier_PB_Click(object sender, EventArgs e)
        {
            nvPanier();
        }

        private void Produit_LB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si la liste de produits est remplie, on met à jour le prix du produit sélectionné
            if (listeProduit != null)
            {
                Prix_TB.Text = Convert.ToString(listeProduit.getPrix(Produit_LB.SelectedItem.ToString()));
                calculPrix();
            }
        }

        private void legumeTextBox_TextChanged(object sender, EventArgs e)
        {
            calculPrix();
        }

        private void Poids_TB_TextChanged(object sender, EventArgs e)
        {
            calculPrix();
        }

        private void validerLegumeButton_Click(object sender, EventArgs e)
        {
            double poids;
            double prix;

            // Si tous les champs sont remplis et au bon format
            if (Produit_LB.SelectedItem != null && double.TryParse(Poids_TB.Text,out poids) && double.TryParse(Total_TB.Text,out prix))
            {
                
                Produit produitAjout = new Produit(Produit_LB.SelectedItem.ToString(), prix, poids); // On initialise un nouveau produit à partir des éléments de l'interface
                nosProduits.ajouterPanier(produitAjout);                                             // Puis on l'ajoute au panier
                ticketActuel.ajouterLigne(produitAjout.extraireString());                            // Avant d'ajouter sa decription au ticket
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis et au bon format!");
            }
        }

        private void genererTicketButton_Click(object sender, EventArgs e)
        {
            String generatedTicketPath;

            // On génère le nouveau ticket, et on en extrait le nom
            generatedTicketPath = ticketActuel.genererTicket(nosProduits.getPrixPanier());

            // On l'affiche ou non
            if (viewTicket_CB.Checked == true)
            {
                System.Diagnostics.Process.Start(generatedTicketPath);
            }

            // Enfin, on réinitialise l'interface avant de créer un nouveau panier
            ticketActuel.razTicketTampon();
            nvPanier();
        }

        private void nvPanier()
        {   
            // Cette fonction est appelée dans le clic de "nouveau Panier" ainsi que lors de la création d'un nouveau ticket!

            // Avant de créer un nouveau panier, on vérifie que les chemins d'accès pour le dossier des tickets et le CSV des produits existe.
            chemins.checkPaths();

            Produit_LB.SelectedItem = "";
            Poids_TB.Text = "";
            Total_TB.Text = "";

            if (!File.Exists(chemins.getCsvFilePath()))
            {
                MessageBox.Show("Impossible de créer un nouveau panier: Liste de produits invalide ");
            }
            else if (!Directory.Exists(chemins.getTicketPath()))
            {
                MessageBox.Show("Impossible de créer un nouveau panier: Chemin d'accès des fichiers de ticket invalide");
            }
            // Si tout existe, on crée le nouveau panier.
            else
            {
                // On commence par mettre à jour la liste de produits et le ListBox à partir du fichier CSV
                try
                {

                    listeProduit = new ListeProduit(chemins.getCsvFilePath()); // ToDo!

                    if (Produit_LB.Items.Count != 0)
                    {
                        Produit_LB.Items.Clear();
                    }
                    Produit_LB.Items.AddRange(listeProduit.getListeProduit());
                }
                catch (Exception error)
                {
                    Console.WriteLine("Erreur lors de l'ouverture du fichier CSV contenant la liste des produits: " + error);
                }

                // Puis on instancie un nouveau panier et un nouveau ticket, les anciens seront détruits par le garbage collector
                nosProduits = new Panier();
                ticketActuel = new Ticket(chemins.getTicketPath());
            }
        }

        // Methode utilisée pour calculer le Prix à chaque changement de l'interface
        private void calculPrix()
        {
            // Total = PrixUnitaire * Poids

            // Avant de calculer, on vérifie que tous les éléments nécessaires au calcul sont présents
            if (Produit_LB.SelectedItem != null && Prix_TB.Text != "" && Poids_TB.Text != "")
            {
                try
                {
                    // Une exception peut arriver si il y a incohérence entre l'élément spécifié dans la ListBox et les éléments déclarés dans Listeproduit
                    Total_TB.Text = Convert.ToString(listeProduit.getPrix(Produit_LB.SelectedItem.ToString()) * Convert.ToDouble(Poids_TB.Text));
                }
                catch (Exception error)
                {
                    Console.WriteLine("Erreur lors du calculs du prix, un champ est peut-être mal renseigné?: " + error);
                }
            }
        }

        private void rstParams_PB_Click(object sender, EventArgs e)
        {
            // On efface les paramètres de l'application, puis on la redémarre pour éviter les effets de bord.
            ticketActuel.razTicketTampon();
            chemins.resetSettings();
            Application.Restart();
        }

        private void ModifyListProducts_PB_Click(object sender, EventArgs e)
        {
            // System.Diagnostics.Process permet entre autres de déterminer grâce à l'OS quelle application utiliser, puis d'ouvrir le fichier au chemin donné en argument.
            System.Diagnostics.Process.Start(chemins.getCsvFilePath());
        }
    }
}
