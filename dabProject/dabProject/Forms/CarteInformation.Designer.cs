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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(156, 58);
            label1.Name = "label1";
            label1.Size = new Size(451, 72);
            label1.TabIndex = 0;
            label1.Text = "Carte Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(207, 225);
            label2.Name = "label2";
            label2.Size = new Size(67, 28);
            label2.TabIndex = 1;
            label2.Text = "Label :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(207, 281);
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
            label5.Location = new Point(207, 397);
            label5.Name = "label5";
            label5.Size = new Size(172, 28);
            label5.TabIndex = 4;
            label5.Text = "Date d'expiration :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(207, 342);
            label6.Name = "label6";
            label6.Size = new Size(165, 28);
            label6.TabIndex = 5;
            label6.Text = "Date de creation :";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(292, 233);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 6;
            label7.Text = "label7";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(292, 289);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 8;
            label9.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(378, 349);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 9;
            label10.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(378, 404);
            label11.Name = "label11";
            label11.Size = new Size(58, 20);
            label11.TabIndex = 10;
            label11.Text = "label11";
            // 
            // CarteInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 732);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarteInformation";
            Text = "CarteInformation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}