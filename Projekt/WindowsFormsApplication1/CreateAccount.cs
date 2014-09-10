using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsGame1;

namespace WindowsFormsApplication1
{
    public partial class CreateAccount:Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btnKreiraj_click(object sender, EventArgs e)
        {
            if ( mtbLozinka.Text == mtbLozinka2.Text )
            {
                if ( tbKorisnickoIme.Text.Length > 3 )
                {
                    string[] split = tbEmail.Text.Split('@');

                    if ( split.Length == 2)
                    {
                        string[] split2 = split[1].Split('.');

                        if ( split2.Length > 1 )
                        {
                            int succes = Forma.DataBaseManager.korisnik_Adapter.DodajKorisnika(tbKorisnickoIme.Text, mtbLozinka.Text, tbEmail.Text, 3);

                            MessageBox.Show("Korisnički račun " + tbKorisnickoIme.Text + " uspješno kreiran!");
                            this.Close();
                        }
                        else
                            MessageBox.Show("Email nije ispravnog formata!");

                    }
                    else
                        MessageBox.Show("Email nije ispravnog formata!");
                }
                else
                    MessageBox.Show("Korisničko ime mora biti duže od barem 3 slova.");
            }
            else
            MessageBox.Show("Lozinke se ne podudaraju!");
        }
    
    }
}
