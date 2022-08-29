Public Class frmAddBanco
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.Panel2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.ulDescCliente = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.txtCif = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCif = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCliente = New Solmicro.Expertis.Engine.UI.TextBox
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
        Me.txtCif.Location = New System.Drawing.Point(76, 34)
        Me.txtCif.Name = "txtCif"
        Me.txtCif.Size = New System.Drawing.Size(107, 21)
        Me.txtCif.TabIndex = 3
        '
        'lblCif
        '
        Me.lblCif.Location = New System.Drawing.Point(18, 32)
        Me.lblCif.Name = "lblCif"
        Me.lblCif.Size = New System.Drawing.Size(36, 17)
        Me.lblCif.TabIndex = 2
        Me.lblCif.Text = "C.I.F."
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(18, 10)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(43, 17)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "Cliente"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(76, 8)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(139, 21)
        Me.txtCliente.TabIndex = 0
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDBanco", "Banco", "IDBanco", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescBanco", "DescBanco")}))})
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""Predetermina" & _
        "do""><Caption>Predeterminado</Caption><ColumnType>CheckBox</ColumnType><DataMembe" & _
        "r>Predeterminado</DataMember><EditType>CheckBox</EditType><Key>Predeterminado</K" & _
        "ey><Position>0</Position><TextAlignment>Near</TextAlignment><Width>80</Width></C" & _
        "olumn0><Column1 ID=""IDClienteBanco""><Caption>IDClienteBanco</Caption><DataMember" & _
        ">IDClienteBanco</DataMember><Key>IDClienteBanco</Key><Position>1</Position><Text" & _
        "Alignment>Far</TextAlignment><Visible>False</Visible></Column1><Column2 ID=""IDCl" & _
        "iente""><Caption>IDCliente</Caption><DataMember>IDCliente</DataMember><Key>IDClie" & _
        "nte</Key><Position>2</Position><TextAlignment>Near</TextAlignment><Visible>False" & _
        "</Visible></Column2><Column3 ID=""IDBanco""><ButtonStyle>Image</ButtonStyle><Capti" & _
        "on>Banco</Caption><DataMember>IDBanco</DataMember><Key>IDBanco</Key><MaxLength>1" & _
        "0</MaxLength><Position>3</Position><TextAlignment>Near</TextAlignment><Width>67<" & _
        "/Width></Column3><Column4 ID=""DescBanco""><Caption>DescBanco</Caption><DataMember" & _
        ">DescBanco</DataMember><EditType>NoEdit</EditType><Key>DescBanco</Key><Position>" & _
        "4</Position><TextAlignment>Near</TextAlignment><Width>133</Width></Column4><Colu" & _
        "mn5 ID=""Sucursal""><Caption>Sucursal</Caption><DataMember>Sucursal</DataMember><K" & _
        "ey>Sucursal</Key><MaxLength>4</MaxLength><Position>5</Position><TextAlignment>Ne" & _
        "ar</TextAlignment><Width>67</Width></Column5><Column6 ID=""DigitoControl""><Captio" & _
        "n>D.C.</Caption><DataMember>DigitoControl</DataMember><Key>DigitoControl</Key><M" & _
        "axLength>4</MaxLength><Position>6</Position><TextAlignment>Near</TextAlignment><" & _
        "Width>33</Width></Column6><Column7 ID=""NCuenta""><Caption>Núm. Cuenta</Caption><D" & _
        "ataMember>NCuenta</DataMember><Key>NCuenta</Key><MaxLength>10</MaxLength><Positi" & _
        "on>7</Position><TextAlignment>Near</TextAlignment></Column7><Column8 ID=""Domicil" & _
        "io""><Caption>Domicilio</Caption><DataMember>Domicilio</DataMember><Key>Domicilio" & _
        "</Key><MaxLength>100</MaxLength><Position>8</Position><TextAlignment>Near</TextA" & _
        "lignment><Width>133</Width></Column8><Column9 ID=""Telefono""><Caption>Teléfono</C" & _
        "aption><DataMember>Telefono</DataMember><Key>Telefono</Key><MaxLength>25</MaxLen" & _
        "gth><Position>9</Position><TextAlignment>Near</TextAlignment><Width>80</Width></" & _
        "Column9><Column10 ID=""Fax""><Caption>Fax</Caption><DataMember>Fax</DataMember><Ke" & _
        "y>Fax</Key><MaxLength>25</MaxLength><Position>10</Position><TextAlignment>Near</" & _
        "TextAlignment></Column10><Column11 ID=""PersonaContacto""><Caption>Persona Contact" & _
        "o</Caption><DataMember>PersonaContacto</DataMember><Key>PersonaContacto</Key><Ma" & _
        "xLength>100</MaxLength><Position>11</Position><TextAlignment>Near</TextAlignment" & _
        "><Width>113</Width></Column11><Column12 ID=""Swift""><Caption>Swift</Caption><Data" & _
        "Member>Swift</DataMember><Key>Swift</Key><MaxLength>100</MaxLength><Position>12<" & _
        "/Position><TextAlignment>Near</TextAlignment></Column12></Columns><GroupConditio" & _
        "n ID="""" /></RootTable></GridEXLayoutData>"
        Me.Grid.DesignTimeLayout = GridEXLayout1
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EntityName = Nothing
        Me.Grid.FrozenColumns = 1
        Me.Grid.Location = New System.Drawing.Point(0, 63)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(710, 229)
        Me.Grid.TabIndex = 5
        Me.Grid.ViewName = Nothing
        '
        'frmAddBanco
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(710, 338)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmAddBanco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta Banco"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.AllRecords
        End Get
    End Property

    Private mstrIDPais, mstrDescPais, mstrIDAlmacen As String
    Private mintIDClienteBanco As Integer

    Private Sub Grid_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles Grid.AdvSearchSetPredefinedFilter
        Select Case e.Key
            Case "DatosCliente", "ClienteDir"
                e.Filter.Add("IDCliente", FilterOperator.Equal, txtCliente.Text)
        End Select

    End Sub

    Private Sub Grid_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.GotFocus
        With Grid
            .Columns("IDCliente").DefaultValue = txtCliente.Text
        End With
    End Sub

    Private Sub Grid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.DoubleClick
        Try
            With Grid
                If .GetValue("IDClienteBanco") Is Nothing OrElse .GetValue("IDClienteBanco") Is System.DBNull.Value Then
                    ExpertisApp.GenerateMessage("Guarde la información de banco antes de volcarla al mantenimiento origen", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If


                If ExpertisApp.GenerateMessage("Se volcará la línea seleccionada en el mantenimiento origen. ¿Desea continuar.?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    mintIDClienteBanco = .GetValue("IDClienteBanco")
                    Me.Close()
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function OpenAddBanco(ByVal strIDCliente As String, ByVal strDescCliente As String, ByVal strCifCliente As String, _
            ByVal OwnerForm As FormBase) As Integer
        '// NOTA: En el ShowDialog se hace el RetrieveData, que recupera TODOS los campos de la tabla 
        '// principal de la vista para poder modificar los datos del grid.
        '// En ese momento el grid debe estar ya configurado, por lo que se ha implementado este método
        '// con el fin de obtener los valores de la propiedades necesarias y poder configurar el grid 
        '// antes de que se haga el Load.
        txtCliente.Text = strIDCliente
        ulDescCliente.Text = strDescCliente
        txtCif.Text = strCifCliente

        With Grid
            .EntityName = "ClienteBanco"
            .ViewName = "vfrmMntoClienteBanco"

            Dim f As New Filter
            f.Add(New StringFilterItem("IDCliente", FilterOperator.Equal, strIDCliente))

            .Filter = f

            Me.ShowDialog(OwnerForm)

        End With
        Return mintIDClienteBanco

    End Function

    Private Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click

        Dim tienePredet As Boolean
        Dim dt As DataTable = CType(Grid.DataSource, DataTable)
        For Each oRw As DataRow In dt.Select(Nothing, Nothing, DataViewRowState.CurrentRows)
            If Not oRw.IsNull("Predeterminado") AndAlso oRw("Predeterminado") = True Then
                tienePredet = True
            End If
        Next
        If Not tienePredet Then
            ExpertisApp.GenerateMessage("Debe haber un banco predeterminado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Me.UpdateData()
    End Sub
End Class