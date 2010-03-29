using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using GSAdminC.Properties;


namespace GSAdminC
{
    public partial class AddServer : Form
    {
        
        Functions func = new Functions();
        RCON rcon = new RCON();
        
            
        public AddServer()
        {
            InitializeComponent();
        }

        private void AddServer_Load(object sender, EventArgs e)
        {
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {

            int records = 0; // Holds number of server records.
            string record; // Record holder.
            int i = 1; //Counter
            try
            {
                if(!func.validateText(txtIP.Text))
                {
                throw new Exception("You must enter an IP address");
                }
                
                if (!func.isValidIP(txtIP.Text))
                {
                    throw new Exception("Please enter a valid IP Address");
                }
                
                if(!func.validatePort(txtPort.Text))
                {
                    throw new Exception("Port number invalid. This must be numeric only, and between 1 and 65535");
                }

                records = Properties.Settings.Default.servers.Count;

                if (records > 0)
                {
                    while(i < records){
                        record = Properties.Settings.Default.servers[i];
                        string[] field = record.Split('^');
                        if (field[0] == txtIP.Text && field[1] == txtPort.Text)
                        {
                            throw new Exception("Server already exists in database. Please try again");
                        }
                        i++;
                    }

                }
                
                GameServerInfo.GameServer server = new GameServerInfo.GameServer(txtIP.Text, Convert.ToInt32(txtPort.Text), GameServerInfo.GameType.Quake3, 500);
                server.QueryServer();
                if (!server.IsOnline)
                {
                    throw new Exception("Could not contact this server. Please check the IP address and Port, then try again");
                }
                else
                {
                    txtServerName.Text = server.Name;
                    txtIP.Enabled = false;
                    txtPort.Enabled = false;
                    txtPass1.Enabled = true;
                    txtPass2.Enabled = true;
                    btnQuery.Enabled = false;
                    btnTest.Enabled = true;
                }           
            }
            catch(Exception ex)
            {
                func.exceptionbox(ex.Message);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (!func.validateText(txtPass1.Text) && !func.validateText(txtPass2.Text))
                {
                    throw new Exception("You must enter a password.");
                }

                if (txtPass1.Text != txtPass2.Text)
                {
                    throw new Exception("Passwords do not match.");
                }

                rcon.initServer(txtIP.Text, Convert.ToInt32(txtPort.Text), txtPass1.Text);
                if(rcon.sendCommand("").Contains("rcon_password")){
                    throw new Exception("RCON Password was incorrect.");
                }else{
                    MessageBox.Show("Authenticated Successfully!");
                    txtPass1.Enabled = false;
                    txtPass2.Enabled = false;
                    btnAdd.Enabled = true;
                    btnTest.Enabled = false;
                }

            } // End of try
            
            catch(Exception ex)
            {
                func.exceptionbox(ex.Message);
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (func.addserver(txtIP.Text, txtPort.Text, txtPass1.Text, txtServerName.Text))
            {
                if (Settings.Default.servers[0].Contains("null"))
                {
                    Settings.Default.servers.RemoveAt(0);
                    Settings.Default.Save();
                }
                this.DialogResult = DialogResult.OK;

            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            
        }
    }
}
