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

namespace WindowsFormsApplication1
{
    public partial class DownloadForm:Form
    {
        public DownloadForm()
        {
            InitializeComponent();
        }

        public List<object> checkBoxList;

        public string[] contents;
     
        private void DownloadForm_Load(object sender, EventArgs e)
        {
            //U load funkciji moramo postaviti određen broj checkboxeva u Flow kontrolu,
            //znači prvo moramo odrediti što je na prošloj formi bilo selektirano kao model,
            //te provjeriti što sve u njegovom folderu postoji za downloadati. 

            //Kreiramo listu referenci na Checkbox objekte tako da kasnije u drugoj funkciji možemo
            //provjeriti njihov .Checked property.
            checkBoxList = new List<object>();

            //Daj sve fajlove u PathTODownloadable, koji se postavlja svaki puta kad odaberemo
            //nešto novo iz DataGridView na glavnoj formi
            contents = Directory.GetFiles(ControlData.PathToDownloadable);

            //Za svaki fajl, kreiraj novi checkbox sa njegovim imenom i dodaj u popis i u Flow kontrolu.
            for ( int i = 0; i < contents.Length; i++ )
            {
                CheckBox box = new CheckBox();
                box.Checked = false;

                string[] name = contents[i].Split('\\');
                box.Text = name[name.Length - 1];
                box.Parent = flowLayoutPanel1;
                box.Width = box.Parent.Width;

                flowLayoutPanel1.Controls.Add(box);
                checkBoxList.Add(box);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Kad kliknemo download, moramo odrediti sljedeće:
            // - što je sve označeno u checkboxevima
            // - gdje ćemo spremiti fajlove
            // - gdje se nalaze fajlovi i spremiti ih u odabrani folder

            //Kreiramo novu listu poteva do fajlova. Ako je checkbox označen, dodajemo put njegovog fajla
            //u listu
            List<string> downloadNames = new List<string>();

            for ( int i = 0; i < checkBoxList.Count; i++ )
            {
                if ( ((CheckBox)checkBoxList[i]).Checked )
                    downloadNames.Add(contents[i]);
                
            }

            //Ako smo označili bilo što,
            if ( downloadNames.Count > 0 )
            {
                //Pokaži dijalog, ako je njegov rezultat OK,
                if ( folderBrowserDialog1.ShowDialog() == DialogResult.OK )
                {
                    //sačuvaj put do odabranog foldera,
                    string path = folderBrowserDialog1.SelectedPath;

                    //I za svaki put od fajla koji je označen,
                    for ( int i = 0; i < downloadNames.Count; i++ )
                    {
                        //Odredi ime fajla skupa sa njegovom extenzijom i kopiraj ga u destination folder.
                        string[] name = downloadNames[i].Split('\\');
                        File.Copy(downloadNames[i], path + "\\" + name[name.Length - 1]);
                    }

                    MessageBox.Show("Download uspješan!");

                }
            }
            else
                MessageBox.Show("Niste odabrali niti jedan file za download.");
        }

        private void DownloadForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help/pomoc.chm", HelpNavigator.TopicId, "40");
        }

        private void DownloadForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(this, "Help/pomoc.chm", HelpNavigator.TopicId, "40");
            e.Cancel = true;
        }
    }
}
