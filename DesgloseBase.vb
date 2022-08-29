Option Explicit On 
Option Compare Text

Public MustInherit Class DesgloseBase
    Protected mIDs As ArrayList
    Protected mIDValues As ArrayList
    Protected mArticulo As String
    Protected mAlmacen As String
    Protected mCantidad As Double
    Protected mCantidad2 As Double?
    Protected mIDDocumento As Integer
    Protected mDocumento As String
    Protected mFechaDocumento As Date
    Protected mTipoMovimiento As enumTipoMovimiento
    Protected mGuardado As Boolean

    Protected mStockData() As StockData

    Public Sub New()
        ReDim mStockData(-1)
        mFechaDocumento = Today
    End Sub

    Public Property Articulo() As String
        Get
            Return mArticulo
        End Get
        Set(ByVal Value As String)
            mArticulo = Value
        End Set
    End Property

    Public Property Almacen() As String
        Get
            Return mAlmacen
        End Get
        Set(ByVal Value As String)
            mAlmacen = Value
        End Set
    End Property

    Public Property Cantidad() As Double
        Get
            Return mCantidad
        End Get
        Set(ByVal Value As Double)
            mCantidad = Value
        End Set
    End Property

    Public Property Cantidad2() As Double?
        Get
            Return mCantidad2
        End Get
        Set(ByVal Value As Double?)
            mCantidad2 = Value
        End Set
    End Property

    Public Property IDDocumento() As Integer
        Get
            Return mIDDocumento
        End Get
        Set(ByVal Value As Integer)
            mIDDocumento = Value
        End Set
    End Property

    Public Property Documento() As String
        Get
            Return mDocumento
        End Get
        Set(ByVal Value As String)
            mDocumento = Value
        End Set
    End Property

    Public Property FechaDocumento() As Date
        Get
            Return mFechaDocumento
        End Get
        Set(ByVal Value As Date)
            mFechaDocumento = Value
        End Set
    End Property

    Public Property TipoMovimiento() As enumTipoMovimiento
        Get
            Return mTipoMovimiento
        End Get
        Set(ByVal Value As enumTipoMovimiento)
            mTipoMovimiento = Value
        End Set
    End Property

    Public ReadOnly Property ID() As ArrayList
        Get
            Return mIDValues
        End Get
    End Property

    Public ReadOnly Property StockData() As StockData()
        Get
            Return mStockData
        End Get
    End Property

    Public ReadOnly Property Guardado() As Boolean
        Get
            Return mGuardado
        End Get
    End Property

    Public Sub SetID(ByVal ID() As String)
        Me.mIDs = New ArrayList
        If ID.Length = 0 Then
            Me.mIDs.Add(mArticulo)
            Me.mIDs.Add(mAlmacen)
        Else
            For i As Integer = 0 To UBound(ID)
                Me.mIDs.Add(ID(i))
            Next
        End If
        mIDValues = ArrayList.ReadOnly(mIDs)
    End Sub

    Public Sub SetID(ByVal ID As ArrayList)
        mIDs = ID
        mIDValues = ArrayList.ReadOnly(mIDs)
    End Sub

    Public Sub SetSavedFlag()
        mGuardado = True
    End Sub

    Public MustOverride Property DataTable() As DataTable
End Class