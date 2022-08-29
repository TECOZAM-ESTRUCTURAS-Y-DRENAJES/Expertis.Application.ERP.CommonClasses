Imports Solmicro.Expertis.Business.Negocio

Imports Janus.Windows.GridEX

Public Class DetalleActualizacionStock
    Inherits System.Windows.Forms.Form

    Private Const IconIndexInfo As Long = 0
    Private Const IconIndexExclamation As Long = 1
    Private Const IconIndexError As Long = 2
    Private Const IconIndexQuestion As Long = 3

    Private mData As DataTable

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        CrearEsquema()
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CloseButton As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Detalle As Janus.Windows.GridEX.GridEX
    Friend WithEvents Icons As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Detalle_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetalleActualizacionStock))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CloseButton = New Solmicro.Expertis.Engine.UI.Button
        Me.Detalle = New Janus.Windows.GridEX.GridEX
        Me.Icons = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CloseButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 306)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 54)
        Me.Panel1.TabIndex = 0
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CloseButton.Location = New System.Drawing.Point(290, 12)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(114, 27)
        Me.CloseButton.TabIndex = 0
        Me.CloseButton.Text = "Cerrar"
        '
        'Detalle
        '
        Me.Detalle.AllowDrop = True
        Me.Detalle.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Detalle_DesignTimeLayout.LayoutString = resources.GetString("Detalle_DesignTimeLayout.LayoutString")
        Me.Detalle.DesignTimeLayout = Detalle_DesignTimeLayout
        Me.Detalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Detalle.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detalle.GridLines = Janus.Windows.GridEX.GridLines.Horizontal
        Me.Detalle.GroupByBoxVisible = False
        Me.Detalle.ImageList = Me.Icons
        Me.Detalle.Location = New System.Drawing.Point(0, 0)
        Me.Detalle.Name = "Detalle"
        Me.Detalle.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Detalle.SelectedFormatStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Detalle.Size = New System.Drawing.Size(700, 306)
        Me.Detalle.TabIndex = 1
        Me.Detalle.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Detalle.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Icons
        '
        Me.Icons.ImageStream = CType(resources.GetObject("Icons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Icons.TransparentColor = System.Drawing.Color.Transparent
        Me.Icons.Images.SetKeyName(0, "")
        Me.Icons.Images.SetKeyName(1, "")
        Me.Icons.Images.SetKeyName(2, "")
        Me.Icons.Images.SetKeyName(3, "")
        '
        'DetalleActualizacionStock
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(700, 360)
        Me.Controls.Add(Me.Detalle)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(708, 387)
        Me.Name = "DetalleActualizacionStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle actualización stock"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public WriteOnly Property DataSource() As Object
        Set(ByVal Value As Object)
            If IsArray(Value) Then
                For Each item As Object In Value
                    If Not item Is Nothing Then
                        If item.GetType Is GetType(StockUpdateData) Then
                            Add(CType(item, StockUpdateData))
                        End If
                    End If
                Next
            ElseIf Value.GetType Is GetType(StockUpdateData) Then
                Add(CType(Value, StockUpdateData))
            End If
        End Set
    End Property

    Private Sub Add(ByVal data As StockUpdateData)
        If Len(data.Detalle) > 0 Then
            Dim newrow As DataRow = mData.NewRow
            newrow("IDArticulo") = data.StockData.Articulo
            newrow("IDAlmacen") = data.StockData.Almacen
            newrow("Lote") = data.StockData.Lote
            newrow("Ubicacion") = data.StockData.Ubicacion
            newrow("Detalle") = data.Detalle
            newrow("EstadoStock") = data.Estado
            mData.Rows.Add(newrow)
        End If
    End Sub

    Private Sub CrearEsquema()
        mData = New DataTable
        mData.Columns.Add("IDArticulo", GetType(String))
        mData.Columns.Add("IDAlmacen", GetType(String))
        mData.Columns.Add("Lote", GetType(String))
        mData.Columns.Add("Ubicacion", GetType(String))
        mData.Columns.Add("Detalle", GetType(String))
        mData.Columns.Add("EstadoStock", GetType(Integer))
    End Sub

    Private Sub DetalleActualizacionStock_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Detalle.TabKeyBehavior = TabKeyBehavior.ControlNavigation
        Detalle.Tables(0).SortKeys.Add(New GridEXSortKey(Detalle.RootTable.Columns("IDArticulo"), SortOrder.Ascending))
        Detalle.DataSource = mData
    End Sub

    Private Sub DetalleActualizacionStock_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        CloseButton.Focus()
    End Sub

    Private Sub CloseButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub Detalle_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Detalle.FormattingRow
        Dim estado As EstadoStock = e.Row.Cells("EstadoStock").Value

        Select Case estado
            Case EstadoStock.Actualizado
                e.Row.Cells("Icon").ImageIndex = IconIndexInfo
            Case EstadoStock.NoActualizado
                e.Row.Cells("Icon").ImageIndex = IconIndexError
                e.Row.Cells("Detalle").FormatStyle = Detalle.FormatStyles("NoActualizado")
            Case EstadoStock.SinGestion
                e.Row.Cells("Icon").ImageIndex = IconIndexExclamation
                e.Row.Cells("Detalle").FormatStyle = Detalle.FormatStyles("NoActualizado")
        End Select
    End Sub
End Class
