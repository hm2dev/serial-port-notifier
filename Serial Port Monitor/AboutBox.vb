Public NotInheritable Class AboutBox

    Private Sub AboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = My.Application.Info.Description
        'Me.lblURL.Text = "<a href=www.google.com>Hello</a>" '"<a>http://www.helmpcb.com/software/serial-port-monitor</a>" & vbNewLine & vbNewLine &
        '"Icons from the <a href=""http://www.iconarchive.com/show/farm-fresh-icons-by-fatcow.html"">Farm Fresh Icon pack</a>"

        'Me.URLLabel.Link
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub URLLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles URLLabel.LinkClicked
        Process.Start(URLLabel.Text)
    End Sub
End Class
