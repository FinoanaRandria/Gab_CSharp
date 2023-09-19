namespace dabProject.Forms
{
    partial class Retrait
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
            retraitBtn = new Button();
            label2 = new Label();
            sommeInput = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 64);
            label1.Name = "label1";
            label1.Size = new Size(183, 72);
            label1.TabIndex = 2;
            label1.Text = "Retrait";
            // 
            // retraitBtn
            // 
            retraitBtn.Location = new Point(126, 283);
            retraitBtn.Name = "retraitBtn";
            retraitBtn.Size = new Size(94, 29);
            retraitBtn.TabIndex = 9;
            retraitBtn.Text = "Retirer";
            retraitBtn.UseVisualStyleBackColor = true;
            retraitBtn.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 205);
            label2.Name = "label2";
            label2.Size = new Size(289, 20);
            label2.TabIndex = 8;
            label2.Text = "Entrer la somme a retirer sur votre compte";
            // 
            // sommeInput
            // 
            sommeInput.Location = new Point(126, 237);
            sommeInput.Name = "sommeInput";
            sommeInput.Size = new Size(235, 27);
            sommeInput.TabIndex = 7;
            // 
            // Retrait
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 732);
            Controls.Add(retraitBtn);
            Controls.Add(label2);
            Controls.Add(sommeInput);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Retrait";
            Text = "Retrait";
            Load += Retrait_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button retraitBtn;
        private Label label2;
        private TextBox sommeInput;
    }
}