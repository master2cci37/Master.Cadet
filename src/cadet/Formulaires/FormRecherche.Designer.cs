namespace CADET
{
    partial class FormRecherche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecherche));
            this.userControlFenetreType1 = new CADET.UserControlFenetreType();
            this.comboBoxCodeRecherche = new System.Windows.Forms.ComboBox();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonOuvrir = new System.Windows.Forms.Button();
            this.buttonAide = new System.Windows.Forms.Button();
            this.labelTitre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLibelleRecherche = new System.Windows.Forms.TextBox();
            this.pictureBoxIcone = new System.Windows.Forms.PictureBox();
            this.errorProviderRecherche = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProviderRecherche = new System.Windows.Forms.HelpProvider();
            this.toolTipRecherche = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRecherche)).BeginInit();
            this.SuspendLayout();
            // 
            // userControlFenetreType1
            // 
            this.userControlFenetreType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlFenetreType1.Location = new System.Drawing.Point(0, 0);
            this.userControlFenetreType1.Name = "userControlFenetreType1";
            this.userControlFenetreType1.Size = new System.Drawing.Size(354, 163);
            this.userControlFenetreType1.TabIndex = 0;
            // 
            // comboBoxCodeRecherche
            // 
            this.comboBoxCodeRecherche.FormattingEnabled = true;
            this.comboBoxCodeRecherche.Location = new System.Drawing.Point(69, 65);
            this.comboBoxCodeRecherche.Name = "comboBoxCodeRecherche";
            this.comboBoxCodeRecherche.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCodeRecherche.TabIndex = 1;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(268, 134);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 2;
            this.buttonAnnuler.Text = "A&nnuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonOuvrir
            // 
            this.buttonOuvrir.Location = new System.Drawing.Point(187, 134);
            this.buttonOuvrir.Name = "buttonOuvrir";
            this.buttonOuvrir.Size = new System.Drawing.Size(75, 23);
            this.buttonOuvrir.TabIndex = 3;
            this.buttonOuvrir.Text = "&Ouvrir";
            this.buttonOuvrir.UseVisualStyleBackColor = true;
            this.buttonOuvrir.Click += new System.EventHandler(this.buttonOuvrir_Click);
            // 
            // buttonAide
            // 
            this.buttonAide.Location = new System.Drawing.Point(13, 134);
            this.buttonAide.Name = "buttonAide";
            this.buttonAide.Size = new System.Drawing.Size(75, 23);
            this.buttonAide.TabIndex = 4;
            this.buttonAide.Text = "&Aide";
            this.buttonAide.UseVisualStyleBackColor = true;
            this.buttonAide.Click += new System.EventHandler(this.buttonAide_Click);
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelTitre.Location = new System.Drawing.Point(54, 18);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(189, 16);
            this.labelTitre.TabIndex = 5;
            this.labelTitre.Text = "Recherche d\'une écritures";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Code : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Libelle : ";
            // 
            // textBoxLibelleRecherche
            // 
            this.textBoxLibelleRecherche.Location = new System.Drawing.Point(69, 93);
            this.textBoxLibelleRecherche.Name = "textBoxLibelleRecherche";
            this.textBoxLibelleRecherche.Size = new System.Drawing.Size(236, 20);
            this.textBoxLibelleRecherche.TabIndex = 8;
            // 
            // pictureBoxIcone
            // 
            this.pictureBoxIcone.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcone.Image")));
            this.pictureBoxIcone.Location = new System.Drawing.Point(8, 8);
            this.pictureBoxIcone.Name = "pictureBoxIcone";
            this.pictureBoxIcone.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxIcone.TabIndex = 9;
            this.pictureBoxIcone.TabStop = false;
            // 
            // errorProviderRecherche
            // 
            this.errorProviderRecherche.ContainerControl = this;
            // 
            // FormRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 163);
            this.Controls.Add(this.pictureBoxIcone);
            this.Controls.Add(this.textBoxLibelleRecherche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.buttonAide);
            this.Controls.Add(this.buttonOuvrir);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.comboBoxCodeRecherche);
            this.Controls.Add(this.userControlFenetreType1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRecherche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recherche";
            this.Load += new System.EventHandler(this.FormRecherche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRecherche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlFenetreType userControlFenetreType1;
        private System.Windows.Forms.ComboBox comboBoxCodeRecherche;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonOuvrir;
        private System.Windows.Forms.Button buttonAide;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLibelleRecherche;
        private System.Windows.Forms.PictureBox pictureBoxIcone;
        private System.Windows.Forms.ErrorProvider errorProviderRecherche;
        private System.Windows.Forms.HelpProvider helpProviderRecherche;
        private System.Windows.Forms.ToolTip toolTipRecherche;
    }
}