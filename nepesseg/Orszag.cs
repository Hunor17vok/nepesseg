using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nepesseg
{
    internal class Orszag
    {
        
    public string Orszagnev { get; private set; }
        public int Terulet { get; private set; }
        public int Nepesseg { get; private set; }
        public string Fovaros { get; private set; }
        public int FovarosNepesseg { get; private set; }

        public Orszag(string orszagnev, int terulet, int nepesseg, string fovaros, int fovarosNepesseg)
        {
            Orszagnev = orszagnev;
            Terulet = terulet;
            Nepesseg = nepesseg;
            Fovaros = fovaros;
            FovarosNepesseg = fovarosNepesseg;
        }

        public Orszag(string sor)
        {
            string[] a = sor.Split(";");
            Orszagnev = a[0];
            Terulet = int.Parse(a[1]);
            Nepesseg = int.Parse(a[2]);
            Fovaros = a[3];
            FovarosNepesseg = int.Parse(a[4]);
        }

        public override string ToString()
        {
            return "";
        }
    }
}

