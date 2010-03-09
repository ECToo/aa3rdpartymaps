Imports System.Windows.Forms

Public Class banlists

    Private Sub banlists_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Clear()
        Dim i
        i = 0
        Dim response
        While i < My.Settings.servers.Count
            Dim records = My.Settings.servers(i)
            Dim rcon As New Rcon.RCON
            Dim record = Split(My.Settings.servers(i), "^")
            TextBox1.AppendText("Server: " & record(3) & vbCrLf)
            TextBox1.AppendText(rcon.sendCommand("sv listip", record(0), record(1), record(2)))
            TextBox1.AppendText(vbCrLf)

            i = i + 1
        End While
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.Close()
    End Sub
End Class
