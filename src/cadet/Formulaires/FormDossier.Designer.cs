namespace CADET
{
    partial class FormDossier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDossier));
            this.userControlFenetreType1 = new CADET.UserControlFenetreType();
            this.buttonAide = new System.Windows.Forms.Button();
            this.buttonEditer = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.comboBoxCodeDossier = new System.Windows.Forms.ComboBox();
            this.labelTitre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxIcone = new System.Windows.Forms.PictureBox();
            this.textBoxLibelleDossier = new System.Windows.Forms.TextBox();
            this.errorProviderDossier = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProviderDossier = new System.Windows.Forms.HelpProvider();
            this.toolTipDossier = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDossier)).BeginInit();
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
            this.buttonAide.Location = new System.Drawing.Point(13, 139);
            this.buttonAide.Name = "buttonAide";
            this.buttonAide.Size = new System.Drawing.Size(75, 23);
            this.buttonAide.TabIndex = 1;
            this.buttonAide.Text = "&Aide";
            this.buttonAide.UseVisualStyleBackColor = true;
            this.buttonAide.Click += new System.EventHandler(this.buttonAide_Click);
            // 
            // buttonEditer
            // 
            this.buttonEditer.Location = new System.Drawing.Point(187, 139);
            this.buttonEditer.Name = "buttonEditer";
            this.buttonEditer.Size = new System.Drawing.Size(75, 23);
            this.buttonEditer.TabIndex = 2;
            this.buttonEditer.Text = "&Editer";
            this.buttonEditer.UseVisualStyleBackColor = true;
            this.buttonEditer.Click += new System.EventHandler(this.buttonEditer_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(268, 139);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 3;
            this.buttonAnnuler.Text = "A&nnuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // comboBoxCodeDossier
            // 
            this.comboBoxCodeDossier.FormattingEnabled = true;
            this.comboBoxCodeDossier.Location = new System.Drawing.Point(75, 69);
            this.comboBoxCodeDossier.Name = "comboBoxCodeDossier";
            this.comboBoxCodeDossier.Size = new System.Drawing.Size(137, 21);
            this.comboBoxCodeDossier.TabIndex = 4;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelTitre.Location = new System.Drawing.Point(42, 18);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(309, 16);
            this.labelTitre.TabIndex = 5;
            this.labelTitre.Text = "Edition des paramètres du dossier en cours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Code :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Libelle :";
            // 
            // pictureBoxIcone
            // 
            this.pictureBoxIcone.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcone.Image")));
            this.pictureBoxIcone.Location = new System.Drawing.Point(6, 9);
            this.pictureBoxIcone.Name = "pictureBoxIcone";
            this.pictureBoxIcone.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxIcone.TabIndex = 8;
            this.pictureBoxIcone.TabStop = false;
            // 
            // textBoxLibelleDossier
            // 
            this.textBoxLibelleDossier.Location = new System.Drawing.Point(75, 100);
            this.textBoxLibelleDossier.Name = "textBoxLibelleDossier";
            this.textBoxLibelleDossier.Size = new System.Drawing.Size(220, 20);
            this.textBoxLibelleDossier.TabIndex = 9;
            // 
            // errorProviderDossier
            // 
            this.errorProviderDossier.ContainerControl = this;
            // 
            // FormDossier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 169);
            this.Controls.Add(this.textBoxLibelleDossier);
            this.Controls.Add(this.pictureBoxIcone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.comboBoxCodeDossier);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonEditer);
            this.Controls.Add(this.buttonAide);
            this.Controls.Add(this.userControlFenetreType1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDossier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dossier";
            this.Load += new System.EventHandler(this.FormDossier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDossier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlFenetreType userControlFenetreType1;
        private System.Windows.Forms.Button buttonAide;
        private System.Windows.Forms.Button buttonEditer;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.ComboBox comboBoxCodeDossier;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxIcone;
        private System.Windows.Forms.TextBox textBoxLibelleDossier;
        private System.Windows.Forms.ErrorProvider errorProviderDossier;
        private System.Windows.Forms.HelpProvider helpProviderDossier;
        private System.Windows.Forms.ToolTip toolTipDossier;
    }
}