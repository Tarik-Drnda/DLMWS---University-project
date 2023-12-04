
using FIT.Infrastucture;
using PRIII___DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PRIII.WinForm
{
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            var korisnickoIme = txtKorisnickoIme.Text;
            var lozinka = txtLozinka.Text;

            if (ValidanUnos())
            {
                if (!korisnickoIme.Prazan() && !lozinka.Prazan())
                {
                    foreach (var korisnik in InMemoryDB.Korisnici)
                    {

                        if (korisnickoIme == korisnik.KorisnickoIme && lozinka == korisnik.Lozinka)
                        {
                            if (korisnik.Aktivan)
                            {
                                MessageBox.Show($"{Kljucevi.Welcome} {korisnik}", Resursi.Get(Kljucevi.Info), MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Aplikacija.PrijavljeniKorisnik = korisnik;
                                var glavnaForma = new frmGlavna();
                                glavnaForma.Show();
                            }
                            else
                            {
                                MessageBox.Show($"{korisnik}, {Resursi.Get(Kljucevi.AccountNotActive)}");
                            }
                            return;
                        }
                    }
                    MessageBox.Show($"{Resursi.Get(Kljucevi.UsernameOrPasswordNotValid)}", Resursi.Get(Kljucevi.Warning), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        private bool ValidanUnos()
        {
            return Validator.ProvjeriUnos(txtKorisnickoIme, err, Resursi.Get(Kljucevi.MandatoryValue)) &&
                Validator.ProvjeriUnos(txtLozinka, err, Resursi.Get(Kljucevi.MandatoryValue));
        }

        private void lblRegistracija_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registracija = new frmRegistracija();
            registracija.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void picProfilna_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtKorisnickoIme_TextChanged(object sender, EventArgs e)
        {
        }
    }
    public class Validator
    {
        public static bool ProvjeriUnos(Control kontrola, ErrorProvider err, string poruka)
        {
            bool valid = true;
            if (kontrola is PictureBox && (kontrola as PictureBox).Image == null)
            {
                valid = false;

            }
            else if (kontrola is ComboBox && (kontrola as ComboBox).SelectedIndex < 0)
            {
                valid = false;

            }
            else if (kontrola is TextBox && (kontrola as TextBox).Text.Prazan())
            {
                valid = false;
            }
            if (!valid)
            {
                err.SetError(kontrola, Resursi.Get(poruka));
                return valid;
            }
            return valid;
        }
    }
    public static class Ekstenzije
    {
        public static bool Prazan(this string sadrzaj)
        {
            return string.IsNullOrWhiteSpace(sadrzaj);
        }
    }
    public class Aplikacija
    {
        public static Korisnik PrijavljeniKorisnik { get; set; }

    }

    public class Resursi
    {
        public static ResourceManager Manager = new ResourceManager("PRIII.WinForm.Resource1", Assembly.GetExecutingAssembly());


        public static string Get(string name)
        {
            return Manager.GetString(name);
        }
    }
}
