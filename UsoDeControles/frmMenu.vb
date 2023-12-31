Public Class frmMenu
    Private Sub itmSalir_Click(sender As Object, e As EventArgs) Handles itmSalir.Click
        End
    End Sub

    Private Sub itmInformacion_Click(sender As Object, e As EventArgs) Handles itmInformacion.Click
        MessageBox.Show("Prueba Corta N°1. Elaborado por Carlos Garita Campos para el Curso Programación Orientada a Objetos II")
    End Sub

    Private Sub ItemDolCol_Click(sender As Object, e As EventArgs) Handles ItmDolCol.Click
        frmDolCol.Show()
    End Sub

    Private Sub itmTemperaturaFC_Click(sender As Object, e As EventArgs) Handles itmTemperaturaFC.Click
        frmTemperaturaFC.Show()
    End Sub

    Private Sub itmImpuesto_Click(sender As Object, e As EventArgs) Handles itmImpuesto.Click
        frmImpuesto.Show()
    End Sub

    Private Sub itmDepreciacionLineal_Click(sender As Object, e As EventArgs) Handles itmDepreciacionLineal.Click
        frmDepreciacionLineal.Show()
    End Sub

    Private Sub itemIMC_Click(sender As Object, e As EventArgs) Handles itemIMC.Click
        frmIMC.Show()
    End Sub
End Class
