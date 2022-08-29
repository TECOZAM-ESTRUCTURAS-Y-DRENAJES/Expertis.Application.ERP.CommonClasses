Imports Solmicro.Expertis.Business.EMCS.BdgDAACabecera

Public Class frmSelectDaa
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
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents Frame2 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents chkCliente As System.Windows.Forms.RadioButton
    Friend WithEvents chkAduana As System.Windows.Forms.RadioButton
    Friend WithEvents cmbAduana As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents ullAduana As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents btnOK As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbDestino As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents cmbEntrega As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents ullDestino As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ullEntrega As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents btnCancel As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Frame3 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents advContador As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblTransportista As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTipoEnvio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmbTipoEnvioDAA As Solmicro.Expertis.Engine.UI.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim cmbDestino_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelectDaa))
        Dim cmbAduana_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cmbEntrega_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cmbTipoEnvioDAA_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.ullDestino = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cmbDestino = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.ullAduana = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cmbAduana = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.chkAduana = New System.Windows.Forms.RadioButton
        Me.chkCliente = New System.Windows.Forms.RadioButton
        Me.advContador = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblTransportista = New Solmicro.Expertis.Engine.UI.Label
        Me.Frame2 = New Solmicro.Expertis.Engine.UI.Frame
        Me.ullEntrega = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cmbEntrega = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.btnOK = New Solmicro.Expertis.Engine.UI.Button
        Me.btnCancel = New Solmicro.Expertis.Engine.UI.Button
        Me.Frame3 = New Solmicro.Expertis.Engine.UI.Frame
        Me.advCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTipoEnvio = New Solmicro.Expertis.Engine.UI.Label
        Me.cmbTipoEnvioDAA = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Frame1.SuspendLayout()
        CType(Me.cmbDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAduana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame2.SuspendLayout()
        CType(Me.cmbEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame3.SuspendLayout()
        CType(Me.cmbTipoEnvioDAA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.ullDestino)
        Me.Frame1.Controls.Add(Me.cmbDestino)
        Me.Frame1.Controls.Add(Me.ullAduana)
        Me.Frame1.Controls.Add(Me.cmbAduana)
        Me.Frame1.Controls.Add(Me.chkAduana)
        Me.Frame1.Controls.Add(Me.chkCliente)
        Me.Frame1.Location = New System.Drawing.Point(16, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(720, 111)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "5 (4) Destinatario"
        '
        'ullDestino
        '
        Me.ullDestino.Location = New System.Drawing.Point(344, 61)
        Me.ullDestino.Name = "ullDestino"
        Me.ullDestino.Size = New System.Drawing.Size(360, 24)
        Me.ullDestino.TabIndex = 5
        '
        'cmbDestino
        '
        cmbDestino_DesignTimeLayout.LayoutString = resources.GetString("cmbDestino_DesignTimeLayout.LayoutString")
        Me.cmbDestino.DesignTimeLayout = cmbDestino_DesignTimeLayout
        Me.cmbDestino.DisabledBackColor = System.Drawing.Color.White
        Me.cmbDestino.DisplayMember = "RazonSocial"
        Me.cmbDestino.Location = New System.Drawing.Point(16, 64)
        Me.cmbDestino.Name = "cmbDestino"
        Me.cmbDestino.SecondaryDataFields = "IDDireccion"
        Me.cmbDestino.SelectedIndex = -1
        Me.cmbDestino.SelectedItem = Nothing
        Me.cmbDestino.Size = New System.Drawing.Size(312, 21)
        Me.cmbDestino.TabIndex = 4
        '
        'ullAduana
        '
        Me.TryDataBinding(ullAduana, New System.Windows.Forms.Binding("Text", Me.cmbAduana, "DescCliente", True))
        Me.ullAduana.Location = New System.Drawing.Point(344, 24)
        Me.ullAduana.Name = "ullAduana"
        Me.ullAduana.Size = New System.Drawing.Size(360, 24)
        Me.ullAduana.TabIndex = 3
        Me.ullAduana.Visible = False
        '
        'cmbAduana
        '
        cmbAduana_DesignTimeLayout.LayoutString = resources.GetString("cmbAduana_DesignTimeLayout.LayoutString")
        Me.cmbAduana.DesignTimeLayout = cmbAduana_DesignTimeLayout
        Me.cmbAduana.DisabledBackColor = System.Drawing.Color.White
        Me.cmbAduana.DisplayMember = "IDCliente"
        Me.cmbAduana.Location = New System.Drawing.Point(192, 27)
        Me.cmbAduana.Name = "cmbAduana"
        Me.cmbAduana.SecondaryDataFields = "IDCliente"
        Me.cmbAduana.SelectedIndex = -1
        Me.cmbAduana.SelectedItem = Nothing
        Me.cmbAduana.Size = New System.Drawing.Size(136, 21)
        Me.cmbAduana.TabIndex = 2
        Me.cmbAduana.ViewName = "frmSelectDaaAduana"
        Me.cmbAduana.Visible = False
        '
        'chkAduana
        '
        Me.chkAduana.Location = New System.Drawing.Point(112, 24)
        Me.chkAduana.Name = "chkAduana"
        Me.chkAduana.Size = New System.Drawing.Size(72, 24)
        Me.chkAduana.TabIndex = 1
        Me.chkAduana.Text = "Aduana"
        '
        'chkCliente
        '
        Me.chkCliente.Checked = True
        Me.chkCliente.Location = New System.Drawing.Point(16, 24)
        Me.chkCliente.Name = "chkCliente"
        Me.chkCliente.Size = New System.Drawing.Size(72, 24)
        Me.chkCliente.TabIndex = 0
        Me.chkCliente.TabStop = True
        Me.chkCliente.Text = "Cliente"
        '
        'advContador
        '
        Me.advContador.DisabledBackColor = System.Drawing.Color.White
        Me.advContador.DisplayField = "IDContador"
        Me.advContador.EntityName = "Contador"
        Me.advContador.Location = New System.Drawing.Point(406, 25)
        Me.advContador.Name = "advContador"
        Me.advContador.SecondaryDataFields = "IDContador"
        Me.advContador.Size = New System.Drawing.Size(103, 23)
        Me.advContador.TabIndex = 1
        Me.advContador.ViewName = "advEntidadContador"
        '
        'LblTransportista
        '
        Me.LblTransportista.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTransportista.Location = New System.Drawing.Point(340, 29)
        Me.LblTransportista.Name = "LblTransportista"
        Me.LblTransportista.Size = New System.Drawing.Size(60, 13)
        Me.LblTransportista.TabIndex = 27
        Me.LblTransportista.Text = "Contador"
        Me.LblTransportista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Frame2
        '
        Me.Frame2.Controls.Add(Me.ullEntrega)
        Me.Frame2.Controls.Add(Me.cmbEntrega)
        Me.Frame2.Location = New System.Drawing.Point(16, 211)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = New System.Drawing.Size(720, 75)
        Me.Frame2.TabIndex = 2
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "7 Lugar de Entrega"
        '
        'ullEntrega
        '
        Me.ullEntrega.Location = New System.Drawing.Point(344, 29)
        Me.ullEntrega.Name = "ullEntrega"
        Me.ullEntrega.Size = New System.Drawing.Size(360, 24)
        Me.ullEntrega.TabIndex = 6
        '
        'cmbEntrega
        '
        cmbEntrega_DesignTimeLayout.LayoutString = resources.GetString("cmbEntrega_DesignTimeLayout.LayoutString")
        Me.cmbEntrega.DesignTimeLayout = cmbEntrega_DesignTimeLayout
        Me.cmbEntrega.DisabledBackColor = System.Drawing.Color.White
        Me.cmbEntrega.DisplayMember = "RazonSocial"
        Me.cmbEntrega.Location = New System.Drawing.Point(16, 32)
        Me.cmbEntrega.Name = "cmbEntrega"
        Me.cmbEntrega.SecondaryDataFields = "IDDireccion"
        Me.cmbEntrega.SelectedIndex = -1
        Me.cmbEntrega.SelectedItem = Nothing
        Me.cmbEntrega.Size = New System.Drawing.Size(312, 21)
        Me.cmbEntrega.TabIndex = 5
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(232, 296)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(96, 32)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "Aceptar"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(400, 296)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 32)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancelar"
        '
        'Frame3
        '
        Me.Frame3.Controls.Add(Me.advCliente)
        Me.Frame3.Controls.Add(Me.lblCliente)
        Me.Frame3.Controls.Add(Me.lblTipoEnvio)
        Me.Frame3.Controls.Add(Me.advContador)
        Me.Frame3.Controls.Add(Me.LblTransportista)
        Me.Frame3.Controls.Add(Me.cmbTipoEnvioDAA)
        Me.Frame3.Location = New System.Drawing.Point(16, 132)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Size = New System.Drawing.Size(720, 64)
        Me.Frame3.TabIndex = 1
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "General"
        '
        'advCliente
        '
        Me.advCliente.DisabledBackColor = System.Drawing.Color.White
        Me.advCliente.DisplayField = "IDCliente"
        Me.advCliente.EntityName = "Cliente"
        Me.advCliente.Location = New System.Drawing.Point(601, 25)
        Me.advCliente.Name = "advCliente"
        Me.advCliente.SecondaryDataFields = "IDCliente"
        Me.advCliente.Size = New System.Drawing.Size(103, 23)
        Me.advCliente.TabIndex = 2
        '
        'lblCliente
        '
        Me.lblCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCliente.Location = New System.Drawing.Point(535, 29)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 93
        Me.lblCliente.Text = "Cliente"
        Me.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoEnvio
        '
        Me.lblTipoEnvio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoEnvio.Location = New System.Drawing.Point(13, 30)
        Me.lblTipoEnvio.Name = "lblTipoEnvio"
        Me.lblTipoEnvio.Size = New System.Drawing.Size(84, 13)
        Me.lblTipoEnvio.TabIndex = 91
        Me.lblTipoEnvio.Text = "Tipo de Envío"
        Me.lblTipoEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbTipoEnvioDAA
        '
        cmbTipoEnvioDAA_DesignTimeLayout.LayoutString = resources.GetString("cmbTipoEnvioDAA_DesignTimeLayout.LayoutString")
        Me.cmbTipoEnvioDAA.DesignTimeLayout = cmbTipoEnvioDAA_DesignTimeLayout
        Me.cmbTipoEnvioDAA.DisabledBackColor = System.Drawing.Color.White
        Me.cmbTipoEnvioDAA.Location = New System.Drawing.Point(126, 25)
        Me.cmbTipoEnvioDAA.Name = "cmbTipoEnvioDAA"
        Me.cmbTipoEnvioDAA.SelectedIndex = -1
        Me.cmbTipoEnvioDAA.SelectedItem = Nothing
        Me.cmbTipoEnvioDAA.Size = New System.Drawing.Size(202, 21)
        Me.cmbTipoEnvioDAA.TabIndex = 0
        '
        'frmSelectDaa
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(752, 342)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Name = "frmSelectDaa"
        Me.Text = "Selección de Destino"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.cmbDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAduana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        CType(Me.cmbEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        CType(Me.cmbTipoEnvioDAA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private stIDCliente As String
    Private intIDDireccionEnvioAV As Integer
    Private mIDAlbaran As Integer
    Private mIDPedido As Integer
    Private mDestino As Integer = -1
    Private mBlnPredeterminar As Boolean

    Private mListado As New RegistroEmpresaInfo
    Public Result As stCrearDAAInfoResult

#Region "Propiedades Sólo Escritura"

    Public WriteOnly Property IDCliente() As String
        Set(ByVal Value As String)
            stIDCliente = Value
            GetDirecciones(stIDCliente)
            If (advCliente.Value <> Value) Then
                advCliente.Value = Value
            End If
            If Not mShowCliente Then
                If Length(Value) > 0 Then
                    Me.advCliente.Visible = False
                    Me.lblCliente.Visible = False
                Else
                    Me.advCliente.Visible = True
                    Me.lblCliente.Visible = True
                End If
            End If
        End Set
    End Property

    Public WriteOnly Property IDDireccionEnvioAV() As Integer
        Set(ByVal Value As Integer)
            intIDDireccionEnvioAV = Value
            If (New EMCSParametro().PredeterminarDireccionesDAA) Then
                SetComboDirValue(Me.cmbDestino, Value)
                SetComboDirValue(Me.cmbEntrega, Value)
                ActualizarTipoEnvioDAA(Me.cmbDestino.Value)
            End If
        End Set
    End Property

    Public WriteOnly Property IDAlbaran() As Integer
        Set(ByVal Value As Integer)
            mIDAlbaran = Value
        End Set
    End Property

    Public WriteOnly Property IDPedido() As Integer
        Set(ByVal Value As Integer)
            mIDPedido = Value
        End Set
    End Property

    Private mShowCliente As Boolean = False
    Public Property ShowCliente() As Boolean
        Get
            Return mShowCliente
        End Get
        Set(ByVal value As Boolean)
            mShowCliente = value
        End Set
    End Property

    Public Property ListadoRegistros() As RegistroEmpresaInfo
        Get
            Return mListado
        End Get
        Set(ByVal Value As RegistroEmpresaInfo)
            mListado = Value
        End Set
    End Property

    Public Sub AñadirRegistro(ByVal IDAlbaran As String, ByVal IDBaseDatos As Guid)
        If (mListado Is Nothing) Then mListado = New RegistroEmpresaInfo
        mListado.Add(IDAlbaran, IDBaseDatos)
    End Sub

#End Region

#Region "Direcciones"

    Private Sub SetComboDirValue(ByVal combo As Expertis.Engine.UI.ComboBox, ByVal value As Object)
        If combo Is Nothing OrElse combo.DataSource Is Nothing Then Return
        Dim dt As DataTable = combo.DataSource()
        If Not dt Is Nothing Then
            Dim oRws() As DataRow = dt.Select(AdoFilterComposer.ComposeNumericFilter("IDDireccion", FilterOperator.Equal, value))
            If oRws.Length > 0 Then
                combo.Value = value
            Else
                combo.Value = Nothing
                combo.Text = String.Empty
            End If
        End If
    End Sub

    Private Sub ActualizarTipoEnvioDAA(ByVal intIDDireccionEnvio As Integer)
        Me.cmbTipoEnvioDAA.Value = DBNull.Value
        If intIDDireccionEnvio <> 0 Then
            Dim DatosEnvioDAA As TipoDAA = ExpertisApp.ExecuteTask(Of Long, TipoDAA)(AddressOf BdgDAACabecera.TipoDAAPorPais, intIDDireccionEnvio)
            If DatosEnvioDAA = TipoDAA.CEE Then
                Me.cmbTipoEnvioDAA.Value = BdgDAACabecera.enumTipoEnvioDAA.EMCSIntracomunitario
            Else
                Me.cmbTipoEnvioDAA.Value = BdgDAACabecera.enumTipoEnvioDAA.EMCSInterno
            End If
        End If
    End Sub

    Private Sub GetDirecciones(ByVal strIDCliente As String)
        If Len(strIDCliente) Then

            Dim oFltr As Filter = New Filter
            oFltr.Add("IDCliente", FilterOperator.Equal, strIDCliente)
            oFltr.Add("Envio", FilterOperator.Equal, 1)

            Dim oFltrAux As New Filter
            oFltrAux.Add("EMCSDestinatario", True)
            oFltrAux.Add(oFltr)

            Dim dtDirs As DataTable = New BE.DataEngine().Filter("frmSelectDAADireccion", oFltrAux)
            Me.cmbDestino.DataSource = dtDirs
            If (mBlnPredeterminar AndAlso dtDirs.Rows.Count > 0) Then
                ActualizarTipoEnvioDAA(dtDirs.Rows(0)("IDDireccion"))
                Me.cmbDestino.Value = dtDirs.Rows(0)("IDDireccion")
            End If

            oFltrAux.Clear()
            oFltrAux.Add("EMCSLugarEntrega", True)
            oFltrAux.Add(oFltr)

            dtDirs = New BE.DataEngine().Filter("frmSelectDAADireccion", oFltrAux)
            Me.cmbEntrega.DataSource = dtDirs
            If (mBlnPredeterminar AndAlso dtDirs.Rows.Count > 0) Then
                Me.cmbEntrega.Value = dtDirs.Rows(0)("IDDireccion")
            End If
            
        End If
    End Sub

    Public Sub DireccionDefecto(ByVal strIDCliente As String)
        If Len(strIDCliente) Then
            Dim oFltr As Filter = New Filter
            oFltr.Add("IDCliente", FilterOperator.Equal, strIDCliente)
            oFltr.Add("IdCae", FilterOperator.NotEqual, DBNull.Value)
            oFltr.Add("Envio", FilterOperator.Equal, 1)
            Dim dtDirs As DataTable = New BE.DataEngine().Filter("frmSelectDAADireccion", oFltr)
            If dtDirs.Rows.Count = 1 Then
                mDestino = dtDirs.Rows(0)("IDDireccion")
            End If
        End If
    End Sub

#End Region

#Region "Eventos"

    Private Sub frmSelectDaa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            mBlnPredeterminar = New EMCSParametro().PredeterminarDireccionesDAA
            advContador.Text = GetContador()
            cmbTipoEnvioDAA.DataSource = New EnumData("enumTipoEnvioDAA")
            If mDestino <> -1 Then SetComboDirValue(cmbDestino, mDestino)
            Me.cmbTipoEnvioDAA.Value = BdgDAACabecera.enumTipoEnvioDAA.EMCSInterno
            cmbTipoEnvioDAA_Validated(cmbTipoEnvioDAA, Nothing)
        End If
    End Sub

    Private Sub chkAduana_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAduana.CheckedChanged
        Me.cmbAduana.Visible = chkAduana.Checked
        Me.ullAduana.Visible = chkAduana.Checked
    End Sub

    Private Sub chkCliente_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCliente.CheckedChanged
        If chkCliente.Checked Then
            GetDirecciones(stIDCliente)
        End If
    End Sub

    Private Sub cmbAduana_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAduana.TextChanged
        GetDirecciones(cmbAduana.Text)
    End Sub

    Private Sub cmbDestino_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDestino.ValueChanged
        ComposeText(cmbDestino, Me.ullDestino)
        ActualizarTipoEnvioDAA(Me.cmbDestino.Value)
    End Sub

    Private Sub ComposeText(ByVal Combo As Expertis.Engine.UI.ComboBox, ByVal uLabel As UnderLineLabel)
        Dim IDDir As Integer
        If Combo.Value Is Nothing OrElse IsDBNull(Combo.Value) Then
            uLabel.Text = Nothing
        Else
            IDDir = Combo.Value
            Dim dt As DataTable = Combo.DataSource()
            If Not dt Is Nothing Then
                Dim oRws() As DataRow = dt.Select(AdoFilterComposer.ComposeNumericFilter("IDDireccion", FilterOperator.Equal, IDDir))
                If oRws.Length > 0 Then
                    uLabel.Text = oRws(0)("Direccion") & " " & oRws(0)("DescPais")
                Else
                    Combo.Value = Nothing
                    Combo.Text = String.Empty
                End If
            End If
        End If
    End Sub

    Private Sub cmbEntrega_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEntrega.ValueChanged
        ComposeText(cmbEntrega, Me.ullEntrega)
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        If Length(Me.cmbTipoEnvioDAA.Value) = 0 Then
            ExpertisApp.GenerateMessage("Debe indicar el tipo de envío.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If Length(Me.cmbAduana.Value) > 0 OrElse (Length(Me.cmbDestino.Text) > 0 AndAlso (Me.cmbTipoEnvioDAA.Value = enumTipoEnvioDAA.EMCSInterno OrElse Length(Me.cmbEntrega.Text) > 0)) _
                                AndAlso Length(Me.advContador.Text) > 0 Then
            If Length(mIDAlbaran) > 0 AndAlso mIDAlbaran <> 0 Then
                GenerarDAAAlbaran()
            ElseIf Length(mIDPedido) > 0 AndAlso mIDPedido <> 0 Then
                GenerarDAAPedido()
            ElseIf Not mListado Is Nothing AndAlso mListado.Listado.Rows.Count > 0 Then
                GenerarDAAAlbaranes()
            Else
                GenerarDAAVacio()
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            ExpertisApp.GenerateMessage("Debe indicar el tipo de envío, el contador y las direcciones de entrega y de destino.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub GenerarDAAVacio()
        Dim dataResult As New stCrearDAAInfo
        dataResult.Contador = Me.advContador.Value
        'dataResult.IDDocumento = dttDatosAlbaran.Rows(0)("IDAlbaran")
        dataResult.FechaDocumento = Today
        'dataResult.NumeroCertificado = dttDatosAlbaran.Rows(0)("NAlbaran")
        'dataResult.IDModoTransporte = dttDatosAlbaran.Rows(0)("IDModoTransporte") & String.Empty
        'dataResult.Transportista = dttDatosAlbaran.Rows(0)("EmpresaTransp") & String.Empty
        'dataResult.NIFResponsableTransporte = dttDatosAlbaran.Rows(0)("DNIConductor") & String.Empty
        'dataResult.ResponsableTransporte = dttDatosAlbaran.Rows(0)("Conductor") & String.Empty
        'dataResult.FormaEnvio = dttDatosAlbaran.Rows(0)("IDFormaEnvio") & String.Empty
        'dataResult.NumeroDocumento = dttDatosAlbaran.Rows(0)("NAlbaran") & String.Empty
        dataResult.Cliente = Me.advCliente.Value
        'dataResult.Direccion = dttDatosAlbaran.Rows(0)("IDDireccion")
        'dataResult.Matricula = dttDatosAlbaran.Rows(0)("Matricula") & String.Empty

        'dataResult.RegistrosEmpresas = data.RegistrosEmpresas
        'dataResult.VistaOrigenLineas = CN_VistaDAAAlbaran
        dataResult.CampoAgrupacionOrigenLineasPorDefecto = "IDLineaAlbaran"
        dataResult.CampoID = "IDAlbaran"
        dataResult.Origen = enumOrigenDAA.Albaran

        dataResult.DireccionDestino = cmbDestino.Value
        dataResult.DireccionEntrega = cmbEntrega.Value
        dataResult.TipoEnvioDAA = cmbTipoEnvioDAA.Value
        dataResult.Aduana = cmbAduana.Value


        Result = ExpertisApp.ExecuteTask(Of stCrearDAAInfo, stCrearDAAInfoResult)(AddressOf BdgDAACabecera.CrearDAA, dataResult)


    End Sub

    'TODO - Refactorizar
    Private Sub GenerarDAAAlbaranes()
        Dim guid As Guid = ExpertisApp.GetConnectionInfo().IDDataBase
        Dim htregistro As RegistroEmpresaInfo = mListado

        If Nz(cmbTipoEnvioDAA.Value, -1) = -1 Then
            ExpertisApp.GenerateMessage("Debe indicar el Tipo de Envío", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'COMPROBAR DATOS PREVIOS
        Dim StValidar As New BdgDAALinea.StValidarDAALineas(enumOrigenDAA.Albaran, htregistro, cmbTipoEnvioDAA.Value, "IDAlbaran", CN_VistaDAAAlbaran)
        ' Dim stMensaje As String = ExpertisApp.ExecuteTask(Of BdgDAALinea.StValidarDAALineas, String)(AddressOf BdgDAALinea.ValidarDAALineas, StValidar)
        'If Length(stMensaje) > 0 Then
        '    stMensaje = stMensaje & "LOS ARTICULOS MENCIONADOS NO SE INCLUIRAN EN EL DAA." & vbCrLf
        '    stMensaje = stMensaje & "¿Desea continuar?"
        '    If Not ExpertisApp.GenerateMessage(stMensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
        '        Exit Sub
        '    End If
        'End If
        Dim Errores() As ClassErrors = ExpertisApp.ExecuteTask(Of BdgDAALinea.StValidarDAALineas, ClassErrors())(AddressOf BdgDAALinea.ValidarDAALineas, StValidar)
        If Not Errores Is Nothing AndAlso Errores.Length > 0 Then
            Dim stMensaje As String = ExpertisApp.Traslate("Se han encontrado los siguientes Errores. ")
            stMensaje = stMensaje & ExpertisApp.Traslate("¿Desea continuar?")
            Dim frm As New frmMostrarErrores
            If Not frm.Abrir(Errores, stMensaje, True) = Windows.Forms.DialogResult.Yes Then
                Exit Sub
            End If
        End If


        Dim data As New stDatosDAADesdeAlbaran()
        data.IDContador = advContador.Text
        data.RegistrosEmpresas = mListado '.Add(mIDAlbaran.ToString(), guid)
        data.DireccionEntrega = Nz(cmbEntrega.Value, 0)
        data.DireccionDestino = Nz(cmbDestino.Value, 0)
        data.TipoEnvioDAA = Nz(cmbTipoEnvioDAA.Value, 0)
        data.Aduana = Nz(cmbAduana.Value, String.Empty)

        Result = ExpertisApp.ExecuteTask(Of stDatosDAADesdeAlbaran, stCrearDAAInfoResult)(AddressOf BdgDAACabecera.CrearDAAAlbaran, data)
        If Not Result Is Nothing AndAlso Length(Result.NDAA) > 0 Then
            If ExpertisApp.GenerateMessage("Se ha generado el DAA Nº |. ¿Desea cargar su mantenimiento?", MessageBoxButtons.YesNo, MessageBoxIcon.Information, Result.NDAA) = DialogResult.Yes Then
                ExpertisApp.OpenForm("BDGDAA", New StringFilterItem("NDAA", FilterOperator.Equal, Result.NDAA))
            End If
        ElseIf Not Result Is Nothing AndAlso Length(Result.ErrorMessage) > 0 Then
            ExpertisApp.GenerateMessage("Se ha producido un error en la generación: |. ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Result.ErrorMessage)
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub GenerarDAAAlbaran()
        Dim guid As Guid = ExpertisApp.GetConnectionInfo().IDDataBase
        Dim htregistro As New RegistroEmpresaInfo
        htregistro.Add(mIDAlbaran.ToString(), guid)
        If Nz(cmbTipoEnvioDAA.Value, -1) = -1 Then
            ExpertisApp.GenerateMessage("Debe indicar el Tipo de Envío", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'COMPROBAR DATOS PREVIOS
        Dim StValidar As New BdgDAALinea.StValidarDAALineas(enumOrigenDAA.Albaran, htregistro, cmbTipoEnvioDAA.Value, "IDAlbaran", CN_VistaDAAAlbaran)
        ' Dim stMensaje As String = ExpertisApp.ExecuteTask(Of BdgDAALinea.StValidarDAALineas, String)(AddressOf BdgDAALinea.ValidarDAALineas, StValidar)
        'If Length(stMensaje) > 0 Then
        '    stMensaje = stMensaje & "LOS ARTICULOS MENCIONADOS NO SE INCLUIRAN EN EL DAA." & vbCrLf
        '    stMensaje = stMensaje & "¿Desea continuar?"
        '    If Not ExpertisApp.GenerateMessage(stMensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
        '        Exit Sub
        '    End If
        'End If
        Dim Errores() As ClassErrors = ExpertisApp.ExecuteTask(Of BdgDAALinea.StValidarDAALineas, ClassErrors())(AddressOf BdgDAALinea.ValidarDAALineas, StValidar)
        If Not Errores Is Nothing AndAlso Errores.Length > 0 Then
            Dim stMensaje As String = ExpertisApp.Traslate("Se han encontrado los siguientes Errores. ")
            stMensaje = stMensaje & ExpertisApp.Traslate("¿Desea continuar?")
            Dim frm As New frmMostrarErrores
            If Not frm.Abrir(Errores, stMensaje, True) = Windows.Forms.DialogResult.Yes Then
                Exit Sub
            End If
        End If

        Dim data As New stDatosDAADesdeAlbaran()
        data.IDContador = advContador.Text
        data.RegistrosEmpresas.Add(mIDAlbaran.ToString(), guid)
        data.DireccionEntrega = Nz(cmbEntrega.Value, 0)
        data.DireccionDestino = Nz(cmbDestino.Value, 0)
        data.TipoEnvioDAA = Nz(cmbTipoEnvioDAA.Value, 0)
        data.Aduana = Nz(cmbAduana.Value, String.Empty)

        Result = ExpertisApp.ExecuteTask(Of stDatosDAADesdeAlbaran, stCrearDAAInfoResult)(AddressOf BdgDAACabecera.CrearDAAAlbaran, data)
        If Not Result Is Nothing AndAlso Length(Result.NDAA) > 0 Then
            If ExpertisApp.GenerateMessage("Se ha generado el DAA Nº |. ¿Desea cargar su mantenimiento?", MessageBoxButtons.YesNo, MessageBoxIcon.Information, Result.NDAA) = DialogResult.Yes Then
                ExpertisApp.OpenForm("BDGDAA", New StringFilterItem("NDAA", FilterOperator.Equal, Result.NDAA))
            End If
        ElseIf Not Result Is Nothing AndAlso Length(Result.ErrorMessage) > 0 Then
            ExpertisApp.GenerateMessage("Se ha producido un error en la generación: |. ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Result.ErrorMessage)
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub GenerarDAAPedido()
        Dim guid As Guid = ExpertisApp.GetConnectionInfo().IDDataBase
        Dim htregistro As New RegistroEmpresaInfo
        htregistro.Add(mIDPedido.ToString(), guid)

        If Nz(cmbTipoEnvioDAA.Value, -1) = -1 Then
            ExpertisApp.GenerateMessage("Debe indicar el Tipo de Envío", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        'COMPROBAR DATOS PREVIOS
        Dim StValidar As New BdgDAALinea.StValidarDAALineas(enumOrigenDAA.Pedido, htregistro, cmbTipoEnvioDAA.Value, "IDPedido", CN_VistaDAAPedido)
        'Dim stMensaje As String = ExpertisApp.ExecuteTask(Of BdgDAALinea.StValidarDAALineas, String)(AddressOf BdgDAALinea.ValidarDAALineas, StValidar)
        'If Length(stMensaje) > 0 Then
        '    stMensaje = stMensaje & "LOS ARTICULOS MENCIONADOS NO SE INCLUIRAN EN EL DAA." & vbCrLf
        '    stMensaje = stMensaje & "¿Desea continuar?"
        '    If Not ExpertisApp.GenerateMessage(stMensaje, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
        '        Exit Sub
        '    End If
        'End If
        Dim Errores() As ClassErrors = ExpertisApp.ExecuteTask(Of BdgDAALinea.StValidarDAALineas, ClassErrors())(AddressOf BdgDAALinea.ValidarDAALineas, StValidar)
        If Not Errores Is Nothing AndAlso Errores.Length > 0 Then
            Dim stMensaje As String = ExpertisApp.Traslate("Se han encontrado los siguientes Errores. ")
            stMensaje = stMensaje & ExpertisApp.Traslate("¿Desea continuar?")
            Dim frm As New frmMostrarErrores
            If Not frm.Abrir(Errores, stMensaje, True) = Windows.Forms.DialogResult.Yes Then
                Exit Sub
            End If
        End If

        Dim data As New stDatosDAADesdePedido()
        data.IDContador = advContador.Text
        data.RegistrosEmpresas.Add(mIDPedido.ToString(), guid)
        data.DireccionEntrega = Nz(cmbEntrega.Value, 0)
        data.DireccionDestino = Nz(cmbDestino.Value, 0)
        data.TipoEnvioDAA = Nz(cmbTipoEnvioDAA.Value, 0)
        data.Aduana = Nz(cmbAduana.Value, String.Empty)

        Result = ExpertisApp.ExecuteTask(Of stDatosDAADesdePedido, stCrearDAAInfoResult)(AddressOf BdgDAACabecera.CrearDAAPedido, data)
        If Not Result Is Nothing AndAlso Length(Result.NDAA) > 0 Then
            If ExpertisApp.GenerateMessage("Se ha generado el DAA Nº |. ¿Desea cargar su mantenimiento?", MessageBoxButtons.YesNo, MessageBoxIcon.Information, Result.NDAA) = DialogResult.Yes Then
                ExpertisApp.OpenForm("BDGDAA", New StringFilterItem("NDAA", FilterOperator.Equal, Result.NDAA))
            End If
        ElseIf Not Result Is Nothing AndAlso Length(Result.ErrorMessage) > 0 Then
            ExpertisApp.GenerateMessage("Se ha producido un error en la generación: |. ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Result.ErrorMessage)
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub


    Private Sub advContador_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advContador.SetPredefinedFilter
        e.Filter.Add("Entidad", "BdgDAACabecera")
    End Sub

    Private Function GetContador() As String
        Dim f As New Filter
        f.Add("Entidad", "BdgDAACabecera")
        f.Add("Predeterminado", True)
        Dim dttent As DataTable = New EntidadContador().Filter(f)
        If Not dttent Is Nothing AndAlso dttent.Rows.Count > 0 Then
            Return dttent.Rows(0)("IDContador")
        End If
        Return String.Empty
    End Function

    Private Sub cmbTipoEnvioDAA_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTipoEnvioDAA.Validated
        If cmbTipoEnvioDAA.Value = enumTipoEnvioDAA.EMCSInterno Then
            Me.Frame2.Visible = False
        Else
            Me.Frame2.Visible = True
        End If
    End Sub

#End Region

    Private Sub advCliente_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advCliente.SelectionChanged
        If e.Selected Is Nothing OrElse e.Selected.Rows.Count = 0 Then Return
        IDCliente = e.Selected.Rows(0)("IDCliente")
    End Sub
End Class
