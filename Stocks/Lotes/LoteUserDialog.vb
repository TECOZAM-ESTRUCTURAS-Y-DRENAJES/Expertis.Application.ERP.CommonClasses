Option Explicit On 
Option Compare Text

Public Class LoteUserDialog
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    Private mUpdateDDBB As Boolean
    Private mQueryOnClose As Boolean
    Private mQueryOnClose2 As Boolean
    Private mReadOnly As Boolean
    Private mArticulo As String
    Private mAlmacen As String
    Private mText As String
    Public WithEvents ntbStockFisico2 As Solmicro.Expertis.Engine.UI.NumericTextBox

    Protected Event AddingRecord As System.ComponentModel.CancelEventHandler
    Protected Event CancelingCellEdit As Janus.Windows.GridEX.ColumnActionCancelEventHandler
    Protected Event CancelingRowEdit As Janus.Windows.GridEX.RowActionCancelEventHandler
    Protected Event CellEditCancelled As Janus.Windows.GridEX.ColumnActionEventHandler
    Protected Event CellEdited As Janus.Windows.GridEX.ColumnActionEventHandler
    Protected Event CellUpdated As Janus.Windows.GridEX.ColumnActionEventHandler
    Protected Event CellValueChanged As Janus.Windows.GridEX.ColumnActionEventHandler
    Protected Shadows Event Click As EventHandler
    Protected Event ColumnButtonClick As Janus.Windows.GridEX.ColumnActionEventHandler
    Protected Event GenerarNLotesClick As Janus.Windows.GridEX.ColumnActionEventHandler
    Protected Event DeletingRecords As System.ComponentModel.CancelEventHandler
    Protected Event EditingCell As Janus.Windows.GridEX.EditingCellEventHandler
    Protected Event FormattingRow As Janus.Windows.GridEX.RowLoadEventHandler
    Protected Event GetNewRow As Janus.Windows.GridEX.GetNewRowEventHandler
    Protected Shadows Event RecordAdded As System.EventHandler
    Protected Event RecordsDeleted As System.EventHandler
    Protected Shadows Event RecordUpdated As System.EventHandler
    Protected Event RowEditCanceled As Janus.Windows.GridEX.RowActionEventHandler
    Protected Event UpdatingCell As Janus.Windows.GridEX.UpdatingCellEventHandler
    Protected Event UpdatingRecord As System.ComponentModel.CancelEventHandler

    Protected mAplicar2Ud As Boolean
    Protected mIDUDInterna As String
    Public WithEvents Panel5 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblEmpezarPor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtNumeracion As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblCodigo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtCodigo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents cmbGenerarLote As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents FraLotesAuto As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents Label5 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtNumLotesGenerar As Solmicro.Expertis.Engine.UI.TextBox
    Protected mIDUDInterna2 As String


    Public Event OkButtonClick As System.ComponentModel.CancelEventHandler
    Public Event CancelButtonClick As System.ComponentModel.CancelEventHandler

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()
        InitializeComponent()

        Grid.AllowAddNew = InheritableBoolean.False
        Grid.AllowDelete = InheritableBoolean.False

        'chkMostrarLotesStockCero.Checked = True
        mText = Me.Text

        LoadLayout()
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
    Public WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents OkButton As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents Panel2 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents Panel3 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents DescArticulo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents DescAlmacen As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents Grid As Janus.Windows.GridEX.GridEX
    Public WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents IDArticulo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents IDAlmacen As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents Icons As System.Windows.Forms.ImageList
    Public WithEvents CancelButton2 As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents chkMostrarLotesStockCero As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents Totales As Janus.Windows.GridEX.GridEX
    Public WithEvents Panel4 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents Label4 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ntbStockFisico As Solmicro.Expertis.Engine.UI.NumericTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoteUserDialog))
        Dim Totales_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.CancelButton2 = New Solmicro.Expertis.Engine.UI.Button
        Me.OkButton = New Solmicro.Expertis.Engine.UI.Button
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.Grid = New Janus.Windows.GridEX.GridEX
        Me.Icons = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel3 = New Solmicro.Expertis.Engine.UI.Panel
        Me.ntbStockFisico2 = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Label4 = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbStockFisico = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.chkMostrarLotesStockCero = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.Panel4 = New Solmicro.Expertis.Engine.UI.Panel
        Me.Panel5 = New Solmicro.Expertis.Engine.UI.Panel
        Me.FraLotesAuto = New Solmicro.Expertis.Engine.UI.Frame
        Me.Label5 = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNumLotesGenerar = New Solmicro.Expertis.Engine.UI.TextBox
        Me.cmbGenerarLote = New Solmicro.Expertis.Engine.UI.Button
        Me.txtNumeracion = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblEmpezarPor = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCodigo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCodigo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Totales = New Janus.Windows.GridEX.GridEX
        Me.Panel2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.DescAlmacen = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.DescArticulo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.IDAlmacen = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.IDArticulo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1.suspendlayout()
        Me.Frame1.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.suspendlayout()
        Me.Panel4.suspendlayout()
        Me.Panel5.suspendlayout()
        Me.FraLotesAuto.SuspendLayout()
        CType(Me.Totales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.suspendlayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CancelButton2)
        Me.Panel1.Controls.Add(Me.OkButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 420)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(770, 65)
        Me.Panel1.TabIndex = 2
        '
        'CancelButton2
        '
        Me.CancelButton2.Location = New System.Drawing.Point(402, 19)
        Me.CancelButton2.Name = "CancelButton2"
        Me.CancelButton2.Size = New System.Drawing.Size(106, 29)
        Me.CancelButton2.TabIndex = 1
        Me.CancelButton2.Text = "Cancelar"
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(262, 19)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(105, 29)
        Me.OkButton.TabIndex = 0
        Me.OkButton.Text = "Aceptar"
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.Grid)
        Me.Frame1.Controls.Add(Me.Panel3)
        Me.Frame1.Controls.Add(Me.Panel4)
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame1.Location = New System.Drawing.Point(0, 49)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(770, 371)
        Me.Frame1.TabIndex = 3
        Me.Frame1.TabStop = False
        '
        'Grid
        '
        Me.Grid.ColumnAutoResize = True
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.GroupByBoxVisible = False
        Me.Grid.HeaderFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Grid.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.Grid.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Grid.ImageList = Me.Icons
        Me.Grid.Location = New System.Drawing.Point(3, 140)
        Me.Grid.Name = "Grid"
        Me.Grid.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.Grid.Size = New System.Drawing.Size(764, 194)
        Me.Grid.TabIndex = 2
        Me.Grid.UpdateOnLeave = False
        Me.Grid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Icons
        '
        Me.Icons.ImageStream = CType(resources.GetObject("Icons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Icons.TransparentColor = System.Drawing.Color.Transparent
        Me.Icons.Images.SetKeyName(0, "")
        Me.Icons.Images.SetKeyName(1, "")
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ntbStockFisico2)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.ntbStockFisico)
        Me.Panel3.Controls.Add(Me.chkMostrarLotesStockCero)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(3, 334)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(764, 34)
        Me.Panel3.TabIndex = 1
        '
        'ntbStockFisico2
        '
        Me.ntbStockFisico2.DisabledBackColor = System.Drawing.Color.White
        Me.ntbStockFisico2.Location = New System.Drawing.Point(140, 8)
        Me.ntbStockFisico2.Name = "ntbStockFisico2"
        Me.ntbStockFisico2.ReadOnly = True
        Me.ntbStockFisico2.Size = New System.Drawing.Size(90, 21)
        Me.ntbStockFisico2.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(3, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Stock"
        '
        'ntbStockFisico
        '
        Me.ntbStockFisico.DisabledBackColor = System.Drawing.Color.White
        Me.ntbStockFisico.Location = New System.Drawing.Point(45, 8)
        Me.ntbStockFisico.Name = "ntbStockFisico"
        Me.ntbStockFisico.ReadOnly = True
        Me.ntbStockFisico.Size = New System.Drawing.Size(90, 21)
        Me.ntbStockFisico.TabIndex = 1
        '
        'chkMostrarLotesStockCero
        '
        Me.chkMostrarLotesStockCero.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.chkMostrarLotesStockCero.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMostrarLotesStockCero.Location = New System.Drawing.Point(568, 9)
        Me.chkMostrarLotesStockCero.Name = "chkMostrarLotesStockCero"
        Me.chkMostrarLotesStockCero.Size = New System.Drawing.Size(186, 16)
        Me.chkMostrarLotesStockCero.TabIndex = 0
        Me.chkMostrarLotesStockCero.Text = "Mostrar lotes con stock cero"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Totales)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 17)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(764, 123)
        Me.Panel4.TabIndex = 9
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.FraLotesAuto)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 74)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(764, 49)
        Me.Panel5.TabIndex = 10
        '
        'FraLotesAuto
        '
        Me.FraLotesAuto.Controls.Add(Me.Label5)
        Me.FraLotesAuto.Controls.Add(Me.txtNumLotesGenerar)
        Me.FraLotesAuto.Controls.Add(Me.cmbGenerarLote)
        Me.FraLotesAuto.Controls.Add(Me.txtNumeracion)
        Me.FraLotesAuto.Controls.Add(Me.lblEmpezarPor)
        Me.FraLotesAuto.Controls.Add(Me.lblCodigo)
        Me.FraLotesAuto.Controls.Add(Me.txtCodigo)
        Me.FraLotesAuto.Location = New System.Drawing.Point(3, 3)
        Me.FraLotesAuto.Name = "FraLotesAuto"
        Me.FraLotesAuto.Size = New System.Drawing.Size(758, 42)
        Me.FraLotesAuto.TabIndex = 11
        Me.FraLotesAuto.TabStop = False
        Me.FraLotesAuto.Text = "Generación Automática de Nº Lotes"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(178, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Nº Lotes a generar"
        '
        'txtNumLotesGenerar
        '
        Me.txtNumLotesGenerar.DisabledBackColor = System.Drawing.Color.White
        Me.txtNumLotesGenerar.Location = New System.Drawing.Point(296, 13)
        Me.txtNumLotesGenerar.Name = "txtNumLotesGenerar"
        Me.txtNumLotesGenerar.Size = New System.Drawing.Size(66, 21)
        Me.txtNumLotesGenerar.TabIndex = 0
        '
        'cmbGenerarLote
        '
        Me.cmbGenerarLote.Icon = CType(resources.GetObject("cmbGenerarLote.Icon"), System.Drawing.Icon)
        Me.cmbGenerarLote.Location = New System.Drawing.Point(729, 13)
        Me.cmbGenerarLote.Name = "cmbGenerarLote"
        Me.cmbGenerarLote.Size = New System.Drawing.Size(21, 21)
        Me.cmbGenerarLote.TabIndex = 3
        '
        'txtNumeracion
        '
        Me.txtNumeracion.DecimalDigits = 0
        Me.txtNumeracion.DisabledBackColor = System.Drawing.Color.White
        Me.txtNumeracion.Location = New System.Drawing.Point(643, 13)
        Me.txtNumeracion.Name = "txtNumeracion"
        Me.txtNumeracion.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtNumeracion.Size = New System.Drawing.Size(82, 21)
        Me.txtNumeracion.TabIndex = 2
        '
        'lblEmpezarPor
        '
        Me.lblEmpezarPor.Location = New System.Drawing.Point(543, 17)
        Me.lblEmpezarPor.Name = "lblEmpezarPor"
        Me.lblEmpezarPor.Size = New System.Drawing.Size(96, 13)
        Me.lblEmpezarPor.TabIndex = 24
        Me.lblEmpezarPor.Text = "Empezar por ..."
        '
        'lblCodigo
        '
        Me.lblCodigo.Location = New System.Drawing.Point(372, 17)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(47, 13)
        Me.lblCodigo.TabIndex = 22
        Me.lblCodigo.Text = "Código"
        '
        'txtCodigo
        '
        Me.txtCodigo.DisabledBackColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(427, 13)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(109, 21)
        Me.txtCodigo.TabIndex = 1
        '
        'Totales
        '
        Me.Totales.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Totales.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Totales.ColumnAutoResize = True
        Totales_DesignTimeLayout.LayoutString = resources.GetString("Totales_DesignTimeLayout.LayoutString")
        Me.Totales.DesignTimeLayout = Totales_DesignTimeLayout
        Me.Totales.Enabled = False
        Me.Totales.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Totales.GroupByBoxVisible = False
        Me.Totales.HeaderFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Totales.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.Totales.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Totales.Location = New System.Drawing.Point(80, 10)
        Me.Totales.Name = "Totales"
        Me.Totales.ScrollBars = Janus.Windows.GridEX.ScrollBars.None
        Me.Totales.Size = New System.Drawing.Size(604, 58)
        Me.Totales.TabIndex = 8
        Me.Totales.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DescAlmacen)
        Me.Panel2.Controls.Add(Me.DescArticulo)
        Me.Panel2.Controls.Add(Me.IDAlmacen)
        Me.Panel2.Controls.Add(Me.IDArticulo)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(770, 49)
        Me.Panel2.TabIndex = 0
        '
        'DescAlmacen
        '
        Me.DescAlmacen.Location = New System.Drawing.Point(200, 23)
        Me.DescAlmacen.Name = "DescAlmacen"
        Me.DescAlmacen.Size = New System.Drawing.Size(487, 22)
        Me.DescAlmacen.TabIndex = 5
        Me.DescAlmacen.Text = "Descripción de Almacén"
        '
        'DescArticulo
        '
        Me.DescArticulo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DescArticulo.Location = New System.Drawing.Point(200, 2)
        Me.DescArticulo.Name = "DescArticulo"
        Me.DescArticulo.Size = New System.Drawing.Size(487, 20)
        Me.DescArticulo.TabIndex = 4
        Me.DescArticulo.Text = "Descripción de Artículo"
        '
        'IDAlmacen
        '
        Me.IDAlmacen.ForeColor = System.Drawing.Color.MediumBlue
        Me.IDAlmacen.Location = New System.Drawing.Point(68, 28)
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
        Me.Label1.Location = New System.Drawing.Point(10, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Artículo: "
        '
        'LoteUserDialog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(770, 485)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.MinimumSize = New System.Drawing.Size(711, 426)
        Me.Name = "LoteUserDialog"
        Me.Text = "Lotes"
        Me.Panel1.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.FraLotesAuto.ResumeLayout(False)
        Me.FraLotesAuto.PerformLayout()
        CType(Me.Totales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected Overridable Sub OnAddingRecord(ByVal e As System.ComponentModel.CancelEventArgs)
        RaiseEvent AddingRecord(Me, e)
    End Sub

    Protected Overridable Sub OnCancelingCellEdit(ByVal e As Janus.Windows.GridEX.ColumnActionCancelEventArgs)
        RaiseEvent CancelingCellEdit(Me, e)
    End Sub

    Protected Overridable Sub OnCellEditCancelled(ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)
        RaiseEvent CellEditCancelled(Me, e)
    End Sub

    Protected Overridable Sub OnCellEdited(ByVal e As System.EventArgs)
        RaiseEvent CellEdited(Me, e)
    End Sub

    Protected Overridable Sub OnCellUpdated(ByVal e As System.EventArgs)
        RaiseEvent CellUpdated(Me, e)
    End Sub

    Protected Overridable Sub OnCancelingRowEdit(ByVal e As Janus.Windows.GridEX.RowActionCancelEventArgs)
        RaiseEvent CancelingRowEdit(Me, e)
    End Sub

    Protected Overridable Sub OnCellValueChanged(ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)
        RaiseEvent CellValueChanged(Me, e)
    End Sub

    Protected Overridable Shadows Sub OnClick(ByVal e As System.EventArgs)
        RaiseEvent Click(Me, e)
    End Sub

    Protected Overridable Sub OnColumnButtonClick(ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)
        RaiseEvent ColumnButtonClick(Me, e)
    End Sub

    Protected Overridable Sub OnDeletingRecords(ByVal e As System.ComponentModel.CancelEventArgs)
        RaiseEvent DeletingRecords(Me, e)
    End Sub

    Protected Overridable Sub OnEditingCell(ByVal e As Janus.Windows.GridEX.EditingCellEventArgs)
        RaiseEvent EditingCell(Me, e)
    End Sub

    Protected Overridable Sub OnFormattingRow(ByVal e As Janus.Windows.GridEX.RowLoadEventArgs)
        RaiseEvent FormattingRow(Me, e)
    End Sub

    Protected Overridable Sub OnGetNewRow(ByVal e As Janus.Windows.GridEX.GetNewRowEventArgs)
        RaiseEvent GetNewRow(Me, e)
    End Sub

    Protected Overridable Shadows Sub OnRecordAdded(ByVal e As System.EventArgs)
        RaiseEvent RecordAdded(Me, e)
    End Sub

    Protected Overridable Sub OnRecordsDeleted(ByVal e As System.EventArgs)
        RaiseEvent RecordsDeleted(Me, e)
    End Sub

    Protected Overridable Shadows Sub OnRecordUpdated(ByVal e As System.EventArgs)
        RaiseEvent RecordUpdated(Me, e)
    End Sub

    Protected Overridable Sub OnRowEditCanceled(ByVal e As Janus.Windows.GridEX.RowActionEventArgs)
        RaiseEvent RowEditCanceled(Me, e)
    End Sub

    Protected Overridable Sub OnUpdatingCell(ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs)
        RaiseEvent UpdatingCell(Me, e)
    End Sub

    Protected Overridable Sub OnUpdatingRecord(ByVal e As System.ComponentModel.CancelEventArgs)
        RaiseEvent UpdatingRecord(Me, e)
    End Sub

    Protected Overridable Sub OnOkButtonClick(ByVal e As System.ComponentModel.CancelEventArgs)
        RaiseEvent OkButtonClick(Me, e)
    End Sub

    Protected Overridable Sub OnCancelButtonClick(ByVal e As System.ComponentModel.CancelEventArgs)
        RaiseEvent CancelButtonClick(Me, e)
    End Sub

    Public Property MostrarLotesStockCero() As Boolean
        Get
            Return chkMostrarLotesStockCero.Checked
        End Get
        Set(ByVal Value As Boolean)
            chkMostrarLotesStockCero.Checked = Value
        End Set
    End Property

    Public Property TitleText() As String
        Get
            Return mText
        End Get
        Set(ByVal value As String)
            mText = value
        End Set
    End Property

    Public Property [ReadOnly]() As Boolean
        Get
            Return mReadOnly
        End Get
        Set(ByVal Value As Boolean)
            mReadOnly = Value
            If mReadOnly Then
                Grid.AllowEdit = InheritableBoolean.False
            Else
                Grid.AllowEdit = InheritableBoolean.True
            End If
        End Set
    End Property

    Protected Property QueryOnClose() As Boolean
        Get
            Return mQueryOnClose2
        End Get
        Set(ByVal Value As Boolean)
            mQueryOnClose2 = Value
        End Set
    End Property

    Protected Property Articulo() As String
        Get
            Return mArticulo
        End Get
        Set(ByVal Value As String)
            mArticulo = Value
        End Set
    End Property

    Protected Property Almacen() As String
        Get
            Return mAlmacen
        End Get
        Set(ByVal Value As String)
            mAlmacen = Value
        End Set
    End Property

    Public Shadows Function ShowDialog(ByVal Articulo As String, ByVal Almacen As String) As DialogResult
        Try
            mArticulo = Articulo
            mAlmacen = Almacen
            Me.LoadData()
            MyBase.ShowDialog()
            Return Me.DialogResult
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Protected Shadows Function ShowDialog() As DialogResult
        Return MyBase.ShowDialog()
    End Function

    Protected Overridable Sub LoadData()
        If Len(mArticulo) > 0 And Len(mAlmacen) > 0 Then
            Dim f As New Filter
            f.Add(New StringFilterItem("IDArticulo", mArticulo))
            f.Add(New StringFilterItem("IDAlmacen", mAlmacen))
            Dim AAL As New ArticuloAlmacenLote
            Grid.DataSource = CType(AAL.Filter(f), DataTable)
            FiltrarLote()
        End If
        CrearTotales()
    End Sub

    Protected Overridable Sub FiltrarLote()
        Grid.UpdateData()
        Dim dt As DataTable = Grid.DataSource
        If Not chkMostrarLotesStockCero.Checked Then
            Dim f As New Filter(FilterUnionOperator.Or)
            f.Add("StockFisico", FilterOperator.NotEqual, 0, FilterType.Numeric)
            If mAplicar2Ud Then f.Add("StockFisico2", FilterOperator.NotEqual, 0, FilterType.Numeric)
            'f.Add("Cantidad", FilterOperator.GreaterThan, 0)
            dt.DefaultView.RowFilter = f.Compose(New AdoFilterComposer)
            Grid.DataSource = dt
        Else
            If Not dt Is Nothing Then
                dt.DefaultView.RowFilter = Nothing
                Grid.DataSource = dt
            End If
        End If
    End Sub

    Protected Overridable Sub CrearTotales()
        ntbStockFisico.Value = Grid.GetTotal(Grid.RootTable.Columns("StockFisico"), AggregateFunction.Sum)
    End Sub

    Protected Overridable Sub LoadLayout()
        Panel4.Visible = False
        Panel4.Height = 0
    End Sub

    Private Sub LoteUserDialog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mQueryOnClose = False
        mQueryOnClose2 = False
        Me.DialogResult = DialogResult.None

        If Not Me.DesignMode Then
            IDArticulo.Text = Nothing
            IDAlmacen.Text = Nothing
            DescArticulo.Text = Nothing
            DescAlmacen.Text = Nothing
            If Len(mArticulo) > 0 And Len(mAlmacen) > 0 Then
                ' SettingDobleUnidad()
                IDArticulo.Text = mArticulo
                IDAlmacen.Text = mAlmacen

                Dim dt As DataTable
                dt = New Articulo().SelOnPrimaryKey(mArticulo)
                If dt.Rows.Count > 0 Then
                    DescArticulo.Text = dt.Rows(0)("DescArticulo")
                    If mAplicar2Ud Then
                        mIDUDInterna = dt.Rows(0)("IDUDInterna")
                        mIDUDInterna2 = dt.Rows(0)("IDUDInterna2")
                    End If
                End If
                dt = New Almacen().SelOnPrimaryKey(mAlmacen)
                If dt.Rows.Count > 0 Then
                    DescAlmacen.Text = dt.Rows(0)("DescAlmacen")
                End If
            End If

            Me.txtNumLotesGenerar.Text = Nothing
            Me.txtCodigo.Text = Nothing
            Me.txtNumeracion.Text = 0
        End If

        If mReadOnly Then
            Me.Text = String.Concat(mText, " - [Sólo lectura]")
        Else
            Me.Text = mText
        End If
    End Sub

    Private Sub Grid_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.CellUpdated
        If e.Column.Key = "FechaCaducidad" Or e.Column.Key = "Bloqueado" Or e.Column.Key = "Observaciones" Then
            mUpdateDDBB = True
            mQueryOnClose = True
        End If
        Me.OnCellUpdated(e)
    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton2.Click
        Dim Cancel As Boolean
        If Grid.DataChanged Or mQueryOnClose Then
            Cancel = (ExpertisApp.GenerateMessage("Las modificaciones realizadas no se grabarán en la Base de Datos.|¿Cancelar de todas formas?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, vbNewLine) = DialogResult.No)
        ElseIf Grid.DataChanged Or mQueryOnClose2 Then
            Cancel = (ExpertisApp.GenerateMessage("Perderá el desglose de cantidades realizado.|¿Cancelar de todas formas?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, vbNewLine) = DialogResult.No)
        End If
        If Not Cancel Then
            Dim lote As DataTable = (CType(Grid.DataSource, DataTable))
            lote.RejectChanges()
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If

        Dim e2 As New System.ComponentModel.CancelEventArgs
        Me.OnCancelButtonClick(e2)
    End Sub

    Private Sub Grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        Me.OnEditingCell(e)
    End Sub

    Private Sub Grid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.Click
        Try
            If Not mReadOnly Then
                Dim hit As GridArea
                hit = Grid.HitTest()
                If hit = GridArea.Cell Then
                    Dim c As GridEXColumn = Grid.ColumnFromPoint()
                    If Not IsNothing(c) Then
                        Select Case c.Key
                            Case "IconoObservaciones"
                                Dim frm As New FormularioTexto
                                frm.Texto = Grid.GetValue("Observaciones") & String.Empty
                                Dim IntPos As Integer = Grid.Row
                                If frm.ShowDialog() = DialogResult.OK Then
                                    Grid.Row = IntPos
                                    If Grid.GetValue("Observaciones") & String.Empty <> frm.Texto Then
                                        mUpdateDDBB = True
                                        Grid.SetValue("Observaciones", frm.Texto)
                                    End If
                                End If
                                frm.Dispose()
                        End Select
                    End If
                End If
            End If

            Me.OnClick(e)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        Me.OnFormattingRow(e)
    End Sub

    Private Sub OkButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OkButton.Click
        If mReadOnly Then
            Me.DialogResult = DialogResult.None
            Me.Close()
        Else
            If Not ValidarCantidades() Then Exit Sub
            Grid.UpdateData()
            Dim e2 As New System.ComponentModel.CancelEventArgs
            Me.OnOkButtonClick(e2)
            If Not e2.Cancel Then
                Dim lote As DataTable = (CType(Grid.DataSource, DataTable))
                If mUpdateDDBB Then
                    Dim dt As DataTable = (CType(Grid.DataSource, DataTable)).Copy
                    Dim dv As New DataView(dt, Nothing, Nothing, DataViewRowState.OriginalRows + DataViewRowState.Added)

                    If dv.Count > 0 Then
                        Dim dtToUpdate As DataTable
                        dtToUpdate = dt.Clone
                        Dim aal As New ArticuloAlmacenLote
                        Try
                            For Each drv As DataRowView In dv
                                If drv.Row.RowState = DataRowState.Modified OrElse drv.Row.RowState = DataRowState.Added Then
                                    dtToUpdate.ImportRow(drv.Row)
                                    aal.Update(dtToUpdate)
                                    dtToUpdate.Rows.Clear()
                                End If
                            Next
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                        dtToUpdate.Dispose()
                    End If
                End If
                lote.AcceptChanges()
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Function ValidarCantidades() As Boolean
        ValidarCantidades = True
        If mAplicar2Ud Then
            Dim lotes As DataTable = (CType(Grid.DataSource, DataTable))
            For Each lt As DataRow In lotes.Rows
                '//Si se ha indicado la cantidad2, debe indicar la cantidad
                If lt("Cantidad2") <> 0 AndAlso lt("Cantidad") = 0 Then
                    ValidarCantidades = False
                    ExpertisApp.GenerateMessage("Si ha indicado cantidad para la segunda unidad, debe indicar para la primera unidad.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Function
                End If
            Next
        End If
    End Function

    Private Sub chkMostrarLotesStockCero_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMostrarLotesStockCero.CheckedChanged
        FiltrarLote()
    End Sub

    Private Sub Grid_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles Grid.UpdatingCell
        Me.OnUpdatingCell(e)
    End Sub

    Private Sub Grid_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Grid.AddingRecord
        Me.OnAddingRecord(e)
    End Sub

    Private Sub Grid_CancelingCellEdit(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionCancelEventArgs) Handles Grid.CancelingCellEdit
        Me.OnCancelingCellEdit(e)
    End Sub

    Private Sub Grid_CancelingRowEdit(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionCancelEventArgs) Handles Grid.CancelingRowEdit
        Me.OnCancelingRowEdit(e)
    End Sub

    Private Sub Grid_CellEditCanceled(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.CellEditCanceled
        Me.OnCellEditCancelled(e)
    End Sub

    Private Sub Grid_CellEdited(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.CellEdited
        Me.OnCellEdited(e)
    End Sub

    Private Sub Grid_CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.CellValueChanged
        Me.OnCellValueChanged(e)
    End Sub

    Private Sub Grid_DeletingRecords(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Grid.DeletingRecords
        Me.OnDeletingRecords(e)
    End Sub

    Private Sub Grid_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.RecordAdded
        Me.OnRecordAdded(e)
    End Sub

    Private Sub Grid_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.RecordsDeleted
        Me.OnRecordsDeleted(e)
    End Sub

    Private Sub Grid_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.RecordUpdated
        Me.OnRecordUpdated(e)
    End Sub

    Private Sub Grid_RowEditCanceled(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles Grid.RowEditCanceled
        Me.OnRowEditCanceled(e)
    End Sub

    Private Sub Grid_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Grid.UpdatingRecord
        Me.OnUpdatingRecord(e)
    End Sub

    Private Sub Grid_GetNewRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.GetNewRowEventArgs) Handles Grid.GetNewRow
        Me.OnGetNewRow(e)
    End Sub

    Private Sub LoteUserDialog_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If Grid.AllowAddNew = InheritableBoolean.True Then
            Grid.Focus()
            Grid.Row = Grid.newTopRowPosition
            Grid.CurrentColumn = Grid.RootTable.Columns("Lote")
        End If
    End Sub

    Protected Sub SettingDobleUnidad()
        If Length(mArticulo) > 0 Then
            mAplicar2Ud = ExpertisApp.ExecuteTask(Of String, Boolean)(AddressOf ProcesoComunes.AplicarSegundaUnidad, mArticulo)
            SettingGridTotales()
            SettingGridLotes()
            ntbStockFisico2.Visible = (ntbStockFisico.Visible AndAlso mAplicar2Ud)
        End If
    End Sub

    Private Sub SettingGridTotales()
        '//Visualizamos las columnas de la segunda unidad
        Dim Cols As GridEXColumnCollection = Me.Totales.RootTable.Columns
        If Cols.Contains("StockActual2") Then Cols("StockActual2").Visible = mAplicar2Ud
        If Cols.Contains("CantidadAsignar2") Then Cols("CantidadAsignar2").Visible = mAplicar2Ud
        If Cols.Contains("CantidadAsignada2") Then Cols("CantidadAsignada2").Visible = mAplicar2Ud
        If Cols.Contains("Diferencia2") Then Cols("Diferencia2").Visible = mAplicar2Ud

        Dim ColSets As GridEXColumnSetCollection = Me.Totales.RootTable.ColumnSets

        If mAplicar2Ud Then
            If ColSets.Count > 0 Then
                '//cambiamos los caption
                CambiarCaption(Totales)
                CambiarCaption(Grid)

                '//Visualizamos las cabeceras de las columnas (dentro del ColumnSet)
                Me.Totales.RootTable.ColumnHeaders = InheritableBoolean.True

                '//Reposicionamos y redimensionamos para que quede centrado
                Me.Totales.Top = 4
                Me.Totales.Height = 58

                '//Añadimos la segunda columna de los ColumnSet
                ColSets("StockActualDoble").ColumnCount = 2
                ColSets("StockActualDoble").Add(Cols("StockActual2"), 0, 1)

                ColSets("QAsignarDoble").ColumnCount = 2
                ColSets("QAsignarDoble").Add(Cols("CantidadAsignar2"), 0, 1)

                ColSets("QAsignadaDoble").ColumnCount = 2
                ColSets("QAsignadaDoble").Add(Cols("CantidadAsignada2"), 0, 1)

                ColSets("DiferenciaDoble").ColumnCount = 2
                ColSets("DiferenciaDoble").Add(Cols("Diferencia2"), 0, 1)
            End If
        Else
            If ColSets.Count > 0 Then
                '//Ocultamos las cabeceras de las columnas (dentro del ColumnSet)
                Me.Totales.RootTable.ColumnHeaders = InheritableBoolean.False

                '//Reposicionamos y redimensionamos para que quede centrado
                Me.Totales.Top = 9
                Me.Totales.Height = 40

                '//Dejamos la primera columna de los ColumnSet
                ColSets("StockActualDoble").ColumnCount = 1
                ColSets("QAsignarDoble").ColumnCount = 1
                ColSets("QAsignadaDoble").ColumnCount = 1
                ColSets("DiferenciaDoble").ColumnCount = 1
            End If
        End If
    End Sub

    Private Sub CambiarCaption(ByVal grid As GridEX)
        If grid.Name = "Totales" Then
            grid.RootTable.Columns("StockActual").Caption = mIDUDInterna
            grid.RootTable.Columns("StockActual2").Caption = mIDUDInterna2
            grid.RootTable.Columns("CantidadAsignar").Caption = mIDUDInterna
            grid.RootTable.Columns("CantidadAsignar2").Caption = mIDUDInterna2
            grid.RootTable.Columns("CantidadAsignada").Caption = mIDUDInterna
            grid.RootTable.Columns("CantidadAsignada2").Caption = mIDUDInterna2
            grid.RootTable.Columns("Diferencia").Caption = mIDUDInterna
            grid.RootTable.Columns("Diferencia2").Caption = mIDUDInterna2
        End If
    End Sub

    Protected Overridable Sub SettingGridLotes()
        Grid.RootTable.Columns("StockFisico2").Visible = mAplicar2Ud
        Grid.RootTable.Columns("Cantidad2").Visible = mAplicar2Ud

        If mAplicar2Ud Then
            Grid.RootTable.Columns("StockFisico").Caption = "Stock Actual"
            Grid.RootTable.Columns("Cantidad").Caption = "Cantidad"

            Grid.RootTable.CellLayoutMode = CellLayoutMode.UseColumnSets

            Grid.RootTable.ColumnSets.Clear()
            Dim Cols As GridEXColumnCollection = Me.Grid.RootTable.Columns
            If Cols.Contains("StockFisico2") Then Cols("StockFisico2").Visible = mAplicar2Ud
            If Cols.Contains("Cantidad2") Then Cols("Cantidad2").Visible = mAplicar2Ud


            Cols("IconoObservaciones").Width = 20
            Cols("Bloqueado").Width = 20

            For Each col As GridEXColumn In Grid.RootTable.Columns
                If col.Visible Then
                    If col.Key <> "StockFisico" AndAlso col.Key <> "StockFisico2" AndAlso _
                       col.Key <> "Cantidad" AndAlso col.Key <> "Cantidad2" Then
                        AddColumnSet(Me.Grid, col, 1, col.Key)
                    ElseIf col.Key = "StockFisico" Then
                        AddColumnSet(Me.Grid, col, 2, "StockFisicoDoble", Grid.RootTable.Columns("StockFisico2"))
                    ElseIf col.Key = "Cantidad" Then
                        AddColumnSet(Me.Grid, col, 2, "CantidadDoble", Grid.RootTable.Columns("Cantidad2"))
                    End If
                End If
            Next
        Else
            Grid.RootTable.CellLayoutMode = CellLayoutMode.UseColumns
            Grid.RootTable.Columns("StockFisico").Caption = "Stock Actual"
            Grid.RootTable.Columns("Cantidad").Caption = "Cantidad"
        End If

    End Sub

    Private Sub AddColumnSet(ByVal g As GridEX, ByVal col1 As GridEXColumn, ByVal ColumnCount As Integer, ByVal key As String, Optional ByVal col2 As GridEXColumn = Nothing)
        If ColumnCount <> 0 Then
            Grid.RootTable.ColumnSetRowCount = 1
            Grid.RootTable.ColumnSetHeaderLines = 1
            Grid.RootTable.HeaderLines = 1

            Dim cs As New GridEXColumnSet
            cs.ColumnCount = ColumnCount
            cs.Key = key
            If Not col1.AllowSize Then
                cs.Width = col1.Width
                cs.AllowSize = col1.AllowSize
            End If
            Grid.RootTable.ColumnSets.Add(cs)
            Grid.RootTable.ColumnSets(cs.Key).Add(col1, 0, 0)
            If ColumnCount = 2 AndAlso Not col2 Is Nothing Then
                Grid.RootTable.ColumnSets(cs.Key).Width = 160
                Grid.RootTable.ColumnSets(cs.Key).Add(col2, 0, 1)
                '//Títulos de Stock Actual y Cantidad
                Grid.RootTable.ColumnSets(cs.Key).Caption = col1.Caption
                Grid.RootTable.ColumnSets(cs.Key).HeaderAlignment = TextAlignment.Center
                col1.Caption = mIDUDInterna
                col1.HeaderAlignment = TextAlignment.Center
                col2.Caption = mIDUDInterna2
                col2.HeaderAlignment = TextAlignment.Center
            End If
        End If
    End Sub

    Private Sub cmbGenerarLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGenerarLote.Click
        RaiseEvent GenerarNLotesClick(sender, Nothing)
    End Sub
End Class