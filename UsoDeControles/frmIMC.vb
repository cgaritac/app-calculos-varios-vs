Public Class frmIMC
    Dim imc As Double = 0.0
    Dim peso As Double = 0.0
    Dim estatura As Double = 0.0
    Dim sexo As String = ""

    Private Sub btnIMCSalir_Click(sender As Object, e As EventArgs) Handles btnIMCSalir.Click
        Me.Close()
    End Sub

    Private Sub btnIMCLimpiar_Click(sender As Object, e As EventArgs) Handles btnIMCLimpiar.Click
        txtIMCPeso.Text = ""
        txtIMCAltura.Text = ""
        rbIMCMujer.Checked = False
        rbIMCHombre.Checked = False
        txtIMCValor.Text = ""
        txtIMCComposicion.Text = ""
    End Sub

    Private Sub btnIMCCalcular_Click(sender As Object, e As EventArgs) Handles btnIMCCalcular.Click
        If txtIMCPeso.Text = "" Then
            MessageBox.Show("Error, favor indique el peso en kilogramos", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            If txtIMCPeso.Text <= 0 Then
                MessageBox.Show("Error, favor indique y un valor de peso superior a cero kilogramos", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            Else
                peso = txtIMCPeso.Text
            End If
        End If

        If txtIMCAltura.Text = "" Then
            MessageBox.Show("Error, favor indique la estatura en metros", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Else
            If txtIMCAltura.Text <= 0 Then
                MessageBox.Show("Error, favor indique y un valor de estatura superior a cero metros", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            Else
                estatura = txtIMCAltura.Text
            End If
        End If

        If rbIMCMujer.Checked = False And rbIMCHombre.Checked = False Then
            MessageBox.Show("Error, favor escoja una de las dos opciones de sexo", "Error de entrada de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        End If

        If rbIMCMujer.Checked = True And rbIMCHombre.Checked = False Then
            sexo = "mujer"
        Else
            If rbIMCMujer.Checked = False And rbIMCHombre.Checked = True Then
                sexo = "hombre"
            End If
        End If

        If txtIMCAltura.Text = "" Or txtIMCPeso.Text = "" Or (rbIMCMujer.Checked = False And rbIMCHombre.Checked = False) Then
            txtIMCValor.Text = ""
            txtIMCComposicion.Text = ""
        Else
            imc = peso / (estatura ^ 2)
            imc = Math.Truncate(imc * 10) / 10
            txtIMCValor.Text = imc

            If sexo = "mujer" Then
                If imc < 20 Then
                    txtIMCComposicion.Text = "Bajo peso"
                Else
                    If imc > 20 And imc < 23.9 Then
                        txtIMCComposicion.Text = "Normal"
                    Else
                        If imc > 24 And imc < 28.9 Then
                            txtIMCComposicion.Text = "Obesidad leve"
                        Else
                            If imc > 29 And imc < 37 Then
                                txtIMCComposicion.Text = "Obesidad severa"
                            Else
                                txtIMCComposicion.Text = "Obesidad muy severa"
                            End If
                        End If
                    End If
                End If

            End If

            If sexo = "hombre" Then
                If imc < 20 Then
                    txtIMCComposicion.Text = "Bajo peso"
                Else
                    If imc > 20 And imc < 24.9 Then
                        txtIMCComposicion.Text = "Normal"
                    Else
                        If imc > 25 And imc < 29.9 Then
                            txtIMCComposicion.Text = "Obesidad leve"
                        Else
                            If imc > 20 And imc < 40 Then
                                txtIMCComposicion.Text = "Obesidad severa"
                            Else
                                txtIMCComposicion.Text = "Obesidad muy severa"
                            End If
                        End If
                    End If
                End If
            End If
            MessageBox.Show("La información fue ingresada correctamente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        End If


    End Sub
End Class