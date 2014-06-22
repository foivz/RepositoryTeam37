using System;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Microsoft.Xna.Framework.Content;
using System.Windows.Forms;
using Microsoft.Xna.Framework.Graphics;
using System.IO;

namespace WindowsGame1.Data
{
    public static class Manipulator
    {
        //Ovo nam treba za izgraditi apsolutni path string do resursa.
        public static string[] category = new string[]
        {
            "01 - Tehnologija",
            "02 - Namjestaj",
            "03 - Vozila",
            "04 - Arhitektura",
            "05 - Primitives",
            "06 - Ostalo"
        };

        //Popisi puteva + popis Imagea za thumbnail u Treeview na glavnoj Formi.
        public static string meshPath;
        public static List<string> actualTextures;
        public static List<string> texturePaths;
        public static List<Image> texThumbnail;

        public static ContentBuilder contentBuilder;


        /// <summary>
        /// Ovo je najbitnija funkcija. Pri selekciji bilo čega iz DataGridViewa se dešava sljedeće:
        /// -Najprije dobivamo preko parametara apsolutni put do foldera gdje su nam odabrani resursi.
        /// -Iz sadržaja foldera određujemo koliko imamo tekstura
        /// -Popunjavamo popis puta do tekstura, i Image resursa.
        /// -Čistimo sve stare foldere i fajlove koje smo izgradili prijašnjim kompajliranjem
        /// -Pokrećemo run-time compiler resursa za pretvaranje FBX i PNG objekata u XNB
        /// -Učitavamo XNB resurse u Renderer da bi ih prikazali na ekran
        /// </summary>
        /// <param name="categoryID">ID kategorije odabranog objekta. Dobiven iz prve ćelije selekcije.</param>
        /// <param name="folderName">Folder name je string iz SQL baze pod imenom "model".</param>
        public static void DoSelect(int categoryID, string folderName)
        {
            //Popisi puteva
            string apsolutePath = ControlData.PathToBinary + category[categoryID - 1] + folderName;
            ControlData.PathToDownloadable = apsolutePath;
            string[] contents = System.IO.Directory.GetFiles(apsolutePath);

            meshPath = "";
            actualTextures = new List<string>();
            texThumbnail = new List<Image>();
            texturePaths = new List<string>();


            //Prepoznavanje sadržaja foldera. 
            for ( int i = 0; i < contents.Length; i++ )
            {
                string[] split = contents[i].Split('.');

                if ( split[split.Length - 1].ToLower() == "png" )
                {
                    string[] fileNameSplit = split[split.Length - 2].Split('\\');
                    actualTextures.Add(fileNameSplit[fileNameSplit.Length-1]);

                    texturePaths.Add(contents[i]);
                    texThumbnail.Add(Image.FromFile(contents[i], true));
                }
                else if ( split[split.Length - 1].ToLower() == "fbx" )
                {
                    meshPath = contents[i];
                }
            }

            //Počisti stare XNB fajlove ako postoje
            string path = contentBuilder.OutputDirectory;
            DirectoryInfo info = new DirectoryInfo(path);
            info = info.Parent;
            info = info.Parent;
            path = info.FullName;

            if ( Directory.Exists(path) ) 
            Directory.Delete(path, true);
          

            //Kompajliraj nove resurse
            contentBuilder.Clear();
            contentBuilder.Add(meshPath, "Model", null, "ModelProcessor");

            for ( int i = 0; i < texturePaths.Count; i++ )
            {
                contentBuilder.Add(texturePaths[i], "tex" + i.ToString(), null, "TextureProcessor");
               
            }

            string error = contentBuilder.Build();

            ControlData.LOADING = true;

            if ( string.IsNullOrEmpty(error) )
            {
                //Pošto koristimo jedan statični mesh u Rendereru, moramo prvo Unloadati sve.
                Game1.content.Unload();
                Renderer.ReloadResources();
                Renderer.ReLoad();
            }
            else
                MessageBox.Show(error);

            ControlData.LOADING = false;

        }

        public static void DoSelectTex(int index)
        {
            Renderer.shader.Parameters["tex0"].SetValue(Game1.content.Load<Texture2D>("..\\build\\content\\tex" + index.ToString()));
            Renderer.ReLoad();
        }
    }
}
