using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GSAdminC
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void splashScreen_Load(object sender, EventArgs e)
        {

        }

        private void splashScreen_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
