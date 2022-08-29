Imports Solmicro.Expertis.Business.Negocio

Imports Janus.Windows.GridEX

Public Class DetalleActualizacionPagoPisos
    Inherits System.Windows.Forms.Form

    Private mData As DataTable

    Public WriteOnly Property DataSource() As Object
        Set(ByVal Value As Object)
            If IsArray(Value) Then
                For Each item As Object In Value
                    If Not item Is Nothing Then
                        If item.GetType Is GetType(DataPrcFacturacionCompraPiso) Then
                            Add(CType(item, DataPrcFacturacionCompraPiso))
                        End If
                    End If
                Next
            ElseIf Value.GetType Is GetType(DataPrcFacturacionCompraPiso) Then
                Add(CType(Value, DataPrcFacturacionCompraPiso))
            End If
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        CrearEsquema()
    End Sub

    Private Sub Add(ByVal data As DataPrcFacturacionCompraPiso)
        If Len(data.IDPisoPagos) > 0 Then
            Dim newrow As DataRow = mData.NewRow
            newrow("DteFechaFactura") = data.DteFechaFactura
            newrow("SuFactura") = data.SuFactura
            mData.Rows.Add(newrow)
        End If
    End Sub

    Private Sub CrearEsquema()
        mData = New DataTable
        mData.Columns.Add("DteFechaFactura", GetType(String))
        mData.Columns.Add("SuFactura", GetType(Date))
    End Sub

    Private Sub DetalleActualizacionPagoPisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Detalle.TabKeyBehavior = TabKeyBehavior.ControlNavigation
        Detalle.DataSource = mData
    End Sub

    Private Sub DetalleActualizacionPagoPisos_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        CloseButton.Focus()
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class