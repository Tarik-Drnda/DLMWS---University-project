using FIT.Infrastucture;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRIII.WinForm._P8
{
    public partial class P8 : Form
    {
        public P8()
        {
            InitializeComponent();
        }

        private void P8_Load(object sender, EventArgs e)
        {
            var student = (Id: 1, Ime: "Tarik", Prezime: "Drnda", Indeks: "IB220069");
            MessageBox.Show(student.ToString());
            PrihvatiTuple(student);
            var student2 = new
            {
                Id = 1,
                Ime="Denis",
                Prezime="Music",
                Indeks="IB220069"
            };
            var rezultat = from s in InMemoryDB.Studenti
                           where s.Id == 1
                           select new
                           {
                               Id = s.Id,
                               Ime = s.Ime,
                               Prezime = s.Prezime,
                               Indeks = s.Indeks
                           }; 
            var student3 = new
            {
                Id = 1,
                Ime="Denis",
                Prezime="Music",
                Indeks="IB190023"
            };

           
        }
        public (int Id, string ime, string prezime, string indeks)
            PrihvatiTuple((int Id, string ime, string prezime, string indeks) student)
        {
            MessageBox.Show(student.ToString());
            return student;
        }
    }
}
