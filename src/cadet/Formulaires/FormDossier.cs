//*----------------------------------------------------------------------------
// Classe : FormDossier
// Fonctions : Edition des parametres du dossier en cours
// 
//  
// Version : 1.0   du 28/05/2008   
// CopyRight  :  / 
//*----------------------------------------------------------------------------
// 2008-08-04 - Création (mb)
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
    /// FormDossier : Edition des parametres du dossier en cours
    /// </summary>
    public partial class FormDossier : Form
    {
        #region creation de la fenetre
        /// <summary>
        /// creation de la fenetre de dailogue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public FormDossier()
        {
            InitializeComponent();
        }
        #endregion

        #region initialisation de la fenetre de dialogue
        /// <summary>
        /// initialisation de la fenetre de dialogue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormDossier_Load(object sender, EventArgs e)
        {
            Text = "Dossier";
            toolTipDossier.ToolTipTitle = "Dossier";

            labelTitre.Parent = userControlFenetreType1;
            pictureBoxIcone.Parent = userControlFenetreType1;
            labelTitre.BringToFront();
            pictureBoxIcone.BringToFront();

            //TODO: Affichage des paramètres du dossier au format imprimable
        }
        #endregion

        #region aide sur l'edition des paramètres du dossier en cours
        /// <summary>
        /// Appel de l'aide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAide_Click(object sender, EventArgs e)
        {
            //TODO: Affichage de l'aide edition des paramètres du dossier en cours

            MessageBox.Show("Affichage de l'aide",
                            "Aide en ligne",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        #endregion

        #region fermeture de la fenetre de dailogue
        /// <summary>
        /// fermeture de la fenetre de dailogue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region affichage des paramètres du dossier en cours
        /// <summary>
        /// edition des paramètres du dossier en cours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditer_Click(object sender, EventArgs e)
        {
            //TODO:edition des paramètres du dossier en cours
            MessageBox.Show("Edition des paramètres du dossier en cours",
                "Format imprimable PDF",
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
            if ((textBoxLibelleDossier.Text == "") & (comboBoxCodeDossier.Text != ""))
            {
                errorProviderDossier.SetError(textBoxLibelleDossier,
                    "Le libellé doit être renseigné");
            }
            else
                // pas d erreur de saisie
                errorProviderDossier.SetError(textBoxLibelleDossier, "");
        }
        #endregion
    }
}
