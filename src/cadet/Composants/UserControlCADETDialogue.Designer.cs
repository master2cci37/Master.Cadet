namespace CADET
{
    partial class UserControlFenetreType
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBasDialogue = new System.Windows.Forms.Panel();
            this.panelCentreDialogue = new System.Windows.Forms.Panel();
            this.panelHautDialogue = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelBasDialogue
            // 
            this.panelBasDialogue.BackColor = System.Drawing.Color.White;
            this.panelBasDialogue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBasDialogue.Location = new System.Drawing.Point(0, 302);
            this.panelBasDialogue.Name = "panelBasDialogue";
            this.panelBasDialogue.Size = new System.Drawing.Size(507, 35);
            this.panelBasDialogue.TabIndex = 0;
            // 
            // panelCentreDialogue
            // 
            this.panelCentreDialogue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentreDialogue.Location = new System.Drawing.Point(0, 50);
            this.panelCentreDialogue.Name = "panelCentreDialogue";
            this.panelCentreDialogue.Size = new System.Drawing.Size(507, 252);
            this.panelCentreDialogue.TabIndex = 3;
            // 
            // panelHautDialogue
            // 
            this.panelHautDialogue.BackgroundImage = global::CADET.Properties.Resources.degrade_bleu_ciel;
            this.panelHautDialogue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHautDialogue.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHautDialogue.Location = new System.Drawing.Point(0, 0);
            this.panelHautDialogue.Name = "panelHautDialogue";
            this.panelHautDialogue.Size = new System.Drawing.Size(507, 50);
            this.panelHautDialogue.TabIndex = 4;
            // 
            // UserControlFenetreType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCentreDialogue);
            this.Controls.Add(this.panelHautDialogue);
            this.Controls.Add(this.panelBasDialogue);
            this.Name = "UserControlFenetreType";
            this.Size = new System.Drawing.Size(507, 337);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelCentreDialogue;
        public System.Windows.Forms.Panel panelBasDialogue;
        private System.Windows.Forms.Panel panelHautDialogue;
    }
}
