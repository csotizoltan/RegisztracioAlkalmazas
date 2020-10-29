using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisztracioAlkalmazas
{
    class Szemely
    {
        private string nev;
        private DateTime szulDatum;
        private string nem;
        private string hobbi;

        public string Nev { get => nev; set => nev = value; }
        public DateTime SzulDatum { get => szulDatum; set => szulDatum = value; }
        public string Nem { get => nem; set => nem = value; }
        public string Hobbi { get => hobbi; set => hobbi = value; }


        public Szemely(string nev, DateTime szulDatum, string nem, string hobbi)
        {
            this.nev = nev;
            this.szulDatum = szulDatum;
            this.nem = nem;
            this.hobbi = hobbi;
        }
    }
}
