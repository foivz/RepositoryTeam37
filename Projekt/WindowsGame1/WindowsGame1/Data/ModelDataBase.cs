using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace WindowsGame1
{
    public static class ModelDataBase
    {
        public struct Package
        {
            public Model model;
            public Texture2D[] textures;
            public Effect[] shaders;
        }

        public static List<Package> dataBase = new List<Package>();

        /// <summary>
        /// Load test data
        /// </summary>
        /// <param name="con"></param>
        public static void Load(ContentManager con)
        {

            Package temp = new Package();

            temp.model = con.Load<Model>("Models/cubeUV");
            temp.textures = new Texture2D[1];
            temp.textures[0] = con.Load<Texture2D>("Textures/avatar");
            temp.shaders = new Effect[1];
            temp.shaders[0] = con.Load<Effect>("Shaders/GenericShader");

            for (int i = 0; i < temp.model.Meshes.Count; i++)
            {
                for (int x = 0; x < temp.model.Meshes[i].MeshParts.Count; x++)
                {
                    temp.model.Meshes[i].MeshParts[x].Effect = temp.shaders[0];
                }
            }

            dataBase.Add(temp);
        }

        public static void LoadIntoRenderer(int index)
        {
            Renderer.mesh = dataBase[index].model;
            Renderer.shader = dataBase[index].shaders[0];

            for (int i = 0; i < dataBase[index].textures.Length; i++)
            {
                Renderer.shader.Parameters["tex" + i].SetValue(dataBase[index].textures[i]);
            }

        }

        public static void LoadIntoRenderer(int indexOfEntry, int indexOfTexture, int indexOfShader)
        {
            Renderer.mesh = dataBase[indexOfEntry].model;
            Renderer.shader = dataBase[indexOfEntry].shaders[indexOfShader];

            Renderer.shader.Parameters["tex0"].SetValue(dataBase[indexOfEntry].textures[indexOfTexture]);
        }
    }
}
