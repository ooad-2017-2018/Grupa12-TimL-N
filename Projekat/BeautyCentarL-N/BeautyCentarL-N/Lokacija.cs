using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOVAVARIJANTA
{
    public class Lokacija
    {
        string drzava;
        string grad;
        string ulicaIBroj;

        public string Drzava { get => drzava; set => drzava = value; }
        public string Grad { get => grad; set => grad = value; }
        public string UlicaIBroj { get => ulicaIBroj; set => ulicaIBroj = value; }
    }
}

