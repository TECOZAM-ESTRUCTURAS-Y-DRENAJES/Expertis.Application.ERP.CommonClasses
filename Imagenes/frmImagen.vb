Public Class frmImagen

#Region "Variables Privadas / Propiedades Públicas"

    Private Data As New DatosConfigFotoInfo

    Public WriteOnly Property DatosFoto() As DatosConfigFotoInfo
        Set(ByVal value As DatosConfigFotoInfo)
            Data = value
        End Set
    End Property

#End Region

#Region "Funciones Privadas"

    Private Sub LoadData()
        Data.ErrorImage = ExpertisApp.GetIcon("cubes.ico").ToBitmap
        Data.InitialImage = ExpertisApp.GetIcon("cubes.ico").ToBitmap
        Data.Reposicionamiento = False
        Me.CtrlImage1.DatosFotoInfo = Data
        Data.MPoint = Me.CtrlImage1.Location
        Me.CtrlImage1.DatosFotoInfo = Data
        Me.CtrlImage1.ReEstablecerPosicion = True
        Me.CtrlImage1.LoadImage()
        Me.CtrlImage1.LoadData()
    End Sub

#End Region

#Region "Eventos FrmImagen"

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmImagenFamilia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            LoadData()
        End If
    End Sub

#End Region

End Class