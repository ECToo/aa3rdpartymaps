namespace GSAdminC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ListView1 = new System.Windows.Forms.ListView();
            this.svrIp = new System.Windows.Forms.ColumnHeader();
            this.svrName = new System.Windows.Forms.ColumnHeader();
            this.colMap = new System.Windows.Forms.ColumnHeader();
            this.svrPlayers = new System.Windows.Forms.ColumnHeader();
            this.svrPing = new System.Windows.Forms.ColumnHeader();
            this.svrCmdSend = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmdServerTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.JoinThisGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MapToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MapstartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KickBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewBanlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnbanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AntilagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CallVotingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OffToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CustomCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Button6 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.NotifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cxtIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshTmr = new System.Windows.Forms.Timer(this.components);
            this.Button5 = new System.Windows.Forms.Button();
            this.lstPlayers = new System.Windows.Forms.ListView();
            this.svrPlayerName = new System.Windows.Forms.ColumnHeader();
            this.svrPlayerScore = new System.Windows.Forms.ColumnHeader();
            this.svrPlayerPing = new System.Windows.Forms.ColumnHeader();
            this.Label1 = new System.Windows.Forms.Label();
            this.lstSvrInfo = new System.Windows.Forms.ListView();
            this.svrKey = new System.Windows.Forms.ColumnHeader();
            this.svrValue = new System.Windows.Forms.ColumnHeader();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusRefresh = new System.Windows.Forms.ToolStripStatusLabel();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.svrRefreshWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.svrCmdSend.SuspendLayout();
            this.cxtIcon.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.svrIp,
            this.svrName,
            this.colMap,
            this.svrPlayers,
            this.svrPing});
            this.ListView1.ContextMenuStrip = this.svrCmdSend;
            this.ListView1.Enabled = false;
            this.ListView1.FullRowSelect = true;
            this.ListView1.Location = new System.Drawing.Point(6, 20);
            this.ListView1.MultiSelect = false;
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(423, 267);
            this.ListView1.TabIndex = 14;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            this.ListView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListView1_MouseDown);
            // 
            // svrIp
            // 
            this.svrIp.Text = "Server IP";
            this.svrIp.Width = 100;
            // 
            // svrName
            // 
            this.svrName.Text = "Server Name";
            this.svrName.Width = 133;
            // 
            // colMap
            // 
            this.colMap.Text = "Map";
            this.colMap.Width = 88;
            // 
            // svrPlayers
            // 
            this.svrPlayers.Text = "Players";
            this.svrPlayers.Width = 54;
            // 
            // svrPing
            // 
            this.svrPing.Text = "Ping";
            this.svrPing.Width = 43;
            // 
            // svrCmdSend
            // 
            this.svrCmdSend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdServerTitle,
            this.toolStripSeparator2,
            this.JoinThisGameToolStripMenuItem,
            this.SayToolStripMenuItem,
            this.MapToolStripMenuItem,
            this.StatusToolStripMenuItem,
            this.KickBanToolStripMenuItem,
            this.ViewBanlistToolStripMenuItem,
            this.UnbanToolStripMenuItem,
            this.ServerInfoToolStripMenuItem,
            this.AntilagToolStripMenuItem,
            this.CallVotingToolStripMenuItem,
            this.ToolStripSeparator1,
            this.CustomCommandToolStripMenuItem});
            this.svrCmdSend.Name = "svrCmdSend";
            this.svrCmdSend.Size = new System.Drawing.Size(177, 280);
            // 
            // cmdServerTitle
            // 
            this.cmdServerTitle.Enabled = false;
            this.cmdServerTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdServerTitle.Name = "cmdServerTitle";
            this.cmdServerTitle.Size = new System.Drawing.Size(176, 22);
            this.cmdServerTitle.Text = "[SERVERNAME]";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
            // 
            // JoinThisGameToolStripMenuItem
            // 
            this.JoinThisGameToolStripMenuItem.Name = "JoinThisGameToolStripMenuItem";
            this.JoinThisGameToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.JoinThisGameToolStripMenuItem.Text = "Join this game";
            this.JoinThisGameToolStripMenuItem.Click += new System.EventHandler(this.JoinThisGameToolStripMenuItem_Click);
            // 
            // SayToolStripMenuItem
            // 
            this.SayToolStripMenuItem.Name = "SayToolStripMenuItem";
            this.SayToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.SayToolStripMenuItem.Text = "Say";
            this.SayToolStripMenuItem.Click += new System.EventHandler(this.SayToolStripMenuItem_Click);
            // 
            // MapToolStripMenuItem
            // 
            this.MapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MapToolStripMenuItem1,
            this.MapstartToolStripMenuItem});
            this.MapToolStripMenuItem.Name = "MapToolStripMenuItem";
            this.MapToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.MapToolStripMenuItem.Text = "Change Map";
            // 
            // MapToolStripMenuItem1
            // 
            this.MapToolStripMenuItem1.Name = "MapToolStripMenuItem1";
            this.MapToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.MapToolStripMenuItem1.Text = "Map";
            this.MapToolStripMenuItem1.Click += new System.EventHandler(this.MapToolStripMenuItem1_Click);
            // 
            // MapstartToolStripMenuItem
            // 
            this.MapstartToolStripMenuItem.Name = "MapstartToolStripMenuItem";
            this.MapstartToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.MapstartToolStripMenuItem.Text = "Mapstart";
            this.MapstartToolStripMenuItem.Click += new System.EventHandler(this.MapstartToolStripMenuItem_Click);
            // 
            // StatusToolStripMenuItem
            // 
            this.StatusToolStripMenuItem.Name = "StatusToolStripMenuItem";
            this.StatusToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.StatusToolStripMenuItem.Text = "Status";
            this.StatusToolStripMenuItem.Click += new System.EventHandler(this.StatusToolStripMenuItem_Click);
            // 
            // KickBanToolStripMenuItem
            // 
            this.KickBanToolStripMenuItem.Name = "KickBanToolStripMenuItem";
            this.KickBanToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.KickBanToolStripMenuItem.Text = "Kick/Ban";
            this.KickBanToolStripMenuItem.Click += new System.EventHandler(this.KickBanToolStripMenuItem_Click);
            // 
            // ViewBanlistToolStripMenuItem
            // 
            this.ViewBanlistToolStripMenuItem.Name = "ViewBanlistToolStripMenuItem";
            this.ViewBanlistToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.ViewBanlistToolStripMenuItem.Text = "View Banlist";
            this.ViewBanlistToolStripMenuItem.Click += new System.EventHandler(this.ViewBanlistToolStripMenuItem_Click);
            // 
            // UnbanToolStripMenuItem
            // 
            this.UnbanToolStripMenuItem.Name = "UnbanToolStripMenuItem";
            this.UnbanToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.UnbanToolStripMenuItem.Text = "Unban";
            this.UnbanToolStripMenuItem.Click += new System.EventHandler(this.UnbanToolStripMenuItem_Click);
            // 
            // ServerInfoToolStripMenuItem
            // 
            this.ServerInfoToolStripMenuItem.Name = "ServerInfoToolStripMenuItem";
            this.ServerInfoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.ServerInfoToolStripMenuItem.Text = "Server Info";
            this.ServerInfoToolStripMenuItem.Click += new System.EventHandler(this.ServerInfoToolStripMenuItem_Click);
            // 
            // AntilagToolStripMenuItem
            // 
            this.AntilagToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnToolStripMenuItem,
            this.OffToolStripMenuItem});
            this.AntilagToolStripMenuItem.Name = "AntilagToolStripMenuItem";
            this.AntilagToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.AntilagToolStripMenuItem.Text = "Antilag";
            // 
            // OnToolStripMenuItem
            // 
            this.OnToolStripMenuItem.Name = "OnToolStripMenuItem";
            this.OnToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.OnToolStripMenuItem.Text = "On";
            this.OnToolStripMenuItem.Click += new System.EventHandler(this.OnToolStripMenuItem_Click);
            // 
            // OffToolStripMenuItem
            // 
            this.OffToolStripMenuItem.Name = "OffToolStripMenuItem";
            this.OffToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.OffToolStripMenuItem.Text = "Off";
            this.OffToolStripMenuItem.Click += new System.EventHandler(this.OffToolStripMenuItem_Click);
            // 
            // CallVotingToolStripMenuItem
            // 
            this.CallVotingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnToolStripMenuItem1,
            this.OffToolStripMenuItem1});
            this.CallVotingToolStripMenuItem.Name = "CallVotingToolStripMenuItem";
            this.CallVotingToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.CallVotingToolStripMenuItem.Text = "Call Voting";
            // 
            // OnToolStripMenuItem1
            // 
            this.OnToolStripMenuItem1.Name = "OnToolStripMenuItem1";
            this.OnToolStripMenuItem1.Size = new System.Drawing.Size(91, 22);
            this.OnToolStripMenuItem1.Text = "On";
            this.OnToolStripMenuItem1.Click += new System.EventHandler(this.OnToolStripMenuItem1_Click);
            // 
            // OffToolStripMenuItem1
            // 
            this.OffToolStripMenuItem1.Name = "OffToolStripMenuItem1";
            this.OffToolStripMenuItem1.Size = new System.Drawing.Size(91, 22);
            this.OffToolStripMenuItem1.Text = "Off";
            this.OffToolStripMenuItem1.Click += new System.EventHandler(this.OffToolStripMenuItem1_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // CustomCommandToolStripMenuItem
            // 
            this.CustomCommandToolStripMenuItem.Name = "CustomCommandToolStripMenuItem";
            this.CustomCommandToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.CustomCommandToolStripMenuItem.Text = "Custom Command";
            this.CustomCommandToolStripMenuItem.Click += new System.EventHandler(this.CustomCommandToolStripMenuItem_Click);
            // 
            // Button6
            // 
            this.Button6.Enabled = false;
            this.Button6.Location = new System.Drawing.Point(252, 55);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(117, 27);
            this.Button6.TabIndex = 11;
            this.Button6.Text = "Broadcast Message";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(252, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 27);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh Now";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Button3
            // 
            this.Button3.Enabled = false;
            this.Button3.Location = new System.Drawing.Point(131, 19);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(117, 27);
            this.Button3.TabIndex = 9;
            this.Button3.Text = "View Banlists";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(388, 353);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(195, 26);
            this.Label4.TabIndex = 22;
            this.Label4.Text = "Once you\'ve added a server, \r\nsimply right click it to see the commands";
            // 
            // NotifyIcon1
            // 
            this.NotifyIcon1.ContextMenuStrip = this.cxtIcon;
            this.NotifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon1.Icon")));
            this.NotifyIcon1.Text = "GSAdmin";
            this.NotifyIcon1.BalloonTipClicked += new System.EventHandler(this.NotifyIcon1_BalloonTipClicked);
            this.NotifyIcon1.Click += new System.EventHandler(this.NotifyIcon1_Click);
            this.NotifyIcon1.DoubleClick += new System.EventHandler(this.NotifyIcon1_DoubleClick);
            this.NotifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // cxtIcon
            // 
            this.cxtIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.cxtIcon.Name = "cxtIcon";
            this.cxtIcon.Size = new System.Drawing.Size(93, 26);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // refreshTmr
            // 
            this.refreshTmr.Interval = 60000;
            this.refreshTmr.Tick += new System.EventHandler(this.refreshTmr_Tick);
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(593, 357);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(63, 27);
            this.Button5.TabIndex = 23;
            this.Button5.Text = "About";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // lstPlayers
            // 
            this.lstPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.svrPlayerName,
            this.svrPlayerScore,
            this.svrPlayerPing});
            this.lstPlayers.FullRowSelect = true;
            this.lstPlayers.Location = new System.Drawing.Point(438, 20);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(225, 122);
            this.lstPlayers.TabIndex = 16;
            this.lstPlayers.UseCompatibleStateImageBehavior = false;
            this.lstPlayers.View = System.Windows.Forms.View.Details;
            // 
            // svrPlayerName
            // 
            this.svrPlayerName.Text = "Name";
            this.svrPlayerName.Width = 131;
            // 
            // svrPlayerScore
            // 
            this.svrPlayerScore.Text = "Score";
            this.svrPlayerScore.Width = 43;
            // 
            // svrPlayerPing
            // 
            this.svrPlayerPing.Text = "Ping";
            this.svrPlayerPing.Width = 43;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 4);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(71, 13);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Your Servers:";
            // 
            // lstSvrInfo
            // 
            this.lstSvrInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.svrKey,
            this.svrValue});
            this.lstSvrInfo.FullRowSelect = true;
            this.lstSvrInfo.Location = new System.Drawing.Point(438, 165);
            this.lstSvrInfo.Name = "lstSvrInfo";
            this.lstSvrInfo.Size = new System.Drawing.Size(225, 174);
            this.lstSvrInfo.TabIndex = 17;
            this.lstSvrInfo.UseCompatibleStateImageBehavior = false;
            this.lstSvrInfo.View = System.Windows.Forms.View.Details;
            // 
            // svrKey
            // 
            this.svrKey.Text = "Key";
            this.svrKey.Width = 68;
            // 
            // svrValue
            // 
            this.svrValue.Text = "Value";
            this.svrValue.Width = 202;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Button6);
            this.GroupBox1.Controls.Add(this.btnRefresh);
            this.GroupBox1.Controls.Add(this.Button3);
            this.GroupBox1.Controls.Add(this.Button4);
            this.GroupBox1.Controls.Add(this.Button2);
            this.GroupBox1.Controls.Add(this.Button1);
            this.GroupBox1.Location = new System.Drawing.Point(6, 293);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(379, 88);
            this.GroupBox1.TabIndex = 21;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Operations";
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(131, 55);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(117, 27);
            this.Button4.TabIndex = 8;
            this.Button4.Text = "Program Settings";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button2
            // 
            this.Button2.Enabled = false;
            this.Button2.Location = new System.Drawing.Point(11, 55);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(117, 27);
            this.Button2.TabIndex = 7;
            this.Button2.Text = "Remove Server";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(11, 19);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(117, 27);
            this.Button1.TabIndex = 6;
            this.Button1.Text = "Add New Server";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.ToolStripStatusLabel1.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 17);
            this.lblStatus.Text = "Ready..";
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.lblStatus,
            this.toolStripStatusLabel2,
            this.statusRefresh});
            this.StatusBar.Location = new System.Drawing.Point(0, 387);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(671, 22);
            this.StatusBar.SizingGrip = false;
            this.StatusBar.Stretch = false;
            this.StatusBar.TabIndex = 20;
            this.StatusBar.Text = "Status:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(75, 17);
            this.toolStripStatusLabel2.Text = "AutoRefresh:";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // statusRefresh
            // 
            this.statusRefresh.Enabled = false;
            this.statusRefresh.Name = "statusRefresh";
            this.statusRefresh.Size = new System.Drawing.Size(41, 17);
            this.statusRefresh.Text = "STATE";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(435, 147);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(96, 13);
            this.Label3.TabIndex = 19;
            this.Label3.Text = "Server Information:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(435, 4);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(44, 13);
            this.Label2.TabIndex = 18;
            this.Label2.Text = "Players:";
            // 
            // svrRefreshWorker
            // 
            this.svrRefreshWorker.WorkerReportsProgress = true;
            this.svrRefreshWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(660, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 10);
            this.panel1.TabIndex = 24;
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 409);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.lstPlayers);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lstSvrInfo);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GSAdmin v1.0 RELEASE - By 3PM Productions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.svrCmdSend.ResumeLayout(false);
            this.cxtIcon.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListView ListView1;
        internal System.Windows.Forms.ColumnHeader svrIp;
        internal System.Windows.Forms.ColumnHeader svrName;
        internal System.Windows.Forms.ColumnHeader colMap;
        internal System.Windows.Forms.ColumnHeader svrPlayers;
        internal System.Windows.Forms.ColumnHeader svrPing;
        internal System.Windows.Forms.ToolStripMenuItem StatusToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem KickBanToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ViewBanlistToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem UnbanToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem MapstartToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem MapToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem MapToolStripMenuItem;
        internal System.Windows.Forms.Button Button6;
        internal System.Windows.Forms.ToolStripMenuItem SayToolStripMenuItem;
        internal System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.ToolStripMenuItem ServerInfoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AntilagToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem OnToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem OffToolStripMenuItem;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.NotifyIcon NotifyIcon1;
        internal System.Windows.Forms.ContextMenuStrip cxtIcon;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        internal System.Windows.Forms.Timer refreshTmr;
        internal System.Windows.Forms.ToolStripMenuItem CustomCommandToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem CallVotingToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem OnToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem OffToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem JoinThisGameToolStripMenuItem;
        internal System.Windows.Forms.ContextMenuStrip svrCmdSend;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.ListView lstPlayers;
        internal System.Windows.Forms.ColumnHeader svrPlayerName;
        internal System.Windows.Forms.ColumnHeader svrPlayerScore;
        internal System.Windows.Forms.ColumnHeader svrPlayerPing;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ListView lstSvrInfo;
        internal System.Windows.Forms.ColumnHeader svrKey;
        internal System.Windows.Forms.ColumnHeader svrValue;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        internal System.Windows.Forms.ToolStripStatusLabel lblStatus;
        internal System.Windows.Forms.StatusStrip StatusBar;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        private System.ComponentModel.BackgroundWorker svrRefreshWorker;
        private System.Windows.Forms.ToolStripMenuItem cmdServerTitle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel statusRefresh;
        private System.Windows.Forms.Panel panel1;
    }
}

