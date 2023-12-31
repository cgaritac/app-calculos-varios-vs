Public Class frmTemperaturaFC
    Dim tempFarFC As Double = 0.0
    Dim tempCelFC As Double = 0.0
    Dim tempFarCF As Double = 0.0
    Dim tempCelCF As Double = 0.0

    Private Sub btnTemperaturaSalir_Click(sender As Object, e As EventArgs) Handles btnTemperaturaSalir.Click
        Me.Close()
    End Sub

    Private Sub btnFahrCelsLimpiar_Click(sender As Object, e As EventArgs) Handles btnFahrCelsLimpiar.Click
        txtFahrenheitFC.Text = ""
        txtCelsiusFC.Text = ""
    End Sub

    Private Sub btnCelsFahrLimpiar_Click(sender As Object, e As EventArgs) Handles btnCelsFahrLimpiar.Click
        txtCelsiusCF.Text = ""
        txtFahrenheitCF.Text = ""
    End Sub

    Private Sub btnFahrCelsCalcular_Click(sender As Object, e As EventArgs) Handles btnFahrCelsCalcular.Click
        If txtFahrenheitFC.Text = "" Then
            MessageBox.Show("Error, favor indique el valor de la temperatura en °F que desea convertir a °C", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            tempFarFC = txtFahrenheitFC.Text
        End If

        If txtFahrenheitFC.Text = "" Then
            txtCelsiusFC.Text = ""
        Else
            tempCelFC = (5 / 9) * (tempFarFC - 32)
            tempCelFC = Math.Truncate(tempCelFC * 100) / 100
            txtCelsiusFC.Text = tempCelFC
            MessageBox.Show("La información fue ingresada correctamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub btnCelsFahrCalcular_Click(sender As Object, e As EventArgs) Handles btnCelsFahrCalcular.Click
        If txtCelsiusCF.Text = "" Then
            MessageBox.Show("Error, favor indique el valor de la temperatura en °C que desea convertir a °F", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            tempCelCF = txtCelsiusCF.Text
        End If

        If txtCelsiusCF.Text = "" Then
            txtFahrenheitCF.Text = ""
        Else
            tempFarCF = (9 / 5) * tempCelCF + 32
            tempFarCF = Math.Truncate(tempFarCF * 100) / 100
            txtFahrenheitCF.Text = tempFarCF
            MessageBox.Show("La información fue ingresada correctamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        End If
    End Sub
End Class