Public Class Form3
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim comprimento As Double = 0
        Dim largura As Double = 0
        Dim altura As Double = 0
        Dim volume As Double = 0
        comprimento = Convert.ToDouble(txtComprimento.Text)
        largura = Convert.ToDouble(txtLargura.Text)
        altura = Convert.ToDouble(txtAltura.Text)
        volume = comprimento * largura * altura
        txtResult.Text = volume.ToString()
    End Sub

End Class