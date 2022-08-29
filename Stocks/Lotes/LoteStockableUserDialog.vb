Option Explicit On
Option Compare Text

Imports System.Math
Imports Solmicro.Expertis.Business.Bodega.BdgVinoMaterialLote

Public Class LoteStockableUserDialog
    Inherits Expertis.Application.ERP.CommonClasses.LoteUserDialog

    Public NotInheritable Class DataSourceSchema
        Private mIDArticulo As String = "IDArticulo"
        Private mIDAlmacen As String = "IDAlmacen"
        Private mLote As String = "Lote"
        Private mUbicacion As String = "Ubicacion"
        Private mCantidad As String = "Cantidad"
        Private mCantidad2 As String = "Cantidad2"

        Public Property IDArticulo() As String
            Get
                Return mIDArticulo
            End Get
            Set(ByVal Value As String)
                mIDArticulo = Value
            End Set
        End Property

        Public Property IDAlmacen() As String
            Get
                Return mIDAlmacen
            End Get
            Set(ByVal Value As String)
                mIDAlmacen = Value
            End Set
        End Property

        Public Property Lote() As String
            Get
                Return mLote
            End Get
            Set(ByVal Value As String)
                mLote = Value
            End Set
        End Property

        Public Property Ubicacion() As String
            Get
                Return mUbicacion
            End Get
            Set(ByVal Value As String)
                mUbicacion = Value
            End Set
        End Property

        Public Property Cantidad() As String
            Get
                Return mCantidad
            End Get
            Set(ByVal Value As String)
                mCantidad = Value
            End Set
        End Property

        Public Property Cantidad2() As String
            Get
                Return mCantidad2
            End Get
            Set(ByVal value As String)
                mCantidad2 = value
            End Set
        End Property

        Friend Sub New()
        End Sub
    End Class

    Protected Shadows Class CurrentData
        Private mIDArticulo As String
        Private mIDAlmacen As String
        Private mLote As String
        Private mUbicacion As String
        Private mCantidad As Double
        Private mCantidad2 As Double
        Private mDataTable As DataTable
        Private mGrid As GridEX
        Private mSchema As New DataSourceSchema

        Public Property Grid() As Grid
            Get
                Return mGrid
            End Get
            Set(ByVal Value As Grid)
                mGrid = Value
                If Not mGrid Is Nothing Then
                    mDataTable = CType(mGrid.DataSource, DataTable)
                End If
            End Set
        End Property

        Public Property DataTable() As DataTable
            Get
                Return mDataTable
            End Get
            Set(ByVal Value As DataTable)
                mDataTable = Value
            End Set
        End Property

        Public Property IDArticulo() As String
            Get
                If Not mGrid Is Nothing Then
                    mIDArticulo = mGrid.GetValue(mSchema.IDArticulo & String.Empty)
                ElseIf Not mDataTable Is Nothing AndAlso mDataTable.Rows.Count > 0 Then
                    mIDArticulo = mDataTable.Rows(0)(mSchema.IDArticulo) & String.Empty
                End If
                Return mIDArticulo
            End Get
            Set(ByVal Value As String)
                mIDArticulo = Value
            End Set
        End Property

        Public Property IDAlmacen() As String
            Get
                If Not mGrid Is Nothing Then
                    mIDAlmacen = mGrid.GetValue(mSchema.IDAlmacen) & String.Empty
                ElseIf Not mDataTable Is Nothing AndAlso mDataTable.Rows.Count > 0 Then
                    mIDAlmacen = mDataTable.Rows(0)(mSchema.IDAlmacen) & String.Empty
                End If
                Return mIDAlmacen
            End Get
            Set(ByVal Value As String)
                mIDAlmacen = Value
            End Set
        End Property

        Public Property Lote() As String
            Get
                If Not mGrid Is Nothing Then
                    mLote = mGrid.GetValue(mSchema.Lote)
                ElseIf Not mDataTable Is Nothing AndAlso mDataTable.Rows.Count > 0 Then
                    mLote = mDataTable.Rows(0)(mSchema.Lote)
                End If
                Return mLote
            End Get
            Set(ByVal Value As String)
                mLote = Value
            End Set
        End Property

        Public Property Ubicacion() As String
            Get
                If Not mGrid Is Nothing Then
                    mUbicacion = mGrid.GetValue(mSchema.Ubicacion)
                ElseIf Not mDataTable Is Nothing AndAlso mDataTable.Rows.Count > 0 Then
                    mUbicacion = mDataTable.Rows(0)(mSchema.Ubicacion)
                End If
                Return mUbicacion
            End Get
            Set(ByVal Value As String)
                mUbicacion = Value
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

        Public Property Cantidad2() As Double
            Get
                Return mCantidad2
            End Get
            Set(ByVal Value As Double)
                mCantidad2 = Value
            End Set
        End Property


        Public Property Schema() As DataSourceSchema
            Get
                Return mSchema
            End Get
            Set(ByVal Value As DataSourceSchema)
                mSchema = Value
            End Set
        End Property
    End Class

    Protected mValorPorDefectoLote As String
    Protected mValorPorDefectoUbicacion As String
    Protected mValorPorDefectoCantidad As Double
    Protected mValorPorDefectoCantidad2 As Double
    Protected mDataSource As Object
    Protected mDataSchema As DataSourceSchema
    Protected mClaseMovimiento As [Shared].ClaseMovimiento
    Protected mLote As Lote
    Protected mLoteCollection As LoteCollection
    Protected mRepartir As Boolean
    Protected mProponer As Boolean
    Protected mAcumular As Boolean
    Protected mIsBound As Boolean
    Protected mSeguimiento As Boolean
    Protected mSeguimientoObligatorio As Boolean
    Protected mIDS() As String
    Protected StDataSegPrec As New BdgHistoricoPrecintas.DataProcSegPrecRet
    Friend WithEvents gridRangoPrecintas As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents PnlPrecintaSeguimiento As Solmicro.Expertis.Engine.UI.Panel
    Protected WithEvents GrdSeguimiento As Solmicro.Expertis.Engine.UI.Grid

    Protected mCurrentData As CurrentData

    Public Event ShowLotesDialog(ByVal sender As Object, ByVal e As ShowDialogEventArgs)
    Public Event CloseLotesDialog(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event ReturningData(ByVal sender As Object, ByVal e As ReturningLoteDataEventArgs)

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()
        InitializeComponent()

        mDataSchema = New DataSourceSchema
        mCurrentData = New CurrentData
        mCurrentData.Schema = mDataSchema
        mLoteCollection = New LoteCollection

        mClaseMovimiento = [Shared].ClaseMovimiento.Indeterminado
        mRepartir = False
        mProponer = False

        Grid.AllowAddNew = InheritableBoolean.True
        Grid.AllowDelete = InheritableBoolean.True
    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Totales_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim gridRangoPrecintas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GrdSeguimiento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoteStockableUserDialog))
        Me.gridRangoPrecintas = New Solmicro.Expertis.Engine.UI.Grid
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.GrdSeguimiento = New Solmicro.Expertis.Engine.UI.Grid
        Me.PnlPrecintaSeguimiento = New Solmicro.Expertis.Engine.UI.Panel
        Me.Panel5.suspendlayout()
        Me.FraLotesAuto.SuspendLayout()
        Me.Panel1.suspendlayout()
        Me.Frame1.SuspendLayout()
        Me.Panel2.suspendlayout()
        Me.Panel3.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Totales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.suspendlayout()
        CType(Me.gridRangoPrecintas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdSeguimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlPrecintaSeguimiento.suspendlayout()
        Me.SuspendLayout()
        '
        'ntbStockFisico2
        '
        Me.ntbStockFisico2.Location = New System.Drawing.Point(154, 9)
        Me.ntbStockFisico2.Size = New System.Drawing.Size(99, 21)
        '
        'Panel5
        '
        Me.Panel5.Location = New System.Drawing.Point(0, 76)
        Me.Panel5.Size = New System.Drawing.Size(843, 49)
        '
        'lblEmpezarPor
        '
        Me.lblEmpezarPor.Location = New System.Drawing.Point(599, 17)
        '
        'txtNumeracion
        '
        Me.txtNumeracion.Location = New System.Drawing.Point(709, 13)
        Me.txtNumeracion.Size = New System.Drawing.Size(90, 21)
        '
        'lblCodigo
        '
        Me.lblCodigo.Location = New System.Drawing.Point(410, 17)
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(471, 13)
        Me.txtCodigo.Size = New System.Drawing.Size(120, 21)
        '
        'cmbGenerarLote
        '
        Me.cmbGenerarLote.Location = New System.Drawing.Point(804, 13)
        Me.cmbGenerarLote.Size = New System.Drawing.Size(23, 21)
        '
        'FraLotesAuto
        '
        Me.FraLotesAuto.Size = New System.Drawing.Size(836, 42)
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(196, 17)
        '
        'txtNumLotesGenerar
        '
        Me.txtNumLotesGenerar.Location = New System.Drawing.Point(326, 13)
        Me.txtNumLotesGenerar.Size = New System.Drawing.Size(73, 21)
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 461)
        Me.Panel1.Size = New System.Drawing.Size(849, 60)
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.Splitter1)
        Me.Frame1.Controls.Add(Me.PnlPrecintaSeguimiento)
        Me.Frame1.Location = New System.Drawing.Point(0, 55)
        Me.Frame1.Size = New System.Drawing.Size(849, 406)
        Me.Frame1.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Frame1.Controls.SetChildIndex(Me.Panel3, 0)
        Me.Frame1.Controls.SetChildIndex(Me.PnlPrecintaSeguimiento, 0)
        Me.Frame1.Controls.SetChildIndex(Me.Splitter1, 0)
        Me.Frame1.Controls.SetChildIndex(Me.Grid, 0)
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(289, 18)
        Me.OkButton.Size = New System.Drawing.Size(116, 29)
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(849, 55)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 8)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 34)
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(3, 363)
        Me.Panel3.Size = New System.Drawing.Size(843, 40)
        '
        'DescArticulo
        '
        Me.DescArticulo.Location = New System.Drawing.Point(221, 2)
        Me.DescArticulo.Size = New System.Drawing.Size(537, 20)
        Me.DescArticulo.Text = ""
        '
        'DescAlmacen
        '
        Me.DescAlmacen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DescAlmacen.Location = New System.Drawing.Point(221, 26)
        Me.DescAlmacen.Size = New System.Drawing.Size(537, 22)
        Me.DescAlmacen.Text = ""
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.HeaderFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Grid.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.Grid.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Grid.Location = New System.Drawing.Point(3, 142)
        Me.Grid.Size = New System.Drawing.Size(454, 221)
        Me.Grid.UpdateOnLeave = True
        '
        'IDArticulo
        '
        Me.IDArticulo.Location = New System.Drawing.Point(75, 6)
        Me.IDArticulo.Size = New System.Drawing.Size(140, 17)
        Me.IDArticulo.Text = ""
        '
        'IDAlmacen
        '
        Me.IDAlmacen.Location = New System.Drawing.Point(75, 31)
        Me.IDAlmacen.Size = New System.Drawing.Size(140, 17)
        Me.IDAlmacen.Text = ""
        '
        'Icons
        '
        Me.Icons.ImageStream = CType(resources.GetObject("Icons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Icons.Images.SetKeyName(0, "")
        Me.Icons.Images.SetKeyName(1, "")
        '
        'CancelButton2
        '
        Me.CancelButton2.Location = New System.Drawing.Point(443, 18)
        Me.CancelButton2.Size = New System.Drawing.Size(117, 29)
        '
        'chkMostrarLotesStockCero
        '
        Me.chkMostrarLotesStockCero.Location = New System.Drawing.Point(1832, 11)
        '
        'Totales
        '
        Totales_DesignTimeLayout.LayoutString = resources.GetString("Totales_DesignTimeLayout.LayoutString")
        Me.Totales.DesignTimeLayout = Totales_DesignTimeLayout
        Me.Totales.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Totales.HeaderFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Totales.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.Totales.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Totales.Location = New System.Drawing.Point(51, 10)
        Me.Totales.Size = New System.Drawing.Size(751, 60)
        '
        'Panel4
        '
        Me.Panel4.Size = New System.Drawing.Size(843, 125)
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(3, 14)
        '
        'ntbStockFisico
        '
        Me.ntbStockFisico.Location = New System.Drawing.Point(50, 9)
        Me.ntbStockFisico.Size = New System.Drawing.Size(99, 21)
        '
        'gridRangoPrecintas
        '
        gridRangoPrecintas_DesignTimeLayout.LayoutString = resources.GetString("gridRangoPrecintas_DesignTimeLayout.LayoutString")
        Me.gridRangoPrecintas.DesignTimeLayout = gridRangoPrecintas_DesignTimeLayout
        Me.gridRangoPrecintas.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.gridRangoPrecintas.EntityName = Nothing
        Me.gridRangoPrecintas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridRangoPrecintas.Location = New System.Drawing.Point(15, 27)
        Me.gridRangoPrecintas.Name = "gridRangoPrecintas"
        Me.gridRangoPrecintas.PrimaryDataFields = Nothing
        Me.gridRangoPrecintas.SecondaryDataFields = Nothing
        Me.gridRangoPrecintas.Size = New System.Drawing.Size(383, 221)
        Me.gridRangoPrecintas.TabIndex = 10
        Me.gridRangoPrecintas.ViewName = Nothing
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter1.Location = New System.Drawing.Point(457, 142)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(10, 221)
        Me.Splitter1.TabIndex = 11
        Me.Splitter1.TabStop = False
        '
        'GrdSeguimiento
        '
        Me.GrdSeguimiento.ColumnAutoResize = True
        GrdSeguimiento_DesignTimeLayout.LayoutString = resources.GetString("GrdSeguimiento_DesignTimeLayout.LayoutString")
        Me.GrdSeguimiento.DesignTimeLayout = GrdSeguimiento_DesignTimeLayout
        Me.GrdSeguimiento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdSeguimiento.EntityName = Nothing
        Me.GrdSeguimiento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrdSeguimiento.Location = New System.Drawing.Point(3, 6)
        Me.GrdSeguimiento.Name = "GrdSeguimiento"
        Me.GrdSeguimiento.PrimaryDataFields = Nothing
        Me.GrdSeguimiento.SecondaryDataFields = Nothing
        Me.GrdSeguimiento.Size = New System.Drawing.Size(350, 192)
        Me.GrdSeguimiento.TabIndex = 12
        Me.GrdSeguimiento.ViewName = Nothing
        '
        'PnlPrecintaSeguimiento
        '
        Me.PnlPrecintaSeguimiento.Controls.Add(Me.GrdSeguimiento)
        Me.PnlPrecintaSeguimiento.Controls.Add(Me.gridRangoPrecintas)
        Me.PnlPrecintaSeguimiento.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlPrecintaSeguimiento.Location = New System.Drawing.Point(467, 142)
        Me.PnlPrecintaSeguimiento.Name = "PnlPrecintaSeguimiento"
        Me.PnlPrecintaSeguimiento.Size = New System.Drawing.Size(379, 221)
        Me.PnlPrecintaSeguimiento.TabIndex = 13
        '
        'LoteStockableUserDialog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(849, 521)
        Me.Name = "LoteStockableUserDialog"
        Me.Text = ""
        Me.Panel5.ResumeLayout(False)
        Me.FraLotesAuto.ResumeLayout(False)
        Me.FraLotesAuto.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Totales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.gridRangoPrecintas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdSeguimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlPrecintaSeguimiento.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Property ValorPorDefectoLote() As String
        Get
            Return mValorPorDefectoLote
        End Get
        Set(ByVal Value As String)
            mValorPorDefectoLote = Value
        End Set
    End Property

    Public Property Lote() As Lote
        Get
            Return mLote
        End Get
        Set(ByVal Value As Lote)
            mLote = Value
        End Set
    End Property

    Public Property ValorPorDefectoUbicacion() As String
        Get
            Return mValorPorDefectoUbicacion
        End Get
        Set(ByVal Value As String)
            mValorPorDefectoUbicacion = Value
        End Set
    End Property

    Public Property ValorPorDefectoCantidad() As Double
        Get
            Return mValorPorDefectoCantidad
        End Get
        Set(ByVal Value As Double)
            mValorPorDefectoCantidad = Value
        End Set
    End Property

    Public Property ValorPorDefectoCantidad2() As Double
        Get
            Return mValorPorDefectoCantidad2
        End Get
        Set(ByVal Value As Double)
            mValorPorDefectoCantidad2 = Value
        End Set
    End Property

    Public Overridable Property ClaseMovimiento() As [Shared].ClaseMovimiento
        Get
            Return mClaseMovimiento
        End Get
        Set(ByVal Value As [Shared].ClaseMovimiento)
            mClaseMovimiento = Value

            If mClaseMovimiento = [Shared].ClaseMovimiento.Salida Then
                Grid.AllowAddNew = InheritableBoolean.False
                Grid.AllowDelete = InheritableBoolean.False
            Else
                Grid.AllowAddNew = InheritableBoolean.True
                Grid.AllowDelete = InheritableBoolean.True
            End If
        End Set
    End Property

    Public ReadOnly Property DataSchema() As DataSourceSchema
        Get
            Return mDataSchema
        End Get
    End Property

    Public Property DataSource() As Object
        Get
            Return mDataSource
        End Get
        Set(ByVal Value As Object)
            If Not Value Is Nothing Then
                If TypeOf Value Is DataTable Then
                    mCurrentData.DataTable = CType(Value, DataTable)
                    AddHandler mCurrentData.DataTable.ColumnChanging, AddressOf DataSourceColumnReading
                    mIsBound = True
                ElseIf TypeOf Value Is GridEX Then
                    mCurrentData.Grid = CType(Value, GridEX)
                    AddHandler mCurrentData.Grid.EditingCell, AddressOf DataSourceColumnReading
                    AddHandler mCurrentData.Grid.KeyDown, AddressOf DataSourceColumnReading
                    AddHandler mCurrentData.Grid.CellValueChanged, AddressOf DataSourceColumnReading
                    AddHandler mCurrentData.Grid.UpdatingCell, AddressOf DataSourceColumnReading
                    AddHandler mCurrentData.Grid.MouseDown, AddressOf DataSourceColumnReading
                    mIsBound = True
                Else
                    Throw New Exception("El tipo del origen de datos para el formulario de lotes no es válido.")
                End If
            End If
        End Set
    End Property

    Public Property RepartirCantidades() As Boolean
        Get
            Return mRepartir
        End Get
        Set(ByVal Value As Boolean)
            mRepartir = Value
            mProponer = Not mRepartir
        End Set
    End Property

    Public Property ProponerCantidades() As Boolean
        Get
            Return mProponer
        End Get
        Set(ByVal Value As Boolean)
            mProponer = Value
            mRepartir = Not mProponer
        End Set
    End Property

    Public Property AcumularCantidades() As Boolean
        Get
            Return mAcumular
        End Get
        Set(ByVal Value As Boolean)
            mAcumular = Value
        End Set
    End Property

    Private mAsignarStockFisicoCero As Boolean
    Public Property AsignarStockFisicoCero() As Boolean
        Get
            Return mAsignarStockFisicoCero
        End Get
        Set(ByVal Value As Boolean)
            mAsignarStockFisicoCero = Value
        End Set
    End Property

    Private mAutoAsignar As Boolean = False
    Public Property AutoAsignar() As Boolean
        Get
            Return mAutoAsignar
        End Get
        Set(ByVal value As Boolean)
            mAutoAsignar = value
        End Set
    End Property

#Region "DataSourceColumnReading"
    '//Metodos para leer en todo momento el campo cantidad del objeto desde donde se gestionan los numeros de serie
    Private Sub DataSourceColumnReading(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs)
        If e.Column.Key = mDataSchema.Cantidad Then
            DataSourceColumnReading(e.Value)
        End If
        If e.Column.Key = mDataSchema.Cantidad2 Then
            DataSourceColumnReading(e.Value, True)
        End If
    End Sub

    Private Sub DataSourceColumnReading(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If mCurrentData.Grid.Columns.Contains(mDataSchema.Cantidad) Then
            DataSourceColumnReading(mCurrentData.Grid.GetValue(mDataSchema.Cantidad))
            If mCurrentData.Grid.Columns.Contains(mDataSchema.Cantidad2) Then DataSourceColumnReading(mCurrentData.Grid.GetValue(mDataSchema.Cantidad2), True)
        End If
    End Sub

    Private Sub DataSourceColumnReading(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)
        If mCurrentData.Grid.Columns.Contains(mDataSchema.Cantidad) Then
            DataSourceColumnReading(mCurrentData.Grid.GetValue(mDataSchema.Cantidad))
            If mCurrentData.Grid.Columns.Contains(mDataSchema.Cantidad2) Then DataSourceColumnReading(mCurrentData.Grid.GetValue(mDataSchema.Cantidad2), True)
        End If
    End Sub

    Private Sub DataSourceColumnReading(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs)
        If e.Column.Key = mDataSchema.Cantidad Then
            DataSourceColumnReading(e.Value)
        End If
        If e.Column.Key = mDataSchema.Cantidad2 Then
            DataSourceColumnReading(e.Value, True)
        End If
    End Sub

    Private Sub DataSourceColumnReading(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            If mCurrentData.Grid.Columns.Contains(mDataSchema.Cantidad) Then
                DataSourceColumnReading(mCurrentData.Grid.GetValue(mDataSchema.Cantidad))
                If mCurrentData.Grid.Columns.Contains(mDataSchema.Cantidad2) Then DataSourceColumnReading(mCurrentData.Grid.GetValue(mDataSchema.Cantidad2), True)
            End If
        End If
    End Sub

    Private Sub DataSourceColumnReading(ByVal Value As Object, Optional ByVal IsValue2 As Boolean = False)
        Dim ex2 As Exception = Nothing

        RemoveHandler mCurrentData.Grid.EditingCell, AddressOf DataSourceColumnReading
        RemoveHandler mCurrentData.Grid.KeyDown, AddressOf DataSourceColumnReading
        RemoveHandler mCurrentData.Grid.CellValueChanged, AddressOf DataSourceColumnReading
        RemoveHandler mCurrentData.Grid.UpdatingCell, AddressOf DataSourceColumnReading
        RemoveHandler mCurrentData.Grid.MouseDown, AddressOf DataSourceColumnReading
        Try
            If Not IsValue2 Then
                If IsNumeric(Value) Then
                    mCurrentData.Cantidad = Value
                Else
                    mCurrentData.Cantidad = 0
                End If
            Else
                If IsNumeric(Value) Then
                    mCurrentData.Cantidad2 = Value
                Else
                    mCurrentData.Cantidad2 = 0
                End If
            End If

        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            ex2 = ex
        Finally
            AddHandler mCurrentData.Grid.EditingCell, AddressOf DataSourceColumnReading
            AddHandler mCurrentData.Grid.KeyDown, AddressOf DataSourceColumnReading
            AddHandler mCurrentData.Grid.CellValueChanged, AddressOf DataSourceColumnReading
            AddHandler mCurrentData.Grid.UpdatingCell, AddressOf DataSourceColumnReading
            AddHandler mCurrentData.Grid.MouseDown, AddressOf DataSourceColumnReading
        End Try
        If Not ex2 Is Nothing Then
            Throw ex2
        End If
    End Sub

    Private Sub DataSourceColumnReading(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs)
        If e.Column.ColumnName = mDataSchema.Cantidad OrElse e.Column.ColumnName = mDataSchema.Cantidad2 Then
            Dim ex2 As Exception
            Dim dt As DataTable = CType(sender, DataTable)

            RemoveHandler dt.ColumnChanging, AddressOf DataSourceColumnReading
            Try
                If e.Column.ColumnName = mDataSchema.Cantidad Then
                    If e.Row.RowState = DataRowState.Unchanged Then
                        mCurrentData.Cantidad = e.Row(e.Column)
                    Else
                        mCurrentData.Cantidad = e.ProposedValue
                    End If
                ElseIf e.Column.ColumnName = mDataSchema.Cantidad2 Then
                    If e.Row.RowState = DataRowState.Unchanged Then
                        mCurrentData.Cantidad2 = e.Row(e.Column)
                    Else
                        mCurrentData.Cantidad2 = e.ProposedValue
                    End If
                End If

            Catch ex As Exception
                ExpertisApp.GenerateMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.ProposedValue = e.Row(e.Column)
                ex2 = ex
            Finally
                AddHandler dt.ColumnChanging, AddressOf DataSourceColumnReading
            End Try
            If Not ex2 Is Nothing Then
                Throw ex2
            End If
        End If
    End Sub

    ''Al editar la línea (cantidad o merma) y acceder seguido al desglose, sucede que la pantalla no recibe bien la cantidad tecleada. Clickando físicamente fuera del grid y volviendo a darle, lo consigue.
    ''Se ha probado sin éxito a aceptar cambios de la línea, etc.
    Public Sub RefreshData()
        If (Not mCurrentData.Grid Is Nothing) Then
            DataSourceColumnReading(mCurrentData.Grid.GetValue(mDataSchema.Cantidad))
        Else
            'TODO - caso datatable?
        End If

    End Sub

#End Region

    Public ReadOnly Property LoteCollection() As LoteCollection
        Get
            Return mLoteCollection
        End Get
    End Property

    Public Shadows Function ShowDialog(ByVal lote As Lote) As DialogResult
        Try
            Dim res As DialogResult = DialogResult.None
            InitializeRangoPrecintas()

            If Not lote Is Nothing Then
                mLote = lote
                Me.Articulo = mLote.Articulo
                Me.Almacen = mLote.Almacen
                SettingDobleUnidad()
                ConfigurarGridPrecintasSeguimiento()

                If mIsBound Then
                    mLote.Cantidad = mCurrentData.Cantidad
                    If mAplicar2Ud Then mLote.Cantidad2 = mCurrentData.Cantidad2
                End If

                If mAcumular Then
                    mLoteCollection.StockActual(mLote)
                End If

                If mProponer Then
                    mLote.ProponerCantidades()
                ElseIf mRepartir Then
                    mLote.RepartirCantidades(mClaseMovimiento)
                End If

                Dim args1 As New ShowDialogEventArgs(mLote)
                RaiseEvent ShowLotesDialog(Me, args1)

                Me.LoadData()
                res = MyBase.ShowDialog()
                If res = DialogResult.OK Then
                    If mAcumular Then
                        mLoteCollection.Acumular(mLote)
                    End If
                    If Not mLote.Guardado Then
                        mLoteCollection.Add(mLote, mLote.ID)
                    End If
                End If
                RaiseEvent CloseLotesDialog(Me, New System.EventArgs)
                RaiseEvent ReturningData(Me, New ReturningLoteDataEventArgs(mLote, Seguimiento.Table, res))
            End If

            Me.DialogResult = res
            Return Me.DialogResult
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Shadows Function ShowDialog(ByVal ParamArray ID() As String) As DialogResult
        Try
            mIDS = ID
            Dim lt As Lote
            lt = mLoteCollection.Item(ID)
            If lt Is Nothing Then
                If mLoteCollection.HasPendingInserts Then
                    lt = mLoteCollection.TempInserts(lt)
                End If
                If lt Is Nothing Then
                    lt = Me.LoadLote(mCurrentData.IDArticulo, mCurrentData.IDAlmacen)
                    lt.SetID(ID)
                End If
            End If

            Return Me.ShowDialog(lt)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function LoadLote(ByVal IDArticulo As String, ByVal IDAlmacen As String) As Lote
        If Len(IDArticulo) = 0 Then
            Throw New Exception("El artículo no tiene un valor válido.")
        ElseIf Len(IDAlmacen) = 0 Then
            Throw New Exception("El almacén no tiene un valor válido.")
        Else
            Dim lt As Lote = New Lote(IDArticulo, IDAlmacen)

            If mAcumular Then
                '//Este datatable almacena todos los registros de tbArticuloAlmacenLote que se traen a presentacion.
                '//Se utiliza para calcular en todo momento el stock actual (metodo Acumular)
                If Not mLoteCollection.Cache Is Nothing Then
                    mLoteCollection.Cache.Clear()
                End If
                mLoteCollection.Cache = lt.DataTable.Clone
                mLoteCollection.Cache.DefaultView.Sort = "IDArticulo,IDAlmacen,Lote,Ubicacion"
                'End If
                If Not mLoteCollection.Cache Is Nothing Then
                    Dim i As Integer
                    For Each dr As DataRow In lt.DataTable.Rows
                        i = mLoteCollection.Cache.DefaultView.Find(New String(3) {dr("IDArticulo"), dr("IDAlmacen"), dr("Lote"), dr("Ubicacion")})
                        If i < 0 Then
                            mLoteCollection.Cache.Rows.Add(dr.ItemArray)
                        End If
                    Next
                End If
                mLoteCollection.StockActual(lt)
            End If

            Return lt
        End If
    End Function

    Protected Overrides Sub LoadData()
        If Not mLote Is Nothing Then
            Grid.DataSource = mLote.DataTable
            FiltrarLote()
        End If
        CrearTotales()
        ActualizarTotales()
        If mSeguimiento AndAlso EsSeguimiento Then GrdSeguimiento.DataSource = Seguimiento
    End Sub

    Protected Overrides Sub LoadLayout()
        Me.Label4.Visible = False
        Me.ntbStockFisico.Visible = False
        Me.Update()
    End Sub

    Protected Overrides Sub CrearTotales()
        Dim dt As New DataTable
        Dim dblStock, dblStock2 As Double

        dt.Columns.Add("StockActual", GetType(Double))
        dt.Columns.Add("CantidadAsignar", GetType(Double))
        dt.Columns.Add("CantidadAsignada", GetType(Double))
        dt.Columns.Add("Diferencia", GetType(Double))

        dt.Columns.Add("StockActual2", GetType(Double))
        dt.Columns.Add("CantidadAsignar2", GetType(Double))
        dt.Columns.Add("CantidadAsignada2", GetType(Double))
        dt.Columns.Add("Diferencia2", GetType(Double))


        Dim newrow As DataRow = dt.NewRow
        Dim dtGrid As DataTable = Grid.DataSource
        If dtGrid.Rows.Count > 0 Then
            dblStock = dtGrid.Compute("SUM(StockFisico)", Nothing)
            If MyBase.mAplicar2Ud Then dblStock2 = nz(dtGrid.Compute("SUM(StockFisico2)", Nothing), 0)
        End If
        newrow("StockActual") = dblStock
        newrow("CantidadAsignar") = mLote.Cantidad
        If mAplicar2Ud Then
            newrow("StockActual2") = dblStock2
            newrow("CantidadAsignar2") = CDbl(Nz(mLote.Cantidad2, 0))
        End If
        dt.Rows.Add(newrow)
        Totales.DataSource = dt
    End Sub

    Protected Overridable Sub ActualizarTotales()
        Dim dt As DataTable

        dt = CType(Totales.DataSource, DataTable)
        If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
            dt.Rows(0)("CantidadAsignada") = SumaCantidad()
            dt.Rows(0)("Diferencia") = dt.Rows(0)("CantidadAsignar") - dt.Rows(0)("CantidadAsignada")
            If mAplicar2Ud Then
                dt.Rows(0)("CantidadAsignada2") = SumaCantidad(True)
                dt.Rows(0)("Diferencia2") = Nz(dt.Rows(0)("CantidadAsignar2"), 0) - Nz(dt.Rows(0)("CantidadAsignada2"), 0)
            End If
        End If
    End Sub

    Private Sub Totales_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Totales.FormattingRow
        If Nz(e.Row.Cells("Diferencia").Value, 0) <> 0 Then
            e.Row.Cells("Diferencia").FormatStyle = Totales.FormatStyles("CantidadNoValida")
            If MyBase.mAplicar2Ud Then e.Row.Cells("Diferencia2").FormatStyle = Totales.FormatStyles("CantidadNoValida")
        End If
    End Sub

    Protected Function SumaCantidad(Optional ByVal SegundaUnidad As Boolean = False) As Double
        Dim dtGrid As DataTable = CType(Grid.DataSource, DataTable)
        Dim t As Double
        If dtGrid.Rows.Count > 0 Then
            t = (Aggregate c In dtGrid Where c.RowState <> DataRowState.Deleted Into Sum(CDec(c("Cantidad"))))
            If SegundaUnidad Then
                t = (Aggregate c In dtGrid Where c.RowState <> DataRowState.Deleted Into Sum(CDec(c("Cantidad2"))))
            End If
        End If
        Return t
    End Function

    Protected Overridable Function UbicacionesDisponibles(ByVal Almacen As String) As DataTable
        If Len(Almacen) > 0 Then
            Dim u As New AlmacenUbicacion
            Return u.Filter(New StringFilterItem("IDAlmacen", FilterOperator.Equal, Almacen))
        End If
        Return Nothing
    End Function

    Protected Overridable Function UbicacionPorDefecto(ByVal ubicaciones As DataTable) As String
        If Not ubicaciones Is Nothing AndAlso ubicaciones.Rows.Count > 0 Then
            Dim aux As DataTable = ubicaciones.Copy
            aux.DefaultView.RowFilter = "Predeterminada=1"
            If aux.DefaultView.Count > 0 Then
                Return aux.DefaultView(0).Row("IDUbicacion")
            End If
        End If

        Dim p As New Parametro
        Return p.UbicacionNoDefinida.IDUbicacion

    End Function

    Protected Overridable Sub LoteStockableUserDialog_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles MyBase.EditingCell
        Try
            Select Case e.Column.Key
                Case "Lote", "SeriePrecinta", "NDesdePrecinta", "NHastaPrecinta"
                    If Grid.Row = Grid.newTopRowPosition Then
                        e.Column.EditType = EditType.TextBox
                    Else
                        e.Cancel = True
                    End If
                Case "Ubicacion"
                    If Grid.Row <> Grid.newTopRowPosition OrElse (Grid.GetValue("StockFisico") <> vbNull And Nz(Grid.GetValue("StockFisico"), 0) <> 0) Then
                        e.Cancel = True
                    End If
                Case "Bloqueado"
                    If Grid.Row = Grid.newTopRowPosition Then
                        e.Cancel = True
                    End If
            End Select
        Catch ex As Exception
            e.Cancel = True
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Protected Overridable Sub LoteStockableUserDialog_GetNewRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.GetNewRowEventArgs) Handles MyBase.GetNewRow
        ActualizarTotales()
    End Sub

    Protected Overridable Sub LoteStockableUserDialog_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles MyBase.CellUpdated
        If e.Column.Key = "Cantidad" OrElse e.Column.Key = "Cantidad2" Then
            If mAplicar2Ud AndAlso Me.AsignarStockFisicoCero Then
                If e.Column.Key = "Cantidad" AndAlso Grid.GetValue(e.Column.Key) = 0 Then Grid.SetValue("Cantidad2", 0)
                If e.Column.Key = "Cantidad2" AndAlso Grid.GetValue(e.Column.Key) = 0 Then Grid.SetValue("Cantidad", 0)
            End If
            If mSeguimiento AndAlso EsSeguimiento Then
                Dim DblTotal As Double = Nz(Me.Grid.GetValue("Cantidad"), 0)
                Dim DblCant As Double
                If Not Me.GrdSeguimiento.DataSource Is Nothing Then
                    For Each DvRow As DataRowView In CType(Me.GrdSeguimiento.DataSource, DataView)
                        DblCant += DvRow("Cantidad")
                    Next
                End If
                Me.GrdSeguimiento.Columns("Cantidad").DefaultValue = DblTotal - DblCant
            End If

            ActualizarTotales()
            Me.QueryOnClose = True
        End If
    End Sub

    Protected Overridable Sub LoteStockableUserDialog_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordUpdated
        ActualizarTotales()
    End Sub

    Protected Overridable Sub LoteStockableUserDialog_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.AddingRecord
        Try
            If Not ValidarAddingPrecinta() Then
                e.Cancel = True
            ElseIf Length(Grid.GetValue("Lote")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("El Lote es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Length(Grid.GetValue("Ubicacion")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("La ubicación es obligatoria.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim dr As DataRow = ObtenerLoteUbicacionActual(Grid.GetValue("Lote"), Grid.GetValue("Ubicacion"))
                If Not dr Is Nothing Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("La relación Lote-Ubicación ya existe.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
            LoteRecordAdded(Grid.GetRow)
        Catch ex As Exception
            e.Cancel = True
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Protected Overridable Sub LoteRecordAdded(ByVal gridRow As GridEXRow)

    End Sub


    Protected Overridable Function ObtenerLoteUbicacionActual(ByVal lote As String, ByVal Ubicacion As String) As DataRow
        Dim dv As New DataView(CType(Grid.DataSource, DataTable))
        Return ObtenerLoteUbicacion(dv, lote, Ubicacion)
    End Function

    Protected Overridable Function ObtenerLoteUbicacionOriginal(ByVal lote As String, ByVal Ubicacion As String) As DataRow
        Dim dv As New DataView(mLote.DataTable)
        Return ObtenerLoteUbicacion(dv, lote, Ubicacion)
    End Function

    Protected Overridable Function ObtenerLoteUbicacion(ByVal dv As DataView, ByVal lote As String, ByVal Ubicacion As String) As DataRow
        Dim f As New Filter
        f.Add(New StringFilterItem("Lote", FilterOperator.Equal, lote))
        f.Add(New StringFilterItem("Ubicacion", FilterOperator.Equal, Ubicacion))
        dv.RowFilter = f.Compose(New AdoFilterComposer)
        If dv.Count Then
            Return dv(0).Row
        End If
    End Function

    Protected Overridable Sub LoteStockableUserDialog_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordsDeleted
        ActualizarTotales()
    End Sub

    Protected Overridable Sub LoteStockableUserDialog_RowEditCanceled(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles MyBase.RowEditCanceled
        ActualizarTotales()
    End Sub

    Protected Overridable Sub LoteStockableUserDialog_DeletingRecords(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.DeletingRecords
        Try
            '//Solo se pueden eliminar lotes introducidos en esta sesion de mantenimiento
            Dim dr As DataRow = ObtenerLoteUbicacionActual(Grid.GetRow.Cells("Lote").Value, Grid.GetRow.Cells("Ubicacion").Value)
            If Not dr Is Nothing Then
                If dr.RowState <> DataRowState.Added Then
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            e.Cancel = True
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Protected Overridable Sub LoteStockableUserDialog_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles MyBase.UpdatingCell
        Try
            Select Case e.Column.Key
                Case "Cantidad"
                    If Not IsNumeric(e.Value) Then
                        e.Value = e.InitialValue
                    End If
                    If e.Value > 0 And Grid.GetValue("Bloqueado") And mClaseMovimiento = [Shared].ClaseMovimiento.Salida Then
                        e.Cancel = True
                        ExpertisApp.GenerateMessage("El lote está bloqueado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        If e.Value > 0 And mClaseMovimiento = [Shared].ClaseMovimiento.Salida Then
                            If e.Value > Nz(Grid.GetValue("StockFisico"), 0) Then
                                e.Cancel = True
                                ExpertisApp.GenerateMessage("No hay stock suficiente.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        ElseIf e.Value < 0 And mClaseMovimiento = [Shared].ClaseMovimiento.Entrada Then
                            If Abs(e.Value) > Nz(Grid.GetValue("StockFisico"), 0) Then
                                e.Cancel = True
                                ExpertisApp.GenerateMessage("No hay stock suficiente.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        End If
                    End If
                Case "Bloqueado"
                    If e.Value Then
                        Grid.GetRow.Cells("Cantidad").Value = 0
                    End If
            End Select
        Catch ex As Exception
            e.Cancel = True
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Protected Overridable Sub LoteStockableUserDialog_OkButtonClick(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.OkButtonClick
        Dim dttLotes As DataTable = GetDatatableLotes()
        If Not ValidarResultado(dttLotes) Then
            e.Cancel = True
        Else
            mLote.DataTable = dttLotes
            mLote.DataTable.AcceptChanges()
            If mEsSeguimiento AndAlso mSeguimiento Then Seguimiento.Table.AcceptChanges()
        End If
    End Sub

    Protected Overridable Function GetDatatableLotes() As DataTable
        If (Not EsSalidaPrecinta) Then Return CType(Grid.DataSource, DataTable).Copy()

        'en caso de ser salida CON RANGOS de precinta, el grid es algo distinto
        Return GetDatatableLotesPrecintas()
    End Function

    Public Overridable Function GetDatatableSeguimiento() As DataTable
        If mSeguimiento Then
            Return Seguimiento.Table
        End If
    End Function

    Protected Overridable Function ValidarResultado(ByVal dttLotes As DataTable) As Boolean
        If Not (AutoAsignar) Then
            If SumaCantidad() <> mLote.Cantidad OrElse (mAplicar2Ud AndAlso SumaCantidad(True) <> mLote.Cantidad2) Then
                ExpertisApp.GenerateMessage("La cantidad asignada debe ser igual a la cantidad a asignar.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
        Else
            mLote.Cantidad = SumaCantidad()
        End If
        
        If (EsPrecinta) Then
            If Not ValidarPrecinta() Then
                ExpertisApp.GenerateMessage("El rango de valores de la precinta no coincide con la cantidad.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

            If (EsSalidaPrecinta) Then
                If Not ValidarSalidaPrecinta(dttLotes) Then
                    ExpertisApp.GenerateMessage("El desglose de precintas indicado ya está siendo utilizado. La operación no puede continuar.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If
            End If
        ElseIf mEsSeguimiento AndAlso mSeguimiento Then
            Dim DtSeguimiento As DataTable = CType(Me.GrdSeguimiento.DataSource, DataView).Table
            If mSeguimientoObligatorio Then
                'Comprobar desglose de seguimiento con los lotes
                For Each Dr As DataRow In dttLotes.Select
                    If Dr.RowState = DataRowState.Modified OrElse Dr.RowState = DataRowState.Added Then
                        If Dr("Cantidad") <> 0 Then
                            Dim DrFind() As DataRow = DtSeguimiento.Select("LoteRel = '" & Dr("Lote") & "' AND Ubicacion = '" & Dr("Ubicacion") & "' AND ID = " & mIDS(0))
                            If DrFind.Length <= 0 Then
                                ExpertisApp.GenerateMessage("No se ha hecho el desglose de seguimiento para el Lote |.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Dr("Lote"))
                                Return False
                            Else
                                Dim DblTotal As Double = 0
                                For Each DrCant As DataRow In DrFind
                                    DblTotal += DrCant("Cantidad")
                                Next
                                If DblTotal > Dr("Cantidad") Then
                                    ExpertisApp.GenerateMessage("Se ha desglosado mas cantidad del seguimiento para el lote |.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Dr("Lote"))
                                    Return False
                                ElseIf DblTotal < Dr("Cantidad") Then
                                    ExpertisApp.GenerateMessage("No se ha desglosado toda cantidad del seguimiento para el lote |.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Dr("Lote"))
                                    Return False
                                End If
                            End If
                        End If
                    End If
                Next
            Else
                For Each Dr As DataRow In dttLotes.Select
                    If Dr.RowState = DataRowState.Modified OrElse Dr.RowState = DataRowState.Added Then
                        If Dr("Cantidad") <> 0 Then
                            Dim DrFind() As DataRow = DtSeguimiento.Select("LoteRel = '" & Dr("Lote") & "'")
                            If DrFind.Length > 0 Then
                                Dim DblTotal As Double = 0
                                For Each DrCant As DataRow In DrFind
                                    DblTotal += DrCant("Cantidad")
                                Next
                                If DblTotal > Dr("Cantidad") OrElse DblTotal < Dr("Cantidad") Then
                                    ExpertisApp.GenerateMessage("No se ha desglosado toda la cantidad del seguimiento para el lote |.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Dr("Lote"))
                                    Return False
                                End If
                            End If
                        End If
                    End If
                Next
            End If
        End If
        Return True
    End Function

    Protected Overridable Sub LoteStockableUserDialog_CancelButtonClick(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.CancelButtonClick
        If Not Grid.DataSource Is Nothing Then
            mLote.DataTable = CType(Grid.DataSource, DataTable).Copy
            mLote.DataTable.RejectChanges()

            If mSeguimiento Then Seguimiento.Table.RejectChanges()
        End If
    End Sub

    Protected Overridable Sub LoteStockableUserDialog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            MyBase.SettingDobleUnidad()
            Me.chkMostrarLotesStockCero.Location = New System.Drawing.Point(647, 11)
            If Grid.AllowAddNew = InheritableBoolean.True Then
                Me.chkMostrarLotesStockCero.Checked = (Me.ClaseMovimiento = [Shared].ClaseMovimiento.Entrada)

                Grid.RootTable.Columns("IDArticulo").DefaultValue = mLote.Articulo
                Grid.RootTable.Columns("IDAlmacen").DefaultValue = mLote.Almacen
                Grid.RootTable.Columns("FechaUltimaEntrada").DefaultValue = Today
                Grid.RootTable.Columns("StockFisico").DefaultValue = 0
                Grid.RootTable.Columns("Bloqueado").DefaultValue = False

                Dim ubicaciones As DataTable = UbicacionesDisponibles(mLote.Almacen)
                Grid.RootTable.Columns("Ubicacion").DropDown.SetDataBinding(ubicaciones, String.Empty)

                If Len(mValorPorDefectoUbicacion) = 0 Then
                    mValorPorDefectoUbicacion = UbicacionPorDefecto(ubicaciones)
                End If

                '//Si hay valores por defecto y corresponden a un lote que ya existe, 
                '//se busca y asigna la cantidad de manera automatica.
                Dim cantidadAsignada As Boolean
                If Len(mValorPorDefectoLote) > 0 And Len(mValorPorDefectoUbicacion) > 0 Then
                    If Grid.RecordCount > 0 Then
                        Dim dv As New DataView(CType(Grid.DataSource, DataTable))
                        Dim f As New Filter
                        f.Add(New StringFilterItem("Lote", mValorPorDefectoLote))
                        f.Add(New StringFilterItem("Ubicacion", mValorPorDefectoUbicacion))
                        dv.RowFilter = f.Compose(New AdoFilterComposer)
                        If dv.Count > 0 Then
                            dv(0).Row("Cantidad") = mValorPorDefectoCantidad
                            If mAplicar2Ud Then dv(0).Row("Cantidad2") = mValorPorDefectoCantidad2
                            cantidadAsignada = True
                        End If
                    End If
                End If

                If cantidadAsignada Then
                    ActualizarTotales()
                Else
                    Grid.RootTable.Columns("Lote").DefaultValue = mValorPorDefectoLote
                    Grid.RootTable.Columns("Ubicacion").DefaultValue = mValorPorDefectoUbicacion
                    Grid.RootTable.Columns("Cantidad").DefaultValue = mValorPorDefectoCantidad
                    If mAplicar2Ud Then Grid.RootTable.Columns("Cantidad2").DefaultValue = mValorPorDefectoCantidad2
                    Grid.MoveToNewRecord()
                    '//Si todos los campos obligatorios tienen valor por defecto se prepara 
                    '//la linea de insercion para actualizarla de la manera mas rapida.
                    If mValorPorDefectoCantidad <> 0 And Len(mValorPorDefectoLote) > 0 And Len(mValorPorDefectoUbicacion) > 0 Then
                        Grid.GetRow.Cells("Cantidad").Value = mValorPorDefectoCantidad
                    End If

                    '//Si no se hace lo siguiente hay problemas en la contabilizacion de los totales
                    Grid.RootTable.Columns("Cantidad").DefaultValue = 0

                    If mAplicar2Ud Then
                        If mValorPorDefectoCantidad2 <> 0 And Len(mValorPorDefectoLote) > 0 And Len(mValorPorDefectoUbicacion) > 0 Then
                            Grid.GetRow.Cells("Cantidad2").Value = mValorPorDefectoCantidad2
                        End If
                        Grid.RootTable.Columns("Cantidad2").DefaultValue = 0
                    End If
                End If
            End If
        End If

    End Sub

    Protected Overrides Function ProcessDialogKey(ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData
            Case Keys.Decimal
                If Not Grid.EditTextBox Is Nothing Then
                    Grid.EditTextBox.SelectedText = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator
                    Return True
                End If
            Case Else
                Return MyBase.ProcessDialogKey(keyData)
        End Select
    End Function

    Protected Overridable Sub LoteStockableUserDialog_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.RecordAdded
        ActualizarTotales()
    End Sub

    Protected Overridable Sub LoteStockableUserDialog_GenerarNLotesClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Me.GenerarNLotesClick
        Dim intMaxLength As Integer = 25  '//El Lote es VARCHAR(25)

        If Not CBool(Me.Grid.AllowAddNew) Then
            ExpertisApp.GenerateMessage("No se pueden añadir Lotes.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If Length(txtNumLotesGenerar.Text) > 0 AndAlso Not IsNumeric(txtNumLotesGenerar.Text) Then
            ExpertisApp.GenerateMessage("El Nº de Lotes a generar debe tener un valor numérico.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If Nz(txtNumLotesGenerar.Text, 0) = 0 Then
            ExpertisApp.GenerateMessage("Debe indicar la cantidad de Lotes a generar.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If Length(txtCodigo.Text & txtNumeracion.Value) > intMaxLength Then
            ExpertisApp.GenerateMessage("La codificación propuesta supera la longitud máxima permitida. Longitud máxima: " & intMaxLength, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim a As New ArticuloNSerie
            Dim cantidad As Double = txtNumLotesGenerar.Text

            Dim CampoUnitario As String
            If (cantidad = Nz(CType(Totales.DataSource, DataTable).Rows(0)("CantidadAsignar"), 0)) Then
                CampoUnitario = "Cantidad"
            ElseIf mAplicar2Ud AndAlso cantidad = Nz(CType(Totales.DataSource, DataTable).Rows(0)("CantidadAsignar2"), 0) Then
                CampoUnitario = "Cantidad2"
            End If

            If cantidad > 0 Then
                Dim datLotes As New ArticuloAlmacenLote.DataADDLoteAutomaticamente(IDArticulo.Text, IDAlmacen.Text, cantidad, _
                                                                                    txtCodigo.Text, txtNumeracion.Value, Grid.DataSource, CampoUnitario)
                Dim dtLotes As DataTable = ExpertisApp.ExecuteTask(Of ArticuloAlmacenLote.DataADDLoteAutomaticamente, DataTable)(AddressOf ArticuloAlmacenLote.ADDLoteAutomaticamente, datLotes)
                Dim fArtAlm As New Filter
                fArtAlm.Add(New StringFilterItem("IDArticulo", IDArticulo.Text))
                fArtAlm.Add(New StringFilterItem("IDAlmacen", IDAlmacen.Text))
                Dim fLote As New Filter

                If Grid.DataSource Is Nothing OrElse Grid.RowCount = 0 Then
                    Dim DtGrid As DataTable = dtLotes.Clone
                    Dim AAL As New ArticuloAlmacenLote
                    Dim dtLote As DataTable
                    For Each Dr As DataRow In dtLotes.Select
                        fLote.Clear()
                        fLote.Add(fArtAlm)
                        fLote.Add(New StringFilterItem("Lote", Dr("Lote")))
                        dtLote = AAL.Filter(fLote)
                        If Not dtLote Is Nothing AndAlso dtLote.Rows.Count > 0 Then
                            ExpertisApp.GenerateMessage("El Lote '|' ya existe en el listado de Lotes.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Dr("Lote"))
                        Else
                            DtGrid.Rows.Add(Dr.ItemArray)
                        End If
                    Next
                    Grid.DataSource = DtGrid
                ElseIf Not dtLotes Is Nothing AndAlso dtLotes.Rows.Count > 0 Then
                    Dim dtGrid As DataTable = Grid.DataSource
                    Dim AAL As New ArticuloAlmacenLote
                    For Each drLote As DataRow In dtLotes.Rows
                        Dim dv As New DataView(dtGrid.Copy)
                        fLote.Clear()
                        fLote.Add(fArtAlm)
                        fLote.Add(New StringFilterItem("Lote", drLote("Lote")))
                        dv.RowFilter = fLote.Compose(New AdoFilterComposer)
                        If dv.Count = 0 Then
                            Dim dtLote As DataTable = AAL.Filter(fLote)
                            If Not dtLote Is Nothing AndAlso dtLote.Rows.Count > 0 Then
                                ExpertisApp.GenerateMessage("El Lote '|' ya existe en el listado de Lotes.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, drLote("Lote"))
                            Else
                                dtGrid.Rows.Add(drLote.ItemArray)
                            End If
                        Else
                            ExpertisApp.GenerateMessage("El Lote '|' ya existe en la lista actual.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, drLote("Lote"))
                        End If
                    Next
                    Grid.DataSource = dtGrid
                End If
                ActualizarTotales()
            End If
        End If
    End Sub

#Region "Configuración Precintas"

    Private blnDesglosePrecintas As Boolean = False
    Public Property MostrarDesglosePrecintas() As Boolean
        Get
            Return blnDesglosePrecintas
        End Get
        Set(ByVal value As Boolean)
            blnDesglosePrecintas = value
        End Set
    End Property

    Private mEsPrecintas As Boolean = False
    Protected Property EsPrecinta() As Boolean
        Get
            Return mEsPrecintas
        End Get
        Set(ByVal value As Boolean)
            mEsPrecintas = value
        End Set
    End Property

    Protected ReadOnly Property EsEntradaPrecinta() As Boolean
        Get
            Return EsPrecinta AndAlso ClaseMovimiento = [Shared].ClaseMovimiento.Entrada
        End Get
    End Property

    Protected ReadOnly Property EsSalidaPrecinta() As Boolean
        Get
            Return EsPrecinta AndAlso ClaseMovimiento = [Shared].ClaseMovimiento.Salida
        End Get
    End Property

    Protected Overridable Sub SetLote()
        'El lote sólo se modificará en las entradas!
        If (EsEntradaPrecinta) Then
            Dim strLote As String = String.Empty
            With Grid
                .SetValue("Lote", String.Format("{0}{1}", .GetValue("SeriePrecinta") & String.Empty, Nz(.GetValue("NDesdePrecinta"), 0)))
            End With
        End If
    End Sub

    Protected Overridable Sub AjustesCantidad(ByVal key As String)
        Dim dblCantidad As Double = 0
        Select Case key
            Case "Cantidad"
                If EsEntradaPrecinta() Then
                    AjustesCantidadEntrada()
                End If
            Case "NDesdePrecinta"
                If (Nz(Grid.GetValue("NHastaPrecinta"), 0) > 0) Then
                    dblCantidad = Nz(Grid.GetValue("NHastaPrecinta"), 0) - Nz(Grid.GetValue("NDesdePrecinta"), 0) + 1
                    If (dblCantidad >= 0) Then Grid.SetValue("Cantidad", dblCantidad)
                ElseIf (Nz(Grid.GetValue("Cantidad"), 0) > 0) Then
                    dblCantidad = Nz(Grid.GetValue("Cantidad"), 0) + Nz(Grid.GetValue("NDesdePrecinta"), 0) - 1
                    If (dblCantidad >= 0) Then Grid.SetValue("NHastaPrecinta", dblCantidad)
                End If
            Case "NHastaPrecinta"
                If (Length(Grid.GetValue("NDesdePrecinta")) > 0) Then
                    dblCantidad = Nz(Grid.GetValue("NHastaPrecinta"), 0) - Nz(Grid.GetValue("NDesdePrecinta"), 0) + 1
                    If (dblCantidad >= 0) Then Grid.SetValue("Cantidad", dblCantidad)
                ElseIf (Length(Grid.GetValue("Cantidad")) > 0) Then
                    dblCantidad = Nz(Grid.GetValue("NHastaPrecinta"), 0) - Nz(Grid.GetValue("Cantidad"), 0) + 1
                    If (dblCantidad >= 0) Then Grid.SetValue("NDesdePrecinta", dblCantidad)
                End If
        End Select
    End Sub

    Protected Overridable Sub AjustesCantidadEntrada()
        If (Length(Grid.GetValue("Cantidad")) > 0) Then
            If (Length(Grid.GetValue("NDesdePrecinta")) > 0) Then
                Grid.SetValue("NHastaPrecinta", Nz(Grid.GetValue("Cantidad"), 0) + Nz(Grid.GetValue("NDesdePrecinta"), 0) - 1)
            ElseIf (Length(Grid.GetValue("NHastaPrecinta")) > 0) Then
                Dim dblTotal As Double = Nz(Grid.GetValue("NHastaPrecinta"), 0) - Nz(Grid.GetValue("Cantidad"), 0) + 1
                If (dblTotal >= 0) Then
                    Grid.SetValue("NDesdePrecinta", dblTotal)
                End If
            End If
        End If
    End Sub

    Protected Overridable Function ValidarPrecinta() As Boolean
        Dim dt As DataTable = Me.Grid.DataSource
        If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
            For Each dtrLinea As DataRow In dt.Rows
                If (EsEntradaPrecinta) Then
                    If (dtrLinea.RowState = DataRowState.Added) Then
                        If Nz(dtrLinea("Cantidad"), 0) <> (Nz(dtrLinea("NHastaPrecinta"), 0) - Nz(dtrLinea("NDesdePrecinta"), 0) + 1) Then
                            Return False
                        End If
                    End If
                End If
            Next
        End If
        Return True
    End Function

    Protected Overridable Function ValidarSalidaPrecinta(ByVal dttCheck As DataTable) As Boolean
        Dim stData As New StValidarDesglosePrecintas(dttCheck)
        Return ExpertisApp.ExecuteTask(Of StValidarDesglosePrecintas, Boolean)(AddressOf BdgVinoMaterialLote.ValidarDesglosePrecintasSalida, stData)
    End Function

    Protected Overridable Sub ConfigurarGridPrecintasSeguimiento()
        EsPrecinta = ExpertisApp.ExecuteTask(Of String, Boolean)(AddressOf Business.Negocio.Articulo.EsPrecinta, Articulo)
        Me.Grid.RootTable.Columns("SeriePrecinta").Visible = EsPrecinta
        Me.Grid.RootTable.Columns("NDesdePrecinta").Visible = EsPrecinta
        Me.Grid.RootTable.Columns("NHastaPrecinta").Visible = EsPrecinta

        Dim ClsParametro As New Parametro
        mSeguimiento = ClsParametro.BodegaSeguimiento
        mSeguimientoObligatorio = ClsParametro.BodegaSeguimientoObligatorio


        If Not EsPrecinta Or Not MostrarDesglosePrecintas Then
            If mSeguimiento AndAlso EsSeguimiento Then
                Me.Splitter1.Visible = True
                Me.PnlPrecintaSeguimiento.Visible = True
                Me.PnlPrecintaSeguimiento.Width = 379

                Me.gridRangoPrecintas.Visible = False
                Me.gridRangoPrecintas.Dock = DockStyle.None
                Me.gridRangoPrecintas.SendToBack()
                Me.Grid.RootTable.Columns("Cantidad").EditType = EditType.TextBox

                Me.GrdSeguimiento.Columns("ID").DefaultValue = mIDS(0)
                Me.GrdSeguimiento.Visible = True
                Me.GrdSeguimiento.Dock = DockStyle.Fill
                Me.GrdSeguimiento.BringToFront()

                'Carga de información de seguimiento de Precintas
                StDataSegPrec = New BdgHistoricoPrecintas.DataProcSegPrecRet
                StDataSegPrec = ExpertisApp.ExecuteTask(Of String, BdgHistoricoPrecintas.DataProcSegPrecRet)(AddressOf BdgHistoricoPrecintas.ProcesoSegPrecinta, Me.Articulo)
                If Length(StDataSegPrec.IDEtiqueta) > 0 Then
                    'Si tenemos etiqueta seguimiento precinta
                    Me.GrdSeguimiento.Columns("Codigo").Visible = True
                    Me.GrdSeguimiento.Columns("Codigo").DropDown.SetDataBinding(StDataSegPrec.DtLotes, Nothing)
                    Me.GrdSeguimiento.Columns("Codigo").EditType = EditType.MultiColumnDropDown
                    If StDataSegPrec.DtLotes.Rows.Count = 1 Then
                        Me.GrdSeguimiento.Columns("Codigo").DefaultValue = StDataSegPrec.DtLotes.Rows(0)("Codigo")
                        Me.GrdSeguimiento.Columns("IDArticulo").DefaultValue = StDataSegPrec.DtLotes.Rows(0)("IDArticulo")
                        Me.GrdSeguimiento.Columns("IDAlmacen").DefaultValue = StDataSegPrec.DtLotes.Rows(0)("IDAlmacen")
                        Me.GrdSeguimiento.Columns("Ubicacion").DefaultValue = StDataSegPrec.DtLotes.Rows(0)("Ubicacion")
                        Me.GrdSeguimiento.Columns("Lote").DefaultValue = StDataSegPrec.DtLotes.Rows(0)("Lote")
                    End If
                    Me.GrdSeguimiento.Columns("NDesde").DefaultValue = 0
                    Me.GrdSeguimiento.Columns("NHasta").DefaultValue = 0
                    Me.GrdSeguimiento.Columns("Cantidad").DefaultValue = 0
                Else
                    Me.GrdSeguimiento.Columns("Codigo").Visible = False
                    Me.GrdSeguimiento.Columns("Codigo").DefaultValue = String.Empty
                    Me.GrdSeguimiento.Columns("Codigo").EditType = EditType.NoEdit
                    Me.GrdSeguimiento.Columns("IDArticulo").DefaultValue = String.Empty
                    Me.GrdSeguimiento.Columns("IDAlmacen").DefaultValue = String.Empty
                    Me.GrdSeguimiento.Columns("Ubicacion").DefaultValue = String.Empty
                    Me.GrdSeguimiento.Columns("Lote").DefaultValue = String.Empty
                    Me.GrdSeguimiento.Columns("Codigo").DropDown.SetDataBinding(Nothing, String.Empty)
                End If
            Else
                Me.PnlPrecintaSeguimiento.Visible = False
                Me.Splitter1.Visible = False
                Me.PnlPrecintaSeguimiento.Width = 1
                Me.Grid.RootTable.Columns("Cantidad").EditType = EditType.TextBox
            End If
        ElseIf MostrarDesglosePrecintas Then
            Me.Splitter1.Visible = True
            Me.PnlPrecintaSeguimiento.Visible = True
            Me.PnlPrecintaSeguimiento.Width = 379

            Me.GrdSeguimiento.Visible = False
            Me.GrdSeguimiento.Dock = DockStyle.None
            Me.GrdSeguimiento.SendToBack()

            Me.gridRangoPrecintas.Dock = DockStyle.Fill
            Me.gridRangoPrecintas.BringToFront()
            Me.gridRangoPrecintas.Visible = True
            Me.gridRangoPrecintas.DataSource = RangoPrecintas
            Me.Grid.RootTable.Columns("Cantidad").EditType = EditType.NoEdit
            CargarRangosPrecintaOcupados()
        End If

        'If ClaseMovimiento = [Shared].ClaseMovimiento.Salida Then
        'añadirlas columnas extra si es necesario
        Dim dttPrecintas As DataTable = Me.mLote.DataTable
        If (Not dttPrecintas.Columns.Contains("NDesde")) Then dttPrecintas.Columns.Add("NDesde", GetType(Integer))
        If (Not dttPrecintas.Columns.Contains("NHasta")) Then dttPrecintas.Columns.Add("NHasta", GetType(Integer))
        'End If
    End Sub

    Protected Overridable Function ValidarAddingPrecinta() As Boolean
        If EsPrecinta AndAlso (Length(Grid.GetRow.Cells("SeriePrecinta").Value) = 0 _
                                    OrElse Length(Grid.GetRow.Cells("NDesdePrecinta").Value) = 0 OrElse Length(Grid.GetRow.Cells("NHastaPrecinta").Value) = 0) Then

            ExpertisApp.GenerateMessage("La precinta es obligatoria.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        Return True
    End Function

    Protected Overridable Sub LoteStockableUserDialog_CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Me.CellValueChanged
        Select Case e.Column.Key
            Case "SeriePrecinta", "NDesdePrecinta", "NHastaPrecinta", "Cantidad" ', "NHasta", "NDesde"
                AjustesCantidad(e.Column.Key)
                SetLote()
        End Select
    End Sub

#End Region

#Region "Rangos Precintas"

    Dim dvRangosPrecintas As DataView
    Protected ReadOnly Property RangoPrecintas() As DataView
        Get
            If dvRangosPrecintas Is Nothing Then
                InitializeRangoPrecintas()
            End If
            Return dvRangosPrecintas
        End Get
    End Property

    Protected Overridable Function InitializeRangoPrecintas() As DataView
        Dim dttResult As New DataTable()
        dttResult.Columns.Add("Lote", GetType(String))
        dttResult.Columns.Add("Ubicacion", GetType(String))
        dttResult.Columns.Add("NPrecintaDesde", GetType(Integer))
        dttResult.Columns.Add("NPrecintaHasta", GetType(Integer))
        dttResult.Columns.Add("Cantidad", GetType(Integer))
        dttResult.Columns.Add("Nuevo", GetType(Boolean))
        dvRangosPrecintas = New DataView(dttResult)
        Me.gridRangoPrecintas.DataSource = dvRangosPrecintas
    End Function

    Protected mEsSeguimiento As Boolean = False
    Public Property EsSeguimiento() As Boolean
        Get
            Return mEsSeguimiento
        End Get
        Set(ByVal value As Boolean)
            mEsSeguimiento = value
        End Set
    End Property

    Private Sub Grid_UpdatingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles Grid.UpdatingCell
        Select Case e.Column.Key
            Case "Cantidad"
                Dim DblTotal As Double = e.Value
                Dim DblCant As Double
                If Not Me.GrdSeguimiento.DataSource Is Nothing Then
                    For Each DvRow As DataRowView In CType(Me.GrdSeguimiento.DataSource, DataView)
                        DblCant += DvRow("Cantidad")
                    Next
                End If
                Me.GrdSeguimiento.Columns("Cantidad").DefaultValue = DblTotal - DblCant
                Me.GrdSeguimiento.Refetch()
        End Select
    End Sub

    Private Sub Grid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.DoubleClick
        If Not EsPrecinta Then
            Dim DtTotales As DataTable = Totales.DataSource
            If Grid.ColumnFromPoint.Key = "Cantidad" AndAlso DtTotales.Rows(0)("Diferencia") <> 0 Then
                If Me.Grid.GetValue("Cantidad") < Me.Grid.GetValue("StockFisico") Then
                    If DtTotales.Rows(0)("Diferencia") > Me.Grid.GetValue("StockFisico") Then
                        Me.Grid.SetValue("Cantidad", Math.Round(Me.Grid.GetValue("StockFisico"), 2))
                    Else : Me.Grid.SetValue("Cantidad", Math.Round(DtTotales.Rows(0)("Diferencia"), 2))
                    End If
                    ActualizarTotales()
                End If
            End If
        End If
    End Sub

    Protected Overridable Sub gridRangoPrecintas_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles gridRangoPrecintas.AddingRecord
        If (ValidarRangoPrecinta()) Then
            gridRangoPrecintas.SetValue("Nuevo", True)
            Dim dblNuevaCantidad As Double = Nz(gridRangoPrecintas.GetValue("Cantidad"), 0)
            Grid.SetValue("Cantidad", Nz(Grid.GetValue("Cantidad"), 0) + dblNuevaCantidad)

            Dim SelectedLote As String = Grid.GetValue("Lote") & String.Empty
            'Dim selected As Integer = Grid.Row
            CType(Grid.DataSource, DataTable).AcceptChanges()
            'Grid.Row = selected
            If Length(SelectedLote) > 0 Then
                Dim jFilter As New Janus.Windows.GridEX.GridEXFilterCondition
                jFilter.Clear()
                jFilter.AddCondition()
                jFilter.Conditions(0).Column = Grid.RootTable.Columns("Lote")
                jFilter.Conditions(0).ConditionOperator = Janus.Windows.GridEX.ConditionOperator.Equal
                jFilter.Conditions(0).Value1 = SelectedLote

                Grid.FindAll(jFilter)
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Protected Overridable Sub gridRangoPrecintas_CellEdited(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles gridRangoPrecintas.CellEdited
        If (e.Column.Key = "NPrecintaDesde" OrElse e.Column.Key = "NPrecintaHasta") Then
            If Length(gridRangoPrecintas.GetValue("NPrecintaHasta")) > 0 AndAlso Length(gridRangoPrecintas.GetValue("NPrecintaDesde")) > 0 Then
                Dim dblNuevaCantidad As Double = Nz(gridRangoPrecintas.GetValue("NPrecintaHasta"), 0) - Nz(gridRangoPrecintas.GetValue("NPrecintaDesde"), 0) + 1
                If (dblNuevaCantidad >= 0) Then
                    gridRangoPrecintas.SetValue("Cantidad", dblNuevaCantidad)
                End If
            End If
        End If
    End Sub

    Protected Overridable Function ValidarRangoPrecinta() As Boolean
        If Length(gridRangoPrecintas.GetValue("NPrecintaDesde")) = 0 OrElse Length(gridRangoPrecintas.GetValue("NPrecintaHasta")) = 0 Then
            'ExpertisApp.GenerateMessage("Debe establecer un rango de precintas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        'hay que validar que estén en el rango de la linea de lote
        If (gridRangoPrecintas.GetValue("NPrecintaDesde") < Grid.GetValue("NDesdePrecinta") OrElse _
                gridRangoPrecintas.GetValue("NPrecintaHasta") > Grid.GetValue("NHastaPrecinta")) Then
            'ExpertisApp.GenerateMessage("El rango establecido no es válido.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        'y salvo que sea una entrada, no coger rangos que ya estén actualmente cogidos en el grid

        If (ClaseMovimiento <> [Shared].ClaseMovimiento.Entrada) Then
            'el grid va a tener el rowfilter adecuado en cada caso así que no hay problema
            For Each dataRowView As DataRowView In RangoPrecintas
                If Length(dataRowView("NPrecintaDesde")) > 0 Then
                    If (gridRangoPrecintas.GetValue("NPrecintaDesde") >= dataRowView("NPrecintaDesde") And gridRangoPrecintas.GetValue("NPrecintaDesde") <= dataRowView("NPrecintaHasta")) Then
                        'ExpertisApp.GenerateMessage("El rango Desde ya está siendo utilizado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Return False
                    End If
                    If (gridRangoPrecintas.GetValue("NPrecintaHasta") >= dataRowView("NPrecintaDesde") And gridRangoPrecintas.GetValue("NPrecintaHasta") <= dataRowView("NPrecintaHasta")) Then
                        'ExpertisApp.GenerateMessage("El rango Hasta ya está siendo utilizado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Return False
                    End If
                End If
            Next
        End If

        Return True
    End Function

    Protected Overridable Sub gridRangoPrecintas_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles gridRangoPrecintas.EditingCell
        'If Length(e.Value) = 0 Then Return
        If gridRangoPrecintas.Row <> GridEX.newTopRowPosition Then
            e.Cancel = True
            Return
        End If
    End Sub

    Protected Overridable Sub gridRangoPrecintas_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridRangoPrecintas.GotFocus
        gridRangoPrecintas.Columns("Lote").DefaultValue = Grid.GetValue("Lote")
    End Sub

    Protected Overridable Sub Grid_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.SelectionChanged
        If Grid.Row <> Grid.newTopRowPosition And Length(Grid.GetValue("Lote")) Then
            Dim filter As New Filter
            filter.Add("Lote", Grid.GetValue("Lote"))
            If Length(Grid.GetValue("Ubicacion")) Then
                filter.Add("Ubicacion", Grid.GetValue("Ubicacion"))
            End If

            RangoPrecintas.RowFilter = filter.Compose(New AdoFilterComposer)

            If mSeguimiento AndAlso EsSeguimiento Then
                Dim FilSeg As New Filter
                FilSeg.Add("LoteRel", Grid.GetValue("Lote"))
                FilSeg.Add("Ubicacion", Grid.GetValue("Ubicacion"))
                Me.GrdSeguimiento.Columns("LoteRel").DefaultValue = Grid.GetValue("Lote")
                Me.GrdSeguimiento.Columns("Ubicacion").DefaultValue = Grid.GetValue("Ubicacion")
                Me.GrdSeguimiento.Columns("ID").DefaultValue = mIDS(0)
                FilSeg.Add("ID", FilterOperator.Equal, mIDS(0))
                Seguimiento.RowFilter = FilSeg.Compose(New AdoFilterComposer)
                Dim DblTotal As Double = Me.Grid.GetValue("Cantidad")
                Dim DblCant As Double
                If Not Me.GrdSeguimiento.DataSource Is Nothing Then
                    For Each DvRow As DataRowView In CType(Me.GrdSeguimiento.DataSource, DataView)
                        DblCant += DvRow("Cantidad")
                    Next
                End If
                Me.GrdSeguimiento.Columns("Cantidad").DefaultValue = DblTotal - DblCant
            End If
        Else
            RangoPrecintas.RowFilter = "1 = 2"
            Seguimiento.RowFilter = "1 = 2"
        End If
        Me.gridRangoPrecintas.Refetch()
    End Sub

    Protected Overridable Sub gridRangoPrecintas_DeletingRecord(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionCancelEventArgs) Handles gridRangoPrecintas.DeletingRecord
        If Not (Nz(gridRangoPrecintas.GetValue("Nuevo"), True)) Then
            ExpertisApp.GenerateMessage("No se puede eliminar el registro, tiene movimientos relacionados.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Cancel = True
            Return
        End If
        If (Nz(Grid.GetValue("Cantidad"), 0) > 0) Then
            Grid.SetValue("Cantidad", Grid.GetValue("Cantidad") - e.Row.DataRow("Cantidad"))
        End If
    End Sub

    Protected Overridable Function GetDatatableLotesPrecintas() As DataTable
        Dim dttOrigen As DataTable = CType(Grid.DataSource, DataTable)
        If RangoPrecintas Is Nothing Then Return dttOrigen.Copy
        RangoPrecintas.RowFilter = String.Empty
        If RangoPrecintas.Count = 0 Then Return dttOrigen.Copy

        Dim dttResult As DataTable = dttOrigen.Clone
        For Each dtrOrigen As DataRow In dttOrigen.Rows
            If (Nz(dtrOrigen("Cantidad"), 0) > 0) Then
                Dim f As New Filter
                f.Add(New StringFilterItem("Lote", dtrOrigen("Lote")))
                f.Add(New BooleanFilterItem("Nuevo", True))
                RangoPrecintas.RowFilter = f.Compose(New AdoFilterComposer)
                If (RangoPrecintas.Count > 0) Then
                    For Each dtrRango As DataRowView In RangoPrecintas
                        Dim dtrNueva As DataRow = dttResult.NewRow
                        dtrNueva("Lote") = dtrRango("Lote")
                        dtrNueva("SeriePrecinta") = dtrOrigen("SeriePrecinta")
                        dtrNueva("StockFisico") = dtrOrigen("StockFisico")
                        dtrNueva("StockFisico2") = dtrOrigen("StockFisico2")
                        dtrNueva("IDArticulo") = dtrOrigen("IDArticulo")
                        dtrNueva("IDAlmacen") = dtrOrigen("IDAlmacen")
                        dtrNueva("Ubicacion") = dtrOrigen("Ubicacion")
                        dtrNueva("FechaUltEntrada") = dtrOrigen("FechaUltEntrada")
                        dtrNueva("FechaCaducidad") = dtrOrigen("FechaCaducidad")
                        dtrNueva("Bloqueado") = dtrOrigen("Bloqueado")
                        dtrNueva("Observaciones") = dtrOrigen("Observaciones")

                        dtrNueva("NDesdePrecinta") = dtrOrigen("NDesdePrecinta")
                        dtrNueva("NHastaPrecinta") = dtrOrigen("NHastaPrecinta")

                        dtrNueva("NDesde") = dtrRango("NPrecintaDesde")
                        dtrNueva("NHasta") = dtrRango("NPrecintaHasta")
                        dtrNueva("Cantidad") = dtrRango("Cantidad")
                        'dtrNueva("Cantidad2") = dtrRango("Cantidad2")

                        dttResult.Rows.Add(dtrNueva)
                    Next
                End If
                RangoPrecintas.RowFilter = String.Empty
            End If
        Next
        Return dttResult

    End Function

    Protected Overridable Sub CargarRangosPrecintaOcupados()
        Dim data As New BdgHistoricoPrecintas.stObtenerRangosPrecinta(Articulo, Almacen)
        Dim dttRangosLibres As DataTable = ExpertisApp.ExecuteTask(Of BdgHistoricoPrecintas.stObtenerRangosPrecinta, DataTable) _
                                            (AddressOf BdgHistoricoPrecintas.ObtenerRangosOcupadosPrecinta, data)
        InitializeRangoPrecintas()
        For Each dr As DataRow In dttRangosLibres.Rows
            Dim drn As DataRow = RangoPrecintas.Table.NewRow
            drn("Lote") = dr("Lote")
            drn("NPrecintaDesde") = dr("NDesdePrecinta")
            drn("NPrecintaHasta") = dr("NHastaPrecinta")
            drn("Cantidad") = dr("StockFisico")
            drn("Nuevo") = False
            RangoPrecintas.Table.Rows.Add(drn)
        Next
        RangoPrecintas.Table.AcceptChanges()
    End Sub

#End Region

#Region "Seguimiento"

    Dim dvSeguimiento As DataView
    Protected ReadOnly Property Seguimiento() As DataView
        Get
            If dvSeguimiento Is Nothing Then
                InitializeSeguimiento()
            End If
            Return dvSeguimiento
        End Get
    End Property

    Protected Overridable Function InitializeSeguimiento() As DataView
        Dim dttResult As New DataTable()
        dttResult.Columns.Add("ID", GetType(Integer))
        dttResult.Columns.Add("Codigo", GetType(String))
        dttResult.Columns.Add("Lote", GetType(String))
        dttResult.Columns.Add("LoteRel", GetType(String))
        dttResult.Columns.Add("IDArticulo", GetType(String))
        dttResult.Columns.Add("IDAlmacen", GetType(String))
        dttResult.Columns.Add("Ubicacion", GetType(String))
        dttResult.Columns.Add("NDesde", GetType(Integer))
        dttResult.Columns.Add("NHasta", GetType(Integer))
        dttResult.Columns.Add("Cantidad", GetType(Double))
        dttResult.Columns.Add("NPallet", GetType(String))
        dvSeguimiento = New DataView(dttResult)
        Me.GrdSeguimiento.DataSource = dvSeguimiento
    End Function

    Public Sub ClearSeguimiento()
        Me.Seguimiento.Table.Rows.Clear()
        Me.Seguimiento.RowFilter = String.Empty
    End Sub

    Private Sub GrdSeguimiento_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GrdSeguimiento.AddingRecord
        If Length(StDataSegPrec.IDEtiqueta) > 0 AndAlso Length(Me.GrdSeguimiento.GetValue("Codigo")) = 0 Then
            ExpertisApp.GenerateMessage("No se ha seleccionado un Almacén - Lote.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
        If Length(Me.GrdSeguimiento.GetValue("NDesde")) = 0 OrElse Length(Me.GrdSeguimiento.GetValue("NHasta")) = 0 Then
            ExpertisApp.GenerateMessage("No se ha establecido un rango de Etiquetas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
        If Nz(Me.GrdSeguimiento.GetValue("Cantidad"), 0) = 0 Then
            ExpertisApp.GenerateMessage("No se  puede introducir un registro con Cantidad 0.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
    End Sub

    Private Sub GrdSeguimiento_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdSeguimiento.CellUpdated
        Select Case e.Column.Key
            Case "Codigo", "Cantidad"
                If Length(Me.GrdSeguimiento.GetValue("Codigo")) > 0 Then
                    Dim DrFindLote() As DataRow = StDataSegPrec.DtLotes.Select("Codigo = '" & Me.GrdSeguimiento.GetValue("Codigo") & "'")
                    If DrFindLote.Length > 0 Then
                        Me.GrdSeguimiento.SetValue("IDArticulo", DrFindLote(0)("IDArticulo"))
                        Me.GrdSeguimiento.SetValue("IDAlmacen", DrFindLote(0)("IDAlmacen"))
                        Me.GrdSeguimiento.SetValue("Ubicacion", DrFindLote(0)("Ubicacion"))
                        Me.GrdSeguimiento.SetValue("Lote", DrFindLote(0)("Lote"))
                    End If
                End If
        End Select
    End Sub

    Protected Overridable Sub GrdSeguimiento_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles GrdSeguimiento.UpdatingCell
        Dim seg As New SeguimientoPrecintas
        seg.Seguimiento_UpdatingCell(StDataSegPrec.IDEtiqueta, StDataSegPrec.Factor, Me.GrdSeguimiento, e)
    End Sub


    Private Sub GrdSeguimiento_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GrdSeguimiento.EditingCell
        If Me.GrdSeguimiento.Row <> Me.GrdSeguimiento.newTopRowPosition Then
            Select Case e.Column.Key
                Case "NDesde", "NHasta"
                    e.Cancel = True
            End Select
        End If
    End Sub

    Protected Overridable Sub GrdSeguimiento_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdSeguimiento.RecordUpdated
        Me.Grid.SetValue("Cantidad", CType(Me.GrdSeguimiento.DataSource, DataView).ToTable.Compute("SUM(Cantidad)", String.Empty))
        Dim DblTotal As Double = Me.Grid.GetValue("Cantidad")
        Dim DblCant As Double = 0
        Dim DrFind() As DataRow = CType(Me.GrdSeguimiento.DataSource, DataView).Table.Select("LoteRel = '" & Me.GrdSeguimiento.GetValue("LoteRel") & "'")
        For Each DrCant As DataRow In DrFind
            DblCant += DrCant("Cantidad")
        Next
        Me.GrdSeguimiento.Columns("Cantidad").DefaultValue = DblTotal - DblCant
        Me.GrdSeguimiento.Refresh()
    End Sub

    Private Sub GrdSeguimiento_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdSeguimiento.RecordAdded, GrdSeguimiento.RecordsDeleted
        If Not Me.GrdSeguimiento.DataSource Is Nothing AndAlso Me.GrdSeguimiento.RecordCount > 0 Then
            Me.Grid.SetValue("Cantidad", CType(Me.GrdSeguimiento.DataSource, DataView).ToTable.Compute("SUM(Cantidad)", String.Empty))
        End If
    End Sub

#End Region

End Class

Public Class SeguimientoPrecintas

    Public Overridable Sub Seguimiento_UpdatingCell(ByVal IDEtiqueta As String, ByVal Factor As Double, ByVal GrdSeguimiento As Grid, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs)
        Select Case e.Column.Key
            Case "NDesde", "NHasta"
                GrdSeguimiento.SetValue(e.Column.Key, e.Value)
                If Length(IDEtiqueta) > 0 Then
                    If Length(IDEtiqueta) = 0 Then
                        ExpertisApp.GenerateMessage("Debe indicar el artículo a utilizar.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        e.Cancel = True
                        Exit Sub
                    End If
                    If Length(GrdSeguimiento.GetValue("IDAlmacen")) = 0 Then
                        ExpertisApp.GenerateMessage("Debe indicar el Almacén.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        e.Cancel = True
                        Exit Sub
                    End If
                    If Length(GrdSeguimiento.GetValue("Lote")) = 0 Then
                        ExpertisApp.GenerateMessage("Debe indicar el Lote.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        e.Cancel = True
                        Exit Sub
                    End If
                    If Length(GrdSeguimiento.GetValue("Ubicacion")) = 0 Then
                        ExpertisApp.GenerateMessage("Debe indicar la Ubicación.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        e.Cancel = True
                        Exit Sub
                    End If

                    Dim IntNDesde, IntNHasta As Integer
                    If (GrdSeguimiento.GetValue("Cantidad")) <> 0 Then
                        Select Case e.Column.Key
                            Case "NDesde"
                                IntNDesde = Nz(GrdSeguimiento.GetValue("NDesde"), 0)
                                IntNHasta = CalcularNHasta(GrdSeguimiento, Factor)
                            Case "NHasta"
                                IntNHasta = Nz(GrdSeguimiento.GetValue("NHasta"), 0)
                                IntNDesde = CalcularNDesde(GrdSeguimiento, Factor)
                        End Select
                    End If

                    If IntNDesde <> 0 AndAlso IntNHasta <> 0 Then
                        Dim StDataExists As New BdgHistoricoPrecintas.DataExistsEtiSeg(IDEtiqueta, GrdSeguimiento.GetValue("IDAlmacen"), GrdSeguimiento.GetValue("Lote"), GrdSeguimiento.GetValue("Ubicacion"), IntNDesde, IntNHasta, (Math.Sign(GrdSeguimiento.GetValue("Cantidad")) = -1))
                        If Not ExpertisApp.ExecuteTask(Of BdgHistoricoPrecintas.DataExistsEtiSeg, Boolean)(AddressOf BdgHistoricoPrecintas.EtiquetaSeguimientoDisponible, StDataExists) Then
                            ExpertisApp.GenerateMessage("Ya está en uso el rango de etiquetas introducidos. Rango [{0} - {1}]", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, IntNDesde, IntNHasta)
                            e.Cancel = True
                        End If

                        If Not e.Cancel Then
                            Dim FilRango As New Filter
                            'If GrdSeguimiento.Columns.Contains("LoteRel") AndAlso Length(GrdSeguimiento.GetValue("LoteRel")) > 0 Then
                            ' FilRango.Add("LoteRel", FilterOperator.Equal, GrdSeguimiento.GetValue("LoteRel"))
                            'Else
                            If GrdSeguimiento.Columns.Contains("IDLineaLote") AndAlso Nz(GrdSeguimiento.GetValue("IDLineaLote"), 0) <> 0 Then
                                FilRango.Add("IDLineaLote", FilterOperator.Equal, GrdSeguimiento.GetValue("IDLineaLote"))
                            End If
                            Dim FilRangoDH As New Filter(FilterUnionOperator.Or)
                            FilRangoDH.Add(New BetweenFilterItem("NDesde", IntNDesde, IntNHasta, FilterType.Numeric))
                            FilRangoDH.Add(New BetweenFilterItem("NHasta", IntNDesde, IntNHasta, FilterType.Numeric))
                            FilRango.Add(FilRangoDH)

                            Dim DrFindRango() As DataRow = CType(GrdSeguimiento.DataSource, DataView).Table.Select(FilRango.Compose(New AdoFilterComposer))
                            If DrFindRango.Length > 0 Then
                                ExpertisApp.GenerateMessage("Ya existe el rango introducido en los datos actuales.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                e.Cancel = True
                            End If
                            If Not e.Cancel Then
                                GrdSeguimiento.SetValue("NHasta", IntNHasta)
                                GrdSeguimiento.SetValue("NDesde", IntNDesde)
                            End If
                        End If
                    End If

                Else
                    Dim IntCantidad As Integer = GrdSeguimiento.GetValue("Cantidad")
                    Dim IntNDesde, IntNHasta As Integer
                    Select Case e.Column.Key
                        Case "NDesde"
                            IntNHasta = CalcularNHasta(GrdSeguimiento, Factor)
                            IntNDesde = Nz(GrdSeguimiento.GetValue("NDesde"), 0)
                        Case "NHasta"
                            IntNDesde = CalcularNDesde(GrdSeguimiento, Factor)
                            IntNHasta = Nz(GrdSeguimiento.GetValue("NHasta"), 0)
                    End Select
                    GrdSeguimiento.SetValue("NHasta", IntNHasta)
                    GrdSeguimiento.SetValue("NDesde", IntNDesde)
                End If
            Case "Cantidad"
                If e.Value = 0 Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("No se  puede introducir un registro con Cantidad 0.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                GrdSeguimiento.SetValue(e.Column.Key, e.Value)
                Dim SignoCantidad As Integer = Math.Sign(GrdSeguimiento.GetValue("Cantidad"))
                If Length((GrdSeguimiento.GetValue("Cantidad"))) > 0 AndAlso Length(GrdSeguimiento.GetValue("NDesde")) > 0 AndAlso GrdSeguimiento.GetValue("NDesde") <> 0 Then
                    GrdSeguimiento.SetValue("NHasta", CalcularNHasta(GrdSeguimiento, Factor))
                ElseIf Length((GrdSeguimiento.GetValue("Cantidad"))) > 0 AndAlso Length(GrdSeguimiento.GetValue("NHasta")) > 0 AndAlso GrdSeguimiento.GetValue("NHasta") <> 0 Then
                    GrdSeguimiento.SetValue("NDesde", CalcularNDesde(GrdSeguimiento, Factor))
                End If
        End Select
    End Sub

    Public Overridable Function CalcularNDesde(ByVal GrdSeguimiento As Grid, ByVal Factor As Double) As Double
        If (GrdSeguimiento.GetValue("Cantidad")) <> 0 Then
            Dim SignoCantidad As Integer = Math.Sign(GrdSeguimiento.GetValue("Cantidad"))
            Return (Nz(GrdSeguimiento.GetValue("NHasta"), 0) - (SignoCantidad * Nz(GrdSeguimiento.GetValue("Cantidad"), 0) * Factor)) + 1
        End If
    End Function

    Public Overridable Function CalcularNHasta(ByVal GrdSeguimiento As Grid, ByVal Factor As Double) As Double
        If (GrdSeguimiento.GetValue("Cantidad")) <> 0 Then
            Dim SignoCantidad As Integer = Math.Sign(GrdSeguimiento.GetValue("Cantidad"))
            Return (Nz(GrdSeguimiento.GetValue("NDesde"), 0) + (SignoCantidad * Nz(GrdSeguimiento.GetValue("Cantidad"), 0) * Factor)) - 1
        End If
    End Function

End Class