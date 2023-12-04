using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIII.WinForm.Helpers
{
    public class Generator
    {
        public static string GetLozinka(int brojZnakova = 15)
        {
            Random rnd=new Random();
            string znakovi = "1234567890qwertzuiopasdfghjklyxcvbnm-_#!?";
            string lozinka = "";
            for (int i = 0; i < brojZnakova; i++)
                lozinka += (znakovi[rnd.Next(0, 40)]).ToString();
            return lozinka;
        }
    }
}
