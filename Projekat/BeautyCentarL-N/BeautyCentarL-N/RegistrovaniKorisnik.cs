using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOVAVARIJANTA
{
    public class RegistrovaniKorisnik: Posjetioc, IPregledRezervacija
    {
        string ime;
        string prezime;
        string email;
        string brojRacuna;
        string sifra;
        string godine;
        List<Rezervacija> rezervacije;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        public string BrojRacuna { get => brojRacuna; set => brojRacuna = value; }
        public string Sifra { get => Sifra1; set => Sifra1 = value; }
        public string Godine { get => godine; set => godine = value; }
        public string Sifra1 { get => sifra; set => sifra = value; }

        public override void PregledSalona() { }
        public string Pregled()
        {
            return "";
        }
    }
}
