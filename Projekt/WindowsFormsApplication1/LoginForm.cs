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
    public partial class LoginForm:Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = maskedTextBox1.Text;

            Baza1DataSet.korisnikDataTable result = korisnikTableAdapter1.VerifyUser(user, pass);

            if ( result.Rows.Count == 1 )
            {
                ControlData.Username = user;

                ControlData.korisnikID = (int)result[0][4];

                DataTable tipResult = tip_korisnikaTableAdapter1.GetTipKorisnikabyID((int)result[0][4]);

                ControlData.tipKorisnika = tipResult.Rows[0][1].ToString();

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
                MessageBox.Show("Korisnički podaci nisu ispravni. Provjerite velika/mala slova i pokušajte ponovo");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            korisnikTableAdapter1.Connection.ConnectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + ControlData.PathToMDF + ";Integrated Security=True;Connect Timeout=30";
            tip_korisnikaTableAdapter1.Connection.ConnectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + ControlData.PathToMDF + ";Integrated Security=True;Connect Timeout=30";
        }
    }
}
