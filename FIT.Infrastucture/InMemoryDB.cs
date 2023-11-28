using PRIII___DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Infrastucture
{
    public class InMemoryDB
    {
       public static List<Korisnik> Korisnici = GenerisiKorisnike();
       public static List<Student> Studenti = GenrisiStudente();
       public static List<Semestar> Semestri = GenerisiSemestre();

       private static List<Semestar> GenerisiSemestre()
       {
           return new List<Semestar>()
           {
               new Semestar()
               {
                   Id=1,
                   Aktivan=true,
                   Oznaka="1.Sem",
                   Opis="Prvi semestar I ciklusa studija"
               },
               new Semestar()
               {
                   Id=2,
                   Aktivan=true,
                   Oznaka="2.Sem",
                   Opis="Prvi semestar II ciklusa studija"
               },
               new Semestar()
               {
                   Id=3,
                   Aktivan=true,
                   Oznaka="3.Sem",
                   Opis="Prvi semestar III ciklusa studija"
               },
               new Semestar()
               {
                   Id=4,
                   Aktivan=true,
                   Oznaka="4.Sem",
                   Opis="Prvi semestar IV ciklusa studija"
               },

           };
       }


       public static List<Student> GenrisiStudente()
       {
           return new List<Student>()
           {
               new Student() {
                   Id = 1, 
                   Aktivan = true, 
                   Email = "admin@edu.fit.ba",
                   Ime="Denis",
                   Indeks="IB2300232",
                   Lozinka = "admin",
                   Prezime = "Music",
                   DatumRodjenja = new DateTime(2000,2,2),
                   Semestar = 1,
                   slika=null
               },
               new Student()
               {
                   Id = 2, 
                   Aktivan = true, 
                   Email = "admin@edu.fit.ba",
                   Ime = "Denis",
                   Indeks = "IB2300232",
                   Lozinka = "admin",
                   Prezime = "Music",
                   DatumRodjenja = new DateTime(2000, 2, 2),
                 Semestar = 1,
                 slika = null
           }
           };
       }

       private static List<Korisnik> GenerisiKorisnike()
        {
            var korisnik = new Korisnik()
            {
                Aktivan = true,
                Email = "admin@edu.fit.ba",
                Id = 1,
                Ime = "Denis",
                KorisnickoIme = "admin",
                Lozinka = "admin",
                Prezime = "Music"
            };
            List<Korisnik> lista = new List<Korisnik>();
            lista.Add(korisnik);
            return lista;
        }
    }
}
