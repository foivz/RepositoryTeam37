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

        public string korisnickoIme, lozinka, email;


    }
}
