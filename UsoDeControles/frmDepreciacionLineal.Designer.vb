<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepreciacionLineal
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
        Me.lblDereciaciónLineal = New System.Windows.Forms.Label()
        Me.pbDepreciaciónLineal = New System.Windows.Forms.PictureBox()
        Me.chkDepreciacionAnual = New System.Windows.Forms.CheckBox()
        Me.chkDepreciacionMensual = New System.Windows.Forms.CheckBox()
        Me.gbDepreciacion = New System.Windows.Forms.GroupBox()
        Me.lblDepreciacionActivo = New System.Windows.Forms.Label()
        Me.txtDepreciacionActivo = New System.Windows.Forms.TextBox()
        Me.txtDepreciacionAnios = New System.Windows.Forms.TextBox()
        Me.lblDepreciacionAnios = New System.Windows.Forms.Label()
        Me.txtDepreciacionResultado = New System.Windows.Forms.TextBox()
        Me.lblDepreciacionResultado = New System.Windows.Forms.Label()
        Me.btnDepreciacionCalcular = New System.Windows.Forms.Button()
        Me.btnDepreciacionLimpiar = New System.Windows.Forms.Button()
        Me.btnDepreciacionSalir = New System.Windows.Forms.Button()
        Me.lblDepreciacionColones = New System.Windows.Forms.Label()
        Me.lblDepreciacionColones2 = New System.Windows.Forms.Label()
        Me.lblDepreciacionAnios2 = New System.Windows.Forms.Label()
        CType(Me.pbDepreciaciónLineal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDepreciacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDereciaciónLineal
        '
        Me.lblDereciaciónLineal.AutoSize = True
        Me.lblDereciaciónLineal.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDereciaciónLineal.Location = New System.Drawing.Point(73, 60)
        Me.lblDereciaciónLineal.Name = "lblDereciaciónLineal"
        Me.lblDereciaciónLineal.Size = New System.Drawing.Size(448, 33)
        Me.lblDereciaciónLineal.TabIndex = 0
        Me.lblDereciaciónLineal.Text = "Cálculo de Depreciación Lineal"
        '
        'pbDepreciaciónLineal
        '
        Me.pbDepreciaciónLineal.BackgroundImage = Global.UsoDeControles.My.Resources.Resources.images__2_1
        Me.pbDepreciaciónLineal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbDepreciaciónLineal.Location = New System.Drawing.Point(572, 27)
        Me.pbDepreciaciónLineal.Name = "pbDepreciaciónLineal"
        Me.pbDepreciaciónLineal.Size = New System.Drawing.Size(185, 119)
        Me.pbDepreciaciónLineal.TabIndex = 1
        Me.pbDepreciaciónLineal.TabStop = False
        '
        'chkDepreciacionAnual
        '
        Me.chkDepreciacionAnual.AutoSize = True
        Me.chkDepreciacionAnual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDepreciacionAnual.Location = New System.Drawing.Point(32, 49)
        Me.chkDepreciacionAnual.Name = "chkDepreciacionAnual"
        Me.chkDepreciacionAnual.Size = New System.Drawing.Size(66, 22)
        Me.chkDepreciacionAnual.TabIndex = 2
        Me.chkDepreciacionAnual.Text = "Anual"
        Me.chkDepreciacionAnual.UseVisualStyleBackColor = True
        '
        'chkDepreciacionMensual
        '
        Me.chkDepreciacionMensual.AutoSize = True
        Me.chkDepreciacionMensual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDepreciacionMensual.Location = New System.Drawing.Point(32, 77)
        Me.chkDepreciacionMensual.Name = "chkDepreciacionMensual"
        Me.chkDepreciacionMensual.Size = New System.Drawing.Size(86, 22)
        Me.chkDepreciacionMensual.TabIndex = 3
        Me.chkDepreciacionMensual.Text = "Mensual"
        Me.chkDepreciacionMensual.UseVisualStyleBackColor = True
        '
        'gbDepreciacion
        '
        Me.gbDepreciacion.Controls.Add(Me.chkDepreciacionAnual)
        Me.gbDepreciacion.Controls.Add(Me.chkDepreciacionMensual)
        Me.gbDepreciacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDepreciacion.Location = New System.Drawing.Point(59, 158)
        Me.gbDepreciacion.Name = "gbDepreciacion"
        Me.gbDepreciacion.Size = New System.Drawing.Size(200, 125)
        Me.gbDepreciacion.TabIndex = 4
        Me.gbDepreciacion.TabStop = False
        Me.gbDepreciacion.Text = "Tipo de Depreciación Lineal"
        '
        'lblDepreciacionActivo
        '
        Me.lblDepreciacionActivo.AutoSize = True
        Me.lblDepreciacionActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepreciacionActivo.Location = New System.Drawing.Point(287, 174)
        Me.lblDepreciacionActivo.Name = "lblDepreciacionActivo"
        Me.lblDepreciacionActivo.Size = New System.Drawing.Size(113, 18)
        Me.lblDepreciacionActivo.TabIndex = 5
        Me.lblDepreciacionActivo.Text = "Valor del Activo:"
        '
        'txtDepreciacionActivo
        '
        Me.txtDepreciacionActivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDepreciacionActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepreciacionActivo.Location = New System.Drawing.Point(446, 171)
        Me.txtDepreciacionActivo.Name = "txtDepreciacionActivo"
        Me.txtDepreciacionActivo.Size = New System.Drawing.Size(100, 24)
        Me.txtDepreciacionActivo.TabIndex = 6
        '
        'txtDepreciacionAnios
        '
        Me.txtDepreciacionAnios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDepreciacionAnios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepreciacionAnios.Location = New System.Drawing.Point(446, 222)
        Me.txtDepreciacionAnios.Name = "txtDepreciacionAnios"
        Me.txtDepreciacionAnios.Size = New System.Drawing.Size(100, 24)
        Me.txtDepreciacionAnios.TabIndex = 8
        '
        'lblDepreciacionAnios
        '
        Me.lblDepreciacionAnios.AutoSize = True
        Me.lblDepreciacionAnios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepreciacionAnios.Location = New System.Drawing.Point(287, 227)
        Me.lblDepreciacionAnios.Name = "lblDepreciacionAnios"
        Me.lblDepreciacionAnios.Size = New System.Drawing.Size(127, 18)
        Me.lblDepreciacionAnios.TabIndex = 7
        Me.lblDepreciacionAnios.Text = "Cantidad de años:"
        '
        'txtDepreciacionResultado
        '
        Me.txtDepreciacionResultado.BackColor = System.Drawing.SystemColors.Control
        Me.txtDepreciacionResultado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDepreciacionResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepreciacionResultado.Location = New System.Drawing.Point(391, 337)
        Me.txtDepreciacionResultado.Name = "txtDepreciacionResultado"
        Me.txtDepreciacionResultado.ReadOnly = True
        Me.txtDepreciacionResultado.Size = New System.Drawing.Size(100, 17)
        Me.txtDepreciacionResultado.TabIndex = 10
        '
        'lblDepreciacionResultado
        '
        Me.lblDepreciacionResultado.AutoSize = True
        Me.lblDepreciacionResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepreciacionResultado.Location = New System.Drawing.Point(123, 336)
        Me.lblDepreciacionResultado.Name = "lblDepreciacionResultado"
        Me.lblDepreciacionResultado.Size = New System.Drawing.Size(225, 18)
        Me.lblDepreciacionResultado.TabIndex = 9
        Me.lblDepreciacionResultado.Text = "El monto de depreciar es de:"
        '
        'btnDepreciacionCalcular
        '
        Me.btnDepreciacionCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepreciacionCalcular.Location = New System.Drawing.Point(635, 235)
        Me.btnDepreciacionCalcular.Name = "btnDepreciacionCalcular"
        Me.btnDepreciacionCalcular.Size = New System.Drawing.Size(106, 27)
        Me.btnDepreciacionCalcular.TabIndex = 11
        Me.btnDepreciacionCalcular.Text = "Calcular"
        Me.btnDepreciacionCalcular.UseVisualStyleBackColor = True
        '
        'btnDepreciacionLimpiar
        '
        Me.btnDepreciacionLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepreciacionLimpiar.Location = New System.Drawing.Point(635, 283)
        Me.btnDepreciacionLimpiar.Name = "btnDepreciacionLimpiar"
        Me.btnDepreciacionLimpiar.Size = New System.Drawing.Size(106, 28)
        Me.btnDepreciacionLimpiar.TabIndex = 12
        Me.btnDepreciacionLimpiar.Text = "Limpiar"
        Me.btnDepreciacionLimpiar.UseVisualStyleBackColor = True
        '
        'btnDepreciacionSalir
        '
        Me.btnDepreciacionSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepreciacionSalir.Location = New System.Drawing.Point(635, 337)
        Me.btnDepreciacionSalir.Name = "btnDepreciacionSalir"
        Me.btnDepreciacionSalir.Size = New System.Drawing.Size(106, 27)
        Me.btnDepreciacionSalir.TabIndex = 13
        Me.btnDepreciacionSalir.Text = "Salir"
        Me.btnDepreciacionSalir.UseVisualStyleBackColor = True
        '
        'lblDepreciacionColones
        '
        Me.lblDepreciacionColones.AutoSize = True
        Me.lblDepreciacionColones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepreciacionColones.Location = New System.Drawing.Point(552, 174)
        Me.lblDepreciacionColones.Name = "lblDepreciacionColones"
        Me.lblDepreciacionColones.Size = New System.Drawing.Size(61, 18)
        Me.lblDepreciacionColones.TabIndex = 14
        Me.lblDepreciacionColones.Text = "colones"
        '
        'lblDepreciacionColones2
        '
        Me.lblDepreciacionColones2.AutoSize = True
        Me.lblDepreciacionColones2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepreciacionColones2.Location = New System.Drawing.Point(497, 336)
        Me.lblDepreciacionColones2.Name = "lblDepreciacionColones2"
        Me.lblDepreciacionColones2.Size = New System.Drawing.Size(68, 18)
        Me.lblDepreciacionColones2.TabIndex = 15
        Me.lblDepreciacionColones2.Text = "colones"
        '
        'lblDepreciacionAnios2
        '
        Me.lblDepreciacionAnios2.AutoSize = True
        Me.lblDepreciacionAnios2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepreciacionAnios2.Location = New System.Drawing.Point(552, 225)
        Me.lblDepreciacionAnios2.Name = "lblDepreciacionAnios2"
        Me.lblDepreciacionAnios2.Size = New System.Drawing.Size(41, 18)
        Me.lblDepreciacionAnios2.TabIndex = 16
        Me.lblDepreciacionAnios2.Text = "años"
        '
        'frmDepreciacionLineal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblDepreciacionAnios2)
        Me.Controls.Add(Me.lblDepreciacionColones2)
        Me.Controls.Add(Me.lblDepreciacionColones)
        Me.Controls.Add(Me.btnDepreciacionSalir)
        Me.Controls.Add(Me.btnDepreciacionLimpiar)
        Me.Controls.Add(Me.btnDepreciacionCalcular)
        Me.Controls.Add(Me.txtDepreciacionResultado)
        Me.Controls.Add(Me.lblDepreciacionResultado)
        Me.Controls.Add(Me.txtDepreciacionAnios)
        Me.Controls.Add(Me.lblDepreciacionAnios)
        Me.Controls.Add(Me.txtDepreciacionActivo)
        Me.Controls.Add(Me.lblDepreciacionActivo)
        Me.Controls.Add(Me.gbDepreciacion)
        Me.Controls.Add(Me.pbDepreciaciónLineal)
        Me.Controls.Add(Me.lblDereciaciónLineal)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDepreciacionLineal"
        Me.ShowIcon = False
        Me.Text = "Menú Secundario"
        CType(Me.pbDepreciaciónLineal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDepreciacion.ResumeLayout(False)
        Me.gbDepreciacion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDereciaciónLineal As Label
    Friend WithEvents pbDepreciaciónLineal As PictureBox
    Friend WithEvents chkDepreciacionAnual As CheckBox
    Friend WithEvents chkDepreciacionMensual As CheckBox
    Friend WithEvents gbDepreciacion As GroupBox
    Friend WithEvents lblDepreciacionActivo As Label
    Friend WithEvents txtDepreciacionActivo As TextBox
    Friend WithEvents txtDepreciacionAnios As TextBox
    Friend WithEvents lblDepreciacionAnios As Label
    Friend WithEvents txtDepreciacionResultado As TextBox
    Friend WithEvents lblDepreciacionResultado As Label
    Friend WithEvents btnDepreciacionCalcular As Button
    Friend WithEvents btnDepreciacionLimpiar As Button
    Friend WithEvents btnDepreciacionSalir As Button
    Friend WithEvents lblDepreciacionColones As Label
    Friend WithEvents lblDepreciacionColones2 As Label
    Friend WithEvents lblDepreciacionAnios2 As Label
End Class
