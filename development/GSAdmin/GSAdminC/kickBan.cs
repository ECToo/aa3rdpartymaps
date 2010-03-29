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
    public partial class kickBan : Form
    {

        RCON rcon = new RCON();
        Functions func = new Functions();
        string IP;
        int PORT;
        string PASSWORD;

        public kickBan()
        {
            InitializeComponent();
        }

        private void kickBan_Load(object sender, EventArgs e)
        {

        }

        public void serverinfo(string servername, string ip, int port, string password)
        {
            IP = ip;
            PORT = port;
            PASSWORD = password;
            label1.Text = servername;
            rcon.initServer(ip, port, password);
            textBox1.Text = rcon.sendCommand("status");
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtIP.Visible = true;
                label3.Visible = true;
            }else{
                txtIP.Visible = false;
                label3.Visible = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            rcon.initServer(IP, PORT, PASSWORD);

            if (checkBox1.Checked)
            {

                if (func.isValidIP(txtIP.Text))
                {
                    textBox1.AppendText(Environment.NewLine);
                    textBox1.AppendText(rcon.sendCommand("kick " + textBox2.Text));
                    textBox1.AppendText(rcon.sendCommand("sv addip " + txtIP.Text));
                    textBox1.AppendText(rcon.sendCommand("status"));
                }
                else
                {
                    func.exceptionbox("Invalid IP Address. Please try again.");
                }

            }
            else
            {
                textBox1.AppendText(Environment.NewLine);
                textBox1.AppendText(rcon.sendCommand("kick " + textBox2.Text));
                textBox1.AppendText(rcon.sendCommand("status"));
            }
            
        }
    }
}
