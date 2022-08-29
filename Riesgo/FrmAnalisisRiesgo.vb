Public Class FrmAnalisisRiesgo
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
    Friend WithEvents jngPedidos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents jngAlbaranes As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents jngFacturas As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents jngCobros As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents fwiDescCliente As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents fwiIdCliente As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblfwiIdCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiRiesgoConsumido As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblfwiRiesgoConsumido As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiRiesgoPendiente As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblfwiRiesgoPendiente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiRiesgoConcedido As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblfwiRiesgoConcedido As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFacturas As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblAlbaranes As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblPedidos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents WLGrid As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents LblEntregasACuentaPend As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pctPeligro As System.Windows.Forms.PictureBox
    Friend WithEvents jngCertificaciones As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Label5 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents jngHitos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents jngGastos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Label9 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents jngMOD As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Label11 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents jngMateriales As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Label7 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents gridAlquiler As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents lblFacturacionMaterialAlquilado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblGrupoRiesgo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblRiesgoTotal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents nbxRiesgoCapAsegurado As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblRiesgoInterno As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents nbxRiesgoInterno As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents FraProveedorAsociado As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblPendienteProv As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents nbxPendienteProv As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblProveedor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDescProveedor As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtIDProveedor As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents NtbEntregasACuentaPend As Solmicro.Expertis.Engine.UI.NumericTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAnalisisRiesgo))
        Dim jngPedidos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngAlbaranes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngFacturas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngCobros_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim gridAlquiler_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngGastos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngMOD_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngMateriales_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngCertificaciones_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngHitos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.cmbImprimir = New Solmicro.Expertis.Engine.UI.Button
        Me.jngPedidos = New Solmicro.Expertis.Engine.UI.Grid
        Me.jngAlbaranes = New Solmicro.Expertis.Engine.UI.Grid
        Me.jngFacturas = New Solmicro.Expertis.Engine.UI.Grid
        Me.jngCobros = New Solmicro.Expertis.Engine.UI.Grid
        Me.fwiDescCliente = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fwiIdCliente = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiIdCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiRiesgoConsumido = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiRiesgoConsumido = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiRiesgoPendiente = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiRiesgoPendiente = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiRiesgoConcedido = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiRiesgoConcedido = New Solmicro.Expertis.Engine.UI.Label
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFacturas = New Solmicro.Expertis.Engine.UI.Label
        Me.lblAlbaranes = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPedidos = New Solmicro.Expertis.Engine.UI.Label
        Me.WLGrid = New Solmicro.Expertis.Engine.UI.Frame
        Me.gridAlquiler = New Solmicro.Expertis.Engine.UI.Grid
        Me.lblFacturacionMaterialAlquilado = New Solmicro.Expertis.Engine.UI.Label
        Me.jngGastos = New Solmicro.Expertis.Engine.UI.Grid
        Me.Label9 = New Solmicro.Expertis.Engine.UI.Label
        Me.jngMOD = New Solmicro.Expertis.Engine.UI.Grid
        Me.Label11 = New Solmicro.Expertis.Engine.UI.Label
        Me.jngMateriales = New Solmicro.Expertis.Engine.UI.Grid
        Me.Label7 = New Solmicro.Expertis.Engine.UI.Label
        Me.jngCertificaciones = New Solmicro.Expertis.Engine.UI.Grid
        Me.Label5 = New Solmicro.Expertis.Engine.UI.Label
        Me.jngHitos = New Solmicro.Expertis.Engine.UI.Grid
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.FraProveedorAsociado = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblPendienteProv = New Solmicro.Expertis.Engine.UI.Label
        Me.nbxPendienteProv = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescProveedor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtIDProveedor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblRiesgoInterno = New Solmicro.Expertis.Engine.UI.Label
        Me.nbxRiesgoInterno = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblRiesgoTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.nbxRiesgoCapAsegurado = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblGrupoRiesgo = New Solmicro.Expertis.Engine.UI.Label
        Me.pctPeligro = New System.Windows.Forms.PictureBox
        Me.LblEntregasACuentaPend = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbEntregasACuentaPend = New Solmicro.Expertis.Engine.UI.NumericTextBox
        CType(Me.jngPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jngAlbaranes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jngFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jngCobros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WLGrid.SuspendLayout()
        CType(Me.gridAlquiler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jngGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jngMOD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jngMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jngCertificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jngHitos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.FraProveedorAsociado.SuspendLayout()
        CType(Me.pctPeligro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbImprimir
        '
        Me.cmbImprimir.Image = CType(resources.GetObject("cmbImprimir.Image"), System.Drawing.Image)
        Me.cmbImprimir.Location = New System.Drawing.Point(560, 13)
        Me.cmbImprimir.Name = "cmbImprimir"
        Me.cmbImprimir.Size = New System.Drawing.Size(33, 33)
        Me.cmbImprimir.TabIndex = 4
        '
        'jngPedidos
        '
        Me.jngPedidos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngPedidos.AllowColumnDrag = False
        Me.jngPedidos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngPedidos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngPedidos_DesignTimeLayout.LayoutString = resources.GetString("jngPedidos_DesignTimeLayout.LayoutString")
        Me.jngPedidos.DesignTimeLayout = jngPedidos_DesignTimeLayout
        Me.jngPedidos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngPedidos.EntityName = "PedidoVentaCabecera"
        Me.jngPedidos.Location = New System.Drawing.Point(11, 144)
        Me.jngPedidos.Name = "jngPedidos"
        Me.jngPedidos.PrimaryDataFields = Nothing
        Me.jngPedidos.RequeryManually = True
        Me.jngPedidos.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngPedidos.SecondaryDataFields = "IdCliente"
        Me.jngPedidos.Size = New System.Drawing.Size(285, 140)
        Me.jngPedidos.TabIndex = 0
        Me.jngPedidos.Tag = "IdRec=4638:4657:4389:4366:;"
        Me.jngPedidos.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.jngPedidos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngPedidos.ViewName = "VFrmMntoRiesgoClientePedidos"
        '
        'jngAlbaranes
        '
        Me.jngAlbaranes.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngAlbaranes.AllowColumnDrag = False
        Me.jngAlbaranes.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngAlbaranes.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngAlbaranes_DesignTimeLayout.LayoutString = resources.GetString("jngAlbaranes_DesignTimeLayout.LayoutString")
        Me.jngAlbaranes.DesignTimeLayout = jngAlbaranes_DesignTimeLayout
        Me.jngAlbaranes.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngAlbaranes.EntityName = "AlbaranVentaCabecera"
        Me.jngAlbaranes.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngAlbaranes.Location = New System.Drawing.Point(304, 144)
        Me.jngAlbaranes.Name = "jngAlbaranes"
        Me.jngAlbaranes.PrimaryDataFields = Nothing
        Me.jngAlbaranes.RequeryManually = True
        Me.jngAlbaranes.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngAlbaranes.SecondaryDataFields = "IDCliente"
        Me.jngAlbaranes.Size = New System.Drawing.Size(292, 140)
        Me.jngAlbaranes.TabIndex = 1
        Me.jngAlbaranes.Tag = "IdRec=4638:4660:4389:4366:;"
        Me.jngAlbaranes.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.jngAlbaranes.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngAlbaranes.ViewName = "VFrmMntoRiesgoClienteAlbaranes"
        '
        'jngFacturas
        '
        Me.jngFacturas.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngFacturas.AllowColumnDrag = False
        Me.jngFacturas.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngFacturas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngFacturas_DesignTimeLayout.LayoutString = resources.GetString("jngFacturas_DesignTimeLayout.LayoutString")
        Me.jngFacturas.DesignTimeLayout = jngFacturas_DesignTimeLayout
        Me.jngFacturas.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngFacturas.EntityName = "FacturaVentaCabecera"
        Me.jngFacturas.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngFacturas.Location = New System.Drawing.Point(606, 29)
        Me.jngFacturas.Name = "jngFacturas"
        Me.jngFacturas.PrimaryDataFields = Nothing
        Me.jngFacturas.RequeryManually = True
        Me.jngFacturas.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngFacturas.SecondaryDataFields = "IDCliente"
        Me.jngFacturas.Size = New System.Drawing.Size(297, 140)
        Me.jngFacturas.TabIndex = 2
        Me.jngFacturas.Tag = "IdRec=4638:4661:4389:4366:;"
        Me.jngFacturas.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.jngFacturas.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngFacturas.ViewName = "VFrmMntoRiesgoClienteFacturas"
        '
        'jngCobros
        '
        Me.jngCobros.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngCobros.AllowColumnDrag = False
        Me.jngCobros.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngCobros.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngCobros_DesignTimeLayout.LayoutString = resources.GetString("jngCobros_DesignTimeLayout.LayoutString")
        Me.jngCobros.DesignTimeLayout = jngCobros_DesignTimeLayout
        Me.jngCobros.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngCobros.EntityName = "Cobro"
        Me.jngCobros.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jngCobros.Location = New System.Drawing.Point(11, 319)
        Me.jngCobros.Name = "jngCobros"
        Me.jngCobros.PrimaryDataFields = Nothing
        Me.jngCobros.RequeryManually = True
        Me.jngCobros.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngCobros.SecondaryDataFields = Nothing
        Me.jngCobros.Size = New System.Drawing.Size(285, 140)
        Me.jngCobros.TabIndex = 3
        Me.jngCobros.Tag = "IdRec=4662:4661:4389:4366:;"
        Me.jngCobros.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.jngCobros.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngCobros.ViewName = "VFrmMntoRiesgoClienteCobros"
        '
        'fwiDescCliente
        '
        Me.fwiDescCliente.DisabledBackColor = System.Drawing.Color.White
        Me.fwiDescCliente.Enabled = False
        Me.fwiDescCliente.Location = New System.Drawing.Point(187, 14)
        Me.fwiDescCliente.Name = "fwiDescCliente"
        Me.fwiDescCliente.Size = New System.Drawing.Size(365, 21)
        Me.fwiDescCliente.TabIndex = 11
        '
        'fwiIdCliente
        '
        Me.fwiIdCliente.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIdCliente.Enabled = False
        Me.fwiIdCliente.Location = New System.Drawing.Point(64, 14)
        Me.fwiIdCliente.Name = "fwiIdCliente"
        Me.fwiIdCliente.Size = New System.Drawing.Size(120, 21)
        Me.fwiIdCliente.TabIndex = 5
        '
        'lblfwiIdCliente
        '
        Me.lblfwiIdCliente.Location = New System.Drawing.Point(12, 18)
        Me.lblfwiIdCliente.Name = "lblfwiIdCliente"
        Me.lblfwiIdCliente.Size = New System.Drawing.Size(51, 13)
        Me.lblfwiIdCliente.TabIndex = 12
        Me.lblfwiIdCliente.Tag = "IdRec=4365;"
        Me.lblfwiIdCliente.Text = "Cliente "
        '
        'fwiRiesgoConsumido
        '
        Me.fwiRiesgoConsumido.DisabledBackColor = System.Drawing.Color.White
        Me.fwiRiesgoConsumido.Enabled = False
        Me.fwiRiesgoConsumido.Location = New System.Drawing.Point(136, 63)
        Me.fwiRiesgoConsumido.Name = "fwiRiesgoConsumido"
        Me.fwiRiesgoConsumido.Size = New System.Drawing.Size(120, 21)
        Me.fwiRiesgoConsumido.TabIndex = 6
        '
        'lblfwiRiesgoConsumido
        '
        Me.lblfwiRiesgoConsumido.Location = New System.Drawing.Point(12, 67)
        Me.lblfwiRiesgoConsumido.Name = "lblfwiRiesgoConsumido"
        Me.lblfwiRiesgoConsumido.Size = New System.Drawing.Size(113, 13)
        Me.lblfwiRiesgoConsumido.TabIndex = 13
        Me.lblfwiRiesgoConsumido.Tag = "IdRec=4658;"
        Me.lblfwiRiesgoConsumido.Text = "Riesgo Consumido"
        '
        'fwiRiesgoPendiente
        '
        Me.fwiRiesgoPendiente.DisabledBackColor = System.Drawing.Color.White
        Me.fwiRiesgoPendiente.Enabled = False
        Me.fwiRiesgoPendiente.Location = New System.Drawing.Point(136, 88)
        Me.fwiRiesgoPendiente.Name = "fwiRiesgoPendiente"
        Me.fwiRiesgoPendiente.Size = New System.Drawing.Size(120, 21)
        Me.fwiRiesgoPendiente.TabIndex = 7
        '
        'lblfwiRiesgoPendiente
        '
        Me.lblfwiRiesgoPendiente.Location = New System.Drawing.Point(12, 92)
        Me.lblfwiRiesgoPendiente.Name = "lblfwiRiesgoPendiente"
        Me.lblfwiRiesgoPendiente.Size = New System.Drawing.Size(105, 13)
        Me.lblfwiRiesgoPendiente.TabIndex = 14
        Me.lblfwiRiesgoPendiente.Tag = "IdRec=4659;"
        Me.lblfwiRiesgoPendiente.Text = "Riesgo Pendiente"
        '
        'fwiRiesgoConcedido
        '
        Me.fwiRiesgoConcedido.DisabledBackColor = System.Drawing.Color.White
        Me.fwiRiesgoConcedido.Enabled = False
        Me.fwiRiesgoConcedido.Location = New System.Drawing.Point(136, 38)
        Me.fwiRiesgoConcedido.Name = "fwiRiesgoConcedido"
        Me.fwiRiesgoConcedido.Size = New System.Drawing.Size(120, 21)
        Me.fwiRiesgoConcedido.TabIndex = 9
        '
        'lblfwiRiesgoConcedido
        '
        Me.lblfwiRiesgoConcedido.Location = New System.Drawing.Point(12, 42)
        Me.lblfwiRiesgoConcedido.Name = "lblfwiRiesgoConcedido"
        Me.lblfwiRiesgoConcedido.Size = New System.Drawing.Size(76, 13)
        Me.lblfwiRiesgoConcedido.TabIndex = 15
        Me.lblfwiRiesgoConcedido.Tag = "IdRec=4663;"
        Me.lblfwiRiesgoConcedido.Text = "Riesgo Total"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Tag = "IdRec=4665;"
        Me.Label2.Text = "Cobros Pendientes"
        '
        'lblFacturas
        '
        Me.lblFacturas.Location = New System.Drawing.Point(607, 13)
        Me.lblFacturas.Name = "lblFacturas"
        Me.lblFacturas.Size = New System.Drawing.Size(210, 13)
        Me.lblFacturas.TabIndex = 22
        Me.lblFacturas.Tag = "IdRec=4666;"
        Me.lblFacturas.Text = "Facturas Pendientes de Contabilizar"
        '
        'lblAlbaranes
        '
        Me.lblAlbaranes.Location = New System.Drawing.Point(304, 128)
        Me.lblAlbaranes.Name = "lblAlbaranes"
        Me.lblAlbaranes.Size = New System.Drawing.Size(198, 13)
        Me.lblAlbaranes.TabIndex = 23
        Me.lblAlbaranes.Tag = "IdRec=4667;"
        Me.lblAlbaranes.Text = "Albaranes Pendientes de Facturar"
        '
        'lblPedidos
        '
        Me.lblPedidos.Location = New System.Drawing.Point(11, 128)
        Me.lblPedidos.Name = "lblPedidos"
        Me.lblPedidos.Size = New System.Drawing.Size(183, 13)
        Me.lblPedidos.TabIndex = 24
        Me.lblPedidos.Tag = "IdRec=4668;"
        Me.lblPedidos.Text = "Pedidos Pendientes de Entrega"
        '
        'WLGrid
        '
        Me.WLGrid.Controls.Add(Me.gridAlquiler)
        Me.WLGrid.Controls.Add(Me.lblFacturacionMaterialAlquilado)
        Me.WLGrid.Controls.Add(Me.jngGastos)
        Me.WLGrid.Controls.Add(Me.Label9)
        Me.WLGrid.Controls.Add(Me.jngMOD)
        Me.WLGrid.Controls.Add(Me.Label11)
        Me.WLGrid.Controls.Add(Me.jngMateriales)
        Me.WLGrid.Controls.Add(Me.Label7)
        Me.WLGrid.Controls.Add(Me.jngCertificaciones)
        Me.WLGrid.Controls.Add(Me.Label5)
        Me.WLGrid.Controls.Add(Me.jngHitos)
        Me.WLGrid.Controls.Add(Me.jngFacturas)
        Me.WLGrid.Controls.Add(Me.Label3)
        Me.WLGrid.Controls.Add(Me.lblFacturas)
        Me.WLGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WLGrid.Location = New System.Drawing.Point(0, 115)
        Me.WLGrid.Name = "WLGrid"
        Me.WLGrid.Size = New System.Drawing.Size(1219, 537)
        Me.WLGrid.TabIndex = 8
        Me.WLGrid.TabStop = False
        Me.WLGrid.Tag = "IdRec=0;"
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
        Me.gridAlquiler.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridAlquiler.Location = New System.Drawing.Point(910, 29)
        Me.gridAlquiler.Name = "gridAlquiler"
        Me.gridAlquiler.PrimaryDataFields = Nothing
        Me.gridAlquiler.RequeryManually = True
        Me.gridAlquiler.SecondaryDataFields = Nothing
        Me.gridAlquiler.Size = New System.Drawing.Size(293, 315)
        Me.gridAlquiler.TabIndex = 44
        Me.gridAlquiler.Tag = ""
        Me.gridAlquiler.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridAlquiler.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.gridAlquiler.ViewName = Nothing
        '
        'lblFacturacionMaterialAlquilado
        '
        Me.lblFacturacionMaterialAlquilado.Location = New System.Drawing.Point(910, 13)
        Me.lblFacturacionMaterialAlquilado.Name = "lblFacturacionMaterialAlquilado"
        Me.lblFacturacionMaterialAlquilado.Size = New System.Drawing.Size(236, 13)
        Me.lblFacturacionMaterialAlquilado.TabIndex = 45
        Me.lblFacturacionMaterialAlquilado.Text = "Facturación Pendiente Material Alquilado"
        '
        'jngGastos
        '
        Me.jngGastos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngGastos.AllowColumnDrag = False
        Me.jngGastos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngGastos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngGastos_DesignTimeLayout.LayoutString = resources.GetString("jngGastos_DesignTimeLayout.LayoutString")
        Me.jngGastos.DesignTimeLayout = jngGastos_DesignTimeLayout
        Me.jngGastos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.jngGastos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngGastos.EntityName = "ObraGastoControl"
        Me.jngGastos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngGastos.Location = New System.Drawing.Point(606, 384)
        Me.jngGastos.Name = "jngGastos"
        Me.jngGastos.PrimaryDataFields = Nothing
        Me.jngGastos.RequeryManually = True
        Me.jngGastos.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngGastos.SecondaryDataFields = "IDCliente"
        Me.jngGastos.Size = New System.Drawing.Size(297, 140)
        Me.jngGastos.TabIndex = 40
        Me.jngGastos.Tag = "IdRec=4638:4660:4389:4366:;"
        Me.jngGastos.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.jngGastos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngGastos.ViewName = "vNegSimulacionTesoreriaObraGasto"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(607, 368)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(180, 13)
        Me.Label9.TabIndex = 43
        Me.Label9.Tag = "IdRec=4667;"
        Me.Label9.Text = "Gastos Pendientes de Facturar"
        '
        'jngMOD
        '
        Me.jngMOD.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngMOD.AllowColumnDrag = False
        Me.jngMOD.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngMOD.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngMOD_DesignTimeLayout.LayoutString = resources.GetString("jngMOD_DesignTimeLayout.LayoutString")
        Me.jngMOD.DesignTimeLayout = jngMOD_DesignTimeLayout
        Me.jngMOD.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.jngMOD.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngMOD.EntityName = "ObraMODControl"
        Me.jngMOD.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngMOD.Location = New System.Drawing.Point(304, 384)
        Me.jngMOD.Name = "jngMOD"
        Me.jngMOD.PrimaryDataFields = Nothing
        Me.jngMOD.RequeryManually = True
        Me.jngMOD.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngMOD.SecondaryDataFields = "IDCliente"
        Me.jngMOD.Size = New System.Drawing.Size(295, 140)
        Me.jngMOD.TabIndex = 36
        Me.jngMOD.Tag = "IdRec=4638:4660:4389:4366:;"
        Me.jngMOD.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.jngMOD.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngMOD.ViewName = "vNegSimulacionTesoreriaObraMOD"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(301, 368)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(168, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Tag = "IdRec=4667;"
        Me.Label11.Text = "MOD Pendientes de Facturar"
        '
        'jngMateriales
        '
        Me.jngMateriales.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngMateriales.AllowColumnDrag = False
        Me.jngMateriales.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngMateriales.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngMateriales_DesignTimeLayout.LayoutString = resources.GetString("jngMateriales_DesignTimeLayout.LayoutString")
        Me.jngMateriales.DesignTimeLayout = jngMateriales_DesignTimeLayout
        Me.jngMateriales.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngMateriales.EntityName = "ObraMaterialControl"
        Me.jngMateriales.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jngMateriales.Location = New System.Drawing.Point(11, 384)
        Me.jngMateriales.Name = "jngMateriales"
        Me.jngMateriales.PrimaryDataFields = Nothing
        Me.jngMateriales.RequeryManually = True
        Me.jngMateriales.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngMateriales.SecondaryDataFields = Nothing
        Me.jngMateriales.Size = New System.Drawing.Size(285, 140)
        Me.jngMateriales.TabIndex = 32
        Me.jngMateriales.Tag = "IdRec=4662:4661:4389:4366:;"
        Me.jngMateriales.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.jngMateriales.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngMateriales.ViewName = "vNegSimulacionTesoreriaObraMaterial"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(9, 368)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Tag = "IdRec=4665;"
        Me.Label7.Text = "Materiales Pendientes"
        '
        'jngCertificaciones
        '
        Me.jngCertificaciones.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngCertificaciones.AllowColumnDrag = False
        Me.jngCertificaciones.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngCertificaciones.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngCertificaciones_DesignTimeLayout.LayoutString = resources.GetString("jngCertificaciones_DesignTimeLayout.LayoutString")
        Me.jngCertificaciones.DesignTimeLayout = jngCertificaciones_DesignTimeLayout
        Me.jngCertificaciones.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngCertificaciones.EntityName = "ObraTraajoCertificacion"
        Me.jngCertificaciones.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngCertificaciones.Location = New System.Drawing.Point(606, 204)
        Me.jngCertificaciones.Name = "jngCertificaciones"
        Me.jngCertificaciones.PrimaryDataFields = Nothing
        Me.jngCertificaciones.RequeryManually = True
        Me.jngCertificaciones.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngCertificaciones.SecondaryDataFields = "IDCliente"
        Me.jngCertificaciones.Size = New System.Drawing.Size(297, 140)
        Me.jngCertificaciones.TabIndex = 28
        Me.jngCertificaciones.Tag = "IdRec=4638:4660:4389:4366:;"
        Me.jngCertificaciones.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.jngCertificaciones.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngCertificaciones.ViewName = "vNegSimulacionTesoreriaObraCertificacion"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(607, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(225, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Tag = "IdRec=4667;"
        Me.Label5.Text = "Certificaciones Pendientes de Facturar"
        '
        'jngHitos
        '
        Me.jngHitos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngHitos.AllowColumnDrag = False
        Me.jngHitos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngHitos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngHitos_DesignTimeLayout.LayoutString = resources.GetString("jngHitos_DesignTimeLayout.LayoutString")
        Me.jngHitos.DesignTimeLayout = jngHitos_DesignTimeLayout
        Me.jngHitos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.jngHitos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngHitos.EntityName = "ObraTrabajoFacturacion"
        Me.jngHitos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngHitos.Location = New System.Drawing.Point(304, 204)
        Me.jngHitos.Name = "jngHitos"
        Me.jngHitos.PrimaryDataFields = Nothing
        Me.jngHitos.RequeryManually = True
        Me.jngHitos.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngHitos.SecondaryDataFields = "IDCliente"
        Me.jngHitos.Size = New System.Drawing.Size(295, 140)
        Me.jngHitos.TabIndex = 24
        Me.jngHitos.Tag = "IdRec=4638:4660:4389:4366:;"
        Me.jngHitos.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.jngHitos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngHitos.ViewName = "vNegSimulacionTesoreriaObraHitos"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(301, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Tag = "IdRec=4667;"
        Me.Label3.Text = "Hitos Pendientes de Facturar"
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.FraProveedorAsociado)
        Me.Frame1.Controls.Add(Me.lblRiesgoInterno)
        Me.Frame1.Controls.Add(Me.nbxRiesgoInterno)
        Me.Frame1.Controls.Add(Me.lblRiesgoTotal)
        Me.Frame1.Controls.Add(Me.nbxRiesgoCapAsegurado)
        Me.Frame1.Controls.Add(Me.lblGrupoRiesgo)
        Me.Frame1.Controls.Add(Me.pctPeligro)
        Me.Frame1.Controls.Add(Me.LblEntregasACuentaPend)
        Me.Frame1.Controls.Add(Me.NtbEntregasACuentaPend)
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(1219, 115)
        Me.Frame1.TabIndex = 10
        Me.Frame1.TabStop = False
        Me.Frame1.Tag = "IdRec=0;"
        '
        'FraProveedorAsociado
        '
        Me.FraProveedorAsociado.Controls.Add(Me.lblPendienteProv)
        Me.FraProveedorAsociado.Controls.Add(Me.nbxPendienteProv)
        Me.FraProveedorAsociado.Controls.Add(Me.lblProveedor)
        Me.FraProveedorAsociado.Controls.Add(Me.txtDescProveedor)
        Me.FraProveedorAsociado.Controls.Add(Me.txtIDProveedor)
        Me.FraProveedorAsociado.Location = New System.Drawing.Point(596, 12)
        Me.FraProveedorAsociado.Name = "FraProveedorAsociado"
        Me.FraProveedorAsociado.Size = New System.Drawing.Size(500, 100)
        Me.FraProveedorAsociado.TabIndex = 37
        Me.FraProveedorAsociado.TabStop = False
        Me.FraProveedorAsociado.Text = "Proveedor Asociado"
        Me.FraProveedorAsociado.Visible = False
        '
        'lblPendienteProv
        '
        Me.lblPendienteProv.Location = New System.Drawing.Point(6, 51)
        Me.lblPendienteProv.Name = "lblPendienteProv"
        Me.lblPendienteProv.Size = New System.Drawing.Size(63, 13)
        Me.lblPendienteProv.TabIndex = 36
        Me.lblPendienteProv.Tag = "IdRec=4659;"
        Me.lblPendienteProv.Text = "Pendiente"
        '
        'nbxPendienteProv
        '
        Me.nbxPendienteProv.DisabledBackColor = System.Drawing.Color.White
        Me.nbxPendienteProv.Enabled = False
        Me.nbxPendienteProv.Location = New System.Drawing.Point(70, 47)
        Me.nbxPendienteProv.Name = "nbxPendienteProv"
        Me.nbxPendienteProv.Size = New System.Drawing.Size(103, 21)
        Me.nbxPendienteProv.TabIndex = 35
        '
        'lblProveedor
        '
        Me.lblProveedor.Location = New System.Drawing.Point(6, 24)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(59, 13)
        Me.lblProveedor.TabIndex = 15
        Me.lblProveedor.Tag = "IdRec=4365;"
        Me.lblProveedor.Text = "Provedor"
        '
        'txtDescProveedor
        '
        Me.txtDescProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescProveedor.Enabled = False
        Me.txtDescProveedor.Location = New System.Drawing.Point(176, 20)
        Me.txtDescProveedor.Name = "txtDescProveedor"
        Me.txtDescProveedor.Size = New System.Drawing.Size(318, 21)
        Me.txtDescProveedor.TabIndex = 14
        '
        'txtIDProveedor
        '
        Me.txtIDProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDProveedor.Enabled = False
        Me.txtIDProveedor.Location = New System.Drawing.Point(70, 20)
        Me.txtIDProveedor.Name = "txtIDProveedor"
        Me.txtIDProveedor.Size = New System.Drawing.Size(103, 21)
        Me.txtIDProveedor.TabIndex = 13
        '
        'lblRiesgoInterno
        '
        Me.lblRiesgoInterno.Location = New System.Drawing.Point(275, 67)
        Me.lblRiesgoInterno.Name = "lblRiesgoInterno"
        Me.lblRiesgoInterno.Size = New System.Drawing.Size(91, 13)
        Me.lblRiesgoInterno.TabIndex = 36
        Me.lblRiesgoInterno.Tag = ""
        Me.lblRiesgoInterno.Text = "Riesgo Interno"
        '
        'nbxRiesgoInterno
        '
        Me.nbxRiesgoInterno.DisabledBackColor = System.Drawing.Color.White
        Me.nbxRiesgoInterno.Enabled = False
        Me.nbxRiesgoInterno.Location = New System.Drawing.Point(429, 63)
        Me.nbxRiesgoInterno.Name = "nbxRiesgoInterno"
        Me.nbxRiesgoInterno.Size = New System.Drawing.Size(120, 21)
        Me.nbxRiesgoInterno.TabIndex = 35
        '
        'lblRiesgoTotal
        '
        Me.lblRiesgoTotal.Location = New System.Drawing.Point(275, 92)
        Me.lblRiesgoTotal.Name = "lblRiesgoTotal"
        Me.lblRiesgoTotal.Size = New System.Drawing.Size(141, 13)
        Me.lblRiesgoTotal.TabIndex = 34
        Me.lblRiesgoTotal.Tag = "IdRec=4659;"
        Me.lblRiesgoTotal.Text = "Riesgo Cap. Asegurado"
        '
        'nbxRiesgoCapAsegurado
        '
        Me.nbxRiesgoCapAsegurado.DisabledBackColor = System.Drawing.Color.White
        Me.nbxRiesgoCapAsegurado.Enabled = False
        Me.nbxRiesgoCapAsegurado.Location = New System.Drawing.Point(429, 88)
        Me.nbxRiesgoCapAsegurado.Name = "nbxRiesgoCapAsegurado"
        Me.nbxRiesgoCapAsegurado.Size = New System.Drawing.Size(120, 21)
        Me.nbxRiesgoCapAsegurado.TabIndex = 33
        '
        'lblGrupoRiesgo
        '
        Me.lblGrupoRiesgo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGrupoRiesgo.Location = New System.Drawing.Point(1102, 13)
        Me.lblGrupoRiesgo.Name = "lblGrupoRiesgo"
        Me.lblGrupoRiesgo.Size = New System.Drawing.Size(105, 13)
        Me.lblGrupoRiesgo.TabIndex = 32
        Me.lblGrupoRiesgo.Text = "Riesgo del Grupo"
        Me.lblGrupoRiesgo.Visible = False
        '
        'pctPeligro
        '
        Me.pctPeligro.BackColor = System.Drawing.Color.Transparent
        Me.pctPeligro.Image = CType(resources.GetObject("pctPeligro.Image"), System.Drawing.Image)
        Me.pctPeligro.Location = New System.Drawing.Point(558, 49)
        Me.pctPeligro.Name = "pctPeligro"
        Me.pctPeligro.Size = New System.Drawing.Size(32, 32)
        Me.pctPeligro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctPeligro.TabIndex = 31
        Me.pctPeligro.TabStop = False
        Me.pctPeligro.Visible = False
        '
        'LblEntregasACuentaPend
        '
        Me.LblEntregasACuentaPend.Location = New System.Drawing.Point(275, 42)
        Me.LblEntregasACuentaPend.Name = "LblEntregasACuentaPend"
        Me.LblEntregasACuentaPend.Size = New System.Drawing.Size(150, 13)
        Me.LblEntregasACuentaPend.TabIndex = 30
        Me.LblEntregasACuentaPend.Tag = "IdRec=4663;"
        Me.LblEntregasACuentaPend.Text = "Entregas A Cuenta Pend."
        '
        'NtbEntregasACuentaPend
        '
        Me.NtbEntregasACuentaPend.DisabledBackColor = System.Drawing.Color.White
        Me.NtbEntregasACuentaPend.Enabled = False
        Me.NtbEntregasACuentaPend.Location = New System.Drawing.Point(429, 38)
        Me.NtbEntregasACuentaPend.Name = "NtbEntregasACuentaPend"
        Me.NtbEntregasACuentaPend.Size = New System.Drawing.Size(120, 21)
        Me.NtbEntregasACuentaPend.TabIndex = 29
        '
        'FrmAnalisisRiesgo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(1219, 652)
        Me.Controls.Add(Me.cmbImprimir)
        Me.Controls.Add(Me.jngPedidos)
        Me.Controls.Add(Me.jngAlbaranes)
        Me.Controls.Add(Me.jngCobros)
        Me.Controls.Add(Me.lblfwiIdCliente)
        Me.Controls.Add(Me.lblfwiRiesgoConsumido)
        Me.Controls.Add(Me.lblfwiRiesgoPendiente)
        Me.Controls.Add(Me.lblfwiRiesgoConcedido)
        Me.Controls.Add(Me.fwiDescCliente)
        Me.Controls.Add(Me.fwiIdCliente)
        Me.Controls.Add(Me.fwiRiesgoConsumido)
        Me.Controls.Add(Me.fwiRiesgoPendiente)
        Me.Controls.Add(Me.fwiRiesgoConcedido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAlbaranes)
        Me.Controls.Add(Me.lblPedidos)
        Me.Controls.Add(Me.WLGrid)
        Me.Controls.Add(Me.Frame1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAnalisisRiesgo"
        Me.Text = "Análisis de Riesgo del Cliente"
        CType(Me.jngPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jngAlbaranes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jngFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jngCobros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WLGrid.ResumeLayout(False)
        Me.WLGrid.PerformLayout()
        CType(Me.gridAlquiler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jngGastos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jngMOD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jngMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jngCertificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jngHitos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.FraProveedorAsociado.ResumeLayout(False)
        Me.FraProveedorAsociado.PerformLayout()
        CType(Me.pctPeligro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Variables Privadas"

    Private mdblRiesgoConsumido As Double
    Private mdblRiesgoPendiente As Double
    Private mstrAlbTransf As String
    Private mstrAlbRetorno As String
    Private mblnGestionAlquiler As Boolean

    Private msIdCliente As String
    Private msDescCliente As String
    Private mlRiesgoConcedido As Double
    Private mFiltro As Filter
    Private mbConsumido As Boolean

#End Region

#Region "Propiedades Publicas"

    Public WriteOnly Property IdCliente() As String
        Set(ByVal Value As String)
            msIdCliente = Value
        End Set
    End Property

    Public WriteOnly Property DescCliente() As String
        Set(ByVal Value As String)
            msDescCliente = Value
        End Set
    End Property

    Public WriteOnly Property RiesgoConcedido() As Double
        Set(ByVal Value As Double)
            mlRiesgoConcedido = Value
        End Set
    End Property

#End Region

#Region "Procesos Privados"

    Private Sub SumaTotales()
        Dim MDblEntregasACuenta As Double = 0
        Dim dblTotalPedidos As Double = Nz(jngPedidos.GetTotal(jngPedidos.Columns("Importe"), AggregateFunction.Sum), 0)
        Dim dblTotalAlbaranes As Double = Nz(jngAlbaranes.GetTotal(jngAlbaranes.Columns("Importe"), AggregateFunction.Sum), 0)
        Dim dblTotalFacturas As Double = Nz(jngFacturas.GetTotal(jngFacturas.Columns("Importe"), AggregateFunction.Sum), 0)
        Dim dblTotalCobros As Double = Nz(jngCobros.GetTotal(jngCobros.Columns("Importe"), AggregateFunction.Sum), 0)
        Dim dblTotalHitos As Double = Nz(jngHitos.GetTotal(jngHitos.Columns("ImpVencimiento"), AggregateFunction.Sum), 0)
        Dim dblTotalCertificaciones As Double = Nz(jngCertificaciones.GetTotal(jngCertificaciones.Columns("ImpVencimientoA"), AggregateFunction.Sum), 0)
        Dim dblTotalMateriales As Double = Nz(jngMateriales.GetTotal(jngMateriales.Columns("ImpVencimientoA"), AggregateFunction.Sum), 0)
        Dim dblTotalMOD As Double = Nz(jngMOD.GetTotal(jngMOD.Columns("ImpVencimientoA"), AggregateFunction.Sum), 0)
        Dim dblTotalGastos As Double = Nz(jngGastos.GetTotal(jngGastos.Columns("ImpVencimientoA"), AggregateFunction.Sum), 0)
        Dim dblTotalAlquiler As Double
        If mblnGestionAlquiler Then
            dblTotalAlquiler = Nz(gridAlquiler.GetTotal(gridAlquiler.Columns("Importe"), AggregateFunction.Sum), 0)
        End If


        mdblRiesgoConsumido = dblTotalPedidos
        mdblRiesgoConsumido = mdblRiesgoConsumido + dblTotalAlbaranes
        mdblRiesgoConsumido = mdblRiesgoConsumido + dblTotalFacturas
        mdblRiesgoConsumido = mdblRiesgoConsumido + dblTotalCobros
        mdblRiesgoConsumido = mdblRiesgoConsumido + dblTotalHitos
        mdblRiesgoConsumido = mdblRiesgoConsumido + dblTotalMOD
        mdblRiesgoConsumido = mdblRiesgoConsumido + dblTotalCertificaciones
        mdblRiesgoConsumido = mdblRiesgoConsumido + dblTotalMateriales
        mdblRiesgoConsumido = mdblRiesgoConsumido + dblTotalGastos
        If mblnGestionAlquiler Then
            mdblRiesgoConsumido = mdblRiesgoConsumido + dblTotalAlquiler
        End If

        Dim FilEntregas As New Filter
        If Not mIDClientesGrupo Is Nothing AndAlso mIDClientesGrupo.Length > 0 Then
            FilEntregas.Add(New InListFilterItem("IDCliente", mIDClientesGrupo, FilterType.String))
        Else
            FilEntregas.Add("IDCliente", FilterOperator.Equal, msIdCliente)
        End If

        FilEntregas.Add("TipoEntrega", FilterOperator.Equal, CInt(enumTipoEntrega.Anticipo))
        FilEntregas.Add("Saldado", FilterOperator.Equal, False)
        FilEntregas.Add("Generado", FilterOperator.Equal, True)
        Dim DtEntregas As DataTable = New BE.DataEngine().Filter("vCIEntregasACuenta", FilEntregas)
        If Not DtEntregas Is Nothing AndAlso DtEntregas.Rows.Count > 0 Then
            MDblEntregasACuenta = DtEntregas.Compute("SUM(ImpTotalA)", Nothing)
            Me.NtbEntregasACuentaPend.Value = MDblEntregasACuenta
        End If
        mdblRiesgoConsumido -= MDblEntregasACuenta

        fwiRiesgoConsumido.Value = mdblRiesgoConsumido

        If Len(fwiRiesgoConsumido.Value) > 0 Then
            fwiRiesgoPendiente.Value = Nz(fwiRiesgoConcedido.Value, 0) - mdblRiesgoConsumido
            mdblRiesgoPendiente = fwiRiesgoPendiente.Value
        End If
        pctPeligro.Visible = IIf(CDbl(Nz(fwiRiesgoPendiente.Value, 0)) > 0, False, True)
    End Sub

#End Region

#Region "Eventos Formulario"

    Private mIDClientesGrupo(-1) As Object

    Private Sub FrmAnalisisRiesgo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            Dim datParams As DataParamRiesgoCliente = ExpertisApp.ExecuteTask(Of String, DataParamRiesgoCliente)(AddressOf Cliente.GetParamsRiesgoCliente, msIdCliente)
            mstrAlbTransf = datParams.TipoAlbaranDeDeposito
            mstrAlbRetorno = datParams.TipoAlbaranRetornoAlquiler
            mblnGestionAlquiler = datParams.GestionAlquiler
            Me.lblGrupoRiesgo.Visible = datParams.RiesgoGrupo

            fwiIdCliente.Text = msIdCliente
            fwiDescCliente.Text = msDescCliente
            fwiRiesgoConcedido.Value = datParams.RiesgoConcedido
            nbxRiesgoInterno.Value = datParams.RiesgoInterno
            nbxRiesgoCapAsegurado.Value = datParams.LimiteCapitalAsegurado

            If Length(datParams.IDProveedorAsociado) > 0 Then
                Me.FraProveedorAsociado.Visible = True
                Me.txtIDProveedor.Text = datParams.IDProveedorAsociado
                Me.txtDescProveedor.Text = datParams.DescProveedorAsociado
                Me.nbxPendienteProv.Value = datParams.PdteFacturar + datParams.PagosNoPagados
            End If

            Dim Fil As New Filter
            If Me.lblGrupoRiesgo.Visible OrElse (Not datParams.IDClientesGrupo Is Nothing AndAlso datParams.IDClientesGrupo.Length > 0) Then
                If Not datParams.IDClientesGrupo Is Nothing AndAlso datParams.IDClientesGrupo.Length > 0 Then
                    ReDim mIDClientesGrupo(datParams.IDClientesGrupo.Length - 1)
                    datParams.IDClientesGrupo.CopyTo(mIDClientesGrupo, 0)
                    Fil.Add(New InListFilterItem("IDCliente", datParams.IDClientesGrupo, FilterType.String))

                    jngPedidos.GroupTotals = GroupTotals.Always
                    jngAlbaranes.GroupTotals = GroupTotals.Always
                    jngFacturas.GroupTotals = GroupTotals.Always
                    jngCobros.GroupTotals = GroupTotals.Always
                    jngHitos.GroupTotals = GroupTotals.Always
                    jngCertificaciones.GroupTotals = GroupTotals.Always
                    jngMOD.GroupTotals = GroupTotals.Always
                    jngMateriales.GroupTotals = GroupTotals.Always
                    jngGastos.GroupTotals = GroupTotals.Always
                    gridAlquiler.GroupTotals = GroupTotals.Always
                Else
                    Fil.Add(New StringFilterItem("IDCliente", msIdCliente))
                End If
            Else
                Fil.Add(New StringFilterItem("IDCliente", msIdCliente))
            End If

            jngPedidos.ReQuery(Fil)
            jngAlbaranes.ReQuery(Fil)
            jngFacturas.ReQuery(Fil)
            jngCobros.ReQuery(Fil)
            jngHitos.ReQuery(Fil)
            jngCertificaciones.ReQuery(Fil)
            jngMOD.ReQuery(Fil)
            jngMateriales.ReQuery(Fil)
            jngGastos.ReQuery(Fil)

            If mblnGestionAlquiler Then
                'Lanzar proceso de facturación
                Dim datosVtos As New dataConfigCalculoFacturacion(Date.Today, Fil, 0, False, False, enumomACalculoRiesgoCliente.omACalculoRiesgoPorObra, msIdCliente)
                gridAlquiler.DataSource = ExpertisApp.ExecuteTask(Of dataConfigCalculoFacturacion, DataTable)(AddressOf CalculoFacturacion.GetLineasFacturacionAlquiler, datosVtos)
            Else
                gridAlquiler.Visible = False
                lblFacturacionMaterialAlquilado.Visible = False
            End If

            CollapseGroups()
            SumaTotales()
        End If

    End Sub

    Private Sub CollapseGroups()
        jngPedidos.CollapseGroups()
        jngAlbaranes.CollapseGroups()
        jngFacturas.CollapseGroups()
        jngCobros.CollapseGroups()

        jngHitos.CollapseGroups()
        jngCertificaciones.CollapseGroups()
        jngMOD.CollapseGroups()
        jngMateriales.CollapseGroups()
        jngGastos.CollapseGroups()
        If mblnGestionAlquiler Then gridAlquiler.CollapseGroups()
    End Sub

    Private Sub cmbImprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbImprimir.Click
        Dim RptRiesgo As New Report("ARC")
        RptRiesgo.Filter.Add(New StringFilterItem("IDCliente", msIdCliente))
        RptRiesgo.Formulas("RConsumido").Text = String.Format(mdblRiesgoConsumido, "#,0.00")
        RptRiesgo.Formulas("RPendiente").Text = String.Format(mdblRiesgoPendiente, "#,0.00")
        ExpertisApp.OpenReport(RptRiesgo)
        Me.Close()
    End Sub

#End Region

End Class