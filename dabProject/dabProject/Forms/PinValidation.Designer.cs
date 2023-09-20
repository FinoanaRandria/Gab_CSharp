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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PinValidation));
            ValidPinBtn = new Button();
            label2 = new Label();
            pinInput = new TextBox();
            pictureBox3 = new PictureBox();
            SetDatePin = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ValidPinBtn
            // 
            ValidPinBtn.Location = new Point(314, 378);
            ValidPinBtn.Name = "ValidPinBtn";
            ValidPinBtn.Size = new Size(109, 29);
            ValidPinBtn.TabIndex = 9;
            ValidPinBtn.Text = "Connexion";
            ValidPinBtn.UseVisualStyleBackColor = true;
            ValidPinBtn.Click += ValidPinBtn_click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 281);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 8;
            label2.Text = "Entrer votre PIN";
            // 
            // pinInput
            // 
            pinInput.Location = new Point(313, 316);
            pinInput.Name = "pinInput";
            pinInput.Size = new Size(109, 27);
            pinInput.TabIndex = 7;
            pinInput.UseSystemPasswordChar = true;
            pinInput.TextChanged += pinInput_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(701, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 29);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // SetDatePin
            // 
            SetDatePin.AutoSize = true;
            SetDatePin.Location = new Point(491, 9);
            SetDatePin.Name = "SetDatePin";
            SetDatePin.Size = new Size(173, 20);
            SetDatePin.TabIndex = 13;
            SetDatePin.Text = "lundi 17 septembre 2023";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(301, 140);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 133);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // PinValidation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 685);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(SetDatePin);
            Controls.Add(ValidPinBtn);
            Controls.Add(label2);
            Controls.Add(pinInput);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PinValidation";
            Text = "PinValidation";
            Load += pinvalidLoad;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ValidPinBtn;
        private Label label2;
        private TextBox pinInput;
        private PictureBox pictureBox3;
        private Label SetDatePin;
        private PictureBox pictureBox1;
    }
}