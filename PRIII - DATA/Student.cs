using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace PRIII___DATA
{
    public class Student 
    {
        public int Id { get; set; } 
        public string Lozinka { get; set; }
        public string Indeks { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Image slika { get; set; }//
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public bool Aktivan { get; set; }
        public int Semestar { get; set; } // semestarId
     
        public int GradId { get; set; }
        public Grad Grad { get; set; }
        public List<PolozeniPredmet> PolozeniPredmeti { get; set; }

        public Student()
        {
            PolozeniPredmeti=new List<PolozeniPredmet>();
        }
        public override string ToString()
        {
            return $"{Indeks} {Ime} {Prezime}";
        }

    }

    public class PolozeniPredmet
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int PredmetId { get; set; }
        public int Ocjena {get; set; }
        public Student Student { get; set; }    
        public Predmet Predmet { get; set; }    
        public DateTime DatumPolaganja { get; set; }
        public string Napomena { get; set; }

    }
}
