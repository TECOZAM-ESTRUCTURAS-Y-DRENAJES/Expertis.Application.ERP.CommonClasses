Public Class FrmConfigTimeLineObras

    Private MDtDataConfigInfo As DataConfigInfo

    Public Property DataConfig() As DataConfigInfo
        Get
            Return MDtDataConfigInfo
        End Get
        Set(ByVal value As DataConfigInfo)
            MDtDataConfigInfo = value
        End Set
    End Property

    Private Sub LoadData()

    End Sub

    Private Function CheckData() As Boolean

    End Function

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If CheckData() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub FrmConfigTimeLineObras_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub FrmConfigTimeLineObras_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadData()
    End Sub

End Class