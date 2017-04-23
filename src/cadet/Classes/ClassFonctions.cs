using System;
using System.Collections.Generic;
#if (Linq35)
using System.Linq;           
#endif
using System.Text;
using System.Data;

namespace CADET
{
     static class  Fonctions 
    {
         public static string Majuscule() 
        {
            return "";
        }






         #region Exportation d un datagrid vers word
         /// <summary>
         /// Exportation d un datagrid vers word
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
         public static void ExportToWord(String filename )
         {

             // Get the filename selected by the user 
             string wordFilename = filename;

              //todo : à programmer
         } 
         #endregion
         #region Exportation d un datagrid vers excel
         /// <summary>
         /// Exportation d un datagrid vers excel
         /// </summary>
         public static void  ExporteVersExcel(String excelFilename)
         {
             // Export the details of specified columns
             try
             {
                 // Get the datatable to export
                 DataView myDv = new DataView();
                 DataTable myDt = myDv.Table;

                 // Specify the column list to export
                 int[] iColumns = { 0, 1, 2, 3, 4, 5, 6 };
                 string[] sHeaders = { "Name", "Author", "Content-type", "Created Date", 
					"Last Modified Date", "Containing Folder", "Containing Project" };

                 // Export the details of specified columns to Excel
                 //todo : à programmer
             }
             catch (Exception e)
             {
                 System.Windows.Forms.MessageBox.Show("Test\n"+e.Message);
             }
                 finally
             {
             }
         } 
         #endregion
 
    }
}
