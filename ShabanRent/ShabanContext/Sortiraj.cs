using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShabanRent.ShabanContext
{
    class Poredi : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x == null || y == null)
            {
                return 0;
            }

            // "CompareTo()" method 
            return x.CompareTo(y);

        }
    }
    class Sortiraj 
    { 
        public static List<string> Sortiranja { get; set; }

        static Sortiraj()
        {
            Sortiranja = new List<string>();
            DodajSortiranja();
        }

        private static void DodajSortiranja()
        {
            Sortiranja.Add("");
            Sortiranja.Add("uzlazno");
            Sortiranja.Add("silazno");
        }
    }
}
