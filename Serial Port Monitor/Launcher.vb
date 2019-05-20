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

<Serializable>
Public Class Launcher
    Public Label As String
    Public Executable As String
    Public CommandLine As String

    Sub New()

    End Sub

    Sub New(label As String, executable As String, commandline As String)
        Me.Label = label
        Me.Executable = executable
        Me.CommandLine = commandline
    End Sub

    Public Sub Launch(serialPort As String)
        Try
            Process.Start(Executable, GetCommandLine(serialPort))
        Catch ex As Exception
            MessageBox.Show(String.Format("Failed to start launcher: {0}", ex.Message), "Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetCommandLine(serialPort As String) As String
        Return CommandLine.Replace("%1", serialPort).Replace("%2", GetPortNumber(serialPort))
    End Function

    Public Function GetPortNumber(serialPort As String) As Integer
        ' Get rid of the first 3 letters (COM)
        Return serialPort.Substring(3)
    End Function

    Public Overrides Function ToString() As String
        Dim CommandLine As String = GetCommandLine("COM15")
        Return String.Format("{0} ({1}{2})", Label, Path.GetFileName(Executable), IIf(CommandLine = "", "", " " + CommandLine))
    End Function
End Class
