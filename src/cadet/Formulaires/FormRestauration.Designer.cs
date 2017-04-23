namespace CADET
{
    partial class FormRestauration
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
            this.labelTitre = new System.Windows.Forms.Label();
            this.buttonAide = new System.Windows.Forms.Button();
            this.buttonRestaurer = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.comboBoxCodeRestauration = new System.Windows.Forms.ComboBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelLibelle = new System.Windows.Forms.Label();
            this.textBoxLibelleRestaurer = new System.Windows.Forms.TextBox();
            this.errorProviderRestaurer = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProviderRestaurer = new System.Windows.Forms.HelpProvider();
            this.toolTipRestaurer = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxIcone = new System.Windows.Forms.PictureBox();
            this.userControlFenetreType1 = new CADET.UserControlFenetreType();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRestaurer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelTitre.Location = new System.Drawing.Point(42, 14);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(305, 16);
            this.labelTitre.TabIndex = 2;
            this.labelTitre.Text = "Ouverture d\'un exercice comptable existant";
            // 
            // buttonAide
            // 
            this.buttonAide.Location = new System.Drawing.Point(12, 140);
            this.buttonAide.Name = "buttonAide";
            this.buttonAide.Size = new System.Drawing.Size(75, 23);
            this.buttonAide.TabIndex = 3;
            this.buttonAide.Text = "&Aide";
            this.buttonAide.UseVisualStyleBackColor = true;
            this.buttonAide.Click += new System.EventHandler(this.buttonAide_Click);
            // 
            // buttonRestaurer
            // 
            this.buttonRestaurer.Location = new System.Drawing.Point(186, 140);
            this.buttonRestaurer.Name = "buttonRestaurer";
            this.buttonRestaurer.Size = new System.Drawing.Size(75, 23);
            this.buttonRestaurer.TabIndex = 4;
            this.buttonRestaurer.Text = "&Ouvrir";
            this.buttonRestaurer.UseVisualStyleBackColor = true;
            this.buttonRestaurer.Click += new System.EventHandler(this.buttonRestaurer_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(267, 140);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 5;
            this.buttonAnnuler.Text = "A&nnuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // comboBoxCodeRestauration
            // 
            this.comboBoxCodeRestauration.FormattingEnabled = true;
            this.comboBoxCodeRestauration.Location = new System.Drawing.Point(79, 62);
            this.comboBoxCodeRestauration.Name = "comboBoxCodeRestauration";
            this.comboBoxCodeRestauration.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCodeRestauration.TabIndex = 6;
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(12, 65);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(41, 13);
            this.labelCode.TabIndex = 7;
            this.labelCode.Text = "Code : ";
            // 
            // labelLibelle
            // 
            this.labelLibelle.AutoSize = true;
            this.labelLibelle.Location = new System.Drawing.Point(12, 97);
            this.labelLibelle.Name = "labelLibelle";
            this.labelLibelle.Size = new System.Drawing.Size(43, 13);
            this.labelLibelle.TabIndex = 8;
            this.labelLibelle.Text = "Libelle :";
            // 
            // textBoxLibelleRestaurer
            // 
            this.textBoxLibelleRestaurer.Location = new System.Drawing.Point(79, 97);
            this.textBoxLibelleRestaurer.Name = "textBoxLibelleRestaurer";
            this.textBoxLibelleRestaurer.Size = new System.Drawing.Size(249, 20);
            this.textBoxLibelleRestaurer.TabIndex = 9;
            // 
            // errorProviderRestaurer
            // 
            this.errorProviderRestaurer.ContainerControl = this;
            // 
            // pictureBoxIcone
            // 
            this.pictureBoxIcone.Location = new System.Drawing.Point(5, 7);
            this.pictureBoxIcone.Name = "pictureBoxIcone";
            this.pictureBoxIcone.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxIcone.TabIndex = 1;
            this.pictureBoxIcone.TabStop = false;
            // 
            // userControlFenetreType1
            // 
            this.userControlFenetreType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlFenetreType1.Location = new System.Drawing.Point(0, 0);
            this.userControlFenetreType1.Name = "userControlFenetreType1";
            this.userControlFenetreType1.Size = new System.Drawing.Size(354, 169);
            this.userControlFenetreType1.TabIndex = 0;
            // 
            // FormRestauration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 169);
            this.Controls.Add(this.textBoxLibelleRestaurer);
            this.Controls.Add(this.labelLibelle);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.comboBoxCodeRestauration);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonRestaurer);
            this.Controls.Add(this.buttonAide);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.pictureBoxIcone);
            this.Controls.Add(this.userControlFenetreType1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRestauration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restauration";
            this.Load += new System.EventHandler(this.FormRestauration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRestaurer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlFenetreType userControlFenetreType1;
        private System.Windows.Forms.PictureBox pictureBoxIcone;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Button buttonAide;
        private System.Windows.Forms.Button buttonRestaurer;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.ComboBox comboBoxCodeRestauration;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelLibelle;
        private System.Windows.Forms.TextBox textBoxLibelleRestaurer;
        private System.Windows.Forms.ErrorProvider errorProviderRestaurer;
        private System.Windows.Forms.HelpProvider helpProviderRestaurer;
        private System.Windows.Forms.ToolTip toolTipRestaurer;
    }
}