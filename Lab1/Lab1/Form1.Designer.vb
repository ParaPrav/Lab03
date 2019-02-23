<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAverageUnitsShipped
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
        Me.components = New System.ComponentModel.Container()
        Me.AverageUnitsShippedTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtUnitShipped = New System.Windows.Forms.TextBox()
        Me.lblUnitShippedPrompt = New System.Windows.Forms.Label()
        Me.lblRecord = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnter.Location = New System.Drawing.Point(12, 218)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Text = "&Enter"
        Me.AverageUnitsShippedTips.SetToolTip(Me.btnEnter, "Enter to continue")
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReset.Location = New System.Drawing.Point(105, 218)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.AverageUnitsShippedTips.SetToolTip(Me.btnReset, "Clear all of the inputs")
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Location = New System.Drawing.Point(195, 218)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.AverageUnitsShippedTips.SetToolTip(Me.btnExit, "Quit the program")
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtUnitShipped
        '
        Me.txtUnitShipped.Location = New System.Drawing.Point(45, 12)
        Me.txtUnitShipped.Name = "txtUnitShipped"
        Me.txtUnitShipped.Size = New System.Drawing.Size(75, 22)
        Me.txtUnitShipped.TabIndex = 1
        Me.AverageUnitsShippedTips.SetToolTip(Me.txtUnitShipped, "input the # of Units Shipped")
        '
        'lblUnitShippedPrompt
        '
        Me.lblUnitShippedPrompt.Location = New System.Drawing.Point(11, 13)
        Me.lblUnitShippedPrompt.Name = "lblUnitShippedPrompt"
        Me.lblUnitShippedPrompt.Size = New System.Drawing.Size(38, 23)
        Me.lblUnitShippedPrompt.TabIndex = 0
        Me.lblUnitShippedPrompt.Text = "&Unit:"
        Me.lblUnitShippedPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRecord
        '
        Me.lblRecord.BackColor = System.Drawing.SystemColors.Window
        Me.lblRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRecord.Location = New System.Drawing.Point(12, 48)
        Me.lblRecord.Name = "lblRecord"
        Me.lblRecord.Size = New System.Drawing.Size(258, 122)
        Me.lblRecord.TabIndex = 3
        '
        'lblAverage
        '
        Me.lblAverage.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAverage.Location = New System.Drawing.Point(12, 182)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(258, 23)
        Me.lblAverage.TabIndex = 4
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDay
        '
        Me.lblDay.Location = New System.Drawing.Point(219, 23)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(51, 23)
        Me.lblDay.TabIndex = 2
        Me.lblDay.Text = "Day 1"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblRecord)
        Me.Controls.Add(Me.txtUnitShipped)
        Me.Controls.Add(Me.lblUnitShippedPrompt)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AverageUnitsShippedTips As ToolTip
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblUnitShippedPrompt As Label
    Friend WithEvents txtUnitShipped As TextBox
    Friend WithEvents lblRecord As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblDay As Label
End Class
