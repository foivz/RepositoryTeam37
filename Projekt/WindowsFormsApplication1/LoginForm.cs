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

        private void btnLogin_click(object sender, EventArgs e)
        {
            string user = tbKorisnickoIme.Text;
            string pass = mtbLozinka.Text;

          
            if(Forma.DataBaseManager.VerifyUser(user,pass)==true)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Korisnički podaci nisu ispravni. Provjerite velika/mala slova i pokušajte ponovo");
            }
        }
    }
}
