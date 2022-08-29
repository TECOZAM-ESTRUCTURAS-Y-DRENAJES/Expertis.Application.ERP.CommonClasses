<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogProcesos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogProcesos))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.Grid1 = New Solmicro.Expertis.Engine.UI.Grid
        Me.Icons = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1.suspendlayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 300)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(627, 46)
        Me.Panel1.TabIndex = 1
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(254, 8)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(115, 29)
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "Aceptar"
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
        Me.Grid1.ImageList = Me.Icons
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.PrimaryDataFields = Nothing
        Me.Grid1.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid1.SecondaryDataFields = Nothing
        Me.Grid1.Size = New System.Drawing.Size(627, 300)
        Me.Grid1.TabIndex = 2
        Me.Grid1.ViewName = Nothing
        '
        'Icons
        '
        Me.Icons.ImageStream = CType(resources.GetObject("Icons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Icons.TransparentColor = System.Drawing.Color.Transparent
        Me.Icons.Images.SetKeyName(0, "about.ico")
        Me.Icons.Images.SetKeyName(1, "delete.ico")
        Me.Icons.Images.SetKeyName(2, "document_info.ico")
        Me.Icons.Images.SetKeyName(3, "document_error.ico")
        '
        'LogProcesos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 346)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "LogProcesos"
        Me.Text = "Detalle Proceso"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Grid1 As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Icons As System.Windows.Forms.ImageList
End Class
