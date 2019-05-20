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

Public Class SettingsForm

    Public Launchers As List(Of Launcher)

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Sub PopulateLauncherList()
        lstLaunchers.Items.Clear()
        lstLaunchers.Items.AddRange(Launchers.ToArray)
    End Sub


    Private Sub btnNewLauncher_Click(sender As Object, e As EventArgs) Handles btnNewLauncher.Click
        Dim Dialog = New LauncherDialog
        Dialog.Text = "New Launcher"
        If Dialog.ShowDialog() = DialogResult.OK Then
            'Create a new launcher
            Dim launcher = Dialog.Launcher
            Launchers.Add(launcher)

            PopulateLauncherList()
        End If
        Dialog.Dispose()
        lstLaunchers_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        PopulateLauncherList()
    End Sub

    Private Sub btnEditLauncher_Click(sender As Object, e As EventArgs) Handles btnEditLauncher.Click
        Dim launcher As Launcher = lstLaunchers.SelectedItem
        Dim Dialog = New LauncherDialog
        Dialog.Text = "Edit Launcher"
        Dialog.SetLauncher(launcher)
        If Dialog.ShowDialog() = DialogResult.OK Then
            launcher = Dialog.Launcher
            Launchers(lstLaunchers.SelectedIndex) = launcher
        End If

        PopulateLauncherList()
        Dialog.Dispose()
        lstLaunchers_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub btnDeleteLauncher_Click(sender As Object, e As EventArgs) Handles btnDeleteLauncher.Click
        Dim launcher As Launcher = lstLaunchers.SelectedItem
        If MessageBox.Show(String.Format("Are you sure you want to delete launcher '{0}'?", launcher.Label),
                           "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Launchers.RemoveAt(lstLaunchers.SelectedIndex)
            PopulateLauncherList()
            lstLaunchers_SelectedIndexChanged(sender, e)
        End If
    End Sub

    Sub SwapItems(Of T)(l As List(Of T), index1 As Integer, index2 As Integer)
        Dim temp As T = l(index1)
        l(index1) = l(index2)
        l(index2) = temp
    End Sub

    Private Sub btnMoveUp_Click(sender As Object, e As EventArgs) Handles btnMoveUp.Click
        If lstLaunchers.SelectedIndex > 0 Then
            Dim index = lstLaunchers.SelectedIndex
            SwapItems(Launchers, index, index - 1)

            PopulateLauncherList()

            lstLaunchers.SelectedIndex = index - 1
        End If
    End Sub

    Private Sub btnMoveDown_Click(sender As Object, e As EventArgs) Handles btnMoveDown.Click
        If lstLaunchers.SelectedIndex < lstLaunchers.Items.Count - 1 Then
            Dim index = lstLaunchers.SelectedIndex
            SwapItems(Launchers, index, index + 1)

            PopulateLauncherList()

            lstLaunchers.SelectedIndex = index + 1
        End If
    End Sub

    Private Sub lstLaunchers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstLaunchers.SelectedIndexChanged
        Dim Enable As Boolean = False
        If lstLaunchers.SelectedIndex >= 0 Then
            Enable = True
        End If

        btnEditLauncher.Enabled = Enable
        btnDeleteLauncher.Enabled = Enable
        btnMoveUp.Enabled = Enable
        btnMoveDown.Enabled = Enable
    End Sub

    Private Sub lstLaunchers_DoubleClick(sender As Object, e As EventArgs) Handles lstLaunchers.DoubleClick
        If lstLaunchers.SelectedIndex >= 0 Then
            btnEditLauncher_Click(sender, e)
        End If
    End Sub
End Class
