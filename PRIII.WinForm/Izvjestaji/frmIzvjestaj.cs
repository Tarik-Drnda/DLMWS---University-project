using Microsoft.Reporting.WinForms;
using PRIII.WinForm._Studenti;
using PRIII.WinForm.Izvjestaji;
using PRIII___DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRIII.WinForm.Izvjestaji
{
    public partial class frmIzvjestaj : Form
    {
        public frmIzvjestaj(dtoPrint dtoPrintObj)
        {
            InitializeComponent();
            this.dtoPrintObj = dtoPrintObj;
        }
        private dtoPrint dtoPrintObj { get; set; }
        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var parametri = new ReportParameterCollection();
            parametri.Add(new ReportParameter("pBrojIndeksa", "IB220069"));
            parametri.Add(new ReportParameter("pImePrezime", "Tarik Drnda"));
            parametri.Add(new ReportParameter("pAkademskaGodina", "2023/24"));
            parametri.Add(new ReportParameter("pStatus", "Student"));
            parametri.Add(new ReportParameter("pSvrha", "Regulisanje stipendije"));
            parametri.Add(new ReportParameter("pBrojDokumenta", "16-10-24-IB220069"));

            var tabela = new DataSet1.PolozeniPredmetiDataTable();

            for(int i=0;i<dtoPrintObj.polozeniPredmeti.Count;i++) 
            {
                var red = tabela.NewPolozeniPredmetiRow();
                red.Rb = dtoPrintObj.polozeniPredmeti[i].Id.ToString();
                red.Ocjena = dtoPrintObj.polozeniPredmeti[i].Ocjena.ToString();
                red.DatumPolaganja = dtoPrintObj.polozeniPredmeti[i].DatumPolaganja.ToString();
                red.Naziv = dtoPrintObj.polozeniPredmeti[i].Predmet.Naziv;
                tabela.AddPolozeniPredmetiRow(red);
            }

            var tabelaIzvjestaj = new ReportDataSource();
            tabelaIzvjestaj.Value = tabela;
            tabelaIzvjestaj.Name = "dsPolozeniPredmeti";

            reportViewer1.RefreshReport();
            reportViewer1.LocalReport.SetParameters(parametri);
            reportViewer1.LocalReport.DataSources.Add(tabelaIzvjestaj);
        }
    }
}
