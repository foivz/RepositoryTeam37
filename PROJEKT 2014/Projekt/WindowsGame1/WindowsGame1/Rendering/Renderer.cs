using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using WindowsGame1.Data;

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
        public static Vector3 CameraTarget = Vector3.Zero;

        public static Model mesh;
        public static Effect shader;
        public static Effect transparentShader;
        public static Texture2D cursor;
        public static SpriteFont font;

        public static void ReLoad()
        {
            view = Matrix.CreateLookAt(Camera, CameraTarget, Vector3.Up);
            projection = Matrix.CreatePerspectiveFieldOfView(MathHelper.ToRadians(65), ControlData.Width / ControlData.Height, 1f, 5000f);

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

            if ( transparentShader != null )
            {
                transparentShader.Parameters["World"].SetValue(worldRotated);
                transparentShader.Parameters["Projection"].SetValue(projection);
                transparentShader.Parameters["View"].SetValue(view);

                transparentShader.CurrentTechnique = transparentShader.Techniques[0];

            }

        }

        public static void UseShaderDiffuse()
        {
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

        public static void UseShaderTransparent()
        {
            if ( mesh != null )
            {
                for ( int i = 0; i < mesh.Meshes.Count; i++ )
                {
                    for ( int x = 0; x < mesh.Meshes[i].MeshParts.Count; x++ )
                    {
                        mesh.Meshes[i].MeshParts[x].Effect = transparentShader;
                    }
                }


            }
        }

        public static void ReloadResources()
        {
            //Ovo nam teba dok loadamo noev modele i teksture, prije toga 
            //korisimo Content.Unload() da počistimo bilo kakve zaostatke.
            Renderer.mesh = Game1.content.Load<Model>("..\\build\\content\\Model");
            Renderer.shader = Game1.content.Load<Effect>("Shaders\\GenericShader");
            Renderer.transparentShader = Game1.content.Load<Effect>("Shaders/TransparentShader");
            Renderer.cursor = Game1.content.Load<Texture2D>("Textures/Cursor");
            Renderer.font = Game1.content.Load<SpriteFont>("Fonts/FullscreenFont");

            Texture2D tex;
            if ( Manipulator.texturePaths.Count > 0 )
                tex = Game1.content.Load<Texture2D>("..\\build\\content\\tex0");
            else
                tex = Game1.content.Load<Texture2D>("Textures/Avatar");

            Renderer.shader.Parameters["tex0"].SetValue(tex);
            Renderer.transparentShader.Parameters["tex0"].SetValue(tex);
            Renderer.transparentShader.Parameters["transparency"].SetValue(0.5f);
        }

        public static void CameraReload()
        {
            view = Matrix.CreateLookAt(Camera, CameraTarget, Vector3.Up);
            projection = Matrix.CreatePerspectiveFieldOfView(1, ControlData.Width / ControlData.Height, 1f, 1000f);

            if ( shader != null )
            {
                shader.Parameters["World"].SetValue(worldRotated);
                shader.Parameters["Projection"].SetValue(projection);
                shader.Parameters["View"].SetValue(view);


                shader.CurrentTechnique = shader.Techniques[0];
            }

            if ( transparentShader != null )
            {
                transparentShader.Parameters["World"].SetValue(worldRotated);
                transparentShader.Parameters["Projection"].SetValue(projection);
                transparentShader.Parameters["View"].SetValue(view);

                transparentShader.CurrentTechnique = transparentShader.Techniques[0];
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

                view = Matrix.CreateLookAt(Camera, CameraTarget, Vector3.Up);
                projection = Matrix.CreatePerspectiveFieldOfView(1, ControlData.Width / ControlData.Height, 1f, 1000f);

                if ( shader != null )
                {
                    shader.Parameters["World"].SetValue(worldRotated);
                    shader.Parameters["Projection"].SetValue(projection);
                    shader.Parameters["View"].SetValue(view);
                }

                if ( transparentShader != null )
                {
                    transparentShader.Parameters["World"].SetValue(worldRotated);
                    transparentShader.Parameters["Projection"].SetValue(projection);
                    transparentShader.Parameters["View"].SetValue(view);
                }

            }
        }

        public static void Render()
        {
            if ( !ControlData.LOADING )
            {
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

                Game1.spriteBatch.DrawString(font, "Lijevi klik: pomicanje modela gore-dolje", new Vector2(5, 5), Color.LightGoldenrodYellow);
                Game1.spriteBatch.DrawString(font, "Scroll: zoomiranje", new Vector2(5, 20), Color.LightGoldenrodYellow);
                Game1.spriteBatch.DrawString(font, "Desni klik: Rotiranje modela", new Vector2(5, 35), Color.LightGoldenrodYellow);
                Game1.spriteBatch.DrawString(font, "ESCAPE: izlaz", new Vector2(5, 60), Color.LightGoldenrodYellow);

            }
            Game1.spriteBatch.End();
        }
    }
}
