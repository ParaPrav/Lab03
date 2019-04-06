Option Strict On

Imports System.IO
Imports System.Text

''' <summary>
''' Author Name:    Praveen Paramanathan
''' Project Name:   Text Editor
''' Date:           05-April-2019
''' Description     Application to create and/or edit a text file.
''' </summary>
''' 

Public Class frmTextEditor

    Private fs As FileStream
    Dim x As Integer

    ''' <summary>
    ''' New - set the textbox back to their default state.
    ''' </summary>
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        If (x = 1) Then
            fs.Close()
        End If
        x = 0
        txtText.Clear()
    End Sub

    ''' <summary>
    ''' Open - allows the user to browse folders and files to open a file they would like to change
    ''' </summary>
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If (x = 1) Then
            fs.Close()
        End If
        OpenFileDialog1.ShowDialog()
        fs = File.OpenWrite(OpenFileDialog1.FileName)
    End Sub

    ''' <summary>
    ''' Save - allows the user to save the contents that were changed within the file
    ''' </summary>
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If (x = 1) Then
            Dim fileWords As Byte() = New UTF8Encoding(True).GetBytes(txtText.Text)
            fs.Write(fileWords, 0, fileWords.Length)
            MsgBox("Your text file has been saved!", MsgBoxStyle.Information, "Success")
        Else
            SaveFileDialog1.ShowDialog()
        End If
    End Sub

    ''' <summary>
    ''' SaveAs - allows the user to browse folders save a file they had created
    ''' </summary>
    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    ''' <summary>
    ''' Exit - closes the program
    ''' </summary>
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim i As MsgBoxResult = MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo)
        If i = MsgBoxResult.Yes Then
            MsgBox("Thank you for using this program.", MsgBoxStyle.Information, "Goodbye")
            ' This will close the form
            Me.Close()
        End If
    End Sub

    ''' <summary>
    ''' Copy - allows the user to copy the selected text to their clipboard
    ''' </summary>
    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(txtText.SelectedText)
    End Sub

    ''' <summary>
    ''' Cut - allows the user to clear the selected text and save it to their clipboard 
    ''' </summary>
    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(txtText.SelectedText)
        txtText.SelectedText = ""
    End Sub

    ''' <summary>
    ''' Paste - allows the user to paste the last text they have in their clipboard
    ''' </summary>
    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        txtText.SelectedText = My.Computer.Clipboard.GetText
    End Sub

    ''' <summary>
    ''' About - gives information about the program
    ''' </summary>
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("NETD-2202" & vbNewLine & "Lab 5: Text Editor" & vbNewLine & "Praveen Paramanathan", MsgBoxStyle.Information, "About The Program")
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim myStreamReader As New StreamReader(OpenFileDialog1.FileName)
        x = 1
        OpenFileDialog1.CheckFileExists = True
        txtText.Text = myStreamReader.ReadToEnd()
        myStreamReader.Close()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim myStreamWriter As New StreamWriter(SaveFileDialog1.FileName)
        If (x = 0) Then
            fs = File.OpenWrite(OpenFileDialog1.FileName)
        End If
        myStreamWriter.Write(txtText.Text)
        myStreamWriter.Close()
        x = 1
    End Sub

    Private Sub frmTextEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Welcome To the Text Editor." & vbNewLine & "Created By: Praveen Paramanathan" & vbNewLine & "Hope you enjoy!", MsgBoxStyle.Information, "Welcome")
        x = 0
    End Sub
End Class
