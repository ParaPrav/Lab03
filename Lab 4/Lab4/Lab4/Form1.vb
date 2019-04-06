Option Strict On

''' <summary>
''' Author Name:    Praveen Paramanathan
''' Project Name:   Car Inventory
''' Date:           11-March-2019
''' Description     Application to keep a list of cars and a little information that describes their importance.
''' </summary>

Public Class frmCarInventory
    Private carList As New SortedList                               ' collection of all the carList in the list
    Private currentCarIdentificationNumber As String = String.Empty ' current selected car identification number
    Private editMode As Boolean = False
    Private DecimalValue As Object

    Function validateInput(ByVal input As String) As Boolean
        Dim inputNumber As Double  ' Holds the user input as an integer
        Dim isValidInput As Boolean = False ' Holds whether the input is valid or not, assuming data is invalid

        ' Example of a try/ catch in VB
        Try
            inputNumber = CDbl(input)  ' Try to cast the input as an integer
            If (input.Equals(inputNumber.ToString)) Then   ' Check if the inputed data is a whole number
                If (inputNumber >= 0) Then ' Check if the inputed data is within defined bounds
                    isValidInput = True ' All checks passed, data is valid
                End If
            End If
        Catch ex As Exception
            ' input could not be cast as an integer, not a number
        End Try

        Return isValidInput ' Return the success or failure of the validation
    End Function

    ''' <summary>
    ''' btnEnter_Click - Validate that the data entered into the controls is appropriate.
    '''                - Insert the new car object into the carList collection. 
    '''                - Check to see if the data in the controls has been selected from the listview by the user.
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim car As Car              ' declare a Car class
        Dim carItem As ListViewItem ' declare a ListViewItem class

        ' validate the data in the form
        If IsValidInput() = True Then

            ' set the edit flag to true
            editMode = True

            lblResult.Text = "It worked!"

            If currentCarIdentificationNumber.Trim.Length = 0 Then

                ' create a new car object using the parameterized constructor
                car = New Car(cmbMakes.Text, txtModel.Text, cmbYears.Text, txtPrice.Text, chkNew.Checked)

                carList.Add(car.IdentificationNumber.ToString(), car)

            Else

                car = CType(carList.Item(currentCarIdentificationNumber), Car)
                ' update the data in the specific object from the controls
                car.Make = cmbMakes.Text
                car.Model = txtModel.Text
                car.Year = cmbYears.Text
                car.Price = txtPrice.Text


                car.VeryImportantCarStatus = chkNew.Checked
            End If

            ' clear the items from the listview control
            lvwCars.Items.Clear()

            ' loop through the carList collection and populate the list view
            For Each customerEntry As DictionaryEntry In carList

                ' instantiate a new ListViewItem
                carItem = New ListViewItem()

                ' get the car from the list
                car = CType(customerEntry.Value, Car)

                ' assign the values to the checked control and the subitems
                carItem.Checked = car.VeryImportantCarStatus
                carItem.SubItems.Add(car.IdentificationNumber.ToString())
                carItem.SubItems.Add(car.Make)
                carItem.SubItems.Add(car.Model)
                carItem.SubItems.Add(car.Year)
                'car.Price = String.Format("{0:0.00}")   I tried bu it didnt work
                carItem.SubItems.Add("$" & Math.Ceiling(CDbl(car.Price) * 100) / 100)

                ' add the new instantiated and populated ListViewItem to the listview control
                lvwCars.Items.Add(carItem)

            Next customerEntry

            ' clear the controls
            Reset()

            ' set the edit flag to false
            editMode = False

        End If
    End Sub

    ''' <summary>
    ''' Reset - set the controls back to their default state.
    ''' </summary>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        txtModel.Text = String.Empty
        txtPrice.Text = String.Empty
        chkNew.Checked = False
        cmbMakes.SelectedIndex = -1
        cmbYears.SelectedIndex = -1
        lblResult.Text = String.Empty

        currentCarIdentificationNumber = String.Empty

    End Sub


    ''' <summary>
    ''' IsValidInput - validates the data in each control to ensure that the user has entered apprpriate values
    ''' </summary>
    ''' <returns>Boolean</returns>
    Private Function IsValidInput() As Boolean

        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty

        ' check if the Make has been selected
        If cmbMakes.SelectedIndex = -1 Then

            ' If not set the error message
            outputMessage += "Please select the car's brand name." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the Year has been selected
        If cmbYears.SelectedIndex = -1 Then

            ' If not set the error message
            outputMessage += "Please select the car's year." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the Model name has been entered
        If txtModel.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Please enter the car's Model." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the Price has been entered
        If txtPrice.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Please enter the car's price." & vbCrLf

            ' And, set the return value to false
            returnValue = False
        Else
            Dim carPrice As String = txtPrice.Text.Trim ' Take user data and store it for use
            If (validateInput(carPrice)) Then           ' Check if data entered by user is valid
            Else
                ' If not set the error message
                outputMessage += "Please enter the car's price in numeric." & vbCrLf

                ' And, set the return value to false
                returnValue = False

            End If
        End If

        ' check to see if any value
        ' did not validate
        If returnValue = False Then

            ' show the message(s) to the user
            lblResult.Text = "ERRORS" & vbCrLf & outputMessage

        End If

        ' return the boolean value
        ' true if it passed validation
        ' false if it did not pass validation
        Return returnValue

    End Function

    ''' <summary>
    ''' btnExit_Click - EventHandler will close the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This will close the form
        Me.Close()
    End Sub

    Private Sub lvwCars_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCars.ItemCheck

        ' if it is not in edit mode
        If editMode = False Then

            ' the new value to the current value
            ' so it cannot be set in the listview by the user
            e.NewValue = e.CurrentValue

        End If

    End Sub

    ''' <summary>
    ''' lvwCustomers_SelectedIndexChanged - when the user selected a row in the list it will populate the fields for editing
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwCars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCars.SelectedIndexChanged

        ' constant that represents the index of the subitem in the list that
        ' holds the car identification number 
        Const identificationSubItemIndex As Integer = 1

        ' Get the car identification number 
        currentCarIdentificationNumber = lvwCars.Items(lvwCars.FocusedItem.Index).SubItems(identificationSubItemIndex).Text

        ' Use the car identification number to get the car from the collection object
        Dim car As Car = CType(carList.Item(currentCarIdentificationNumber), Car)

        ' set the controls on the form
        cmbMakes.Text = car.Make                            ' get the Brand Name of the car and set the combo box
        txtModel.Text = car.Model                           ' get the Model Name of the car and set the text box
        'car.Price = String.Format("{0:0.00}")  I tried bu it didnt work
        txtPrice.Text = CType(Math.Ceiling(CDbl(car.Price) * 100) / 100, String) ' get the Price of the car and set the text box  
        cmbYears.Text = car.Year                            ' get the Year it was made and set the combo box
        chkNew.Checked = car.VeryImportantCarStatus         ' get the very status of the car if its new or used and set the combo box

        lblResult.Text = car.GetSalutation()
    End Sub

End Class

Public Class Car


    Private Shared carCount As Integer                       ' static or shared private variable to hold the number of cars
    Private carIdentificationNumber As Integer = 0           ' private variable to hold the car's identification number
    Private carMake As String = String.Empty                 ' private variable to hold the car's Brand name
    Private carModel As String = String.Empty                ' private variable to hold the car's Model
    Private carYear As String = String.Empty                 ' private variable to hold the Year of the car 
    Private carPrice As String = String.Empty                ' private variable to hold the car's Price
    Private carVeryImportantCarStatus As Boolean = False     ' private variable to hold the car's status

    ''' <summary>
    ''' Constructor - Default - creates a new car object
    ''' </summary>
    Public Sub New()

        carCount += 1      ' increment the shared/static variable counter by 1
        carIdentificationNumber = carCount ' assign the cars id

    End Sub

    ''' <summary>
    ''' Constructor - Parameterized - creates a new car object
    ''' </summary>
    ''' <param name="make"></param>
    ''' <param name="model"></param>
    ''' <param name="year"></param>
    ''' <param name="price"></param>
    ''' <param name="veryImportantCarStatus"></param>
    Public Sub New(make As String, model As String, year As String, price As String, veryImportantCarStatus As Boolean)

        ' call the other constructor 
        ' to set the car count and
        ' to set the car id
        Me.New()

        carMake = make                                       ' set the car's Make
        carModel = model                                     ' set the car's Model
        carYear = year                                       ' set the car's Year
        carPrice = price                                     ' set the car's Price
        carVeryImportantCarStatus = veryImportantCarStatus   ' set the car's status

    End Sub


    ''' <summary>
    ''' Count ReadOnly Property - Gets the number of cars that have been instantiated/created
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property

    ''' <summary>
    ''' IdentificationNumber ReadOnly Property - Gets a specific cars identification number
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return carIdentificationNumber
        End Get
    End Property

    ''' <summary>
    ''' VeryImportantPersonStatus Property - >Gets and Sets the Very Important Car status of a car
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Property VeryImportantCarStatus() As Boolean
        Get
            Return carVeryImportantCarStatus
        End Get
        Set(ByVal value As Boolean)
            carVeryImportantCarStatus = value
        End Set
    End Property

    ''' <summary>
    ''' Title property - Gets and Sets the title of a car
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(ByVal value As String)
            carMake = value
        End Set
    End Property

    ''' <summary>
    ''' Model property - Gets and Sets the Model of a car
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(ByVal value As String)
            carModel = value
        End Set
    End Property

    ''' <summary>
    ''' Year property - Gets and Sets the year of a car
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Year() As String
        Get
            Return carYear
        End Get
        Set(ByVal value As String)
            carYear = value
        End Set
    End Property

    ''' <summary>
    ''' Price property - Gets and Sets the price of a car
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Price() As String
        Get
            Return carPrice
        End Get
        Set(ByVal value As String)
            carPrice = value
        End Set
    End Property

    ''' <summary>
    ''' GetSalutation is a function that a salutation based on the private properties within the class scope
    ''' </summary>
    ''' <returns>String</returns>
    Public Function GetSalutation() As String

        Return "You are looking at " & IIf(carVeryImportantCarStatus = True, "the brand new ", "a used ").ToString() & carMake & " " & carModel & " " & carYear & ". This Vehicle costs $" & carPrice & "."

    End Function


End Class
