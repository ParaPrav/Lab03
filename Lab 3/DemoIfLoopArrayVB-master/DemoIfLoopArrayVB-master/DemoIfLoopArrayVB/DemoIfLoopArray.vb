
Option Strict On

''' <summary>
''' Author: Alfred Massardo
''' Project Name: DemoIfLoopArrayVB
''' Date: 01-Jan-2018
''' Description: Application to demonstrate various VB constructs.
''' </summary>

Public Class frmDemoIfLoopArray

#Region "If"

    ''' <summary>
    ''' Enter a number and click Enter. 
    ''' It will test If the number Is a... 
    '''    1. Number 
    '''    2. Double 
    '''    3. Integer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnIfDemo_Click(sender As Object, e As EventArgs) Handles btnIfDemo.Click


        ' variables
        Dim userInput As String = String.Empty  ' Holds the user input as a string
        Dim userInputDouble As Double = 0.0     ' Holds the user input if it converts to a Double
        Dim userInputInteger As Integer = 0     ' Holds the user input if it converts to a Integer
        Dim output As String = String.Empty     ' Holds the output to be displayed to the user

        ' Enter a break point on userInput = tbIfInput.Text and you can 
        ' watch the execution of the code from start to finish
        ' press...
        '   F10 - step over
        '   F11 - step into (this is when you want to step into functions)
        userInput = tbIfInput.Text  ' Get the input from the text box


        If (Integer.TryParse(userInput, userInputInteger)) Then ' If the input is an Integer

            ' create the message to be output to the user
            output = userInputInteger.ToString("n0") & " = Integer"

        ElseIf (Double.TryParse(userInput, userInputDouble)) Then ' If the input is an Double

            ' create the message to be output to the user
            output = userInputDouble.ToString("n2") & " = Double"

        Else ' Otherwise the input is Not a Number

            ' create the message to be output to the user
            output = userInput & " = Not a Number (NaN)"

        End If

        ' output the message to the user
        lbIfOutput.Text = output

    End Sub

#End Region

#Region "Nested If"

    ''' <summary>
    ''' Enter a number and click Enter. 
    ''' It will test If the number Is a... 
    '''    1. Number 
    '''    2. Double 
    '''    3. Integer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnNestedIfDemo_Click(sender As Object, e As EventArgs) Handles btnNestedIfDemo.Click

        ' variables
        Dim userInput As String = String.Empty  ' Holds the user input as a string
        Dim userInputDouble As Double = 0.0     ' Holds the user input if it converts to a Double
        Dim userInputInteger As Integer = 0     ' Holds the user input if it converts to a Integer
        Dim output As String = String.Empty     ' Holds the output to be displayed to the user

        ' Enter a break point on userInput = tbNestedIfInput.Text and you can 
        ' watch the execution of the code from start to finish
        ' press...
        '   F10 - step over
        '   F11 - step into (this is when you want to step into functions)

        userInput = tbNestedIfInput.Text  ' Get the input from the text box

        If (Double.TryParse(userInput, userInputDouble)) Then ' If the input is an Double

            If (Integer.TryParse(userInput, userInputInteger)) Then ' If the input is an Integer


                ' create the message to be output to the user
                ' processing
                output = userInputInteger.ToString("n0") & " = Integer"

            Else

                ' create the message to be output to the user
                ' invalid input integer required
                output = "Integer required " & userInputDouble.ToString("n2") & " = Double"

            End If


        Else ' Otherwise the input is Not a Number

            ' create the message to be output to the user
            ' invalid input integer required
            output = "Integer required " & userInput & " = Not a Number (NaN)"

        End If

        ' output the message to the user
        lbNestedIfOutput.Text = output

    End Sub

#End Region

#Region "For Loop"

    ''' <summary>
    ''' Enter a number and click Enter. 
    ''' This will Loop until the number 
    ''' you have entered Is reached.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnForLoopDemo_Click(sender As Object, e As EventArgs) Handles btnForLoopDemo.Click

        ' variables
        Dim userInput As String = String.Empty  ' Holds the user input as a string
        Dim userInputDouble As Double = 0.0     ' Holds the user input if it converts to a Double
        Dim userInputInteger As Integer = 0     ' Holds the user input if it converts to a Integer
        Dim output As String = String.Empty     ' Holds the output to be displayed to the user

        userInput = tbForLoopDemoInput.Text  ' Get the input from the text box

        If (Double.TryParse(userInput, userInputDouble)) Then ' If the input is an Double

            If (Integer.TryParse(userInput, userInputInteger)) Then ' If the input is an Integer


                ' processing

                ' Enter a break point on For counter As Integer = 1 To userInputInteger and you can 
                ' watch the execution of the code from start to finish
                ' press...
                '   F10 - step over
                '   F11 - step into (this is when you want to step into functions)

                ' loop starting at the number 1
                ' until the counter has reached
                ' the number the user has input
                '      initializer;        condition;              iterat
                For counter As Integer = 1 To userInputInteger ' initialize the variable and specifies the test

                    ' append number to the output
                    output += counter.ToString & " "

                    ' 1 2 3 4 5
                Next counter 'pseudo incrementer - even If the counter was Not beside Next it would still increment
                ' iterator

            Else

                ' create the message to be output to the user
                ' invalid input integer required
                output = "Integer required " & userInputDouble.ToString("n2") & " = Double"

            End If


        Else ' Otherwise the input is Not a Number

            ' create the message to be output to the user
            ' invalid input integer required
            output = "Integer required " & userInput & " = Not a Number (NaN)"

        End If

        ' output the message to the user
        lbForLoopDemoOutput.Text = output

    End Sub
#End Region

#Region "For Loop with Break"

    ''' <summary>
    ''' Enter a number and click Enter. 
    ''' This will Loop until the number entered  
    ''' is reached or until the loop limit is reached.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnForLoopBreakDemo_Click(sender As Object, e As EventArgs) Handles btnForLoopBreakDemo.Click

        Const loopLimit As Integer = 20

        ' variables
        Dim userInput As String = String.Empty  ' Holds the user input as a string
        Dim userInputDouble As Double = 0.0     ' Holds the user input if it converts to a Double
        Dim userInputInteger As Integer = 0     ' Holds the user input if it converts to a Integer
        Dim output As String = String.Empty     ' Holds the output to be displayed to the user

        userInput = tbForLoopBreakDemoInput.Text  ' Get the input from the text box

        If (Double.TryParse(userInput, userInputDouble)) Then ' If the input is an Double

            If (Integer.TryParse(userInput, userInputInteger)) Then ' If the input is an Integer

                ' processing

                ' Enter a break point on For counter As Integer = 1 To userInputInteger and you can 
                ' watch the execution of the code from start to finish
                ' press...
                '   F10 - step over
                '   F11 - step into (this is when you want to step into functions)

                ' loop starting at the number 1
                ' until the counter has reached
                ' the number the user has input
                For counter As Integer = 1 To loopLimit ' initialize the variable and specifies the test

                    ' append number to the output
                    output += counter.ToString & " " ' & vbCrLf

                    ' Check if the counter has reached 
                    ' the user input
                    If userInputInteger = counter Then

                        ' set the counter to the loopLimit
                        ' to stop the loop
                        counter = loopLimit

                        ' no breaks or continues required

                    End If

                Next counter ' pseudo incrementer - even if the counter was not beside Next it would still increment

            Else

                ' create the message to be output to the user
                ' invalid input integer required
                output = "Integer required " & userInputDouble.ToString("n2") & " = Double"

            End If


        Else ' Otherwise the input is Not a Number

            ' create the message to be output to the user
            ' invalid input integer required
            output = "Integer required " & userInput & " = Not a Number (NaN)"

        End If

        ' output the message to the user
        lbForLoopBreakDemoOutput.Text = output

    End Sub
#End Region

#Region "While Loop"

    ''' <summary>
    ''' Enter a number and click Enter. 
    ''' This will Loop until the number 
    ''' you have entered Is reached.
    ''' </summary>
    ''' <param name="sender"></param>
    Private Sub btnWhileLoopDemoOutput_Click(sender As Object, e As EventArgs) Handles btnWhileLoopDemo.Click


        ' variables
        Dim userInput As String = String.Empty  ' Holds the user input as a string
        Dim userInputDouble As Double = 0.0     ' Holds the user input if it converts to a Double
        Dim userInputInteger As Integer = 0     ' Holds the user input if it converts to a Integer
        Dim output As String = String.Empty     ' Holds the output to be displayed to the user
        Dim counter As Integer = 1              ' Holds the an interger used to count 

        userInput = tbWhileLoopDemoInput.Text  ' Get the input from the text box

        If (Double.TryParse(userInput, userInputDouble)) Then ' If the input is an Double

            If (Integer.TryParse(userInput, userInputInteger)) Then ' If the input is an Integer


                ' processing

                ' Enter a break point on For counter As Integer = 1 To userInputInteger and you can 
                ' watch the execution of the code from start to finish
                ' press...
                '   F10 - step over
                '   F11 - step into (this is when you want to step into functions)

                ' loop starting at the number 1
                ' until the counter has reached
                ' the number the user has input

                While (counter <= userInputInteger)

                    ' append number to the output
                    output += counter.ToString & " "

                    ' increment counter
                    counter += 1

                End While

            Else

                ' create the message to be output to the user
                ' invalid input integer required
                output = "Integer required " & userInputDouble.ToString("n2") & " = Double"

            End If


        Else ' Otherwise the input is Not a Number

            ' create the message to be output to the user
            ' invalid input integer required
            output = "Integer required " & userInput & " = Not a Number (NaN)"

        End If

        ' output the message to the user
        lbWhileLoopDemoOutput.Text = output

    End Sub
#End Region

#Region "While Loop with Break"

    ''' <summary>
    ''' Enter a number and click Enter. 
    ''' This will Loop until the number entered  
    ''' is reached or until the loop limit is reached.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnWhileLoopBreakDemoOutput_Click(sender As Object, e As EventArgs) Handles btnWhileLoopBreakDemo.Click

        Const loopLimit As Integer = 15

        ' variables
        Dim userInput As String = String.Empty  ' Holds the user input as a string
        Dim userInputDouble As Double = 0.0     ' Holds the user input if it converts to a Double
        Dim userInputInteger As Integer = 0     ' Holds the user input if it converts to a Integer
        Dim output As String = String.Empty     ' Holds the output to be displayed to the user
        Dim counter As Integer = 1              ' Holds the an interger used to count 

        userInput = tbWhileLoopBreakDemoInput.Text  ' Get the input from the text box

        If (Double.TryParse(userInput, userInputDouble)) Then ' If the input is an Double

            If (Integer.TryParse(userInput, userInputInteger)) Then ' If the input is an Integer


                ' processing

                ' Enter a break point on For counter As Integer = 1 To userInputInteger and you can 
                ' watch the execution of the code from start to finish
                ' press...
                '   F10 - step over
                '   F11 - step into (this is when you want to step into functions)

                ' loop starting at the number 1
                ' until the counter has reached
                ' the number the user has input

                While (counter <= loopLimit)

                    ' append number to the output
                    output += counter.ToString & " "

                    ' Check if the counter has reached 
                    ' the user input
                    If userInputInteger = counter Then

                        ' set the counter to the loopLimit
                        ' to stop the loop
                        counter = loopLimit + 1

                        ' no breaks or continues required
                    Else

                        ' increment counter
                        counter += 1

                    End If


                End While

            Else

                ' create the message to be output to the user
                ' invalid input integer required
                output = "Integer required " & userInputDouble.ToString("n2") & " = Double"

            End If


        Else ' Otherwise the input is Not a Number

            ' create the message to be output to the user
            ' invalid input integer required
            output = "Integer required " & userInput & " = Not a Number (NaN)"

        End If

        ' output the message to the user
        lbWhileLoopBreakDemoOutput.Text = output

    End Sub
#End Region

#Region "Do While Loop"

    ''' <summary>
    ''' Enter a number and click Enter. 
    ''' This will Loop until the number 
    ''' you have entered Is reached.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDoWhileLoopDemo_Click(sender As Object, e As EventArgs) Handles btnDoWhileLoopDemo.Click


        ' variables
        Dim userInput As String = String.Empty  ' Holds the user input as a string
        Dim userInputDouble As Double = 0.0     ' Holds the user input if it converts to a Double
        Dim userInputInteger As Integer = 0     ' Holds the user input if it converts to a Integer
        Dim output As String = String.Empty     ' Holds the output to be displayed to the user
        Dim counter As Integer = 1              ' Holds the an interger used to count 

        userInput = tbDoWhileLoopDemoInput.Text  ' Get the input from the text box

        If (Double.TryParse(userInput, userInputDouble)) Then ' If the input is an Double

            If (Integer.TryParse(userInput, userInputInteger)) Then ' If the input is an Integer


                ' processing

                ' Enter a break point on For counter As Integer = 1 To userInputInteger and you can 
                ' watch the execution of the code from start to finish
                ' press...
                '   F10 - step over
                '   F11 - step into (this is when you want to step into functions)

                ' loop starting at the number 1
                ' until the counter has reached
                ' the number the user has input
                Do

                    ' append number to the output
                    output += counter.ToString & " "

                    ' increment counter
                    counter += 1

                Loop While (counter <= userInputInteger)

            Else

                ' create the message to be output to the user
                ' invalid input integer required
                output = "Integer required " & userInputDouble.ToString("n2") & " = Double"

            End If


        Else ' Otherwise the input is Not a Number

            ' create the message to be output to the user
            ' invalid input integer required
            output = "Integer required " & userInput & " = Not a Number (NaN)"

        End If

        ' output the message to the user
        lbDoWhileLoopDemoOutput.Text = output


    End Sub

#End Region

#Region "Do While Loop with Break"

    ''' <summary>
    ''' Enter a number and click Enter. 
    ''' This will Loop until the number entered  
    ''' is reached or until the loop limit is reached.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDoWhileLoopBreakDemo_Click_1(sender As Object, e As EventArgs) Handles btnDoWhileLoopBreakDemo.Click

        Const loopLimit As Integer = 18

        ' variables
        Dim userInput As String = String.Empty  ' Holds the user input as a string
        Dim userInputDouble As Double = 0.0     ' Holds the user input if it converts to a Double
        Dim userInputInteger As Integer = 0     ' Holds the user input if it converts to a Integer
        Dim output As String = String.Empty     ' Holds the output to be displayed to the user
        Dim counter As Integer = 1              ' Holds the an interger used to count 

        userInput = tbDoWhileLoopBreakDemoInput.Text  ' Get the input from the text box

        If (Double.TryParse(userInput, userInputDouble)) Then ' If the input is an Double

            If (Integer.TryParse(userInput, userInputInteger)) Then ' If the input is an Integer


                ' processing

                ' Enter a break point on For counter As Integer = 1 To userInputInteger and you can 
                ' watch the execution of the code from start to finish
                ' press...
                '   F10 - step over
                '   F11 - step into (this is when you want to step into functions)

                ' loop starting at the number 1
                ' until the counter has reached
                ' the number the user has input

                Do

                    ' append number to the output
                    output += counter.ToString & " "

                    If userInputInteger = counter Then

                        ' set the counter to the loopLimit
                        ' to stop the loop
                        counter = loopLimit

                    End If

                    ' increment counter
                    counter += 1

                Loop While (counter <= loopLimit)

            Else

                ' create the message to be output to the user
                ' invalid input integer required
                output = "Integer required " & userInputDouble.ToString("n2") & " = Double"

            End If


        Else ' Otherwise the input is Not a Number

            ' create the message to be output to the user
            ' invalid input integer required
            output = "Integer required " & userInput & " = Not a Number (NaN)"

        End If

        ' output the message to the user
        lbDoWhileLoopBreakDemoOutput.Text = output

    End Sub
#End Region

#Region "Create an Array"

    ''' <summary>
    ''' Enter a number and click Enter. 
    ''' This will create an array Of the 
    ''' number of elements specified. 
    ''' Then each element of the array
    ''' will be filled by looping the array 
    ''' and countingby 2s.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCreateArrayDemo_Click(sender As Object, e As EventArgs) Handles btnCreateArrayDemo.Click

        Const minimumArraySize As Integer = 1

        ' variables
        Dim userInput As String = String.Empty  ' Holds the user input as a string
        Dim userInputDouble As Double = 0.0     ' Holds the user input if it converts to a Double
        Dim userInputInteger As Integer = 0     ' Holds the user input if it converts to a Integer
        Dim output As String = String.Empty     ' Holds the output to be displayed to the user
        Dim demoArray() As Integer

        userInput = tbCreateArrayInput.Text  ' Get the input from the text box

        If (Double.TryParse(userInput, userInputDouble)) Then ' If the input is an Double

            If (Integer.TryParse(userInput, userInputInteger) AndAlso ' If the input is an Integer
               userInputInteger >= minimumArraySize) Then             ' Also, there must be at least 1 element

                ' processing

                ' create the array with the number of 
                ' elements specifiedby the iuser
                ' The reason for the -1 is the VB is
                ' a little different than other languages
                ' like c#. If you create the array with a 
                ' size of 10 it will create an array with
                ' 11 elements, 0 - 10 inclusive.
                demoArray = New Integer(userInputInteger - 1) {}

                ' Enter a break point on For counter As Integer = 1 To userInputInteger and you can 
                ' watch the execution of the code from start to finish
                ' press...
                '   F10 - step over
                '   F11 - step into (this is when you want to step into functions)

                ' loop starting at the number 0
                ' until the index has reached
                ' the length/size of the array
                ' -1. (Zero based index)
                For index As Integer = 0 To demoArray.Length - 1 ' initialize the variable and specifies the test

                    ' fill the element at the
                    ' index specified
                    demoArray(index) = (index + 1) * 2

                Next index ' pseudo incrementer - even if the index was not beside Next it would still increment

                ' loop starting at the number 0
                ' until the index has reached
                ' the length/size of the array
                ' -1. (Zero based index)
                For index As Integer = 0 To demoArray.Length - 1 ' initialize the variable and specifies the test

                    ' append number to the output
                    output += demoArray(index).ToString() & " " ' & vbCrLf
                    ' 2 4 6 8 10 12...
                    ' 2
                    ' 4
                    ' 6
                    ' ...
                Next index ' pseudo incrementer - even if the index was not beside Next it would still increment

            Else

                ' create the message to be output to the user
                ' invalid input integer required
                output = "Arrays size must be an Integer/Whole number with a minimum value of " & minimumArraySize.ToString() & vbCrLf & "Your input was " & userInputDouble.ToString("n0")

            End If

        Else ' Otherwise the input is Not a Number

            ' create the message to be output to the user
            ' invalid input integer required
            output = "Integer required " & userInput & " = Not a Number (NaN)"

        End If

        ' output the message to the user
        lbCreateArrayOutput.Text = output

    End Sub

#End Region

#Region "Add Method/Function Demo"

    ''' <summary>
    ''' btnAddDemo_Click - event that fires when the btnAddDemo is click and demonstrates a method function by calling a simple add method/function.
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    Private Sub btnAddDemo_Click(sender As Object, e As EventArgs) Handles btnAddDemo.Click

        Dim inputNumberOneString As String = String.Empty   ' holds the string assigned from text box one
        Dim inputNumberTwoString As String = String.Empty   ' holds the string assigned from text box two
        Dim inputNumberOne As Double = 0.0                  ' holds the double converted and assigned from input number one string.
        Dim inputNumberTwo As Double = 0.0                  ' holds the double converted and assigned from input number two string.
        Dim summedNumber As Double = 0.0                    ' holds the double assigned from Add function.

        ' get the input from the textboxes
        inputNumberOneString = tbNumberOne.Text     ' get the string input from text box one
        inputNumberTwoString = tbNumberTwo.Text     ' get the string input from text box two

        ' convert the string input to doubles
        ' ( I'm not validating to see if the strings are doubles, so the code is much simpler. The concept to be learned here is how to create and call a method/function)
        inputNumberOne = Convert.ToDouble(inputNumberOneString) ' convert the 1st number string to a double and assign it to the input number one (double) variable
        inputNumberTwo = Convert.ToDouble(inputNumberTwoString) ' convert the 2st number string to a double and assign it to the input number two (double) variable

        ' call the Add method/function and pass it the two double variables
        ' the 1st argument passed is the input number one (double) variable
        ' the 2nd argument passed is the input number two (double) variable.
        ' The returned value of the function is assigned (=) to the summed number (double) variable
        summedNumber = Add(inputNumberOne, inputNumberTwo)

        ' display the the result to the user by
        ' converting all three variable to strings
        ' and contatenating them to show a simple 
        ' addition math equation.
        lbAddDemoOutput.Text = summedNumber.ToString("n2") & " = " & inputNumberOne.ToString("n2") & " + " & inputNumberTwo.ToString("n2")

    End Sub

    ''' <summary>
    ''' Add - Adds two numbers
    '''     *** Function is a self contained area of code that contains one or more lines of code that can be called by another procedure and returns a value to the calling code. 
    ''' </summary>
    ''' <param name="numberOne">Double</param>
    ''' <param name="numberTwo">Double</param>
    ''' <returns>Double - the sum of the two arguments passed to the Method/Function</returns>
    Private Function Add(numberOne As Double, numberTwo As Double) As Double
        ' Modifiers / Function / FunctionName / (Parameters) / Return DataType

        ' --------------------------------- Access Modifiers -------------------------------
        'Public             - No access restrictions. Access Is available To other projects, applications, etc. 
        '                       (Public should be your last consideration When deciding on an access modifier.)
        'Protected          - Access limited to containing And inherited classes. Inheritance will be covered fully in NETD II
        'Private            - Access limited To containing Class, module or structure.
        '                       (Private should be your first consideration When deciding on an access modifier.)
        'Friend             - Access limited to the current project.
        'Protected Friend   - Access limited to containing And inherited classes And the current project.
        'https://docs.microsoft.com/en-us/dotnet/visual-basic/programming-guide/language-features/declared-elements/access-levels
        ' ----------------------------------------------------------------------------------

        ' Statements - start

        ' declare a variable to hold the return value that will be summed
        ' based on the two
        Dim returnSumNumber As Double = 0.0

        ' add number one and number two and assign the
        ' value to return sum mumber.
        returnSumNumber = numberOne + numberTwo

        ' return the value in return sum number
        ' back to the code that called our Add
        ' method
        Return returnSumNumber

        ' Statements - end

    End Function

    ''' <summary>
    ''' Add - Adds any number of numbers, but the numbers must be passed in as a double array
    ''' </summary>
    ''' <param name="numbers">Double()</param>
    ''' <returns>Double - the sum of the array argument passed to the Method/Function</returns>
    Private Function Add(numbers As Double()) As Double

        ' declare a variable to hold the return value that will be summed
        ' based on the summed numbers in the array
        Dim returnSummedNumber As Double = 0.0


        ' loop the array And continually add
        ' the current element to the summed number to be returned
        For index As Integer = 0 To numbers.Length - 1

            ' add the current numbers element to
            ' the summed number to be returned
            returnSummedNumber += numbers(index)

        Next index

        ' return the value in return sum number
        ' back to the code that called our Add
        ' method
        Return returnSummedNumber

    End Function

#End Region

#Region "Method Demo/Advanced"

    ''' <summary>
    ''' Enter a number and click Enter. 
    ''' This will create an array Of the 
    ''' number of elements specified. 
    ''' Then each element of the array
    ''' will be filled by looping the array 
    ''' and counting by 2s. Uses a 
    ''' method to create the array And 
    ''' a method To create output.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnMethodDemo_Click(sender As Object, e As EventArgs) Handles btnMethodDemo.Click

        ' variables
        Dim userInput As String = String.Empty  ' Holds the user input as a string
        Dim userInputInteger As Integer = 0     ' Holds the user input if it converts to a Integer
        Dim output As String = String.Empty     ' Holds the output to be displayed to the user
        Dim demoArray() As Integer              ' Holds the values

        userInput = tbMethodInput.Text  ' Get the input from the text box

        ' check if the user input passes validation
        If IsValidInput(userInput, userInputInteger) Then

            ' Processing

            ' Enter a break point on For counter As Integer = 1 To userInputInteger and you can 
            ' watch the execution of the code from start to finish
            ' press...
            '   F10 - step over
            '   F11 - step into (this is when you want to step into functions)

            ' create the array
            demoArray = CreateAndLoadArray(userInputInteger)

            ' Output
            ' loop starting at the number 0
            ' until the index has reached
            ' the length/size of the array
            ' -1. (Zero based index)
            output = CreateOutput(demoArray)

            ' output the message to the user
            lbMethodOutput.Text = output

        End If


    End Sub

    ''' <summary>
    ''' IsValidInput - check the input to determine if it is a number and also confirms if it is a whole number.
    ''' </summary>
    ''' <param name="userInput">ByVal String</param>
    ''' <param name="returnInputInteger">ByRef - Integer</param>
    ''' <returns></returns>
    Private Function IsValidInput(ByVal userInput As String, ByRef validInputInteger As Integer) As Boolean

        Const minimumArraySize As Integer = 1

        Dim userInputDouble As Double = 0.0     ' Holds the user input if it converts to a Double
        Dim userInputInteger As Integer = 0     ' Holds the user input if it converts to a Integer
        Dim returnValue As Boolean = True       ' Holds the value that return to the calling code True if it passed validation. False if it did not.
        Dim output As String = String.Empty     ' Holds the output to be displayed to the user

        If (Double.TryParse(userInput, userInputDouble)) Then ' If the input is an Double

            If (Integer.TryParse(userInputDouble.ToString(), userInputInteger) AndAlso ' If the input is an Integer
               userInputInteger >= minimumArraySize) Then             ' Also, there must be at least 1 element

                ' set the valid input integer to be passed back to the calling code.
                validInputInteger = userInputInteger

                ' set the return boolean to true as it passed validation
                returnValue = True

            Else

                ' create the message to be output to the user
                ' invalid input integer required
                output = "Arrays size must be an Integer/Whole number with a minimum value of " & minimumArraySize.ToString() & vbCrLf & "Your input was " & userInputDouble.ToString("n0")

                ' set the valid input integer to be passed back to the calling code.
                validInputInteger = 0

                ' set to false as it did not pass validation
                returnValue = False

            End If

        Else ' Otherwise the input is Not a Number

            ' create the message to be output to the user
            ' invalid input integer required
            output = "Integer required " & userInput & " = Not a Number (NaN)"

            ' set the valid input integer to be passed back to the calling code.
            validInputInteger = 0

            ' set to false as it did not pass validation
            returnValue = False

        End If


        ' if the return value is false,
        ' as it did not pass validation,
        ' show the message in the output
        ' label
        If returnValue = False Then

            ' output the message to the user
            lbMethodOutput.Text = output

        End If

        ' return the boolean True if it passed validation, False if it did not
        Return returnValue

    End Function

    ''' <summary>
    ''' Function that accepts an integer representing the length 
    ''' of size of the array. It creates the array And then proceeds
    ''' to fill each element counting up by 2s.
    ''' </summary>
    ''' <param name="arrayLength"></param>
    ''' <returns>array of type integer</returns>
    Private Function CreateAndLoadArray(arrayLength As Integer) As Integer()

        ' create the array with the number of 
        ' elements specifiedby the user
        ' The reason for the -1 is the VB is
        ' a little different than other languages
        ' like c#. If you create the array with a 
        ' size of 10 it will create an array with
        ' 11 elements, 0 - 10 inclusive.

        ' create the array with the number of 
        ' elements specified by the user
        Dim returnArray() = New Integer(arrayLength - 1) {}

        ' Enter a break point on For counter As Integer = 1 To userInputInteger And you can 
        ' watch the execution of the code from start to finish
        ' press...
        '   F10 - step over
        '   F11 - step into (this Is when you want to step into functions)

        ' loop starting at the number 0
        ' until the index has reached
        ' the length/size of the array
        ' -1. (Zero based index)

        For index As Integer = 0 To returnArray.Length - 1

            ' append number to the output
            returnArray(index) = (index + 1) * 2

        Next index

        ' return the New array 
        ' to the calling code
        Return returnArray

    End Function

    ''' <summary>
    ''' Function that accepts an integer array as an argument.
    ''' It then loops through the array And create a string
    ''' based on the values in the array.
    ''' </summary>
    ''' <param name="arrayOfValues">integer array</param>
    ''' <returns>string</returns>
    Private Function CreateOutput(arrayOfValues() As Integer) As String
        Dim returnValue As String = String.Empty

        ' loop starting at the number 0
        ' until the index has reached
        ' the length/size of the array
        ' -1. (Zero based index)
        For index As Integer = 0 To arrayOfValues.Length - 1

            ' append number to the output
            returnValue += arrayOfValues(index).ToString() & " "

        Next index

        ' return the string that was
        ' created from the array that 
        ' was passed to the function/method
        Return returnValue

    End Function

#End Region

#Region "Reset Form/Sub Demo"

    ''' <summary>
    ''' The Click event of the reset button Is fired when the
    ''' user clicks the reset button when they wish to clear the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        resetForm()
    End Sub

    ''' <summary>
    ''' Private function that loops through the form And
    ''' determines if the control should be cleared. If so,
    ''' the control Is cleared.
    '''     *** Sub is a self contained area of code that contains one or more lines of code that can be called by another procedure but does **not** return anything to the calling code. 
    ''' </summary>
    Private Sub resetForm()
        ' Modifiers / Sub / SubName / (Parameters) / No Return DataType

        ' --------------------------------- Access Modifiers -------------------------------
        'Public             - No access restrictions. Access Is available To other projects, applications, etc. 
        '                       (Public should be your last consideration When deciding on an access modifier.)
        'Protected          - Access limited to containing And inherited classes. Inheritance will be covered fully in NETD II
        'Private            - Access limited To containing Class, module or structure.
        '                       (Private should be your first consideration When deciding on an access modifier.)
        'Friend             - Access limited to the current project.
        'Protected Friend   - Access limited to containing And inherited classes And the current project.
        'https://docs.microsoft.com/en-us/dotnet/visual-basic/programming-guide/language-features/declared-elements/access-levels
        ' ----------------------------------------------------------------------------------

        ' declare a group box as 
        ' all other controls are
        ' within group boxes
        Dim groupBoxControl As GroupBox

        ' loop through each control that Is directly
        ' placed on the form (so the group boxes)
        For Each controlGroupBox As Object In Me.Controls

            ' if it Is a group box (which it will be)
            If (TypeOf (controlGroupBox) Is GroupBox) Then

                ' Convert And assign the current control to the
                ' group box variable.
                groupBoxControl = CType(controlGroupBox, GroupBox)

                ' Loop through the controls in the current group box
                For Each currentControl As Object In groupBoxControl.Controls

                    ' if the control Is a text box
                    If (TypeOf (currentControl) Is TextBox) Then

                        ' clear it
                        CType(currentControl, TextBox).Text = String.Empty

                    ElseIf (TypeOf (currentControl) Is Label) Then ' If the control Is a label

                        ' If the border style Is Fixed3D, meaning we use it
                        ' for output
                        If (CType(currentControl, Label).BorderStyle = BorderStyle.Fixed3D) Then

                            ' clear it 
                            CType(currentControl, Label).Text = String.Empty
                            ' all other labels will Not be touched
                        End If
                    End If
                Next currentControl
            End If
        Next controlGroupBox
    End Sub

#End Region

#Region "Select Case"

    ''' <summary>
    ''' Private click event to demonstrate a select case statement
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSelectCase_Click(sender As Object, e As EventArgs) Handles btnSelectCase.Click

        Dim grade As String = String.Empty      ' variable to hold the grade letter
        Dim output As String = String.Empty     ' variable to hold the output

        ' get the grade from the text box
        grade = tbSelectCase.Text.Trim()

        ' compare the grade to the
        ' ones in the different cases
        Select Case grade

            Case "A", "a"
                output = "Nice!!!"
            Case "B", "b"
                output = "Respectable!"
            Case "C", "c"
                output = "Okay, not bad!"
            Case "D", "d"
                output = "A pass, is a pass."
            Case "F", "f"
                output = "Uh oh, better hide this from the parents."
            Case Else ' if they did not pick something listed in the cases
                ' Nicely(ish), tell then to try again. 
                output = "What part of A, B, C, D, F did you not understand!" & vbCrLf & "Please try again!"
        End Select

        ' output the data to the output label
        lbSelectCaseOutput.Text = output


    End Sub



#End Region

#Region "2D & Jagged Array Demo"

    ' form/class level constants
    Private Const numberRowColumnLabels As Integer = 6  ' how many RowColumn labels will there be 6
    Private Const numberValueLabels As Integer = 6      ' how many value labels will there be 6
    Private Const numberControlArrays As Integer = 2    ' how many control array will be held by the jagged array 2

    Private Const numberColumnLastIndex As Integer = 1  ' what is the last column index for the 2d array
    Private Const numberRowLastIndex As Integer = 2     ' what is the last row index for the 2d array

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

    ''' <summary>
    ''' frmDemoIfLoopArray_Load - load the controls into the respective control arrays
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmDemoIfLoopArray_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' load the controls into the 
        ' respective control arrays

        ' load the value labels into
        ' their control array
        valueLabels(0) = lbOneValue
        valueLabels(1) = lbTwoValue
        valueLabels(2) = lbThreeValue
        valueLabels(3) = lbFourValue
        valueLabels(4) = lbFiveValue
        valueLabels(5) = lbSixValue

        ' load the row column labels into
        ' their control array
        rowColumnLabels(0) = lbOneRowColumn
        rowColumnLabels(1) = lbTwoRowColumn
        rowColumnLabels(2) = lbThreeRowColumn
        rowColumnLabels(3) = lbFourRowColumn
        rowColumnLabels(4) = lbFiveRowColumn
        rowColumnLabels(5) = lbSixRowColumn

        ' load the valueLabels control array and the
        ' rowColumnLabels  control array into the
        ' jagged array
        allControls(indexValueLabels) = valueLabels
        allControls(indexRowColumnLabels) = rowColumnLabels

    End Sub

    ''' <summary>
    ''' btn2dJaggedEnter_Click - enters the value entered by the user into the numberArray and displays it in the output label
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn2dJaggedEnter_Click(sender As Object, e As EventArgs) Handles btn2dJaggedEnter.Click

        ' input the number entered into the array
        ' no validation to simplify the code
        numberArray(rowCounter, columnCounter) = Convert.ToDouble(tb2dJaggedInput.Text)

        ' output the number to the output label
        lb2dJaggedOutput.Text += numberArray(rowCounter, columnCounter).ToString() & " "

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
            lb2dJaggedOutput.Text += vbCrLf

        ElseIf rowCounter = numberRowLastIndex And columnCounter = numberColumnLastIndex Then
            ' if this is the last row and last index

            ' disable the control so the user cannot enter 
            ' any more numbers
            btn2dJaggedEnter.Enabled = False

        Else

            ' increment the column counter
            columnCounter += 1

        End If

        ' clear the input text box
        tb2dJaggedInput.Text = String.Empty

    End Sub

    ''' <summary>
    ''' btn2dJaggedDisplay_Click - displays the content of the numberArray (2D) 
    '''                            into the rowColumnLabels and the valueLabels 
    '''                            that are housed in the control arrays which 
    '''                            are held in the jagged array.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn2dJaggedDisplay_Click(sender As Object, e As EventArgs) Handles btn2dJaggedDisplay.Click

        Dim controlIndex As Integer = 0         ' will hold the index or the current control
        Dim currentValueLabel As Label          ' will hold the current ValueLabel
        Dim currentRowColumnLabel As Label      ' will hold the current RowColumnLabel

        ' loop through the rows
        For rowIndex As Integer = 0 To numberArray.GetLength(0) - 1

            ' loop through the columns
            For columnIndex As Integer = 0 To numberArray.GetLength(1) - 1

                ' multiply the row index by 2 and add the column index 
                ' to get the current label index
                controlIndex = (rowIndex * 2) + columnIndex ' will produce 0 1 2 3 4 5

                ' The above code can also be replaced with the following
                ' but I wanted to demonstrate doing it based on using
                ' the row and column indexes of the number array
                ' controlIndex += 1

                ' get the current ValueLabel control from the control array
                currentValueLabel = CType(CType(allControls(indexValueLabels), Label())(controlIndex), Label)

                ' clear the current ValueLabel's text property
                currentValueLabel.Text = numberArray(rowIndex, columnIndex).ToString()

                ' get the current RowColumnLabel control from the control array
                currentRowColumnLabel = CType(CType(allControls(indexRowColumnLabels), Label())(controlIndex), Label)

                ' clear the current RowColumn's text property
                currentRowColumnLabel.Text = "Row-" & rowIndex & " Col-" & columnIndex

            Next columnIndex ' next column

        Next rowIndex ' next row

    End Sub

    ''' <summary>
    ''' btn2dJaggedReset_Click - clears the controls in this section of code 
    '''                          looping the the control arrays in the jagged
    '''                          array. And looping through rows and columns
    '''                          in the 2D array.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn2dJaggedReset_Click(sender As Object, e As EventArgs) Handles btn2dJaggedReset.Click

        ' clear all the label text properties in the control arrays
        ' loop through the array of arrays
        For arrayIndex As Integer = 0 To allControls.Length - 1

            ' loop through each specific control array
            For controlIndex As Integer = 0 To CType(allControls(arrayIndex), Label()).Length - 1

                ' clear the current label
                CType(CType(allControls(arrayIndex), Label())(controlIndex), Label).Text = String.Empty

            Next controlIndex

        Next arrayIndex

        ' loop through each row
        For rowIndex As Integer = 0 To numberArray.GetLength(0) - 1

            ' loop through each column
            For columnIndex As Integer = 0 To numberArray.GetLength(1) - 1

                ' set the value to zero
                numberArray(rowIndex, columnIndex) = 0

            Next columnIndex ' next column

        Next rowIndex ' next row

        ' reset form/class level variables
        columnCounter = 0   ' reset the input column counter
        rowCounter = 0      ' reset the input row counter

        lb2dJaggedOutput.Text = String.Empty

        ' enable the enter button
        btn2dJaggedEnter.Enabled = True

    End Sub

#End Region

#Region "Assign appropriate Accept Button"

    ''' <summary>
    ''' Captures the GotFocus event for a number of controls when a specific controls gets focus this reset the accept button
    ''' to the appropriate button on the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub input_GotFocus(sender As Object, e As EventArgs) Handles tbIfInput.GotFocus,
                                                                        tbNestedIfInput.GotFocus,
                                                                        tbForLoopDemoInput.GotFocus,
                                                                        tbForLoopBreakDemoInput.GotFocus,
                                                                        tbWhileLoopDemoInput.GotFocus,
                                                                        tbWhileLoopBreakDemoInput.GotFocus,
                                                                        tbDoWhileLoopDemoInput.GotFocus,
                                                                        tbDoWhileLoopBreakDemoInput.GotFocus,
                                                                        tbCreateArrayInput.GotFocus,
                                                                        tbMethodInput.GotFocus,
                                                                        tbNumberOne.GotFocus,
                                                                        tbNumberTwo.GotFocus,
                                                                        tbSelectCase.GotFocus,
                                                                        tb2dJaggedInput.GotFocus


        ' set the control name
        Dim controlName As String = CType(sender, TextBox).Name

        ' check which text box has focus
        If controlName = "tbIfInput" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnIfDemo

        ElseIf controlName = "tbNestedIfInput" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnNestedIfDemo

        ElseIf controlName = "tbForLoopDemoInput" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnForLoopDemo

        ElseIf controlName = "tbForLoopBreakDemoInput" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnForLoopBreakDemo

        ElseIf controlName = "tbWhileLoopDemoInput" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnWhileLoopDemo

        ElseIf controlName = "tbWhileLoopBreakDemoInput" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnWhileLoopBreakDemo

        ElseIf controlName = "tbDoWhileLoopDemoInput" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnDoWhileLoopDemo

        ElseIf controlName = "tbDoWhileLoopBreakDemoInput" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnDoWhileLoopBreakDemo

        ElseIf controlName = "tbCreateArrayInput" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnCreateArrayDemo

        ElseIf controlName = "tbMethodInput" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnMethodDemo

        ElseIf controlName = "tbNumberOne" Or
           controlName = "tbNumberOne" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnAddDemo

        ElseIf controlName = "tbSelectCase" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnSelectCase

        ElseIf controlName = "tb2dJaggedInput" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btn2dJaggedEnter

        End If

    End Sub


#End Region

#Region "Close Form"

    ''' <summary>
    ''' btnExit_Click - when click will call the form method to close the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' close the form 
        Me.Close()

    End Sub


#End Region

End Class
