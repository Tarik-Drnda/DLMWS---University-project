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
using PRIII___DATA;

namespace PRIII.WinForm.Studenti
{
    public partial class frmStudentNovi : Form
    {
        public frmStudentNovi()
        {
            InitializeComponent();
            GenerisiBrojIndeksa();
        }

        private void btnOdabirSlike_Click(object sender, EventArgs e)
        {
            if (ofdOdabirSlike.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(ofdOdabirSlike.FileName);
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmStudentNovi_Load(object sender, EventArgs e)
        {
            UcitajSemestre();
        }

        private void UcitajSemestre()
        {
            cmbSemestar.DataSource = InMemoryDB.Semestri;
            cmbSemestar.DisplayMember = "Oznaka";
            cmbSemestar.ValueMember = "Id";
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
            txtIndeks.Text = $"{ime}.{prezime}";

        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            GenerisiPodatke();
        }
    }
}
