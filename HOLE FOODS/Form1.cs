﻿using HOLE_FOODS;
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
            ticketActuel = new Ticket();

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
            // On initialise un nouveau produit à partir des éléments de l'interface
            Produit produitAjout;
            produitAjout = new Produit(Produit_LB.SelectedItem.ToString(), Convert.ToDouble(Prix_TB.Text), Convert.ToDouble(Poids_TB.Text));
            // Puis on l'ajoute au panier
            nosProduits.ajouterPanier(produitAjout);
            // Avant d'ajouter sa decription au ticket
            ticketActuel.ajouterLigne(produitAjout.extraireString());
        }

        private void genererTicketButton_Click(object sender, EventArgs e)
        {

        }

    }
}
