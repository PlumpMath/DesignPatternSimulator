namespace DesignPatternSimulator.Views.Labyrinthe
{
    partial class Labyrinthe
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
            this.painter1 = new DesignPatternSimulator.Views.Damier.Painter();
            this.SuspendLayout();
            // 
            // painter1
            // 
            this.painter1.Location = new System.Drawing.Point(12, 12);
            this.painter1.Name = "painter1";
            this.painter1.Size = new System.Drawing.Size(838, 380);
            this.painter1.TabIndex = 0;
            // 
            // Labyrinthe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 404);
            this.Controls.Add(this.painter1);
            this.Name = "Labyrinthe";
            this.Text = "Labyrinthe";
            this.ResumeLayout(false);

        }

        #endregion

        private Damier.Painter painter1;
    }
}