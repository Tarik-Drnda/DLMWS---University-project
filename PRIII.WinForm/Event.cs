using FIT.Infrastucture;
using PRIII___DATA;

namespace PRIII.WinForm
{
    public partial class Event : Form
    {
        public Event()
        {
            InitializeComponent();
            Matoperacija += Kvadiraj;
            Matoperacija += Kubiraj;
        }
        delegate int potpisFunkcije(int broj);
        event potpisFunkcije Matoperacija;

        delegate void marketing(string poruka);
        event marketing smsMarketing;

        int Kvadiraj(int broj) { return broj * broj; }
        int Kubiraj(int broj) { return broj * broj * broj; }

        void BHTelecom(string poruka)
        {
            MessageBox.Show($"BHTelecom -> {poruka}");
        }
        void HTEronet(string poruka)
        {
            MessageBox.Show($"HTeronet -> {poruka}");
        }
        void mTel(string poruka)
        {
            MessageBox.Show($"mTel -> {poruka}");
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            smsMarketing?.Invoke(textBox1.Text);
        }

        private void PreplatiMetodu(object sender,marketing metoda)
        {
            if ((sender as CheckBox).Checked)
                smsMarketing += metoda;
            else
                smsMarketing -= metoda;
        }
        private void cbBHT_CheckedChanged(object sender, EventArgs e)
        {
            PreplatiMetodu(sender, BHTelecom);
        }

        private void cbHTE_CheckedChanged(object sender, EventArgs e)
        {
            PreplatiMetodu(sender, HTEronet);
        }
    }
}