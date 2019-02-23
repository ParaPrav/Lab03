Option Strict On    ' Force compiler to adhere to more strict rules

' Author:         Praveen Paramanathan
' Student Number: 100706882 
' File Name:      Form1.vb
' Created:        2019/02/05
' Updated:        2019/01/14
' Description:    A VB system to take user inputed grades for all 6 courses, and return the
'                 average grade with the letter its worth

Public Class frmSemesterGrades

#Region "Variable and constant Declaration"

    ' Declare Constants
    Const MIN_VALUE As Double = 0.0     ' Minimum allowed Grade Mark
    Const MAX_VALUE As Double = 100.0   ' Maximum allowed Grade Mark
    Const ERROR_MESSAGE As String = "ERROR(S)" ' error message to be returned on incorrect data entry
    Dim averageGrade As Double
    Dim CalculateClick As Boolean = False 'Make sure this is before all subs
#End Region

#Region "Functions and Subs"

    ''' <summary>
    '''     Resets form to initial state
    ''' </summary>
    Sub resetForm()

        ' Reset fields and labels
        txtCourse1.Text = ""
        txtCourse2.Text = ""
        txtCourse3.Text = ""
        txtCourse4.Text = ""
        txtCourse5.Text = ""
        txtCourse6.Text = ""
        lblSemester.Text = ""
        lblCourse1Grade.Text = ""
        lblCourse2Grade.Text = ""
        lblCourse3Grade.Text = ""
        lblCourse4Grade.Text = ""
        lblCourse5Grade.Text = ""
        lblCourse6Grade.Text = ""
        lblSemesterGrade.Text = ""
        lblMessageDisplay.Text = ""

        ' Ensure user's ability to enter data
        btnCalculate.Enabled = True
        txtCourse1.ReadOnly = False
        txtCourse2.ReadOnly = False
        txtCourse3.ReadOnly = False
        txtCourse4.ReadOnly = False
        txtCourse5.ReadOnly = False
        txtCourse6.ReadOnly = False

        ' Set focus back to input box for usability
        txtCourse1.Focus()

        CalculateClick = False
        averageGrade = 0
    End Sub

    Sub Button_Click()
        CalculateClick = False
    End Sub

    ''' <summary>
    '''     Letter grade for course 1
    ''' </summary>
    Sub course1()
        Dim userInput As String = txtCourse1.Text ' Take user data and store it for use
        If (validateInput(userInput)) Then ' Check if data entered by user is valid
                lblMessageDisplay.Text = ""
                If (CInt(userInput) >= 90 AndAlso CInt(userInput) <= 100) Then
                    lblCourse1Grade.Text = "A+"
                ElseIf (CInt(userInput) >= 85 AndAlso CInt(userInput) <= 89) Then
                    lblCourse1Grade.Text = "A"
                ElseIf (CInt(userInput) >= 80 AndAlso CInt(userInput) <= 84) Then
                    lblCourse1Grade.Text = "A-"
                ElseIf (CInt(userInput) >= 77 AndAlso CInt(userInput) <= 79) Then
                    lblCourse1Grade.Text = "B+"
                ElseIf (CInt(userInput) >= 73 AndAlso CInt(userInput) <= 76) Then
                    lblCourse1Grade.Text = "B"
                ElseIf (CInt(userInput) >= 70 AndAlso CInt(userInput) <= 72) Then
                    lblCourse1Grade.Text = "B-"
                ElseIf (CInt(userInput) >= 67 AndAlso CInt(userInput) <= 69) Then
                    lblCourse1Grade.Text = "C+"
                ElseIf (CInt(userInput) >= 63 AndAlso CInt(userInput) <= 66) Then
                    lblCourse1Grade.Text = "C"
                ElseIf (CInt(userInput) >= 60 AndAlso CInt(userInput) <= 62) Then
                    lblCourse1Grade.Text = "C-"
                ElseIf (CInt(userInput) >= 57 AndAlso CInt(userInput) <= 59) Then
                    lblCourse1Grade.Text = "D+"
                ElseIf (CInt(userInput) >= 53 AndAlso CInt(userInput) <= 56) Then
                    lblCourse1Grade.Text = "D"
                ElseIf (CInt(userInput) >= 50 AndAlso CInt(userInput) <= 52) Then
                    lblCourse1Grade.Text = "D-"
                Else
                    lblCourse1Grade.Text = "F"
                End If
            Else
                If (txtCourse1.Text = "") Then
                    lblMessageDisplay.Text = ""
                    lblCourse1Grade.Text = ""
                Else
                    btnCalculate.Enabled = False    ' Prevent the user from pressing enter
                    lblCourse1Grade.Text = ""
                    lblMessageDisplay.Text = "Please ensure that what you input is a number between 0 and 100!" + vbCrLf ' Entered data didn't validate, return error
                End If
            End If
    End Sub

    ''' <summary>
    '''     Letter grade for course 2
    ''' </summary>
    Sub course2()
        Dim userInput As String = txtCourse2.Text ' Take user data and store it for use
        If (validateInput(userInput)) Then ' Check if data entered by user is valid
                lblMessageDisplay.Text = ""
                If (CInt(userInput) >= 90 AndAlso CInt(userInput) <= 100) Then
                    lblCourse2Grade.Text = "A+"
                ElseIf (CInt(userInput) >= 85 AndAlso CInt(userInput) <= 89) Then
                    lblCourse2Grade.Text = "A"
                ElseIf (CInt(userInput) >= 80 AndAlso CInt(userInput) <= 84) Then
                    lblCourse2Grade.Text = "A-"
                ElseIf (CInt(userInput) >= 77 AndAlso CInt(userInput) <= 79) Then
                    lblCourse2Grade.Text = "B+"
                ElseIf (CInt(userInput) >= 73 AndAlso CInt(userInput) <= 76) Then
                    lblCourse2Grade.Text = "B"
                ElseIf (CInt(userInput) >= 70 AndAlso CInt(userInput) <= 72) Then
                    lblCourse2Grade.Text = "B-"
                ElseIf (CInt(userInput) >= 67 AndAlso CInt(userInput) <= 69) Then
                    lblCourse2Grade.Text = "C+"
                ElseIf (CInt(userInput) >= 63 AndAlso CInt(userInput) <= 66) Then
                    lblCourse2Grade.Text = "C"
                ElseIf (CInt(userInput) >= 60 AndAlso CInt(userInput) <= 62) Then
                    lblCourse2Grade.Text = "C-"
                ElseIf (CInt(userInput) >= 57 AndAlso CInt(userInput) <= 59) Then
                    lblCourse2Grade.Text = "D+"
                ElseIf (CInt(userInput) >= 53 AndAlso CInt(userInput) <= 56) Then
                    lblCourse2Grade.Text = "D"
                ElseIf (CInt(userInput) >= 50 AndAlso CInt(userInput) <= 52) Then
                    lblCourse2Grade.Text = "D-"
                Else
                    lblCourse2Grade.Text = "F"
                End If
            Else
                If (txtCourse2.Text = "") Then
                    lblCourse2Grade.Text = ""
                Else
                    btnCalculate.Enabled = False    ' Prevent the user from pressing enter
                    lblCourse2Grade.Text = ""
                    lblMessageDisplay.Text = ""
                    lblMessageDisplay.Text = "Please ensure that what you input is a number between 0 and 100!" + vbCrLf ' Entered data didn't validate, return error
                End If
            End If
    End Sub

    ''' <summary>
    '''     Letter grade for course 3
    ''' </summary>
    Sub course3()
        Dim userInput As String = txtCourse3.Text ' Take user data and store it for use
        If (validateInput(userInput)) Then ' Check if data entered by user is valid
                lblMessageDisplay.Text = ""
                If (CInt(userInput) >= 90 AndAlso CInt(userInput) <= 100) Then
                    lblCourse3Grade.Text = "A+"
                ElseIf (CInt(userInput) >= 85 AndAlso CInt(userInput) <= 89) Then
                    lblCourse3Grade.Text = "A"
                ElseIf (CInt(userInput) >= 80 AndAlso CInt(userInput) <= 84) Then
                    lblCourse3Grade.Text = "A-"
                ElseIf (CInt(userInput) >= 77 AndAlso CInt(userInput) <= 79) Then
                    lblCourse3Grade.Text = "B+"
                ElseIf (CInt(userInput) >= 73 AndAlso CInt(userInput) <= 76) Then
                    lblCourse3Grade.Text = "B"
                ElseIf (CInt(userInput) >= 70 AndAlso CInt(userInput) <= 72) Then
                    lblCourse3Grade.Text = "B-"
                ElseIf (CInt(userInput) >= 67 AndAlso CInt(userInput) <= 69) Then
                    lblCourse3Grade.Text = "C+"
                ElseIf (CInt(userInput) >= 63 AndAlso CInt(userInput) <= 66) Then
                    lblCourse3Grade.Text = "C"
                ElseIf (CInt(userInput) >= 60 AndAlso CInt(userInput) <= 62) Then
                    lblCourse3Grade.Text = "C-"
                ElseIf (CInt(userInput) >= 57 AndAlso CInt(userInput) <= 59) Then
                    lblCourse3Grade.Text = "D+"
                ElseIf (CInt(userInput) >= 53 AndAlso CInt(userInput) <= 56) Then
                    lblCourse3Grade.Text = "D"
                ElseIf (CInt(userInput) >= 50 AndAlso CInt(userInput) <= 52) Then
                    lblCourse3Grade.Text = "D-"
                Else
                    lblCourse3Grade.Text = "F"
                End If
            Else
                If (txtCourse3.Text = "") Then
                    lblCourse3Grade.Text = ""
                Else
                    btnCalculate.Enabled = False    ' Prevent the user from pressing enter
                    lblCourse3Grade.Text = ""
                    lblMessageDisplay.Text = ""
                    lblMessageDisplay.Text = "Please ensure that what you input is a number between 0 and 100!" + vbCrLf ' Entered data didn't validate, return error
                End If
            End If
    End Sub

    ''' <summary>
    '''     Letter grade for course 4
    ''' </summary>
    Sub course4()
        Dim userInput As String = txtCourse4.Text ' Take user data and store it for use
        If (validateInput(userInput)) Then ' Check if data entered by user is valid
                lblMessageDisplay.Text = ""
                If (CInt(userInput) >= 90 AndAlso CInt(userInput) <= 100) Then
                    lblCourse4Grade.Text = "A+"
                ElseIf (CInt(userInput) >= 85 AndAlso CInt(userInput) <= 89) Then
                    lblCourse4Grade.Text = "A"
                ElseIf (CInt(userInput) >= 80 AndAlso CInt(userInput) <= 84) Then
                    lblCourse4Grade.Text = "A-"
                ElseIf (CInt(userInput) >= 77 AndAlso CInt(userInput) <= 79) Then
                    lblCourse4Grade.Text = "B+"
                ElseIf (CInt(userInput) >= 73 AndAlso CInt(userInput) <= 76) Then
                    lblCourse4Grade.Text = "B"
                ElseIf (CInt(userInput) >= 70 AndAlso CInt(userInput) <= 72) Then
                    lblCourse4Grade.Text = "B-"
                ElseIf (CInt(userInput) >= 67 AndAlso CInt(userInput) <= 69) Then
                    lblCourse4Grade.Text = "C+"
                ElseIf (CInt(userInput) >= 63 AndAlso CInt(userInput) <= 66) Then
                    lblCourse4Grade.Text = "C"
                ElseIf (CInt(userInput) >= 60 AndAlso CInt(userInput) <= 62) Then
                    lblCourse4Grade.Text = "C-"
                ElseIf (CInt(userInput) >= 57 AndAlso CInt(userInput) <= 59) Then
                    lblCourse4Grade.Text = "D+"
                ElseIf (CInt(userInput) >= 53 AndAlso CInt(userInput) <= 56) Then
                    lblCourse4Grade.Text = "D"
                ElseIf (CInt(userInput) >= 50 AndAlso CInt(userInput) <= 52) Then
                    lblCourse4Grade.Text = "D-"
                Else
                    lblCourse4Grade.Text = "F"
                End If
            Else
                If (txtCourse4.Text = "") Then
                    lblCourse4Grade.Text = ""
                Else
                    btnCalculate.Enabled = False    ' Prevent the user from pressing enter
                    lblCourse4Grade.Text = ""
                    lblMessageDisplay.Text = ""
                    lblMessageDisplay.Text = "Please ensure that what you input is a number between 0 and 100!" + vbCrLf ' Entered data didn't validate, return error
                End If
            End If
    End Sub

    ''' <summary>
    '''     Letter grade for course 5
    ''' </summary>
    Sub course5()
        Dim userInput As String = txtCourse5.Text ' Take user data and store it for use
        If (validateInput(userInput)) Then ' Check if data entered by user is valid
            lblMessageDisplay.Text = ""
            If (CInt(userInput) >= 90 AndAlso CInt(userInput) <= 100) Then
                lblCourse5Grade.Text = "A+"
            ElseIf (CInt(userInput) >= 85 AndAlso CInt(userInput) <= 89) Then
                lblCourse5Grade.Text = "A"
            ElseIf (CInt(userInput) >= 80 AndAlso CInt(userInput) <= 84) Then
                lblCourse5Grade.Text = "A-"
            ElseIf (CInt(userInput) >= 77 AndAlso CInt(userInput) <= 79) Then
                lblCourse5Grade.Text = "B+"
            ElseIf (CInt(userInput) >= 73 AndAlso CInt(userInput) <= 76) Then
                lblCourse5Grade.Text = "B"
            ElseIf (CInt(userInput) >= 70 AndAlso CInt(userInput) <= 72) Then
                lblCourse5Grade.Text = "B-"
            ElseIf (CInt(userInput) >= 67 AndAlso CInt(userInput) <= 69) Then
                lblCourse5Grade.Text = "C+"
            ElseIf (CInt(userInput) >= 63 AndAlso CInt(userInput) <= 66) Then
                lblCourse5Grade.Text = "C"
            ElseIf (CInt(userInput) >= 60 AndAlso CInt(userInput) <= 62) Then
                lblCourse5Grade.Text = "C-"
            ElseIf (CInt(userInput) >= 57 AndAlso CInt(userInput) <= 59) Then
                lblCourse5Grade.Text = "D+"
            ElseIf (CInt(userInput) >= 53 AndAlso CInt(userInput) <= 56) Then
                lblCourse5Grade.Text = "D"
            ElseIf (CInt(userInput) >= 50 AndAlso CInt(userInput) <= 52) Then
                lblCourse5Grade.Text = "D-"
            Else
                lblCourse5Grade.Text = "F"
            End If
        Else
            If (txtCourse5.Text = "") Then
                lblCourse5Grade.Text = ""
            Else
                btnCalculate.Enabled = False    ' Prevent the user from pressing enter
                lblCourse5Grade.Text = ""
                lblMessageDisplay.Text = ""
                lblMessageDisplay.Text = "Please ensure that what you input is a number between 0 and 100!" + vbCrLf ' Entered data didn't validate, return error
            End If
        End If
    End Sub

    ''' <summary>
    '''     Letter grade for course 6
    ''' </summary>
    Sub course6()
        Dim userInput As String = txtCourse6.Text ' Take user data and store it for use

        If (validateInput(userInput)) Then ' Check if data entered by user is valid
            lblMessageDisplay.Text = ""
            If (CInt(userInput) >= 90 AndAlso CInt(userInput) <= 100) Then
                lblCourse6Grade.Text = "A+"
            ElseIf (CInt(userInput) >= 85 AndAlso CInt(userInput) <= 89) Then
                lblCourse6Grade.Text = "A"
            ElseIf (CInt(userInput) >= 80 AndAlso CInt(userInput) <= 84) Then
                lblCourse6Grade.Text = "A-"
            ElseIf (CInt(userInput) >= 77 AndAlso CInt(userInput) <= 79) Then
                lblCourse6Grade.Text = "B+"
            ElseIf (CInt(userInput) >= 73 AndAlso CInt(userInput) <= 76) Then
                lblCourse6Grade.Text = "B"
            ElseIf (CInt(userInput) >= 70 AndAlso CInt(userInput) <= 72) Then
                lblCourse6Grade.Text = "B-"
            ElseIf (CInt(userInput) >= 67 AndAlso CInt(userInput) <= 69) Then
                lblCourse6Grade.Text = "C+"
            ElseIf (CInt(userInput) >= 63 AndAlso CInt(userInput) <= 66) Then
                lblCourse6Grade.Text = "C"
            ElseIf (CInt(userInput) >= 60 AndAlso CInt(userInput) <= 62) Then
                lblCourse6Grade.Text = "C-"
            ElseIf (CInt(userInput) >= 57 AndAlso CInt(userInput) <= 59) Then
                lblCourse6Grade.Text = "D+"
            ElseIf (CInt(userInput) >= 53 AndAlso CInt(userInput) <= 56) Then
                lblCourse6Grade.Text = "D"
            ElseIf (CInt(userInput) >= 50 AndAlso CInt(userInput) <= 52) Then
                lblCourse6Grade.Text = "D-"
            Else
                lblCourse6Grade.Text = "F"
            End If
        Else
            If (txtCourse6.Text = "") Then
                lblCourse6Grade.Text = ""
            Else
                btnCalculate.Enabled = False    ' Prevent the user from pressing enter
                lblCourse6Grade.Text = ""
                lblMessageDisplay.Text = ""
                lblMessageDisplay.Text = "Please ensure that what you input is a number between 0 and 100!" + vbCrLf ' Entered data didn't validate, return error
            End If
        End If
    End Sub
    ''' <summary>
    '''     Letter grade for Semester
    ''' </summary>
    Sub semesterLetter()

        If (averageGrade >= 90 AndAlso averageGrade <= 100) Then
            lblSemesterGrade.Text = "A+"
        ElseIf (averageGrade >= 85 AndAlso averageGrade <= 89) Then
            lblSemesterGrade.Text = "A"
        ElseIf (averageGrade >= 80 AndAlso averageGrade <= 84) Then
            lblSemesterGrade.Text = "A-"
        ElseIf (averageGrade >= 77 AndAlso averageGrade <= 79) Then
            lblSemesterGrade.Text = "B+"
        ElseIf (averageGrade >= 73 AndAlso averageGrade <= 76) Then
            lblSemesterGrade.Text = "B"
        ElseIf (averageGrade >= 70 AndAlso averageGrade <= 72) Then
            lblSemesterGrade.Text = "B-"
        ElseIf (averageGrade >= 67 AndAlso averageGrade <= 69) Then
            lblSemesterGrade.Text = "C+"
        ElseIf (averageGrade >= 63 AndAlso averageGrade <= 66) Then
            lblSemesterGrade.Text = "C"
        ElseIf (averageGrade >= 60 AndAlso averageGrade <= 62) Then
            lblSemesterGrade.Text = "C-"
        ElseIf (averageGrade >= 57 AndAlso averageGrade <= 59) Then
            lblSemesterGrade.Text = "D+"
        ElseIf (averageGrade >= 53 AndAlso averageGrade <= 56) Then
            lblSemesterGrade.Text = "D"
        ElseIf (averageGrade >= 50 AndAlso averageGrade <= 52) Then
            lblSemesterGrade.Text = "D-"
        Else
            lblSemesterGrade.Text = "F"
        End If
    End Sub

    ''' <summary>
    '''     Validates inputed user data
    ''' </summary>
    ''' <param name="input">User input to be validated</param>
    ''' <returns>Whether the input was valid or invalid as boolean</returns>
    Function validateInput(ByVal input As String) As Boolean
        Dim inputNumber As Double  ' Holds the user input as a double
        Dim isValidInput As Boolean = False ' Holds whether the input is valid or not, assuming data is invalid

        ' Example of a try/ catch in VB
        Try
            inputNumber = CInt(input)   ' Try to cast the input as an integer
            If (inputNumber >= MIN_VALUE AndAlso inputNumber <= MAX_VALUE) Then ' Check if the inputed data is within defined bounds
                isValidInput = True ' All checks passed, data is valid

            End If
        Catch ex As Exception
            ' input could not be cast as an integer, not a number
        End Try

        Return isValidInput ' Return the success or failure of the validation
    End Function

#End Region

#Region "Event Handlers"

    ''' <summary>
    '''     Handles Calculate Button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        CalculateClick = True
        btnCalculate.Enabled = False    ' Prevent the user from pressing enter
        txtCourse1.ReadOnly = True      ' Prevent the user from entering new text in Course 1 textbox
        txtCourse2.ReadOnly = True      ' Prevent the user from entering new text in Course 2 textbox
        txtCourse3.ReadOnly = True      ' Prevent the user from entering new text in Course 3 textbox
        txtCourse4.ReadOnly = True      ' Prevent the user from entering new text in Course 4 textbox
        txtCourse5.ReadOnly = True      ' Prevent the user from entering new text in Course 5 textbox
        txtCourse6.ReadOnly = True      ' Prevent the user from entering new text in Course 6 textbo

        If (CalculateClick AndAlso txtCourse1.Text = "") Then
            lblMessageDisplay.Text += "Please ensure that what you input in Course 1 is a number between 0 and 100!" + vbCrLf ' Entered data didn't validate, return error
        Else
            Call course1()    ' Enter the grade letter
        End If
        If (CalculateClick AndAlso txtCourse2.Text = "") Then
            lblMessageDisplay.Text += "Please ensure that what you input in Course 2 is a number between 0 and 100!" + vbCrLf ' Entered data didn't validate, return error
        Else
            Call course2()    ' Enter the grade letter
        End If
        If (CalculateClick AndAlso txtCourse3.Text = "") Then
            lblMessageDisplay.Text += "Please ensure that what you input in Course 3 is a number between 0 and 100!" + vbCrLf ' Entered data didn't validate, return error
        Else
            Call course3()    ' Enter the grade letter
        End If
        If (CalculateClick AndAlso txtCourse4.Text = "") Then
            lblMessageDisplay.Text += "Please ensure that what you input in Course 4 is a number between 0 and 100!" + vbCrLf ' Entered data didn't validate, return error
        Else
            Call course4()    ' Enter the grade letter
        End If

        If (CalculateClick AndAlso txtCourse5.Text = "") Then
            lblMessageDisplay.Text += "Please ensure that what you input in Course 5 is a number between 0 and 100!" + vbCrLf ' Entered data didn't validate, return error
        Else
            Call course5()    ' Enter the grade letter
        End If

        If (CalculateClick AndAlso txtCourse6.Text = "") Then
            lblMessageDisplay.Text += "Please ensure that what you input in Course 6 is a number between 0 and 100!" + vbCrLf ' Entered data didn't validate, return error
        Else
            Call course6()    ' Enter the grade letter
        End If

        If (lblMessageDisplay.Text = "" AndAlso txtCourse6.Text = "") Then
            averageGrade = (CInt(txtCourse1.Text) + CInt(txtCourse2.Text) + CInt(txtCourse3.Text) + CInt(txtCourse4.Text) + CInt(txtCourse5.Text) + CInt(txtCourse6.Text)) / 6
            lblSemester.Text = averageGrade.ToString
            Call semesterLetter()    ' Enter the grade letter
        End If

        btnReset.Focus()    ' Set focus to reset button for usability
    End Sub

    ''' <summary>
    '''     Handles Reset Button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call resetForm()    ' Reset the form
    End Sub

    ''' <summary>
    '''     Handles Exit Button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub txtCourse1_TextChanged(sender As Object, e As EventArgs) Handles txtCourse1.TextChanged
        Call course1()    ' Enter the grade letter
        Call course2()    ' Enter the grade letter
        Call course3()    ' Enter the grade letter
        Call course4()    ' Enter the grade letter
        Call course5()    ' Enter the grade letter
        Call course6()    ' Enter the grade letter
        If (lblMessageDisplay.Text = "") Then
            btnCalculate.Enabled = True
        Else
            btnCalculate.Enabled = False
        End If
    End Sub

    Private Sub txtCourse2_TextChanged(sender As Object, e As EventArgs) Handles txtCourse2.TextChanged
        Call course1()    ' Enter the grade letter
        Call course2()    ' Enter the grade letter
        Call course3()    ' Enter the grade letter
        Call course4()    ' Enter the grade letter
        Call course5()    ' Enter the grade letter
        Call course6()    ' Enter the grade letter
        If (lblMessageDisplay.Text = "") Then
            btnCalculate.Enabled = True
        Else
            btnCalculate.Enabled = False
        End If
    End Sub

    Private Sub txtCourse3_TextChanged(sender As Object, e As EventArgs) Handles txtCourse3.TextChanged
        Call course1()    ' Enter the grade letter
        Call course2()    ' Enter the grade letter
        Call course3()    ' Enter the grade letter
        Call course4()    ' Enter the grade letter
        Call course5()    ' Enter the grade letter
        Call course6()    ' Enter the grade letter
        If (lblMessageDisplay.Text = "") Then
            btnCalculate.Enabled = True
        Else
            btnCalculate.Enabled = False
        End If
    End Sub

    Private Sub txtCourse4_TextChanged(sender As Object, e As EventArgs) Handles txtCourse4.TextChanged
        Call course1()    ' Enter the grade letter
        Call course2()    ' Enter the grade letter
        Call course3()    ' Enter the grade letter
        Call course4()    ' Enter the grade letter
        Call course5()    ' Enter the grade letter
        Call course6()    ' Enter the grade letter
        If (lblMessageDisplay.Text = "") Then
            btnCalculate.Enabled = True
        Else
            btnCalculate.Enabled = False
        End If
    End Sub
        
    Private Sub txtCourse5_TextChanged(sender As Object, e As EventArgs) Handles txtCourse5.TextChanged
        Call course1()    ' Enter the grade letter
        Call course2()    ' Enter the grade letter
        Call course3()    ' Enter the grade letter
        Call course4()    ' Enter the grade letter
        Call course5()    ' Enter the grade letter
        Call course6()    ' Enter the grade letter
        If (lblMessageDisplay.Text = "") Then
            btnCalculate.Enabled = True
        Else
            btnCalculate.Enabled = False
        End If
    End Sub

    Private Sub txtCourse6_TextChanged(sender As Object, e As EventArgs) Handles txtCourse6.TextChanged
        Call course1()    ' Enter the grade letter
        Call course2()    ' Enter the grade letter
        Call course3()    ' Enter the grade letter
        Call course4()    ' Enter the grade letter
        Call course5()    ' Enter the grade letter
        Call course6()    ' Enter the grade letter
        If (lblMessageDisplay.Text = "") Then
            btnCalculate.Enabled = True
        Else
            btnCalculate.Enabled = False
        End If
    End Sub

    Private Sub lblMessageDisplay_Click(sender As Object, e As EventArgs) Handles lblMessageDisplay.Click

    End Sub



#End Region
End Class
