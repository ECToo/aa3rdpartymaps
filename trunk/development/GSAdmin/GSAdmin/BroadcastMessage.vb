Imports System.Windows.Forms
Imports GameServerInfo
Imports Rcon

Public Class BroadcastMessage

    Public serverinfo As New Collection

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try


            If chkList.CheckedItems.Count = 0 Then
                MsgBox("You must select a server to send a message to. Or click close")
                GoTo retry
            End If
            Dim response As String
            Dim i = 0
            Dim s = 0
            For Each item In chkList.CheckedItems
                While i < My.Settings.servers.Count
                    Dim records = My.Settings.servers(i)
                    If records.Contains(item) Then
                        Dim rcon As New Rcon.RCON
                        Dim record = Split(My.Settings.servers(i), "^")
                        response = rcon.sendCommand("say " & TextBox1.Text, record(0), record(1), record(2))
                        s = s + 1
                        GoTo nexty
                    End If

                    i = i + 1

                End While

nexty:
            Next item
            If response.Contains("print") Then
                MsgBox("Message successfully broadcast to " & s & " servers.")
            End If
        Catch ex As Exception

        End Try
retry:

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        chkList.Items.Clear()
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BroadcastMessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim counter
            Dim records
            Dim record
            Dim password
            records = My.Settings.servers.Count
            counter = 0
            chkList.Items.Clear()

            While counter < records

                record = Split(My.Settings.servers(counter), "^")
                Dim server As New GameServer(record(0), record(2), GameType.Quake3, 500)
                Dim serverstring
                server.QueryServer()
                If server.IsOnline Then
                    If My.Settings.servers(counter).Contains(GameServer.CleanName(server.Name)) Then
                        password = Split(My.Settings.servers(counter), "^")
                    End If
                    chkList.Items.Add(GameServer.CleanName(server.Name))
                    serverstring = record(0) & "^" & record(2) & "^" & password(1)

                Else
                End If

                counter = counter + 1
            End While

        Catch ex As Exception

        End Try

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            For i = 0 To chkList.Items.Count - 1
                chkList.SetItemChecked(i, True)
            Next i
            OK_Button.Enabled = True

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            For i = 0 To chkList.Items.Count - 1
                chkList.SetItemChecked(i, False)
            Next i
            OK_Button.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkList_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles chkList.MouseUp
        If chkList.CheckedItems.Count = 0 Then
            OK_Button.Enabled = False
        Else
            OK_Button.Enabled = True
        End If
    End Sub
End Class
