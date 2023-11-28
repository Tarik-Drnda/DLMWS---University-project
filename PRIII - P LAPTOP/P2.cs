using FIT.Infrastucture;
using PRIII___DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIII___P_LAPTOP
{
    public class P2
    {
        public static void Pokreni()
        {
            //BazniTip();
            //Override();
            //Slojevi();
            //VrijednostiReference();
        }
        private static void VrijednostiReference()
        {
            Student denis1 = new Student("IB220069", "tARUJ", "dRNDA");
            Student denis2 = denis1;

            sStudent jasmin1 = new sStudent() { Indeks = "IB220069", Ime = "Tarik", Prezime = "Drnda" };
            sStudent jasmin2 = jasmin1;
        }
        private static void Slojevi()
        {
            StudentService studentService = new StudentService();
            Student student = studentService.GetByBrojIndeksa("IB22022");
            Console.WriteLine(student);

        }
        public static void Override()
        {
            Student denis = new Student("IB220069", "tARUJ", "dRNDA");

            Console.WriteLine(denis);
        }
        private static void BazniTip()
        {
            int godina = 2023;



        }


        private static void FromObject(object obj)
        {
            if (obj is Student)
                (obj as Student).PredstaviSe();
            else if (obj is int)
                Console.WriteLine("Int");
        }
    }

}
