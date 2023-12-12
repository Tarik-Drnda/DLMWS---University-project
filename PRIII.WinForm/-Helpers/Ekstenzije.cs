using FIT.Infrastucture;
using System.Windows.Forms;
namespace PRIII.WinForm
{
    public static class Ekstenzije
    {
        public static bool Prazan(this string sadrzaj)
        {
            return string.IsNullOrWhiteSpace(sadrzaj);
        }
        public static void UcitajPodatke<T>(this ComboBox comboBox,List<T> dataSoruce,string displayMember,string ValueMember)
        {
            comboBox.DataSource = InMemoryDB.Predmeti;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = ValueMember;
        }
    }
}
