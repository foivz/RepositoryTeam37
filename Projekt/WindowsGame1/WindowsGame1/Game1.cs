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
    class User32
    {
        [DllImport("user32.dll")]
        public static extern void SetWindowPos(uint Hwnd, int Level, int X, int Y, int W, int H, uint Flags);
    }
   
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        public static GraphicsDeviceManager graphics;
        public static SpriteBatch spriteBatch;

        public  bool needsToExit = false;

        public Control control;
        public Form gWindow;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

        }

        
        protected override void Initialize()
        {

            base.Initialize();
        }

     
        protected override void LoadContent()
        {
            

            graphics.ApplyChanges();

            control = Form.FromHandle(this.Window.Handle);
            gWindow = control.FindForm();
            gWindow.FormBorderStyle = FormBorderStyle.None;
            gWindow.TopMost = true;

            spriteBatch = new SpriteBatch(GraphicsDevice);
            User32.SetWindowPos((uint)this.Window.Handle, -1, 0, 0, graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight, 0);
            ModelDataBase.Load(Content);
            ModelDataBase.LoadIntoRenderer(0);

        }

     
        protected override void UnloadContent()
        {
           
        }

      
        protected override void Update(GameTime gameTime)
        {
        
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                this.Exit();

            if (Keyboard.GetState().IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Escape))
                this.Exit();

            if (needsToExit) this.Exit();

            System.Drawing.Point location = new System.Drawing.Point(ControlData.X, ControlData.Y);

            gWindow.DesktopLocation = location;
            gWindow.Width = ControlData.Width;
            gWindow.Height = ControlData.Height;


            Renderer.CameraRotationUpdate();
            Renderer.ShaderUpdate();

            base.Update(gameTime);
        }

      
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkGray);

            Renderer.Render();

            base.Draw(gameTime);
        }
    }
}
