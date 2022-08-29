Public Class frmImpuestos
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
    Friend WithEvents BottomPanel As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents ButtonCancel As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents ButtonOK As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents TopPanel As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents jngImpuestos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents TopFrame As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents IDArticulo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents ImporteLinea As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents DescArticulo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblImporte As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblArticulo As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim jngImpuestos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImpuestos))
        Me.BottomPanel = New Solmicro.Expertis.Engine.UI.Panel
        Me.ButtonOK = New Solmicro.Expertis.Engine.UI.Button
        Me.ButtonCancel = New Solmicro.Expertis.Engine.UI.Button
        Me.TopPanel = New Solmicro.Expertis.Engine.UI.Panel
        Me.jngImpuestos = New Solmicro.Expertis.Engine.UI.Grid
        Me.TopFrame = New Solmicro.Expertis.Engine.UI.Frame
        Me.IDArticulo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.ImporteLinea = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.DescArticulo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblImporte = New Solmicro.Expertis.Engine.UI.Label
        Me.lblArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.BottomPanel.suspendlayout()
        Me.TopPanel.suspendlayout()
        CType(Me.jngImpuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopFrame.SuspendLayout()
        Me.SuspendLayout()
        '
        'BottomPanel
        '
        Me.BottomPanel.Controls.Add(Me.ButtonOK)
        Me.BottomPanel.Controls.Add(Me.ButtonCancel)
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel.Location = New System.Drawing.Point(0, 287)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(614, 72)
        Me.BottomPanel.TabIndex = 5
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(356, 20)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(102, 33)
        Me.ButtonOK.TabIndex = 2
        Me.ButtonOK.Text = "Aceptar"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(464, 20)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(102, 33)
        Me.ButtonCancel.TabIndex = 3
        Me.ButtonCancel.Text = "Cancelar"
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.jngImpuestos)
        Me.TopPanel.Controls.Add(Me.TopFrame)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(614, 287)
        Me.TopPanel.TabIndex = 6
        '
        'jngImpuestos
        '
        Me.jngImpuestos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDImpuesto", "Impuesto", "IDImpuesto", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescImpuesto", "DescImpuesto"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Porcentaje", "Porcentaje"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Valor", "Valor")}))})
        jngImpuestos_DesignTimeLayout.LayoutString = resources.GetString("jngImpuestos_DesignTimeLayout.LayoutString")
        Me.jngImpuestos.DesignTimeLayout = jngImpuestos_DesignTimeLayout
        Me.jngImpuestos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngImpuestos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngImpuestos.EntityName = ""
        Me.jngImpuestos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngImpuestos.Location = New System.Drawing.Point(0, 80)
        Me.jngImpuestos.Name = "jngImpuestos"
        Me.jngImpuestos.PrimaryDataFields = ""
        Me.jngImpuestos.SecondaryDataFields = ""
        Me.jngImpuestos.Size = New System.Drawing.Size(614, 207)
        Me.jngImpuestos.TabIndex = 7
        Me.jngImpuestos.Tag = ""
        Me.jngImpuestos.ViewName = ""
        '
        'TopFrame
        '
        Me.TopFrame.Controls.Add(Me.IDArticulo)
        Me.TopFrame.Controls.Add(Me.ImporteLinea)
        Me.TopFrame.Controls.Add(Me.DescArticulo)
        Me.TopFrame.Controls.Add(Me.lblImporte)
        Me.TopFrame.Controls.Add(Me.lblArticulo)
        Me.TopFrame.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopFrame.Location = New System.Drawing.Point(0, 0)
        Me.TopFrame.Name = "TopFrame"
        Me.TopFrame.Size = New System.Drawing.Size(614, 80)
        Me.TopFrame.TabIndex = 5
        Me.TopFrame.TabStop = False
        Me.TopFrame.Tag = ""
        '
        'IDArticulo
        '
        Me.IDArticulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(IDArticulo, New System.Windows.Forms.Binding("Text", Me, "IDArticulo", True))
        Me.IDArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.IDArticulo.Enabled = False
        Me.IDArticulo.Location = New System.Drawing.Point(61, 14)
        Me.IDArticulo.Name = "IDArticulo"
        Me.IDArticulo.Size = New System.Drawing.Size(143, 21)
        Me.IDArticulo.TabIndex = 9
        '
        'ImporteLinea
        '
        Me.ImporteLinea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(ImporteLinea, New System.Windows.Forms.Binding("Value", Me, "Importe", True))
        Me.ImporteLinea.DisabledBackColor = System.Drawing.Color.White
        Me.ImporteLinea.Enabled = False
        Me.ImporteLinea.Location = New System.Drawing.Point(61, 46)
        Me.ImporteLinea.Name = "ImporteLinea"
        Me.ImporteLinea.Size = New System.Drawing.Size(143, 21)
        Me.ImporteLinea.TabIndex = 11
        '
        'DescArticulo
        '
        Me.DescArticulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(DescArticulo, New System.Windows.Forms.Binding("Text", Me, "DescArticulo", True))
        Me.DescArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.DescArticulo.Enabled = False
        Me.DescArticulo.Location = New System.Drawing.Point(210, 14)
        Me.DescArticulo.Name = "DescArticulo"
        Me.DescArticulo.Size = New System.Drawing.Size(392, 21)
        Me.DescArticulo.TabIndex = 19
        '
        'lblImporte
        '
        Me.lblImporte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblImporte.Location = New System.Drawing.Point(8, 48)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(53, 13)
        Me.lblImporte.TabIndex = 12
        Me.lblImporte.Tag = "IdRec=4389;"
        Me.lblImporte.Text = "Importe"
        '
        'lblArticulo
        '
        Me.lblArticulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblArticulo.Location = New System.Drawing.Point(8, 16)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblArticulo.TabIndex = 10
        Me.lblArticulo.Tag = ""
        Me.lblArticulo.Text = "Artículo"
        '
        'frmImpuestos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(614, 359)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.BottomPanel)
        Me.CreateTransaction = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImpuestos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impuestos"
        Me.BottomPanel.ResumeLayout(False)
        Me.TopPanel.ResumeLayout(False)
        CType(Me.jngImpuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopFrame.ResumeLayout(False)
        Me.TopFrame.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mQueryOnclose As Boolean
    Private mPendingUpdate As Boolean
    Private mPendingDelete As Boolean
    Private mReadOnly As Boolean
    Private mIDLinea, mIDFactura As Integer
    Private mImporteLinea As Double
    Private mIDMoneda As String
    Private mCambioA As Double
    Private mCambioB As Double
    Private mIDClienteProveedor As String
    Private mFecha As Date

    Public WriteOnly Property IDMoneda() As String
        Set(ByVal Value As String)
            mIDMoneda = Value
        End Set
    End Property

    Public WriteOnly Property Fecha() As Date
        Set(ByVal Value As Date)
            mFecha = Value
        End Set
    End Property

    Public WriteOnly Property IDClienteProveedor() As String
        Set(ByVal Value As String)
            mIDClienteProveedor = Value
        End Set
    End Property

    Public WriteOnly Property SoloLectura() As Boolean
        Set(ByVal Value As Boolean)
            mReadOnly = Value
        End Set
    End Property

    Private mCurrentDataImpuestos As DataTable
    Public WriteOnly Property Data() As DataTable
        Set(ByVal Value As DataTable)
            mCurrentDataImpuestos = Value
        End Set
    End Property

    Private mIDDocKeyField As String
    Public WriteOnly Property IDDocKeyField() As String
        Set(ByVal value As String)
            mIDDocKeyField = value
        End Set
    End Property

    Private Sub jngImpuestos_DeletingRecord(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionCancelEventArgs) Handles jngImpuestos.DeletingRecord
        If mReadOnly Then
            e.Cancel = True
            ExpertisApp.GenerateMessage("Sólo se pueden visualizar datos.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub jngImpuestos_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles jngImpuestos.EditingCell
        Try
            If Not mReadOnly Then
                With jngImpuestos
                    Select Case e.Column.Key
                        Case "IDImpuesto"
                            If .Row = Grid.newTopRowPosition Then
                                e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                                e.Column.EditType = Janus.Windows.GridEX.EditType.TextBox
                            Else
                                e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                                e.Cancel = True
                            End If
                            'Case "Importe"
                            '    If .Value(.Columns("Porcentaje").Index) Then
                            '        e.Cancel = True
                            '    Else
                            '        e.Column.EditType = Janus.Windows.GridEX.EditType.TextBox
                            '    End If
                            'Case "Comision"
                            '    If .Value(.Columns("Porcentaje").Index) Then
                            '        e.Column.EditType = Janus.Windows.GridEX.EditType.TextBox
                            '    Else
                            '        e.Cancel = True
                            '    End If
                    End Select
                End With
            Else
                e.Cancel = True
                'ExpertisApp.GenerateMessage("Sólo se pueden visualizar datos.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            e.Cancel = True
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmImpuestos_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
        Try
            Dim context As New BusinessData

            e.Data.Context.Clear()
            Select Case e.EntityName
                Case jngImpuestos.EntityName
                    'context("IDLinea") = mIDLinea
                    'context("IDArticulo") = Me.CurrentData.Rows(0)("IDArticulo")
                    context("SumaImporte") = jngImpuestos.GetTotal(jngImpuestos.Columns("Importe"), AggregateFunction.Sum)

                    context("IDCliente") = mIDClienteProveedor
                    context("IDProveedor") = mIDClienteProveedor
                    context("ImporteLinea") = Me.CurrentData.Rows(0)("Importe")
                    context("QInterna") = Me.CurrentData.Rows(0)("QInterna")
                    'context("Porcentaje") = jngImpuestos.Columns("Porcentaje")
                    'context("Valor") = jngImpuestos.Columns("Valor")
                    context("IDMoneda") = mIDMoneda
                    context("CambioA") = mCambioA
                    context("CambioB") = mCambioB
                    context("Fecha") = mFecha
            End Select
            e.Data.Context = context
        Catch ex As Exception
            e.Cancel = True
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmImpuestos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            mFecha = Today
            If Not IsNothing(Me.CurrentData) AndAlso Me.CurrentData.Rows.Count Then
                mIDLinea = Me.CurrentData.Rows(0)(jngImpuestos.PrimaryDataFields)
                mIDFactura = Me.CurrentData.Rows(0)("IDFactura")
                mImporteLinea = Me.CurrentData.Rows(0)("Importe")
                Me.jngImpuestos.DataSource = New DataView(mCurrentDataImpuestos, jngImpuestos.PrimaryDataFields & " = " & CStr(mIDLinea), Nothing, DataViewRowState.CurrentRows)
                Dim datMon As New Business.General.Moneda.DatosObtenerMoneda
                datMon.IDMoneda = mIDMoneda
                datMon.Fecha = mFecha
                Dim MonInfo As MonedaInfo = ExpertisApp.ExecuteTask(Of Object, MonedaInfo)(AddressOf Business.General.Moneda.ObtenerMoneda, datMon)
                mCambioA = MonInfo.CambioA
                mCambioB = MonInfo.CambioB
                With jngImpuestos
                    If mReadOnly Then
                        .AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
                        .AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False
                        .AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
                    Else
                        Dim c As GridEXColumn
                        c = .Columns.Add(.PrimaryDataFields, ColumnType.Text, EditType.TextBox)
                        c.Visible = False
                        .Columns(.PrimaryDataFields).DefaultValue = mIDLinea
                        Dim c2 As GridEXColumn
                        c2 = .Columns.Add("IDFactura", ColumnType.Text, EditType.TextBox)
                        c2.Visible = False
                        .Columns("IDFactura").DefaultValue = mIDFactura
                        .Columns("Valor").DefaultValue = 0
                        .Columns("Porcentaje").DefaultValue = 1
                        .Columns("Importe").DefaultValue = 0
                        .Columns("ImporteA").DefaultValue = 0
                        .Columns("ImporteB").DefaultValue = 0
                    End If
                End With

                SumaImporte()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmImpuestos_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If mQueryOnclose Then
            e.Cancel = (ExpertisApp.GenerateMessage("¿Desea realmente perder el desglose realizado?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No)
            If Not e.Cancel Then
                Dim dv As DataView = CType(Me.jngImpuestos.DataSource, DataView)
                dv.RowStateFilter = DataViewRowState.CurrentRows + DataViewRowState.Deleted
                For Each drv As DataRowView In dv
                    If drv.Row.RowState <> DataRowState.Unchanged AndAlso drv.Row.RowState <> DataRowState.Detached Then
                        drv.Row.RejectChanges()
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub jngImpuestos_CellValueChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles jngImpuestos.CellValueChanged
        mQueryOnclose = True
        mPendingUpdate = True
    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    'Private mblnUpdateData As Boolean
    Private Sub ButtonOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonOK.Click
        Dim close As Boolean = True
        'mblnUpdateData = False
        If Not mReadOnly Then
            If mImporteLinea < 0 Then
                If SumaImporte() >= mImporteLinea Then
                    close = True
                    mQueryOnclose = False
                    If mPendingUpdate Or mPendingDelete Then
                        'mblnUpdateData = True
                    End If
                Else
                    close = False
                    ExpertisApp.GenerateMessage("La suma de importes en el desglose es mayor que el importe a asignar.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                If SumaImporte() > mImporteLinea Then
                    close = False
                    ExpertisApp.GenerateMessage("La suma de importes en el desglose es mayor que el importe a asignar.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    close = True
                    mQueryOnclose = False
                    If mPendingUpdate Or mPendingDelete Then
                        'mblnUpdateData = True
                    End If
                End If
            End If
        End If

        If close Then
            mQueryOnclose = False
            'If mblnUpdateData Then
            '    Me.DialogResult = Windows.Forms.DialogResult.OK
            'End If
            Me.Close()
        End If
    End Sub

    Private Sub jngImpuestos_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngImpuestos.RecordUpdated
        SumaImporte()
    End Sub

    Private Sub jngImpuestos_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngImpuestos.AddingRecord
        If mReadOnly Then
            e.Cancel = True
            'ExpertisApp.GenerateMessage("Sólo se pueden visualizar datos.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        SumaImporte()
    End Sub

    Private Sub jngImpuestos_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngImpuestos.RecordsDeleted
        SumaImporte()
        mPendingDelete = True
        mQueryOnclose = True
    End Sub

    Private Sub jngImpuestos_RowEditCanceled(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles jngImpuestos.RowEditCanceled
        SumaImporte()
    End Sub

    Private Function SumaImporte() As Double
        Dim c As GridEXColumn = jngImpuestos.Columns("Importe")
        Dim s As Double = jngImpuestos.GetTotal(c, AggregateFunction.Sum)
        'c.DefaultValue = xRound(mImporteLinea - s, mMoneda.NDecimalesImporte)
        c.DefaultValue = mImporteLinea - s

        'Return xRound(s, mMoneda.NDecimalesImporte)
        Return s
    End Function
End Class
