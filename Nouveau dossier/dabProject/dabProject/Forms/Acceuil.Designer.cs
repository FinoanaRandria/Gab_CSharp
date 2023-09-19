namespace dabProject.Forms
{
    partial class Acceuil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceuil));
            label1 = new Label();
            label2 = new Label();
            continuerBtn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            keyInput = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(120, 283);
            label1.Name = "label1";
            label1.Size = new Size(518, 35);
            label1.TabIndex = 2;
            label1.Text = "WELCOME / BIENVENUE / TONGASOA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 337);
            label2.Name = "label2";
            label2.Size = new Size(273, 20);
            label2.TabIndex = 5;
            label2.Text = "Entrer votre Numero de carte banquaire";
            // 
            // continuerBtn
            // 
            continuerBtn.Location = new Point(564, 372);
            continuerBtn.Name = "continuerBtn";
            continuerBtn.Size = new Size(94, 29);
            continuerBtn.TabIndex = 6;
            continuerBtn.Text = "Continuer";
            continuerBtn.UseVisualStyleBackColor = true;
            continuerBtn.Click += continuerBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(310, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 122);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(21, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(84, 62);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // keyInput
            // 
            keyInput.Location = new Point(215, 372);
            keyInput.Name = "keyInput";
            keyInput.Size = new Size(343, 27);
            keyInput.TabIndex = 3;
            // 
            // Acceuil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 732);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(continuerBtn);
            Controls.Add(label2);
            Controls.Add(keyInput);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Acceuil";
            Text = "Acceuil";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button continuerBtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        public TextBox keyInput;
    }
}