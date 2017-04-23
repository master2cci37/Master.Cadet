//*----------------------------------------------------------------------------
// Classe : FormOuvrir
// Fonctions : ouverture d un dossier existant
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
    /// FormOuvrir : ouverture d un dossier existant
    /// </summary>
    public partial class FormOuvrir : Form
    {
        #region creation de la fenetre de dailogue
        /// <summary>
        /// creation de la fenetre de dailogue
        /// </summary>
        public FormOuvrir()
        {
            InitializeComponent();
        }
        #endregion

        #region initialisation de la fenetre
        /// <summary>
        /// initialisation de la fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormOuvrir_Load(object sender, EventArgs e)
        {
            Text = "Ouvrir";
            toolTipOuvrir.ToolTipTitle = "Ouvrir";

            labelTitre.Parent = userControlFenetreType1;
            pictureBoxIcone.Parent = userControlFenetreType1;
            labelTitre.BringToFront();
            pictureBoxIcone.BringToFront();
        }
        #endregion

        #region Appel de l'aide
        /// <summary>
        /// Appel de l'aide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAide_Click(object sender, EventArgs e)
        {
            //TODO: Affichage de l'aide ouverture d'un dossier comptable existant

            MessageBox.Show("Affichage de l'aide",
                            "Aide en ligne",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        #endregion

        #region Fermeture de la fenetre
        /// <summary>
        /// Fermeture de la fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Ouverture d'un dossier existant
        /// <summary>
        /// Ouverture d'un dossier existant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOuvrir_Click(object sender, EventArgs e)
        {
            //TODO:Ouverture d un dossier comptable existant
            MessageBox.Show("Ouverture d'un dossier comptable existant",
                "Ouverture d'un dossier comptable existant",
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
            if ((textBoxLibelleOuvrir.Text == "") & (comboBoxCodeOuvrir.Text != ""))
            {
                errorProviderOuvrir.SetError(textBoxLibelleOuvrir,
                    "Le libellé doit être renseigné");
            }
            else
                // pas d erreur de saisie
                errorProviderOuvrir.SetError(textBoxLibelleOuvrir, "");
        }
        #endregion

        private void userControlFenetreType1_Load(object sender, EventArgs e)
        {

        }
    }
}
