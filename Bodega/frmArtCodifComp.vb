Public Class frmArtCodifComp

#Region "Variables Privadas / Propiedades Públicas"

    Protected mIDArticulo As String
    Public WriteOnly Property IDArticulo() As String
        Set(ByVal value As String)
            mIDArticulo = value
            Me.ULblArticulo.Text = value
        End Set
    End Property

    Public WriteOnly Property DescArticulo() As String
        Set(ByVal value As String)
            Me.ULblDescArticulo.Text = value
        End Set
    End Property

    Protected mUDMedidaArticulo As String
    Public WriteOnly Property UDMedidaArticulo() As String
        Set(ByVal value As String)
            mUDMedidaArticulo = value
            Me.ulblUDMedidaArticulo.Text = mUDMedidaArticulo
        End Set
    End Property


    Protected mUDExpedicion As String
    Public WriteOnly Property UDExpedicion() As String
        Set(ByVal value As String)
            mUDExpedicion = value
            Me.ULblUDExpedicion.Text = value
        End Set
    End Property

    Protected mDblCantidadTotal As Double = 0
    Public WriteOnly Property CantidadTotal() As Double
        Set(ByVal value As Double)
            mDblCantidadTotal = value
        End Set
    End Property

    Protected mIDLineaPedido As Integer
    Public Property IDLineaPedido() As Integer
        Get
            Return mIDLineaPedido
        End Get
        Set(ByVal value As Integer)
            mIDLineaPedido = value
        End Set
    End Property

    Protected mlstArticulosPrimerNivel As List(Of DataRow)
    Public ReadOnly Property ArticulosPrimerNivel() As List(Of DataRow)
        Get
            Return mlstArticulosPrimerNivel
        End Get
    End Property

    Protected mlstArticulosSegundoNivel As List(Of DataRow)
    Public ReadOnly Property ArticulosSegundoNivel() As List(Of DataRow)
        Get
            Return mlstArticulosSegundoNivel
        End Get
    End Property

    Protected mlstArticulosCompatibles As New List(Of DataRow)
    Public ReadOnly Property ArticulosCompatibles() As List(Of DataRow)
        Get
            Return mlstArticulosCompatibles
        End Get
    End Property

    Public ReadOnly Property IDDeposito() As String
        Get
            Return Me.AdvDeposito.Value
        End Get
    End Property

    Public ReadOnly Property IDTipoOperacion() As String
        Get
            Return Me.AdvTipoOperacion.Value
        End Get
    End Property

#End Region

#Region " Carga del formulario "

    Protected Overridable Sub frmArtCodifComp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            LoadData()
        End If
    End Sub

    Protected Overridable Sub LoadData()
        Dim datArtComp As New Articulo.DataObtenerArticulosCompatibles(mIDArticulo, mUDMedidaArticulo, mIDLineaPedido)
        datArtComp = ExpertisApp.ExecuteTask(Of Articulo.DataObtenerArticulosCompatibles, Articulo.DataObtenerArticulosCompatibles)(AddressOf Articulo.ObtenerArticulosCompatibles, datArtComp)

        If Not datArtComp.dtArticulosPrimerNivel Is Nothing Then GrdArtPrincipal.AddCheckColumnToDataSource(datArtComp.dtArticulosPrimerNivel, Nothing)
        If Not datArtComp.dtArticulosSegundoNivel Is Nothing Then GrdArtSecundario.AddCheckColumnToDataSource(datArtComp.dtArticulosSegundoNivel, Nothing)

        Me.GrdArtPrincipal.DataSource = datArtComp.dtArticulosPrimerNivel
        Me.GrdArtSecundario.DataSource = datArtComp.dtArticulosSegundoNivel
        Me.NtbCantidadAAsignar.Value = mDblCantidadTotal
        CalcularDiferencia()

        Dim ClsParam As New Parametro
        Dim StrIDTipoOper As String = ClsParam.BodegaTipoOperacionArtCompatibles
        Dim StrDepOper As String = ClsParam.BodegaDepositoArtCompatibles
        Me.AdvTipoOperacion.Value = StrIDTipoOper
        Me.AdvDeposito.Value = StrDepOper
    End Sub

#End Region

#Region " Funciones / Procesos Privados "

    Protected Overridable Function GetArticulosPrimerNivelMarcados() As List(Of DataRow)
        If Not Me.GrdArtPrincipal.DataSource Is Nothing AndAlso Not GrdArtPrincipal.CheckedRecords Is Nothing Then
            Return (From c In CType(GrdArtPrincipal.DataSource, DataTable) Where Not c.IsNull("Expertis.CheckValue") AndAlso c("Expertis.CheckValue") = True Select c).ToList
        End If
    End Function

    Protected Overridable Function GetArticulosSegundoNivelMarcados() As List(Of DataRow)
        If Not Me.GrdArtSecundario.DataSource Is Nothing AndAlso Not GrdArtSecundario.CheckedRecords Is Nothing Then
            Return (From c In CType(GrdArtSecundario.DataSource, DataTable) Where Not c.IsNull("Expertis.CheckValue") AndAlso c("Expertis.CheckValue") = True Select c).ToList
        End If
    End Function

    Protected Overridable Sub CalcularDiferencia()
        Dim DblTotalPrin As Double
        Dim lstArtPrimerNivelMarcados As List(Of DataRow) = GetArticulosPrimerNivelMarcados()
        Dim lstArtSegundoNivelMarcados As List(Of DataRow) = GetArticulosSegundoNivelMarcados()

        If Not lstArtPrimerNivelMarcados Is Nothing Then
            DblTotalPrin = (Aggregate c In lstArtPrimerNivelMarcados Into Sum(CDbl(c("Cantidad")) * CDbl(c("Factor"))))
        End If

        Dim DblTotalSecon As Double
        If Not lstArtSegundoNivelMarcados Is Nothing Then
            DblTotalSecon = (Aggregate c In lstArtSegundoNivelMarcados Into Sum(CDbl(c("Cantidad")) * CDbl(c("Factor"))))
        End If

        Me.NtbCantidadAsignada.Value = DblTotalPrin + DblTotalSecon
        Me.NtbDiferencia.Value = Nz(Me.NtbCantidadAsignada.Value, 0) - Nz(Me.NtbCantidadAAsignar.Value, 0)
        If Me.NtbDiferencia.Value < 0 Then
            Me.NtbDiferencia.ForeColor = Color.Red
        ElseIf Me.NtbDiferencia.Value > 0 Then
            Me.NtbDiferencia.ForeColor = Color.Blue
        End If
    End Sub

    Protected Overridable Function CheckData() As Boolean
        If Nz(Me.NtbDiferencia.Value, 0) <> 0 Then
            ExpertisApp.GenerateMessage("La cantidad asignada no es correcta.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        Dim lstArtPrimerNivelMarcados As List(Of DataRow) = GetArticulosPrimerNivelMarcados()
        Dim lstArtSegundoNivelMarcados As List(Of DataRow) = GetArticulosSegundoNivelMarcados()
        If (lstArtPrimerNivelMarcados Is Nothing OrElse lstArtPrimerNivelMarcados.Count = 0) AndAlso _
           (lstArtSegundoNivelMarcados Is Nothing OrElse lstArtSegundoNivelMarcados.Count = 0) Then
            ExpertisApp.GenerateMessage("No se ha seleccionado ningún registro.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        If Length(Me.AdvTipoOperacion.Value) = 0 Then
            ExpertisApp.GenerateMessage("El Tipo de Operación es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        If Length(Me.AdvDeposito.Value) = 0 Then
            ExpertisApp.GenerateMessage("El Depósito es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        Return True
    End Function

#End Region

#Region " Grids "

    Protected Overridable Sub Grids_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GrdArtPrincipal.FormattingRow, GrdArtSecundario.FormattingRow
        If e.Row.Cells("IDUDInterna").Value = mUDExpedicion Then
            e.Row.RowStyle = sender.FormatStyles("FMTUDExpedicion")
        End If
    End Sub

    Protected Overridable Sub Grids_CheckingRecord(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.CheckingEventArgs) Handles GrdArtPrincipal.CheckingRecord, GrdArtSecundario.CheckingRecord
        If e.CheckState = CheckStates.UnChecked Then
            If NtbDiferencia.Value = 0 Then e.Cancel = True
            If Nz(sender.GetValue("Expertis.Check"), False) AndAlso sender.GetValue("Cantidad") = 0 AndAlso NtbDiferencia.Value <> 0 Then
                Dim QTotal As Double
                Dim Factor As Double = Nz(sender.GetValue("Factor"), 1)
                If Factor <> 0 Then
                    QTotal = Nz(sender.GetValue("CantidadTotal"), 0) / Factor
                Else
                    QTotal = 0
                End If

                Dim Q As Double = 0
                If NtbDiferencia.Value > 0 AndAlso NtbDiferencia.Value < QTotal Then
                    Q = NtbDiferencia.Value / Factor
                ElseIf NtbDiferencia.Value < 0 AndAlso Math.Abs(NtbDiferencia.Value) < QTotal Then
                    Q = Math.Abs(NtbDiferencia.Value) / Factor
                Else
                    Q = QTotal
                End If

                sender.SetValue("Cantidad", Q)
            End If
        Else
            sender.SetValue("Cantidad", 0)
        End If
    End Sub
    Protected Overridable Sub Grids_RecordChecked(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.CheckedEventArgs) Handles GrdArtPrincipal.RecordChecked, GrdArtSecundario.RecordChecked
        CalcularDiferencia()
    End Sub

    Protected Overridable Sub Grids_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdArtPrincipal.CellUpdated, GrdArtSecundario.CellUpdated
        Select Case e.Column.Key
            Case "Cantidad"
                If Nz(sender.GetValue("Cantidad"), 0) <> 0 Then
                    sender.CheckRecord()
                Else
                    sender.UnCheckRecord()
                End If
        End Select
    End Sub
#End Region

#Region " Aceptar/Cancelar "

    Protected Overridable Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If CheckData() Then
            mlstArticulosPrimerNivel = GetArticulosPrimerNivelMarcados()
            mlstArticulosSegundoNivel = GetArticulosSegundoNivelMarcados()
            If Not mlstArticulosSegundoNivel Is Nothing AndAlso mlstArticulosSegundoNivel.Count > 0 Then mlstArticulosCompatibles.InsertRange(0, mlstArticulosSegundoNivel)
            If Not mlstArticulosPrimerNivel Is Nothing AndAlso mlstArticulosPrimerNivel.Count > 0 Then mlstArticulosCompatibles.InsertRange(0, mlstArticulosPrimerNivel)

            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Protected Overridable Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

#End Region

End Class