using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternSimulator.Views.Labyrinthe
{
    public partial class NewGameLab : Form
    {
        SelectorSimulation papa;

        public NewGameLab()
        {
            InitializeComponent();
            rbEasy.Select();
        }

        public NewGameLab(SelectorSimulation parent)
        {
            InitializeComponent();
            papa = parent;
            rbEasy.Select();
        }

        private void NewGameLab_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int level = 0;
            if (rbEasy.Checked)
            {
                level = 1;
            }
            else if (rbMedium.Checked)
            {
                level = 2;
            }
            else
            {
                level = 3;
            }
            Labyrinthe fm = new Labyrinthe((int)numericUpDown1.Value, level);
            fm.MdiParent = papa;
            //fm.Dock = DockStyle.Fill;
            fm.StartPosition = FormStartPosition.CenterScreen;
            fm.Show();
        }
    }
}
