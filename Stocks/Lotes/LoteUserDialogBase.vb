Public Class LoteUserDialogBase
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
    Public WithEvents BottomPanel As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents OkButton As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents TopPanel As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents GridPanel As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents DeleteButton As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents ShowAllButton As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents lblArticulo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents SplMain As System.Windows.Forms.SplitContainer
    Public WithEvents GrdSeguimiento As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents lblAlmacen As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoteUserDialogBase))
        Dim GrdSeguimiento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.BottomPanel = New Solmicro.Expertis.Engine.UI.Panel
        Me.ShowAllButton = New Solmicro.Expertis.Engine.UI.Button
        Me.DeleteButton = New Solmicro.Expertis.Engine.UI.Button
        Me.OkButton = New Solmicro.Expertis.Engine.UI.Button
        Me.TopPanel = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.lblArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.GridPanel = New Solmicro.Expertis.Engine.UI.Panel
        Me.SplMain = New System.Windows.Forms.SplitContainer
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.GrdSeguimiento = New Solmicro.Expertis.Engine.UI.Grid
        Me.BottomPanel.suspendlayout()
        Me.TopPanel.suspendlayout()
        Me.GridPanel.suspendlayout()
        Me.SplMain.Panel1.SuspendLayout()
        Me.SplMain.Panel2.SuspendLayout()
        Me.SplMain.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdSeguimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BottomPanel
        '
        Me.BottomPanel.Controls.Add(Me.ShowAllButton)
        Me.BottomPanel.Controls.Add(Me.DeleteButton)
        Me.BottomPanel.Controls.Add(Me.OkButton)
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel.Location = New System.Drawing.Point(0, 250)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(756, 57)
        Me.BottomPanel.TabIndex = 1
        '
        'ShowAllButton
        '
        Me.ShowAllButton.Location = New System.Drawing.Point(12, 12)
        Me.ShowAllButton.Name = "ShowAllButton"
        Me.ShowAllButton.Size = New System.Drawing.Size(102, 33)
        Me.ShowAllButton.TabIndex = 2
        Me.ShowAllButton.Text = "Ver Todos"
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(123, 12)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(102, 33)
        Me.DeleteButton.TabIndex = 1
        Me.DeleteButton.Text = "Eliminar"
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(642, 12)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(102, 33)
        Me.OkButton.TabIndex = 0
        Me.OkButton.Text = "Aceptar"
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.lblAlmacen)
        Me.TopPanel.Controls.Add(Me.lblArticulo)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(756, 60)
        Me.TopPanel.TabIndex = 2
        '
        'lblAlmacen
        '
        Me.lblAlmacen.Location = New System.Drawing.Point(15, 36)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(61, 13)
        Me.lblAlmacen.TabIndex = 2
        Me.lblAlmacen.Text = "Almacén:"
        '
        'lblArticulo
        '
        Me.lblArticulo.Location = New System.Drawing.Point(15, 9)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(55, 13)
        Me.lblArticulo.TabIndex = 1
        Me.lblArticulo.Text = "Artículo:"
        '
        'GridPanel
        '
        Me.GridPanel.Controls.Add(Me.SplMain)
        Me.GridPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPanel.Location = New System.Drawing.Point(0, 60)
        Me.GridPanel.Name = "GridPanel"
        Me.GridPanel.Size = New System.Drawing.Size(756, 190)
        Me.GridPanel.TabIndex = 3
        '
        'SplMain
        '
        Me.SplMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplMain.Location = New System.Drawing.Point(0, 0)
        Me.SplMain.Name = "SplMain"
        '
        'SplMain.Panel1
        '
        Me.SplMain.Panel1.Controls.Add(Me.Grid)
        '
        'SplMain.Panel2
        '
        Me.SplMain.Panel2.Controls.Add(Me.GrdSeguimiento)
        Me.SplMain.Size = New System.Drawing.Size(756, 190)
        Me.SplMain.SplitterDistance = 314
        Me.SplMain.TabIndex = 1
        '
        'Grid
        '
        Me.Grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = Nothing
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(314, 190)
        Me.Grid.TabIndex = 0
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = Nothing
        '
        'GrdSeguimiento
        '
        GrdSeguimiento_DesignTimeLayout.LayoutString = resources.GetString("GrdSeguimiento_DesignTimeLayout.LayoutString")
        Me.GrdSeguimiento.DesignTimeLayout = GrdSeguimiento_DesignTimeLayout
        Me.GrdSeguimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdSeguimiento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdSeguimiento.EntityName = Nothing
        Me.GrdSeguimiento.Location = New System.Drawing.Point(0, 0)
        Me.GrdSeguimiento.Name = "GrdSeguimiento"
        Me.GrdSeguimiento.PrimaryDataFields = Nothing
        Me.GrdSeguimiento.SecondaryDataFields = Nothing
        Me.GrdSeguimiento.Size = New System.Drawing.Size(438, 190)
        Me.GrdSeguimiento.TabIndex = 0
        Me.GrdSeguimiento.ViewName = Nothing
        '
        'LoteUserDialogBase
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(756, 307)
        Me.Controls.Add(Me.GridPanel)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.BottomPanel)
        Me.CreateTransaction = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoteUserDialogBase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lotes"
        Me.BottomPanel.ResumeLayout(False)
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        Me.GridPanel.ResumeLayout(False)
        Me.SplMain.Panel1.ResumeLayout(False)
        Me.SplMain.Panel2.ResumeLayout(False)
        Me.SplMain.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdSeguimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Event DeletingRecords(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
    Public Event RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs)

    Protected mDeletemessage As String = "Esta acción eliminará todo el desglose de lotes y el estado de la línea de albarán asociada quedará como 'no actualizada'."

    Public mArticulo As String
    Public mAlmacen As String
    Public mDocumento As String
    Public mTextoDocumento As String
    Public mBodega As Boolean
    Public mArticuloBodega As Boolean
    Private dblCantidadLote As Double

    Protected StDataSegPrec As New BdgHistoricoPrecintas.DataProcSegPrecRet

    Public mEsSeguimiento As Boolean = False
    Public WriteOnly Property EsSeguimiento() As Boolean
        Set(ByVal value As Boolean)
            mEsSeguimiento = value
        End Set
    End Property

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If Grid.RecordCount > 0 Then
            Dim DtGrid As DataTable = Me.Grid.DataSource
            If mBodega AndAlso mArticuloBodega Then
                If DtGrid.Columns.Contains("NEntrada") Then
                    Dim ClsEntVinoDep As New BdgEntradaVinoDeposito
                    For Each DrLote As DataRow In DtGrid.Select
                        If Length(DrLote("NEntrada")) > 0 Then
                            Dim DtDeposito As DataTable = ClsEntVinoDep.Filter(New FilterItem("NEntrada", FilterOperator.Equal, DrLote("NEntrada")))
                            If Not DtDeposito Is Nothing AndAlso DtDeposito.Rows.Count > 0 Then
                                ExpertisApp.GenerateMessage("No se puede borrar el desglose de Lotes.|Existe una entrada de vino asociada con depósito: |.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, vbNewLine, DrLote("NEntrada"))
                                Exit Sub
                            End If
                        End If
                    Next

                    Dim ClsEntVino As New BdgEntradaVino
                    Dim ClsAlbLin As New AlbaranCompraLinea
                    For Each DrLote As DataRow In DtGrid.Select
                        Dim DtEntVino As DataTable = ClsEntVino.Filter(New FilterItem("NEntrada", FilterOperator.Equal, DrLote("NEntrada")))
                        ClsEntVino.Delete(DtEntVino)
                    Next

                    Dim DtLinea As DataTable = ClsAlbLin.Filter(New FilterItem("IDLineaAlbaran", FilterOperator.Equal, DtGrid.Rows(0)("IDLineaAlbaran")))
                    DtLinea.Rows(0)("EstadoStock") = enumaclEstadoStock.aclNoActualizado
                    ClsAlbLin.Update(DtLinea)
                End If
                If DtGrid.Columns.Contains("IDOperacion") AndAlso Length(DtGrid.Rows(0)("IDOperacion")) > 0 Then
                    ExpertisApp.GenerateMessage("No se puede borrar el desglose de lotes.|Existe una operación relacionada.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, vbNewLine)
                    Exit Sub
                End If
            End If

            If ExpertisApp.GenerateMessage(mDeletemessage, _
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                Try
                    If mEsSeguimiento Then
                        Dim ClsAlbVentaSeg As New AlbaranVentaSeguimiento
                        ClsAlbVentaSeg.Delete(CType(Me.GrdSeguimiento.DataSource, DataView).Table)
                    End If
                    Dim eventArgs1 As New System.ComponentModel.CancelEventArgs
                    Me.OnDeletingRecords(eventArgs1)
                    If Not eventArgs1.Cancel Then
                        Me.OnRecordsDeleted(New System.EventArgs)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                Me.Close()
            End If
        End If
    End Sub

    Protected Overridable Sub OkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkButton.Click
        If mEsSeguimiento Then
            Dim ClsAlbSeg As New AlbaranVentaSeguimiento
            Dim DtSeg As DataTable = CType(Me.GrdSeguimiento.DataSource, DataView).Table
            Dim DtUpdate As DataTable = DtSeg.GetChanges(DataRowState.Added Or DataRowState.Modified)
            If Not DtUpdate Is Nothing AndAlso DtUpdate.Rows.Count > 0 Then
                DtUpdate.TableName = "AlbaranVentaSeguimiento"
                ClsAlbSeg.Update(DtUpdate)
            End If
            Dim DtDelete As DataTable = DtSeg.GetChanges(DataRowState.Deleted)
            If Not DtDelete Is Nothing AndAlso DtDelete.Rows.Count > 0 Then
                DtDelete.RejectChanges()
                DtDelete.TableName = "AlbaranVentaSeguimiento"
                ClsAlbSeg.Delete(DtDelete)
            End If
        End If
        Me.Close()
    End Sub

    Protected Overridable Sub AlbaranLoteUserDialog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            lblArticulo.Text = String.Concat(lblArticulo.Text, " ", mArticulo)
            lblAlmacen.Text = String.Concat(lblAlmacen.Text, " ", mAlmacen)
            mBodega = New Parametro().GestionBodegas
            mArticuloBodega = False
            Dim dtArticulo As DataTable = New BE.DataEngine().Filter("vNegCaractArticulo", New StringFilterItem("IDArticulo", mArticulo))
            If dtArticulo.Rows.Count > 0 AndAlso Length(dtArticulo.Rows(0)("EnsambladoStock")) > 0 AndAlso Length(dtArticulo.Rows(0)("ClaseStock")) > 0 Then
                mArticuloBodega = True
            End If
            Me.Text = String.Concat(Me.Text, " - ", mTextoDocumento, mDocumento)

            If Len(mArticulo) > 0 And Len(mAlmacen) > 0 Then
                SettingDobleUnidad()
                ConfigurarGridPrecintas()
                Dim art As New Articulo
                Dim alm As New Almacen
                Dim dt As DataTable
                dt = art.SelOnPrimaryKey(mArticulo)
                If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                    lblArticulo.Text = String.Concat(lblArticulo.Text, " - ", dt.Rows(0)("DescArticulo"))
                End If
                dt = alm.SelOnPrimaryKey(mAlmacen)
                If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                    lblAlmacen.Text = String.Concat(lblAlmacen.Text, " - ", dt.Rows(0)("DescAlmacen"))
                End If
            End If
            If mEsSeguimiento Then
                If Me.Grid.RowCount > 0 Then
                    Me.Grid.Row = 0
                    If Not Me.GrdSeguimiento.DataSource Is Nothing Then
                        CType(Me.GrdSeguimiento.DataSource, DataView).RowFilter = "IDLineaLote = " & Me.Grid.GetValue("IDLineaLote")
                        dblCantidadLote = Me.Grid.CurrentRow.Cells("QInterna").Value

                        'Carga de información de seguimiento de Precintas
                        StDataSegPrec = New BdgHistoricoPrecintas.DataProcSegPrecRet
                        StDataSegPrec = ExpertisApp.ExecuteTask(Of String, BdgHistoricoPrecintas.DataProcSegPrecRet)(AddressOf BdgHistoricoPrecintas.ProcesoSegPrecinta, mArticulo)
                        If Length(StDataSegPrec.IDEtiqueta) > 0 Then
                            'Si tenemos etiqueta seguimiento precinta
                            Me.GrdSeguimiento.Columns("Codigo").Visible = True
                            Me.GrdSeguimiento.Columns("Codigo").DropDown.SetDataBinding(StDataSegPrec.DtLotes, Nothing)
                            Me.GrdSeguimiento.Columns("Codigo").EditType = EditType.MultiColumnDropDown
                            If StDataSegPrec.DtLotes.Rows.Count = 1 Then
                                Me.GrdSeguimiento.Columns("Codigo").DefaultValue = StDataSegPrec.DtLotes.Rows(0)("Codigo")
                                Me.GrdSeguimiento.Columns("IDArticulo").DefaultValue = StDataSegPrec.DtLotes.Rows(0)("IDArticulo")
                                Me.GrdSeguimiento.Columns("IDAlmacen").DefaultValue = StDataSegPrec.DtLotes.Rows(0)("IDAlmacen")
                                Me.GrdSeguimiento.Columns("Ubicacion").DefaultValue = StDataSegPrec.DtLotes.Rows(0)("Ubicacion")
                                Me.GrdSeguimiento.Columns("Lote").DefaultValue = StDataSegPrec.DtLotes.Rows(0)("Lote")
                            End If
                            Me.GrdSeguimiento.Columns("NDesde").DefaultValue = 0
                            Me.GrdSeguimiento.Columns("NHasta").DefaultValue = 0
                            Me.GrdSeguimiento.Columns("Cantidad").DefaultValue = 0
                        Else
                            Me.GrdSeguimiento.Columns("Codigo").Visible = False
                            Me.GrdSeguimiento.Columns("Codigo").DefaultValue = String.Empty
                            Me.GrdSeguimiento.Columns("Codigo").EditType = EditType.NoEdit
                            Me.GrdSeguimiento.Columns("IDArticulo").DefaultValue = String.Empty
                            Me.GrdSeguimiento.Columns("IDAlmacen").DefaultValue = String.Empty
                            Me.GrdSeguimiento.Columns("Ubicacion").DefaultValue = String.Empty
                            Me.GrdSeguimiento.Columns("Lote").DefaultValue = String.Empty
                            Me.GrdSeguimiento.Columns("Codigo").DropDown.SetDataBinding(Nothing, String.Empty)
                        End If
                    End If
                End If
            Else : Me.SplMain.Panel2Collapsed = True
            End If
        End If
    End Sub

    Private Sub SettingDobleUnidad()
        If Length(mArticulo) > 0 Then
            Dim Aplicar2Ud As Boolean = ExpertisApp.ExecuteTask(Of String, Boolean)(AddressOf ProcesoComunes.AplicarSegundaUnidad, mArticulo)
            Me.Grid.RootTable.Columns("QInterna2").Visible = Aplicar2Ud
        End If
    End Sub

    Private Sub ConfigurarGridPrecintas()
        Dim esPrecinta As Boolean = ExpertisApp.ExecuteTask(Of String, Boolean)(AddressOf Business.Negocio.Articulo.EsPrecinta, mArticulo)
        Me.Grid.RootTable.Columns("SeriePrecinta").Visible = esPrecinta
        Me.Grid.RootTable.Columns("NDesdePrecinta").Visible = esPrecinta
        Me.Grid.RootTable.Columns("NHastaPrecinta").Visible = esPrecinta
        Me.Grid.AutoSizeColumns()
    End Sub

    Private Sub ShowAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAllButton.Click
        If Len(mArticulo) > 0 And Len(mAlmacen) > 0 Then
            Dim frm As New LoteUserDialog
            frm.ShowDialog(mArticulo, mAlmacen)
        End If
    End Sub

    Public Overridable Sub OnDeletingRecords(ByVal e As System.ComponentModel.CancelEventArgs)
        RaiseEvent DeletingRecords(Me, e)
    End Sub

    Public Overridable Sub OnRecordsDeleted(ByVal e As System.EventArgs)
        RaiseEvent RecordsDeleted(Me, e)
    End Sub

    Private Sub Grid_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.SelectionChanged
        If mEsSeguimiento Then
            If Not Me.GrdSeguimiento.DataSource Is Nothing Then
                CType(Me.GrdSeguimiento.DataSource, DataView).RowFilter = "IDLineaLote = " & Me.Grid.GetValue("IDLineaLote")
                Me.GrdSeguimiento.Columns("IDLineaLote").DefaultValue = Me.Grid.GetValue("IDLineaLote")
                dblCantidadLote = Me.Grid.CurrentRow.Cells("QInterna").Value
            End If
        End If
    End Sub

    Private Sub GrdSeguimiento_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GrdSeguimiento.AddingRecord
        If Length(StDataSegPrec.IDEtiqueta) > 0 AndAlso Length(Me.GrdSeguimiento.GetValue("Codigo")) = 0 Then
            ExpertisApp.GenerateMessage("No se ha seleccionado un Almacén - Lote.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
        If Length(Me.GrdSeguimiento.GetValue("NDesde")) = 0 OrElse Length(Me.GrdSeguimiento.GetValue("NHasta")) = 0 Then
            ExpertisApp.GenerateMessage("No se ha establecido un rango de Etiquetas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
        If Nz(Me.GrdSeguimiento.GetValue("Cantidad"), 0) = 0 Then
            ExpertisApp.GenerateMessage("No se  puede introducir un registro con Cantidad 0.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
        If Not e.Cancel Then Me.GrdSeguimiento.SetValue("IDLineaLote", Me.Grid.GetValue("IDLineaLote"))
    End Sub

    Private Sub GrdSeguimiento_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdSeguimiento.CellUpdated
        Select Case e.Column.Key
            Case "Codigo", "Cantidad"
                If Length(Me.GrdSeguimiento.GetValue("Codigo")) > 0 Then
                    Dim DrFindLote() As DataRow = StDataSegPrec.DtLotes.Select("Codigo = '" & Me.GrdSeguimiento.GetValue("Codigo") & "'")
                    If DrFindLote.Length > 0 Then
                        Me.GrdSeguimiento.SetValue("IDArticulo", DrFindLote(0)("IDArticulo"))
                        Me.GrdSeguimiento.SetValue("IDAlmacen", DrFindLote(0)("IDAlmacen"))
                        Me.GrdSeguimiento.SetValue("Ubicacion", DrFindLote(0)("Ubicacion"))
                        Me.GrdSeguimiento.SetValue("Lote", DrFindLote(0)("Lote"))
                    End If
                End If
        End Select
    End Sub

    Protected Overridable Sub GrdSeguimiento_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles GrdSeguimiento.UpdatingCell
        Select Case e.Column.Key
            Case "Cantidad"
                If Length(e.Value) > 0 AndAlso e.Value > 0 Then
                    Dim difCantidad As Double = e.Value - Nz(e.InitialValue, 0)
                    Dim dblCantidad As Double = Me.GrdSeguimiento.GetTotal(Me.GrdSeguimiento.Columns("Cantidad"), AggregateFunction.Sum)
                    If (dblCantidad + difCantidad) > dblCantidadLote Then
                        ExpertisApp.GenerateMessage("No se puede indicar mas cantidad que las correspondientes al Lote.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        e.Cancel = True
                    End If
                Else : e.Cancel = True
                End If
        End Select
        If Not e.Cancel Then
            Dim seg As New SeguimientoPrecintas
            seg.Seguimiento_UpdatingCell(StDataSegPrec.IDEtiqueta, StDataSegPrec.Factor, Me.GrdSeguimiento, e)
        End If
    End Sub

End Class

Public Class AlbaranVentaLoteUserDialog
    Inherits LoteUserDialogBase

    Public WriteOnly Property ShowAllButtonVisible() As Boolean
        Set(ByVal value As Boolean)
            Me.ShowAllButton.Visible = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        MyBase.EsSeguimiento = New Parametro().BodegaSeguimiento
    End Sub

    Private Sub LoadDataSeguimiento()
        Dim DtLotes As DataTable = Me.Grid.DataSource
        If Not DtLotes Is Nothing AndAlso DtLotes.Rows.Count > 0 Then
            Dim FilLotes As New Filter(FilterUnionOperator.Or)
            For Each DrLote As DataRow In DtLotes.Select
                FilLotes.Add("IDLineaLote", FilterOperator.Equal, DrLote("IDLineaLote"))
            Next
            Dim DtSeg As DataTable = New AlbaranVentaSeguimiento().Filter(FilLotes)
            DtSeg.Columns.Add("Codigo", GetType(String))
            For Each DrSeg As DataRow In DtSeg.Select
                DrSeg("Codigo") = DrSeg("IDArticulo") & "-" & DrSeg("IDAlmacen") & "-" & DrSeg("Lote") & "-" & DrSeg("Ubicacion")
            Next
            DtSeg.AcceptChanges()
            Dim DvSeg As New DataView(DtSeg)
            Me.GrdSeguimiento.DataSource = DvSeg
        End If
    End Sub

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        LoadDataSeguimiento()
        MyBase.OnLoad(e)
    End Sub

    Public Overrides Sub OnDeletingRecords(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnDeletingRecords(e)
    End Sub

    Public Overrides Sub OnRecordsDeleted(ByVal e As System.EventArgs)
        Dim AVLT As New AlbaranVentaLote
        AVLT.Delete(CType(Grid.DataSource, DataTable))
        MyBase.OnRecordsDeleted(e)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class

Public Class AlbaranCompraLoteUserDialog
    Inherits LoteUserDialogBase

    Public Sub New()
        MyBase.New()
    End Sub

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        MyBase.OnLoad(e)

        If Not Me.DesignMode Then
            If New Parametro().GestionBodegas Then
                Dim GrdCol As New GridEXColumn
                GrdCol.Key = "NEntrada"
                GrdCol.EditType = EditType.NoEdit
                GrdCol.DataMember = "NEntrada"
                GrdCol.Caption = "Nº Entrada"
                GrdCol.Visible = True
                Me.Grid.Columns.Add(GrdCol)

                Me.Grid.Actions.Add("Abrir Entrada Vino", AddressOf AbrirEntradaVino, ExpertisApp.GetIcon("data_previous.ico"))
                Me.Grid.AddSeparator()
                Me.Grid.Actions.Add("Abrir Trazabilidad", AddressOf AbrirTrazabilidad, ExpertisApp.GetIcon("xConsultaMovim.ico"))
            End If
        End If
    End Sub

    Private Sub AbrirEntradaVino()
        If Length(Me.Grid.GetValue("NEntrada")) > 0 Then
            ExpertisApp.OpenForm("BDGENTVIN", New FilterItem("NEntrada", FilterOperator.Equal, Me.Grid.GetValue("NEntrada")))
            Me.Close()
        End If
    End Sub

    Private Sub AbrirTrazabilidad()
        Dim ht As New Hashtable
        If Length(Me.Grid.GetValue("NEntrada")) > 0 Then
            ht.Add("NEntradaVino", Me.Grid.GetValue("NEntrada"))
            ht.Add("EntradaVino", True)
        Else
            ht.Add("Componente", True)
            Dim DtAlbLin As DataTable = New AlbaranCompraLinea().Filter(New FilterItem("IDLineaAlbaran", FilterOperator.Equal, Me.Grid.GetValue("IDLineaAlbaran")))
            ht.Add("IDArticulo", DtAlbLin.Rows(0)("IDArticulo"))
            ht.Add("Lote", Me.Grid.GetValue("Lote"))
        End If
        ExpertisApp.OpenForm("BDGCITR", , ht)
        Me.Close()
    End Sub

    Public Overrides Sub OnDeletingRecords(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnDeletingRecords(e)
    End Sub

    Public Overrides Sub OnRecordsDeleted(ByVal e As System.EventArgs)
        Dim ACLT As New AlbaranCompraLote
        ACLT.Delete(CType(Grid.DataSource, DataTable))
        MyBase.OnRecordsDeleted(e)
    End Sub
End Class

Public Class ObraMaterialLoteUserDialog
    Inherits LoteUserDialogBase

    Public Sub New()
        MyBase.New()
    End Sub

    Public Overrides Sub OnDeletingRecords(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnDeletingRecords(e)
    End Sub

    Public Overrides Sub OnRecordsDeleted(ByVal e As System.EventArgs)
        Dim omcl As New ObraMaterialControlLote
        omcl.Delete(CType(Grid.DataSource, DataTable))
        MyBase.OnRecordsDeleted(e)
    End Sub
End Class

'TODO - A lo mejor lo sacamos a Bodega
Public Class VinoMaterialLoteUserDialog
    Inherits LoteUserDialogBase

    Private bsnObj As BE.BusinessHelper = New BdgVinoMaterialLote

    Public Property businessObject() As BE.BusinessHelper
        Get
            Return bsnObj
        End Get
        Set(ByVal value As BE.BusinessHelper)
            bsnObj = value
        End Set
    End Property

    Private blnCanDelete As Boolean
    Public Property CanDelete() As Boolean
        Get
            Return blnCanDelete
        End Get
        Set(ByVal value As Boolean)
            blnCanDelete = value
            CheckDelete()
        End Set
    End Property

    Private mEsPrecintas As Boolean = False
    Protected Property EsPrecinta() As Boolean
        Get
            Return mEsPrecintas
        End Get
        Set(ByVal value As Boolean)
            mEsPrecintas = value
        End Set
    End Property

    Public Sub New(Optional ByVal allowDelete As Boolean = True, Optional ByVal bsnHelper As BE.BusinessHelper = Nothing)
        MyBase.New()
        CanDelete = allowDelete
        If (Not bsnHelper Is Nothing) Then
            businessObject = bsnHelper
        End If
    End Sub

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        MyBase.OnLoad(e)

        SetGridProperties()
    End Sub

    Public Overrides Sub OnDeletingRecords(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnDeletingRecords(e)
    End Sub

    Public Overrides Sub OnRecordsDeleted(ByVal e As System.EventArgs)
        If (Not businessObject Is Nothing) Then
            businessObject.Delete(CType(Grid.DataSource, DataTable))
        End If
        MyBase.OnRecordsDeleted(e)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub SetGridProperties()
        'OCULTAR CAMPOS QUE NO QUEREMOS VER Y MOSTRAR LOS CORREPSONDIENTES AL VINO
        Me.Grid.Columns("QInterna").Visible = False

        'Me.Grid.Columns("Merma").Visible = True
        Me.Grid.Columns("Cantidad").Visible = True

        EsPrecinta = ExpertisApp.ExecuteTask(Of String, Boolean)(AddressOf Business.Negocio.Articulo.EsPrecinta, mArticulo)

        Me.Grid.Columns("SeriePrecinta").Visible = EsPrecinta
        Me.Grid.Columns("NDesdePrecinta").Visible = EsPrecinta
        Me.Grid.Columns("NHastaPrecinta").Visible = EsPrecinta
        
        mDeletemessage = "Esta acción eliminará todo el desglose de lotes."

    End Sub

    Private Sub CheckDelete()
        Me.DeleteButton.Visible = CanDelete
    End Sub

End Class

Public Class ParteAgrupadoLoteUserDialog
    Inherits LoteUserDialogBase

    Public Sub New()
        MyBase.New()
    End Sub

    Public Overrides Sub OnRecordsDeleted(ByVal e As System.EventArgs)
        Dim oml As New ObraParteAgrupadoMaterialLote
        oml.Delete(CType(Grid.DataSource, DataTable))
        MyBase.OnRecordsDeleted(e)
    End Sub
    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        MyBase.OnLoad(e)

        SetGridProperties()
    End Sub

    Private Sub SetGridProperties()
        'OCULTAR CAMPOS QUE NO QUEREMOS VER Y MOSTRAR LOS CORREPSONDIENTES AL VINO
        Me.Grid.Columns("QInterna").Visible = True
        Me.Grid.Columns("Cantidad").Visible = False

        Me.Grid.Columns("SeriePrecinta").Visible = False
        Me.Grid.Columns("NDesdePrecinta").Visible = False
        Me.Grid.Columns("NHastaPrecinta").Visible = False

        mDeletemessage = "Esta acción eliminará todo el desglose de lotes."

    End Sub


End Class