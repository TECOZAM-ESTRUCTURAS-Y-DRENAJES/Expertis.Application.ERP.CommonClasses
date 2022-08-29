Option Explicit On 
Option Compare Text

Public NotInheritable Class NSerie
    Inherits DesgloseBase

    '//Estos valores deben coincidir con los de la tabla tbMntoEstadoActivo y corresponden 
    '//a los estados de activo marcados como de Sistema, predeterminados en la aplicacion.
    Public Const ESTADO_DISPONIBLE As String = "0"
    Public Const ESTADO_EN_MANTENIMIENTO As String = "1"
    Public Const ESTADO_RESERVADA As String = "2"
    Public Const ESTADO_TRABAJANDO As String = "3"
    Public Const ESTADO_VENDIDO As String = "4"
    Public Const ESTADO_BAJA As String = "5"
    Public Const ESTADO_AVERIADO As String = "6"
    Public Const ESTADO_EN_TRANSITO As String = "7"
    Public Const ESTADO_OCUPADO_EN_PORTE As String = "8"

    Private mSeries As DataTable
    Private mOriginalData As DataTable

    Friend Sub New()
        MyBase.New()
        '//Este new se pone friend para que funcione lo de 'SoloEntradas'
        Me.DataTable = New ArticuloNSerie().AddNew()
    End Sub

    Public Sub New(ByVal Articulo As String, ByVal Almacen As String)
        Me.New(Articulo, Almacen, Nothing, True)
    End Sub

    Public Sub New(ByVal Articulo As String, ByVal Almacen As String, ByVal FiltroPorAlmacen As Boolean)
        MyBase.New()
        mArticulo = Articulo
        mAlmacen = Almacen
        If Len(Articulo) > 0 And Len(Almacen) > 0 Then
            Dim f0 As New Filter
            f0.Add(New StringFilterItem("IDArticulo", Articulo))
            f0.Add(New StringFilterItem("IDAlmacen", Almacen))
            f0.Add(New BooleanFilterItem("Disponible", True))
            Dim DtSeries As DataTable = New ArticuloNSerie().Filter(f0)
            For Each dr As DataRow In DtSeries.Select
                dr("IDAlmacen") = mAlmacen
            Next
            Dim f1 As New Filter
            f1.Add(New StringFilterItem("IDArticulo", Articulo))
            f1.Add(New BooleanFilterItem("Disponible", False))
            Dim DtBajas As DataTable = New ArticuloNSerie().Filter(f1)
            If Not DtBajas Is Nothing AndAlso DtBajas.Rows.Count > 0 Then
                For Each DrBaja As DataRow In DtBajas.Select
                    DrBaja("IDAlmacen") = malmacen
                    DtSeries.Rows.Add(DrBaja.ItemArray)
                Next
            End If
            Me.DataTable = DtSeries

            mOriginalData = Me.DataTable.Copy
            mOriginalData.DefaultView.Sort = "NSerie"

            Me.DataTable.AcceptChanges()
            Me.SetID(New String() {})
        End If
    End Sub

    Public Sub New(ByVal Articulo As String, ByVal Almacen As String, ByVal f As Filter, ByVal FiltroPorAlmacen As Boolean)
        MyBase.New()
        mArticulo = Articulo
        mAlmacen = Almacen
        If Len(Articulo) > 0 And Len(Almacen) > 0 Then
            Dim f0 As New Filter
            f0.Add(New StringFilterItem("IDArticulo", Articulo))
            If FiltroPorAlmacen Then f0.Add(New StringFilterItem("IDAlmacen", Almacen))
            If Not f Is Nothing AndAlso f.Count > 0 Then
                f0.Add(f)
            End If
            Dim DtSeries As DataTable = New ArticuloNSerie().Filter(f0)
            If Not FiltroPorAlmacen Then
                For Each dr As DataRow In DtSeries.Select
                    dr("IDAlmacen") = mAlmacen
                Next
            End If
            Me.DataTable = DtSeries

            mOriginalData = Me.DataTable.Copy
            mOriginalData.DefaultView.Sort = "NSerie"

            Me.DataTable.AcceptChanges()
            Me.SetID(New String() {})
        End If
    End Sub

    Public Overrides Property DataTable() As System.Data.DataTable
        Get
            Return mSeries
        End Get
        Set(ByVal Value As System.Data.DataTable)
            mSeries = Value
            ReDim mStockData(-1)
            If Not mSeries Is Nothing AndAlso mSeries.Rows.Count > 0 Then
                For Each dr As DataRow In mSeries.Rows
                    Dim data As New StockData(dr("IDArticulo"), dr("IDAlmacen"), dr("NSerie"), dr("IDActivo") & String.Empty, dr("IDEstadoActivo"), dr("IDOperario") & String.Empty, mFechaDocumento, mTipoMovimiento, mDocumento, mIDDocumento)
                    If dr.Table.Columns.Contains("Ubicacion") Then data.Ubicacion = dr("Ubicacion") & String.Empty
                    StockDataManager.Copy(data, mStockData)
                Next
            End If
        End Set
    End Property

    Public ReadOnly Property OriginalData() As DataTable
        Get
            Return mOriginalData
        End Get
    End Property

    Public Function Copiar() As NSerie
        Dim copia As New NSerie
        copia.Articulo = mArticulo
        copia.Almacen = mAlmacen
        copia.Cantidad = mCantidad
        copia.DataTable = mSeries.Copy
        copia.FechaDocumento = mFechaDocumento
        copia.Documento = mDocumento
        copia.IDDocumento = mIDDocumento
        copia.TipoMovimiento = mTipoMovimiento
        copia.SetID(mIDs)
        If mGuardado Then
            copia.SetSavedFlag()
        End If
        Return copia
    End Function
End Class
