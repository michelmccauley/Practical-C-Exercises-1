using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtons
{
    public partial class frmButtons : Form
    {
        public frmButtons()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void grpMood_Enter(object sender, EventArgs e)
        {
           
            
        }

        private void rdoHappy_CheckedChanged(object sender, EventArgs e)
        {
            picHappy.Visible = true;
            picSad.Visible = false;
        }

        private void rdoSad_CheckedChanged(object sender, EventArgs e)
        {
            picHappy.Visible = false;
            picSad.Visible = true;
        }
    }
}
