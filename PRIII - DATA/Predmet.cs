﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIII___DATA
{
    public class Predmet
    {
        public int Id {get; set; }
        public string Naziv { get; set; }
        public int Semestar { get; set; }


      
        public override string ToString()
        {
            return $"{Naziv}";
        }
    }
}
