<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIEntidadFoto
    Inherits Solmicro.Expertis.Engine.UI.CIMntoBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIEntidadFoto))
        Dim GrdEntidadFoto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbEntidad_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.SplitImages = New System.Windows.Forms.SplitContainer
        Me.GrdEntidadFoto = New Solmicro.Expertis.Engine.UI.Grid
        Me.FlowImages = New System.Windows.Forms.FlowLayoutPanel
        Me.FrmFilter = New Solmicro.Expertis.Engine.UI.Frame
        Me.AdvClave = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblClave = New Solmicro.Expertis.Engine.UI.Label
        Me.CmbEntidad = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.LbLEntidad = New Solmicro.Expertis.Engine.UI.Label
        Me.UICmdEntidadFoto = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar2 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.Add2 = New Janus.Windows.UI.CommandBars.UICommand("Add")
        Me.Delete = New Janus.Windows.UI.CommandBars.UICommand("Delete")
        Me.Predeterminado = New Janus.Windows.UI.CommandBars.UICommand("Predeterminado")
        Me.UICtxtOptions = New Janus.Windows.UI.CommandBars.UIContextMenu
        Me.Add1 = New Janus.Windows.UI.CommandBars.UICommand("Add")
        Me.Delete1 = New Janus.Windows.UI.CommandBars.UICommand("Delete")
        Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.Predeterminado1 = New Janus.Windows.UI.CommandBars.UICommand("Predeterminado")
        Me.UICtxtGeneral = New Janus.Windows.UI.CommandBars.UIContextMenu
        Me.Add3 = New Janus.Windows.UI.CommandBars.UICommand("Add")
        Me.LeftRebar2 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.RightRebar2 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.TopRebar2 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.OpenImage = New System.Windows.Forms.OpenFileDialog
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.SplitImages.Panel1.SuspendLayout()
        Me.SplitImages.Panel2.SuspendLayout()
        Me.SplitImages.SuspendLayout()
        CType(Me.GrdEntidadFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrmFilter.SuspendLayout()
        CType(Me.CmbEntidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UICmdEntidadFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UICtxtOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UICtxtGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckAll
        '
        Me.CheckAll.Icon = CType(resources.GetObject("CheckAll.Icon"), System.Drawing.Icon)
        Me.CheckAll.Text = ""
        '
        'UncheckAll
        '
        Me.UncheckAll.Icon = CType(resources.GetObject("UncheckAll.Icon"), System.Drawing.Icon)
        Me.UncheckAll.Text = ""
        '
        'ExecuteQuery
        '
        Me.ExecuteQuery.Icon = CType(resources.GetObject("ExecuteQuery.Icon"), System.Drawing.Icon)
        Me.ExecuteQuery.Text = ""
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Icon = CType(resources.GetObject("ShowAllCheckedItems.Icon"), System.Drawing.Icon)
        Me.ShowAllCheckedItems.Text = ""
        '
        'ClearFilter
        '
        Me.ClearFilter.Icon = CType(resources.GetObject("ClearFilter.Icon"), System.Drawing.Icon)
        Me.ClearFilter.Text = ""
        '
        'Export
        '
        Me.Export.Icon = CType(resources.GetObject("Export.Icon"), System.Drawing.Icon)
        Me.Export.Text = ""
        '
        'Toolbar
        '
        Me.Toolbar.Location = New System.Drawing.Point(52, 0)
        Me.Toolbar.Size = New System.Drawing.Size(180, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        Me.Menubar.Visible = False
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.SplitImages)
        Me.MainPanel.Controls.Add(Me.FrmFilter)
        Me.MainPanel.Size = New System.Drawing.Size(822, 452)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Icon = CType(resources.GetObject("ExecuteActions.Icon"), System.Drawing.Icon)
        Me.ExecuteActions.Text = ""
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(822, 452)
        '
        'SplitImages
        '
        Me.SplitImages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitImages.Location = New System.Drawing.Point(0, 0)
        Me.SplitImages.Name = "SplitImages"
        '
        'SplitImages.Panel1
        '
        Me.SplitImages.Panel1.Controls.Add(Me.GrdEntidadFoto)
        '
        'SplitImages.Panel2
        '
        Me.SplitImages.Panel2.Controls.Add(Me.FlowImages)
        Me.SplitImages.Size = New System.Drawing.Size(822, 397)
        Me.SplitImages.SplitterDistance = 436
        Me.SplitImages.TabIndex = 0
        '
        'GrdEntidadFoto
        '
        Me.GrdEntidadFoto.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GrdEntidadFoto.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GrdEntidadFoto.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GrdEntidadFoto_DesignTimeLayout.LayoutString = resources.GetString("GrdEntidadFoto_DesignTimeLayout.LayoutString")
        Me.GrdEntidadFoto.DesignTimeLayout = GrdEntidadFoto_DesignTimeLayout
        Me.GrdEntidadFoto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdEntidadFoto.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdEntidadFoto.EntityName = Nothing
        Me.GrdEntidadFoto.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrdEntidadFoto.Location = New System.Drawing.Point(0, 0)
        Me.GrdEntidadFoto.Name = "GrdEntidadFoto"
        Me.GrdEntidadFoto.PrimaryDataFields = Nothing
        Me.GrdEntidadFoto.SecondaryDataFields = Nothing
        Me.GrdEntidadFoto.Size = New System.Drawing.Size(436, 397)
        Me.GrdEntidadFoto.TabIndex = 2
        Me.GrdEntidadFoto.ViewName = Nothing
        '
        'FlowImages
        '
        Me.FlowImages.AutoScroll = True
        Me.FlowImages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowImages.Location = New System.Drawing.Point(0, 0)
        Me.FlowImages.Name = "FlowImages"
        Me.FlowImages.Size = New System.Drawing.Size(382, 397)
        Me.FlowImages.TabIndex = 0
        '
        'FrmFilter
        '
        Me.FrmFilter.Controls.Add(Me.AdvClave)
        Me.FrmFilter.Controls.Add(Me.LblClave)
        Me.FrmFilter.Controls.Add(Me.CmbEntidad)
        Me.FrmFilter.Controls.Add(Me.LbLEntidad)
        Me.FrmFilter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FrmFilter.Location = New System.Drawing.Point(0, 397)
        Me.FrmFilter.Name = "FrmFilter"
        Me.FrmFilter.Size = New System.Drawing.Size(822, 55)
        Me.FrmFilter.TabIndex = 0
        Me.FrmFilter.TabStop = False
        Me.FrmFilter.Text = "Filtros"
        '
        'AdvClave
        '
        Me.AdvClave.DisabledBackColor = System.Drawing.Color.White
        Me.AdvClave.Location = New System.Drawing.Point(329, 18)
        Me.AdvClave.Name = "AdvClave"
        Me.AdvClave.Size = New System.Drawing.Size(160, 23)
        Me.AdvClave.TabIndex = 0
        '
        'LblClave
        '
        Me.LblClave.Location = New System.Drawing.Point(283, 23)
        Me.LblClave.Name = "LblClave"
        Me.LblClave.Size = New System.Drawing.Size(40, 13)
        Me.LblClave.TabIndex = 2
        Me.LblClave.Text = "Clave"
        '
        'CmbEntidad
        '
        CmbEntidad_DesignTimeLayout.LayoutString = resources.GetString("CmbEntidad_DesignTimeLayout.LayoutString")
        Me.CmbEntidad.DesignTimeLayout = CmbEntidad_DesignTimeLayout
        Me.CmbEntidad.DisabledBackColor = System.Drawing.Color.White
        Me.CmbEntidad.DisplayMember = "Entidad"
        Me.CmbEntidad.Location = New System.Drawing.Point(79, 20)
        Me.CmbEntidad.Name = "CmbEntidad"
        Me.CmbEntidad.SelectedIndex = -1
        Me.CmbEntidad.SelectedItem = Nothing
        Me.CmbEntidad.Size = New System.Drawing.Size(179, 21)
        Me.CmbEntidad.TabIndex = 1
        Me.CmbEntidad.ValueMember = "Tabla"
        '
        'LbLEntidad
        '
        Me.LbLEntidad.Location = New System.Drawing.Point(8, 24)
        Me.LbLEntidad.Name = "LbLEntidad"
        Me.LbLEntidad.Size = New System.Drawing.Size(49, 13)
        Me.LbLEntidad.TabIndex = 0
        Me.LbLEntidad.Text = "Entidad"
        '
        'UICmdEntidadFoto
        '
        Me.UICmdEntidadFoto.BottomRebar = Me.BottomRebar2
        Me.UICmdEntidadFoto.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Add2, Me.Delete, Me.Predeterminado})
        Me.UICmdEntidadFoto.ContainerControl = Me
        Me.UICmdEntidadFoto.ContextMenus.AddRange(New Janus.Windows.UI.CommandBars.UIContextMenu() {Me.UICtxtOptions, Me.UICtxtGeneral})
        Me.UICmdEntidadFoto.Id = New System.Guid("33c98f42-78f8-4b70-81c7-357a0b45c963")
        Me.UICmdEntidadFoto.LeftRebar = Me.LeftRebar2
        Me.UICmdEntidadFoto.RightRebar = Me.RightRebar2
        Me.UICmdEntidadFoto.TopRebar = Me.TopRebar2
        '
        'BottomRebar2
        '
        Me.BottomRebar2.CommandManager = Me.UICmdEntidadFoto
        Me.BottomRebar2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomRebar2.Location = New System.Drawing.Point(0, 540)
        Me.BottomRebar2.Name = "BottomRebar2"
        Me.BottomRebar2.Size = New System.Drawing.Size(830, 0)
        '
        'Add2
        '
        Me.Add2.Icon = CType(resources.GetObject("Add2.Icon"), System.Drawing.Icon)
        Me.Add2.Key = "Add"
        Me.Add2.Name = "Add2"
        Me.Add2.Text = "Añadir Nueva Imagen"
        '
        'Delete
        '
        Me.Delete.Icon = CType(resources.GetObject("Delete.Icon"), System.Drawing.Icon)
        Me.Delete.Key = "Delete"
        Me.Delete.Name = "Delete"
        Me.Delete.Text = "Borrar Imagen"
        '
        'Predeterminado
        '
        Me.Predeterminado.Icon = CType(resources.GetObject("Predeterminado.Icon"), System.Drawing.Icon)
        Me.Predeterminado.Key = "Predeterminado"
        Me.Predeterminado.Name = "Predeterminado"
        Me.Predeterminado.Text = "Predeterminado"
        '
        'UICtxtOptions
        '
        Me.UICtxtOptions.CommandManager = Me.UICmdEntidadFoto
        Me.UICtxtOptions.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Add1, Me.Delete1, Me.Separator1, Me.Predeterminado1})
        Me.UICtxtOptions.Key = "CTxtOptions"
        '
        'Add1
        '
        Me.Add1.Key = "Add"
        Me.Add1.Name = "Add1"
        '
        'Delete1
        '
        Me.Delete1.Key = "Delete"
        Me.Delete1.Name = "Delete1"
        '
        'Separator1
        '
        Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator1.Key = "Separator"
        Me.Separator1.Name = "Separator1"
        '
        'Predeterminado1
        '
        Me.Predeterminado1.Key = "Predeterminado"
        Me.Predeterminado1.Name = "Predeterminado1"
        '
        'UICtxtGeneral
        '
        Me.UICtxtGeneral.CommandManager = Me.UICmdEntidadFoto
        Me.UICtxtGeneral.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Add3})
        Me.UICtxtGeneral.Key = "CTxtGeneral"
        '
        'Add3
        '
        Me.Add3.Key = "Add"
        Me.Add3.Name = "Add3"
        '
        'LeftRebar2
        '
        Me.LeftRebar2.CommandManager = Me.UICmdEntidadFoto
        Me.LeftRebar2.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftRebar2.Location = New System.Drawing.Point(0, 54)
        Me.LeftRebar2.Name = "LeftRebar2"
        Me.LeftRebar2.Size = New System.Drawing.Size(0, 486)
        '
        'RightRebar2
        '
        Me.RightRebar2.CommandManager = Me.UICmdEntidadFoto
        Me.RightRebar2.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightRebar2.Location = New System.Drawing.Point(830, 54)
        Me.RightRebar2.Name = "RightRebar2"
        Me.RightRebar2.Size = New System.Drawing.Size(0, 486)
        '
        'TopRebar2
        '
        Me.TopRebar2.CommandManager = Me.UICmdEntidadFoto
        Me.TopRebar2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopRebar2.Location = New System.Drawing.Point(0, 54)
        Me.TopRebar2.Name = "TopRebar2"
        Me.TopRebar2.Size = New System.Drawing.Size(830, 0)
        '
        'CIEntidadFoto
        '
        Me.AllowDynamicFilter = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 540)
        Me.Controls.Add(Me.TopRebar2)
        Me.EntityName = "EntidadFoto"
        Me.Name = "CIEntidadFoto"
        Me.Text = "CIEntidadFoto"
        Me.Controls.SetChildIndex(Me.TopRebar2, 0)
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.SplitImages.Panel1.ResumeLayout(False)
        Me.SplitImages.Panel2.ResumeLayout(False)
        Me.SplitImages.ResumeLayout(False)
        CType(Me.GrdEntidadFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrmFilter.ResumeLayout(False)
        Me.FrmFilter.PerformLayout()
        CType(Me.CmbEntidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UICmdEntidadFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UICtxtOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UICtxtGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitImages As System.Windows.Forms.SplitContainer
    Friend WithEvents FrmFilter As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents GrdEntidadFoto As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents FlowImages As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents CmbEntidad As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents LbLEntidad As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblClave As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvClave As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents UICmdEntidadFoto As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents BottomRebar2 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LeftRebar2 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar2 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents TopRebar2 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents UICtxtOptions As Janus.Windows.UI.CommandBars.UIContextMenu
    Public WithEvents OpenImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Add2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Delete As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Predeterminado As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Add1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Delete1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Predeterminado1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents UICtxtGeneral As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents Add3 As Janus.Windows.UI.CommandBars.UICommand
End Class
