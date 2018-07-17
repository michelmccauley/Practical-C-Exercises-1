using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollBars
{
    public partial class frmScrollBars : Form
    {
        public frmScrollBars()
        {
            InitializeComponent();
        }

        private void frmScrollBars_Load(object sender, EventArgs e)
        {

        }

        private void hscBar_Scroll(object sender, ScrollEventArgs e)
        {
            lblScroll.Text = hscBar.Value.ToString();
        }

        private void lblScroll_Click(object sender, EventArgs e)
        {
            
        }
    }
}
