using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRIII.WinForm._Prijava
{
    public partial class frmPingTest : Form
    {
        public string Sadrzaj { get; set; }
        public int Brojac { get; set; }
        public frmPingTest()
        {
            InitializeComponent();
        }

        private void PING_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(PingGoogle);
            Thread t2 = new Thread(PingOlx);

            t1.Start();
            t2.Start();


        }

        private void prikaziSadrzaj()
        {
            txtLog.Text += Sadrzaj;
            PostaviNaKraj();
        }

        private void PostaviNaKraj()
        {
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }

        private void PingOlx()
        {
            try
            {
                var pingObj = new Ping();
                for (int i = 0; i < 10; i++)
                {
                    var replay = pingObj.Send("www.olx.ba");
                    Sadrzaj += PrikaziPing(replay);
                    BeginInvoke(prikaziSadrzaj);
                    Thread.Sleep(200);
                }
            }
            catch (Exception ex)
            {
                Sadrzaj = ex.Message;
            }
        }

        private string PrikaziPing(PingReply replay)
        {
            string nula = Brojac < 9 ? "0" : "";
            return $"{nula}{++Brojac} - > {replay.Address}\t{replay.RoundtripTime}\t{replay.Status}\t{Environment.NewLine}";
        }

        private void PingGoogle()
        {
            try
            {
                var pingObj = new Ping();
                for (int i = 0; i < 10; i++)
                {
                    var replay = pingObj.Send("www.google.ba");
                    Sadrzaj += PrikaziPing(replay);
                    BeginInvoke(prikaziSadrzaj);
                    Thread.Sleep(200);
                }
            }
            catch (Exception ex)
            {
                Sadrzaj = ex.Message;
            }
        }
    }
}
