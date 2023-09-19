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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Retrait));
            label1 = new Label();
            retraitBtn = new Button();
            label2 = new Label();
            sommeInput = new TextBox();
            pictureBox3 = new PictureBox();
            SetDate = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(282, 266);
            label1.Name = "label1";
            label1.Size = new Size(183, 72);
            label1.TabIndex = 2;
            label1.Text = "Retrait";
            // 
            // retraitBtn
            // 
            retraitBtn.Location = new Point(326, 420);
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
            label2.Location = new Point(230, 338);
            label2.Name = "label2";
            label2.Size = new Size(289, 20);
            label2.TabIndex = 8;
            label2.Text = "Entrer la somme a retirer sur votre compte";
            // 
            // sommeInput
            // 
            sommeInput.Location = new Point(258, 377);
            sommeInput.Name = "sommeInput";
            sommeInput.Size = new Size(235, 27);
            sommeInput.TabIndex = 7;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(716, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 29);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // SetDate
            // 
            SetDate.AutoSize = true;
            SetDate.Location = new Point(534, 9);
            SetDate.Name = "SetDate";
            SetDate.Size = new Size(173, 20);
            SetDate.TabIndex = 13;
            SetDate.Text = "lundi 17 septembre 2023";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(312, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 141);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Retrait
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 732);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(SetDate);
            Controls.Add(retraitBtn);
            Controls.Add(label2);
            Controls.Add(sommeInput);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Retrait";
            Text = "Retrait";
            Load += Retrait_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button retraitBtn;
        private Label label2;
        private TextBox sommeInput;
        private PictureBox pictureBox3;
        private Label SetDate;
        private PictureBox pictureBox1;
    }
}