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
       
        //Event za pokretanje Forme - odmah pokrećemo novi thread koji sadrži 
        //XNA Game program. Ovo moramo raditi na novom threadu preko lambde,
        //u protivnom se Windows žali da nemožemo pokrenuti dva identična 
        //"Message pump" objekta u paraleli na istom threadu. 
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza1DataSet._3D_objekt' table. You can move, or remove it, as needed.
            //this._3D_objektTableAdapter.Fill(this.baza1DataSet._3D_objekt);

            //Moramo znati gdje nam je lokalni filesystem odma u startu.
            ControlData.DajPutDoBinary();
            Manipulator.contentBuilder = new ContentBuilder();

            Thread game = new Thread(() =>

            {
                game1 = new Game1();
                game1.Run();
            });

            game.Start();

            RemakeWindow();

            toolStripStatusLabel1.Text = "Spreman";
            toolStripStatusLabel2.Text = "";
            
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
            game1.needsToExit = true;
        }

        private void MainForm_Leave(object sender, EventArgs e)
        {
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
                toolStripStatusLabel1.Text = "Dohvaćam popis iz baze...";
                toolStripStatusLabel1.Invalidate();
                toolStripStatusLabel2.Text = "Kompajliram XNA resurse...";
                toolStripStatusLabel2.Invalidate();

                Manipulator.DoSelect((int)dataGridView1.SelectedCells[1].Value, (string)dataGridView1.SelectedCells[2].Value);

                treeView1.ImageList = new ImageList();
                treeView1.ImageList.ImageSize = new Size(60, 60);

                for ( int i = 0; i < Manipulator.actualTextures.Count; i++ )
                {
                    treeView1.Nodes.Add(i.ToString(), Manipulator.actualTextures[i], i);
                    treeView1.Nodes[i].SelectedImageIndex = i;
                    treeView1.ImageList.Images.Add(Manipulator.texThumbnail[i]);
                }
                toolStripStatusLabel1.Text = "Gotovo!";
                toolStripStatusLabel2.Text = "Dohvaćeno " + treeView1.Nodes.Count + " tekstura za " + (string)dataGridView1.SelectedCells[2].Value;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Manipulator.DoSelectTex(e.Node.Index);
          
        }
   }
}
