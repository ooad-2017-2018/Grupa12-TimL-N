using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOVAVARIJANTA
{
    public class Rezervacija
    {
        string ime;
        string prezime;
        string brojRacuna;
        DateTime datumRezervacije;
        List<Usluga> usluge;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string BrojRacuna { get => brojRacuna; set => brojRacuna = value; }
        public DateTime DatumRezervacije { get => datumRezervacije; set => datumRezervacije = value; }
        public List<Usluga> Usluge { get => usluge; set => usluge = value; }
    }
}
