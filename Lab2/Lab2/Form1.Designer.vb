<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemesterGrades
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblCourse1Prompt = New System.Windows.Forms.Label()
        Me.SemesterGradesTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtCourse1 = New System.Windows.Forms.TextBox()
        Me.txtCourse2 = New System.Windows.Forms.TextBox()
        Me.txtCourse3 = New System.Windows.Forms.TextBox()
        Me.txtCourse4 = New System.Windows.Forms.TextBox()
        Me.txtCourse5 = New System.Windows.Forms.TextBox()
        Me.txtCourse6 = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCourse2Prompt = New System.Windows.Forms.Label()
        Me.lblCourse3Prompt = New System.Windows.Forms.Label()
        Me.lblCourse4Prompt = New System.Windows.Forms.Label()
        Me.lblCourse5Prompt = New System.Windows.Forms.Label()
        Me.lblCourse6Prompt = New System.Windows.Forms.Label()
        Me.lblSemesterDisplay = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblCourse1Grade = New System.Windows.Forms.Label()
        Me.lblCourse2Grade = New System.Windows.Forms.Label()
        Me.lblCourse3Grade = New System.Windows.Forms.Label()
        Me.lblCourse4Grade = New System.Windows.Forms.Label()
        Me.lblCourse5Grade = New System.Windows.Forms.Label()
        Me.lblCourse6Grade = New System.Windows.Forms.Label()
        Me.lblSemesterGrade = New System.Windows.Forms.Label()
        Me.lblMessageDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCourse1Prompt
        '
        Me.lblCourse1Prompt.Location = New System.Drawing.Point(9, 12)
        Me.lblCourse1Prompt.Name = "lblCourse1Prompt"
        Me.lblCourse1Prompt.Size = New System.Drawing.Size(70, 23)
        Me.lblCourse1Prompt.TabIndex = 0
        Me.lblCourse1Prompt.Text = "Course &1:"
        Me.lblCourse1Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCourse1
        '
        Me.txtCourse1.Location = New System.Drawing.Point(85, 12)
        Me.txtCourse1.Name = "txtCourse1"
        Me.txtCourse1.Size = New System.Drawing.Size(100, 22)
        Me.txtCourse1.TabIndex = 1
        Me.txtCourse1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterGradesTips.SetToolTip(Me.txtCourse1, "Enter Course 1 Grade")
        '
        'txtCourse2
        '
        Me.txtCourse2.Location = New System.Drawing.Point(85, 39)
        Me.txtCourse2.Name = "txtCourse2"
        Me.txtCourse2.Size = New System.Drawing.Size(100, 22)
        Me.txtCourse2.TabIndex = 4
        Me.txtCourse2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterGradesTips.SetToolTip(Me.txtCourse2, "Enter Course 2 Grade")
        '
        'txtCourse3
        '
        Me.txtCourse3.Location = New System.Drawing.Point(85, 66)
        Me.txtCourse3.Name = "txtCourse3"
        Me.txtCourse3.Size = New System.Drawing.Size(100, 22)
        Me.txtCourse3.TabIndex = 7
        Me.txtCourse3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterGradesTips.SetToolTip(Me.txtCourse3, "Enter Course 3 Grade")
        '
        'txtCourse4
        '
        Me.txtCourse4.Location = New System.Drawing.Point(85, 93)
        Me.txtCourse4.Name = "txtCourse4"
        Me.txtCourse4.Size = New System.Drawing.Size(100, 22)
        Me.txtCourse4.TabIndex = 10
        Me.txtCourse4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterGradesTips.SetToolTip(Me.txtCourse4, "Enter Course 4 Grade")
        '
        'txtCourse5
        '
        Me.txtCourse5.Location = New System.Drawing.Point(85, 120)
        Me.txtCourse5.Name = "txtCourse5"
        Me.txtCourse5.Size = New System.Drawing.Size(100, 22)
        Me.txtCourse5.TabIndex = 13
        Me.txtCourse5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterGradesTips.SetToolTip(Me.txtCourse5, "Enter Course 5 Grade")
        '
        'txtCourse6
        '
        Me.txtCourse6.Location = New System.Drawing.Point(85, 147)
        Me.txtCourse6.Name = "txtCourse6"
        Me.txtCourse6.Size = New System.Drawing.Size(100, 22)
        Me.txtCourse6.TabIndex = 16
        Me.txtCourse6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SemesterGradesTips.SetToolTip(Me.txtCourse6, "Enter Course 6 Grade")
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 408)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(84, 28)
        Me.btnCalculate.TabIndex = 22
        Me.btnCalculate.Text = "&Calculate"
        Me.SemesterGradesTips.SetToolTip(Me.btnCalculate, "Calculate the Semester Grade")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(109, 408)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(84, 28)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "&Reset"
        Me.SemesterGradesTips.SetToolTip(Me.btnReset, "Reset the Program")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(206, 408)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 28)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "E&xit"
        Me.SemesterGradesTips.SetToolTip(Me.btnExit, "Exit the Program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCourse2Prompt
        '
        Me.lblCourse2Prompt.Location = New System.Drawing.Point(9, 39)
        Me.lblCourse2Prompt.Name = "lblCourse2Prompt"
        Me.lblCourse2Prompt.Size = New System.Drawing.Size(70, 23)
        Me.lblCourse2Prompt.TabIndex = 3
        Me.lblCourse2Prompt.Text = "Course &2:"
        Me.lblCourse2Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourse3Prompt
        '
        Me.lblCourse3Prompt.Location = New System.Drawing.Point(9, 66)
        Me.lblCourse3Prompt.Name = "lblCourse3Prompt"
        Me.lblCourse3Prompt.Size = New System.Drawing.Size(70, 23)
        Me.lblCourse3Prompt.TabIndex = 6
        Me.lblCourse3Prompt.Text = "Course &3:"
        Me.lblCourse3Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourse4Prompt
        '
        Me.lblCourse4Prompt.Location = New System.Drawing.Point(9, 93)
        Me.lblCourse4Prompt.Name = "lblCourse4Prompt"
        Me.lblCourse4Prompt.Size = New System.Drawing.Size(70, 23)
        Me.lblCourse4Prompt.TabIndex = 9
        Me.lblCourse4Prompt.Text = "Course &4:"
        Me.lblCourse4Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourse5Prompt
        '
        Me.lblCourse5Prompt.Location = New System.Drawing.Point(9, 120)
        Me.lblCourse5Prompt.Name = "lblCourse5Prompt"
        Me.lblCourse5Prompt.Size = New System.Drawing.Size(70, 23)
        Me.lblCourse5Prompt.TabIndex = 12
        Me.lblCourse5Prompt.Text = "Course &5:"
        Me.lblCourse5Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourse6Prompt
        '
        Me.lblCourse6Prompt.Location = New System.Drawing.Point(9, 147)
        Me.lblCourse6Prompt.Name = "lblCourse6Prompt"
        Me.lblCourse6Prompt.Size = New System.Drawing.Size(70, 23)
        Me.lblCourse6Prompt.TabIndex = 15
        Me.lblCourse6Prompt.Text = "Course &6:"
        Me.lblCourse6Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSemesterDisplay
        '
        Me.lblSemesterDisplay.Location = New System.Drawing.Point(9, 174)
        Me.lblSemesterDisplay.Name = "lblSemesterDisplay"
        Me.lblSemesterDisplay.Size = New System.Drawing.Size(70, 23)
        Me.lblSemesterDisplay.TabIndex = 18
        Me.lblSemesterDisplay.Text = "Semester:"
        Me.lblSemesterDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSemester
        '
        Me.lblSemester.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblSemester.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSemester.Location = New System.Drawing.Point(85, 174)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(100, 23)
        Me.lblSemester.TabIndex = 19
        Me.lblSemester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourse1Grade
        '
        Me.lblCourse1Grade.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCourse1Grade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse1Grade.Location = New System.Drawing.Point(191, 11)
        Me.lblCourse1Grade.Name = "lblCourse1Grade"
        Me.lblCourse1Grade.Size = New System.Drawing.Size(100, 23)
        Me.lblCourse1Grade.TabIndex = 2
        Me.lblCourse1Grade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourse2Grade
        '
        Me.lblCourse2Grade.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCourse2Grade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse2Grade.Location = New System.Drawing.Point(191, 38)
        Me.lblCourse2Grade.Name = "lblCourse2Grade"
        Me.lblCourse2Grade.Size = New System.Drawing.Size(100, 23)
        Me.lblCourse2Grade.TabIndex = 5
        Me.lblCourse2Grade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourse3Grade
        '
        Me.lblCourse3Grade.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCourse3Grade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse3Grade.Location = New System.Drawing.Point(191, 65)
        Me.lblCourse3Grade.Name = "lblCourse3Grade"
        Me.lblCourse3Grade.Size = New System.Drawing.Size(100, 23)
        Me.lblCourse3Grade.TabIndex = 8
        Me.lblCourse3Grade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourse4Grade
        '
        Me.lblCourse4Grade.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCourse4Grade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse4Grade.Location = New System.Drawing.Point(191, 92)
        Me.lblCourse4Grade.Name = "lblCourse4Grade"
        Me.lblCourse4Grade.Size = New System.Drawing.Size(100, 23)
        Me.lblCourse4Grade.TabIndex = 11
        Me.lblCourse4Grade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourse5Grade
        '
        Me.lblCourse5Grade.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCourse5Grade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse5Grade.Location = New System.Drawing.Point(191, 119)
        Me.lblCourse5Grade.Name = "lblCourse5Grade"
        Me.lblCourse5Grade.Size = New System.Drawing.Size(100, 23)
        Me.lblCourse5Grade.TabIndex = 14
        Me.lblCourse5Grade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourse6Grade
        '
        Me.lblCourse6Grade.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCourse6Grade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse6Grade.Location = New System.Drawing.Point(191, 146)
        Me.lblCourse6Grade.Name = "lblCourse6Grade"
        Me.lblCourse6Grade.Size = New System.Drawing.Size(100, 23)
        Me.lblCourse6Grade.TabIndex = 17
        Me.lblCourse6Grade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSemesterGrade
        '
        Me.lblSemesterGrade.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblSemesterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSemesterGrade.Location = New System.Drawing.Point(191, 173)
        Me.lblSemesterGrade.Name = "lblSemesterGrade"
        Me.lblSemesterGrade.Size = New System.Drawing.Size(100, 23)
        Me.lblSemesterGrade.TabIndex = 20
        Me.lblSemesterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMessageDisplay
        '
        Me.lblMessageDisplay.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblMessageDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessageDisplay.Location = New System.Drawing.Point(12, 210)
        Me.lblMessageDisplay.Name = "lblMessageDisplay"
        Me.lblMessageDisplay.Size = New System.Drawing.Size(279, 195)
        Me.lblMessageDisplay.TabIndex = 21
        '
        'frmSemesterGrades
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(303, 441)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblMessageDisplay)
        Me.Controls.Add(Me.lblSemesterGrade)
        Me.Controls.Add(Me.lblCourse6Grade)
        Me.Controls.Add(Me.lblCourse5Grade)
        Me.Controls.Add(Me.lblCourse4Grade)
        Me.Controls.Add(Me.lblCourse3Grade)
        Me.Controls.Add(Me.lblCourse2Grade)
        Me.Controls.Add(Me.lblCourse1Grade)
        Me.Controls.Add(Me.txtCourse6)
        Me.Controls.Add(Me.txtCourse5)
        Me.Controls.Add(Me.txtCourse4)
        Me.Controls.Add(Me.txtCourse3)
        Me.Controls.Add(Me.txtCourse2)
        Me.Controls.Add(Me.txtCourse1)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.lblSemesterDisplay)
        Me.Controls.Add(Me.lblCourse6Prompt)
        Me.Controls.Add(Me.lblCourse5Prompt)
        Me.Controls.Add(Me.lblCourse4Prompt)
        Me.Controls.Add(Me.lblCourse3Prompt)
        Me.Controls.Add(Me.lblCourse2Prompt)
        Me.Controls.Add(Me.lblCourse1Prompt)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSemesterGrades"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCourse1Prompt As Label
    Friend WithEvents SemesterGradesTips As ToolTip
    Friend WithEvents lblCourse2Prompt As Label
    Friend WithEvents lblCourse3Prompt As Label
    Friend WithEvents lblCourse4Prompt As Label
    Friend WithEvents lblCourse5Prompt As Label
    Friend WithEvents lblCourse6Prompt As Label
    Friend WithEvents lblSemesterDisplay As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents txtCourse1 As TextBox
    Friend WithEvents txtCourse2 As TextBox
    Friend WithEvents txtCourse3 As TextBox
    Friend WithEvents txtCourse4 As TextBox
    Friend WithEvents txtCourse5 As TextBox
    Friend WithEvents txtCourse6 As TextBox
    Friend WithEvents lblCourse1Grade As Label
    Friend WithEvents lblCourse2Grade As Label
    Friend WithEvents lblCourse3Grade As Label
    Friend WithEvents lblCourse4Grade As Label
    Friend WithEvents lblCourse5Grade As Label
    Friend WithEvents lblCourse6Grade As Label
    Friend WithEvents lblSemesterGrade As Label
    Friend WithEvents lblMessageDisplay As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
