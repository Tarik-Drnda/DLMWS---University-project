using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FIT.Infrastucture;
using Microsoft.EntityFrameworkCore;
using PRIII.WinForm._Studenti;
using PRIII___DATA;

namespace PRIII.WinForm.Studenti
{
    public partial class frmStudentiPretraga : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();
        public frmStudentiPretraga()
        {
            
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudentiPretraga_Load(object sender, EventArgs e)
        {
            UcitajStudente();
            //VarObj();
           // Dynamic();
            //AnonimniTipovi();
            //Linq();
        }

        private void Linq()
        {
            /*
             SELECT *
            FROM Customers
            WHERE PostalCode=postalCode
             */
            var ocjene = new List<int>() { 6, 8, 9, 10, 6, 8, 7 };

            var rez1 = from o in ocjene
                       where o >= 8
                       select o;
            var rez2 = from s in InMemoryDB.Semestri
                       where s.Aktivan == false
                       select new
                       {
                           Id = s.Id,
                           Naziv = s.Oznaka
                       };

        }

        private void AnonimniTipovi()
        {
            var student = new dtoStudent()
            {
                Id = 1,
                Indeks = "190091",
                Ime = "Denis",
                Prezime = "Music",
                semestar = 2,
                DatumPosljednjegPristupa = DateTime.Now
            };
            student.Id = 2;
            PrikaziTuple(student);

            var Denis = new
            {
                Id = 1,
                Indeks = "190091",
                Ime = "Denis",
                Prezime = "Music"
            };
        }

        private dtoStudent PrikaziTuple(dtoStudent student)
        {
            return student;
        }

        private void Dynamic()
        {
            dynamic obj;
            obj = "IB190091";
            obj = new List<int>() { 6, 8, 9, 7, 5 };
            obj = 28.5;
            obj = GetObjekatSaNepostojecomMetodom();
            PrikaziDynamic(obj);


            var expObj1 = new ExpandoObject();

            dynamic expObj = new ExpandoObject();
            expObj.Id = 1;
            expObj.Indeks = "IB190091";
            expObj.Ime = "Denis";
            expObj.Prosjek = 6.7;



            foreach (var par in expObj)
            {
                MessageBox.Show($"{par.Key}->{par.Value}");
            }


            Dictionary<string, int> ocjene = new Dictionary<string, int>();
            ocjene.Add("IB190091", 8);
            ocjene.Add("IB190092", 7);
            ocjene.Add("IB190093", 6);


            //foreach (var par in ocjene)
            //{
            //    MessageBox.Show($"{par.Key}->{par.Value}");
            //}

        }

        private dynamic GetObjekatSaNepostojecomMetodom()
        {
            return new EksterniTip();
        }

        private void VarObj()
        {
            var indeks1 = "IB220069"; // PREPORZNA tip automatski - ne moze biti povratna vrijednost ili tip parametra
            object indeks2 = "IB190091"; // moramo kastati
            PrikaziInfo(indeks2);

        }

        private void PrikaziInfo(object obj)
        {

        }

        private void PrikaziDynamic(dynamic obj)
        {
            obj.NepostojecaMetoda();
        }

        private void UcitajStudente(List<Student> studenti=null)
        {
            var list = baza.Studenti.Include(s => s.Semestar).Include(s=> s.Uloga).ToList();
           
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = list;
        }

        private void btnStudentNovi_Click(object sender, EventArgs e)
        {
            frmStudentNovi frm = new frmStudentNovi();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                UcitajStudente();
            }
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var odabraniStudent = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
            Form forma = null;

            if (dgvStudenti.CurrentCell is DataGridViewButtonCell)
            {
                forma = new frmStudentiPredmeti(odabraniStudent);
            }
            else
            {
                forma = new frmStudentNovi(odabraniStudent);
            }

            forma.ShowDialog();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            var filter = txtFilter.Text.ToLower();
            var rezultat = baza.Studenti.Where(Sadrzi).ToList();

            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = rezultat;
        }
        private bool Sadrzi(Student student) =>
            student.Ime.ToLower().Contains(txtFilter.Text.ToLower()) ||
                student.Prezime.ToLower().Contains(txtFilter.Text.ToLower()) ||
                student.Indeks.ToLower().Contains(txtFilter.Text.ToLower());
    }

    public class EksterniTip
    {
        public void NepostojecaMetoda()
        {
            MessageBox.Show("Hello from NepostojecaMetoda");
        }
    }

    public class dtoStudent
    {
        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int semestar { get; set; }
        public DateTime DatumPosljednjegPristupa { get; set; }

    }
}
