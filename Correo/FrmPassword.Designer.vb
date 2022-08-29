<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPassword
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
        Me.PnlButtons = New Solmicro.Expertis.Engine.UI.Panel
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.TxtPassword = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblPassword = New Solmicro.Expertis.Engine.UI.Label
        Me.LblUserID = New Solmicro.Expertis.Engine.UI.Label
        Me.TxtUserID = New Solmicro.Expertis.Engine.UI.TextBox
        Me.PnlButtons.suspendlayout()
        Me.SuspendLayout()
        '
        'PnlButtons
        '
        Me.PnlButtons.Controls.Add(Me.BtnCancelar)
        Me.PnlButtons.Controls.Add(Me.BtnAceptar)
        Me.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlButtons.Location = New System.Drawing.Point(0, 93)
        Me.PnlButtons.Name = "PnlButtons"
        Me.PnlButtons.Size = New System.Drawing.Size(305, 38)
        Me.PnlButtons.TabIndex = 3
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(155, 3)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(94, 28)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(55, 3)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(94, 28)
        Me.BtnAceptar.TabIndex = 4
        Me.BtnAceptar.Text = "&Aceptar"
        '
        'TxtPassword
        '
        Me.TxtPassword.DisabledBackColor = System.Drawing.Color.White
        Me.TxtPassword.Location = New System.Drawing.Point(15, 65)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(275, 21)
        Me.TxtPassword.TabIndex = 2
        '
        'LblPassword
        '
        Me.LblPassword.Location = New System.Drawing.Point(12, 49)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(73, 13)
        Me.LblPassword.TabIndex = 3
        Me.LblPassword.Text = "Contraseña"
        '
        'LblUserID
        '
        Me.LblUserID.Location = New System.Drawing.Point(12, 9)
        Me.LblUserID.Name = "LblUserID"
        Me.LblUserID.Size = New System.Drawing.Size(99, 13)
        Me.LblUserID.TabIndex = 8
        Me.LblUserID.Text = "Nombre Usuario"
        '
        'TxtUserID
        '
        Me.TxtUserID.DisabledBackColor = System.Drawing.Color.White
        Me.TxtUserID.Location = New System.Drawing.Point(15, 25)
        Me.TxtUserID.Name = "TxtUserID"
        Me.TxtUserID.Size = New System.Drawing.Size(275, 21)
        Me.TxtUserID.TabIndex = 1
        '
        'FrmPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 131)
        Me.Controls.Add(Me.TxtUserID)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.PnlButtons)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUserID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Introduzca la contraseña del Certificado"
        Me.PnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlButtons As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents TxtPassword As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblPassword As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblUserID As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TxtUserID As Solmicro.Expertis.Engine.UI.TextBox
End Class
