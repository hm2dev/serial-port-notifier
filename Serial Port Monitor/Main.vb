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

Module Main
    Dim SerialPorts As New List(Of String)

    Dim WithEvents SerialMonitor As Timer
    Dim WithEvents TrayIcon As NotifyIcon
    Dim RightClickMenu As ContextMenuStrip

    Dim LauncherXMLSerializer As New Xml.Serialization.XmlSerializer(GetType(List(Of Launcher)))
    Dim ProgramLaunchers As New List(Of Launcher)

    Public Sub Main()
        Application.EnableVisualStyles()

        'Create the SerialMonitor timer
        SerialMonitor = New Timer
        With SerialMonitor
            .Interval = 500
            .Enabled = True
        End With

        'Create the tray icon
        RightClickMenu = New ContextMenuStrip

        TrayIcon = New NotifyIcon

        With TrayIcon
            .ContextMenuStrip = RightClickMenu
            .Icon = My.Resources.Logo
            .Visible = True
            .Text = "Serial Port Monitor"
        End With

        'Load the launchers
        If My.Settings.Launchers <> "" Then
            Try
                ProgramLaunchers = LauncherXMLSerializer.Deserialize(New IO.StringReader(My.Settings.Launchers))
            Catch ex As Exception
                MessageBox.Show("Failed to load program launchers, error parsing settings: " + ex.ToString, "Settings", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If

        SerialPorts = New List(Of String)(My.Computer.Ports.SerialPortNames)
        BuildMenu()

        Application.Run()

        TrayIcon.Visible = False
    End Sub

    Private Sub SerialMonitor_Tick(sender As Object, e As EventArgs) Handles SerialMonitor.Tick
        'Get a list of the ports currently connected
        Dim CurrentPorts = My.Computer.Ports.SerialPortNames

        'Determine the new ports
        Dim NewPorts = (From port In CurrentPorts
                        Where Not SerialPorts.Contains(port)).ToList

        'Determine the removed ports
        Dim RemovedPorts = (From port In SerialPorts
                            Where Not CurrentPorts.Contains(port)).ToList

        'Generate the notification bubble listing the changes
        Dim BalloonText As String = ""

        If NewPorts.Count > 0 Then
            BalloonText = String.Format("New Serial Ports: {0}", String.Join(",", NewPorts))
        End If

        If RemovedPorts.Count > 0 Then
            'Add a new line if there's already some balloon text from a port being added:
            If BalloonText.Length > 0 Then
                BalloonText &= vbNewLine
            End If

            BalloonText &= String.Format("Serial Ports Removed: {0}", String.Join(",", RemovedPorts))
        End If

        'See if we need to show the notification
        If BalloonText.Length > 0 Then
            TrayIcon.BalloonTipText = BalloonText
            TrayIcon.ShowBalloonTip(3000)
        End If

        'Update the serial ports list - make sure to maintain the order of the ports
        'First get rid of the removed ports
        For Each RemovedPort In RemovedPorts
            SerialPorts.Remove(RemovedPort)
        Next

        'Now add the new ports
        SerialPorts.AddRange(NewPorts)

        If NewPorts.Count > 0 OrElse RemovedPorts.Count > 0 Then
            'There's been a change to the number of ports, so update the right click menu
            BuildMenu()
        End If
    End Sub

    Sub BuildMenu()
        With RightClickMenu.Items
            .Clear()
            .Add("Serial Ports (newest first):")
            .Add("-")
            'Now add the serial ports in reverse order, with the newest ones first.
            If SerialPorts.Count > 0 Then
                For i As Integer = SerialPorts.Count - 1 To 0 Step -1
                    Dim port = New ToolStripMenuItem(SerialPorts(i))
                    .Add(port)
                    'Now add the launchers
                    If ProgramLaunchers.Count > 0 Then
                        For Each l In ProgramLaunchers
                            Dim portName As String = SerialPorts(i)
                            port.DropDownItems.Add(l.Label, Nothing, New EventHandler(Sub()
                                                                                          l.Launch(portName)
                                                                                      End Sub))
                        Next
                    Else
                        port.DropDownItems.Add("No launchers")
                    End If
                Next
            Else
                .Add("None")
            End If
            .Add("-")
            .Add("Settings", Nothing, New EventHandler(AddressOf SettingsMenu_Click))
            .Add("About", Nothing, New EventHandler(AddressOf AboutMenu_Click))
            .Add("Exit", Nothing, New EventHandler(AddressOf ExitMenu_Click))
        End With

    End Sub

    Private Sub SettingsMenu_Click(sender As Object, e As EventArgs)
        Dim Settings As New SettingsForm
        Settings.Launchers = CopyLauncherList(ProgramLaunchers)
        If Settings.ShowDialog() = DialogResult.OK Then
            ProgramLaunchers = Settings.Launchers
            Dim StringWriter As New IO.StringWriter()
            LauncherXMLSerializer.Serialize(StringWriter, ProgramLaunchers)
            My.Settings.Launchers = StringWriter.ToString
            My.Settings.Save()
            BuildMenu()
        End If
        Settings.Dispose()
    End Sub

    Private Sub AboutMenu_Click(sender As Object, e As EventArgs)
        AboutBox.Show()
    End Sub

    Private Sub ExitMenu_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Function CopyLauncherList(list As List(Of Launcher)) As List(Of Launcher)
        Dim outputStream As New IO.StringWriter
        LauncherXMLSerializer.Serialize(outputStream, list)
        Dim inputStream As New IO.StringReader(outputStream.ToString)
        Return LauncherXMLSerializer.Deserialize(inputStream)
    End Function
End Module
