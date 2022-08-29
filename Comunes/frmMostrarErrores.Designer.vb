<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMostrarErrores
    Inherits Solmicro.Expertis.Engine.UI.FormBase

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
        Me.components = New System.ComponentModel.Container
        Dim Grid1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMostrarErrores))
        Me.Grid1 = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlAceptar = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.pnlContinuar = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmdNo = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdSi = New Solmicro.Expertis.Engine.UI.Button
        Me.pnlTop = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblTexto = New Solmicro.Expertis.Engine.UI.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAceptar.suspendlayout()
        Me.pnlContinuar.suspendlayout()
        Me.pnlTop.suspendlayout()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid1.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Grid1_DesignTimeLayout.LayoutString = resources.GetString("Grid1_DesignTimeLayout.LayoutString")
        Me.Grid1.DesignTimeLayout = Grid1_DesignTimeLayout
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid1.EntityName = Nothing
        Me.Grid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Grid1.GridLines = Janus.Windows.GridEX.GridLines.Horizontal
        Me.Grid1.ImageList = Me.ImageList1
        Me.Grid1.Location = New System.Drawing.Point(0, 35)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.PrimaryDataFields = Nothing
        Me.Grid1.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid1.SecondaryDataFields = Nothing
        Me.Grid1.Size = New System.Drawing.Size(634, 230)
        Me.Grid1.TabIndex = 4
        Me.Grid1.ViewName = Nothing
        '
        'pnlAceptar
        '
        Me.pnlAceptar.Controls.Add(Me.cmdAceptar)
        Me.pnlAceptar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlAceptar.Location = New System.Drawing.Point(0, 311)
        Me.pnlAceptar.Name = "pnlAceptar"
        Me.pnlAceptar.Size = New System.Drawing.Size(634, 46)
        Me.pnlAceptar.TabIndex = 3
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(254, 8)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(115, 29)
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "Aceptar"
        '
        'pnlContinuar
        '
        Me.pnlContinuar.Controls.Add(Me.cmdNo)
        Me.pnlContinuar.Controls.Add(Me.cmdSi)
        Me.pnlContinuar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlContinuar.Location = New System.Drawing.Point(0, 265)
        Me.pnlContinuar.Name = "pnlContinuar"
        Me.pnlContinuar.Size = New System.Drawing.Size(634, 46)
        Me.pnlContinuar.TabIndex = 5
        '
        'cmdNo
        '
        Me.cmdNo.Location = New System.Drawing.Point(320, 8)
        Me.cmdNo.Name = "cmdNo"
        Me.cmdNo.Size = New System.Drawing.Size(115, 29)
        Me.cmdNo.TabIndex = 1
        Me.cmdNo.Text = "No"
        '
        'cmdSi
        '
        Me.cmdSi.Location = New System.Drawing.Point(199, 8)
        Me.cmdSi.Name = "cmdSi"
        Me.cmdSi.Size = New System.Drawing.Size(115, 29)
        Me.cmdSi.TabIndex = 0
        Me.cmdSi.Text = "Si"
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.lblTexto)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(634, 35)
        Me.pnlTop.TabIndex = 6
        '
        'lblTexto
        '
        Me.lblTexto.Location = New System.Drawing.Point(12, 9)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(27, 13)
        Me.lblTexto.TabIndex = 0
        Me.lblTexto.Text = "     "
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "error.ico")
        '
        'frmMostrarErrores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 357)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlContinuar)
        Me.Controls.Add(Me.pnlAceptar)
        Me.Name = "frmMostrarErrores"
        Me.Text = "Errores"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAceptar.ResumeLayout(False)
        Me.pnlContinuar.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grid1 As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents pnlAceptar As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents pnlContinuar As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmdSi As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdNo As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents pnlTop As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblTexto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
