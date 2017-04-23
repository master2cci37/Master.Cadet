//*----------------------------------------------------------------------------
// Classe : FormEnregistrement
// Fonctions : Saisie des informations d'enregistrement de la licence de CADET
// 
//  
// Version : 1.0   du 28/05/2008   
// CopyRight  :  / 
//*----------------------------------------------------------------------------
// 2008-04-07 - Création (Hassan)
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
    /// FormEnregistrement : 
    /// </summary>
    public partial class FormEnregistrement : Form
    {
        #region Creation de la fenetre de dialogue
        /// <summary>
        /// Creation de la fenetre
        /// </summary>
        public FormEnregistrement()
        {
            InitializeComponent();
        }
        #endregion
        #region Initialisation de la fenetre de dialogue
        /// <summary>
        /// Initialisation de la fenetre de dialogue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FormEnregistrement_Load(object sender, EventArgs e)
        {
            {
                Text = "Enregistrement";
                toolTipEnregistrement.ToolTipTitle = "Enregistrement";

                labelTitre.Parent = userControlFenetreType1;
                //pictureBoxIcone.Parent = userControlFenetreType1;
                labelTitre.BringToFront();
                //pictureBoxIcone.BringToFront();

                //TODO:!!!
            }
        #endregion
            #region Appel de l'aide
            /// <summary>
            /// appel de l aide
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
        }
        private void buttonAide_Click(object sender, EventArgs e)
        {
            {

                //TODO: !!!

                MessageBox.Show("Affichage de l'aide",
                                "Aide en ligne",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

            }
            #endregion
            #region Saisie des informations d'enregistrement de la licence de CADET
            /// <summary>
            /// Saisie des informations d'enregistrement de la licence de CADET
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            {
                //TODO:!!!!

                MessageBox.Show(" Saisie des informations d'enregistrement de la licence de CADET",
                    "Titre",
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
        }

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
        {/*
            // libelle vide et code renseigne ; affichage erreur
            if ((textBoxLibelleEnregistrement.Text == "") & (comboBox1.Text != ""))
            {
                errorProviderEnregistrement.SetError(textBoxLibelleEnregistrement,
                    "Le libellé doit être renseigné");
            }
            else
                // pas d erreur de saisie
                errorProviderEnregistrement.SetError(textBoxLibelleEnregistrement, "");
          */
        }
        #endregion
    }
}


