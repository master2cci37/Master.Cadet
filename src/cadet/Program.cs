///
/// Application cadet
/// M2 CCI Tours / 2008
///
///#define Linq35 // decommenter pour compilation Net 3.5
#define prototype
#define alpha
#define beta
#define finale
#define finaleprof

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CADET
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormCADETPrincipal());
        }
    }
}
