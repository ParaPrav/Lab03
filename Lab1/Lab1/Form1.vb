Public Class frmAverageUnitsShipped

    Dim userInput As String = String.Empty
    Dim num As Integer = 1
    Dim iSum As Integer = 0
    Dim dAverage As Double = 0
    Private Sub frmAverageUnitsShipped_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblUnitShippedPrompt_Click(sender As Object, e As EventArgs) Handles lblUnitShippedPrompt.Click

    End Sub

    Private Sub txtUnitShipped_TextChanged(sender As Object, e As EventArgs) Handles txtUnitShipped.TextChanged

    End Sub

    Private Sub lblDay_Click(sender As Object, e As EventArgs) Handles lblDay.Click

    End Sub

    Private Sub lblRecord_Click(sender As Object, e As EventArgs) Handles lblRecord.Click

    End Sub

    Private Sub lblAverage_Click(sender As Object, e As EventArgs) Handles lblAverage.Click

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        If IsNumeric(txtUnitShipped.Text) Then
            'If Double.TryParse(userInput, num) Then        'I tried making the user get an invalid msg if they inputed a decimal value but it didnt work 
            'MessageBox.Show("ERROR. ")
            'Else
            iSum = iSum + CInt(txtUnitShipped.Text)
                num = num + 1
                lblDay.Text = "Day " & num.ToString
                lblRecord.Text = lblRecord.Text & txtUnitShipped.Text & vbCrLf
            'End If

        Else
            MessageBox.Show("ERROR. You had inputed an incorrect value. You can only input whole numbers. Please try again.")
        End If

            If (num = 8) Then
                btnEnter.Enabled = False
            dAverage = iSum / 7.0
            dAverage = Math.Round(dAverage, 2)
            lblDay.Text = "Day 7"
                lblAverage.Text = "Average for this week: " & dAverage
                MessageBox.Show("This week the average units you had sold was " & dAverage)
            End If

        txtUnitShipped.Text = ""

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        num = 1
        iSum = 0
        dAverage = 0
        lblRecord.Text = " "
        lblDay.Text = "Day " & num.ToString
        lblAverage.Text = " "
        txtUnitShipped.Clear()
        btnEnter.Enabled = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

End Class
