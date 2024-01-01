using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIII___DATA
{
    public class Uloga
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        
        public ICollection<Student> Student { get; set; } = new HashSet<Student>();

        public override string ToString()
        {
            return Naziv;
        }
    }
}
