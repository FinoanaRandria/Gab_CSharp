using dabProject.Database;
using Microsoft.EntityFrameworkCore;
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
    public partial class Retrait : Form
    {
        public Retrait()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SommeARetirer = int.Parse(sommeInput.Text);

            using (DabDatabaseContext _context = new DabDatabaseContext())
            {
                try
                {
                    Account _temp_account = (from a in _context.Accounts where a.Status == true && a.CarteNumber == Form1.CurrentUser_card select a).FirstOrDefault();
                    if (_temp_account != null)
                    {
                        int SommeBefore = (int)_temp_account.Solde;
                        if (SommeARetirer <= _temp_account.Solde)
                        {
                            _temp_account.Solde -= SommeARetirer;
                            _context.Transactions.Add(
                                new Transaction
                                {
                                    SoldeApres = (int)_temp_account.Solde,
                                    SoldeAvant = SommeBefore,
                                    DateDeLaTransaction = DateTime.Now,
                                    Type = "Retrait",
                                    AccountId = _temp_account.AccountId
                                });
                            _context.SaveChanges();
                        }
                        else
                        {
                            //Recuperer tous les transacrion
                            //List<Transaction> lt = _context.Transactions.ToList();
                            //
                            Console.WriteLine("Solde insuffisant !");
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

        private void Retrait_Load(object sender, EventArgs e)
        {

        }
    }
}
