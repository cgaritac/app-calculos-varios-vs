<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIMC
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
        Me.lblIMC = New System.Windows.Forms.Label()
        Me.pbIMC = New System.Windows.Forms.PictureBox()
        Me.lblIMCPeso = New System.Windows.Forms.Label()
        Me.txtIMCPeso = New System.Windows.Forms.TextBox()
        Me.lblIMCSexo = New System.Windows.Forms.Label()
        Me.rbIMCMujer = New System.Windows.Forms.RadioButton()
        Me.rbIMCHombre = New System.Windows.Forms.RadioButton()
        Me.txtIMCAltura = New System.Windows.Forms.TextBox()
        Me.lblIMCAltura = New System.Windows.Forms.Label()
        Me.txtIMCValor = New System.Windows.Forms.TextBox()
        Me.lblIMCValor = New System.Windows.Forms.Label()
        Me.btnIMCLimpiar = New System.Windows.Forms.Button()
        Me.btnIMCSalir = New System.Windows.Forms.Button()
        Me.btnIMCCalcular = New System.Windows.Forms.Button()
        Me.lblIMCPeso2 = New System.Windows.Forms.Label()
        Me.lblIMCAltura2 = New System.Windows.Forms.Label()
        Me.txtIMCComposicion = New System.Windows.Forms.TextBox()
        Me.lblIMCComposicion = New System.Windows.Forms.Label()
        CType(Me.pbIMC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblIMC
        '
        Me.lblIMC.AutoSize = True
        Me.lblIMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIMC.Location = New System.Drawing.Point(36, 56)
        Me.lblIMC.Name = "lblIMC"
        Me.lblIMC.Size = New System.Drawing.Size(520, 33)
        Me.lblIMC.TabIndex = 0
        Me.lblIMC.Text = "Cálculo del Índice de Masa Corporal"
        '
        'pbIMC
        '
        Me.pbIMC.BackgroundImage = Global.UsoDeControles.My.Resources.Resources.images2
        Me.pbIMC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbIMC.Location = New System.Drawing.Point(604, 21)
        Me.pbIMC.Name = "pbIMC"
        Me.pbIMC.Size = New System.Drawing.Size(163, 119)
        Me.pbIMC.TabIndex = 1
        Me.pbIMC.TabStop = False
        '
        'lblIMCPeso
        '
        Me.lblIMCPeso.AutoSize = True
        Me.lblIMCPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIMCPeso.Location = New System.Drawing.Point(64, 157)
        Me.lblIMCPeso.Name = "lblIMCPeso"
        Me.lblIMCPeso.Size = New System.Drawing.Size(77, 18)
        Me.lblIMCPeso.TabIndex = 3
        Me.lblIMCPeso.Text = "Peso (kg):"
        '
        'txtIMCPeso
        '
        Me.txtIMCPeso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtIMCPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIMCPeso.Location = New System.Drawing.Point(158, 154)
        Me.txtIMCPeso.Name = "txtIMCPeso"
        Me.txtIMCPeso.Size = New System.Drawing.Size(100, 24)
        Me.txtIMCPeso.TabIndex = 4
        '
        'lblIMCSexo
        '
        Me.lblIMCSexo.AutoSize = True
        Me.lblIMCSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIMCSexo.Location = New System.Drawing.Point(353, 187)
        Me.lblIMCSexo.Name = "lblIMCSexo"
        Me.lblIMCSexo.Size = New System.Drawing.Size(46, 18)
        Me.lblIMCSexo.TabIndex = 6
        Me.lblIMCSexo.Text = "Sexo:"
        '
        'rbIMCMujer
        '
        Me.rbIMCMujer.AutoSize = True
        Me.rbIMCMujer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbIMCMujer.Location = New System.Drawing.Point(420, 172)
        Me.rbIMCMujer.Name = "rbIMCMujer"
        Me.rbIMCMujer.Size = New System.Drawing.Size(66, 22)
        Me.rbIMCMujer.TabIndex = 7
        Me.rbIMCMujer.TabStop = True
        Me.rbIMCMujer.Text = "Mujer"
        Me.rbIMCMujer.UseVisualStyleBackColor = True
        '
        'rbIMCHombre
        '
        Me.rbIMCHombre.AutoSize = True
        Me.rbIMCHombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbIMCHombre.Location = New System.Drawing.Point(420, 199)
        Me.rbIMCHombre.Name = "rbIMCHombre"
        Me.rbIMCHombre.Size = New System.Drawing.Size(83, 22)
        Me.rbIMCHombre.TabIndex = 8
        Me.rbIMCHombre.TabStop = True
        Me.rbIMCHombre.Text = "Hombre"
        Me.rbIMCHombre.UseVisualStyleBackColor = True
        '
        'txtIMCAltura
        '
        Me.txtIMCAltura.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtIMCAltura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIMCAltura.Location = New System.Drawing.Point(173, 205)
        Me.txtIMCAltura.Name = "txtIMCAltura"
        Me.txtIMCAltura.Size = New System.Drawing.Size(100, 24)
        Me.txtIMCAltura.TabIndex = 11
        '
        'lblIMCAltura
        '
        Me.lblIMCAltura.AutoSize = True
        Me.lblIMCAltura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIMCAltura.Location = New System.Drawing.Point(65, 208)
        Me.lblIMCAltura.Name = "lblIMCAltura"
        Me.lblIMCAltura.Size = New System.Drawing.Size(94, 18)
        Me.lblIMCAltura.TabIndex = 10
        Me.lblIMCAltura.Text = "Estatura (m):"
        '
        'txtIMCValor
        '
        Me.txtIMCValor.BackColor = System.Drawing.SystemColors.Control
        Me.txtIMCValor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIMCValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIMCValor.Location = New System.Drawing.Point(489, 308)
        Me.txtIMCValor.Name = "txtIMCValor"
        Me.txtIMCValor.ReadOnly = True
        Me.txtIMCValor.Size = New System.Drawing.Size(100, 17)
        Me.txtIMCValor.TabIndex = 13
        '
        'lblIMCValor
        '
        Me.lblIMCValor.AutoSize = True
        Me.lblIMCValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIMCValor.Location = New System.Drawing.Point(104, 308)
        Me.lblIMCValor.Name = "lblIMCValor"
        Me.lblIMCValor.Size = New System.Drawing.Size(334, 18)
        Me.lblIMCValor.TabIndex = 12
        Me.lblIMCValor.Text = "El valor del índice de masa corporal es de: "
        '
        'btnIMCLimpiar
        '
        Me.btnIMCLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIMCLimpiar.Location = New System.Drawing.Point(642, 230)
        Me.btnIMCLimpiar.Name = "btnIMCLimpiar"
        Me.btnIMCLimpiar.Size = New System.Drawing.Size(94, 27)
        Me.btnIMCLimpiar.TabIndex = 17
        Me.btnIMCLimpiar.Text = "Limpiar"
        Me.btnIMCLimpiar.UseVisualStyleBackColor = True
        '
        'btnIMCSalir
        '
        Me.btnIMCSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIMCSalir.Location = New System.Drawing.Point(642, 280)
        Me.btnIMCSalir.Name = "btnIMCSalir"
        Me.btnIMCSalir.Size = New System.Drawing.Size(94, 27)
        Me.btnIMCSalir.TabIndex = 16
        Me.btnIMCSalir.Text = "Salir"
        Me.btnIMCSalir.UseVisualStyleBackColor = True
        '
        'btnIMCCalcular
        '
        Me.btnIMCCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIMCCalcular.Location = New System.Drawing.Point(642, 183)
        Me.btnIMCCalcular.Name = "btnIMCCalcular"
        Me.btnIMCCalcular.Size = New System.Drawing.Size(94, 27)
        Me.btnIMCCalcular.TabIndex = 15
        Me.btnIMCCalcular.Text = "Calcular"
        Me.btnIMCCalcular.UseVisualStyleBackColor = True
        '
        'lblIMCPeso2
        '
        Me.lblIMCPeso2.AutoSize = True
        Me.lblIMCPeso2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIMCPeso2.Location = New System.Drawing.Point(264, 157)
        Me.lblIMCPeso2.Name = "lblIMCPeso2"
        Me.lblIMCPeso2.Size = New System.Drawing.Size(24, 18)
        Me.lblIMCPeso2.TabIndex = 18
        Me.lblIMCPeso2.Text = "kg"
        '
        'lblIMCAltura2
        '
        Me.lblIMCAltura2.AutoSize = True
        Me.lblIMCAltura2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIMCAltura2.Location = New System.Drawing.Point(279, 208)
        Me.lblIMCAltura2.Name = "lblIMCAltura2"
        Me.lblIMCAltura2.Size = New System.Drawing.Size(21, 18)
        Me.lblIMCAltura2.TabIndex = 19
        Me.lblIMCAltura2.Text = "m"
        '
        'txtIMCComposicion
        '
        Me.txtIMCComposicion.BackColor = System.Drawing.SystemColors.Control
        Me.txtIMCComposicion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIMCComposicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIMCComposicion.Location = New System.Drawing.Point(386, 358)
        Me.txtIMCComposicion.Name = "txtIMCComposicion"
        Me.txtIMCComposicion.ReadOnly = True
        Me.txtIMCComposicion.Size = New System.Drawing.Size(203, 17)
        Me.txtIMCComposicion.TabIndex = 21
        '
        'lblIMCComposicion
        '
        Me.lblIMCComposicion.AutoSize = True
        Me.lblIMCComposicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIMCComposicion.Location = New System.Drawing.Point(104, 358)
        Me.lblIMCComposicion.Name = "lblIMCComposicion"
        Me.lblIMCComposicion.Size = New System.Drawing.Size(224, 18)
        Me.lblIMCComposicion.TabIndex = 20
        Me.lblIMCComposicion.Text = "La composición corporal es:"
        '
        'frmIMC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtIMCComposicion)
        Me.Controls.Add(Me.lblIMCComposicion)
        Me.Controls.Add(Me.lblIMCAltura2)
        Me.Controls.Add(Me.lblIMCPeso2)
        Me.Controls.Add(Me.btnIMCLimpiar)
        Me.Controls.Add(Me.btnIMCSalir)
        Me.Controls.Add(Me.btnIMCCalcular)
        Me.Controls.Add(Me.txtIMCValor)
        Me.Controls.Add(Me.lblIMCValor)
        Me.Controls.Add(Me.txtIMCAltura)
        Me.Controls.Add(Me.lblIMCAltura)
        Me.Controls.Add(Me.rbIMCHombre)
        Me.Controls.Add(Me.rbIMCMujer)
        Me.Controls.Add(Me.lblIMCSexo)
        Me.Controls.Add(Me.txtIMCPeso)
        Me.Controls.Add(Me.lblIMCPeso)
        Me.Controls.Add(Me.pbIMC)
        Me.Controls.Add(Me.lblIMC)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIMC"
        Me.ShowIcon = False
        Me.Text = "Menú Secundario"
        CType(Me.pbIMC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIMC As Label
    Friend WithEvents pbIMC As PictureBox
    Friend WithEvents lblIMCPeso As Label
    Friend WithEvents txtIMCPeso As TextBox
    Friend WithEvents lblIMCSexo As Label
    Friend WithEvents rbIMCMujer As RadioButton
    Friend WithEvents rbIMCHombre As RadioButton
    Friend WithEvents txtIMCAltura As TextBox
    Friend WithEvents lblIMCAltura As Label
    Friend WithEvents txtIMCValor As TextBox
    Friend WithEvents lblIMCValor As Label
    Friend WithEvents btnIMCLimpiar As Button
    Friend WithEvents btnIMCSalir As Button
    Friend WithEvents btnIMCCalcular As Button
    Friend WithEvents lblIMCPeso2 As Label
    Friend WithEvents lblIMCAltura2 As Label
    Friend WithEvents txtIMCComposicion As TextBox
    Friend WithEvents lblIMCComposicion As Label
End Class
