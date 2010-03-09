Imports System.Windows.Forms

Public Class settings

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            If chkStart.Checked Then
                My.Settings.startup = True
            Else
                My.Settings.startup = False
            End If

            If chkAuto.Checked Then
                My.Settings.autorefresh = True
                My.Settings.interval = numMin.Value * 60
            Else
                My.Settings.autorefresh = False
                My.Settings.interval = 0
            End If

            My.Settings.Save()
            My.Settings.Reload()
        Catch ex As Exception
            MsgBox("Unhandled exception: " & ex.ToString)
        End Try
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.servers Is Nothing Then
            MsgBox("Settings can not load as you do not have any servers defined. Please add a server and try again.")
            Me.Close()
        End If
        If My.Settings.startup = True Then
            chkStart.Checked = True
        Else
            chkStart.Checked = False
        End If

        If My.Settings.autorefresh = True Then
            chkAuto.Checked = True
            numMin.Enabled = True
        Else
            chkAuto.Checked = False
            numMin.Enabled = False
        End If

    End Sub

    Private Sub chkAuto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAuto.CheckedChanged
        If chkStart.Checked Then
            If My.Settings.servers Is Nothing Then
                MsgBox("You must add a server to enable this option")
                chkStart.Checked = False
                GoTo ending
            End If
        Else

        End If
        If chkAuto.Checked Then
            numMin.Enabled = True
        Else
            numMin.Enabled = False
        End If
ending:

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try


            Dim result

            result = MsgBox("Please note that this will remove all servers from your management list, as well as the settings above. This process is irreversible. Do you wish to continue?", MsgBoxStyle.YesNo, "Confirm..")

            If result = vbYes Then
                My.Settings.servers.Clear()
                My.Settings.startup = False
                My.Settings.autorefresh = False
                My.Settings.interval = 0
                My.Settings.Save()
                My.Settings.Reload()
                Form1.checksettings()
                Form1.btnRefresh.PerformClick()
                Me.Close()
            Else

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub chkStart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStart.CheckedChanged
        If chkStart.Checked Then
            If My.Settings.servers Is Nothing Then
                MsgBox("You must add a server to enable this option")
                chkStart.Checked = False
            End If
        Else

        End If
    End Sub
End Class
