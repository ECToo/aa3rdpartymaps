Imports GameServerInfo
Imports System.Text.RegularExpressions
Imports System.Text

Public Class Form1

    Public playerinfo(30, 30) As String
    Public serverinfo(30, 30) As String
    Public selindex As Integer
    Public rmindex As Integer
    Public konami

    Public Function cmdok(ByVal data As String) As Boolean
        Dim txt1 As String = "unknown"

        Dim re11 As String = "(unknown)"   'Word 1

        Dim r1 As Regex = New Regex(re11, RegexOptions.IgnoreCase Or RegexOptions.Singleline)
        Dim m1 As Match = r1.Match(data)
        If (m1.Success) Then
            Dim word1 = m1.Groups(1)
            Return False
        Else

            Dim txt As String = "can't find"

            Dim re1 As String = "(can)"   'Word 1
            Dim re2 As String = "(')" 'Any Single Character 1
            Dim re3 As String = "(t)" 'Variable Name 1
            Dim re4 As String = ".*?" 'Non-greedy match on filler
            Dim re5 As String = "(find)"  'Variable Name 2

            Dim r As Regex = New Regex(re1 + re2 + re3 + re4 + re5, RegexOptions.IgnoreCase Or RegexOptions.Singleline)
            Dim m As Match = r.Match(data)
            If (m.Success) Then
                Dim word1 = m.Groups(1)
                Dim c1 = m.Groups(2)
                Dim var1 = m.Groups(3)
                Dim var2 = m.Groups(4)
                Return False
            Else
                Return True
            End If
        End If
    End Function

    Public Function checksettings()
        Try

            My.Settings.Reload()
            If My.Settings.autorefresh = True Then
                refreshTmr.Interval = My.Settings.interval * 1000
                refreshTmr.Enabled = True
                refreshTmr.Start()
            Else
                refreshTmr.Enabled = False
                refreshTmr.Stop()
            End If

            If My.Settings.startup = True Then
                btnRefresh.PerformClick()
            End If
        Catch ex As Exception

        End Try
        Return Nothing
    End Function

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If AddServer.ShowDialog() = Windows.Forms.DialogResult.OK Then
            btnRefresh.PerformClick()
            AddServer.Dispose()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            ListView1.Enabled = True
            If My.Settings.servers Is Nothing Then
                MsgBox("No servers defined. Please add a server to the list. Auto refresh settings will be removed until you create a server.")
                My.Settings.autorefresh = False
                My.Settings.startup = False
                My.Settings.interval = 0
                checksettings()
                GoTo retry

            End If
            lblStatus.Text = "Refreshing..."
            My.Settings.Reload()
            Dim records
            Dim record
            Dim counter
            ListView1.Items.Clear()
            ListView2.Items.Clear()
            lstPlayers.Items.Clear()
            lstSvrInfo.Items.Clear()
            Array.Clear(playerinfo, 0, 899)
            Array.Clear(serverinfo, 0, 899)
            records = My.Settings.servers.Count
            ' IP = record 0 - Pass = record 1 - port = record 2 - server = record 3
            counter = 0
            While counter < records

                record = Split(My.Settings.servers(counter), "^")
                Dim server As New GameServer(record(0), record(2), GameType.Quake3, 500)
                Dim ping As New Stopwatch

                ping.Start()
                server.QueryServer()
                ping.Stop()


                Dim str(5) As String
                If server.IsOnline Then

                    str(0) = record(0) & ":" & record(2)
                    str(1) = GameServer.CleanName(server.Name)
                    str(2) = server.Map
                    str(3) = server.NumPlayers & " / " & server.MaxPlayers
                    str(4) = ping.ElapsedMilliseconds
                    ping.Reset()
                    Dim itm As ListViewItem
                    itm = New ListViewItem(str)
                    ListView1.Items.Add(itm)
                    Dim i As Integer

                    i = 0

                    If server.Players.Count = 0 Then

                    Else

                        While i < server.Players.Count


                            playerinfo(counter, i) = GameServer.CleanName(server.Players.Item(i).Name) & "`" & server.Players.Item(i).Ping & "`" & server.Players.Item(i).Score
                            i = i + 1

                        End While
                    End If

                    ' Now lets parse the server info vars..

                    Dim j As Integer
                    Dim serverstring
                    serverstring = ""

                    serverinfo(counter, 0) = server.version
                    serverinfo(counter, 1) = server.timelimit
                    serverinfo(counter, 2) = server.fraglimit
                    serverinfo(counter, 3) = server.admin
                    serverinfo(counter, 4) = server.antilag
                    serverinfo(counter, 5) = server.reward
                    serverinfo(counter, 6) = server.MaxPlayers

                    counter = counter + 1
                Else
                    str(0) = record(0) & ":" & record(2)
                    str(1) = record(3)
                    str(2) = "Server Offline"
                    str(3) = "0 / 0"
                    str(4) = "000"
                    ping.Reset()
                    Dim itm As ListViewItem
                    itm = New ListViewItem(str)
                    ListView2.Items.Add(itm)
                    counter = counter + 1
                End If

                Button2.Enabled = True
                Button3.Enabled = True
                Button6.Enabled = True

            End While

            lblStatus.Text = "Ready.."
        Catch ex As Exception

        End Try
retry:

    End Sub

    Private Sub ListView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseDown
        Try
            If Me.ListView1.SelectedIndices.Count <= 0 Then
                Return
            End If
            Dim selNdx = Me.ListView1.SelectedIndices(0)
            If selNdx >= 0 Then
                selindex = ListView1.Items(selNdx).Index
            End If

            If Me.ListView1.SelectedIndices.Count <= 0 Then
                Return
            Else
                If e.Button = MouseButtons.Right Then
                    svrCmdSend.Show(ListView1, e.Location)
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Try


            If Me.ListView1.SelectedIndices.Count <= 0 Then
                Return
            End If
            Dim selNdx = Me.ListView1.SelectedIndices(0)
            If selNdx >= 0 Then
                selindex = ListView1.Items(selNdx).Index
            End If

            Dim i As Integer
            Dim plr(3) As String
            Dim record
            lstPlayers.Items.Clear()

            Try
                For Each item As String In playerinfo(selindex, i)
                    record = Split(playerinfo(selindex, i), "`")
                    plr(0) = record(0)
                    plr(1) = record(2)
                    plr(2) = record(1)
                    Dim itm As ListViewItem
                    itm = New ListViewItem(plr)
                    lstPlayers.Items.Add(itm)
                    i = i + 1

                Next
            Catch ex As Exception

            End Try

            lstSvrInfo.Items.Clear()


            Dim key(2) As String

            'serverinfo(counter, 0) = server.version
            'serverinfo(counter, 1) = server.timelimit
            'serverinfo(counter, 2) = server.fraglimit
            'serverinfo(counter, 3) = server.admin
            'serverinfo(counter, 4) = server.antilag
            'serverinfo(counter, 5) = server.reward
            'serverinfo(counter, 6) = server.MaxPlayers
            Dim antilagged
            If serverinfo(selindex, 4) = "1" Then
                antilagged = "Yes"
            Else
                antilagged = "No"
            End If

            Dim keys As ListViewItem
            key(0) = "Version"
            key(1) = serverinfo(selindex, 0)
            keys = New ListViewItem(key)
            lstSvrInfo.Items.Add(keys)
            key(0) = "Timelimit"
            key(1) = serverinfo(selindex, 1)
            keys = New ListViewItem(key)
            lstSvrInfo.Items.Add(keys)
            key(0) = "Fraglimit"
            key(1) = serverinfo(selindex, 2)
            keys = New ListViewItem(key)
            lstSvrInfo.Items.Add(keys)
            key(0) = "Admin"
            key(1) = serverinfo(selindex, 3)
            keys = New ListViewItem(key)
            lstSvrInfo.Items.Add(keys)
            key(0) = "Antilagged"
            key(1) = antilagged
            keys = New ListViewItem(key)
            lstSvrInfo.Items.Add(keys)
            key(0) = "Rewards"
            key(1) = serverinfo(selindex, 5)
            keys = New ListViewItem(key)
            lstSvrInfo.Items.Add(keys)
            key(0) = "Max Players"
            key(1) = serverinfo(selindex, 6)
            keys = New ListViewItem(key)
            lstSvrInfo.Items.Add(keys)

        Catch ex As Exception

        End Try


    End Sub

    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim records
        Dim record
        Dim counter
        Try
            If My.Settings.servers.Count = Nothing Then
                MsgBox("You must add a server to continue.")
                If AddServer.ShowDialog() = vbCancel Then
                    MsgBox("You will not be able to access any program features until you add a server")
                    GoTo ending
                End If

            Else
                records = My.Settings.servers.Count
            End If
        Catch ex As Exception

        End Try
        Try


            records = My.Settings.servers.Count
            ' IP = record 0 - Pass = record 1 - port = record 2 - server = record 3
            counter = 0
            While counter < records

                record = Split(My.Settings.servers(counter), "^")

                Dim str(5) As String

                str(0) = record(0) & ":" & record(2)
                str(1) = record(3)
                str(2) = "Need Refresh"
                str(3) = "0 / 0"
                str(4) = "0"

                Dim itm As ListViewItem
                itm = New ListViewItem(str)
                ListView1.Items.Add(itm)
                counter = counter + 1

            End While
            checksettings()
        Catch ex As Exception

        End Try
ending:
    End Sub

    Private Sub MapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MapToolStripMenuItem.Click

    End Sub

    Private Sub MapToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MapToolStripMenuItem1.Click
        Try


            Dim input As String
            input = InputBox("Please enter the map name to change to", "Command Arguments")

            If input.Replace(" ", "") = "" Then
            Else
                Dim rcon As New Rcon.RCON
                Dim record
                record = Split(My.Settings.servers(selindex), "^")
                ' IP = record 0 - Pass = record 1 - port = record 2 - server = record 3
                Dim returned

                returned = rcon.sendCommand("map " & input, record(0), record(1), record(2))

                If cmdok(returned) Then
                    MsgBox("Map changed to " & input, MsgBoxStyle.Information, "Success")
                    btnRefresh.PerformClick()
                Else
                    MsgBox("Error. The server returned: " & returned, MsgBoxStyle.Exclamation, "Error")

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MapstartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MapstartToolStripMenuItem.Click
        Try
            Dim input As String
            input = InputBox("Please enter the map name to change to. This will reset scores aswell.", "Command Arguments")

            If input.Replace(" ", "") = "" Then
            Else
                Dim rcon As New Rcon.RCON
                Dim record
                record = Split(My.Settings.servers(selindex), "^")
                ' IP = record 0 - Pass = record 1 - port = record 2 - server = record 3
                Dim returned

                returned = rcon.sendCommand("startmap " & input, record(0), record(1), record(2))

                If cmdok(returned) Then
                    MsgBox("Map changed to " & input & " and restarted.", MsgBoxStyle.Information, "Success")
                    btnRefresh.PerformClick()
                Else
                    MsgBox("Error. The server returned: " & returned, MsgBoxStyle.Exclamation, "Error")

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub KickBanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KickBanToolStripMenuItem.Click
        kickban.ShowDialog()
        kickban.selindex = selindex

    End Sub

    Private Sub ServerInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServerInfoToolStripMenuItem.Click
        Try
            Dim rcon As New Rcon.RCON
            Dim record
            record = Split(My.Settings.servers(selindex), "^")
            ' IP = record 0 - Pass = record 1 - port = record 2 - server = record 3
            Dim returned

            returned = rcon.sendCommand("serverinfo", record(0), record(1), record(2))

            RconStatus.cmdtext = returned
            RconStatus.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnToolStripMenuItem.Click
        Try
            Dim rcon As New Rcon.RCON
            Dim record
            record = Split(My.Settings.servers(selindex), "^")
            ' IP = record 0 - Pass = record 1 - port = record 2 - server = record 3
            Dim returned

            returned = rcon.sendCommand("set g_antilag 1", record(0), record(1), record(2))

            If cmdok(returned) Then
                MsgBox("Command executed successfully.", MsgBoxStyle.Information, "Success")
                btnRefresh.PerformClick()
            Else
                MsgBox("Error. The server returned: " & returned, MsgBoxStyle.Exclamation, "Error.")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OffToolStripMenuItem.Click
        Try
            Dim rcon As New Rcon.RCON
            Dim record
            record = Split(My.Settings.servers(selindex), "^")
            ' IP = record 0 - Pass = record 1 - port = record 2 - server = record 3
            Dim returned

            returned = rcon.sendCommand("set g_antilag 0", record(0), record(1), record(2))

            If cmdok(returned) Then
                MsgBox("Command executed successfully.", MsgBoxStyle.Information, "Success")
                btnRefresh.PerformClick()
            Else
                MsgBox("Error. The server returned: " & returned, MsgBoxStyle.Exclamation, "Error.")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SayToolStripMenuItem.Click
        Try
            Dim input As String
            input = InputBox("Please enter the message to say", "Command Arguments")

            If input.Replace(" ", "") = "" Then
            Else
                Dim rcon As New Rcon.RCON
                Dim record
                record = Split(My.Settings.servers(selindex), "^")
                ' IP = record 0 - Pass = record 1 - port = record 2 - server = record 3
                Dim returned

                returned = rcon.sendCommand("say " & input, record(0), record(1), record(2))

                If cmdok(returned) Then
                    MsgBox("Command executed successfully.", MsgBoxStyle.Information, "Success")
                Else
                    MsgBox("Error. The server returned: " & returned, MsgBoxStyle.Exclamation, "Error.")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OnToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnToolStripMenuItem1.Click
        Try
            Dim rcon As New Rcon.RCON
            Dim record
            record = Split(My.Settings.servers(selindex), "^")
            ' IP = record 0 - Pass = record 1 - port = record 2 - server = record 3
            Dim returned

            returned = rcon.sendCommand("set g_callvote 1", record(0), record(1), record(2))

            If cmdok(returned) Then
                MsgBox("Command executed successfully.", MsgBoxStyle.Information, "Success")
                btnRefresh.PerformClick()
            Else
                MsgBox("Error. The server returned: " & returned, MsgBoxStyle.Exclamation, "Error.")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OffToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OffToolStripMenuItem1.Click
        Try
            Dim rcon As New Rcon.RCON
            Dim record
            record = Split(My.Settings.servers(selindex), "^")
            ' IP = record 0 - Pass = record 1 - port = record 2 - server = record 3
            Dim returned

            returned = rcon.sendCommand("set g_callvote 0", record(0), record(1), record(2))

            If cmdok(returned) Then
                MsgBox("Command executed successfully.", MsgBoxStyle.Information, "Success")
                btnRefresh.PerformClick()
            Else
                MsgBox("Error. The server returned: " & returned, MsgBoxStyle.Exclamation, "Error.")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CustomCommandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomCommandToolStripMenuItem.Click
        custcmd.selindex = selindex
        custcmd.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If settings.ShowDialog() = vbOK Then
            checksettings()
        End If
    End Sub

    Private Sub refreshTmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreshTmr.Tick
        btnRefresh.PerformClick()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim response
            Dim record
            record = Split(My.Settings.servers(selindex), "^")
            response = MsgBox("Are you sure you want to remove " & record(3) & "?", MsgBoxStyle.YesNo, "Confirm")

            If response = vbYes Then
                ListView1.Items.RemoveAt(selindex)
                My.Settings.servers.RemoveAt(selindex)
                My.Settings.Save()
                btnRefresh.PerformClick()
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub StatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusToolStripMenuItem.Click
        Try
            Dim rcon As New Rcon.RCON
            Dim record
            record = Split(My.Settings.servers(selindex), "^")
            ' IP = record 0 - Pass = record 1 - port = record 2 - server = record 3
            Dim returned

            returned = rcon.sendCommand("status", record(0), record(1), record(2))

            RconStatus.cmdtext = returned
            RconStatus.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UnbanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnbanToolStripMenuItem.Click
        UnBan.ShowDialog()
        UnBan.selindex = selindex
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub ListView2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView2.MouseDown
        Try
            If Me.ListView2.SelectedIndices.Count <= 0 Then
                Return
            End If
            Dim selNdx2 = Me.ListView2.SelectedIndices(0)
            If selNdx2 >= 0 Then
                rmindex = ListView2.Items(selNdx2).Index
            End If

            If Me.ListView2.SelectedIndices.Count <= 0 Then
                Return
            Else
                If e.Button = MouseButtons.Right Then
                    svrRemove.Show(ListView2, e.Location)
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListView2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView2.SelectedIndexChanged
        If Me.ListView2.SelectedIndices.Count <= 0 Then
            Return
        End If
        Dim selNdx2 = Me.ListView2.SelectedIndices(0)
        If selNdx2 >= 0 Then
            rmindex = ListView2.Items(selNdx2).Index
        End If
    End Sub

    

    Private Sub RemoveThisServerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveThisServerToolStripMenuItem.Click
        Dim response1
        Dim record1
        Dim count

        count = My.Settings.servers.Count

        Dim i
        i = 0
        While i < count

            If My.Settings.servers(i).Contains(ListView2.FocusedItem.SubItems(1).Text) Then
                record1 = Split(My.Settings.servers(i), "^")

                GoTo remover
            Else
            End If
            i = i + 1
        End While
remover:
        response1 = MsgBox("Are you sure you want to remove " & record1(3) & "?", MsgBoxStyle.YesNo, "Confirm")

        If response1 = vbYes Then
            ListView2.Items.RemoveAt(rmindex)
            My.Settings.servers.RemoveAt(i)
            My.Settings.Save()
            btnRefresh.PerformClick()
        Else
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        BroadcastMessage.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        banlists.ShowDialog()
    End Sub

    Private Sub ViewBanlistToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewBanlistToolStripMenuItem.Click
        Try
            Dim rcon As New Rcon.RCON
            Dim record
            record = Split(My.Settings.servers(selindex), "^")
            ' IP = record 0 - Pass = record 1 - port = record 2 - server = record 3
            Dim returned

            returned = rcon.sendCommand("sv listip", record(0), record(1), record(2))

            RconStatus.cmdtext = returned
            RconStatus.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Panel1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.DoubleClick
        MsgBox("[VP]Xenos is just about as gay as they come! - [VP]Cheney 4th March 2010", MsgBoxStyle.Critical)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
