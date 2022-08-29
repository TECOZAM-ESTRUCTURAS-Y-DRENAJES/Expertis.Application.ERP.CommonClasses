Imports Janus.Windows.TimeLine

Public Class CtrlTimeLineObras

#Region "Variables Privadas"

    Private MyDtData As DataTable
    Private MyIDObra As Integer = -1
    Private MyIDTrabajo As Integer
    Private MyNavigationLevel As enumNavigationLevel
    Private MBlnChangingItem As Boolean = False
    Private MBlnLoad As Boolean = True

    Public Event UpdateTrabajo(ByVal IDTrabajo As Integer, ByVal StartDate As DateTime, ByVal EndDate As DateTime, ByVal Avance As Double, ByVal TipoAvance As Integer)
    Public Event UpdateInsertTrabajo(ByVal IDTrabajo As Integer, ByVal FechaInicio As Date, ByVal FechaFin As Date)
    Public Event VerFichaTrabajo(ByVal IDTrabajo As Integer)

#End Region

#Region "Propiedades Públicas"

    Public WriteOnly Property IDObra() As Integer
        Set(ByVal value As Integer)
            MyIDObra = value
        End Set
    End Property

    Public WriteOnly Property IDTrabajo() As Integer
        Set(ByVal value As Integer)
            MyIDTrabajo = value
        End Set
    End Property

#End Region

#Region "Funciones / Procesos Privados"

    Public Sub LoadTimeObras()
        Me.SplTimes.Panel2.Hide()
        Me.SplTimes.Panel2Collapsed = True
        If Not Me.DesignMode Then
            If Not MBlnLoad Then
                If RdPorObra.Checked = False AndAlso RdPorNivel.Checked = False Then
                    RdPorObra.Checked = True
                Else
                    If MyIDObra <> -1 Then
                        Me.FrmOpciones.Enabled = True
                        FillData()
                        LoadTimeLineInfo()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub LoadTimeLineInfo()
        Me.TimeObras.DataSource = mydtdata
        Me.TimeObras.StartTimeMember = "StartTime"
        Me.TimeObras.EndTimeMember = "EndTime"
        Me.TimeObras.EstimatedStartTimeMember = "EstimatedStartTime"
        Me.TimeObras.EstimatedEndTimeMember = "EstimatedEndTime"
        Me.TimeObras.TextMember = "TextMember"
        Me.TimeObras.ToolTipMember = "ToolTipMember"
        If MyDtData.Rows.Count > 0 Then Me.TimeObras.FirstDate = CDate(MyDtData.Compute("MIN(StartTime)", "")).AddDays(-3)
        For Each itm As TimeLineItem In Me.TimeObras.Items
            itm.Tag = itm.DataRow("IDTrabajo")
        Next
        For Each ItmGrp As TimeLineGroupRow In Me.TimeObras.GetGroupRows
            Dim DrSel() As DataRow = MyDtData.Select("Secuencia = " & ItmGrp.Value)
            If DrSel.Length > 0 Then
                ItmGrp.GroupCaption = DrSel(0)("TextMember")
                ItmGrp.Tag = DrSel(0)("IDTrabajo")
            End If
        Next
    End Sub

    Private Sub LoadDtData()
        MyDtData = New DataTable
        MyDtData.Columns.Add("IDTrabajo", GetType(Integer))
        MyDtData.Columns.Add("IDTrabajoPadre", GetType(Integer))
        MyDtData.Columns.Add("StartTime", GetType(DateTime))
        MyDtData.Columns.Add("EndTime", GetType(DateTime))
        MyDtData.Columns.Add("EstimatedStartTime", GetType(DateTime))
        MyDtData.Columns.Add("EstimatedEndTime", GetType(DateTime))
        MyDtData.Columns.Add("TextMember", GetType(String))
        MyDtData.Columns.Add("ToolTipMember", GetType(String))
        MyDtData.Columns.Add("AvanceEstimado", GetType(Double))
        MyDtData.Columns.Add("AvanceCalculado", GetType(Double))
        MyDtData.Columns.Add("Secuencia", GetType(Integer))
        MyDtData.TableName = "Trabajos"
    End Sub

    Private Sub FillData()
        Dim DtTrabajos As DataTable = New ObraTrabajo().Filter(New FilterItem("IDObra", FilterOperator.Equal, MyIDObra))
        If Not DtTrabajos Is Nothing AndAlso DtTrabajos.Rows.Count > 0 Then
            If MyDtData Is Nothing OrElse MyDtData.Columns.Count = 0 Then LoadDtData()
            MyDtData.Rows.Clear()
            Dim FilTrabajos As New Filter
            FilTrabajos.Add(New IsNullFilterItem("FechaInicio", False))
            FilTrabajos.Add(New IsNullFilterItem("FechaFin", False))
            If MyNavigationLevel = enumNavigationLevel.PorNivel Then
                FilTrabajos.Add("IDTrabajoPadre", FilterOperator.Equal, MyIDTrabajo)
            End If
            For Each Dr As DataRow In DtTrabajos.Select(FilTrabajos.Compose(New AdoFilterComposer), "Secuencia")
                Dim DrNew As DataRow = MyDtData.NewRow
                DrNew("IDTrabajo") = Dr("IDTrabajo")
                DrNew("IDTrabajoPadre") = DBNull.Value
                DrNew("StartTime") = Dr("FechaInicio")
                DrNew("EndTime") = Dr("FechaFin")
                DrNew("AvanceEstimado") = Nz(Dr("AvanceEstimado"), 0)
                DrNew("AvanceCalculado") = Nz(Dr("AvanceCalculado"), 0)
                Dim IntDur As Integer = CDate(Dr("FechaFin")).Day - CDate(Dr("FechaInicio")).Day
                Dim DblAvance As Double
                If Me.CmbAvance.Value = 0 Then
                    DblAvance = Nz(DrNew("AvanceEstimado"), 0)
                Else : DblAvance = Nz(DrNew("AvanceCalculado"), 0)
                End If
                Dim IntDiasEst As Integer = Math.Ceiling((DblAvance * IntDur) / 100)
                Dim DtEstStart As DateTime = DrNew("StartTime")
                Dim DtEstEnd As DateTime = DtEstStart.AddDays(IntDiasEst)
                DrNew("EstimatedStartTime") = DtEstStart
                DrNew("EstimatedEndTime") = DtEstEnd
                DrNew("Secuencia") = Dr("Secuencia")
                DrNew("TextMember") = Dr("Secuencia") & " - " & Dr("CodTrabajo")
                DrNew("ToolTipMember") = Dr("CodTrabajo") & " - " & Dr("DescTrabajo")
                MyDtData.Rows.Add(DrNew)
            Next
            MyDtData.AcceptChanges()
        End If
    End Sub

    Private Sub LoadAvances()
        Dim DtNew As New DataTable
        DtNew.Columns.Add("Text", GetType(String))
        DtNew.Columns.Add("Value", GetType(Integer))

        Dim DrNew1 As DataRow = DtNew.NewRow
        DrNew1("Text") = "Avance Estimado"
        DrNew1("Value") = 0
        DtNew.Rows.Add(DrNew1)

        Dim DrNew2 As DataRow = DtNew.NewRow
        DrNew2("Text") = "Avance Calculado"
        DrNew2("Value") = 1
        DtNew.Rows.Add(DrNew2)
        DtNew.AcceptChanges()

        Me.CmbAvance.DataSource = DtNew
        Me.CmbAvance.Value = 0
    End Sub

#End Region

#Region "Eventos CtrlTimeLineObras"

#Region "Eventos Formulario"

    Private Sub CtrlTimeLineObras_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MBlnLoad = True
        LoadAvances()
        MBlnLoad = False
    End Sub

#End Region

#Region "Eventos TimeLine"

    Private Sub TimeObras_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TimeObras.DoubleClick
        If Me.FrmOpciones.Enabled Then
            Dim tmlArea As TimeLineArea = Me.TimeObras.HitTest()
            If tmlArea = TimeLineArea.Background Then
                Me.CmdNew.InvokeOnClick()
            ElseIf tmlArea = TimeLineArea.TimeLineItem Then
                'raise de llamar a ir a ver ficha de ese item en las obras
                Dim Itm As TimeLineItem = Me.TimeObras.GetItemAt
                RaiseEvent VerFichaTrabajo(Itm.Tag)
            End If
        End If
    End Sub

    Private Sub TimeObras_ItemChanged(ByVal sender As Object, ByVal e As Janus.Windows.TimeLine.ItemChangeEventArgs) Handles TimeObras.ItemChanged
        If Not mBlnChangingItem Then
            MBlnChangingItem = True
            If e.PropertyChanged = ItemChange.EstimatedEndTime OrElse e.PropertyChanged = ItemChange.EstimatedStartTime Then
                Dim IntDur As Integer = e.Item.EstimatedEndTime.Day - e.Item.EstimatedStartTime.Day
                Dim IntPrev As Integer = e.Item.EndTime.Day - e.Item.StartTime.Day
                Dim DblAvance As Double = 0
                If Me.CmbAvance.Value = 0 Then
                    e.Item.DataRow("AvanceEstimado") = Math.Floor((IntDur * 100) / IntPrev)
                    RaiseEvent UpdateTrabajo(e.Item.DataRow("IDTrabajo"), e.Item.StartTime, e.Item.EndTime, Nz(e.Item.DataRow("AvanceEstimado"), 0), 0)
                Else
                    e.Item.DataRow("AvanceCalculado") = Math.Floor((IntDur * 100) / IntPrev)
                    RaiseEvent UpdateTrabajo(e.Item.DataRow("IDTrabajo"), e.Item.StartTime, e.Item.EndTime, Nz(e.Item.DataRow("AvanceCalculado"), 0), 1)
                End If

            Else
                e.Item.EstimatedStartTime = e.Item.StartTime
                Dim IntDur As Integer = e.Item.EndTime.Day - e.Item.StartTime.Day
                Dim IntDiasEst As Integer = 0
                If CmbAvance.Value = 0 Then
                    IntDiasEst = Math.Ceiling((Nz(e.Item.DataRow("AvanceEstimado"), 0) * IntDur) / 100)
                    e.Item.EstimatedEndTime = e.Item.EstimatedStartTime.AddDays(IntDiasEst)
                    RaiseEvent UpdateTrabajo(e.Item.DataRow("IDTrabajo"), e.Item.StartTime, e.Item.EndTime, Nz(e.Item.DataRow("AvanceEstimado"), 0), 0)
                Else
                    IntDiasEst = Math.Ceiling((Nz(e.Item.DataRow("AvanceCalculado"), 0) * IntDur) / 100)
                    e.Item.EstimatedEndTime = e.Item.EstimatedStartTime.AddDays(IntDiasEst)
                    RaiseEvent UpdateTrabajo(e.Item.DataRow("IDTrabajo"), e.Item.StartTime, e.Item.EndTime, Nz(e.Item.DataRow("AvanceCalculado"), 0), 1)
                End If
            End If
            Me.FrmOpciones.Enabled = False
            MBlnChangingItem = False
        End If
    End Sub

    Private Sub TimeObras_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TimeObras.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim tmlArea As TimeLineArea = Me.TimeObras.HitTest()
            If tmlArea = TimeLineArea.Background Then
                Me.UICTxtOptions.Commands("CmdNew").Visible = Janus.Windows.UI.InheritableBoolean.True
            Else
                Me.UICTxtOptions.Commands("CmdNew").Visible = Janus.Windows.UI.InheritableBoolean.False
            End If
            If FrmOpciones.Enabled Then Me.UICTxtOptions.Show()
        End If
    End Sub

#End Region

#Region "Eventos CmdCTxtOpciones"

    Private Sub CmdNew_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles CmdNew.Click
        Dim DtFechas As Date = Me.TimeObras.GetDateTimeAt
        RaiseEvent UpdateInsertTrabajo(Me.TimeObras.GetGroupRowAt.Tag, DtFechas, DtFechas)
    End Sub

    Private Sub CmdPorObra_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles CmdPorObra1.Click
        Me.RdPorObra.Checked = True
    End Sub

    Private Sub CmdPorNivel_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles CmdPorNivel.Click
        Me.RdPorNivel.Checked = True
    End Sub

    Private Sub CmdAvanceEstimado_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles CmdAvanceEstimado.Click
        Me.CmbAvance.Value = 0
    End Sub

    Private Sub CmdAvanceCalculado_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles CmdAvanceCalculado.Click
        Me.CmbAvance.Value = 1
    End Sub

#End Region

#End Region

#Region "Eventos RadioButtons"

    Private Sub RdPorObra_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RdPorObra.CheckedChanged
        MyNavigationLevel = enumNavigationLevel.PorObra
        Me.CmdPorNivel.IsChecked = False : Me.CmdPorObra.IsChecked = True
        Me.CmdPorNivel.Checked = Janus.Windows.UI.InheritableBoolean.False : Me.CmdPorObra1.Checked = Janus.Windows.UI.InheritableBoolean.True
        LoadTimeObras()
    End Sub

    Private Sub RdPorNivel_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RdPorNivel.CheckedChanged
        MyNavigationLevel = enumNavigationLevel.PorNivel
        Me.CmdPorNivel.IsChecked = True : Me.CmdPorObra.IsChecked = False
        Me.CmdPorNivel.Checked = Janus.Windows.UI.InheritableBoolean.True : Me.CmdPorObra1.Checked = Janus.Windows.UI.InheritableBoolean.False
        LoadTimeObras()
    End Sub

#End Region

#Region "Eventos Combobox"

    Private Sub CmbAvance_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAvance.ValueChanged
        If Me.CmbAvance.Value = 0 Then
            Me.CmdAvanceEstimado.IsChecked = True : Me.CmdAvanceCalculado.IsChecked = False
            Me.CmdAvanceEstimado.Checked = Janus.Windows.UI.InheritableBoolean.True : Me.CmdAvanceCalculado.Checked = Janus.Windows.UI.InheritableBoolean.False
        Else
            Me.CmdAvanceEstimado.IsChecked = False : Me.CmdAvanceCalculado.IsChecked = True
            Me.CmdAvanceEstimado.Checked = Janus.Windows.UI.InheritableBoolean.False : Me.CmdAvanceCalculado.Checked = Janus.Windows.UI.InheritableBoolean.True
        End If
        LoadTimeObras()
    End Sub

#End Region

End Class

#Region "Enumerados / Estructuras Públicas"

Public Enum enumNavigationLevel
    PorObra = 0
    PorNivel = 1
End Enum

Public Enum EnumValueData
    Real = 0
    Estimado = 1
End Enum

<Serializable()> _
Public Structure DataConfigInfo
    Public TipoNavigationLevel As enumNavigationLevel
    Public ValueData As EnumValueData

    Public Sub New(ByVal TipoNavigationLevel As enumNavigationLevel, ByVal ValueData As EnumValueData)
        Me.TipoNavigationLevel = TipoNavigationLevel
        Me.ValueData = ValueData
    End Sub
End Structure

#End Region