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

namespace PRIII.WinForm._Studenti
{
    public partial class frmStudentiPredmeti : Form
    {
        private Student? odabraniStudent;

        public frmStudentiPredmeti(Student? odabraniStudent)
        {
            InitializeComponent();
            this.odabraniStudent = odabraniStudent;
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
        }

        private void dgvPolozeniPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmStudentiPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
            UcitajOcjene();
            UcitajPolozenePredmete();
            UcitajPodatke();


        }

        private void UcitajPodatke()
        {
            lblImePrezime.Text = $"{odabraniStudent.Indeks}, {odabraniStudent.Ime}, {odabraniStudent.Prezime}";
            pcbProfilna.Image = odabraniStudent.slika.ToImage();
        }

        private void UcitajOcjene()
        {
            cmbOcjene.DataSource = new List<int>(5) { 6, 7, 8, 9, 10 };

        }

        private void UcitajPredmete()
        {
            cmbPredmeti.UcitajPodatke<Predmet>(InMemoryDB.Predmeti, "Naziv", "Id");
        }

        private void UcitajPolozenePredmete()
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = odabraniStudent.PolozeniPredmeti;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var predmet = cmbPredmeti.SelectedItem as Predmet;

                foreach (var p in odabraniStudent.PolozeniPredmeti)
                {
                    if (predmet.Id == p.PredmetId)
                    {
                        MessageBox.Show($"{Resursi.Get(Kljucevi.DuplicatedValue)}", Resursi.Get(Kljucevi.Info), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                var polozeni = new PolozeniPredmet()
                {

                    Id = odabraniStudent.PolozeniPredmeti.Count + 1,
                    DatumPolaganja = dtmPolaganje.Value,
                    Ocjena = int.Parse(cmbOcjene.Text),
                    Predmet = predmet,
                    PredmetId = predmet.Id,

                };
                odabraniStudent.PolozeniPredmeti.Add(polozeni);
                UcitajPolozenePredmete();

            }
        }
        private bool ValidanUnos()
        {
            return Validator.ProvjeriUnos(cmbPredmeti, errPolozeniPredmet, Kljucevi.MandatoryValue) &&
                Validator.ProvjeriUnos(cmbOcjene, errPolozeniPredmet, Kljucevi.MandatoryValue);
        }
    }
}
