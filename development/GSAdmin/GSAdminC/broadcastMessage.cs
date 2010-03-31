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
                if (settings.servers.Count == 0)
                {
                    throw new Exception("You have no servers defined. You must add a server before you can use this function.");
                }

                int offline = 0;
                int records = settings.servers.Count;
                int counter = 0;
                string record;
                string[] field;
                
                while (counter < records)
                {
                    record = settings.servers[counter];
                    field = record.Split('^');
                    GameServerInfo.GameServer server = new GameServerInfo.GameServer(field[0], Convert.ToInt32(field[1]), GameServerInfo.GameType.Quake3);
                   
                    server.QueryServer();
                    

                    string[] item = new string[5];

                    if (server.IsOnline)
                    {                  
                        
                    }
                    
                       
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
    }
}
