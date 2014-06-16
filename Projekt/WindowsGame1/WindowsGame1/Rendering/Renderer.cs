using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

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

        public static Matrix worldRotated = Matrix.CreateRotationX(MathHelper.ToRadians(-90));

        public static Vector3 Camera = new Vector3(100, 50, 100);

        public static Model mesh;
        public static Effect shader;

        public static void ReLoad()
        {
            view = Matrix.CreateLookAt(Camera, Vector3.Zero, Vector3.Up);
            projection = Matrix.CreatePerspectiveFieldOfView(1, ControlData.Width / ControlData.Height, 1f, 1000f);

            if (shader != null)
            {
                shader.Parameters["World"].SetValue(worldRotated);
                shader.Parameters["Projection"].SetValue(projection);
                shader.Parameters["View"].SetValue(view);

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

        public static void CameraRotationUpdate()
        {
            Matrix rotationMatrix = Matrix.CreateRotationY(0.01f);
            Camera = Vector3.Transform(Camera, rotationMatrix);

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
        }
    }
}
