using System;
using System.Collections.Generic;
#if (Linq35)
using System.Linq;           
#endif
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CADET
{
    static class ClassConnexionBD
    {
        public static string BaseDonnees = "CADETCCI08";
        
        public static string connectionString = "Server=INSPIRON1521B;Database=CADETCCI08;Trusted_Connection=True;";
        //"INSPIRON1521B;Initial Catalog=CADETCCI08;Integrated Security=True";
        public static string CheminBaseDonnees = "c:\\cadet\\compta\\CADETCCI08.mdf";
        public static SqlConnection ConnexionBDCADET;
        public static DataSet dataSetCADET = new DataSet();

        /// <summary>
        /// connexion et recuperation comptes
        /// </summary>
        /// <returns></returns>
        public static void connexionDataSetCADET()
        {

            try
            {
                ConnexionBDCADET = new SqlConnection(connectionString);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}
