namespace dabProject.Forms
{
    partial class PinValidation
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
            ValidPinBtn = new Button();
            label2 = new Label();
            pinInput = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // ValidPinBtn
            // 
            ValidPinBtn.Location = new Point(192, 247);
            ValidPinBtn.Name = "ValidPinBtn";
            ValidPinBtn.Size = new Size(94, 29);
            ValidPinBtn.TabIndex = 9;
            ValidPinBtn.Text = "Connexion";
            ValidPinBtn.UseVisualStyleBackColor = true;
            ValidPinBtn.Click += ValidPinBtn_click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 151);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 8;
            label2.Text = "Entrer votre PIN";
            // 
            // pinInput
            // 
            pinInput.Location = new Point(192, 186);
            pinInput.Name = "pinInput";
            pinInput.Size = new Size(109, 27);
            pinInput.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(114, 72);
            label1.TabIndex = 10;
            label1.Text = "PIN";
            // 
            // PinValidation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 685);
            Controls.Add(label1);
            Controls.Add(ValidPinBtn);
            Controls.Add(label2);
            Controls.Add(pinInput);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PinValidation";
            Text = "PinValidation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ValidPinBtn;
        private Label label2;
        private TextBox pinInput;
        private Label label1;
    }
}