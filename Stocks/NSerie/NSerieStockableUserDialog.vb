Option Explicit On 
Option Compare Text

Imports Solmicro.Expertis.Business.Mnto
Imports System.Drawing

Public Class NSerieStockableUserDialog
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    Public NotInheritable Class DataSourceSchema
        Private mIDArticulo As String = "IDArticulo"
        Private mIDAlmacen As String = "IDAlmacen"
        Private mNSerie As String = "Lote"              '//por defecto lote porque se utiliza el mismo campo que en la gestion de lotes
        Private mCantidad As String = "Cantidad"

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
                Return mNSerie
            End Get
            Set(ByVal Value As String)
                mNSerie = Value
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

        Friend Sub New()
        End Sub
    End Class

    Protected Shadows Class CurrentData
        Private mIDArticulo As String
        Private mIDAlmacen As String
        Private mLote As String
        Private mCantidad As Double
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

        Public Property Cantidad() As Double
            Get
                Return mCantidad
            End Get
            Set(ByVal Value As Double)
                mCantidad = Value
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

    Private mIDOperario As String
    Private mQueryOnClose As Boolean
    Private mEstados As DataTable
    Private mOperarios As DataTable
    Private mValorPorDefectoEstado As String
    Private mFiltroEstado As Filter
    Private mUsarColumnaSeleccion As Boolean
    Private mValorPorDefectoSeleccionEstado As String
    Private mModoRecuentoSalidas As [Shared].ModoRecuentoSalidas
    Private mDataSource As Object
    Private mDataSchema As DataSourceSchema
    Protected mClaseMovimiento As [Shared].ClaseMovimiento
    Private mFiltro As Filter
    Private mSerie As NSerie
    Private mSerieCollection As NSerieCollection
    Private mCallDatabase As Boolean
    Private mIsBound As Boolean
    Private mFiltroPorAlmacen As Boolean = True
    Private mAjusteInv As Boolean = False
    Private MDtGrid As DataTable
    'Protected MBlnUpdate As Boolean
    Protected mGestionSerieConActivo As Boolean

    Protected mCurrentData As CurrentData

    Public Event ShowLotesDialog(ByVal sender As Object, ByVal e As ShowDialogEventArgs)
    Public Event OkButtonClick As System.ComponentModel.CancelEventHandler
    Public Event ReturningData(ByVal sender As Object, ByVal e As ReturningSerieDataEventArgs)
    Public Event CancelButtonClick As System.EventHandler
    Public Event CloseLotesDialog(ByVal sender As Object, ByVal e As System.EventArgs)

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()
        InitializeComponent()

        mDataSchema = New DataSourceSchema
        mCurrentData = New CurrentData
        mCurrentData.Schema = mDataSchema
        mFiltroEstado = New Filter
        mFiltro = New Filter
        mSerieCollection = New NSerieCollection

        mClaseMovimiento = [Shared].ClaseMovimiento.Indeterminado

        'pend Private mValorPorDefectoSeleccionEstado As String

        mCallDatabase = True
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
    Public WithEvents Panel2 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents DescAlmacen As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents DescArticulo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents IDAlmacen As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents IDArticulo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents CancelButton2 As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents OkButton As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents Panel4 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents SituacionButton As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents Totales As Janus.Windows.GridEX.GridEX
    Friend WithEvents ChkVerNoDisp As Solmicro.Expertis.Engine.UI.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NSerieStockableUserDialog))
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Totales_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.DescAlmacen = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.DescArticulo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.IDAlmacen = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.IDArticulo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.SituacionButton = New Solmicro.Expertis.Engine.UI.Button
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.ChkVerNoDisp = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.CancelButton2 = New Solmicro.Expertis.Engine.UI.Button
        Me.OkButton = New Solmicro.Expertis.Engine.UI.Button
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel4 = New Solmicro.Expertis.Engine.UI.Panel
        Me.Totales = New Janus.Windows.GridEX.GridEX
        Me.Panel2.suspendlayout()
        Me.Panel1.suspendlayout()
        Me.Frame1.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.suspendlayout()
        CType(Me.Totales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DescAlmacen)
        Me.Panel2.Controls.Add(Me.DescArticulo)
        Me.Panel2.Controls.Add(Me.IDAlmacen)
        Me.Panel2.Controls.Add(Me.IDArticulo)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.SituacionButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(704, 55)
        Me.Panel2.TabIndex = 1
        '
        'DescAlmacen
        '
        Me.DescAlmacen.Location = New System.Drawing.Point(200, 26)
        Me.DescAlmacen.Name = "DescAlmacen"
        Me.DescAlmacen.Size = New System.Drawing.Size(408, 22)
        Me.DescAlmacen.TabIndex = 5
        Me.DescAlmacen.Text = "Descripción de Almacén"
        '
        'DescArticulo
        '
        Me.DescArticulo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DescArticulo.Location = New System.Drawing.Point(200, 2)
        Me.DescArticulo.Name = "DescArticulo"
        Me.DescArticulo.Size = New System.Drawing.Size(408, 20)
        Me.DescArticulo.TabIndex = 4
        Me.DescArticulo.Text = "Descripción de Artículo"
        '
        'IDAlmacen
        '
        Me.IDAlmacen.ForeColor = System.Drawing.Color.MediumBlue
        Me.IDAlmacen.Location = New System.Drawing.Point(68, 31)
        Me.IDAlmacen.Name = "IDAlmacen"
        Me.IDAlmacen.Size = New System.Drawing.Size(127, 17)
        Me.IDAlmacen.TabIndex = 3
        Me.IDAlmacen.Text = "ID Almacen"
        '
        'IDArticulo
        '
        Me.IDArticulo.ForeColor = System.Drawing.Color.MediumBlue
        Me.IDArticulo.Location = New System.Drawing.Point(68, 5)
        Me.IDArticulo.Name = "IDArticulo"
        Me.IDArticulo.Size = New System.Drawing.Size(127, 17)
        Me.IDArticulo.TabIndex = 2
        Me.IDArticulo.Text = "ID Articulo"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Almacén: "
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Artículo: "
        '
        'SituacionButton
        '
        Me.SituacionButton.Icon = CType(resources.GetObject("SituacionButton.Icon"), System.Drawing.Icon)
        Me.SituacionButton.Location = New System.Drawing.Point(617, 7)
        Me.SituacionButton.Name = "SituacionButton"
        Me.SituacionButton.Size = New System.Drawing.Size(79, 42)
        Me.SituacionButton.TabIndex = 0
        Me.SituacionButton.Text = "Situación"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ChkVerNoDisp)
        Me.Panel1.Controls.Add(Me.CancelButton2)
        Me.Panel1.Controls.Add(Me.OkButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 357)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(704, 48)
        Me.Panel1.TabIndex = 3
        '
        'ChkVerNoDisp
        '
        Me.ChkVerNoDisp.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkVerNoDisp.Location = New System.Drawing.Point(560, 8)
        Me.ChkVerNoDisp.Name = "ChkVerNoDisp"
        Me.ChkVerNoDisp.Size = New System.Drawing.Size(136, 16)
        Me.ChkVerNoDisp.TabIndex = 2
        Me.ChkVerNoDisp.Text = "Ver no Disponibles"
        Me.ChkVerNoDisp.Visible = False
        '
        'CancelButton2
        '
        Me.CancelButton2.Location = New System.Drawing.Point(368, 8)
        Me.CancelButton2.Name = "CancelButton2"
        Me.CancelButton2.Size = New System.Drawing.Size(106, 29)
        Me.CancelButton2.TabIndex = 1
        Me.CancelButton2.Text = "Cancelar"
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(228, 8)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(105, 29)
        Me.OkButton.TabIndex = 0
        Me.OkButton.Text = "Aceptar"
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.Grid)
        Me.Frame1.Controls.Add(Me.Panel4)
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame1.Location = New System.Drawing.Point(0, 55)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(704, 302)
        Me.Frame1.TabIndex = 4
        Me.Frame1.TabStop = False
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("Ubicacion", "AlmacenUbicacion", "IDUbicacion")})
        Me.Grid.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        Me.Grid.ColumnAutoResize = True
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = Nothing
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.Location = New System.Drawing.Point(3, 74)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(698, 225)
        Me.Grid.TabIndex = 2
        Me.Grid.UpdateOnLeave = False
        Me.Grid.ViewName = Nothing
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Totales)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 17)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(698, 57)
        Me.Panel4.TabIndex = 9
        '
        'Totales
        '
        Me.Totales.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Totales.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Totales.ColumnAutoResize = True
        Totales_DesignTimeLayout.LayoutString = resources.GetString("Totales_DesignTimeLayout.LayoutString")
        Me.Totales.DesignTimeLayout = Totales_DesignTimeLayout
        Me.Totales.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Totales.Enabled = False
        Me.Totales.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Totales.GroupByBoxVisible = False
        Me.Totales.HeaderFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Totales.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Totales.Location = New System.Drawing.Point(151, 7)
        Me.Totales.Name = "Totales"
        Me.Totales.ScrollBars = Janus.Windows.GridEX.ScrollBars.None
        Me.Totales.Size = New System.Drawing.Size(397, 42)
        Me.Totales.TabIndex = 8
        Me.Totales.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'NSerieStockableUserDialog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(704, 405)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.MinimumSize = New System.Drawing.Size(712, 432)
        Me.Name = "NSerieStockableUserDialog"
        Me.Text = "Números de Serie"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.Totales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Property UsarColumnaSeleccion() As Boolean
        Get
            Return mUsarColumnaSeleccion
        End Get
        Set(ByVal Value As Boolean)
            mUsarColumnaSeleccion = Value
        End Set
    End Property

    Public Property ValorPorDefectoSeleccionEstado() As String
        Get
            Return mValorPorDefectoSeleccionEstado
        End Get
        Set(ByVal Value As String)
            mValorPorDefectoSeleccionEstado = Value
        End Set
    End Property

    Public Property ValorPorDefectoEstado() As String
        Get
            Return mValorPorDefectoEstado
        End Get
        Set(ByVal Value As String)
            mValorPorDefectoEstado = Value
        End Set
    End Property

    Public Property ModoRecuentoSalidas() As [Shared].ModoRecuentoSalidas
        Get
            Return mModoRecuentoSalidas
        End Get
        Set(ByVal Value As [Shared].ModoRecuentoSalidas)
            mModoRecuentoSalidas = Value
        End Set
    End Property

    Public Property FiltroEstado() As Filter
        Get
            Return mFiltroEstado
        End Get
        Set(ByVal Value As Filter)
            mFiltroEstado = Value
        End Set
    End Property

    Public Property ClaseMovimiento() As [Shared].ClaseMovimiento
        Get
            Return mClaseMovimiento
        End Get
        Set(ByVal Value As [Shared].ClaseMovimiento)
            mClaseMovimiento = Value

            If mClaseMovimiento = [Shared].ClaseMovimiento.Salida Then
                Grid.AllowAddNew = InheritableBoolean.False
                Grid.AllowDelete = InheritableBoolean.False
                'mUsarColumnaSeleccion = True
                mModoRecuentoSalidas = [Shared].ModoRecuentoSalidas.Seleccionados
            Else
                Grid.AllowAddNew = InheritableBoolean.True
                Grid.AllowDelete = InheritableBoolean.True
            End If
        End Set
    End Property

    Public Property Filtro() As Filter
        Get
            Return mFiltro
        End Get
        Set(ByVal Value As Filter)
            mFiltro = Value
        End Set
    End Property

    Public Property FiltroPorAlmacen() As Boolean
        Get
            Return mFiltroPorAlmacen
        End Get
        Set(ByVal Value As Boolean)
            mFiltroPorAlmacen = Value
        End Set
    End Property

    Public Property ModoAjusteInventario() As Boolean
        Get
            Return mAjusteInv
        End Get
        Set(ByVal Value As Boolean)
            mAjusteInv = Value
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
                End If
            End If
        End Set
    End Property

    Public Property IDOperario() As String
        Get
            Return mIDOperario
        End Get
        Set(ByVal Value As String)
            mIDOperario = Value
        End Set
    End Property


#Region "DataSourceColumnReading"
    '//Metodos para leer en todo momento el campo cantidad del objeto desde donde se gestionan los numeros de serie
    Private Sub DataSourceColumnReading(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs)
        If e.Column.Key = mDataSchema.Cantidad Then
            DataSourceColumnReading(e.Value)
        End If
    End Sub

    Private Sub DataSourceColumnReading(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        DataSourceColumnReading(mCurrentData.Grid.GetValue(mDataSchema.Cantidad))
    End Sub

    Private Sub DataSourceColumnReading(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)
        DataSourceColumnReading(mCurrentData.Grid.GetValue(mDataSchema.Cantidad))
    End Sub

    Private Sub DataSourceColumnReading(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs)
        If e.Column.Key = mDataSchema.Cantidad Then
            DataSourceColumnReading(e.Value)
        End If
    End Sub

    Private Sub DataSourceColumnReading(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            DataSourceColumnReading(mCurrentData.Grid.GetValue(mDataSchema.Cantidad))
        End If
    End Sub

    Private Sub DataSourceColumnReading(ByVal Value As Object)
        Dim ex2 As Exception

        RemoveHandler mCurrentData.Grid.EditingCell, AddressOf DataSourceColumnReading
        RemoveHandler mCurrentData.Grid.KeyDown, AddressOf DataSourceColumnReading
        RemoveHandler mCurrentData.Grid.CellValueChanged, AddressOf DataSourceColumnReading
        RemoveHandler mCurrentData.Grid.UpdatingCell, AddressOf DataSourceColumnReading
        RemoveHandler mCurrentData.Grid.MouseDown, AddressOf DataSourceColumnReading
        Try
            If IsNumeric(Value) Then
                mCurrentData.Cantidad = Value
            Else
                mCurrentData.Cantidad = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        If e.Column.ColumnName = mDataSchema.Cantidad Then
            Dim ex2 As Exception
            Dim dt As DataTable = CType(sender, DataTable)

            RemoveHandler dt.ColumnChanging, AddressOf DataSourceColumnReading
            Try
                If e.Row.RowState = DataRowState.Unchanged Then
                    mCurrentData.Cantidad = e.Row(e.Column)
                Else
                    mCurrentData.Cantidad = e.ProposedValue
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
#End Region

    Public ReadOnly Property SerieCollection() As NSerieCollection
        Get
            Return mSerieCollection
        End Get
    End Property

    Public Shadows Function ShowDialog(ByRef serie As NSerie) As DialogResult
        Try
            If Not serie Is Nothing Then
                mSerie = serie
                If mIsBound Then mSerie.Cantidad = mCurrentData.Cantidad

                Dim args1 As New ShowDialogEventArgs(mSerie)
                RaiseEvent ShowLotesDialog(Me, args1)

                Me.LoadData()
                MyBase.ShowDialog()
                If Me.DialogResult = DialogResult.OK Then
                    If Not mSerie.Guardado Then
                        mSerieCollection.Add(mSerie, mSerie.ID)
                    End If
                End If
                RaiseEvent CloseLotesDialog(Me, New System.EventArgs)
                RaiseEvent ReturningData(Me, New ReturningSerieDataEventArgs(mSerie, Me.DialogResult))
            End If

            Return Me.DialogResult
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Shadows Function ShowDialog(ByVal ParamArray ID() As String) As DialogResult
        Try
            Dim ns As NSerie
            ns = mSerieCollection.Item(ID)
            If ns Is Nothing Then
                If mSerieCollection.HasPendingInserts Then
                    ns = mSerieCollection.TempInserts(ns)
                End If
                If ns Is Nothing Then
                    ns = Me.LoadSerie()
                    ns.SetID(ID)
                End If
            End If
            Return MyClass.ShowDialog(ns)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Function LoadSerie() As NSerie
        If Len(mCurrentData.IDArticulo) = 0 Then
            Throw New Exception("El artículo no tiene un valor válido.")
        ElseIf Len(mCurrentData.IDAlmacen) = 0 Then
            Throw New Exception("El almacén no tiene un valor válido.")
        Else
            Dim ns As NSerie
            If mAjusteInv Then
                ns = New NSerie(mCurrentData.IDArticulo, mCurrentData.IDAlmacen, False)
            Else
                If mClaseMovimiento = [Shared].ClaseMovimiento.SoloEntradas Then
                    ns = New NSerie
                    ns.Articulo = mCurrentData.IDArticulo
                    ns.Almacen = mCurrentData.IDAlmacen
                ElseIf Not mFiltro Is Nothing AndAlso mFiltro.Count > 0 Then
                    ns = New NSerie(mCurrentData.IDArticulo, mCurrentData.IDAlmacen, mFiltro, mFiltroPorAlmacen)
                Else
                    ns = New NSerie(mCurrentData.IDArticulo, mCurrentData.IDAlmacen)
                End If
            End If
            Return ns
        End If
    End Function

    Private Sub LoadData()
        If mUsarColumnaSeleccion Then
            If Not Grid.Columns.Contains("Selector") Then
                Dim c As GridEXColumn = Grid.Columns.Add("Selector")
                'c.ActAsSelector = True
                '//La columna no vale ActAsSelector, porque aunque tenga DataMemeber, no mantiene los valores.
                c.DataMember = "Selector"
                c.EditType = EditType.CheckBox
                c.ColumnType = ColumnType.CheckBox
                c.Position = 0
                c.Width = 22
                c.AllowSize = False
                c.AllowDrag = False
                c.AllowSort = False
                c.AllowRemove = InheritableBoolean.False
                c.UseHeaderSelector = False
                Grid.FrozenColumns = 1
            End If
            If Not mSerie.DataTable Is Nothing Then
                If Not mSerie.DataTable.Columns.Contains("Selector") Then
                    mSerie.DataTable.Columns.Add("Selector", GetType(Boolean))
                    For Each dr As DataRow In mSerie.DataTable.Rows
                        dr("Selector") = False
                    Next
                End If
            End If
        Else
            mSerie.DataTable.Rows.Clear()
        End If

        Grid.DataSource = mSerie.DataTable
        LoadDatosAjusteInv()
        CrearTotales()
        ActualizarTotales()
    End Sub

    Private Sub LoadDatosAjusteInv()
        If mAjusteInv Then
            ChkVerNoDisp.Visible = True
            MDtGrid = Grid.DataSource
            ChkVerNoDisp.Checked = False
            TratarGridAjuste()
        Else
            ChkVerNoDisp.Visible = False
        End If
    End Sub

    Private Sub TratarGridAjuste()
        Dim DtTratado As DataTable = MDtGrid.Copy
        For Each Dr As DataRow In DtTratado.Select("Disponible = True")
            Dr("Selector") = True
        Next
        If Not ChkVerNoDisp.Checked Then
            For Each DrDel As DataRow In DtTratado.Select("Disponible = False")
                DrDel.Delete()
            Next
        End If
        Grid.DataSource = DtTratado
    End Sub

    Private Sub CrearTotales()
        Dim dt As New DataTable

        dt.Columns.Add("CantidadAsignar", GetType(Double))
        dt.Columns.Add("CantidadAsignada", GetType(Double))
        dt.Columns.Add("Diferencia", GetType(Double))

        Dim newrow As DataRow = dt.NewRow
        newrow("CantidadAsignar") = mSerie.Cantidad
        dt.Rows.Add(newrow)

        Totales.DataSource = dt
    End Sub

    Private Sub ActualizarTotales()
        Dim dt As DataTable

        dt = CType(Totales.DataSource, DataTable)
        If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
            If mAjusteInv Then
                dt.Rows(0)("CantidadAsignada") = SeriesSeleccionadas()
                dt.Rows(0)("Diferencia") = Math.Abs(dt.Rows(0)("CantidadAsignar")) - dt.Rows(0)("CantidadAsignada")
            Else
                dt.Rows(0)("CantidadAsignada") = SumaCantidad()
                dt.Rows(0)("Diferencia") = Math.Abs(dt.Rows(0)("CantidadAsignar")) - dt.Rows(0)("CantidadAsignada")
            End If
        End If
    End Sub

    Private Sub Totales_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Totales.FormattingRow
        If Nz(e.Row.Cells("Diferencia").Value, 0) <> 0 Then
            e.Row.Cells("Diferencia").FormatStyle = Totales.FormatStyles("CantidadNoValida")
        End If
    End Sub

    Private Function SumaCantidad() As Integer
        If mClaseMovimiento = [Shared].ClaseMovimiento.Salida Then
            Select Case mModoRecuentoSalidas
                Case [Shared].ModoRecuentoSalidas.Bajas
                    Return SeriesDeBaja()
                Case [Shared].ModoRecuentoSalidas.Seleccionados
                    Return SeriesSeleccionadas()
            End Select
        Else
            Return CType(Grid.DataSource, DataTable).Rows.Count - SeriesDeBaja()
        End If
    End Function

    Private Function SumaCantidadAjuste()
        Return SeriesSeleccionadas()
    End Function

    Private Function SeriesDeBaja() As Integer
        Dim dv As New DataView(CType(Grid.DataSource, DataTable))
        Dim f As New Filter
        f.Add(New BooleanFilterItem("Baja", True))
        dv.RowFilter = f.Compose(New AdoFilterComposer)
        Return dv.Count
    End Function

    Private Function SeriesSeleccionadas() As Integer
        'Return Grid.GetCheckedRows.Length
        Dim dv As New DataView(CType(Grid.DataSource, DataTable))
        If mUsarColumnaSeleccion Then
            Dim f As New Filter
            f.Add(New BooleanFilterItem("Selector", True))
            dv.RowFilter = f.Compose(New AdoFilterComposer)
        End If
        Return dv.Count
    End Function

    Private Sub NSerieStockableUserDialog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            mValorPorDefectoEstado = New Parametro().EstadoActivoPorDefecto()
            Grid.Columns("NSerie").MaxLength = 50
            mQueryOnClose = False
            Me.DialogResult = DialogResult.None

            If Not Me.DesignMode Then
                If mCallDatabase Then
                    mGestionSerieConActivo = New Parametro().GestionNumeroSerieConActivos()
                    '//cargar estados de activo
                    mEstados = New MntoEstadoActivo().Filter
                    Grid.DropDowns("Estados").SetDataBinding(mEstados, Nothing)
                    '//cargar operarios
                    Dim Op As New Operario
                    mOperarios = Op.Filter
                    Grid.DropDowns("Operarios").SetDataBinding(mOperarios, Nothing)
                    Dim dtOperario As DataTable = Op.Filter(New GuidFilterItem("IDUsuario", ExpertisApp.Token.UserID))
                    If Length(mIDOperario) = 0 AndAlso dtOperario.Rows.Count > 0 Then
                        mIDOperario = dtOperario.Rows(0)("IDOperario")
                    End If

                    mCallDatabase = False
                End If

                IDArticulo.Text = Nothing
                IDAlmacen.Text = Nothing
                DescArticulo.Text = Nothing
                DescAlmacen.Text = Nothing

                If Len(mSerie.Articulo) > 0 And Len(mSerie.Almacen) > 0 Then
                    IDArticulo.Text = mSerie.Articulo
                    IDAlmacen.Text = mSerie.Almacen

                    Dim dt As DataTable
                    dt = New Articulo().SelOnPrimaryKey(mSerie.Articulo)
                    If dt.Rows.Count > 0 Then
                        DescArticulo.Text = dt.Rows(0)("DescArticulo")
                    End If
                    dt = New Almacen().SelOnPrimaryKey(mSerie.Almacen)
                    If dt.Rows.Count > 0 Then
                        DescAlmacen.Text = dt.Rows(0)("DescAlmacen")
                    End If
                End If

                '//La gestion de numeros de serie se hace conjuntamente con la de activos
                If Not mGestionSerieConActivo Then
                    Grid.Columns("IDActivo").Visible = True
                    Grid.Columns("DescActivo").Visible = False
                End If
                '//valores por defecto
                If Grid.AllowAddNew = InheritableBoolean.True Then
                    SettingsDefaultValuesGrid()
                End If
                '//Crear los formatos correspondientes a los colores de cada estado de activo
                GridFormatStyle.CrearFormatos(Grid, mEstados, GridFormatStyle.TipoFormato.EstadoActivo)
                Grid.Refresh()
            End If
        End If
    End Sub

    Protected Overridable Sub SettingsDefaultValuesGrid()
        Grid.Columns("IDArticulo").DefaultValue = mSerie.Articulo
        Grid.Columns("IDAlmacen").DefaultValue = mSerie.Almacen
        If Grid.Columns.Contains("Ubicacion") Then
            Grid.Columns("Ubicacion").DefaultValue = String.Empty
            If Length(mSerie.Almacen) > 0 Then
                Dim f As New Filter
                f.Add(New StringFilterItem("IDAlmacen", mSerie.Almacen))
                f.Add(New BooleanFilterItem("Predeterminada", True))
                Dim dtUbicacion As DataTable = New AlmacenUbicacion().Filter(f)
                If dtUbicacion.Rows.Count > 0 Then
                    Grid.Columns("Ubicacion").DefaultValue = dtUbicacion.Rows(0)("IDUbicacion")
                End If
            End If
        End If

        Grid.Columns("Disponible").DefaultValue = True
        Grid.Columns("EnCurso").DefaultValue = False
        Grid.Columns("Baja").DefaultValue = False
        If Length(mIDOperario) > 0 Then
            Grid.Columns("IDOperario").DefaultValue = mIDOperario
        End If

        If Len(mValorPorDefectoEstado) > 0 Then
            Grid.Columns("IDEstadoActivo").DefaultValue = mValorPorDefectoEstado
            Dim propiedades As DataRow = CaracteristicasEstadoActivo(mValorPorDefectoEstado)
            If Not propiedades Is Nothing Then
                Grid.Columns("Disponible").DefaultValue = propiedades("Disponible")
                Grid.Columns("EnCurso").DefaultValue = propiedades("EnCurso")
                Grid.Columns("Baja").DefaultValue = propiedades("Baja")
            End If
        End If
        If mAjusteInv Then Grid.Columns("Selector").DefaultValue = True
    End Sub

    Private Sub Grid_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        Me.OnEditingCell(e)
    End Sub

    Protected Overridable Sub OnEditingCell(ByVal e As Janus.Windows.GridEX.EditingCellEventArgs)
        Try
            Select Case e.Column.Key
                Case "NSerie"
                    If Grid.Row = Grid.newTopRowPosition Then
                        If Length(Grid.Value("IDActivo")) > 0 Then
                            e.Cancel = True
                        Else
                            e.Column.EditType = EditType.TextBox
                        End If
                    Else
                        e.Cancel = True
                    End If
                Case "Ubicacion"
                    If Grid.Row = Grid.newTopRowPosition Then
                        If Length(Grid.Value("IDActivo")) > 0 Then
                            e.Cancel = True
                            e.Column.ButtonStyle = ButtonStyle.NoButton
                        Else
                            e.Column.EditType = EditType.TextBox
                            e.Column.ButtonStyle = ButtonStyle.Image
                        End If
                    Else
                        If CBool(Grid.AllowAddNew) Then
                            e.Column.EditType = EditType.TextBox
                            e.Column.ButtonStyle = ButtonStyle.Image
                        Else
                            e.Cancel = True
                            e.Column.ButtonStyle = ButtonStyle.NoButton
                        End If
                    End If
                Case "IDActivo"
                    If Grid.Row = Grid.newTopRowPosition Then
                        Grid.RootTable.Columns("IDActivo").ButtonStyle = ButtonStyle.Image
                        Grid.RootTable.Columns("IDActivo").EditType = EditType.TextBox
                    Else
                        Grid.RootTable.Columns("IDActivo").ButtonStyle = ButtonStyle.NoButton
                        e.Cancel = True
                    End If
                Case "IDEstadoActivo"
                    AplicarFiltroEstados()
                Case "Selector"
                    If mAjusteInv Then
                        If Grid.GetValue("EnCurso") OrElse (Not Grid.GetValue("Disponible") AndAlso Not Grid.GetValue("Baja")) Then
                            e.Cancel = True
                        End If
                    End If
            End Select
        Catch ex As Exception
            e.Cancel = True
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Grid_DeletingRecords(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionCancelEventArgs) Handles Grid.DeletingRecord
        Me.OnDeletingRecords(e)
    End Sub

    Protected Overridable Sub OnDeletingRecords(ByVal e As Janus.Windows.GridEX.RowActionCancelEventArgs)
        Try
            '//Solo se pueden eliminar lotes introducidos en esta sesion de mantenimiento
            Dim dv As New DataView(CType(Grid.DataSource, DataTable))
            Dim f As New Filter
            f.Add(New StringFilterItem("NSerie", FilterOperator.Equal, e.Row.Cells("NSerie").Value))
            dv.RowFilter = f.Compose(New AdoFilterComposer)
            If dv.Count Then
                If dv(0).Row.RowState <> DataRowState.Added Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("Sólo puede eliminar las filas introducidas en el desglose actual.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            e.Cancel = True
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Grid_RecordUpdated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.RecordUpdated
        ActualizarTotales()
        Me.OnRecordUpdated(e)
    End Sub

    Protected Overrides Sub OnRecordUpdated(ByVal e As System.EventArgs)
    End Sub

    Private Sub Grid_RecordsDeleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.RecordsDeleted
        ActualizarTotales()
        Me.OnRecordsDeleted(e)
    End Sub

    Protected Overridable Sub OnRecordsDeleted(ByVal e As System.EventArgs)
    End Sub

    Private Sub Grid_RowEditCanceled(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles Grid.RowEditCanceled
        ActualizarTotales()
    End Sub

    Private Sub Grid_RecordAdded(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.RecordAdded
        ActualizarTotales()
        Me.OnRecordAdded(e)
        Grid.Row = -1
        Grid.Col = Grid.Columns("Nserie").Index
    End Sub

    Protected Overridable Shadows Sub OnRecordAdded(ByVal e As System.EventArgs)
    End Sub

    Protected Overridable Sub Grid_AddingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Grid.AddingRecord
        Me.OnAddingRecord(e)
    End Sub

    Protected Overridable Sub OnAddingRecord(ByVal e As System.ComponentModel.CancelEventArgs)
        Try
            If Length(Grid.GetRow.Cells("NSerie").Value) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("El número de serie es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ElseIf Length(Grid.GetRow.Cells("IDArticulo").Value) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("El artículo es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Length(Grid.GetRow.Cells("IDAlmacen").Value) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("El almacen es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Length(Grid.GetRow.Cells("IDEstadoActivo").Value) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("El estado es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Length(Grid.GetRow.Cells("IDOperario").Value) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("El operario es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                '//La busqueda desde presentacion se hace en el orden siguiente:
                '//1.se busca en la lista actual del grid
                '//2.Se busca en el resto de desgloses de numeros de serie que se hayan guardado para esta pantalla
                '//3.finalmente se va a la base de datos
                Dim dv As DataView
                dv = New DataView(Grid.DataSource)
                dv.Sort = "NSerie"
                Dim index As Integer
                Dim serie As String = Grid.GetRow.Cells("NSerie").Value
                index = dv.Find(serie)
                If index >= 0 Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("El número de serie | ya existe en la lista actual.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Quoted(serie))
                Else
                    If Not mSerieCollection Is Nothing Then
                        For Each ns As NSerie In mSerieCollection.List
                            dv = New DataView(ns.DataTable)
                            dv.Sort = "NSerie"
                            index = dv.Find(serie)
                            If index >= 0 Then
                                e.Cancel = True
                                ExpertisApp.GenerateMessage("El número de serie | se ha asignado de manera provisional al artículo | en el almacén |.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Quoted(serie), Quoted(ns.Articulo), Quoted(ns.Almacen))
                                Exit For
                            End If
                        Next
                    End If

                    If Not e.Cancel Then
                        Dim p As New Parametro
                        Dim blnActivo As Boolean = p.GestionNumeroSerieConActivos()
                        Dim f As New Filter
                        f.Add(New FilterItem("NSerie", FilterOperator.Equal, serie, FilterType.String))
                        If Not blnActivo Then
                            f.Add(New FilterItem("IDArticulo", FilterOperator.Equal, IDArticulo.Text, FilterType.String))
                        End If
                        Dim dt As DataTable = New ArticuloNSerie().Filter(f)
                        If dt.Rows.Count > 0 Then
                            'e.Cancel = True
                            Dim propiedades As DataRow = CaracteristicasEstadoActivo(dt.Rows(0)("IDEstadoActivo"))
                            If Not propiedades Is Nothing AndAlso propiedades("baja") Then
                                If ExpertisApp.GenerateMessage("El Número de Serie | ya está asignado al artículo | y está en estado de baja.|¿Desea volver a ponerlo en disponible?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, Quoted(serie), dt.Rows(0)("IDArticulo"), vbNewLine) = DialogResult.Yes Then
                                Else : e.Cancel = True
                                End If
                            Else
                                ExpertisApp.GenerateMessage("El número de serie | ya está asignado al artículo |.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Quoted(serie), dt.Rows(0)("IDArticulo"))
                                e.Cancel = True
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            e.Cancel = True
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function CaracteristicasEstadoActivo(ByVal IDEstado As String) As DataRow
        If Len(IDEstado) > 0 Then
            Dim dv As New DataView(mEstados)
            dv.Sort = "IDEstadoActivo"
            Dim index As Integer
            index = dv.Find(IDEstado)
            If index >= 0 Then
                Return dv(index).Row
            End If
        End If
    End Function

    Private Sub Grid_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles Grid.AdvSearchSetPredefinedFilter
        Me.OnAdvSearchPredefinedFilter(e)
    End Sub

    Protected Overridable Sub OnAdvSearchPredefinedFilter(ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs)
        Select e.Key

            Case "IDActivo"
                e.Filter.Add(New IsNullFilterItem("NSerie"))
                If Len(mSerie.Articulo) > 0 Then
                    e.Filter.Add(New StringFilterItem("IDArticulo", mSerie.Articulo))
                End If
            Case "Ubicacion"
                If Len(mSerie.Almacen) > 0 Then
                    e.Filter.Add(New StringFilterItem("IDAlmacen", mSerie.Almacen))
                End If
        End Select
    End Sub

    Private Sub Grid_AdvSearchSelectionChanged(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchSelectionChangedEventArgs) Handles Grid.AdvSearchSelectionChanged
        Me.OnAdvSearchSelectionChanged(e)
    End Sub

    Protected Overridable Sub OnAdvSearchSelectionChanged(ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchSelectionChangedEventArgs)
        If e.Key = "IDActivo" Then
            Grid.Value("NSerie") = e.Selected.Rows(0)("IDActivo")
            Grid.Value("DescActivo") = e.Selected.Rows(0)("DescActivo")
            Grid.Value("IDEstadoActivo") = e.Selected.Rows(0)("IDEstadoActivo")
            Dim propiedades As DataRow = CaracteristicasEstadoActivo(e.Selected.Rows(0)("IDEstadoActivo"))
            If Not propiedades Is Nothing Then
                Grid.Value("Disponible") = propiedades("Disponible")
                Grid.Value("EnCurso") = propiedades("EnCurso")
                Grid.Value("Baja") = propiedades("Baja")
            End If
        End If
    End Sub

    Private Sub Grid_UpdatingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles Grid.UpdatingCell
        Me.OnUpdatingCell(e)
    End Sub

    Protected Overridable Sub OnUpdatingCell(ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs)
        Select Case e.Column.Key
            Case "IDEstadoActivo"
                If Length(e.Value) > 0 Then
                    ActualizarPropiedadesEstadoLinea(e.Value)
                    If mAjusteInv AndAlso Grid.GetValue("Disponible") Then
                        Grid.SetValue("Selector", True)
                    ElseIf mAjusteInv AndAlso Not Grid.GetValue("Disponible") Then
                        Grid.SetValue("Selector", False)
                    End If
                    GridFormatStyle.AplicarFormato(Grid.GetRow, e.Value)
                End If
            Case "Selector"
                If e.Value Then
                    If Not mAjusteInv Then
                        If Len(mValorPorDefectoSeleccionEstado) > 0 Then
                            Grid.Value("IDEstadoActivo") = mValorPorDefectoSeleccionEstado
                        End If
                    Else
                        If Grid.GetValue("Baja") Then
                            Grid.SetValue("IDEstadoActivo", ERP.CommonClasses.NSerie.ESTADO_DISPONIBLE)
                        End If
                    End If
                Else
                    Dim i As Integer = mSerie.OriginalData.DefaultView.Find(Grid.Value("NSerie"))
                    If i >= 0 Then
                        If Grid.GetValue("IDEstadoActivo") = mSerie.OriginalData.DefaultView(i)("IDEstadoActivo") _
                        AndAlso Grid.GetValue("IDEstadoActivo") = ERP.CommonClasses.NSerie.ESTADO_DISPONIBLE Then
                            Grid.SetValue("IDEstadoActivo", ERP.CommonClasses.NSerie.ESTADO_BAJA)
                        Else
                            Grid.Value("IDEstadoActivo") = mSerie.OriginalData.DefaultView(i)("IDEstadoActivo")
                        End If
                    End If
                End If
                ActualizarPropiedadesEstadoLinea(Grid.Value("IDEstadoActivo"))
                GridFormatStyle.AplicarFormato(Grid.GetRow, Grid.Value("IDEstadoActivo"))
        End Select
    End Sub

    Private Sub ActualizarPropiedadesEstadoLinea(ByVal IDEstado As String)
        Dim propiedades As DataRow = CaracteristicasEstadoActivo(IDEstado)
        If Not propiedades Is Nothing Then
            Grid.Value("Disponible") = propiedades("Disponible")
            Grid.Value("EnCurso") = propiedades("EnCurso")
            Grid.Value("Baja") = propiedades("Baja")
        End If
    End Sub

    Private Sub Grid_FirstChange(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles Grid.FirstChange
        mQueryOnClose = True
    End Sub

    Private Sub CancelButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton2.Click
        Dim Cancel As Boolean
        If Grid.DataChanged Or mQueryOnClose Then
            Cancel = (ExpertisApp.GenerateMessage("¿Desea perder las modificaciones realizadas?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No)
        End If
        If Not Cancel Then
            If Not Grid.DataSource Is Nothing AndAlso Not mAjusteInv Then
                mSerie.DataTable = CType(Grid.DataSource, DataTable)
                mSerie.DataTable.RejectChanges()
            End If
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If

        Dim e2 As New System.EventArgs
        Me.OnCancelButtonClick(e2)
    End Sub

    Private Sub OkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkButton.Click
        Grid.UpdateData()
        If SumaCantidad() <> Math.Abs(mSerie.Cantidad) Then
            If mAjusteInv Then
                If SumaCantidadAjuste() <> Math.Abs(mSerie.Cantidad) Then
                    ExpertisApp.GenerateMessage("La cantidad asignada debe ser igual a la cantidad a asignar.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Else
                ExpertisApp.GenerateMessage("La cantidad asignada debe ser igual a la cantidad a asignar.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            'Inicio- David Velasco 06/10.Aún por depurar los mensajes desde Business\Activo.vb
        Else
            ''    'SI LA CANTIDAD DE ASIGNACIÓN ES IGUAL A LA CANTIDAD A ASIGNAR, GUARDO LOS DATOS EN BBDD

            'Dim DtGrid As DataTable = Grid.DataSource
            'Dim activo As New Activo
            'Dim pordefecto00 As String
            'pordefecto00 = "00"

            'If DtGrid.Rows.Count > 0 Then
            '    For Each dr As DataRow In DtGrid.Rows
            '        If dr("IDActivo").ToString.Length <> 0 Then
            '            dr("IDActivo") = dr("NSerie")
            '            'Crea el activo pero no lo vincula con tbArticuloNSerie
            '            Dim dt As DataTable = activo.AddNewForm
            '            dt(0)("IDActivo") = dr("IDActivo")
            '            dt(0)("IDArticulo") = dr("IDArticulo")
            '            Dim articulo As New Business.Negocio.Articulo
            '            Dim dtarticulo As New DataTable
            '            dtarticulo = articulo.SelOnPrimaryKey(dr("IDArticulo"))

            '            dt(0)("DescActivo") = dtarticulo(0)("DescArticulo")
            '            dt(0)("IDZona") = "00"
            '            dt(0)("IDClaseActivo") = "00"
            '            dt(0)("IDEstadoActivo") = dr("IDEstadoActivo")
            '            dt(0)("IDCentroCoste") = "00"
            '            dt(0)("NSerie") = dr("NSerie")
            '            dt(0)("FechaAlta") = Today
            '            dt(0)("IDArticulo") = dr("IDArticulo")
            '            dt(0)("IDOperario") = dr("IDOperario")
            '            Dim dt2 As DataTable = dt
            '            activo.Validate(dt)
            '            activo.Update(dt)

            '            '                'CODIGO PARA CREAR EL ACTIVO
            '            '                activo.CreaActivo(dr("IDActivo"), dr("NSerie"), dr("IDArticulo"), pordefecto00, dr("IDEstadoActivo"), dr("IDOperario"))
            '            '                activo.CreaEstadoActivo(dr("IDActivo"), dr("IDEstadoActivo"), dr("IDOperario"))
            '            '                activo.crearArtNSerie(dr("IDArticulo"), dr("NSerie"), dr("IDActivo"), dr("IDEstadoActivo"), dr("IDOperario"))
            '        Else
            '            '                'CODIGO PARA CREAR EL ACTIVO
            '            '                activo.CreaActivo(dr("IDActivo"), dr("NSerie"), dr("IDArticulo"), pordefecto00, dr("IDEstadoActivo"), dr("IDOperario"))
            '            '                activo.CreaEstadoActivo(dr("IDActivo"), dr("IDEstadoActivo"), dr("IDOperario"))
            '            '                activo.crearArtNSerie(dr("IDArticulo"), dr("NSerie"), dr("IDActivo"), dr("IDEstadoActivo"), dr("IDOperario"))
            '        End If
            '    Next
            'Else
            '    ExpertisApp.GenerateMessage("La tabla esta vacía.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'End If
        End If
        'Fin-David Velasco 06/10
        Dim e2 As New System.ComponentModel.CancelEventArgs
        Me.OnOkButtonClick(e2)
        If Not e2.Cancel Then
            If mUsarColumnaSeleccion Then
                Dim DtSel As DataTable = Grid.DataSource.clone
                If mAjusteInv Then
                    For Each Dr As DataRow In Grid.DataSource.Select("", "", DataViewRowState.ModifiedCurrent)
                        DtSel.Rows.Add(Dr.ItemArray)
                    Next
                    For Each Dr As DataRow In Grid.DataSource.Select("Selector = True")
                        Dim DrSel() As DataRow = DtSel.Select("NSerie = '" & Dr("NSerie") & "'")
                        If DrSel.Length = 0 Then
                            DtSel.Rows.Add(Dr.ItemArray)
                        End If
                    Next
                Else
                    For Each dr As DataRow In Grid.DataSource.Select("Selector = True")
                        DtSel.Rows.Add(dr.ItemArray)
                    Next
                End If
                mSerie.DataTable = DtSel
            Else
                mSerie.DataTable = CType(Grid.DataSource, DataTable)
            End If
            'mSerie.DataTable.AcceptChanges()
            Me.DialogResult = DialogResult.OK

            Me.Close()


        End If
    End Sub

    Protected Overridable Sub OnCancelButtonClick(ByVal e As System.EventArgs)
        RaiseEvent CancelButtonClick(Me, e)
    End Sub

    Protected Overridable Sub OnOkButtonClick(ByVal e As System.ComponentModel.CancelEventArgs)
        RaiseEvent OkButtonClick(Me, e)
    End Sub

    Private Sub SituacionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SituacionButton.Click
        Dim frm As New NSerieSituacion(mSerie.Articulo)
        frm.ShowDialog()
    End Sub

    Private Sub NSerieStockableUserDialog_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Grid.Focus()
        If Grid.AllowAddNew = InheritableBoolean.True Then
            Grid.Row = Grid.newTopRowPosition
            Grid.CurrentColumn = Grid.Columns("NSerie")
        End If
    End Sub

    Private Sub Grid_DropDown(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.DropDown
        AplicarFiltroEstados()
        Me.OnDropDown(e)
    End Sub

    Protected Overridable Sub OnDropDown(ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)
    End Sub

    Private Sub Grid_DropDownHide(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.DropDownHideEventArgs) Handles Grid.DropDownHide
        RestaurarEstados()
        Me.OnDropDownHide(e)
    End Sub

    Protected Overridable Sub OnDropDownHide(ByVal e As Janus.Windows.GridEX.DropDownHideEventArgs)
    End Sub

    Private Sub AplicarFiltroEstados()
        If mFiltroEstado.Count > 0 Then
            mEstados.DefaultView.RowFilter = mFiltroEstado.Compose(New AdoFilterComposer)
        End If
    End Sub

    Private Sub RestaurarEstados()
        mEstados.DefaultView.RowFilter = Nothing
    End Sub

    Private Sub Grid_CellEdited(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.CellEdited
        'If e.Column.Key = "NSerie" Then
        '    Grid.SetValue("IDActivo", Grid.GetValue("NSerie"))
        'End If
        If e.Column.Key = "IDEstadoActivo" Then
            RestaurarEstados()
        End If
        Me.OnCellEdited(e)
    End Sub

    Protected Overridable Sub OnCellEdited(ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)
    End Sub

    Private Sub Grid_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        Me.OnFormattingRow(e)
    End Sub

    Protected Overridable Sub OnFormattingRow(ByVal e As Janus.Windows.GridEX.RowLoadEventArgs)
        If e.Row.RowType = RowType.Record Then
            GridFormatStyle.AplicarFormato(e.Row, e.Row.Cells("IDEstadoActivo").Value)
        End If
    End Sub

    Private Sub Grid_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Grid.UpdatingRecord
        Me.OnUpdatingRecord(e)
    End Sub

    Protected Overridable Sub OnUpdatingRecord(ByVal e As System.ComponentModel.CancelEventArgs)
    End Sub

    Private Sub Grid_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.CellUpdated
        Me.OnCellUpdated(e)
    End Sub

    Protected Overridable Sub OnCellUpdated(ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)
    End Sub

    Private Sub ChkVerNoDisp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkVerNoDisp.CheckedChanged
        TratarGridAjuste()
        ActualizarTotales()
    End Sub

End Class