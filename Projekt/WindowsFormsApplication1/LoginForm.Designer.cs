namespace WindowsFormsApplication1
{
    partial class LoginForm
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
            this.lbIme = new System.Windows.Forms.Label();
            this.lbLozinka = new System.Windows.Forms.Label();
            this.tbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.mtbLozinka = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Location = new System.Drawing.Point(51, 67);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(24, 13);
            this.lbIme.TabIndex = 0;
            this.lbIme.Text = "Ime";
            // 
            // lbLozinka
            // 
            this.lbLozinka.AutoSize = true;
            this.lbLozinka.Location = new System.Drawing.Point(51, 111);
            this.lbLozinka.Name = "lbLozinka";
            this.lbLozinka.Size = new System.Drawing.Size(44, 13);
            this.lbLozinka.TabIndex = 1;
            this.lbLozinka.Text = "Lozinka";
            // 
            // tbKorisnickoIme
            // 
            this.tbKorisnickoIme.Location = new System.Drawing.Point(143, 64);
            this.tbKorisnickoIme.Name = "tbKorisnickoIme";
            this.tbKorisnickoIme.Size = new System.Drawing.Size(167, 20);
            this.tbKorisnickoIme.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(258, 189);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(109, 28);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_click);
            // 
            // mtbLozinka
            // 
            this.mtbLozinka.Location = new System.Drawing.Point(143, 108);
            this.mtbLozinka.Name = "mtbLozinka";
            this.mtbLozinka.PasswordChar = '●';
            this.mtbLozinka.Size = new System.Drawing.Size(167, 20);
            this.mtbLozinka.TabIndex = 3;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 229);
            this.Controls.Add(this.mtbLozinka);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbKorisnickoIme);
            this.Controls.Add(this.lbLozinka);
            this.Controls.Add(this.lbIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.Label lbLozinka;
        private System.Windows.Forms.TextBox tbKorisnickoIme;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.MaskedTextBox mtbLozinka;
    }
}