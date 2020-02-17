using ShabanRent.ShabanContext;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShabanRent
{
    public class Student
    {
        public int Id { get; set; }
        public int BrojIndeksa{ get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public virtual Grad Grad { get; set; }
        public decimal Dani { get; set; }
        public string Platiti { get; set; }
        public string Kod{ get; set; }
        //public Image Slika { get; set; }
        public byte[] Slika { get; set; }
        public Datum Datum { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime} ostaje {Dani} dana! {Kod}";
        }

    }
}
