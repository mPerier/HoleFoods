namespace HOLE_FOODS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Prix_TB = new System.Windows.Forms.TextBox();
            this.Poids_TB = new System.Windows.Forms.TextBox();
            this.validerLegumeButton = new System.Windows.Forms.Button();
            this.Produit_LB = new System.Windows.Forms.ListBox();
            this.genererTicketButton = new System.Windows.Forms.Button();
            this.Total_TB = new System.Windows.Forms.TextBox();
            this.NVPanier_PB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rstParams_PB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Prix_TB
            // 
            this.Prix_TB.Location = new System.Drawing.Point(233, 107);
            this.Prix_TB.Margin = new System.Windows.Forms.Padding(2);
            this.Prix_TB.Name = "Prix_TB";
            this.Prix_TB.ReadOnly = true;
            this.Prix_TB.Size = new System.Drawing.Size(72, 20);
            this.Prix_TB.TabIndex = 3;
            this.Prix_TB.TextChanged += new System.EventHandler(this.legumeTextBox_TextChanged);
            // 
            // Poids_TB
            // 
            this.Poids_TB.Location = new System.Drawing.Point(339, 106);
            this.Poids_TB.Margin = new System.Windows.Forms.Padding(2);
            this.Poids_TB.Name = "Poids_TB";
            this.Poids_TB.Size = new System.Drawing.Size(72, 20);
            this.Poids_TB.TabIndex = 4;
            this.Poids_TB.TextChanged += new System.EventHandler(this.Poids_TB_TextChanged);
            // 
            // validerLegumeButton
            // 
            this.validerLegumeButton.Location = new System.Drawing.Point(441, 90);
            this.validerLegumeButton.Margin = new System.Windows.Forms.Padding(2);
            this.validerLegumeButton.Name = "validerLegumeButton";
            this.validerLegumeButton.Size = new System.Drawing.Size(74, 42);
            this.validerLegumeButton.TabIndex = 5;
            this.validerLegumeButton.Text = "Valider";
            this.validerLegumeButton.UseVisualStyleBackColor = true;
            this.validerLegumeButton.Click += new System.EventHandler(this.validerLegumeButton_Click);
            // 
            // Produit_LB
            // 
            this.Produit_LB.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Produit_LB.FormattingEnabled = true;
            this.Produit_LB.ItemHeight = 19;
            this.Produit_LB.Items.AddRange(new object[] {
            "Appuyez sur \"Nouveau panier\""});
            this.Produit_LB.Location = new System.Drawing.Point(12, 69);
            this.Produit_LB.Margin = new System.Windows.Forms.Padding(2);
            this.Produit_LB.Name = "Produit_LB";
            this.Produit_LB.Size = new System.Drawing.Size(199, 118);
            this.Produit_LB.TabIndex = 6;
            this.Produit_LB.SelectedIndexChanged += new System.EventHandler(this.Produit_LB_SelectedIndexChanged);
            // 
            // genererTicketButton
            // 
            this.genererTicketButton.Location = new System.Drawing.Point(441, 149);
            this.genererTicketButton.Margin = new System.Windows.Forms.Padding(2);
            this.genererTicketButton.Name = "genererTicketButton";
            this.genererTicketButton.Size = new System.Drawing.Size(74, 42);
            this.genererTicketButton.TabIndex = 7;
            this.genererTicketButton.Text = "Editer ticket";
            this.genererTicketButton.UseVisualStyleBackColor = true;
            this.genererTicketButton.Click += new System.EventHandler(this.genererTicketButton_Click);
            // 
            // Total_TB
            // 
            this.Total_TB.Location = new System.Drawing.Point(339, 161);
            this.Total_TB.Margin = new System.Windows.Forms.Padding(2);
            this.Total_TB.Name = "Total_TB";
            this.Total_TB.ReadOnly = true;
            this.Total_TB.Size = new System.Drawing.Size(72, 20);
            this.Total_TB.TabIndex = 9;
            // 
            // NVPanier_PB
            // 
            this.NVPanier_PB.Location = new System.Drawing.Point(11, 11);
            this.NVPanier_PB.Margin = new System.Windows.Forms.Padding(2);
            this.NVPanier_PB.Name = "NVPanier_PB";
            this.NVPanier_PB.Size = new System.Drawing.Size(104, 40);
            this.NVPanier_PB.TabIndex = 10;
            this.NVPanier_PB.Text = "Nouveau panier";
            this.NVPanier_PB.UseVisualStyleBackColor = true;
            this.NVPanier_PB.Click += new System.EventHandler(this.NVPanier_PB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Prix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Poids";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "€";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "€";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "kg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Prix total";
            // 
            // rstParams_PB
            // 
            this.rstParams_PB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rstParams_PB.Location = new System.Drawing.Point(12, 222);
            this.rstParams_PB.Name = "rstParams_PB";
            this.rstParams_PB.Size = new System.Drawing.Size(217, 22);
            this.rstParams_PB.TabIndex = 24;
            this.rstParams_PB.Text = "Réinitialiser les paramètres de l\'application";
            this.rstParams_PB.UseVisualStyleBackColor = true;
            this.rstParams_PB.Click += new System.EventHandler(this.rstParams_PB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 256);
            this.Controls.Add(this.rstParams_PB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NVPanier_PB);
            this.Controls.Add(this.Total_TB);
            this.Controls.Add(this.genererTicketButton);
            this.Controls.Add(this.Produit_LB);
            this.Controls.Add(this.validerLegumeButton);
            this.Controls.Add(this.Poids_TB);
            this.Controls.Add(this.Prix_TB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox Total_TB;
        private System.Windows.Forms.Button NVPanier_PB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button rstParams_PB;
    }
}

