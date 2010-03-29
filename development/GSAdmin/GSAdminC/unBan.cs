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
    public partial class unBan : Form
    {

        RCON rcon = new RCON();
        Functions func = new Functions();
        string IP;
        int PORT;
        string PASSWORD;

        public unBan()
        {
            InitializeComponent();
        }

        private void unBan_Load(object sender, EventArgs e)
        {

        }

        public void serverinfo(string servername, string ip, int port, string password)
        {
            IP = ip;
            PORT = port;
            PASSWORD = password;
            label1.Text = servername;
            rcon.initServer(ip, port, password);
            textBox1.Text = rcon.sendCommand("sv listip");

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(rcon.sendCommand("sv removeip " + textBox2.Text));
            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText(rcon.sendCommand("sv writeip"));
            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText(rcon.sendCommand("sv listip"));
            textBox1.AppendText(Environment.NewLine);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
