<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetalleActualizacionPagoPisos
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
        Dim Detalle_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetalleActualizacionPagoPisos))
        Me.Detalle = New Janus.Windows.GridEX.GridEX
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CloseButton = New Solmicro.Expertis.Engine.UI.Button
        CType(Me.Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Detalle
        '
        Me.Detalle.AllowDrop = True
        Me.Detalle.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Detalle_DesignTimeLayout.LayoutString = resources.GetString("Detalle_DesignTimeLayout.LayoutString")
        Me.Detalle.DesignTimeLayout = Detalle_DesignTimeLayout
        Me.Detalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Detalle.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detalle.GridLines = Janus.Windows.GridEX.GridLines.Horizontal
        Me.Detalle.GroupByBoxVisible = False
        Me.Detalle.Location = New System.Drawing.Point(0, 0)
        Me.Detalle.Name = "Detalle"
        Me.Detalle.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Detalle.SelectedFormatStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Detalle.Size = New System.Drawing.Size(465, 326)
        Me.Detalle.TabIndex = 2
        Me.Detalle.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Detalle.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CloseButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 270)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(465, 56)
        Me.Panel1.TabIndex = 3
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CloseButton.Location = New System.Drawing.Point(172, 12)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(114, 27)
        Me.CloseButton.TabIndex = 0
        Me.CloseButton.Text = "Cerrar"
        '
        'DetalleActualizacionPagoPisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 326)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Detalle)
        Me.Name = "DetalleActualizacionPagoPisos"
        Me.Text = "DetalleActualizacionPagoPisos"
        CType(Me.Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Detalle As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CloseButton As Solmicro.Expertis.Engine.UI.Button
End Class
