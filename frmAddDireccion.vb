Public Class frmAddDireccion
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.Grid.RelationMode = RelationMode.NoRelation
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
    Friend WithEvents Panel2 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents txtCliente As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblCif As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtCif As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents ulDescCliente As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents lblSoloAlquiler As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Grid_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddDireccion))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.Panel2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.ulDescCliente = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.txtCif = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCif = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCliente = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblSoloAlquiler = New Solmicro.Expertis.Engine.UI.Label
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1.suspendlayout()
        Me.Panel2.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 292)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(710, 46)
        Me.Panel1.TabIndex = 0
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(366, 7)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(102, 33)
        Me.cmbCancelar.TabIndex = 3
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(255, 7)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(102, 33)
        Me.cmbAceptar.TabIndex = 2
        Me.cmbAceptar.Text = "Guardar datos"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ulDescCliente)
        Me.Panel2.Controls.Add(Me.txtCif)
        Me.Panel2.Controls.Add(Me.lblCif)
        Me.Panel2.Controls.Add(Me.lblCliente)
        Me.Panel2.Controls.Add(Me.txtCliente)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(710, 63)
        Me.Panel2.TabIndex = 2
        '
        'ulDescCliente
        '
        Me.ulDescCliente.Location = New System.Drawing.Point(217, 8)
        Me.ulDescCliente.Name = "ulDescCliente"
        Me.ulDescCliente.Size = New System.Drawing.Size(474, 21)
        Me.ulDescCliente.TabIndex = 4
        '
        'txtCif
        '
        Me.txtCif.DisabledBackColor = System.Drawing.Color.White
        Me.txtCif.Enabled = False
        Me.txtCif.Location = New System.Drawing.Point(76, 34)
        Me.txtCif.Name = "txtCif"
        Me.txtCif.Size = New System.Drawing.Size(107, 21)
        Me.txtCif.TabIndex = 3
        Me.txtCif.TabStop = False
        '
        'lblCif
        '
        Me.lblCif.Location = New System.Drawing.Point(18, 32)
        Me.lblCif.Name = "lblCif"
        Me.lblCif.Size = New System.Drawing.Size(37, 13)
        Me.lblCif.TabIndex = 2
        Me.lblCif.Text = "C.I.F."
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(18, 10)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "Cliente"
        '
        'txtCliente
        '
        Me.txtCliente.DisabledBackColor = System.Drawing.Color.White
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(76, 8)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(139, 21)
        Me.txtCliente.TabIndex = 0
        Me.txtCliente.TabStop = False
        '
        'lblSoloAlquiler
        '
        Me.lblSoloAlquiler.AutoSize = False
        Me.lblSoloAlquiler.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblSoloAlquiler.Location = New System.Drawing.Point(0, 260)
        Me.lblSoloAlquiler.Name = "lblSoloAlquiler"
        Me.lblSoloAlquiler.Size = New System.Drawing.Size(710, 32)
        Me.lblSoloAlquiler.TabIndex = 4
        Me.lblSoloAlquiler.Text = "Marcar la columna ""Dirección de Factura"" cuando la dirección de facturación de la" & _
            " Obra sea diferente de la dirección de factura predeterminada del cliente."
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("ClienteDir", "ClienteDireccion", "IDCliente", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Tipo", "Tipo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("RazonSocial", "RazonSocial"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("CifCliente", "CifCliente"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Direccion", "Direccion"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("CodPostal", "CodPostal"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Poblacion", "Poblacion"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Provincia", "Provincia"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDPais", "IDPais"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Telefono", "Telefono"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Fax", "Fax"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Email", "Email")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDPais", "Pais", "IDPais", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescPais", "DescPais")}))})
        Grid_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_0.Instance"), Object)
        Grid_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {Grid_DesignTimeLayout_Reference_0})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = ""
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.FrozenColumns = 5
        Me.Grid.ImageSource = Janus.Windows.GridEX.ImageSource.InternalImageList
        Me.Grid.Location = New System.Drawing.Point(0, 63)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(710, 197)
        Me.Grid.TabIndex = 5
        Me.Grid.ViewName = ""
        '
        'frmAddDireccion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(710, 338)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.lblSoloAlquiler)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmAddDireccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta dirección de envío"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.AllRecords
        End Get
    End Property

    Private Const cnLABELALQUILER As String = "Marcar la columna 'Dirección de Factura' cuando la dirección de facturación del Alquiler sea diferente de la dirección de factura predeterminada del cliente."
    Private Const cnLABELPRESUPEMPRESA As String = "Marcar la columna 'Dirección de Factura' cuando la dirección de facturación del Presupuesto Obra es diferente de la dirección de factura predeterminada de la empresa."
    Private Const cnLABELPRESUPCLIENTE As String = "Marcar la columna 'Dirección de Factura' cuando la dirección de facturación del Presupuesto Obra es diferente de la dirección de factura predeterminada del cliente."

    Public Enum enumTipoAlquiler
        SinAlquiler = 0
        Alquiler = 1
        AlquilerPresup = 2
    End Enum

    Public Class AddDireccionInfo
        Public strIDCliente, strDescCliente, strCifCliente, strNObra As String
        Public strIDEmpresa, strDescEmpresa, strCifEmpresa As String
        Public intIDObra, intIDPresup As Integer
        Public TipoAlquiler As enumTipoAlquiler = enumTipoAlquiler.SinAlquiler
        Public TipoDireccion As enumcdTipoDireccion = enumcdTipoDireccion.cdDireccionEnvio
    End Class

    Private mstrIDPais, mstrDescPais, mstrIDAlmacen, mstrNObra As String
    Private mintTipo, mintIDObra, mintIDDireccion, mintIDPresup As Integer
    Private mblnAlquiler, mblnEmpresa As Boolean
    Private strCampo As String = "IDCliente"
    Private strTabla As String = "vFrmAddDireccionVolcarDatosCliente"

#Region " Load "

    Public Sub OpenAddDireccion(ByVal info As AddDireccionInfo, ByRef intIDireccion As Integer, _
                                Optional ByRef strIDAlmacen As String = "")

        '// NOTA: En el ShowDialog se hace el RetrieveData, que recupera TODOS los campos de la tabla 
        '// principal de la vista para poder modificar los datos del grid.
        '// En ese momento el grid debe estar ya configurado, por lo que se ha implementado este método
        '// con el fin de obtener los valores de la propiedades necesarias y poder configurar el grid 
        '// antes de que se haga el Load.

        With Grid
            If info.TipoAlquiler <> enumTipoAlquiler.AlquilerPresup Then
                .EntityName = "ClienteDireccion"
                .ViewName = "vfrmMntoClienteDireccion"
            Else
                .EntityName = "ObraPresupDireccion"
                .ViewName = "vfrmMntoObraPresupDireccion"
            End If

            If Length(info.strIDCliente) > 0 Then
                Dim c As New Cliente
                Dim dtCliente As DataTable = c.SelOnPrimaryKey(info.strIDCliente)
                If Not dtCliente Is Nothing AndAlso dtCliente.Rows.Count > 0 Then
                    If Length(dtCliente.Rows(0)("IDGrupoCliente")) > 0 Then
                        Dim strIDGrupoCliente As String = String.Empty
                        Select Case info.TipoDireccion
                            Case enumcdTipoDireccion.cdDireccionEnvio
                                If Nz(dtCliente.Rows(0)("GrupoDireccion"), False) Then
                                    strIDGrupoCliente = dtCliente.Rows(0)("IDGrupoCliente")
                                End If
                            Case enumcdTipoDireccion.cdDireccionFactura
                                If Nz(dtCliente.Rows(0)("GrupoFactura"), False) Then
                                    strIDGrupoCliente = dtCliente.Rows(0)("IDGrupoCliente")
                                End If
                        End Select
                        If Length(strIDGrupoCliente) > 0 Then
                            dtCliente = c.SelOnPrimaryKey(strIDGrupoCliente)
                            If Not dtCliente Is Nothing AndAlso dtCliente.Rows.Count > 0 Then
                                info.strIDCliente = dtCliente.Rows(0)("IDCliente")
                                info.strDescCliente = dtCliente.Rows(0)("DescCliente")
                                info.strCifCliente = dtCliente.Rows(0)("CifCliente")
                            End If
                        End If
                    End If
                End If
                txtCliente.Text = info.strIDCliente : lblCliente.Text = "Cliente"
            Else
                mblnEmpresa = True
                txtCliente.Text = info.strIDEmpresa : lblCliente.Text = "Empresa"
                .Columns("ClienteDir").Visible = False
            End If

            ulDescCliente.Text = IIf(Length(info.strDescCliente) > 0, info.strDescCliente, info.strDescEmpresa)
            txtCif.Text = IIf(Length(info.strCifCliente) > 0, info.strCifCliente, info.strCifEmpresa)
            mintTipo = info.TipoDireccion
            mintIDObra = info.intIDObra
            mstrNObra = info.strNObra
            mblnAlquiler = (info.TipoAlquiler <> enumTipoAlquiler.SinAlquiler)
            mintIDPresup = info.intIDPresup

            Dim f As New Filter
            If mblnEmpresa Then
                strCampo = "IDEmpresa" : strTabla = "vFrmAddDireccionVolcarDatosEmpresa"
            Else
                f.Add(New StringFilterItem("IDCliente", info.strIDCliente))
            End If
            Select Case info.TipoDireccion
                Case enumcdTipoDireccion.cdDireccionEnvio
                    f.Add(New BooleanFilterItem("Envio", True))
                    Me.Text = "Alta Dirección de Envío"
                Case enumcdTipoDireccion.cdDireccionFactura
                    f.Add(New BooleanFilterItem("Factura", True))
                    Me.Text = "Alta Dirección Facturación"
                Case enumcdTipoDireccion.cdDireccionGiro
                    f.Add(New BooleanFilterItem("Giro", True))
                    Me.Text = "Alta Dirección Giro"
            End Select
            If mblnAlquiler Then
                If info.TipoAlquiler = enumTipoAlquiler.Alquiler Then
                    lblSoloAlquiler.Text = cnLABELALQUILER
                Else
                    lblSoloAlquiler.Text = IIf(Length(info.strIDCliente) > 0, cnLABELPRESUPCLIENTE, cnLABELPRESUPEMPRESA)
                End If
                If mintIDObra > 0 Then f.Add(New NumberFilterItem("IDObra", mintIDObra))
                If mintIDPresup > 0 Then f.Add(New NumberFilterItem("IDPresup", mintIDPresup))

                .Columns("DireccionFactura").Visible = True
                .Columns("PredeterminadaEnvio").Visible = True
                .Columns("Factura").Visible = False
                .Columns("PredeterminadaFactura").Visible = False
                .Columns("Giro").Visible = False
                .Columns("PredeterminadaGiro").Visible = False
            End If
            .Filter = f

            Me.ShowDialog()

            intIDireccion = mintIDDireccion
            strIDAlmacen = mstrIDAlmacen
        End With
    End Sub

    Private Sub frmAddDireccion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadERPData()
        LoadTratamientoAlquiler()
    End Sub

    Private Sub LoadTratamientoAlquiler()
        lblSoloAlquiler.Visible = mblnAlquiler
        lblSoloAlquiler.BackColor = System.Drawing.Color.LightGoldenrodYellow

        With Grid
            .Columns("DireccionFactura").Visible = mblnAlquiler
            .Columns("IDCAE").Visible = Not mblnAlquiler
        End With
    End Sub

    Private Sub LoadERPData()
        If Len(txtCliente.Text) > 0 Then
            Dim a As New BE.DataEngine
            Dim dt As DataTable = a.Filter("VfrmCiClientePais", New StringFilterItem("IDCliente", txtCliente.Text))
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                mstrIDPais = dt.Rows(0)("IDPais")
                mstrDescPais = dt.Rows(0)("DescPais")
            End If
        Else
            cmbCancelar.Enabled = False
        End If
    End Sub

#End Region

#Region " Grid "

    Private Sub Grid_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles Grid.AdvSearchSetPredefinedFilter
        Select Case e.Key
            Case "ClienteDir"
                If mblnEmpresa Then
                    e.Filter.Add("IDEmpresa", FilterOperator.Equal, txtCliente.Text)
                Else
                    e.Filter.Add("IDCliente", FilterOperator.Equal, txtCliente.Text)
                End If
        End Select
    End Sub

    Private Sub Grid_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.GotFocus
        With Grid
            If mintIDObra <> 0 Then .Columns("IDObra").DefaultValue = mintIDObra
            If mintIDPresup <> 0 Then .Columns("IDPresup").DefaultValue = mintIDPresup
            If Not mblnEmpresa Then .Columns("IDCliente").DefaultValue = txtCliente.Text
            .Columns("RazonSocial").DefaultValue = ulDescCliente.Text
            .Columns("CifCliente").DefaultValue = txtCif.Text
            Select Case mintTipo
                Case CInt(enumcdTipoDireccion.cdDireccionEnvio)
                    .Columns("Envio").DefaultValue = True
                Case CInt(enumcdTipoDireccion.cdDireccionFactura)
                    .Columns("Factura").DefaultValue = True
                Case CInt(enumcdTipoDireccion.cdDireccionGiro)
                    .Columns("Giro").DefaultValue = True
            End Select
            .Columns("IDPais").DefaultValue = mstrIDPais
            .Columns("DescPais").DefaultValue = mstrDescPais
        End With
    End Sub

    Private Sub Grid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.DoubleClick
        With Grid
            If .GetValue("IDDireccion") Is Nothing OrElse .GetValue("IDDireccion") Is System.DBNull.Value Then
                ExpertisApp.GenerateMessage("Guarde la dirección antes de volcarla al mantenimiento origen", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If ExpertisApp.GenerateMessage("Se volcará la línea seleccionada en el mantenimiento origen. ¿Desea continuar.?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                mintIDDireccion = .GetValue("IDDireccion")
                If mblnAlquiler Then mstrIDAlmacen = .GetValue("IDAlmacen") & String.Empty
                Me.Close()
            End If
        End With
    End Sub

    Private Sub Grid_Validacion(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Grid.AddingRecord, Grid.UpdatingRecord
        If mblnAlquiler Then
            With Grid
                If Length(.GetValue("CifCliente")) = 0 OrElse Length(.GetValue("IDPais")) = 0 OrElse Length(.GetValue("Direccion")) = 0 OrElse Not .GetValue("Envio") Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("El CIF, la Dirección, Marca Envío y el País son Datos Obligatorios.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            End With
        End If
    End Sub

    Private Sub Grid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.Click
        With Grid
            Dim hit As GridArea = .HitTest()
            If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                Dim c As GridEXColumn = .ColumnFromPoint()
                If Not IsNothing(c) Then
                    Select Case c.Key
                        Case "VolcarDatos"
                            VolcarDatosGenerales()
                    End Select
                End If
            End If
        End With
    End Sub

    Private Sub VolcarDatosGenerales()
        Dim f As New Filter
        f.Add(New StringFilterItem(strCampo, txtCliente.Text))
        Dim dt As DataTable = New BE.DataEngine().Filter(strTabla, f)
        If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
            Grid.SetValue("RazonSocial", dt.Rows(0)("RazonSocial"))
            Grid.SetValue("CifCliente", dt.Rows(0)("CifCliente"))
            Grid.SetValue("Direccion", dt.Rows(0)("Direccion"))
            Grid.SetValue("CodPostal", dt.Rows(0)("CodPostal"))
            Grid.SetValue("Poblacion", dt.Rows(0)("Poblacion"))
            Grid.SetValue("Provincia", dt.Rows(0)("Provincia"))
            Grid.SetValue("IDPais", dt.Rows(0)("IDPais"))
            Grid.SetValue("DescPais", dt.Rows(0)("DescPais"))
            Grid.SetValue("Telefono", dt.Rows(0)("Telefono"))
            Grid.SetValue("Fax", dt.Rows(0)("Fax"))
            Grid.SetValue("Email", dt.Rows(0)("Email"))
            If mblnAlquiler Then Grid.SetValue("Envio", True)
        End If
    End Sub

#End Region

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Dim dtDirecciones As DataTable = Grid.DataSource
        If dtDirecciones Is Nothing Then
            If mblnAlquiler Then
                ExpertisApp.GenerateMessage("Debe haber al menos una dirección de Envío.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                ExpertisApp.GenerateMessage("Debe haber al menos una dirección.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If

        Dim dv As DataView = dtDirecciones.DefaultView
        dv.RowStateFilter = DataViewRowState.CurrentRows
        If dv Is Nothing OrElse dv.Count = 0 Then
            ExpertisApp.GenerateMessage("Debe haber al menos una dirección predeterminada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf Not mblnAlquiler Then
            Dim tienePredetEnvio As Boolean
            Dim tienePredetFactura As Boolean
            Dim tienePredetGiro As Boolean
            For Each drv As DataRowView In dv
                If Not drv.Row.IsNull("PredeterminadaEnvio") AndAlso drv("PredeterminadaEnvio") Then
                    tienePredetEnvio = True
                End If
                If Not drv.Row.IsNull("PredeterminadaFactura") AndAlso drv("PredeterminadaFactura") Then
                    tienePredetFactura = True
                End If
                If Not drv.Row.IsNull("PredeterminadaGiro") AndAlso drv("PredeterminadaGiro") Then
                    tienePredetGiro = True
                End If
            Next
            If Not tienePredetEnvio And mintTipo = CInt(enumcdTipoDireccion.cdDireccionEnvio) Then
                ExpertisApp.GenerateMessage("Debe haber una dirección predeterminada de envío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            ElseIf Not tienePredetFactura And mintTipo = CInt(enumcdTipoDireccion.cdDireccionFactura) Then
                ExpertisApp.GenerateMessage("Debe haber una dirección predeterminada de factura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            ElseIf Not tienePredetGiro And mintTipo = CInt(enumcdTipoDireccion.cdDireccionGiro) Then
                ExpertisApp.GenerateMessage("Debe haber una dirección predeterminada de giro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If

        Me.UpdateData()

        Grid.RequeryManually = True
        Grid.ReQuery()
    End Sub

    Private Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.Close()
    End Sub

End Class