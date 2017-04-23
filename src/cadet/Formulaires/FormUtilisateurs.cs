//*----------------------------------------------------------------------------
// Classe : FormUtilisateurs
// Fonctions : modifier les paramètres d'un utilisateur
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
    /// FormUtilisateurs : modifier les paramètres d'un utilisateur
    /// </summary>
    public partial class FormUtilisateurs : Form
    {
        #region création de la fenetre de dialogue
        /// <summary>
        /// creation de la fenetre de dialogue
        /// </summary>
        public FormUtilisateurs()
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
        private void FormUtilisateurs_Load(object sender, EventArgs e)
        {
            Text = "Utilisateurs";
            toolTipUtilisateur.ToolTipTitle = "Utilisateurs";

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
            //TODO: Affichage de l'aide ouverture et modification des paramètres utilisateurs

            MessageBox.Show("Affichage de l'aide",
                            "Aide en ligne",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        #endregion

        #region modification des paramètres utilisateurs
        /// <summary>
        /// Ouverture et modification des paramètres utilisateurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOuvrir_Click(object sender, EventArgs e)
        {
            //TODO:Ouverture et modification des paramètres utilisateurs
            MessageBox.Show("Ouverture et modification des paramètres utilisateurs",
                "Ajout d'un utilisateur",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        #endregion

        #region Fremeture de la fenetre
        /// <summary>
        /// Fremeture de la fenetre
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
            if ((textBoxLibelleUtilisateur.Text == "") & (comboBoxCodeUtilisateur.Text != ""))
            {
                errorProviderUtilisateur.SetError(textBoxLibelleUtilisateur,
                    "Le libellé doit être renseigné");
            }
            else
                // pas d erreur de saisie
                errorProviderUtilisateur.SetError(textBoxLibelleUtilisateur, "");
        }
        #endregion
    }
}
