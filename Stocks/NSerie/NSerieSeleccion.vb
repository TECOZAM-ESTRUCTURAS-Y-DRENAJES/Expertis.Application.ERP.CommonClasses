Public Class NSerieSeleccion
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    Public Event SeleccionSerie(ByVal Row As DataRow)

    Private mFilter As Filter
    Private mPermitirFiltrar As Boolean
    Private mReadOnly As Boolean
    Private mOperarios As DataTable
    Private mstrIDArticulo As String
    Private mblnOS As Boolean

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        mPermitirFiltrar = True
        mFilter = New Filter
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
    Private WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents txtDescArticulo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmdSearch As Solmicro.Expertis.Engine.UI.Button
    Private WithEvents TopPanel As Solmicro.Expertis.Engine.UI.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NSerieSeleccion))
        Me.TopPanel = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmdSearch = New Solmicro.Expertis.Engine.UI.Button
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescArticulo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.advArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.TopPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.cmdSearch)
        Me.TopPanel.Controls.Add(Me.Label2)
        Me.TopPanel.Controls.Add(Me.txtDescArticulo)
        Me.TopPanel.Controls.Add(Me.advArticulo)
        Me.TopPanel.Controls.Add(Me.Label1)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(704, 48)
        Me.TopPanel.TabIndex = 2
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(8, 8)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(40, 32)
        Me.cmdSearch.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(256, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Descripción:"
        '
        'txtDescArticulo
        '
        Me.txtDescArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescArticulo.Location = New System.Drawing.Point(336, 12)
        Me.txtDescArticulo.Name = "txtDescArticulo"
        Me.txtDescArticulo.Size = New System.Drawing.Size(360, 21)
        Me.txtDescArticulo.TabIndex = 6
        '
        'advArticulo
        '
        Me.advArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.advArticulo.EntityName = "Articulo"
        Me.advArticulo.Location = New System.Drawing.Point(112, 12)
        Me.advArticulo.Name = "advArticulo"
        Me.advArticulo.PrimaryDataFields = "IDArticulo"
        Me.advArticulo.SecondaryDataFields = "IDArticulo"
        Me.advArticulo.Size = New System.Drawing.Size(136, 23)
        Me.advArticulo.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(56, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Artículo: "
        '
        'Grid
        '
        Me.Grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        Me.Grid.ColumnAutoResize = True
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = Nothing
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.Location = New System.Drawing.Point(0, 48)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(704, 245)
        Me.Grid.TabIndex = 3
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UpdateOnLeave = False
        Me.Grid.ViewName = Nothing
        '
        'NSerieSeleccion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(704, 293)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.TopPanel)
        Me.MinimumSize = New System.Drawing.Size(712, 320)
        Me.Name = "NSerieSeleccion"
        Me.Text = "Seleccionar número de serie"
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Shadows Property FilterCriteria() As Filter
        Get
            Return mFilter
        End Get
        Set(ByVal Value As Filter)
            mFilter = Value
        End Set
    End Property

    Public Property PermitirFiltrar() As Boolean
        Get
            Return mPermitirFiltrar
        End Get
        Set(ByVal Value As Boolean)
            mPermitirFiltrar = Value
        End Set
    End Property

    Public Property [ReadOnly]() As Boolean
        Get
            Return mReadOnly
        End Get
        Set(ByVal Value As Boolean)
            mReadOnly = Value
        End Set
    End Property

    Public WriteOnly Property Articulo() As String
        Set(ByVal Value As String)
            mstrIDArticulo = Value
        End Set
    End Property

    Public WriteOnly Property OrdenServicio() As Boolean
        Set(ByVal Value As Boolean)
            mblnOS = value
        End Set
    End Property

    Private Sub NSerieSeleccion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmdSearch.Image = UI.Resources.FilterIcon.ToBitmap

        Dim activos As Boolean = New Parametro().GestionNumeroSerieConActivos()
        If Not activos Then
            Grid.Columns("IDActivo").Visible = False
            Grid.Columns("DescActivo").Visible = False
        End If

        GridFormatStyle.CrearFormatos(Grid, GridFormatStyle.TipoFormato.EstadoActivo)

        If mFilter.Count > 0 Then
            Grid.DataSource = Me.Filtrar(mFilter)
        End If
        If Not mPermitirFiltrar Then
            'cmdSearch.Enabled = False
            'advArticulo.Enabled = False
            'txtDescArticulo.Enabled = False
            TopPanel.Visible = False
        End If
        If mReadOnly Then
            Grid.AllowEdit = InheritableBoolean.False
            Grid.Columns("IDOperario").Visible = False
            Grid.Columns("DescOperario").Visible = True
        Else
            mOperarios = New Operario().Filter(New GuidFilterItem("IDUsuario", ExpertisApp.Token.UserID))
            Grid.DropDowns("Operarios").SetDataBinding(mOperarios, Nothing)
        End If

        If mblnOS = True Then
            If Length(mstrIDArticulo) > 0 Then
                cmdSearch.Enabled = False
                advArticulo.Enabled = False
                txtDescArticulo.Enabled = False
                advArticulo.Text = mstrIDArticulo
                Dim art As New Articulo
                Dim dtArt As DataTable = art.SelOnPrimaryKey(mstrIDArticulo)
                If Not IsNothing(dtArt) AndAlso dtArt.Rows.Count > 0 Then txtDescArticulo.Text = dtArt.Rows(0)("DescArticulo")
            End If
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        If Len(advArticulo.Text) > 0 Or Len(txtDescArticulo.Text) > 0 Then
            Dim f As New Filter
            If Len(advArticulo.Text) > 0 Then
                f.Add(New StringFilterItem("IDArticulo", advArticulo.Text))
            End If
            If Len(txtDescArticulo.Text) > 0 Then
                f.Add(New LikeFilterItem("DescArticulo", txtDescArticulo.Text, True))
            End If
            Grid.DataSource = Me.Filtrar(f)
        End If
    End Sub

    Private Function Filtrar(ByVal f As Filter) As DataTable
        Dim dataSource As DataTable = New BE.DataEngine().Filter("vFrmSeleccionSeries", f)
        Return dataSource
    End Function

    Private Sub advArticulo_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advArticulo.SelectionChanged
        txtDescArticulo.Text = e.Selected.Rows(0)("DescArticulo") & String.Empty
    End Sub

    Private Sub advArticulo_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advArticulo.SetPredefinedFilter
        e.Filter.Add(New BooleanFilterItem("NSerieObligatorio", True))
    End Sub

    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        GridFormatStyle.AplicarFormato(e.Row, e.Row.Cells("IDEstadoActivo").Value)
    End Sub

    Private Sub Grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.DoubleClick
        Dim hit As GridArea
        hit = Grid.HitTest()
        If hit = GridArea.Cell Then
            Me.Close()
            RaiseEvent SeleccionSerie(CType(Grid.GetRow.DataRow, DataRowView).Row)
        End If
    End Sub
End Class
