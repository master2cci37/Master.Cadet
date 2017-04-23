//*----------------------------------------------------------------------------
// Classe : FormRestaurer
// Fonctions : Ouverture de fichiers comptable existant
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
    /// FormResrauration : Restaurer des fichiers comptable existants
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public partial class FormRestauration : Form
    {
        #region creation de la fenetre de dialogue
        /// <summary>
        /// creation de la fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public FormRestauration()
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
        private void FormRestauration_Load(object sender, EventArgs e)
        {
            Text = "Restauration";
            toolTipRestaurer.ToolTipTitle = "Restauration";

            labelTitre.Parent = userControlFenetreType1;
            pictureBoxIcone.Parent = userControlFenetreType1;
            labelTitre.BringToFront();
            pictureBoxIcone.BringToFront();

            //TODO: mettre à jour les tables Dossier, Adresse, Configuration, Utilisateur et Devises
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
            //TODO: Affichage de l'aide ouverture d'un exercice comptable existant

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

        #region Ouverture d un exercice comptable existant
        /// <summary>
        /// Ouverture d un exercice comptable existant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRestaurer_Click(object sender, EventArgs e)
        {
            //TODO:Ouverture d un exercice comptable existant
            MessageBox.Show("Ouverture d un exercice comptable existant",
                "Recherche de fichiers comptable existants",
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
            if ((textBoxLibelleRestaurer.Text == "") & (comboBoxCodeRestauration.Text != ""))
            {
                errorProviderRestaurer.SetError(textBoxLibelleRestaurer,
                    "Le libellé doit être renseigné");
            }
            else
                // pas d erreur de saisie
                errorProviderRestaurer.SetError(textBoxLibelleRestaurer, "");
        }
        #endregion
    }
}
