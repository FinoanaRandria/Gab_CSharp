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
    public partial class ConsultationSolde : Form
    {
        public ConsultationSolde()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Set_Date(object sender, PaintEventArgs e)
        {
            this.SetDate.Text = DateTime.Now.ToString("dddd dd MMMM yyyy");
        }

        private void ConsultationSolde_Load(object sender, EventArgs e)
        {
            try
            {
                using (Database.DabDatabaseContext _context = new Database.DabDatabaseContext())
                {
                    Account _temp_account = (from a in _context.Accounts where a.CarteNumber == Form1.CurrentUser_card select a).FirstOrDefault();
                    if (_temp_account != null)
                    {
                        solde.Text = _temp_account.Solde.ToString();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SetDate_Click(object sender, EventArgs e)
        {

        }
    }
}

