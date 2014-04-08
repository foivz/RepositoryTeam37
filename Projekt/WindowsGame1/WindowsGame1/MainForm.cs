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

        public Game1 game1;
       
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            game1.needsToExit = true;
        }

        private void MainForm_Leave(object sender, EventArgs e)
        {
           
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            
        }

   }
}
