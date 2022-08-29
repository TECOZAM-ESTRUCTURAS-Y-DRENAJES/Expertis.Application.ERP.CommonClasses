<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListImage
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
        Me.FrmList = New Solmicro.Expertis.Engine.UI.Frame
        Me.FlowImages = New System.Windows.Forms.FlowLayoutPanel
        Me.PnlButtons = New Solmicro.Expertis.Engine.UI.Panel
        Me.BtnCerrar = New Solmicro.Expertis.Engine.UI.Button
        Me.LbEntidad = New Solmicro.Expertis.Engine.UI.Label
        Me.TxtEntidad = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblClave = New Solmicro.Expertis.Engine.UI.Label
        Me.TxtClave = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FrmCab = New Solmicro.Expertis.Engine.UI.Frame
        Me.FrmList.SuspendLayout()
        Me.PnlButtons.suspendlayout()
        Me.FrmCab.SuspendLayout()
        Me.SuspendLayout()
        '
        'FrmList
        '
        Me.FrmList.Controls.Add(Me.FlowImages)
        Me.FrmList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmList.Location = New System.Drawing.Point(0, 42)
        Me.FrmList.Name = "FrmList"
        Me.FrmList.Size = New System.Drawing.Size(544, 261)
        Me.FrmList.TabIndex = 0
        Me.FrmList.TabStop = False
        Me.FrmList.Text = "Listado de Imágenes Disponibles"
        '
        'FlowImages
        '
        Me.FlowImages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowImages.Location = New System.Drawing.Point(3, 17)
        Me.FlowImages.Name = "FlowImages"
        Me.FlowImages.Size = New System.Drawing.Size(538, 241)
        Me.FlowImages.TabIndex = 0
        '
        'PnlButtons
        '
        Me.PnlButtons.Controls.Add(Me.BtnCerrar)
        Me.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlButtons.Location = New System.Drawing.Point(0, 303)
        Me.PnlButtons.Name = "PnlButtons"
        Me.PnlButtons.Size = New System.Drawing.Size(544, 54)
        Me.PnlButtons.TabIndex = 1
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(216, 6)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(95, 36)
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.Text = "&Cerrar"
        '
        'LbEntidad
        '
        Me.LbEntidad.Location = New System.Drawing.Point(6, 17)
        Me.LbEntidad.Name = "LbEntidad"
        Me.LbEntidad.Size = New System.Drawing.Size(49, 13)
        Me.LbEntidad.TabIndex = 0
        Me.LbEntidad.Text = "Entidad"
        '
        'TxtEntidad
        '
        Me.TxtEntidad.DisabledBackColor = System.Drawing.Color.White
        Me.TxtEntidad.Enabled = False
        Me.TxtEntidad.Location = New System.Drawing.Point(61, 13)
        Me.TxtEntidad.Name = "TxtEntidad"
        Me.TxtEntidad.Size = New System.Drawing.Size(190, 21)
        Me.TxtEntidad.TabIndex = 1
        '
        'LblClave
        '
        Me.LblClave.Location = New System.Drawing.Point(257, 17)
        Me.LblClave.Name = "LblClave"
        Me.LblClave.Size = New System.Drawing.Size(40, 13)
        Me.LblClave.TabIndex = 2
        Me.LblClave.Text = "Clave"
        '
        'TxtClave
        '
        Me.TxtClave.DisabledBackColor = System.Drawing.Color.White
        Me.TxtClave.Enabled = False
        Me.TxtClave.Location = New System.Drawing.Point(303, 13)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.Size = New System.Drawing.Size(235, 21)
        Me.TxtClave.TabIndex = 3
        '
        'FrmCab
        '
        Me.FrmCab.Controls.Add(Me.TxtClave)
        Me.FrmCab.Controls.Add(Me.LbEntidad)
        Me.FrmCab.Controls.Add(Me.LblClave)
        Me.FrmCab.Controls.Add(Me.TxtEntidad)
        Me.FrmCab.Dock = System.Windows.Forms.DockStyle.Top
        Me.FrmCab.Location = New System.Drawing.Point(0, 0)
        Me.FrmCab.Name = "FrmCab"
        Me.FrmCab.Size = New System.Drawing.Size(544, 42)
        Me.FrmCab.TabIndex = 2
        Me.FrmCab.TabStop = False
        Me.FrmCab.Text = "Datos"
        '
        'frmListImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 357)
        Me.Controls.Add(Me.FrmList)
        Me.Controls.Add(Me.FrmCab)
        Me.Controls.Add(Me.PnlButtons)
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListImage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Imágenes"
        Me.FrmList.ResumeLayout(False)
        Me.PnlButtons.ResumeLayout(False)
        Me.FrmCab.ResumeLayout(False)
        Me.FrmCab.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FrmList As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents PnlButtons As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents BtnCerrar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents FlowImages As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents LbEntidad As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TxtEntidad As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblClave As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TxtClave As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents FrmCab As Solmicro.Expertis.Engine.UI.Frame
End Class
