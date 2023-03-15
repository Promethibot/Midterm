Public Class Midterm

    Dim strTbxI As String
    Dim decTbxI As Decimal
    Const _cdecConv As Decimal = 39.37

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub tbxIn_TextChanged(sender As Object, e As EventArgs) Handles tbxIn.TextChanged
        strTbxI = tbxIn.Text
        btnClear.Enabled = True
        btnConv.Enabled = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbxIn.Text = ""
        lblResult.Visible = False
        btnClear.Enabled = False
        btnConv.Enabled = False
        rdiItM.PerformClick()
        tbxIn.Select()
    End Sub

    Private Sub btnConv_Click(sender As Object, e As EventArgs) Handles btnConv.Click
        If Decimal.TryParse(strTbxI, decTbxI) Then
            If decTbxI < 0 Then
                MessageBox.Show("You can't have a negative length! Try again!")
            End If
            If rdiItM.Checked Then
                lblResult.Text = "Converted value: " + (decTbxI / _cdecConv).ToString + " meters"
                lblResult.Visible = True

            Else
                lblResult.Text = "Converted value: " + (decTbxI * _cdecConv).ToString + " inches"
                lblResult.Visible = True
            End If
        Else
            MessageBox.Show("That doesn't look like a number!")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClear.PerformClick()
    End Sub
End Class
