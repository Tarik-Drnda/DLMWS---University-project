using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            dgvPolozeniPredmeti.DataSource = null;
        }

        private void dgvPolozeniPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmStudentiPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPolozenePredmete();

        }

        private void UcitajPolozenePredmete()
        {
            dgvPolozeniPredmeti.DataSource = odabraniStudent.PolozeniPredmeti;
        }
    }
}
