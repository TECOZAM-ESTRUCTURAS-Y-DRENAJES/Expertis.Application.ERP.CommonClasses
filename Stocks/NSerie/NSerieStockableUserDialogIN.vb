Public Class NSerieStockableUserDialogIN
    Inherits Expertis.Application.ERP.CommonClasses.NSerieStockableUserDialog

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        txtNumeracion.Value = System.DBNull.Value
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
    Friend WithEvents Panel3 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblGenAutoCod As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtCodigo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblCodigo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblEmpezarPor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmbGenerarNSerie As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents txtNumeracion As Solmicro.Expertis.Engine.UI.NumericTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Grid_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.ButtonImage")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NSerieStockableUserDialogIN))
        Dim Grid_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.ButtonImage")
        Dim Grid_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.ButtonImage")
        Dim Grid_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column6.ButtonImage")
        Dim Grid_DesignTimeLayout_Reference_4 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column7.ButtonImage")
        Dim Totales_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel3 = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblEmpezarPor = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNumeracion = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblCodigo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCodigo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.cmbGenerarNSerie = New Solmicro.Expertis.Engine.UI.Button
        Me.lblGenAutoCod = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel2.suspendlayout()
        Me.Panel1.suspendlayout()
        Me.Frame1.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.suspendlayout()
        CType(Me.Totales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.suspendlayout()
        Me.SuspendLayout()
        '
        'OkButton
        '
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("Ubicacion", "AlmacenUbicacion", "IDUbicacion")})
        Grid_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_0.Instance"), Object)
        Grid_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_1.Instance"), Object)
        Grid_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_2.Instance"), Object)
        Grid_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_3.Instance"), Object)
        Grid_DesignTimeLayout_Reference_4.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_4.Instance"), Object)
        Grid_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {Grid_DesignTimeLayout_Reference_0, Grid_DesignTimeLayout_Reference_1, Grid_DesignTimeLayout_Reference_2, Grid_DesignTimeLayout_Reference_3, Grid_DesignTimeLayout_Reference_4})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.Location = New System.Drawing.Point(3, 124)
        Me.Grid.Size = New System.Drawing.Size(698, 175)
        Me.Grid.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Size = New System.Drawing.Size(698, 107)
        Me.Panel4.Controls.SetChildIndex(Me.Panel3, 0)
        Me.Panel4.Controls.SetChildIndex(Me.Totales, 0)
        '
        'Totales
        '
        Me.Totales.Anchor = System.Windows.Forms.AnchorStyles.None
        Totales_DesignTimeLayout.LayoutString = resources.GetString("Totales_DesignTimeLayout.LayoutString")
        Me.Totales.DesignTimeLayout = Totales_DesignTimeLayout
        Me.Totales.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Totales.HeaderFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Totales.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Totales.Location = New System.Drawing.Point(151, 4)
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblEmpezarPor)
        Me.Panel3.Controls.Add(Me.txtNumeracion)
        Me.Panel3.Controls.Add(Me.lblCodigo)
        Me.Panel3.Controls.Add(Me.txtCodigo)
        Me.Panel3.Controls.Add(Me.cmbGenerarNSerie)
        Me.Panel3.Controls.Add(Me.lblGenAutoCod)
        Me.Panel3.Location = New System.Drawing.Point(143, 48)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(405, 56)
        Me.Panel3.TabIndex = 9
        '
        'lblEmpezarPor
        '
        Me.lblEmpezarPor.Location = New System.Drawing.Point(198, 30)
        Me.lblEmpezarPor.Name = "lblEmpezarPor"
        Me.lblEmpezarPor.Size = New System.Drawing.Size(96, 13)
        Me.lblEmpezarPor.TabIndex = 24
        Me.lblEmpezarPor.Text = "Empezar por ..."
        '
        'txtNumeracion
        '
        Me.txtNumeracion.DecimalDigits = 0
        Me.txtNumeracion.DisabledBackColor = System.Drawing.Color.White
        Me.txtNumeracion.Location = New System.Drawing.Point(296, 28)
        Me.txtNumeracion.Name = "txtNumeracion"
        Me.txtNumeracion.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtNumeracion.Size = New System.Drawing.Size(82, 21)
        Me.txtNumeracion.TabIndex = 1
        '
        'lblCodigo
        '
        Me.lblCodigo.Location = New System.Drawing.Point(12, 30)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(47, 13)
        Me.lblCodigo.TabIndex = 22
        Me.lblCodigo.Text = "Código"
        '
        'txtCodigo
        '
        Me.txtCodigo.DisabledBackColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(62, 28)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(128, 21)
        Me.txtCodigo.TabIndex = 0
        '
        'cmbGenerarNSerie
        '
        Me.cmbGenerarNSerie.Icon = CType(resources.GetObject("cmbGenerarNSerie.Icon"), System.Drawing.Icon)
        Me.cmbGenerarNSerie.Location = New System.Drawing.Point(382, 28)
        Me.cmbGenerarNSerie.Name = "cmbGenerarNSerie"
        Me.cmbGenerarNSerie.Size = New System.Drawing.Size(21, 21)
        Me.cmbGenerarNSerie.TabIndex = 2
        '
        'lblGenAutoCod
        '
        Me.lblGenAutoCod.Location = New System.Drawing.Point(7, 5)
        Me.lblGenAutoCod.Name = "lblGenAutoCod"
        Me.lblGenAutoCod.Size = New System.Drawing.Size(210, 13)
        Me.lblGenAutoCod.TabIndex = 17
        Me.lblGenAutoCod.Text = "Generación Automática de Nº Serie"
        '
        'NSerieStockableUserDialogIN
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(704, 405)
        Me.Name = "NSerieStockableUserDialogIN"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.Totales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub NSerieStockableUserDialogIN_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            txtCodigo.Text = String.Empty
            txtNumeracion.Value = System.DBNull.Value
            If mClaseMovimiento = [Shared].ClaseMovimiento.Salida Then
                Panel3.Enabled = False
            End If
        End If
    End Sub

    Private Sub cmbGenerarNSerie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGenerarNSerie.Click
        Dim intMaxLength As Integer = Grid.Columns("NSerie").MaxLength

        If Length(txtCodigo.Text & txtNumeracion.Value) > intMaxLength Then
            ExpertisApp.GenerateMessage("La codificación propuesta supera la longitud máxima permitida. Longitud máxima: " & intMaxLength, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim a As New ArticuloNSerie
            Dim cantidad As Double = Nz(CType(Totales.DataSource, DataTable).Rows(0)("CantidadAsignar"), 0)
            If cantidad > 0 Then
                Dim IDEstadoActivo As String = Grid.Columns("IDEstadoActivo").DefaultValue
                Dim IDOperario As String = Grid.Columns("IDOperario").DefaultValue
                Dim dtNSerie As DataTable
                dtNSerie = a.ADDNSerieAutomaticamente(IDArticulo.Text, IDAlmacen.Text, cantidad, IDEstadoActivo, _
                                                      IDOperario, txtCodigo.Text, txtNumeracion.Value, Grid.DataSource)
                Dim p As New Parametro
                Dim blnActivo As Boolean = p.GestionNumeroSerieConActivos()
                If Grid.DataSource Is Nothing OrElse Grid.RowCount = 0 Then
                    Dim DtGrid As DataTable = dtNSerie.Clone
                    Dim ClsArtN As New ArticuloNSerie
                    Dim DtArtN As DataTable
                    For Each Dr As DataRow In dtNSerie.Select
                        Dim f As New Filter
                        f.Add(New FilterItem("NSerie", FilterOperator.Equal, Dr("NSerie"), FilterType.String))
                        If Not blnActivo Then
                            f.Add(New FilterItem("IDArticulo", FilterOperator.Equal, IDArticulo.Text, FilterType.String))
                        End If
                        DtArtN = ClsArtN.Filter(f)
                        'DtArtN = ClsArtN.Filter(New FilterItem("NSerie", FilterOperator.Equal, Dr("NSerie"), FilterType.String))
                        If Not DtArtN Is Nothing AndAlso DtArtN.Rows.Count > 0 Then
                            Dim DE As New BE.DataEngine
                            Dim DtEst As DataTable = DE.Filter("tbMntoEstadoActivo", New FilterItem("IDEstadoActivo", DtArtN.Rows(0)("IDEstadoActivo")))
                            If DtEst.Rows(0)("Baja") Then
                                If ExpertisApp.GenerateMessage("El Número de Serie | ya está asignado al artículo | y está en estado de baja.|¿Desea volver a ponerlo en disponible?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, Dr("NSerie"), DtArtN.Rows(0)("IDArticulo"), vbNewLine) = DialogResult.Yes Then
                                    Dr("IDAlmacen") = IDAlmacen.Text
                                    DtGrid.Rows.Add(Dr.ItemArray)
                                End If
                            Else
                                ExpertisApp.GenerateMessage("El número de serie '|' ya existe en el listado de Numeros de Serie.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Dr("NSerie"))
                            End If
                        Else
                            DtGrid.Rows.Add(Dr.ItemArray)
                        End If
                    Next

                    'David Velasco 05/10
                    'Dim activo As New Activo
                    'Dim pordefecto00 As String
                    'pordefecto00 = "00"

                    'For Each dr As DataRow In DtGrid.Rows
                    '    activo.CreaActivo(dr("IDActivo"), dr("NSerie"), dr("IDArticulo"), pordefecto00, dr("IDEstadoActivo"), dr("IDOperario"))
                    '    activo.CreaEstadoActivo(dr("IDActivo"), dr("IDEstadoActivo"), dr("IDOperario"))
                    '    activo.crearArtNSerie(dr("IDArticulo"), dr("NSerie"), dr("IDActivo"), dr("IDEstadoActivo"), dr("IDOperario"))
                    '    'activo.AsignoNSerie(dr("IDActivo"), dr("NSerie"))
                    '    'activo.AsignoNSerie("LIL", "LIL")

                    'Next
                    'David Velasco 05/10

                    Grid.DataSource = DtGrid
                ElseIf Not dtNSerie Is Nothing AndAlso dtNSerie.Rows.Count > 0 Then
                    Dim dtGrid As DataTable = Grid.DataSource
                    Dim DtArtN As DataTable
                    Dim ClsArtN As New ArticuloNSerie
                    For Each drNSerie As DataRow In dtNSerie.Rows
                        Dim dv As New DataView(dtGrid.Copy)
                        Dim f As New Filter
                        f.Add(New StringFilterItem("NSerie", drNSerie("NSerie")))
                        dv.RowFilter = f.Compose(New AdoFilterComposer)
                        If dv.Count = 0 Then
                            Dim f1 As New Filter
                            f1.Add(New FilterItem("NSerie", FilterOperator.Equal, drNSerie("NSerie"), FilterType.String))
                            If Not blnActivo Then
                                f1.Add(New FilterItem("IDArticulo", FilterOperator.Equal, IDArticulo.Text, FilterType.String))
                            End If
                            DtArtN = ClsArtN.Filter(f1)
                            'DtArtN = ClsArtN.Filter(New FilterItem("NSerie", FilterOperator.Equal, drNSerie("NSerie"), FilterType.String))
                            If Not DtArtN Is Nothing AndAlso DtArtN.Rows.Count > 0 Then
                                Dim DE As New BE.DataEngine
                                Dim DtEst As DataTable = DE.Filter("tbMntoEstadoActivo", New FilterItem("IDEstadoActivo", DtArtN.Rows(0)("IDEstadoActivo")))
                                If DtEst.Rows(0)("Baja") Then
                                    If ExpertisApp.GenerateMessage("El Número de Serie | ya está asignado al artículo | y está en estado de baja.|¿Desea volver a ponerlo en disponible?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, drNSerie("NSerie"), DtArtN.Rows(0)("IDArticulo"), vbNewLine) = DialogResult.Yes Then
                                        drNSerie("IDAlmacen") = IDAlmacen.Text
                                        dtGrid.Rows.Add(drNSerie.ItemArray)
                                    End If
                                Else
                                    ExpertisApp.GenerateMessage("El número de serie '|' ya existe en el listado de Numeros de Serie.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, drNSerie("NSerie"))
                                End If
                            Else
                                dtGrid.Rows.Add(drNSerie.ItemArray)
                            End If
                        Else
                            ExpertisApp.GenerateMessage("El número de serie '|' ya existe en la lista actual.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, drNSerie("NSerie"))
                        End If
                    Next
                    Grid.DataSource = dtGrid
                End If

                ActualizarTotales()
            End If
        End If
    End Sub

    Private Sub ActualizarTotales()
        Dim dt As DataTable = CType(Totales.DataSource, DataTable)
        If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
            dt.Rows(0)("CantidadAsignada") = Grid.RowCount
            dt.Rows(0)("Diferencia") = dt.Rows(0)("CantidadAsignar") - dt.Rows(0)("CantidadAsignada")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub OkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkButton.Click

    End Sub
End Class
