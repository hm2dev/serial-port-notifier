<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDuplicateLauncher = New System.Windows.Forms.Button()
        Me.btnDeleteLauncher = New System.Windows.Forms.Button()
        Me.btnMoveDown = New System.Windows.Forms.Button()
        Me.btnMoveUp = New System.Windows.Forms.Button()
        Me.btnEditLauncher = New System.Windows.Forms.Button()
        Me.btnNewLauncher = New System.Windows.Forms.Button()
        Me.lstLaunchers = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkShowNotification = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(363, 341)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnDuplicateLauncher)
        Me.GroupBox2.Controls.Add(Me.btnDeleteLauncher)
        Me.GroupBox2.Controls.Add(Me.btnMoveDown)
        Me.GroupBox2.Controls.Add(Me.btnMoveUp)
        Me.GroupBox2.Controls.Add(Me.btnEditLauncher)
        Me.GroupBox2.Controls.Add(Me.btnNewLauncher)
        Me.GroupBox2.Controls.Add(Me.lstLaunchers)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 103)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(497, 230)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Launchers"
        '
        'btnDuplicateLauncher
        '
        Me.btnDuplicateLauncher.Enabled = False
        Me.btnDuplicateLauncher.Location = New System.Drawing.Point(252, 198)
        Me.btnDuplicateLauncher.Name = "btnDuplicateLauncher"
        Me.btnDuplicateLauncher.Size = New System.Drawing.Size(75, 23)
        Me.btnDuplicateLauncher.TabIndex = 12
        Me.btnDuplicateLauncher.Text = "Duplicate"
        Me.btnDuplicateLauncher.UseVisualStyleBackColor = True
        '
        'btnDeleteLauncher
        '
        Me.btnDeleteLauncher.Enabled = False
        Me.btnDeleteLauncher.Location = New System.Drawing.Point(171, 198)
        Me.btnDeleteLauncher.Name = "btnDeleteLauncher"
        Me.btnDeleteLauncher.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteLauncher.TabIndex = 11
        Me.btnDeleteLauncher.Text = "Delete..."
        Me.btnDeleteLauncher.UseVisualStyleBackColor = True
        '
        'btnMoveDown
        '
        Me.btnMoveDown.Enabled = False
        Me.btnMoveDown.Location = New System.Drawing.Point(414, 198)
        Me.btnMoveDown.Name = "btnMoveDown"
        Me.btnMoveDown.Size = New System.Drawing.Size(75, 23)
        Me.btnMoveDown.TabIndex = 14
        Me.btnMoveDown.Text = "Move Down"
        Me.btnMoveDown.UseVisualStyleBackColor = True
        '
        'btnMoveUp
        '
        Me.btnMoveUp.Enabled = False
        Me.btnMoveUp.Location = New System.Drawing.Point(333, 198)
        Me.btnMoveUp.Name = "btnMoveUp"
        Me.btnMoveUp.Size = New System.Drawing.Size(75, 23)
        Me.btnMoveUp.TabIndex = 13
        Me.btnMoveUp.Text = "Move Up"
        Me.btnMoveUp.UseVisualStyleBackColor = True
        '
        'btnEditLauncher
        '
        Me.btnEditLauncher.Enabled = False
        Me.btnEditLauncher.Location = New System.Drawing.Point(90, 198)
        Me.btnEditLauncher.Name = "btnEditLauncher"
        Me.btnEditLauncher.Size = New System.Drawing.Size(75, 23)
        Me.btnEditLauncher.TabIndex = 10
        Me.btnEditLauncher.Text = "Edit..."
        Me.btnEditLauncher.UseVisualStyleBackColor = True
        '
        'btnNewLauncher
        '
        Me.btnNewLauncher.Location = New System.Drawing.Point(9, 198)
        Me.btnNewLauncher.Name = "btnNewLauncher"
        Me.btnNewLauncher.Size = New System.Drawing.Size(75, 23)
        Me.btnNewLauncher.TabIndex = 9
        Me.btnNewLauncher.Text = "New..."
        Me.btnNewLauncher.UseVisualStyleBackColor = True
        '
        'lstLaunchers
        '
        Me.lstLaunchers.FormattingEnabled = True
        Me.lstLaunchers.Location = New System.Drawing.Point(9, 19)
        Me.lstLaunchers.Name = "lstLaunchers"
        Me.lstLaunchers.Size = New System.Drawing.Size(480, 173)
        Me.lstLaunchers.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkShowNotification)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 85)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Application Settings"
        '
        'chkShowNotification
        '
        Me.chkShowNotification.AutoSize = True
        Me.chkShowNotification.Location = New System.Drawing.Point(20, 36)
        Me.chkShowNotification.Name = "chkShowNotification"
        Me.chkShowNotification.Size = New System.Drawing.Size(191, 17)
        Me.chkShowNotification.TabIndex = 0
        Me.chkShowNotification.Text = "Show Notification on Port Changes"
        Me.chkShowNotification.UseVisualStyleBackColor = True
        '
        'SettingsForm
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(521, 382)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lstLaunchers As ListBox
    Friend WithEvents btnDeleteLauncher As Button
    Friend WithEvents btnMoveDown As Button
    Friend WithEvents btnMoveUp As Button
    Friend WithEvents btnEditLauncher As Button
    Friend WithEvents btnNewLauncher As Button
    Friend WithEvents btnDuplicateLauncher As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkShowNotification As CheckBox
End Class
