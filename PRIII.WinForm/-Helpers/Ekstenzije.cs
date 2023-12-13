using FIT.Infrastucture;
using System.Drawing.Imaging;
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

        public static Image ToImage(this byte[] sadrzaj) 
        {
            var ms = new MemoryStream(sadrzaj);
           return Image.FromStream(ms);
        }
        public static byte[] ToByteArray(this Image sadrzaj)
        {
            var ms = new MemoryStream();
            sadrzaj.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }
}
