<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.svrIp = New System.Windows.Forms.ColumnHeader
        Me.svrName = New System.Windows.Forms.ColumnHeader
        Me.colMap = New System.Windows.Forms.ColumnHeader
        Me.svrPlayers = New System.Windows.Forms.ColumnHeader
        Me.svrPing = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstPlayers = New System.Windows.Forms.ListView
        Me.svrPlayerName = New System.Windows.Forms.ColumnHeader
        Me.svrPlayerScore = New System.Windows.Forms.ColumnHeader
        Me.svrPlayerPing = New System.Windows.Forms.ColumnHeader
        Me.lstSvrInfo = New System.Windows.Forms.ListView
        Me.svrKey = New System.Windows.Forms.ColumnHeader
        Me.svrValue = New System.Windows.Forms.ColumnHeader
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.StatusBar = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.svrCmdSend = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MapToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MapstartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KickBanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewBanlistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UnbanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ServerInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AntilagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CallVotingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OnToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.OffToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.CustomCommandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.refreshTmr = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.svrRemove = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveThisServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.StatusBar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.svrCmdSend.SuspendLayout()
        Me.svrRemove.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.svrIp, Me.svrName, Me.colMap, Me.svrPlayers, Me.svrPing})
        Me.ListView1.Enabled = False
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(12, 24)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(423, 164)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'svrIp
        '
        Me.svrIp.Text = "Server IP"
        Me.svrIp.Width = 100
        '
        'svrName
        '
        Me.svrName.Text = "Server Name"
        Me.svrName.Width = 133
        '
        'colMap
        '
        Me.colMap.Text = "Map"
        Me.colMap.Width = 88
        '
        'svrPlayers
        '
        Me.svrPlayers.Text = "Players"
        Me.svrPlayers.Width = 54
        '
        'svrPing
        '
        Me.svrPing.Text = "Ping"
        Me.svrPing.Width = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Your Servers:"
        '
        'lstPlayers
        '
        Me.lstPlayers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.svrPlayerName, Me.svrPlayerScore, Me.svrPlayerPing})
        Me.lstPlayers.FullRowSelect = True
        Me.lstPlayers.Location = New System.Drawing.Point(444, 24)
        Me.lstPlayers.Name = "lstPlayers"
        Me.lstPlayers.Size = New System.Drawing.Size(225, 122)
        Me.lstPlayers.TabIndex = 2
        Me.lstPlayers.UseCompatibleStateImageBehavior = False
        Me.lstPlayers.View = System.Windows.Forms.View.Details
        '
        'svrPlayerName
        '
        Me.svrPlayerName.Text = "Name"
        Me.svrPlayerName.Width = 131
        '
        'svrPlayerScore
        '
        Me.svrPlayerScore.Text = "Score"
        Me.svrPlayerScore.Width = 43
        '
        'svrPlayerPing
        '
        Me.svrPlayerPing.Text = "Ping"
        Me.svrPlayerPing.Width = 43
        '
        'lstSvrInfo
        '
        Me.lstSvrInfo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.svrKey, Me.svrValue})
        Me.lstSvrInfo.FullRowSelect = True
        Me.lstSvrInfo.Location = New System.Drawing.Point(444, 169)
        Me.lstSvrInfo.Name = "lstSvrInfo"
        Me.lstSvrInfo.Size = New System.Drawing.Size(225, 174)
        Me.lstSvrInfo.TabIndex = 3
        Me.lstSvrInfo.UseCompatibleStateImageBehavior = False
        Me.lstSvrInfo.View = System.Windows.Forms.View.Details
        '
        'svrKey
        '
        Me.svrKey.Text = "Key"
        Me.svrKey.Width = 68
        '
        'svrValue
        '
        Me.svrValue.Text = "Value"
        Me.svrValue.Width = 202
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(441, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Players:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(441, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Server Information:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 27)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Add New Server"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(6, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 27)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Remove Server"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'StatusBar
        '
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblStatus})
        Me.StatusBar.Location = New System.Drawing.Point(0, 391)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(681, 22)
        Me.StatusBar.TabIndex = 8
        Me.StatusBar.Text = "Status:"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel1.Text = "Status:"
        '
        'lblStatus
        '
        Me.lblStatus.ForeColor = System.Drawing.Color.Gray
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(45, 17)
        Me.lblStatus.Text = "Ready.."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 297)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 88)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operations"
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.Location = New System.Drawing.Point(247, 55)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 27)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Broadcast Message"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(247, 19)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(117, 27)
        Me.btnRefresh.TabIndex = 10
        Me.btnRefresh.Text = "Refresh Now"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(126, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 27)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "View Banlists"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(126, 55)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 27)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Program Settings"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(606, 361)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(63, 27)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "About"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'svrCmdSend
        '
        Me.svrCmdSend.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SayToolStripMenuItem, Me.MapToolStripMenuItem, Me.StatusToolStripMenuItem, Me.KickBanToolStripMenuItem, Me.ViewBanlistToolStripMenuItem, Me.UnbanToolStripMenuItem, Me.ServerInfoToolStripMenuItem, Me.AntilagToolStripMenuItem, Me.CallVotingToolStripMenuItem, Me.ToolStripSeparator1, Me.CustomCommandToolStripMenuItem})
        Me.svrCmdSend.Name = "svrCmdSend"
        Me.svrCmdSend.Size = New System.Drawing.Size(177, 230)
        '
        'SayToolStripMenuItem
        '
        Me.SayToolStripMenuItem.Name = "SayToolStripMenuItem"
        Me.SayToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SayToolStripMenuItem.Text = "Say"
        '
        'MapToolStripMenuItem
        '
        Me.MapToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MapToolStripMenuItem1, Me.MapstartToolStripMenuItem})
        Me.MapToolStripMenuItem.Name = "MapToolStripMenuItem"
        Me.MapToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.MapToolStripMenuItem.Text = "Change Map"
        '
        'MapToolStripMenuItem1
        '
        Me.MapToolStripMenuItem1.Name = "MapToolStripMenuItem1"
        Me.MapToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.MapToolStripMenuItem1.Text = "Map"
        '
        'MapstartToolStripMenuItem
        '
        Me.MapstartToolStripMenuItem.Name = "MapstartToolStripMenuItem"
        Me.MapstartToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.MapstartToolStripMenuItem.Text = "Mapstart"
        '
        'StatusToolStripMenuItem
        '
        Me.StatusToolStripMenuItem.Name = "StatusToolStripMenuItem"
        Me.StatusToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.StatusToolStripMenuItem.Text = "Status"
        '
        'KickBanToolStripMenuItem
        '
        Me.KickBanToolStripMenuItem.Name = "KickBanToolStripMenuItem"
        Me.KickBanToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.KickBanToolStripMenuItem.Text = "Kick/Ban"
        '
        'ViewBanlistToolStripMenuItem
        '
        Me.ViewBanlistToolStripMenuItem.Name = "ViewBanlistToolStripMenuItem"
        Me.ViewBanlistToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ViewBanlistToolStripMenuItem.Text = "View Banlist"
        '
        'UnbanToolStripMenuItem
        '
        Me.UnbanToolStripMenuItem.Name = "UnbanToolStripMenuItem"
        Me.UnbanToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.UnbanToolStripMenuItem.Text = "Unban"
        '
        'ServerInfoToolStripMenuItem
        '
        Me.ServerInfoToolStripMenuItem.Name = "ServerInfoToolStripMenuItem"
        Me.ServerInfoToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ServerInfoToolStripMenuItem.Text = "Server Info"
        '
        'AntilagToolStripMenuItem
        '
        Me.AntilagToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnToolStripMenuItem, Me.OffToolStripMenuItem})
        Me.AntilagToolStripMenuItem.Name = "AntilagToolStripMenuItem"
        Me.AntilagToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.AntilagToolStripMenuItem.Text = "Antilag"
        '
        'OnToolStripMenuItem
        '
        Me.OnToolStripMenuItem.Name = "OnToolStripMenuItem"
        Me.OnToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.OnToolStripMenuItem.Text = "On"
        '
        'OffToolStripMenuItem
        '
        Me.OffToolStripMenuItem.Name = "OffToolStripMenuItem"
        Me.OffToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.OffToolStripMenuItem.Text = "Off"
        '
        'CallVotingToolStripMenuItem
        '
        Me.CallVotingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnToolStripMenuItem1, Me.OffToolStripMenuItem1})
        Me.CallVotingToolStripMenuItem.Name = "CallVotingToolStripMenuItem"
        Me.CallVotingToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CallVotingToolStripMenuItem.Text = "Call Voting"
        '
        'OnToolStripMenuItem1
        '
        Me.OnToolStripMenuItem1.Name = "OnToolStripMenuItem1"
        Me.OnToolStripMenuItem1.Size = New System.Drawing.Size(91, 22)
        Me.OnToolStripMenuItem1.Text = "On"
        '
        'OffToolStripMenuItem1
        '
        Me.OffToolStripMenuItem1.Name = "OffToolStripMenuItem1"
        Me.OffToolStripMenuItem1.Size = New System.Drawing.Size(91, 22)
        Me.OffToolStripMenuItem1.Text = "Off"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(173, 6)
        '
        'CustomCommandToolStripMenuItem
        '
        Me.CustomCommandToolStripMenuItem.Name = "CustomCommandToolStripMenuItem"
        Me.CustomCommandToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CustomCommandToolStripMenuItem.Text = "Custom Command"
        '
        'refreshTmr
        '
        Me.refreshTmr.Interval = 60000
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(388, 359)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 26)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Once you've added a server, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "simply right click it to see the commands"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(347, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Servers not responding: To remove servers from this list, right click them."
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.Location = New System.Drawing.Point(12, 207)
        Me.ListView2.MultiSelect = False
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(423, 84)
        Me.ListView2.TabIndex = 11
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Server IP"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Server Name"
        Me.ColumnHeader2.Width = 133
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Map"
        Me.ColumnHeader3.Width = 88
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Players"
        Me.ColumnHeader4.Width = 54
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Ping"
        Me.ColumnHeader5.Width = 43
        '
        'svrRemove
        '
        Me.svrRemove.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveThisServerToolStripMenuItem})
        Me.svrRemove.Name = "svrRemove"
        Me.svrRemove.Size = New System.Drawing.Size(174, 26)
        '
        'RemoveThisServerToolStripMenuItem
        '
        Me.RemoveThisServerToolStripMenuItem.Name = "RemoveThisServerToolStripMenuItem"
        Me.RemoveThisServerToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.RemoveThisServerToolStripMenuItem.Text = "Remove this server"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(395, 306)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(39, 36)
        Me.Panel1.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 413)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstSvrInfo)
        Me.Controls.Add(Me.lstPlayers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "GS Admin v0.5 STABLE by 3PM"
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.svrCmdSend.ResumeLayout(False)
        Me.svrRemove.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstPlayers As System.Windows.Forms.ListView
    Friend WithEvents lstSvrInfo As System.Windows.Forms.ListView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents StatusBar As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents svrIp As System.Windows.Forms.ColumnHeader
    Friend WithEvents svrName As System.Windows.Forms.ColumnHeader
    Friend WithEvents svrPing As System.Windows.Forms.ColumnHeader
    Friend WithEvents svrPlayers As System.Windows.Forms.ColumnHeader
    Friend WithEvents svrPlayerName As System.Windows.Forms.ColumnHeader
    Friend WithEvents svrPlayerScore As System.Windows.Forms.ColumnHeader
    Friend WithEvents svrPlayerPing As System.Windows.Forms.ColumnHeader
    Friend WithEvents svrKey As System.Windows.Forms.ColumnHeader
    Friend WithEvents svrValue As System.Windows.Forms.ColumnHeader
    Friend WithEvents svrCmdSend As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MapToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MapstartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KickBanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServerInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AntilagToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CallVotingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OffToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CustomCommandToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents refreshTmr As System.Windows.Forms.Timer
    Friend WithEvents colMap As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnbanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents svrRemove As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveThisServerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ViewBanlistToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
