namespace dabProject.Forms
{
    partial class virementArgent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(virementArgent));
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            SetDateVirement = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(332, 574);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 0;
            button1.Text = "ENVOYER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(241, 401);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 362);
            label1.Name = "label1";
            label1.Size = new Size(264, 20);
            label1.TabIndex = 2;
            label1.Text = "Entrer le montant du solde a transferer";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(241, 510);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 477);
            label2.Name = "label2";
            label2.Size = new Size(193, 20);
            label2.TabIndex = 4;
            label2.Text = "Entrer le numero de la carte";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(306, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 160);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun-ExtB", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(165, 277);
            label3.Name = "label3";
            label3.Size = new Size(415, 54);
            label3.TabIndex = 6;
            label3.Text = "Virement Solde";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(688, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 29);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // SetDateVirement
            // 
            SetDateVirement.AutoSize = true;
            SetDateVirement.Location = new Point(494, 17);
            SetDateVirement.Name = "SetDateVirement";
            SetDateVirement.Size = new Size(173, 20);
            SetDateVirement.TabIndex = 13;
            SetDateVirement.Text = "lundi 17 septembre 2023";
            // 
            // virementArgent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 638);
            Controls.Add(pictureBox3);
            Controls.Add(SetDateVirement);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "virementArgent";
            Text = "virementArgent";
            Load += virementArgent_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox3;
        private Label SetDateVirement;
    }
}