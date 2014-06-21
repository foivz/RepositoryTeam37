using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsGame1
{
    public static class Input
    {
        public static KeyboardState lastKState;
        public static MouseState lastMState;
        public static int X, Y;
        public static int ScrollValue = 0;

        public static void Update()
        {
            //Daj input sa miša
            int tempX, tempY;

            tempX = Mouse.GetState().X;
            tempY = Mouse.GetState().Y;

            int actX, actY;

            actX = tempX - X;
            actY = tempY - Y;

            int actualScroll = Mouse.GetState().ScrollWheelValue;


            //Input sa tipkovnice
            KeyboardState tempKstate = Keyboard.GetState();

            if ( tempKstate.IsKeyDown(Keys.Escape) )
            {
                if ( !lastKState.IsKeyDown(Keys.Escape) )
                    Game1.lowerFullscreen = true;
            }


            //Ako je miš unutar 3D ekrana trenutno

            if ( Game1.isFullscreen )
            {
                //Sa right button rotiraj
                if ( Mouse.GetState().RightButton == ButtonState.Pressed )
                {
                    //Influence camera rotation
                    Matrix rotationY = Matrix.CreateRotationY(-(float)actX/100);
                   
                    Renderer.Camera = Vector3.Transform(Renderer.Camera, rotationY);

                    Renderer.CameraReload();
                }

                if ( Mouse.GetState().LeftButton == ButtonState.Pressed )
                {
                    Renderer.worldRotated *= Matrix.CreateTranslation(new Vector3(0, -actY, 0));
                   // Renderer.CameraTarget = Vector3.Transform(Renderer.CameraTarget, Matrix.CreateTranslation(new Vector3(0, -actY, 0)));

                    Renderer.CameraReload();
                }

                //Sa scroll zoomiraj
                if ( actualScroll != ScrollValue )
                {
                    if ( actualScroll < ScrollValue )
                    {
                        Renderer.worldRotated *= Matrix.CreateScale(1.1f);
                        //Renderer.Camera *= new Vector3(1.2f);
                        Renderer.CameraReload();
                    }
                    if ( actualScroll > ScrollValue )
                    {
                        Renderer.worldRotated *= Matrix.CreateScale(0.9f);
                        //Renderer.Camera *= new Vector3(0.8f);
                        Renderer.CameraReload();
                    }
                }

            }

            X = tempX;
            Y = tempY;
            ScrollValue = actualScroll;

            lastKState = tempKstate;
        }
    }
}
