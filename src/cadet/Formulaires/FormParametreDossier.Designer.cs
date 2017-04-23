namespace CADET
{
    partial class FormParametreDossier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParametreDossier));
            this.pictureBoxIcone = new System.Windows.Forms.PictureBox();
            this.labelTitre = new System.Windows.Forms.Label();
            this.buttonAide = new System.Windows.Forms.Button();
            this.buttonCofigurer = new System.Windows.Forms.Button();
            this.buttonEnrgisterXml = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelLibelle = new System.Windows.Forms.Label();
            this.comboBoxCodeParammetreDossier = new System.Windows.Forms.ComboBox();
            this.textBoxLibelleParametreDossier = new System.Windows.Forms.TextBox();
            this.errorProviderParametreDossier = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProviderParametreDossier = new System.Windows.Forms.HelpProvider();
            this.toolTipParametreDossier = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxSignaletiqueParametresDossier = new System.Windows.Forms.GroupBox();
            this.checkBoxSupprimer = new System.Windows.Forms.CheckBox();
            this.userControlFenetreType1 = new CADET.UserControlFenetreType();
            this.groupBoxParametresDossierElement = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxElementsDossier = new System.Windows.Forms.GroupBox();
            this.textBoxCheminBase = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxFederation = new System.Windows.Forms.TextBox();
            this.textBoxAssociation = new System.Windows.Forms.TextBox();
            this.textBoxDateMaJour = new System.Windows.Forms.TextBox();
            this.textBoxDateCreation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderParametreDossier)).BeginInit();
            this.groupBoxSignaletiqueParametresDossier.SuspendLayout();
            this.groupBoxParametresDossierElement.SuspendLayout();
            this.groupBoxElementsDossier.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxIcone
            // 
            this.pictureBoxIcone.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcone.Image")));
            this.pictureBoxIcone.Location = new System.Drawing.Point(8, 9);
            this.pictureBoxIcone.Name = "pictureBoxIcone";
            this.pictureBoxIcone.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxIcone.TabIndex = 1;
            this.pictureBoxIcone.TabStop = false;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelTitre.Location = new System.Drawing.Point(52, 8);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(317, 32);
            this.labelTitre.TabIndex = 2;
            this.labelTitre.Text = "Modifier les éléments d\'un dossier et de son \r\nenvironnement de travail";
            // 
            // buttonAide
            // 
            this.buttonAide.Location = new System.Drawing.Point(9, 259);
            this.buttonAide.Name = "buttonAide";
            this.buttonAide.Size = new System.Drawing.Size(75, 23);
            this.buttonAide.TabIndex = 3;
            this.buttonAide.Text = "&Aide";
            this.buttonAide.UseVisualStyleBackColor = true;
            this.buttonAide.Click += new System.EventHandler(this.buttonAide_Click);
            // 
            // buttonCofigurer
            // 
            this.buttonCofigurer.Location = new System.Drawing.Point(121, 259);
            this.buttonCofigurer.Name = "buttonCofigurer";
            this.buttonCofigurer.Size = new System.Drawing.Size(75, 23);
            this.buttonCofigurer.TabIndex = 4;
            this.buttonCofigurer.Text = "&Configurer";
            this.buttonCofigurer.UseVisualStyleBackColor = true;
            this.buttonCofigurer.Click += new System.EventHandler(this.buttonCofigurer_Click);
            // 
            // buttonEnrgisterXml
            // 
            this.buttonEnrgisterXml.Location = new System.Drawing.Point(203, 259);
            this.buttonEnrgisterXml.Name = "buttonEnrgisterXml";
            this.buttonEnrgisterXml.Size = new System.Drawing.Size(149, 23);
            this.buttonEnrgisterXml.TabIndex = 14;
            this.buttonEnrgisterXml.Text = "&Enregistrer Au Format XML";
            this.buttonEnrgisterXml.Click += new System.EventHandler(this.buttonEnrgisterXml_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(358, 259);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 7;
            this.buttonAnnuler.Text = "A&nnuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(12, 22);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(38, 13);
            this.labelCode.TabIndex = 8;
            this.labelCode.Text = "Code :";
            // 
            // labelLibelle
            // 
            this.labelLibelle.AutoSize = true;
            this.labelLibelle.Location = new System.Drawing.Point(12, 54);
            this.labelLibelle.Name = "labelLibelle";
            this.labelLibelle.Size = new System.Drawing.Size(43, 13);
            this.labelLibelle.TabIndex = 9;
            this.labelLibelle.Text = "Libelle :";
            // 
            // comboBoxCodeParammetreDossier
            // 
            this.comboBoxCodeParammetreDossier.FormattingEnabled = true;
            this.comboBoxCodeParammetreDossier.Location = new System.Drawing.Point(91, 19);
            this.comboBoxCodeParammetreDossier.Name = "comboBoxCodeParammetreDossier";
            this.comboBoxCodeParammetreDossier.Size = new System.Drawing.Size(133, 21);
            this.comboBoxCodeParammetreDossier.TabIndex = 10;
            // 
            // textBoxLibelleParametreDossier
            // 
            this.textBoxLibelleParametreDossier.Location = new System.Drawing.Point(91, 51);
            this.textBoxLibelleParametreDossier.Name = "textBoxLibelleParametreDossier";
            this.textBoxLibelleParametreDossier.Size = new System.Drawing.Size(262, 20);
            this.textBoxLibelleParametreDossier.TabIndex = 11;
            // 
            // errorProviderParametreDossier
            // 
            this.errorProviderParametreDossier.ContainerControl = this;
            // 
            // groupBoxSignaletiqueParametresDossier
            // 
            this.groupBoxSignaletiqueParametresDossier.Controls.Add(this.checkBoxSupprimer);
            this.groupBoxSignaletiqueParametresDossier.Controls.Add(this.comboBoxCodeParammetreDossier);
            this.groupBoxSignaletiqueParametresDossier.Controls.Add(this.labelLibelle);
            this.groupBoxSignaletiqueParametresDossier.Controls.Add(this.textBoxLibelleParametreDossier);
            this.groupBoxSignaletiqueParametresDossier.Controls.Add(this.labelCode);
            this.groupBoxSignaletiqueParametresDossier.Location = new System.Drawing.Point(11, 57);
            this.groupBoxSignaletiqueParametresDossier.Name = "groupBoxSignaletiqueParametresDossier";
            this.groupBoxSignaletiqueParametresDossier.Size = new System.Drawing.Size(422, 77);
            this.groupBoxSignaletiqueParametresDossier.TabIndex = 12;
            this.groupBoxSignaletiqueParametresDossier.TabStop = false;
            this.groupBoxSignaletiqueParametresDossier.Text = "Signalétique";
            // 
            // checkBoxSupprimer
            // 
            this.checkBoxSupprimer.AutoSize = true;
            this.checkBoxSupprimer.Location = new System.Drawing.Point(276, 22);
            this.checkBoxSupprimer.Name = "checkBoxSupprimer";
            this.checkBoxSupprimer.Size = new System.Drawing.Size(73, 17);
            this.checkBoxSupprimer.TabIndex = 12;
            this.checkBoxSupprimer.Text = "Supprimer";
            this.checkBoxSupprimer.UseVisualStyleBackColor = true;
            // 
            // userControlFenetreType1
            // 
            this.userControlFenetreType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlFenetreType1.Location = new System.Drawing.Point(0, 0);
            this.userControlFenetreType1.Name = "userControlFenetreType1";
            this.userControlFenetreType1.Size = new System.Drawing.Size(445, 288);
            this.userControlFenetreType1.TabIndex = 0;
            // 
            // groupBoxParametresDossierElement
            // 
            this.groupBoxParametresDossierElement.Controls.Add(this.label4);
            this.groupBoxParametresDossierElement.Controls.Add(this.label3);
            this.groupBoxParametresDossierElement.Controls.Add(this.label2);
            this.groupBoxParametresDossierElement.Controls.Add(this.label1);
            this.groupBoxParametresDossierElement.Controls.Add(this.textBox4);
            this.groupBoxParametresDossierElement.Controls.Add(this.textBox3);
            this.groupBoxParametresDossierElement.Controls.Add(this.textBox2);
            this.groupBoxParametresDossierElement.Controls.Add(this.textBox1);
            this.groupBoxParametresDossierElement.Location = new System.Drawing.Point(11, 140);
            this.groupBoxParametresDossierElement.Name = "groupBoxParametresDossierElement";
            this.groupBoxParametresDossierElement.Size = new System.Drawing.Size(422, 113);
            this.groupBoxParametresDossierElement.TabIndex = 13;
            this.groupBoxParametresDossierElement.TabStop = false;
            this.groupBoxParametresDossierElement.Text = "Elements du Dossier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fédération :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Association :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date de Mise à Jour :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date de Création :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(249, 64);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(249, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(65, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBoxElementsDossier
            // 
            this.groupBoxElementsDossier.Controls.Add(this.textBoxCheminBase);
            this.groupBoxElementsDossier.Controls.Add(this.label9);
            this.groupBoxElementsDossier.Controls.Add(this.label5);
            this.groupBoxElementsDossier.Controls.Add(this.label6);
            this.groupBoxElementsDossier.Controls.Add(this.label7);
            this.groupBoxElementsDossier.Controls.Add(this.label8);
            this.groupBoxElementsDossier.Controls.Add(this.textBoxFederation);
            this.groupBoxElementsDossier.Controls.Add(this.textBoxAssociation);
            this.groupBoxElementsDossier.Controls.Add(this.textBoxDateMaJour);
            this.groupBoxElementsDossier.Controls.Add(this.textBoxDateCreation);
            this.groupBoxElementsDossier.Location = new System.Drawing.Point(11, 140);
            this.groupBoxElementsDossier.Name = "groupBoxElementsDossier";
            this.groupBoxElementsDossier.Size = new System.Drawing.Size(422, 113);
            this.groupBoxElementsDossier.TabIndex = 13;
            this.groupBoxElementsDossier.TabStop = false;
            this.groupBoxElementsDossier.Text = "Elements du Dossier";
            // 
            // textBoxCheminBase
            // 
            this.textBoxCheminBase.Location = new System.Drawing.Point(125, 78);
            this.textBoxCheminBase.Name = "textBoxCheminBase";
            this.textBoxCheminBase.Size = new System.Drawing.Size(284, 20);
            this.textBoxCheminBase.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Chemin de Base :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fédération :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Association :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Date de Mise à Jour :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Date de Création :";
            // 
            // textBoxFederation
            // 
            this.textBoxFederation.Location = new System.Drawing.Point(309, 52);
            this.textBoxFederation.Name = "textBoxFederation";
            this.textBoxFederation.Size = new System.Drawing.Size(100, 20);
            this.textBoxFederation.TabIndex = 3;
            // 
            // textBoxAssociation
            // 
            this.textBoxAssociation.Location = new System.Drawing.Point(309, 26);
            this.textBoxAssociation.Name = "textBoxAssociation";
            this.textBoxAssociation.Size = new System.Drawing.Size(100, 20);
            this.textBoxAssociation.TabIndex = 2;
            // 
            // textBoxDateMaJour
            // 
            this.textBoxDateMaJour.Location = new System.Drawing.Point(125, 52);
            this.textBoxDateMaJour.Name = "textBoxDateMaJour";
            this.textBoxDateMaJour.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateMaJour.TabIndex = 1;
            // 
            // textBoxDateCreation
            // 
            this.textBoxDateCreation.Location = new System.Drawing.Point(125, 26);
            this.textBoxDateCreation.Name = "textBoxDateCreation";
            this.textBoxDateCreation.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateCreation.TabIndex = 0;
            // 
            // FormParametreDossier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 288);
            this.Controls.Add(this.groupBoxElementsDossier);
            this.Controls.Add(this.groupBoxParametresDossierElement);
            this.Controls.Add(this.groupBoxSignaletiqueParametresDossier);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonEnrgisterXml);
            this.Controls.Add(this.buttonCofigurer);
            this.Controls.Add(this.buttonAide);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.pictureBoxIcone);
            this.Controls.Add(this.userControlFenetreType1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormParametreDossier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paramètres dossier";
            this.Load += new System.EventHandler(this.FormParametreDossier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderParametreDossier)).EndInit();
            this.groupBoxSignaletiqueParametresDossier.ResumeLayout(false);
            this.groupBoxSignaletiqueParametresDossier.PerformLayout();
            this.groupBoxParametresDossierElement.ResumeLayout(false);
            this.groupBoxParametresDossierElement.PerformLayout();
            this.groupBoxElementsDossier.ResumeLayout(false);
            this.groupBoxElementsDossier.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlFenetreType userControlFenetreType1;
        private System.Windows.Forms.PictureBox pictureBoxIcone;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Button buttonAide;
        private System.Windows.Forms.Button buttonCofigurer;
        private System.Windows.Forms.Button buttonEnrgisterXml;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelLibelle;
        private System.Windows.Forms.ComboBox comboBoxCodeParammetreDossier;
        private System.Windows.Forms.TextBox textBoxLibelleParametreDossier;
        private System.Windows.Forms.ErrorProvider errorProviderParametreDossier;
        private System.Windows.Forms.HelpProvider helpProviderParametreDossier;
        private System.Windows.Forms.ToolTip toolTipParametreDossier;
        private System.Windows.Forms.GroupBox groupBoxSignaletiqueParametresDossier;
        private System.Windows.Forms.GroupBox groupBoxParametresDossierElement;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxSupprimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxElementsDossier;
        private System.Windows.Forms.TextBox textBoxCheminBase;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxFederation;
        private System.Windows.Forms.TextBox textBoxAssociation;
        private System.Windows.Forms.TextBox textBoxDateMaJour;
        private System.Windows.Forms.TextBox textBoxDateCreation;
    }
}