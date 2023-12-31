Public Class frmDolCol
    Dim dolaresDC As Double = 0.0
    Dim colonesDC As Double = 0.0
    Dim cambioDC As Double = 0.0
    Dim dolaresCD As Double = 0.0
    Dim colonesCD As Double = 0.0
    Dim cambioCD As Double = 0.0

    Private Sub btnDolColSalir_Click(sender As Object, e As EventArgs) Handles btnDolColSalir.Click
        Me.Close()
    End Sub

    Private Sub btnDolColLimpiar_Click(sender As Object, e As EventArgs) Handles btnDolColLimpiar.Click
        txtDolDC.Text = ""
        txtCambioDC.Text = ""
        txtColDC.Text = ""
    End Sub

    Private Sub btnColDolLimpiar_Click(sender As Object, e As EventArgs) Handles btnColDolLimpiar.Click
        txtColCD.Text = ""
        txtCambioCD.Text = ""
        txtDolCD.Text = ""
    End Sub

    Private Sub btnDolColCalcular_Click(sender As Object, e As EventArgs) Handles btnDolColCalcular.Click
        If txtDolDC.Text = "" Then
            MessageBox.Show("Error, favor indique el monto en dólares que desea convertir a colones", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            dolaresDC = txtDolDC.Text
        End If

        If txtCambioDC.Text = "" Or txtCambioDC.Text = "0" Then
            MessageBox.Show("Error, favor indique el tipo de cambio de venta de dólares", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            cambioDC = txtCambioDC.Text
        End If

        If txtDolDC.Text = "" Or txtCambioDC.Text = "" Or txtCambioDC.Text = "0" Then
            txtColDC.Text = ""
        Else
            colonesDC = cambioDC * dolaresDC
            colonesDC = Math.Truncate(colonesDC * 100) / 100
            txtColDC.Text = colonesDC
            MessageBox.Show("La información fue ingresada correctamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        End If

    End Sub

    Private Sub btnColDolCalcular_Click(sender As Object, e As EventArgs) Handles btnColDolCalcular.Click
        If txtColCD.Text = "" Then
            MessageBox.Show("Error, favor indique el monto en colones que desea convertir a dólares", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            colonesCD = txtColCD.Text
        End If

        If txtCambioCD.Text = "" Or txtCambioCD.Text = "0" Then
            MessageBox.Show("Error, favor indique el tipo de cambio de compra de dólares", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            cambioCD = txtCambioCD.Text
        End If

        If txtColCD.Text = "" Or txtCambioCD.Text = "" Or txtCambioCD.Text = "0" Then
            txtDolCD.Text = ""
        Else
            dolaresCD = colonesCD / cambioCD
            dolaresCD = Math.Truncate(dolaresCD * 100) / 100
            txtDolCD.Text = dolaresCD
            MessageBox.Show("La información fue ingresada correctamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        End If
    End Sub
End Class