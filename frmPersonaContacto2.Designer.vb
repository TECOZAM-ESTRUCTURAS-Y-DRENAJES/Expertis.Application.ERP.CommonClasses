<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonaContacto2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPersonaContacto2))
        Me.Button1 = New Solmicro.Expertis.Engine.UI.Button
        Me.Grid1 = New Solmicro.Expertis.Engine.UI.Grid
        Me.Button2 = New Solmicro.Expertis.Engine.UI.Button
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(225, 240)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 41)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Guardar registro"
        '
        'Grid1
        '
        Me.Grid1.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid1.ColumnAutoResize = True
        Grid1_DesignTimeLayout.LayoutString = resources.GetString("Grid1_DesignTimeLayout.LayoutString")
        Me.Grid1.DesignTimeLayout = Grid1_DesignTimeLayout
        Me.Grid1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid1.EntityName = Nothing
        Me.Grid1.Location = New System.Drawing.Point(1, 0)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.PrimaryDataFields = Nothing
        Me.Grid1.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.Grid1.SecondaryDataFields = "IDPersona"
        Me.Grid1.Size = New System.Drawing.Size(787, 224)
        Me.Grid1.TabIndex = 3
        Me.Grid1.ViewName = "vfrmObraPersonaContacto2"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(444, 240)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 41)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Salir"
        '
        'frmPersonaContacto2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 306)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmPersonaContacto2"
        Me.Text = "frmPersonaContacto2"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Grid1 As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Button2 As Solmicro.Expertis.Engine.UI.Button
End Class
