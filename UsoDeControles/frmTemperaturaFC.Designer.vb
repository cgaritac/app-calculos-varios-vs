<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemperaturaFC
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
        Me.lblTempraturaFC = New System.Windows.Forms.Label()
        Me.pbTemperaturaFC = New System.Windows.Forms.PictureBox()
        Me.tbcTemperaturaFC = New System.Windows.Forms.TabControl()
        Me.tbcFC = New System.Windows.Forms.TabPage()
        Me.lblFahrenheitFC2 = New System.Windows.Forms.Label()
        Me.lblCelsiusFC2 = New System.Windows.Forms.Label()
        Me.btnFahrCelsCalcular = New System.Windows.Forms.Button()
        Me.btnFahrCelsLimpiar = New System.Windows.Forms.Button()
        Me.txtCelsiusFC = New System.Windows.Forms.TextBox()
        Me.txtFahrenheitFC = New System.Windows.Forms.TextBox()
        Me.lblCelsiusFC = New System.Windows.Forms.Label()
        Me.lblFahrenheitFC = New System.Windows.Forms.Label()
        Me.tbcCF = New System.Windows.Forms.TabPage()
        Me.lblCelsiusCF2 = New System.Windows.Forms.Label()
        Me.lblFahrenheitCF2 = New System.Windows.Forms.Label()
        Me.btnCelsFahrCalcular = New System.Windows.Forms.Button()
        Me.btnCelsFahrLimpiar = New System.Windows.Forms.Button()
        Me.txtFahrenheitCF = New System.Windows.Forms.TextBox()
        Me.txtCelsiusCF = New System.Windows.Forms.TextBox()
        Me.lblFahrenheitCF = New System.Windows.Forms.Label()
        Me.lblCelsiusCF = New System.Windows.Forms.Label()
        Me.btnTemperaturaSalir = New System.Windows.Forms.Button()
        CType(Me.pbTemperaturaFC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcTemperaturaFC.SuspendLayout()
        Me.tbcFC.SuspendLayout()
        Me.tbcCF.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTempraturaFC
        '
        Me.lblTempraturaFC.AutoSize = True
        Me.lblTempraturaFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempraturaFC.Location = New System.Drawing.Point(33, 53)
        Me.lblTempraturaFC.Name = "lblTempraturaFC"
        Me.lblTempraturaFC.Size = New System.Drawing.Size(513, 33)
        Me.lblTempraturaFC.TabIndex = 0
        Me.lblTempraturaFC.Text = "Conversión de Temperatura °F y °C"
        '
        'pbTemperaturaFC
        '
        Me.pbTemperaturaFC.BackgroundImage = Global.UsoDeControles.My.Resources.Resources.Portada_Calor_640x360
        Me.pbTemperaturaFC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbTemperaturaFC.Location = New System.Drawing.Point(617, 12)
        Me.pbTemperaturaFC.Name = "pbTemperaturaFC"
        Me.pbTemperaturaFC.Size = New System.Drawing.Size(203, 135)
        Me.pbTemperaturaFC.TabIndex = 1
        Me.pbTemperaturaFC.TabStop = False
        '
        'tbcTemperaturaFC
        '
        Me.tbcTemperaturaFC.Controls.Add(Me.tbcFC)
        Me.tbcTemperaturaFC.Controls.Add(Me.tbcCF)
        Me.tbcTemperaturaFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcTemperaturaFC.Location = New System.Drawing.Point(2, 135)
        Me.tbcTemperaturaFC.Name = "tbcTemperaturaFC"
        Me.tbcTemperaturaFC.SelectedIndex = 0
        Me.tbcTemperaturaFC.Size = New System.Drawing.Size(829, 316)
        Me.tbcTemperaturaFC.TabIndex = 2
        '
        'tbcFC
        '
        Me.tbcFC.Controls.Add(Me.lblFahrenheitFC2)
        Me.tbcFC.Controls.Add(Me.lblCelsiusFC2)
        Me.tbcFC.Controls.Add(Me.btnFahrCelsCalcular)
        Me.tbcFC.Controls.Add(Me.btnFahrCelsLimpiar)
        Me.tbcFC.Controls.Add(Me.txtCelsiusFC)
        Me.tbcFC.Controls.Add(Me.txtFahrenheitFC)
        Me.tbcFC.Controls.Add(Me.lblCelsiusFC)
        Me.tbcFC.Controls.Add(Me.lblFahrenheitFC)
        Me.tbcFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcFC.Location = New System.Drawing.Point(4, 27)
        Me.tbcFC.Name = "tbcFC"
        Me.tbcFC.Padding = New System.Windows.Forms.Padding(3)
        Me.tbcFC.Size = New System.Drawing.Size(821, 285)
        Me.tbcFC.TabIndex = 0
        Me.tbcFC.Text = "Conversión °F a °C"
        Me.tbcFC.UseVisualStyleBackColor = True
        '
        'lblFahrenheitFC2
        '
        Me.lblFahrenheitFC2.AutoSize = True
        Me.lblFahrenheitFC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFahrenheitFC2.Location = New System.Drawing.Point(482, 71)
        Me.lblFahrenheitFC2.Name = "lblFahrenheitFC2"
        Me.lblFahrenheitFC2.Size = New System.Drawing.Size(23, 18)
        Me.lblFahrenheitFC2.TabIndex = 28
        Me.lblFahrenheitFC2.Text = "°F"
        '
        'lblCelsiusFC2
        '
        Me.lblCelsiusFC2.AutoSize = True
        Me.lblCelsiusFC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelsiusFC2.Location = New System.Drawing.Point(608, 149)
        Me.lblCelsiusFC2.Name = "lblCelsiusFC2"
        Me.lblCelsiusFC2.Size = New System.Drawing.Size(27, 18)
        Me.lblCelsiusFC2.TabIndex = 27
        Me.lblCelsiusFC2.Text = "°C"
        '
        'btnFahrCelsCalcular
        '
        Me.btnFahrCelsCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFahrCelsCalcular.Location = New System.Drawing.Point(208, 215)
        Me.btnFahrCelsCalcular.Name = "btnFahrCelsCalcular"
        Me.btnFahrCelsCalcular.Size = New System.Drawing.Size(106, 27)
        Me.btnFahrCelsCalcular.TabIndex = 23
        Me.btnFahrCelsCalcular.Text = "Calcular"
        Me.btnFahrCelsCalcular.UseVisualStyleBackColor = True
        '
        'btnFahrCelsLimpiar
        '
        Me.btnFahrCelsLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFahrCelsLimpiar.Location = New System.Drawing.Point(485, 215)
        Me.btnFahrCelsLimpiar.Name = "btnFahrCelsLimpiar"
        Me.btnFahrCelsLimpiar.Size = New System.Drawing.Size(106, 29)
        Me.btnFahrCelsLimpiar.TabIndex = 26
        Me.btnFahrCelsLimpiar.Text = "Limpiar"
        Me.btnFahrCelsLimpiar.UseVisualStyleBackColor = True
        '
        'txtCelsiusFC
        '
        Me.txtCelsiusFC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCelsiusFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelsiusFC.Location = New System.Drawing.Point(502, 149)
        Me.txtCelsiusFC.Name = "txtCelsiusFC"
        Me.txtCelsiusFC.ReadOnly = True
        Me.txtCelsiusFC.Size = New System.Drawing.Size(100, 17)
        Me.txtCelsiusFC.TabIndex = 25
        '
        'txtFahrenheitFC
        '
        Me.txtFahrenheitFC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtFahrenheitFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFahrenheitFC.Location = New System.Drawing.Point(376, 68)
        Me.txtFahrenheitFC.Name = "txtFahrenheitFC"
        Me.txtFahrenheitFC.Size = New System.Drawing.Size(100, 24)
        Me.txtFahrenheitFC.TabIndex = 24
        '
        'lblCelsiusFC
        '
        Me.lblCelsiusFC.AutoSize = True
        Me.lblCelsiusFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelsiusFC.Location = New System.Drawing.Point(54, 149)
        Me.lblCelsiusFC.Name = "lblCelsiusFC"
        Me.lblCelsiusFC.Size = New System.Drawing.Size(393, 18)
        Me.lblCelsiusFC.TabIndex = 22
        Me.lblCelsiusFC.Text = "El valor de la temperatura en grados Celsius es de:"
        '
        'lblFahrenheitFC
        '
        Me.lblFahrenheitFC.AutoSize = True
        Me.lblFahrenheitFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFahrenheitFC.Location = New System.Drawing.Point(54, 71)
        Me.lblFahrenheitFC.Name = "lblFahrenheitFC"
        Me.lblFahrenheitFC.Size = New System.Drawing.Size(272, 18)
        Me.lblFahrenheitFC.TabIndex = 21
        Me.lblFahrenheitFC.Text = "Temperatura en grados Fahrenheit (°F): "
        '
        'tbcCF
        '
        Me.tbcCF.Controls.Add(Me.lblCelsiusCF2)
        Me.tbcCF.Controls.Add(Me.lblFahrenheitCF2)
        Me.tbcCF.Controls.Add(Me.btnCelsFahrCalcular)
        Me.tbcCF.Controls.Add(Me.btnCelsFahrLimpiar)
        Me.tbcCF.Controls.Add(Me.txtFahrenheitCF)
        Me.tbcCF.Controls.Add(Me.txtCelsiusCF)
        Me.tbcCF.Controls.Add(Me.lblFahrenheitCF)
        Me.tbcCF.Controls.Add(Me.lblCelsiusCF)
        Me.tbcCF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcCF.Location = New System.Drawing.Point(4, 27)
        Me.tbcCF.Name = "tbcCF"
        Me.tbcCF.Padding = New System.Windows.Forms.Padding(3)
        Me.tbcCF.Size = New System.Drawing.Size(821, 285)
        Me.tbcCF.TabIndex = 1
        Me.tbcCF.Text = "Conversión °C a °F"
        Me.tbcCF.UseVisualStyleBackColor = True
        '
        'lblCelsiusCF2
        '
        Me.lblCelsiusCF2.AutoSize = True
        Me.lblCelsiusCF2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelsiusCF2.Location = New System.Drawing.Point(472, 69)
        Me.lblCelsiusCF2.Name = "lblCelsiusCF2"
        Me.lblCelsiusCF2.Size = New System.Drawing.Size(25, 18)
        Me.lblCelsiusCF2.TabIndex = 36
        Me.lblCelsiusCF2.Text = "°C"
        '
        'lblFahrenheitCF2
        '
        Me.lblFahrenheitCF2.AutoSize = True
        Me.lblFahrenheitCF2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFahrenheitCF2.Location = New System.Drawing.Point(588, 148)
        Me.lblFahrenheitCF2.Name = "lblFahrenheitCF2"
        Me.lblFahrenheitCF2.Size = New System.Drawing.Size(25, 18)
        Me.lblFahrenheitCF2.TabIndex = 35
        Me.lblFahrenheitCF2.Text = "°F"
        '
        'btnCelsFahrCalcular
        '
        Me.btnCelsFahrCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCelsFahrCalcular.Location = New System.Drawing.Point(230, 213)
        Me.btnCelsFahrCalcular.Name = "btnCelsFahrCalcular"
        Me.btnCelsFahrCalcular.Size = New System.Drawing.Size(101, 27)
        Me.btnCelsFahrCalcular.TabIndex = 31
        Me.btnCelsFahrCalcular.Text = "Calcular"
        Me.btnCelsFahrCalcular.UseVisualStyleBackColor = True
        '
        'btnCelsFahrLimpiar
        '
        Me.btnCelsFahrLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCelsFahrLimpiar.Location = New System.Drawing.Point(475, 213)
        Me.btnCelsFahrLimpiar.Name = "btnCelsFahrLimpiar"
        Me.btnCelsFahrLimpiar.Size = New System.Drawing.Size(101, 29)
        Me.btnCelsFahrLimpiar.TabIndex = 34
        Me.btnCelsFahrLimpiar.Text = "Limpiar"
        Me.btnCelsFahrLimpiar.UseVisualStyleBackColor = True
        '
        'txtFahrenheitCF
        '
        Me.txtFahrenheitCF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFahrenheitCF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFahrenheitCF.Location = New System.Drawing.Point(513, 148)
        Me.txtFahrenheitCF.Name = "txtFahrenheitCF"
        Me.txtFahrenheitCF.ReadOnly = True
        Me.txtFahrenheitCF.Size = New System.Drawing.Size(100, 17)
        Me.txtFahrenheitCF.TabIndex = 33
        '
        'txtCelsiusCF
        '
        Me.txtCelsiusCF.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtCelsiusCF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelsiusCF.Location = New System.Drawing.Point(366, 66)
        Me.txtCelsiusCF.Name = "txtCelsiusCF"
        Me.txtCelsiusCF.Size = New System.Drawing.Size(100, 24)
        Me.txtCelsiusCF.TabIndex = 32
        '
        'lblFahrenheitCF
        '
        Me.lblFahrenheitCF.AutoSize = True
        Me.lblFahrenheitCF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFahrenheitCF.Location = New System.Drawing.Point(30, 148)
        Me.lblFahrenheitCF.Name = "lblFahrenheitCF"
        Me.lblFahrenheitCF.Size = New System.Drawing.Size(416, 18)
        Me.lblFahrenheitCF.TabIndex = 30
        Me.lblFahrenheitCF.Text = "El valor de la temperatura en grados Fahrenheit es de:"
        '
        'lblCelsiusCF
        '
        Me.lblCelsiusCF.AutoSize = True
        Me.lblCelsiusCF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelsiusCF.Location = New System.Drawing.Point(50, 69)
        Me.lblCelsiusCF.Name = "lblCelsiusCF"
        Me.lblCelsiusCF.Size = New System.Drawing.Size(254, 18)
        Me.lblCelsiusCF.TabIndex = 29
        Me.lblCelsiusCF.Text = "Temperatura en grados Celsius (°C): "
        '
        'btnTemperaturaSalir
        '
        Me.btnTemperaturaSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTemperaturaSalir.Location = New System.Drawing.Point(500, 106)
        Me.btnTemperaturaSalir.Name = "btnTemperaturaSalir"
        Me.btnTemperaturaSalir.Size = New System.Drawing.Size(75, 27)
        Me.btnTemperaturaSalir.TabIndex = 10
        Me.btnTemperaturaSalir.Text = "Salir"
        Me.btnTemperaturaSalir.UseVisualStyleBackColor = True
        '
        'frmTemperaturaFC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 450)
        Me.Controls.Add(Me.btnTemperaturaSalir)
        Me.Controls.Add(Me.pbTemperaturaFC)
        Me.Controls.Add(Me.tbcTemperaturaFC)
        Me.Controls.Add(Me.lblTempraturaFC)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTemperaturaFC"
        Me.ShowIcon = False
        Me.Text = "Menú Secundario"
        CType(Me.pbTemperaturaFC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcTemperaturaFC.ResumeLayout(False)
        Me.tbcFC.ResumeLayout(False)
        Me.tbcFC.PerformLayout()
        Me.tbcCF.ResumeLayout(False)
        Me.tbcCF.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTempraturaFC As Label
    Friend WithEvents pbTemperaturaFC As PictureBox
    Friend WithEvents tbcTemperaturaFC As TabControl
    Friend WithEvents tbcFC As TabPage
    Friend WithEvents tbcCF As TabPage
    Friend WithEvents btnTemperaturaSalir As Button
    Friend WithEvents lblFahrenheitFC2 As Label
    Friend WithEvents lblCelsiusFC2 As Label
    Friend WithEvents btnFahrCelsCalcular As Button
    Friend WithEvents btnFahrCelsLimpiar As Button
    Friend WithEvents txtCelsiusFC As TextBox
    Friend WithEvents txtFahrenheitFC As TextBox
    Friend WithEvents lblCelsiusFC As Label
    Friend WithEvents lblFahrenheitFC As Label
    Friend WithEvents lblCelsiusCF2 As Label
    Friend WithEvents lblFahrenheitCF2 As Label
    Friend WithEvents btnCelsFahrCalcular As Button
    Friend WithEvents btnCelsFahrLimpiar As Button
    Friend WithEvents txtFahrenheitCF As TextBox
    Friend WithEvents txtCelsiusCF As TextBox
    Friend WithEvents lblFahrenheitCF As Label
    Friend WithEvents lblCelsiusCF As Label
End Class
