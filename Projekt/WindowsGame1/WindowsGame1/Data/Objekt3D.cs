using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace WindowsGame1.Data
{
    public class Objekt3D
    {
        public Model model;
        public Texture2D[] textureArray;
        public Effect[] shaderArray;

        public Objekt3D(Model _model, Texture2D tekstura, Effect shader)
        {
            model = _model;
            textureArray = new Texture2D[1];
            textureArray[0] = tekstura;
            shaderArray = new Effect[1];
            shaderArray[0] = shader;
        }

        public Objekt3D(Model _model, Texture2D[] teksture, Effect[] shaderi)
        {
            model = _model;
            textureArray = teksture;
            shaderArray = shaderi;
        }



    }
}
