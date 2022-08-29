Public Class frmAddInformacionCheque


#Region " Propiedades "

    Public Property NumeroCheque() As String
        Get
            Return Me.txtNumeroCheque.Text & String.Empty
        End Get
        Set(ByVal value As String)
            Me.txtNumeroCheque.Text = value
        End Set
    End Property

    Public Property NombreCheque() As String
        Get
            Return Me.txtNombreCheque.Text & String.Empty
        End Get
        Set(ByVal value As String)
            Me.txtNombreCheque.Text = value
        End Set
    End Property

    Public Property DireccionCheque() As String
        Get
            Return Me.txtDireccionCheque.Text & String.Empty
        End Get
        Set(ByVal value As String)
            Me.txtDireccionCheque.Text = value
        End Set
    End Property

    Public Property IDBancoCheque() As String
        Get
            Return Me.advIDBancoCheque.Value & String.Empty
        End Get
        Set(ByVal value As String)
            Me.advIDBancoCheque.Value = value
        End Set
    End Property

    Public Property TelefonoCheque() As String
        Get
            Return Me.txtTelefCheque.Text & String.Empty
        End Get
        Set(ByVal value As String)
            Me.txtTelefCheque.Text = value
        End Set
    End Property

    Public Property NumeroCuentaCheque() As String
        Get
            Return Me.txtNumCuentaCheque.Text & String.Empty
        End Get
        Set(ByVal value As String)
            Me.txtNumCuentaCheque.Text = value
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


    Protected mIDCheque As Integer?
    Public Property IDCheque() As Integer?
        Get
            Return mIDCheque
        End Get
        Set(ByVal value As Integer?)
            mIDCheque = value
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

    Protected Overridable Sub frmAddInformacionCheque_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            LoadData()
            SettingForm()
        End If
    End Sub

    Protected Overridable Sub LoadData()
        If Not Me.IDCheque Is Nothing Then
            Dim dtCheque As DataTable = New Cheque().SelOnPrimaryKey(Me.IDCheque)
            If dtCheque.Rows.Count > 0 Then
                Me.txtNombreCheque.Text = dtCheque.Rows(0)("NombreCheque") & String.Empty
                Me.txtDireccionCheque.Text = dtCheque.Rows(0)("DireccionCheque") & String.Empty
                Me.advIDBancoCheque.Value = dtCheque.Rows(0)("IDBancoCheque") & String.Empty
                Me.txtNumeroCheque.Text = dtCheque.Rows(0)("NumeroCheque") & String.Empty
                Me.txtTelefCheque.Text = dtCheque.Rows(0)("TelefCheque") & String.Empty
                Me.txtNumCuentaCheque.Text = dtCheque.Rows(0)("NumCuentaCheque") & String.Empty
                If Length(dtCheque.Rows(0)("Fecha")) > 0 Then Me.cbxFecha.Value = dtCheque.Rows(0)("Fecha")

                Me.AdvIDBancoPropio.Value = dtCheque.Rows(0)("IDBancoPropio") & String.Empty
            End If
        End If
    End Sub

    Protected Overridable Sub SettingForm()
        Me.txtNombreCheque.Enabled = Not mReadOnly
        Me.txtDireccionCheque.Enabled = Not mReadOnly
        Me.advIDBancoCheque.Enabled = Not mReadOnly
        Me.txtNumeroCheque.Enabled = Not mReadOnly
        Me.txtTelefCheque.Enabled = Not mReadOnly
        Me.txtNumCuentaCheque.Enabled = Not mReadOnly

        If Me.cbxFecha.Enabled Then Me.cbxFecha.Enabled = Not mReadOnly
        If Me.AdvIDBancoPropio.Enabled Then Me.AdvIDBancoPropio.Enabled = Not mReadOnly
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
            Dim datCheque As Cheque.dataAddInformacionCheque
            If Not Me.IDCheque Is Nothing Then
                datCheque = New Cheque.dataAddInformacionCheque(IDCheque, cbxFecha.Value, Me.txtNumeroCheque.Text, Me.txtNombreCheque.Text & String.Empty, _
                                                                Me.txtDireccionCheque.Text & String.Empty, Me.txtTelefCheque.Text & String.Empty, _
                                                                   Me.txtNumCuentaCheque.Text & String.Empty, Me.advIDBancoCheque.Value, Me.AdvIDBancoPropio.Value)
            Else
                datCheque = New Cheque.dataAddInformacionCheque(Me.IDCobros, cbxFecha.Value, Me.txtNumeroCheque.Text, Me.txtNombreCheque.Text & String.Empty, _
                                                                   Me.txtDireccionCheque.Text & String.Empty, Me.txtTelefCheque.Text & String.Empty, _
                                                                   Me.txtNumCuentaCheque.Text & String.Empty, Me.advIDBancoCheque.Value, Me.AdvIDBancoPropio.Value)

            End If
            IDCheque = ExpertisApp.ExecuteTask(Of Cheque.dataAddInformacionCheque, Integer)(AddressOf Cheque.AddInformacionCheque, datCheque)
            If IDCheque <> -1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                ExpertisApp.GenerateMessage("Ha ocurrido algún problema al Crear/Modificar los datos del Cheque.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If
    End Sub

    Protected Overridable Function ValidarCamposObligatorios() As Boolean
        ValidarCamposObligatorios = False
        If Length(txtNumeroCheque.Text) = 0 Then
            ExpertisApp.GenerateMessage("El Número del Cheque es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Length(advIDBancoCheque.Value) = 0 Then
            ExpertisApp.GenerateMessage("El Banco del Cheque es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Nz(cbxFecha.Value, cnMinDate) = cnMinDate Then
            ExpertisApp.GenerateMessage("La Fecha es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Me.IDCheque Is Nothing AndAlso (Me.IDCobros Is Nothing OrElse Me.IDCobros.Length = 0) Then
            ExpertisApp.GenerateMessage("Debe indicar el Cheque o los Cobros que se van a pagar a través del mismo.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            ValidarCamposObligatorios = True
        End If
    End Function

    Protected Overridable Sub cmbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.Close()
    End Sub

#End Region

End Class