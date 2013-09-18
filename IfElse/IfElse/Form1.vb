Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2, largerNum As Double
        num1 = CDbl(txtFirstNum.Text)
        num2 = CDbl(txtSecondNum.Text)

        If num1 > num2 Then
            largerNum = num1
        Else
            largerNum = num2

        End If
        txtResult.Text = "The larger number is " &
            largerNum
    End Sub
End Class
