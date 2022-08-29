Public Class frmVerEntregasACuenta
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
    Protected WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Protected WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Protected WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Protected WithEvents lblIDClienteProveedor As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents txtIDClienteProveedor As Solmicro.Expertis.Engine.UI.TextBox
    Protected WithEvents txtDescClienteProveedor As Solmicro.Expertis.Engine.UI.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVerEntregasACuenta))
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.lblIDClienteProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIDClienteProveedor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDescClienteProveedor = New Solmicro.Expertis.Engine.UI.TextBox
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(616, 300)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(96, 27)
        Me.cmbCancelar.TabIndex = 10
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmbAceptar.Location = New System.Drawing.Point(512, 300)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(96, 27)
        Me.cmbAceptar.TabIndex = 9
        Me.cmbAceptar.Text = "Aceptar"
        '
        'Grid
        '
        Me.Grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = "EntregasACuenta"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.KeyField = "IDEntrega"
        Me.Grid.Location = New System.Drawing.Point(8, 37)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = ""
        Me.Grid.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.Grid.RequeryManually = True
        Me.Grid.SecondaryDataFields = ""
        Me.Grid.Size = New System.Drawing.Size(703, 256)
        Me.Grid.TabIndex = 11
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vEntregasACuentaGeneradas"
        '
        'lblIDClienteProveedor
        '
        Me.lblIDClienteProveedor.Location = New System.Drawing.Point(8, 8)
        Me.lblIDClienteProveedor.Name = "lblIDClienteProveedor"
        Me.lblIDClienteProveedor.Size = New System.Drawing.Size(47, 13)
        Me.lblIDClienteProveedor.TabIndex = 12
        Me.lblIDClienteProveedor.Text = "Cliente"
        '
        'txtIDClienteProveedor
        '
        Me.txtIDClienteProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDClienteProveedor.Enabled = False
        Me.txtIDClienteProveedor.Location = New System.Drawing.Point(79, 8)
        Me.txtIDClienteProveedor.Name = "txtIDClienteProveedor"
        Me.txtIDClienteProveedor.ReadOnly = True
        Me.txtIDClienteProveedor.Size = New System.Drawing.Size(97, 21)
        Me.txtIDClienteProveedor.TabIndex = 13
        '
        'txtDescClienteProveedor
        '
        Me.txtDescClienteProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescClienteProveedor.Enabled = False
        Me.txtDescClienteProveedor.Location = New System.Drawing.Point(184, 8)
        Me.txtDescClienteProveedor.Name = "txtDescClienteProveedor"
        Me.txtDescClienteProveedor.ReadOnly = True
        Me.txtDescClienteProveedor.Size = New System.Drawing.Size(528, 21)
        Me.txtDescClienteProveedor.TabIndex = 15
        '
        'frmVerEntregasACuenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(722, 333)
        Me.Controls.Add(Me.txtDescClienteProveedor)
        Me.Controls.Add(Me.txtIDClienteProveedor)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.cmbCancelar)
        Me.Controls.Add(Me.cmbAceptar)
        Me.Controls.Add(Me.lblIDClienteProveedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmVerEntregasACuenta"
        Me.Text = "Entregas a Cuenta pendientes de saldar"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private mstrCampoIDClienteProveedor As String

#Region " Propiedades "

    Protected mintCircuito As Circuito
    Public WriteOnly Property CircuitoOrigen() As Circuito
        Set(ByVal Value As Circuito)
            mintCircuito = Value
            Select Case mintCircuito
                Case Circuito.Ventas
                    mstrCampoIDClienteProveedor = "IDCliente"
                Case Circuito.Compras
                    mstrCampoIDClienteProveedor = "IDproveedor"
            End Select
        End Set
    End Property

    Protected mintIDFactura As Integer
    Public WriteOnly Property IDFactura() As Integer
        Set(ByVal Value As Integer)
            mintIDFactura = Value
        End Set
    End Property

    Protected mstrIDClienteProveedor As String
    Public WriteOnly Property IDClienteProveedor() As String
        Set(ByVal Value As String)
            mstrIDClienteProveedor = Value

            Dim objFilter As New Filter
            objFilter.Clear()
            objFilter.Add(New StringFilterItem(mstrCampoIDClienteProveedor, mstrIDClienteProveedor))
            Grid.Filter = objFilter
        End Set
    End Property

    Protected mstrDescClienteProveedor As String
    Public WriteOnly Property DescClienteProveedor() As String
        Set(ByVal Value As String)
            mstrDescClienteProveedor = Value
        End Set
    End Property

    Protected mblnAñadirEntregas As Boolean
    Public Property AñadirEntregas() As Boolean
        Set(ByVal Value As Boolean)
            mblnAñadirEntregas = Value
            Grid.UseCheck = Value
            Grid.ViewName = "vEntregasACuentaGeneradas"
        End Set
        Get
            Return mblnAñadirEntregas
        End Get
    End Property

    Protected mblnEliminarEntregas As Boolean
    Public Property EliminarEntregas() As Boolean
        Set(ByVal Value As Boolean)
            mblnEliminarEntregas = Value
            Grid.UseCheck = Value
            Grid.ViewName = "vEntregasACuentaSaldadas"

            Dim objFilter As New Filter
            If mintIDFactura <> 0 Then
                objFilter.Add(New NumberFilterItem("IDFacturaDestino", mintIDFactura))
                objFilter.Add(New NumberFilterItem("TipoEntrega", FilterOperator.NotEqual, enumTipoEntrega.Retencion))
            End If
            Grid.Filter = objFilter
        End Set
        Get
            Return mblnEliminarEntregas
        End Get
    End Property



#End Region

#Region " Carga del formulario "

    Protected Overridable Sub frmVerEntregasACuenta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Grid.ReQuery()
        LoadProperties()
        LoadEnums()
        SettingsGrid()
    End Sub

    Protected Overridable Sub LoadProperties()
        Select Case mintCircuito
            Case Circuito.Ventas
                Me.lblIDClienteProveedor.Text = "Cliente"
            Case Circuito.Compras
                Me.lblIDClienteProveedor.Text = "Proveedor"
        End Select
        Me.txtIDClienteProveedor.Text = mstrIDClienteProveedor
        Me.txtDescClienteProveedor.Text = mstrDescClienteProveedor
    End Sub

    Protected Overridable Sub LoadEnums()
        EnumData.PopulateValueList("enumTipoEntrega", Grid.Columns("TipoEntrega"))
    End Sub

    Protected Overridable Sub SettingsGrid()
        Select Case mintCircuito
            Case Circuito.Ventas
                Grid.Columns("CCClienteProveedor").Caption = "C. C. Cliente"
                Grid.Columns("IDCobroPago").Caption = "Cobro"
                Grid.Columns("IDTipoCobroPago").Caption = "ID. Tipo Cobro"
                Grid.Columns("DescTipoCobroPago").Caption = "Tipo Cobro"
            Case Circuito.Compras
                Grid.Columns("CCClienteProveedor").Caption = "C. C. Proveedor"
                Grid.Columns("IDCobroPago").Caption = "Pago"
                Grid.Columns("IDTipoCobroPago").Caption = "ID. Tipo Pago"
                Grid.Columns("DescTipoCobroPago").Caption = "Tipo Pago"
        End Select
        Grid.Columns("TipoEntrega").EditType = Janus.Windows.GridEX.EditType.NoEdit

        'If Grid.UseCheck Then
        '    Grid.Columns("Expertis.Check").EditType = EditType.CheckBox
        '    Grid.Columns("Expertis.Check").ColumnType = ColumnType.CheckBox
        'Else
        '    Grid.Filter = Nothing
        'End If
    End Sub

#End Region

#Region " Aceptar/Cancelar "

    Protected Overridable Sub cmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        If mblnAñadirEntregas OrElse mblnEliminarEntregas Then
            If Grid.CheckedRecordsCount > 0 Then
                Me.Cursor = Cursors.WaitCursor
                Dim IDEntregas(-1) As Integer
                For Each entrega As DataRow In Grid.CheckedRecords.Rows
                    ReDim Preserve IDEntregas(IDEntregas.Length)
                    IDEntregas(IDEntregas.Length - 1) = entrega("IDEntrega")
                Next
                Dim datos As New EntregasACuenta.DataEntregas(Me.mintIDFactura, IDEntregas)
                Select Case Me.mintCircuito
                    Case Circuito.Compras
                        If mblnAñadirEntregas Then
                            ExpertisApp.ExecuteTask(Of EntregasACuenta.DataEntregas)(AddressOf EntregasACuenta.AñadirEntregasAFacturaCompra, datos)
                        ElseIf mblnEliminarEntregas Then
                            ExpertisApp.ExecuteTask(Of EntregasACuenta.DataEntregas)(AddressOf EntregasACuenta.QuitarEntregasAFacturaCompra, datos)
                        End If
                    Case Circuito.Ventas
                        If mblnAñadirEntregas Then
                            ExpertisApp.ExecuteTask(Of EntregasACuenta.DataEntregas)(AddressOf EntregasACuenta.AñadirEntregasAFacturaVenta, datos)
                        ElseIf mblnEliminarEntregas Then
                            ExpertisApp.ExecuteTask(Of EntregasACuenta.DataEntregas)(AddressOf EntregasACuenta.QuitarEntregasAFacturaVenta, datos)
                        End If
                End Select
                ExpertisApp.GenerateMessage("Proceso finalizado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Grid.UnCheckAllRecords()
                Me.Cursor = Cursors.Default
                Me.Close()
            Else
                ExpertisApp.GenerateMessage("Debe seleccionar algún registro.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            Me.Close()
        End If
    End Sub

    Protected Overridable Sub cmbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.Close()
    End Sub

#End Region

#Region " Grid "

    Protected Overridable Sub Grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        Select Case e.Column.Key
            Case "Expertis.Check"
                If Grid.Value("TipoEntrega") = enumTipoEntrega.Retencion Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("Las Entregas de tipo Retención no se permiten añadir.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
        End Select
    End Sub

#End Region

End Class
