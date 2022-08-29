<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrlImage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtrlImage))
        Me.FrmImage = New Solmicro.Expertis.Engine.UI.Frame
        Me.pbxFoto = New System.Windows.Forms.PictureBox
        Me.PnlButtons = New System.Windows.Forms.Panel
        Me.SplitButtons = New System.Windows.Forms.SplitContainer
        Me.BtnBack = New Solmicro.Expertis.Engine.UI.Button
        Me.ImgList = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnForward = New Solmicro.Expertis.Engine.UI.Button
        Me.LblNumberImage = New Solmicro.Expertis.Engine.UI.Label
        Me.UICtrlPicMenu = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.Add2 = New Janus.Windows.UI.CommandBars.UICommand("Add")
        Me.Delete = New Janus.Windows.UI.CommandBars.UICommand("Delete")
        Me.List = New Janus.Windows.UI.CommandBars.UICommand("List")
        Me.Modify = New Janus.Windows.UI.CommandBars.UICommand("Modify")
        Me.Predeterminado = New Janus.Windows.UI.CommandBars.UICommand("Predeterminado")
        Me.UiCtrlPicContextMenu = New Janus.Windows.UI.CommandBars.UIContextMenu
        Me.Add1 = New Janus.Windows.UI.CommandBars.UICommand("Add")
        Me.Modify1 = New Janus.Windows.UI.CommandBars.UICommand("Modify")
        Me.Delete1 = New Janus.Windows.UI.CommandBars.UICommand("Delete")
        Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.Predeterminado1 = New Janus.Windows.UI.CommandBars.UICommand("Predeterminado")
        Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.List1 = New Janus.Windows.UI.CommandBars.UICommand("List")
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.OpenImage = New System.Windows.Forms.OpenFileDialog
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FrmImage.SuspendLayout()
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlButtons.SuspendLayout()
        Me.SplitButtons.Panel1.SuspendLayout()
        Me.SplitButtons.Panel2.SuspendLayout()
        Me.SplitButtons.SuspendLayout()
        CType(Me.UICtrlPicMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCtrlPicContextMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FrmImage
        '
        Me.FrmImage.Controls.Add(Me.pbxFoto)
        Me.FrmImage.Controls.Add(Me.PnlButtons)
        Me.FrmImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmImage.Location = New System.Drawing.Point(0, 0)
        Me.FrmImage.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.FrmImage.Name = "FrmImage"
        Me.FrmImage.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.FrmImage.Size = New System.Drawing.Size(230, 180)
        Me.FrmImage.TabIndex = 178
        Me.FrmImage.TabStop = False
        '
        'pbxFoto
        '
        Me.pbxFoto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxFoto.Location = New System.Drawing.Point(3, 14)
        Me.pbxFoto.Name = "pbxFoto"
        Me.pbxFoto.Size = New System.Drawing.Size(224, 123)
        Me.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxFoto.TabIndex = 179
        Me.pbxFoto.TabStop = False
        '
        'PnlButtons
        '
        Me.PnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlButtons.Controls.Add(Me.SplitButtons)
        Me.PnlButtons.Controls.Add(Me.LblNumberImage)
        Me.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlButtons.Location = New System.Drawing.Point(3, 137)
        Me.PnlButtons.Name = "PnlButtons"
        Me.PnlButtons.Size = New System.Drawing.Size(224, 40)
        Me.PnlButtons.TabIndex = 180
        Me.PnlButtons.Visible = False
        '
        'SplitButtons
        '
        Me.SplitButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitButtons.IsSplitterFixed = True
        Me.SplitButtons.Location = New System.Drawing.Point(0, 15)
        Me.SplitButtons.Name = "SplitButtons"
        '
        'SplitButtons.Panel1
        '
        Me.SplitButtons.Panel1.Controls.Add(Me.BtnBack)
        '
        'SplitButtons.Panel2
        '
        Me.SplitButtons.Panel2.Controls.Add(Me.BtnForward)
        Me.SplitButtons.Size = New System.Drawing.Size(222, 23)
        Me.SplitButtons.SplitterDistance = 103
        Me.SplitButtons.SplitterWidth = 1
        Me.SplitButtons.TabIndex = 2
        '
        'BtnBack
        '
        Me.BtnBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnBack.ImageIndex = 0
        Me.BtnBack.ImageList = Me.ImgList
        Me.BtnBack.Location = New System.Drawing.Point(0, 0)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(103, 23)
        Me.BtnBack.TabIndex = 0
        '
        'ImgList
        '
        Me.ImgList.ImageStream = CType(resources.GetObject("ImgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgList.Images.SetKeyName(0, "media_step_back.ico")
        Me.ImgList.Images.SetKeyName(1, "media_step_forward.ico")
        '
        'BtnForward
        '
        Me.BtnForward.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnForward.ImageIndex = 1
        Me.BtnForward.ImageList = Me.ImgList
        Me.BtnForward.Location = New System.Drawing.Point(0, 0)
        Me.BtnForward.Name = "BtnForward"
        Me.BtnForward.Size = New System.Drawing.Size(118, 23)
        Me.BtnForward.TabIndex = 1
        '
        'LblNumberImage
        '
        Me.LblNumberImage.AutoSize = False
        Me.LblNumberImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNumberImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblNumberImage.Location = New System.Drawing.Point(0, 0)
        Me.LblNumberImage.Name = "LblNumberImage"
        Me.LblNumberImage.Size = New System.Drawing.Size(222, 15)
        Me.LblNumberImage.TabIndex = 3
        Me.LblNumberImage.Text = "0 de 0"
        Me.LblNumberImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UICtrlPicMenu
        '
        Me.UICtrlPicMenu.BottomRebar = Me.BottomRebar1
        Me.UICtrlPicMenu.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Add2, Me.Delete, Me.List, Me.Modify, Me.Predeterminado})
        Me.UICtrlPicMenu.ContainerControl = Me
        Me.UICtrlPicMenu.ContextMenus.AddRange(New Janus.Windows.UI.CommandBars.UIContextMenu() {Me.UiCtrlPicContextMenu})
        Me.UICtrlPicMenu.Id = New System.Guid("306f1062-3aaa-4e64-8545-4975a06f0ba6")
        Me.UICtrlPicMenu.LeftRebar = Me.LeftRebar1
        Me.UICtrlPicMenu.RightRebar = Me.RightRebar1
        Me.UICtrlPicMenu.TopRebar = Me.TopRebar1
        '
        'BottomRebar1
        '
        Me.BottomRebar1.CommandManager = Me.UICtrlPicMenu
        Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomRebar1.Location = New System.Drawing.Point(0, 180)
        Me.BottomRebar1.Name = "BottomRebar1"
        Me.BottomRebar1.Size = New System.Drawing.Size(230, 0)
        '
        'Add2
        '
        Me.Add2.Image = CType(resources.GetObject("Add2.Image"), System.Drawing.Image)
        Me.Add2.Key = "Add"
        Me.Add2.Name = "Add2"
        Me.Add2.Text = "Agregar Imagen Nueva"
        '
        'Delete
        '
        Me.Delete.Image = CType(resources.GetObject("Delete.Image"), System.Drawing.Image)
        Me.Delete.Key = "Delete"
        Me.Delete.Name = "Delete"
        Me.Delete.Text = "Eliminar Imagen"
        '
        'List
        '
        Me.List.Image = CType(resources.GetObject("List.Image"), System.Drawing.Image)
        Me.List.Key = "List"
        Me.List.Name = "List"
        Me.List.Text = "Lista Imágenes"
        '
        'Modify
        '
        Me.Modify.Image = CType(resources.GetObject("Modify.Image"), System.Drawing.Image)
        Me.Modify.Key = "Modify"
        Me.Modify.Name = "Modify"
        Me.Modify.Text = "Modificar Imagen Actual"
        '
        'Predeterminado
        '
        Me.Predeterminado.Key = "Predeterminado"
        Me.Predeterminado.Name = "Predeterminado"
        Me.Predeterminado.Text = "Predeterminado"
        '
        'UiCtrlPicContextMenu
        '
        Me.UiCtrlPicContextMenu.CommandManager = Me.UICtrlPicMenu
        Me.UiCtrlPicContextMenu.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Add1, Me.Modify1, Me.Delete1, Me.Separator1, Me.Predeterminado1, Me.Separator2, Me.List1})
        Me.UiCtrlPicContextMenu.Key = "UiCtrlPicContextMenu"
        '
        'Add1
        '
        Me.Add1.Key = "Add"
        Me.Add1.Name = "Add1"
        '
        'Modify1
        '
        Me.Modify1.Key = "Modify"
        Me.Modify1.Name = "Modify1"
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
        'Separator2
        '
        Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator2.Key = "Separator"
        Me.Separator2.Name = "Separator2"
        '
        'List1
        '
        Me.List1.Key = "List"
        Me.List1.Name = "List1"
        '
        'LeftRebar1
        '
        Me.LeftRebar1.CommandManager = Me.UICtrlPicMenu
        Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftRebar1.Location = New System.Drawing.Point(0, 0)
        Me.LeftRebar1.Name = "LeftRebar1"
        Me.LeftRebar1.Size = New System.Drawing.Size(0, 180)
        '
        'RightRebar1
        '
        Me.RightRebar1.CommandManager = Me.UICtrlPicMenu
        Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightRebar1.Location = New System.Drawing.Point(230, 0)
        Me.RightRebar1.Name = "RightRebar1"
        Me.RightRebar1.Size = New System.Drawing.Size(0, 180)
        '
        'TopRebar1
        '
        Me.TopRebar1.CommandManager = Me.UICtrlPicMenu
        Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
        Me.TopRebar1.Name = "TopRebar1"
        Me.TopRebar1.Size = New System.Drawing.Size(230, 0)
        '
        'Timer1
        '
        '
        'CtrlImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TopRebar1)
        Me.Controls.Add(Me.FrmImage)
        Me.Controls.Add(Me.LeftRebar1)
        Me.Controls.Add(Me.RightRebar1)
        Me.Controls.Add(Me.BottomRebar1)
        Me.Name = "CtrlImage"
        Me.Size = New System.Drawing.Size(230, 180)
        Me.FrmImage.ResumeLayout(False)
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlButtons.ResumeLayout(False)
        Me.SplitButtons.Panel1.ResumeLayout(False)
        Me.SplitButtons.Panel2.ResumeLayout(False)
        Me.SplitButtons.ResumeLayout(False)
        CType(Me.UICtrlPicMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCtrlPicContextMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents Add2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Delete As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents List As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Modify As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Add1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Modify1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Delete1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents List1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Predeterminado As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Predeterminado1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents SplitButtons As System.Windows.Forms.SplitContainer
    Public WithEvents UICtrlPicMenu As Janus.Windows.UI.CommandBars.UICommandManager
    Public WithEvents UiCtrlPicContextMenu As Janus.Windows.UI.CommandBars.UIContextMenu
    Public WithEvents OpenImage As System.Windows.Forms.OpenFileDialog
    Public WithEvents FrmImage As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents pbxFoto As System.Windows.Forms.PictureBox
    Public WithEvents PnlButtons As System.Windows.Forms.Panel
    Public WithEvents BtnForward As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents BtnBack As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents ImgList As System.Windows.Forms.ImageList
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents LblNumberImage As Solmicro.Expertis.Engine.UI.Label

End Class
