Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Imports System.Net

Public Class kickban
    Public selindex As Integer

    Public Function IsAddressValid(ByVal addrString As String) As Boolean
        Dim address As IPAddress
        Return IPAddress.TryParse(addrString, address)
    End Function


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If TextBox2.Text = "" Then
            MsgBox("You must enter a number of the player to kick, or click close", MsgBoxStyle.Exclamation, "Error")
            GoTo retry
        End If

        If CheckBox1.Checked Then
            If TextBox3.Text = "" Then
                MsgBox("You must enter an IP address to enforce the ban.")
                GoTo retry
            Else
                If IsAddressValid(TextBox3.Text) = False Then
                    MsgBox("IP Address not valid. Please try again")
                    GoTo retry
                Else
                    GoTo kicker
                End If
            End If
        End If

kicker:
        Dim record
        record = Split(My.Settings.servers(selindex), "^")
        Label1.Text = "Server: " & record(3)
        Dim rcon As New Rcon.RCON
        Dim returned
        If CheckBox1.Checked Then
            returned = rcon.sendCommand("kick " & TextBox2.Text, record(0), record(1), record(2))
            TextBox1.AppendText(returned)
            returned = rcon.sendCommand("sv addip " & TextBox3.Text, record(0), record(1), record(2))
            TextBox1.AppendText(returned)
            returned = rcon.sendCommand("sv writeip", record(0), record(1), record(2))
            TextBox1.AppendText(returned)
            returned = rcon.sendCommand("exec listip.cfg", record(0), record(1), record(2))
            TextBox1.AppendText(returned)
            returned = rcon.sendCommand("sv listip", record(0), record(1), record(2))
            TextBox1.AppendText(returned)
        Else
            returned = rcon.sendCommand("kick " & TextBox2.Text, record(0), record(1), record(2))
            TextBox1.AppendText(returned)
        End If

        Dim response
        response = MsgBox("Kick another?", MsgBoxStyle.YesNo, "Question.")

        If response = vbYes Then
            TextBox2.Clear()
            returned = rcon.sendCommand("status", record(0), record(1), record(2))
            CheckBox1.Checked = False
            TextBox3.Clear()
            TextBox1.AppendText(returned)
        Else
            Me.Close()
            Me.Dispose()
        End If

retry:

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SendCmd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim record
        record = Split(My.Settings.servers(selindex), "^")
        Label1.Text = "Server: " & record(3)
        Dim input As String
        Dim rcon As New Rcon.RCON

        ' IP = record 0 - Pass = record 1 - port = record 2 - server = record 3
        Dim returned
        'Dim myregex As Regex
        'myregex = New Regex("/\^[0-9]+(?:\.[0-9]*)?/gix")

        returned = rcon.sendCommand("status", record(0), record(1), record(2))
        'returned = returned.Regex.Replace(returned, myregex, "")
        TextBox1.Text = returned
        Dim numlines
        Dim lines As Array
        lines = Split(returned, vbCrLf)
        numlines = lines.Length

        ' First 3 lines are printinfo. 0-3

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Label3.Visible = True
            TextBox3.Visible = True
        Else
            Label3.Visible = False
            TextBox3.Visible = False
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True

        End If

        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then

            e.Handled = False

        End If
    End Sub
End Class
