using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FIT.Infrastucture;
using Microsoft.EntityFrameworkCore;
using PRIII.WinForm.Helpers;
using PRIII___DATA;

namespace PRIII.WinForm.Studenti
{
    
    public partial class frmStudentNovi : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();
        private Student _std;
        public frmStudentNovi(Student std=null)
        {
            InitializeComponent();
            GenerisiBrojIndeksa();
            GenerisiLozinku();
            UcitajSemestre();
            _std = std ?? new Student();
        }

        private void GenerisiLozinku()
        {
            txtLozinka.Text = Generator.GetLozinka();
        }
        private void btnOdabirSlike_Click(object sender, EventArgs e)
        {
            if (ofdOdabirSlike.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(ofdOdabirSlike.FileName);
            }

        }

        private void frmStudentNovi_Load(object sender, EventArgs e)
        {
            UcitajSemestre();
            if(_std.Id!=0)
            {
                UcitajPodatkeOStudentu();
            }
        }

        private void UcitajPodatkeOStudentu()
        {
            txtIme.Text = _std.Ime;
            dtpDatumRodjenja.Value=_std.DatumRodjenja;
            txtEmail.Text = _std.Email;
            txtLozinka.Text= _std.Lozinka;
            cbAktivan.Checked=_std.Aktivan;
            cmbSemestar.SelectedIndex = _std.SemestarId;
            txtPrezime.Text= _std.Prezime;
            pbSlika.Image = _std.Slika.ToImage();
            txtIndeks.Text= _std.Indeks;
        }

        private void UcitajSemestre()
        {
            cmbSemestar.UcitajPodatke(baza.Semestri.ToList(), "Oznaka", "Id");
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            GenerisiPodatke();
            GenerisiBrojIndeksa();
        }

        private void GenerisiBrojIndeksa()
        {
            txtIndeks.Text = $"IB{(DateTime.Now.Year - 2000) * 10000 + InMemoryDB.Studenti.Count + 1}";
        }


        private void GenerisiPodatke()
        {
            var ime = txtIme.Text.ToLower();
            var prezime = txtPrezime.Text.ToLower();
            txtEmail.Text = $"{ime}.{prezime}" + Resursi.Get(Kljucevi.EmailDomain);


        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            GenerisiPodatke();
        }

        private void btnNovaLozinka_Click(object sender, EventArgs e)
        {
            GenerisiLozinku();
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                _std.Aktivan = cbAktivan.Checked;
                _std.DatumRodjenja = dtpDatumRodjenja.Value;
                _std.Email = txtEmail.Text;
                _std.Indeks = txtIndeks.Text;
                _std.Lozinka = txtLozinka.Text;
                _std.Prezime = txtPrezime.Text;
                _std.SemestarId = (int)cmbSemestar.SelectedValue;
                _std.Slika = pbSlika.Image.ToByteArray();
                _std.Ime = txtIme.Text;

                if (_std.Id == 0)
                {
                    //_std.Id = InMemoryDB.Studenti.Count+1;
                    //InMemoryDB.Studenti.Add(_std);
                    baza.Studenti.Add(_std);
                   
                }
                else
                {
                    baza.Entry(_std).State = EntityState.Modified;
                }
                baza.SaveChanges();
                this.DialogResult=DialogResult.OK;
                Close();
            }
        }

        private bool ValidanUnos()
        {
            return Validator.ProvjeriUnos(txtIme, errNoviStudent, Resursi.Get(Kljucevi.MandatoryValue)) &&
                   Validator.ProvjeriUnos(txtPrezime, errNoviStudent, Resursi.Get(Kljucevi.MandatoryValue)) &&
                   Validator.ProvjeriUnos(txtEmail, errNoviStudent, Resursi.Get(Kljucevi.MandatoryValue)) &&
                   Validator.ProvjeriUnos(cmbSemestar, errNoviStudent, Resursi.Get(Kljucevi.MandatoryValue)) &&
                   Validator.ProvjeriUnos(txtLozinka, errNoviStudent, Resursi.Get(Kljucevi.MandatoryValue)) &&
                   Validator.ProvjeriUnos(txtIndeks, errNoviStudent, Resursi.Get(Kljucevi.MandatoryValue))  &&
                   Validator.ProvjeriUnos(pbSlika, errNoviStudent, Resursi.Get(Kljucevi.MandatoryValue));

        }
    }
}
