Imports System.Windows.Forms
Imports Rcon

Public Class custcmd

    Public selindex

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()


    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()


    End Sub

    Private Sub custcmd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim record
        record = Split(My.Settings.servers(selindex), "^")
        Label1.Text = "Server: " & record(3)
        TextBox2.Clear()
        TextBox1.Clear()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim record
        record = Split(My.Settings.servers(selindex), "^")

        Dim rcon As New Rcon.RCON

        ' IP = record 0 - Pass = record 1 - port = record 2 - server = record 3
        Dim returned
        'Dim myregex As Regex
        'myregex = New Regex("/\^[0-9]+(?:\.[0-9]*)?/gix")
        Dim mycmd

        mycmd = ""
        mycmd = TextBox1.Text
        returned = rcon.sendCommand(mycmd, record(0), record(1), record(2))

        TextBox2.AppendText(Replace(returned, "\n", vbCrLf))
        TextBox1.Text = ""
        TextBox1.Focus()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
