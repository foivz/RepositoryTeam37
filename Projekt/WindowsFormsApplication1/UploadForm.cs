using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsGame1;
using WindowsGame1.Data;

namespace WindowsFormsApplication1
{
    public partial class UploadForm:Form
    {
        public UploadForm()
        {
            InitializeComponent();
        }

        public List<object> listaCheckBox;
        
        public List<string> Paths;
        public string FBXpath;
        public bool nadjeno = false;

        private void UploadForm_Load(object sender, EventArgs e)
        {
            lbKorisnik.Text = "Upload kao: " + ControlData.Username + ", " + ControlData.tipKorisnika;
            lbKategorija.Text = "Kategorija: " + Manipulator.category[Manipulator.activeCategory - 1];

            listaCheckBox = new List<object>();
            
            Paths = new List<string>();
        }

        private void btnNadji_Click(object sender, EventArgs e)
        {
            if ( folderBrowserDialog1.ShowDialog() == DialogResult.OK )
            {
                tbLokacija.Text = folderBrowserDialog1.SelectedPath;

                listaCheckBox = new List<object>();
                FBXpath = "";
                Paths = new List<string>();

                string[] contents = Directory.GetFiles(tbLokacija.Text);

                for ( int i = 0; i < contents.Length; i++ )
                {
                    string[] split = contents[i].Split('\\');

                    string[] extension = split[split.Length - 1].Split('.');

                    if ( extension[extension.Length - 1].ToLower() == "fbx" )
                    {
                        if ( FBXpath == "" )
                        {
                            FBXpath = contents[i];

                            Paths.Add(contents[i]);

                            CheckBox box = new CheckBox();
                            box.Text = split[split.Length-1];
                            box.Checked = true;
                            box.Enabled = false;
                            box.Parent = flowLayoutPanel;
                            box.Width = box.Parent.Width;

                            flowLayoutPanel.Controls.Add(box);
                            listaCheckBox.Add(box);

                            nadjeno = true;
                        }
                        else
                        {
                            MessageBox.Show("U odabranom folderu je više od jedne FBX datoteke! Odaberite folder samo sa jednim FBX-om. Smije biti više tekstura.");
                            break;
                        }
                    }
                    if ( extension[extension.Length - 1].ToLower() == "png" )
                    {
                        Paths.Add(contents[i]);

                        CheckBox box = new CheckBox();
                        box.Text = split[split.Length-1];
                        box.Checked = false;
                        box.Parent = flowLayoutPanel;
                        box.Width = box.Parent.Width;

                        flowLayoutPanel.Controls.Add(box);
                        listaCheckBox.Add(box);
                    }

                }
            }

            if (!nadjeno)
                MessageBox.Show("Odabrani folder ne sadrži niti jedan FBX fajl. Pobrinite se da odabrani folder sadrži barem jedan FBX fajl i teksture koje želite uploadati!");
        }

        private void btnUpload_click(object sender, EventArgs e)
        {
            if ( nadjeno )
            {
                if ( tbFolder.Text != "" )
                {
                    if (!tbFolder.Text.Contains('\\'))
                    {

                        string destinationDirectory = ControlData.PathToBinary + "\\" + Manipulator.category[Manipulator.activeCategory-1] + "\\" + tbFolder.Text;

                        Directory.CreateDirectory(destinationDirectory);
                        destinationDirectory += "\\";

                        for ( int i = 0; i < listaCheckBox.Count; i++ )
                        {
                            if ( ((CheckBox)listaCheckBox[i]).Checked )
                            {
                                File.Copy(Paths[i], destinationDirectory + ((CheckBox)listaCheckBox[i]).Text);
                            }
                        }
                        //INSERT
                        Forma.DataBaseManager._3D_Adapter.Upload(Manipulator.activeCategory , tbFolder.Text, tbNovoIme.Text, tbOpis.Text, ControlData.korisnikID);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("Ime podfoldera nesmije sadržavati znak \"\\\"");
                }
                else
                    MessageBox.Show("Upišite ime podfoldera u kojem će biti sadržaj vašeg uploada!");

            }
            else
                MessageBox.Show("Molimo odaberite folder pomoću \"Nađi na disku\" opcije." );
        }

     
    }
}
