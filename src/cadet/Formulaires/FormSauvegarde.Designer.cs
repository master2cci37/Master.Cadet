namespace CADET
{
    partial class FormSauvegarde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSauvegarde));
            this.userControlFenetreType1 = new CADET.UserControlFenetreType();
            this.buttonAide = new System.Windows.Forms.Button();
            this.buttonEnregister = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.labelTitre = new System.Windows.Forms.Label();
            this.pictureBoxIcone = new System.Windows.Forms.PictureBox();
            this.textBoxLibelleSauvegarde = new System.Windows.Forms.TextBox();
            this.errorProviderSauvegarde = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProviderSauvegarde = new System.Windows.Forms.HelpProvider();
            this.toolTipSauvegarde = new System.Windows.Forms.ToolTip(this.components);
            this.labelCode = new System.Windows.Forms.Label();
            this.labelLibelle = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBoxCodeSauvegarde = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSauvegarde)).BeginInit();
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
            this.buttonAide.Location = new System.Drawing.Point(7, 140);
            this.buttonAide.Name = "buttonAide";
            this.buttonAide.Size = new System.Drawing.Size(75, 23);
            this.buttonAide.TabIndex = 1;
            this.buttonAide.Text = "&Aide";
            this.buttonAide.UseVisualStyleBackColor = true;
            this.buttonAide.Click += new System.EventHandler(this.buttonAide_Click);
            // 
            // buttonEnregister
            // 
            this.buttonEnregister.Location = new System.Drawing.Point(180, 140);
            this.buttonEnregister.Name = "buttonEnregister";
            this.buttonEnregister.Size = new System.Drawing.Size(75, 23);
            this.buttonEnregister.TabIndex = 2;
            this.buttonEnregister.Text = "&Enregistrer";
            this.buttonEnregister.UseVisualStyleBackColor = true;
            this.buttonEnregister.Click += new System.EventHandler(this.buttonEnregister_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(269, 140);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 3;
            this.buttonAnnuler.Text = "A&nnuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelTitre.Location = new System.Drawing.Point(58, 11);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(226, 16);
            this.labelTitre.TabIndex = 5;
            this.labelTitre.Text = "Sauvegarder votre comptabilité";
            // 
            // pictureBoxIcone
            // 
            this.pictureBoxIcone.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcone.Image")));
            this.pictureBoxIcone.Location = new System.Drawing.Point(7, 3);
            this.pictureBoxIcone.Name = "pictureBoxIcone";
            this.pictureBoxIcone.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxIcone.TabIndex = 4;
            this.pictureBoxIcone.TabStop = false;
            // 
            // textBoxLibelleSauvegarde
            // 
            this.textBoxLibelleSauvegarde.Location = new System.Drawing.Point(70, 99);
            this.textBoxLibelleSauvegarde.Name = "textBoxLibelleSauvegarde";
            this.textBoxLibelleSauvegarde.Size = new System.Drawing.Size(270, 20);
            this.textBoxLibelleSauvegarde.TabIndex = 7;
            // 
            // errorProviderSauvegarde
            // 
            this.errorProviderSauvegarde.ContainerControl = this;
            this.errorProviderSauvegarde.RightToLeftChanged += new System.EventHandler(this.buttonEnregister_Click);
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(10, 67);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(38, 13);
            this.labelCode.TabIndex = 8;
            this.labelCode.Text = "Code :";
            // 
            // labelLibelle
            // 
            this.labelLibelle.AutoSize = true;
            this.labelLibelle.Location = new System.Drawing.Point(10, 102);
            this.labelLibelle.Name = "labelLibelle";
            this.labelLibelle.Size = new System.Drawing.Size(43, 13);
            this.labelLibelle.TabIndex = 9;
            this.labelLibelle.Text = "Libelle :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(258, 64);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Suppression";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBoxCodeSauvegarde
            // 
            this.comboBoxCodeSauvegarde.FormattingEnabled = true;
            this.comboBoxCodeSauvegarde.Location = new System.Drawing.Point(70, 64);
            this.comboBoxCodeSauvegarde.Name = "comboBoxCodeSauvegarde";
            this.comboBoxCodeSauvegarde.Size = new System.Drawing.Size(139, 21);
            this.comboBoxCodeSauvegarde.TabIndex = 11;
            // 
            // FormSauvegarde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 169);
            this.Controls.Add(this.comboBoxCodeSauvegarde);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelLibelle);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.textBoxLibelleSauvegarde);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.pictureBoxIcone);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonEnregister);
            this.Controls.Add(this.buttonAide);
            this.Controls.Add(this.userControlFenetreType1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSauvegarde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sauvegarde";
            this.Load += new System.EventHandler(this.Sauvegarde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSauvegarde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlFenetreType userControlFenetreType1;
        private System.Windows.Forms.Button buttonAide;
        private System.Windows.Forms.Button buttonEnregister;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.PictureBox pictureBoxIcone;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.TextBox textBoxLibelleSauvegarde;
        private System.Windows.Forms.ErrorProvider errorProviderSauvegarde;
        private System.Windows.Forms.HelpProvider helpProviderSauvegarde;
        private System.Windows.Forms.ToolTip toolTipSauvegarde;
        private System.Windows.Forms.ComboBox comboBoxCodeSauvegarde;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelLibelle;
        private System.Windows.Forms.Label labelCode;
    }
}