//*----------------------------------------------------------------------------
// Classe : FormParametreDossier
// Fonctions : Modifier les elements du dossier et l environnement de travail, export XML complet et suppression d un dossier
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
    /// FormParametreDossier : Modifier les elements du dossier et l environnement de travail, export XML complet et suppression d un dossier
    /// </summary>
    public partial class FormParametreDossier : Form
    {
        #region creation de la fenetre 
        /// <summary>
        /// creation de la fenetre 
        /// </summary>        
        public FormParametreDossier()
        {
            InitializeComponent();
        }
        #endregion

        #region initialisation de la fenetre
        /// <summary>
        /// initialisation de la fenetre de dialogue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormParametreDossier_Load(object sender, EventArgs e)
        {
            Text = "Parametre Dossier";
            toolTipParametreDossier.ToolTipTitle = "Parametre Dossier";

            labelTitre.Parent = userControlFenetreType1;
            pictureBoxIcone.Parent = userControlFenetreType1;
            labelTitre.BringToFront();
            pictureBoxIcone.BringToFront();
            //TODO : modification et mise a jour de la table Dossier, voir button expoter Xml?
        }
        #endregion

        #region Appel de l'aide
        /// <summary>
        /// Appel a l aide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAide_Click(object sender, EventArgs e)
        {
            //TODO: Affichage de l'aide sur les paramètres dossier, suppression d'un dossier et export d'un dossier au format XML

            MessageBox.Show("Affichage de l'aide",
                            "Aide en ligne",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        #endregion

        #region Fermeture de la fenetre de dialogue
        /// <summary>
        /// fermeture de la fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region suppression d'un dossier
        /// <summary>
        /// supprimer un dossier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            //TODO:suppression d'un dossier existant
            MessageBox.Show("suppression d'un dossier existant",
                "suppression d'un dossier",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        #endregion
        
        #region Exporter un dossier complet au format Xml
        /// <summary>
        /// Exporter un dossier complet au format Xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnrgisterXml_Click(object sender, EventArgs e)
        {
            //TODO:Exporter un dossier complet au format Xml
            MessageBox.Show("Exporter un dossier complet au format Xml",
                "Exporter un dossier complet au format Xml",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        #endregion
       
        #region Modifier l'environnement de CADET
        /// <summary>
        /// Modifier l'environnement de CADET
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCofigurer_Click(object sender, EventArgs e)
        {
            //TODO:Modifier l'environnement de CADET
            MessageBox.Show("Modifier l'environnement de CADET",
                "Changement de son et image de fond pour l'utilisateur",
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
            if ((textBoxLibelleParametreDossier.Text == "") & (comboBoxCodeParammetreDossier.Text != ""))
            {
                errorProviderParametreDossier.SetError(textBoxLibelleParametreDossier,
                    "Le libellé doit être renseigné");
            }
            else
                // pas d erreur de saisie
                errorProviderParametreDossier.SetError(textBoxLibelleParametreDossier, "");
        }
        #endregion
    }
}
