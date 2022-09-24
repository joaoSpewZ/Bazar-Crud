using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPessoa
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        private void FormSplash_Load_1(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            timer4.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lblBV.ForeColor = lblBV.ForeColor == Color.Transparent ? Color.Red : Color.Transparent;
        }
     
        private void timer4_Tick_1(object sender, EventArgs e)
        {
            lblBar1.ForeColor = lblBar1.ForeColor == Color.Transparent ? Color.Yellow : Color.Transparent;
        }
    }
}
