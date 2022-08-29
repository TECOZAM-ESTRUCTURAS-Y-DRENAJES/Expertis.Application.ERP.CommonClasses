Public Class frmSendMail
    Inherits FormBase

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
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents pnlBotones As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlTop As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents txtAsunto As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblAsunto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlBottom As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblDocAdjunto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtPathAdjunto As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents cmbDocAdjunto As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbFichero As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents txtPathFicheroMensaje As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblFichero As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlFill As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblMensaje As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ImgList As System.Windows.Forms.ImageList
    Friend WithEvents PnlPara As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents TxtPara As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblPara As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtMensaje As Solmicro.Expertis.Engine.UI.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSendMail))
        Me.pnlBotones = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.ImgList = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.pnlTop = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtAsunto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblAsunto = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlBottom = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbDocAdjunto = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbFichero = New Solmicro.Expertis.Engine.UI.Button
        Me.lblDocAdjunto = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPathAdjunto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtPathFicheroMensaje = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFichero = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlFill = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblMensaje = New Solmicro.Expertis.Engine.UI.Label
        Me.txtMensaje = New Solmicro.Expertis.Engine.UI.TextBox
        Me.PnlPara = New Solmicro.Expertis.Engine.UI.Panel
        Me.TxtPara = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblPara = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlBotones.suspendlayout()
        Me.pnlTop.suspendlayout()
        Me.pnlBottom.suspendlayout()
        Me.pnlFill.suspendlayout()
        Me.PnlPara.suspendlayout()
        Me.SuspendLayout()
        '
        'pnlBotones
        '
        Me.pnlBotones.Controls.Add(Me.cmdCancelar)
        Me.pnlBotones.Controls.Add(Me.cmdAceptar)
        Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBotones.Location = New System.Drawing.Point(0, 447)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(672, 40)
        Me.pnlBotones.TabIndex = 6
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.ImageList = Me.ImgList
        Me.cmdCancelar.Location = New System.Drawing.Point(340, 4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(88, 32)
        Me.cmdCancelar.TabIndex = 8
        Me.cmdCancelar.Text = "Cancelar"
        '
        'ImgList
        '
        Me.ImgList.ImageStream = CType(resources.GetObject("ImgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgList.Images.SetKeyName(0, "check2.ico")
        Me.ImgList.Images.SetKeyName(1, "delete2.ico")
        '
        'cmdAceptar
        '
        Me.cmdAceptar.ImageList = Me.ImgList
        Me.cmdAceptar.Location = New System.Drawing.Point(244, 4)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(88, 32)
        Me.cmdAceptar.TabIndex = 7
        Me.cmdAceptar.Text = "Aceptar"
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.txtAsunto)
        Me.pnlTop.Controls.Add(Me.lblAsunto)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 28)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(672, 30)
        Me.pnlTop.TabIndex = 41
        '
        'txtAsunto
        '
        Me.txtAsunto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAsunto.DisabledBackColor = System.Drawing.Color.White
        Me.txtAsunto.Location = New System.Drawing.Point(93, 6)
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(574, 21)
        Me.txtAsunto.TabIndex = 32
        '
        'lblAsunto
        '
        Me.lblAsunto.Location = New System.Drawing.Point(8, 6)
        Me.lblAsunto.Name = "lblAsunto"
        Me.lblAsunto.Size = New System.Drawing.Size(46, 13)
        Me.lblAsunto.TabIndex = 33
        Me.lblAsunto.Text = "Asunto"
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.cmbDocAdjunto)
        Me.pnlBottom.Controls.Add(Me.cmbFichero)
        Me.pnlBottom.Controls.Add(Me.lblDocAdjunto)
        Me.pnlBottom.Controls.Add(Me.txtPathAdjunto)
        Me.pnlBottom.Controls.Add(Me.txtPathFicheroMensaje)
        Me.pnlBottom.Controls.Add(Me.lblFichero)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 394)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(672, 53)
        Me.pnlBottom.TabIndex = 42
        '
        'cmbDocAdjunto
        '
        Me.cmbDocAdjunto.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmbDocAdjunto.Image = CType(resources.GetObject("cmbDocAdjunto.Image"), System.Drawing.Image)
        Me.cmbDocAdjunto.Location = New System.Drawing.Point(93, 28)
        Me.cmbDocAdjunto.Name = "cmbDocAdjunto"
        Me.cmbDocAdjunto.Size = New System.Drawing.Size(21, 21)
        Me.cmbDocAdjunto.TabIndex = 41
        '
        'cmbFichero
        '
        Me.cmbFichero.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmbFichero.Image = CType(resources.GetObject("cmbFichero.Image"), System.Drawing.Image)
        Me.cmbFichero.Location = New System.Drawing.Point(93, 4)
        Me.cmbFichero.Name = "cmbFichero"
        Me.cmbFichero.Size = New System.Drawing.Size(21, 21)
        Me.cmbFichero.TabIndex = 39
        '
        'lblDocAdjunto
        '
        Me.lblDocAdjunto.Location = New System.Drawing.Point(8, 28)
        Me.lblDocAdjunto.Name = "lblDocAdjunto"
        Me.lblDocAdjunto.Size = New System.Drawing.Size(81, 13)
        Me.lblDocAdjunto.TabIndex = 44
        Me.lblDocAdjunto.Text = "Doc. Adjunto"
        '
        'txtPathAdjunto
        '
        Me.txtPathAdjunto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPathAdjunto.DisabledBackColor = System.Drawing.Color.White
        Me.txtPathAdjunto.Location = New System.Drawing.Point(117, 28)
        Me.txtPathAdjunto.Name = "txtPathAdjunto"
        Me.txtPathAdjunto.Size = New System.Drawing.Size(550, 21)
        Me.txtPathAdjunto.TabIndex = 42
        '
        'txtPathFicheroMensaje
        '
        Me.txtPathFicheroMensaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPathFicheroMensaje.DisabledBackColor = System.Drawing.Color.White
        Me.txtPathFicheroMensaje.Location = New System.Drawing.Point(117, 4)
        Me.txtPathFicheroMensaje.Name = "txtPathFicheroMensaje"
        Me.txtPathFicheroMensaje.Size = New System.Drawing.Size(550, 21)
        Me.txtPathFicheroMensaje.TabIndex = 40
        '
        'lblFichero
        '
        Me.lblFichero.Location = New System.Drawing.Point(8, 4)
        Me.lblFichero.Name = "lblFichero"
        Me.lblFichero.Size = New System.Drawing.Size(48, 13)
        Me.lblFichero.TabIndex = 43
        Me.lblFichero.Text = "Fichero"
        '
        'pnlFill
        '
        Me.pnlFill.Controls.Add(Me.lblMensaje)
        Me.pnlFill.Controls.Add(Me.txtMensaje)
        Me.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFill.Location = New System.Drawing.Point(0, 58)
        Me.pnlFill.Name = "pnlFill"
        Me.pnlFill.Size = New System.Drawing.Size(672, 336)
        Me.pnlFill.TabIndex = 43
        '
        'lblMensaje
        '
        Me.lblMensaje.Location = New System.Drawing.Point(8, 4)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(54, 13)
        Me.lblMensaje.TabIndex = 42
        Me.lblMensaje.Text = "Mensaje"
        '
        'txtMensaje
        '
        Me.txtMensaje.AcceptsReturn = True
        Me.txtMensaje.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMensaje.DisabledBackColor = System.Drawing.Color.White
        Me.txtMensaje.Location = New System.Drawing.Point(93, 2)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMensaje.Size = New System.Drawing.Size(574, 331)
        Me.txtMensaje.TabIndex = 41
        '
        'PnlPara
        '
        Me.PnlPara.Controls.Add(Me.TxtPara)
        Me.PnlPara.Controls.Add(Me.LblPara)
        Me.PnlPara.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlPara.Location = New System.Drawing.Point(0, 0)
        Me.PnlPara.Name = "PnlPara"
        Me.PnlPara.Size = New System.Drawing.Size(672, 28)
        Me.PnlPara.TabIndex = 44
        '
        'TxtPara
        '
        Me.TxtPara.DisabledBackColor = System.Drawing.Color.White
        Me.TxtPara.Enabled = False
        Me.TxtPara.Location = New System.Drawing.Point(93, 5)
        Me.TxtPara.Name = "TxtPara"
        Me.TxtPara.Size = New System.Drawing.Size(574, 21)
        Me.TxtPara.TabIndex = 1
        '
        'LblPara
        '
        Me.LblPara.Location = New System.Drawing.Point(8, 5)
        Me.LblPara.Name = "LblPara"
        Me.LblPara.Size = New System.Drawing.Size(33, 13)
        Me.LblPara.TabIndex = 0
        Me.LblPara.Text = "Para"
        '
        'frmSendMail
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(672, 487)
        Me.Controls.Add(Me.pnlFill)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlBotones)
        Me.Controls.Add(Me.PnlPara)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSendMail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos del mail"
        Me.pnlBotones.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlBottom.PerformLayout()
        Me.pnlFill.ResumeLayout(False)
        Me.pnlFill.PerformLayout()
        Me.PnlPara.ResumeLayout(False)
        Me.PnlPara.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Propiedades Públicas"

    Public Property Para() As String
        Get
            Return Me.TxtPara.Text
        End Get
        Set(ByVal value As String)
            Me.TxtPara.Text = value
        End Set
    End Property

    Public Property Asunto() As String
        Set(ByVal value As String)
            Me.txtAsunto.Text = value
        End Set
        Get
            Return Me.txtAsunto.Text
        End Get
    End Property

    Public Property Mensaje() As String
        Set(ByVal value As String)
            Me.txtMensaje.Text = value
        End Set
        Get
            Return Me.txtMensaje.Text
        End Get
    End Property

    Public WriteOnly Property MensajeConObservacion() As String
        Set(ByVal value As String)
            LoadObservacion(value)
        End Set
    End Property

    Public Property FicheroMensaje() As String
        Set(ByVal value As String)
            Me.txtPathFicheroMensaje.Text = value
        End Set
        Get
            Return Me.txtPathFicheroMensaje.Text
        End Get
    End Property

    Public ReadOnly Property Adjunto() As String
        Get
            Return Me.txtPathAdjunto.Text
        End Get
    End Property

    Public WriteOnly Property VerPara() As Boolean
        Set(ByVal value As Boolean)
            MostrarPara(value)
        End Set
    End Property

    Public WriteOnly Property VerFichero() As Boolean
        Set(ByVal value As Boolean)
            MostrarFichero(value)
        End Set
    End Property

    Public WriteOnly Property VerAdjunto() As Boolean
        Set(ByVal value As Boolean)
            MostrarAdjunto(value)
        End Set
    End Property

    Public WriteOnly Property FicheroSoloLectura() As Boolean
        Set(ByVal value As Boolean)
            SoloLecturaFichero(Not value)
        End Set
    End Property

#End Region

#Region "Procesos Privados"

    Private Sub LoadObservacion(ByVal StrEntidad As String)
        If Length(StrEntidad) > 0 Then
            Dim DtObserv As DataTable = New Observacion().Filter(New FilterItem("Entidad", FilterOperator.Equal, StrEntidad))
            If Not DtObserv Is Nothing AndAlso DtObserv.Rows.Count > 0 Then
                Me.txtMensaje.Text = DtObserv.Rows(0)("DescObservacion")
            End If
        End If
    End Sub

    Private Sub MostrarPara(ByVal BlnVer As Boolean)
        Me.PnlPara.Visible = BlnVer
    End Sub

    Private Sub MostrarFichero(ByVal BlnVer As Boolean)
        Me.txtPathFicheroMensaje.Visible = BlnVer
        Me.lblFichero.Visible = BlnVer
        Me.cmbFichero.Visible = BlnVer
    End Sub

    Private Sub MostrarAdjunto(ByVal BlnVer As Boolean)
        Me.txtPathAdjunto.Visible = BlnVer
        Me.lblDocAdjunto.Visible = BlnVer
        Me.cmbDocAdjunto.Visible = BlnVer
    End Sub

    Private Sub SoloLecturaFichero(ByVal BlnModo As Boolean)
        Me.txtPathFicheroMensaje.Enabled = BlnModo
        Me.cmbFichero.Enabled = BlnModo
    End Sub

#End Region

#Region "Eventos FrmSendMail"

    Private Sub cmbFichero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFichero.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Pagina Web (*.htm;*.html)|*.html;*.htm|Texto sin Formato (*.txt)|*.txt|Todos los Archivos (*.*)|*.*"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Me.txtPathFicheroMensaje.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub cmbDocAdjunto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDocAdjunto.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Me.txtPathAdjunto.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Length(Me.txtMensaje.Text) > 0 Or Length(Me.txtPathFicheroMensaje.Text) > 0 Then
            Me.DialogResult = DialogResult.OK
        Else
            ExpertisApp.GenerateMessage("El Mensaje o el Fichero son datos obligatorios.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

End Class