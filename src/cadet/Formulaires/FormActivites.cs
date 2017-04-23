//* ==========================================================================
// Classe : FormActivites
// Fonctions : Création, modification, suppression d'activité
// 
//  
// Version : 1.0   du 28/05/2008   
// Auteur(s) : Mehdi ALLAS, JF. PACORY, Mahmoud BOUKERROUI, Hassan RAHHOU
// CopyRight  :  /
// Etat : en cours
//*---------------------------------------------------------------------------
// 2008-04-04 - Création (jfp)
// 
// 
//* ==========================================================================
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
    /// FormActivites : Création, modification, suppression d'activité
    /// </summary>
    public partial class FormActivites : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonAide = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxLibelleActivite = new System.Windows.Forms.TextBox();
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelCodeActivite = new System.Windows.Forms.Label();
            this.pictureBoxIcone = new System.Windows.Forms.PictureBox();
            this.comboBoxCodeActivite = new System.Windows.Forms.ComboBox();
            this.labelLibelleActivite = new System.Windows.Forms.Label();
            this.checkBoxSuppressionActivite = new System.Windows.Forms.CheckBox();
            this.errorProviderActivite = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProviderActivite = new System.Windows.Forms.HelpProvider();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.userControlFenetreType1 = new CADET.UserControlFenetreType();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderActivite)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(280, 151);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 1;
            this.buttonAnnuler.Text = "A&nnuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonAide
            // 
            this.buttonAide.Location = new System.Drawing.Point(5, 151);
            this.buttonAide.Name = "buttonAide";
            this.buttonAide.Size = new System.Drawing.Size(75, 23);
            this.buttonAide.TabIndex = 2;
            this.buttonAide.Text = "&Aide";
            this.buttonAide.UseVisualStyleBackColor = true;
            this.buttonAide.Click += new System.EventHandler(this.buttonAide_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(199, 151);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "&Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxLibelleActivite
            // 
            this.helpProviderActivite.SetHelpString(this.textBoxLibelleActivite, "");
            this.textBoxLibelleActivite.Location = new System.Drawing.Point(104, 106);
            this.textBoxLibelleActivite.Name = "textBoxLibelleActivite";
            this.helpProviderActivite.SetShowHelp(this.textBoxLibelleActivite, true);
            this.textBoxLibelleActivite.Size = new System.Drawing.Size(232, 20);
            this.textBoxLibelleActivite.TabIndex = 4;
            this.textBoxLibelleActivite.Validating += new System.ComponentModel.CancelEventHandler(this.controleSaisie);
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.BackColor = System.Drawing.Color.Transparent;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelTitre.Location = new System.Drawing.Point(48, 14);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(273, 17);
            this.labelTitre.TabIndex = 6;
            this.labelTitre.Text = "Création / modification d\'une activité";
            // 
            // labelCodeActivite
            // 
            this.labelCodeActivite.AutoSize = true;
            this.labelCodeActivite.Location = new System.Drawing.Point(11, 74);
            this.labelCodeActivite.Name = "labelCodeActivite";
            this.labelCodeActivite.Size = new System.Drawing.Size(38, 13);
            this.labelCodeActivite.TabIndex = 7;
            this.labelCodeActivite.Text = "&Code :";
            // 
            // pictureBoxIcone
            // 
            this.pictureBoxIcone.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxIcone.Image = global::CADET.Properties.Resources.paste_clipboard_32;
            this.pictureBoxIcone.Location = new System.Drawing.Point(9, 6);
            this.pictureBoxIcone.Name = "pictureBoxIcone";
            this.pictureBoxIcone.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxIcone.TabIndex = 5;
            this.pictureBoxIcone.TabStop = false;
            // 
            // comboBoxCodeActivite
            // 
            this.comboBoxCodeActivite.FormattingEnabled = true;
            this.comboBoxCodeActivite.Location = new System.Drawing.Point(104, 66);
            this.comboBoxCodeActivite.Name = "comboBoxCodeActivite";
            this.comboBoxCodeActivite.Size = new System.Drawing.Size(104, 21);
            this.comboBoxCodeActivite.TabIndex = 8;
            this.comboBoxCodeActivite.Validating += new System.ComponentModel.CancelEventHandler(this.controleSaisie);
            // 
            // labelLibelleActivite
            // 
            this.labelLibelleActivite.AutoSize = true;
            this.labelLibelleActivite.Location = new System.Drawing.Point(11, 113);
            this.labelLibelleActivite.Name = "labelLibelleActivite";
            this.labelLibelleActivite.Size = new System.Drawing.Size(43, 13);
            this.labelLibelleActivite.TabIndex = 9;
            this.labelLibelleActivite.Text = "&Libellé :";
            // 
            // checkBoxSuppressionActivite
            // 
            this.checkBoxSuppressionActivite.AutoSize = true;
            this.checkBoxSuppressionActivite.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBoxSuppressionActivite.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBoxSuppressionActivite.Location = new System.Drawing.Point(246, 70);
            this.checkBoxSuppressionActivite.Name = "checkBoxSuppressionActivite";
            this.checkBoxSuppressionActivite.Size = new System.Drawing.Size(90, 17);
            this.checkBoxSuppressionActivite.TabIndex = 10;
            this.checkBoxSuppressionActivite.Text = "&Suppression :";
            this.checkBoxSuppressionActivite.UseVisualStyleBackColor = true;
            // 
            // errorProviderActivite
            // 
            this.errorProviderActivite.ContainerControl = this;
            // 
            // userControlFenetreType1
            // 
            this.userControlFenetreType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlFenetreType1.Location = new System.Drawing.Point(0, 0);
            this.userControlFenetreType1.Name = "userControlFenetreType1";
            this.userControlFenetreType1.Size = new System.Drawing.Size(363, 179);
            this.userControlFenetreType1.TabIndex = 11;
            // 
            // FormActivites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 179);
            this.Controls.Add(this.checkBoxSuppressionActivite);
            this.Controls.Add(this.labelLibelleActivite);
            this.Controls.Add(this.comboBoxCodeActivite);
            this.Controls.Add(this.labelCodeActivite);
            this.Controls.Add(this.pictureBoxIcone);
            this.Controls.Add(this.textBoxLibelleActivite);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonAide);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.userControlFenetreType1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormActivites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormActivites";
            this.Load += new System.EventHandler(this.FormActivites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderActivite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonAide;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxLibelleActivite;
        private System.Windows.Forms.PictureBox pictureBoxIcone;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelCodeActivite;
        private System.Windows.Forms.ComboBox comboBoxCodeActivite;
        private System.Windows.Forms.Label labelLibelleActivite;
        private System.Windows.Forms.CheckBox checkBoxSuppressionActivite;
        private System.Windows.Forms.ErrorProvider errorProviderActivite;
        private System.Windows.Forms.HelpProvider helpProviderActivite;
        private UserControlFenetreType userControlFenetreType1;
        private System.Windows.Forms.ToolTip toolTip;

        #region Creation de la fenetre de dialogue
        /// <summary>
        /// Creation de la fenetre
        /// </summary>
        public FormActivites()
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
        private void FormActivites_Load(object sender, EventArgs e)
        {
            // -- contenu textuel
            this.Text = rsCADET.FormActivitesText;// "Activité []"
            toolTip.ToolTipTitle = rsCADET.toolTipActivitesTitle;// Activité
            labelTitre.Text = rsCADET.labelTitreText;// "Création / Modification d'une activ

            labelCodeActivite.Text = rsCADET.labelCodeActiviteText;// "&Code :";
            labelLibelleActivite.Text = rsCADET.labelLibelleActiviteText;// "&Libellé :";
            checkBoxSuppressionActivite.Text = rsCADET.checkBoxSuppressionActiviteText;// "&Suppression :";         

            toolTip.SetToolTip(comboBoxCodeActivite, rsCADET.comboBoxCodeActiviteToolTip);// "Code de l'activité sur 6 caractèr
            toolTip.SetToolTip(textBoxLibelleActivite, rsCADET.textBoxLibelleActiviteToolTip);//"Entrez le libellé de l'activité";
            toolTip.SetToolTip(checkBoxSuppressionActivite, rsCADET.checkBoxSuppressionActiviteToolTip);// "Cochez cette case pour supprimer 

            toolTip.SetToolTip(buttonOk, rsCADET.buttonOKToolTip);
            toolTip.SetToolTip(buttonAnnuler, rsCADET.buttonAnnulerToolTip);
            toolTip.SetToolTip(buttonAide, rsCADET.buttonAideToolTip);

            //ksCADET.MsgErr183 ; "Création Activités";

             /*
           labelTitre.Parent= userControlFenetreType1;
           pictureBoxIcone.Parent = userControlFenetreType1;
           labelTitre.BringToFront();
            pictureBoxIcone.BringToFront();
                                */
            //TODO: charger la table activité dans le combo
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

            //TODO: Affichage de l'aide Création/Modification d'une activité

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
            // Fermeture de la fenetre de dialogue
            this.Close();
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
            //TODO:Enregistrement des modifications d'une activité
            MessageBox.Show("Enregistrement des modifications d'une activité",
                "Création/Modification d'une activité",
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
            if ((textBoxLibelleActivite.Text == "") & (comboBoxCodeActivite.Text != ""))
            {
                errorProviderActivite.SetError(textBoxLibelleActivite,
                    "Le libellé doit être renseigné");
            }
            else
                // pas d erreur de saisie
                errorProviderActivite.SetError(textBoxLibelleActivite, "");
        }
        #endregion
    }
}
