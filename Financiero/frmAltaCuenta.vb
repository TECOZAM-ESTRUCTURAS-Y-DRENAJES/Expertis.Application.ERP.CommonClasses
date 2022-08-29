Public Class frmAltaCuenta
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
    Friend WithEvents fwiCuentaNueva As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblfwiGrupoAmortiz As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiGrupoAmortiz As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents fwiAnalitica As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdDetalle As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents fwiEjercicioSiguiente As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents fwiEjercicioActual As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents fwiEjercicioAnterior As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents optNinguno As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents optVenta As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents optInversion As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents optGasto As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents optCompra As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents PnGrid As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents PnDetalle As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents PnBotones As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Frame2 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents chkEjercicioActualTributario As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkEliminacion As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkGrupo As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents TxtNIFEmpresa As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblNIFEmpresa As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDDivisa As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblDivisa As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAltaCuenta))
        Me.fwiCuentaNueva = New Solmicro.Expertis.Engine.UI.TextBox
        Me.PnGrid = New Solmicro.Expertis.Engine.UI.Panel
        Me.PnDetalle = New Solmicro.Expertis.Engine.UI.Panel
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.AdvIDDivisa = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblDivisa = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiGrupoAmortiz = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiGrupoAmortiz = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.fwiAnalitica = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.optNinguno = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.optVenta = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.optInversion = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.optGasto = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.optCompra = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.PnBotones = New Solmicro.Expertis.Engine.UI.Panel
        Me.LblNIFEmpresa = New Solmicro.Expertis.Engine.UI.Label
        Me.TxtNIFEmpresa = New Solmicro.Expertis.Engine.UI.TextBox
        Me.chkEliminacion = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkGrupo = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.cmdDetalle = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.Frame2 = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkEjercicioActualTributario = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.fwiEjercicioSiguiente = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.fwiEjercicioActual = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.fwiEjercicioAnterior = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.PnGrid.suspendlayout()
        Me.PnDetalle.suspendlayout()
        Me.Frame1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PnBotones.suspendlayout()
        Me.Frame2.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fwiCuentaNueva
        '
        Me.fwiCuentaNueva.DisabledBackColor = System.Drawing.Color.White
        Me.fwiCuentaNueva.Location = New System.Drawing.Point(10, 3)
        Me.fwiCuentaNueva.Name = "fwiCuentaNueva"
        Me.fwiCuentaNueva.Size = New System.Drawing.Size(127, 21)
        Me.fwiCuentaNueva.TabIndex = 3
        '
        'PnGrid
        '
        Me.PnGrid.Controls.Add(Me.PnDetalle)
        Me.PnGrid.Controls.Add(Me.PnBotones)
        Me.PnGrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnGrid.Location = New System.Drawing.Point(0, 236)
        Me.PnGrid.Name = "PnGrid"
        Me.PnGrid.Size = New System.Drawing.Size(547, 144)
        Me.PnGrid.TabIndex = 25
        '
        'PnDetalle
        '
        Me.PnDetalle.Controls.Add(Me.Frame1)
        Me.PnDetalle.Controls.Add(Me.GroupBox1)
        Me.PnDetalle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnDetalle.Location = New System.Drawing.Point(0, 72)
        Me.PnDetalle.Name = "PnDetalle"
        Me.PnDetalle.Size = New System.Drawing.Size(547, 72)
        Me.PnDetalle.TabIndex = 26
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.lblfwiGrupoAmortiz)
        Me.Frame1.Controls.Add(Me.fwiGrupoAmortiz)
        Me.Frame1.Controls.Add(Me.fwiAnalitica)
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Frame1.Location = New System.Drawing.Point(0, 36)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(547, 36)
        Me.Frame1.TabIndex = 40
        Me.Frame1.TabStop = False
        '
        'AdvIDDivisa
        '
        Me.AdvIDDivisa.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDDivisa.EntityName = "Moneda"
        Me.AdvIDDivisa.Location = New System.Drawing.Point(327, 45)
        Me.AdvIDDivisa.Name = "AdvIDDivisa"
        Me.AdvIDDivisa.SecondaryDataFields = "IDMoneda"
        Me.AdvIDDivisa.Size = New System.Drawing.Size(76, 23)
        Me.AdvIDDivisa.TabIndex = 44
        Me.AdvIDDivisa.ViewName = "tbMaestroMoneda"
        '
        'lblDivisa
        '
        Me.lblDivisa.Location = New System.Drawing.Point(327, 24)
        Me.lblDivisa.Name = "lblDivisa"
        Me.lblDivisa.Size = New System.Drawing.Size(42, 13)
        Me.lblDivisa.TabIndex = 43
        Me.lblDivisa.Text = "Divisa"
        '
        'lblfwiGrupoAmortiz
        '
        Me.lblfwiGrupoAmortiz.Location = New System.Drawing.Point(313, 14)
        Me.lblfwiGrupoAmortiz.Name = "lblfwiGrupoAmortiz"
        Me.lblfwiGrupoAmortiz.Size = New System.Drawing.Size(94, 13)
        Me.lblfwiGrupoAmortiz.TabIndex = 42
        Me.lblfwiGrupoAmortiz.Text = "Grupo Amortiz."
        Me.lblfwiGrupoAmortiz.Visible = False
        '
        'fwiGrupoAmortiz
        '
        Me.fwiGrupoAmortiz.DisabledBackColor = System.Drawing.Color.White
        Me.fwiGrupoAmortiz.EntityName = "GrupoAmortizacion"
        Me.fwiGrupoAmortiz.Location = New System.Drawing.Point(409, 9)
        Me.fwiGrupoAmortiz.Name = "fwiGrupoAmortiz"
        Me.fwiGrupoAmortiz.SecondaryDataFields = "IDGrupoAmortiz"
        Me.fwiGrupoAmortiz.Size = New System.Drawing.Size(76, 23)
        Me.fwiGrupoAmortiz.TabIndex = 40
        Me.fwiGrupoAmortiz.ViewName = "tbMaestroGrupoAmortizacion"
        Me.fwiGrupoAmortiz.Visible = False
        '
        'fwiAnalitica
        '
        Me.fwiAnalitica.Location = New System.Drawing.Point(16, 10)
        Me.fwiAnalitica.Name = "fwiAnalitica"
        Me.fwiAnalitica.Size = New System.Drawing.Size(67, 19)
        Me.fwiAnalitica.TabIndex = 39
        Me.fwiAnalitica.Text = "Analítica"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optNinguno)
        Me.GroupBox1.Controls.Add(Me.optVenta)
        Me.GroupBox1.Controls.Add(Me.optInversion)
        Me.GroupBox1.Controls.Add(Me.optGasto)
        Me.GroupBox1.Controls.Add(Me.optCompra)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(547, 30)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'optNinguno
        '
        Me.optNinguno.Location = New System.Drawing.Point(25, 8)
        Me.optNinguno.Name = "optNinguno"
        Me.optNinguno.Size = New System.Drawing.Size(79, 19)
        Me.optNinguno.TabIndex = 46
        Me.optNinguno.Text = "Ninguno"
        '
        'optVenta
        '
        Me.optVenta.Location = New System.Drawing.Point(119, 8)
        Me.optVenta.Name = "optVenta"
        Me.optVenta.Size = New System.Drawing.Size(54, 19)
        Me.optVenta.TabIndex = 45
        Me.optVenta.Text = "Venta"
        '
        'optInversion
        '
        Me.optInversion.Location = New System.Drawing.Point(378, 8)
        Me.optInversion.Name = "optInversion"
        Me.optInversion.Size = New System.Drawing.Size(78, 19)
        Me.optInversion.TabIndex = 44
        Me.optInversion.Text = "Inversión"
        '
        'optGasto
        '
        Me.optGasto.Location = New System.Drawing.Point(295, 8)
        Me.optGasto.Name = "optGasto"
        Me.optGasto.Size = New System.Drawing.Size(54, 19)
        Me.optGasto.TabIndex = 43
        Me.optGasto.Text = "Gasto"
        '
        'optCompra
        '
        Me.optCompra.Location = New System.Drawing.Point(200, 8)
        Me.optCompra.Name = "optCompra"
        Me.optCompra.Size = New System.Drawing.Size(76, 19)
        Me.optCompra.TabIndex = 42
        Me.optCompra.Text = "Compra"
        '
        'PnBotones
        '
        Me.PnBotones.Controls.Add(Me.AdvIDDivisa)
        Me.PnBotones.Controls.Add(Me.LblNIFEmpresa)
        Me.PnBotones.Controls.Add(Me.lblDivisa)
        Me.PnBotones.Controls.Add(Me.TxtNIFEmpresa)
        Me.PnBotones.Controls.Add(Me.chkEliminacion)
        Me.PnBotones.Controls.Add(Me.chkGrupo)
        Me.PnBotones.Controls.Add(Me.cmdDetalle)
        Me.PnBotones.Controls.Add(Me.cmbAceptar)
        Me.PnBotones.Controls.Add(Me.cmbCancelar)
        Me.PnBotones.Controls.Add(Me.Frame2)
        Me.PnBotones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnBotones.Location = New System.Drawing.Point(0, 0)
        Me.PnBotones.Name = "PnBotones"
        Me.PnBotones.Size = New System.Drawing.Size(547, 75)
        Me.PnBotones.TabIndex = 25
        '
        'LblNIFEmpresa
        '
        Me.LblNIFEmpresa.Location = New System.Drawing.Point(189, 50)
        Me.LblNIFEmpresa.Name = "LblNIFEmpresa"
        Me.LblNIFEmpresa.Size = New System.Drawing.Size(26, 13)
        Me.LblNIFEmpresa.TabIndex = 36
        Me.LblNIFEmpresa.Text = "NIF"
        '
        'TxtNIFEmpresa
        '
        Me.TxtNIFEmpresa.DisabledBackColor = System.Drawing.Color.White
        Me.TxtNIFEmpresa.Location = New System.Drawing.Point(221, 45)
        Me.TxtNIFEmpresa.Name = "TxtNIFEmpresa"
        Me.TxtNIFEmpresa.Size = New System.Drawing.Size(100, 21)
        Me.TxtNIFEmpresa.TabIndex = 35
        '
        'chkEliminacion
        '
        Me.chkEliminacion.Location = New System.Drawing.Point(92, 46)
        Me.chkEliminacion.Name = "chkEliminacion"
        Me.chkEliminacion.Size = New System.Drawing.Size(91, 20)
        Me.chkEliminacion.TabIndex = 34
        Me.chkEliminacion.Text = "Eliminación"
        '
        'chkGrupo
        '
        Me.chkGrupo.Location = New System.Drawing.Point(17, 46)
        Me.chkGrupo.Name = "chkGrupo"
        Me.chkGrupo.Size = New System.Drawing.Size(71, 20)
        Me.chkGrupo.TabIndex = 33
        Me.chkGrupo.Text = "Grupo"
        '
        'cmdDetalle
        '
        Me.cmdDetalle.Location = New System.Drawing.Point(408, 42)
        Me.cmdDetalle.Name = "cmdDetalle"
        Me.cmdDetalle.Size = New System.Drawing.Size(133, 27)
        Me.cmdDetalle.TabIndex = 31
        Me.cmdDetalle.Text = "Detalle ..."
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(408, 8)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(65, 32)
        Me.cmbAceptar.TabIndex = 22
        Me.cmbAceptar.Text = "Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(476, 8)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(65, 32)
        Me.cmbCancelar.TabIndex = 21
        Me.cmbCancelar.Text = "Cancelar"
        '
        'Frame2
        '
        Me.Frame2.Controls.Add(Me.chkEjercicioActualTributario)
        Me.Frame2.Controls.Add(Me.fwiEjercicioSiguiente)
        Me.Frame2.Controls.Add(Me.fwiEjercicioActual)
        Me.Frame2.Controls.Add(Me.fwiEjercicioAnterior)
        Me.Frame2.Location = New System.Drawing.Point(9, 4)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = New System.Drawing.Size(312, 37)
        Me.Frame2.TabIndex = 26
        Me.Frame2.TabStop = False
        '
        'chkEjercicioActualTributario
        '
        Me.chkEjercicioActualTributario.Location = New System.Drawing.Point(7, 11)
        Me.chkEjercicioActualTributario.Name = "chkEjercicioActualTributario"
        Me.chkEjercicioActualTributario.Size = New System.Drawing.Size(74, 20)
        Me.chkEjercicioActualTributario.TabIndex = 34
        Me.chkEjercicioActualTributario.Text = "Tributario"
        '
        'fwiEjercicioSiguiente
        '
        Me.fwiEjercicioSiguiente.Location = New System.Drawing.Point(234, 11)
        Me.fwiEjercicioSiguiente.Name = "fwiEjercicioSiguiente"
        Me.fwiEjercicioSiguiente.Size = New System.Drawing.Size(70, 20)
        Me.fwiEjercicioSiguiente.TabIndex = 33
        Me.fwiEjercicioSiguiente.Text = "sig"
        '
        'fwiEjercicioActual
        '
        Me.fwiEjercicioActual.Location = New System.Drawing.Point(163, 11)
        Me.fwiEjercicioActual.Name = "fwiEjercicioActual"
        Me.fwiEjercicioActual.Size = New System.Drawing.Size(74, 20)
        Me.fwiEjercicioActual.TabIndex = 32
        Me.fwiEjercicioActual.Text = "act"
        '
        'fwiEjercicioAnterior
        '
        Me.fwiEjercicioAnterior.Location = New System.Drawing.Point(87, 11)
        Me.fwiEjercicioAnterior.Name = "fwiEjercicioAnterior"
        Me.fwiEjercicioAnterior.Size = New System.Drawing.Size(68, 20)
        Me.fwiEjercicioAnterior.TabIndex = 31
        Me.fwiEjercicioAnterior.Text = "ant"
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDDivisa", "Moneda", "IDMoneda")})
        Me.Grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = Nothing
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(547, 236)
        Me.Grid.TabIndex = 26
        Me.Grid.Tag = "IdRec=5361:5362:4595:4629:;"
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = Nothing
        '
        'frmAltaCuenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(547, 380)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.PnGrid)
        Me.Controls.Add(Me.fwiCuentaNueva)
        Me.Name = "frmAltaCuenta"
        Me.Text = "Detalle ..."
        Me.PnGrid.ResumeLayout(False)
        Me.PnDetalle.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.PnBotones.ResumeLayout(False)
        Me.PnBotones.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region " Propiedades "

    Private mdtEjercicios As DataTable
    Public Property Ejercicios() As DataTable
        Get
            Return mdtEjercicios
        End Get
        Set(ByVal Value As DataTable)
            mdtEjercicios = Value
        End Set
    End Property

    Private mstrCuentaAlta As String
    Public Property CuentaAlta() As String
        Get
            Return mstrCuentaAlta
        End Get
        Set(ByVal Value As String)
            mstrCuentaAlta = Value
        End Set
    End Property

    Private mstrDescCuentaAlta As String
    Public Property DescCuentaAlta() As String
        Get
            Return mstrDescCuentaAlta
        End Get
        Set(ByVal Value As String)
            mstrDescCuentaAlta = Value
        End Set
    End Property

    Private mblnAltaOk As Boolean
    Public Property AltaOK() As Boolean
        Get
            Return mblnAltaOk
        End Get
        Set(ByVal Value As Boolean)
            mblnAltaOk = Value
        End Set
    End Property

    Private mblnGrupo As Boolean
    Public Property Grupo() As Boolean
        Get
            Return mblnGrupo
        End Get
        Set(ByVal Value As Boolean)
            mblnGrupo = Value
        End Set
    End Property

    Private mIDDivisa As String
    Public Property IDDivisa() As String
        Get
            Return mIDDivisa
        End Get
        Set(ByVal value As String)
            mIDDivisa = value
        End Set
    End Property

#End Region

    'Private Const cnMENSAJE_LONGITUD As String = "La nueva cuenta a crear tiene una longitud incorrecta en alguno de los ejercicios. " & Chr(13) & _
    '                                           "¿Desea darla de alta de todas formas?"

    Private Const cnMAYOR1 As Integer = 1
    Private Const cnMAYOR6 As Integer = 6

#Region " Carga del formulario "
    Protected mIDMonedaA As String
    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            Dim strEjercicioAlta As String
            Dim EC As New EjercicioContable
            Dim objNegPlanContable As New PlanContable

            mblnAltaOk = False
            Me.Text = Me.Text & mstrCuentaAlta
            chkEjercicioActualTributario.Visible = False
            fwiEjercicioAnterior.Visible = False
            fwiEjercicioActual.Visible = False
            fwiEjercicioSiguiente.Visible = False
            Me.chkGrupo.Checked = mblnGrupo
            Dim p As New Parametro
            mIDMonedaA = p.MonedaInternaA

            If Length(mIDDivisa) > 0 AndAlso mIDDivisa <> mIDMonedaA Then Me.AdvIDDivisa.Value = mIDDivisa

            Dim DE As New BE.DataEngine
            Dim dt As DataTable = DE.Filter("vFrmAltaCuentaContable", New NoRowsFilterItem)

            ' Dim objFilterEjercicios As New Filter(FilterUnionOperator.Or)
            Dim blnMsgLongitud As Boolean
            For Each drEjercicio As DataRow In mdtEjercicios.Rows
                ' objFilterEjercicios.Add(New StringFilterItem("IDEjercicio", drEjercicio("IDEjercicio")))
                If Length(mstrCuentaAlta) > cnMAYOR6 AndAlso Length(mstrCuentaAlta) < drEjercicio("DigitosAuxiliar") Then
                    blnMsgLongitud = True
                End If
            Next

            If blnMsgLongitud Then

                If ExpertisApp.GenerateMessage("La nueva cuenta a crear tiene una longitud incorrecta en alguno de los ejercicios. |" & _
                                               "¿Desea darla de alta de todas formas?", MessageBoxButtons.YesNo, MessageBoxIcon.Information, vbNewLine) = DialogResult.No Then
                    Me.Close()
                    Exit Sub
                End If
            End If

            ''//Traemos el Plan Contable de los Ejercicios indicados, para comprobar si la C.Contable o los Mayores existen ya en dichos ejercicios.
            'Dim dtPlanEjercicios As DataTable = objNegPlanContable.Filter(objFilterEjercicios)

            For Each drEjercicio As DataRow In mdtEjercicios.Rows
                strEjercicioAlta = drEjercicio("IDEjercicio") & String.Empty
                If Nz(drEjercicio("Actual"), 0) = 1 Then
                    fwiEjercicioActual.Text = strEjercicioAlta
                    fwiEjercicioActual.Visible = True
                    fwiEjercicioActual.Checked = True
                ElseIf Nz(drEjercicio("ActualTributario"), 0) = 1 Then
                    chkEjercicioActualTributario.Text = strEjercicioAlta
                    chkEjercicioActualTributario.Visible = True
                    chkEjercicioActualTributario.Checked = True
                ElseIf Nz(drEjercicio("Anterior"), 0) = 1 Then
                    fwiEjercicioAnterior.Text = strEjercicioAlta
                    fwiEjercicioAnterior.Visible = True
                    fwiEjercicioAnterior.Checked = True
                ElseIf Nz(drEjercicio("Siguiente"), 0) = 1 Then
                    fwiEjercicioSiguiente.Text = strEjercicioAlta
                    fwiEjercicioSiguiente.Visible = True
                    fwiEjercicioSiguiente.Checked = True
                End If

                Dim dtEjercicio As DataTable = EC.SelOnPrimaryKey(strEjercicioAlta)
                If Not IsNothing(dtEjercicio) AndAlso dtEjercicio.Rows.Count > 0 Then
                    '//Agregamos los mayores
                    For indice As Integer = cnMAYOR1 To cnMAYOR6
                        If dtEjercicio.Rows(0)("DigitosMayor" & indice) AndAlso Length(mstrCuentaAlta) >= indice Then
                            If Not ExisteCuentaEnPlan(strEjercicioAlta, Strings.Left(mstrCuentaAlta, indice)) Then
                                Dim drNewRow As DataRow = dt.NewRow
                                drNewRow("Mayor") = "Mayor" & " " & indice
                                drNewRow("IdEjercicio") = strEjercicioAlta
                                drNewRow("IdCContable") = Strings.Left(mstrCuentaAlta, indice)
                                drNewRow("DescCContable") = mstrDescCuentaAlta
                                If dt.Columns.Contains("IDDivisa") AndAlso Me.AdvIDDivisa.Value & String.Empty <> mIDMonedaA Then drNewRow("IDDivisa") = Me.AdvIDDivisa.Value
                                dt.Rows.Add(drNewRow)
                            End If
                        End If
                    Next indice

                    '//Agregamos las cuentas auxiliares.
                    If (Length(mstrCuentaAlta) > cnMAYOR6 AndAlso Length(mstrCuentaAlta) <= drEjercicio("DigitosAuxiliar")) Then
                        If Not ExisteCuentaEnPlan(strEjercicioAlta, mstrCuentaAlta) Then
                            Dim drNewRow As DataRow = dt.NewRow
                            drNewRow("Mayor") = "Cuenta Contable"
                            drNewRow("IdEjercicio") = strEjercicioAlta
                            drNewRow("IdCContable") = mstrCuentaAlta
                            drNewRow("DescCContable") = mstrDescCuentaAlta
                            If dt.Columns.Contains("IDDivisa") AndAlso Me.AdvIDDivisa.Value & String.Empty <> mIDMonedaA Then drNewRow("IDDivisa") = Me.AdvIDDivisa.Value
                            dt.Rows.Add(drNewRow)
                        End If
                    End If
                Else
                    ExpertisApp.GenerateMessage("No existe Ejecicio Contable.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Next

            Grid.DataSource = dt
            Grid.Refresh()
        End If
    End Sub

    Private Function ExisteCuentaEnPlan(ByVal strIDEjercicio As String, ByVal strCContable As String) As Boolean
        ExisteCuentaEnPlan = False
        Dim objFilter As New Filter
        objFilter.Add(New StringFilterItem("IDEjercicio", strIDEjercicio))
        objFilter.Add(New StringFilterItem("IDCContable", strCContable))
        Dim dt As DataTable = New PlanContable().Filter(objFilter)
        ExisteCuentaEnPlan = (dt.Rows.Count > 0)
    End Function

#End Region

#Region " Checks de Ejercicios "

    Private Sub fwiEjercicioSiguiente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwiEjercicioSiguiente.CheckedChanged
        RefrescarGRID()
    End Sub

    Private Sub fwiEjercicioAnterior_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwiEjercicioAnterior.CheckedChanged
        RefrescarGRID()
    End Sub

    Private Sub fwiEjercicioActual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwiEjercicioActual.CheckedChanged
        RefrescarGRID()
    End Sub

    Private Sub chkEjercicioActualTributario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEjercicioActualTributario.CheckedChanged
        RefrescarGRID()
    End Sub

    Private Function RefrescarGRID() As String
        Dim strWhere As String = String.Empty
        If Not Grid.DataSource Is Nothing Then

            Dim objFilter As New Filter(FilterUnionOperator.Or)
            objFilter.Clear()
            If chkEjercicioActualTributario.Checked Then
                objFilter.Add(New StringFilterItem("IDEjercicio", chkEjercicioActualTributario.Text))
            End If
            If fwiEjercicioAnterior.Checked Then
                objFilter.Add(New StringFilterItem("IDEjercicio", fwiEjercicioAnterior.Text))
            End If
            If fwiEjercicioActual.Checked Then
                objFilter.Add(New StringFilterItem("IDEjercicio", fwiEjercicioActual.Text))
            End If
            If fwiEjercicioSiguiente.Checked Then
                objFilter.Add(New StringFilterItem("IDEjercicio", fwiEjercicioSiguiente.Text))
            End If

            If Not IsNothing(objFilter) AndAlso objFilter.Count > 0 Then
                strWhere = objFilter.Compose(New AdoFilterComposer)
            Else
                strWhere = "1=2"
            End If
            CType(Grid.DataSource, DataTable).DefaultView.RowFilter = strWhere
        End If
        RefrescarGRID = strWhere
    End Function

#End Region

#Region " Checks de detalle "

    Private Sub optInversion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optInversion.CheckedChanged
        fwiGrupoAmortiz.Visible = True
        lblfwiGrupoAmortiz.Visible = True
    End Sub

    Private Sub optNinguno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optNinguno.CheckedChanged
        fwiGrupoAmortiz.Visible = False
        lblfwiGrupoAmortiz.Visible = False
    End Sub

    Private Sub optVenta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optVenta.CheckedChanged
        optNinguno_CheckedChanged(optNinguno, New EventArgs)
    End Sub

    Private Sub optGasto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optGasto.CheckedChanged
        optNinguno_CheckedChanged(optNinguno, New EventArgs)
    End Sub

    Private Sub optCompra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCompra.CheckedChanged
        optNinguno_CheckedChanged(optNinguno, New EventArgs)
    End Sub

    Private Sub chkGrupo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkGrupo.CheckedChanged
        Me.LblNIFEmpresa.Visible = chkGrupo.Checked
        Me.TxtNIFEmpresa.Visible = chkGrupo.Checked
    End Sub

#End Region

#Region " Aceptar/Cancelar/Detalle "

    Private Sub cmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        If (Me.chkGrupo.Checked AndAlso Length(Me.TxtNIFEmpresa.Text) > 0) OrElse Not Me.chkGrupo.Checked Then
            If chkEjercicioActualTributario.Checked OrElse fwiEjercicioActual.Checked OrElse fwiEjercicioAnterior.Checked OrElse fwiEjercicioSiguiente.Checked Then
                Dim objNegPlanContable As New PlanContable
                Dim objNegEjercicio As New EjercicioContable
                Dim dtPlanContable As DataTable = objNegPlanContable.AddNew

                If Not Grid.DataSource Is Nothing Then
                    Dim intNDigitosAuxiliar As Integer
                    Dim strIDEjercicio As String = String.Empty
                    For Each drRowGrid As DataRow In CType(Grid.DataSource, DataTable).Select(RefrescarGRID(), "IDEjercicio")
                        If strIDEjercicio <> drRowGrid("IDEjercicio") Then
                            intNDigitosAuxiliar = objNegEjercicio.GetNDigitosAuxiliar(drRowGrid("IDEjercicio"))
                            strIDEjercicio = drRowGrid("IDEjercicio")
                        End If
                        Dim FilPlan As New Filter
                        FilPlan.Add("IDEjercicio", FilterOperator.Equal, drRowGrid("IDEjercicio"))
                        FilPlan.Add("IDCContable", FilterOperator.Equal, drRowGrid("IDCContable"))
                        Dim DtPlan As DataTable = New PlanContable().Filter(FilPlan)
                        If DtPlan Is Nothing OrElse DtPlan.Rows.Count = 0 Then
                            With dtPlanContable
                                Dim drNewRow As DataRow = .NewRow
                                drNewRow("IdEjercicio") = drRowGrid("IdEjercicio")
                                drNewRow("IdCContable") = drRowGrid("IdCContable")
                                drNewRow("DescCContable") = drRowGrid("DescCContable")
                                If DtPlan.Columns.Contains("IDDivisa") AndAlso drRowGrid("IDDivisa") & String.Empty <> mIDMonedaA Then drNewRow("IDDivisa") = drRowGrid("IDDivisa")

                                '  drNewRow("Balance") = fwiBalance.Checked
                                drNewRow("Venta") = optVenta.Checked
                                drNewRow("Compra") = optCompra.Checked
                                drNewRow("Gasto") = optGasto.Checked
                                drNewRow("Inversion") = optInversion.Checked
                                drNewRow("Grupo") = chkGrupo.Checked
                                drNewRow("Eliminacion") = chkEliminacion.Checked
                                If drNewRow("Inversion") Then
                                    If Length(fwiGrupoAmortiz.Text) Then
                                        drNewRow("IdGrupoAmortiz") = fwiGrupoAmortiz.Text
                                    End If
                                End If
                                If drNewRow("Grupo") Then drNewRow("NIFEmpresa") = Me.TxtNIFEmpresa.Text
                                drNewRow("Analitica") = fwiAnalitica.Checked

                                If (Length(drNewRow("IdCContable")) > cnMAYOR6 AndAlso Length(drNewRow("IdCContable")) <= intNDigitosAuxiliar) Then
                                    drNewRow("Auxiliar") = True
                                End If
                                .Rows.Add(drNewRow)
                            End With
                        End If
                    Next

                    objNegPlanContable.Update(dtPlanContable)
                    mblnAltaOk = True
                End If
            End If
            Me.Close()
        Else : ExpertisApp.GenerateMessage("La cuenta se ha marcado de grupo y hace falta especificar el NIF de Empresa.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub cmbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDetalle.Click
        PnDetalle.Visible = Not PnDetalle.Visible
        If PnDetalle.Visible Then
            PnDetalle.Height = PnBotones.Height
        Else
            PnDetalle.Height = 0
        End If
    End Sub

#End Region

    Protected Overridable Sub AdvIDDivisa_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdvIDDivisa.LostFocus
        If mCambiosEnDivisa Then
            mCambiosEnDivisa = False
            Dim dtGrid As DataTable = CType(Grid.DataSource, DataTable)
            If Not dtGrid Is Nothing AndAlso dtGrid.Rows.Count > 0 AndAlso dtGrid.Columns.Contains("IDDivisa") Then
                Dim Cuentas As List(Of DataRow) = (From c In dtGrid Select c).ToList
                If Not Cuentas Is Nothing AndAlso Cuentas.Count > 0 Then
                    For Each dr As DataRow In Cuentas
                        dr("IDDivisa") = Me.AdvIDDivisa.Value
                    Next
                End If
            End If
        End If
    End Sub

    Protected mCambiosEnDivisa As Boolean
    Protected Overridable Sub AdvIDDivisa_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdvIDDivisa.TextChanged
        mCambiosEnDivisa = True
    End Sub


End Class
