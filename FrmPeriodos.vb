Public Class FrmPeriodos
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
    Friend WithEvents FraFecha As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FraContador As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents nbxPeriodoMax As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblnbxPeriodoMax As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents nbxPeriodoMin As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblnbxPeriodoMin As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FraDiasExcluidos As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents btnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents btnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents txtIDPreventivo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lbltxtIDPreventivo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDescPreventivo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents cbxFechaUltima As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblcbxFechaUltima As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaInicial As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblcbxFechaInicial As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents nbxPeriodo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblnbxPeriodo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FraPeriodos As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents chkDomingo As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkSabado As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkViernes As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkJueves As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkMiercoles As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkMartes As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkLunes As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkPlanificar As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkObligatorio As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblcboCriterio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cboCriterio As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lbladvContadorPrev As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcadvContadorPrev As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents advContadorPrev As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblnbxIntervaloContador As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents nbxIntervaloContador As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents cboTipoPeriodo As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblcboTipoPeriodo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblActivo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtIDActivo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtDescActivo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtOrdenUltIntervencion As Solmicro.Expertis.Engine.UI.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim cboCriterio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPeriodos))
        Dim cboTipoPeriodo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.FraFecha = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblcboCriterio = New Solmicro.Expertis.Engine.UI.Label
        Me.cboCriterio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.FraContador = New Solmicro.Expertis.Engine.UI.Frame
        Me.FraPeriodos = New Solmicro.Expertis.Engine.UI.Frame
        Me.nbxPeriodoMin = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblnbxPeriodoMax = New Solmicro.Expertis.Engine.UI.Label
        Me.nbxPeriodoMax = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblnbxPeriodoMin = New Solmicro.Expertis.Engine.UI.Label
        Me.lblnbxIntervaloContador = New Solmicro.Expertis.Engine.UI.Label
        Me.nbxIntervaloContador = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lbladvContadorPrev = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcadvContadorPrev = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advContadorPrev = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FraDiasExcluidos = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkDomingo = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkSabado = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkViernes = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkJueves = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkMiercoles = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkMartes = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkLunes = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.nbxPeriodo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblnbxPeriodo = New Solmicro.Expertis.Engine.UI.Label
        Me.chkPlanificar = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkObligatorio = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.cboTipoPeriodo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblcboTipoPeriodo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaUltima = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblcbxFechaUltima = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaInicial = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblcbxFechaInicial = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIDPreventivo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lbltxtIDPreventivo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescPreventivo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.btnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.btnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.lblActivo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIDActivo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDescActivo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.txtOrdenUltIntervencion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FraFecha.SuspendLayout()
        CType(Me.cboCriterio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraContador.SuspendLayout()
        Me.FraPeriodos.SuspendLayout()
        Me.FraDiasExcluidos.SuspendLayout()
        CType(Me.cboTipoPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FraFecha
        '
        Me.FraFecha.Controls.Add(Me.lblcboCriterio)
        Me.FraFecha.Controls.Add(Me.cboCriterio)
        Me.FraFecha.Location = New System.Drawing.Point(4, 219)
        Me.FraFecha.Name = "FraFecha"
        Me.FraFecha.Size = New System.Drawing.Size(572, 45)
        Me.FraFecha.TabIndex = 16
        Me.FraFecha.TabStop = False
        Me.FraFecha.Text = "Por Fecha ..."
        '
        'lblcboCriterio
        '
        Me.lblcboCriterio.Location = New System.Drawing.Point(112, 18)
        Me.lblcboCriterio.Name = "lblcboCriterio"
        Me.lblcboCriterio.Size = New System.Drawing.Size(124, 13)
        Me.lblcboCriterio.TabIndex = 0
        Me.lblcboCriterio.Text = "Criterio Planificación"
        '
        'cboCriterio
        '
        Me.cboCriterio.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cboCriterio_DesignTimeLayout.LayoutString = resources.GetString("cboCriterio_DesignTimeLayout.LayoutString")
        Me.cboCriterio.DesignTimeLayout = cboCriterio_DesignTimeLayout
        Me.cboCriterio.DisabledBackColor = System.Drawing.Color.White
        Me.cboCriterio.DisplayMember = "Text"
        Me.cboCriterio.Location = New System.Drawing.Point(240, 16)
        Me.cboCriterio.Name = "cboCriterio"
        Me.cboCriterio.SelectedIndex = -1
        Me.cboCriterio.SelectedItem = Nothing
        Me.cboCriterio.Size = New System.Drawing.Size(264, 21)
        Me.cboCriterio.TabIndex = 17
        Me.cboCriterio.ValueMember = "Value"
        '
        'FraContador
        '
        Me.FraContador.Controls.Add(Me.FraPeriodos)
        Me.FraContador.Controls.Add(Me.lblnbxIntervaloContador)
        Me.FraContador.Controls.Add(Me.nbxIntervaloContador)
        Me.FraContador.Controls.Add(Me.lbladvContadorPrev)
        Me.FraContador.Controls.Add(Me.lblcadvContadorPrev)
        Me.FraContador.Controls.Add(Me.advContadorPrev)
        Me.FraContador.Location = New System.Drawing.Point(4, 265)
        Me.FraContador.Name = "FraContador"
        Me.FraContador.Size = New System.Drawing.Size(572, 106)
        Me.FraContador.TabIndex = 18
        Me.FraContador.TabStop = False
        Me.FraContador.Text = "Por Contador ..."
        '
        'FraPeriodos
        '
        Me.FraPeriodos.Controls.Add(Me.nbxPeriodoMin)
        Me.FraPeriodos.Controls.Add(Me.lblnbxPeriodoMax)
        Me.FraPeriodos.Controls.Add(Me.nbxPeriodoMax)
        Me.FraPeriodos.Controls.Add(Me.lblnbxPeriodoMin)
        Me.FraPeriodos.Location = New System.Drawing.Point(268, 49)
        Me.FraPeriodos.Name = "FraPeriodos"
        Me.FraPeriodos.Size = New System.Drawing.Size(295, 50)
        Me.FraPeriodos.TabIndex = 21
        Me.FraPeriodos.TabStop = False
        Me.FraPeriodos.Text = "Períodos (Días)"
        '
        'nbxPeriodoMin
        '
        Me.nbxPeriodoMin.DisabledBackColor = System.Drawing.Color.White
        Me.nbxPeriodoMin.Location = New System.Drawing.Point(207, 19)
        Me.nbxPeriodoMin.Name = "nbxPeriodoMin"
        Me.nbxPeriodoMin.Size = New System.Drawing.Size(82, 21)
        Me.nbxPeriodoMin.TabIndex = 23
        '
        'lblnbxPeriodoMax
        '
        Me.lblnbxPeriodoMax.Location = New System.Drawing.Point(16, 22)
        Me.lblnbxPeriodoMax.Name = "lblnbxPeriodoMax"
        Me.lblnbxPeriodoMax.Size = New System.Drawing.Size(51, 13)
        Me.lblnbxPeriodoMax.TabIndex = 0
        Me.lblnbxPeriodoMax.Text = "Máximo"
        '
        'nbxPeriodoMax
        '
        Me.nbxPeriodoMax.DisabledBackColor = System.Drawing.Color.White
        Me.nbxPeriodoMax.Location = New System.Drawing.Point(69, 18)
        Me.nbxPeriodoMax.Name = "nbxPeriodoMax"
        Me.nbxPeriodoMax.Size = New System.Drawing.Size(82, 21)
        Me.nbxPeriodoMax.TabIndex = 22
        '
        'lblnbxPeriodoMin
        '
        Me.lblnbxPeriodoMin.Location = New System.Drawing.Point(157, 22)
        Me.lblnbxPeriodoMin.Name = "lblnbxPeriodoMin"
        Me.lblnbxPeriodoMin.Size = New System.Drawing.Size(47, 13)
        Me.lblnbxPeriodoMin.TabIndex = 22
        Me.lblnbxPeriodoMin.Tag = "IdRec=7571;"
        Me.lblnbxPeriodoMin.Text = "Mínimo"
        '
        'lblnbxIntervaloContador
        '
        Me.lblnbxIntervaloContador.Location = New System.Drawing.Point(8, 56)
        Me.lblnbxIntervaloContador.Name = "lblnbxIntervaloContador"
        Me.lblnbxIntervaloContador.Size = New System.Drawing.Size(59, 13)
        Me.lblnbxIntervaloContador.TabIndex = 21
        Me.lblnbxIntervaloContador.Tag = "IdRec=7571;"
        Me.lblnbxIntervaloContador.Text = "Intervalo"
        '
        'nbxIntervaloContador
        '
        Me.nbxIntervaloContador.DisabledBackColor = System.Drawing.Color.White
        Me.nbxIntervaloContador.Location = New System.Drawing.Point(104, 54)
        Me.nbxIntervaloContador.Name = "nbxIntervaloContador"
        Me.nbxIntervaloContador.Size = New System.Drawing.Size(132, 21)
        Me.nbxIntervaloContador.TabIndex = 20
        '
        'lbladvContadorPrev
        '
        Me.lbladvContadorPrev.Location = New System.Drawing.Point(8, 24)
        Me.lbladvContadorPrev.Name = "lbladvContadorPrev"
        Me.lbladvContadorPrev.Size = New System.Drawing.Size(94, 13)
        Me.lbladvContadorPrev.TabIndex = 22
        Me.lbladvContadorPrev.Tag = "IdRec=7571;"
        Me.lbladvContadorPrev.Text = "Contador Prev."
        '
        'lblcadvContadorPrev
        '
        Me.lblcadvContadorPrev.Location = New System.Drawing.Point(240, 19)
        Me.lblcadvContadorPrev.Name = "lblcadvContadorPrev"
        Me.lblcadvContadorPrev.Size = New System.Drawing.Size(326, 21)
        Me.lblcadvContadorPrev.TabIndex = 23
        '
        'advContadorPrev
        '
        Me.advContadorPrev.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescContadorPrev", lblcadvContadorPrev)})
        Me.advContadorPrev.DisabledBackColor = System.Drawing.Color.White
        Me.advContadorPrev.DisplayField = "IDContadorPrev"
        Me.advContadorPrev.EntityName = "PreventivoContador"
        Me.advContadorPrev.Location = New System.Drawing.Point(104, 19)
        Me.advContadorPrev.Name = "advContadorPrev"
        Me.advContadorPrev.Size = New System.Drawing.Size(132, 23)
        Me.advContadorPrev.TabIndex = 19
        Me.advContadorPrev.ViewName = "tbPreventivoContador"
        '
        'FraDiasExcluidos
        '
        Me.FraDiasExcluidos.Controls.Add(Me.chkDomingo)
        Me.FraDiasExcluidos.Controls.Add(Me.chkSabado)
        Me.FraDiasExcluidos.Controls.Add(Me.chkViernes)
        Me.FraDiasExcluidos.Controls.Add(Me.chkJueves)
        Me.FraDiasExcluidos.Controls.Add(Me.chkMiercoles)
        Me.FraDiasExcluidos.Controls.Add(Me.chkMartes)
        Me.FraDiasExcluidos.Controls.Add(Me.chkLunes)
        Me.FraDiasExcluidos.Location = New System.Drawing.Point(4, 132)
        Me.FraDiasExcluidos.Name = "FraDiasExcluidos"
        Me.FraDiasExcluidos.Size = New System.Drawing.Size(572, 56)
        Me.FraDiasExcluidos.TabIndex = 6
        Me.FraDiasExcluidos.TabStop = False
        Me.FraDiasExcluidos.Text = "Día(s) de la semana excluído(s)"
        '
        'chkDomingo
        '
        Me.chkDomingo.Location = New System.Drawing.Point(480, 24)
        Me.chkDomingo.Name = "chkDomingo"
        Me.chkDomingo.Size = New System.Drawing.Size(73, 19)
        Me.chkDomingo.TabIndex = 13
        Me.chkDomingo.Text = "Domingo"
        '
        'chkSabado
        '
        Me.chkSabado.Location = New System.Drawing.Point(400, 24)
        Me.chkSabado.Name = "chkSabado"
        Me.chkSabado.Size = New System.Drawing.Size(69, 19)
        Me.chkSabado.TabIndex = 12
        Me.chkSabado.Text = "Sabado"
        '
        'chkViernes
        '
        Me.chkViernes.Location = New System.Drawing.Point(320, 24)
        Me.chkViernes.Name = "chkViernes"
        Me.chkViernes.Size = New System.Drawing.Size(80, 19)
        Me.chkViernes.TabIndex = 11
        Me.chkViernes.Text = "Viernes"
        '
        'chkJueves
        '
        Me.chkJueves.Location = New System.Drawing.Point(248, 24)
        Me.chkJueves.Name = "chkJueves"
        Me.chkJueves.Size = New System.Drawing.Size(72, 19)
        Me.chkJueves.TabIndex = 10
        Me.chkJueves.Text = "Jueves"
        '
        'chkMiercoles
        '
        Me.chkMiercoles.Location = New System.Drawing.Point(160, 24)
        Me.chkMiercoles.Name = "chkMiercoles"
        Me.chkMiercoles.Size = New System.Drawing.Size(81, 19)
        Me.chkMiercoles.TabIndex = 9
        Me.chkMiercoles.Text = "Miércoles"
        '
        'chkMartes
        '
        Me.chkMartes.Location = New System.Drawing.Point(88, 24)
        Me.chkMartes.Name = "chkMartes"
        Me.chkMartes.Size = New System.Drawing.Size(60, 19)
        Me.chkMartes.TabIndex = 8
        Me.chkMartes.Text = "Martes"
        '
        'chkLunes
        '
        Me.chkLunes.Location = New System.Drawing.Point(24, 24)
        Me.chkLunes.Name = "chkLunes"
        Me.chkLunes.Size = New System.Drawing.Size(64, 19)
        Me.chkLunes.TabIndex = 7
        Me.chkLunes.Text = "Lunes"
        '
        'nbxPeriodo
        '
        Me.nbxPeriodo.DisabledBackColor = System.Drawing.Color.White
        Me.nbxPeriodo.Location = New System.Drawing.Point(400, 54)
        Me.nbxPeriodo.Name = "nbxPeriodo"
        Me.nbxPeriodo.Size = New System.Drawing.Size(96, 21)
        Me.nbxPeriodo.TabIndex = 4
        '
        'lblnbxPeriodo
        '
        Me.lblnbxPeriodo.Location = New System.Drawing.Point(320, 56)
        Me.lblnbxPeriodo.Name = "lblnbxPeriodo"
        Me.lblnbxPeriodo.Size = New System.Drawing.Size(50, 13)
        Me.lblnbxPeriodo.TabIndex = 24
        Me.lblnbxPeriodo.Tag = ""
        Me.lblnbxPeriodo.Text = "Período"
        '
        'chkPlanificar
        '
        Me.chkPlanificar.Location = New System.Drawing.Point(209, 197)
        Me.chkPlanificar.Name = "chkPlanificar"
        Me.chkPlanificar.Size = New System.Drawing.Size(167, 19)
        Me.chkPlanificar.TabIndex = 15
        Me.chkPlanificar.Text = "Planificar"
        '
        'chkObligatorio
        '
        Me.chkObligatorio.Location = New System.Drawing.Point(11, 197)
        Me.chkObligatorio.Name = "chkObligatorio"
        Me.chkObligatorio.Size = New System.Drawing.Size(167, 19)
        Me.chkObligatorio.TabIndex = 14
        Me.chkObligatorio.Text = "Obligatorio generar OT"
        '
        'cboTipoPeriodo
        '
        Me.cboTipoPeriodo.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cboTipoPeriodo_DesignTimeLayout.LayoutString = resources.GetString("cboTipoPeriodo_DesignTimeLayout.LayoutString")
        Me.cboTipoPeriodo.DesignTimeLayout = cboTipoPeriodo_DesignTimeLayout
        Me.cboTipoPeriodo.DisabledBackColor = System.Drawing.Color.White
        Me.cboTipoPeriodo.DisplayMember = "Text"
        Me.cboTipoPeriodo.Location = New System.Drawing.Point(400, 78)
        Me.cboTipoPeriodo.Name = "cboTipoPeriodo"
        Me.cboTipoPeriodo.SelectedIndex = -1
        Me.cboTipoPeriodo.SelectedItem = Nothing
        Me.cboTipoPeriodo.Size = New System.Drawing.Size(96, 21)
        Me.cboTipoPeriodo.TabIndex = 5
        Me.cboTipoPeriodo.ValueMember = "Value"
        '
        'lblcboTipoPeriodo
        '
        Me.lblcboTipoPeriodo.Location = New System.Drawing.Point(320, 80)
        Me.lblcboTipoPeriodo.Name = "lblcboTipoPeriodo"
        Me.lblcboTipoPeriodo.Size = New System.Drawing.Size(78, 13)
        Me.lblcboTipoPeriodo.TabIndex = 25
        Me.lblcboTipoPeriodo.Text = "Tipo Período"
        '
        'cbxFechaUltima
        '
        Me.cbxFechaUltima.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaUltima.Location = New System.Drawing.Point(168, 78)
        Me.cbxFechaUltima.Name = "cbxFechaUltima"
        Me.cbxFechaUltima.Size = New System.Drawing.Size(96, 21)
        Me.cbxFechaUltima.TabIndex = 3
        '
        'lblcbxFechaUltima
        '
        Me.lblcbxFechaUltima.Location = New System.Drawing.Point(7, 80)
        Me.lblcbxFechaUltima.Name = "lblcbxFechaUltima"
        Me.lblcbxFechaUltima.Size = New System.Drawing.Size(156, 13)
        Me.lblcbxFechaUltima.TabIndex = 26
        Me.lblcbxFechaUltima.Tag = "IdRec=4457;"
        Me.lblcbxFechaUltima.Text = "Fecha Ultima Intervención"
        '
        'cbxFechaInicial
        '
        Me.cbxFechaInicial.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaInicial.Location = New System.Drawing.Point(168, 54)
        Me.cbxFechaInicial.Name = "cbxFechaInicial"
        Me.cbxFechaInicial.Size = New System.Drawing.Size(96, 21)
        Me.cbxFechaInicial.TabIndex = 2
        '
        'lblcbxFechaInicial
        '
        Me.lblcbxFechaInicial.Location = New System.Drawing.Point(7, 56)
        Me.lblcbxFechaInicial.Name = "lblcbxFechaInicial"
        Me.lblcbxFechaInicial.Size = New System.Drawing.Size(78, 13)
        Me.lblcbxFechaInicial.TabIndex = 27
        Me.lblcbxFechaInicial.Text = "Fecha Inicial"
        '
        'txtIDPreventivo
        '
        Me.txtIDPreventivo.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDPreventivo.Enabled = False
        Me.txtIDPreventivo.Location = New System.Drawing.Point(80, 5)
        Me.txtIDPreventivo.Name = "txtIDPreventivo"
        Me.txtIDPreventivo.Size = New System.Drawing.Size(80, 21)
        Me.txtIDPreventivo.TabIndex = 0
        '
        'lbltxtIDPreventivo
        '
        Me.lbltxtIDPreventivo.Location = New System.Drawing.Point(7, 7)
        Me.lbltxtIDPreventivo.Name = "lbltxtIDPreventivo"
        Me.lbltxtIDPreventivo.Size = New System.Drawing.Size(68, 13)
        Me.lbltxtIDPreventivo.TabIndex = 28
        Me.lbltxtIDPreventivo.Text = "Preventivo"
        '
        'txtDescPreventivo
        '
        Me.txtDescPreventivo.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescPreventivo.Enabled = False
        Me.txtDescPreventivo.Location = New System.Drawing.Point(168, 5)
        Me.txtDescPreventivo.Name = "txtDescPreventivo"
        Me.txtDescPreventivo.Size = New System.Drawing.Size(408, 21)
        Me.txtDescPreventivo.TabIndex = 1
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(291, 378)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(96, 30)
        Me.btnCancelar.TabIndex = 30
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Location = New System.Drawing.Point(179, 378)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(96, 30)
        Me.btnAceptar.TabIndex = 29
        Me.btnAceptar.Text = "Aceptar"
        '
        'lblActivo
        '
        Me.lblActivo.Location = New System.Drawing.Point(7, 30)
        Me.lblActivo.Name = "lblActivo"
        Me.lblActivo.Size = New System.Drawing.Size(42, 13)
        Me.lblActivo.TabIndex = 31
        Me.lblActivo.Text = "Activo"
        '
        'txtIDActivo
        '
        Me.txtIDActivo.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDActivo.Enabled = False
        Me.txtIDActivo.Location = New System.Drawing.Point(80, 28)
        Me.txtIDActivo.Name = "txtIDActivo"
        Me.txtIDActivo.Size = New System.Drawing.Size(80, 21)
        Me.txtIDActivo.TabIndex = 32
        '
        'txtDescActivo
        '
        Me.txtDescActivo.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescActivo.Enabled = False
        Me.txtDescActivo.Location = New System.Drawing.Point(168, 28)
        Me.txtDescActivo.Name = "txtDescActivo"
        Me.txtDescActivo.Size = New System.Drawing.Size(408, 21)
        Me.txtDescActivo.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "O.T. Ult. Intervención"
        '
        'txtOrdenUltIntervencion
        '
        Me.txtOrdenUltIntervencion.DisabledBackColor = System.Drawing.Color.White
        Me.txtOrdenUltIntervencion.Enabled = False
        Me.txtOrdenUltIntervencion.Location = New System.Drawing.Point(168, 104)
        Me.txtOrdenUltIntervencion.Name = "txtOrdenUltIntervencion"
        Me.txtOrdenUltIntervencion.Size = New System.Drawing.Size(96, 21)
        Me.txtOrdenUltIntervencion.TabIndex = 35
        '
        'FrmPeriodos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(584, 414)
        Me.Controls.Add(Me.txtOrdenUltIntervencion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescActivo)
        Me.Controls.Add(Me.txtIDActivo)
        Me.Controls.Add(Me.lblActivo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtDescPreventivo)
        Me.Controls.Add(Me.FraFecha)
        Me.Controls.Add(Me.FraContador)
        Me.Controls.Add(Me.FraDiasExcluidos)
        Me.Controls.Add(Me.lblnbxPeriodo)
        Me.Controls.Add(Me.lblcboTipoPeriodo)
        Me.Controls.Add(Me.lblcbxFechaUltima)
        Me.Controls.Add(Me.lblcbxFechaInicial)
        Me.Controls.Add(Me.lbltxtIDPreventivo)
        Me.Controls.Add(Me.nbxPeriodo)
        Me.Controls.Add(Me.chkPlanificar)
        Me.Controls.Add(Me.chkObligatorio)
        Me.Controls.Add(Me.cboTipoPeriodo)
        Me.Controls.Add(Me.cbxFechaUltima)
        Me.Controls.Add(Me.cbxFechaInicial)
        Me.Controls.Add(Me.txtIDPreventivo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmPeriodos"
        Me.Text = "Periodos"
        Me.FraFecha.ResumeLayout(False)
        Me.FraFecha.PerformLayout()
        CType(Me.cboCriterio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraContador.ResumeLayout(False)
        Me.FraContador.PerformLayout()
        Me.FraPeriodos.ResumeLayout(False)
        Me.FraPeriodos.PerformLayout()
        Me.FraDiasExcluidos.ResumeLayout(False)
        CType(Me.cboTipoPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private mContadorFecha As enumpaContadorFecha     '//Variable para saber si es de Tipo Contador o de Tipo Fecha
    Private mblnContador As Boolean

#Region " Propiedades "

    Property NROTUltimaIntervencion() As String
        Get
            Return txtOrdenUltIntervencion.Text
        End Get
        Set(ByVal Value As String)
            txtOrdenUltIntervencion.Text = Value
        End Set
    End Property
    Property IDPreventivo() As String
        Get
            Return txtIDPreventivo.Text
        End Get
        Set(ByVal Value As String)
            txtIDPreventivo.Text = Value
        End Set
    End Property
    Property DescPreventivo() As String
        Get
            Return txtDescPreventivo.Text
        End Get
        Set(ByVal Value As String)
            txtDescPreventivo.Text = Value
        End Set
    End Property
    Property IDActivo() As String
        Get
            Return txtIDActivo.Text
        End Get
        Set(ByVal Value As String)
            txtIDActivo.Text = Value
        End Set
    End Property
    Property DescActivo() As String
        Get
            Return txtDescActivo.Text
        End Get
        Set(ByVal Value As String)
            txtDescActivo.Text = Value
        End Set
    End Property
    Property FechaIni() As Date
        Get
            If Length(cbxFechaInicial.Value) = 0 Then
                Return System.DateTime.Today
            Else
                Return cbxFechaInicial.Value
            End If
        End Get
        Set(ByVal Value As Date)
            cbxFechaInicial.Value = Value
        End Set
    End Property
    Property FechaFin() As Date
        Get
            If Length(cbxFechaUltima.Value) = 0 Then
                Return cbxFechaInicial.Value
            Else
                Return cbxFechaUltima.Value
            End If
        End Get
        Set(ByVal Value As Date)
            cbxFechaUltima.Value = Value
        End Set
    End Property
    Property Periodo() As Long
        Get
            Return nbxPeriodo.Value
        End Get
        Set(ByVal Value As Long)
            nbxPeriodo.Value = Value
        End Set
    End Property
    Property TipoPeriodo() As Integer
        Get
            If Length(cboTipoPeriodo.Value) > 0 Then
                Return cboTipoPeriodo.Value
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Integer)
            If Value <> -1 Then
                cboTipoPeriodo.Value = Value
            End If
        End Set
    End Property
    Property DiasSemana() As Boolean()
        Get
            Return New Boolean(6) {chkLunes.Checked, chkMartes.Checked, _
                chkMiercoles.Checked, chkJueves.Checked, chkViernes.Checked, _
                chkSabado.Checked, chkDomingo.Checked}
        End Get
        Set(ByVal Value As Boolean())
            chkLunes.Checked = Nz(Value(0), False)
            chkMartes.Checked = Nz(Value(1), False)
            chkMiercoles.Checked = Nz(Value(2), False)
            chkJueves.Checked = Nz(Value(3), False)
            chkViernes.Checked = Nz(Value(4), False)
            chkSabado.Checked = Nz(Value(5), True)
            chkDomingo.Checked = Nz(Value(6), True)
        End Set
    End Property
    Property Obligatorio() As Boolean
        Get
            Return chkObligatorio.Checked
        End Get
        Set(ByVal Value As Boolean)
            chkObligatorio.Checked = Value
        End Set
    End Property
    Property Planificar() As Boolean
        Get
            Return chkPlanificar.Checked
        End Get
        Set(ByVal Value As Boolean)
            chkPlanificar.Checked = Value
        End Set
    End Property
    Property Criterio() As Integer
        Get
            If Length(cboCriterio.Value) > 0 Then
                Return cboCriterio.Value
            Else
                Return -1
            End If
        End Get
        Set(ByVal Value As Integer)
            If Value <> -1 Then
                cboCriterio.Value = Value
            End If
        End Set
    End Property
    Property ContadorPrev() As String
        Get
            Return advContadorPrev.Text
        End Get
        Set(ByVal Value As String)
            advContadorPrev.Text = Value
        End Set
    End Property
    Property Intervalo() As Double
        Get
            Return nbxIntervaloContador.Value
        End Get
        Set(ByVal Value As Double)
            nbxIntervaloContador.Value = Value
        End Set
    End Property
    Property PeriodoMax() As Double
        Get
            Return nbxPeriodoMax.Value
        End Get
        Set(ByVal Value As Double)
            nbxPeriodoMax.Value = Value
        End Set
    End Property
    Property PeriodoMin() As Double
        Get
            Return nbxPeriodoMin.Value
        End Get
        Set(ByVal Value As Double)
            nbxPeriodoMin.Value = Value
        End Set
    End Property
    Property Contador() As enumpaContadorFecha
        Get
            Return mContadorFecha
        End Get
        Set(ByVal Value As enumpaContadorFecha)
            mContadorFecha = Value
            mblnContador = (Value = enumpaContadorFecha.Contador)
        End Set
    End Property
#End Region

#Region " Carga del formulario "

    Private Sub FrmPeriodos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadEnums()
            SettingsPositions()
            VisibleControls()
            LoadDefaultValues()
        End If
    End Sub

    Private Sub LoadEnums()
        cboTipoPeriodo.DataSource = EnumData.EnumView("enumcpPeriodo")
        If Not mblnContador Then cboCriterio.DataSource = EnumData.EnumView("emumpaCriterioPlanificaion")
    End Sub

    Private Sub SettingsPositions()
        chkObligatorio.Top = FraFecha.Top
        chkPlanificar.Top = FraFecha.Top
        FraFecha.Top = FraContador.Top
    End Sub

    Private Sub VisibleControls()
        FraContador.Visible = mblnContador
        FraFecha.Visible = Not mblnContador

        lblnbxPeriodo.Visible = Not mblnContador
        nbxPeriodo.Visible = Not mblnContador
        lblcboTipoPeriodo.Visible = Not mblnContador
        cboTipoPeriodo.Visible = Not mblnContador
    End Sub

    Private Sub LoadDefaultValues()
        If Length(cbxFechaInicial.Value) = 0 Then
            cbxFechaInicial.Value = System.DateTime.Today
        End If
        If Length(cbxFechaUltima.Value) = 0 Then
            cbxFechaUltima.Value = cbxFechaInicial.Value
        End If
        If Length(cboTipoPeriodo.Value) = 0 Then
            cboTipoPeriodo.Value = CInt(enumcpPeriodo.cpDia)
        End If
        If Length(cboCriterio.Value) = 0 Then
            cboCriterio.Value = CInt(emumpaCriterioPlanificaion.DesdeUltimaIntervencion)
        End If
    End Sub

#End Region

    Private Sub cbxFechaInicial_FechaUltima_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbxFechaInicial.Validating, cbxFechaUltima.Validating
        If Length(cbxFechaUltima.Value) > 0 AndAlso Length(cbxFechaInicial.Value) > 0 Then
            If cbxFechaUltima.Value < cbxFechaInicial.Value Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("La Fecha Inicial ha de ser menor que la Fecha última intervención.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            If Length(cbxFechaInicial.Value) > 0 AndAlso Length(cbxFechaUltima.Value) = 0 Then
                cbxFechaUltima.Value = cbxFechaInicial.Value
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If mContadorFecha = enumpaContadorFecha.Fecha AndAlso (Length(cbxFechaInicial.Value) = 0 OrElse Length(nbxPeriodo.Value) = 0 OrElse nbxPeriodo.Value = 0 OrElse Length(cboTipoPeriodo.Value) = 0) Then
            ExpertisApp.GenerateMessage("La Fecha Inicial, el Periodo y el Tipo Periodo son obligatorios.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If cbxFechaUltima.Value < cbxFechaInicial.Value Then
            ExpertisApp.GenerateMessage("La Fecha Inicial ha de ser menor que la Fecha última intervención.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Length(cboCriterio.Value) = 0 Then
            ExpertisApp.GenerateMessage("Introduzca el Criterio Planificación.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cbxFechaUltima_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxFechaUltima.ValueChanged
        Me.txtOrdenUltIntervencion.Text = String.Empty
    End Sub

End Class
