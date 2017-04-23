namespace CADET
{
    partial class FormExporteEcritures
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
            this.buttonAide = new System.Windows.Forms.Button();
            this.buttonExporterXml = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.checkBoxExportExritures = new System.Windows.Forms.CheckBox();
            this.comboBoxCodeExportEcritures = new System.Windows.Forms.ComboBox();
            this.errorProviderExportEcritures = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelTitre = new System.Windows.Forms.Label();
            this.textBoxLibelleExportEcritures = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.helpProviderExportEcritures = new System.Windows.Forms.HelpProvider();
            this.toolTipExportEcritures = new System.Windows.Forms.ToolTip(this.components);
            this.buttonExporterCsv = new System.Windows.Forms.Button();
            this.pictureBoxIcone = new System.Windows.Forms.PictureBox();
            this.userControlFenetreType1 = new CADET.UserControlFenetreType();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderExportEcritures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAide
            // 
            this.buttonAide.Location = new System.Drawing.Point(8, 142);
            this.buttonAide.Name = "buttonAide";
            this.buttonAide.Size = new System.Drawing.Size(75, 23);
            this.buttonAide.TabIndex = 1;
            this.buttonAide.Text = "&Aide";
            this.buttonAide.UseVisualStyleBackColor = true;
            this.buttonAide.Click += new System.EventHandler(this.buttonAide_Click);
            // 
            // buttonExporterXml
            // 
            this.buttonExporterXml.Location = new System.Drawing.Point(195, 142);
            this.buttonExporterXml.Name = "buttonExporterXml";
            this.buttonExporterXml.Size = new System.Drawing.Size(94, 23);
            this.buttonExporterXml.TabIndex = 2;
            this.buttonExporterXml.Text = "&Exporter en XML";
            this.buttonExporterXml.UseVisualStyleBackColor = true;
            this.buttonExporterXml.Click += new System.EventHandler(this.buttonExporterXml_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(295, 142);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 3;
            this.buttonAnnuler.Text = "A&nnuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // checkBoxExportExritures
            // 
            this.checkBoxExportExritures.AutoSize = true;
            this.checkBoxExportExritures.Location = new System.Drawing.Point(224, 77);
            this.checkBoxExportExritures.Name = "checkBoxExportExritures";
            this.checkBoxExportExritures.Size = new System.Drawing.Size(84, 17);
            this.checkBoxExportExritures.TabIndex = 4;
            this.checkBoxExportExritures.Text = "Suppression";
            this.checkBoxExportExritures.UseVisualStyleBackColor = true;
            // 
            // comboBoxCodeExportEcritures
            // 
            this.comboBoxCodeExportEcritures.FormattingEnabled = true;
            this.comboBoxCodeExportEcritures.Location = new System.Drawing.Point(60, 75);
            this.comboBoxCodeExportEcritures.Name = "comboBoxCodeExportEcritures";
            this.comboBoxCodeExportEcritures.Size = new System.Drawing.Size(123, 21);
            this.comboBoxCodeExportEcritures.TabIndex = 5;
            // 
            // errorProviderExportEcritures
            // 
            this.errorProviderExportEcritures.ContainerControl = this;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelTitre.Location = new System.Drawing.Point(53, 17);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(303, 16);
            this.labelTitre.TabIndex = 6;
            this.labelTitre.Text = "Exporter les écritures au format Xml ou Csv";
            // 
            // textBoxLibelleExportEcritures
            // 
            this.textBoxLibelleExportEcritures.Location = new System.Drawing.Point(61, 102);
            this.textBoxLibelleExportEcritures.Name = "textBoxLibelleExportEcritures";
            this.textBoxLibelleExportEcritures.Size = new System.Drawing.Size(244, 20);
            this.textBoxLibelleExportEcritures.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Code : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Libelle :";
            // 
            // buttonExporterCsv
            // 
            this.buttonExporterCsv.Location = new System.Drawing.Point(89, 142);
            this.buttonExporterCsv.Name = "buttonExporterCsv";
            this.buttonExporterCsv.Size = new System.Drawing.Size(94, 23);
            this.buttonExporterCsv.TabIndex = 11;
            this.buttonExporterCsv.Text = "E&xporter en CSV";
            this.buttonExporterCsv.UseVisualStyleBackColor = true;
            this.buttonExporterCsv.Click += new System.EventHandler(this.buttonExporterCsv_Click);
            // 
            // pictureBoxIcone
            // 
            this.pictureBoxIcone.Image = global::CADET.Properties.Resources.up_folder;
            this.pictureBoxIcone.Location = new System.Drawing.Point(9, 9);
            this.pictureBoxIcone.Name = "pictureBoxIcone";
            this.pictureBoxIcone.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxIcone.TabIndex = 7;
            this.pictureBoxIcone.TabStop = false;
            // 
            // userControlFenetreType1
            // 
            this.userControlFenetreType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlFenetreType1.Location = new System.Drawing.Point(0, 0);
            this.userControlFenetreType1.Name = "userControlFenetreType1";
            this.userControlFenetreType1.Size = new System.Drawing.Size(378, 169);
            this.userControlFenetreType1.TabIndex = 0;
            // 
            // FormExporteEcritures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 169);
            this.Controls.Add(this.buttonExporterCsv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLibelleExportEcritures);
            this.Controls.Add(this.pictureBoxIcone);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.comboBoxCodeExportEcritures);
            this.Controls.Add(this.checkBoxExportExritures);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonExporterXml);
            this.Controls.Add(this.buttonAide);
            this.Controls.Add(this.userControlFenetreType1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExporteEcritures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export des Ecritures";
            this.Load += new System.EventHandler(this.FormExporteEcritures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderExportEcritures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlFenetreType userControlFenetreType1;
        private System.Windows.Forms.Button buttonAide;
        private System.Windows.Forms.Button buttonExporterXml;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.CheckBox checkBoxExportExritures;
        private System.Windows.Forms.ComboBox comboBoxCodeExportEcritures;
        private System.Windows.Forms.ErrorProvider errorProviderExportEcritures;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLibelleExportEcritures;
        private System.Windows.Forms.PictureBox pictureBoxIcone;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.HelpProvider helpProviderExportEcritures;
        private System.Windows.Forms.ToolTip toolTipExportEcritures;
        private System.Windows.Forms.Button buttonExporterCsv;
    }
}