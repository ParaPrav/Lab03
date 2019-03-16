<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAverageUnitsShippedByEmployee
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
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblUnitsPrompt = New System.Windows.Forms.Label()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.AvgUnitsShippedByEmployeeTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblEmployee1Prompt = New System.Windows.Forms.Label()
        Me.lblEmployee2Prompt = New System.Windows.Forms.Label()
        Me.lblEmployee3Prompt = New System.Windows.Forms.Label()
        Me.lblEmployee1AvgDisplay = New System.Windows.Forms.Label()
        Me.lblEmployee2AvgDisplay = New System.Windows.Forms.Label()
        Me.lblEmployee3AvgDisplay = New System.Windows.Forms.Label()
        Me.lblTotalAvgDisplay = New System.Windows.Forms.Label()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDay
        '
        Me.lblDay.Location = New System.Drawing.Point(383, 18)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(55, 23)
        Me.lblDay.TabIndex = 0
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUnitsPrompt
        '
        Me.lblUnitsPrompt.Location = New System.Drawing.Point(11, 18)
        Me.lblUnitsPrompt.Name = "lblUnitsPrompt"
        Me.lblUnitsPrompt.Size = New System.Drawing.Size(55, 23)
        Me.lblUnitsPrompt.TabIndex = 1
        Me.lblUnitsPrompt.Text = "&Unit(s):"
        Me.lblUnitsPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(62, 19)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(37, 22)
        Me.txtUnits.TabIndex = 2
        Me.AvgUnitsShippedByEmployeeTips.SetToolTip(Me.txtUnits, "Enter Units Shipped")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(17, 298)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(128, 28)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.AvgUnitsShippedByEmployeeTips.SetToolTip(Me.btnEnter, "Enter Unit(s) Shipped")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(163, 298)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(128, 28)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.AvgUnitsShippedByEmployeeTips.SetToolTip(Me.btnReset, "Enter Unit(s) Shipped")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(310, 298)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(128, 28)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.AvgUnitsShippedByEmployeeTips.SetToolTip(Me.btnExit, "Enter Unit(s) Shipped")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblEmployee1Prompt
        '
        Me.lblEmployee1Prompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee1Prompt.Location = New System.Drawing.Point(17, 56)
        Me.lblEmployee1Prompt.Name = "lblEmployee1Prompt"
        Me.lblEmployee1Prompt.Size = New System.Drawing.Size(128, 23)
        Me.lblEmployee1Prompt.TabIndex = 3
        Me.lblEmployee1Prompt.Text = "Employee 1"
        Me.lblEmployee1Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee2Prompt
        '
        Me.lblEmployee2Prompt.Location = New System.Drawing.Point(163, 56)
        Me.lblEmployee2Prompt.Name = "lblEmployee2Prompt"
        Me.lblEmployee2Prompt.Size = New System.Drawing.Size(128, 23)
        Me.lblEmployee2Prompt.TabIndex = 6
        Me.lblEmployee2Prompt.Text = "Employee 2"
        Me.lblEmployee2Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee3Prompt
        '
        Me.lblEmployee3Prompt.Location = New System.Drawing.Point(310, 56)
        Me.lblEmployee3Prompt.Name = "lblEmployee3Prompt"
        Me.lblEmployee3Prompt.Size = New System.Drawing.Size(128, 23)
        Me.lblEmployee3Prompt.TabIndex = 9
        Me.lblEmployee3Prompt.Text = "Employee 3"
        Me.lblEmployee3Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee1AvgDisplay
        '
        Me.lblEmployee1AvgDisplay.BackColor = System.Drawing.SystemColors.Control
        Me.lblEmployee1AvgDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee1AvgDisplay.Location = New System.Drawing.Point(17, 237)
        Me.lblEmployee1AvgDisplay.Name = "lblEmployee1AvgDisplay"
        Me.lblEmployee1AvgDisplay.Size = New System.Drawing.Size(128, 23)
        Me.lblEmployee1AvgDisplay.TabIndex = 5
        Me.lblEmployee1AvgDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee2AvgDisplay
        '
        Me.lblEmployee2AvgDisplay.BackColor = System.Drawing.SystemColors.Control
        Me.lblEmployee2AvgDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee2AvgDisplay.Location = New System.Drawing.Point(163, 237)
        Me.lblEmployee2AvgDisplay.Name = "lblEmployee2AvgDisplay"
        Me.lblEmployee2AvgDisplay.Size = New System.Drawing.Size(128, 23)
        Me.lblEmployee2AvgDisplay.TabIndex = 8
        Me.lblEmployee2AvgDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee3AvgDisplay
        '
        Me.lblEmployee3AvgDisplay.BackColor = System.Drawing.SystemColors.Control
        Me.lblEmployee3AvgDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee3AvgDisplay.Location = New System.Drawing.Point(310, 237)
        Me.lblEmployee3AvgDisplay.Name = "lblEmployee3AvgDisplay"
        Me.lblEmployee3AvgDisplay.Size = New System.Drawing.Size(128, 23)
        Me.lblEmployee3AvgDisplay.TabIndex = 11
        Me.lblEmployee3AvgDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalAvgDisplay
        '
        Me.lblTotalAvgDisplay.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotalAvgDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalAvgDisplay.Location = New System.Drawing.Point(17, 272)
        Me.lblTotalAvgDisplay.Name = "lblTotalAvgDisplay"
        Me.lblTotalAvgDisplay.Size = New System.Drawing.Size(421, 23)
        Me.lblTotalAvgDisplay.TabIndex = 12
        Me.lblTotalAvgDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee1
        '
        Me.lblEmployee1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblEmployee1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployee1.Location = New System.Drawing.Point(17, 91)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(128, 143)
        Me.lblEmployee1.TabIndex = 4
        '
        'lblEmployee2
        '
        Me.lblEmployee2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblEmployee2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployee2.Location = New System.Drawing.Point(163, 91)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(128, 143)
        Me.lblEmployee2.TabIndex = 7
        '
        'lblEmployee3
        '
        Me.lblEmployee3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblEmployee3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployee3.Location = New System.Drawing.Point(310, 91)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(128, 143)
        Me.lblEmployee3.TabIndex = 10
        '
        'frmAverageUnitsShippedByEmployee
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(459, 334)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblTotalAvgDisplay)
        Me.Controls.Add(Me.lblEmployee3AvgDisplay)
        Me.Controls.Add(Me.lblEmployee2AvgDisplay)
        Me.Controls.Add(Me.lblEmployee1AvgDisplay)
        Me.Controls.Add(Me.lblEmployee3Prompt)
        Me.Controls.Add(Me.lblEmployee2Prompt)
        Me.Controls.Add(Me.lblEmployee1Prompt)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.lblUnitsPrompt)
        Me.Controls.Add(Me.lblDay)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShippedByEmployee"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDay As Label
    Friend WithEvents lblUnitsPrompt As Label
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents AvgUnitsShippedByEmployeeTips As ToolTip
    Friend WithEvents lblEmployee1Prompt As Label
    Friend WithEvents lblEmployee2Prompt As Label
    Friend WithEvents lblEmployee3Prompt As Label
    Friend WithEvents lblEmployee1AvgDisplay As Label
    Friend WithEvents lblEmployee2AvgDisplay As Label
    Friend WithEvents lblEmployee3AvgDisplay As Label
    Friend WithEvents lblTotalAvgDisplay As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
End Class
