Public Class frmImpuesto
    Dim impuesto As Double = 0.0
    Dim costo As Double = 0.0
    Dim montoImpuesto As Double = 0.0
    Dim costoTotal As Double = 0.0

    Private Sub btnImpuestoLimpiar_Click(sender As Object, e As EventArgs) Handles btnImpuestoLimpiar.Click
        txtImpuestoCosto.Text = ""
        txtImpuestoMonto.Text = ""
        txtImpuestoCostoTot.Text = ""
        cbImpuestoTipo.Text = ""
    End Sub

    Private Sub btnImpuestoSalir_Click(sender As Object, e As EventArgs) Handles btnImpuestoSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImpuestoCalcular_Click(sender As Object, e As EventArgs) Handles btnImpuestoCalcular.Click
        If cbImpuestoTipo.Text = "" Then
            MessageBox.Show("Error, favor elija una de las opciones de tipo de impuesto del listado", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            If cbImpuestoTipo.Text = "Accesorio de carro 42,78 %" Then
                impuesto = 0.4278
            End If

            If cbImpuestoTipo.Text = "Ropa 29,95 %" Then
                impuesto = 0.2995
            End If

            If cbImpuestoTipo.Text = "Adorno 29,95 %" Then
                impuesto = 0.2995
            End If

            If cbImpuestoTipo.Text = "Aire acondicionado doméstico 75,04 %" Then
                impuesto = 0.754
            End If

            If cbImpuestoTipo.Text = "Accesorios de computadora 42,38 %" Then
                impuesto = 0.4238
            End If

            If cbImpuestoTipo.Text = "Bisutería 29,95 %" Then
                impuesto = 0.2995
            End If

            If cbImpuestoTipo.Text = "Cámara 13,00 %" Then
                impuesto = 0.13
            End If

            If cbImpuestoTipo.Text = "Juguetes 29,95 %" Then
                impuesto = 0.2995
            End If

            If cbImpuestoTipo.Text = "Computadora 13,00 %" Then
                impuesto = 0.13
            End If

            If cbImpuestoTipo.Text = "Libro 1,00 %" Then
                impuesto = 0.01
            End If

            If cbImpuestoTipo.Text = "Reproductor MP3 49,27 %" Then
                impuesto = 0.4927
            End If

            If cbImpuestoTipo.Text = "Consola de video juegos 55,71 %" Then
                impuesto = 0.5571
            End If

            If cbImpuestoTipo.Text = "Instrumento musical 24,3 %" Then
                impuesto = 0.243
            End If

            If cbImpuestoTipo.Text = "Televisor o monitor 49,27 %" Then
                impuesto = 0.4927
            End If

            If cbImpuestoTipo.Text = "Accesorio de celular 14,13 %" Then
                impuesto = 0.1413
            End If

        End If

        If txtImpuestoCosto.Text = "" Then
            MessageBox.Show("Error, favor indique el costo del artículo", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            costo = txtImpuestoCosto.Text
        End If

        If cbImpuestoTipo.Text = "" Or txtImpuestoCosto.Text = "" Then
            txtImpuestoMonto.Text = ""
            txtImpuestoCostoTot.Text = ""
        Else
            montoImpuesto = costo * impuesto
            montoImpuesto = Math.Truncate(montoImpuesto * 100) / 100
            costoTotal = montoImpuesto + costo
            costoTotal = Math.Truncate(costoTotal * 100) / 100
            txtImpuestoMonto.Text = montoImpuesto
            txtImpuestoCostoTot.Text = costoTotal
            MessageBox.Show("La información fue ingresada correctamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        End If
    End Sub

End Class