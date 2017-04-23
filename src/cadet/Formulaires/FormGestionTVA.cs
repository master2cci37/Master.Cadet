//*----------------------------------------------------------------------------
// Classe : FormGestionTVA
// Fonctions : Gérer la TAV
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
    /// FormGestionTVA : Gérer la TAV
    /// </summary>
    public partial class FormGestionTVA : Form
    {
        #region Création de la fenetre de dialogue
        /// <summary>
        /// Création de la fenetre de dialogue
        /// </summary>
        public FormGestionTVA()
        {
            InitializeComponent();
        }
        #endregion

        #region Initialisation de la fenetre
        /// <summary>
        /// Initialisation de la fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormGestionTVA_Load(object sender, EventArgs e)
        {
            Text = "Gestion de la TVA";
            toolTipTVA.ToolTipTitle = "Gestion de la TVA";

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
            //TODO: Affichage de l'aide gestion de la TVA

            MessageBox.Show("Affichage de l'aide",
                            "Aide en ligne",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        #endregion

        #region Modification et/ou ajout de la TVA
        /// <summary>
        /// Modification, ajout de la TVA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModifer_Click(object sender, EventArgs e)
        {
            //TODO:Modification et/ou ajout d'une TVA
            MessageBox.Show("Modification et/ou ajout d'une TVA",
                "Modification et/ou ajout d'une TVA",
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

        #region Verifie la bonne saisie des donnees de la fenetre
        /// <summary>
        /// Verifie la bonne saisie des donnees de la fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void controleSaisie(object sender, CancelEventArgs e)
        {
            // libelle vide et code non renseigne ; affichage erreur
            if ((textBoxLibelleTVA.Text == "") & (comboBoxCodeTVA.Text != ""))
            {
                errorProviderTVA.SetError(textBoxLibelleTVA,
                    "Le libellé doit être renseigné");
            }
            else
                // pas d erreur de saisie
                errorProviderTVA.SetError(textBoxLibelleTVA, "");
        }
        #endregion        
    }
}
