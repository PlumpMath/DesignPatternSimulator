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
            this.PionBlanc = new System.Windows.Forms.Label();
            this.PionNoir = new System.Windows.Forms.Label();
            this.buttonB = new System.Windows.Forms.Button();
            this.textBoxXB = new System.Windows.Forms.TextBox();
            this.textBoxYB = new System.Windows.Forms.TextBox();
            this.textBoxXN = new System.Windows.Forms.TextBox();
            this.textBoxYN = new System.Windows.Forms.TextBox();
            this.buttonN = new System.Windows.Forms.Button();
            this.panelBlanc = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.painter1 = new DesignPatternSimulator.Views.Damier.Painter();
            this.panelBlanc.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PionBlanc
            // 
            this.PionBlanc.AutoSize = true;
            this.PionBlanc.Location = new System.Drawing.Point(55, 11);
            this.PionBlanc.Name = "PionBlanc";
            this.PionBlanc.Size = new System.Drawing.Size(55, 13);
            this.PionBlanc.TabIndex = 5;
            this.PionBlanc.Text = "PionBlanc";
            // 
            // PionNoir
            // 
            this.PionNoir.AutoSize = true;
            this.PionNoir.Location = new System.Drawing.Point(50, 11);
            this.PionNoir.Name = "PionNoir";
            this.PionNoir.Size = new System.Drawing.Size(47, 13);
            this.PionNoir.TabIndex = 6;
            this.PionNoir.Text = "PionNoir";
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(35, 81);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(75, 23);
            this.buttonB.TabIndex = 7;
            this.buttonB.Text = "Pion Blanc";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // textBoxXB
            // 
            this.textBoxXB.Location = new System.Drawing.Point(26, 38);
            this.textBoxXB.Name = "textBoxXB";
            this.textBoxXB.Size = new System.Drawing.Size(35, 20);
            this.textBoxXB.TabIndex = 8;
            // 
            // textBoxYB
            // 
            this.textBoxYB.Location = new System.Drawing.Point(87, 38);
            this.textBoxYB.Name = "textBoxYB";
            this.textBoxYB.Size = new System.Drawing.Size(35, 20);
            this.textBoxYB.TabIndex = 9;
            // 
            // textBoxXN
            // 
            this.textBoxXN.Location = new System.Drawing.Point(29, 49);
            this.textBoxXN.Name = "textBoxXN";
            this.textBoxXN.Size = new System.Drawing.Size(35, 20);
            this.textBoxXN.TabIndex = 10;
            // 
            // textBoxYN
            // 
            this.textBoxYN.Location = new System.Drawing.Point(102, 49);
            this.textBoxYN.Name = "textBoxYN";
            this.textBoxYN.Size = new System.Drawing.Size(35, 20);
            this.textBoxYN.TabIndex = 11;
            // 
            // buttonN
            // 
            this.buttonN.Location = new System.Drawing.Point(41, 82);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(75, 21);
            this.buttonN.TabIndex = 12;
            this.buttonN.Text = "Pion Noir";
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // panelBlanc
            // 
            this.panelBlanc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panelBlanc.Controls.Add(this.PionBlanc);
            this.panelBlanc.Controls.Add(this.buttonB);
            this.panelBlanc.Controls.Add(this.textBoxXB);
            this.panelBlanc.Controls.Add(this.textBoxYB);
            this.panelBlanc.Enabled = false;
            this.panelBlanc.Location = new System.Drawing.Point(625, 252);
            this.panelBlanc.Name = "panelBlanc";
            this.panelBlanc.Size = new System.Drawing.Size(161, 118);
            this.panelBlanc.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonN);
            this.panel1.Controls.Add(this.PionNoir);
            this.panel1.Controls.Add(this.textBoxXN);
            this.panel1.Controls.Add(this.textBoxYN);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(625, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 118);
            this.panel1.TabIndex = 14;
            // 
            // painter1
            // 
            this.painter1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painter1.Location = new System.Drawing.Point(12, 36);
            this.painter1.Name = "painter1";
            this.painter1.Size = new System.Drawing.Size(550, 449);
            this.painter1.TabIndex = 4;
            // 
            // Damier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBlanc);
            this.Controls.Add(this.painter1);
            this.Name = "Damier";
            this.Text = "               ";
            this.Load += new System.EventHandler(this.Damier_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Damier_Paint);
            this.panelBlanc.ResumeLayout(false);
            this.panelBlanc.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Painter painter1;
        private System.Windows.Forms.Label PionBlanc;
        private System.Windows.Forms.Label PionNoir;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.TextBox textBoxXB;
        private System.Windows.Forms.TextBox textBoxYB;
        private System.Windows.Forms.TextBox textBoxXN;
        private System.Windows.Forms.TextBox textBoxYN;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Panel panelBlanc;
        private System.Windows.Forms.Panel panel1;

    }
}