﻿namespace HOLE_FOODS
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Prix_TB = new System.Windows.Forms.TextBox();
            this.Poids_TB = new System.Windows.Forms.TextBox();
            this.validerLegumeButton = new System.Windows.Forms.Button();
            this.Produit_LB = new System.Windows.Forms.ListBox();
            this.genererTicketButton = new System.Windows.Forms.Button();
            this.TotalPanierTextBox = new System.Windows.Forms.TextBox();
            this.Total_TB = new System.Windows.Forms.TextBox();
            this.NVPanier_PB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ticketPath_PB = new System.Windows.Forms.Button();
            this.ticketPathRecover_FD = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Prix_TB
            // 
            this.Prix_TB.Location = new System.Drawing.Point(323, 108);
            this.Prix_TB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Prix_TB.Name = "Prix_TB";
            this.Prix_TB.Size = new System.Drawing.Size(95, 22);
            this.Prix_TB.TabIndex = 3;
            this.Prix_TB.TextChanged += new System.EventHandler(this.legumeTextBox_TextChanged);
            // 
            // Poids_TB
            // 
            this.Poids_TB.Location = new System.Drawing.Point(464, 107);
            this.Poids_TB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Poids_TB.Name = "Poids_TB";
            this.Poids_TB.Size = new System.Drawing.Size(95, 22);
            this.Poids_TB.TabIndex = 4;
            this.Poids_TB.TextChanged += new System.EventHandler(this.Poids_TB_TextChanged);
            // 
            // validerLegumeButton
            // 
            this.validerLegumeButton.Location = new System.Drawing.Point(600, 106);
            this.validerLegumeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.validerLegumeButton.Name = "validerLegumeButton";
            this.validerLegumeButton.Size = new System.Drawing.Size(75, 23);
            this.validerLegumeButton.TabIndex = 5;
            this.validerLegumeButton.Text = "Valider";
            this.validerLegumeButton.UseVisualStyleBackColor = true;
            this.validerLegumeButton.Click += new System.EventHandler(this.validerLegumeButton_Click);
            // 
            // Produit_LB
            // 
            this.Produit_LB.FormattingEnabled = true;
            this.Produit_LB.ItemHeight = 16;
            this.Produit_LB.Location = new System.Drawing.Point(179, 107);
            this.Produit_LB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Produit_LB.Name = "Produit_LB";
            this.Produit_LB.Size = new System.Drawing.Size(76, 52);
            this.Produit_LB.TabIndex = 6;
            // 
            // genererTicketButton
            // 
            this.genererTicketButton.Location = new System.Drawing.Point(464, 214);
            this.genererTicketButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genererTicketButton.Name = "genererTicketButton";
            this.genererTicketButton.Size = new System.Drawing.Size(105, 23);
            this.genererTicketButton.TabIndex = 7;
            this.genererTicketButton.Text = "Editer ticket";
            this.genererTicketButton.UseVisualStyleBackColor = true;
            this.genererTicketButton.Click += new System.EventHandler(this.genererTicketButton_Click);
            // 
            // TotalPanierTextBox
            // 
            this.TotalPanierTextBox.Location = new System.Drawing.Point(363, 175);
            this.TotalPanierTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TotalPanierTextBox.Name = "TotalPanierTextBox";
            this.TotalPanierTextBox.ReadOnly = true;
            this.TotalPanierTextBox.Size = new System.Drawing.Size(85, 22);
            this.TotalPanierTextBox.TabIndex = 8;
            this.TotalPanierTextBox.Text = "Total panier :";
            // 
            // Total_TB
            // 
            this.Total_TB.Location = new System.Drawing.Point(464, 175);
            this.Total_TB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Total_TB.Name = "Total_TB";
            this.Total_TB.Size = new System.Drawing.Size(95, 22);
            this.Total_TB.TabIndex = 9;
            // 
            // NVPanier_PB
            // 
            this.NVPanier_PB.Location = new System.Drawing.Point(12, 107);
            this.NVPanier_PB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NVPanier_PB.Name = "NVPanier_PB";
            this.NVPanier_PB.Size = new System.Drawing.Size(139, 49);
            this.NVPanier_PB.TabIndex = 10;
            this.NVPanier_PB.Text = "Nouveau panier";
            this.NVPanier_PB.UseVisualStyleBackColor = true;
            this.NVPanier_PB.Click += new System.EventHandler(this.NVPanier_PB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Prix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Poids";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "€";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "€";
            // 
            // ticketPath_PB
            // 
            this.ticketPath_PB.Location = new System.Drawing.Point(2, 275);
            this.ticketPath_PB.Name = "ticketPath_PB";
            this.ticketPath_PB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ticketPath_PB.Size = new System.Drawing.Size(235, 23);
            this.ticketPath_PB.TabIndex = 19;
            this.ticketPath_PB.Text = "Choisir dossier sauvegarde ticket";
            this.ticketPath_PB.UseVisualStyleBackColor = true;
            this.ticketPath_PB.Click += new System.EventHandler(this.ticketPath_PB_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 238);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(231, 31);
            this.button1.TabIndex = 20;
            this.button1.Text = "Choisir base de donnée produits";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(565, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "kg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 315);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ticketPath_PB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NVPanier_PB);
            this.Controls.Add(this.Total_TB);
            this.Controls.Add(this.TotalPanierTextBox);
            this.Controls.Add(this.genererTicketButton);
            this.Controls.Add(this.Produit_LB);
            this.Controls.Add(this.validerLegumeButton);
            this.Controls.Add(this.Poids_TB);
            this.Controls.Add(this.Prix_TB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "HoleFoods Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Prix_TB;
        private System.Windows.Forms.TextBox Poids_TB;
        private System.Windows.Forms.Button validerLegumeButton;
        private System.Windows.Forms.ListBox Produit_LB;
        private System.Windows.Forms.Button genererTicketButton;
        private System.Windows.Forms.TextBox TotalPanierTextBox;
        private System.Windows.Forms.TextBox Total_TB;
        private System.Windows.Forms.Button NVPanier_PB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ticketPath_PB;
        private System.Windows.Forms.FolderBrowserDialog ticketPathRecover_FD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}

