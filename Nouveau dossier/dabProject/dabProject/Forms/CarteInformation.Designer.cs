﻿namespace dabProject.Forms
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Label = new Label();
            Status = new Label();
            Creation = new Label();
            Expiration = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 58);
            label1.Name = "label1";
            label1.Size = new Size(451, 72);
            label1.TabIndex = 0;
            label1.Text = "Carte Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(168, 185);
            label2.Name = "label2";
            label2.Size = new Size(67, 28);
            label2.TabIndex = 1;
            label2.Text = "Label :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(168, 241);
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
            label5.Location = new Point(168, 357);
            label5.Name = "label5";
            label5.Size = new Size(172, 28);
            label5.TabIndex = 4;
            label5.Text = "Date d'expiration :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(168, 302);
            label6.Name = "label6";
            label6.Size = new Size(165, 28);
            label6.TabIndex = 5;
            label6.Text = "Date de creation :";
            label6.Click += label6_Click;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Location = new Point(253, 193);
            Label.Name = "Label";
            Label.Size = new Size(50, 20);
            Label.TabIndex = 6;
            Label.Text = "label7";
            Label.Click += Label_Click;
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Location = new Point(253, 249);
            Status.Name = "Status";
            Status.Size = new Size(50, 20);
            Status.TabIndex = 8;
            Status.Text = "label9";
            // 
            // Creation
            // 
            Creation.AutoSize = true;
            Creation.Location = new Point(339, 309);
            Creation.Name = "Creation";
            Creation.Size = new Size(58, 20);
            Creation.TabIndex = 9;
            Creation.Text = "label10";
            // 
            // Expiration
            // 
            Expiration.AutoSize = true;
            Expiration.Location = new Point(339, 364);
            Expiration.Name = "Expiration";
            Expiration.Size = new Size(58, 20);
            Expiration.TabIndex = 10;
            Expiration.Text = "label11";
            // 
            // CarteInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 732);
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
    }
}