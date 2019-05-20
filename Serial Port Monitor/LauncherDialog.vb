' Copyright(c) 2019 Amr Bekhit
' https://helmpcb.com/software/serial-port-monitor
'
' Permission Is hereby granted, free Of charge, to any person obtaining a copy of this 'software And associated documentation files (the "Software"), 
' to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
' And/Or sell copies of the Software, And to permit persons to whom the Software Is furnished to do so, subject to the following conditions:
'
' The above copyright notice And this permission notice shall be included In all copies Or substantial portions Of the Software.
'
' THE SOFTWARE Is PROVIDED "AS IS", WITHOUT WARRANTY Of ANY KIND, EXPRESS Or IMPLIED, INCLUDING BUT Not LIMITED To THE WARRANTIES Of MERCHANTABILITY,
' FITNESS For A PARTICULAR PURPOSE And NONINFRINGEMENT. In NO Event SHALL THE AUTHORS Or COPYRIGHT HOLDERS BE LIABLE For ANY CLAIM, DAMAGES Or OTHER LIABILITY,
' WHETHER In AN ACTION Of CONTRACT, TORT Or OTHERWISE, ARISING FROM, OUT Of Or In CONNECTION With THE SOFTWARE Or THE USE Or OTHER DEALINGS In THE SOFTWARE.

Imports System.IO

Public Class LauncherDialog

    Public Launcher As Launcher

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'Validate the form
        If txtLauncherLabel.Text.Trim = "" Then
            MessageBox.Show("Please enter a label", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If txtLauncherProgram.Text.Trim = "" Then
            MessageBox.Show("Please enter a program to launch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Launcher = New Launcher(txtLauncherLabel.Text, txtLauncherProgram.Text, txtLauncherCommandLine.Text)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            txtLauncherProgram.Text = OpenFileDialog.FileName
        End If
    End Sub

    Private Sub UpdatePreview(sender As Object, e As EventArgs) Handles txtLauncherProgram.TextChanged, txtLauncherCommandLine.TextChanged
        Try
            Dim launcher As New Launcher("", txtLauncherProgram.Text, txtLauncherCommandLine.Text)
            lblPreview.Text = String.Format("Preview: {0} {1}", Path.GetFileName(launcher.Executable), launcher.GetCommandLine("COM15"))
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Clear()
        txtLauncherLabel.Text = ""
        txtLauncherProgram.Text = ""
        txtLauncherCommandLine.Text = ""
    End Sub

    Public Sub SetLauncher(l As Launcher)
        txtLauncherLabel.Text = l.Label
        txtLauncherProgram.Text = l.Executable
        txtLauncherCommandLine.Text = l.CommandLine
    End Sub
End Class
