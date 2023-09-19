namespace dabProject.Forms
{
    partial class ConsultationSolde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultationSolde));
            label1 = new Label();
            label2 = new Label();
            solde = new Label();
            label4 = new Label();
            SetDate = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(232, 314);
            label1.Name = "label1";
            label1.Size = new Size(303, 54);
            label1.TabIndex = 2;
            label1.Text = "Mon solde ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 419);
            label2.Name = "label2";
            label2.Size = new Size(165, 20);
            label2.TabIndex = 4;
            label2.Text = "Solde total du compte :";
            // 
            // solde
            // 
            solde.AutoSize = true;
            solde.Location = new Point(387, 419);
            solde.Name = "solde";
            solde.Size = new Size(17, 20);
            solde.TabIndex = 5;
            solde.Text = "0";
            solde.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(467, 419);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 7;
            label4.Text = "Ar";
            // 
            // SetDate
            // 
            SetDate.AutoSize = true;
            SetDate.Location = new Point(558, 9);
            SetDate.Name = "SetDate";
            SetDate.Size = new Size(173, 20);
            SetDate.TabIndex = 9;
            SetDate.Text = "lundi 17 septembre 2023";
            SetDate.Paint += Set_Date;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(307, 189);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 122);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // ConsultationSolde
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 685);
            Controls.Add(pictureBox1);
            Controls.Add(SetDate);
            Controls.Add(label4);
            Controls.Add(solde);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConsultationSolde";
            Text = "ConsultationSolde";
            Load += ConsultationSolde_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label solde;
        private Label label4;
        private Label SetDate;
        private PictureBox pictureBox1;
    }
}