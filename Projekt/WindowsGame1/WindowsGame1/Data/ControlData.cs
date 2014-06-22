using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsGame1
{
    public static class ControlData
    {
        public static int X = 0, Y = 0, Width = 0, Height = 0;


        public static string ConnectionString;
        //Korisnicki podaci:
        public static string Username, tipKorisnika;

        public static bool LOADING = false;

        /// <summary>
        /// Put do offline Binary foldera u kojem se nalaze naši resursi
        /// </summary>
        public static string PathToBinary = "";
        public static string PathToMDF = "";

        public static string PathToDownloadable = "";


        /// <summary>
        /// Formira apsolutni path string do Binary foldera.
        /// </summary>
        public static void DajPutDoBinary()
        {
            //Počinjemo od executable lokacije, idemo 5 levela gore, pa onda u Binary folder.

            string path = Application.ExecutablePath;
            DirectoryInfo info = System.IO.Directory.GetParent(path);

            for ( int i = 0; i < 4; i++ )
            {
                info = info.Parent;
            }

            path = info.FullName;
            PathToBinary = path + "\\Binary\\";
        }

        public static void DajPutDoBaze()
        {
            string path = Application.ExecutablePath;
            DirectoryInfo info = System.IO.Directory.GetParent(path);

            for ( int i = 0; i < 4; i++ )
            {
                info = info.Parent;
            }

            path = info.FullName;
            PathToMDF = path + "\\Baza\\Baza1.mdf";
        }
        

    }
}
