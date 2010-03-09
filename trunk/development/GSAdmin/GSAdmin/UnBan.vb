Imports System.Windows.Forms
Imports System.Net

Public Class UnBan
    Public selindex

    Public Function IsAddressValid(ByVal addrString As String) As Boolean
        Dim address As IPAddress
        Return IPAddress.TryParse(addrString, address)
    End Function

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub UnBan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim record
        record = Split(My.Settings.servers(selindex), "^")
        Label1.Text = "Server: " & record(3)
        Dim rcon As New Rcon.RCON
        Dim returned
        returned = rcon.sendCommand("sv listip", record(0), record(1), record(2))
        TextBox1.Text = returned
    End Sub

    Private Sub OK_Button_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If TextBox3.Text = "" Then
            MsgBox("You must enter an IP address to remove, or click close.", MsgBoxStyle.Exclamation, "Error.")
            GoTo retry
        Else
            If IsAddressValid(TextBox3.Text) = True Then
                Dim record
                record = Split(My.Settings.servers(selindex), "^")
                Dim rcon As New Rcon.RCON
                Dim returned
                returned = rcon.sendCommand("sv removeip " & TextBox3.Text, record(0), record(1), record(2))
                TextBox1.AppendText(returned)
                returned = rcon.sendCommand("sv writeip", record(0), record(1), record(2))
                TextBox1.AppendText(returned)
                returned = rcon.sendCommand("sv listip", record(0), record(1), record(2))
                TextBox1.AppendText(returned)
            Else
                MsgBox("IP Address is not valid! Please try again")
                GoTo retry

            End If
            
        End If


retry:

    End Sub

End Class
