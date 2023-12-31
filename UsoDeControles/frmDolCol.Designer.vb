<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDolCol
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
        Me.lblDolCol = New System.Windows.Forms.Label()
        Me.pbColDol = New System.Windows.Forms.PictureBox()
        Me.btnDolColCalcular = New System.Windows.Forms.Button()
        Me.tbcConversionDolCol = New System.Windows.Forms.TabControl()
        Me.tbcDolCol = New System.Windows.Forms.TabPage()
        Me.lblCambioDC2 = New System.Windows.Forms.Label()
        Me.txtCambioDC = New System.Windows.Forms.TextBox()
        Me.lblCambioDC = New System.Windows.Forms.Label()
        Me.lblDolDC2 = New System.Windows.Forms.Label()
        Me.lblColDC2 = New System.Windows.Forms.Label()
        Me.btnDolColLimpiar = New System.Windows.Forms.Button()
        Me.txtColDC = New System.Windows.Forms.TextBox()
        Me.txtDolDC = New System.Windows.Forms.TextBox()
        Me.lblColDC = New System.Windows.Forms.Label()
        Me.lblDolDC = New System.Windows.Forms.Label()
        Me.tbcColDol = New System.Windows.Forms.TabPage()
        Me.lblCambioCD2 = New System.Windows.Forms.Label()
        Me.txtCambioCD = New System.Windows.Forms.TextBox()
        Me.lblCambioCD = New System.Windows.Forms.Label()
        Me.lblColCD2 = New System.Windows.Forms.Label()
        Me.lblDolCD2 = New System.Windows.Forms.Label()
        Me.btnColDolCalcular = New System.Windows.Forms.Button()
        Me.btnColDolLimpiar = New System.Windows.Forms.Button()
        Me.txtDolCD = New System.Windows.Forms.TextBox()
        Me.txtColCD = New System.Windows.Forms.TextBox()
        Me.lblDolCD = New System.Windows.Forms.Label()
        Me.lblColCD = New System.Windows.Forms.Label()
        Me.btnDolColSalir = New System.Windows.Forms.Button()
        CType(Me.pbColDol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcConversionDolCol.SuspendLayout()
        Me.tbcDolCol.SuspendLayout()
        Me.tbcColDol.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDolCol
        '
        Me.lblDolCol.AutoSize = True
        Me.lblDolCol.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDolCol.Location = New System.Drawing.Point(50, 34)
        Me.lblDolCol.Name = "lblDolCol"
        Me.lblDolCol.Size = New System.Drawing.Size(481, 33)
        Me.lblDolCol.TabIndex = 0
        Me.lblDolCol.Text = "Conversión de Dólares y Colones"
        '
        'pbColDol
        '
        Me.pbColDol.BackgroundImage = Global.UsoDeControles.My.Resources.Resources.images
        Me.pbColDol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbColDol.Location = New System.Drawing.Point(612, 12)
        Me.pbColDol.Name = "pbColDol"
        Me.pbColDol.Size = New System.Drawing.Size(208, 136)
        Me.pbColDol.TabIndex = 1
        Me.pbColDol.TabStop = False
        '
        'btnDolColCalcular
        '
        Me.btnDolColCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDolColCalcular.Location = New System.Drawing.Point(616, 73)
        Me.btnDolColCalcular.Name = "btnDolColCalcular"
        Me.btnDolColCalcular.Size = New System.Drawing.Size(106, 27)
        Me.btnDolColCalcular.TabIndex = 2
        Me.btnDolColCalcular.Text = "Calcular"
        Me.btnDolColCalcular.UseVisualStyleBackColor = True
        '
        'tbcConversionDolCol
        '
        Me.tbcConversionDolCol.Controls.Add(Me.tbcDolCol)
        Me.tbcConversionDolCol.Controls.Add(Me.tbcColDol)
        Me.tbcConversionDolCol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcConversionDolCol.Location = New System.Drawing.Point(3, 132)
        Me.tbcConversionDolCol.Name = "tbcConversionDolCol"
        Me.tbcConversionDolCol.SelectedIndex = 0
        Me.tbcConversionDolCol.Size = New System.Drawing.Size(831, 315)
        Me.tbcConversionDolCol.TabIndex = 3
        '
        'tbcDolCol
        '
        Me.tbcDolCol.Controls.Add(Me.lblCambioDC2)
        Me.tbcDolCol.Controls.Add(Me.txtCambioDC)
        Me.tbcDolCol.Controls.Add(Me.lblCambioDC)
        Me.tbcDolCol.Controls.Add(Me.lblDolDC2)
        Me.tbcDolCol.Controls.Add(Me.lblColDC2)
        Me.tbcDolCol.Controls.Add(Me.btnDolColCalcular)
        Me.tbcDolCol.Controls.Add(Me.btnDolColLimpiar)
        Me.tbcDolCol.Controls.Add(Me.txtColDC)
        Me.tbcDolCol.Controls.Add(Me.txtDolDC)
        Me.tbcDolCol.Controls.Add(Me.lblColDC)
        Me.tbcDolCol.Controls.Add(Me.lblDolDC)
        Me.tbcDolCol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcDolCol.Location = New System.Drawing.Point(4, 27)
        Me.tbcDolCol.Name = "tbcDolCol"
        Me.tbcDolCol.Padding = New System.Windows.Forms.Padding(3)
        Me.tbcDolCol.Size = New System.Drawing.Size(823, 284)
        Me.tbcDolCol.TabIndex = 0
        Me.tbcDolCol.Text = "Conversión Dólares a Colones"
        Me.tbcDolCol.UseVisualStyleBackColor = True
        '
        'lblCambioDC2
        '
        Me.lblCambioDC2.AutoSize = True
        Me.lblCambioDC2.Location = New System.Drawing.Point(396, 122)
        Me.lblCambioDC2.Name = "lblCambioDC2"
        Me.lblCambioDC2.Size = New System.Drawing.Size(61, 18)
        Me.lblCambioDC2.TabIndex = 11
        Me.lblCambioDC2.Text = "colones"
        '
        'txtCambioDC
        '
        Me.txtCambioDC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtCambioDC.Location = New System.Drawing.Point(290, 119)
        Me.txtCambioDC.Name = "txtCambioDC"
        Me.txtCambioDC.Size = New System.Drawing.Size(100, 24)
        Me.txtCambioDC.TabIndex = 10
        '
        'lblCambioDC
        '
        Me.lblCambioDC.AutoSize = True
        Me.lblCambioDC.Location = New System.Drawing.Point(57, 122)
        Me.lblCambioDC.Name = "lblCambioDC"
        Me.lblCambioDC.Size = New System.Drawing.Size(206, 18)
        Me.lblCambioDC.TabIndex = 9
        Me.lblCambioDC.Text = "Tipo cambio de venta dólares:"
        '
        'lblDolDC2
        '
        Me.lblDolDC2.AutoSize = True
        Me.lblDolDC2.Location = New System.Drawing.Point(333, 73)
        Me.lblDolDC2.Name = "lblDolDC2"
        Me.lblDolDC2.Size = New System.Drawing.Size(57, 18)
        Me.lblDolDC2.TabIndex = 8
        Me.lblDolDC2.Text = "dólares"
        '
        'lblColDC2
        '
        Me.lblColDC2.AutoSize = True
        Me.lblColDC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColDC2.Location = New System.Drawing.Point(486, 209)
        Me.lblColDC2.Name = "lblColDC2"
        Me.lblColDC2.Size = New System.Drawing.Size(68, 18)
        Me.lblColDC2.TabIndex = 7
        Me.lblColDC2.Text = "colones"
        '
        'btnDolColLimpiar
        '
        Me.btnDolColLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDolColLimpiar.Location = New System.Drawing.Point(616, 132)
        Me.btnDolColLimpiar.Name = "btnDolColLimpiar"
        Me.btnDolColLimpiar.Size = New System.Drawing.Size(106, 29)
        Me.btnDolColLimpiar.TabIndex = 6
        Me.btnDolColLimpiar.Text = "Limpiar"
        Me.btnDolColLimpiar.UseVisualStyleBackColor = True
        '
        'txtColDC
        '
        Me.txtColDC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtColDC.Location = New System.Drawing.Point(412, 209)
        Me.txtColDC.Name = "txtColDC"
        Me.txtColDC.ReadOnly = True
        Me.txtColDC.Size = New System.Drawing.Size(100, 17)
        Me.txtColDC.TabIndex = 5
        '
        'txtDolDC
        '
        Me.txtDolDC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDolDC.Location = New System.Drawing.Point(227, 70)
        Me.txtDolDC.Name = "txtDolDC"
        Me.txtDolDC.Size = New System.Drawing.Size(100, 24)
        Me.txtDolDC.TabIndex = 4
        '
        'lblColDC
        '
        Me.lblColDC.AutoSize = True
        Me.lblColDC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColDC.Location = New System.Drawing.Point(158, 209)
        Me.lblColDC.Name = "lblColDC"
        Me.lblColDC.Size = New System.Drawing.Size(215, 18)
        Me.lblColDC.TabIndex = 1
        Me.lblColDC.Text = "El monto en colones es de:"
        '
        'lblDolDC
        '
        Me.lblDolDC.AutoSize = True
        Me.lblDolDC.Location = New System.Drawing.Point(57, 73)
        Me.lblDolDC.Name = "lblDolDC"
        Me.lblDolDC.Size = New System.Drawing.Size(132, 18)
        Me.lblDolDC.TabIndex = 0
        Me.lblDolDC.Text = "Monto en dólares: "
        '
        'tbcColDol
        '
        Me.tbcColDol.Controls.Add(Me.lblCambioCD2)
        Me.tbcColDol.Controls.Add(Me.txtCambioCD)
        Me.tbcColDol.Controls.Add(Me.lblCambioCD)
        Me.tbcColDol.Controls.Add(Me.lblColCD2)
        Me.tbcColDol.Controls.Add(Me.lblDolCD2)
        Me.tbcColDol.Controls.Add(Me.btnColDolCalcular)
        Me.tbcColDol.Controls.Add(Me.btnColDolLimpiar)
        Me.tbcColDol.Controls.Add(Me.txtDolCD)
        Me.tbcColDol.Controls.Add(Me.txtColCD)
        Me.tbcColDol.Controls.Add(Me.lblDolCD)
        Me.tbcColDol.Controls.Add(Me.lblColCD)
        Me.tbcColDol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcColDol.Location = New System.Drawing.Point(4, 27)
        Me.tbcColDol.Name = "tbcColDol"
        Me.tbcColDol.Padding = New System.Windows.Forms.Padding(3)
        Me.tbcColDol.Size = New System.Drawing.Size(823, 284)
        Me.tbcColDol.TabIndex = 1
        Me.tbcColDol.Text = "Conversión Colones a Dólares"
        Me.tbcColDol.UseVisualStyleBackColor = True
        '
        'lblCambioCD2
        '
        Me.lblCambioCD2.AutoSize = True
        Me.lblCambioCD2.Location = New System.Drawing.Point(405, 126)
        Me.lblCambioCD2.Name = "lblCambioCD2"
        Me.lblCambioCD2.Size = New System.Drawing.Size(61, 18)
        Me.lblCambioCD2.TabIndex = 23
        Me.lblCambioCD2.Text = "colones"
        '
        'txtCambioCD
        '
        Me.txtCambioCD.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtCambioCD.Location = New System.Drawing.Point(299, 123)
        Me.txtCambioCD.Name = "txtCambioCD"
        Me.txtCambioCD.Size = New System.Drawing.Size(100, 24)
        Me.txtCambioCD.TabIndex = 22
        '
        'lblCambioCD
        '
        Me.lblCambioCD.AutoSize = True
        Me.lblCambioCD.Location = New System.Drawing.Point(57, 126)
        Me.lblCambioCD.Name = "lblCambioCD"
        Me.lblCambioCD.Size = New System.Drawing.Size(222, 18)
        Me.lblCambioCD.TabIndex = 21
        Me.lblCambioCD.Text = "Tipo cambio de compra dólares:"
        '
        'lblColCD2
        '
        Me.lblColCD2.AutoSize = True
        Me.lblColCD2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColCD2.Location = New System.Drawing.Point(339, 77)
        Me.lblColCD2.Name = "lblColCD2"
        Me.lblColCD2.Size = New System.Drawing.Size(61, 18)
        Me.lblColCD2.TabIndex = 20
        Me.lblColCD2.Text = "colones"
        '
        'lblDolCD2
        '
        Me.lblDolCD2.AutoSize = True
        Me.lblDolCD2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDolCD2.Location = New System.Drawing.Point(475, 210)
        Me.lblDolCD2.Name = "lblDolCD2"
        Me.lblDolCD2.Size = New System.Drawing.Size(64, 18)
        Me.lblDolCD2.TabIndex = 19
        Me.lblDolCD2.Text = "dólares"
        '
        'btnColDolCalcular
        '
        Me.btnColDolCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnColDolCalcular.Location = New System.Drawing.Point(639, 77)
        Me.btnColDolCalcular.Name = "btnColDolCalcular"
        Me.btnColDolCalcular.Size = New System.Drawing.Size(113, 27)
        Me.btnColDolCalcular.TabIndex = 15
        Me.btnColDolCalcular.Text = "Calcular"
        Me.btnColDolCalcular.UseVisualStyleBackColor = True
        '
        'btnColDolLimpiar
        '
        Me.btnColDolLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnColDolLimpiar.Location = New System.Drawing.Point(639, 136)
        Me.btnColDolLimpiar.Name = "btnColDolLimpiar"
        Me.btnColDolLimpiar.Size = New System.Drawing.Size(113, 29)
        Me.btnColDolLimpiar.TabIndex = 18
        Me.btnColDolLimpiar.Text = "Limpiar"
        Me.btnColDolLimpiar.UseVisualStyleBackColor = True
        '
        'txtDolCD
        '
        Me.txtDolCD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDolCD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDolCD.Location = New System.Drawing.Point(384, 210)
        Me.txtDolCD.Name = "txtDolCD"
        Me.txtDolCD.ReadOnly = True
        Me.txtDolCD.Size = New System.Drawing.Size(100, 17)
        Me.txtDolCD.TabIndex = 17
        '
        'txtColCD
        '
        Me.txtColCD.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtColCD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColCD.Location = New System.Drawing.Point(233, 74)
        Me.txtColCD.Name = "txtColCD"
        Me.txtColCD.Size = New System.Drawing.Size(100, 24)
        Me.txtColCD.TabIndex = 16
        '
        'lblDolCD
        '
        Me.lblDolCD.AutoSize = True
        Me.lblDolCD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDolCD.Location = New System.Drawing.Point(132, 210)
        Me.lblDolCD.Name = "lblDolCD"
        Me.lblDolCD.Size = New System.Drawing.Size(211, 18)
        Me.lblDolCD.TabIndex = 14
        Me.lblDolCD.Text = "El monto en dólares es de:"
        '
        'lblColCD
        '
        Me.lblColCD.AutoSize = True
        Me.lblColCD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColCD.Location = New System.Drawing.Point(57, 77)
        Me.lblColCD.Name = "lblColCD"
        Me.lblColCD.Size = New System.Drawing.Size(136, 18)
        Me.lblColCD.TabIndex = 13
        Me.lblColCD.Text = "Monto en colones: "
        '
        'btnDolColSalir
        '
        Me.btnDolColSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDolColSalir.Location = New System.Drawing.Point(496, 87)
        Me.btnDolColSalir.Name = "btnDolColSalir"
        Me.btnDolColSalir.Size = New System.Drawing.Size(92, 26)
        Me.btnDolColSalir.TabIndex = 3
        Me.btnDolColSalir.Text = "Salir"
        Me.btnDolColSalir.UseVisualStyleBackColor = True
        '
        'frmDolCol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(832, 450)
        Me.Controls.Add(Me.pbColDol)
        Me.Controls.Add(Me.tbcConversionDolCol)
        Me.Controls.Add(Me.lblDolCol)
        Me.Controls.Add(Me.btnDolColSalir)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDolCol"
        Me.ShowIcon = False
        Me.Text = "Menú Secundario"
        CType(Me.pbColDol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcConversionDolCol.ResumeLayout(False)
        Me.tbcDolCol.ResumeLayout(False)
        Me.tbcDolCol.PerformLayout()
        Me.tbcColDol.ResumeLayout(False)
        Me.tbcColDol.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDolCol As Label
    Friend WithEvents pbColDol As PictureBox
    Friend WithEvents btnDolColCalcular As Button
    Friend WithEvents tbcConversionDolCol As TabControl
    Friend WithEvents tbcDolCol As TabPage
    Friend WithEvents tbcColDol As TabPage
    Friend WithEvents txtColDC As TextBox
    Friend WithEvents txtDolDC As TextBox
    Friend WithEvents btnDolColSalir As Button
    Friend WithEvents lblColDC As Label
    Friend WithEvents lblDolDC As Label
    Friend WithEvents btnDolColLimpiar As Button
    Friend WithEvents lblDolDC2 As Label
    Friend WithEvents lblColDC2 As Label
    Friend WithEvents lblColCD2 As Label
    Friend WithEvents lblDolCD2 As Label
    Friend WithEvents btnColDolCalcular As Button
    Friend WithEvents btnColDolLimpiar As Button
    Friend WithEvents txtDolCD As TextBox
    Friend WithEvents txtColCD As TextBox
    Friend WithEvents lblDolCD As Label
    Friend WithEvents lblColCD As Label
    Friend WithEvents lblCambioDC2 As Label
    Friend WithEvents txtCambioDC As TextBox
    Friend WithEvents lblCambioDC As Label
    Friend WithEvents lblCambioCD2 As Label
    Friend WithEvents txtCambioCD As TextBox
    Friend WithEvents lblCambioCD As Label
End Class
