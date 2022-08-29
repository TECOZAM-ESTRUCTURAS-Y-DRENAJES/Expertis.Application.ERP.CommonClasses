
Public Class FrmAnalisisRiesgoAlquiler
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    Friend WithEvents cmbImprimir As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents gridPedidos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents gridAlbaranes As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents gridFacturas As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents gridCobros As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents gridAlquiler As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents lblFacturacionMaterialAlquilado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTotalAlquiler As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblTotalAlquiler As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDescCliente As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtIDCliente As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtRiesgoConsumido As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblRiesgoConsumido As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtRiesgoPendiente As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblRiesgoPendiente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtRiesgoConcedido As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblRiesgoConcedido As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTotalPedidos As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblTotalPedidos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTotalAlbaranes As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblTotalAlbaranes As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTotalFacturas As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblTotalFacturas As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTotalCobros As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblTotalCobros As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblCobros As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFacturas As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblAlbaranes As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblPedidos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents WLCab As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents WLGrid As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblEntregasACuentaPend As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtEntregasACuentaPend As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents pctPeligro As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAnalisisRiesgoAlquiler))
        Dim gridPedidos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim gridAlbaranes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim gridFacturas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim gridCobros_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim gridAlquiler_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.cmbImprimir = New Solmicro.Expertis.Engine.UI.Button
        Me.gridPedidos = New Solmicro.Expertis.Engine.UI.Grid
        Me.gridAlbaranes = New Solmicro.Expertis.Engine.UI.Grid
        Me.gridFacturas = New Solmicro.Expertis.Engine.UI.Grid
        Me.gridCobros = New Solmicro.Expertis.Engine.UI.Grid
        Me.gridAlquiler = New Solmicro.Expertis.Engine.UI.Grid
        Me.lblFacturacionMaterialAlquilado = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalAlquiler = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalAlquiler = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescCliente = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtIDCliente = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.txtRiesgoConsumido = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblRiesgoConsumido = New Solmicro.Expertis.Engine.UI.Label
        Me.txtRiesgoPendiente = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblRiesgoPendiente = New Solmicro.Expertis.Engine.UI.Label
        Me.txtRiesgoConcedido = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblRiesgoConcedido = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalPedidos = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalPedidos = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalAlbaranes = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalAlbaranes = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalFacturas = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalFacturas = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalCobros = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalCobros = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCobros = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFacturas = New Solmicro.Expertis.Engine.UI.Label
        Me.lblAlbaranes = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPedidos = New Solmicro.Expertis.Engine.UI.Label
        Me.WLCab = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblEntregasACuentaPend = New Solmicro.Expertis.Engine.UI.Label
        Me.txtEntregasACuentaPend = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.pctPeligro = New System.Windows.Forms.PictureBox
        Me.WLGrid = New Solmicro.Expertis.Engine.UI.Frame
        CType(Me.gridPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridAlbaranes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCobros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridAlquiler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WLCab.SuspendLayout()
        CType(Me.pctPeligro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WLGrid.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbImprimir
        '
        Me.cmbImprimir.Image = CType(resources.GetObject("cmbImprimir.Image"), System.Drawing.Image)
        Me.cmbImprimir.Location = New System.Drawing.Point(826, 18)
        Me.cmbImprimir.Name = "cmbImprimir"
        Me.cmbImprimir.Size = New System.Drawing.Size(33, 33)
        Me.cmbImprimir.TabIndex = 4
        '
        'gridPedidos
        '
        Me.gridPedidos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.gridPedidos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.gridPedidos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridPedidos_DesignTimeLayout.LayoutString = resources.GetString("gridPedidos_DesignTimeLayout.LayoutString")
        Me.gridPedidos.DesignTimeLayout = gridPedidos_DesignTimeLayout
        Me.gridPedidos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.gridPedidos.EntityName = "PedidoVentaCabecera"
        Me.gridPedidos.Location = New System.Drawing.Point(8, 33)
        Me.gridPedidos.Name = "gridPedidos"
        Me.gridPedidos.PrimaryDataFields = Nothing
        Me.gridPedidos.RequeryManually = True
        Me.gridPedidos.SecondaryDataFields = "IDCliente"
        Me.gridPedidos.Size = New System.Drawing.Size(269, 120)
        Me.gridPedidos.TabIndex = 0
        Me.gridPedidos.Tag = ""
        Me.gridPedidos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.gridPedidos.ViewName = "VFrmMntoRiesgoClientePedidos"
        '
        'gridAlbaranes
        '
        Me.gridAlbaranes.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.gridAlbaranes.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.gridAlbaranes.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridAlbaranes_DesignTimeLayout.LayoutString = resources.GetString("gridAlbaranes_DesignTimeLayout.LayoutString")
        Me.gridAlbaranes.DesignTimeLayout = gridAlbaranes_DesignTimeLayout
        Me.gridAlbaranes.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.gridAlbaranes.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.gridAlbaranes.EntityName = "AlbaranVentaCabecera"
        Me.gridAlbaranes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridAlbaranes.Location = New System.Drawing.Point(282, 33)
        Me.gridAlbaranes.Name = "gridAlbaranes"
        Me.gridAlbaranes.PrimaryDataFields = Nothing
        Me.gridAlbaranes.RequeryManually = True
        Me.gridAlbaranes.SecondaryDataFields = "IDCliente"
        Me.gridAlbaranes.Size = New System.Drawing.Size(269, 120)
        Me.gridAlbaranes.TabIndex = 1
        Me.gridAlbaranes.Tag = ""
        Me.gridAlbaranes.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.gridAlbaranes.ViewName = "VFrmMntoRiesgoClienteAlbaranes"
        '
        'gridFacturas
        '
        Me.gridFacturas.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.gridFacturas.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.gridFacturas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridFacturas_DesignTimeLayout.LayoutString = resources.GetString("gridFacturas_DesignTimeLayout.LayoutString")
        Me.gridFacturas.DesignTimeLayout = gridFacturas_DesignTimeLayout
        Me.gridFacturas.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.gridFacturas.EntityName = "FacturaVentaCabecera"
        Me.gridFacturas.Location = New System.Drawing.Point(8, 207)
        Me.gridFacturas.Name = "gridFacturas"
        Me.gridFacturas.PrimaryDataFields = Nothing
        Me.gridFacturas.RequeryManually = True
        Me.gridFacturas.SecondaryDataFields = "IDCliente"
        Me.gridFacturas.Size = New System.Drawing.Size(269, 120)
        Me.gridFacturas.TabIndex = 2
        Me.gridFacturas.Tag = ""
        Me.gridFacturas.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.gridFacturas.ViewName = "VFrmMntoRiesgoClienteFacturas"
        '
        'gridCobros
        '
        Me.gridCobros.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.gridCobros.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.gridCobros.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridCobros_DesignTimeLayout.LayoutString = resources.GetString("gridCobros_DesignTimeLayout.LayoutString")
        Me.gridCobros.DesignTimeLayout = gridCobros_DesignTimeLayout
        Me.gridCobros.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.gridCobros.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.gridCobros.EntityName = "Cobro"
        Me.gridCobros.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridCobros.Location = New System.Drawing.Point(282, 207)
        Me.gridCobros.Name = "gridCobros"
        Me.gridCobros.PrimaryDataFields = Nothing
        Me.gridCobros.RequeryManually = True
        Me.gridCobros.SecondaryDataFields = "IdCliente"
        Me.gridCobros.Size = New System.Drawing.Size(269, 120)
        Me.gridCobros.TabIndex = 3
        Me.gridCobros.Tag = ""
        Me.gridCobros.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.gridCobros.ViewName = "VFrmMntoRiesgoClienteCobros"
        '
        'gridAlquiler
        '
        Me.gridAlquiler.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.gridAlquiler.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.gridAlquiler.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridAlquiler_DesignTimeLayout.LayoutString = resources.GetString("gridAlquiler_DesignTimeLayout.LayoutString")
        Me.gridAlquiler.DesignTimeLayout = gridAlquiler_DesignTimeLayout
        Me.gridAlquiler.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.gridAlquiler.EntityName = "ObraCabecera"
        Me.gridAlquiler.Location = New System.Drawing.Point(556, 33)
        Me.gridAlquiler.Name = "gridAlquiler"
        Me.gridAlquiler.PrimaryDataFields = Nothing
        Me.gridAlquiler.RequeryManually = True
        Me.gridAlquiler.SecondaryDataFields = Nothing
        Me.gridAlquiler.Size = New System.Drawing.Size(303, 294)
        Me.gridAlquiler.TabIndex = 21
        Me.gridAlquiler.Tag = ""
        Me.gridAlquiler.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.gridAlquiler.ViewName = Nothing
        '
        'lblFacturacionMaterialAlquilado
        '
        Me.lblFacturacionMaterialAlquilado.Location = New System.Drawing.Point(559, 17)
        Me.lblFacturacionMaterialAlquilado.Name = "lblFacturacionMaterialAlquilado"
        Me.lblFacturacionMaterialAlquilado.Size = New System.Drawing.Size(237, 13)
        Me.lblFacturacionMaterialAlquilado.TabIndex = 22
        Me.lblFacturacionMaterialAlquilado.Text = "Facturación Pendiente Material Alquilado"
        '
        'txtTotalAlquiler
        '
        Me.txtTotalAlquiler.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalAlquiler.Enabled = False
        Me.txtTotalAlquiler.Location = New System.Drawing.Point(757, 333)
        Me.txtTotalAlquiler.Name = "txtTotalAlquiler"
        Me.txtTotalAlquiler.Size = New System.Drawing.Size(102, 21)
        Me.txtTotalAlquiler.TabIndex = 22
        '
        'lblTotalAlquiler
        '
        Me.lblTotalAlquiler.Location = New System.Drawing.Point(716, 337)
        Me.lblTotalAlquiler.Name = "lblTotalAlquiler"
        Me.lblTotalAlquiler.Size = New System.Drawing.Size(35, 13)
        Me.lblTotalAlquiler.TabIndex = 23
        Me.lblTotalAlquiler.Tag = ""
        Me.lblTotalAlquiler.Text = "Total"
        '
        'txtDescCliente
        '
        Me.txtDescCliente.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescCliente.Enabled = False
        Me.txtDescCliente.Location = New System.Drawing.Point(190, 18)
        Me.txtDescCliente.Name = "txtDescCliente"
        Me.txtDescCliente.Size = New System.Drawing.Size(630, 21)
        Me.txtDescCliente.TabIndex = 11
        '
        'txtIDCliente
        '
        Me.txtIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDCliente.Enabled = False
        Me.txtIDCliente.Location = New System.Drawing.Point(67, 18)
        Me.txtIDCliente.Name = "txtIDCliente"
        Me.txtIDCliente.Size = New System.Drawing.Size(120, 21)
        Me.txtIDCliente.TabIndex = 5
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(9, 21)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(51, 13)
        Me.lblCliente.TabIndex = 24
        Me.lblCliente.Tag = ""
        Me.lblCliente.Text = "Cliente "
        '
        'txtRiesgoConsumido
        '
        Me.txtRiesgoConsumido.DisabledBackColor = System.Drawing.Color.White
        Me.txtRiesgoConsumido.Enabled = False
        Me.txtRiesgoConsumido.Location = New System.Drawing.Point(135, 67)
        Me.txtRiesgoConsumido.Name = "txtRiesgoConsumido"
        Me.txtRiesgoConsumido.Size = New System.Drawing.Size(112, 21)
        Me.txtRiesgoConsumido.TabIndex = 6
        '
        'lblRiesgoConsumido
        '
        Me.lblRiesgoConsumido.Location = New System.Drawing.Point(9, 71)
        Me.lblRiesgoConsumido.Name = "lblRiesgoConsumido"
        Me.lblRiesgoConsumido.Size = New System.Drawing.Size(113, 13)
        Me.lblRiesgoConsumido.TabIndex = 25
        Me.lblRiesgoConsumido.Tag = ""
        Me.lblRiesgoConsumido.Text = "Riesgo Consumido"
        '
        'txtRiesgoPendiente
        '
        Me.txtRiesgoPendiente.DisabledBackColor = System.Drawing.Color.White
        Me.txtRiesgoPendiente.Enabled = False
        Me.txtRiesgoPendiente.Location = New System.Drawing.Point(135, 91)
        Me.txtRiesgoPendiente.Name = "txtRiesgoPendiente"
        Me.txtRiesgoPendiente.Size = New System.Drawing.Size(112, 21)
        Me.txtRiesgoPendiente.TabIndex = 7
        '
        'lblRiesgoPendiente
        '
        Me.lblRiesgoPendiente.Location = New System.Drawing.Point(9, 95)
        Me.lblRiesgoPendiente.Name = "lblRiesgoPendiente"
        Me.lblRiesgoPendiente.Size = New System.Drawing.Size(105, 13)
        Me.lblRiesgoPendiente.TabIndex = 26
        Me.lblRiesgoPendiente.Tag = ""
        Me.lblRiesgoPendiente.Text = "Riesgo Pendiente"
        '
        'txtRiesgoConcedido
        '
        Me.txtRiesgoConcedido.DisabledBackColor = System.Drawing.Color.White
        Me.txtRiesgoConcedido.Enabled = False
        Me.txtRiesgoConcedido.Location = New System.Drawing.Point(135, 43)
        Me.txtRiesgoConcedido.Name = "txtRiesgoConcedido"
        Me.txtRiesgoConcedido.Size = New System.Drawing.Size(112, 21)
        Me.txtRiesgoConcedido.TabIndex = 9
        '
        'lblRiesgoConcedido
        '
        Me.lblRiesgoConcedido.Location = New System.Drawing.Point(9, 47)
        Me.lblRiesgoConcedido.Name = "lblRiesgoConcedido"
        Me.lblRiesgoConcedido.Size = New System.Drawing.Size(109, 13)
        Me.lblRiesgoConcedido.TabIndex = 27
        Me.lblRiesgoConcedido.Tag = ""
        Me.lblRiesgoConcedido.Text = "Riesgo Concedido"
        '
        'txtTotalPedidos
        '
        Me.txtTotalPedidos.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalPedidos.Enabled = False
        Me.txtTotalPedidos.Location = New System.Drawing.Point(175, 159)
        Me.txtTotalPedidos.Name = "txtTotalPedidos"
        Me.txtTotalPedidos.Size = New System.Drawing.Size(102, 21)
        Me.txtTotalPedidos.TabIndex = 17
        '
        'lblTotalPedidos
        '
        Me.lblTotalPedidos.Location = New System.Drawing.Point(134, 163)
        Me.lblTotalPedidos.Name = "lblTotalPedidos"
        Me.lblTotalPedidos.Size = New System.Drawing.Size(35, 13)
        Me.lblTotalPedidos.TabIndex = 28
        Me.lblTotalPedidos.Tag = ""
        Me.lblTotalPedidos.Text = "Total"
        '
        'txtTotalAlbaranes
        '
        Me.txtTotalAlbaranes.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalAlbaranes.Enabled = False
        Me.txtTotalAlbaranes.Location = New System.Drawing.Point(448, 159)
        Me.txtTotalAlbaranes.Name = "txtTotalAlbaranes"
        Me.txtTotalAlbaranes.Size = New System.Drawing.Size(102, 21)
        Me.txtTotalAlbaranes.TabIndex = 18
        '
        'lblTotalAlbaranes
        '
        Me.lblTotalAlbaranes.Location = New System.Drawing.Point(407, 163)
        Me.lblTotalAlbaranes.Name = "lblTotalAlbaranes"
        Me.lblTotalAlbaranes.Size = New System.Drawing.Size(35, 13)
        Me.lblTotalAlbaranes.TabIndex = 29
        Me.lblTotalAlbaranes.Tag = ""
        Me.lblTotalAlbaranes.Text = "Total"
        '
        'txtTotalFacturas
        '
        Me.txtTotalFacturas.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalFacturas.Enabled = False
        Me.txtTotalFacturas.Location = New System.Drawing.Point(175, 333)
        Me.txtTotalFacturas.Name = "txtTotalFacturas"
        Me.txtTotalFacturas.Size = New System.Drawing.Size(102, 21)
        Me.txtTotalFacturas.TabIndex = 19
        '
        'lblTotalFacturas
        '
        Me.lblTotalFacturas.Location = New System.Drawing.Point(134, 337)
        Me.lblTotalFacturas.Name = "lblTotalFacturas"
        Me.lblTotalFacturas.Size = New System.Drawing.Size(35, 13)
        Me.lblTotalFacturas.TabIndex = 30
        Me.lblTotalFacturas.Tag = ""
        Me.lblTotalFacturas.Text = "Total"
        '
        'txtTotalCobros
        '
        Me.txtTotalCobros.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalCobros.Enabled = False
        Me.txtTotalCobros.Location = New System.Drawing.Point(449, 333)
        Me.txtTotalCobros.Name = "txtTotalCobros"
        Me.txtTotalCobros.Size = New System.Drawing.Size(102, 21)
        Me.txtTotalCobros.TabIndex = 20
        '
        'lblTotalCobros
        '
        Me.lblTotalCobros.Location = New System.Drawing.Point(407, 337)
        Me.lblTotalCobros.Name = "lblTotalCobros"
        Me.lblTotalCobros.Size = New System.Drawing.Size(35, 13)
        Me.lblTotalCobros.TabIndex = 31
        Me.lblTotalCobros.Tag = ""
        Me.lblTotalCobros.Text = "Total"
        '
        'lblCobros
        '
        Me.lblCobros.Location = New System.Drawing.Point(282, 189)
        Me.lblCobros.Name = "lblCobros"
        Me.lblCobros.Size = New System.Drawing.Size(114, 13)
        Me.lblCobros.TabIndex = 32
        Me.lblCobros.Tag = ""
        Me.lblCobros.Text = "Cobros Pendientes"
        '
        'lblFacturas
        '
        Me.lblFacturas.Location = New System.Drawing.Point(8, 189)
        Me.lblFacturas.Name = "lblFacturas"
        Me.lblFacturas.Size = New System.Drawing.Size(211, 13)
        Me.lblFacturas.TabIndex = 33
        Me.lblFacturas.Tag = ""
        Me.lblFacturas.Text = "Facturas Pendientes de Contabilizar"
        '
        'lblAlbaranes
        '
        Me.lblAlbaranes.Location = New System.Drawing.Point(282, 17)
        Me.lblAlbaranes.Name = "lblAlbaranes"
        Me.lblAlbaranes.Size = New System.Drawing.Size(199, 13)
        Me.lblAlbaranes.TabIndex = 34
        Me.lblAlbaranes.Tag = ""
        Me.lblAlbaranes.Text = "Albaranes Pendientes de Facturar"
        '
        'lblPedidos
        '
        Me.lblPedidos.Location = New System.Drawing.Point(8, 17)
        Me.lblPedidos.Name = "lblPedidos"
        Me.lblPedidos.Size = New System.Drawing.Size(183, 13)
        Me.lblPedidos.TabIndex = 35
        Me.lblPedidos.Tag = ""
        Me.lblPedidos.Text = "Pedidos Pendientes de Entrega"
        '
        'WLCab
        '
        Me.WLCab.Controls.Add(Me.cmbImprimir)
        Me.WLCab.Controls.Add(Me.lblEntregasACuentaPend)
        Me.WLCab.Controls.Add(Me.lblCliente)
        Me.WLCab.Controls.Add(Me.txtEntregasACuentaPend)
        Me.WLCab.Controls.Add(Me.lblRiesgoConsumido)
        Me.WLCab.Controls.Add(Me.pctPeligro)
        Me.WLCab.Controls.Add(Me.lblRiesgoPendiente)
        Me.WLCab.Controls.Add(Me.txtRiesgoPendiente)
        Me.WLCab.Controls.Add(Me.lblRiesgoConcedido)
        Me.WLCab.Controls.Add(Me.txtRiesgoConcedido)
        Me.WLCab.Controls.Add(Me.txtDescCliente)
        Me.WLCab.Controls.Add(Me.txtRiesgoConsumido)
        Me.WLCab.Controls.Add(Me.txtIDCliente)
        Me.WLCab.Location = New System.Drawing.Point(3, -2)
        Me.WLCab.Name = "WLCab"
        Me.WLCab.Size = New System.Drawing.Size(868, 122)
        Me.WLCab.TabIndex = 10
        Me.WLCab.TabStop = False
        Me.WLCab.Tag = "IdRec=0;"
        '
        'lblEntregasACuentaPend
        '
        Me.lblEntregasACuentaPend.Location = New System.Drawing.Point(517, 47)
        Me.lblEntregasACuentaPend.Name = "lblEntregasACuentaPend"
        Me.lblEntregasACuentaPend.Size = New System.Drawing.Size(173, 13)
        Me.lblEntregasACuentaPend.TabIndex = 32
        Me.lblEntregasACuentaPend.Tag = ""
        Me.lblEntregasACuentaPend.Text = "Entregas a Cuenta Pendiente"
        '
        'txtEntregasACuentaPend
        '
        Me.txtEntregasACuentaPend.DisabledBackColor = System.Drawing.Color.White
        Me.txtEntregasACuentaPend.Enabled = False
        Me.txtEntregasACuentaPend.Location = New System.Drawing.Point(693, 43)
        Me.txtEntregasACuentaPend.Name = "txtEntregasACuentaPend"
        Me.txtEntregasACuentaPend.Size = New System.Drawing.Size(127, 21)
        Me.txtEntregasACuentaPend.TabIndex = 31
        '
        'pctPeligro
        '
        Me.pctPeligro.BackColor = System.Drawing.Color.Transparent
        Me.pctPeligro.Image = CType(resources.GetObject("pctPeligro.Image"), System.Drawing.Image)
        Me.pctPeligro.Location = New System.Drawing.Point(827, 56)
        Me.pctPeligro.Name = "pctPeligro"
        Me.pctPeligro.Size = New System.Drawing.Size(32, 32)
        Me.pctPeligro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctPeligro.TabIndex = 27
        Me.pctPeligro.TabStop = False
        Me.pctPeligro.Visible = False
        '
        'WLGrid
        '
        Me.WLGrid.Controls.Add(Me.gridAlquiler)
        Me.WLGrid.Controls.Add(Me.gridPedidos)
        Me.WLGrid.Controls.Add(Me.gridAlbaranes)
        Me.WLGrid.Controls.Add(Me.lblPedidos)
        Me.WLGrid.Controls.Add(Me.txtTotalAlquiler)
        Me.WLGrid.Controls.Add(Me.gridFacturas)
        Me.WLGrid.Controls.Add(Me.lblAlbaranes)
        Me.WLGrid.Controls.Add(Me.gridCobros)
        Me.WLGrid.Controls.Add(Me.lblFacturas)
        Me.WLGrid.Controls.Add(Me.lblTotalAlquiler)
        Me.WLGrid.Controls.Add(Me.lblCobros)
        Me.WLGrid.Controls.Add(Me.txtTotalCobros)
        Me.WLGrid.Controls.Add(Me.txtTotalFacturas)
        Me.WLGrid.Controls.Add(Me.txtTotalAlbaranes)
        Me.WLGrid.Controls.Add(Me.txtTotalPedidos)
        Me.WLGrid.Controls.Add(Me.lblTotalPedidos)
        Me.WLGrid.Controls.Add(Me.lblTotalCobros)
        Me.WLGrid.Controls.Add(Me.lblTotalAlbaranes)
        Me.WLGrid.Controls.Add(Me.lblTotalFacturas)
        Me.WLGrid.Controls.Add(Me.lblFacturacionMaterialAlquilado)
        Me.WLGrid.Location = New System.Drawing.Point(3, 122)
        Me.WLGrid.Name = "WLGrid"
        Me.WLGrid.Size = New System.Drawing.Size(868, 363)
        Me.WLGrid.TabIndex = 8
        Me.WLGrid.TabStop = False
        Me.WLGrid.Tag = "IdRec=0;"
        '
        'FrmAnalisisRiesgoAlquiler
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(875, 488)
        Me.Controls.Add(Me.WLGrid)
        Me.Controls.Add(Me.WLCab)
        Me.MaximizeBox = False
        Me.Name = "FrmAnalisisRiesgoAlquiler"
        Me.Text = "Análisis de Riesgo del Cliente"
        CType(Me.gridPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridAlbaranes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCobros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridAlquiler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WLCab.ResumeLayout(False)
        Me.WLCab.PerformLayout()
        CType(Me.pctPeligro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WLGrid.ResumeLayout(False)
        Me.WLGrid.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mdblRiesgoConsumido, mdblRiesgoPendiente As Double
    Private mstrAlbTransf, mstrAlbRetorno As String

#Region "Propiedades Publicas"

    Public WriteOnly Property IDCliente() As String
        Set(ByVal Value As String)
            txtIDCliente.Text = Value
        End Set
    End Property

    Public WriteOnly Property DescCliente() As String
        Set(ByVal Value As String)
            txtDescCliente.Text = Value
        End Set
    End Property

    Public WriteOnly Property RiesgoConcedido() As Double
        Set(ByVal Value As Double)
            txtRiesgoConcedido.Value = Value
        End Set
    End Property

#End Region

#Region "Procesos Privados"

    Private Sub SumaTotales()
        Dim MDblEntregasACuenta As Double = 0
        txtTotalPedidos.Value = gridPedidos.GetTotal(gridPedidos.Columns("Importe"), AggregateFunction.Sum)
        txtTotalAlbaranes.Value = gridAlbaranes.GetTotal(gridAlbaranes.Columns("Importe"), AggregateFunction.Sum)
        txtTotalFacturas.Value = gridFacturas.GetTotal(gridFacturas.Columns("Importe"), AggregateFunction.Sum)
        txtTotalCobros.Value = gridCobros.GetTotal(gridCobros.Columns("Importe"), AggregateFunction.Sum)
        txtTotalAlquiler.Value = gridAlquiler.GetTotal(gridAlquiler.Columns("Importe"), AggregateFunction.Sum)

        mdblRiesgoConsumido = IIf(Len(txtTotalPedidos.Value) > 0, txtTotalPedidos.Value, 0)
        mdblRiesgoConsumido = mdblRiesgoConsumido + IIf(Len(txtTotalAlbaranes.Value) > 0, txtTotalAlbaranes.Value, 0)
        mdblRiesgoConsumido = mdblRiesgoConsumido + IIf(Len(txtTotalFacturas.Value) > 0, txtTotalFacturas.Value, 0)
        mdblRiesgoConsumido = mdblRiesgoConsumido + IIf(Len(txtTotalCobros.Value) > 0, txtTotalCobros.Value, 0)
        mdblRiesgoConsumido = mdblRiesgoConsumido + IIf(Len(txtTotalAlquiler.Value) > 0, txtTotalAlquiler.Value, 0)

        Dim f As New Filter
        f.Add(New StringFilterItem("IDCliente", txtIDCliente.Text))
        f.Add(New NumberFilterItem("TipoEntrega", CInt(enumTipoEntrega.Anticipo)))
        f.Add(New BooleanFilterItem("Saldado", False))
        f.Add(New BooleanFilterItem("Generado", True))
        Dim DtEntregas As DataTable = New BE.DataEngine().Filter("vCIEntregasACuenta", f)
        If Not DtEntregas Is Nothing AndAlso DtEntregas.Rows.Count > 0 Then
            MDblEntregasACuenta = DtEntregas.Compute("SUM(Importe)", Nothing)
            Me.txtEntregasACuentaPend.Value = MDblEntregasACuenta
        End If
        mdblRiesgoConsumido -= MDblEntregasACuenta

        txtRiesgoConsumido.Value = mdblRiesgoConsumido

        If Len(txtRiesgoConsumido.Value) > 0 Then
            txtRiesgoPendiente.Value = Nz(txtRiesgoConcedido.Value, 0) - mdblRiesgoConsumido
            mdblRiesgoPendiente = txtRiesgoPendiente.Value
        End If

        pctPeligro.Visible = IIf(CDbl(Nz(txtRiesgoPendiente.Value, 0)) >= 0, False, True)
    End Sub

#End Region

#Region "Eventos Formulario"

    Private Sub FrmAnalisisRiesgoAlquiler_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim f As New Filter
        f.Add(New StringFilterItem("IDCliente", txtIDCliente.Text))

        gridPedidos.ReQuery(f)
        gridAlbaranes.ReQuery(f)
        gridFacturas.ReQuery(f)
        gridCobros.ReQuery(f)

        'Lanzar proceso de facturación
        Dim datosVtos As New dataConfigCalculoFacturacion(Date.Today, f, 0, False, False, enumomACalculoRiesgoCliente.omACalculoRiesgoPorObra, txtIDCliente.Text)
        gridAlquiler.DataSource = ExpertisApp.ExecuteTask(Of dataConfigCalculoFacturacion, DataTable)(AddressOf CalculoFacturacion.GetLineasFacturacionAlquiler, datosVtos)

        SumaTotales()

        If CDbl(Nz(txtRiesgoPendiente.Value, 0)) < 0 Then
            If ExpertisApp.GenerateMessage("Este Cliente ha superado su riesgo permitido. ¿Desea ver su desglose?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Me.Close()
                Exit Sub
            End If
        End If
        Dim p As New Parametro
        mstrAlbTransf = p.TipoAlbaranDeDeposito
        mstrAlbRetorno = p.TipoAlbaranRetornoAlquiler
    End Sub

    Private Sub cmbImprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbImprimir.Click
        Dim RptRiesgoAlq As New Report("ARCA")
        Dim f As New Filter
        f.Add("IDTipoAlbaran", FilterOperator.NotEqual, mstrAlbTransf, FilterType.String)
        f.Add("IDTipoAlbaran", FilterOperator.NotEqual, mstrAlbRetorno, FilterType.String)
        f.Add("AlbaranFacturable", FilterOperator.Equal, 1)

        RptRiesgoAlq.Subreports("Albaranes").DataSource = New BE.DataEngine().Filter("VFrmMntoRiesgoClienteAlbaranes", f)
        RptRiesgoAlq.Filter.Add(New StringFilterItem("IDCliente", txtIDCliente.Text))
        RptRiesgoAlq.Formulas("RConsumido").Text = Format(mdblRiesgoConsumido, "#,0.00")
        RptRiesgoAlq.Formulas("RPendiente").Text = Format(mdblRiesgoPendiente, "#,0.00")
        Me.Close()
        ExpertisApp.OpenReport(RptRiesgoAlq)
    End Sub

    Private Sub SumarImportes(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridAlbaranes.RecordAdded, gridAlbaranes.RecordsDeleted, gridAlbaranes.RecordUpdated, gridCobros.RecordAdded, gridCobros.RecordsDeleted, gridCobros.RecordUpdated, gridFacturas.RecordAdded, gridFacturas.RecordsDeleted, gridFacturas.RecordUpdated, gridPedidos.RecordAdded, gridPedidos.RecordsDeleted, gridPedidos.RecordUpdated
        SumaTotales()
    End Sub

#End Region

End Class