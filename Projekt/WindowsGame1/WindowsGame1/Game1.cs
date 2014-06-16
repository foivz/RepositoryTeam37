using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace WindowsGame1
{

    /// <summary>
    /// Pomoćna klasa za postavljanje prioriteta prozora koji prikazuje 3D render.
    /// </summary>
    class User32
    {
        [DllImport("user32.dll")]
        public static extern void SetWindowPos(uint Hwnd, int Level, int X, int Y, int W, int H, uint Flags);
    }
   
    /// <summary>
    /// Primarna klasa XNA Frameworka koja rukuje sa renderiranjem resursa koje postavljamu pomoću MainForm.
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        //Default
        public static GraphicsDeviceManager graphics;
        public static SpriteBatch spriteBatch;
        public static ContentManager content;

        //Kontrolne varijable za vidljivost
        public  bool needsToExit = false;
        public bool needsToMinimize = false;
        

        //Kontrolne varjable za poziciju i veličinu 3D prozora
        public Control control;
        public Form gWindow;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        
        protected override void Initialize()
        {
            content = Content;

            
            base.Initialize();
        }

     
        /// <summary>
        /// Funkcija za učitavanje početnih resursa pri paljenju programa.
        /// </summary>
        protected override void LoadContent()
        {
            //Postavljanje svih početnih postavki pri paljenju programa.
            graphics.ApplyChanges();

            control = Form.FromHandle(this.Window.Handle);
            gWindow = control.FindForm();
            gWindow.FormBorderStyle = FormBorderStyle.None;
            gWindow.TopMost = true;

            spriteBatch = new SpriteBatch(GraphicsDevice);

            //Ovaj dio zove Windows API da mu kaže da 3D render mora uvjek biti "on top" prozor, u protivnom
            //on nestane svaki puta kad se na formi nešto klikne.
            User32.SetWindowPos((uint)this.Window.Handle, -1, 0, 0, graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight, 0);

           
            //Tu samo učitamo standardnu kocku za prikazati, da se nešto renderira prije nego li se spojimo
            //na bazu i odaberemo vlastite modele.
            ModelDataBase.Load(Content);
            ModelDataBase.LoadIntoRenderer(0);

        }

     
        protected override void UnloadContent()
        {
           
        }

        protected override void Update(GameTime gameTime)
        {
            //Provjera kontrolnih petlji za izlaz iz programa (ili samo sakrivanje prozora)

            if (needsToMinimize)
                ((Form)Form.FromHandle(this.Window.Handle)).Visible = false;
            else
                ((Form)Form.FromHandle(this.Window.Handle)).Visible = true;

            if (needsToExit) this.Exit();

            //Premještanje prozora i veličine na nove vrijednosti 
            //Pošto se ovo dešava u svakom update loop, čim pomoću MainForm eventova
            //promjenimo poziciju ili veličinu, promjena se očituje instantno
            System.Drawing.Point location = new System.Drawing.Point(ControlData.X, ControlData.Y);

            gWindow.DesktopLocation = location;
            gWindow.Width = ControlData.Width;
            gWindow.Height = ControlData.Height;

            //Render Update
            Renderer.CameraRotationUpdate();
            Renderer.ShaderUpdate();

            base.Update(gameTime);
        }

      
        //Draw se zove odmah nakon Update petlje, te nakon ove funkcije program miruje dok nije 
        //vrijeme za izcrtati sljedeći frame.
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkGray);   //Postavljanje pozadinske boje na tamno sivu

            Renderer.Render();                      //Izrenderirati frame sa trenutnim resursima
                                                    //postavljenim u 3D rendereru
            base.Draw(gameTime);                    
        }
    }
}
