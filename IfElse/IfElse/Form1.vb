Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2 As Double

        'If the user did the wrong thing
        If Not (IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text) And num1 >= 0 And num2 >= 0) Then
            MessageBox.Show("Error: please type a number!", "Error")
            Return
        End If

        num1 = CDbl(txtFirstNum.Text)
        num2 = CDbl(txtSecondNum.Text)

        'If the user did the wrong thing, then MsgBox and eliminate them
        If (num1 < 0 Or num2 < 0) Then
            MessageBox.Show("Error: please type a POSITIVE number!", "Error")
            Return
        End If

        'Sterile area , sure that the user has typed a number and that the numbers are positive
        If (num1 > num2) Then
            txtResult.Text = "Larger number is " & num1
        ElseIf (num2 > num1) Then
            txtResult.Text = "Larger number is " & num2
        Else
            txtResult.Text = "The two are equal. "
        End If
    End Sub
End Class
