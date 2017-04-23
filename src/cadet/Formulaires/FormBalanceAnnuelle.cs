//*----------------------------------------------------------------------------
// Classe : FormActivites
// Fonctions : Création, modification, suppression d'activité
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
    /// FormBalanceAnnuelle : Crée un tableau de bord annuel
    /// </summary>
    public partial class FormBalanceAnnuelle : Form
    {
        #region Creation de la fenetre de dialogue
        /// <summary>
        /// Creation de la fenetre
        /// </summary>
        public FormBalanceAnnuelle()
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
         private void FormBalanceAnnuelle_Load(object sender, EventArgs e)
         {
         Text = "Balance Annuelle";
            toolTipBalanceAnnuelle.ToolTipTitle = "Balance Annuelle";
           
           labelTitre.Parent= userControlFenetreType1;
             /*
           pictureBoxIcone.Parent = userControlFenetreType1;
           labelTitre.BringToFront();
            pictureBoxIcone.BringToFront();
                          */      
            //TODO: !!!
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


         #region Enregistrement des modifications d'un tableau de bord annuel
         /// <summary>
         /// Enregistrement des modifications d'un tableau de bord annuel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void buttonOk_Click(object sender, EventArgs e)
         {
            //TODO:!!!
            MessageBox.Show("Enregistrement des modifications d'un tableau de bord annuel",
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
          private void buttonAnuler_Click(object sender, EventArgs e)
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
              if ((textBoxLibelleBalanceAnnuelle.Text == "") & (comboBox1.Text != ""))
              {
                  errorProviderBalanceAnnuelle.SetError(textBoxLibelleBalanceAnnuelle,
                      "Le libellé doit être renseigné");
              }
              else
                  // pas d erreur de saisie
                  errorProviderBalanceAnnuelle.SetError(textBoxLibelleBalanceAnnuelle, "");
            */
          }
          #endregion
    }



}
