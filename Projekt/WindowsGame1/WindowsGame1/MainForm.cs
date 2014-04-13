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

namespace WindowsGame1
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
            Thread game = new Thread(() =>
            {
                game1 = new Game1();
                game1.Run();
            });

            game.Start();

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
            ControlData.Height = splitContainer1.Panel2.Height;

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

   }
}
