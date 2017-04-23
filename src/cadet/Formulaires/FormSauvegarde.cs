//*----------------------------------------------------------------------------
// Classe : FormSauvegarde
// Fonctions : Sauvegarde de la comptabilité
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
    /// FormSuavegarde : Enregistrement de la comptabilité en cours
    /// </summary>
    public partial class FormSauvegarde : Form
    {
        #region creation de la fenetre de dialogue
        /// <summary>
        /// creation de la fenetre
        /// </summary>
        public FormSauvegarde()
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
        private void Sauvegarde_Load(object sender, EventArgs e)
        {
            Text = "Sauvegarde";
            toolTipSauvegarde.ToolTipTitle = "Sauvegarde";
            
            labelTitre.Parent= userControlFenetreType1;
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
            //TODO: Affichage de l'aide Sauvegarde d'un exercice comptable

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
               
        #region Enregistrement d un exercice comptable
        /// <summary>
        /// Enregistrement  d un exercice comptable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         private void buttonEnregister_Click(object sender, EventArgs e)
        {
            //TODO:Enregistrement d un exercice comptable
            MessageBox.Show("Enregistrement d un exercice comptable",
                "Sauvegarde des fichiers comptable",
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
             if ((textBoxLibelleSauvegarde.Text == "") & (comboBoxCodeSauvegarde.Text != ""))
             {
                 errorProviderSauvegarde.SetError(textBoxLibelleSauvegarde,
                     "Le libellé doit être renseigné");
             }
             else
                 // pas d erreur de saisie
                 errorProviderSauvegarde.SetError(textBoxLibelleSauvegarde, "");
         }
        #endregion

        
    }
}
