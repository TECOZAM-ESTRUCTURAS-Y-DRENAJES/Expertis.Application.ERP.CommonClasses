Option Explicit On
Option Compare Text

Public Class [Shared]
    Public Enum ClaseMovimiento
        Indeterminado = 0
        Entrada = 1
        Salida = 2
        SoloEntradas = 3
    End Enum

    Public Enum ModoRecuentoSalidas
        Bajas
        Seleccionados
    End Enum
End Class

Public NotInheritable Class ReturningLoteDataEventArgs
    Inherits System.EventArgs

    Private mLote As Lote
    Private mSeguimiento As DataTable
    Private mDialogResult As DialogResult

    Public Sub New(ByVal l As Lote, ByVal seg As DataTable, ByVal result As DialogResult)
        MyBase.New()
        mLote = l
        mSeguimiento = seg
        mDialogResult = result
    End Sub

    Public ReadOnly Property Lote() As Lote
        Get
            Return mLote
        End Get
    End Property

    Public ReadOnly Property Seguimiento() As DataTable
        Get
            Return mSeguimiento
        End Get
    End Property

    Public ReadOnly Property DialogResult() As DialogResult
        Get
            Return mDialogResult
        End Get
    End Property
End Class

Public NotInheritable Class ReturningSerieDataEventArgs
    Inherits System.EventArgs

    Private mSerie As NSerie
    Private mDialogResult As DialogResult

    Public Sub New(ByVal s As NSerie, ByVal result As DialogResult)
        MyBase.New()
        mSerie = s
        mDialogResult = result
    End Sub

    Public ReadOnly Property Serie() As NSerie
        Get
            Return mSerie
        End Get
    End Property

    Public ReadOnly Property DialogResult() As DialogResult
        Get
            Return mDialogResult
        End Get
    End Property
End Class

Public NotInheritable Class ShowDialogEventArgs
    Inherits System.EventArgs

    Private mDesglose As ERP.CommonClasses.DesgloseBase

    Public Sub New(ByVal desglose As ERP.CommonClasses.DesgloseBase)
        MyBase.New()
        mDesglose = desglose
    End Sub

    Public ReadOnly Property Desglose() As ERP.CommonClasses.DesgloseBase
        Get
            Return mDesglose
        End Get
        'Set(ByVal Value As ERP.CommonClasses.Lote)
        '    mLote = Value
        'End Set
    End Property
End Class

