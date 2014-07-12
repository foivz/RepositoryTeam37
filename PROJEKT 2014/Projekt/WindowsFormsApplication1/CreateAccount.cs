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

            korisnikTableAdapter1.Connection.ConnectionString = ControlData.ConnectionString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( maskedTextBox1.Text == maskedTextBox2.Text )
            {
                if ( textBox1.Text.Length > 3 )
                {
                    string[] split = textBox2.Text.Split('@');

                    if ( split.Length == 2)
                    {
                        string[] split2 = split[1].Split('.');

                        if ( split2.Length > 1 )
                        {
                            int success = korisnikTableAdapter1.DodajKorisnika(textBox1.Text, maskedTextBox1.Text, textBox2.Text, 3);
                            MessageBox.Show("Korisnički račun " + textBox1.Text + " uspješno kreiran!");
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
