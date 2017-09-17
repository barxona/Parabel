using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Mathix.Parabel;
namespace Mathix
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           Application.Run(new ParabelForm());
        }
    }
}
