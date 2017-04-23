namespace CADET
{
    partial class FormEditeFichier
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonAide = new System.Windows.Forms.Button();
            this.pictureBoxIcone = new System.Windows.Forms.PictureBox();
            this.labelTitre = new System.Windows.Forms.Label();
            this.toolTipEditeFichier = new System.Windows.Forms.ToolTip(this.components);
            this.errorProviderEditeFichier = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProviderEditeFichier = new System.Windows.Forms.HelpProvider();
            this.saveFileDialogfichier = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogfichier = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditeFichier)).BeginInit();
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
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(209, 143);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(285, 143);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 2;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAide
            // 
            this.buttonAide.Location = new System.Drawing.Point(3, 143);
            this.buttonAide.Name = "buttonAide";
            this.buttonAide.Size = new System.Drawing.Size(75, 23);
            this.buttonAide.TabIndex = 3;
            this.buttonAide.Text = "&Aide";
            this.buttonAide.UseVisualStyleBackColor = true;
            this.buttonAide.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBoxIcone
            // 
            this.pictureBoxIcone.Location = new System.Drawing.Point(3, 4);
            this.pictureBoxIcone.Name = "pictureBoxIcone";
            this.pictureBoxIcone.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxIcone.TabIndex = 4;
            this.pictureBoxIcone.TabStop = false;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelTitre.Location = new System.Drawing.Point(62, 7);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(264, 32);
            this.labelTitre.TabIndex = 5;
            this.labelTitre.Text = "Lancer l\'édition du fichier choisi avec\r\n             l\'éditeur par défaut";
            // 
            // errorProviderEditeFichier
            // 
            this.errorProviderEditeFichier.ContainerControl = this;
            // 
            // openFileDialogfichier
            // 
            this.openFileDialogfichier.FileName = "openFileDialog1";
            // 
            // FormEditeFichier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 171);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.pictureBoxIcone);
            this.Controls.Add(this.buttonAide);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.userControlFenetreType1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditeFichier";
            this.Text = "Editefichier";
            this.Load += new System.EventHandler(this.FormEditeFichier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEditeFichier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlFenetreType userControlFenetreType1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonAide;
        private System.Windows.Forms.PictureBox pictureBoxIcone;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.ToolTip toolTipEditeFichier;
        private System.Windows.Forms.ErrorProvider errorProviderEditeFichier;
        private System.Windows.Forms.HelpProvider helpProviderEditeFichier;
        private System.Windows.Forms.SaveFileDialog saveFileDialogfichier;
        private System.Windows.Forms.OpenFileDialog openFileDialogfichier;
    }
}