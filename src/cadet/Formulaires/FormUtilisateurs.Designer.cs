namespace CADET
{
    partial class FormUtilisateurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtilisateurs));
            this.userControlFenetreType1 = new CADET.UserControlFenetreType();
            this.buttonAide = new System.Windows.Forms.Button();
            this.buttonOuvrir = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.comboBoxCodeUtilisateur = new System.Windows.Forms.ComboBox();
            this.checkBoxSupprimer = new System.Windows.Forms.CheckBox();
            this.errorProviderUtilisateur = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProviderUtilisateur = new System.Windows.Forms.HelpProvider();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxIcone = new System.Windows.Forms.PictureBox();
            this.labelTitre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLibelleUtilisateur = new System.Windows.Forms.TextBox();
            this.toolTipUtilisateur = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUtilisateur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // userControlFenetreType1
            // 
            this.userControlFenetreType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlFenetreType1.Location = new System.Drawing.Point(0, 0);
            this.userControlFenetreType1.Name = "userControlFenetreType1";
            this.userControlFenetreType1.Size = new System.Drawing.Size(354, 169);
            this.userControlFenetreType1.TabIndex = 0;
            // 
            // buttonAide
            // 
            this.buttonAide.Location = new System.Drawing.Point(13, 141);
            this.buttonAide.Name = "buttonAide";
            this.buttonAide.Size = new System.Drawing.Size(75, 23);
            this.buttonAide.TabIndex = 1;
            this.buttonAide.Text = "&Aide";
            this.buttonAide.UseVisualStyleBackColor = true;
            this.buttonAide.Click += new System.EventHandler(this.buttonAide_Click);
            // 
            // buttonOuvrir
            // 
            this.buttonOuvrir.Location = new System.Drawing.Point(187, 141);
            this.buttonOuvrir.Name = "buttonOuvrir";
            this.buttonOuvrir.Size = new System.Drawing.Size(75, 23);
            this.buttonOuvrir.TabIndex = 2;
            this.buttonOuvrir.Text = "&Ouvrir";
            this.buttonOuvrir.UseVisualStyleBackColor = true;
            this.buttonOuvrir.Click += new System.EventHandler(this.buttonOuvrir_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(268, 141);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 3;
            this.buttonAnnuler.Text = "A&nnuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // comboBoxCodeUtilisateur
            // 
            this.comboBoxCodeUtilisateur.FormattingEnabled = true;
            this.comboBoxCodeUtilisateur.Location = new System.Drawing.Point(78, 70);
            this.comboBoxCodeUtilisateur.Name = "comboBoxCodeUtilisateur";
            this.comboBoxCodeUtilisateur.Size = new System.Drawing.Size(119, 21);
            this.comboBoxCodeUtilisateur.TabIndex = 4;
            // 
            // checkBoxSupprimer
            // 
            this.checkBoxSupprimer.AutoSize = true;
            this.checkBoxSupprimer.Location = new System.Drawing.Point(216, 74);
            this.checkBoxSupprimer.Name = "checkBoxSupprimer";
            this.checkBoxSupprimer.Size = new System.Drawing.Size(73, 17);
            this.checkBoxSupprimer.TabIndex = 5;
            this.checkBoxSupprimer.Text = "Supprimer";
            this.checkBoxSupprimer.UseVisualStyleBackColor = true;
            // 
            // errorProviderUtilisateur
            // 
            this.errorProviderUtilisateur.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Code :";
            // 
            // pictureBoxIcone
            // 
            this.pictureBoxIcone.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcone.Image")));
            this.pictureBoxIcone.Location = new System.Drawing.Point(10, 9);
            this.pictureBoxIcone.Name = "pictureBoxIcone";
            this.pictureBoxIcone.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxIcone.TabIndex = 7;
            this.pictureBoxIcone.TabStop = false;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelTitre.Location = new System.Drawing.Point(58, 17);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(281, 16);
            this.labelTitre.TabIndex = 8;
            this.labelTitre.Text = "Modifier les paramètres des utilisateurs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Libelle :";
            // 
            // textBoxLibelleUtilisateur
            // 
            this.textBoxLibelleUtilisateur.Location = new System.Drawing.Point(78, 98);
            this.textBoxLibelleUtilisateur.Name = "textBoxLibelleUtilisateur";
            this.textBoxLibelleUtilisateur.Size = new System.Drawing.Size(209, 20);
            this.textBoxLibelleUtilisateur.TabIndex = 10;
            // 
            // FormUtilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 169);
            this.Controls.Add(this.textBoxLibelleUtilisateur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.pictureBoxIcone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxSupprimer);
            this.Controls.Add(this.comboBoxCodeUtilisateur);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonOuvrir);
            this.Controls.Add(this.buttonAide);
            this.Controls.Add(this.userControlFenetreType1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUtilisateurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utilisateurs";
            this.Load += new System.EventHandler(this.FormUtilisateurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUtilisateur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlFenetreType userControlFenetreType1;
        private System.Windows.Forms.Button buttonAide;
        private System.Windows.Forms.Button buttonOuvrir;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.ComboBox comboBoxCodeUtilisateur;
        private System.Windows.Forms.CheckBox checkBoxSupprimer;
        private System.Windows.Forms.ErrorProvider errorProviderUtilisateur;
        private System.Windows.Forms.HelpProvider helpProviderUtilisateur;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.PictureBox pictureBoxIcone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLibelleUtilisateur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTipUtilisateur;
    }
}