Imports System.ComponentModel

Public Class Form1
    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click, AddToolStripMenuItem.Click
        Dim add As Decimal
        add = firstNumTextBox.Text + +secondNumTextBox.Text
        resultTextBox.Text = add.ToString()
    End Sub

    Private Sub subtractButton_Click(sender As Object, e As EventArgs) Handles subtractButton.Click, SubtractToolStripMenuItem.Click
        Dim subtract As Decimal
        subtract = firstNumTextBox.Text - secondNumTextBox.Text
        resultTextBox.Text = subtract.ToString()
    End Sub

    Private Sub divideButton_Click(sender As Object, e As EventArgs) Handles divideButton.Click, DivideToolStripMenuItem.Click
        Try
            Dim div As Decimal = firstNumTextBox.Text / secondNumTextBox.Text
            resultTextBox.Text = Decimal.Round(div, 2).ToString()
        Catch divideByZeroExceptionParameter As DivideByZeroException
            MessageBox.Show("Cannot divide by zero", "Division By Zero Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex1 As Exception
            MessageBox.Show("Enter valid inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub multiplyButton_Click(sender As Object, e As EventArgs) Handles multiplyButton.Click, MultiplyToolStripMenuItem.Click
        Dim product As Decimal = firstNumTextBox.Text * secondNumTextBox.Text
        resultTextBox.Text = product
    End Sub


    Private Sub firstNumTextBox_Validating(sender As Object, e As CancelEventArgs) Handles firstNumTextBox.Validating
        If IsNumeric(firstNumTextBox.Text) = False Then
            e.Cancel = True
            ErrorProvider1.SetError(firstNumTextBox, "Enter a whole number or decimal")
        Else
            ErrorProvider1.SetError(firstNumTextBox, "")
        End If
    End Sub



    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = False
    End Sub



    Private Sub secondNumTextBox_Validating(sender As Object, e As CancelEventArgs) Handles secondNumTextBox.Validating
        If IsNumeric(secondNumTextBox.Text) = False Then
            e.Cancel = True
            ErrorProvider1.SetError(secondNumTextBox, "Enter second number")
        Else
            ErrorProvider1.SetError(secondNumTextBox, "")
        End If
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        firstNumTextBox.Clear()
        secondNumTextBox.Clear()
        resultTextBox.Clear()
        firstNumTextBox.Focus()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim exitForm As DialogResult = MessageBox.Show("Do you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        If exitForm = DialogResult.Yes Then
            Me.Close()

        End If
    End Sub
End Class
