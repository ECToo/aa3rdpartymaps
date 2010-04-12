using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AATime
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        Properties.Settings mysettings = new Properties.Settings();
        private void settings_Load(object sender, EventArgs e)
        {
            if (mysettings.shownotify == true)
            {
                checkBox2.Checked = true;
            }
            else
            {
                checkBox2.Checked = false;
            }

            if (mysettings.minstart == true)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                mysettings.minstart = true;
            }
            else
            {
                mysettings.minstart = false;
            }

            if (checkBox2.Checked)
            {
                mysettings.shownotify = true;
            }
            else
            {
                mysettings.shownotify = false;
            }
            mysettings.Save();
            mysettings.Reload();
            DialogResult = DialogResult.OK;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
