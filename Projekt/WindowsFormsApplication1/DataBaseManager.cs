using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApplication1;
using WindowsGame1;


namespace Forma
{
        public static class DataBaseManager
        {
            public static WindowsFormsApplication1.Baza1DataSetTableAdapters._3D_objektTableAdapter _3D_Adapter =
                new WindowsFormsApplication1.Baza1DataSetTableAdapters._3D_objektTableAdapter();

            public static WindowsFormsApplication1.Baza1DataSetTableAdapters.kategorijaTableAdapter kategorija_Adapter =
                new WindowsFormsApplication1.Baza1DataSetTableAdapters.kategorijaTableAdapter();

            public static WindowsFormsApplication1.Baza1DataSetTableAdapters.korisnikTableAdapter korisnik_Adapter =
                new WindowsFormsApplication1.Baza1DataSetTableAdapters.korisnikTableAdapter();

            public static WindowsFormsApplication1.Baza1DataSetTableAdapters.tip_korisnikaTableAdapter tipKorisnika_Adapter =
                new WindowsFormsApplication1.Baza1DataSetTableAdapters.tip_korisnikaTableAdapter();

            /// <summary>
            /// Inicira početne vrijednosti potrebne za funkcioniranje programa,
            /// -Connection stringove
            /// -//TO DO - kaj još ide tu
            /// </summary>
            public static void Initialize()
            {
                _3D_Adapter.Connection.ConnectionString = ControlData.ConnectionString;

                korisnik_Adapter.Connection.ConnectionString = ControlData.ConnectionString;

                kategorija_Adapter.Connection.ConnectionString = ControlData.ConnectionString;

                tipKorisnika_Adapter.Connection.ConnectionString = ControlData.ConnectionString;
            }

            /// <summary>
            /// Verificira da li korisnik sa danim parametrima postoji u bazi
            /// </summary>
            /// <param name="Username">Korisničko ime korisnika</param>
            /// <param name="Password">Lozinka korisnika</param>
            public static bool VerifyUser(string Username, string Password)
            {
                Baza1DataSet.korisnikDataTable result = korisnik_Adapter.VerifyUser(Username, Password);

                if (result.Rows.Count == 1)
                {
                    ControlData.Username = Username;

                    ControlData.korisnikID = (int)result[0][4];

                    DataTable tipResult = tipKorisnika_Adapter.GetTipKorisnikabyID((int)result[0][4]);

                    ControlData.tipKorisnika = tipResult.Rows[0][1].ToString();

                    return true;
                }
                else
                    return false;
            }

            public static void Popuni_DGV_Tech(Baza1DataSet referenca)
            {
                _3D_Adapter.FillByCategory(referenca._3D_objekt, 1);
                
            }

            public static void Popuni_DGV_Namjestaj(Baza1DataSet referenca)
            {
                _3D_Adapter.FillByCategory(referenca._3D_objekt, 2);
            }


            public static void Popuni_DGV_Vozila(Baza1DataSet referenca)
            {


                _3D_Adapter.FillByCategory(referenca._3D_objekt, 3);
            }

            public static void Popuni_DGV_Arhitektura(Baza1DataSet referenca)
            {
                _3D_Adapter.FillByCategory(referenca._3D_objekt, 4);

            }

            public static void Popuni_DGV_Primitives(Baza1DataSet referenca)
            {
                _3D_Adapter.FillByCategory(referenca._3D_objekt, 5);

            }

            public static void Popuni_DGV_Ostalo(Baza1DataSet referenca)
            {
                _3D_Adapter.FillByCategory(referenca._3D_objekt, 6);
            }

            public static string GetAutorModela(int ID)
            {
                DataTable autorResult = korisnik_Adapter.GetKorisnikByID(ID);
                return (string)autorResult.Rows[0][1];
            }
        }
    
}
