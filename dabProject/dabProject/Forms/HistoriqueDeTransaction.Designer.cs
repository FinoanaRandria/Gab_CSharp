namespace dabProject.Forms
{
    partial class HistoriqueDeTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoriqueDeTransaction));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            dataGridTransactions = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            pictureBox3 = new PictureBox();
            SetDate = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTransactions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 31.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(139, 167);
            label1.Name = "label1";
            label1.Size = new Size(481, 52);
            label1.TabIndex = 1;
            label1.Text = "Mes transactions ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 252);
            label2.Name = "label2";
            label2.Size = new Size(215, 20);
            label2.TabIndex = 2;
            label2.Text = "Liste des dernieres transaction :";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(309, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 126);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // dataGridTransactions
            // 
            dataGridTransactions.AllowUserToAddRows = false;
            dataGridTransactions.AllowUserToDeleteRows = false;
            dataGridTransactions.BackgroundColor = Color.WhiteSmoke;
            dataGridTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTransactions.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridTransactions.Location = new Point(21, 292);
            dataGridTransactions.Name = "dataGridTransactions";
            dataGridTransactions.ReadOnly = true;
            dataGridTransactions.RowHeadersWidth = 51;
            dataGridTransactions.RowTemplate.Height = 29;
            dataGridTransactions.Size = new Size(701, 260);
            dataGridTransactions.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Date de la transaction";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Type";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Solde avant";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Solde apres";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(688, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 29);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // SetDate
            // 
            SetDate.AutoSize = true;
            SetDate.Location = new Point(506, 9);
            SetDate.Name = "SetDate";
            SetDate.Size = new Size(173, 20);
            SetDate.TabIndex = 13;
            SetDate.Text = "lundi 17 septembre 2023";
            // 
            // HistoriqueDeTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 638);
            Controls.Add(pictureBox3);
            Controls.Add(SetDate);
            Controls.Add(dataGridTransactions);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HistoriqueDeTransaction";
            Text = "HistoriqueDeTransaction";
            Load += HistoriqueDeTransaction_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTransactions).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private DataGridView dataGridTransactions;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private PictureBox pictureBox3;
        private Label SetDate;
    }
}