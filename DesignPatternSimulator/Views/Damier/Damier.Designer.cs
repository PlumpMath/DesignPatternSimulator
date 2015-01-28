namespace DesignPatternSimulator.Views.Damier
{
    partial class Damier
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
            this.consoleBox = new System.Windows.Forms.RichTextBox();
            this.launcher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // consoleBox
            // 
            this.consoleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleBox.Location = new System.Drawing.Point(278, 135);
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.Size = new System.Drawing.Size(259, 191);
            this.consoleBox.TabIndex = 3;
            this.consoleBox.Text = "";
            // 
            // launcher
            // 
            this.launcher.AccessibleName = "";
            this.launcher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.launcher.Location = new System.Drawing.Point(348, 89);
            this.launcher.Name = "launcher";
            this.launcher.Size = new System.Drawing.Size(119, 23);
            this.launcher.TabIndex = 2;
            this.launcher.Text = "Launch";
            this.launcher.UseVisualStyleBackColor = true;
            this.launcher.Click += new System.EventHandler(this.launcher_Click);
            // 
            // Damier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 415);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.launcher);
            this.Name = "Damier";
            this.Text = "Damier";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox consoleBox;
        private System.Windows.Forms.Button launcher;

    }
}