using System;
using System.Collections.Generic;
#if (Linq35)
using System.Linq;           
#endif
using System.Text;
using System.Windows.Forms;

namespace CADET
{
    static class ClassGlobale
    {
        // contient le chemin du programme au lancement de celui-ci
        public static string CheminApplication = Application.StartupPath;
        public static string osVers = Environment.OSVersion.ToString();

    }
}
