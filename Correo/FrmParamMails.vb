Public Class FrmParamMails

#Region "Variables Privadas"

    Private MBlnCambio As Boolean = False
    Private MBlnLoad As Boolean = False
    Private MMailParamInfo As Business.General.SmtpServerInfo

#End Region

#Region "Propiedades Públicas"

    Public Property MailParamInfo() As SmtpServerInfo
        Get
            Return MMailParamInfo
        End Get
        Set(ByVal value As SmtpServerInfo)
            MMailParamInfo = value
        End Set
    End Property

#End Region

#Region "Funciones Privadas"

    Private Sub LoadDatos()
        MBlnLoad = True
        If MMailParamInfo Is Nothing Then
            MMailParamInfo = ExpertisApp.ExecuteTask(Of Object, SmtpServerInfo)(AddressOf Business.General.Correos.LoadSmtpServerInfo, New Object)
        End If
        Me.TxtServidorSMTP.Text = MMailParamInfo.SmtpServerName
        Me.TxtPuertoServidor.Text = MMailParamInfo.SmtpServerPort
        Me.ChkUseSSL.Checked = MMailParamInfo.UseSSL
        Me.TxtDirecCorreo.Text = MMailParamInfo.UserMail
        MBlnLoad = False
    End Sub

    Private Function ComprobarDatos() As Boolean
        Dim StrMsg As String = String.Empty
        If Length(Me.TxtDirecCorreo.Text) = 0 Then StrMsg = "La Dirección de Correo es obligatorio."
        If Length(Me.TxtPuertoServidor.Text) = 0 Then StrMsg = "El Puerto del Servidor SMTP es obligatorio."
        If Length(Me.TxtServidorSMTP.Text) = 0 Then StrMsg = "El Servidor SMTP es un dato obligatorio."
        If Length(StrMsg) > 0 Then
            ExpertisApp.GenerateMessage(StrMsg, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else : Return True
        End If
    End Function

    Private Sub GrabarDatos()
        MMailParamInfo.SmtpServerName = Me.TxtServidorSMTP.Text
        MMailParamInfo.SmtpServerPort = Me.TxtPuertoServidor.Text
        MMailParamInfo.UseSSL = Me.ChkUseSSL.Checked
        MMailParamInfo.UserMail = Me.TxtDirecCorreo.Text
        ExpertisApp.ExecuteTask(Of SmtpServerInfo)(AddressOf Business.General.Correos.SaveSmtpServerInfo, MMailParamInfo)
    End Sub

    Private Sub EnviarMailPrueba()
        Dim ParamInfo As New Business.General.SmtpServerInfo
        ParamInfo.SmtpServerName = Me.TxtServidorSMTP.Text
        ParamInfo.SmtpServerPort = Me.TxtPuertoServidor.Text
        ParamInfo.UseSSL = Me.ChkUseSSL.Checked
        ParamInfo.UserMail = Me.TxtDirecCorreo.Text
        ParamInfo.UserID = IIf(Length(MMailParamInfo.UserID) > 0, MMailParamInfo.UserID, String.Empty)

        Dim FrmPass As New FrmPassword
        FrmPass.Text = "Introduzca Usuario y Contraseña de la Cuenta de Correo"
        FrmPass.DatosInfo = ParamInfo
        If FrmPass.ShowDialog = Windows.Forms.DialogResult.OK Then
            ParamInfo = FrmPass.DatosInfo
            MMailParamInfo = ParamInfo
            Dim LogPrc As LogProcess = SendTestMail(ParamInfo)
            If Not LogPrc Is Nothing AndAlso (LogPrc.CreatedElements.Length > 0 OrElse LogPrc.Errors.Length > 0) Then
                TratarMailLog(LogPrc)
            End If
        End If
    End Sub

#End Region

#Region "Eventos FrmParamMails"

#Region "Eventos Formulario"

    Private Sub FrmParamMails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadDatos()
    End Sub

#End Region

#Region "Eventos Controles"

    Private Sub TxtServidorSMTP_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtServidorSMTP.TextChanged, TxtPuertoServidor.TextChanged, TxtDirecCorreo.TextChanged
        If Not MBlnLoad Then MBlnCambio = True
    End Sub

    Private Sub ChkUseSSL_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkUseSSL.CheckedChanged
        If Not MBlnLoad Then MBlnCambio = True
    End Sub

    Private Sub BtnTestMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTestMail.Click
        If ComprobarDatos() Then EnviarMailPrueba()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If MBlnCambio Then
            If ComprobarDatos() Then
                GrabarDatos()
                Me.Close()
            Else : ExpertisApp.GenerateMessage("Todos los Parámetros son datos obligatorios. Por favor, revise los datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else : Me.Close()
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        If MBlnCambio Then
            If ExpertisApp.GenerateMessage("No se han confirmado los cambios introducidos. ¿Desea salir de todos modos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.Close()
            End If
        Else : Me.Close()
        End If
    End Sub

#End Region

#End Region

End Class