using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace WindowsGame1
{
    /// <summary>
    /// Glavna klasa XNA dijela projekta, zadužena za crtanje odabranog modela, sa danim shaderom
    /// na ekran pomoću Managed DirectX API-a. Također obavlja jednostavnu rotaciju kamere.
    /// 
    /// Bitno: Tekstura za model se u Shader postavlja drugde.
    /// </summary>
    public static class Renderer
    {
        
        public static Matrix
            World = Matrix.Identity,
            view, projection;
        
        public static Matrix worldRotated = Matrix.CreateRotationX(MathHelper.ToRadians(-90)) * Matrix.CreateTranslation(new Vector3(0f, -10f, 0f));

        public static Vector3 Camera = new Vector3(100, 50, 100);

        public static Model mesh;
        public static Effect shader;
        public static Texture2D cursor;

        public static void ReLoad()
        {
            view = Matrix.CreateLookAt(Camera, Vector3.Zero, Vector3.Up);
            projection = Matrix.CreatePerspectiveFieldOfView(1, ControlData.Width / ControlData.Height, 1f, 5000f);

            if (shader != null)
            {
                shader.Parameters["World"].SetValue(worldRotated);
                shader.Parameters["Projection"].SetValue(projection);
                shader.Parameters["View"].SetValue(view);
                shader.CurrentTechnique = shader.Techniques[0];

                if ( mesh != null )
                {
                    for ( int i = 0; i < mesh.Meshes.Count; i++ )
                    {
                        for ( int x = 0; x < mesh.Meshes[i].MeshParts.Count; x++ )
                        {
                            mesh.Meshes[i].MeshParts[x].Effect = shader;
                        }
                    }

                    
                }
            }

        }

        public static void CameraReload()
        {
            view = Matrix.CreateLookAt(Camera, Vector3.Zero, Vector3.Up);
            projection = Matrix.CreatePerspectiveFieldOfView(1, ControlData.Width / ControlData.Height, 1f, 1000f);

            if ( shader != null )
            {
                shader.Parameters["World"].SetValue(worldRotated);
                shader.Parameters["Projection"].SetValue(projection);
                shader.Parameters["View"].SetValue(view);
                shader.CurrentTechnique = shader.Techniques[0];
            }
        }

        public static void CameraRotationUpdate()
        {
            if ( Mouse.GetState().RightButton != ButtonState.Pressed )
            {
                Matrix rotationMatrix = Matrix.CreateRotationY(0.01f);
                Camera = Vector3.Transform(Camera, rotationMatrix);
            }
        }

        public static void ShaderUpdate()
        {
            if ( !ControlData.LOADING )
            {

                view = Matrix.CreateLookAt(Camera, Vector3.Zero, Vector3.Up);
                projection = Matrix.CreatePerspectiveFieldOfView(1, ControlData.Width / ControlData.Height, 1f, 1000f);

                shader.Parameters["World"].SetValue(worldRotated);
                shader.Parameters["Projection"].SetValue(projection);
                shader.Parameters["View"].SetValue(view);

            }
        }

        public static void Render()
        {
            if ( !ControlData.LOADING )
            {
                shader.CurrentTechnique.Passes[0].Apply();

                for ( int i = 0; i < mesh.Meshes.Count; i++ )
                {
                    mesh.Meshes[i].Draw();
                }
            }

            Game1.spriteBatch.Begin();
            if ( Game1.isFullscreen )
            {
                Game1.spriteBatch.Draw(cursor, new Vector2((float)Input.X, (float)Input.Y), null, Color.White, 0f,
                    new Vector2(cursor.Width / 2, cursor.Height / 2), 1f, SpriteEffects.None, 0f);

            }
            Game1.spriteBatch.End();
        }
    }
}
