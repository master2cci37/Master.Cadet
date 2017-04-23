//*----------------------------------------------------------------------------
// Classe : FormSons
// Fonctions : Paramétrage des avertissements sonores
// 
//  
// Version : 1.0   du 28/05/2008   
// CopyRight  :  / 
//*----------------------------------------------------------------------------
// 2008-04-04 - Création (jfp)
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
    /// FormSons: Paramétrage des avertissements sonores
    /// </summary>
    /// 
    public partial class FormSon : Form
    {
        #region Creation de la fenetre de dialogue

        /// <summary>
        /// Creation de la fenetre
        /// </summary>

        public FormSon()
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

        private void FormSon_Load(object sender, EventArgs e)
        {
            this.Text = "Son";
            toolTipson.ToolTipTitle = "son";
            labelTitre.Parent = userControlFenetreType1;           
            pictureBoxIcone.Parent = userControlFenetreType1;
            labelTitre.BringToFront();
            pictureBoxIcone.BringToFront();

            // TODO:................................

        }
       
        #endregion
 
        #region   Appel de l'aide

        /// <summary>
        /// appel de laide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void buttonAide_Click(object sender, EventArgs e)
        {
            // TODO :  Affichage de l'aide ,Paramétrage des avertissements sonores
            
                MessageBox.Show("Affichage de l'aide", "Aide en ligne",
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

        #region Enregistrement des modifications de son

        /// <summary>
        /// Enregistrement des modifications de son
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // TODO: Enregistrement des modifications de son

            MessageBox.Show("Enregistrement des modifications d'une activité",
                "Paramétrage des avertissements sonores",
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
            // libelle vide et code renseigne ; affichage erreur

            /* if ((textBoxLibelleActivite.Text == "") & (comboBox1.Text != ""))
            {
                errorProviderActivite.SetError(textBoxLibelleActivite,
                    "Le libellé doit être renseigné");
            }
            else
                // pas d erreur de saisie
                errorProviderActivite.SetError(textBoxLibelleActivite, "");*/

            // TODO:.................
        }

        #endregion

    }
}