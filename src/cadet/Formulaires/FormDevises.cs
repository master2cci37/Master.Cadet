//*----------------------------------------------------------------------------
// Classe : FormDevises
// Fonctions : Paremétrer les taux de conversion des devises
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
    /// FormDevises : Paremétrer les taux de conversion des devises
    /// </summary>
    public partial class FormDevises : Form
    {
        #region Création de la fenetre de dialogue
        /// <summary>
        /// Création de la fenetre de dialogue
        /// </summary>
        public FormDevises()
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
        private void FormDevises_Load(object sender, EventArgs e)
        {
            Text = "Devises";
            toolTipDevises.ToolTipTitle = "Devises";

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
            //TODO: Affichage de l'aide du paramètrage des devises

            MessageBox.Show("Affichage de l'aide",
                            "Aide en ligne",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        #endregion

        #region Paramétrer les taux de conversion d'une devises
        /// <summary>
        /// Paramétrer les taux de conversion d'une devises
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            //TODO:Paramétrer/Ajouter les taux de conversion d'une devises
            MessageBox.Show("Paramétrer les taux de conversion d'une devises",
                "Mise a jour de la table devise",
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
            if ((textBoxLibelleDevises.Text == "") & (comboBoxCodeDevises.Text != ""))
            {
                errorProviderDevises.SetError(textBoxLibelleDevises,
                    "Le libellé doit être renseigné");
            }
            else
                // pas d erreur de saisie
                errorProviderDevises.SetError(textBoxLibelleDevises, "");
        }
        #endregion
    }
}
