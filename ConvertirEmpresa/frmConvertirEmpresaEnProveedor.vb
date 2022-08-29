Public Class frmConvertirEmpresaEnProveedor
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
    Friend WithEvents FraGeneraCuentasProveedor As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents chkCCEfectos As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkCCProveedor As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkCContableAll As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents pnlCIF As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblCIF As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtCIF As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents AdvContador As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblContador As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmbTipoDocIdentidad As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblGrupoProveedor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtIDGrupoProveedor As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblTipoDocIdent As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim cmbTipoDocIdentidad_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConvertirEmpresaEnProveedor))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.FraGeneraCuentasProveedor = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkCCEfectos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkCCProveedor = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkCContableAll = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.pnlCIF = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtIDGrupoProveedor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblGrupoProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.cmbTipoDocIdentidad = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.LblTipoDocIdent = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvContador = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblContador = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCIF = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCIF = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Panel1.suspendlayout()
        Me.FraGeneraCuentasProveedor.SuspendLayout()
        Me.pnlCIF.suspendlayout()
        CType(Me.cmbTipoDocIdentidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CmbAceptar)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 194)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(304, 47)
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
        'FraGeneraCuentasProveedor
        '
        Me.FraGeneraCuentasProveedor.Controls.Add(Me.chkCCEfectos)
        Me.FraGeneraCuentasProveedor.Controls.Add(Me.chkCCProveedor)
        Me.FraGeneraCuentasProveedor.Controls.Add(Me.chkCContableAll)
        Me.FraGeneraCuentasProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FraGeneraCuentasProveedor.Location = New System.Drawing.Point(3, 106)
        Me.FraGeneraCuentasProveedor.Name = "FraGeneraCuentasProveedor"
        Me.FraGeneraCuentasProveedor.Size = New System.Drawing.Size(304, 88)
        Me.FraGeneraCuentasProveedor.TabIndex = 2
        Me.FraGeneraCuentasProveedor.TabStop = False
        Me.FraGeneraCuentasProveedor.Text = "Cuentas contables a generar "
        '
        'chkCCEfectos
        '
        Me.chkCCEfectos.Location = New System.Drawing.Point(44, 61)
        Me.chkCCEfectos.Name = "chkCCEfectos"
        Me.chkCCEfectos.Size = New System.Drawing.Size(220, 21)
        Me.chkCCEfectos.TabIndex = 2
        Me.chkCCEfectos.Text = "Generar CC. Efectos"
        '
        'chkCCProveedor
        '
        Me.chkCCProveedor.Location = New System.Drawing.Point(44, 42)
        Me.chkCCProveedor.Name = "chkCCProveedor"
        Me.chkCCProveedor.Size = New System.Drawing.Size(220, 21)
        Me.chkCCProveedor.TabIndex = 1
        Me.chkCCProveedor.Text = "Generar CC. Proveedor"
        '
        'chkCContableAll
        '
        Me.chkCContableAll.Location = New System.Drawing.Point(22, 21)
        Me.chkCContableAll.Name = "chkCContableAll"
        Me.chkCContableAll.Size = New System.Drawing.Size(256, 21)
        Me.chkCContableAll.TabIndex = 0
        Me.chkCContableAll.Text = "Generar todas las Cuentas Contables"
        '
        'pnlCIF
        '
        Me.pnlCIF.Controls.Add(Me.txtIDGrupoProveedor)
        Me.pnlCIF.Controls.Add(Me.lblGrupoProveedor)
        Me.pnlCIF.Controls.Add(Me.cmbTipoDocIdentidad)
        Me.pnlCIF.Controls.Add(Me.LblTipoDocIdent)
        Me.pnlCIF.Controls.Add(Me.AdvContador)
        Me.pnlCIF.Controls.Add(Me.lblContador)
        Me.pnlCIF.Controls.Add(Me.lblCIF)
        Me.pnlCIF.Controls.Add(Me.txtCIF)
        Me.pnlCIF.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCIF.Location = New System.Drawing.Point(3, 0)
        Me.pnlCIF.Name = "pnlCIF"
        Me.pnlCIF.Size = New System.Drawing.Size(304, 106)
        Me.pnlCIF.TabIndex = 1
        '
        'txtIDGrupoProveedor
        '
        Me.txtIDGrupoProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDGrupoProveedor.Enabled = False
        Me.txtIDGrupoProveedor.Location = New System.Drawing.Point(112, 53)
        Me.txtIDGrupoProveedor.MaxLength = 25
        Me.txtIDGrupoProveedor.Name = "txtIDGrupoProveedor"
        Me.txtIDGrupoProveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIDGrupoProveedor.Size = New System.Drawing.Size(130, 21)
        Me.txtIDGrupoProveedor.TabIndex = 2
        '
        'lblGrupoProveedor
        '
        Me.lblGrupoProveedor.Location = New System.Drawing.Point(6, 57)
        Me.lblGrupoProveedor.Name = "lblGrupoProveedor"
        Me.lblGrupoProveedor.Size = New System.Drawing.Size(105, 13)
        Me.lblGrupoProveedor.TabIndex = 189
        Me.lblGrupoProveedor.Tag = ""
        Me.lblGrupoProveedor.Text = "Grupo Proveedor"
        '
        'cmbTipoDocIdentidad
        '
        Me.cmbTipoDocIdentidad.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cmbTipoDocIdentidad_DesignTimeLayout.LayoutString = resources.GetString("cmbTipoDocIdentidad_DesignTimeLayout.LayoutString")
        Me.cmbTipoDocIdentidad.DesignTimeLayout = cmbTipoDocIdentidad_DesignTimeLayout
        Me.cmbTipoDocIdentidad.DisabledBackColor = System.Drawing.Color.White
        Me.cmbTipoDocIdentidad.DisplayMember = "Text"
        Me.cmbTipoDocIdentidad.Enabled = False
        Me.cmbTipoDocIdentidad.Location = New System.Drawing.Point(112, 4)
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
        Me.LblTipoDocIdent.Location = New System.Drawing.Point(6, 8)
        Me.LblTipoDocIdent.Name = "LblTipoDocIdent"
        Me.LblTipoDocIdent.Size = New System.Drawing.Size(100, 13)
        Me.LblTipoDocIdent.TabIndex = 187
        Me.LblTipoDocIdent.Text = "Tipo Documento"
        Me.LblTipoDocIdent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvContador
        '
        Me.AdvContador.DisabledBackColor = System.Drawing.Color.White
        Me.AdvContador.EntityName = "EntidadContador"
        Me.AdvContador.Location = New System.Drawing.Point(112, 78)
        Me.AdvContador.Name = "AdvContador"
        Me.AdvContador.PrimaryDataFields = "IDContador"
        Me.AdvContador.SecondaryDataFields = "IDContador"
        Me.AdvContador.Size = New System.Drawing.Size(130, 23)
        Me.AdvContador.TabIndex = 3
        Me.AdvContador.ViewName = "tbEntidadContador"
        '
        'lblContador
        '
        Me.lblContador.Location = New System.Drawing.Point(6, 83)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(60, 13)
        Me.lblContador.TabIndex = 80
        Me.lblContador.Tag = "IdRec=5005;"
        Me.lblContador.Text = "Contador"
        '
        'lblCIF
        '
        Me.lblCIF.Location = New System.Drawing.Point(6, 32)
        Me.lblCIF.Name = "lblCIF"
        Me.lblCIF.Size = New System.Drawing.Size(72, 13)
        Me.lblCIF.TabIndex = 76
        Me.lblCIF.Tag = ""
        Me.lblCIF.Text = "Documento"
        '
        'txtCIF
        '
        Me.txtCIF.DisabledBackColor = System.Drawing.Color.White
        Me.txtCIF.Location = New System.Drawing.Point(112, 28)
        Me.txtCIF.MaxLength = 25
        Me.txtCIF.Name = "txtCIF"
        Me.txtCIF.Size = New System.Drawing.Size(130, 21)
        Me.txtCIF.TabIndex = 1
        '
        'frmConvertirEmpresaEnProveedor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(310, 241)
        Me.Controls.Add(Me.FraGeneraCuentasProveedor)
        Me.Controls.Add(Me.pnlCIF)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmConvertirEmpresaEnProveedor"
        Me.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.Text = "Convertir Empresa en Proveedor"
        Me.Panel1.ResumeLayout(False)
        Me.FraGeneraCuentasProveedor.ResumeLayout(False)
        Me.pnlCIF.ResumeLayout(False)
        Me.pnlCIF.PerformLayout()
        CType(Me.cmbTipoDocIdentidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private blnMarcoAll, blnCIFRepetido As Boolean
    Private infoCContablesCrear As Empresa.infoConvertirEmpresaEnProveedor

#Region " Load "

    Public Function AbrirForm(ByVal TipoDocumento As enumTipoDocIdent, ByVal Documento As String) As Empresa.infoConvertirEmpresaEnProveedor
        cmbTipoDocIdentidad.DataSource = New EnumData("enumTipoDocIdent")
        txtCIF.Text = Documento
        cmbTipoDocIdentidad.Value = TipoDocumento
        ValidaCIF()
        chkCCProveedor.Checked = True

        Me.ShowDialog()
        Return infoCContablesCrear
    End Function

    Private Sub ValidaCIF()
        If Length(cmbTipoDocIdentidad.Value) > 0 AndAlso Length(txtCIF.Text) > 0 Then
            Dim StDatos As New Proveedor.DatosCifRepetido
            StDatos.Documento = txtCIF.Text
            StDatos.TipoDocumento = cmbTipoDocIdentidad.Value
            StDatos.IDProveedor = String.Empty
            StDatos.IDGrupoProveedor = txtIDGrupoProveedor.text & String.Empty
            Dim r As Empresa.DataResultValidacionDocumento = ExpertisApp.ExecuteTask(Of Proveedor.DatosCifRepetido, Empresa.DataResultValidacionDocumento)(AddressOf Empresa.ValidarCIFRepetidoProveedor, StDatos)
            blnCIFRepetido = r.Repetido
            txtCIF.Enabled = blnCIFRepetido
            txtIDGrupoProveedor.Text = r.IDGrupo
        End If
    End Sub

    Private Sub frmConvertirEmpresaEnProveedor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadConfigForm()
        If blnCIFRepetido Then
            ExpertisApp.GenerateMessage("Ya existe un Proveedor con el Documento '{0}.{1}Sólo se permiten Proveedores con el mismo Documento si pertenecen al mismo grupo.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, txtCIF.Text, vbNewLine)
        End If
    End Sub

    Private Sub LoadConfigForm()
        chkCContableAll.Checked = True
    End Sub

#End Region

    Private Sub AdvContador_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvContador.SetPredefinedFilter
        e.Filter.Add("Entidad", FilterOperator.Equal, "Proveedor")
    End Sub

    Private Sub txtCIF_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCIF.Validating
        If Length(txtCIF.Text) = 0 Then txtIDGrupoProveedor.Text = String.Empty
    End Sub

    Private Sub CContable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCCEfectos.CheckedChanged, chkCCProveedor.CheckedChanged
        If Not blnMarcoAll Then
            If chkCCProveedor.Checked And chkCCEfectos.Checked Then
                chkCContableAll.Checked = True
            Else
                chkCContableAll.Checked = False
            End If
        End If
    End Sub

    Private Sub chkCContableAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCContableAll.CheckedChanged
        blnMarcoAll = True
        If chkCContableAll.Checked Then
            chkCCProveedor.Checked = chkCContableAll.Checked
            chkCCEfectos.Checked = chkCContableAll.Checked
        End If
        blnMarcoAll = False
    End Sub

    Private Sub CmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        If Length(txtCIF.Text) > 0 Then
            ValidaCIF()
            If Not blnCIFRepetido Then
                infoCContablesCrear = New Empresa.infoConvertirEmpresaEnProveedor
                infoCContablesCrear.blnCrearCCProveedor = chkCCProveedor.Checked
                infoCContablesCrear.blnCrearCCEfectos = chkCCEfectos.Checked
                infoCContablesCrear.Cif = txtCIF.Text
                infoCContablesCrear.IDGrupoProveedor = txtIDGrupoProveedor.Text
                infoCContablesCrear.IDContador = AdvContador.Text

                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                ExpertisApp.GenerateMessage("Ya existe un Proveedor con el Documento '{0}.{1}Sólo se permiten Proveedores con el mismo Documento si pertenecen al mismo grupo.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, txtCIF.Text, vbNewLine)
            End If
        Else
            ExpertisApp.GenerateMessage("El Documento es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

End Class
