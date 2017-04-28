using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcAdd_Click(object sender, EventArgs e)
        {
            lblAnsAdd.Text = String.Format("{0}",1+2);
        }

        private void btnCalcSub_Click(object sender, EventArgs e)
        {
            lblAnsSub.Text = String.Format("{0}", 5-3);
        }

        private void btnCalcMul_Click(object sender, EventArgs e)
        {
            lblAnsMul.Text = String.Format("{0}", 2*3);
        }

        private void btnCalcDiv_Click(object sender, EventArgs e)
        {
            lblAnsDiv.Text = String.Format("{0}", 8/2);
        }
    }
}
