using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsGame1.Data
{
    public class Korisnik
    {
        public enum tipKorisnika
        {
            Korisnik,
            Moderator,
            Administrator
        }

        private string korisnickoIme;
		private string lozinka;
		private string email;
        public tipKorisnika TipKorisnika;
		private List<Objekt3D> izradeniObjekti = new List<Objekt3D>();

        public Korisnik(string kIme, string password, string _email)
        {
            korisnickoIme = kIme;
            lozinka = password;
            email = _email;

            TipKorisnika = tipKorisnika.Korisnik;
        }

		public void dodaj3DObjekt(Objekt3D objekt)
		{

		}
		
		public List<Objekt3D> Korisnikove3DObjekte()
		{
            List<Objekt3D> lista = new List<Objekt3D>();


            return lista;
		}

    }
}
