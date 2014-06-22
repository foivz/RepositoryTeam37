using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Xna.Framework.Graphics;
using System.IO;
using Microsoft.Xna.Framework;
using WindowsGame1;
using WindowsGame1.Data;
using WindowsFormsApplication1;

namespace Forma
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Pravimo novu referencu na naš XNA Game projekt, pomoću ove reference
        //kasnije možemo mjenjati parametre našeg 3D rendera 
        public Game1 game1;
        public Thread game;
       
        //Event za pokretanje Forme - odmah pokrećemo novi thread koji sadrži 
        //XNA Game program. Ovo moramo raditi na novom threadu preko lambde,
        //u protivnom se Windows žali da nemožemo pokrenuti dva identična 
        //"Message pump" objekta u paraleli na istom threadu. 
        private void MainForm_Load(object sender, EventArgs e)
        {

            ControlData.DajPutDoBinary();
            ControlData.DajPutDoBaze();

            ControlData.ConnectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + ControlData.PathToMDF + ";Integrated Security=True;Connect Timeout=30"; 

            //Moramo znati gdje nam je lokalni filesystem odmah u startu.
            

            Manipulator.contentBuilder = new ContentBuilder();

            game = new Thread(() =>

            {
                game1 = new Game1();
                game1.Run();
            });



            _3D_objektTableAdapter.Connection.ConnectionString = ControlData.ConnectionString;
            korisnikTableAdapter1.Connection.ConnectionString = ControlData.ConnectionString;

            toolStripStatusLabel1.Text = "Spreman.";
            toolStripStatusLabel2.Text = "Molim, loginajte se pomoću vaših korisničkih podataka.";
            listBox1.Items.Clear();

            menuStrip1.Items[0].Enabled = false;
            menuStrip1.Items[1].Enabled = false;
            menuStrip1.Items[3].Enabled = false;
            downloadToolStripMenuItem.Enabled = false;

            this.TopMost = false;
        }

        void MainForm_GotFocus(object sender, EventArgs e)
        {
          
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            RemakeWindow();
        }

        //Ova funkcija se zove iz Forme svaki puta kada je potrebno promjeniti 3D render 
        //poziciju i veličinu:
        //Pri resize eventu od Forme, i pri Location Changed eventu.
        public  void RemakeWindow()
        {
            ControlData.X = splitContainer1.Panel2.Bounds.X + this.Location.X + 5;
            ControlData.Y = splitContainer1.Panel2.Bounds.Y + this.Location.Y + 30;

            ControlData.Width = splitContainer1.Panel2.Width + 3;
            ControlData.Height = splitContainer1.Panel2.Height - 50;

            Renderer.ReLoad();

        }

        private void splitContainer1_Panel2_SizeChanged(object sender, EventArgs e)
        {
            RemakeWindow();
        }

        //Dvije kontrolne varijable koje se prosljeđuju XNA Game programu, 
        //koji mu kažu da li treba biti vidljiv, i da li treba prekinuti izvođenje.
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (game1 != null)
            game1.needsToExit = true;
        }

        private void MainForm_Leave(object sender, EventArgs e)
        {
            if ( game1 != null )
            game1.needsToMinimize = true;
        }


        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
           
        }

        //Popuni DGW: Tehnologija
        private void kategorija1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Dohvaćam popis iz baze...";
            toolStripStatusLabel1.Invalidate();
            this._3D_objektTableAdapter.FillByCategory(this.baza1DataSet._3D_objekt, 1);
            toolStripStatusLabel1.Text = "Dohvaćeno " + dataGridView1.RowCount.ToString() + " modela";
        }

        //Popuni DGW: Namjestaj
        private void namjestajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            toolStripStatusLabel1.Text = "Dohvaćam popis iz baze...";
            toolStripStatusLabel1.Invalidate();
            this._3D_objektTableAdapter.FillByCategory(this.baza1DataSet._3D_objekt, 2);
            toolStripStatusLabel1.Text = "Dohvaćeno " + dataGridView1.RowCount.ToString() + " modela";
        }

        //Popuni DGW: Vozila
        private void vozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Dohvaćam popis iz baze...";
            toolStripStatusLabel1.Invalidate();
            this._3D_objektTableAdapter.FillByCategory(this.baza1DataSet._3D_objekt, 3);
            toolStripStatusLabel1.Text = "Dohvaćeno " + dataGridView1.RowCount.ToString() + " modela";
        }

        //Popuni DGW: Arhitektura
        private void arhitekturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Dohvaćam popis iz baze...";
            toolStripStatusLabel1.Invalidate();
            this._3D_objektTableAdapter.FillByCategory(this.baza1DataSet._3D_objekt, 4);
            toolStripStatusLabel1.Text = "Dohvaćeno " + dataGridView1.RowCount.ToString() + " modela";
        }

        //Popuni DGW: Primitives
        private void primitivesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Dohvaćam popis iz baze...";
            toolStripStatusLabel1.Invalidate();
            this._3D_objektTableAdapter.FillByCategory(this.baza1DataSet._3D_objekt, 5);
            toolStripStatusLabel1.Text = "Dohvaćeno " + dataGridView1.RowCount.ToString() + " modela";
        }

        //Popuni DGW: Ostalo/Misc
        private void ostaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Dohvaćam popis iz baze...";
            toolStripStatusLabel1.Invalidate();
            this._3D_objektTableAdapter.FillByCategory(this.baza1DataSet._3D_objekt, 6);
            toolStripStatusLabel1.Text = "Dohvaćeno " + dataGridView1.RowCount.ToString() + " modela";
        }

        //DGW click
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

            if ( dataGridView1.SelectedCells.Count > 0 )
            {
                //Postavi tooltipove
                toolStripStatusLabel1.Text = "Dohvaćam popis iz baze...";
                toolStripStatusLabel1.Invalidate();
                toolStripStatusLabel2.Text = "Kompajliram XNA resurse...";
                toolStripStatusLabel2.Invalidate();

                //Pokreni Manipulator, da možemo kompajlirati resurse.
                Manipulator.DoSelect((int)dataGridView1.SelectedCells[1].Value, (string)dataGridView1.SelectedCells[2].Value);

                //Napravi novu image listu i postavi 50x50 pixel thumbnail
                treeView1.ImageList = new ImageList();
                treeView1.ImageList.ImageSize = new Size(50, 50);

                //Dodaj teksture u popis
                for ( int i = 0; i < Manipulator.actualTextures.Count; i++ )
                {
                    treeView1.Nodes.Add(i.ToString(), Manipulator.actualTextures[i], i);
                    treeView1.Nodes[i].SelectedImageIndex = i;
                    treeView1.ImageList.Images.Add(Manipulator.texThumbnail[i]);
                }   
                //Postavi tooltipove da znamo da je gotovo.
                toolStripStatusLabel1.Text = "Gotovo!";
                toolStripStatusLabel2.Text = "Dohvaćeno " + treeView1.Nodes.Count + " tekstura za " + (string)dataGridView1.SelectedCells[2].Value;

                //Napiši autora 3D modela ispod rendera
                DataTable autorResult = korisnikTableAdapter1.GetKorisnikByID((int)dataGridView1.SelectedCells[5].Value);
                
                txtAutor.Text = "Autor: " + (string)autorResult.Rows[0][1];

                //Osposobi download i daj shadere u popis.
                downloadToolStripMenuItem.Enabled =  true;
                listBox1.Items.Clear();
                listBox1.Items.Add("Diffuse");
                listBox1.Items.Add("Transparent");
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Postavi novu odabranu teksturu
            Manipulator.DoSelectTex(e.Node.Index);
        }

        private void fullscreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Trebamo ići u fullscreen?
            game1.raiseFullscreen = true;
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Download: minimizamo render (da ne smeta) i pokrenemo Download dialog.
            game1.needsToMinimize = true;
            DownloadForm form = new DownloadForm();
            form.ShowDialog();
            game1.needsToMinimize = false;

        }

        private void logInToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Nova log in forma
            LoginForm logForma = new LoginForm();

            Manipulator.activeCategory = -1;
            //Počisti popis shadera, i onesposobi sve main menu opcije 
            // U principu, vrsta "Log out" operacije.
            listBox1.Items.Clear();
            menuStrip1.Items[0].Enabled = false;
            menuStrip1.Items[1].Enabled = false;
            downloadToolStripMenuItem.Enabled = false;

            if ( logForma.ShowDialog() == System.Windows.Forms.DialogResult.OK )
            {
                menuStrip1.Items[0].Enabled = true;
                menuStrip1.Items[3].Enabled = true;


                if ( ControlData.tipKorisnika != "Korisnik" )
                {
                    //Ako nije korisnik, omogući i upload.
                    menuStrip1.Items[1].Enabled = true;
                }

                game.Start();
                RemakeWindow();

                toolStripStatusLabel1.Text = "Dobrodošao, " + ControlData.tipKorisnika + " " + ControlData.Username + ".";
                toolStripStatusLabel2.Text = "";
            }
        }

        private void kreirajteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAccount form = new CreateAccount();
            form.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Postavi odabrani shader.
            if ( listBox1.SelectedIndex == 0 )
                Renderer.UseShaderDiffuse();
            if ( listBox1.SelectedIndex == 1 )
                Renderer.UseShaderTransparent();
        }

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game1.needsToMinimize = true;

            if ( Manipulator.activeCategory != -1)
            {
               
                UploadForm form = new UploadForm();

                if ( form.ShowDialog() == DialogResult.OK )
                {
                    MessageBox.Show("Upload uspješan!");
                }

                
            }
            else
                MessageBox.Show("Izaberite prvo kategoriju!");

            game1.needsToMinimize = false;
            
        }

        
   }
}
