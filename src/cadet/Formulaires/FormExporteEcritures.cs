//*----------------------------------------------------------------------------
// Classe : FormporteEcritures
// Fonctions : Exporter les écritures au format Xml ou Csv
// 
//  
// Version : 1.0   du 28/05/2008   
// CopyRight  :  / 
//*----------------------------------------------------------------------------
// 2008-07-04 - Création (mb)
// 
// 
//*----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
#if (Linq35)
using System.Linq;           
#endif
using System.Text;
using System.Windows.Forms;

namespace CADET
{
    
    /// <summary>
    /// FormporteEcritures : Exporter les écritures au format Xml ou Csv
    /// </summary>
    ///  <param name="sender"></param>
    /// <param name="e"></param>
    public partial class FormExporteEcritures : Form
    {
        #region creation de la fenetre de dialogue
        /// <summary>
        /// Creation de la fenetre
        /// </summary>
        ///  <param name="sender"></param>
        /// <param name="e"></param>
        public FormExporteEcritures()
        {
            InitializeComponent();
        }
        #endregion
      
        #region Initialisation de la fenetre de dialogue
        /// <summary>
        /// Initialisation de la fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormExporteEcritures_Load(object sender, EventArgs e)
        {
            Text = "Exporter";
            toolTipExportEcritures.ToolTipTitle = "Exporter";
            /*
            labelTitre.Parent = userControlFenetreType1;
            pictureBoxIcone.Parent = userControlFenetreType1;
            labelTitre.BringToFront();
            pictureBoxIcone.BringToFront();
            */
            //TODO:Exporter les ecritures au format Xml et CSV
        }
        #endregion

        #region Appel de l'aide
        /// <summary>
        /// appel de laide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAide_Click(object sender, EventArgs e)
        {
            //TODO: Affichage de l'aide export des ecritures au format Xml et Csv

            MessageBox.Show("Affichage de l'aide",
                            "Aide en ligne",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        #endregion
        
        #region Fermeture de la fenetre de dialogue
        /// <summary>
        /// Fermeture de la fenetre de dialogue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
            
        #region export des ecritures au format Xml
        /// <summary>
        /// export des ecritures au format Xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExporterXml_Click(object sender, EventArgs e)
         {
            //TODO: Export des ecritures au format Xml
             MessageBox.Show("export des ecritures au format Xml",
                 "Recherche d'ecritures existantes",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
         }
        #endregion

        #region export des ecritures au format Csv
        /// <summary>
        /// export des ecritures au format Csv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExporterCsv_Click(object sender, EventArgs e)
        {
            //TODO: Export des ecritures au format Csv
            MessageBox.Show("export des ecritures au format Csv",
                "Recherche d'ecritures existantes",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        #endregion

        #region Verifie la bonne saisie des donnees de la fenetre
        /// <summary>
        /// Verifie la bonne saisie des donnees de la fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void controleSaisie(object sender, CancelEventArgs e)
        {
            // libelle vide et code non renseigne ; affichage erreur
            if ((textBoxLibelleExportEcritures.Text == "") & (comboBoxCodeExportEcritures.Text != ""))
            {
                errorProviderExportEcritures.SetError(textBoxLibelleExportEcritures,
                    "Le libellé doit être renseigné");
            }
            else
                // pas d erreur de saisie
                errorProviderExportEcritures.SetError(textBoxLibelleExportEcritures, "");
        }
        #endregion
    }
}
