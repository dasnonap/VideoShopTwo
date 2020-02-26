using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoShop
{
    public partial class WarmColorPalleteBG : Form
    {
        public WarmColorPalleteBG()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void WarmColorPalleteBG_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(220, 93, 1);
        }
    }
}
