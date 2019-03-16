Option Strict On    ' Force compiler to adhere to more strict rules

' Author:         Praveen Paramanathan
' Student Number:  100706882
' File Name:      Lab3.vb
' Created:        2019/02/21
' Updated:        2019/02/22
' Description:    A VB system to take user inputed units, store them, and return the
'                 average units shipped per day and per employee over the period entered

Public Class frmAverageUnitsShippedByEmployee

#Region "Variable and constant Declaration"
    ' form/class level constants
    Private Const numberRowColumnLabels As Integer = 7  ' how many RowColumn labels will there be 6
    Private Const numberValueLabels As Integer = 7      ' how many value labels will there be 6
    Private Const numberControlArrays As Integer = 3    ' how many control array will be held by the jagged array 2

    Private Const numberColumnLastIndex As Integer = 2  ' what is the last column index for the 2d array
    Private Const numberRowLastIndex As Integer = 6     ' what is the last row index for the 2d array

    Private Const indexValueLabels As Integer = 0       ' holds the index of the Value labels
    Private Const indexRowColumnLabels As Integer = 1   ' holds the index of the RowColumn labels

    ' form/class level control arrays
    Private valueLabels(numberValueLabels - 1) As Label         ' create an array to hold the Value labels
    Private rowColumnLabels(numberRowColumnLabels - 1) As Label   ' create an array to hold the RowColumn labels

    ' form/class level jagged array an array of arrays
    ' set the last index to be 1 as numberControlArrays is 2 - 1 = 1
    Private allControls(numberControlArrays - 1) As Object

    ' 2 dimensional array
    ' 2 columns = 1
    ' 3 rows = 2
    Private numberArray(numberRowLastIndex, numberColumnLastIndex) As Double

    Private columnCounter As Integer = 0
    Private rowCounter As Integer = 0

    ' Declare Constants
    Const MIN_INPUTS As Integer = 0      ' Minimum allowed unit volume
    Const MAX_INPUTS As Integer = 1000   ' Maximum allowed unit volume

    ' Declare Variables
    Dim units(6) As Integer ' Holds entered units
    Dim day As Integer = 1  ' Holds current day of data entry

#End Region

#Region "Functions and Subs"

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
        ' Ensure user's ability to enter data
        btnEnter.Enabled = True
        txtUnits.ReadOnly = False

        ' Set focus back to input box for usability
        txtUnits.Focus()
    End Sub

    ''' <summary>
    '''     Updates data display to contain values currently stored in units array
    ''' </summary>
    Sub updateDataDisplay1()

        ' output the number to the output label
        lblEmployee1.Text += numberArray(rowCounter, columnCounter).ToString() & " "

        ' if the row lindex is less than the last index
        ' and the column counter is the last column
        ' move to the next row and reset the column to the start
        If rowCounter < numberRowLastIndex And columnCounter = numberColumnLastIndex Then

            'move to the next row
            rowCounter += 1

            'reset to the first column
            columnCounter = 0

            ' add carriage return line feed 
            ' to move to the next row
            lblEmployee1.Text += vbCrLf

        ElseIf rowCounter = numberRowLastIndex And columnCounter = numberColumnLastIndex Then
            ' if this is the last row and last index

            ' disable the control so the user cannot enter 
            ' any more numbers
            btnEnter.Enabled = False

        Else

            ' increment the column counter
            columnCounter += 1
        End If

        ' clear the input text box
        lblEmployee1.Text = String.Empty
        'lblEmployee1.Text += newData + vbCrLf
    End Sub

    ''' <summary>
    '''     Updates data display to contain values currently stored in units array
    ''' </summary>
    Sub updateDataDisplay2()

        ' output the number to the output label
        lblEmployee2.Text += numberArray(rowCounter, columnCounter).ToString() & " "

        ' if the row lindex is less than the last index
        ' and the column counter is the last column
        ' move to the next row and reset the column to the start
        If rowCounter < numberRowLastIndex And columnCounter = numberColumnLastIndex Then

            'move to the next row
            rowCounter += 1

            'reset to the first column
            columnCounter = 1

            ' add carriage return line feed 
            ' to move to the next row
            lblEmployee2.Text += vbCrLf

        ElseIf rowCounter = numberRowLastIndex And columnCounter = numberColumnLastIndex Then
            ' if this is the last row and last index

            ' disable the control so the user cannot enter 
            ' any more numbers
            btnEnter.Enabled = False

        Else

            ' increment the column counter
            columnCounter += 1
        End If

        ' clear the input text box
        lblEmployee2.Text = String.Empty
        'lblEmployee2.Text += newData + vbCrLf
    End Sub

    ''' <summary>
    '''     Updates data display to contain values currently stored in units array
    ''' </summary>
    Sub updateDataDisplay3()

        ' output the number to the output label
        lblEmployee3.Text += numberArray(rowCounter, columnCounter).ToString() & " "

        ' if the row lindex is less than the last index
        ' and the column counter is the last column
        ' move to the next row and reset the column to the start
        If rowCounter < numberRowLastIndex And columnCounter = numberColumnLastIndex Then

            'move to the next row
            rowCounter += 1

            'reset to the first column
            columnCounter = 2

            ' add carriage return line feed 
            ' to move to the next row
            lblEmployee3.Text += vbCrLf

        ElseIf rowCounter = numberRowLastIndex And columnCounter = numberColumnLastIndex Then
            ' if this is the last row and last index

            ' disable the control so the user cannot enter 
            ' any more numbers
            btnEnter.Enabled = False

        Else

            ' increment the column counter
            columnCounter += 1
        End If

        ' clear the input text box
        lblEmployee3.Text = String.Empty
        'lblEmployee3.Text += newData + vbCrLf
    End Sub

    ''' <summary>
    '''     Validates inputed user data
    ''' </summary>
    ''' <param name="input">User input to be validated</param>
    ''' <returns>Whether the input was valid or invalid as boolean</returns>
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

    ''' <summary>
    '''     Returns the average value of a provided array
    ''' </summary>
    ''' <param name="arrayToAverage">Array to be averaged</param>
    ''' <returns>Average of provided array</returns>
    Function averageArray(ByVal arrayToAverage() As Integer) As Double
        Dim runningTotal As Integer ' Holds a running total of the values in the array

        ' Example of a For Each loop in VB
        For Each dailyTotal In arrayToAverage  ' Loop through the array
            runningTotal += dailyTotal  ' Add the current value to the running total
        Next

        averageArray = Math.Round(runningTotal / arrayToAverage.Length, 2) ' Return the average value of the array, rounded to 2 decimal places
    End Function

#End Region

#Region "Event Handlers"

    ''' <summary>
    '''     Handles enter button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim userInput As String = txtUnits.Text ' Take user data and store it for use

        If (validateInput(userInput)) Then ' Check if data entered by user is valid

            units(day - 1) = Convert.ToInt32(userInput) ' Add new unit value to array of units
            If (columnCounter = 0 And day < 7) Then
                Call updateDataDisplay1()               ' Update display to show new units
            ElseIf (columnCounter = 1 And day < 7) Then
                lblEmployee1AvgDisplay.Text = "Average: " + averageArray(units).ToString ' Display the rounded average
                Call updateDataDisplay2()               ' Update display to show new units
            Else
                lblEmployee2AvgDisplay.Text = "Average: " + averageArray(units).ToString ' Display the rounded average
                Call updateDataDisplay3()
            End If
            If (day < 7 And columnCounter = 4) Then   ' Check if there is still data to be entered
                    day = day + 1                               ' Increment day counter to next day
                    lblDay.Text = "Day " + day.ToString  ' Display updated day count
                Else ' No new data to be entered
                    btnEnter.Enabled = False    ' Prevent the user from pressing enter
                    txtUnits.ReadOnly = True    ' Prevent the user from entering new text in units box
                lblTotalAvgDisplay.Text = "Average: " + averageArray(units).ToString ' Display the rounded average
            End If

            Else
                MessageBox.Show("Please ensure the units shipped are between 0 and 1000!", "Invalid Entry", MessageBoxButtons.OK)
        End If

        txtUnits.Focus()    ' Set focus back to entry box for usability
        txtUnits.Text = ""  ' Clear the last data entry from the text box
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

    Private Sub frmAverageUnitsShippedByEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region
End Class
