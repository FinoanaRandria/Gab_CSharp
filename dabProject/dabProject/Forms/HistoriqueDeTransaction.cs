using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dabProject.Forms
{
    public partial class HistoriqueDeTransaction : Form
    {
        public HistoriqueDeTransaction()
        {
            InitializeComponent();
        }

        private void HistoriqueDeTransaction_Load(object sender, EventArgs e)
        {
            using (Database.DabDatabaseContext _context = new Database.DabDatabaseContext())
            {
                List<Database.Transaction> user_transaction = _context.Transactions.Where(x => x.AccountId == (from a in _context.Accounts where a.CarteNumber == Form1.CurrentUser_card select a.AccountId).First()).ToList();

                foreach (var item in user_transaction)
                {
                    dataGridTransactions.Rows.Add(
                        $"{item.DateDeLaTransaction.ToString("dddd dd/MMMM/yyyy HH:mm")}",
                        item.Type,
                        $"{item.SoldeAvant.ToString("n", CultureInfo.GetCultureInfo("fr-FR"))} Ar",
                        $"{item.SoldeApres.ToString("n", CultureInfo.GetCultureInfo("fr-FR"))} Ar"
                        );
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
