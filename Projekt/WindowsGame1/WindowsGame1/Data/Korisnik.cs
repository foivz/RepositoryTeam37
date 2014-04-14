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

        public string korisnickoIme, email;
        public tipKorisnika TipKorisnika;

        public List<Objekt3D> dodaniObjekti = new List<Objekt3D>();

        private string lozinka;

        public Korisnik(string kIme, string password, string _email)
        {
            korisnickoIme = kIme;
            lozinka = password;
            email = _email;

            TipKorisnika = tipKorisnika.Korisnik;
        }



    }
}
