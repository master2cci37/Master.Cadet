namespace CADET
{
    partial class FormDevise
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
            this.SuspendLayout();
            // 
            // userControlFenetreType1
            // 
            this.userControlFenetreType1.BackColor = System.Drawing.Color.Transparent;
            this.userControlFenetreType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlFenetreType1.Location = new System.Drawing.Point(0, 0);
            this.userControlFenetreType1.Name = "userControlFenetreType1";
            this.userControlFenetreType1.Size = new System.Drawing.Size(624, 463);
            this.userControlFenetreType1.TabIndex = 0;
            // 
            // FormDevise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 463);
            this.Controls.Add(this.userControlFenetreType1);
            this.Name = "FormDevise";
            this.Text = "Devise";
            this.ResumeLayout(false);

        }

        #endregion

        private CADET.UserControlFenetreType userControlFenetreType1;
    }
}