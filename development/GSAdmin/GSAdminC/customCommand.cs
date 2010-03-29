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
    public partial class customCommand : Form
    {

        RCON rcon = new RCON();
        Functions func = new Functions();
        string IP;
        int PORT;
        string PASSWORD;

        public customCommand()
        {
            InitializeComponent();
        }

        private void customCommand_Load(object sender, EventArgs e)
        {
            rcon.initServer(IP, PORT, PASSWORD);
        }

        public void serverinfo(string servername, string ip, int port, string password)
        {
            IP = ip;
            PORT = port;
            PASSWORD = password;
            label1.Text = servername;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(rcon.sendCommand(textBox2.Text));
            textBox1.AppendText(Environment.NewLine);
        }
    }
}
