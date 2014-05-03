using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsGame1.Data
{
    public class BazaPodataka
    {
		private SqlConnection baza;
		private string bazaPutanja;
        private static BazaPodataka instanca;
		
		public static BazaPodataka dohvatiInstancu(string adresa)
		{
			if (instanca == null)
			{
				instanca = new BazaPodataka(adresa);
			}
			return instanca;
		}
		
		private BazaPodataka(string adresa)
		{
		}
		
		public int unos(Korisnik korisnik)
		{
		}
		
		public int azuriraj(Korisnik korisnik)
		{
		}
		
		public int brisi(Korisnik korisnik)
		{
		}
		
		public List<Korisnik> dohvatiKorisnike()
		{
		}
		
		public int unos(Objekt3D objekt)
		{
		}
		
		public int azuriraj(Objekt3D objekt)
		{
		}
		
		public int brisi(Objekt3D objekt)
		{
		}
		
		public List<Objekt3D> dohvati3DObjekte()
		{
		}

    }
}
