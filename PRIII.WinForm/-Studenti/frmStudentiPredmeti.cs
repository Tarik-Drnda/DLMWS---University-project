using FIT.Infrastucture;
using PRIII.WinForm.Izvjestaji;
using PRIII___DATA;

namespace PRIII.WinForm._Studenti
{
    public partial class frmStudentiPredmeti : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();
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
            pcbProfilna.Image = odabraniStudent.Slika.ToImage();
        }

        private void UcitajOcjene()
        {
            cmbOcjene.DataSource = new List<int>(5) { 6, 7, 8, 9, 10 };

        }

        private void UcitajPredmete()
        {
            cmbPredmeti.UcitajPodatke<Predmet>(baza.Predmeti.ToList(), "Naziv", "Id");
        }

        private void UcitajPolozenePredmete()
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = baza.PolozeniPredmeti.Where(s => s.StudentId == odabraniStudent.Id).ToList();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var predmet = cmbPredmeti.SelectedItem as Predmet;

                foreach (var p in baza.PolozeniPredmeti.ToList())
                {
                    if (predmet.Id == p.PredmetId && odabraniStudent.Id == p.StudentId)
                    {
                        MessageBox.Show($"{Resursi.Get(Kljucevi.DuplicatedValue)}", Resursi.Get(Kljucevi.Info), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                var polozeni = new PolozeniPredmet()
                {

                    DatumPolaganja = dtmPolaganje.Value,
                    Ocjena = int.Parse(cmbOcjene.Text),
                    //Predmet = predmet,
                    PredmetId = predmet.Id,
                    //Student = odabraniStudent,
                    StudentId = odabraniStudent.Id,
                    Napomena = txtNapomena.Text,

                };
                baza.PolozeniPredmeti.Add(polozeni);
                baza.SaveChanges();
                UcitajPolozenePredmete();

            }
        }
        private bool ValidanUnos()
        {
            return Validator.ProvjeriUnos(cmbPredmeti, errPolozeniPredmet, Kljucevi.MandatoryValue) &&
                Validator.ProvjeriUnos(cmbOcjene, errPolozeniPredmet, Kljucevi.MandatoryValue);
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
           
            var dtoPrintObj = new dtoPrint()
            {
                ImePrezime = $"{odabraniStudent.Ime} {odabraniStudent.Prezime}",
                BrojIndeksa = odabraniStudent.Indeks,
                polozeniPredmeti = dgvPolozeniPredmeti.DataSource as List<PolozeniPredmet>,
            };
            var forma = new frmIzvjestaj(dtoPrintObj);
            forma.ShowDialog();
        }
    }

    public class dtoPrint
    { 
        public string ImePrezime { get; set; }
        public string BrojIndeksa { get; set; }
        public List<PolozeniPredmet> polozeniPredmeti { get; set; }
        
    }
}
