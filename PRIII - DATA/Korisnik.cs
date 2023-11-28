using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIII___DATA
{
    public class BazniEntitet
    {
        
        public DateTime Kreiran { get; set; }
        public int KreiraoId { get; set; }
        public DateTime Modifikovan { get; set; }

        public int ModifikovaoId { get; set; }
    }

    public class Korisnik : BazniEntitet
    {
        public int Id { get; set; }
        public string? Ime { get; set; }
        public string? Prezime { get; set; } 
        public string? KorisnickoIme { get; set; }   
        public string? Lozinka { get; set; }
        public string? Email { get; set; }
        public bool Aktivan { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }


}
