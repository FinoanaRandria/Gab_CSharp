﻿namespace dabProject.Forms
{
    partial class InformationUtilisateur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            CIN = new Label();
            Addresse = new Label();
            Prenom = new Label();
            Nom = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            Expiration = new Label();
            dateDexpiration = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 44);
            label1.Name = "label1";
            label1.Size = new Size(566, 72);
            label1.TabIndex = 1;
            label1.Text = "Information Utilisateur";
            // 
            // CIN
            // 
            CIN.AutoSize = true;
            CIN.Location = new Point(162, 359);
            CIN.Name = "CIN";
            CIN.Size = new Size(58, 20);
            CIN.TabIndex = 18;
            CIN.Text = "label11";
            // 
            // Addresse
            // 
            Addresse.AutoSize = true;
            Addresse.Location = new Point(196, 304);
            Addresse.Name = "Addresse";
            Addresse.Size = new Size(58, 20);
            Addresse.TabIndex = 17;
            Addresse.Text = "label10";
            // 
            // Prenom
            // 
            Prenom.AutoSize = true;
            Prenom.Location = new Point(193, 244);
            Prenom.Name = "Prenom";
            Prenom.Size = new Size(50, 20);
            Prenom.TabIndex = 16;
            Prenom.Text = "label9";
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.Location = new Point(170, 187);
            Nom.Name = "Nom";
            Nom.Size = new Size(50, 20);
            Nom.TabIndex = 15;
            Nom.Text = "label7";
            Nom.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(98, 296);
            label6.Name = "label6";
            label6.Size = new Size(89, 28);
            label6.TabIndex = 14;
            label6.Text = "Adresse :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(98, 352);
            label5.Name = "label5";
            label5.Size = new Size(53, 28);
            label5.TabIndex = 13;
            label5.Text = "CIN :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(98, 236);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(89, 28);
            label4.TabIndex = 12;
            label4.Text = "Prenom :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(98, 180);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 11;
            label2.Text = "Nom :";
            // 
            // Expiration
            // 
            Expiration.AutoSize = true;
            Expiration.Location = new Point(277, 410);
            Expiration.Name = "Expiration";
            Expiration.Size = new Size(50, 20);
            Expiration.TabIndex = 20;
            Expiration.Text = "label3";
            // 
            // dateDexpiration
            // 
            dateDexpiration.AutoSize = true;
            dateDexpiration.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateDexpiration.Location = new Point(99, 403);
            dateDexpiration.Name = "dateDexpiration";
            dateDexpiration.Size = new Size(172, 28);
            dateDexpiration.TabIndex = 19;
            dateDexpiration.Text = "Date d'expiration :";
            // 
            // InformationUtilisateur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 685);
            Controls.Add(Expiration);
            Controls.Add(dateDexpiration);
            Controls.Add(CIN);
            Controls.Add(Addresse);
            Controls.Add(Prenom);
            Controls.Add(Nom);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InformationUtilisateur";
            Text = "InformationUtilisateur";
            Load += InformationUtilisateur_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label CIN;
        private Label Addresse;
        private Label Prenom;
        private Label Nom;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label Expiration;
        private Label dateDexpiration;
    }
}