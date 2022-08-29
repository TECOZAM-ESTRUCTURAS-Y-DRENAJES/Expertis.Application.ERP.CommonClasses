Public Class FrmCopiaObra
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
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents CmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Panel2 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents FraConfiguracion As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents pnlGeneral As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents chkVarios As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkGastos As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkCentros As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkMod As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkMateriales As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkConceptosAll As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents pnlchkMediciones As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents chkMediciones As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents pnlchkCaracteristicas As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents chkTareas As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkRecursos As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkCaracteristicas As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents pnlClaseObra As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlContador As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents AdvContador As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblContador As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblClaseObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxIDClase As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblNObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtNObra As Solmicro.Expertis.Engine.UI.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim cbxIDClase_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCopiaObra))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.pnlClaseObra = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblClaseObra = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxIDClase = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Panel2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.FraConfiguracion = New Solmicro.Expertis.Engine.UI.Frame
        Me.pnlGeneral = New Solmicro.Expertis.Engine.UI.Panel
        Me.chkVarios = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkGastos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkCentros = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkMod = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkMateriales = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkConceptosAll = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.pnlchkMediciones = New Solmicro.Expertis.Engine.UI.Panel
        Me.chkMediciones = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.pnlchkCaracteristicas = New Solmicro.Expertis.Engine.UI.Panel
        Me.chkTareas = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkRecursos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkCaracteristicas = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.pnlContador = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtNObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblNObra = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvContador = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblContador = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1.suspendlayout()
        Me.pnlClaseObra.suspendlayout()
        CType(Me.cbxIDClase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.suspendlayout()
        Me.FraConfiguracion.SuspendLayout()
        Me.pnlGeneral.suspendlayout()
        Me.pnlchkMediciones.suspendlayout()
        Me.pnlchkCaracteristicas.suspendlayout()
        Me.pnlContador.suspendlayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CmbAceptar)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 307)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 47)
        Me.Panel1.TabIndex = 16
        '
        'CmbAceptar
        '
        Me.CmbAceptar.Location = New System.Drawing.Point(51, 9)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmbAceptar.TabIndex = 14
        Me.CmbAceptar.Text = "Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(151, 9)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 0
        Me.cmbCancelar.Text = "Cancelar"
        '
        'pnlClaseObra
        '
        Me.pnlClaseObra.Controls.Add(Me.lblClaseObra)
        Me.pnlClaseObra.Controls.Add(Me.cbxIDClase)
        Me.pnlClaseObra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlClaseObra.Location = New System.Drawing.Point(0, 283)
        Me.pnlClaseObra.Name = "pnlClaseObra"
        Me.pnlClaseObra.Size = New System.Drawing.Size(296, 24)
        Me.pnlClaseObra.TabIndex = 17
        '
        'lblClaseObra
        '
        Me.lblClaseObra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClaseObra.Location = New System.Drawing.Point(65, 5)
        Me.lblClaseObra.Name = "lblClaseObra"
        Me.lblClaseObra.Size = New System.Drawing.Size(43, 13)
        Me.lblClaseObra.TabIndex = 178
        Me.lblClaseObra.Tag = ""
        Me.lblClaseObra.Text = "Clase "
        '
        'cbxIDClase
        '
        Me.cbxIDClase.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        cbxIDClase_DesignTimeLayout.LayoutString = resources.GetString("cbxIDClase_DesignTimeLayout.LayoutString")
        Me.cbxIDClase.DesignTimeLayout = cbxIDClase_DesignTimeLayout
        Me.cbxIDClase.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDClase.DisplayMember = "Value"
        Me.cbxIDClase.Location = New System.Drawing.Point(148, 2)
        Me.cbxIDClase.Name = "cbxIDClase"
        Me.cbxIDClase.PrimaryDataFields = "Estado"
        Me.cbxIDClase.SecondaryDataFields = "Value"
        Me.cbxIDClase.SelectedIndex = -1
        Me.cbxIDClase.SelectedItem = Nothing
        Me.cbxIDClase.Size = New System.Drawing.Size(140, 21)
        Me.cbxIDClase.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.FraConfiguracion)
        Me.Panel2.Controls.Add(Me.pnlContador)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(296, 283)
        Me.Panel2.TabIndex = 18
        '
        'FraConfiguracion
        '
        Me.FraConfiguracion.Controls.Add(Me.pnlGeneral)
        Me.FraConfiguracion.Controls.Add(Me.pnlchkMediciones)
        Me.FraConfiguracion.Controls.Add(Me.pnlchkCaracteristicas)
        Me.FraConfiguracion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FraConfiguracion.Location = New System.Drawing.Point(0, 0)
        Me.FraConfiguracion.Name = "FraConfiguracion"
        Me.FraConfiguracion.Size = New System.Drawing.Size(296, 233)
        Me.FraConfiguracion.TabIndex = 176
        Me.FraConfiguracion.TabStop = False
        Me.FraConfiguracion.Tag = "IdRec=12604;"
        Me.FraConfiguracion.Text = "Configuración de la copia"
        '
        'pnlGeneral
        '
        Me.pnlGeneral.Controls.Add(Me.chkVarios)
        Me.pnlGeneral.Controls.Add(Me.chkGastos)
        Me.pnlGeneral.Controls.Add(Me.chkCentros)
        Me.pnlGeneral.Controls.Add(Me.chkMod)
        Me.pnlGeneral.Controls.Add(Me.chkMateriales)
        Me.pnlGeneral.Controls.Add(Me.chkConceptosAll)
        Me.pnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGeneral.Location = New System.Drawing.Point(3, 17)
        Me.pnlGeneral.Name = "pnlGeneral"
        Me.pnlGeneral.Size = New System.Drawing.Size(290, 123)
        Me.pnlGeneral.TabIndex = 31
        '
        'chkVarios
        '
        Me.chkVarios.Location = New System.Drawing.Point(40, 102)
        Me.chkVarios.Name = "chkVarios"
        Me.chkVarios.Size = New System.Drawing.Size(220, 21)
        Me.chkVarios.TabIndex = 6
        Me.chkVarios.Text = "Copiar el Concepto de Varios"
        '
        'chkGastos
        '
        Me.chkGastos.Location = New System.Drawing.Point(40, 82)
        Me.chkGastos.Name = "chkGastos"
        Me.chkGastos.Size = New System.Drawing.Size(220, 21)
        Me.chkGastos.TabIndex = 5
        Me.chkGastos.Text = "Copiar el Concepto de Gastos"
        '
        'chkCentros
        '
        Me.chkCentros.Location = New System.Drawing.Point(40, 63)
        Me.chkCentros.Name = "chkCentros"
        Me.chkCentros.Size = New System.Drawing.Size(220, 21)
        Me.chkCentros.TabIndex = 4
        Me.chkCentros.Text = "Copiar el Concepto de Centros"
        '
        'chkMod
        '
        Me.chkMod.Location = New System.Drawing.Point(40, 44)
        Me.chkMod.Name = "chkMod"
        Me.chkMod.Size = New System.Drawing.Size(220, 21)
        Me.chkMod.TabIndex = 3
        Me.chkMod.Text = "Copiar el Concepto de M.O.D."
        '
        'chkMateriales
        '
        Me.chkMateriales.Location = New System.Drawing.Point(40, 25)
        Me.chkMateriales.Name = "chkMateriales"
        Me.chkMateriales.Size = New System.Drawing.Size(220, 21)
        Me.chkMateriales.TabIndex = 2
        Me.chkMateriales.Text = "Copiar el Concepto de Materiales"
        '
        'chkConceptosAll
        '
        Me.chkConceptosAll.Location = New System.Drawing.Point(18, 4)
        Me.chkConceptosAll.Name = "chkConceptosAll"
        Me.chkConceptosAll.Size = New System.Drawing.Size(222, 21)
        Me.chkConceptosAll.TabIndex = 1
        Me.chkConceptosAll.Text = "Copiar todos los Conceptos"
        '
        'pnlchkMediciones
        '
        Me.pnlchkMediciones.Controls.Add(Me.chkMediciones)
        Me.pnlchkMediciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlchkMediciones.Location = New System.Drawing.Point(3, 140)
        Me.pnlchkMediciones.Name = "pnlchkMediciones"
        Me.pnlchkMediciones.Size = New System.Drawing.Size(290, 23)
        Me.pnlchkMediciones.TabIndex = 30
        '
        'chkMediciones
        '
        Me.chkMediciones.Location = New System.Drawing.Point(40, 1)
        Me.chkMediciones.Name = "chkMediciones"
        Me.chkMediciones.Size = New System.Drawing.Size(221, 21)
        Me.chkMediciones.TabIndex = 7
        Me.chkMediciones.Text = "Copiar el Concepto de Mediciones"
        '
        'pnlchkCaracteristicas
        '
        Me.pnlchkCaracteristicas.Controls.Add(Me.chkTareas)
        Me.pnlchkCaracteristicas.Controls.Add(Me.chkRecursos)
        Me.pnlchkCaracteristicas.Controls.Add(Me.chkCaracteristicas)
        Me.pnlchkCaracteristicas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlchkCaracteristicas.Location = New System.Drawing.Point(3, 163)
        Me.pnlchkCaracteristicas.Name = "pnlchkCaracteristicas"
        Me.pnlchkCaracteristicas.Size = New System.Drawing.Size(290, 67)
        Me.pnlchkCaracteristicas.TabIndex = 29
        '
        'chkTareas
        '
        Me.chkTareas.Location = New System.Drawing.Point(18, 23)
        Me.chkTareas.Name = "chkTareas"
        Me.chkTareas.Size = New System.Drawing.Size(208, 19)
        Me.chkTareas.TabIndex = 9
        Me.chkTareas.Text = "Copiar Tareas"
        '
        'chkRecursos
        '
        Me.chkRecursos.Location = New System.Drawing.Point(18, 44)
        Me.chkRecursos.Name = "chkRecursos"
        Me.chkRecursos.Size = New System.Drawing.Size(220, 21)
        Me.chkRecursos.TabIndex = 10
        Me.chkRecursos.Text = "Copiar Recursos"
        '
        'chkCaracteristicas
        '
        Me.chkCaracteristicas.Location = New System.Drawing.Point(18, 1)
        Me.chkCaracteristicas.Name = "chkCaracteristicas"
        Me.chkCaracteristicas.Size = New System.Drawing.Size(220, 21)
        Me.chkCaracteristicas.TabIndex = 8
        Me.chkCaracteristicas.Text = "Copiar Características"
        '
        'pnlContador
        '
        Me.pnlContador.Controls.Add(Me.txtNObra)
        Me.pnlContador.Controls.Add(Me.lblNObra)
        Me.pnlContador.Controls.Add(Me.AdvContador)
        Me.pnlContador.Controls.Add(Me.lblContador)
        Me.pnlContador.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlContador.Location = New System.Drawing.Point(0, 233)
        Me.pnlContador.Name = "pnlContador"
        Me.pnlContador.Size = New System.Drawing.Size(296, 50)
        Me.pnlContador.TabIndex = 175
        '
        'txtNObra
        '
        Me.txtNObra.DisabledBackColor = System.Drawing.Color.White
        Me.txtNObra.Location = New System.Drawing.Point(148, 26)
        Me.txtNObra.Name = "txtNObra"
        Me.txtNObra.Size = New System.Drawing.Size(140, 21)
        Me.txtNObra.TabIndex = 12
        Me.txtNObra.TabStop = False
        '
        'lblNObra
        '
        Me.lblNObra.Location = New System.Drawing.Point(65, 29)
        Me.lblNObra.Name = "lblNObra"
        Me.lblNObra.Size = New System.Drawing.Size(79, 13)
        Me.lblNObra.TabIndex = 178
        Me.lblNObra.Tag = ""
        Me.lblNObra.Text = "Nº. Proyecto"
        '
        'AdvContador
        '
        Me.AdvContador.DisabledBackColor = System.Drawing.Color.White
        Me.AdvContador.EntityName = "EntidadContador"
        Me.AdvContador.Location = New System.Drawing.Point(148, 1)
        Me.AdvContador.Name = "AdvContador"
        Me.AdvContador.PrimaryDataFields = "IDContador"
        Me.AdvContador.SecondaryDataFields = "IDContador"
        Me.AdvContador.Size = New System.Drawing.Size(96, 23)
        Me.AdvContador.TabIndex = 11
        Me.AdvContador.ViewName = "tbEntidadContador"
        '
        'lblContador
        '
        Me.lblContador.Location = New System.Drawing.Point(65, 5)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(60, 13)
        Me.lblContador.TabIndex = 177
        Me.lblContador.Tag = ""
        Me.lblContador.Text = "Contador"
        '
        'FrmCopiaObra
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(296, 354)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlClaseObra)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmCopiaObra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Copia Proyecto"
        Me.Panel1.ResumeLayout(False)
        Me.pnlClaseObra.ResumeLayout(False)
        Me.pnlClaseObra.PerformLayout()
        CType(Me.cbxIDClase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.FraConfiguracion.ResumeLayout(False)
        Me.pnlGeneral.ResumeLayout(False)
        Me.pnlchkMediciones.ResumeLayout(False)
        Me.pnlchkCaracteristicas.ResumeLayout(False)
        Me.pnlContador.ResumeLayout(False)
        Me.pnlContador.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mintClaseObra As enumClaseObra
    Private mstrCaption As String
    Private blnMarcoAll, blnContadorVisible, blnVerMediciones, blnVerClaseObra As Boolean
    Public ConfiguracionCopia As dataConfigCopiaObra

    Public WriteOnly Property ClaseObra() As enumClaseObra
        Set(ByVal Value As enumClaseObra)
            mintClaseObra = Value
        End Set
    End Property

    Public WriteOnly Property VerClaseObra() As Boolean
        Set(ByVal Value As Boolean)
            blnVerClaseObra = Value
            If Not Value Then Me.Height = Me.Height - pnlClaseObra.Height
        End Set
    End Property

    Public WriteOnly Property VerMediciones() As Boolean
        Set(ByVal Value As Boolean)
            blnVerMediciones = Value
        End Set
    End Property

    Public WriteOnly Property VerContador() As Boolean
        Set(ByVal Value As Boolean)
            blnContadorVisible = Value
            If Not Value Then Me.Height = Me.Height - pnlContador.Height
        End Set
    End Property

    Public WriteOnly Property Caption() As String
        Set(ByVal Value As String)
            mstrCaption = Value
        End Set
    End Property

#Region " Load "

    Private Sub FrmCopiaObra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Length(mstrCaption) > 0 Then Me.Text = mstrCaption

        LoadEnums()
        LoadConfigForm()
    End Sub

    Private Sub LoadEnums()
        cbxIDClase.DataSource = New EnumData("enumClaseObra")
    End Sub

    Private Sub LoadConfigForm()
        pnlClaseObra.Enabled = (mintClaseObra = enumClaseObra.FacturacionControl)
        cbxIDClase.Value = CInt(mintClaseObra)
        pnlContador.Visible = blnContadorVisible
        pnlClaseObra.Visible = blnContadorVisible
        pnlchkMediciones.Visible = blnVerMediciones
        chkConceptosAll.Checked = True
        chkRecursos.Checked = True
        chkCaracteristicas.Checked = True
        chkTareas.Checked = True
    End Sub

#End Region

    Private Sub TodosMarcados()
        If chkMateriales.Checked And chkMod.Checked And chkCentros.Checked And chkGastos.Checked And chkVarios.Checked And chkMediciones.Checked Then
            chkConceptosAll.Checked = True
        Else
            chkConceptosAll.Checked = False
        End If
    End Sub

    Private Sub Conceptos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVarios.CheckedChanged, chkGastos.CheckedChanged, chkCentros.CheckedChanged, chkMod.CheckedChanged, chkMateriales.CheckedChanged, chkMediciones.CheckedChanged
        If Not blnMarcoAll Then TodosMarcados()
    End Sub

    Private Sub chkConceptosAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkConceptosAll.CheckedChanged
        blnMarcoAll = True
        If chkConceptosAll.Checked Then
            chkMateriales.Checked = chkConceptosAll.Checked
            chkMod.Checked = chkConceptosAll.Checked
            chkCentros.Checked = chkConceptosAll.Checked
            chkGastos.Checked = chkConceptosAll.Checked
            chkVarios.Checked = chkConceptosAll.Checked
            chkMediciones.Checked = chkConceptosAll.Checked
        End If
        blnMarcoAll = False
    End Sub

    Private Sub AdvContador_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs)
        e.Filter.Add("Entidad", FilterOperator.Equal, "ObraCabecera")
    End Sub

    Private Sub CmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        Me.DialogResult = DialogResult.None
        Dim blnCancel As Boolean
        If blnContadorVisible AndAlso Length(AdvContador.Text) = 0 AndAlso Length(txtNObra.Text) = 0 Then
            If ExpertisApp.GenerateMessage("No ha seleccionado un Contador. Por defecto se cogerá el que tenga el Proyecto que va a copiar. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                blnCancel = True
            End If
        End If

        If Not blnCancel Then
            GuardarConfiguracion()
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub GuardarConfiguracion()
        ConfiguracionCopia = New dataConfigCopiaObra
        ConfiguracionCopia.IDContador = AdvContador.Text
        ConfiguracionCopia.NDestino = txtNObra.Text
        ConfiguracionCopia.IDClase = cbxIDClase.Value
        ConfiguracionCopia.CopiarMateriales = chkMateriales.Checked
        ConfiguracionCopia.CopiarMod = chkMod.Checked
        ConfiguracionCopia.CopiarCentros = chkCentros.Checked
        ConfiguracionCopia.CopiarGastos = chkGastos.Checked
        ConfiguracionCopia.CopiarVarios = chkVarios.Checked
        ConfiguracionCopia.CopiarRecursos = chkRecursos.Checked
        ConfiguracionCopia.CopiarMediciones = chkMediciones.Checked
        ConfiguracionCopia.CopiarCaracteristicas = chkCaracteristicas.Checked
        ConfiguracionCopia.CopiarTrabajos = True
        ConfiguracionCopia.CopiarSubTrabajos = True
        ConfiguracionCopia.CopiarTareas = chkTareas.Checked
        ConfiguracionCopia.SinOrigen = False
    End Sub

End Class