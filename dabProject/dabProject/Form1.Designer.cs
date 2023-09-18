namespace dabProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MenuPanel = new Panel();
            button4 = new Button();
            SidePanel = new Panel();
            HistoriqueBtn = new Button();
            RetraitBtn = new Button();
            ConsultationSoldeBtn = new Button();
            InformationUtilisateurBtn = new Button();
            carteInformationBtn = new Button();
            AcceuilBtn = new Button();
            colorPanel = new Panel();
            ColorPanel1 = new Panel();
            NumberPanel = new Panel();
            button3 = new Button();
            button1 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn0 = new Button();
            btn6 = new Button();
            btm5 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            MainPanel = new Panel();
            MenuPanel.SuspendLayout();
            NumberPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.FromArgb(64, 64, 64);
            MenuPanel.Controls.Add(button4);
            MenuPanel.Controls.Add(SidePanel);
            MenuPanel.Controls.Add(HistoriqueBtn);
            MenuPanel.Controls.Add(RetraitBtn);
            MenuPanel.Controls.Add(ConsultationSoldeBtn);
            MenuPanel.Controls.Add(InformationUtilisateurBtn);
            MenuPanel.Controls.Add(carteInformationBtn);
            MenuPanel.Controls.Add(AcceuilBtn);
            MenuPanel.Dock = DockStyle.Left;
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Margin = new Padding(3, 4, 3, 4);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(314, 775);
            MenuPanel.TabIndex = 1;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Snow;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(23, 609);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(285, 77);
            button4.TabIndex = 7;
            button4.Text = "  Eteindre";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.Firebrick;
            SidePanel.Location = new Point(-1, 87);
            SidePanel.Margin = new Padding(3, 4, 3, 4);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(11, 68);
            SidePanel.TabIndex = 6;
            // 
            // HistoriqueBtn
            // 
            HistoriqueBtn.FlatAppearance.BorderSize = 0;
            HistoriqueBtn.FlatStyle = FlatStyle.Flat;
            HistoriqueBtn.ForeColor = Color.Snow;
            HistoriqueBtn.Image = (Image)resources.GetObject("HistoriqueBtn.Image");
            HistoriqueBtn.ImageAlign = ContentAlignment.MiddleLeft;
            HistoriqueBtn.Location = new Point(24, 524);
            HistoriqueBtn.Margin = new Padding(3, 4, 3, 4);
            HistoriqueBtn.Name = "HistoriqueBtn";
            HistoriqueBtn.Size = new Size(285, 77);
            HistoriqueBtn.TabIndex = 5;
            HistoriqueBtn.Text = "  Historique De Transaction ";
            HistoriqueBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            HistoriqueBtn.UseVisualStyleBackColor = true;
            HistoriqueBtn.Click += HisotriqueBtn_Click;
            // 
            // RetraitBtn
            // 
            RetraitBtn.FlatAppearance.BorderSize = 0;
            RetraitBtn.FlatStyle = FlatStyle.Flat;
            RetraitBtn.ForeColor = Color.Snow;
            RetraitBtn.Image = (Image)resources.GetObject("RetraitBtn.Image");
            RetraitBtn.ImageAlign = ContentAlignment.MiddleLeft;
            RetraitBtn.Location = new Point(24, 439);
            RetraitBtn.Margin = new Padding(3, 4, 3, 4);
            RetraitBtn.Name = "RetraitBtn";
            RetraitBtn.Size = new Size(285, 77);
            RetraitBtn.TabIndex = 4;
            RetraitBtn.Text = "  Retrait";
            RetraitBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            RetraitBtn.UseVisualStyleBackColor = true;
            RetraitBtn.Click += RetraitBtn_Click;
            // 
            // ConsultationSoldeBtn
            // 
            ConsultationSoldeBtn.FlatAppearance.BorderSize = 0;
            ConsultationSoldeBtn.FlatStyle = FlatStyle.Flat;
            ConsultationSoldeBtn.ForeColor = Color.Snow;
            ConsultationSoldeBtn.Image = (Image)resources.GetObject("ConsultationSoldeBtn.Image");
            ConsultationSoldeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ConsultationSoldeBtn.Location = new Point(24, 348);
            ConsultationSoldeBtn.Margin = new Padding(3, 4, 3, 4);
            ConsultationSoldeBtn.Name = "ConsultationSoldeBtn";
            ConsultationSoldeBtn.Size = new Size(285, 77);
            ConsultationSoldeBtn.TabIndex = 3;
            ConsultationSoldeBtn.Text = "  Consulation Solde";
            ConsultationSoldeBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ConsultationSoldeBtn.UseVisualStyleBackColor = true;
            ConsultationSoldeBtn.Click += ConsultationSoldeBtn_Click;
            // 
            // InformationUtilisateurBtn
            // 
            InformationUtilisateurBtn.FlatAppearance.BorderSize = 0;
            InformationUtilisateurBtn.FlatStyle = FlatStyle.Flat;
            InformationUtilisateurBtn.ForeColor = Color.Snow;
            InformationUtilisateurBtn.Image = (Image)resources.GetObject("InformationUtilisateurBtn.Image");
            InformationUtilisateurBtn.ImageAlign = ContentAlignment.MiddleLeft;
            InformationUtilisateurBtn.Location = new Point(23, 257);
            InformationUtilisateurBtn.Margin = new Padding(3, 4, 3, 4);
            InformationUtilisateurBtn.Name = "InformationUtilisateurBtn";
            InformationUtilisateurBtn.Size = new Size(285, 77);
            InformationUtilisateurBtn.TabIndex = 2;
            InformationUtilisateurBtn.Text = "  Information utilisateur";
            InformationUtilisateurBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            InformationUtilisateurBtn.UseVisualStyleBackColor = true;
            InformationUtilisateurBtn.Click += InformationUtilisateurBtn_Click;
            // 
            // carteInformationBtn
            // 
            carteInformationBtn.FlatAppearance.BorderSize = 0;
            carteInformationBtn.FlatStyle = FlatStyle.Flat;
            carteInformationBtn.ForeColor = Color.Snow;
            carteInformationBtn.Image = (Image)resources.GetObject("carteInformationBtn.Image");
            carteInformationBtn.ImageAlign = ContentAlignment.MiddleLeft;
            carteInformationBtn.Location = new Point(23, 172);
            carteInformationBtn.Margin = new Padding(3, 4, 3, 4);
            carteInformationBtn.Name = "carteInformationBtn";
            carteInformationBtn.Size = new Size(285, 77);
            carteInformationBtn.TabIndex = 1;
            carteInformationBtn.Text = "    Carte Information";
            carteInformationBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            carteInformationBtn.UseVisualStyleBackColor = true;
            carteInformationBtn.Click += button2_Click;
            // 
            // AcceuilBtn
            // 
            AcceuilBtn.FlatAppearance.BorderSize = 0;
            AcceuilBtn.FlatStyle = FlatStyle.Flat;
            AcceuilBtn.ForeColor = Color.Snow;
            AcceuilBtn.Image = (Image)resources.GetObject("AcceuilBtn.Image");
            AcceuilBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AcceuilBtn.Location = new Point(23, 87);
            AcceuilBtn.Margin = new Padding(3, 4, 3, 4);
            AcceuilBtn.Name = "AcceuilBtn";
            AcceuilBtn.Size = new Size(285, 79);
            AcceuilBtn.TabIndex = 0;
            AcceuilBtn.Text = "    Acceuil ";
            AcceuilBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            AcceuilBtn.UseVisualStyleBackColor = true;
            AcceuilBtn.Click += button1_Click;
            // 
            // colorPanel
            // 
            colorPanel.BackColor = Color.Firebrick;
            colorPanel.Dock = DockStyle.Left;
            colorPanel.Location = new Point(314, 0);
            colorPanel.Margin = new Padding(3, 4, 3, 4);
            colorPanel.Name = "colorPanel";
            colorPanel.Size = new Size(56, 775);
            colorPanel.TabIndex = 3;
            // 
            // ColorPanel1
            // 
            ColorPanel1.BackColor = Color.Firebrick;
            ColorPanel1.Dock = DockStyle.Bottom;
            ColorPanel1.Location = new Point(370, 732);
            ColorPanel1.Margin = new Padding(3, 4, 3, 4);
            ColorPanel1.Name = "ColorPanel1";
            ColorPanel1.Size = new Size(1068, 43);
            ColorPanel1.TabIndex = 6;
            // 
            // NumberPanel
            // 
            NumberPanel.BackColor = Color.Firebrick;
            NumberPanel.Controls.Add(button3);
            NumberPanel.Controls.Add(button1);
            NumberPanel.Controls.Add(btn9);
            NumberPanel.Controls.Add(btn8);
            NumberPanel.Controls.Add(btn7);
            NumberPanel.Controls.Add(btn0);
            NumberPanel.Controls.Add(btn6);
            NumberPanel.Controls.Add(btm5);
            NumberPanel.Controls.Add(btn4);
            NumberPanel.Controls.Add(btn1);
            NumberPanel.Controls.Add(btn2);
            NumberPanel.Controls.Add(btn3);
            NumberPanel.Dock = DockStyle.Right;
            NumberPanel.Location = new Point(1131, 0);
            NumberPanel.Margin = new Padding(3, 4, 3, 4);
            NumberPanel.Name = "NumberPanel";
            NumberPanel.Size = new Size(307, 732);
            NumberPanel.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new Point(187, 667);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 27;
            button3.Text = "Confirmer";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(69, 667);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 26;
            button1.Text = "Annuler";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Location = new Point(215, 433);
            btn9.Margin = new Padding(3, 4, 3, 4);
            btn9.Name = "btn9";
            btn9.Size = new Size(66, 45);
            btn9.TabIndex = 25;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(142, 433);
            btn8.Margin = new Padding(3, 4, 3, 4);
            btn8.Name = "btn8";
            btn8.Size = new Size(66, 45);
            btn8.TabIndex = 24;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(69, 433);
            btn7.Margin = new Padding(3, 4, 3, 4);
            btn7.Name = "btn7";
            btn7.Size = new Size(66, 45);
            btn7.TabIndex = 23;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(142, 593);
            btn0.Margin = new Padding(3, 4, 3, 4);
            btn0.Name = "btn0";
            btn0.Size = new Size(66, 45);
            btn0.TabIndex = 22;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(215, 486);
            btn6.Margin = new Padding(3, 4, 3, 4);
            btn6.Name = "btn6";
            btn6.Size = new Size(66, 45);
            btn6.TabIndex = 21;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btm5
            // 
            btm5.Location = new Point(142, 486);
            btm5.Margin = new Padding(3, 4, 3, 4);
            btm5.Name = "btm5";
            btm5.Size = new Size(66, 45);
            btm5.TabIndex = 20;
            btm5.Text = "5";
            btm5.UseVisualStyleBackColor = true;
            btm5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(69, 486);
            btn4.Margin = new Padding(3, 4, 3, 4);
            btn4.Name = "btn4";
            btn4.Size = new Size(66, 45);
            btn4.TabIndex = 19;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(69, 539);
            btn1.Margin = new Padding(3, 4, 3, 4);
            btn1.Name = "btn1";
            btn1.Size = new Size(66, 45);
            btn1.TabIndex = 18;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(142, 539);
            btn2.Margin = new Padding(3, 4, 3, 4);
            btn2.Name = "btn2";
            btn2.Size = new Size(66, 45);
            btn2.TabIndex = 17;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(215, 539);
            btn3.Margin = new Padding(3, 4, 3, 4);
            btn3.Name = "btn3";
            btn3.Size = new Size(66, 45);
            btn3.TabIndex = 16;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(370, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(761, 732);
            MainPanel.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1438, 775);
            Controls.Add(MainPanel);
            Controls.Add(NumberPanel);
            Controls.Add(ColorPanel1);
            Controls.Add(colorPanel);
            Controls.Add(MenuPanel);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DAB";
            MenuPanel.ResumeLayout(false);
            NumberPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel MenuPanel;
        private Panel colorPanel;
        private Button AcceuilBtn;
        private Panel ColorPanel1;
        private Panel NumberPanel;
        private Button btn3;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn0;
        private Button btn6;
        private Button btm5;
        private Button btn4;
        private Button btn1;
        private Button btn2;
        private Button InformationUtilisateurBtn;
        private Button carteInformationBtn;
        private Button ConsultationSoldeBtn;
        private Button HistoriqueBtn;
        private Button RetraitBtn;
        private Panel SidePanel;
        private Panel MainPanel;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}