using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShabanRent
{
     class ListaKorisnika
    {
        public static List<Student> PrijavljeniKorisnici{get;set;}

        static ListaKorisnika()
        {
            PrijavljeniKorisnici = new List<Student>();
            DodajStalneStudente();
        }

        private static void DodajStalneStudente()
        {
            Student s1 = new Student() { Id = 1, Ime = "Muhamed", Prezime = "Halkić", Dani = 30, Kod="#H35HD75"};
            Student s2 = new Student() { Id = 2, Ime = "Tarik", Prezime = "Pašalić", Dani = 30, Kod = "#PO0075" };
            PrijavljeniKorisnici.Add(s1);
            PrijavljeniKorisnici.Add(s2);
        }
    }
}
