using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace WindowsGame1
{
    public static class Renderer
    {
        public static Matrix
            World = Matrix.Identity,
            view, projection;

        public static Vector3 Camera = new Vector3(30, 15, 30);

        public static Model mesh;
        public static Effect shader;

        public static void ReLoad()
        {
            view = Matrix.CreateLookAt(Camera, Vector3.Zero, Vector3.Up);
            projection = Matrix.CreatePerspectiveFieldOfView(1, ControlData.Width / ControlData.Height, 1f, 1000f);

            if (shader != null)
            {
                shader.Parameters["World"].SetValue(World);
                shader.Parameters["Projection"].SetValue(projection);
                shader.Parameters["View"].SetValue(view);
            }

        }

        public static void CameraRotationUpdate()
        {
            Matrix rotationMatrix = Matrix.CreateRotationY(0.01f);
            Camera = Vector3.Transform(Camera, rotationMatrix);

        }

        public static void ShaderUpdate()
        {

            view = Matrix.CreateLookAt(Camera, Vector3.Zero, Vector3.Up);
            projection = Matrix.CreatePerspectiveFieldOfView(1, ControlData.Width / ControlData.Height, 1f, 1000f);

            shader.Parameters["World"].SetValue(World);
            shader.Parameters["Projection"].SetValue(projection);
            shader.Parameters["View"].SetValue(view);

        }

        public static void Render()
        {
            shader.CurrentTechnique.Passes[0].Apply();
            for (int i = 0; i < mesh.Meshes.Count; i++)
            {
                mesh.Meshes[i].Draw();
            }
        }
    }
}
