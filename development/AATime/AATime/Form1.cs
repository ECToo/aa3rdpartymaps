using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;

namespace AATime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int beats;
        

        private void timer1_Tick(object sender, EventArgs e)
        {
           
           int seconds = Convert.ToInt16(TimeSpan.Parse(Convert.ToString(DateTime.UtcNow.AddHours(1).TimeOfDay)).TotalSeconds * 0.01157);

           beats = Convert.ToInt32(seconds);
           lblBeats.Text = Convert.ToString(seconds);
           
        }
    }
}
