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
    public partial class programSettings : Form
    {
        Properties.Settings settings = new Properties.Settings();
        public programSettings()
        {
            InitializeComponent();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (chkStart.Checked)
            {
                settings.startup = true;
            }
            else
            {
                settings.startup = false;
            }

            if (chkAuto.Checked)
            {
                settings.autorefresh = true;
               // settings.interval = numMin.Value * 60;
            }
            else
            {
                settings.autorefresh = false;
                settings.interval = 0;
            }

            if (chkMinimize.Checked)
            {
                settings.minimize = true;
            }
            else
            {
                settings.minimize = false;
            }

            if (chkNotify.Checked)
            {
                settings.notify = true;
            }
            else
            {
                settings.notify = false;
            }

            if (chkBots.Checked)
            {
                settings.showbots = true;
            }
            else
            {
                settings.showbots = false;
            }

            if (chkJoin.Checked)
            {
                settings.enablejoin = true;
            }
            else
            {
                settings.enablejoin = false;
            }

        }
    }
}
