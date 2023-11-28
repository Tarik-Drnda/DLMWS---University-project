using PRIII___DATA;

namespace FIT.Infrastucture
{
    public class KonekcijaNaBazu
    {

    }
    public class StudentService
    {
        KonekcijaNaBazu db = new KonekcijaNaBazu();
        public cStudent GetByBrojIndeksa(string indeks)
        {
            cStudent student = new cStudent("IB220069", "tARUJ", "dRNDA");
         
            return student;
        }
        public List<Student> GetByGodinaStudija(int godinaStudija)
        {
            int brojac = 0;
            //return new List<Student>()
            //{
            //    new Student() {Indeks=$"IB{230000+brojac}", Ime=$"ime{brojac}",Prezime=$"Prezime{brojac++}" },
            //    new Student() {Indeks=$"IB{230000+brojac}", Ime=$"ime{brojac}",Prezime=$"Prezime{brojac++}" },
            //    new Student() {Indeks=$"IB{230000+brojac}", Ime=$"ime{brojac}",Prezime=$"Prezime{brojac++}" },
            //};
            List<Student> list = new List<Student>();
            //list.Add(new Student() { Indeks = $"IB{230000 + brojac}", Ime = $"ime{brojac}", Prezime = $"Prezime{brojac++}" });
            //list.Add(new Student() { Indeks = $"IB{230000 + brojac}", Ime = $"ime{brojac}", Prezime = $"Prezime{brojac++}" });
            //list.Add(new Student() { Indeks = $"IB{230000 + brojac}", Ime = $"ime{brojac}", Prezime = $"Prezime{brojac++}" });
            return list;
        }
    }
}