Public Class FrmPassword

#Region "Variables Privadas / Propiedades Públicas"

    Private MInfo As New Business.General.SmtpServerInfo

    Public Property DatosInfo() As Business.General.SmtpServerInfo
        Set(ByVal value As Business.General.SmtpServerInfo)
            MInfo = value
        End Set
        Get
            Return MInfo
        End Get
    End Property

#End Region

#Region "Funciones Privadas"

    Private Sub SaveData()
        MInfo.UserID = Me.TxtUserID.Text & String.Empty
        MInfo.UserPassword = Me.TxtPassword.Text & String.Empty
        ExpertisApp.ExecuteTask(Of SmtpServerInfo)(AddressOf Business.General.Correos.SaveSmtpServerInfo, MInfo)
    End Sub

#End Region

#Region "Eventos FrmPass"

    Private Sub FrmPassword_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Length(MInfo.UserID) > 0 Then Me.TxtUserID.Text = MInfo.UserID
        If Length(MInfo.UserPassword) > 0 Then Me.TxtPassword.Text = MInfo.UserPassword
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        SaveData()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

#End Region

End Class