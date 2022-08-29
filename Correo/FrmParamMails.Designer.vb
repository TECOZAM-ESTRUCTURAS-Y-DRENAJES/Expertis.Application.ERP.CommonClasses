<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmParamMails
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
        Me.FrmConfigMails = New Solmicro.Expertis.Engine.UI.Frame
        Me.FrmDatosCuenta = New Solmicro.Expertis.Engine.UI.Frame
        Me.LblDirecCorreo = New Solmicro.Expertis.Engine.UI.Label
        Me.TxtDirecCorreo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FrmDatosSMTP = New Solmicro.Expertis.Engine.UI.Frame
        Me.LblSmtpServer = New Solmicro.Expertis.Engine.UI.Label
        Me.TxtServidorSMTP = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblPuertoServidor = New Solmicro.Expertis.Engine.UI.Label
        Me.TxtPuertoServidor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.ChkUseSSL = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.PnlButtons = New Solmicro.Expertis.Engine.UI.Panel
        Me.BtnTestMail = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.FrmConfigMails.SuspendLayout()
        Me.FrmDatosCuenta.SuspendLayout()
        Me.FrmDatosSMTP.SuspendLayout()
        Me.PnlButtons.suspendlayout()
        Me.SuspendLayout()
        '
        'FrmConfigMails
        '
        Me.FrmConfigMails.Controls.Add(Me.FrmDatosCuenta)
        Me.FrmConfigMails.Controls.Add(Me.FrmDatosSMTP)
        Me.FrmConfigMails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmConfigMails.Location = New System.Drawing.Point(0, 0)
        Me.FrmConfigMails.Name = "FrmConfigMails"
        Me.FrmConfigMails.Size = New System.Drawing.Size(376, 163)
        Me.FrmConfigMails.TabIndex = 0
        Me.FrmConfigMails.TabStop = False
        Me.FrmConfigMails.Text = "Datos Configuración"
        '
        'FrmDatosCuenta
        '
        Me.FrmDatosCuenta.Controls.Add(Me.LblDirecCorreo)
        Me.FrmDatosCuenta.Controls.Add(Me.TxtDirecCorreo)
        Me.FrmDatosCuenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmDatosCuenta.Location = New System.Drawing.Point(3, 117)
        Me.FrmDatosCuenta.Name = "FrmDatosCuenta"
        Me.FrmDatosCuenta.Size = New System.Drawing.Size(370, 43)
        Me.FrmDatosCuenta.TabIndex = 5
        Me.FrmDatosCuenta.TabStop = False
        Me.FrmDatosCuenta.Text = "Datos Cuenta Correo"
        '
        'LblDirecCorreo
        '
        Me.LblDirecCorreo.Location = New System.Drawing.Point(9, 21)
        Me.LblDirecCorreo.Name = "LblDirecCorreo"
        Me.LblDirecCorreo.Size = New System.Drawing.Size(113, 13)
        Me.LblDirecCorreo.TabIndex = 9
        Me.LblDirecCorreo.Text = "Correo Electrónico"
        '
        'TxtDirecCorreo
        '
        Me.TxtDirecCorreo.DisabledBackColor = System.Drawing.Color.White
        Me.TxtDirecCorreo.Location = New System.Drawing.Point(145, 17)
        Me.TxtDirecCorreo.Name = "TxtDirecCorreo"
        Me.TxtDirecCorreo.Size = New System.Drawing.Size(218, 21)
        Me.TxtDirecCorreo.TabIndex = 6
        '
        'FrmDatosSMTP
        '
        Me.FrmDatosSMTP.Controls.Add(Me.LblSmtpServer)
        Me.FrmDatosSMTP.Controls.Add(Me.TxtServidorSMTP)
        Me.FrmDatosSMTP.Controls.Add(Me.LblPuertoServidor)
        Me.FrmDatosSMTP.Controls.Add(Me.TxtPuertoServidor)
        Me.FrmDatosSMTP.Controls.Add(Me.ChkUseSSL)
        Me.FrmDatosSMTP.Dock = System.Windows.Forms.DockStyle.Top
        Me.FrmDatosSMTP.Location = New System.Drawing.Point(3, 17)
        Me.FrmDatosSMTP.Name = "FrmDatosSMTP"
        Me.FrmDatosSMTP.Size = New System.Drawing.Size(370, 100)
        Me.FrmDatosSMTP.TabIndex = 1
        Me.FrmDatosSMTP.TabStop = False
        Me.FrmDatosSMTP.Text = "Datos Servidor SMTP"
        '
        'LblSmtpServer
        '
        Me.LblSmtpServer.Location = New System.Drawing.Point(6, 17)
        Me.LblSmtpServer.Name = "LblSmtpServer"
        Me.LblSmtpServer.Size = New System.Drawing.Size(91, 13)
        Me.LblSmtpServer.TabIndex = 0
        Me.LblSmtpServer.Text = "Servidor SMTP"
        '
        'TxtServidorSMTP
        '
        Me.TxtServidorSMTP.DisabledBackColor = System.Drawing.Color.White
        Me.TxtServidorSMTP.Location = New System.Drawing.Point(150, 13)
        Me.TxtServidorSMTP.Name = "TxtServidorSMTP"
        Me.TxtServidorSMTP.Size = New System.Drawing.Size(213, 21)
        Me.TxtServidorSMTP.TabIndex = 2
        '
        'LblPuertoServidor
        '
        Me.LblPuertoServidor.Location = New System.Drawing.Point(6, 45)
        Me.LblPuertoServidor.Name = "LblPuertoServidor"
        Me.LblPuertoServidor.Size = New System.Drawing.Size(132, 13)
        Me.LblPuertoServidor.TabIndex = 2
        Me.LblPuertoServidor.Text = "Puerto Servidor SMTP"
        '
        'TxtPuertoServidor
        '
        Me.TxtPuertoServidor.DisabledBackColor = System.Drawing.Color.White
        Me.TxtPuertoServidor.Location = New System.Drawing.Point(150, 41)
        Me.TxtPuertoServidor.Name = "TxtPuertoServidor"
        Me.TxtPuertoServidor.Size = New System.Drawing.Size(213, 21)
        Me.TxtPuertoServidor.TabIndex = 3
        '
        'ChkUseSSL
        '
        Me.ChkUseSSL.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkUseSSL.Location = New System.Drawing.Point(9, 71)
        Me.ChkUseSSL.Name = "ChkUseSSL"
        Me.ChkUseSSL.Size = New System.Drawing.Size(215, 23)
        Me.ChkUseSSL.TabIndex = 4
        Me.ChkUseSSL.Text = "Usar Conexión Segura Cifrada"
        '
        'PnlButtons
        '
        Me.PnlButtons.Controls.Add(Me.BtnTestMail)
        Me.PnlButtons.Controls.Add(Me.BtnCancelar)
        Me.PnlButtons.Controls.Add(Me.BtnAceptar)
        Me.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlButtons.Location = New System.Drawing.Point(0, 163)
        Me.PnlButtons.Name = "PnlButtons"
        Me.PnlButtons.Size = New System.Drawing.Size(376, 45)
        Me.PnlButtons.TabIndex = 9
        '
        'BtnTestMail
        '
        Me.BtnTestMail.Location = New System.Drawing.Point(12, 7)
        Me.BtnTestMail.Name = "BtnTestMail"
        Me.BtnTestMail.Size = New System.Drawing.Size(129, 29)
        Me.BtnTestMail.TabIndex = 12
        Me.BtnTestMail.Text = "Prueba de Envío"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(279, 6)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(87, 29)
        Me.BtnCancelar.TabIndex = 11
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(186, 7)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(87, 29)
        Me.BtnAceptar.TabIndex = 10
        Me.BtnAceptar.Text = "&Aceptar"
        '
        'FrmParamMails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 208)
        Me.Controls.Add(Me.FrmConfigMails)
        Me.Controls.Add(Me.PnlButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmParamMails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración de Envios Correo Electrónico"
        Me.FrmConfigMails.ResumeLayout(False)
        Me.FrmDatosCuenta.ResumeLayout(False)
        Me.FrmDatosCuenta.PerformLayout()
        Me.FrmDatosSMTP.ResumeLayout(False)
        Me.FrmDatosSMTP.PerformLayout()
        Me.PnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FrmConfigMails As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents TxtServidorSMTP As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblSmtpServer As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents PnlButtons As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents ChkUseSSL As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents TxtPuertoServidor As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblPuertoServidor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FrmDatosCuenta As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents LblDirecCorreo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TxtDirecCorreo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents FrmDatosSMTP As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents BtnTestMail As Solmicro.Expertis.Engine.UI.Button
End Class
