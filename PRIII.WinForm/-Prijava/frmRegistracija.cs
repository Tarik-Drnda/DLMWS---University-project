using FIT.Infrastucture;
using PRIII___DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRIII.WinForm
{
    public partial class frmRegistracija : Form
    {
        public frmRegistracija()
        {
            InitializeComponent();
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            GenerisiPodatke();
        }


        private void GenerisiPodatke()
        {
            var ime = txtIme.Text.ToLower();
            var prezime = txtPrezime.Text.ToLower();
            txtEmail.Text = $"{ime}.{prezime}" + Resursi.Get(Kljucevi.EmailDomain);
            txtKorisnickoIme.Text = $"{ime}.{prezime}";

        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            GenerisiPodatke();
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var noviKorisnik = new Korisnik()
                {
                    Aktivan = cbAktivan.Checked,
                    Email = txtEmail.Text,
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Id = InMemoryDB.Korisnici.Count + 1,
                    Lozinka=txtLozinka.Text,
                    KorisnickoIme=txtKorisnickoIme.Text
                };
                InMemoryDB.Korisnici.Add(noviKorisnik);
                Close();
            }
        }

        private bool ValidanUnos()
        {
            return Validator.ProvjeriUnos(txtIme, errorProvider1, Resursi.Get(Kljucevi.MandatoryValue)) &&
                Validator.ProvjeriUnos(txtPrezime, errorProvider1, Resursi.Get(Kljucevi.MandatoryValue))&&
                Validator.ProvjeriUnos(txtEmail, errorProvider1, Resursi.Get(Kljucevi.MandatoryValue))&&
                Validator.ProvjeriUnos(txtKorisnickoIme, errorProvider1, Resursi.Get(Kljucevi.MandatoryValue)) &&
                Validator.ProvjeriUnos(txtLozinka, errorProvider1, Resursi.Get(Kljucevi.MandatoryValue));
        }
    }
}
