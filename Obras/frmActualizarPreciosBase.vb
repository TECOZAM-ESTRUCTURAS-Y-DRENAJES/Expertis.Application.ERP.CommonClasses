Public Class frmActualizarPreciosBase
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
    Protected Friend WithEvents rbCosteVenta As Solmicro.Expertis.Engine.UI.RadioButton
    Protected Friend WithEvents rbCosteMargen As Solmicro.Expertis.Engine.UI.RadioButton
    Protected Friend WithEvents rbVentaMargen As Solmicro.Expertis.Engine.UI.RadioButton
    Protected Friend WithEvents rbMargenVenta As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents frmActualizar As System.Windows.Forms.GroupBox
    Public WithEvents pnlActualizaciones As System.Windows.Forms.Panel
    Public WithEvents pnlAcciones As System.Windows.Forms.Panel
    Public WithEvents pnlValidar As System.Windows.Forms.Panel
    Public WithEvents frmAcciones As System.Windows.Forms.GroupBox
    Public WithEvents txtMargen As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblMargen As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtDecrementar As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtIncrementar As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblDecrementar As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblIncrementar As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents btnCancelar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents btnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents pnlGeneral As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.pnlActualizaciones = New System.Windows.Forms.Panel
        Me.frmActualizar = New System.Windows.Forms.GroupBox
        Me.rbCosteVenta = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbCosteMargen = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbVentaMargen = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbMargenVenta = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.pnlAcciones = New System.Windows.Forms.Panel
        Me.frmAcciones = New System.Windows.Forms.GroupBox
        Me.txtMargen = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblMargen = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDecrementar = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtIncrementar = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblDecrementar = New Solmicro.Expertis.Engine.UI.Label
        Me.lblIncrementar = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlValidar = New System.Windows.Forms.Panel
        Me.btnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.btnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.pnlGeneral = New System.Windows.Forms.Panel
        Me.pnlActualizaciones.SuspendLayout()
        Me.frmActualizar.SuspendLayout()
        Me.pnlAcciones.SuspendLayout()
        Me.frmAcciones.SuspendLayout()
        Me.pnlValidar.SuspendLayout()
        Me.pnlGeneral.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlActualizaciones
        '
        Me.pnlActualizaciones.Controls.Add(Me.frmActualizar)
        Me.pnlActualizaciones.Location = New System.Drawing.Point(0, 0)
        Me.pnlActualizaciones.Name = "pnlActualizaciones"
        Me.pnlActualizaciones.Size = New System.Drawing.Size(520, 136)
        Me.pnlActualizaciones.TabIndex = 0
        '
        'frmActualizar
        '
        Me.frmActualizar.Controls.Add(Me.rbCosteVenta)
        Me.frmActualizar.Controls.Add(Me.rbCosteMargen)
        Me.frmActualizar.Controls.Add(Me.rbVentaMargen)
        Me.frmActualizar.Controls.Add(Me.rbMargenVenta)
        Me.frmActualizar.Location = New System.Drawing.Point(8, 8)
        Me.frmActualizar.Name = "frmActualizar"
        Me.frmActualizar.Size = New System.Drawing.Size(272, 120)
        Me.frmActualizar.TabIndex = 0
        Me.frmActualizar.TabStop = False
        Me.frmActualizar.Text = "Actualizar"
        '
        'rbCosteVenta
        '
        Me.rbCosteVenta.Location = New System.Drawing.Point(8, 16)
        Me.rbCosteVenta.Name = "rbCosteVenta"
        Me.rbCosteVenta.Size = New System.Drawing.Size(256, 23)
        Me.rbCosteVenta.TabIndex = 4
        '
        'rbCosteMargen
        '
        Me.rbCosteMargen.Location = New System.Drawing.Point(8, 40)
        Me.rbCosteMargen.Name = "rbCosteMargen"
        Me.rbCosteMargen.Size = New System.Drawing.Size(256, 23)
        Me.rbCosteMargen.TabIndex = 5
        '
        'rbVentaMargen
        '
        Me.rbVentaMargen.Location = New System.Drawing.Point(8, 64)
        Me.rbVentaMargen.Name = "rbVentaMargen"
        Me.rbVentaMargen.Size = New System.Drawing.Size(256, 23)
        Me.rbVentaMargen.TabIndex = 6
        '
        'rbMargenVenta
        '
        Me.rbMargenVenta.Location = New System.Drawing.Point(8, 88)
        Me.rbMargenVenta.Name = "rbMargenVenta"
        Me.rbMargenVenta.Size = New System.Drawing.Size(256, 24)
        Me.rbMargenVenta.TabIndex = 7
        '
        'pnlAcciones
        '
        Me.pnlAcciones.Controls.Add(Me.frmAcciones)
        Me.pnlAcciones.Location = New System.Drawing.Point(0, 136)
        Me.pnlAcciones.Name = "pnlAcciones"
        Me.pnlAcciones.Size = New System.Drawing.Size(520, 87)
        Me.pnlAcciones.TabIndex = 1
        '
        'frmAcciones
        '
        Me.frmAcciones.Controls.Add(Me.txtMargen)
        Me.frmAcciones.Controls.Add(Me.lblMargen)
        Me.frmAcciones.Controls.Add(Me.txtDecrementar)
        Me.frmAcciones.Controls.Add(Me.txtIncrementar)
        Me.frmAcciones.Controls.Add(Me.lblDecrementar)
        Me.frmAcciones.Controls.Add(Me.lblIncrementar)
        Me.frmAcciones.Location = New System.Drawing.Point(8, 3)
        Me.frmAcciones.Name = "frmAcciones"
        Me.frmAcciones.Size = New System.Drawing.Size(504, 80)
        Me.frmAcciones.TabIndex = 0
        Me.frmAcciones.TabStop = False
        Me.frmAcciones.Text = "Acciones"
        '
        'txtMargen
        '
        Me.txtMargen.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargen.Location = New System.Drawing.Point(352, 24)
        Me.txtMargen.Name = "txtMargen"
        Me.txtMargen.Size = New System.Drawing.Size(91, 21)
        Me.txtMargen.TabIndex = 18
        '
        'lblMargen
        '
        Me.lblMargen.Location = New System.Drawing.Point(296, 28)
        Me.lblMargen.Name = "lblMargen"
        Me.lblMargen.Size = New System.Drawing.Size(49, 13)
        Me.lblMargen.TabIndex = 17
        Me.lblMargen.Text = "Margen"
        '
        'txtDecrementar
        '
        Me.txtDecrementar.DisabledBackColor = System.Drawing.Color.White
        Me.txtDecrementar.Location = New System.Drawing.Point(117, 48)
        Me.txtDecrementar.Name = "txtDecrementar"
        Me.txtDecrementar.Size = New System.Drawing.Size(91, 21)
        Me.txtDecrementar.TabIndex = 16
        '
        'txtIncrementar
        '
        Me.txtIncrementar.DisabledBackColor = System.Drawing.Color.White
        Me.txtIncrementar.Location = New System.Drawing.Point(117, 24)
        Me.txtIncrementar.Name = "txtIncrementar"
        Me.txtIncrementar.Size = New System.Drawing.Size(91, 21)
        Me.txtIncrementar.TabIndex = 15
        '
        'lblDecrementar
        '
        Me.lblDecrementar.Location = New System.Drawing.Point(16, 52)
        Me.lblDecrementar.Name = "lblDecrementar"
        Me.lblDecrementar.Size = New System.Drawing.Size(98, 13)
        Me.lblDecrementar.TabIndex = 14
        Me.lblDecrementar.Text = "Decrementar %"
        '
        'lblIncrementar
        '
        Me.lblIncrementar.Location = New System.Drawing.Point(16, 28)
        Me.lblIncrementar.Name = "lblIncrementar"
        Me.lblIncrementar.Size = New System.Drawing.Size(94, 13)
        Me.lblIncrementar.TabIndex = 13
        Me.lblIncrementar.Text = "Incrementar %"
        '
        'pnlValidar
        '
        Me.pnlValidar.Controls.Add(Me.btnCancelar)
        Me.pnlValidar.Controls.Add(Me.btnAceptar)
        Me.pnlValidar.Location = New System.Drawing.Point(0, 224)
        Me.pnlValidar.Name = "pnlValidar"
        Me.pnlValidar.Size = New System.Drawing.Size(520, 48)
        Me.pnlValidar.TabIndex = 1
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(276, 8)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(113, 31)
        Me.btnCancelar.TabIndex = 16
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(156, 8)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(113, 32)
        Me.btnAceptar.TabIndex = 15
        Me.btnAceptar.Text = "Aceptar"
        '
        'pnlGeneral
        '
        Me.pnlGeneral.Controls.Add(Me.pnlAcciones)
        Me.pnlGeneral.Controls.Add(Me.pnlActualizaciones)
        Me.pnlGeneral.Controls.Add(Me.pnlValidar)
        Me.pnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGeneral.Location = New System.Drawing.Point(0, 0)
        Me.pnlGeneral.Name = "pnlGeneral"
        Me.pnlGeneral.Size = New System.Drawing.Size(520, 273)
        Me.pnlGeneral.TabIndex = 2
        '
        'frmActualizarPreciosBase
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(520, 273)
        Me.Controls.Add(Me.pnlGeneral)
        Me.Name = "frmActualizarPreciosBase"
        Me.Text = "Actualizar Precios"
        Me.pnlActualizaciones.ResumeLayout(False)
        Me.frmActualizar.ResumeLayout(False)
        Me.pnlAcciones.ResumeLayout(False)
        Me.frmAcciones.ResumeLayout(False)
        Me.frmAcciones.PerformLayout()
        Me.pnlValidar.ResumeLayout(False)
        Me.pnlGeneral.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected Cancelar As Boolean = True
    Protected Actualizar As Boolean = False
    Protected minfoActualizacionPrecios As ActualizarPrecios.datosActualizacionPrecios

    Private mintTipoActualizacion As enumTipoActualizacionPreciosObras
    Private mintTipoAccion As enumTipoAccionPreciosObras
    Private mdblPorCiento As Double
    Private mblnIncrementar As Boolean
    Private mintCoste As enumOMPrecioCoste
    Private mintVenta As enumOMPrecioVenta
    Private mstrPresupCoste As String
    Private mstrPresupVenta As String
    Private mIDtarifa As String
    Private mdblMargen As Double

#Region "Propiedades"

    Property infoActualizacionPrecios() As ActualizarPrecios.datosActualizacionPrecios
        Get
            Return minfoActualizacionPrecios
        End Get
        Set(ByVal Value As ActualizarPrecios.datosActualizacionPrecios)
            minfoActualizacionPrecios = Value
        End Set
    End Property

    Property TipoActualizacion() As enumTipoActualizacionPreciosObras
        Get
            Return mintTipoActualizacion
        End Get
        Set(ByVal Value As enumTipoActualizacionPreciosObras)
            mintTipoActualizacion = Value
        End Set
    End Property

    Property TipoAccion() As enumTipoAccionPreciosObras
        Get
            Return mintTipoAccion
        End Get
        Set(ByVal Value As enumTipoAccionPreciosObras)
            mintTipoAccion = Value
        End Set
    End Property

    Property PorCiento() As Double
        Get
            Return mdblPorCiento
        End Get
        Set(ByVal Value As Double)
            mdblPorCiento = Value
        End Set
    End Property

    Property Incrementar() As Boolean
        Get
            Return mblnIncrementar
        End Get
        Set(ByVal Value As Boolean)
            mblnIncrementar = Value
        End Set
    End Property

    Property Coste() As enumOMPrecioCoste
        Get
            Return mintCoste
        End Get
        Set(ByVal Value As enumOMPrecioCoste)
            mintCoste = Value
        End Set
    End Property

    Property PresupCoste() As String
        Get
            Return mstrPresupCoste
        End Get
        Set(ByVal Value As String)
            mstrPresupCoste = Value
        End Set
    End Property

    Property Venta() As enumOMPrecioVenta
        Get
            Return mintVenta
        End Get
        Set(ByVal Value As enumOMPrecioVenta)
            mintVenta = Value
        End Set
    End Property

    Property PresupVenta() As String
        Get
            Return mstrPresupVenta
        End Get
        Set(ByVal Value As String)
            mstrPresupVenta = Value
        End Set
    End Property

    Property Tarifa() As String
        Get
            Return mIDtarifa
        End Get
        Set(ByVal Value As String)
            mIDtarifa = Value
        End Set
    End Property

    Property Margen() As Double
        Get
            Return mdblMargen
        End Get
        Set(ByVal Value As Double)
            mdblMargen = Value
        End Set
    End Property

#End Region

    Public Overridable Sub OpenForm()
        Me.ShowDialog()
    End Sub

    Protected Function CargarTipoActualizacion() As Integer
        Dim elegido As Integer = 0
        For Each rb As Solmicro.Expertis.Engine.UI.RadioButton In frmActualizar.Controls
            If rb.Checked Then
                Return elegido
            Else
                elegido = elegido + 1
            End If
        Next
    End Function

    Protected Sub CargarDatos()
        rbCosteVenta.Text = ExpertisApp.Traslate("Precio coste y recalcular precio venta")
        rbCosteMargen.Text = ExpertisApp.Traslate("Precio coste y recalcular margen")
        rbVentaMargen.Text = ExpertisApp.Traslate("Precio venta y recalcular margen")
        rbMargenVenta.Text = ExpertisApp.Traslate("Margen y recalcular precio venta")
        rbCosteVenta.Select()
        rbCosteVenta.Checked = True
    End Sub

    Protected Overridable Function ValidarCampos() As Boolean

    End Function

#Region "Respuesta a eventos del Formulario"

    Private Sub frmActualizarPrecios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    Private Sub frmActualizarPrecios_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Cancelar Then
            e.Cancel = False ''cierra
        Else
            e.Cancel = True ''no cierra
            Cancelar = True
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        If Not ValidarCampos() Then
            Actualizar = False
            Cancelar = False
        Else
            Actualizar = True
            Cancelar = True
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Cancelar = True
        Actualizar = False
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub rbCosteVenta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCosteVenta.CheckedChanged
        lblMargen.Enabled = False
        txtMargen.Enabled = False
    End Sub

    Private Sub rbVentaMargen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbVentaMargen.CheckedChanged
        lblMargen.Enabled = False
        txtMargen.Enabled = False
    End Sub

    Private Sub rbCosteMargen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCosteMargen.CheckedChanged
        lblMargen.Enabled = False
        txtMargen.Enabled = False
    End Sub

    Private Sub rbMargenVenta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMargenVenta.CheckedChanged
        lblMargen.Enabled = True
        txtMargen.Enabled = True
    End Sub

#End Region

End Class
