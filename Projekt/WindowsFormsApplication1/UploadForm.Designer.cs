namespace WindowsFormsApplication1
{
    partial class UploadForm
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
            this.lbKorisnik = new System.Windows.Forms.Label();
            this.lbKategorija = new System.Windows.Forms.Label();
            this.btnNadji = new System.Windows.Forms.Button();
            this.tbLokacija = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lbIzvorisnaLokacija = new System.Windows.Forms.Label();
            this.lbImeNovogFoldera = new System.Windows.Forms.Label();
            this.tbFolder = new System.Windows.Forms.TextBox();
            this.lbSadrzaj = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lbImeModela = new System.Windows.Forms.Label();
            this.tbNovoIme = new System.Windows.Forms.TextBox();
            this.lbOpisModela = new System.Windows.Forms.Label();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbKorisnik
            // 
            this.lbKorisnik.AutoSize = true;
            this.lbKorisnik.Location = new System.Drawing.Point(16, 19);
            this.lbKorisnik.Name = "lbKorisnik";
            this.lbKorisnik.Size = new System.Drawing.Size(35, 13);
            this.lbKorisnik.TabIndex = 0;
            this.lbKorisnik.Text = "label1";
            // 
            // lbKategorija
            // 
            this.lbKategorija.AutoSize = true;
            this.lbKategorija.Location = new System.Drawing.Point(16, 46);
            this.lbKategorija.Name = "lbKategorija";
            this.lbKategorija.Size = new System.Drawing.Size(35, 13);
            this.lbKategorija.TabIndex = 1;
            this.lbKategorija.Text = "label2";
            // 
            // btnNadji
            // 
            this.btnNadji.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNadji.Location = new System.Drawing.Point(186, 75);
            this.btnNadji.Name = "btnNadji";
            this.btnNadji.Size = new System.Drawing.Size(105, 22);
            this.btnNadji.TabIndex = 2;
            this.btnNadji.Text = "Nađi na disku";
            this.btnNadji.UseVisualStyleBackColor = true;
            this.btnNadji.Click += new System.EventHandler(this.btnNadji_Click);
            // 
            // tbLokacija
            // 
            this.tbLokacija.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLokacija.Location = new System.Drawing.Point(17, 101);
            this.tbLokacija.Name = "tbLokacija";
            this.tbLokacija.Size = new System.Drawing.Size(274, 20);
            this.tbLokacija.TabIndex = 3;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(19, 275);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(272, 143);
            this.flowLayoutPanel.TabIndex = 4;
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpload.Location = new System.Drawing.Point(186, 439);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(105, 30);
            this.btnUpload.TabIndex = 5;
            this.btnUpload.Text = "Upload!";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_click);
            // 
            // lbIzvorisnaLokacija
            // 
            this.lbIzvorisnaLokacija.AutoSize = true;
            this.lbIzvorisnaLokacija.Location = new System.Drawing.Point(16, 80);
            this.lbIzvorisnaLokacija.Name = "lbIzvorisnaLokacija";
            this.lbIzvorisnaLokacija.Size = new System.Drawing.Size(88, 13);
            this.lbIzvorisnaLokacija.TabIndex = 6;
            this.lbIzvorisnaLokacija.Text = "Izvorišna lokacija";
            // 
            // lbImeNovogFoldera
            // 
            this.lbImeNovogFoldera.AutoSize = true;
            this.lbImeNovogFoldera.Location = new System.Drawing.Point(26, 142);
            this.lbImeNovogFoldera.Name = "lbImeNovogFoldera";
            this.lbImeNovogFoldera.Size = new System.Drawing.Size(132, 13);
            this.lbImeNovogFoldera.TabIndex = 7;
            this.lbImeNovogFoldera.Text = "Ime novog foldera na bazi:";
            // 
            // tbFolder
            // 
            this.tbFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFolder.Location = new System.Drawing.Point(164, 139);
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.Size = new System.Drawing.Size(127, 20);
            this.tbFolder.TabIndex = 8;
            // 
            // lbSadrzaj
            // 
            this.lbSadrzaj.AutoSize = true;
            this.lbSadrzaj.Location = new System.Drawing.Point(16, 259);
            this.lbSadrzaj.Name = "lbSadrzaj";
            this.lbSadrzaj.Size = new System.Drawing.Size(45, 13);
            this.lbSadrzaj.TabIndex = 9;
            this.lbSadrzaj.Text = "Sadržaj:";
            // 
            // lbImeModela
            // 
            this.lbImeModela.AutoSize = true;
            this.lbImeModela.Location = new System.Drawing.Point(26, 175);
            this.lbImeModela.Name = "lbImeModela";
            this.lbImeModela.Size = new System.Drawing.Size(99, 13);
            this.lbImeModela.TabIndex = 10;
            this.lbImeModela.Text = "Ime vašeg modela: ";
            // 
            // tbNovoIme
            // 
            this.tbNovoIme.Location = new System.Drawing.Point(131, 172);
            this.tbNovoIme.Name = "tbNovoIme";
            this.tbNovoIme.Size = new System.Drawing.Size(160, 20);
            this.tbNovoIme.TabIndex = 11;
            // 
            // lbOpisModela
            // 
            this.lbOpisModela.AutoSize = true;
            this.lbOpisModela.Location = new System.Drawing.Point(26, 203);
            this.lbOpisModela.Name = "lbOpisModela";
            this.lbOpisModela.Size = new System.Drawing.Size(128, 13);
            this.lbOpisModela.TabIndex = 12;
            this.lbOpisModela.Text = "Kratki opis vašeg modela:";
            // 
            // tbOpis
            // 
            this.tbOpis.Location = new System.Drawing.Point(29, 219);
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(261, 20);
            this.tbOpis.TabIndex = 13;
            // 
            // UploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 481);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.lbOpisModela);
            this.Controls.Add(this.tbNovoIme);
            this.Controls.Add(this.lbImeModela);
            this.Controls.Add(this.lbSadrzaj);
            this.Controls.Add(this.tbFolder);
            this.Controls.Add(this.lbImeNovogFoldera);
            this.Controls.Add(this.lbIzvorisnaLokacija);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.tbLokacija);
            this.Controls.Add(this.btnNadji);
            this.Controls.Add(this.lbKategorija);
            this.Controls.Add(this.lbKorisnik);
            this.Name = "UploadForm";
            this.Text = "UploadForm";
            this.Load += new System.EventHandler(this.UploadForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbKorisnik;
        private System.Windows.Forms.Label lbKategorija;
        private System.Windows.Forms.Button btnNadji;
        private System.Windows.Forms.TextBox tbLokacija;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lbIzvorisnaLokacija;
        private System.Windows.Forms.Label lbImeNovogFoldera;
        private System.Windows.Forms.TextBox tbFolder;
        private System.Windows.Forms.Label lbSadrzaj;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lbImeModela;
        private System.Windows.Forms.TextBox tbNovoIme;
        private System.Windows.Forms.Label lbOpisModela;
        private System.Windows.Forms.TextBox tbOpis;
    }
}