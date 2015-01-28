namespace DesignPatternSimulator.Views
{
    partial class SelectorSimulation
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvellePartieToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guerreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvellePartieToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simulationsToolStripMenuItem1,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(876, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fermerToolStripMenuItem});
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // simulationsToolStripMenuItem1
            // 
            this.simulationsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dameToolStripMenuItem,
            this.guerreToolStripMenuItem1});
            this.simulationsToolStripMenuItem1.Name = "simulationsToolStripMenuItem1";
            this.simulationsToolStripMenuItem1.Size = new System.Drawing.Size(81, 20);
            this.simulationsToolStripMenuItem1.Text = "Simulations";
            // 
            // dameToolStripMenuItem
            // 
            this.dameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvellePartieToolStripMenuItem3,
            this.chargerToolStripMenuItem});
            this.dameToolStripMenuItem.Name = "dameToolStripMenuItem";
            this.dameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dameToolStripMenuItem.Text = "Dame";
            // 
            // nouvellePartieToolStripMenuItem3
            // 
            this.nouvellePartieToolStripMenuItem3.Name = "nouvellePartieToolStripMenuItem3";
            this.nouvellePartieToolStripMenuItem3.Size = new System.Drawing.Size(154, 22);
            this.nouvellePartieToolStripMenuItem3.Text = "Nouvelle Partie";
            this.nouvellePartieToolStripMenuItem3.Click += new System.EventHandler(this.nouvellePartieToolStripMenuItem3_Click);
            // 
            // chargerToolStripMenuItem
            // 
            this.chargerToolStripMenuItem.Name = "chargerToolStripMenuItem";
            this.chargerToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.chargerToolStripMenuItem.Text = "Charger";
            // 
            // guerreToolStripMenuItem1
            // 
            this.guerreToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvellePartieToolStripMenuItem4,
            this.chargerToolStripMenuItem1});
            this.guerreToolStripMenuItem1.Name = "guerreToolStripMenuItem1";
            this.guerreToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.guerreToolStripMenuItem1.Text = "Guerre";
            // 
            // nouvellePartieToolStripMenuItem4
            // 
            this.nouvellePartieToolStripMenuItem4.Name = "nouvellePartieToolStripMenuItem4";
            this.nouvellePartieToolStripMenuItem4.Size = new System.Drawing.Size(154, 22);
            this.nouvellePartieToolStripMenuItem4.Text = "Nouvelle Partie";
            this.nouvellePartieToolStripMenuItem4.Click += new System.EventHandler(this.nouvellePartieToolStripMenuItem4_Click);
            // 
            // chargerToolStripMenuItem1
            // 
            this.chargerToolStripMenuItem1.Name = "chargerToolStripMenuItem1";
            this.chargerToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.chargerToolStripMenuItem1.Text = "Charger";
            // 
            // SelectorSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 489);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SelectorSimulation";
            this.Text = "SelectorSimulation";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulationsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvellePartieToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem chargerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guerreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nouvellePartieToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem chargerToolStripMenuItem1;
    }
}