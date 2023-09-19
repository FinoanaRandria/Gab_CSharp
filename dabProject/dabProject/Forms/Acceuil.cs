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
    public delegate void Params();
    public partial class Acceuil : Form
    {
        private Params callBack;
        public Acceuil(Params callBack)
        {
            InitializeComponent();
            this.callBack = callBack;
        }


        private void continuerBtn_Click(object sender, EventArgs e)
        {
            using (Database.DabDatabaseContext _context = new Database.DabDatabaseContext())
            {
                try
                {
                    string card_user_input = keyInput.Text.Replace(" ", "");
                    Account _temp_account = (from a in _context.Accounts where a.Status == true && a.CarteNumber == card_user_input select a).FirstOrDefault();
                    if (_temp_account != null)
                    {
                        Form1.CurrentUser_card = _temp_account.CarteNumber;
                        callBack();
                    }
                    else
                    {
                        Console.WriteLine("User card not valid");
                    }

                }
                catch (Exception)
                {

                }
            }
        }
    }
}
