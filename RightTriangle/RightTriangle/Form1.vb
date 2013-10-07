Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim side1 As Double = CDbl(txtSideOne.Text)
        Dim side2 As Double = CDbl(txtSideTwo.Text)
        Dim side3 As Double

        side3 = Hypotenuse(side1, side2)


        txtHyp.Text = CStr(side3)

    End Sub
    Function Hypotenuse(ByVal side1 As Double, ByVal side2 As Double) As Double
        Dim CalculateHypo As Double
        CalculateHypo = Math.Sqrt(side1 ^ 2 + side2 ^ 2)
        Return CalculateHypo

    End Function
End Class
