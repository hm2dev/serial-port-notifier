Imports System.Windows.Forms

Public Class CustomPortNameDialog

    Public PortName As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub CustomPortNameDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInstructions.Text = String.Format(lblInstructions.Text, PortName)
    End Sub
End Class
