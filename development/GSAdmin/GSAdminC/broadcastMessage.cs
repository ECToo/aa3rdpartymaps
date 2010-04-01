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
    public partial class broadcastMessage : Form
    {
        Properties.Settings settings = new Properties.Settings();
        Functions func = new Functions();

        public broadcastMessage()
        {
            InitializeComponent();
        }

        private void broadcastMessage_Load(object sender, EventArgs e)
        {
            try
            {
                int records = settings.servers.Count;
                int counter = 0;
                string record;
                string[] field;
                chkList.Items.Clear();

                while (counter < records)
                {
                    record = settings.servers[counter];
                    field = record.Split('^');
                    GameServerInfo.GameServer server = new GameServerInfo.GameServer(field[0], Convert.ToInt32(field[1]), GameServerInfo.GameType.Quake3);
                   
                    server.QueryServer();
                    
                    if (server.IsOnline)
                    {                  
                    chkList.Items.Add(GameServerInfo.GameServer.CleanName(server.Name));
                    }                    
                    counter++;   
                }

                #region listview enabling
                if (chkList.Items.Count > 0)
                {
                    chkList.Enabled = true;
                    Button1.Enabled = true;
                    Button2.Enabled = true;
                    OK_Button.Enabled = true;
                    
                }
                else
                {
                    chkList.Enabled = false;
                    Button1.Enabled = false;
                    Button2.Enabled = false;
                    OK_Button.Enabled = false;
                }
                #endregion
                
            }
            catch (Exception ex)
            {
                func.exceptionbox(ex.Message);  
            }   
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkList.Items.Count; i++)
            {
                chkList.SetItemChecked(i, true);
            }  
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkList.Items.Count; i++)
            {
                chkList.SetItemChecked(i, false);
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {

        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (chkList.CheckedItems.Count == 0)
            {
                throw new Exception("You must select at least one server to broadcast to. Alternatively, click close");
            }
            int i = 0;
            string search;
            string[] field;
            int online = 0;
            int offline = 0;
            string response;
            foreach (string item in chkList.CheckedItems)
            {
                i = 0;
                while (i < settings.servers.Count)
                {
                    search = settings.servers[i];
                    if (search.Contains(item))
                    {
                        RCON rcon = new RCON();
                        field = search.Split('^');
                        rcon.initServer(field[0], Convert.ToInt32(field[1]), field[2]);
                        response = rcon.sendCommand("say " + TextBox1.Text);
                        if (func.cmdValid(response))
                        {
                            online++;
                        }
                        else
                        {
                            offline++;
                        }
                        i++;
                    }else{
                        i++;
                    }

                }
            }
            if (offline != 0)
            {
                func.successbox("Message sent to " + Convert.ToString(online) + " of " + Convert.ToString(chkList.CheckedItems.Count) + " servers. " + Environment.NewLine + Convert.ToString(offline) + " server(s) reported errors. Please check your rcon passwords, and ensure the servers are online.");
            }
            else
            {
                func.successbox("Message broadcast to " + Convert.ToString(online) + " servers.");
            }

        }
    }
}
