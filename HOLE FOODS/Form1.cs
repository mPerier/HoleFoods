using HOLE_FOODS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
*
* Contrôleur du programme:
*
*/

namespace HOLE_FOODS
{
    public partial class Form1 : Form
    {
        Panier nosProduits;
        Ticket ticketActuel;
        ListeProduit listeProduit;


        public Form1()
        {
            InitializeComponent();
        }
        private void NVPanier_PB_Click(object sender, EventArgs e)
        {
            nosProduits = new Panier();
            ticketActuel = new Ticket();
            try
            {
                listeProduit = new ListeProduit("some CSV file path"); // ToDo!
            }
            catch (Exception error)
            {
                Console.WriteLine("Erreur lors de l'ouverture du fichier CSV contenant la liste des tickets: " + error);
            }
            Produit_LB.Items.AddRange(listeProduit.getListeProduit());
        }
        private void Produit_LB_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculPrix();
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
            if (Produit_LB.SelectedItem != null)
            {
                // On initialise un nouveau produit à partir des éléments de l'interface
                Produit produitAjout;
                produitAjout = new Produit(Produit_LB.SelectedItem.ToString(), Convert.ToDouble(Prix_TB.Text), Convert.ToDouble(Poids_TB.Text));
                // Puis on l'ajoute au panier
                nosProduits.ajouterPanier(produitAjout);
                // Avant d'ajouter sa decription au ticket
                ticketActuel.ajouterLigne(produitAjout.extraireString());
            }
        }

        private void genererTicketButton_Click(object sender, EventArgs e)
        {
            // Generer Ticket
            ticketActuel.genererTicket();
            // RAZ interface
            ticketActuel.razTicketTampon();
            Produit_LB.SelectedItem = "";
            Poids_TB.Text = "";
            Total_TB.Text = "";
        }

        private void ticketPath_PB_Click(object sender, EventArgs e)
        {

            // Show the FolderBrowserDialog.
            DialogResult result = ticketPathRecover_FD.ShowDialog();
            if (result == DialogResult.OK)
            {
                /**folderName = ticketPathRecover_FD.SelectedPath;
                if (!fileOpened)
                {
                    // No file is opened, bring up openFileDialog in selected path.
                    openFileDialog1.InitialDirectory = folderName;
                    openFileDialog1.FileName = null;
                    openMenuItem.PerformClick();
                }
    */
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
    }
}
