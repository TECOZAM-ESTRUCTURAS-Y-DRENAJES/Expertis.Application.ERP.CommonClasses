<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrlTimeLineObras
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim TimeObras_DesignTimeLayout As Janus.Windows.TimeLine.TimeLineLayout = New Janus.Windows.TimeLine.TimeLineLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtrlTimeLineObras))
        Dim CmbAvance_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim TimeExtendedObras_DesignTimeLayout As Janus.Windows.TimeLine.TimeLineLayout = New Janus.Windows.TimeLine.TimeLineLayout
        Me.TimeObras = New Janus.Windows.TimeLine.TimeLine
        Me.UICmdTimeLine = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.CmdNew = New Janus.Windows.UI.CommandBars.UICommand("CmdNew")
        Me.CmdView = New Janus.Windows.UI.CommandBars.UICommand("CmdView")
        Me.CmdPorObra1 = New Janus.Windows.UI.CommandBars.UICommand("CmdPorObra")
        Me.CmdPorNivel1 = New Janus.Windows.UI.CommandBars.UICommand("CmdPorNivel")
        Me.CmdPorObra = New Janus.Windows.UI.CommandBars.UICommand("CmdPorObra")
        Me.CmdPorNivel = New Janus.Windows.UI.CommandBars.UICommand("CmdPorNivel")
        Me.CmdTipoAvance = New Janus.Windows.UI.CommandBars.UICommand("CmdTipoAvance")
        Me.CmdAvanceEstimado1 = New Janus.Windows.UI.CommandBars.UICommand("CmdAvanceEstimado")
        Me.CmdAvanceCalculado1 = New Janus.Windows.UI.CommandBars.UICommand("CmdAvanceCalculado")
        Me.CmdAvanceEstimado = New Janus.Windows.UI.CommandBars.UICommand("CmdAvanceEstimado")
        Me.CmdAvanceCalculado = New Janus.Windows.UI.CommandBars.UICommand("CmdAvanceCalculado")
        Me.UICTxtOptions = New Janus.Windows.UI.CommandBars.UIContextMenu
        Me.CmdNew1 = New Janus.Windows.UI.CommandBars.UICommand("CmdNew")
        Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.CmdView1 = New Janus.Windows.UI.CommandBars.UICommand("CmdView")
        Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.CmdTipoAvance1 = New Janus.Windows.UI.CommandBars.UICommand("CmdTipoAvance")
        Me.ImgList = New System.Windows.Forms.ImageList(Me.components)
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.FrmOpciones = New Solmicro.Expertis.Engine.UI.Frame
        Me.LblTipoAvance = New Solmicro.Expertis.Engine.UI.Label
        Me.LblNivel = New Solmicro.Expertis.Engine.UI.Label
        Me.CmbAvance = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.RdPorNivel = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.RdPorObra = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.TimeExtendedObras = New Janus.Windows.TimeLine.TimeLine
        Me.SplTimes = New System.Windows.Forms.SplitContainer
        Me.FrmTimeObras = New Solmicro.Expertis.Engine.UI.Frame
        Me.FrmTimeExtendedObras = New Solmicro.Expertis.Engine.UI.Frame
        CType(Me.TimeObras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UICmdTimeLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UICTxtOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrmOpciones.SuspendLayout()
        CType(Me.CmbAvance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeExtendedObras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplTimes.Panel1.SuspendLayout()
        Me.SplTimes.Panel2.SuspendLayout()
        Me.SplTimes.SuspendLayout()
        Me.FrmTimeObras.SuspendLayout()
        Me.FrmTimeExtendedObras.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimeObras
        '
        Me.TimeObras.AllowEdit = False
        Me.TimeObras.AllowExpandRowHeader = False
        Me.TimeObras.AllowItemDrag = CType(((Janus.Windows.TimeLine.AllowItemDrag.Move Or Janus.Windows.TimeLine.AllowItemDrag.Resize) _
                    Or Janus.Windows.TimeLine.AllowItemDrag.EstimatedDurationChange), Janus.Windows.TimeLine.AllowItemDrag)
        TimeObras_DesignTimeLayout.LayoutString = resources.GetString("TimeObras_DesignTimeLayout.LayoutString")
        Me.TimeObras.DesignTimeLayout = TimeObras_DesignTimeLayout
        Me.TimeObras.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.TimeObras.DropDownCalendar.Name = ""
        Me.TimeObras.FirstDate = New Date(2010, 10, 25, 0, 0, 0, 0)
        Me.TimeObras.FirstDayOfWeek = Janus.Windows.TimeLine.DayOfWeek.Monday
        Me.TimeObras.GridLines = Janus.Windows.TimeLine.GridLines.Both
        Me.TimeObras.ItemsBarFormatStyle.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TimeObras.ItemsDurationBarHeight = 10
        Me.TimeObras.ItemsEstimatedBarFormatStyle.BackColor = System.Drawing.Color.ForestGreen
        Me.TimeObras.ItemsFormatStyle.BackColor = System.Drawing.Color.White
        Me.TimeObras.ItemSizeMode = Janus.Windows.TimeLine.ItemSizeMode.DurationBased
        Me.TimeObras.ItemsLineStyle = Janus.Windows.TimeLine.ItemsLineStyle.SmallDots
        Me.TimeObras.ItemToolTip = Janus.Windows.TimeLine.ItemToolTip.UseToolTipMember
        Me.TimeObras.Location = New System.Drawing.Point(3, 17)
        Me.TimeObras.MultiSelect = False
        Me.TimeObras.Name = "TimeObras"
        Me.TimeObras.RowHeight = 40
        Me.TimeObras.ShowItemsEstimatedDurationBar = True
        Me.TimeObras.ShowLastGroupAsRowHeader = True
        Me.TimeObras.ShowWeekNumbers = True
        Me.TimeObras.Size = New System.Drawing.Size(833, 146)
        Me.TimeObras.TabIndex = 0
        Me.TimeObras.Text = "TimeObras"
        Me.TimeObras.TimescaleTiers = Janus.Windows.TimeLine.TimescaleTiers.ThreeTiers
        Me.TimeObras.TooltipFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeObras.VisualStyle = Janus.Windows.TimeLine.VisualStyle.Office2003
        Me.TimeObras.WeekText = "Semana"
        Me.TimeObras.WorkEndTime = System.TimeSpan.Parse("18.00:00:00")
        Me.TimeObras.WorkingTimeFormatStyle.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TimeObras.YearText = "Año"
        '
        'UICmdTimeLine
        '
        Me.UICmdTimeLine.BottomRebar = Me.BottomRebar1
        Me.UICmdTimeLine.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.CmdNew, Me.CmdView, Me.CmdPorObra, Me.CmdPorNivel, Me.CmdTipoAvance, Me.CmdAvanceEstimado, Me.CmdAvanceCalculado})
        Me.UICmdTimeLine.ContainerControl = Me
        Me.UICmdTimeLine.ContextMenus.AddRange(New Janus.Windows.UI.CommandBars.UIContextMenu() {Me.UICTxtOptions})
        Me.UICmdTimeLine.Id = New System.Guid("d8b5cb9a-80d5-4c40-9c47-b876f010b964")
        Me.UICmdTimeLine.ImageList = Me.ImgList
        Me.UICmdTimeLine.LeftRebar = Me.LeftRebar1
        Me.UICmdTimeLine.RightRebar = Me.RightRebar1
        Me.UICmdTimeLine.TopRebar = Me.TopRebar1
        '
        'BottomRebar1
        '
        Me.BottomRebar1.CommandManager = Me.UICmdTimeLine
        Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomRebar1.Location = New System.Drawing.Point(0, 400)
        Me.BottomRebar1.Name = "BottomRebar1"
        Me.BottomRebar1.Size = New System.Drawing.Size(839, 0)
        '
        'CmdNew
        '
        Me.CmdNew.ImageIndex = 0
        Me.CmdNew.Key = "CmdNew"
        Me.CmdNew.Name = "CmdNew"
        Me.CmdNew.Text = "&Nuevo"
        '
        'CmdView
        '
        Me.CmdView.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.CmdPorObra1, Me.CmdPorNivel1})
        Me.CmdView.ImageIndex = 6
        Me.CmdView.Key = "CmdView"
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Text = "&Ver"
        '
        'CmdPorObra1
        '
        Me.CmdPorObra1.Checked = Janus.Windows.UI.InheritableBoolean.[False]
        Me.CmdPorObra1.Key = "CmdPorObra"
        Me.CmdPorObra1.Name = "CmdPorObra1"
        '
        'CmdPorNivel1
        '
        Me.CmdPorNivel1.Key = "CmdPorNivel"
        Me.CmdPorNivel1.Name = "CmdPorNivel1"
        '
        'CmdPorObra
        '
        Me.CmdPorObra.Key = "CmdPorObra"
        Me.CmdPorObra.Name = "CmdPorObra"
        Me.CmdPorObra.Text = "Por Proyecto"
        '
        'CmdPorNivel
        '
        Me.CmdPorNivel.Key = "CmdPorNivel"
        Me.CmdPorNivel.Name = "CmdPorNivel"
        Me.CmdPorNivel.Text = "Por Nivel"
        '
        'CmdTipoAvance
        '
        Me.CmdTipoAvance.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.CmdAvanceEstimado1, Me.CmdAvanceCalculado1})
        Me.CmdTipoAvance.Key = "CmdTipoAvance"
        Me.CmdTipoAvance.Name = "CmdTipoAvance"
        Me.CmdTipoAvance.Text = "Tipo Avance"
        '
        'CmdAvanceEstimado1
        '
        Me.CmdAvanceEstimado1.Key = "CmdAvanceEstimado"
        Me.CmdAvanceEstimado1.Name = "CmdAvanceEstimado1"
        '
        'CmdAvanceCalculado1
        '
        Me.CmdAvanceCalculado1.Key = "CmdAvanceCalculado"
        Me.CmdAvanceCalculado1.Name = "CmdAvanceCalculado1"
        '
        'CmdAvanceEstimado
        '
        Me.CmdAvanceEstimado.Key = "CmdAvanceEstimado"
        Me.CmdAvanceEstimado.Name = "CmdAvanceEstimado"
        Me.CmdAvanceEstimado.Text = "Avance Estimado"
        '
        'CmdAvanceCalculado
        '
        Me.CmdAvanceCalculado.Key = "CmdAvanceCalculado"
        Me.CmdAvanceCalculado.Name = "CmdAvanceCalculado"
        Me.CmdAvanceCalculado.Text = "Avance Calculado"
        '
        'UICTxtOptions
        '
        Me.UICTxtOptions.CommandManager = Me.UICmdTimeLine
        Me.UICTxtOptions.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.CmdNew1, Me.Separator2, Me.CmdView1, Me.Separator1, Me.CmdTipoAvance1})
        Me.UICTxtOptions.ImageList = Me.ImgList
        Me.UICTxtOptions.Key = "CTxtOptions"
        '
        'CmdNew1
        '
        Me.CmdNew1.Key = "CmdNew"
        Me.CmdNew1.Name = "CmdNew1"
        '
        'Separator2
        '
        Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator2.Key = "Separator"
        Me.Separator2.Name = "Separator2"
        '
        'CmdView1
        '
        Me.CmdView1.Key = "CmdView"
        Me.CmdView1.Name = "CmdView1"
        '
        'Separator1
        '
        Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator1.Key = "Separator"
        Me.Separator1.Name = "Separator1"
        '
        'CmdTipoAvance1
        '
        Me.CmdTipoAvance1.ImageIndex = 5
        Me.CmdTipoAvance1.Key = "CmdTipoAvance"
        Me.CmdTipoAvance1.Name = "CmdTipoAvance1"
        '
        'ImgList
        '
        Me.ImgList.ImageStream = CType(resources.GetObject("ImgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgList.Images.SetKeyName(0, "Add.ico")
        Me.ImgList.Images.SetKeyName(1, "pen_blue.ico")
        Me.ImgList.Images.SetKeyName(2, "delete.ico")
        Me.ImgList.Images.SetKeyName(3, "row_preferences.ico")
        Me.ImgList.Images.SetKeyName(4, "row.ico")
        Me.ImgList.Images.SetKeyName(5, "gear.ico")
        Me.ImgList.Images.SetKeyName(6, "find.ico")
        '
        'LeftRebar1
        '
        Me.LeftRebar1.CommandManager = Me.UICmdTimeLine
        Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftRebar1.Location = New System.Drawing.Point(0, 0)
        Me.LeftRebar1.Name = "LeftRebar1"
        Me.LeftRebar1.Size = New System.Drawing.Size(0, 400)
        '
        'RightRebar1
        '
        Me.RightRebar1.CommandManager = Me.UICmdTimeLine
        Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightRebar1.Location = New System.Drawing.Point(839, 0)
        Me.RightRebar1.Name = "RightRebar1"
        Me.RightRebar1.Size = New System.Drawing.Size(0, 400)
        '
        'TopRebar1
        '
        Me.TopRebar1.CommandManager = Me.UICmdTimeLine
        Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
        Me.TopRebar1.Name = "TopRebar1"
        Me.TopRebar1.Size = New System.Drawing.Size(839, 0)
        '
        'FrmOpciones
        '
        Me.FrmOpciones.Controls.Add(Me.LblTipoAvance)
        Me.FrmOpciones.Controls.Add(Me.LblNivel)
        Me.FrmOpciones.Controls.Add(Me.CmbAvance)
        Me.FrmOpciones.Controls.Add(Me.RdPorNivel)
        Me.FrmOpciones.Controls.Add(Me.RdPorObra)
        Me.FrmOpciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.FrmOpciones.Location = New System.Drawing.Point(0, 0)
        Me.FrmOpciones.Name = "FrmOpciones"
        Me.FrmOpciones.Size = New System.Drawing.Size(839, 48)
        Me.FrmOpciones.TabIndex = 0
        Me.FrmOpciones.TabStop = False
        Me.FrmOpciones.Text = "Opciones Gráfico"
        '
        'LblTipoAvance
        '
        Me.LblTipoAvance.Location = New System.Drawing.Point(603, 24)
        Me.LblTipoAvance.Name = "LblTipoAvance"
        Me.LblTipoAvance.Size = New System.Drawing.Size(95, 13)
        Me.LblTipoAvance.TabIndex = 5
        Me.LblTipoAvance.Text = "Tipo de Avance"
        '
        'LblNivel
        '
        Me.LblNivel.Location = New System.Drawing.Point(6, 24)
        Me.LblNivel.Name = "LblNivel"
        Me.LblNivel.Size = New System.Drawing.Size(97, 13)
        Me.LblNivel.TabIndex = 4
        Me.LblNivel.Text = "Ver datos por..."
        '
        'CmbAvance
        '
        Me.CmbAvance.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        CmbAvance_DesignTimeLayout.LayoutString = resources.GetString("CmbAvance_DesignTimeLayout.LayoutString")
        Me.CmbAvance.DesignTimeLayout = CmbAvance_DesignTimeLayout
        Me.CmbAvance.DisabledBackColor = System.Drawing.Color.White
        Me.CmbAvance.DisplayMember = "Text"
        Me.CmbAvance.Location = New System.Drawing.Point(704, 20)
        Me.CmbAvance.Name = "CmbAvance"
        Me.CmbAvance.SelectedIndex = -1
        Me.CmbAvance.SelectedItem = Nothing
        Me.CmbAvance.Size = New System.Drawing.Size(125, 21)
        Me.CmbAvance.TabIndex = 3
        Me.CmbAvance.ValueMember = "Value"
        '
        'RdPorNivel
        '
        Me.RdPorNivel.Location = New System.Drawing.Point(252, 18)
        Me.RdPorNivel.Name = "RdPorNivel"
        Me.RdPorNivel.Size = New System.Drawing.Size(76, 23)
        Me.RdPorNivel.TabIndex = 2
        Me.RdPorNivel.Text = "por Nivel"
        '
        'RdPorObra
        '
        Me.RdPorObra.Location = New System.Drawing.Point(139, 18)
        Me.RdPorObra.Name = "RdPorObra"
        Me.RdPorObra.Size = New System.Drawing.Size(98, 23)
        Me.RdPorObra.TabIndex = 1
        Me.RdPorObra.Text = "por Proyecto"
        '
        'TimeExtendedObras
        '
        Me.TimeExtendedObras.AllowEdit = False
        Me.TimeExtendedObras.AllowExpandRowHeader = False
        Me.TimeExtendedObras.AllowItemDrag = CType(((Janus.Windows.TimeLine.AllowItemDrag.Move Or Janus.Windows.TimeLine.AllowItemDrag.Resize) _
                    Or Janus.Windows.TimeLine.AllowItemDrag.EstimatedDurationChange), Janus.Windows.TimeLine.AllowItemDrag)
        TimeExtendedObras_DesignTimeLayout.LayoutString = resources.GetString("TimeExtendedObras_DesignTimeLayout.LayoutString")
        Me.TimeExtendedObras.DesignTimeLayout = TimeExtendedObras_DesignTimeLayout
        Me.TimeExtendedObras.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.TimeExtendedObras.DropDownCalendar.Name = ""
        Me.TimeExtendedObras.FirstDate = New Date(2010, 10, 25, 0, 0, 0, 0)
        Me.TimeExtendedObras.FirstDayOfWeek = Janus.Windows.TimeLine.DayOfWeek.Monday
        Me.TimeExtendedObras.GridLines = Janus.Windows.TimeLine.GridLines.Both
        Me.TimeExtendedObras.ItemsBarFormatStyle.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TimeExtendedObras.ItemsDurationBarHeight = 10
        Me.TimeExtendedObras.ItemsEstimatedBarFormatStyle.BackColor = System.Drawing.Color.ForestGreen
        Me.TimeExtendedObras.ItemsFormatStyle.BackColor = System.Drawing.Color.White
        Me.TimeExtendedObras.ItemSizeMode = Janus.Windows.TimeLine.ItemSizeMode.DurationBased
        Me.TimeExtendedObras.ItemsLineStyle = Janus.Windows.TimeLine.ItemsLineStyle.SmallDots
        Me.TimeExtendedObras.ItemToolTip = Janus.Windows.TimeLine.ItemToolTip.UseToolTipMember
        Me.TimeExtendedObras.Location = New System.Drawing.Point(3, 17)
        Me.TimeExtendedObras.MultiSelect = False
        Me.TimeExtendedObras.Name = "TimeExtendedObras"
        Me.TimeExtendedObras.RowHeight = 40
        Me.TimeExtendedObras.ShowItemsEstimatedDurationBar = True
        Me.TimeExtendedObras.ShowLastGroupAsRowHeader = True
        Me.TimeExtendedObras.ShowWeekNumbers = True
        Me.TimeExtendedObras.Size = New System.Drawing.Size(833, 162)
        Me.TimeExtendedObras.TabIndex = 1
        Me.TimeExtendedObras.Text = "TimeLine1"
        Me.TimeExtendedObras.TimescaleTiers = Janus.Windows.TimeLine.TimescaleTiers.ThreeTiers
        Me.TimeExtendedObras.TooltipFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeExtendedObras.VisualStyle = Janus.Windows.TimeLine.VisualStyle.Office2003
        Me.TimeExtendedObras.WeekText = "Semana"
        Me.TimeExtendedObras.WorkEndTime = System.TimeSpan.Parse("18.00:00:00")
        Me.TimeExtendedObras.WorkingTimeFormatStyle.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TimeExtendedObras.YearText = "Año"
        '
        'SplTimes
        '
        Me.SplTimes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplTimes.Location = New System.Drawing.Point(0, 48)
        Me.SplTimes.Name = "SplTimes"
        Me.SplTimes.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplTimes.Panel1
        '
        Me.SplTimes.Panel1.AccessibleName = "PnlTimeObras"
        Me.SplTimes.Panel1.Controls.Add(Me.FrmTimeObras)
        '
        'SplTimes.Panel2
        '
        Me.SplTimes.Panel2.AccessibleName = "PnlTimeExtendedObras"
        Me.SplTimes.Panel2.Controls.Add(Me.FrmTimeExtendedObras)
        Me.SplTimes.Size = New System.Drawing.Size(839, 352)
        Me.SplTimes.SplitterDistance = 166
        Me.SplTimes.TabIndex = 2
        '
        'FrmTimeObras
        '
        Me.FrmTimeObras.Controls.Add(Me.TimeObras)
        Me.FrmTimeObras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmTimeObras.Location = New System.Drawing.Point(0, 0)
        Me.FrmTimeObras.Name = "FrmTimeObras"
        Me.FrmTimeObras.Size = New System.Drawing.Size(839, 166)
        Me.FrmTimeObras.TabIndex = 1
        Me.FrmTimeObras.TabStop = False
        Me.FrmTimeObras.Text = "Obras"
        '
        'FrmTimeExtendedObras
        '
        Me.FrmTimeExtendedObras.Controls.Add(Me.TimeExtendedObras)
        Me.FrmTimeExtendedObras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmTimeExtendedObras.Location = New System.Drawing.Point(0, 0)
        Me.FrmTimeExtendedObras.Name = "FrmTimeExtendedObras"
        Me.FrmTimeExtendedObras.Size = New System.Drawing.Size(839, 182)
        Me.FrmTimeExtendedObras.TabIndex = 2
        Me.FrmTimeExtendedObras.TabStop = False
        Me.FrmTimeExtendedObras.Text = "Extended Obras"
        '
        'CtrlTimeLineObras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplTimes)
        Me.Controls.Add(Me.FrmOpciones)
        Me.Controls.Add(Me.TopRebar1)
        Me.Name = "CtrlTimeLineObras"
        Me.Size = New System.Drawing.Size(839, 400)
        CType(Me.TimeObras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UICmdTimeLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UICTxtOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrmOpciones.ResumeLayout(False)
        Me.FrmOpciones.PerformLayout()
        CType(Me.CmbAvance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeExtendedObras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplTimes.Panel1.ResumeLayout(False)
        Me.SplTimes.Panel2.ResumeLayout(False)
        Me.SplTimes.ResumeLayout(False)
        Me.FrmTimeObras.ResumeLayout(False)
        Me.FrmTimeExtendedObras.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UICmdTimeLine As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents UICTxtOptions As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents ImgList As System.Windows.Forms.ImageList
    Friend WithEvents CmdNew As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents CmdNew1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents CmdView As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents CmdPorObra As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents CmdPorNivel As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents CmdPorObra1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents CmdPorNivel1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents CmdView1 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents TimeObras As Janus.Windows.TimeLine.TimeLine
    Public WithEvents FrmOpciones As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents RdPorNivel As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents RdPorObra As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents LblTipoAvance As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblNivel As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents CmbAvance As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents CmdTipoAvance As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents CmdAvanceEstimado As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents CmdAvanceEstimado1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents CmdAvanceCalculado1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents CmdAvanceCalculado As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents CmdTipoAvance1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents SplTimes As System.Windows.Forms.SplitContainer
    Public WithEvents TimeExtendedObras As Janus.Windows.TimeLine.TimeLine
    Friend WithEvents FrmTimeObras As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FrmTimeExtendedObras As Solmicro.Expertis.Engine.UI.Frame

End Class
