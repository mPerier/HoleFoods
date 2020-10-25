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
* GROS TRAVAIL sur la rationalisation des fonctions évennementielles!
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

        }
        private void Produit_LB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void legumeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Poids_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void validerLegumeButton_Click(object sender, EventArgs e)
        {

        }

        private void genererTicketButton_Click(object sender, EventArgs e)
        {

        }

    }
}
