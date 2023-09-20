using dabProject.Database;
using dabProject.Forms;

namespace dabProject
{
    public partial class Form1 : Form
    {
        private Form activeForm = null;
        public static string CurrentUser_card;
        public static bool CurrentUser_isLogged = false;

        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = AcceuilBtn.Height;
            OpenChildForm(new Forms.Acceuil(() => OpenChildForm(new Forms.PinValidation(() => UserIsConnected()))));


            if (!CurrentUser_isLogged)
            {
                carteInformationBtn.Visible = false;
                InformationUtilisateurBtn.Visible = false;
                ConsultationSoldeBtn.Visible = false;
                RetraitBtn.Visible = false;
                HistoriqueBtn.Visible = false;
                VirementBtn.Visible = false;
            }
        }

        public void UserIsConnected()
        {
            AcceuilBtn.Visible = false;
            carteInformationBtn.Visible = true;
            InformationUtilisateurBtn.Visible = true;
            ConsultationSoldeBtn.Visible = true;
            RetraitBtn.Visible = true;
            HistoriqueBtn.Visible = true;
            VirementBtn.Visible = true;
            OpenChildForm(new Forms.CarteInformation());
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
            OpenChildForm(new Forms.Acceuil(() => OpenChildForm(new Forms.PinValidation(() => UserIsConnected()))));
        }

        private void HisotriqueBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.HistoriqueDeTransaction());
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.virementArgent());
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AddNumber(int _n)
        {
            if (Acceuil.keyInput.Text.Length % 5 == 0)
            {
                Acceuil.keyInput.Text += " ";
            }
            if (Acceuil.keyInput.Text.Length <= 20)
            {

                Acceuil.keyInput.Text += _n.ToString();
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            AddNumber(0);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AddNumber(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AddNumber(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AddNumber(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AddNumber(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AddNumber(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AddNumber(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AddNumber(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AddNumber(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AddNumber(9);
        }

        private void NumberPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}