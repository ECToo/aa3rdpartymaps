using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using Microsoft.Win32;

namespace AATime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        
        private Point LastCursorPosition;
        private bool IsMouseDown;
        public bool cxtexit = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblLocal.Text = Convert.ToString(DateTime.Now);
            double seconds = TimeSpan.Parse(Convert.ToString(DateTime.UtcNow.TimeOfDay)).TotalSeconds * 0.01157;

            lblBeats.Text = "A:" + Convert.ToDecimal(seconds.ToString("F2"));
            notifyIcon1.Text = "Current AAT: " + Convert.ToString(Convert.ToDecimal(seconds.ToString("F2")));

            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Text = "AAT: " + Convert.ToDecimal(seconds.ToString("F2"));
            }
            else
            {
                this.Text = "AAT (Alien Arena Time)";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.minstart)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            timer2.Enabled = false;
        }

        private void lblBeats_Click(object sender, EventArgs e)
        {

        }

        private void lblBeats_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            
            try
            {
                double seconds = TimeSpan.Parse(Convert.ToString(DateTime.UtcNow.TimeOfDay)).TotalSeconds * 0.01157;
                dateTimePicker1.Value = DateTime.Now;
                lblBeats.Text = "A:" + Convert.ToDecimal(seconds.ToString("F2"));
            }
            catch
            {
            }
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Reload();
            if (Properties.Settings.Default.shownotify)
            {
                if (!cxtexit)
                {
                    e.Cancel = true;
                    notifyIcon1.Visible = true;
                    this.Hide();
                }
                else
                {
                    e.Cancel = false;
                }
            }
            else
            {
                e.Cancel = false;
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                double answer;
                answer = TimeSpan.Parse(Convert.ToString(dateTimePicker1.Value.ToUniversalTime().TimeOfDay)).TotalSeconds * 0.01157;
                textBox1.Text = Convert.ToString(Convert.ToDecimal(answer.ToString("F1")));
            }
            catch
            {
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text != "")
                {
                    string answer;
                    answer = Convert.ToString(TimeSpan.FromSeconds(Convert.ToDouble(textBox2.Text) * 86.4));
                    DateTime convertedDate = DateTime.SpecifyKind(DateTime.Parse(answer), DateTimeKind.Utc);
                    textBox3.Text = Convert.ToString(convertedDate.ToLocalTime().TimeOfDay);
                }
                else
                {
                    textBox3.Text = "";
                }
            }
            catch
            {
                textBox3.Text = "Invalid";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            this.IsMouseDown = true;
            this.LastCursorPosition = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (this.IsMouseDown == true)
            {
                this.Location = new Point(this.Left - (this.LastCursorPosition.X - e.X), this.Top - (this.LastCursorPosition.Y - e.Y));
                this.Invalidate();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            this.IsMouseDown = false;
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            settings settings = new settings();
            settings.ShowDialog();
            
            
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxtexit = true;
            this.Close();
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            Help.ShowHelp(this, "http://aa3rdpartymaps.googlecode.com");
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            
        }

        
    }
}