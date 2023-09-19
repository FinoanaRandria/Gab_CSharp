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
            label1 = new Label();
            label2 = new Label();
            solde = new Label();
            label4 = new Label();
            label5 = new Label();
            SetDate = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(481, 72);
            label1.TabIndex = 2;
            label1.Text = "Consultation Solde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 191);
            label2.Name = "label2";
            label2.Size = new Size(165, 20);
            label2.TabIndex = 4;
            label2.Text = "Solde total du compte :";
            // 
            // solde
            // 
            solde.AutoSize = true;
            solde.Location = new Point(256, 191);
            solde.Name = "solde";
            solde.Size = new Size(17, 20);
            solde.TabIndex = 5;
            solde.Text = "0";
            solde.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(361, 191);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 7;
            label4.Text = "ar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 145);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 8;
            label5.Text = "Date :";
            // 
            // SetDate
            // 
            SetDate.AutoSize = true;
            SetDate.Location = new Point(122, 145);
            SetDate.Name = "SetDate";
            SetDate.Size = new Size(173, 20);
            SetDate.TabIndex = 9;
            SetDate.Text = "lundi 17 septembre 2023";
            SetDate.Paint += Set_Date;
            // 
            // ConsultationSolde
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 685);
            Controls.Add(SetDate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(solde);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConsultationSolde";
            Text = "ConsultationSolde";
            Load += ConsultationSolde_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label solde;
        private Label label4;
        private Label label5;
        private Label SetDate;
    }
}