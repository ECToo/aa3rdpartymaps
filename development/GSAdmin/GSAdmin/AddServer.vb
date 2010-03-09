Imports System.Windows.Forms
Imports GameServerInfo
Imports Rcon
Imports System.Net


Public Class AddServer

    Public Function IsAddressValid(ByVal addrString As String) As Boolean
        Dim address As IPAddress
        Return IPAddress.TryParse(addrString, address)
    End Function

    Private Sub AddServer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Me.DialogResult = System.Windows.Forms.DialogResult.OK

            Dim server
            server = txtIP.Text & "^" & txtPass1.Text & "^" & txtPort.Text & "^" & GameServer.CleanName(txtServerName.Text)


            If My.Settings.servers Is Nothing Then
                My.Settings.servers = New Specialized.StringCollection
            End If

            My.Settings.servers.Add(server.ToString)

            My.Settings.Save()
            Me.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click

        If txtIP.Text = "" Or txtPort.Text = "" Then
            MsgBox("You must enter a server IP and port number", MsgBoxStyle.Exclamation, "Error.")
            GoTo retry

        Else
            If IsAddressValid(txtIP.Text) = False Then
                MsgBox("IP must be a valid IPv4 address. Please try again", MsgBoxStyle.Exclamation, "Error.")
                GoTo retry
            End If
        End If

        Try
            Dim port As Integer
            port = txtPort.Text
            Dim records
            Dim counter
            Dim record
            If My.Settings.servers Is Nothing Then
                GoTo addnew
            Else

            End If
            records = My.Settings.servers.Count
            ' IP = record 0 - Pass = record 1 - port = record 2 - server = record 3
            counter = 0

            If records > 0 Then
                While counter < records
                    record = Split(My.Settings.servers(counter), "^")

                    If record(0) = txtIP.Text And record(2) = txtPort.Text Then
                        MsgBox("This server already exists in the database")
                        GoTo retry
                    End If
                    counter = counter + 1

                End While
            End If
addnew:
            Dim gameserver As New GameServer(txtIP.Text, port, GameType.Quake3)
            gameserver.QueryServer()
            txtServerName.Text = gameserver.CleanName(gameserver.Name)

            If gameserver.IsOnline Then
                txtIP.Enabled = False
                txtPort.Enabled = False
                btnQuery.Enabled = False
                txtPass1.Enabled = True
                txtPass2.Enabled = True
                btnTest.Enabled = True

            End If
        Catch ex As Exception

        End Try

retry:
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        Try

       
            If txtPass1.Text = txtPass2.Text Then
                Dim rcon As New Rcon.RCON
                Dim returned As String
                Dim port As Integer
                Dim parsereturned
                port = txtPort.Text
                returned = rcon.sendCommand("print", txtIP.Text, txtPass1.Text, port)
                parsereturned = Split(returned, "print")

                Dim search As String = parsereturned(1).ToString
                If search.Contains("rcon_password.") Then


                    MsgBox("RCON Password Incorrect. Please try again")
                Else
                    MsgBox("Authenticated successfully")
                    btnAdd.Enabled = True
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPort_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPort.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True

        End If

        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then

            e.Handled = False

        End If
    End Sub

    Private Sub txtPort_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPort.TextChanged

    End Sub

    Private Sub txtIP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIP.TextChanged

    End Sub
End Class
