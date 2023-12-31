Public Class frmDepreciacionLineal
    Dim activo As Double = 0.0
    Dim cAnios As Double = 0.0
    Dim mDepreciar As Double = 0.0

    Private Sub btnDepreciacionSalir_Click(sender As Object, e As EventArgs) Handles btnDepreciacionSalir.Click
        Me.Close()
    End Sub

    Private Sub btnDepreciacionCalcular_Click(sender As Object, e As EventArgs) Handles btnDepreciacionCalcular.Click
        If txtDepreciacionActivo.Text = "" Then
            MessageBox.Show("Error, favor ingrese un valor del activo", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            activo = txtDepreciacionActivo.Text
        End If

        If txtDepreciacionAnios.Text = "" Then
            MessageBox.Show("Error, favor ingrese una cantidad de años", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            cAnios = txtDepreciacionAnios.Text
        End If

        If chkDepreciacionAnual.Checked = False And chkDepreciacionMensual.Checked = False Then
            MessageBox.Show("Error, favor escoja una de las dos opciones de tipo de depreciación", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        End If

        If chkDepreciacionAnual.Checked = True And chkDepreciacionMensual.Checked = True Then
            MessageBox.Show("Error, favor escoja solo una de las dos opciones de tipo de depreciación", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        End If

        If txtDepreciacionActivo.Text = "" Or txtDepreciacionAnios.Text = "" Or (chkDepreciacionAnual.Checked = False And chkDepreciacionMensual.Checked = False) Or (chkDepreciacionAnual.Checked = True And chkDepreciacionMensual.Checked = True) Then
            txtDepreciacionResultado.Text = ""
        Else
            mDepreciar = activo / cAnios
            mDepreciar = Math.Truncate(mDepreciar * 100) / 100
        End If

        If chkDepreciacionAnual.Checked = True And chkDepreciacionMensual.Checked = False Then
            txtDepreciacionResultado.Text = mDepreciar
            MessageBox.Show("La información fue ingresada correctamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        End If

        If chkDepreciacionAnual.Checked = False And chkDepreciacionMensual.Checked = True Then
            mDepreciar = Math.Truncate((mDepreciar / 12) * 100) / 100
            txtDepreciacionResultado.Text = mDepreciar
            MessageBox.Show("La información fue ingresada correctamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub btnDepreciacionLimpiar_Click(sender As Object, e As EventArgs) Handles btnDepreciacionLimpiar.Click
        txtDepreciacionActivo.Text = ""
        txtDepreciacionAnios.Text = ""
        txtDepreciacionResultado.Text = ""
        chkDepreciacionAnual.Checked = False
        chkDepreciacionMensual.Checked = False
    End Sub

End Class