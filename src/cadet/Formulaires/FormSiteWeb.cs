//*----------------------------------------------------------------------------
// Classe : FormSiteWeb
// Fonctions : Accès au site internet du programme pour informations et actualités
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
    /// FormSiteWeb : Accès au site internet du programme pour informations et actualités
    /// </summary>
    public partial class FormSiteWeb : Form
    {
        #region Creation de la fenetre de dialogue
        /// <summary>
        /// Creation de la fenetre
        /// </summary>
        public FormSiteWeb()
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
        private void FormSiteWeb_Load(object sender, EventArgs e)
        {
        Text = "Site Web";
            toolTipSiteWeb.ToolTipTitle = "Site Web";
         
           labelTitre.Parent= userControlFenetreType1;
            /*
           pictureBoxIcone.Parent = userControlFenetreType1;
           labelTitre.BringToFront();
            pictureBoxIcone.BringToFront();*/
                                
            //TODO: charger la table activité dans le combo
        }
        #endregion
        #region Appel de l'aide
        /// <summary>
        /// appel de l aide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAide_Click(object sender, EventArgs e)
        {
         //TODO: Affichage de l'aide Création/Modification d'une activité

            MessageBox.Show("Affichage de l'aide",
                            "Aide en ligne",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        #endregion
        #region Accès au site internet du programme pour + d information
        /// <summary>
        /// Accès au site internet du programme pour + d information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
        private void buttonOk_Click(object sender, EventArgs e)
        {
        //TODO:!!!
            MessageBox.Show(" Accès au site internet du programme pour informations et actualités",
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
        /// 
        private void buttonAnnler_Click(object sender, EventArgs e)
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
            if ((textBoxLibelleSiteWeb.Text == "") & (comboBox1.Text != ""))
            {
                errorProviderSiteWeb.SetError(textBoxLibelleSiteWeb,
                    "Le libellé doit être renseigné");
            }
            else
                // pas d erreur de saisie
                errorProviderSiteWeb.SetError(textBoxLibelleSiteWeb, "");
          * */
        }
        #endregion
    }
    
        }