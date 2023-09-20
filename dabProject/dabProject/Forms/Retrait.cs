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
using PdfSharp.Pdf;
using PdfSharp.Drawing;


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
                            Print_Transaction(_context, _temp_account);
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

        private void Print_Transaction(DabDatabaseContext _context, Account _account)
        {
            try
            {
                Client _temp_client = _context.Clients.Where(x => x.ClentId == _account.ClientId).First();
                Transaction _temp_transaction = _context.Transactions.OrderBy(x => x.DateDeLaTransaction).Last();
                // Créer un nouveau document PDF
                PdfDocument document = new PdfDocument();
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);

                // Texte avec sauts de ligne
                string texteAvecSautDeLigne = @"Ceci est la première ligne.\nCeci est la deuxième ligne.\nCeci est la troisième ligne." + _account.Label;

                // Coordonnées de départ pour afficher le texte
                XPoint startPoint = new XPoint(30, 30);
                // Créer un objet XFont pour spécifier la police et la taille du texte
                XFont font = new XFont("Arial", 12);
                double Y = 30;
                // Dessiner le texte sur la page PDF    
                gfx.DrawString(@"Date : " + _temp_transaction.DateDeLaTransaction.ToString("dddd dd MMMM yyyy hh:mm"), font, XBrushes.Black, new XPoint(30, Y));
                gfx.DrawString(@"Nom : " + _temp_client.Nom + " " + _temp_client.Prenom, font, XBrushes.Black, new XPoint(30, Y + font.GetHeight() * 1));
                gfx.DrawString(@"CIN : " + _temp_client.Cin, font, XBrushes.Black, new XPoint(30, Y + font.GetHeight() * 2));
                gfx.DrawString(@"Addresse : " + _temp_client.Adresse, font, XBrushes.Black, new XPoint(30, Y + font.GetHeight() * 3));
                gfx.DrawString(@"--------------------------------------------------------------", font, XBrushes.Black, new XPoint(30, Y + font.GetHeight() * 4));
                gfx.DrawString(@"Solde Retire : " + (_temp_transaction.SoldeAvant - _temp_transaction.SoldeApres) + " Ar", font, XBrushes.Black, new XPoint(30, Y + font.GetHeight() * 6));



                // Spécifier l'emplacement où vous souhaitez enregistrer le fichier PDF
                string cheminDuFichier = $"{_temp_client.Nom}{_temp_client.Prenom}-{_temp_transaction.TransactionId}.pdf";

                // Enregistrer le document PDF
                document.Save(cheminDuFichier);

                // Ouvrir le PDF généré avec le lecteur PDF par défaut
                //System.Diagnostics.Process.Start(cheminDuFichier);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Nplante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Retrait_Load(object sender, EventArgs e)
        {

        }
    }
}
