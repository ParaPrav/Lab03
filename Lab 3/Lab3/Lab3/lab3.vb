Option Strict On    ' Force compiler to adhere to more strict rules

' Author:         Praveen Paramanathan
' Student Number: 100706882
' File Name:      Lab3.vb
' Created:        2019/02/20
' Updated:        2019/02/22
' Description:    A VB system to take user inputed units, store them, and return the
'                 average units shipped per day and per employee over the period entered

Public Class frmAverageUnitsShippedByEmployee

#Region "Variable and constant Declaration"

    ' Declare Constants
    Const MIN_INPUTS As Integer = 0      ' Minimum allowed unit volume
    Const MAX_INPUTS As Integer = 1000   ' Maximum allowed unit volume

    ' Declare Variables
    Dim units(6) As Integer ' Holds entered units
    Dim day As Integer = 1  ' Holds current day of data entry

    ' form/class level constants
    Private Const numberColumnLastIndex As Integer = 2  ' what is the last column index for the 2d array
    Private Const numberRowLastIndex As Integer = 6     ' what is the last row index for the 2d array

    Private Const indexValueLabels As Integer = 0       ' holds the index of the Value labels
    Private Const indexRowColumnLabels As Integer = 1   ' holds the index of the RowColumn labels

    ' 2 dimensional array
    ' 2 columns = 1
    ' 3 rows = 2
    Private numberArray(numberRowLastIndex, numberColumnLastIndex) As Double

    Private columnCounter As Integer = 0
    Private rowCounter As Integer = 0

    Dim TOTAL_AVG As Double = 0   ' holds the Total Average

#End Region

#Region "Functions and Subs"

    Function validateInput(ByVal input As String) As Boolean
        Dim inputNumber As Integer  ' Holds the user input as an integer
        Dim isValidInput As Boolean = False ' Holds whether the input is valid or not, assuming data is invalid

        ' Example of a try/ catch in VB
        Try
            inputNumber = CInt(input)   ' Try to cast the input as an integer
            If (input.Equals(inputNumber.ToString)) Then   ' Check if the inputed data is a whole number
                If (inputNumber >= MIN_INPUTS AndAlso inputNumber <= MAX_INPUTS) Then ' Check if the inputed data is within defined bounds
                    isValidInput = True ' All checks passed, data is valid
                End If
            End If
        Catch ex As Exception
            ' input could not be cast as an integer, not a number
        End Try

        Return isValidInput ' Return the success or failure of the validation
    End Function

    Function averageArray(ByVal arrayToAverage() As Integer) As Double
        Dim runningTotal As Integer ' Holds a running total of the values in the array

        ' Example of a For Each loop in VB
        For Each dailyTotal In arrayToAverage  ' Loop through the array
            runningTotal += dailyTotal  ' Add the current value to the running total
        Next

        averageArray = Math.Round(runningTotal / arrayToAverage.Length, 2) ' Return the average value of the array, rounded to 2 decimal places
    End Function

    Sub updateDataDisplay()
        ' input the number entered into the array
        ' no validation to simplify the code
        numberArray(rowCounter, columnCounter) = Convert.ToDouble(txtUnits.Text)

        ' output the number to the output label
        If (columnCounter = 0) Then
            lblEmployee1.Text += numberArray(rowCounter, columnCounter).ToString() & " "

            ' if the row lindex is less than the last index
            ' and the column counter is the last column
            ' move to the next row and reset the column to the start
            If rowCounter < numberRowLastIndex Then

                'move to the next row
                rowCounter += 1

                ' add carriage return line feed 
                ' to move to the next row
                lblEmployee1.Text += vbCrLf

            ElseIf rowCounter = numberRowLastIndex And columnCounter = numberColumnLastIndex Then
                ' if this is the last row and last index
                btnEnter.Enabled = False    ' Prevent the user from clicking Enter
                txtUnits.Text = ""          ' Clear the last data entry from the text box
                txtUnits.ReadOnly = True    ' Prevent the user from entering new text in units box
                btnReset().Focus()          ' Set focus to Reset Button for usability
            Else
                ' increment the column counter
                columnCounter += 1
                'move to the next row
                rowCounter = 0
                lblEmployee1AvgDisplay.Text = "Average: " + averageArray(units).ToString ' Display the rounded average
                lblEmployee1Prompt.Font = New Font(lblEmployee1Prompt.Font, FontStyle.Regular)
                lblEmployee2Prompt.Font = New Font(lblEmployee2Prompt.Font, FontStyle.Bold)
                TOTAL_AVG = TOTAL_AVG + averageArray(units)
            End If

            ' clear the input text box
            txtUnits.Text = String.Empty

        ElseIf (columnCounter = 1) Then
            lblEmployee2.Text += numberArray(rowCounter, columnCounter).ToString() & " "

            ' if the row lindex is less than the last index
            ' and the column counter is the last column
            ' move to the next row and reset the column to the start
            If rowCounter < numberRowLastIndex Then

                'move to the next row
                rowCounter += 1

                ' add carriage return line feed 
                ' to move to the next row
                lblEmployee2.Text += vbCrLf

            ElseIf rowCounter = numberRowLastIndex And columnCounter = numberColumnLastIndex Then
                ' if this is the last row and last index
                btnEnter.Enabled = False    ' Prevent the user from clicking Enter
                txtUnits.Text = ""          ' Clear the last data entry from the text box
                txtUnits.ReadOnly = True    ' Prevent the user from entering new text in units box
                btnReset().Focus()          ' Set focus to Reset Button for usability
            Else
                ' increment the column counter
                columnCounter += 1
                'move to the next row
                rowCounter = 0
                lblEmployee2AvgDisplay.Text = "Average: " + averageArray(units).ToString ' Display the rounded average
                lblEmployee2Prompt.Font = New Font(lblEmployee2Prompt.Font, FontStyle.Regular)
                lblEmployee3Prompt.Font = New Font(lblEmployee3Prompt.Font, FontStyle.Bold)
                TOTAL_AVG = TOTAL_AVG + averageArray(units)
            End If

            ' clear the input text box
            txtUnits.Text = String.Empty

        ElseIf (columnCounter = 2) Then
            lblEmployee3.Text += numberArray(rowCounter, columnCounter).ToString() & " "

            ' if the row lindex is less than the last index
            ' and the column counter is the last column
            ' move to the next row and reset the column to the start
            If rowCounter < numberRowLastIndex Then

                'move to the next row
                rowCounter += 1

                ' add carriage return line feed 
                ' to move to the next row
                lblEmployee3.Text += vbCrLf

            ElseIf rowCounter = numberRowLastIndex And columnCounter = numberColumnLastIndex Then
                ' if this is the last row and last index
                btnEnter.Enabled = False    ' Prevent the user from clicking Enter
                txtUnits.Text = ""          ' Clear the last data entry from the text box
                txtUnits.ReadOnly = True    ' Prevent the user from entering new text in units box
                btnReset().Focus()          ' Set focus to Reset Button for usability
            Else
                ' increment the column counter
                columnCounter += 1
                'move to the next row
                rowCounter = 0
                TOTAL_AVG = TOTAL_AVG + averageArray(units)
            End If

            ' clear the input text box
            txtUnits.Text = String.Empty
        End If

    End Sub

    ''' <summary>
    '''     Resets form to initial state
    ''' </summary>
    Sub resetForm()
        ' Reset variables
        day = 1
        Array.Clear(units, 0, units.Length)

        ' Reset fields and labels
        txtUnits.Text = ""
        lblDay.Text = "Day 1"
        lblEmployee1.Text = ""
        lblEmployee2.Text = ""
        lblEmployee3.Text = ""
        lblEmployee1AvgDisplay.Text = ""
        lblEmployee2AvgDisplay.Text = ""
        lblEmployee3AvgDisplay.Text = ""
        lblTotalAvgDisplay.Text = ""
        columnCounter = 0
        rowCounter = 0
        TOTAL_AVG = 0
        ' Ensure user's ability to enter data
        btnEnter.Enabled = True
        txtUnits.ReadOnly = False
        lblEmployee1Prompt.Font = New Font(lblEmployee1Prompt.Font, FontStyle.Bold)

        ' Set focus back to input box for usability
        txtUnits.Focus()
    End Sub
#End Region

#Region "Event Handlers"

    ''' <summary>
    ''' btn2dJaggedEnter_Click - enters the value entered by the user into the numberArray and displays it in the output label
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim userInput As String = txtUnits.Text ' Take user data and store it for use

        If (validateInput(userInput)) Then ' Check if data entered by user is valid

            units(day - 1) = Convert.ToInt32(userInput) ' Add new unit value to array of units

            Call updateDataDisplay()               ' Update display to show new units

            If (day < 7) Then   ' Check if there is still data to be entered
                day = day + 1                               ' Increment day counter to next day
                lblDay.Text = "Day " + day.ToString  ' Display updated day count
            Else ' No new data to be entered
                If (btnEnter.Enabled = False) Then
                    lblDay.Text = "Done"
                    lblEmployee3AvgDisplay.Text = "Average: " + averageArray(units).ToString ' Display the rounded average
                    TOTAL_AVG = TOTAL_AVG + averageArray(units)
                    TOTAL_AVG = TOTAL_AVG / 3
                    TOTAL_AVG = Math.Round(TOTAL_AVG, 2)
                    lblTotalAvgDisplay.Text = "Average per day: " + TOTAL_AVG.ToString ' Display the rounded average
                    lblEmployee3Prompt.Font = New Font(lblEmployee3Prompt.Font, FontStyle.Regular)
                Else
                    day = 1

                End If
            End If

        Else
            MessageBox.Show("Please ensure the units shipped are between 0 and 1000!", "Invalid Entry", MessageBoxButtons.OK)
            txtUnits.Text = ""
        End If
    End Sub

    ''' <summary>
    '''     Handles exit button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit() ' Gracefully tell the application to exit
    End Sub

    ''' <summary>
    '''     Handles Reset Button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call resetForm()    ' Reset the form
    End Sub

#End Region
End Class