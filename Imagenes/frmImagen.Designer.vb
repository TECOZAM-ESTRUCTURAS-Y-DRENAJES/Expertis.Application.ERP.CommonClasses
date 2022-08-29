<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImagen
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCerrar = New Solmicro.Expertis.Engine.UI.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CtrlImage1 = New Solmicro.Expertis.Application.ERP.CommonClasses.CtrlImage
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCerrar.Location = New System.Drawing.Point(178, 7)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(67, 25)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "&Cerrar"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 241)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(422, 39)
        Me.Panel1.TabIndex = 4
        '
        'CtrlImage1
        '
        Me.CtrlImage1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtrlImage1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlImage1.Name = "CtrlImage1"
        Me.CtrlImage1.Size = New System.Drawing.Size(422, 241)
        Me.CtrlImage1.TabIndex = 3
        '
        'frmImagen
        '
        Me.ClientSize = New System.Drawing.Size(422, 280)
        Me.Controls.Add(Me.CtrlImage1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImagen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ver / Modificar Imágen"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CtrlImage1 As Solmicro.Expertis.Application.ERP.CommonClasses.CtrlImage
    Friend WithEvents btnCerrar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
