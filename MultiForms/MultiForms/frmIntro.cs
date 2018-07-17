using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForms
{
    public partial class frmIntro : Form
    {
        public frmIntro()
        {
            InitializeComponent();
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            frmGame x = new frmGame();
            x.Show();
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
