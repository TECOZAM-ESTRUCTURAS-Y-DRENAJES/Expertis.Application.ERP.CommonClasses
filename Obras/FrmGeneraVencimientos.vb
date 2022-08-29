Imports System.Math
Public Class FrmGeneraVencimientos
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.GridCadencia.RelationMode = RelationMode.NoRelation
        Me.GridVtos.RelationMode = RelationMode.NoRelation
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
    Friend WithEvents LblVencimientos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents GridCadencia As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridVtos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents txtImporteTrabajo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents cmbGeneraHitos As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents lblImporteTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblNObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtNObra As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents fraCabecera As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents pnlLabelHitosFacturacion As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlCadencia As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlHitos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents txtCodTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridCadencia_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGeneraVencimientos))
        Dim GridVtos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.cmbGeneraHitos = New Solmicro.Expertis.Engine.UI.Button
        Me.GridCadencia = New Solmicro.Expertis.Engine.UI.Grid
        Me.GridVtos = New Solmicro.Expertis.Engine.UI.Grid
        Me.txtImporteTrabajo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImporteTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCodTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.LblVencimientos = New Solmicro.Expertis.Engine.UI.Label
        Me.lblNObra = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fraCabecera = New Solmicro.Expertis.Engine.UI.Frame
        Me.pnlLabelHitosFacturacion = New Solmicro.Expertis.Engine.UI.Panel
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlCadencia = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlHitos = New Solmicro.Expertis.Engine.UI.Panel
        Me.Splitter1 = New System.Windows.Forms.Splitter
        CType(Me.GridCadencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridVtos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraCabecera.SuspendLayout()
        Me.pnlLabelHitosFacturacion.suspendlayout()
        Me.Panel1.suspendlayout()
        Me.pnlCadencia.suspendlayout()
        Me.pnlHitos.suspendlayout()
        Me.SuspendLayout()
        '
        'cmbGeneraHitos
        '
        Me.cmbGeneraHitos.Location = New System.Drawing.Point(516, 6)
        Me.cmbGeneraHitos.Name = "cmbGeneraHitos"
        Me.cmbGeneraHitos.Size = New System.Drawing.Size(128, 40)
        Me.cmbGeneraHitos.TabIndex = 10
        Me.cmbGeneraHitos.Text = "Generar Hitos de Facturación"
        '
        'GridCadencia
        '
        Me.GridCadencia.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDFormaPago", "FormaPago", "IDFormaPago")})
        GridCadencia_DesignTimeLayout.LayoutString = resources.GetString("GridCadencia_DesignTimeLayout.LayoutString")
        Me.GridCadencia.DesignTimeLayout = GridCadencia_DesignTimeLayout
        Me.GridCadencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCadencia.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridCadencia.EntityName = ""
        Me.GridCadencia.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridCadencia.Location = New System.Drawing.Point(0, 0)
        Me.GridCadencia.Name = "GridCadencia"
        Me.GridCadencia.PrimaryDataFields = Nothing
        Me.GridCadencia.SecondaryDataFields = ""
        Me.GridCadencia.Size = New System.Drawing.Size(1161, 274)
        Me.GridCadencia.TabIndex = 0
        Me.GridCadencia.ViewName = ""
        '
        'GridVtos
        '
        Me.GridVtos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridVtos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridVtos_DesignTimeLayout.LayoutString = resources.GetString("GridVtos_DesignTimeLayout.LayoutString")
        Me.GridVtos.DesignTimeLayout = GridVtos_DesignTimeLayout
        Me.GridVtos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridVtos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridVtos.EntityName = "ObraTrabajoFacturacion"
        Me.GridVtos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridVtos.FrozenColumns = 11
        Me.GridVtos.Location = New System.Drawing.Point(0, 26)
        Me.GridVtos.Name = "GridVtos"
        Me.GridVtos.PrimaryDataFields = ""
        Me.GridVtos.RequeryManually = True
        Me.GridVtos.SecondaryDataFields = "IDVencimiento"
        Me.GridVtos.Size = New System.Drawing.Size(1161, 225)
        Me.GridVtos.TabIndex = 8
        Me.GridVtos.Tag = "$FrmGeneraVencimientos.frx:1D0A"
        Me.GridVtos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridVtos.ViewName = "vFrmObraTrabajoFacturacion"
        '
        'txtImporteTrabajo
        '
        Me.txtImporteTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtImporteTrabajo.Enabled = False
        Me.txtImporteTrabajo.Location = New System.Drawing.Point(1027, 15)
        Me.txtImporteTrabajo.Name = "txtImporteTrabajo"
        Me.txtImporteTrabajo.Size = New System.Drawing.Size(112, 21)
        Me.txtImporteTrabajo.TabIndex = 6
        '
        'lblImporteTrabajo
        '
        Me.lblImporteTrabajo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblImporteTrabajo.Location = New System.Drawing.Point(914, 19)
        Me.lblImporteTrabajo.Name = "lblImporteTrabajo"
        Me.lblImporteTrabajo.Size = New System.Drawing.Size(112, 13)
        Me.lblImporteTrabajo.TabIndex = 14
        Me.lblImporteTrabajo.Text = "Importe Trabajo A"
        '
        'txtCodTrabajo
        '
        Me.txtCodTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtCodTrabajo.Enabled = False
        Me.txtCodTrabajo.Location = New System.Drawing.Point(288, 15)
        Me.txtCodTrabajo.Name = "txtCodTrabajo"
        Me.txtCodTrabajo.Size = New System.Drawing.Size(128, 21)
        Me.txtCodTrabajo.TabIndex = 5
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(235, 19)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(50, 13)
        Me.lblTrabajo.TabIndex = 15
        Me.lblTrabajo.Text = "Trabajo"
        '
        'LblVencimientos
        '
        Me.LblVencimientos.Location = New System.Drawing.Point(6, 7)
        Me.LblVencimientos.Name = "LblVencimientos"
        Me.LblVencimientos.Size = New System.Drawing.Size(126, 13)
        Me.LblVencimientos.TabIndex = 16
        Me.LblVencimientos.Text = "Hitos de Facturación:"
        '
        'lblNObra
        '
        Me.lblNObra.Location = New System.Drawing.Point(9, 19)
        Me.lblNObra.Name = "lblNObra"
        Me.lblNObra.Size = New System.Drawing.Size(75, 13)
        Me.lblNObra.TabIndex = 18
        Me.lblNObra.Text = "Nº Proyecto"
        '
        'txtNObra
        '
        Me.txtNObra.DisabledBackColor = System.Drawing.Color.White
        Me.txtNObra.Enabled = False
        Me.txtNObra.Location = New System.Drawing.Point(86, 15)
        Me.txtNObra.Name = "txtNObra"
        Me.txtNObra.Size = New System.Drawing.Size(128, 21)
        Me.txtNObra.TabIndex = 21
        '
        'fraCabecera
        '
        Me.fraCabecera.Controls.Add(Me.txtNObra)
        Me.fraCabecera.Controls.Add(Me.txtCodTrabajo)
        Me.fraCabecera.Controls.Add(Me.txtImporteTrabajo)
        Me.fraCabecera.Controls.Add(Me.lblImporteTrabajo)
        Me.fraCabecera.Controls.Add(Me.lblNObra)
        Me.fraCabecera.Controls.Add(Me.lblTrabajo)
        Me.fraCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.fraCabecera.Location = New System.Drawing.Point(0, 0)
        Me.fraCabecera.Name = "fraCabecera"
        Me.fraCabecera.Size = New System.Drawing.Size(1161, 45)
        Me.fraCabecera.TabIndex = 22
        Me.fraCabecera.TabStop = False
        '
        'pnlLabelHitosFacturacion
        '
        Me.pnlLabelHitosFacturacion.Controls.Add(Me.LblVencimientos)
        Me.pnlLabelHitosFacturacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLabelHitosFacturacion.Location = New System.Drawing.Point(0, 0)
        Me.pnlLabelHitosFacturacion.Name = "pnlLabelHitosFacturacion"
        Me.pnlLabelHitosFacturacion.Size = New System.Drawing.Size(1161, 26)
        Me.pnlLabelHitosFacturacion.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbGeneraHitos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 575)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1161, 53)
        Me.Panel1.TabIndex = 24
        '
        'pnlCadencia
        '
        Me.pnlCadencia.Controls.Add(Me.GridCadencia)
        Me.pnlCadencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCadencia.Location = New System.Drawing.Point(0, 45)
        Me.pnlCadencia.Name = "pnlCadencia"
        Me.pnlCadencia.Size = New System.Drawing.Size(1161, 274)
        Me.pnlCadencia.TabIndex = 25
        '
        'pnlHitos
        '
        Me.pnlHitos.Controls.Add(Me.GridVtos)
        Me.pnlHitos.Controls.Add(Me.pnlLabelHitosFacturacion)
        Me.pnlHitos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlHitos.Location = New System.Drawing.Point(0, 324)
        Me.pnlHitos.Name = "pnlHitos"
        Me.pnlHitos.Size = New System.Drawing.Size(1161, 251)
        Me.pnlHitos.TabIndex = 26
        Me.pnlHitos.Visible = False
        '
        'Splitter1
        '
        Me.Splitter1.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter1.Location = New System.Drawing.Point(0, 319)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1161, 5)
        Me.Splitter1.TabIndex = 27
        Me.Splitter1.TabStop = False
        '
        'FrmGeneraVencimientos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(1161, 628)
        Me.Controls.Add(Me.pnlCadencia)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.pnlHitos)
        Me.Controls.Add(Me.fraCabecera)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmGeneraVencimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ficha de Vencimientos del Trabajo"
        CType(Me.GridCadencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridVtos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraCabecera.ResumeLayout(False)
        Me.fraCabecera.PerformLayout()
        Me.pnlLabelHitosFacturacion.ResumeLayout(False)
        Me.pnlLabelHitosFacturacion.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.pnlCadencia.ResumeLayout(False)
        Me.pnlHitos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.AllRecords
        End Get
    End Property

    Public WriteOnly Property QPrevTrabajo() As Double
        Set(ByVal value As Double)
            mQPrevTrabajo = value
        End Set
    End Property

    Dim f As New Filter
    Dim mdrLinea, mdrObra As DataRow
    Dim mIDObra, mClaseVto, mIDLinea As Integer
    Dim mDescLinea, mIDArticulo, mIDCliente As String
    Dim mQPrevTrabajo As Double = 1

#Region " Load "

    Public Sub AbrirGeneracionVencimientos(ByVal drLinea As DataRow, ByVal drObra As DataRow, ByVal intClaseVto As enumottfClaseVencimiento, ByVal OwnerForm As FormBase)
        If Length(drObra("IDDiaPago")) > 0 Then
            mdrLinea = drLinea
            mClaseVto = intClaseVto
            mIDObra = drObra("IDObra")
            mIDCliente = drObra("IDCliente") & String.Empty

            txtNObra.Text = drObra("NObra") & String.Empty
            txtCodTrabajo.Text = drLinea("CodTrabajo") & String.Empty

            With GridCadencia
                .EntityName = GetType(ObraTrabajoTipoFacturacion).Name
                .ViewName = "vfrmObraTrabajoTipoFacturacion"

                If Length(drObra("IDFormaPago")) > 0 Then .Columns("IDFormaPago").DefaultValue = drObra("IDFormaPago")
                .Columns("IDTrabajo").DefaultValue = drLinea("IDTrabajo")
                .Columns("TipoCadencia").DefaultValue = CInt(enumottfCadencia.ottfMes)
                .Columns("Periodificable").DefaultValue = False
                .Columns("CriterioGeneracion").DefaultValue = CInt(enumottfCriterioGeneracion.ImporteTrabajo)

                Select Case intClaseVto
                    Case enumottfClaseVencimiento.ottfMaterial
                        Me.Text = "Ficha de Vencimientos de Materiales."
                        txtImporteTrabajo.Text = Nz(drLinea("ImpPrevMatVentaA"), 0) * Nz(drLinea("QPrevTrabajo"), 1)
                        mIDLinea = Nz(drLinea("IDLineaMaterial"), 0)
                        .Columns("IDLineaMaterial").DefaultValue = mIDLinea
                        mDescLinea = drLinea("DescMaterial") & String.Empty
                        f.Add(New NumberFilterItem("IDLineaMaterial", mIDLinea))
                        mIDArticulo = drLinea("IDMaterial")

                    Case enumottfClaseVencimiento.ottfMod
                        txtImporteTrabajo.Text = Nz(drLinea("ImpPrevModVentaA"), 0) * Nz(drLinea("QPrevTrabajo"), 1)
                        Me.Text = "Ficha de Vencimientos de M.O.D."
                        mIDLinea = Nz(drLinea("IdLineaMod"), 0)
                        .Columns("IdLineaMod").DefaultValue = mIDLinea
                        mDescLinea = drLinea("DesHora") & String.Empty
                        f.Add(New NumberFilterItem("IDLineaMod", mIDLinea))

                    Case enumottfClaseVencimiento.ottfCentro
                        txtImporteTrabajo.Text = Nz(drLinea("ImpPrevCentroVentaA"), 0) * Nz(drLinea("QPrevTrabajo"), 1)
                        Me.Text = "Ficha de Vencimientos de Centros."
                        mIDLinea = Nz(drLinea("IdLineaCentro"), 0)
                        .Columns("IdLineaCentro").DefaultValue = mIDLinea
                        mDescLinea = drLinea("DescCentro") & String.Empty
                        f.Add(New NumberFilterItem("IDLineaCentro", mIDLinea))

                    Case enumottfClaseVencimiento.ottfGasto
                        txtImporteTrabajo.Text = Nz(drLinea("ImpPrevGastoVentaA"), 0) * mQPrevTrabajo
                        Me.Text = "Ficha de Vencimientos de Gastos."
                        mIDLinea = Nz(drLinea("IdLineaGasto"), 0)
                        .Columns("IdLineaGasto").DefaultValue = mIDLinea
                        mDescLinea = drLinea("DescGasto") & String.Empty
                        f.Add(New NumberFilterItem("IDLineaGasto", mIDLinea))

                    Case enumottfClaseVencimiento.ottfVarios
                        txtImporteTrabajo.Text = Nz(drLinea("ImpPrevVariosVentaA"), 0) * mQPrevTrabajo
                        Me.Text = "Ficha de Vencimientos de Varios."
                        mIDLinea = Nz(drLinea("IdLineaVarios"), 0)
                        .Columns("IdLineaVarios").DefaultValue = mIDLinea
                        mDescLinea = drLinea("DescVarios") & String.Empty
                        f.Add(New NumberFilterItem("IDLineaVarios", mIDLinea))

                    Case enumottfClaseVencimiento.ottfTrabajo
                        txtImporteTrabajo.Text = Nz(drLinea("ImpPrevQTrabajoVentaA"), 0)
                        Me.Text = "Ficha de Vencimientos de Trabajos."
                        mIDLinea = Nz(drLinea("IDTrabajo"), 0)
                        mDescLinea = drLinea("DescTrabajo") & String.Empty
                        f.Add(New NumberFilterItem("IDTrabajo", mIDLinea))
                        mIDArticulo = drLinea("IDArticulo") & String.Empty
                End Select

                .Filter = f
            End With

            If mIDLinea > 0 Then Me.ShowDialog(OwnerForm)
        Else
            ExpertisApp.GenerateMessage("Para poder generar Hitos de Facturación debe de indicar el Día de Pago en el Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub FrmGeneraVencimientos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EnumData.PopulateValueList("enumottfCadencia", GridCadencia.Columns("TipoCadencia"))
        EnumData.PopulateValueList("enumottfCriterioGeneracion", GridCadencia.Columns("CriterioGeneracion"))
        GridVtos.ReQuery(f)
        SumaImporte()
    End Sub

#End Region

    Private Sub GridCadencia_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridCadencia.EditingCell
        Select Case e.Column.Key
            Case "CriterioGeneracion"
                e.Cancel = Not GridCadencia.Value("Periodificable")
            Case "ImporteA"
                e.Cancel = GridCadencia.Value("Periodificable")
        End Select
    End Sub

    Private Sub GridCadencia_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridCadencia.SelectionChanged
        'Solo podrán generar hitos aquellos registros que sean NO periodificables.
        cmbGeneraHitos.Enabled = Not Nz(GridCadencia.Value("Periodificable"), False)
    End Sub

    Protected Overridable Sub GridCadencia_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridCadencia.FormattingRow
        If e.Row.RowType = RowType.Record Then
            If Length(e.Row.Cells("FechaInicio").Value) > 0 Then
                If Nz(e.Row.Cells("FechaInicio").Value) = Nz(e.Row.Cells("FechaUltima").Value, e.Row.Cells("FechaInicio").Value) Then
                    e.Row.RowStyle = GridCadencia.FormatStyles("RegistroActivoFormatStyle")
                End If
            End If
        End If
    End Sub

    Private Sub GridCadencia_SaveChanges(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridCadencia.RecordAdded, GridCadencia.RecordUpdated, GridCadencia.RecordsDeleted
        Me.UpdateData()
        SumaImporte()
    End Sub

    Private Function SumaImporte() As Double
        Dim s As Double = Nz(CType(GridCadencia.DataSource, DataTable).Compute("SUM(ImporteA)", New BooleanFilterItem("Periodificable", False).Compose(New AdoFilterComposer)), 0)

        Dim c As GridEXColumn = GridCadencia.Columns("ImporteA")
        c.DefaultValue = txtImporteTrabajo.Value - s

        Return s
    End Function

    Private Sub cmbGeneraHitos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGeneraHitos.Click
        If GridCadencia.RowCount > 0 Then
            If GridCadencia.SelectedRows.Rows.Count > 0 Then
                Dim dtGrid As DataTable = GridVtos.DataSource.Copy
                Dim strMsg As String = ExpertisApp.Traslate("El proceso generará los nuevos Hitos de Facturación de la línea seleccionada. ¿Desea continuar?.")
                If Not IsNothing(dtGrid) AndAlso dtGrid.Rows.Count > 0 Then
                    Dim dv As DataView = dtGrid.DefaultView
                    dv.RowFilter = "Facturado=1"
                    If dv.Count > 0 Then
                        strMsg = "Existen Hitos de Facturación facturados. Recuerde que se pueden generar Hitos de Facturación que ya han sido generados. Dichos Hitos deberá eliminarlos manualmente. ¿Desea continuar?."
                    End If
                End If

                If ExpertisApp.GenerateMessage(strMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    Dim dataHitos As New ObraTrabajoFacturacion.DatosGenerarHitos(GridCadencia.SelectedRows, mIDObra, mdrLinea("IDTrabajo"), mIDArticulo, mIDLinea, mDescLinea, mClaseVto)
                    Dim dtVtos As DataTable = ExpertisApp.ExecuteTask(Of ObraTrabajoFacturacion.DatosGenerarHitos, DataTable)(AddressOf ObraTrabajoFacturacion.GenerarHitosFacturacion, dataHitos)
                    GridVtos.DataSource = dtVtos

                    GridCadencia.DataSource = New BE.DataEngine().Filter(GridCadencia.ViewName, f)
                    pnlHitos.Visible = True
                    Me.Cursor = Cursors.Default
                    ExpertisApp.GenerateMessage("Proceso finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                ExpertisApp.GenerateMessage("No hay un registro de cadencia seleccionado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            ExpertisApp.GenerateMessage("No hay lineas de cadencia.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub FrmGeneraVencimientos_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
        e.Data.Context.Clear()
        Select Case e.EntityName
            Case GetType(ObraTrabajoTipoFacturacion).Name
                If GridCadencia.Value("CriterioGeneracion") = enumottfCriterioGeneracion.ImporteTrabajo Then
                    e.Data.Context("RSImporteCadencia") = GridCadencia.DataSource
                    e.Data.Context("ImpTrabajoA") = txtImporteTrabajo.Value
                    e.Data.Context("IDCliente") = mIDCliente
                Else
                    e.Data.Context("ImpTrabajoA") = txtImporteTrabajo.Value
                End If
        End Select
    End Sub

End Class

