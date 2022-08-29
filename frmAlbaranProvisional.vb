Public Class frmAlbaranProvisional
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
    Friend WithEvents cmbCancel As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbOK As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancel = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbOK = New Solmicro.Expertis.Engine.UI.Button
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCancel)
        Me.Panel1.Controls.Add(Me.cmbOK)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 211)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(486, 46)
        Me.Panel1.TabIndex = 3
        '
        'cmbCancel
        '
        Me.cmbCancel.Location = New System.Drawing.Point(246, 10)
        Me.cmbCancel.Name = "cmbCancel"
        Me.cmbCancel.Size = New System.Drawing.Size(105, 27)
        Me.cmbCancel.TabIndex = 4
        Me.cmbCancel.Text = "Cancelar"
        '
        'cmbOK
        '
        Me.cmbOK.Location = New System.Drawing.Point(135, 10)
        Me.cmbOK.Name = "cmbOK"
        Me.cmbOK.Size = New System.Drawing.Size(105, 27)
        Me.cmbOK.TabIndex = 3
        Me.cmbOK.Text = "Aceptar"
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("ResponsableExpedicion", "Operario", "IDOperario", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDOperario", "ResponsableExpedicion")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCliente", "Cliente", "IDCliente")})
        Me.Grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDAlbaran""><" & _
        "Caption>IDAlbaran</Caption><DataMember>IDAlbaran</DataMember><Key>IDAlbaran</Key" & _
        "><Position>0</Position><TextAlignment>Near</TextAlignment><Visible>False</Visibl" & _
        "e><Width>80</Width></Column0><Column1 ID=""NAlbaran""><Caption>Nº. Albarán</Captio" & _
        "n><DataMember>NAlbaran</DataMember><Key>NAlbaran</Key><Position>1</Position></Co" & _
        "lumn1><Column2 ID=""IDContador""><Caption>IDContador</Caption><DataMember>IDContad" & _
        "or</DataMember><Key>IDContador</Key><Position>2</Position><TextAlignment>Near</T" & _
        "extAlignment><Visible>False</Visible></Column2><Column3 ID=""FechaAlbaran""><Capti" & _
        "on>Fecha Albarán</Caption><DataMember>FechaAlbaran</DataMember><EditType>Calenda" & _
        "rDropDown</EditType><Key>FechaAlbaran</Key><Position>3</Position><TextAlignment>" & _
        "Near</TextAlignment><Width>91</Width></Column3><Column4 ID=""ResponsableExpedicio" & _
        "n""><Caption>Responsable</Caption><DataMember>ResponsableExpedicion</DataMember><" & _
        "Key>ResponsableExpedicion</Key><Position>4</Position><TextAlignment>Near</TextAl" & _
        "ignment><Width>87</Width></Column4><Column5 ID=""Matricula""><Caption>Matrícula</C" & _
        "aption><DataMember>Matricula</DataMember><Key>Matricula</Key><Position>5</Positi" & _
        "on><TextAlignment>Near</TextAlignment><Width>69</Width></Column5><Column6 ID=""ID" & _
        "Cliente""><Caption>Cliente</Caption><DataMember>IDCliente</DataMember><Key>IDClie" & _
        "nte</Key><Position>6</Position><TextAlignment>Near</TextAlignment></Column6><Col" & _
        "umn7 ID=""DescCliente""><Caption>Desc. Cliente</Caption><DataMember>DescCliente</D" & _
        "ataMember><Key>DescCliente</Key><Position>7</Position><TextAlignment>Near</TextA" & _
        "lignment><Visible>False</Visible></Column7><Column8 ID=""IDDireccion""><Caption>ID" & _
        "Direccion</Caption><DataMember>IDDireccion</DataMember><Key>IDDireccion</Key><Po" & _
        "sition>8</Position><TextAlignment>Near</TextAlignment><Visible>False</Visible></" & _
        "Column8></Columns><GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
        Me.Grid.DesignTimeLayout = GridEXLayout1
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = Nothing
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(486, 211)
        Me.Grid.TabIndex = 4
        Me.Grid.Tag = ""
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = Nothing
        '
        'frmAlbaranProvisional
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(486, 257)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmAlbaranProvisional"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Provisionales de Albaranes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.Panel1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mblnCancel As Boolean
    Private mdtLineas As DataTable
    Private mblnRetornos As Boolean

    Private Sub frmAlbaranProvisional_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Grid.Focus()
        cmbOK.Enabled = (Grid.RowCount > 0)
    End Sub

    Public Function AbrirFormulario(ByVal dtAlbaranes As DataTable, Optional ByVal dtLineas As DataTable = Nothing, Optional ByVal blnRetornos As Boolean = False) As DialogResult

        Grid.DataSource = dtAlbaranes

        mdtLineas = dtLineas
        mblnRetornos = blnRetornos

        Me.ShowDialog()

        Return Me.DialogResult
    End Function

    Private Sub Grid_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Grid.UpdatingRecord
        If Length(Grid.Value("IDAlbaran")) = 0 Then
            e.Cancel = True
            ExpertisApp.GenerateMessage("El Albarán es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'Albarán es un dato obligatorio.
        End If
    End Sub

    Private Sub Grid_UpdatingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles Grid.UpdatingCell
        Select Case e.Column.Key
            Case "IDAlbaran"
                Dim a As New AlbaranVentaCabecera
                Dim dt As DataTable = a.SelOnPrimaryKey(e.Value)
                If IsNothing(dt) OrElse dt.Rows.Count = 0 Then
                    Grid.Value("IDContador") = System.DBNull.Value
                Else
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("El albarán introducido ya existe.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'El albarán ya existe.
                End If
        End Select
    End Sub

    Private Sub cmbOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbOK.Click
        mblnCancel = False
        Dim blnlineas As Boolean
        Dim dv As DataView
        Me.DialogResult = DialogResult.OK
        Dim dt As DataTable = Grid.DataSource
        If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
            If Not IsNothing(mdtLineas) Then
                dv = New DataView(mdtLineas)
                blnlineas = True
            End If
            For Each dr As DataRow In dt.Rows
                If Length(Grid.Value("FechaAlbaran")) = 0 Then
                    mblnCancel = True
                    ExpertisApp.GenerateMessage("Datos incompletos.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Grid.Focus()
                    Grid.Col = Grid.Columns("FechaAlbaran").Position
                    Exit For
                Else
                    If blnlineas = True Then
                        dv.RowFilter = "IDAlbaran = " & dr("IDAlbaran")
                        For Each drv As DataRowView In dv
                            drv("FechaAlquiler") = dr("FechaAlbaran")
                        Next
                        dv.RowFilter = String.Empty
                    End If
                End If
            Next
        End If

        Me.Close()
    End Sub

    Private Sub cmbCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancel.Click
        Me.DialogResult = DialogResult.Cancel
        mblnCancel = False
        Me.Close()
    End Sub

    Private Sub frmAlbaranProvisional_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = mblnCancel
    End Sub

    Private Sub Grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        Select Case e.Column.Key
            Case "FechaAlbaran"
                If mblnRetornos = True Then e.Cancel = True
        End Select
    End Sub
End Class