namespace CADET
{
    partial class FormDevises
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
            this.buttonAide = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.pictureBoxIcone = new System.Windows.Forms.PictureBox();
            this.labelTitre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCodeDevises = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxLibelleDevises = new System.Windows.Forms.TextBox();
            this.errorProviderDevises = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProviderDevises = new System.Windows.Forms.HelpProvider();
            this.toolTipDevises = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDevises)).BeginInit();
            this.SuspendLayout();
            // 
            // userControlFenetreType1
            // 
            this.userControlFenetreType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlFenetreType1.Location = new System.Drawing.Point(0, 0);
            this.userControlFenetreType1.Name = "userControlFenetreType1";
            this.userControlFenetreType1.Size = new System.Drawing.Size(387, 169);
            this.userControlFenetreType1.TabIndex = 0;
            // 
            // buttonAide
            // 
            this.buttonAide.Location = new System.Drawing.Point(12, 141);
            this.buttonAide.Name = "buttonAide";
            this.buttonAide.Size = new System.Drawing.Size(75, 23);
            this.buttonAide.TabIndex = 1;
            this.buttonAide.Text = "&Aide";
            this.buttonAide.UseVisualStyleBackColor = true;
            this.buttonAide.Click += new System.EventHandler(this.buttonAide_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(201, 141);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(93, 23);
            this.buttonAjouter.TabIndex = 2;
            this.buttonAjouter.Text = "A&jouter/Modifier";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(300, 141);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 3;
            this.buttonAnnuler.Text = "A&nnuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // pictureBoxIcone
            // 
            this.pictureBoxIcone.Location = new System.Drawing.Point(8, 9);
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
            this.labelTitre.Location = new System.Drawing.Point(45, 15);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(333, 16);
            this.labelTitre.TabIndex = 5;
            this.labelTitre.Text = "Paramètrer les taux de conversion des devises";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Code :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Libelle :";
            // 
            // comboBoxCodeDevises
            // 
            this.comboBoxCodeDevises.FormattingEnabled = true;
            this.comboBoxCodeDevises.Location = new System.Drawing.Point(80, 69);
            this.comboBoxCodeDevises.Name = "comboBoxCodeDevises";
            this.comboBoxCodeDevises.Size = new System.Drawing.Size(129, 21);
            this.comboBoxCodeDevises.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(231, 71);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Supprimer";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxLibelleDevises
            // 
            this.textBoxLibelleDevises.Location = new System.Drawing.Point(80, 96);
            this.textBoxLibelleDevises.Name = "textBoxLibelleDevises";
            this.textBoxLibelleDevises.Size = new System.Drawing.Size(224, 20);
            this.textBoxLibelleDevises.TabIndex = 10;
            // 
            // errorProviderDevises
            // 
            this.errorProviderDevises.ContainerControl = this;
            // 
            // FormDevises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 169);
            this.Controls.Add(this.textBoxLibelleDevises);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBoxCodeDevises);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.pictureBoxIcone);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonAide);
            this.Controls.Add(this.userControlFenetreType1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDevises";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devises";
            this.Load += new System.EventHandler(this.FormDevises_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDevises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlFenetreType userControlFenetreType1;
        private System.Windows.Forms.Button buttonAide;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.PictureBox pictureBoxIcone;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCodeDevises;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxLibelleDevises;
        private System.Windows.Forms.ErrorProvider errorProviderDevises;
        private System.Windows.Forms.HelpProvider helpProviderDevises;
        private System.Windows.Forms.ToolTip toolTipDevises;
    }
}