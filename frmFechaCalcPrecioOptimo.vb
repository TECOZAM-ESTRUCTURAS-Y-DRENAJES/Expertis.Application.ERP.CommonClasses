Public Class frmFechaCalcPrecioOptimo

    Public Property Fecha() As Date
        Get
            Return Me.ClbFechaPrecioOptimo.Value
        End Get
        Set(ByVal value As Date)
            Me.ClbFechaPrecioOptimo.Value = value
        End Set
    End Property

    Private Sub frmFechaCalcPrecioOptimo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Length(Me.ClbFechaPrecioOptimo.Value) = 0 Then Me.ClbFechaPrecioOptimo.Value = Today.Date
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If Length(Me.ClbFechaPrecioOptimo.Value) > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else : ExpertisApp.GenerateMessage("Es necesario especificar una fecha.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

End Class