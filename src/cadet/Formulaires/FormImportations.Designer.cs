namespace CADET
{
    partial class FormImportations
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
            this.userControlFenetreType1 = new CADET.UserControlFenetreType();
            this.pictureBoxIcone = new System.Windows.Forms.PictureBox();
            this.labelTitre = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonAide = new System.Windows.Forms.Button();
            this.toolTipImportations = new System.Windows.Forms.ToolTip(this.components);
            this.helpProviderImportations = new System.Windows.Forms.HelpProvider();
            this.errorProviderImportations = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialogImportations = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogImportations = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderImportations)).BeginInit();
            this.SuspendLayout();
            // 
            // userControlFenetreType1
            // 
            this.userControlFenetreType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlFenetreType1.Location = new System.Drawing.Point(0, 0);
            this.userControlFenetreType1.Name = "userControlFenetreType1";
            this.userControlFenetreType1.Size = new System.Drawing.Size(362, 171);
            this.userControlFenetreType1.TabIndex = 0;
            // 
            // pictureBoxIcone
            // 
            this.pictureBoxIcone.Location = new System.Drawing.Point(6, 4);
            this.pictureBoxIcone.Name = "pictureBoxIcone";
            this.pictureBoxIcone.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxIcone.TabIndex = 1;
            this.pictureBoxIcone.TabStop = false;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelTitre.Location = new System.Drawing.Point(89, 7);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(184, 32);
            this.labelTitre.TabIndex = 2;
            this.labelTitre.Text = "    Import des écritures et \r\n    comptes au format &XML";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(205, 144);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(285, 144);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 4;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // buttonAide
            // 
            this.buttonAide.Location = new System.Drawing.Point(3, 144);
            this.buttonAide.Name = "buttonAide";
            this.buttonAide.Size = new System.Drawing.Size(75, 23);
            this.buttonAide.TabIndex = 5;
            this.buttonAide.Text = "&Aide";
            this.buttonAide.UseVisualStyleBackColor = true;
            // 
            // errorProviderImportations
            // 
            this.errorProviderImportations.ContainerControl = this;
            // 
            // openFileDialogImportations
            // 
            this.openFileDialogImportations.FileName = "openFileDialog1";
            // 
            // FormImportations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 171);
            this.Controls.Add(this.buttonAide);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.pictureBoxIcone);
            this.Controls.Add(this.userControlFenetreType1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormImportations";
            this.Text = "FormImportations";
            this.Load += new System.EventHandler(this.FormImportations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderImportations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlFenetreType userControlFenetreType1;
        private System.Windows.Forms.PictureBox pictureBoxIcone;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonAide;
        private System.Windows.Forms.ToolTip toolTipImportations;
        private System.Windows.Forms.HelpProvider helpProviderImportations;
        private System.Windows.Forms.ErrorProvider errorProviderImportations;
        private System.Windows.Forms.OpenFileDialog openFileDialogImportations;
        private System.Windows.Forms.SaveFileDialog saveFileDialogImportations;
    }
}