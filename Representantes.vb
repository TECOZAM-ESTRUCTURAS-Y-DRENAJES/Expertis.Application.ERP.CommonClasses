Public Class Representantes
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
    Public WithEvents jngRepresentantes As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents TopFrame As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents IDArticulo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents ImporteLinea As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents DescArticulo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.BottomPanel = New Solmicro.Expertis.Engine.UI.Panel
        Me.ButtonCancel = New Solmicro.Expertis.Engine.UI.Button
        Me.ButtonOK = New Solmicro.Expertis.Engine.UI.Button
        Me.TopPanel = New Solmicro.Expertis.Engine.UI.Panel
        Me.jngRepresentantes = New Solmicro.Expertis.Engine.UI.Grid
        Me.TopFrame = New Solmicro.Expertis.Engine.UI.Frame
        Me.IDArticulo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.ImporteLinea = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.DescArticulo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.BottomPanel.SuspendLayout()
        Me.TopPanel.SuspendLayout()
        CType(Me.jngRepresentantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopFrame.SuspendLayout()
        Me.SuspendLayout()
        '
        'BottomPanel
        '
        Me.BottomPanel.Controls.Add(Me.ButtonCancel)
        Me.BottomPanel.Controls.Add(Me.ButtonOK)
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel.Location = New System.Drawing.Point(0, 287)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(578, 72)
        Me.BottomPanel.TabIndex = 5
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(297, 20)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(102, 33)
        Me.ButtonCancel.TabIndex = 3
        Me.ButtonCancel.Text = "Cancelar"
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(179, 20)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(102, 33)
        Me.ButtonOK.TabIndex = 2
        Me.ButtonOK.Text = "Aceptar"
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.jngRepresentantes)
        Me.TopPanel.Controls.Add(Me.TopFrame)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(578, 287)
        Me.TopPanel.TabIndex = 6
        '
        'jngRepresentantes
        '
        Me.jngRepresentantes.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDRepresentante", "Representante", "IDRepresentante", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescRepresentante", "DescRepresentante")}))})
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><AllowAddNew>True</AllowAddNew><AllowDelete>True</Al" & _
        "lowDelete><AllowEdit>True</AllowEdit><Columns Collection=""true""><Column0 ID=""IDR" & _
        "epresentante""><Caption>Representante</Caption><DataMember>IDRepresentante</DataM" & _
        "ember><Key>IDRepresentante</Key><Position>0</Position><TextAlignment>Near</TextA" & _
        "lignment><Width>113</Width></Column0><Column1 ID=""DescRepresentante""><Caption>De" & _
        "sc. Representante</Caption><DataMember>DescRepresentante</DataMember><EditType>N" & _
        "oEdit</EditType><Key>DescRepresentante</Key><Position>1</Position><TextAlignment" & _
        ">Near</TextAlignment><Width>229</Width></Column1><Column2 ID=""Porcentaje""><Capti" & _
        "on>%</Caption><ColumnType>CheckBox</ColumnType><DataMember>Porcentaje</DataMembe" & _
        "r><EditType>CheckBox</EditType><HeaderAlignment>Center</HeaderAlignment><Key>Por" & _
        "centaje</Key><Position>2</Position><TextAlignment>Near</TextAlignment><Width>33<" & _
        "/Width></Column2><Column3 ID=""Comision""><AggregateFunction>Sum</AggregateFunctio" & _
        "n><Caption>Comisión</Caption><DataMember>Comision</DataMember><Key>Comision</Key" & _
        "><Position>3</Position><TextAlignment>Far</TextAlignment><Width>60</Width><Total" & _
        "FormatString>#,0.0###</TotalFormatString></Column3><Column4 ID=""Importe""><Aggreg" & _
        "ateFunction>Sum</AggregateFunction><Caption>Importe</Caption><DataMember>Importe" & _
        "</DataMember><Key>Importe</Key><Position>4</Position><TextAlignment>Far</TextAli" & _
        "gnment><Width>80</Width><TotalFormatString>#,0.0###</TotalFormatString></Column4" & _
        "><Column5 ID=""ImporteA""><Caption>ImporteA</Caption><DataMember>ImporteA</DataMem" & _
        "ber><Key>ImporteA</Key><Position>5</Position><TextAlignment>Far</TextAlignment><" & _
        "Visible>False</Visible></Column5><Column6 ID=""ImporteB""><Caption>ImporteB</Capti" & _
        "on><DataMember>ImporteB</DataMember><Key>ImporteB</Key><Position>6</Position><Te" & _
        "xtAlignment>Far</TextAlignment><Visible>False</Visible></Column6><Column7 ID=""ID" & _
        "LineaFactura""><DataMember>IDLineaFactura</DataMember><Key>IDLineaFactura</Key><P" & _
        "osition>7</Position><TextAlignment>Near</TextAlignment><Visible>False</Visible><" & _
        "/Column7></Columns><GroupCondition ID="""" /><SortKeys Collection=""true""><SortKey0" & _
        " ID=""SortKey0""><ColIndex>0</ColIndex></SortKey0></SortKeys></RootTable></GridEXL" & _
        "ayoutData>"
        Me.jngRepresentantes.DesignTimeLayout = GridEXLayout1
        Me.jngRepresentantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngRepresentantes.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.jngRepresentantes.EntityName = ""
        Me.jngRepresentantes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jngRepresentantes.Location = New System.Drawing.Point(0, 80)
        Me.jngRepresentantes.Name = "jngRepresentantes"
        Me.jngRepresentantes.PrimaryDataFields = ""
        Me.jngRepresentantes.SecondaryDataFields = ""
        Me.jngRepresentantes.Size = New System.Drawing.Size(578, 207)
        Me.jngRepresentantes.TabIndex = 7
        Me.jngRepresentantes.Tag = ""
        Me.jngRepresentantes.ViewName = ""
        '
        'TopFrame
        '
        Me.TopFrame.Controls.Add(Me.IDArticulo)
        Me.TopFrame.Controls.Add(Me.ImporteLinea)
        Me.TopFrame.Controls.Add(Me.DescArticulo)
        Me.TopFrame.Controls.Add(Me.Label1)
        Me.TopFrame.Controls.Add(Me.Label2)
        Me.TopFrame.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopFrame.Location = New System.Drawing.Point(0, 0)
        Me.TopFrame.Name = "TopFrame"
        Me.TopFrame.Size = New System.Drawing.Size(578, 80)
        Me.TopFrame.TabIndex = 5
        Me.TopFrame.TabStop = False
        Me.TopFrame.Tag = ""
        '
        'IDArticulo
        '
        Me.IDArticulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(IDArticulo, New System.Windows.Forms.Binding("Text", Me, "IDArticulo"))
        Me.IDArticulo.Enabled = False
        Me.IDArticulo.Location = New System.Drawing.Point(61, 14)
        Me.IDArticulo.Name = "IDArticulo"
        Me.IDArticulo.Size = New System.Drawing.Size(107, 21)
        Me.IDArticulo.TabIndex = 9
        '
        'ImporteLinea
        '
        Me.ImporteLinea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(ImporteLinea, New System.Windows.Forms.Binding("Value", Me, "Importe"))
        Me.ImporteLinea.Enabled = False
        Me.ImporteLinea.Location = New System.Drawing.Point(61, 46)
        Me.ImporteLinea.Name = "ImporteLinea"
        Me.ImporteLinea.Size = New System.Drawing.Size(107, 21)
        Me.ImporteLinea.TabIndex = 11
        '
        'DescArticulo
        '
        Me.DescArticulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(DescArticulo, New System.Windows.Forms.Binding("Text", Me, "DescArticulo"))
        Me.DescArticulo.Enabled = False
        Me.DescArticulo.Location = New System.Drawing.Point(176, 14)
        Me.DescArticulo.Name = "DescArticulo"
        Me.DescArticulo.Size = New System.Drawing.Size(393, 21)
        Me.DescArticulo.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Tag = "IdRec=4389;"
        Me.Label1.Text = "Importe"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Tag = ""
        Me.Label2.Text = "Artículo"
        '
        'Representantes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(578, 359)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.BottomPanel)
        Me.CreateTransaction = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Representantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Representantes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.BottomPanel.ResumeLayout(False)
        Me.TopPanel.ResumeLayout(False)
        CType(Me.jngRepresentantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopFrame.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mQueryOnclose As Boolean
    Private mPendingUpdate As Boolean
    Private mPendingDelete As Boolean
    Private mReadOnly As Boolean
    Private mIDLinea As Long
    Private mImporteLinea As Double
    Private mIDMoneda As String
    Private mCambioA As Double
    Private mCambioB As Double
    Private mIDCliente As String
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

    Public WriteOnly Property IDCliente() As String
        Set(ByVal Value As String)
            mIDCliente = Value
        End Set
    End Property

    Public WriteOnly Property SoloLectura() As Boolean
        Set(ByVal Value As Boolean)
            mReadOnly = Value
        End Set
    End Property

    Private Sub jngRepresentantes_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles jngRepresentantes.EditingCell
        Try
            If Not mReadOnly Then
                With jngRepresentantes
                    Select Case e.Column.Key
                        Case "IDRepresentante"
                            If .Row = Grid.newTopRowPosition Then
                                e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                                e.Column.EditType = Janus.Windows.GridEX.EditType.TextBox
                            Else
                                e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                                e.Cancel = True
                            End If
                        Case "Importe"
                            If .Value(.Columns("Porcentaje").Index) Then
                                e.Cancel = True
                            Else
                                e.Column.EditType = Janus.Windows.GridEX.EditType.TextBox
                            End If
                        Case "Comision"
                            If .Value(.Columns("Porcentaje").Index) Then
                                e.Column.EditType = Janus.Windows.GridEX.EditType.TextBox
                            Else
                                e.Cancel = True
                            End If
                    End Select
                End With
            Else
                e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                e.Cancel = True
            End If
        Catch ex As Exception
            e.Cancel = True
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Representantes_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
        Try
            Dim context As New BusinessData

            e.Data.Context.Clear()
            Select Case e.EntityName
                Case jngRepresentantes.EntityName
                    'context("IDLinea") = mIDLinea
                    'context("IDArticulo") = Me.CurrentData.Rows(0)("IDArticulo")
                    'context("SumaImporte") = jngRepresentantes.GetTotalRow.Cells("Importe").Value

                    context("IDCliente") = mIDCliente
                    context("ImporteLinea") = Me.CurrentData.Rows(0)("Importe")
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

    Private Sub Representantes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            mFecha = Today
            If Not IsNothing(Me.CurrentData) AndAlso Me.CurrentData.Rows.Count Then
                mIDLinea = Me.CurrentData.Rows(0)(jngRepresentantes.PrimaryDataFields)
                mImporteLinea = Me.CurrentData.Rows(0)("Importe")
                Dim datMon As New Moneda.DatosObtenerMoneda
                datMon.IDMoneda = mIDMoneda
                datMon.Fecha = mFecha
                Dim MonInfo As MonedaInfo = ExpertisApp.ExecuteTask(Of Moneda.DatosObtenerMoneda, MonedaInfo)(AddressOf Moneda.ObtenerMoneda, datMon)
                mCambioA = MonInfo.CambioA
                mCambioB = MonInfo.CambioB
                With jngRepresentantes
                    If mReadOnly Then
                        'TODO: comprobar por que no funciona el siguiente codigo
                        .AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
                        .AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False
                        .AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
                        .RowHeaders = InheritableBoolean.False
                    Else
                        Dim c As GridEXColumn
                        c = .Columns.Add(.PrimaryDataFields, ColumnType.Text, EditType.TextBox)
                        c.Visible = False
                        .Columns(.PrimaryDataFields).DefaultValue = mIDLinea
                        .Columns("Porcentaje").DefaultValue = True
                        .Columns("Comision").DefaultValue = 0
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

    Private Sub Representantes_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If mQueryOnclose Then
            e.Cancel = (ExpertisApp.GenerateMessage("¿Desea realmente perder el desglose realizado?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No)
        End If
    End Sub

    Private Sub jngRepresentantes_CellValueChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles jngRepresentantes.CellValueChanged
        mQueryOnclose = True
        mPendingUpdate = True
    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub ButtonOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonOK.Click
        Dim close As Boolean = True

        If Not mReadOnly Then
            If mImporteLinea < 0 Then
                If SumaImporte() >= mImporteLinea Then
                    close = True
                    mQueryOnclose = False
                    If mPendingUpdate Or mPendingDelete Then
                        Me.UpdateData()
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
                        Me.UpdateData()
                    End If
                End If
            End If
        End If

        If close Then
            mQueryOnclose = False
            Me.Close()
        End If
    End Sub

    Private Sub jngRepresentantes_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngRepresentantes.RecordUpdated
        SumaImporte()
    End Sub

    Private Sub jngRepresentantes_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngRepresentantes.AddingRecord
        SumaImporte()
    End Sub

    Private Sub jngRepresentantes_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngRepresentantes.RecordsDeleted
        SumaImporte()
        mPendingDelete = True
    End Sub

    Private Sub jngRepresentantes_RowEditCanceled(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles jngRepresentantes.RowEditCanceled
        SumaImporte()
    End Sub

    Private Function SumaImporte() As Double
        Dim c As GridEXColumn = jngRepresentantes.Columns("Importe")
        Dim s As Double = jngRepresentantes.GetTotal(c, AggregateFunction.Sum)
        'c.DefaultValue = xRound(mImporteLinea - s, mMoneda.NDecimalesImporte)
        c.DefaultValue = mImporteLinea - s

        'Return xRound(s, mMoneda.NDecimalesImporte)
        Return s
    End Function
End Class
