using PRIII___DATA;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIII___P_LAPTOP
{
    public class AppData
    {
        public const string Naziv= "FITApp";
        public readonly string Autor;
        public AppData(string autor) 
        {
            Autor = autor;
        }
        public override string ToString()
        {

            return base.ToString();
        }

    }
    public class P3
    {
        public static void Pokreni()
        {
            // Var();
            //Imutabilnost();
            // Params();
            //Indekseri();
            // Nasljedjivanje();
           
            Interfejsi();
        }

        public static void OsobaInfo(Osoba osoba)
        {
            if (osoba is Student)
                Console.WriteLine(((cStudent)osoba).Indeks);
            else
                Console.WriteLine(osoba);
        }
        public static void Interfejsi()
        {

        }
        private static void Nasljedjivanje() 
        {
            //Osoba denis =new Osoba("Denis","Music");
            Osoba jasmin = new cStudent("IB220069","dENIS","pREZIME");
            OsobaInfo(jasmin);


        }
        private static void Indekseri()
        {
            cStudent denis=new cStudent("IB220069", "tARUJ", "dRNDA");
            Console.WriteLine(denis[1]);
        }
        private static void Imutabilnost()
        {
            string fit = "Fakultet informacijskih tehnologija";
            fit=fit.ToUpper();
            Console.WriteLine(fit);

            DateTime danas=DateTime.Now;
            var za156dana=danas.AddDays(156);
            Console.WriteLine(danas);
            Console.WriteLine(za156dana);
        }

        private static void Params()
        {
            Console.WriteLine($"Suma - > {Sumiraj(new int[] { 2, 6, 9, 8, 11 })}");
            Console.WriteLine($"Suma - > {Sumiraj(2, 6, 9, 8, 11,12,66)}");
            var noviString=string.Join("-", 2, 6, 9, 8, 22);
            Console.WriteLine(noviString);
        }
        private static object Sumiraj(params int[] niz)
        {
            int suma = 0;
            for(int i = 0;i<niz.Length;i++)
            {
                suma += niz[i];
            }
            return suma;
        }
        private static void Var()  
        {
            int a = 0;
            var b = 0;
            var denis = new cStudent("IB220069","tARIK","dRNDA");
            var ime = "Denis";

            var podaci = GetPodatkeByGodina(1);
        }

        private static object GetPodatkeByGodina(int v)
        {
            return new string[] { };
        }
    }
}
