namespace CADET
{
    partial class FormCompteResultat
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
            this.userControlFenetreType1 = new CADET.UserControlFenetreType();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOKcompterésultat = new System.Windows.Forms.Button();
            this.buttonAnnulercompterésultat = new System.Windows.Forms.Button();
            this.buttonAidecompterésultat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userControlFenetreType1
            // 
            this.userControlFenetreType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlFenetreType1.Location = new System.Drawing.Point(0, 0);
            this.userControlFenetreType1.Name = "userControlFenetreType1";
            this.userControlFenetreType1.Size = new System.Drawing.Size(501, 305);
            this.userControlFenetreType1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Compte de résultat détaillé";
            // 
            // buttonOKcompterésultat
            // 
            this.buttonOKcompterésultat.Location = new System.Drawing.Point(5, 275);
            this.buttonOKcompterésultat.Name = "buttonOKcompterésultat";
            this.buttonOKcompterésultat.Size = new System.Drawing.Size(75, 23);
            this.buttonOKcompterésultat.TabIndex = 3;
            this.buttonOKcompterésultat.Text = "&OK";
            this.buttonOKcompterésultat.UseVisualStyleBackColor = true;
            // 
            // buttonAnnulercompterésultat
            // 
            this.buttonAnnulercompterésultat.Location = new System.Drawing.Point(344, 277);
            this.buttonAnnulercompterésultat.Name = "buttonAnnulercompterésultat";
            this.buttonAnnulercompterésultat.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnulercompterésultat.TabIndex = 4;
            this.buttonAnnulercompterésultat.Text = "Annuler";
            this.buttonAnnulercompterésultat.UseVisualStyleBackColor = true;
            // 
            // buttonAidecompterésultat
            // 
            this.buttonAidecompterésultat.Location = new System.Drawing.Point(423, 276);
            this.buttonAidecompterésultat.Name = "buttonAidecompterésultat";
            this.buttonAidecompterésultat.Size = new System.Drawing.Size(75, 23);
            this.buttonAidecompterésultat.TabIndex = 5;
            this.buttonAidecompterésultat.Text = "&Aide";
            this.buttonAidecompterésultat.UseVisualStyleBackColor = true;
            // 
            // FormCompteResultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 305);
            this.Controls.Add(this.buttonAidecompterésultat);
            this.Controls.Add(this.buttonAnnulercompterésultat);
            this.Controls.Add(this.buttonOKcompterésultat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userControlFenetreType1);
            this.Name = "FormCompteResultat";
            this.Text = "FormCompresultat";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlFenetreType userControlFenetreType1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOKcompterésultat;
        private System.Windows.Forms.Button buttonAnnulercompterésultat;
        private System.Windows.Forms.Button buttonAidecompterésultat;
    }
}