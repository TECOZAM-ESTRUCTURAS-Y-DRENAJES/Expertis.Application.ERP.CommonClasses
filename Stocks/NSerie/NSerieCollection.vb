Option Explicit On 
Option Compare Text

Public Class NSerieCollection
    Inherits CollectionBase

    Private mPendingInserts As Boolean
    Private mPendingDeletes As Boolean
    Private mTempInserts As Collection
    Private mTempDeletes As Collection

    Public Sub New()
        MyBase.New()
        mTempInserts = New Collection
        mTempDeletes = New Collection
    End Sub

    Public Property HasPendingInserts() As Boolean
        Get
            Return mPendingInserts
        End Get
        Set(ByVal Value As Boolean)
            mPendingInserts = Value
        End Set
    End Property

    Public Property HasPendingDeletes() As Boolean
        Get
            Return mPendingDeletes
        End Get
        Set(ByVal Value As Boolean)
            mPendingDeletes = Value
        End Set
    End Property

    Public ReadOnly Property TempInserts() As Collection
        Get
            Return mTempInserts
        End Get
    End Property

    Public ReadOnly Property TempDeletes() As Collection
        Get
            Return mTempDeletes
        End Get
    End Property

    Public ReadOnly Property Item(ByVal ParamArray ID() As String) As NSerie
        Get
            For Each ns As NSerie In Me.List
                Dim Coincide As Boolean = True
                Dim i As Integer

                For i = 0 To ns.ID.Count - 1
                    Try
                        Coincide = Coincide And (ns.ID(i) = ID(i))
                        If Not Coincide Then Exit For
                    Catch ex As IndexOutOfRangeException
                        Coincide = False
                        Err.Clear()
                        Exit For
                    End Try
                Next
                If Coincide Then
                    Return ns
                End If
            Next
        End Get
    End Property

    Friend Shadows ReadOnly Property List() As System.Collections.IList
        Get
            Return MyBase.List()
        End Get
    End Property

    Public Function GetDataTable(ByVal ParamArray ID() As String) As DataTable
        Dim ns As NSerie = Me.Item(ID)
        If Not ns Is Nothing Then
            Return ns.DataTable
        End If
    End Function

    Public Function GetStockData(ByVal ParamArray ID() As String) As StockData()
        Dim ns As NSerie = Me.Item(ID)
        If Not ns Is Nothing Then
            Return ns.StockData
        End If
    End Function

    Public Function SeriesDeBajaFormatoDataTable(ByVal ParamArray ID() As String) As DataTable
        Dim dt As DataTable = Me.GetDataTable(ID)
        Return Me.FiltrarSeriesDeBaja(dt)
    End Function

    Public Function SeriesDeBajaFormatoStockData(ByVal ParamArray ID() As String) As StockData()
        Dim sd(-1) As StockData
        Dim ns As NSerie = Me.Item(ID)
        If Not ns Is Nothing Then
            Dim dt As DataTable = Me.FiltrarSeriesDeBaja(ns.DataTable)
            If Not dt Is Nothing Then
                For Each dr As DataRow In dt.Rows
                    Dim data As New StockData(dr("IDArticulo"), dr("IDAlmacen"), dr("NSerie"), dr("IDActivo") & String.Empty, dr("IDEstadoActivo"), dr("IDOperario") & String.Empty, ns.FechaDocumento, ns.TipoMovimiento, ns.Documento, ns.IDDocumento)
                    If dr.Table.Columns.Contains("Ubicacion") Then data.Ubicacion = dr("Ubicacion") & String.Empty
                    StockDataManager.Copy(data, sd)
                Next
            End If
        End If
        Return sd
    End Function

    Private Function FiltrarSeriesDeBaja(ByVal dt As DataTable) As DataTable
        If Not dt Is Nothing Then
            Dim newdt As DataTable = dt.Clone
            Dim dv As New DataView(dt)
            Dim f As New Filter
            f.Add(New BooleanFilterItem("Baja", True))
            dv.RowFilter = f.Compose(New AdoFilterComposer)

            For Each drv As DataRowView In dv
                newdt.ImportRow(drv.Row)
            Next
            Return newdt
        End If
    End Function

    Public Function SeriesSeleccionadasFormatoDataTable(ByVal ParamArray ID() As String) As DataTable
        Dim dt As DataTable = Me.GetDataTable(ID)
        Return Me.FiltrarSeriesSeleccionadas(dt)
    End Function

    Public Function SeriesSeleccionadasFormatoStockData(ByVal ParamArray ID() As String) As StockData()
        Dim sd(-1) As StockData
        Dim ns As NSerie = Me.Item(ID)
        If Not ns Is Nothing Then
            Dim dt As DataTable = Me.FiltrarSeriesSeleccionadas(ns.DataTable)
            If Not dt Is Nothing Then
                For Each dr As DataRow In dt.Rows
                    Dim data As New StockData(dr("IDArticulo"), dr("IDAlmacen"), dr("NSerie"), dr("IDActivo") & String.Empty, dr("IDEstadoActivo"), dr("IDOperario") & String.Empty, ns.FechaDocumento, ns.TipoMovimiento, ns.Documento, ns.IDDocumento)
                    If dr.Table.Columns.Contains("Ubicacion") Then data.Ubicacion = dr("Ubicacion") & String.Empty
                    StockDataManager.Copy(data, sd)
                Next
            End If
        End If
        Return sd
    End Function

    Private Function FiltrarSeriesSeleccionadas(ByVal dt As DataTable) As DataTable
        If Not dt Is Nothing Then
            Dim newdt As DataTable = dt.Clone
            Dim dv As New DataView(dt)
            Dim f As New Filter
            f.Add(New BooleanFilterItem("Selector", True))
            dv.RowFilter = f.Compose(New AdoFilterComposer)

            For Each drv As DataRowView In dv
                newdt.ImportRow(drv.Row)
            Next
            Return newdt
        End If
    End Function

    Public Function Add(ByVal serie As NSerie, ByVal ParamArray ID() As String) As NSerie
        serie.SetID(ID)

        If Not mPendingInserts Then
            Me.List.Add(serie)
        Else
            mTempInserts.Add(serie)
        End If
        serie.SetSavedFlag()
        Return serie
    End Function

    Friend Function Add(ByVal serie As NSerie, ByVal ID As ArrayList) As NSerie
        Dim IDvalues(-1) As String
        IDvalues = Array.CreateInstance(GetType(String), ID.Count)
        For i As Integer = 0 To ID.Count - 1
            IDvalues(i) = ID(i)
        Next
        Return Me.Add(serie, IDvalues)
    End Function

    Public Shadows Sub RemoveAt(ByVal serie As NSerie)
        If Not serie Is Nothing Then
            If Not mPendingDeletes Then
                Me.List.Remove(serie)
            Else
                mTempDeletes.Add(serie)
            End If
        End If
    End Sub

    Public Shadows Sub RemoveAt(ByVal ParamArray ID() As String)
        Dim ns As NSerie = Me.Item(ID)
        Me.RemoveAt(ns)
    End Sub

    Public Sub BeginAdd()
        mPendingInserts = True
    End Sub

    Public Sub AbortAdd()
        If mPendingInserts Then
            mTempInserts = Nothing
            mTempInserts = New Collection
            mPendingInserts = False
        End If
    End Sub

    Public Sub CommitAdd()
        If mPendingInserts Then
            For Each item As NSerie In mTempInserts
                Me.List.Add(item)
            Next
            mTempInserts = Nothing
            mTempInserts = New Collection
            mPendingInserts = False
        End If
    End Sub

    Public Sub BeginDelete()
        mPendingDeletes = True
    End Sub

    Public Sub AbortDelete()
        If mPendingDeletes Then
            mTempDeletes = Nothing
            mTempDeletes = New Collection
            mPendingDeletes = False
        End If
    End Sub

    Public Sub CommitDelete()
        If mPendingDeletes Then
            For Each item As NSerie In mTempDeletes
                Me.List.Remove(item)
            Next
            mTempDeletes = Nothing
            mTempDeletes = New Collection
            mPendingDeletes = False
        End If
    End Sub
End Class