﻿namespace dabProject.Forms
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
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
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
            // textBox1
            // 
            textBox1.Location = new Point(214, 239);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(343, 27);
            textBox1.TabIndex = 3;
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
            // button1
            // 
            button1.Location = new Point(214, 304);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Continuer";
            button1.UseVisualStyleBackColor = true;
            // 
            // Acceuil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 732);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Acceuil";
            Text = "Acceuil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
    }
}