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

namespace dabProject.Forms
{
    public partial class CarteInformation : Form
    {
        public CarteInformation()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CarteInformation_Load(object sender, EventArgs e)
        {

            SetDateCarte.Text = DateTime.Now.ToString("dddd dd MMMM yyyy");

            try
            {
                using (Database.DabDatabaseContext _context = new Database.DabDatabaseContext())
                {
                    Account _temp_account = (from a in _context.Accounts where a.CarteNumber == Form1.CurrentUser_card select a).FirstOrDefault();
                    if (_temp_account != null)
                    {
                        numCarte.Text = $"{_temp_account.CarteNumber.Substring(0, 4)} " +
                             $"{_temp_account.CarteNumber.Substring(4, 4)} " +
                             $"{_temp_account.CarteNumber.Substring(8, 4)} " +
                             $"{_temp_account.CarteNumber.Substring(12, 4)}"; ;
                        Label.Text = _temp_account.Label;
                        Status.Text = _temp_account.Status ? "Actif" : "Desactivé";
                        Creation.Text = _temp_account.Creation.ToString("dddd dd MMMM yyyy");
                        Expiration.Text = _temp_account.Expiration.ToString("dddd dd MMMM yyyy");
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void Label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
