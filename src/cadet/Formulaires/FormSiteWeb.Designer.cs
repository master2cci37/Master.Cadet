namespace CADET
{
    partial class FormSiteWeb
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitre = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonAnnler = new System.Windows.Forms.Button();
            this.buttonAide = new System.Windows.Forms.Button();
            this.errorProviderSiteWeb = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProviderSiteWeb = new System.Windows.Forms.HelpProvider();
            this.toolTipSiteWeb = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSiteWeb)).BeginInit();
            this.SuspendLayout();
            // 
            // userControlFenetreType1
            // 
            this.userControlFenetreType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlFenetreType1.Location = new System.Drawing.Point(0, 0);
            this.userControlFenetreType1.Name = "userControlFenetreType1";
            this.userControlFenetreType1.Size = new System.Drawing.Size(362, 167);
            this.userControlFenetreType1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelTitre.Location = new System.Drawing.Point(59, 0);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(262, 32);
            this.labelTitre.TabIndex = 2;
            this.labelTitre.Text = "Site internet du programme pour plus\r\n        d\'informations et actualités";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(189, 132);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "&OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonAnnler
            // 
            this.buttonAnnler.Location = new System.Drawing.Point(275, 132);
            this.buttonAnnler.Name = "buttonAnnler";
            this.buttonAnnler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnler.TabIndex = 4;
            this.buttonAnnler.Text = "Annuler";
            this.buttonAnnler.UseVisualStyleBackColor = true;
            this.buttonAnnler.Click += new System.EventHandler(this.buttonAnnler_Click);
            // 
            // buttonAide
            // 
            this.buttonAide.Location = new System.Drawing.Point(0, 132);
            this.buttonAide.Name = "buttonAide";
            this.buttonAide.Size = new System.Drawing.Size(75, 23);
            this.buttonAide.TabIndex = 5;
            this.buttonAide.Text = "&Aide";
            this.buttonAide.UseVisualStyleBackColor = true;
            this.buttonAide.Click += new System.EventHandler(this.buttonAide_Click);
            // 
            // errorProviderSiteWeb
            // 
            this.errorProviderSiteWeb.ContainerControl = this;
            // 
            // FormGrandesClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 167);
            this.Controls.Add(this.buttonAide);
            this.Controls.Add(this.buttonAnnler);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userControlFenetreType1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGrandesClasses";
            this.Text = "FormSiteWeb";
            this.Load += new System.EventHandler(this.FormSiteWeb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSiteWeb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlFenetreType userControlFenetreType1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonAnnler;
        private System.Windows.Forms.Button buttonAide;
        private System.Windows.Forms.ErrorProvider errorProviderSiteWeb;
        private System.Windows.Forms.HelpProvider helpProviderSiteWeb;
        private System.Windows.Forms.ToolTip toolTipSiteWeb;
    }
}