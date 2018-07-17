using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menues
{
    public partial class frmMenues : Form
    {
        public frmMenues()
        {
            InitializeComponent();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
    }
}
