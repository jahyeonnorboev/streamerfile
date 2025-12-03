using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Form2 ga o‘tish
            Application.Run(new Form2(
                "Viewer1",          // userName
                "55.230235.221",    // server IP
                50000               // port
            ));
        }
    }
}
