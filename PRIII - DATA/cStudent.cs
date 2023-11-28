using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIII___DATA
{
    public class cStudent : Osoba
    {
        public cStudent(string id,string ime,string prezime):base(ime,prezime)
        {
            Indeks = id;
        }
        public int[] ocjene = new int[] { 6, 6, 8, 9, 7 };
        public int this[int lokacija]
        {
            get { return ocjene[lokacija]; }
        }
        public string Indeks { get; set; }


        public override string ToString()
        {
            return $"{Indeks} {Ime} {Prezime}";
        }
        public override void info()
        {
            Console.WriteLine($"{Indeks} {Ime} {Prezime}");
        }
    }
    public struct sStudent
    {


        public string Indeks { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int ? Fakultet { get; set; }  

        public override string ToString()
        {
            return $"{Indeks} {Ime} {Prezime}";
        }
    }
}
