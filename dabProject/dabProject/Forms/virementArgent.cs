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
    public partial class virementArgent : Form
    {
        public virementArgent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var pinDialog = new CodePinDialog())
            {
                var result = pinDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string codePinSaisi = pinDialog.CodePinSaisi;

                    if (VerifierCodePin(codePinSaisi))
                    {
                        int montantVirement = int.Parse(textBox1.Text);
                        string numeroCarteDest = textBox2.Text;

                        using (DabDatabaseContext _context = new DabDatabaseContext())
                        {
                            try
                            {
                                Account compteDestination = _context.Accounts.FirstOrDefault(a => a.CarteNumber == numeroCarteDest && a.Status == true);

                                if (compteDestination != null)
                                {
                                    Account compteSource = (from a in _context.Accounts where a.Status == true && a.CarteNumber == Form1.CurrentUser_card select a).FirstOrDefault();

                                    if (compteSource != null)
                                    {
                                        int soldeAvant = (int)compteSource.Solde;

                                        if (montantVirement <= compteSource.Solde)
                                        {
                                            compteSource.Solde -= montantVirement;
                                            compteDestination.Solde += montantVirement;

                                            _context.Transactions.Add(
                                                new Transaction
                                                {
                                                    SoldeAvant = soldeAvant,
                                                    SoldeApres = (int)compteSource.Solde,
                                                    DateDeLaTransaction = DateTime.Now,
                                                    Type = "Virement",
                                                    AccountId = compteSource.AccountId
                                                });

                                            _context.SaveChanges();
                                            Client clientSource = _context.Clients.FirstOrDefault(c => c.ClentId == compteSource.ClientId);
                                            Client clientDest = _context.Clients.FirstOrDefault(c => c.ClentId == compteDestination.ClientId);

                                            MessageBox.Show(
                                                $"Virement effectué avec succès !\n" +
                                                $"NOM : {clientSource.Nom} {clientSource.Prenom}\n" +
                                                $"Solde transféré : {montantVirement}\n" +
                                                $"Solde restant : {(int)compteSource.Solde}\n" +
                                                $"NOM Destination : {clientDest.Nom} {clientDest.Prenom}");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Solde insuffisant pour effectuer le virement.");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Compte source invalide.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Numéro de carte de destination invalide.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Code PIN incorrect. Virement annulé.");
                    }
                }
                else
                {
                    MessageBox.Show("Virement annulé.");
                }
            }
        }

        private bool VerifierCodePin(string codePinSaisi)
        {
            using (DabDatabaseContext _context = new DabDatabaseContext())
            {
                try
                {
                    Account compteSource = (from a in _context.Accounts where a.Status == true && a.CarteNumber == Form1.CurrentUser_card select a).FirstOrDefault();

                    if (compteSource != null)
                    {
                        string codePinDansLaBaseDeDonnees = compteSource.Pin;


                        return codePinSaisi == codePinDansLaBaseDeDonnees;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite lors de la vérification du code PIN : " + ex.Message);
                }
            }

            return false;
        }

        private void virementArgent_Load(object sender, EventArgs e)
        {
            SetDateVirement.Text = DateTime.Now.ToString("dddd dd MMMM yyyy");
        }
    }
}
