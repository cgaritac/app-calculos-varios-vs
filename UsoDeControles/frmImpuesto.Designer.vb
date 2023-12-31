<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpuesto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblImpuesto = New System.Windows.Forms.Label()
        Me.pbImpuesto = New System.Windows.Forms.PictureBox()
        Me.cbImpuestoTipo = New System.Windows.Forms.ComboBox()
        Me.lblImpuestoTipo = New System.Windows.Forms.Label()
        Me.lblImpuestoCosto = New System.Windows.Forms.Label()
        Me.txtImpuestoCosto = New System.Windows.Forms.TextBox()
        Me.txtImpuestoMonto = New System.Windows.Forms.TextBox()
        Me.lblImpuestoMonto = New System.Windows.Forms.Label()
        Me.btnImpuestoCalcular = New System.Windows.Forms.Button()
        Me.btnImpuestoSalir = New System.Windows.Forms.Button()
        Me.btnImpuestoLimpiar = New System.Windows.Forms.Button()
        Me.txtImpuestoCostoTot = New System.Windows.Forms.TextBox()
        Me.lblImpuestoCostoTot = New System.Windows.Forms.Label()
        Me.lblImpuestoMonto2 = New System.Windows.Forms.Label()
        Me.lblImpuestoCostoTot2 = New System.Windows.Forms.Label()
        Me.lblImpuestoCosto2 = New System.Windows.Forms.Label()
        CType(Me.pbImpuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblImpuesto
        '
        Me.lblImpuesto.AutoSize = True
        Me.lblImpuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpuesto.Location = New System.Drawing.Point(45, 52)
        Me.lblImpuesto.Name = "lblImpuesto"
        Me.lblImpuesto.Size = New System.Drawing.Size(456, 33)
        Me.lblImpuesto.TabIndex = 0
        Me.lblImpuesto.Text = "Cálculo del Impuesto de Ventas"
        '
        'pbImpuesto
        '
        Me.pbImpuesto.BackgroundImage = Global.UsoDeControles.My.Resources.Resources.impuesto_png_2
        Me.pbImpuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbImpuesto.Location = New System.Drawing.Point(557, 12)
        Me.pbImpuesto.Name = "pbImpuesto"
        Me.pbImpuesto.Size = New System.Drawing.Size(183, 128)
        Me.pbImpuesto.TabIndex = 1
        Me.pbImpuesto.TabStop = False
        '
        'cbImpuestoTipo
        '
        Me.cbImpuestoTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbImpuestoTipo.FormattingEnabled = True
        Me.cbImpuestoTipo.Items.AddRange(New Object() {"Accesorio de carro 42,78 %", "Ropa 29,95 %", "Adorno 29,95 %", "Aire acondicionado doméstico 75,04 %", "Accesorios de computadora 42,38 %", "Bisutería 29,95 %", "Cámara 13,00 %", "Accesorio de celular 14,13 %", "Juguetes 29,95 %", "Computadora 13,00 %", "Libro 1,00 %", "Reproductor MP3 49,27 %", "Consola de video juegos 55,71 %", "Instrumento musical 24,3 %", "Televisor o monitor 49,27 %"})
        Me.cbImpuestoTipo.Location = New System.Drawing.Point(222, 150)
        Me.cbImpuestoTipo.Name = "cbImpuestoTipo"
        Me.cbImpuestoTipo.Size = New System.Drawing.Size(326, 26)
        Me.cbImpuestoTipo.TabIndex = 2
        '
        'lblImpuestoTipo
        '
        Me.lblImpuestoTipo.AutoSize = True
        Me.lblImpuestoTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpuestoTipo.Location = New System.Drawing.Point(86, 153)
        Me.lblImpuestoTipo.Name = "lblImpuestoTipo"
        Me.lblImpuestoTipo.Size = New System.Drawing.Size(113, 18)
        Me.lblImpuestoTipo.TabIndex = 3
        Me.lblImpuestoTipo.Text = "Tipo de artículo:"
        '
        'lblImpuestoCosto
        '
        Me.lblImpuestoCosto.AutoSize = True
        Me.lblImpuestoCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpuestoCosto.Location = New System.Drawing.Point(86, 204)
        Me.lblImpuestoCosto.Name = "lblImpuestoCosto"
        Me.lblImpuestoCosto.Size = New System.Drawing.Size(128, 18)
        Me.lblImpuestoCosto.TabIndex = 4
        Me.lblImpuestoCosto.Text = "Costo del artículo:"
        '
        'txtImpuestoCosto
        '
        Me.txtImpuestoCosto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtImpuestoCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpuestoCosto.Location = New System.Drawing.Point(252, 201)
        Me.txtImpuestoCosto.Name = "txtImpuestoCosto"
        Me.txtImpuestoCosto.Size = New System.Drawing.Size(100, 24)
        Me.txtImpuestoCosto.TabIndex = 5
        '
        'txtImpuestoMonto
        '
        Me.txtImpuestoMonto.BackColor = System.Drawing.SystemColors.Control
        Me.txtImpuestoMonto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtImpuestoMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpuestoMonto.Location = New System.Drawing.Point(473, 323)
        Me.txtImpuestoMonto.Name = "txtImpuestoMonto"
        Me.txtImpuestoMonto.ReadOnly = True
        Me.txtImpuestoMonto.Size = New System.Drawing.Size(100, 17)
        Me.txtImpuestoMonto.TabIndex = 7
        '
        'lblImpuestoMonto
        '
        Me.lblImpuestoMonto.AutoSize = True
        Me.lblImpuestoMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpuestoMonto.Location = New System.Drawing.Point(114, 324)
        Me.lblImpuestoMonto.Name = "lblImpuestoMonto"
        Me.lblImpuestoMonto.Size = New System.Drawing.Size(305, 18)
        Me.lblImpuestoMonto.TabIndex = 6
        Me.lblImpuestoMonto.Text = "El monto del impuesto de ventas es de:"
        '
        'btnImpuestoCalcular
        '
        Me.btnImpuestoCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImpuestoCalcular.Location = New System.Drawing.Point(634, 172)
        Me.btnImpuestoCalcular.Name = "btnImpuestoCalcular"
        Me.btnImpuestoCalcular.Size = New System.Drawing.Size(91, 27)
        Me.btnImpuestoCalcular.TabIndex = 8
        Me.btnImpuestoCalcular.Text = "Calcular"
        Me.btnImpuestoCalcular.UseVisualStyleBackColor = True
        '
        'btnImpuestoSalir
        '
        Me.btnImpuestoSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImpuestoSalir.Location = New System.Drawing.Point(634, 269)
        Me.btnImpuestoSalir.Name = "btnImpuestoSalir"
        Me.btnImpuestoSalir.Size = New System.Drawing.Size(91, 27)
        Me.btnImpuestoSalir.TabIndex = 9
        Me.btnImpuestoSalir.Text = "Salir"
        Me.btnImpuestoSalir.UseVisualStyleBackColor = True
        '
        'btnImpuestoLimpiar
        '
        Me.btnImpuestoLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImpuestoLimpiar.Location = New System.Drawing.Point(634, 219)
        Me.btnImpuestoLimpiar.Name = "btnImpuestoLimpiar"
        Me.btnImpuestoLimpiar.Size = New System.Drawing.Size(91, 27)
        Me.btnImpuestoLimpiar.TabIndex = 10
        Me.btnImpuestoLimpiar.Text = "Limpiar"
        Me.btnImpuestoLimpiar.UseVisualStyleBackColor = True
        '
        'txtImpuestoCostoTot
        '
        Me.txtImpuestoCostoTot.BackColor = System.Drawing.SystemColors.Control
        Me.txtImpuestoCostoTot.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtImpuestoCostoTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpuestoCostoTot.Location = New System.Drawing.Point(438, 374)
        Me.txtImpuestoCostoTot.Name = "txtImpuestoCostoTot"
        Me.txtImpuestoCostoTot.ReadOnly = True
        Me.txtImpuestoCostoTot.Size = New System.Drawing.Size(100, 17)
        Me.txtImpuestoCostoTot.TabIndex = 12
        '
        'lblImpuestoCostoTot
        '
        Me.lblImpuestoCostoTot.AutoSize = True
        Me.lblImpuestoCostoTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpuestoCostoTot.Location = New System.Drawing.Point(114, 373)
        Me.lblImpuestoCostoTot.Name = "lblImpuestoCostoTot"
        Me.lblImpuestoCostoTot.Size = New System.Drawing.Size(283, 18)
        Me.lblImpuestoCostoTot.TabIndex = 11
        Me.lblImpuestoCostoTot.Text = "El costo total del artículo (IVI) es de:"
        '
        'lblImpuestoMonto2
        '
        Me.lblImpuestoMonto2.AutoSize = True
        Me.lblImpuestoMonto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpuestoMonto2.Location = New System.Drawing.Point(579, 323)
        Me.lblImpuestoMonto2.Name = "lblImpuestoMonto2"
        Me.lblImpuestoMonto2.Size = New System.Drawing.Size(68, 18)
        Me.lblImpuestoMonto2.TabIndex = 13
        Me.lblImpuestoMonto2.Text = "colones"
        '
        'lblImpuestoCostoTot2
        '
        Me.lblImpuestoCostoTot2.AutoSize = True
        Me.lblImpuestoCostoTot2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpuestoCostoTot2.Location = New System.Drawing.Point(544, 374)
        Me.lblImpuestoCostoTot2.Name = "lblImpuestoCostoTot2"
        Me.lblImpuestoCostoTot2.Size = New System.Drawing.Size(68, 18)
        Me.lblImpuestoCostoTot2.TabIndex = 14
        Me.lblImpuestoCostoTot2.Text = "colones"
        '
        'lblImpuestoCosto2
        '
        Me.lblImpuestoCosto2.AutoSize = True
        Me.lblImpuestoCosto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpuestoCosto2.Location = New System.Drawing.Point(358, 204)
        Me.lblImpuestoCosto2.Name = "lblImpuestoCosto2"
        Me.lblImpuestoCosto2.Size = New System.Drawing.Size(61, 18)
        Me.lblImpuestoCosto2.TabIndex = 15
        Me.lblImpuestoCosto2.Text = "colones"
        '
        'frmImpuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblImpuestoCosto2)
        Me.Controls.Add(Me.lblImpuestoCostoTot2)
        Me.Controls.Add(Me.lblImpuestoMonto2)
        Me.Controls.Add(Me.txtImpuestoCostoTot)
        Me.Controls.Add(Me.lblImpuestoCostoTot)
        Me.Controls.Add(Me.btnImpuestoLimpiar)
        Me.Controls.Add(Me.btnImpuestoSalir)
        Me.Controls.Add(Me.btnImpuestoCalcular)
        Me.Controls.Add(Me.txtImpuestoMonto)
        Me.Controls.Add(Me.lblImpuestoMonto)
        Me.Controls.Add(Me.txtImpuestoCosto)
        Me.Controls.Add(Me.lblImpuestoCosto)
        Me.Controls.Add(Me.lblImpuestoTipo)
        Me.Controls.Add(Me.cbImpuestoTipo)
        Me.Controls.Add(Me.pbImpuesto)
        Me.Controls.Add(Me.lblImpuesto)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImpuesto"
        Me.ShowIcon = False
        Me.Text = "Menú Secundario"
        CType(Me.pbImpuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblImpuesto As Label
    Friend WithEvents pbImpuesto As PictureBox
    Friend WithEvents cbImpuestoTipo As ComboBox
    Friend WithEvents lblImpuestoTipo As Label
    Friend WithEvents lblImpuestoCosto As Label
    Friend WithEvents txtImpuestoCosto As TextBox
    Friend WithEvents txtImpuestoMonto As TextBox
    Friend WithEvents lblImpuestoMonto As Label
    Friend WithEvents btnImpuestoCalcular As Button
    Friend WithEvents btnImpuestoSalir As Button
    Friend WithEvents btnImpuestoLimpiar As Button
    Friend WithEvents txtImpuestoCostoTot As TextBox
    Friend WithEvents lblImpuestoCostoTot As Label
    Friend WithEvents lblImpuestoMonto2 As Label
    Friend WithEvents lblImpuestoCostoTot2 As Label
    Friend WithEvents lblImpuestoCosto2 As Label
End Class
