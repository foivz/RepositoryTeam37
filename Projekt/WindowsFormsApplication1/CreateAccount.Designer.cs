namespace WindowsFormsApplication1
{
    partial class CreateAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if ( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbKorisnickoIme = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbLozinka = new System.Windows.Forms.Label();
            this.lbPonoviteLozinku = new System.Windows.Forms.Label();
            this.tbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.mtbLozinka = new System.Windows.Forms.MaskedTextBox();
            this.mtbLozinka2 = new System.Windows.Forms.MaskedTextBox();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbKorisnickoIme
            // 
            this.lbKorisnickoIme.AutoSize = true;
            this.lbKorisnickoIme.Location = new System.Drawing.Point(25, 28);
            this.lbKorisnickoIme.Name = "lbKorisnickoIme";
            this.lbKorisnickoIme.Size = new System.Drawing.Size(78, 13);
            this.lbKorisnickoIme.TabIndex = 0;
            this.lbKorisnickoIme.Text = "Korisničko ime:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(68, 54);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "Email:";
            // 
            // lbLozinka
            // 
            this.lbLozinka.AutoSize = true;
            this.lbLozinka.Location = new System.Drawing.Point(56, 80);
            this.lbLozinka.Name = "lbLozinka";
            this.lbLozinka.Size = new System.Drawing.Size(47, 13);
            this.lbLozinka.TabIndex = 2;
            this.lbLozinka.Text = "Lozinka:";
            // 
            // lbPonoviteLozinku
            // 
            this.lbPonoviteLozinku.AutoSize = true;
            this.lbPonoviteLozinku.Location = new System.Drawing.Point(15, 106);
            this.lbPonoviteLozinku.Name = "lbPonoviteLozinku";
            this.lbPonoviteLozinku.Size = new System.Drawing.Size(88, 13);
            this.lbPonoviteLozinku.TabIndex = 3;
            this.lbPonoviteLozinku.Text = "Ponovite lozinku:";
            // 
            // textBox1
            // 
            this.tbKorisnickoIme.Location = new System.Drawing.Point(109, 25);
            this.tbKorisnickoIme.Name = "textBox1";
            this.tbKorisnickoIme.Size = new System.Drawing.Size(277, 20);
            this.tbKorisnickoIme.TabIndex = 5;
            // 
            // textBox2
            // 
            this.tbEmail.Location = new System.Drawing.Point(109, 51);
            this.tbEmail.Name = "textBox2";
            this.tbEmail.Size = new System.Drawing.Size(277, 20);
            this.tbEmail.TabIndex = 6;
            // 
            // maskedTextBox1
            // 
            this.mtbLozinka.Location = new System.Drawing.Point(109, 77);
            this.mtbLozinka.Name = "maskedTextBox1";
            this.mtbLozinka.PasswordChar = '×';
            this.mtbLozinka.Size = new System.Drawing.Size(277, 20);
            this.mtbLozinka.TabIndex = 7;
            // 
            // maskedTextBox2
            // 
            this.mtbLozinka2.Location = new System.Drawing.Point(109, 103);
            this.mtbLozinka2.Name = "maskedTextBox2";
            this.mtbLozinka2.PasswordChar = '×';
            this.mtbLozinka2.Size = new System.Drawing.Size(277, 20);
            this.mtbLozinka2.TabIndex = 8;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(18, 153);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(368, 32);
            this.btnKreiraj.TabIndex = 9;
            this.btnKreiraj.Text = "Kreiraj!";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 205);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.mtbLozinka2);
            this.Controls.Add(this.mtbLozinka);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbKorisnickoIme);
            this.Controls.Add(this.lbPonoviteLozinku);
            this.Controls.Add(this.lbLozinka);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbKorisnickoIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateAccount";
            this.Text = "Kreirajte svoj novi korisnički račun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbKorisnickoIme;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbLozinka;
        private System.Windows.Forms.Label lbPonoviteLozinku;
        private System.Windows.Forms.TextBox tbKorisnickoIme;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.MaskedTextBox mtbLozinka;
        private System.Windows.Forms.MaskedTextBox mtbLozinka2;
        private System.Windows.Forms.Button btnKreiraj;
    }
}