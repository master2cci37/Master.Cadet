//*----------------------------------------------------------------------------
// Classe : FormRecherche
// Fonctions : Recherche d une ecriture comptable existante
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
    /// FormRecherche : Recherche d une ecriture comptable existante
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public partial class FormRecherche : Form
    {
        #region creation de la fenetre de dialogue
        /// <summary>
        /// creation de la fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public FormRecherche()
        {
            InitializeComponent();
        }
        #endregion

        #region initialisation de la fenetre de dialogue
        /// <summary>
        /// initialisation de la fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormRecherche_Load(object sender, EventArgs e)
        {
            Text = "Recherche";
            toolTipRecherche.ToolTipTitle = "Recherche";
            /*
            labelTitre.Parent = userControlFenetreType1;
            pictureBoxIcone.Parent = userControlFenetreType1;
            labelTitre.BringToFront();
            pictureBoxIcone.BringToFront();
            */
            //TODO:faire une entrée a la table ecriture
        }
        #endregion

        #region recherche d une ecriture
        /// <summary>
        /// appel a l'aide sur la recherche d une ecriture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAide_Click(object sender, EventArgs e)
        {
            //TODO: Affichage de l'aide recherche d une ecriture

            MessageBox.Show("Affichage de l'aide",
                            "Aide en ligne",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        #endregion

        #region fermeture de la fenetre
        /// <summary>
        /// annuler la recherche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region ouverture d une ecriture comptable
        /// <summary>
        /// ouverture et affichage d une ecriture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOuvrir_Click(object sender, EventArgs e)
        {
            //TDDO : recherche et affichage d une ecriture
            MessageBox.Show("Recherche et affichage d une ecriture comptable",
               "Affichage a l ecran du contenu",
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
            if ((textBoxLibelleRecherche.Text == "") & (comboBoxCodeRecherche.Text != ""))
            {
                errorProviderRecherche.SetError(textBoxLibelleRecherche,
                    "Le libellé doit être renseigné");
            }
            else
                // pas d erreur de saisie
                errorProviderRecherche.SetError(textBoxLibelleRecherche, "");
        }
        #endregion
    }
}
