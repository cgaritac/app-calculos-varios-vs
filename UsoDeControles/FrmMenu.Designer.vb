<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.mnuMenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.itmCalculos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItmDolCol = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmTemperaturaFC = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmImpuesto = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmDepreciacionLineal = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemIMC = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmInformacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbTitulo = New System.Windows.Forms.PictureBox()
        Me.mnuMenuPrincipal.SuspendLayout()
        CType(Me.pbTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.GhostWhite
        Me.lblTitulo.Location = New System.Drawing.Point(54, 43)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(776, 33)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Programa de conversión de unidades y cálculos varios"
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitulo.Enabled = False
        Me.txtTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.ForeColor = System.Drawing.Color.White
        Me.txtTitulo.Location = New System.Drawing.Point(32, 179)
        Me.txtTitulo.Multiline = True
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(444, 157)
        Me.txtTitulo.TabIndex = 2
        Me.txtTitulo.Text = resources.GetString("txtTitulo.Text")
        '
        'mnuMenuPrincipal
        '
        Me.mnuMenuPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuMenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmCalculos, Me.itmInformacion, Me.itmSalir})
        Me.mnuMenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuPrincipal.Name = "mnuMenuPrincipal"
        Me.mnuMenuPrincipal.Size = New System.Drawing.Size(880, 28)
        Me.mnuMenuPrincipal.TabIndex = 3
        Me.mnuMenuPrincipal.Text = "Menu de opciones"
        '
        'itmCalculos
        '
        Me.itmCalculos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItmDolCol, Me.itmTemperaturaFC, Me.itmImpuesto, Me.itmDepreciacionLineal, Me.itemIMC})
        Me.itmCalculos.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.itmCalculos.Image = Global.UsoDeControles.My.Resources.Resources.e6f7d9d79675eece3bc3074d98b4f9f7
        Me.itmCalculos.Name = "itmCalculos"
        Me.itmCalculos.Size = New System.Drawing.Size(156, 24)
        Me.itmCalculos.Text = "Opciones Cálculo"
        '
        'ItmDolCol
        '
        Me.ItmDolCol.Image = Global.UsoDeControles.My.Resources.Resources.images__1_
        Me.ItmDolCol.Name = "ItmDolCol"
        Me.ItmDolCol.Size = New System.Drawing.Size(279, 26)
        Me.ItmDolCol.Text = "Convertir Dólares y Colones"
        '
        'itmTemperaturaFC
        '
        Me.itmTemperaturaFC.Image = Global.UsoDeControles.My.Resources.Resources.temperatura
        Me.itmTemperaturaFC.Name = "itmTemperaturaFC"
        Me.itmTemperaturaFC.Size = New System.Drawing.Size(279, 26)
        Me.itmTemperaturaFC.Text = "Convertir Temperatura °F y °C"
        '
        'itmImpuesto
        '
        Me.itmImpuesto.Image = Global.UsoDeControles.My.Resources.Resources.Money_bag_300x265
        Me.itmImpuesto.Name = "itmImpuesto"
        Me.itmImpuesto.Size = New System.Drawing.Size(279, 26)
        Me.itmImpuesto.Text = "Impuesto de Ventas"
        '
        'itmDepreciacionLineal
        '
        Me.itmDepreciacionLineal.Image = Global.UsoDeControles.My.Resources.Resources.kisspng_depreciation_vehicle_leasing_tax_womack_auto_sales_lease_5accc718a53b46_7602067715233697526768
        Me.itmDepreciacionLineal.Name = "itmDepreciacionLineal"
        Me.itmDepreciacionLineal.Size = New System.Drawing.Size(279, 26)
        Me.itmDepreciacionLineal.Text = "Depreciación Lineal"
        '
        'itemIMC
        '
        Me.itemIMC.Image = Global.UsoDeControles.My.Resources.Resources.indiceVidaSaludable_IMC
        Me.itemIMC.Name = "itemIMC"
        Me.itemIMC.Size = New System.Drawing.Size(279, 26)
        Me.itemIMC.Text = "Índice de Masa Corporal"
        '
        'itmInformacion
        '
        Me.itmInformacion.Image = Global.UsoDeControles.My.Resources.Resources.Información
        Me.itmInformacion.Name = "itmInformacion"
        Me.itmInformacion.Size = New System.Drawing.Size(121, 24)
        Me.itmInformacion.Text = "Información"
        '
        'itmSalir
        '
        Me.itmSalir.Image = Global.UsoDeControles.My.Resources.Resources.salir
        Me.itmSalir.Name = "itmSalir"
        Me.itmSalir.Size = New System.Drawing.Size(70, 24)
        Me.itmSalir.Text = "Salir"
        '
        'pbTitulo
        '
        Me.pbTitulo.BackgroundImage = Global.UsoDeControles.My.Resources.Resources.Titulo
        Me.pbTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbTitulo.Location = New System.Drawing.Point(508, 107)
        Me.pbTitulo.Name = "pbTitulo"
        Me.pbTitulo.Size = New System.Drawing.Size(360, 270)
        Me.pbTitulo.TabIndex = 1
        Me.pbTitulo.TabStop = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(880, 453)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.pbTitulo)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mnuMenuPrincipal)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MainMenuStrip = Me.mnuMenuPrincipal
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMenu"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu principal "
        Me.TransparencyKey = System.Drawing.Color.White
        Me.mnuMenuPrincipal.ResumeLayout(False)
        Me.mnuMenuPrincipal.PerformLayout()
        CType(Me.pbTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents pbTitulo As PictureBox
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents mnuMenuPrincipal As MenuStrip
    Friend WithEvents itmCalculos As ToolStripMenuItem
    Friend WithEvents ItmDolCol As ToolStripMenuItem
    Friend WithEvents itmTemperaturaFC As ToolStripMenuItem
    Friend WithEvents itmImpuesto As ToolStripMenuItem
    Friend WithEvents itmDepreciacionLineal As ToolStripMenuItem
    Friend WithEvents itemIMC As ToolStripMenuItem
    Friend WithEvents itmInformacion As ToolStripMenuItem
    Friend WithEvents itmSalir As ToolStripMenuItem
End Class
