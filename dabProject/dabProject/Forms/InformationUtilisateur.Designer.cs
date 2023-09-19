namespace dabProject.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationUtilisateur));
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
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            SetDate = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 31.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(232, 212);
            label1.Name = "label1";
            label1.Size = new Size(292, 52);
            label1.TabIndex = 1;
            label1.Text = "Mon compte";
            // 
            // CIN
            // 
            CIN.AutoSize = true;
            CIN.Location = new Point(455, 392);
            CIN.Name = "CIN";
            CIN.Size = new Size(58, 20);
            CIN.TabIndex = 18;
            CIN.Text = "label11";
            // 
            // Addresse
            // 
            Addresse.AutoSize = true;
            Addresse.Location = new Point(455, 361);
            Addresse.Name = "Addresse";
            Addresse.Size = new Size(58, 20);
            Addresse.TabIndex = 17;
            Addresse.Text = "label10";
            // 
            // Prenom
            // 
            Prenom.AutoSize = true;
            Prenom.Location = new Point(455, 333);
            Prenom.Name = "Prenom";
            Prenom.Size = new Size(50, 20);
            Prenom.TabIndex = 16;
            Prenom.Text = "label9";
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.Location = new Point(455, 301);
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
            label6.Location = new Point(237, 354);
            label6.Name = "label6";
            label6.Size = new Size(89, 28);
            label6.TabIndex = 14;
            label6.Text = "Adresse :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(237, 385);
            label5.Name = "label5";
            label5.Size = new Size(53, 28);
            label5.TabIndex = 13;
            label5.Text = "CIN :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(237, 326);
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
            label2.Location = new Point(237, 294);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 11;
            label2.Text = "Nom :";
            // 
            // Expiration
            // 
            Expiration.AutoSize = true;
            Expiration.Location = new Point(455, 421);
            Expiration.Name = "Expiration";
            Expiration.Size = new Size(50, 20);
            Expiration.TabIndex = 20;
            Expiration.Text = "label3";
            // 
            // dateDexpiration
            // 
            dateDexpiration.AutoSize = true;
            dateDexpiration.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateDexpiration.Location = new Point(237, 413);
            dateDexpiration.Name = "dateDexpiration";
            dateDexpiration.Size = new Size(172, 28);
            dateDexpiration.TabIndex = 19;
            dateDexpiration.Text = "Date d'expiration :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(315, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 138);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(705, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 29);
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // SetDate
            // 
            SetDate.AutoSize = true;
            SetDate.Location = new Point(523, 9);
            SetDate.Name = "SetDate";
            SetDate.Size = new Size(173, 20);
            SetDate.TabIndex = 22;
            SetDate.Text = "lundi 17 septembre 2023";
            // 
            // InformationUtilisateur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 685);
            Controls.Add(pictureBox3);
            Controls.Add(SetDate);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label SetDate;
    }
}