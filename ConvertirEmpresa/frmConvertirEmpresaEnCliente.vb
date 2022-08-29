Public Class frmConvertirEmpresaEnCliente
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
    Friend WithEvents pnlCIF As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblCIF As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtCIF As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents FraGeneraCuentasCliente As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents CmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents chkCCEGestionCobros As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkCCECliente As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkCCCliente As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents AdvContador As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblContador As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmbTipoDocIdentidad As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents LblTipoDocIdent As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblGrupoCliente As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtIDGrupoCliente As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents chkCContableAll As Solmicro.Expertis.Engine.UI.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim cmbTipoDocIdentidad_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConvertirEmpresaEnCliente))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.pnlCIF = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblGrupoCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.cmbTipoDocIdentidad = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.LblTipoDocIdent = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvContador = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblContador = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCIF = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCIF = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FraGeneraCuentasCliente = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkCCEGestionCobros = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkCCECliente = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkCCCliente = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkCContableAll = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.txtIDGrupoCliente = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Panel1.suspendlayout()
        Me.pnlCIF.suspendlayout()
        CType(Me.cmbTipoDocIdentidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraGeneraCuentasCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CmbAceptar)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 218)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(306, 47)
        Me.Panel1.TabIndex = 3
        '
        'CmbAceptar
        '
        Me.CmbAceptar.Location = New System.Drawing.Point(46, 9)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmbAceptar.TabIndex = 0
        Me.CmbAceptar.Text = "Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(146, 9)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 1
        Me.cmbCancelar.Text = "Cancelar"
        '
        'pnlCIF
        '
        Me.pnlCIF.Controls.Add(Me.txtIDGrupoCliente)
        Me.pnlCIF.Controls.Add(Me.lblGrupoCliente)
        Me.pnlCIF.Controls.Add(Me.cmbTipoDocIdentidad)
        Me.pnlCIF.Controls.Add(Me.LblTipoDocIdent)
        Me.pnlCIF.Controls.Add(Me.AdvContador)
        Me.pnlCIF.Controls.Add(Me.lblContador)
        Me.pnlCIF.Controls.Add(Me.lblCIF)
        Me.pnlCIF.Controls.Add(Me.txtCIF)
        Me.pnlCIF.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCIF.Location = New System.Drawing.Point(3, 0)
        Me.pnlCIF.Name = "pnlCIF"
        Me.pnlCIF.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlCIF.Size = New System.Drawing.Size(306, 111)
        Me.pnlCIF.TabIndex = 1
        '
        'lblGrupoCliente
        '
        Me.lblGrupoCliente.Location = New System.Drawing.Point(7, 59)
        Me.lblGrupoCliente.Name = "lblGrupoCliente"
        Me.lblGrupoCliente.Size = New System.Drawing.Size(86, 13)
        Me.lblGrupoCliente.TabIndex = 187
        Me.lblGrupoCliente.Tag = ""
        Me.lblGrupoCliente.Text = "Grupo Cliente"
        '
        'cmbTipoDocIdentidad
        '
        Me.cmbTipoDocIdentidad.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cmbTipoDocIdentidad_DesignTimeLayout.LayoutString = resources.GetString("cmbTipoDocIdentidad_DesignTimeLayout.LayoutString")
        Me.cmbTipoDocIdentidad.DesignTimeLayout = cmbTipoDocIdentidad_DesignTimeLayout
        Me.cmbTipoDocIdentidad.DisabledBackColor = System.Drawing.Color.White
        Me.cmbTipoDocIdentidad.DisplayMember = "Text"
        Me.cmbTipoDocIdentidad.Enabled = False
        Me.cmbTipoDocIdentidad.Location = New System.Drawing.Point(110, 6)
        Me.cmbTipoDocIdentidad.Name = "cmbTipoDocIdentidad"
        Me.cmbTipoDocIdentidad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTipoDocIdentidad.SelectedIndex = -1
        Me.cmbTipoDocIdentidad.SelectedItem = Nothing
        Me.cmbTipoDocIdentidad.Size = New System.Drawing.Size(185, 21)
        Me.cmbTipoDocIdentidad.TabIndex = 0
        Me.cmbTipoDocIdentidad.ValueMember = "Value"
        '
        'LblTipoDocIdent
        '
        Me.LblTipoDocIdent.Location = New System.Drawing.Point(7, 10)
        Me.LblTipoDocIdent.Name = "LblTipoDocIdent"
        Me.LblTipoDocIdent.Size = New System.Drawing.Size(100, 13)
        Me.LblTipoDocIdent.TabIndex = 185
        Me.LblTipoDocIdent.Text = "Tipo Documento"
        Me.LblTipoDocIdent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvContador
        '
        Me.AdvContador.DisabledBackColor = System.Drawing.Color.White
        Me.AdvContador.EntityName = "EntidadContador"
        Me.AdvContador.Location = New System.Drawing.Point(110, 80)
        Me.AdvContador.Name = "AdvContador"
        Me.AdvContador.PrimaryDataFields = "IDContador"
        Me.AdvContador.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AdvContador.SecondaryDataFields = "IDContador"
        Me.AdvContador.Size = New System.Drawing.Size(130, 23)
        Me.AdvContador.TabIndex = 3
        Me.AdvContador.ViewName = "tbEntidadContador"
        '
        'lblContador
        '
        Me.lblContador.Location = New System.Drawing.Point(7, 85)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(60, 13)
        Me.lblContador.TabIndex = 78
        Me.lblContador.Tag = "IdRec=5005;"
        Me.lblContador.Text = "Contador"
        '
        'lblCIF
        '
        Me.lblCIF.Location = New System.Drawing.Point(7, 34)
        Me.lblCIF.Name = "lblCIF"
        Me.lblCIF.Size = New System.Drawing.Size(72, 13)
        Me.lblCIF.TabIndex = 76
        Me.lblCIF.Tag = ""
        Me.lblCIF.Text = "Documento"
        '
        'txtCIF
        '
        Me.txtCIF.DisabledBackColor = System.Drawing.Color.White
        Me.txtCIF.Location = New System.Drawing.Point(110, 30)
        Me.txtCIF.MaxLength = 25
        Me.txtCIF.Name = "txtCIF"
        Me.txtCIF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCIF.Size = New System.Drawing.Size(130, 21)
        Me.txtCIF.TabIndex = 1
        '
        'FraGeneraCuentasCliente
        '
        Me.FraGeneraCuentasCliente.Controls.Add(Me.chkCCEGestionCobros)
        Me.FraGeneraCuentasCliente.Controls.Add(Me.chkCCECliente)
        Me.FraGeneraCuentasCliente.Controls.Add(Me.chkCCCliente)
        Me.FraGeneraCuentasCliente.Controls.Add(Me.chkCContableAll)
        Me.FraGeneraCuentasCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FraGeneraCuentasCliente.Location = New System.Drawing.Point(3, 111)
        Me.FraGeneraCuentasCliente.Name = "FraGeneraCuentasCliente"
        Me.FraGeneraCuentasCliente.Size = New System.Drawing.Size(306, 107)
        Me.FraGeneraCuentasCliente.TabIndex = 2
        Me.FraGeneraCuentasCliente.TabStop = False
        Me.FraGeneraCuentasCliente.Text = "Cuentas contables a generar "
        '
        'chkCCEGestionCobros
        '
        Me.chkCCEGestionCobros.Location = New System.Drawing.Point(44, 80)
        Me.chkCCEGestionCobros.Name = "chkCCEGestionCobros"
        Me.chkCCEGestionCobros.Size = New System.Drawing.Size(238, 21)
        Me.chkCCEGestionCobros.TabIndex = 3
        Me.chkCCEGestionCobros.Text = "Generar CC. Efectos Gestión Cobros"
        '
        'chkCCECliente
        '
        Me.chkCCECliente.Location = New System.Drawing.Point(44, 61)
        Me.chkCCECliente.Name = "chkCCECliente"
        Me.chkCCECliente.Size = New System.Drawing.Size(220, 21)
        Me.chkCCECliente.TabIndex = 2
        Me.chkCCECliente.Text = "Generar CC. Efectos Cliente"
        '
        'chkCCCliente
        '
        Me.chkCCCliente.Enabled = False
        Me.chkCCCliente.Location = New System.Drawing.Point(44, 42)
        Me.chkCCCliente.Name = "chkCCCliente"
        Me.chkCCCliente.Size = New System.Drawing.Size(220, 21)
        Me.chkCCCliente.TabIndex = 1
        Me.chkCCCliente.Text = "Generar CC. Cliente"
        '
        'chkCContableAll
        '
        Me.chkCContableAll.Location = New System.Drawing.Point(22, 21)
        Me.chkCContableAll.Name = "chkCContableAll"
        Me.chkCContableAll.Size = New System.Drawing.Size(256, 21)
        Me.chkCContableAll.TabIndex = 0
        Me.chkCContableAll.Text = "Generar todas las Cuentas Contables"
        '
        'txtIDGrupoCliente
        '
        Me.txtIDGrupoCliente.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDGrupoCliente.Enabled = False
        Me.txtIDGrupoCliente.Location = New System.Drawing.Point(110, 55)
        Me.txtIDGrupoCliente.MaxLength = 25
        Me.txtIDGrupoCliente.Name = "txtIDGrupoCliente"
        Me.txtIDGrupoCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIDGrupoCliente.Size = New System.Drawing.Size(130, 21)
        Me.txtIDGrupoCliente.TabIndex = 2
        '
        'frmConvertirEmpresaEnCliente
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(312, 265)
        Me.Controls.Add(Me.FraGeneraCuentasCliente)
        Me.Controls.Add(Me.pnlCIF)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmConvertirEmpresaEnCliente"
        Me.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convertir Empresa en Cliente"
        Me.Panel1.ResumeLayout(False)
        Me.pnlCIF.ResumeLayout(False)
        Me.pnlCIF.PerformLayout()
        CType(Me.cmbTipoDocIdentidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraGeneraCuentasCliente.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private blnMarcoAll, blnCIFRepetido As Boolean
    Private infoCContablesCrear As Empresa.infoConvertirEmpresaEnCliente

#Region " Load "

    Public Function AbrirForm(Optional ByVal TipoDocumento As enumTipoDocIdent = enumTipoDocIdent.NIF, Optional ByVal Documento As String = "") As Empresa.infoConvertirEmpresaEnCliente
        cmbTipoDocIdentidad.DataSource = New EnumData("enumTipoDocIdent")
        txtCIF.Text = Documento
        cmbTipoDocIdentidad.Value = TipoDocumento
        ValidaCIF()
        chkCCCliente.Checked = True

        Me.ShowDialog()
        Return infoCContablesCrear
    End Function

    Private Sub ValidaCIF()
        If Length(cmbTipoDocIdentidad.Value) > 0 AndAlso Length(txtCIF.Text) > 0 Then
            Dim StDatos As New Cliente.DataCIFRepetido
            StDatos.Documento = txtCIF.Text
            StDatos.TipoDocumento = cmbTipoDocIdentidad.Value
            StDatos.IDCliente = String.Empty
            StDatos.IDGrupoCliente = txtIDGrupoCliente.Text & String.Empty
            Dim r As Empresa.DataResultValidacionDocumento = ExpertisApp.ExecuteTask(Of Cliente.DataCIFRepetido, Empresa.DataResultValidacionDocumento)(AddressOf Empresa.ValidarCIFRepetidoCliente, StDatos)
            blnCIFRepetido = r.Repetido
            txtCIF.Enabled = blnCIFRepetido
            txtIDGrupoCliente.Text = r.IDGrupo
        End If
    End Sub

    Private Sub frmConvertirEmpresaEnCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadConfigForm()
        If blnCIFRepetido Then
            If Length(txtIDGrupoCliente.Text) > 0 Then
                If ExpertisApp.GenerateMessage("Para poder utilizar el Documento {0} tiene que formar parte del Grupo Cliente {1}{2}. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Information, txtCIF.Text, txtIDGrupoCliente.Text, vbNewLine) = Windows.Forms.DialogResult.No Then
                    Me.Close()
                End If
            Else
                ExpertisApp.GenerateMessage("Ya existe un Cliente con el Documento '{0}'.{1}Sólo se permiten Clientes con el mismo Documento si pertenecen al mismo grupo.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, txtCIF.Text, vbNewLine)
            End If
        End If
    End Sub

    Private Sub LoadConfigForm()
        chkCContableAll.Checked = True
    End Sub

#End Region


    Private Sub AdvContador_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvContador.SetPredefinedFilter
        e.Filter.Add("Entidad", FilterOperator.Equal, "Cliente")
    End Sub

    Private Sub txtCIF_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCIF.Validating
        If Length(txtCIF.Text) = 0 Then txtIDGrupoCliente.Text = String.Empty
    End Sub

    Private Sub CContable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCCECliente.CheckedChanged, chkCCCliente.CheckedChanged, chkCCEGestionCobros.CheckedChanged
        If Not blnMarcoAll Then
            If chkCCCliente.Checked And chkCCECliente.Checked And chkCCEGestionCobros.Checked Then
                chkCContableAll.Checked = True
            Else
                chkCContableAll.Checked = False
            End If
        End If
    End Sub

    Private Sub chkCContableAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCContableAll.CheckedChanged
        blnMarcoAll = True
        If chkCContableAll.Checked Then
            chkCCCliente.Checked = chkCContableAll.Checked
            chkCCECliente.Checked = chkCContableAll.Checked
            chkCCEGestionCobros.Checked = chkCContableAll.Checked
        End If
        blnMarcoAll = False
    End Sub

    Private Sub CmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        If Length(txtCIF.Text) > 0 Then
            ValidaCIF()
            Dim blnOK As Boolean = False
            If Not blnCIFRepetido Then
                blnOK = True
            ElseIf Length(txtIDGrupoCliente.Text) > 0 Then
                If ExpertisApp.GenerateMessage("Para poder utilizar el Documento {0} tiene que formar parte del Grupo Cliente {1}{2}. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Information, txtCIF.Text, txtIDGrupoCliente.Text, vbNewLine) = Windows.Forms.DialogResult.No Then
                    Me.Close()
                Else
                    blnOK = True
                End If
            Else
                ExpertisApp.GenerateMessage("Ya existe un Cliente con el Documento '{0}'.{1}Sólo se permiten Clientes con el mismo Documento si pertenecen al mismo grupo.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, txtCIF.Text, vbNewLine)
            End If
            If blnOK Then
                infoCContablesCrear = New Empresa.infoConvertirEmpresaEnCliente
                infoCContablesCrear.blnCrearCCCliente = chkCCCliente.Checked
                infoCContablesCrear.blnCrearCCEfectosCliente = chkCCECliente.Checked
                infoCContablesCrear.blnCrearCCEGestionCobros = chkCCEGestionCobros.Checked
                infoCContablesCrear.Cif = txtCIF.Text
                infoCContablesCrear.IDGrupoCliente = txtIDGrupoCliente.Text
                infoCContablesCrear.IDContador = AdvContador.Text

                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Else
            ExpertisApp.GenerateMessage("El Documento es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

End Class
