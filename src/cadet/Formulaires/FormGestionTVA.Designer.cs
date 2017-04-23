namespace CADET
{
    partial class FormGestionTVA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionTVA));
            this.userControlFenetreType1 = new CADET.UserControlFenetreType();
            this.buttonAide = new System.Windows.Forms.Button();
            this.buttonModifer = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.comboBoxCodeTVA = new System.Windows.Forms.ComboBox();
            this.errorProviderTVA = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProviderTVA = new System.Windows.Forms.HelpProvider();
            this.pictureBoxIcone = new System.Windows.Forms.PictureBox();
            this.labelTitre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLibelleTVA = new System.Windows.Forms.TextBox();
            this.toolTipTVA = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).BeginInit();
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
            this.buttonAide.Location = new System.Drawing.Point(12, 139);
            this.buttonAide.Name = "buttonAide";
            this.buttonAide.Size = new System.Drawing.Size(75, 23);
            this.buttonAide.TabIndex = 1;
            this.buttonAide.Text = "&Aide";
            this.buttonAide.UseVisualStyleBackColor = true;
            this.buttonAide.Click += new System.EventHandler(this.buttonAide_Click);
            // 
            // buttonModifer
            // 
            this.buttonModifer.Location = new System.Drawing.Point(186, 139);
            this.buttonModifer.Name = "buttonModifer";
            this.buttonModifer.Size = new System.Drawing.Size(75, 23);
            this.buttonModifer.TabIndex = 2;
            this.buttonModifer.Text = "&Modifier";
            this.buttonModifer.UseVisualStyleBackColor = true;
            this.buttonModifer.Click += new System.EventHandler(this.buttonModifer_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(267, 139);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 3;
            this.buttonAnnuler.Text = "A&nnuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // comboBoxCodeTVA
            // 
            this.comboBoxCodeTVA.FormattingEnabled = true;
            this.comboBoxCodeTVA.Location = new System.Drawing.Point(80, 69);
            this.comboBoxCodeTVA.Name = "comboBoxCodeTVA";
            this.comboBoxCodeTVA.Size = new System.Drawing.Size(145, 21);
            this.comboBoxCodeTVA.TabIndex = 4;
            // 
            // errorProviderTVA
            // 
            //this.errorProviderTVA.ContainerControl = this;
            //this.errorProviderTVA.RightToLeftChanged += new System.EventHandler(this.errorProviderTVA_RightToLeftChanged);
            // 
            // pictureBoxIcone
            // 
            this.pictureBoxIcone.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcone.Image")));
            this.pictureBoxIcone.Location = new System.Drawing.Point(6, 9);
            this.pictureBoxIcone.Name = "pictureBoxIcone";
            this.pictureBoxIcone.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxIcone.TabIndex = 5;
            this.pictureBoxIcone.TabStop = false;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelTitre.Location = new System.Drawing.Point(45, 15);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(134, 16);
            this.labelTitre.TabIndex = 6;
            this.labelTitre.Text = "Gestion de la TVA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Code :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Libelle :";
            // 
            // textBoxLibelleTVA
            // 
            this.textBoxLibelleTVA.Location = new System.Drawing.Point(80, 98);
            this.textBoxLibelleTVA.Name = "textBoxLibelleTVA";
            this.textBoxLibelleTVA.Size = new System.Drawing.Size(218, 20);
            this.textBoxLibelleTVA.TabIndex = 9;
            // 
            // FormGestionTVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 169);
            this.Controls.Add(this.textBoxLibelleTVA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.pictureBoxIcone);
            this.Controls.Add(this.comboBoxCodeTVA);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonModifer);
            this.Controls.Add(this.buttonAide);
            this.Controls.Add(this.userControlFenetreType1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGestionTVA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de la TVA";
            this.Load += new System.EventHandler(this.FormGestionTVA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlFenetreType userControlFenetreType1;
        private System.Windows.Forms.Button buttonAide;
        private System.Windows.Forms.Button buttonModifer;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.ComboBox comboBoxCodeTVA;
        private System.Windows.Forms.ErrorProvider errorProviderTVA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.PictureBox pictureBoxIcone;
        private System.Windows.Forms.HelpProvider helpProviderTVA;
        private System.Windows.Forms.TextBox textBoxLibelleTVA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTipTVA;
    }
}