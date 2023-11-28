using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRIII.WinForm
{
    public partial class EventsTest : Form
    {
        public EventsTest()
        {
            InitializeComponent();
            //Func<int,int, bool> test = tF;
            // test(2, 4);
            //Func<int, bool> f = x=> x>5;
            //int[] niz = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var fil = niz.Where(f);
            //foreach (var VARIABLE in fil)
           // {
            //    MessageBox.Show(VARIABLE.ToString());
           //}
           //List<Func<int,int,bool>> lista=new List<Func<int,int,bool>>();
           //lista.Add(tF);
          // MessageBox.Show((lista[0](4, 1)).ToString());
          tF(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18);
        }

        private bool filtriraj(int broj)
        {
            return broj > 5;}
        private bool tF(params int[] niz)
        {
            for (int i = 0; i < niz.Length; i++)
                MessageBox.Show(niz[i].ToString());
            return true;
        }
        delegate void potpisFunk(string poruka);

        private event potpisFunk smsServisi;

        public void BHT(string poruka)
        {
            MessageBox.Show("BHT -> " + rtbPoruka.Text);
        }
        public void Haloo(string poruka)
        {
            MessageBox.Show("Haloo -> " + rtbPoruka.Text);
        }
        public void HTeronet(string poruka)
        {
            MessageBox.Show("HTeronet -> " + rtbPoruka.Text);
        }
        private void btn_test_Click(object sender, EventArgs e)
        {
            smsServisi?.Invoke(rtbPoruka.Text);
        }

        private void PrikljuciMetodu(object sender, potpisFunk metoda)
        {
            if (sender is CheckBox)
            {
                if ((sender as CheckBox).Checked)
                {
                    smsServisi += metoda;
                }
                else
                {

                    smsServisi -= metoda;
                }
            }
        }

        private void cbBHT_CheckedChanged(object sender, EventArgs e)
        {
           // PrikljuciMetodu(sender,BHT);
        }

        private void cbHTE_CheckedChanged(object sender, EventArgs e)
        {
           // PrikljuciMetodu(sender, HTeronet);
        }

        private void cbHaloo_CheckedChanged(object sender, EventArgs e)
        {
           // PrikljuciMetodu(sender, Haloo);
        }
    }
}
