Option Explicit On 
Option Compare Text

Public Class Lote
    Inherits DesgloseBase

    Protected mLote As DataTable

    Private Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Articulo As String, ByVal Almacen As String)
        MyBase.New()
        mArticulo = Articulo
        mAlmacen = Almacen
        If Len(Articulo) > 0 And Len(Almacen) > 0 Then
            Dim f As New Filter
            f.Add(New StringFilterItem("IDArticulo", Articulo))
            f.Add(New StringFilterItem("IDAlmacen", Almacen))
            Me.DataTable = New ArticuloAlmacenLote().Filter(f) 'esto no vale? - PRECINTAS
            Me.DataTable.AcceptChanges()
            Me.SetID(New String() {})
        End If
    End Sub

    Public Overrides Property DataTable() As System.Data.DataTable
        Get
            Return mLote
        End Get
        Set(ByVal Value As System.Data.DataTable)
            mLote = Value
            ReDim mStockData(-1)
            If Not mLote Is Nothing AndAlso mLote.Rows.Count > 0 Then
                For Each dr As DataRow In mLote.Rows
                    Dim data As New StockData(dr("IDArticulo"), dr("IDAlmacen"), dr("Lote"), dr("Ubicacion"), dr("Cantidad"), 0, 0, mFechaDocumento, mTipoMovimiento, mDocumento, mIDDocumento)
                    If Length(dr("Cantidad2")) > 0 Then data.Cantidad2 = CDbl(dr("Cantidad2"))

                    If (mLote.Columns.Contains("FechaCaducidad") AndAlso Length(dr("FechaCaducidad")) > 0) Then data.FechaCaducidad = dr("FechaCaducidad")
                    If (mLote.Columns.Contains("SeriePrecinta") AndAlso Length(dr("SeriePrecinta")) > 0) Then data.PrecintaNSerie = dr("SeriePrecinta")
                    If (mLote.Columns.Contains("NDesdePrecinta") AndAlso Length(dr("NDesdePrecinta")) > 0) Then data.PrecintaDesde = dr("NDesdePrecinta")
                    If (mLote.Columns.Contains("NHastaPrecinta") AndAlso Length(dr("NHastaPrecinta")) > 0) Then data.PrecintaHasta = dr("NHastaPrecinta")
                    If (mLote.Columns.Contains("NDesde") AndAlso Length(dr("NDesde")) > 0) Then data.PrecintaUtilizadaDesde = dr("NDesde")
                    If (mLote.Columns.Contains("NHasta") AndAlso Length(dr("NHasta")) > 0) Then data.PrecintaUtilizadaHasta = dr("NHasta")
                    If (mLote.Columns.Contains("IDOperacionPlan") AndAlso Length(dr("IDOperacionPlan")) > 0) Then data.IDOperacionPlan = dr("IDOperacionPlan")

                    ReDim Preserve mStockData(UBound(mStockData) + 1)
                    mStockData(UBound(mStockData)) = data
                Next
            End If
        End Set
    End Property

    Public Function Copiar() As Lote
        Dim copia As New Lote
        copia.Articulo = mArticulo
        copia.Almacen = mAlmacen
        copia.Cantidad = mCantidad
        copia.DataTable = mLote.Copy
        copia.FechaDocumento = mFechaDocumento
        copia.Documento = mDocumento
        copia.IDDocumento = mIDDocumento
        copia.TipoMovimiento = mTipoMovimiento
        copia.SetID(mIDs)
        If mGuardado Then
            copia.SetSavedFlag()
        End If
        'pend despues de quitar los valores por defecto este metodo puede ser comun a Desglose
        'pend si se puede el problema esta en el new dentro de copiar ...
        Return copia
    End Function

    Public Sub ProponerCantidades()
        If Not mGuardado Then
            If mCantidad > 0 AndAlso Not mLote Is Nothing Then
                For Each dr As DataRow In mLote.Rows
                    dr("Cantidad") = dr("StockFisico")
                    If Length(dr("StockFisico2")) > 0 Then dr("Cantidad2") = dr("StockFisico2")
                Next
            End If
        End If
    End Sub

    Public Sub RepartirCantidades(ByVal claseMovimiento As [Shared].ClaseMovimiento)
        If Not mGuardado Then
            If mCantidad > 0 AndAlso Not mLote Is Nothing Then
                Dim dv As New DataView(mLote)
                dv.Sort = "FechaCaducidad ASC,FechaUltEntrada ASC"
                Dim QARepartir As Double = mCantidad
                Dim QARepartir2 As Double?
                If Not mCantidad2 Is Nothing Then QARepartir2 = mCantidad2
                If claseMovimiento = [Shared].ClaseMovimiento.Salida Then
                    Dim StockDisponible As Double = (Aggregate c In dv _
                                                         Where Not c.row.IsNull("Bloqueado") AndAlso Not c.row.IsNull("StockFisico") AndAlso _
                                                         c.row("Bloqueado") = 0 AndAlso c.row("StockFisico") <> 0 _
                                                         Into Sum(CDbl(c.row("StockFisico"))))

                    If QARepartir > StockDisponible Then Exit Sub

                    Dim StockDisponible2 As Double = (Aggregate c In dv _
                                                        Where Not c.row.IsNull("Bloqueado") AndAlso Not c.row.IsNull("StockFisico2") AndAlso _
                                                        c.row("Bloqueado") = 0 AndAlso c.row("StockFisico2") <> 0 _
                                                        Into Sum(CDbl(c.row("StockFisico2"))))

                    If QARepartir2 > StockDisponible2 Then Exit Sub

                End If


                Dim cantidad As Double
                Dim cantidad2 As Double

                For Each drv As DataRowView In dv
                    If Not (drv.Row("Bloqueado") And claseMovimiento = [Shared].ClaseMovimiento.Salida) Then
                        If drv.Row("StockFisico") <> 0 Then
                            If QARepartir > 0 Then
                                If QARepartir > drv.Row("StockFisico") Then
                                    QARepartir -= drv.Row("StockFisico")
                                    cantidad = drv.Row("StockFisico")
                                Else
                                    cantidad = QARepartir
                                    QARepartir = 0
                                End If
                                drv.Row("Cantidad") = cantidad
                            Else
                                If QARepartir2 Is Nothing Then Exit For
                            End If
                        End If

                        If Not QARepartir2 Is Nothing AndAlso drv.Row("StockFisico2") <> 0 Then
                            If QARepartir2 > 0 Then
                                If QARepartir2 > drv.Row("StockFisico2") Then
                                    QARepartir2 -= drv.Row("StockFisico2")
                                    cantidad2 = drv.Row("StockFisico2")
                                Else
                                    cantidad2 = QARepartir2
                                    QARepartir2 = 0
                                End If
                                drv.Row("Cantidad2") = cantidad2
                            End If
                        End If
                    End If
                Next
            End If
        End If
    End Sub
End Class
