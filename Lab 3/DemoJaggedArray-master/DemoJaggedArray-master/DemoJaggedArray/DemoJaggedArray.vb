''' <summary>
''' Author:         Alfred Massardo
''' Project Name:   DemoJaggedArray
''' Date:           23-Jan-2018
''' Description:    Simple program to demonstrate creating, loading, looping, and display the content of a jagged array.
''' </summary>

Public Class frmDemoJaggedArray

    ' constants
    Private Const indexClassical As Integer = 0     ' Holds the index if the Classical array
    Private Const indexJazz As Integer = 1          ' Holds the index if the Jazz array
    Private Const indexHiphop As Integer = 2        ' Holds the index if the Hip Hop array
    Private Const indexRock As Integer = 3          ' Holds the index if the Rock array

    ' declare the jagged array
    Private genres As String()() = New String(3)() {} ' Holds the differnt genres of music

    ' Jaggaed arrays can hold arrays with varying numbers of dimensions
    ' In other words, the child arrays can have varying sizes.
    Private classical As String() = {"Fugue in G minor", "The Four Seasons", "Adagio for Strings", "Symphony No. 5 In C Minor"} ' Holds 4 Classical songs
    Private jazz As String() = {"Summertime", "What a Wonderful World", "Feeling Good"} ' Holds 3 Jazz songs
    Private hiphop As String() = {"Jump Around", "Finesse"} ' Holds 2 Hip Hop songs
    Private rock As String() = {"Heathens", "We Rock", "Not Falling", "Closer to The Heart"} ' Holds 4 Rock Songs songs


    ''' <summary>
    ''' frmDemoJaggedArray_Load - loads the jagged arrays with the child arrays
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmDemoJaggedArray_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' load the child arrays
        genres(indexClassical) = classical  ' load Classical array
        genres(indexJazz) = jazz            ' load Jazz array
        genres(indexHiphop) = hiphop        ' load Hip Hop array
        genres(indexRock) = rock            ' load Rock array

    End Sub

    ''' <summary>
    ''' cboGenres_SelectedIndexChanged - When the index changes, the index is used to select the child array
    '''                                  and then loops the elements in the child array
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboGenres_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGenres.SelectedIndexChanged

        ' clear the label text
        lbOutput.Text = String.Empty

        ' get the index the user selected from the combobox/dropdownlist
        ' the selected index will be used to select the genre array
        Dim selectedIndex As Integer = cboGenres.SelectedIndex

        ' Ensure something has been selected by checking that the
        ' selected index is equal to or greater than zero (0)
        If selectedIndex >= 0 Then

            ' With the child array selected, using the selected index,
            ' loop the child array elements
            For index As Integer = 0 To genres(selectedIndex).Length - 1

                ' Concatinate the content of the child array
                ' element with a carriage return line feed
                ' so the content of every element appears on
                ' a new line
                lbOutput.Text += genres(selectedIndex)(index) & vbCrLf

            Next index ' next array index

        End If

    End Sub

    ''' <summary>
    ''' btnReset_Click - event that resets the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        cboGenres.SelectedIndex = -1
        lbOutput.Text = String.Empty

    End Sub

    ''' <summary>
    ''' btnExit_Click - Will close the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' Close the form
        Me.Close()

    End Sub

End Class
