Public Class Calculator
    Dim Num1 As Double
    Dim Num2 As Double
    Dim Symbol As String
    Private Sub Calculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnZero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZero.Click
        If Num2 = Nothing Then
            txtDisp.Text = txtDisp.Text & 0
        End If
    End Sub
    Private Sub btnOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOne.Click
        If Num2 = Nothing Then
            txtDisp.Text = txtDisp.Text & 1
        End If
    End Sub

    Private Sub btnTwo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTwo.Click
        txtDisp.Text = txtDisp.Text & 2
    End Sub

    Private Sub btnThree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThree.Click
        txtDisp.Text = txtDisp.Text & 3
    End Sub

    Private Sub btnFour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFour.Click
        txtDisp.Text = txtDisp.Text & 4
    End Sub

    Private Sub btnFive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFive.Click
        txtDisp.Text = txtDisp.Text & 5
    End Sub

    Private Sub btnSix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSix.Click
        txtDisp.Text = txtDisp.Text & 6
    End Sub

    Private Sub btnSeven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeven.Click
        txtDisp.Text = txtDisp.Text & 7
    End Sub

    Private Sub btnEigth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEigth.Click
        txtDisp.Text = txtDisp.Text & 8
    End Sub

    Private Sub btnNine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNine.Click
        txtDisp.Text = txtDisp.Text & 9
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Num1 = Val(txtDisp.Text)
        Symbol = "+"
        txtDisp.Clear()
    End Sub

    Private Sub btnAns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAns.Click
        Num2 = Val(txtDisp.Text)
        If Symbol = "+" Then
            txtDisp.Text = Num1 + Num2
        ElseIf Symbol = "-" Then
            txtDisp.Text = Num1 - Num2
        ElseIf Symbol = "*" Then
            txtDisp.Text = Num1 * Num2
        ElseIf Symbol = "/" Then
            txtDisp.Text = Num1 / Num2
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtDisp.Text = 0
        Num1 = Nothing
        Num2 = Nothing
        Symbol = Nothing
    End Sub
    Private Sub btnSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSub.Click
        Num1 = Val(txtDisp.Text)
        Symbol = "-"
        txtDisp.Clear()
    End Sub

    Private Sub btnMult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMult.Click
        Num1 = Val(txtDisp.Text)
        Symbol = "*"
        txtDisp.Clear()
    End Sub

    Private Sub btnDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiv.Click
        Num1 = Val(txtDisp.Text)
        Symbol = "/"
        txtDisp.Clear()
    End Sub
End Class
