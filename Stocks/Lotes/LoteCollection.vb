Option Explicit On 
Option Compare Text

Imports System.ComponentModel

Public Class LoteCollection
    Inherits CollectionBase

    Private mPendingInserts As Boolean
    Private mPendingDeletes As Boolean
    Private mTempInserts As Collection
    Private mTempDeletes As Collection
    Private mCache As DataTable

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

    Public ReadOnly Property Item(ByVal ParamArray ID() As String) As Lote
        Get
            For Each lt As Lote In Me.List
                Dim Coincide As Boolean = True
                Dim i As Integer

                For i = 0 To lt.ID.Count - 1
                    Try
                        Coincide = Coincide And (lt.ID(i) = ID(i))
                        If Not Coincide Then Exit For
                    Catch ex As IndexOutOfRangeException
                        Coincide = False
                        Err.Clear()
                        Exit For
                    End Try
                Next
                If Coincide Then
                    Return lt
                End If
            Next
        End Get
    End Property

    Public Property Cache() As DataTable
        Get
            Return mCache
        End Get
        Set(ByVal Value As DataTable)
            mCache = Value
        End Set
    End Property

    Public Function GetDataTable(ByVal ParamArray ID() As String) As DataTable
        Dim lt As Lote = Me.Item(ID)
        If Not lt Is Nothing Then
            Return lt.DataTable
        End If
    End Function

    Public Function GetStockData(ByVal ParamArray ID() As String) As StockData()
        Dim lt As Lote = Me.Item(ID)
        If Not lt Is Nothing Then
            Return lt.StockData
        End If
    End Function

    Public Function Add(ByVal lote As Lote, ByVal ParamArray ID() As String) As Lote
        lote.SetID(ID)
        If Not mPendingInserts Then
            Me.List.Add(lote)
        Else
            mTempInserts.Add(lote)
        End If
        lote.SetSavedFlag()
        Return lote
    End Function

    Public Function Add(ByVal lote As Lote, ByVal ID As ArrayList) As Lote
        Dim IDvalues(-1) As String
        IDvalues = Array.CreateInstance(GetType(String), ID.Count)
        For i As Integer = 0 To ID.Count - 1
            IDvalues(i) = ID(i)
        Next
        Return Me.Add(lote, IDvalues)
    End Function

    Public Shadows Sub RemoveAt(ByVal lote As Lote)
        If Not lote Is Nothing Then
            Acumular(lote, True)
            If Not mPendingDeletes Then
                Me.List.Remove(lote)
            Else
                mTempDeletes.Add(lote)
            End If
        End If
    End Sub

    Public Shadows Sub RemoveAt(ByVal ParamArray ID() As String)
        Dim lt As Lote = Me.Item(ID)
        Me.RemoveAt(lt)
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
            For Each item As Lote In mTempInserts
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
            For Each item As Lote In mTempDeletes
                Me.List.Remove(item)
            Next
            mTempDeletes = Nothing
            mTempDeletes = New Collection
            mPendingDeletes = False
        End If
    End Sub

    Public Sub Reset(ByVal lote As Lote)
        If Not lote Is Nothing Then
            Acumular(lote, True)
            For Each dr As DataRow In lote.DataTable.Rows
                dr("Cantidad") = 0
            Next
        End If
    End Sub

    Public Sub Reset(ByVal ParamArray ID() As String)
        Dim lt As Lote = Me.Item(ID)
        Me.Reset(lt)
    End Sub

    Public Sub Acumular(ByVal lt As Lote, Optional ByVal EsBorrado As Boolean = False)
        Dim f As New Filter
        f.Add(New StringFilterItem("IDArticulo", lt.Articulo))
        f.Add(New StringFilterItem("IDAlmacen", lt.Almacen))

        Dim dv As New DataView(mCache)
        dv.RowFilter = f.Compose(New AdoFilterComposer)
        If dv.Count > 0 Then
            dv.Sort = "Lote,Ubicacion"
            Dim idx As Integer
            For Each dr As DataRow In lt.DataTable.Rows
                If Not EsBorrado Then
                    If dr.RowState = DataRowState.Modified AndAlso dr("Cantidad") <> 0 Then
                        idx = dv.Find(New String(1) {dr("Lote"), dr("Ubicacion")})
                        If idx >= 0 Then
                            dv(idx).Row("StockFisico") -= dr("Cantidad")
                        End If
                    End If
                Else
                    idx = dv.Find(New String(1) {dr("Lote"), dr("Ubicacion")})
                    If idx >= 0 Then
                        dv(idx).Row("StockFisico") += dr("Cantidad")
                    End If
                End If
            Next
        End If
    End Sub

    Public Sub StockActual(ByVal lt As Lote)
        Dim f As New Filter
        f.Add(New StringFilterItem("IDArticulo", lt.Articulo))
        f.Add(New StringFilterItem("IDAlmacen", lt.Almacen))

        Dim dv As New DataView(mCache)
        dv.RowFilter = f.Compose(New AdoFilterComposer)
        If dv.Count > 0 Then
            dv.Sort = "Lote,Ubicacion"
            Dim idx As Integer
            For Each dr As DataRow In lt.DataTable.Rows
                idx = dv.Find(New String(1) {dr("Lote"), dr("Ubicacion")})
                If idx >= 0 Then
                    dr("StockFisico") = dv(idx).Row("StockFisico")
                End If
            Next
        End If
        '//Esta linea hace que RowState de todas las lineas pase a Unchanged.
        '//De esta forma las filas van con el RowState adecuado a la funcion de Acumular
        lt.DataTable.AcceptChanges()
    End Sub
End Class
