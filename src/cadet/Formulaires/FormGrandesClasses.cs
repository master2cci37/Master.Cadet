//*----------------------------------------------------------------------------
// Classe : FormGrandesClasses
// Fonctions :  
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
    /// FormGrandesClasses : donne les grandes classe de cette comptabilité
    /// </summary>
    public partial class FormGrandesClasses : Form
    {
        #region Creation de la fenetre de dialogue
        /// <summary>
        /// Creation de la fenetre
        /// </summary>
        public FormGrandesClasses()
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

        private void FormGrandesClasses_Load(object sender, EventArgs e)
        {
            Text = "Grandes Classes";
            toolTipGrandesClasses.ToolTipTitle = "Grandes Classes";

            labelTitre.Parent = userControlFenetreType1;
            //pictureBoxIcone.Parent = userControlFenetreType1;
            labelTitre.BringToFront();
            //pictureBoxIcone.BringToFront();

            //TODO: !!!!
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

            //TODO: !!!

            MessageBox.Show("Affichage de l'aide",
                            "Aide en ligne",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

        }
        #endregion


        #region Enregistrement des modifications d'une activité
        /// <summary>
        /// Enregistrement des modifications d'une activité
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonOk_Click(object sender, EventArgs e)
        {
            //TODO:!!!
            MessageBox.Show("Enregistrement des grandes classe de cette comptabilité",
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
            if ((textBoxLibelleGrandesClasses.Text == "") & (comboBox1.Text != ""))
            {
                errorProviderGrandesClasses.SetError(textBoxLibelleGrandesClasses,
                    "Le libellé doit être renseigné");
            }
            else
                // pas d erreur de saisie
                errorProviderGrandesClasses.SetError(textBoxLibelleGrandesClasses, "");
          * */
        }
        #endregion
    }
}
