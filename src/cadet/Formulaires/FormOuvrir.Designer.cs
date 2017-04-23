namespace CADET
{
    partial class FormOuvrir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOuvrir));
            this.userControlFenetreType1 = new CADET.UserControlFenetreType();
            this.textBoxLibelleOuvrir = new System.Windows.Forms.TextBox();
            this.pictureBoxIcone = new System.Windows.Forms.PictureBox();
            this.labelTitre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCodeOuvrir = new System.Windows.Forms.ComboBox();
            this.buttonAide = new System.Windows.Forms.Button();
            this.buttonOuvrir = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.errorProviderOuvrir = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProviderOuvrir = new System.Windows.Forms.HelpProvider();
            this.toolTipOuvrir = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOuvrir)).BeginInit();
            this.SuspendLayout();
            // 
            // userControlFenetreType1
            // 
            this.userControlFenetreType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlFenetreType1.Location = new System.Drawing.Point(0, 0);
            this.userControlFenetreType1.Name = "userControlFenetreType1";
            this.userControlFenetreType1.Size = new System.Drawing.Size(354, 169);
            this.userControlFenetreType1.TabIndex = 0;
            this.userControlFenetreType1.Load += new System.EventHandler(this.userControlFenetreType1_Load);
            // 
            // textBoxLibelleOuvrir
            // 
            this.textBoxLibelleOuvrir.Location = new System.Drawing.Point(86, 100);
            this.textBoxLibelleOuvrir.Name = "textBoxLibelleOuvrir";
            this.textBoxLibelleOuvrir.Size = new System.Drawing.Size(194, 20);
            this.textBoxLibelleOuvrir.TabIndex = 1;
            // 
            // pictureBoxIcone
            // 
            this.pictureBoxIcone.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcone.Image")));
            this.pictureBoxIcone.Location = new System.Drawing.Point(12, 8);
            this.pictureBoxIcone.Name = "pictureBoxIcone";
            this.pictureBoxIcone.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxIcone.TabIndex = 2;
            this.pictureBoxIcone.TabStop = false;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelTitre.Location = new System.Drawing.Point(56, 18);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(221, 16);
            this.labelTitre.TabIndex = 3;
            this.labelTitre.Text = "Ouverture d\'un dossier existant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Code :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Libelle :";
            // 
            // comboBoxCodeOuvrir
            // 
            this.comboBoxCodeOuvrir.FormattingEnabled = true;
            this.comboBoxCodeOuvrir.Location = new System.Drawing.Point(88, 66);
            this.comboBoxCodeOuvrir.Name = "comboBoxCodeOuvrir";
            this.comboBoxCodeOuvrir.Size = new System.Drawing.Size(134, 21);
            this.comboBoxCodeOuvrir.TabIndex = 6;
            // 
            // buttonAide
            // 
            this.buttonAide.Location = new System.Drawing.Point(12, 138);
            this.buttonAide.Name = "buttonAide";
            this.buttonAide.Size = new System.Drawing.Size(75, 23);
            this.buttonAide.TabIndex = 7;
            this.buttonAide.Text = "&Aide";
            this.buttonAide.UseVisualStyleBackColor = true;
            this.buttonAide.Click += new System.EventHandler(this.buttonAide_Click);
            // 
            // buttonOuvrir
            // 
            this.buttonOuvrir.Location = new System.Drawing.Point(186, 138);
            this.buttonOuvrir.Name = "buttonOuvrir";
            this.buttonOuvrir.Size = new System.Drawing.Size(75, 23);
            this.buttonOuvrir.TabIndex = 8;
            this.buttonOuvrir.Text = "&Ouvrir";
            this.buttonOuvrir.UseVisualStyleBackColor = true;
            this.buttonOuvrir.Click += new System.EventHandler(this.buttonOuvrir_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(267, 138);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 9;
            this.buttonAnnuler.Text = "A&nnuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // errorProviderOuvrir
            // 
            this.errorProviderOuvrir.ContainerControl = this;
            // 
            // FormOuvrir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 169);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonOuvrir);
            this.Controls.Add(this.buttonAide);
            this.Controls.Add(this.comboBoxCodeOuvrir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.pictureBoxIcone);
            this.Controls.Add(this.textBoxLibelleOuvrir);
            this.Controls.Add(this.userControlFenetreType1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOuvrir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ouvrir";
            this.Load += new System.EventHandler(this.FormOuvrir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOuvrir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlFenetreType userControlFenetreType1;
        private System.Windows.Forms.TextBox textBoxLibelleOuvrir;
        private System.Windows.Forms.PictureBox pictureBoxIcone;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCodeOuvrir;
        private System.Windows.Forms.Button buttonAide;
        private System.Windows.Forms.Button buttonOuvrir;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.ErrorProvider errorProviderOuvrir;
        private System.Windows.Forms.HelpProvider helpProviderOuvrir;
        private System.Windows.Forms.ToolTip toolTipOuvrir;
    }
}