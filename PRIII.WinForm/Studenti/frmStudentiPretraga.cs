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
    public partial class frmStudentiPretraga : Form
    {
        public frmStudentiPretraga()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudentiPretraga_Load(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void UcitajStudente()
        {
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = InMemoryDB.Studenti;
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
            var odabraniStudent= dgvStudenti.SelectedRows[0].DataBoundItem as Student;
            frmStudentNovi frmEdit = new frmStudentNovi(odabraniStudent);
            frmEdit.ShowDialog();
        }
    }
}
