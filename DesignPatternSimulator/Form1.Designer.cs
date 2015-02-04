namespace DesignPatternSimulator
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.launcher = new System.Windows.Forms.Button();
            this.consoleBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // launcher
            // 
            this.launcher.AccessibleName = "";
            this.launcher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.launcher.Location = new System.Drawing.Point(433, 13);
            this.launcher.Name = "launcher";
            this.launcher.Size = new System.Drawing.Size(119, 23);
            this.launcher.TabIndex = 0;
            this.launcher.Text = "Launching";
            this.launcher.UseVisualStyleBackColor = true;
            this.launcher.Click += new System.EventHandler(this.launcher_Click);
            // 
            // consoleBox
            // 
            this.consoleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleBox.Location = new System.Drawing.Point(13, 59);
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ShowSelectionMargin = true;
            this.consoleBox.Size = new System.Drawing.Size(959, 391);
            this.consoleBox.TabIndex = 1;
            this.consoleBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.launcher);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button launcher;
        private System.Windows.Forms.RichTextBox consoleBox;
    }
}

