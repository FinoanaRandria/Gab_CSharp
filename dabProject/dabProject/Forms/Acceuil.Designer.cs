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
            keyInput = new TextBox();
            label2 = new Label();
            continuerBtn = new Button();
            pictureBox3 = new PictureBox();
            SetDate = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-2, 253);
            label1.Name = "label1";
            label1.Size = new Size(767, 72);
            label1.TabIndex = 2;
            label1.Text = "Welcome/Bienvenue/Tongasoa";
            // 
            // keyInput
            // 
            keyInput.Location = new Point(206, 386);
            keyInput.Name = "keyInput";
            keyInput.Size = new Size(350, 27);
            keyInput.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 352);
            label2.Name = "label2";
            label2.Size = new Size(273, 20);
            label2.TabIndex = 5;
            label2.Text = "Entrer votre Numero de carte banquaire";
            // 
            // continuerBtn
            // 
            continuerBtn.Location = new Point(341, 446);
            continuerBtn.Name = "continuerBtn";
            continuerBtn.Size = new Size(94, 29);
            continuerBtn.TabIndex = 6;
            continuerBtn.Text = "Continuer";
            continuerBtn.UseVisualStyleBackColor = true;
            continuerBtn.Click += continuerBtn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(714, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 29);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // SetDate
            // 
            SetDate.AutoSize = true;
            SetDate.Location = new Point(532, 9);
            SetDate.Name = "SetDate";
            SetDate.Size = new Size(173, 20);
            SetDate.TabIndex = 13;
            SetDate.Text = "lundi 17 septembre 2023";
            // 
            // Acceuil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 732);
            Controls.Add(pictureBox3);
            Controls.Add(SetDate);
            Controls.Add(continuerBtn);
            Controls.Add(label2);
            Controls.Add(keyInput);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Acceuil";
            Text = "Acceuil";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button continuerBtn;
        private PictureBox pictureBox3;
        private Label SetDate;
        public static TextBox keyInput;
    }
}