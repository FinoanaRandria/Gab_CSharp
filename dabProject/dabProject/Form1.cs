namespace dabProject
{
    public partial class Form1 : Form
    {
        private Form activeForm = null;
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = AcceuilBtn.Height;
            OpenChildForm(new Forms.Acceuil());

        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            //active
            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(childForm);
            MainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CarteInformation());
        }

        private void InformationUtilisateurBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.InformationUtilisateur());
        }

        private void ConsultationSoldeBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ConsultationSolde());
        }

        private void RetraitBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Retrait());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Acceuil());
        }

        private void HisotriqueBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.HistoriqueDeTransaction());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}