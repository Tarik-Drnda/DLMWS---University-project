using PRIII.WinForm._P8;
using PRIII.WinForm._Prijava;
using PRIII.WinForm.Asinhrono;
using PRIII.WinForm.Izvjestaji;
using PRIII.WinForm.Predmeti;
using PRIII.WinForm.Studenti;

namespace PRIII.WinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var frmPr=new frmPrijava();
            Application.Run(new frmPingTest());
        }
    }
}