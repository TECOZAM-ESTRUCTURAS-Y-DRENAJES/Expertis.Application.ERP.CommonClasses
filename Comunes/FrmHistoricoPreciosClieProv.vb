Public Class FrmHistoricoPreciosClieProv

#Region "Variables Privadas / Propiedades Públicas"

    Private MIDArticulo As String
    Public WriteOnly Property IDArticulo() As String
        Set(ByVal value As String)
            MIDArticulo = value
        End Set
    End Property

    Private MDescArticulo As String
    Public WriteOnly Property DescArticulo() As String
        Set(ByVal value As String)
            MDescArticulo = value
        End Set
    End Property

    Private MQuantity As Double
    Public WriteOnly Property Cantidad() As Double
        Set(ByVal value As Double)
            MQuantity = value
        End Set
    End Property

    Private MIDEntity As String
    Public WriteOnly Property IDEntity() As String
        Set(ByVal value As String)
            MIDEntity = value
        End Set
    End Property

    Private MDescIdentity As String
    Public WriteOnly Property DescIdentity() As String
        Set(ByVal value As String)
            MDescIdentity = value
        End Set
    End Property

    Private MEntity As Object
    Public WriteOnly Property Entity() As Object
        Set(ByVal value As Object)
            MEntity = value
        End Set
    End Property

    Private MOpt As Opt
    Public Enum Opt
        PreciosClientes = 0
        PreciosClientesLineas = 1
        PreciosProveedores = 2
        PreciosProveedoresLineas = 3
    End Enum

    Public WriteOnly Property Opcion() As Opt
        Set(ByVal value As Opt)
            MOpt = value
        End Set
    End Property

    Private MPrecio As Double
    Public WriteOnly Property Precio() As Double
        Set(ByVal value As Double)
            MPrecio = value
        End Set
    End Property

    Private MPVP As Double
    Public WriteOnly Property PVP() As Double
        Set(ByVal value As Double)
            MPVP = value
        End Set
    End Property

    Private MDto1 As Double
    Public WriteOnly Property Dto1() As Double
        Set(ByVal value As Double)
            MDto1 = value
        End Set
    End Property

    Private MDto2 As Double
    Public WriteOnly Property Dto2() As Double
        Set(ByVal value As Double)
            MDto2 = value
        End Set
    End Property

    Private MDto3 As Double
    Public WriteOnly Property Dto3() As Double
        Set(ByVal value As Double)
            MDto3 = value
        End Set
    End Property

    Private mEntityName As String

#End Region

#Region "Funciones / Procesos Privados"

    Private Sub LoadDesign()

        Dim ColIDArticulo As New GridEXColumn
        ColIDArticulo.Key = "IDArticulo"
        ColIDArticulo.Caption = "Artículo"
        ColIDArticulo.DataMember = "IDArticulo"
        ColIDArticulo.DefaultValue = MIDArticulo
        ColIDArticulo.BoundMode = ColumnBoundMode.Bound
        ColIDArticulo.ColumnType = ColumnType.Text
        ColIDArticulo.EditType = EditType.NoEdit
        ColIDArticulo.Visible = False
        Me.GrdHistorico.Columns.Add(ColIDArticulo)

        Dim ColFechaDesde As New GridEXColumn
        ColFechaDesde.Key = "FechaDesde"
        ColFechaDesde.Caption = "Fecha Desde"
        ColFechaDesde.DataMember = "FechaDesde"
        ColFechaDesde.DefaultValue = Today.Date
        ColFechaDesde.FormatString = "dd/MM/yyyy"
        ColFechaDesde.BoundMode = ColumnBoundMode.Bound
        ColFechaDesde.ColumnType = ColumnType.Text
        ColFechaDesde.EditType = EditType.CalendarCombo
        Me.GrdHistorico.Columns.Add(ColFechaDesde)

        Dim ColFechaHasta As New GridEXColumn
        ColFechaHasta.Key = "FechaHasta"
        ColFechaHasta.Caption = "Fecha Hasta"
        ColFechaHasta.DataMember = "FechaHasta"
        ColFechaHasta.DefaultValue = Today.Date
        ColFechaHasta.FormatString = "dd/MM/yyyy"
        ColFechaHasta.BoundMode = ColumnBoundMode.Bound
        ColFechaHasta.ColumnType = ColumnType.Text
        ColFechaHasta.EditType = EditType.CalendarCombo
        Me.GrdHistorico.Columns.Add(ColFechaHasta)

        Dim ColPrecio As New GridEXColumn
        ColPrecio.Key = "Precio"
        ColPrecio.Caption = "Precio"
        ColPrecio.DataMember = "Precio"
        ColPrecio.DefaultValue = MPrecio
        'ColPrecio.FormatString = "#0.00"
        ColPrecio.TextAlignment = TextAlignment.Far
        ColPrecio.BoundMode = ColumnBoundMode.Bound
        ColPrecio.ColumnType = ColumnType.Text
        ColPrecio.EditType = EditType.TextBox
        Me.GrdHistorico.Columns.Add(ColPrecio)
        Select Case MOpt
            Case Opt.PreciosClientes
                Dim ColClie As New GridEXColumn
                ColClie.Key = "IDCliente"
                ColClie.Caption = "Cliente"
                ColClie.DataMember = "IDCliente"
                ColClie.DefaultValue = MIDEntity
                ColClie.BoundMode = ColumnBoundMode.Bound
                ColClie.ColumnType = ColumnType.Text
                ColClie.EditType = EditType.NoEdit
                ColClie.Visible = False
                Me.GrdHistorico.Columns.Add(ColClie)

                Dim ColPVP As New GridEXColumn
                ColPVP.Key = "PVP"
                ColPVP.Caption = "P.V.P."
                ColPVP.DataMember = "PVP"
                ColPVP.DefaultValue = MPVP
                'ColPVP.FormatString = "#0.00"
                ColPVP.TextAlignment = TextAlignment.Far
                ColPVP.BoundMode = ColumnBoundMode.Bound
                ColPVP.ColumnType = ColumnType.Text
                ColPVP.EditType = EditType.TextBox
                Me.GrdHistorico.Columns.Add(ColPVP)

                Dim ColDto1 As New GridEXColumn
                ColDto1.Key = "Dto1"
                ColDto1.Caption = "Dto1"
                ColDto1.DataMember = "Dto1"
                ColDto1.DefaultValue = MDto1
                ColDto1.FormatString = "#0.00"
                ColDto1.TextAlignment = TextAlignment.Far
                ColDto1.BoundMode = ColumnBoundMode.Bound
                ColDto1.ColumnType = ColumnType.Text
                ColDto1.EditType = EditType.TextBox
                Me.GrdHistorico.Columns.Add(ColDto1)

                Dim ColDto2 As New GridEXColumn
                ColDto2.Key = "Dto2"
                ColDto2.Caption = "Dto2"
                ColDto2.DataMember = "Dto2"
                ColDto2.DefaultValue = MDto2
                ColDto2.FormatString = "#0.00"
                ColDto2.TextAlignment = TextAlignment.Far
                ColDto2.BoundMode = ColumnBoundMode.Bound
                ColDto2.ColumnType = ColumnType.Text
                ColDto2.EditType = EditType.TextBox
                Me.GrdHistorico.Columns.Add(ColDto2)

                Dim ColDto3 As New GridEXColumn
                ColDto3.Key = "Dto3"
                ColDto3.Caption = "Dto3"
                ColDto3.DataMember = "Dto3"
                ColDto3.DefaultValue = MDto3
                ColDto3.FormatString = "#0.00"
                ColDto3.TextAlignment = TextAlignment.Far
                ColDto3.BoundMode = ColumnBoundMode.Bound
                ColDto3.ColumnType = ColumnType.Text
                ColDto3.EditType = EditType.TextBox
                Me.GrdHistorico.Columns.Add(ColDto3)
            Case Opt.PreciosClientesLineas
                Dim ColClie As New GridEXColumn
                ColClie.Key = "IDCliente"
                ColClie.Caption = "Cliente"
                ColClie.DataMember = "IDCliente"
                ColClie.DefaultValue = MIDEntity
                ColClie.BoundMode = ColumnBoundMode.Bound
                ColClie.ColumnType = ColumnType.Text
                ColClie.EditType = EditType.NoEdit
                ColClie.Visible = False
                Me.GrdHistorico.Columns.Add(ColClie)

                Dim ColQDesde As New GridEXColumn
                ColQDesde.Key = "QDesde"
                ColQDesde.Caption = "Q. Desde"
                ColQDesde.DataMember = "QDesde"
                ColQDesde.DefaultValue = MQuantity
                ColQDesde.FormatString = "#0.00"
                ColQDesde.TextAlignment = TextAlignment.Far
                ColQDesde.BoundMode = ColumnBoundMode.Bound
                ColQDesde.ColumnType = ColumnType.Text
                ColQDesde.EditType = EditType.NoEdit
                ColQDesde.Visible = False
                Me.GrdHistorico.Columns.Add(ColQDesde)

                Dim ColPVP As New GridEXColumn
                ColPVP.Key = "PVP"
                ColPVP.Caption = "P.V.P."
                ColPVP.DataMember = "PVP"
                ColPVP.DefaultValue = MPVP
                'ColPVP.FormatString = "#0.00"
                ColPVP.TextAlignment = TextAlignment.Far
                ColPVP.BoundMode = ColumnBoundMode.Bound
                ColPVP.ColumnType = ColumnType.Text
                ColPVP.EditType = EditType.TextBox
                Me.GrdHistorico.Columns.Add(ColPVP)

                Dim ColDto1 As New GridEXColumn
                ColDto1.Key = "Dto1"
                ColDto1.Caption = "Dto1"
                ColDto1.DataMember = "Dto1"
                ColDto1.DefaultValue = MDto1
                ColDto1.FormatString = "#0.00"
                ColDto1.TextAlignment = TextAlignment.Far
                ColDto1.BoundMode = ColumnBoundMode.Bound
                ColDto1.ColumnType = ColumnType.Text
                ColDto1.EditType = EditType.TextBox
                Me.GrdHistorico.Columns.Add(ColDto1)

                Dim ColDto2 As New GridEXColumn
                ColDto2.Key = "Dto2"
                ColDto2.Caption = "Dto2"
                ColDto2.DataMember = "Dto2"
                ColDto2.DefaultValue = MDto2
                ColDto2.FormatString = "#0.00"
                ColDto2.TextAlignment = TextAlignment.Far
                ColDto2.BoundMode = ColumnBoundMode.Bound
                ColDto2.ColumnType = ColumnType.Text
                ColDto2.EditType = EditType.TextBox
                Me.GrdHistorico.Columns.Add(ColDto2)

                Dim ColDto3 As New GridEXColumn
                ColDto3.Key = "Dto3"
                ColDto3.Caption = "Dto3"
                ColDto3.DataMember = "Dto3"
                ColDto3.DefaultValue = MDto3
                ColDto3.FormatString = "#0.00"
                ColDto3.TextAlignment = TextAlignment.Far
                ColDto3.BoundMode = ColumnBoundMode.Bound
                ColDto3.ColumnType = ColumnType.Text
                ColDto3.EditType = EditType.TextBox
                Me.GrdHistorico.Columns.Add(ColDto3)
            Case Opt.PreciosProveedores
                Dim ColProv As New GridEXColumn
                ColProv.Key = "IDProveedor"
                ColProv.Caption = "Proveedor"
                ColProv.DataMember = "IDProveedor"
                ColProv.DefaultValue = MIDEntity
                ColProv.BoundMode = ColumnBoundMode.Bound
                ColProv.ColumnType = ColumnType.Text
                ColProv.EditType = EditType.NoEdit
                ColProv.Visible = False
                Me.GrdHistorico.Columns.Add(ColProv)

                Dim ColDto1 As New GridEXColumn
                ColDto1.Key = "Dto1"
                ColDto1.Caption = "Dto1"
                ColDto1.DataMember = "Dto1"
                ColDto1.DefaultValue = MDto1
                ColDto1.FormatString = "#0.00"
                ColDto1.TextAlignment = TextAlignment.Far
                ColDto1.BoundMode = ColumnBoundMode.Bound
                ColDto1.ColumnType = ColumnType.Text
                ColDto1.EditType = EditType.TextBox
                Me.GrdHistorico.Columns.Add(ColDto1)

                Dim ColDto2 As New GridEXColumn
                ColDto2.Key = "Dto2"
                ColDto2.Caption = "Dto2"
                ColDto2.DataMember = "Dto2"
                ColDto2.DefaultValue = MDto2
                ColDto2.FormatString = "#0.00"
                ColDto2.TextAlignment = TextAlignment.Far
                ColDto2.BoundMode = ColumnBoundMode.Bound
                ColDto2.ColumnType = ColumnType.Text
                ColDto2.EditType = EditType.TextBox
                Me.GrdHistorico.Columns.Add(ColDto2)

                Dim ColDto3 As New GridEXColumn
                ColDto3.Key = "Dto3"
                ColDto3.Caption = "Dto3"
                ColDto3.DataMember = "Dto3"
                ColDto3.DefaultValue = MDto3
                ColDto3.FormatString = "#0.00"
                ColDto3.TextAlignment = TextAlignment.Far
                ColDto3.BoundMode = ColumnBoundMode.Bound
                ColDto3.ColumnType = ColumnType.Text
                ColDto3.EditType = EditType.TextBox
                Me.GrdHistorico.Columns.Add(ColDto3)
            Case Opt.PreciosProveedoresLineas
                Dim ColProv As New GridEXColumn
                ColProv.Key = "IDProveedor"
                ColProv.Caption = "Proveedor"
                ColProv.DataMember = "IDProveedor"
                ColProv.DefaultValue = MIDEntity
                ColProv.BoundMode = ColumnBoundMode.Bound
                ColProv.ColumnType = ColumnType.Text
                ColProv.EditType = EditType.NoEdit
                ColProv.Visible = False
                Me.GrdHistorico.Columns.Add(ColProv)

                Dim ColQDesde As New GridEXColumn
                ColQDesde.Key = "QDesde"
                ColQDesde.Caption = "Q. Desde"
                ColQDesde.DataMember = "QDesde"
                ColQDesde.DefaultValue = MQuantity
                ColQDesde.FormatString = "#0.00"
                ColQDesde.TextAlignment = TextAlignment.Far
                ColQDesde.BoundMode = ColumnBoundMode.Bound
                ColQDesde.ColumnType = ColumnType.Text
                ColQDesde.EditType = EditType.NoEdit
                ColQDesde.Visible = False
                Me.GrdHistorico.Columns.Add(ColQDesde)

                Dim ColDto1 As New GridEXColumn
                ColDto1.Key = "Dto1"
                ColDto1.Caption = "Dto1"
                ColDto1.DataMember = "Dto1"
                ColDto1.DefaultValue = MDto1
                ColDto1.FormatString = "#0.00"
                ColDto1.TextAlignment = TextAlignment.Far
                ColDto1.BoundMode = ColumnBoundMode.Bound
                ColDto1.ColumnType = ColumnType.Text
                ColDto1.EditType = EditType.TextBox
                Me.GrdHistorico.Columns.Add(ColDto1)

                Dim ColDto2 As New GridEXColumn
                ColDto2.Key = "Dto2"
                ColDto2.Caption = "Dto2"
                ColDto2.DataMember = "Dto2"
                ColDto2.DefaultValue = MDto2
                ColDto2.FormatString = "#0.00"
                ColDto2.TextAlignment = TextAlignment.Far
                ColDto2.BoundMode = ColumnBoundMode.Bound
                ColDto2.ColumnType = ColumnType.Text
                ColDto2.EditType = EditType.TextBox
                Me.GrdHistorico.Columns.Add(ColDto2)

                Dim ColDto3 As New GridEXColumn
                ColDto3.Key = "Dto3"
                ColDto3.Caption = "Dto3"
                ColDto3.DataMember = "Dto3"
                ColDto3.DefaultValue = MDto3
                ColDto3.FormatString = "#0.00"
                ColDto3.TextAlignment = TextAlignment.Far
                ColDto3.BoundMode = ColumnBoundMode.Bound
                ColDto3.ColumnType = ColumnType.Text
                ColDto3.EditType = EditType.TextBox
                Me.GrdHistorico.Columns.Add(ColDto3)
        End Select
        'David 29/10/21
        Dim ColTexto As New GridEXColumn
        ColTexto.Key = "Texto"
        ColTexto.Caption = "Texto"
        ColTexto.DataMember = "Texto"
        ColTexto.DefaultValue = ""
        ColTexto.TextAlignment = TextAlignment.Far
        ColTexto.BoundMode = ColumnBoundMode.Bound
        ColTexto.ColumnType = ColumnType.Text
        ColTexto.EditType = EditType.TextBox
        Me.GrdHistorico.Columns.Add(ColTexto)
        'Fin David

    End Sub

    Private Sub LoadData()
        Dim FilEntity As New Filter
        Select Case MOpt
            Case Opt.PreciosClientes
                mEntityName = GetType(HistoricoPreciosCliente).Name
                Me.LblIdentity.Text = "Cliente"
                FilEntity.Add("IDCliente", FilterOperator.Equal, MIDEntity)
            Case Opt.PreciosClientesLineas
                mEntityName = GetType(HistoricoPreciosClienteQDesde).Name
                Me.LblIdentity.Text = "Cliente"
                FilEntity.Add("IDCliente", FilterOperator.Equal, MIDEntity)
                FilEntity.Add("QDesde", FilterOperator.Equal, MQuantity)
            Case Opt.PreciosProveedores
                mEntityName = GetType(HistoricoPreciosProveedor).Name
                Me.LblIdentity.Text = "Proveedor"
                FilEntity.Add("IDProveedor", FilterOperator.Equal, MIDEntity)
            Case Opt.PreciosProveedoresLineas
                mEntityName = GetType(HistoricoPreciosProveedorQDesde).Name
                Me.LblIdentity.Text = "Proveedor"
                FilEntity.Add("IDProveedor", FilterOperator.Equal, MIDEntity)
                FilEntity.Add("QDesde", FilterOperator.Equal, MQuantity)
        End Select
        FilEntity.Add("IDArticulo", FilterOperator.Equal, MIDArticulo)
        Me.TxtIDArticulo.Text = MIDArticulo
        Me.ULblDescArticulo.Text = MDescArticulo
        Me.TxtIdentity.Text = MIDEntity
        Me.ULblDescIdentity.Text = MDescIdentity
        Me.GrdHistorico.DataSource = MEntity.Filter(FilEntity)
    End Sub

    Private Sub SaveData()
        Dim DtData As DataTable = Me.GrdHistorico.DataSource
        'Análisis de estados de rows
        Dim DtDelete As DataTable = DtData.GetChanges(DataRowState.Deleted)
        If Not DtDelete Is Nothing AndAlso DtDelete.Rows.Count > 0 Then
            DtDelete.RejectChanges()
            MEntity.Delete(DtDelete)
        End If
        Dim DtAdded As DataTable = DtData.GetChanges(DataRowState.Added)
        If Not DtAdded Is Nothing AndAlso DtAdded.Rows.Count > 0 Then
            MEntity.Validate(DtAdded)
            MEntity.Update(DtAdded)
        End If
        Dim DtModified As DataTable = DtData.GetChanges(DataRowState.Modified)
        If Not DtModified Is Nothing AndAlso DtModified.Rows.Count > 0 Then
            MEntity.Validate(DtModified)
            MEntity.Update(DtModified)
        End If
    End Sub
    Private Sub LoadPermisos()
        Dim mDenyRead As Boolean = False
        Dim mDenyInsert As Boolean = False
        Dim mDenyUpdate As Boolean = False
        Dim mDenyDelete As Boolean = False

        Dim ES As EntitySecurity = ExpertisApp.SessionDescriptor.Security(mEntityName)
        If Not ES Is Nothing Then
            Select Case ES.Restriction
                Case EntityRestriction.DenyRead
                    mDenyRead = True
                Case EntityRestriction.DenyInsert
                    mDenyInsert = True
                Case EntityRestriction.DenyRead + EntityRestriction.DenyInsert
                    mDenyRead = True : mDenyInsert = True
                Case EntityRestriction.DenyUpdate
                    mDenyUpdate = True
                Case EntityRestriction.DenyRead + EntityRestriction.DenyUpdate
                    mDenyRead = True : mDenyUpdate = True
                Case EntityRestriction.DenyInsert + EntityRestriction.DenyUpdate
                    mDenyInsert = True : mDenyUpdate = True
                Case EntityRestriction.DenyRead + EntityRestriction.DenyInsert + EntityRestriction.DenyUpdate
                    mDenyRead = True : mDenyInsert = True : mDenyUpdate = True
                Case EntityRestriction.DenyDelete
                    mDenyDelete = True
                Case EntityRestriction.DenyRead + EntityRestriction.DenyDelete
                    mDenyRead = True : mDenyDelete = True
                Case EntityRestriction.DenyInsert + EntityRestriction.DenyDelete
                    mDenyInsert = True : mDenyDelete = True
                Case EntityRestriction.DenyRead + EntityRestriction.DenyInsert + EntityRestriction.DenyDelete
                    mDenyRead = True : mDenyInsert = True : mDenyDelete = True
                Case EntityRestriction.DenyUpdate + EntityRestriction.DenyDelete
                    mDenyUpdate = True : mDenyDelete = True
                Case EntityRestriction.DenyRead + EntityRestriction.DenyUpdate + EntityRestriction.DenyDelete
                    mDenyRead = True : mDenyUpdate = True : mDenyDelete = True
                Case EntityRestriction.DenyInsert + EntityRestriction.DenyUpdate + EntityRestriction.DenyDelete
                    mDenyInsert = True : mDenyUpdate = True : mDenyDelete = True
                Case EntityRestriction.DenyRead + EntityRestriction.DenyInsert + EntityRestriction.DenyUpdate + EntityRestriction.DenyDelete
                    mDenyRead = True : mDenyInsert = True : mDenyUpdate = True : mDenyDelete = True
            End Select

            If mDenyDelete Then
                GrdHistorico.AllowDelete = InheritableBoolean.False
            End If
            If mDenyInsert Then
                GrdHistorico.AllowAddNew = InheritableBoolean.False
            End If
            If mDenyRead Then
                GrdHistorico.Visible = False
            End If
            If mDenyUpdate Then
                GrdHistorico.AllowEdit = InheritableBoolean.False
            End If
        End If
    End Sub
#End Region

#Region "Eventos FrmHistoricoPreciosClieProv"

    Private Sub FrmHistoricoPreciosClieProv_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadDesign()
        LoadData()
        LoadPermisos()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        SaveData()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub GrdHistorico_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GrdHistorico.AddingRecord
        If Length(GrdHistorico.GetValue("FechaDesde")) = 0 OrElse Length(GrdHistorico.GetValue("Fechahasta")) = 0 Then
            ExpertisApp.GenerateMessage("Las fechas son datos obligatorios.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
    End Sub

    Private Sub GrdHistorico_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdHistorico.CellUpdated
        Select Case e.Column.Key
            Case "Precio"
                Dim DtArt As DataTable = New Articulo().SelOnPrimaryKey(GrdHistorico.GetValue("IDArticulo"))
                Dim DtCliPro As DataTable
                Dim DtMoneda As DataTable
                Dim ndecimalesImp As Integer
                Dim ndecimalesPrec As Integer

                If GrdHistorico.Columns.Contains("IdCliente") Then
                    DtCliPro = New Cliente().SelOnPrimaryKey(Nz(GrdHistorico.GetValue("IDCliente"), String.Empty))
                    DtMoneda = New Moneda().SelOnPrimaryKey(Nz(DtCliPro.Rows(0)("IDmoneda"), String.Empty))
                ElseIf GrdHistorico.Columns.Contains("IdProveedor") Then
                    DtCliPro = New Proveedor().SelOnPrimaryKey(Nz(GrdHistorico.GetValue("IDProveedor"), String.Empty))
                    DtMoneda = New Moneda().SelOnPrimaryKey(Nz(DtCliPro.Rows(0)("IDmoneda"), String.Empty))
                End If

                If Not DtMoneda Is Nothing AndAlso DtMoneda.Rows.Count > 0 Then
                    ndecimalesImp = DtMoneda.Rows(0)("NDecimalesImp")
                    ndecimalesPrec = DtMoneda.Rows(0)("NDecimalesPrec")
                Else
                    Dim MonInfoA As MonedaInfo = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, Today.Date)
                    ndecimalesImp = MonInfoA.NDecimalesImporte
                    ndecimalesPrec = MonInfoA.NDecimalesprecio
                End If

                If Not DtArt Is Nothing AndAlso DtArt.Rows.Count > 0 Then
                    Dim dblFactor As Double
                    If Length(Nz(DtArt.Rows(0)("IDTipoIVA"), String.Empty)) > 0 Then
                        Dim oIVA As New TipoIva
                        Dim dtIVA As DataTable = oIVA.SelOnPrimaryKey(Nz(DtArt.Rows(0)("IDTipoIVA"), String.Empty))
                        If Not IsNothing(dtIVA) AndAlso dtIVA.Rows.Count > 0 Then
                            dblFactor = dtIVA.Rows(0)("Factor") / 100
                        End If
                    End If

                    If GrdHistorico.Columns.Contains("PVP") Then
                        GrdHistorico.SetValue("PVP", xRound(GrdHistorico.GetValue("Precio") * (1 + dblFactor), ndecimalesImp))
                    End If
                End If
                GrdHistorico.SetValue("Precio", xRound(GrdHistorico.GetValue("Precio"), ndecimalesPrec))
        End Select
    End Sub

    Private Sub GrdHistorico_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GrdHistorico.EditingCell
        If GrdHistorico.AllowEdit = InheritableBoolean.True Then
            Select Case e.Column.Key
                Case "FechaDesde", "FechaHasta"
                    If GrdHistorico.Row <> Grid.newTopRowPosition Then
                        e.Cancel = True
                    End If
            End Select
        Else
            e.Cancel = True
        End If
    End Sub

#End Region

End Class