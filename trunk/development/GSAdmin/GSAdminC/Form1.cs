using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace GSAdminC
{
    public partial class Form1 : Form
    {

        RCON rcon = new RCON();
        Properties.Settings settings = new Properties.Settings();
        Functions func = new Functions();
        public string[,] serverinfo = new string[50, 7];
        public string[,] playerinfo = new string[50, 30];
        public int selIndex;
        public bool notify = true;
        public bool cxtExit = false;

        public Form1()
        {
            InitializeComponent();
        }

        public void checksettings()
        {
            settings.Reload();
            if (settings.autorefresh)
            {
                refreshTmr.Enabled = true;
                refreshTmr.Interval = settings.interval * 1000;
                refreshTmr.Start();
                statusRefresh.Text = "Enabled. Interval: " + Convert.ToString(settings.interval / 60) + " Minute(s)";
            }
            else
            {
                refreshTmr.Enabled = false;
                refreshTmr.Stop();
                statusRefresh.Text = "Disabled";
            }

            if (settings.startup)
            {
                btnRefresh.PerformClick();
            }

            if (settings.servers[0] == "null")
            {
                
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button6.Enabled = false;
                ListView1.Enabled = false;
            }else{
                
                Button2.Enabled = true;
                Button3.Enabled = true;
                Button6.Enabled = true;
                
            } 
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            splashScreen splash = new splashScreen();
            splash.StartPosition = FormStartPosition.CenterScreen;
            splash.ShowDialog();
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            Version appVersion = a.GetName().Version;
            string appVersionString = appVersion.ToString();

            if (Properties.Settings.Default.ApplicationVersion != appVersion.ToString())
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.ApplicationVersion = appVersionString;
            }
            
            checksettings();
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            #region Initial refresh setup
            lblStatus.Text = "Refreshing.. Please wait";            
            ListView1.Items.Clear();
            lstPlayers.Items.Clear();
            settings.Reload();
            Array.Clear(playerinfo, 0, playerinfo.Length);
            Array.Clear(serverinfo, 0, serverinfo.Length);
            #endregion
            try
            {
                if (settings.servers[0] == "null")
                {
                    throw new Exception("You have no servers defined. You must add a server before you can use this function.");
                }

                int offline = 0;
                int records = settings.servers.Count;
                int counter = 0;
                string record;
                string[] field;
                Stopwatch ping = new Stopwatch();
                while (counter < records)
                {
                    record = settings.servers[counter];
                    field = record.Split('^');
                    GameServerInfo.GameServer server = new GameServerInfo.GameServer(field[0], Convert.ToInt32(field[1]), GameServerInfo.GameType.Quake3);
                    ping.Start();
                    server.QueryServer();
                    ping.Stop();

                    string[] item = new string[5];

                    if (server.IsOnline)
                    {
                        // If server name has changed since initial insert, update record with new name.
                        #region bugfix from old version for db server name
                        if (field[3] != GameServerInfo.GameServer.CleanName(server.Name))
                        {
                            settings.servers[counter] = field[0] + "^" + field[1] + "^" + field[2] + "^" + GameServerInfo.GameServer.CleanName(server.Name) + "^" + field[4];
                        }
                        #endregion

                        #region insert servers into listview
                        item[0] = field[0] + ":" + field[1];
                        item[1] = GameServerInfo.GameServer.CleanName(server.Name);
                        item[2] = server.Map;
                        item[3] = server.NumPlayers + " / " + server.MaxPlayers;
                        item[4] = Convert.ToString(ping.ElapsedMilliseconds);
                        ping.Reset();

                        ListViewItem itm;
                        itm = new ListViewItem(item);
                        ListView1.Items.Add(itm);
                        ListView1.Items[counter].ForeColor = Color.Black;
                        ListView1.Items[counter].BackColor = Color.White;
                        #endregion
                        
                        #region insert players into array
                        int i = 0;
                        if (server.NumPlayers != 0)
                        {
                            while (i < server.NumPlayers)
                            {
                                playerinfo[counter, i] = Convert.ToString(server.Players[i].Ping) + "^" + GameServerInfo.GameServer.CleanName(server.Players[i].Name) + "^" + server.Players[i].Score;
                                /*Commented out until re-implemented.
                                 * if (settings.showbots)
                                {
                                        playerinfo[counter, i] = Convert.ToString(server.Players[i].Ping) + "^" + GameServerInfo.GameServer.CleanName(server.Players[i].Name) + "^" + server.Players[i].Score;
                                    
                                }
                                else
                                {
                                    if (server.Players[i].Ping != 0)
                                    {
                                        playerinfo[counter, i] = Convert.ToString(server.Players[i].Ping) + "^" + GameServerInfo.GameServer.CleanName(server.Players[i].Name) + "^" + server.Players[i].Score;
                                    }
                                }*/
                                i++;
                            }
                        }
                        #endregion

                        // Finally, let's parse the server info vars.
                        #region insert server vars into array
                        serverinfo[counter, 0] = server.version;
                        serverinfo[counter, 1] = server.timelimit;
                        serverinfo[counter, 2] = server.fraglimit;
                        serverinfo[counter, 3] = server.admin;
                        serverinfo[counter, 4] = server.antilag;
                        serverinfo[counter, 5] = server.reward;
                        serverinfo[counter, 6] = Convert.ToString(server.MaxPlayers);
                        counter++;
                        #endregion
                    }
                    else
                    {
                        //Server Is Offline.
                        #region offline server handling
                        item[0] = field[0] + ":" + field[1];
                        item[1] = GameServerInfo.GameServer.CleanName(field[3]);
                        item[2] = "Server Offline";
                        item[3] = "0 / 0";
                        item[4] = "000";
                        ping.Reset();
                        ListViewItem itm;
                        itm = new ListViewItem(item);
                        ListView1.Items.Add(itm);
                        ListView1.Items[counter].ForeColor = Color.White;
                        ListView1.Items[counter].BackColor = Color.Red;
                        counter++;
                        offline++;
                        #endregion
                    }
                }
                #region listview enabling
                if (ListView1.Items.Count > 0)
                {
                    ListView1.Enabled = true;
                    Button2.Enabled = true;
                    Button3.Enabled = true;
                    Button6.Enabled = true;
                }
                else
                {
                    ListView1.Enabled = false;
                    Button2.Enabled = false;
                    Button3.Enabled = false;
                    Button6.Enabled = true;
                }
                #endregion
                lblStatus.Text = "Ready..";
                if (notify && offline > 0 && settings.notify == true)
                {
                    NotifyIcon1.BalloonTipTitle = Convert.ToString(offline) + " servers offline";
                    NotifyIcon1.BalloonTipText = "There are currently " + Convert.ToString(offline) + " servers offline. Click here to hide this message for the rest of the session.";
                    NotifyIcon1.ShowBalloonTip(5000);
                }
            }
            catch(Exception ex)
            {
                func.exceptionbox(ex.Message);
                lblStatus.Text = "An error occured..";
            }   
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddServer addsvr = new AddServer();
            
            DialogResult result = addsvr.ShowDialog();

            if (result == DialogResult.OK)
            {
                addsvr.Dispose();
                checksettings();
                btnRefresh.PerformClick();
            }
            else
            {
                addsvr.Dispose();
            }
           
        }

        
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selIndex = this.ListView1.FocusedItem.Index;
            
                int i = 0;

                if (Convert.ToString(ListView1.Items[selIndex].SubItems[4].Text) != "000")
                {
                    svrCmdSend.Enabled = true;
                    cmdServerTitle.Text = Convert.ToString(ListView1.Items[selIndex].SubItems[1].Text);
                }
                else
                {
                    cmdServerTitle.Text = Convert.ToString(ListView1.Items[selIndex].SubItems[1].Text) + " (Offline)";
                    svrCmdSend.Enabled = false;
                }

                // Insert the server information from the array.
                #region serverInsert
                lstSvrInfo.Items.Clear();
                string[] key = new string[2];
                string antilagged = null;
                if (serverinfo[selIndex, 4] == "1")
                {
                    antilagged = "Yes";
                }
                else
                {
                    antilagged = "No";
                }

                ListViewItem keys;
                key[0] = "Version";
                key[1] = serverinfo[selIndex, 0];
                keys = new ListViewItem(key);
                lstSvrInfo.Items.Add(keys);

                key[0] = "Timelimit";
                key[1] = serverinfo[selIndex, 1];
                keys = new ListViewItem(key);
                lstSvrInfo.Items.Add(keys);

                key[0] = "Fraglimit";
                key[1] = serverinfo[selIndex, 2];
                keys = new ListViewItem(key);
                lstSvrInfo.Items.Add(keys);

                key[0] = "Admin";
                key[1] = serverinfo[selIndex, 3];
                keys = new ListViewItem(key);
                lstSvrInfo.Items.Add(keys);

                key[0] = "Antilag";
                key[1] = antilagged;
                keys = new ListViewItem(key);
                lstSvrInfo.Items.Add(keys);

                key[0] = "Rewards";
                key[1] = serverinfo[selIndex, 5];
                keys = new ListViewItem(key);
                lstSvrInfo.Items.Add(keys);

                key[0] = "Max Players";
                key[1] = serverinfo[selIndex, 6];
                keys = new ListViewItem(key);
                lstSvrInfo.Items.Add(keys);
                #endregion
                // Insert the players from the array, into the player list.
                #region playerInsert
                lstPlayers.Items.Clear();
                if (playerinfo[selIndex, 0] != null)
                {
                    foreach (char item in playerinfo[selIndex, i])
                    {
                        string records = playerinfo[selIndex, i];
                        string[] record = records.Split('^');
                        string[] plr = new string[3];

                        plr[0] = record[1];
                        plr[1] = record[2];
                        plr[2] = record[0];

                        ListViewItem itm;
                        itm = new ListViewItem(plr);
                        lstPlayers.Items.Add(itm);
                        i++;
                    }
                }
                #endregion
            }
            catch
            {
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            settings.Save();
            if (settings.minimize == false || cxtExit == true)
            {
                e.Cancel = false;
            }
            else
            {
                this.Hide();
                e.Cancel = true;
                NotifyIcon1.Visible = true;
                if (settings.closeNotify)
                {
                    NotifyIcon1.BalloonTipTitle = "Information";
                    NotifyIcon1.BalloonTipText = "GSAdmin is still running. To exit, right click this icon and choose \"Exit\". This can be changed in the program settings menu. To stop displaying this message, click here.";
                    NotifyIcon1.ShowBalloonTip(8000);
                }
            }

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void ListView1_MouseDown(object sender, MouseEventArgs e)
        {
                            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string servername = ListView1.Items[selIndex].SubItems[1].Text;

            if (func.questionbox("Are you sure you want to remove server: " + servername))
            {
                settings.servers.RemoveAt(selIndex);
                settings.Save();
                btnRefresh.PerformClick();
                checksettings();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            rconResponse rconresponse = new rconResponse();
            rconresponse.servername("All Servers");
            while (i < settings.servers.Count)
            {
                string[] record = settings.servers[i].Split('^');
                rcon.initServer(record[0], Convert.ToInt32(record[1]), record[2]);
                string response = rcon.sendCommand("sv listip");
                rconresponse.response("Server: " + record[3],true);
                rconresponse.response(response + "\r\n",true);
                i++;
            }
            rconresponse.ShowDialog();
            rconresponse.Dispose();
        }

        private void SayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string response;
            response = Microsoft.VisualBasic.Interaction.InputBox("Please enter the message you would like to say.", "Send Message", "", this.Location.X,this.Location.Y);


            if (!string.IsNullOrEmpty(response) || response.Replace(" ", "") != "")
            {
                string[] record = settings.servers[selIndex].Split('^');
                rcon.initServer(record[0], Convert.ToInt32(record[1]), record[2]);
                string returned;
                returned = rcon.sendCommand("say " + response);
                if (!func.cmdValid(returned))
                {
                    func.exceptionbox("Message could not be sent. Please check your rcon password");
                }
                else
                {
                    func.successbox("Message Sent");
                }                
            }
        }

        private void MapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string response;
            response = Microsoft.VisualBasic.Interaction.InputBox("Please enter the map to change to.", "Change Map", "", this.Location.X, this.Location.Y);

            if (!string.IsNullOrEmpty(response) || response.Replace(" ", "") != "")
            {
                string[] record = settings.servers[selIndex].Split('^');
                rcon.initServer(record[0], Convert.ToInt32(record[1]), record[2]);
                string returned;
                returned = rcon.sendCommand("map " + response);
                if (!func.cmdValid(returned))
                {
                    func.exceptionbox("The server returned an error:\n" + returned);
                }
                else
                {
                    func.successbox("Map changed to " + response);
                }
            }
        }

        private void MapstartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string response;
            response = Microsoft.VisualBasic.Interaction.InputBox("Please enter the map to change to. This will reset all team scores too. Useful for starting tourneys / clan matches after warmup", "Change Map", "", this.Location.X, this.Location.Y);

            if (!string.IsNullOrEmpty(response) || response.Replace(" ", "") != "")
            {
                string[] record = settings.servers[selIndex].Split('^');
                rcon.initServer(record[0], Convert.ToInt32(record[1]), record[2]);
                string returned;
                returned = rcon.sendCommand("startmap " + response);
                if (!func.cmdValid(returned))
                {
                    func.exceptionbox("The server returned an error:\n" + returned);
                }
                else
                {
                    func.successbox("Map changed to " + response + " and scores reset.");
                }
            }
        }

        private void ViewBanlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rconResponse rconresponse = new rconResponse();
            rconresponse.servername(cmdServerTitle.Text);

            string[] record = settings.servers[selIndex].Split('^');
            rcon.initServer(record[0], Convert.ToInt32(record[1]), record[2]);
            string returned;
            returned = rcon.sendCommand("sv listip");
            
            rconresponse.response(returned, true);
            rconresponse.ShowDialog();
            rconresponse.Dispose();
        }

        private void ServerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rconResponse rconresponse = new rconResponse();
            rconresponse.servername(cmdServerTitle.Text);

            string[] record = settings.servers[selIndex].Split('^');
            rcon.initServer(record[0], Convert.ToInt32(record[1]), record[2]);
            string returned;
            returned = rcon.sendCommand("serverinfo");

            rconresponse.response(returned, true);
            rconresponse.ShowDialog();
            rconresponse.Dispose();
        }

        private void OnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] record = settings.servers[selIndex].Split('^');
            rcon.initServer(record[0], Convert.ToInt32(record[1]), record[2]);
            string returned;
            returned = rcon.sendCommand("set g_antilag 1");
            if (!func.cmdValid(returned))
            {
                func.exceptionbox("The server returned an error:\n" + returned);
            }
            else
            {
                func.successbox("Antilag is now enabled.");
            }
        }

        private void OffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] record = settings.servers[selIndex].Split('^');
            rcon.initServer(record[0], Convert.ToInt32(record[1]), record[2]);
            string returned;
            returned = rcon.sendCommand("set g_antilag 0");
            if (!func.cmdValid(returned))
            {
                func.exceptionbox("The server returned an error:\n" + returned);
            }
            else
            {
                func.successbox("Antilag is now disabled.");
            }
        }

        private void OnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string[] record = settings.servers[selIndex].Split('^');
            rcon.initServer(record[0], Convert.ToInt32(record[1]), record[2]);
            string returned;
            returned = rcon.sendCommand("set g_callvote 1");
            if (!func.cmdValid(returned))
            {
                func.exceptionbox("The server returned an error:\n" + returned);
            }
            else
            {
                func.successbox("Callvoting is now enabled.");
            }
        }

        private void OffToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string[] record = settings.servers[selIndex].Split('^');
            rcon.initServer(record[0], Convert.ToInt32(record[1]), record[2]);
            string returned;
            returned = rcon.sendCommand("set g_callvote 0");
            if (!func.cmdValid(returned))
            {
                func.exceptionbox("The server returned an error:\n" + returned);
            }
            else
            {
                func.successbox("Callvoting is now disabled.");
            }
        }

        private void StatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rconResponse rconresponse = new rconResponse();
            rconresponse.servername(cmdServerTitle.Text);

            string[] record = settings.servers[selIndex].Split('^');
            rcon.initServer(record[0], Convert.ToInt32(record[1]), record[2]);
            string returned;
            returned = rcon.sendCommand("status");

            rconresponse.response(returned, true);
            rconresponse.ShowDialog();
            rconresponse.Dispose();
        }

        private void KickBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kickBan kickban = new kickBan();
            string[] record = settings.servers[selIndex].Split('^');
            kickban.serverinfo(cmdServerTitle.Text, record[0], Convert.ToInt32(record[1]), record[2]);
            kickban.ShowDialog();
            kickban.Dispose();
        }

        private void CustomCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customCommand custCmd = new customCommand();
            string[] record = settings.servers[selIndex].Split('^');
            custCmd.serverinfo(cmdServerTitle.Text, record[0], Convert.ToInt32(record[1]), record[2]);
            custCmd.ShowDialog();
            custCmd.Dispose();
        }

        private void UnbanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unBan unban = new unBan();
            string[] record = settings.servers[selIndex].Split('^');
            unban.serverinfo(cmdServerTitle.Text, record[0], Convert.ToInt32(record[1]), record[2]);
            unban.ShowDialog();
            unban.Dispose();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            programSettings settingsfrm = new programSettings();
            settingsfrm.ShowDialog();
            checksettings();
            btnRefresh.PerformClick();
            
        }

        private void refreshTmr_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = "Refreshing.. Please wait.";
            btnRefresh.PerformClick();
            lblStatus.Text = "Ready..";
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void JoinThisGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                
                if (settings.enablejoin == false)
                {
                    throw new Exception("You must enable this feature in program settings before you can use it");
                }
                string[] record = settings.servers[selIndex].Split('^');
                Process StartGame = new Process();
                StartGame.StartInfo.WorkingDirectory = settings.aalocation;
                StartGame.StartInfo.FileName = settings.aalocation + "\\crx.exe";
                StartGame.StartInfo.Arguments = "+set game arena +set name " + settings.playername + " +connect " + record[0] + ":" + record[1];
                StartGame.Start();
            }
            catch(Exception ex)
            {
                func.exceptionbox(ex.Message);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            aboutBox about = new aboutBox();
            about.ShowDialog();
        }

        private void NotifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            
            if (NotifyIcon1.BalloonTipText.Contains("GSAdmin is still running"))
            {
                settings.closeNotify = false;
            }
            else
            {
                notify = false;
            }

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (settings.servers.Count == 0)
                {
                    throw new Exception("You have no servers defined. You must add a server before you can use this function.");
                }

                broadcastMessage message = new broadcastMessage();
                message.ShowDialog();
            }
            catch (Exception ex)
            {
                func.exceptionbox(ex.Message);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxtExit = true;
            this.Close();
        }

        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            NotifyIcon1.Visible = false;
        }

        private void NotifyIcon1_Click(object sender, EventArgs e)
        {

        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            egg egg = new egg();
            egg.ShowDialog();
        }

    }
}
