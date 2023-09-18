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
            label1 = new Label();
            keyInput = new TextBox();
            label2 = new Label();
            continuerBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(64, 65);
            label1.Name = "label1";
            label1.Size = new Size(613, 72);
            label1.TabIndex = 2;
            label1.Text = "Bienvenu Sur Notre DAB";
            // 
            // keyInput
            // 
            keyInput.Location = new Point(214, 239);
            keyInput.Name = "keyInput";
            keyInput.Size = new Size(343, 27);
            keyInput.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 204);
            label2.Name = "label2";
            label2.Size = new Size(273, 20);
            label2.TabIndex = 5;
            label2.Text = "Entrer votre Numero de carte banquaire";
            // 
            // continuerBtn
            // 
            continuerBtn.Location = new Point(214, 304);
            continuerBtn.Name = "continuerBtn";
            continuerBtn.Size = new Size(94, 29);
            continuerBtn.TabIndex = 6;
            continuerBtn.Text = "Continuer";
            continuerBtn.UseVisualStyleBackColor = true;
            continuerBtn.Click += continuerBtn_Click;
            // 
            // Acceuil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 732);
            Controls.Add(continuerBtn);
            Controls.Add(label2);
            Controls.Add(keyInput);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Acceuil";
            Text = "Acceuil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button continuerBtn;
        public static TextBox keyInput;
    }
}