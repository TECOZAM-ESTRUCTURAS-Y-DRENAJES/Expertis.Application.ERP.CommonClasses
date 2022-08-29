Public Class frmAddInformacionTarjeta

#Region " Propiedades "

    Public Property NumeroTarjeta() As String
        Get
            Return Me.txtNumeroTarjeta.Text & String.Empty
        End Get
        Set(ByVal value As String)
            Me.txtNumeroTarjeta.Text = value
        End Set
    End Property

    Public Property Voucher() As String
        Get
            Return Me.txtVoucher.Text & String.Empty
        End Get
        Set(ByVal value As String)
            Me.txtVoucher.Text = value
        End Set
    End Property

    Public Property IDBancoPropio() As String
        Get
            Return Me.AdvIDBancoPropio.Value & String.Empty
        End Get
        Set(ByVal value As String)
            Me.AdvIDBancoPropio.Value = value
            Me.AdvIDBancoPropio.Enabled = (Length(Me.AdvIDBancoPropio.Value) = 0)
        End Set
    End Property


    Protected mReadOnly As Boolean
    Public Property SoloLectura() As Boolean
        Get
            Return mReadOnly
        End Get
        Set(ByVal value As Boolean)
            mReadOnly = value
        End Set
    End Property

    Protected mIDTarjeta As Integer?
    Public Property IDTarjeta() As Integer?
        Get
            Return mIDTarjeta
        End Get
        Set(ByVal value As Integer?)
            mIDTarjeta = value
        End Set
    End Property


    Protected mIDCobros(-1) As Integer
    Public Property IDCobros() As Integer()
        Get
            Return mIDCobros
        End Get
        Set(ByVal value As Integer())
            mIDCobros = value
        End Set
    End Property

    Public Property Fecha() As Date
        Get
            Return Nz(Me.cbxFecha.Value, Today)
        End Get
        Set(ByVal value As Date)
            If value <> cnMinDate Then Me.cbxFecha.Value = value
            Me.cbxFecha.Enabled = (Nz(Me.cbxFecha.Value, cnMinDate) = cnMinDate)
        End Set
    End Property


#End Region


#Region " Carga del formulario "

    Protected Overridable Sub frmAddInformacionTarjeta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            LoadData()
            SettingForm()
        End If
    End Sub

    Protected Overridable Sub LoadData()
        If Not Me.IDTarjeta Is Nothing Then
            Dim dtTarjeta As DataTable = New Tarjeta().SelOnPrimaryKey(Me.IDTarjeta)
            If dtTarjeta.Rows.Count > 0 Then
                Me.txtNumeroTarjeta.Text = dtTarjeta.Rows(0)("NumeroTarjeta") & String.Empty
                Me.txtVoucher.Text = dtTarjeta.Rows(0)("Voucher") & String.Empty
                If Length(dtTarjeta.Rows(0)("Fecha")) > 0 Then Me.cbxFecha.Value = dtTarjeta.Rows(0)("Fecha")
                Me.AdvIDBancoPropio.Value = dtTarjeta.Rows(0)("IDBancoPropio") & String.Empty
                Me.advIDBancoTarjeta.Value = dtTarjeta.Rows(0)("IDBancoTarjeta") & String.Empty
            End If
        End If
    End Sub

    Protected Overridable Sub SettingForm()
        Me.txtNumeroTarjeta.Enabled = Not mReadOnly
        Me.txtVoucher.Enabled = Not mReadOnly
        If Me.cbxFecha.Enabled Then Me.cbxFecha.Enabled = Not mReadOnly
        If Me.AdvIDBancoPropio.Enabled Then Me.AdvIDBancoPropio.Enabled = Not mReadOnly
        Me.advIDBancoTarjeta.Enabled = Not mReadOnly
    End Sub

#End Region


#Region " Aceptar/Cancelar "

    Protected Overridable Sub cmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Aceptar()
    End Sub

    Protected Overridable Sub Aceptar()
        Me.DialogResult = Windows.Forms.DialogResult.None
        If Me.SoloLectura Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

        If ValidarCamposObligatorios() Then
            Dim datTarjeta As Tarjeta.dataAddInformacionTarjeta
            If Not Me.IDTarjeta Is Nothing Then
                datTarjeta = New Tarjeta.dataAddInformacionTarjeta(IDTarjeta, cbxFecha.Value, Me.txtNumeroTarjeta.Text, Me.txtVoucher.Text & String.Empty, Me.AdvIDBancoPropio.Value, Me.advIDBancoTarjeta.Value & String.Empty)
            Else
                datTarjeta = New Tarjeta.dataAddInformacionTarjeta(Me.IDCobros, cbxFecha.Value, Me.txtNumeroTarjeta.Text, Me.txtVoucher.Text & String.Empty, Me.AdvIDBancoPropio.Value, Me.advIDBancoTarjeta.Value & String.Empty)
            End If
            IDTarjeta = ExpertisApp.ExecuteTask(Of Tarjeta.dataAddInformacionTarjeta, Integer)(AddressOf Tarjeta.AddInformacionTarjeta, datTarjeta)
            If IDTarjeta <> -1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                ExpertisApp.GenerateMessage("Ha ocurrido algún problema al Crear/Modificar los datos de la Tarjeta.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Protected Overridable Function ValidarCamposObligatorios() As Boolean
        ValidarCamposObligatorios = False
        If Length(Me.txtNumeroTarjeta.Text) = 0 Then
            ExpertisApp.GenerateMessage("El Número de Tarjeta es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Nz(cbxFecha.Value, cnMinDate) = cnMinDate Then
            ExpertisApp.GenerateMessage("La Fecha es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Me.IDTarjeta Is Nothing AndAlso (Me.IDCobros Is Nothing OrElse Me.IDCobros.Length = 0) Then
            ExpertisApp.GenerateMessage("Debe indicar la Tarjeta o los Cobros que se van a pagar a través de la misma.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            ValidarCamposObligatorios = True
        End If
    End Function

    Protected Overridable Sub cmbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.Close()
    End Sub

#End Region


End Class