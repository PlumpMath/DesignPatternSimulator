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
            this.infoGame = new System.Windows.Forms.Panel();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblNBcoupsValue = new System.Windows.Forms.Label();
            this.lblNBcoups = new System.Windows.Forms.Label();
            this.Labyr = new System.Windows.Forms.Panel();
            this.infoGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoGame
            // 
            this.infoGame.Controls.Add(this.btnPause);
            this.infoGame.Controls.Add(this.lblNBcoupsValue);
            this.infoGame.Controls.Add(this.lblNBcoups);
            this.infoGame.Location = new System.Drawing.Point(12, 12);
            this.infoGame.Name = "infoGame";
            this.infoGame.Size = new System.Drawing.Size(862, 53);
            this.infoGame.TabIndex = 0;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(555, 17);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(129, 23);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Pause / Start";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPause_MouseClick);
            // 
            // lblNBcoupsValue
            // 
            this.lblNBcoupsValue.AutoSize = true;
            this.lblNBcoupsValue.Location = new System.Drawing.Point(313, 22);
            this.lblNBcoupsValue.Name = "lblNBcoupsValue";
            this.lblNBcoupsValue.Size = new System.Drawing.Size(35, 13);
            this.lblNBcoupsValue.TabIndex = 1;
            this.lblNBcoupsValue.Text = "label1";
            // 
            // lblNBcoups
            // 
            this.lblNBcoups.AutoSize = true;
            this.lblNBcoups.Location = new System.Drawing.Point(171, 22);
            this.lblNBcoups.Name = "lblNBcoups";
            this.lblNBcoups.Size = new System.Drawing.Size(135, 13);
            this.lblNBcoups.TabIndex = 0;
            this.lblNBcoups.Text = "Nombre de coups restant : ";
            // 
            // Labyr
            // 
            this.Labyr.Location = new System.Drawing.Point(12, 71);
            this.Labyr.Name = "Labyr";
            this.Labyr.Size = new System.Drawing.Size(862, 401);
            this.Labyr.TabIndex = 1;
            // 
            // Labyrinthe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 484);
            this.Controls.Add(this.Labyr);
            this.Controls.Add(this.infoGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Labyrinthe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Labyrinthe";
            this.infoGame.ResumeLayout(false);
            this.infoGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel infoGame;
        private System.Windows.Forms.Panel Labyr;
        private System.Windows.Forms.Label lblNBcoups;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblNBcoupsValue;

        //private Labyrinthe.Painter painter1;
    }
}