Public Class NSerieSituacion
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    Private mIDArticulo As String
    Private mFilter As Filter

#Region " Código generado por el Diseñador de Windows Forms "

    Friend Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        mFilter = New Filter
    End Sub

    Public Sub New(ByVal IDArticulo As String)
        Me.New()
        mIDArticulo = IDArticulo
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
    Friend WithEvents Panel2 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents DescArticulo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents IDArticulo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Private WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Private WithEvents OkButton As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Panel3 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents lblRecordcount As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NSerieSituacion))
        Me.Panel2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblRecordcount = New Solmicro.Expertis.Engine.UI.Label
        Me.DescArticulo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.IDArticulo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.OkButton = New Solmicro.Expertis.Engine.UI.Button
        Me.Panel3 = New Solmicro.Expertis.Engine.UI.Panel
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel2.suspendlayout()
        Me.Panel1.suspendlayout()
        Me.Panel3.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblRecordcount)
        Me.Panel2.Controls.Add(Me.DescArticulo)
        Me.Panel2.Controls.Add(Me.IDArticulo)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(808, 32)
        Me.Panel2.TabIndex = 2
        '
        'lblRecordcount
        '
        Me.lblRecordcount.Location = New System.Drawing.Point(680, 8)
        Me.lblRecordcount.Name = "lblRecordcount"
        Me.lblRecordcount.Size = New System.Drawing.Size(96, 13)
        Me.lblRecordcount.TabIndex = 5
        Me.lblRecordcount.Text = "<Recordcount>"
        Me.lblRecordcount.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        'IDArticulo
        '
        Me.IDArticulo.ForeColor = System.Drawing.Color.MediumBlue
        Me.IDArticulo.Location = New System.Drawing.Point(68, 5)
        Me.IDArticulo.Name = "IDArticulo"
        Me.IDArticulo.Size = New System.Drawing.Size(127, 17)
        Me.IDArticulo.TabIndex = 2
        Me.IDArticulo.Text = "ID Articulo"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Artículo: "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.OkButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 382)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 48)
        Me.Panel1.TabIndex = 4
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(352, 10)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(105, 29)
        Me.OkButton.TabIndex = 0
        Me.OkButton.Text = "Aceptar"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Grid)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(808, 350)
        Me.Panel3.TabIndex = 5
        '
        'Grid
        '
        Me.Grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        Me.Grid.ColumnAutoResize = True
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = ""
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.GroupTotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.Grid.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.Grid.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = ""
        Me.Grid.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.SecondaryDataFields = ""
        Me.Grid.Size = New System.Drawing.Size(808, 350)
        Me.Grid.TabIndex = 3
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UpdateOnLeave = False
        Me.Grid.ViewName = ""
        '
        'NSerieSituacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(808, 430)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.MinimumSize = New System.Drawing.Size(816, 464)
        Me.Name = "NSerieSituacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Números de Serie - Situación"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
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

    Private Sub OkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkButton.Click
        Me.Close()
    End Sub

    Private Sub NSerieSituacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IDArticulo.Text = Nothing
        DescArticulo.Text = Nothing

        If Len(mIDArticulo) > 0 Then
            IDArticulo.Text = mIDArticulo

            Dim dt As DataTable = New Articulo().SelOnPrimaryKey(mIDArticulo)
            If dt.Rows.Count > 0 Then
                DescArticulo.Text = dt.Rows(0)("DescArticulo")
            End If

            Dim activos As Boolean = New Parametro().GestionNumeroSerieConActivos()
            If Not activos Then
                Grid.Columns("IDActivo").Visible = False
                Grid.Columns("DescActivo").Visible = False
            End If

            GridFormatStyle.CrearFormatos(Grid, GridFormatStyle.TipoFormato.EstadoActivo)

            Dim de As New BE.DataEngine
            Dim f As New Filter
            f.Add(New StringFilterItem("IDArticulo", mIDArticulo))
            If mFilter.Count > 0 Then
                Dim ie As IEnumerator = mFilter.GetEnumerator
                Do While ie.MoveNext
                    f.Add(CType(ie.Current, IFilter))
                Loop
            End If
            Dim dataSource As DataTable = de.Filter("vFrmSituacionSeries", f)
            Grid.DataSource = dataSource

            lblRecordcount.Text = String.Concat(Grid.RecordCount, " números de serie")
        End If
    End Sub

    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        GridFormatStyle.AplicarFormato(e.Row, e.Row.Cells("IDEstadoActivo").Value)
    End Sub

    Private Sub Grid_GroupsChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.GroupsChangedEventArgs) Handles Grid.GroupsChanged
        Grid.CollapseGroups()
    End Sub
End Class
