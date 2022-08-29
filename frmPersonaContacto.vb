Public Class FrmPersonaContacto
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
    Friend WithEvents jngContacto As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim jngContacto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngContacto_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPersonaContacto))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.jngContacto = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1.suspendlayout()
        CType(Me.jngContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdCancelar)
        Me.Panel1.Controls.Add(Me.cmdAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 271)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(746, 54)
        Me.Panel1.TabIndex = 231
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(376, 7)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmdCancelar.TabIndex = 15
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdAceptar.Location = New System.Drawing.Point(276, 7)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(94, 29)
        Me.cmdAceptar.TabIndex = 14
        Me.cmdAceptar.Text = "Aceptar"
        '
        'jngContacto
        '
        Me.jngContacto.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCargo", "Cargo", "IDCargo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescCargo", "DescCargo")}), "tbMaestroCargo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("Nombre", "ClientePersonaContacto", "Nombre", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("telefono1", "telefono1"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("telefono2", "telefono2"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Fax", "Fax"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Email", "Email"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Predeterminada", "Predeterminada"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IdCargo", "IdCargo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDPersonaContacto", "IDPersonaContacto"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDPersona", "IDClientePersonaContacto")}), "tbClientePersonaContacto"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDPersonaContacto", "PersonaContacto", "IDPersonaContacto", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Nombre", "Nombre")}), "tbMaestroPersonaContacto")})
        jngContacto_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("jngContacto_DesignTimeLayout_Reference_0.Instance"), Object)
        jngContacto_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {jngContacto_DesignTimeLayout_Reference_0})
        jngContacto_DesignTimeLayout.LayoutString = resources.GetString("jngContacto_DesignTimeLayout.LayoutString")
        Me.jngContacto.DesignTimeLayout = jngContacto_DesignTimeLayout
        Me.jngContacto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngContacto.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngContacto.EntityName = Nothing
        Me.jngContacto.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngContacto.Location = New System.Drawing.Point(0, 0)
        Me.jngContacto.Name = "jngContacto"
        Me.jngContacto.PrimaryDataFields = Nothing
        Me.jngContacto.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.jngContacto.SecondaryDataFields = Nothing
        Me.jngContacto.Size = New System.Drawing.Size(746, 271)
        Me.jngContacto.TabIndex = 232
        Me.jngContacto.ViewName = Nothing
        '
        'FrmPersonaContacto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(746, 325)
        Me.Controls.Add(Me.jngContacto)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "FrmPersonaContacto"
        Me.Text = "Personas Contacto"
        Me.Panel1.ResumeLayout(False)
        CType(Me.jngContacto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Enum TipoContacto
        Cliente = 0
        Obra = 1
        Oferta = 2
    End Enum

    Public Enum TipoCliente
        Cliente = 0
        Empresa = 1
    End Enum

#Region " Propiedades "

    '//Con ésta propiedad se devolverá el IDPersonaContacto del último creado, .....

    Public Property IDPersonaContacto() As Integer
        Get
            Return mintIDPersonaContacto
        End Get
        Set(ByVal Value As Integer)
            mintIDPersonaContacto = Value
        End Set
    End Property

    Public Property Contacto() As String
        Get
            Return mstrContacto
        End Get
        Set(ByVal Value As String)
            mstrContacto = Value
        End Set
    End Property

#End Region

    Private mintIDPersonaContacto, mintIDObra As Integer
    Private mstrContacto, mstrIDClienteEmpresa As String
    Private mintTipoContacto As TipoContacto
    Private mintTipoCliente As TipoCliente = TipoCliente.Cliente

#Region " Carga del formulario "

    Public Sub AbrirPersonaContacto(ByVal intTCto As TipoContacto, ByVal strIDClienteEmpresa As String, _
                                    Optional ByVal intIDObraPresup As Integer = 0, _
                                    Optional ByVal intTClte As TipoCliente = TipoCliente.Cliente)

        mintTipoContacto = intTCto
        mintTipoCliente = intTClte
        mstrIDClienteEmpresa = strIDClienteEmpresa
        mintIDObra = intIDObraPresup

        If ComprobarCamposNecesarios() Then
            LoadSettingsGrid()
            LoadAdvSearchGrid()
            LoadDefaultValues()

            Me.ShowDialog()
        End If
    End Sub

    Private Function ComprobarCamposNecesarios() As Boolean
        Dim blnOK As Boolean = True
        If Length(mstrIDClienteEmpresa) = 0 Then
            blnOK = False
            ExpertisApp.GenerateMessage("Debe introducir el Cliente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If mintTipoContacto <> TipoContacto.Cliente AndAlso mintIDObra = 0 Then
            blnOK = False
            Select Case mintTipoContacto
                Case TipoContacto.Obra
                    ExpertisApp.GenerateMessage("Debe introducir el Proyecto.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case TipoContacto.Oferta
                    ExpertisApp.GenerateMessage("Debe introducir la Oferta.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        End If

        Return blnOK
    End Function

    Private Sub LoadSettingsGrid()
        With jngContacto
            .Columns("NombreCli").Visible = False
            .Columns("Nombre").Visible = False
            Select Case mintTipoContacto
                Case TipoContacto.Cliente
                    .EntityName = "ClientePersonaContacto"
                    .ViewName = "vfrmClientePersonaContacto"
                    .Columns("CIFCliente").Visible = False
                    .Columns("NombreCli").Visible = True
                    .Columns("Activo").Visible = True
                    .Columns("Activo").EditType = EditType.CheckBox
                    .Columns("Activo").DefaultValue = True
                Case TipoContacto.Obra
                    .EntityName = "ObraPersonaContacto"
                    .ViewName = "vfrmObraPersonaContacto"
                    .Columns("Nombre").Visible = True
                    .Columns("Activo").Visible = True
                    .Columns("Activo").EditType = EditType.CheckBox
                    .Columns("Activo").DefaultValue = True
                Case TipoContacto.Oferta
                    .EntityName = "ObraPresupContacto"
                    .ViewName = "VfrmObraPresupContactos"
                    .Columns("Nombre").Visible = True
            End Select

            Dim objFilter As New Filter
            Dim strCampoClienteEmpresa As String
            Select Case mintTipoCliente
                Case TipoCliente.Empresa
                    strCampoClienteEmpresa = "IDEmpresa"
                Case Else
                    strCampoClienteEmpresa = "IDCliente"
            End Select
            If Length(mstrIDClienteEmpresa) > 0 Then objFilter.Add(New StringFilterItem(strCampoClienteEmpresa, mstrIDClienteEmpresa))
            If mintIDObra <> 0 Then objFilter.Add(New NumberFilterItem("IDObra", mintIDObra))
            jngContacto.Filter = objFilter
        End With
    End Sub

    Private Sub LoadAdvSearchGrid()
        With jngContacto
            Select Case mintTipoContacto
                Case TipoContacto.Oferta
                    Select Case mintTipoCliente
                        Case TipoCliente.Empresa
                            .AdvSearchColumns("Nombre").EntityName = "EmpresaPersona"
                            .AdvSearchColumns("Nombre").ViewName = "tbEmpresaPersona"
                            .AdvSearchColumns("Nombre").Key = "Nombre"
                            .AdvSearchColumns("Nombre").SelectedField = "Nombre"

                            .AdvSearchColumns("Nombre").SelectedColumns.Clear()
                            Dim asc As Solmicro.Expertis.Engine.UI.ASSelectedColumn

                            asc = New Solmicro.Expertis.Engine.UI.ASSelectedColumn
                            asc.GridColumn = "Telefono1"
                            asc.SelectedColumn = "TelefonoDirecto"
                            .AdvSearchColumns("Nombre").SelectedColumns.Add(asc)

                            asc = New Solmicro.Expertis.Engine.UI.ASSelectedColumn
                            asc.GridColumn = "Telefono2"
                            asc.SelectedColumn = "TelefonoMovil"
                            .AdvSearchColumns("Nombre").SelectedColumns.Add(asc)

                            asc = New Solmicro.Expertis.Engine.UI.ASSelectedColumn
                            asc.GridColumn = "Fax"
                            asc.SelectedColumn = "Fax"
                            .AdvSearchColumns("Nombre").SelectedColumns.Add(asc)

                            asc = New Solmicro.Expertis.Engine.UI.ASSelectedColumn
                            asc.GridColumn = "Email"
                            asc.SelectedColumn = "Email"
                            .AdvSearchColumns("Nombre").SelectedColumns.Add(asc)

                            asc = New Solmicro.Expertis.Engine.UI.ASSelectedColumn
                            asc.GridColumn = "Predeterminada"
                            asc.SelectedColumn = "Predeterminada"
                            .AdvSearchColumns("Nombre").SelectedColumns.Add(asc)

                            asc = New Solmicro.Expertis.Engine.UI.ASSelectedColumn
                            asc.GridColumn = "IDCargo"
                            asc.SelectedColumn = "IDCargo"
                            .AdvSearchColumns("Nombre").SelectedColumns.Add(asc)
                    End Select
            End Select
        End With
    End Sub

    Private Sub LoadDefaultValues()
        With jngContacto
            .Columns("AltaAutomatica").DefaultValue = True
            .Columns("IDCliente").DefaultValue = mstrIDClienteEmpresa
            Select Case mintTipoContacto
                Case TipoContacto.Obra
                    .Columns("IDObra").DefaultValue = mintIDObra
                Case TipoContacto.Oferta
                    .Columns("IDPresup").DefaultValue = mintIDObra
            End Select
            .Columns("Predeterminada").DefaultValue = False
        End With
    End Sub


#End Region

#Region " Grid "

    Private Sub jngContacto_AdvSearchNotInList(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchNotInListEventArgs) Handles jngContacto.AdvSearchNotInList
         Select e.Key
            Case "Nombre"
                e.Handled = True
                e.Cancel = False
        End Select
    End Sub

    Private Sub jngContacto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngContacto.GotFocus
        jngContacto.Columns("Predeterminada").DefaultValue = False
    End Sub

    Private Sub jngContacto_ColumnButtonClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles jngContacto.ColumnButtonClick
        Select Case e.Column.Key
            Case "Email"
                If Length(jngContacto.Value("Email")) > 0 Then
                    Process.Start("mailto:" & jngContacto.Value("Email"))
                End If
        End Select
    End Sub

    Private Sub jngContacto_DeletingRecords(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngContacto.DeletingRecords
        With jngContacto
            '//Si se va a borrar una linea con marca "predet", no se debe dejar borrar. A menos que sea la última.
            If .RowCount > 1 AndAlso (.Value("Predeterminada")) Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("No se puede eliminar el registro predeterminado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End With
    End Sub

    Private Sub jngContacto_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles jngContacto.AdvSearchSetPredefinedFilter
        With jngContacto
            Select Case e.Key
                Case "Nombre"
                    Select Case mintTipoCliente
                        Case TipoCliente.Empresa
                            e.Filter.Add(New StringFilterItem("IDEmpresa", mstrIDClienteEmpresa))
                        Case Else
                            e.Filter.Add(New StringFilterItem("IDCliente", mstrIDClienteEmpresa))
                    End Select
            End Select
        End With
    End Sub

    Private Sub jngContacto_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles jngContacto.EditingCell
        With jngContacto
            Select Case e.Column.Key
                Case "Predeterminada"
                    If .Row <> Grid.newTopRowPosition Then
                        '//NOTA: Ver evento Click. Complementa el caso en el que estaba la marca activada.
                        If e.Value Then    '//Si estaba marcada, no la dejamos desmarcar
                            e.Cancel = True
                        Else
                            '//Si la marcamos, se desmarca la que estaba marcada.
                            Dim objFilterPred As New Filter
                            objFilterPred.Add(New BooleanFilterItem("Predeterminada", True))
                            For Each drRow As DataRow In CType(jngContacto.DataSource, DataTable).Select(objFilterPred.Compose(New AdoFilterComposer))
                                .GetRow(drRow).BeginEdit()
                                .GetRow(drRow).Cells("Predeterminada").Value = False
                                .GetRow(drRow).EndEdit()
                            Next
                        End If
                    End If
                Case "IDPersonaContacto"
                    e.Cancel = True
                Case "Nombre"
                    '.Value("AltaAutomatica") = True

                    '//El nombre se podrá rellenar de dos formas, si viene por la persona de contacto, o bien, si lo añadimos manualmente.
                    If Length(.Value("IDPersonaContacto")) > 0 Then
                        e.Cancel = True
                    Else
                        .Columns(e.Column.Index).EditType = Janus.Windows.GridEX.EditType.TextBox
                    End If
                    If Me.mintTipoContacto = TipoContacto.Cliente Then
                        e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                    Else
                        e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                    End If
            End Select
        End With
    End Sub

    Private Sub jngContacto_AdvSearchSelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchSelectionChangedEventArgs) Handles jngContacto.AdvSearchSelectionChanged
        Select Case e.Key
            Case "IDPersonaContacto"
                '//NOTA: De momento ponemos esto, por que si no no saltan las BusinessRules.
                Dim contacto As New BusinessData
                contacto.Add("IDPersonaContacto", jngContacto.Value("IDPersonaContacto"))
                contacto.Add("Nombre", jngContacto.Value("Nombre"))
                contacto.Add("IDCargo", jngContacto.Value("IDCargo"))
                Dim objNegOPC As New ClientePersonaContacto
                contacto = objNegOPC.ApplyBusinessRule("IDPersonaContacto", jngContacto.Value("IDPersonaContacto"), contacto)
                jngContacto.SetValue("Nombre", contacto("Nombre"))
                jngContacto.SetValue("IDCargo", contacto("IDCargo"))
                jngContacto.SetValue("Predeterminada", False)
            Case "Nombre"
                jngContacto.SetValue("AltaAutomatica", False)
        End Select
    End Sub

    Private Sub jngContacto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngContacto.Click
        With jngContacto
            Dim hit As GridArea = .HitTest()
            If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                Dim c As GridEXColumn = .ColumnFromPoint()
                If Not IsNothing(c) Then
                    Select Case c.Key
                        Case "Predeterminada"
                            If .Row <> Grid.newTopRowPosition Then
                                '//NOTA: Esto es necesario. Es una especie de cancelación de edición. 
                                '//El EditingCell salta una vez y si volvemos a clickar no vuelve a saltar, por estar el registro ya en 
                                '//edición, aunque si cambia el valor. Entonces, hay que volver a poner el valor que nos interesa.
                                '//Ver evento EditingCell
                                .GetRow(.Row).BeginEdit()
                                .GetRow(.Row).Cells(c.Key).Value = True
                                .GetRow(.Row).EndEdit()
                                .Refresh()
                            End If
                    End Select
                End If
            End If
        End With
    End Sub

    Private Sub jngContacto_RecordAdding_Updating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngContacto.AddingRecord, jngContacto.UpdatingRecord
        With jngContacto
            If .Row = Grid.newTopRowPosition Then
                If Length(.Value("IDPersonaContacto")) = 0 AndAlso Length(.Value("nombreCli")) = 0 AndAlso Length(.Value("nombre")) = 0 Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("Debe indicar al menos la Persona de Contacto o el Nombre.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    If .Value("Predeterminada") Then
                        Dim objFilterPred As New Filter
                        objFilterPred.Clear()
                        objFilterPred.Add(New BooleanFilterItem("Predeterminada", True))
                        For Each drRow As DataRow In CType(.DataSource, DataTable).Select(objFilterPred.Compose(New AdoFilterComposer))
                            .GetRow(drRow).BeginEdit()
                            .GetRow(drRow).Cells("Predeterminada").Value = False
                            .GetRow(drRow).EndEdit()
                        Next
                    End If
                End If
            End If

            If Length(.Value("IDPersonaContacto")) = 0 AndAlso Nz(jngContacto.Value("AltaAutomatica"), False) Then
                If ExpertisApp.GenerateMessage("El contacto no existe en la Gestión de Contactos. ¿Desea darlo de alta automaticamente?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    AltaNuevoContacto()
                Else
                    .Value("AltaAutomatica") = False
                End If
            End If
            If .RowCount = 0 Then
                .Value("Predeterminada") = True
            End If
        End With

    End Sub

    Private Sub jngContacto_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles jngContacto.CellUpdated
        If e.Column.Key = "Nombre" AndAlso jngContacto.Row = Grid.newTopRowPosition Then
            jngContacto.SetValue("Predeterminada", False)
        End If
    End Sub

    Private Sub AltaNuevoContacto()
        With jngContacto
            Select Case Me.mintTipoContacto
                Case TipoContacto.Cliente
                    Dim datosCtcto As New PersonaContacto.DatosAltaNuevoContacto
                    datosCtcto.Nombre = .Value("Nombre") & String.Empty
                    datosCtcto.IDCargo = .Value("IDCargo") & String.Empty
                    mintIDPersonaContacto = ExpertisApp.ExecuteTask(Of PersonaContacto.DatosAltaNuevoContacto, Integer)(AddressOf PersonaContacto.AltaNuevoContacto, datosCtcto)
                Case TipoContacto.Obra, TipoContacto.Oferta
                    Dim StDataCon As New ClientePersonaContacto.DataNuevoContacto
                    StDataCon.IDCliente = .Value("IDCliente") & String.Empty
                    StDataCon.Nombre = .Value("Nombre") & String.Empty
                    StDataCon.Telefono1 = .Value("Telefono1") & String.Empty
                    StDataCon.Telefono2 = .Value("Telefono2") & String.Empty
                    StDataCon.EMail = .Value("Email") & String.Empty
                    StDataCon.Fax = .Value("Email") & String.Empty
                    StDataCon.IDCargo = .Value("IDCargo") & String.Empty
                    mintIDPersonaContacto = ExpertisApp.ExecuteTask(Of ClientePersonaContacto.DataNuevoContacto, Integer)(AddressOf ClientePersonaContacto.AltaNuevoContacto, StDataCon)
            End Select

            .Value("IDPersonaContacto") = mintIDPersonaContacto
        End With
    End Sub

#End Region

#Region " Aceptar/Cancelar "

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.UpdateData()

        '//Devolvemos el Nombre del Contacto Predeterminado
        Dim objFilter As New Filter
        objFilter.Add(New BooleanFilterItem("Predeterminada", True))
        Dim dvPredeter As DataView = New DataView(jngContacto.DataSource, objFilter.Compose(New AdoFilterComposer), Nothing, DataViewRowState.CurrentRows)
        If Not IsNothing(dvPredeter) AndAlso dvPredeter.Count > 0 Then
            Me.mstrContacto = dvPredeter(0)("Nombre")
        Else
            Me.mstrContacto = String.Empty
        End If

        Me.Close()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        mstrContacto = String.Empty
        mintIDPersonaContacto = 0
        Me.Close()
    End Sub

#End Region

End Class