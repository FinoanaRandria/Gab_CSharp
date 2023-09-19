namespace dabProject.Forms
{
    partial class CarteInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarteInformation));
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Label = new Label();
            Status = new Label();
            Creation = new Label();
            Expiration = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            numCarte = new Label();
            pictureBox3 = new PictureBox();
            SetDateCarte = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(249, 275);
            label1.Name = "label1";
            label1.Size = new Size(245, 72);
            label1.TabIndex = 0;
            label1.Text = "Ma Carte";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(184, 407);
            label2.Name = "label2";
            label2.Size = new Size(67, 28);
            label2.TabIndex = 1;
            label2.Text = "Label :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(184, 439);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(74, 28);
            label4.TabIndex = 3;
            label4.Text = "Status :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(184, 511);
            label5.Name = "label5";
            label5.Size = new Size(172, 28);
            label5.TabIndex = 4;
            label5.Text = "Date d'expiration :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(184, 472);
            label6.Name = "label6";
            label6.Size = new Size(165, 28);
            label6.TabIndex = 5;
            label6.Text = "Date de creation :";
            label6.Click += label6_Click;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Location = new Point(428, 415);
            Label.Name = "Label";
            Label.Size = new Size(50, 20);
            Label.TabIndex = 6;
            Label.Text = "label7";
            Label.Click += Label_Click;
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Location = new Point(428, 447);
            Status.Name = "Status";
            Status.Size = new Size(50, 20);
            Status.TabIndex = 8;
            Status.Text = "label9";
            // 
            // Creation
            // 
            Creation.AutoSize = true;
            Creation.Location = new Point(428, 480);
            Creation.Name = "Creation";
            Creation.Size = new Size(58, 20);
            Creation.TabIndex = 9;
            Creation.Text = "label10";
            // 
            // Expiration
            // 
            Expiration.AutoSize = true;
            Expiration.Location = new Point(428, 519);
            Expiration.Name = "Expiration";
            Expiration.Size = new Size(58, 20);
            Expiration.TabIndex = 10;
            Expiration.Text = "label11";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(293, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 136);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(184, 369);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 12;
            label3.Text = "Num carte :";
            // 
            // numCarte
            // 
            numCarte.AutoSize = true;
            numCarte.Location = new Point(428, 377);
            numCarte.Name = "numCarte";
            numCarte.Size = new Size(50, 20);
            numCarte.TabIndex = 13;
            numCarte.Text = "label7";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(721, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 29);
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // SetDateCarte
            // 
            SetDateCarte.AutoSize = true;
            SetDateCarte.Location = new Point(539, 9);
            SetDateCarte.Name = "SetDateCarte";
            SetDateCarte.Size = new Size(173, 20);
            SetDateCarte.TabIndex = 15;
            SetDateCarte.Text = "lundi 17 septembre 2023";
            // 
            // CarteInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 732);
            Controls.Add(pictureBox3);
            Controls.Add(SetDateCarte);
            Controls.Add(numCarte);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(Expiration);
            Controls.Add(Creation);
            Controls.Add(Status);
            Controls.Add(Label);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarteInformation";
            Text = "CarteInformation";
            Load += CarteInformation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label Label;
        private Label Status;
        private Label Creation;
        private Label Expiration;
        private PictureBox pictureBox1;
        private Label label3;
        private Label numCarte;
        private PictureBox pictureBox3;
        private Label SetDateCarte;
    }
}