using dabProject.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dabProject.Forms
{
    public partial class InformationUtilisateur : Form
    {
        public InformationUtilisateur()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {






        }

        private void InformationUtilisateur_Load(object sender, EventArgs e)
        {
            try
            {
                using (Database.DabDatabaseContext _context = new Database.DabDatabaseContext())
                {
                    Account _temp_account = (from a in _context.Accounts where a.CarteNumber == Form1.CurrentUser_card select a).FirstOrDefault();

                    Expiration.Text = _temp_account.Expiration.ToString();



                    if (_temp_account != null)
                    {
                        Client _temp_client = (from a in _context.Clients where a.ClentId == _temp_account.ClientId select a).FirstOrDefault();


                        Nom.Text = _temp_client.Nom;
                        Prenom.Text = _temp_client.Prenom;
                        Addresse.Text = _temp_client.Adresse;
                        CIN.Text = _temp_client.Cin;
                        





                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
