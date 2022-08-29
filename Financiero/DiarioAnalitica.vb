Imports Solmicro.Expertis.Business
Imports Solmicro.Expertis.Engine.BE

Public Class DiarioAnalitica
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
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents jngCentroCoste As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents cmdRepartirCG As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents lblcFwiRepartoCG As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents fwiIDCContable As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblfwiIDCContable As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiFecha As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblfwiFecha As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiImporte As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiDescripcion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblfwiDescripcion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiPorcentajeAcu As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblfwiPorcentajeAcu As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiImporteAcumulado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents WLFrame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents WLFrame2 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents fwiImporte As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents fwiImporteAcumulado As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblRepartoCG As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmbRepartoCG As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents SubGrid As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim jngCentroCoste_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DiarioAnalitica))
        Dim cmbRepartoCG_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim SubGrid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.jngCentroCoste = New Solmicro.Expertis.Engine.UI.Grid
        Me.cmdRepartirCG = New Solmicro.Expertis.Engine.UI.Button
        Me.lblcFwiRepartoCG = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiIDCContable = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiIDCContable = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFecha = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiImporte = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiDescripcion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiDescripcion = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiPorcentajeAcu = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiPorcentajeAcu = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiImporteAcumulado = New Solmicro.Expertis.Engine.UI.Label
        Me.WLFrame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.cmbRepartoCG = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.fwiImporte = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblRepartoCG = New Solmicro.Expertis.Engine.UI.Label
        Me.WLFrame2 = New Solmicro.Expertis.Engine.UI.Frame
        Me.fwiImporteAcumulado = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.SubGrid = New Solmicro.Expertis.Engine.UI.Grid
        CType(Me.jngCentroCoste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WLFrame1.SuspendLayout()
        CType(Me.cmbRepartoCG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WLFrame2.SuspendLayout()
        CType(Me.SubGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(326, 323)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(81, 25)
        Me.cmbAceptar.TabIndex = 0
        Me.cmbAceptar.Text = "Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(414, 323)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(81, 25)
        Me.cmbCancelar.TabIndex = 1
        Me.cmbCancelar.Text = "Cancelar"
        '
        'jngCentroCoste
        '
        Me.jngCentroCoste.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCentroGestion", "CentroGestion", "IDCentroGestion")})
        jngCentroCoste_DesignTimeLayout.LayoutString = resources.GetString("jngCentroCoste_DesignTimeLayout.LayoutString")
        Me.jngCentroCoste.DesignTimeLayout = jngCentroCoste_DesignTimeLayout
        Me.jngCentroCoste.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.jngCentroCoste.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngCentroCoste.EntityName = ""
        Me.jngCentroCoste.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngCentroCoste.Location = New System.Drawing.Point(8, 105)
        Me.jngCentroCoste.Name = "jngCentroCoste"
        Me.jngCentroCoste.PrimaryDataFields = Nothing
        Me.jngCentroCoste.SecondaryDataFields = Nothing
        Me.jngCentroCoste.Size = New System.Drawing.Size(488, 185)
        Me.jngCentroCoste.TabIndex = 4
        Me.jngCentroCoste.Tag = "IdRec=4569:4571:4401:4402:;"
        Me.jngCentroCoste.ViewName = Nothing
        '
        'cmdRepartirCG
        '
        Me.cmdRepartirCG.Image = CType(resources.GetObject("cmdRepartirCG.Image"), System.Drawing.Image)
        Me.cmdRepartirCG.Location = New System.Drawing.Point(18, 71)
        Me.cmdRepartirCG.Name = "cmdRepartirCG"
        Me.cmdRepartirCG.Size = New System.Drawing.Size(20, 21)
        Me.cmdRepartirCG.TabIndex = 15
        Me.cmdRepartirCG.Visible = False
        '
        'lblcFwiRepartoCG
        '
        Me.TryDataBinding(lblcFwiRepartoCG, New System.Windows.Forms.Binding("Text", Me.cmbRepartoCG, "DescRepartoCentroGestion", True))
        Me.lblcFwiRepartoCG.Location = New System.Drawing.Point(245, 72)
        Me.lblcFwiRepartoCG.Name = "lblcFwiRepartoCG"
        Me.lblcFwiRepartoCG.Size = New System.Drawing.Size(235, 21)
        Me.lblcFwiRepartoCG.TabIndex = 17
        Me.lblcFwiRepartoCG.Visible = False
        '
        'fwiIDCContable
        '
        Me.fwiIDCContable.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIDCContable.Enabled = False
        Me.fwiIDCContable.Location = New System.Drawing.Point(114, 12)
        Me.fwiIDCContable.Name = "fwiIDCContable"
        Me.fwiIDCContable.ReadOnly = True
        Me.fwiIDCContable.Size = New System.Drawing.Size(86, 21)
        Me.fwiIDCContable.TabIndex = 2
        '
        'lblfwiIDCContable
        '
        Me.lblfwiIDCContable.Location = New System.Drawing.Point(14, 12)
        Me.lblfwiIDCContable.Name = "lblfwiIDCContable"
        Me.lblfwiIDCContable.Size = New System.Drawing.Size(103, 13)
        Me.lblfwiIDCContable.TabIndex = 19
        Me.lblfwiIDCContable.Tag = "IdRec=4615;"
        Me.lblfwiIDCContable.Text = "Cuenta Contable"
        '
        'fwiFecha
        '
        Me.fwiFecha.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFecha.Enabled = False
        Me.fwiFecha.Location = New System.Drawing.Point(253, 12)
        Me.fwiFecha.Name = "fwiFecha"
        Me.fwiFecha.ReadOnly = True
        Me.fwiFecha.Size = New System.Drawing.Size(70, 21)
        Me.fwiFecha.TabIndex = 5
        '
        'lblfwiFecha
        '
        Me.lblfwiFecha.Location = New System.Drawing.Point(213, 12)
        Me.lblfwiFecha.Name = "lblfwiFecha"
        Me.lblfwiFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblfwiFecha.TabIndex = 20
        Me.lblfwiFecha.Tag = "IdRec=4638;"
        Me.lblfwiFecha.Text = "Fecha"
        '
        'lblfwiImporte
        '
        Me.lblfwiImporte.Location = New System.Drawing.Point(335, 12)
        Me.lblfwiImporte.Name = "lblfwiImporte"
        Me.lblfwiImporte.Size = New System.Drawing.Size(53, 13)
        Me.lblfwiImporte.TabIndex = 21
        Me.lblfwiImporte.Tag = "IdRec=4389;"
        Me.lblfwiImporte.Text = "Importe"
        '
        'fwiDescripcion
        '
        Me.fwiDescripcion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiDescripcion.Enabled = False
        Me.fwiDescripcion.Location = New System.Drawing.Point(114, 42)
        Me.fwiDescripcion.Name = "fwiDescripcion"
        Me.fwiDescripcion.ReadOnly = True
        Me.fwiDescripcion.Size = New System.Drawing.Size(374, 21)
        Me.fwiDescripcion.TabIndex = 7
        '
        'lblfwiDescripcion
        '
        Me.lblfwiDescripcion.Location = New System.Drawing.Point(14, 42)
        Me.lblfwiDescripcion.Name = "lblfwiDescripcion"
        Me.lblfwiDescripcion.Size = New System.Drawing.Size(73, 13)
        Me.lblfwiDescripcion.TabIndex = 22
        Me.lblfwiDescripcion.Tag = "IdRec=4934;"
        Me.lblfwiDescripcion.Text = "Descripción"
        '
        'fwiPorcentajeAcu
        '
        Me.fwiPorcentajeAcu.DisabledBackColor = System.Drawing.Color.White
        Me.fwiPorcentajeAcu.Enabled = False
        Me.fwiPorcentajeAcu.Location = New System.Drawing.Point(172, 10)
        Me.fwiPorcentajeAcu.Name = "fwiPorcentajeAcu"
        Me.fwiPorcentajeAcu.ReadOnly = True
        Me.fwiPorcentajeAcu.Size = New System.Drawing.Size(71, 21)
        Me.fwiPorcentajeAcu.TabIndex = 8
        Me.fwiPorcentajeAcu.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        '
        'lblfwiPorcentajeAcu
        '
        Me.lblfwiPorcentajeAcu.Location = New System.Drawing.Point(15, 302)
        Me.lblfwiPorcentajeAcu.Name = "lblfwiPorcentajeAcu"
        Me.lblfwiPorcentajeAcu.Size = New System.Drawing.Size(134, 13)
        Me.lblfwiPorcentajeAcu.TabIndex = 23
        Me.lblfwiPorcentajeAcu.Tag = "IdRec=4935;"
        Me.lblfwiPorcentajeAcu.Text = "Porcentaje acumulado"
        '
        'lblfwiImporteAcumulado
        '
        Me.lblfwiImporteAcumulado.Location = New System.Drawing.Point(8, 36)
        Me.lblfwiImporteAcumulado.Name = "lblfwiImporteAcumulado"
        Me.lblfwiImporteAcumulado.Size = New System.Drawing.Size(120, 13)
        Me.lblfwiImporteAcumulado.TabIndex = 24
        Me.lblfwiImporteAcumulado.Tag = "IdRec=4936;"
        Me.lblfwiImporteAcumulado.Text = "Importe Acumulado"
        '
        'WLFrame1
        '
        Me.WLFrame1.Controls.Add(Me.cmbRepartoCG)
        Me.WLFrame1.Controls.Add(Me.fwiImporte)
        Me.WLFrame1.Controls.Add(Me.lblRepartoCG)
        Me.WLFrame1.Controls.Add(Me.lblcFwiRepartoCG)
        Me.WLFrame1.Location = New System.Drawing.Point(8, 0)
        Me.WLFrame1.Name = "WLFrame1"
        Me.WLFrame1.Size = New System.Drawing.Size(488, 101)
        Me.WLFrame1.TabIndex = 11
        Me.WLFrame1.TabStop = False
        Me.WLFrame1.Tag = "IdRec=0;"
        '
        'cmbRepartoCG
        '
        cmbRepartoCG_DesignTimeLayout.LayoutString = resources.GetString("cmbRepartoCG_DesignTimeLayout.LayoutString")
        Me.cmbRepartoCG.DesignTimeLayout = cmbRepartoCG_DesignTimeLayout
        Me.cmbRepartoCG.DisabledBackColor = System.Drawing.Color.White
        Me.cmbRepartoCG.DisplayMember = "IDRepartoCentroGestion"
        Me.cmbRepartoCG.EntityName = "RepartoCGCabecera"
        Me.cmbRepartoCG.Location = New System.Drawing.Point(120, 72)
        Me.cmbRepartoCG.Name = "cmbRepartoCG"
        Me.cmbRepartoCG.PrimaryDataFields = "IDRepartoCentroGestion"
        Me.cmbRepartoCG.SecondaryDataFields = "IDRepartoCentroGestion"
        Me.cmbRepartoCG.SelectedIndex = -1
        Me.cmbRepartoCG.SelectedItem = Nothing
        Me.cmbRepartoCG.Size = New System.Drawing.Size(121, 21)
        Me.cmbRepartoCG.TabIndex = 2
        Me.cmbRepartoCG.ValueMember = "IDRepartoCentroGestion"
        Me.cmbRepartoCG.ViewName = "tbMaestroRepartoCentroGestionCabecera"
        Me.cmbRepartoCG.Visible = False
        '
        'fwiImporte
        '
        Me.fwiImporte.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImporte.Enabled = False
        Me.fwiImporte.Location = New System.Drawing.Point(384, 12)
        Me.fwiImporte.Name = "fwiImporte"
        Me.fwiImporte.ReadOnly = True
        Me.fwiImporte.Size = New System.Drawing.Size(98, 21)
        Me.fwiImporte.TabIndex = 0
        '
        'lblRepartoCG
        '
        Me.lblRepartoCG.Location = New System.Drawing.Point(32, 72)
        Me.lblRepartoCG.Name = "lblRepartoCG"
        Me.lblRepartoCG.Size = New System.Drawing.Size(86, 13)
        Me.lblRepartoCG.TabIndex = 1
        Me.lblRepartoCG.Text = "Reparto C. G."
        Me.lblRepartoCG.Visible = False
        '
        'WLFrame2
        '
        Me.WLFrame2.Controls.Add(Me.fwiImporteAcumulado)
        Me.WLFrame2.Controls.Add(Me.lblfwiImporteAcumulado)
        Me.WLFrame2.Controls.Add(Me.fwiPorcentajeAcu)
        Me.WLFrame2.Location = New System.Drawing.Point(8, 289)
        Me.WLFrame2.Name = "WLFrame2"
        Me.WLFrame2.Size = New System.Drawing.Size(248, 60)
        Me.WLFrame2.TabIndex = 10
        Me.WLFrame2.TabStop = False
        Me.WLFrame2.Tag = "IdRec=0;"
        '
        'fwiImporteAcumulado
        '
        Me.fwiImporteAcumulado.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImporteAcumulado.Enabled = False
        Me.fwiImporteAcumulado.Location = New System.Drawing.Point(147, 34)
        Me.fwiImporteAcumulado.Name = "fwiImporteAcumulado"
        Me.fwiImporteAcumulado.ReadOnly = True
        Me.fwiImporteAcumulado.Size = New System.Drawing.Size(96, 21)
        Me.fwiImporteAcumulado.TabIndex = 25
        '
        'SubGrid
        '
        Me.SubGrid.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        SubGrid_DesignTimeLayout.LayoutString = resources.GetString("SubGrid_DesignTimeLayout.LayoutString")
        Me.SubGrid.DesignTimeLayout = SubGrid_DesignTimeLayout
        Me.SubGrid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.SubGrid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.SubGrid.EntityName = Nothing
        Me.SubGrid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.SubGrid.Location = New System.Drawing.Point(328, 296)
        Me.SubGrid.Name = "SubGrid"
        Me.SubGrid.PrimaryDataFields = Nothing
        Me.SubGrid.ScrollBars = Janus.Windows.GridEX.ScrollBars.None
        Me.SubGrid.SecondaryDataFields = Nothing
        Me.SubGrid.Size = New System.Drawing.Size(165, 21)
        Me.SubGrid.TabIndex = 24
        Me.SubGrid.ViewName = Nothing
        Me.SubGrid.Visible = False
        '
        'DiarioAnalitica
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(506, 351)
        Me.Controls.Add(Me.SubGrid)
        Me.Controls.Add(Me.jngCentroCoste)
        Me.Controls.Add(Me.lblfwiIDCContable)
        Me.Controls.Add(Me.lblfwiFecha)
        Me.Controls.Add(Me.lblfwiImporte)
        Me.Controls.Add(Me.lblfwiDescripcion)
        Me.Controls.Add(Me.lblfwiPorcentajeAcu)
        Me.Controls.Add(Me.cmbAceptar)
        Me.Controls.Add(Me.cmbCancelar)
        Me.Controls.Add(Me.cmdRepartirCG)
        Me.Controls.Add(Me.fwiIDCContable)
        Me.Controls.Add(Me.fwiFecha)
        Me.Controls.Add(Me.fwiDescripcion)
        Me.Controls.Add(Me.WLFrame1)
        Me.Controls.Add(Me.WLFrame2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DiarioAnalitica"
        Me.Text = "Desglose Analítico"
        CType(Me.jngCentroCoste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WLFrame1.ResumeLayout(False)
        Me.WLFrame1.PerformLayout()
        CType(Me.cmbRepartoCG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WLFrame2.ResumeLayout(False)
        Me.WLFrame2.PerformLayout()
        CType(Me.SubGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region " Propiedades "

    Public WriteOnly Property ReadOnlyAnalitica() As Boolean
        Set(ByVal Value As Boolean)
            If Value Then
                jngCentroCoste.AllowAddNew = InheritableBoolean.False
                jngCentroCoste.AllowDelete = InheritableBoolean.False
            End If
        End Set
    End Property

    Private mintTipoAnalitica As enumtaTipoAnalitica = enumtaTipoAnalitica.AsientoNuevo
    Public Property TipoAnalitica() As enumtaTipoAnalitica
        Get
            Return mintTipoAnalitica
        End Get
        Set(ByVal Value As enumtaTipoAnalitica)
            mintTipoAnalitica = Value
            If mintTipoAnalitica = enumtaTipoAnalitica.AsientoPredeterminado Then
                Me.EntityName = "AsientoPredeterAnalitica"
                Me.ViewName = "tbMaestroAsientoPredeterAnalitica"
                jngCentroCoste.EntityName = Me.EntityName
                mblnMostarFecha = False
                mstrCampoImporte = "Importe"
                mstrCampoEnlace = "IDLinea"
            Else
                Me.EntityName = "DiarioContableCentro"
                Me.ViewName = "tbDiarioContableCentro"
                Me.FilterCriteria = New NoRowsFilterItem
                mblnMostarFecha = True
                mstrCampoImporte = "ImporteA"
                mstrCampoEnlace = "IDApunte"
            End If
            jngCentroCoste.EntityName = Me.EntityName
            jngCentroCoste.KeyField = mstrCampoEnlace
        End Set
    End Property

    Private mblnCCAnalitica As Boolean
    Public Property CCAnalitica() As Boolean
        Get
            Return mblnCCAnalitica
        End Get
        Set(ByVal Value As Boolean)
            mblnCCAnalitica = Value
        End Set
    End Property

    Private mstrCuentaContable As String
    Public Property CuentaContable() As String
        Get
            Return mstrCuentaContable
        End Get
        Set(ByVal Value As String)
            mstrCuentaContable = Value
        End Set
    End Property

    Private mstrDescripcionAnalitica As String  '//Descripción del Apunte
    Public Property DescripcionAnalitica() As String
        Get
            Return mstrDescripcionAnalitica
        End Get
        Set(ByVal Value As String)
            mstrDescripcionAnalitica = Value
        End Set
    End Property

    Private mdtFechaAnalitica As Date
    Public Property FechaAnalitica() As Date
        Get
            Return mdtFechaAnalitica
        End Get
        Set(ByVal Value As Date)
            mdtFechaAnalitica = Value
        End Set
    End Property

    Private mdblImporteAnalitica As Double
    Public Property ImporteAnalitica() As Double
        Get
            Return mdblImporteAnalitica
        End Get
        Set(ByVal Value As Double)
            mdblImporteAnalitica = Value
        End Set
    End Property

    Private mintIDEnlace As Integer
    Public Property IDEnlace() As Integer
        Get
            Return mintIDEnlace
        End Get
        Set(ByVal Value As Integer)
            mintIDEnlace = Value
        End Set
    End Property

    Private mblnMostrarRepartoCG As Boolean
    Public Property MostrarRepartoCG() As Boolean
        Get
            Return mblnMostrarRepartoCG
        End Get
        Set(ByVal Value As Boolean)
            mblnMostrarRepartoCG = Value
        End Set
    End Property

    Private mdtAnalitica As DataTable
    Public Property DTAnalitica() As DataTable
        Get
            Return mdtAnalitica
        End Get
        Set(ByVal Value As DataTable)
            mdtAnalitica = Value
        End Set
    End Property

    Private mstrTitle As String = "Desglose Analítico"
    Public WriteOnly Property Title() As String
        Set(ByVal Value As String)
            mstrTitle = Value
        End Set
    End Property

    Private mstrDH As String
    Public WriteOnly Property DH() As String
        Set(ByVal Value As String)
            mstrDH = Value
            Select Case mstrDH
                Case cnDebe
                    mstrTextoDH = " - DEBE "
                Case cnHaber
                    mstrTextoDH = " - HABER "
            End Select
        End Set
    End Property

#End Region

#Region " Variables y Constantes "

    Private Const cnDebe As String = "D"
    Private Const cnHaber As String = "H"

    Private mstrCampoImporte As String
    Private mstrCampoEnlace As String
    Private pstrMonedaIntA As String
    Private pstrMonedaIntB As String
    Private plngDecimalesA As Long
    Private plngDecimalesB As Long
    Private pstrAbvA As String
    Private pstrAbvB As String
    Private pstrDescMonedaIntA As String
    Private pstrDescMonedaIntB As String
    Private mblnMostarFecha As Boolean

    Private mstrTextoDH As String
    'Private mblnCambioPorcentaje As Boolean
    'Private mblnCambioImporteA As Boolean


    Private mblnCancelarUpdating As Boolean '//PROVISIONAL, para cancelar un UpdatingCell, de una B.Avan.
    Private mblnCerrandoDesdeBotones As Boolean

    Private MIntNiveles As Integer

    Private WithEvents sctIDAnalitica1 As AdvancedSearch
    Private WithEvents sctIDAnalitica2 As AdvancedSearch
    Private WithEvents sctIDAnalitica3 As AdvancedSearch
    Private WithEvents sctIDAnalitica4 As AdvancedSearch
    Private WithEvents sctIDAnalitica5 As AdvancedSearch
#End Region

#Region " Carga del formulario "

    Private Sub DiarioAnalitica_Closing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closing
        If Not mblnCerrandoDesdeBotones Then
            cmbCancelar_Click(Me, Nothing)
        End If
    End Sub

    Private Sub DiarioAnalitica_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadFormSettings()
            MostrarRestante()
            LoadColumns()
            LoadAdvSearchSettings()
        End If
    End Sub

    Private Sub LoadFormSettings()
        '//Mostrar los controles referentes al reparto.
        'If Me.MostrarRepartoCG Then

        '    Me.cmdRepartirCG.Visible = True
        '    Me.lblRepartoCG.Visible = True
        '    Me.cmbRepartoCG.Visible = True
        '    Me.lblcFwiRepartoCG.Visible = True

        '    '//Sólo se activarán si se permite la analítica por c.gestión.
        '    Dim objNegParametro As New Parametro
        '    Dim blnEnabled As Boolean = objNegParametro.CAnaliticGestion
        '    objNegParametro = Nothing

        '    Me.cmdRepartirCG.Enabled = False
        '    Me.lblRepartoCG.Enabled = blnEnabled
        '    Me.cmbRepartoCG.Enabled = blnEnabled
        '    Me.lblcFwiRepartoCG.Enabled = blnEnabled
        'Else
        '    Me.cmdRepartirCG.Visible = False
        '    Me.lblRepartoCG.Visible = False
        '    Me.cmbRepartoCG.Visible = False
        '    Me.lblcFwiRepartoCG.Visible = False
        'End If
        Me.Text = mstrTitle & mstrTextoDH
        Me.cmdRepartirCG.Visible = False
        Me.lblRepartoCG.Visible = False
        Me.cmbRepartoCG.Visible = False
        Me.lblcFwiRepartoCG.Visible = False

        '//Carga de los controles
        fwiIDCContable.Text = Me.CuentaContable
        If Me.mblnMostarFecha Then
            lblfwiFecha.Visible = True
            fwiFecha.Visible = True
            fwiFecha.Text = Me.FechaAnalitica
        Else
            lblfwiFecha.Visible = False
            fwiFecha.Visible = False
            fwiFecha.Text = String.Empty
        End If
        fwiImporte.Text = Me.ImporteAnalitica
        fwiDescripcion.Text = Me.DescripcionAnalitica

        '// CargarMoneda
        InformacionMonedas(pstrMonedaIntA, _
                           pstrAbvA, _
                           plngDecimalesA, _
                           pstrDescMonedaIntA, _
                           pstrMonedaIntB, _
                           pstrAbvB, _
                           plngDecimalesB, _
                           pstrDescMonedaIntB)

        '//Carga y configuración del grid
        CargarDatosGrid()

        '//Calculo de los totales
        CalcularAcumulados()
    End Sub
    Private Sub CargarDatosGrid()
        '''Dim dt As DataTable
        Dim objFilter As New Filter

        'Debug.Write(Me.DTAnalitica)
        Select Case Me.mintTipoAnalitica
            Case enumtaTipoAnalitica.AsientoNuevo
                '''If Me.CargadoAsientoNuevo Then
                '''    '//Se está creando la Analítica de un Asiento Nuevo
                '''    dt = XmlToDataTable(Me.Analitica)
                '''    If IsNothing(dt) Then
                '''        dt = InicializarDtAnalitica()
                '''    End If
                '''Else
                '''    '//Si no se le pasa una analítica desde donde se abre la pantalla, la buscamos en la BD.
                '''    dt = XmlToDataTable(Me.Analitica)
                '''    If IsNothing(dt) OrElse dt.Rows.Count = 0 Then
                '''        '//Se recupera la Analítica del Apunte indicado.
                '''        Dim objNegDCC As New DiarioContableCentro
                '''        objFilter.Clear()
                '''        objFilter.Add(New NumberFilterItem("IDApunte", Me.IDEnlace))
                '''        dt = objNegDCC.Filter("*", objFilter.Compose(New AdoFilterComposer))
                '''        objNegDCC = Nothing
                '''    End If
                '''End If
                '''jngCentroCoste.DataSource = dt
                If Length(Me.IDEnlace) > 0 Then
                    If IsNothing(objFilter) Then objFilter = New Filter
                    objFilter.Clear()
                    objFilter.Add(New NumberFilterItem("IDApunte", Me.IDEnlace))
                    If Not IsNothing(Me.DTAnalitica) Then
                        jngCentroCoste.DataSource = InvertirSigno(Me.DTAnalitica)
                        '//Hacemos este filtrado para ver sólo la analítica del apunte
                        Me.DTAnalitica.DefaultView.RowFilter = objFilter.Compose(New AdoFilterComposer)
                        Dim Where As String = objFilter.Compose(New AdoFilterComposer)
                        '//Hacemos un AcceptChanges, para partir de 0 en las modificaciones a realizar, sobre la analítica.
                        '//En este caso, podemos hacerlo por que en el Diario la analítica viene a nivel de línea de apunte.
                        If Not Me.DTAnalitica Is Nothing Then
                            For Each drapunte As DataRow In Me.DTAnalitica.Select(Where)
                                drapunte.AcceptChanges()
                            Next
                        End If
                    End If
                Else
                    If Not IsNothing(Me.DTAnalitica) Then
                        jngCentroCoste.DataSource = InvertirSigno(Me.DTAnalitica)
                    Else
                        jngCentroCoste.DataSource = InicializarDtAnalitica()
                    End If
                End If

            Case enumtaTipoAnalitica.Diario
                '//Filtramos el DataTable que trae la analítica del asiento completo, para quedarnos únicamente
                '//con la analítica del apunte correspondiente.
                If IsNothing(objFilter) Then objFilter = New Filter
                objFilter.Clear()
                objFilter.Add(New NumberFilterItem("IDApunte", Me.IDEnlace))
                If Not IsNothing(Me.DTAnalitica) Then
                    jngCentroCoste.DataSource = InvertirSigno(Me.DTAnalitica)
                    Me.DTAnalitica.DefaultView.RowFilter = objFilter.Compose(New AdoFilterComposer)
                    '//Hacemos un AcceptChanges, para partir de 0 en las modificaciones a realizar, sobre la analítica.
                    '//En este caso, podemos hacerlo por que en el Diario la analítica viene a nivel de línea de apunte.
                    Me.DTAnalitica.AcceptChanges()
                End If
            Case enumtaTipoAnalitica.AsientoPredeterminado
                '//Filtramos el DataTable que trae la analítica del asiento completo, para quedarnos únicamente
                '//con la analítica del apunte correspondiente.
                If IsNothing(objFilter) Then objFilter = New Filter
                objFilter.Clear()
                objFilter.Add(New NumberFilterItem("IDLinea", Me.IDEnlace))
                If Not IsNothing(Me.DTAnalitica) Then
                    jngCentroCoste.DataSource = InvertirSigno(CType(Me.DTAnalitica, DataTable), Me.IDEnlace)
                    Me.DTAnalitica.DefaultView.RowFilter = objFilter.Compose(New AdoFilterComposer)
                End If
        End Select

        ConfigurarGrid()
    End Sub
    Private Sub ConfigurarGrid()
        With jngCentroCoste
            Select Case Me.mintTipoAnalitica
                Case enumtaTipoAnalitica.Diario, enumtaTipoAnalitica.AsientoNuevo
                    .Columns("Importe").Visible = False
                    .Columns("Importe").EditType = EditType.NoEdit
                    .Columns("ImporteB").Visible = False
                    .Columns("ImporteB").EditType = EditType.NoEdit
                Case enumtaTipoAnalitica.AsientoPredeterminado
                    .Columns("ImporteA").Visible = False
                    .Columns("ImporteB").Visible = False
                    .Columns("ImporteA").EditType = EditType.NoEdit
                    .Columns("ImporteB").EditType = EditType.NoEdit
            End Select
        End With

        '//Centro Coste por defecto
        Dim objNegParametro As New Parametro
        jngCentroCoste.Columns("IDCentroCoste").DefaultValue = objNegParametro.CCostePredet
        '//Centro Gestión por defecto, no tiene por que ser la Sede Central
        jngCentroCoste.Columns("IDCentroGestion").DefaultValue = objNegParametro.CGestionPredet
        objNegParametro = Nothing

        jngCentroCoste.Columns(mstrCampoEnlace).DefaultValue = mintIDEnlace

    End Sub

    Private Sub InformacionMonedas(ByRef pstrMonedaIntA As String, _
                                   ByRef pstrAbvA As String, _
                                   ByRef plngDecimalesA As Long, _
                                   ByRef pstrDescMonedaIntA As String, _
                                   ByRef pstrMonedaIntB As String, _
                                   ByRef pstrAbvB As String, _
                                   ByRef plngDecimalesB As Long, _
                                   ByRef pstrDescMonedaIntB As String)
        Dim objNegMoneda As Moneda
        Dim dtMonedas As DataTable

        objNegMoneda = New Moneda
        dtMonedas = ExpertisApp.ExecuteTask(Of String, DataTable)(AddressOf Moneda.ObtenerMonedas, String.Empty)
        objNegMoneda = Nothing

        If Not IsNothing(dtMonedas) AndAlso dtMonedas.Rows.Count > 0 Then
            'Obtenemos la Información de la MonedaA
            pstrMonedaIntA = dtMonedas.Rows(0)("IDMonedaA")
            pstrAbvA = Nz(dtMonedas.Rows(0)("AbreviaturaA"), String.Empty)
            plngDecimalesA = Nz(dtMonedas.Rows(0)("NDecimalesImpA"), 0)
            pstrDescMonedaIntA = Nz(dtMonedas.Rows(0)("DescMonedaA"), String.Empty)

            'Obtenemos la Información de la MonedaB
            pstrMonedaIntB = dtMonedas.Rows(0)("IDMonedaB")
            pstrAbvB = Nz(dtMonedas.Rows(0)("AbreviaturaB"), String.Empty)
            plngDecimalesB = Nz(dtMonedas.Rows(0)("NDecimalesImpB"), 0)
            pstrDescMonedaIntB = Nz(dtMonedas.Rows(0)("DescMonedaB"), String.Empty)
        End If
        If Not IsNothing(dtMonedas) Then dtMonedas.Dispose()
    End Sub

    Private Function InicializarDtAnalitica() As DataTable
        Dim objNegDiarioContCentro As New DiarioContableCentro

        Dim dtAnalitica As DataTable = objNegDiarioContCentro.Filter(New NoRowsFilterItem)
        objNegDiarioContCentro = Nothing
        Return dtAnalitica
    End Function

    Private Sub LoadColumns()
        MIntNiveles = New Parametro().NivelesDeAnalitica
        If MIntNiveles <> CInt(EnumNivelesAnalitica.Nivel0) Then
            Dim ClsBE As New BE.DataEngine
            Dim DtAnalit1 As DataTable = ClsBE.GetPrimaryKey("AnaliticaNivel1")
            Dim DtAnalit2 As DataTable = ClsBE.GetPrimaryKey("AnaliticaNivel2")
            Dim DtAnalit3 As DataTable = ClsBE.GetPrimaryKey("AnaliticaNivel3")
            Dim DtAnalit4 As DataTable = ClsBE.GetPrimaryKey("AnaliticaNivel4")
            Dim DtAnalit5 As DataTable = ClsBE.GetPrimaryKey("AnaliticaNivel5")
            jngCentroCoste.Columns("IDCentroCoste").EditType = EditType.Custom

            SubGrid.Columns("IDAnalitica1").MaxLength = cnLENGTH_NIVELES_ANALITICA
            SubGrid.Columns("IDAnalitica1").InputMask = New String("A", SubGrid.Columns("IDAnalitica1").MaxLength)
            SubGrid.Columns("IDAnalitica2").MaxLength = cnLENGTH_NIVELES_ANALITICA
            SubGrid.Columns("IDAnalitica2").InputMask = New String("A", SubGrid.Columns("IDAnalitica2").MaxLength)
            SubGrid.Columns("IDAnalitica3").MaxLength = cnLENGTH_NIVELES_ANALITICA
            SubGrid.Columns("IDAnalitica3").InputMask = New String("A", SubGrid.Columns("IDAnalitica3").MaxLength)
            SubGrid.Columns("IDAnalitica4").MaxLength = cnLENGTH_NIVELES_ANALITICA
            SubGrid.Columns("IDAnalitica4").InputMask = New String("A", SubGrid.Columns("IDAnalitica4").MaxLength)
            SubGrid.Columns("IDAnalitica5").MaxLength = cnLENGTH_NIVELES_ANALITICA
            SubGrid.Columns("IDAnalitica5").InputMask = New String("A", SubGrid.Columns("IDAnalitica5").MaxLength)

            Select Case MIntNiveles
                Case 1
                    SubGrid.Columns("IDAnalitica2").Visible = False : SubGrid.Columns("IDAnalitica2").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica2").ButtonStyle = ButtonStyle.NoButton
                    SubGrid.Columns("IDAnalitica3").Visible = False : SubGrid.Columns("IDAnalitica3").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica3").ButtonStyle = ButtonStyle.NoButton
                    SubGrid.Columns("IDAnalitica4").Visible = False : SubGrid.Columns("IDAnalitica4").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica4").ButtonStyle = ButtonStyle.NoButton
                    SubGrid.Columns("IDAnalitica5").Visible = False : SubGrid.Columns("IDAnalitica5").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica5").ButtonStyle = ButtonStyle.NoButton
                Case 2
                    SubGrid.Columns("IDAnalitica3").Visible = False : SubGrid.Columns("IDAnalitica3").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica3").ButtonStyle = ButtonStyle.NoButton
                    SubGrid.Columns("IDAnalitica4").Visible = False : SubGrid.Columns("IDAnalitica4").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica4").ButtonStyle = ButtonStyle.NoButton
                    SubGrid.Columns("IDAnalitica5").Visible = False : SubGrid.Columns("IDAnalitica5").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica5").ButtonStyle = ButtonStyle.NoButton
                Case 3
                    SubGrid.Columns("IDAnalitica4").Visible = False : SubGrid.Columns("IDAnalitica4").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica4").ButtonStyle = ButtonStyle.NoButton
                    SubGrid.Columns("IDAnalitica5").Visible = False : SubGrid.Columns("IDAnalitica5").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica5").ButtonStyle = ButtonStyle.NoButton
                Case 4
                    SubGrid.Columns("IDAnalitica5").Visible = False : SubGrid.Columns("IDAnalitica5").EditType = EditType.NoEdit : SubGrid.Columns("IDAnalitica5").ButtonStyle = ButtonStyle.NoButton
            End Select

            jngCentroCoste.Columns("IDCentroCoste").Width = MIntNiveles * 80
        Else
            jngCentroCoste.Columns("IDCentroCoste").EditType = EditType.TextBox
            jngCentroCoste.AdvSearchColumns.Add("CentroCosteAnalitica", "IDCentroCoste", "IDCentroCoste")
            Dim AssCol As New Engine.UI.ASSelectedColumn("DescCentroCoste", "DescCentroCoste")
            jngCentroCoste.AdvSearchColumns(0).SelectedColumns.Add(AssCol)
            Dim AdvIcon As New Icon(Engine.UI.Resources.AdvSearchIcon, 16, 16)
            jngCentroCoste.Columns("IDCentroCoste").ButtonStyle = ButtonStyle.Image
            jngCentroCoste.Columns("IDCentroCoste").ButtonImage = AdvIcon.ToBitmap
            jngCentroCoste.Columns("IDCentroCoste").Width = 100
        End If
    End Sub

    Private Function CalcularIDCoste() As String
        Dim StrIDCoste As String = String.Empty
        Dim IntCuenta As Integer = 0
        For i As Integer = 1 To MIntNiveles
            If Length(SubGrid.GetValue("IDAnalitica" & i)) = 0 Then
                IntCuenta += 1
            End If
        Next
        If IntCuenta = MIntNiveles Then
            StrIDCoste = String.Empty
        Else
            For j As Integer = 1 To MIntNiveles
                If Length(SubGrid.GetValue("IDAnalitica" & j)) = 0 Then
                    SubGrid.SetValue("IDAnalitica" & j, New String("@", MIntNiveles))
                End If
                jngCentroCoste.SetValue("IDAnalitica" & j, SubGrid.GetValue("IDAnalitica" & j))
                StrIDCoste &= SubGrid.GetValue("IDAnalitica" & j)
            Next
        End If
        Return StrIDCoste
    End Function

    Private Sub LoadAdvSearchSettings()
        If MIntNiveles <> CInt(EnumNivelesAnalitica.Nivel0) Then
            Dim AdvIcon As New Icon(Engine.UI.Resources.AdvSearchIcon, 16, 16)
            sctIDAnalitica1 = New AdvancedSearch
            sctIDAnalitica1.EntityName = "AnaliticaNivel1"
            SubGrid.Columns("IDAnalitica1").ButtonImage = AdvIcon.ToBitmap

            Dim f As Filter
            sctIDAnalitica2 = New AdvancedSearch
            Dim dtR12 As DataTable = New AnaliticaR12().Filter(f, , "TOP 1 *")
            If Not dtR12 Is Nothing AndAlso dtR12.Rows.Count > 0 Then
                sctIDAnalitica2.EntityName = "AnaliticaR12"
                sctIDAnalitica2.ViewName = "vFrmAnaliticaR12"
            Else
                sctIDAnalitica2.EntityName = "AnaliticaNivel2"
            End If
            SubGrid.Columns("IDAnalitica2").ButtonImage = AdvIcon.ToBitmap

            sctIDAnalitica3 = New AdvancedSearch
            Dim dtR23 As DataTable = New AnaliticaR23().Filter(f, , "TOP 1 *")
            If Not dtR23 Is Nothing AndAlso dtR23.Rows.Count > 0 Then
                sctIDAnalitica3.EntityName = "AnaliticaR23"
                sctIDAnalitica3.ViewName = "vFrmAnaliticaR23"
            Else
                sctIDAnalitica3.EntityName = "AnaliticaNivel3"
            End If
            SubGrid.Columns("IDAnalitica3").ButtonImage = AdvIcon.ToBitmap

            sctIDAnalitica4 = New AdvancedSearch
            Dim dtR34 As DataTable = New AnaliticaR34().Filter(f, , "TOP 1 *")
            If Not dtR34 Is Nothing AndAlso dtR34.Rows.Count > 0 Then
                sctIDAnalitica4.EntityName = "AnaliticaR34"
                sctIDAnalitica4.ViewName = "vFrmAnaliticaR34"
            Else
                sctIDAnalitica4.EntityName = "AnaliticaNivel4"
            End If
            SubGrid.Columns("IDAnalitica4").ButtonImage = AdvIcon.ToBitmap

            sctIDAnalitica5 = New AdvancedSearch
            Dim dtR45 As DataTable = New AnaliticaR45().Filter(f, , "TOP 1 *")
            If Not dtR45 Is Nothing AndAlso dtR45.Rows.Count > 0 Then
                sctIDAnalitica5.EntityName = "AnaliticaR45"
                sctIDAnalitica5.ViewName = "vFrmAnaliticaR45"
            Else
                sctIDAnalitica5.EntityName = "AnaliticaNivel5"
            End If
            SubGrid.Columns("IDAnalitica5").ButtonImage = AdvIcon.ToBitmap
        End If
    End Sub

    Private Sub ComprobarIDCoste()
        Dim ClsCoste As New CentroCosteAnalitica
        Dim DtCoste As DataTable
        Dim DtCosteFinal As DataTable = ClsCoste.AddNew
        Dim DtGrid As DataTable = jngCentroCoste.DataSource

        Dim IntLenAnalit1 As Integer = cnLENGTH_NIVELES_ANALITICA
        Dim IntLenAnalit2 As Integer = cnLENGTH_NIVELES_ANALITICA
        Dim IntLenAnalit3 As Integer = cnLENGTH_NIVELES_ANALITICA
        Dim IntLenAnalit4 As Integer = cnLENGTH_NIVELES_ANALITICA
        Dim IntLenAnalit5 As Integer = cnLENGTH_NIVELES_ANALITICA

        For Each Dr As DataRow In DtGrid.Select
            DtCoste = ClsCoste.SelOnPrimaryKey(Dr("IDCentroCoste"))
            If DtCoste Is Nothing OrElse DtCoste.Rows.Count = 0 Then
                Dim DrNew As DataRow = DtCosteFinal.NewRow
                DrNew("IDCentroCoste") = Dr("IDCentroCoste")
                DrNew("DescCentroCoste") = "Desc. Centro: " & Dr("IDCentroCoste")
                If MIntNiveles >= 1 Then
                    DrNew("IDAnalitica1") = DrNew("IDCentroCoste").Substring(0, IntLenAnalit1)
                End If
                If MIntNiveles >= 2 Then
                    DrNew("IDAnalitica2") = DrNew("IDCentroCoste").Substring(IntLenAnalit1, IntLenAnalit2)
                End If
                If MIntNiveles >= 3 Then
                    DrNew("IDAnalitica3") = DrNew("IDCentroCoste").Substring((IntLenAnalit1 + IntLenAnalit2), IntLenAnalit3)
                End If
                If MIntNiveles >= 4 Then
                    DrNew("IDAnalitica4") = DrNew("IDCentroCoste").Substring((IntLenAnalit1 + IntLenAnalit2 + IntLenAnalit3), IntLenAnalit4)
                End If
                If MIntNiveles >= 5 Then
                    DrNew("IDAnalitica5") = DrNew("IDCentroCoste").Substring((IntLenAnalit1 + IntLenAnalit2 + IntLenAnalit3 + IntLenAnalit4), IntLenAnalit5)
                End If
                DtCosteFinal.Rows.Add(DrNew)
            End If
        Next
        If DtCosteFinal.Rows.Count > 0 Then ClsCoste.Update(DtCosteFinal)
    End Sub

    Private Sub CrearIDCoste(ByVal StrIDCoste As String)
        Dim ClsCoste As New CentroCosteAnalitica
        Dim DtCoste As DataTable = ClsCoste.SelOnPrimaryKey(StrIDCoste)
        If DtCoste Is Nothing OrElse DtCoste.Rows.Count = 0 Then
            Dim DtNew As DataTable = DtCoste.Clone
            Dim DrNew As DataRow = DtNew.NewRow
            DrNew("IDCentroCoste") = StrIDCoste
            DrNew("DescCentroCoste") = "Centro Coste Analitico"
            DrNew("IDAnalitica1") = SubGrid.GetValue("IDAnalitica1")
            DrNew("IDAnalitica2") = SubGrid.GetValue("IDAnalitica2")
            DrNew("IDAnalitica3") = SubGrid.GetValue("IDAnalitica3")
            DrNew("IDAnalitica4") = SubGrid.GetValue("IDAnalitica4")
            DrNew("IDAnalitica5") = SubGrid.GetValue("IDAnalitica5")
            DtNew.Rows.Add(DrNew)
            ClsCoste.Update(DtNew)
        End If
    End Sub

    Private Function ComprobarIDAnalitica(ByVal IntLevel As Integer) As Boolean
        Dim ClsObj As BE.BusinessHelper
        Select Case IntLevel
            Case 1
                ClsObj = New AnaliticaNivel1
            Case 2
                ClsObj = New AnaliticaNivel2
            Case 3
                ClsObj = New AnaliticaNivel3
            Case 4
                ClsObj = New AnaliticaNivel4
            Case 5
                ClsObj = New AnaliticaNivel5
        End Select

        Dim DtAnalit As DataTable = ClsObj.SelOnPrimaryKey(SubGrid.GetValue("IDAnalitica" & IntLevel))
        If DtAnalit Is Nothing OrElse DtAnalit.Rows.Count = 0 Then
            ExpertisApp.GenerateMessage("El Código introducido no existe.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SubGrid.SetValue("IDAnalitica" & IntLevel, String.Empty)
            Return False
        Else
            Dim FilBE As New Filter
            Dim DtBE As DataTable
            Dim ClsBE As New BE.DataEngine
            Select Case IntLevel
                Case 2
                    FilBE.Add("IDAnalitica1", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica1"))
                    FilBE.Add("IDAnalitica2", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica2"))
                    DtBE = ClsBE.Filter("vFrmAnaliticaR12", FilBE)
                    If DtBE Is Nothing OrElse DtBE.Rows.Count = 0 Then
                        DtBE = ClsBE.Filter("vFrmAnaliticaR12", Nothing)
                        If Not DtBE Is Nothing AndAlso DtBE.Rows.Count > 0 Then
                            ExpertisApp.GenerateMessage("El Código introducido no existe.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            SubGrid.SetValue("IDAnalitica" & IntLevel, String.Empty)
                            Return False
                        End If
                    End If
                Case 3
                    FilBE.Add("IDAnalitica2", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica2"))
                    FilBE.Add("IDAnalitica3", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica3"))
                    DtBE = ClsBE.Filter("vFrmAnaliticaR23", FilBE)
                    If DtBE Is Nothing OrElse DtBE.Rows.Count = 0 Then
                        DtBE = ClsBE.Filter("vFrmAnaliticaR23", Nothing)
                        If Not DtBE Is Nothing AndAlso DtBE.Rows.Count > 0 Then
                            ExpertisApp.GenerateMessage("El Código introducido no existe.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            SubGrid.SetValue("IDAnalitica" & IntLevel, String.Empty)
                            Return False
                        End If
                    End If
                Case 4
                    FilBE.Add("IDAnalitica3", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica3"))
                    FilBE.Add("IDAnalitica4", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica4"))
                    DtBE = ClsBE.Filter("vFrmAnaliticaR34", FilBE)
                    If DtBE Is Nothing OrElse DtBE.Rows.Count = 0 Then
                        DtBE = ClsBE.Filter("vFrmAnaliticaR34", Nothing)
                        If Not DtBE Is Nothing AndAlso DtBE.Rows.Count > 0 Then
                            ExpertisApp.GenerateMessage("El Código introducido no existe.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            SubGrid.SetValue("IDAnalitica" & IntLevel, String.Empty)
                            Return False
                        End If
                    End If
                Case 5
                    FilBE.Add("IDAnalitica4", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica4"))
                    FilBE.Add("IDAnalitica5", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica5"))
                    DtBE = ClsBE.Filter("vFrmAnaliticaR45", FilBE)
                    If DtBE Is Nothing OrElse DtBE.Rows.Count = 0 Then
                        DtBE = ClsBE.Filter("vFrmAnaliticaR45", Nothing)
                        If Not DtBE Is Nothing AndAlso DtBE.Rows.Count > 0 Then
                            ExpertisApp.GenerateMessage("El Código introducido no existe.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            SubGrid.SetValue("IDAnalitica" & IntLevel, String.Empty)
                            Return False
                        End If
                    End If
            End Select
        End If
        Return True
    End Function

    Private Sub LimpiarIDAnaliticas(ByVal IntLevelDesde As Integer)
        For i As Integer = IntLevelDesde To MIntNiveles
            SubGrid.SetValue("IDAnalitica" & i, String.Empty)
        Next
    End Sub

#End Region

#Region " Reparto C.Gestión "

    'Private Sub cmbRepartoCG_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbRepartoCG.Validating
    '    If Length(cmbRepartoCG.Value) > 0 Then
    '        Dim objFilter As New Filter
    '        objFilter.Clear()
    '        objFilter.Add(New StringFilterItem("IDRepartoCentroGestion", cmbRepartoCG.Value))
    '        Dim objNegRepartoCG As RepartoCGCabecera = New RepartoCGCabecera
    '        Dim dtRepartoCG As DataTable = objNegRepartoCG.Filter(objFilter)
    '        objNegRepartoCG = Nothing
    '        e.Cancel = (IsNothing(dtRepartoCG) OrElse dtRepartoCG.Rows.Count = 0)
    '        If Not IsNothing(dtRepartoCG) Then dtRepartoCG.Dispose()
    '    End If
    'End Sub

    Private Sub cmbRepartoCG_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbRepartoCG.TextChanged
        cmdRepartirCG.Enabled = (Length(cmbRepartoCG.Text) > 0)
    End Sub

    Private Sub cmdRepartirCG_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdRepartirCG.Click
        If Length(cmbRepartoCG.Value) > 0 Then
            Dim dtRepartoCG As DataTable = IniciarDtReparto()
            If ValidarRepartirCG(dtRepartoCG) Then
                Dim MonInfoA As MonedaInfo = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, cnMinDate)
                If Length(MonInfoA.ID) > 0 Then
                    dtRepartoCG = New RepartoCGCabecera().RepartirCGAnalitica(cmbRepartoCG.Value, dtRepartoCG, fwiImporte.Text, MonInfoA.ID, fwiFecha.Text)
                    If Not dtRepartoCG Is Nothing AndAlso dtRepartoCG.Rows.Count = 0 Then
                        '//Hay que copiar el recordset pero sin el campo importe
                        CopiarReparto(dtRepartoCG)
                    End If
                End If
                ExpertisApp.GenerateMessage("Repartir")
            Else
                ApplicationService.GenerateError("No se puede realizar el reparto debido a que hay líneas con centro de gestión asociado.")
            End If
        End If

    End Sub

    'Hace una copia del grid, con datos.
    Private Function IniciarDtReparto() As DataTable
        IniciarDtReparto = CType(jngCentroCoste.DataSource, DataTable).Copy
        IniciarDtReparto.Columns.Remove("IDApunte")
    End Function

    Private Function ValidarRepartirCG(ByVal dt As DataTable) As Boolean
        ValidarRepartirCG = False

        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            ValidarRepartirCG = New Parametro().CAnaliticGestion
        Else
            Dim f As New Filter
            f.Add(New IsNullFilterItem("IDCentroGestion"))
            Dim NumNulos As Integer = dt.Compute("COUNT(IDCentroGestion)", f.Compose(New AdoFilterComposer))
            '//Si el campo IDCentroGestion está nulo en todos los registros
            ValidarRepartirCG = (NumNulos = dt.Rows.Count)
        End If
    End Function

    Private Sub CopiarReparto(ByVal dt As DataTable)
        Dim dtCentroCoste As DataTable
        If Not dt Is Nothing Then
            If dt.Rows.Count <> 0 Then
                dtCentroCoste = IniciarGrid()
                For Each dr As DataRow In dt.Rows
                    Dim newRow As DataRow = dtCentroCoste.NewRow
                    For Each col As DataColumn In dt.Columns
                        If col.ColumnName <> "Importe" Then 'En el diario no se usa
                            newRow(col.ColumnName) = dr(col.ColumnName)
                        End If
                    Next
                    dtCentroCoste.Rows.Add(newRow)
                Next

                jngCentroCoste.DataSource = dtCentroCoste
            End If
        End If
    End Sub

    Private Function IniciarGrid() As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("IDCentroCoste", GetType(String))
        dt.Columns.Add("IDCentroGestion", GetType(String))
        dt.Columns.Add("Porcentaje", GetType(Double))
        dt.Columns.Add("ImporteA", GetType(Double))
        dt.Columns.Add("ImporteB", GetType(Double))
        Return dt
    End Function

#End Region

#Region " jngCentroCoste "

    Private Sub jngCentroCoste_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles jngCentroCoste.EditingCell
        e.Cancel = (jngCentroCoste.AllowAddNew = InheritableBoolean.False)
        If e.Cancel Then
            Select Case e.Column.Key
                Case "IDCentroCoste", "IDCentroGestion"
                    e.Column.ButtonStyle = ButtonStyle.NoButton
            End Select
        End If
    End Sub

    Private Sub jngCentroCoste_ColumnsFormatted() Handles jngCentroCoste.ColumnsFormatted

        With jngCentroCoste
            .Columns(mstrCampoImporte).Caption = "Importe" & mstrTextoDH & "(" & pstrAbvA & ")"
            If Me.mintTipoAnalitica = enumtaTipoAnalitica.Diario OrElse Me.mintTipoAnalitica = enumtaTipoAnalitica.AsientoNuevo Then
                .Columns("ImporteB").Caption = "Importe" & mstrTextoDH & "(" & pstrAbvB & ")"
            End If
        End With
    End Sub
    Private Sub jngCentroCoste_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngCentroCoste.AddingRecord
        Dim jRow As GridEXRow = jngCentroCoste.GetRow(Grid.newTopRowPosition)
        With jRow
            If .Cells("IDCentroCoste").Value & String.Empty <> String.Empty AndAlso _
               .Cells("IDCentroGestion").Value & String.Empty <> String.Empty Then
                '//Comprobar si se intenta introducir el mismo centro de coste y el mismo centro de gestión en 2 registros diferentes.
                Dim objFilter As New Filter
                objFilter.Clear()
                If Length(.Cells(mstrCampoEnlace).Value) > 0 Then
                    objFilter.Add(New StringFilterItem(mstrCampoEnlace, .Cells(mstrCampoEnlace).Value))
                End If
                objFilter.Add(New StringFilterItem("IDCentroCoste", .Cells("IDCentroCoste").Value))
                objFilter.Add(New StringFilterItem("IDCentroGestion", .Cells("IDCentroGestion").Value))
                Dim adrRows() As DataRow = jngCentroCoste.DataSource.Select(objFilter.Compose(New AdoFilterComposer))
                If Not IsNothing(adrRows) AndAlso adrRows.Length = 1 Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("El Centro de Coste y el Centro de Gestión ya existen en el desglose", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            If Not e.Cancel AndAlso .Cells("Porcentaje").Value = 0 Then
                e.Cancel = True
                Throw New Exception("El porcentaje no puede ser 0.")
            End If

        End With
    End Sub

    Private Sub jngCentroCoste_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles jngCentroCoste.UpdatingCell
        mblnCancelarUpdating = False
        Select Case e.Column.Key
            Case "IDCentroCoste", "IDCentroGestion"
                '//En las de Tipo de Analitica de Asiento Nuevo, no tenemos el IDApunte, con lo que no se puede comprobar en las BusinessRules
                '//los duplicados del Centro Coste, Centro Gestion.
                With jngCentroCoste
                    If Me.TipoAnalitica = enumtaTipoAnalitica.AsientoNuevo AndAlso .Row <> Grid.newTopRowPosition Then
                        If .Value("IDCentroCoste") & String.Empty <> String.Empty AndAlso _
                           .Value("IDCentroGestion") & String.Empty <> String.Empty Then
                            '//Comprobar si se intenta introducir el mismo centro de coste y el mismo centro de gestión en 2 registros diferentes.
                            Dim objFilter As New Filter
                            objFilter.Clear()
                            If Length(.Value(mstrCampoEnlace)) > 0 AndAlso .Value(mstrCampoEnlace) <> -1 Then
                                objFilter.Add(New StringFilterItem(mstrCampoEnlace, .Value(mstrCampoEnlace)))
                            End If
                            If e.Column.Key = "IDCentroCoste" Then
                                objFilter.Add(New StringFilterItem("IDCentroCoste", e.Value))
                            Else
                                objFilter.Add(New StringFilterItem("IDCentroCoste", .Value("IDCentroCoste")))
                            End If
                            If e.Column.Key = "IDCentroGestion" Then
                                objFilter.Add(New StringFilterItem("IDCentroGestion", e.Value))
                            Else
                                objFilter.Add(New StringFilterItem("IDCentroGestion", .Value("IDCentroGestion")))
                            End If

                            Dim adrRows() As DataRow = jngCentroCoste.DataSource.Select(objFilter.Compose(New AdoFilterComposer))
                            If Not IsNothing(adrRows) AndAlso adrRows.Length = 1 Then
                                ExpertisApp.GenerateMessage("El Centro de Coste y el Centro de Gestión ya existen en el desglose", MessageBoxButtons.OK, MessageBoxIcon.Error)

                                e.Cancel = True
                                mblnCancelarUpdating = True
                                .SetValue(e.Column.Key, e.InitialValue)
                            End If
                        End If
                    End If
                End With
        End Select

    End Sub

    Private Sub jngCentroCoste_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngCentroCoste.UpdatingRecord
        e.Cancel = mblnCancelarUpdating
    End Sub

    Private Sub jngCentroCoste_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngCentroCoste.RecordAdded
        MostrarRestante()
    End Sub
    Private Sub jngCentroCoste_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngCentroCoste.RecordUpdated
        MostrarRestante()
    End Sub
    Private Sub jngCentroCoste_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngCentroCoste.RecordsDeleted
        MostrarRestante()
    End Sub
    Private Sub CalcularAcumulados()
        With jngCentroCoste
            fwiPorcentajeAcu.Text = xRound(.GetTotal(Nz(.Columns("Porcentaje"), 0), Janus.Windows.GridEX.AggregateFunction.Sum), 3)
            fwiImporteAcumulado.Text = xRound(.GetTotal(Nz(.Columns(mstrCampoImporte), 0), Janus.Windows.GridEX.AggregateFunction.Sum), 3)
        End With
    End Sub
    Private Sub MostrarRestante()
        Const cnNDecimalesPorc As Integer = 2
        Dim dblCambioB As Double

        CalcularAcumulados()

        '//Cálculo de los restantes
        With jngCentroCoste
            If Me.mintTipoAnalitica = enumtaTipoAnalitica.Diario OrElse Me.mintTipoAnalitica = enumtaTipoAnalitica.AsientoNuevo Then
                dblCambioB = CambioB(fwiFecha.Text)
                .Columns("ImporteB").DefaultValue = xRound(.Columns(mstrCampoImporte).DefaultValue * dblCambioB, plngDecimalesB)
            End If
            .Columns(mstrCampoImporte).DefaultValue = xRound(Nz(fwiImporte.Text, 0) - Nz(fwiImporteAcumulado.Text, 0), plngDecimalesA)
            .Columns("Porcentaje").DefaultValue = xRound(100 - Nz(fwiPorcentajeAcu.Text, 0), cnNDecimalesPorc)
        End With
    End Sub


    Private Function CambioB(ByVal dteFecha As Date) As Double
        Static dteFechaAct As Date
        Static dblCambioB As Double
        Dim objNegMoneda As Moneda

        If dteFechaAct <> dteFecha Then
            dteFechaAct = dteFecha
            objNegMoneda = New Moneda
            Dim StDatos As New Moneda.DatosObtenerMoneda
            StDatos.IDMoneda = pstrMonedaIntA
            StDatos.Fecha = dteFechaAct
            dblCambioB = ExpertisApp.ExecuteTask(Of Moneda.DatosObtenerMoneda, MonedaInfo)(AddressOf Moneda.ObtenerMoneda, StDatos).CambioB
            objNegMoneda = Nothing
        End If
        CambioB = dblCambioB
    End Function

    Private Sub jngCentroCoste_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles jngCentroCoste.KeyDown
        If e.KeyCode = Keys.F9 AndAlso jngCentroCoste.Row = Grid.newTopRowPosition Then
            '//Para que pase la línea de insercción al grid.
            e.Handled = True
            System.Windows.Forms.SendKeys.Send("{Down}")
        End If
    End Sub

    Private Sub jngCentroCoste_InitCustomEdit(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.InitCustomEditEventArgs) Handles jngCentroCoste.InitCustomEdit
        Dim DtNew As New DataTable
        DtNew.Columns.Add("IDAnalitica1", GetType(String))
        DtNew.Columns.Add("IDAnalitica2", GetType(String))
        DtNew.Columns.Add("IDAnalitica3", GetType(String))
        DtNew.Columns.Add("IDAnalitica4", GetType(String))
        DtNew.Columns.Add("IDAnalitica5", GetType(String))

        SubGrid.DataSource = DtNew
        e.EditControl = SubGrid
        SubGrid.Row = Grid.newTopRowPosition

        Dim StrCoste As String = Nz(e.Value, String.Empty)
        If Length(StrCoste) > 0 Then
            'Dim IntLenAnalit1 As Integer = SubGrid.Columns("IDAnalitica1").MaxLength
            'Dim IntLenAnalit2 As Integer = SubGrid.Columns("IDAnalitica2").MaxLength
            'Dim IntLenAnalit3 As Integer = SubGrid.Columns("IDAnalitica3").MaxLength
            'Dim IntLenAnalit4 As Integer = SubGrid.Columns("IDAnalitica4").MaxLength
            'Dim IntLenAnalit5 As Integer = SubGrid.Columns("IDAnalitica5").MaxLength

            Dim IntLenTotal As Integer = 0
            If MIntNiveles >= 1 Then IntLenTotal += cnLENGTH_NIVELES_ANALITICA
            If MIntNiveles >= 2 Then IntLenTotal += cnLENGTH_NIVELES_ANALITICA
            If MIntNiveles >= 3 Then IntLenTotal += cnLENGTH_NIVELES_ANALITICA
            If MIntNiveles >= 4 Then IntLenTotal += cnLENGTH_NIVELES_ANALITICA
            If MIntNiveles = 5 Then IntLenTotal += cnLENGTH_NIVELES_ANALITICA

            If Len(StrCoste) = IntLenTotal Then
                If MIntNiveles >= 1 Then
                    SubGrid.SetValue("IDAnalitica1", StrCoste.Substring(0, cnLENGTH_NIVELES_ANALITICA))
                End If
                If MIntNiveles >= 2 Then
                    SubGrid.SetValue("IDAnalitica2", StrCoste.Substring(cnLENGTH_NIVELES_ANALITICA, cnLENGTH_NIVELES_ANALITICA))
                End If
                If MIntNiveles >= 3 Then
                    SubGrid.SetValue("IDAnalitica3", StrCoste.Substring((2 * cnLENGTH_NIVELES_ANALITICA), cnLENGTH_NIVELES_ANALITICA))
                End If
                If MIntNiveles >= 4 Then
                    SubGrid.SetValue("IDAnalitica4", StrCoste.Substring((3 * cnLENGTH_NIVELES_ANALITICA), cnLENGTH_NIVELES_ANALITICA))
                End If
                If MIntNiveles >= 5 Then
                    SubGrid.SetValue("IDAnalitica5", StrCoste.Substring((4 * cnLENGTH_NIVELES_ANALITICA), cnLENGTH_NIVELES_ANALITICA))
                End If
            End If
        End If
    End Sub

    Private Sub jngCentroCoste_EndCustomEdit(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EndCustomEditEventArgs) Handles jngCentroCoste.EndCustomEdit
        Dim StrCoste As String = CalcularIDCoste()
        If Len(StrCoste) > 0 Then
            e.Value = StrCoste
            CrearIDCoste(e.Value)
        End If
    End Sub

    Private Sub SubGrid_CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles SubGrid.CellValueChanged
        If (e.Column.Index + 1) >= 0 AndAlso (e.Column.Index + 1) <= 4 Then
            If Len(CStr(SubGrid.GetValue("IDAnalitica" & (e.Column.Index + 1)))) = cnLENGTH_NIVELES_ANALITICA Then
                If ComprobarIDAnalitica(e.Column.Index + 1) Then
                    LimpiarIDAnaliticas(e.Column.Index + 2)
                    If e.Column.Index + 1 = MIntNiveles Then
                        jngCentroCoste.Col = 1
                    Else : SubGrid.Col += 1
                    End If
                Else
                    LimpiarIDAnaliticas(e.Column.Index + 2)
                End If
            End If
        Else
            If Len(CStr(SubGrid.GetValue("IDAnalitica5"))) = cnLENGTH_NIVELES_ANALITICA Then
                ComprobarIDAnalitica(e.Column.Index + 1)
                jngCentroCoste.Col = 1
            End If
        End If
    End Sub

    Private Sub SubGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubGrid.Click
        Dim hit As GridArea
        With SubGrid
            hit = .HitTest()
            If hit = GridArea.CellButton Then
                Dim c As GridEXColumn = .ColumnFromPoint()
                If Not IsNothing(c) Then
                    Select Case c.Key
                        Case "IDAnalitica1"
                            sctIDAnalitica1.Open()
                        Case "IDAnalitica2"
                            sctIDAnalitica2.Open()
                        Case "IDAnalitica3"
                            sctIDAnalitica3.Open()
                        Case "IDAnalitica4"
                            sctIDAnalitica4.Open()
                        Case "IDAnalitica5"
                            sctIDAnalitica5.Open()
                    End Select
                End If
            End If
        End With
    End Sub

    Private Sub SubGrid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SubGrid.KeyUp
        If e.KeyCode = Keys.F4 Then
            Select Case SubGrid.Col
                Case SubGrid.Columns("IDAnalitica1").Index
                    sctIDAnalitica1.Open()
                Case SubGrid.Columns("IDAnalitica2").Index
                    sctIDAnalitica2.Open()
                Case SubGrid.Columns("IDAnalitica3").Index
                    sctIDAnalitica3.Open()
                Case SubGrid.Columns("IDAnalitica4").Index
                    sctIDAnalitica4.Open()
                Case SubGrid.Columns("IDAnalitica5").Index
                    sctIDAnalitica5.Open()
            End Select
        End If
    End Sub

    Private Sub SubGrid_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SubGrid.AddingRecord
        e.Cancel = True
    End Sub

#End Region

#Region "Eventos AdvSearch"

    Private Sub sctIDAnalitica1_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles sctIDAnalitica1.SelectionChanged
        SubGrid.SetValue("IDAnalitica1", e.Selected.Rows(0)("IDAnalitica1"))
    End Sub

    Private Sub sctIDAnalitica2_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles sctIDAnalitica2.SelectionChanged
        SubGrid.SetValue("IDAnalitica2", e.Selected.Rows(0)("IDAnalitica2"))
    End Sub

    Private Sub sctIDAnalitica3_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles sctIDAnalitica3.SelectionChanged
        SubGrid.SetValue("IDAnalitica3", e.Selected.Rows(0)("IDAnalitica3"))
    End Sub

    Private Sub sctIDAnalitica4_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles sctIDAnalitica4.SelectionChanged
        SubGrid.SetValue("IDAnalitica4", e.Selected.Rows(0)("IDAnalitica4"))
    End Sub

    Private Sub sctIDAnalitica5_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles sctIDAnalitica5.SelectionChanged
        SubGrid.SetValue("IDAnalitica5", e.Selected.Rows(0)("IDAnalitica5"))
    End Sub

    Private Sub sctIDAnalitica2_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles sctIDAnalitica2.SetPredefinedFilter
        If sctIDAnalitica2.EntityName = GetType(AnaliticaR12).Name Then
            If Length(SubGrid.GetValue("IDAnalitica1")) > 0 Then
                e.Filter.Add("IDAnalitica1", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica1"))
            End If
        End If
    End Sub

    Private Sub sctIDAnalitica3_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles sctIDAnalitica3.SetPredefinedFilter
        If sctIDAnalitica3.EntityName = GetType(AnaliticaR23).Name Then
            If Length(SubGrid.GetValue("IDAnalitica2")) > 0 Then
                e.Filter.Add("IDAnalitica2", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica2"))
            End If
        End If
    End Sub

    Private Sub sctIDAnalitica4_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles sctIDAnalitica4.SetPredefinedFilter
        If sctIDAnalitica4.EntityName = GetType(AnaliticaR34).Name Then
            If Length(SubGrid.GetValue("IDAnalitica3")) > 0 Then
                e.Filter.Add("IDAnalitica3", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica3"))
            End If
        End If
    End Sub

    Private Sub sctIDAnalitica5_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles sctIDAnalitica5.SetPredefinedFilter
        If sctIDAnalitica5.EntityName = GetType(AnaliticaR45).Name Then
            If Length(SubGrid.GetValue("IDAnalitica4")) > 0 Then
                e.Filter.Add("IDAnalitica4", FilterOperator.Equal, SubGrid.GetValue("IDAnalitica4"))
            End If
        End If
    End Sub

#End Region

#Region " ACEPTAR/CANCELAR "

    Private Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Select Case Me.TipoAnalitica
            Case enumtaTipoAnalitica.AsientoPredeterminado, enumtaTipoAnalitica.Diario
                If Not IsNothing(Me.DTAnalitica) Then
                    '//Se cancela a nivel de DataRow del NeededData, con las filas OriginalRows, para que recupere tb las borradas,
                    '//y con las Added para que elimine las que no estaban anteriormente.
                    Dim objFilter As New Filter
                    objFilter.Add(New NumberFilterItem(Me.mstrCampoEnlace, Me.IDEnlace))

                    For Each drRow As DataRow In Me.DTAnalitica.Select(objFilter.Compose(New AdoFilterComposer), Nothing, DataViewRowState.OriginalRows + DataViewRowState.Added)
                        drRow.RejectChanges()
                    Next

                    If Me.TipoAnalitica = enumtaTipoAnalitica.Diario Then
                        Me.DTAnalitica = InvertirSigno(CType(jngCentroCoste.DataSource, DataTable))
                        If mstrDH = cnHaber AndAlso Not IsNothing(Me.DTAnalitica) Then
                            '//Para que al cancelar no se activen los botones de guardar en la pantalla de la que proviene.
                            For Each drRowSigno As DataRow In Me.DTAnalitica.Select
                                drRowSigno.AcceptChanges()
                            Next
                        End If
                    End If
                End If
            Case enumtaTipoAnalitica.AsientoNuevo
                '''Nuevo
                If Length(Me.mstrCampoEnlace) > 0 Then
                    Dim objFilter As New Filter
                    objFilter.Add(New NumberFilterItem(Me.mstrCampoEnlace, Me.IDEnlace))
                    For Each drRow As DataRow In CType(jngCentroCoste.DataSource, DataTable).Select(objFilter.Compose(New AdoFilterComposer), Nothing, DataViewRowState.OriginalRows + DataViewRowState.Added)
                        'drRow.AcceptChanges()
                        'drRow.SetAdded()
                        drRow.RejectChanges()
                    Next
                    Me.DTAnalitica = InvertirSigno(CType(jngCentroCoste.DataSource, DataTable))
                Else
                    Me.DTAnalitica = InvertirSigno(CType(jngCentroCoste.DataSource, DataTable))
                    If mstrDH = cnHaber AndAlso Not IsNothing(Me.DTAnalitica) Then
                        '//Para que al cancelar no se activen los botones de guardar en la pantalla de la que proviene.
                        For Each drRowSigno As DataRow In Me.DTAnalitica.Select
                            drRowSigno.AcceptChanges()
                        Next
                    End If
                End If
        End Select

        mblnCerrandoDesdeBotones = True
        Me.Close()

    End Sub

    Private Function InvertirSigno(ByVal dtAnalitica As DataTable, Optional ByVal IDEnlace As Integer = -1) As DataTable
        If Not IsNothing(dtAnalitica) AndAlso mstrDH = cnHaber Then
            For Each drRow As DataRow In dtAnalitica.Select
                If Me.TipoAnalitica = enumtaTipoAnalitica.AsientoPredeterminado Then
                    If drRow("IdLinea") = IDEnlace Then drRow("Importe") = drRow("Importe") * -1
                Else
                    drRow("ImporteA") = drRow("ImporteA") * -1
                    drRow("ImporteB") = drRow("ImporteB") * -1
                End If
            Next
        End If
        Return dtAnalitica
    End Function

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Dim dblImporteAcumulado As Double
        Dim blnGrabar As Boolean
        Dim blnCerrar As Boolean

        blnCerrar = True

        If Not IsNothing(jngCentroCoste.DataSource) Then
            If jngCentroCoste.RowCount = 0 Then
                If Me.CCAnalitica Then
                    blnGrabar = False
                    blnCerrar = False
                    ExpertisApp.GenerateMessage("La Cuenta es analítica y debe contener algún desglose.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    blnGrabar = True
                End If
            Else
                blnGrabar = True
                'Dim objFilter As New Filter
                'objFilter.Add(New NumberFilterItem(Me.mstrCampoEnlace, Me.IDEnlace))
                'objFilter.Add(New NumberFilterItem("Porcentaje", FilterOperator.NotEqual, 0))
                'Dim PorcAsignado As Double = xRound(CType(jngCentroCoste.DataSource, DataTable).Compute("SUM(Porcentaje)", objFilter.Compose(New AdoFilterComposer)), 3)
                'If PorcAsignado <> 100 Then
                '    blnGrabar = False
                '    blnCerrar = False
                '    ExpertisApp.GenerateMessage("Revise el Porcentaje asignado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'End If
            End If

            If blnGrabar Then
                ComprobarIDCoste()
                Select Case Me.TipoAnalitica
                    Case enumtaTipoAnalitica.AsientoNuevo
                        If IsNothing(jngCentroCoste.DataSource) Then
                            blnCerrar = False
                            Me.DTAnalitica = Nothing
                        Else
                            Me.DTAnalitica = InvertirSigno(CType(jngCentroCoste.DataSource, DataTable))
                        End If
                        If Length(Me.mstrCampoEnlace) > 0 Then
                            Dim objFilter As New Filter
                            objFilter.Add(New NumberFilterItem(Me.mstrCampoEnlace, Me.IDEnlace))
                            For Each drRow As DataRow In CType(jngCentroCoste.DataSource, DataTable).Select(objFilter.Compose(New AdoFilterComposer), Nothing, DataViewRowState.OriginalRows + DataViewRowState.Added)
                                drRow.AcceptChanges()
                                If drRow.RowState <> DataRowState.Detached Then drRow.SetAdded()
                            Next
                        End If
                    Case enumtaTipoAnalitica.Diario, enumtaTipoAnalitica.AsientoPredeterminado
                        Me.DTAnalitica = InvertirSigno(CType(jngCentroCoste.DataSource, DataTable))
                End Select

                dblImporteAcumulado = 0
                If Length(fwiImporteAcumulado.Text) > 0 AndAlso IsNumeric(fwiImporteAcumulado.Text) Then dblImporteAcumulado = fwiImporteAcumulado.Text

                Dim dblImporte As Double
                If Length(fwiImporte.Text) > 0 And IsNumeric(fwiImporte.Text) Then dblImporte = CDbl(fwiImporte.Text)

                If (dblImporteAcumulado <> 0 OrElse (dblImporteAcumulado = 0 AndAlso Me.CCAnalitica)) _
                    AndAlso xRound(dblImporteAcumulado, plngDecimalesA) <> xRound(dblImporte, plngDecimalesA) Then
                    blnCerrar = False
                    ExpertisApp.GenerateMessage("La suma  de los Importes de las líneas, no coincide con el Importe del Apunte.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If

            blnGrabar = False
        End If

        If blnCerrar Then
            Me.DialogResult = DialogResult.OK
            mblnCerrandoDesdeBotones = True
            Me.Close()
        End If
    End Sub

#End Region

#Region " BUSINESSCALLING "

    Private Sub DiarioAnalitica_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
        Select Case e.EntityName
            Case jngCentroCoste.EntityName
                e.Data.Context.Clear()
                e.Data.Context.Add("TipoAnalitica", Me.TipoAnalitica)
                e.Data.Context.Add("IDMoneda", pstrMonedaIntA)
                If Not IsNothing(Me.CurrentData) AndAlso Me.CurrentData.Rows.Count > 0 Then
                    e.Data.Context.Add("Porcentaje", Me.CurrentData.Rows(0)("Porcentaje"))
                    '//Dependiendo del tipo de Analítica el campo que contiene el importe será "Importe" o "ImporteA"
                    e.Data.Context.Add(mstrCampoImporte, Me.CurrentData.Rows(0)(mstrCampoImporte))
                Else
                    e.Data.Context.Add("Porcentaje", CDbl(100))
                    e.Data.Context.Add(mstrCampoImporte, fwiImporte.Value)
                End If
                Dim dblImporte As Double
                If Length(fwiImporte.Text) > 0 And IsNumeric(fwiImporte.Text) Then dblImporte = CDbl(fwiImporte.Text)
                e.Data.Context.Add("ImporteLinea", dblImporte)
        End Select
    End Sub

#End Region

End Class