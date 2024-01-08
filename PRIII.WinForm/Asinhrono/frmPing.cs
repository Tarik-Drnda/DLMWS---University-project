using FIT.Infrastucture;
using PRIII.WinForm.Helpers;
using PRIII___DATA;
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

namespace PRIII.WinForm.Asinhrono
{
    public partial class frmPing : Form
    {
        public int Brojac { get; set; }
        public string Sadrzaj { get; set; }
        DLWMSDbContext baza = new DLWMSDbContext();
        public frmPing()
        {
            InitializeComponent();
        }

        private async void btnPing_Click(object sender, EventArgs e)
        {
            Thread google = new Thread( 
            ()=>PingLokacija(
                new dtoPing() 
                {
                    BrojPonavljanja=10,
                    Lokacija="www.google.ba",
                    Pauza=200
                })
            );
            Thread olx = new Thread(PingOlx);
            Thread studenti = new Thread(DodajStudenta);

            //var task = Task.Run( () => 
            //  { DodajStudenta(); }
            // );

            // task.GetAwaiter().OnCompleted(
            //        () => PingLokacija(
            //     new dtoPing()
            //     {
            //         BrojPonavljanja = 10,
            //         Lokacija = "www.google.ba",
            //         Pauza = 200
            //     })
            //        );

            await Task.Run(() =>
            { DodajStudenta(); }
            );
            await Task.Run(() => PingLokacija(
                new dtoPing()
                {
                    BrojPonavljanja = 10,
                    Lokacija = "www.google.ba",
                    Pauza = 200
                }
              )
            );

            //google.Start();
            //olx.Start();
            //studenti.Start();
            //PingGoogle();
            //PingOlx();

            //google.Join();
            //olx.Join();
            PrikaziSadrzaj();

        }

        private void DodajStudenta()
        {
          try
          { 
            var slika = baza.Studenti.Find(1).Slika;
            for (int i = 0; i < 100; i++)
            {
                var noviStudent = new Student()
                {
                    Aktivan = true,
                    DatumRodjenja = DateTime.Now,
                    Email = $"ime{i + 1}.prezime{i + 1}@edu.fit.ba",
                    Ime = $"ime{i + 1}",
                    Prezime = $"prezime{i + 1}",
                    Indeks = "IB220069",
                    Lozinka = Generator.GetLozinka(),
                    SemestarId = 1,
                    Slika = slika
                };
                baza.Studenti.Add(noviStudent);
                Sadrzaj += $"Student -> {noviStudent}{Environment.NewLine}";
                BeginInvoke(PrikaziSadrzaj);
                Thread.Sleep(200);
            }
            baza.SaveChanges();
          }
            catch (Exception ex)
            {
                txtIspis.Text += ex.Message;
            }
        }

        private void PingLokacija(object obj)
        {
            try
            {
                var ping = new Ping();
                var dtoPing = obj as dtoPing;
                for (int i = 0; i < dtoPing.BrojPonavljanja; i++)
                {
                    var reply = ping.Send(dtoPing.Lokacija);
                    Sadrzaj += StringFromReply(reply);
                    BeginInvoke(PrikaziSadrzaj);
                    Thread.Sleep(dtoPing.Pauza);
                }

            }
            catch (Exception ex)
            {
                txtIspis.Text += ex.Message;
            }
        }


        private void PrikaziSadrzaj()
        {
            txtIspis.Text = Sadrzaj;
            PomjeriNaKraj();
        }

       

        private void PomjeriNaKraj()
        {
            txtIspis.SelectionStart = txtIspis.TextLength;
            txtIspis.ScrollToCaret();
        }


        private string StringFromReply(PingReply reply)
        {
            string nula = Brojac < 9 ? "0" : "";
            return $"{nula}{++Brojac} -> {reply.Address}\t\t{reply.RoundtripTime}\t{reply.Status}{Environment.NewLine}";
        }
        private void PingOlx()
        {
            try
            {
                var ping = new Ping();
                for (int i = 0; i < 10; i++)
                {
                    var reply = ping.Send("olx.ba");
                    Sadrzaj += StringFromReply(reply);
                    BeginInvoke(PrikaziSadrzaj);
                    Thread.Sleep(200);
                }

            }
            catch (Exception ex)
            {
                txtIspis.Text += ex.Message;
            }
        }
        //private void PingGoogle()
        //{
        //    try
        //    {
        //        var ping = new Ping();
        //        for (int i = 0; i < 10; i++)
        //        {
        //            var reply = ping.Send("www.google.ba");
        //            Sadrzaj += StringFromReply(reply);
        //            BeginInvoke(PrikaziSadrzaj);
        //            Thread.Sleep(200);
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        txtIspis.Text += ex.Message;
        //    }
        //}
    }
    public class dtoPing
    {
        public string Lokacija { get; set; }
        public int BrojPonavljanja { get; set;}
        public int Pauza { get; set; }
    }
}
