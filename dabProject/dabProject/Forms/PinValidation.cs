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
    public delegate void Params_Pin();
    public partial class PinValidation : Form
    {
        private Params_Pin callback;
        public PinValidation(Params_Pin callback)
        {
            InitializeComponent();
            this.callback = callback;
        }

        private void ValidPinBtn_click(object sender, EventArgs e)
        {
            string pin_input = pinInput.Text.Trim();
            using (Database.DabDatabaseContext _context = new Database.DabDatabaseContext())
            {
                try
                {
                    Account _temp_account = (from a in _context.Accounts where a.Status == true && a.CarteNumber == Form1.CurrentUser_card select a).FirstOrDefault();
                    if (_temp_account != null)
                    {


                        if (_temp_account.Tentative == 0)
                        {
                            Console.WriteLine("your Account has been Blocked");
                        }
                        else
                        {
                            Account _temp_account_verified = (from a in _context.Accounts where a.CarteNumber == Form1.CurrentUser_card && a.Pin == pin_input select a).FirstOrDefault();
                            if (_temp_account_verified != null)
                            {
                                Form1.CurrentUser_isLogged = true;
                                this.callback();
                            }
                            else
                            {
                                Console.WriteLine("User Pin is incorrect");
                            }
                        }
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
