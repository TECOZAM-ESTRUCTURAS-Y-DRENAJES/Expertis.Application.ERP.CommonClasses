<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArtCodifComp
    Inherits Solmicro.Expertis.Engine.UI.FormBase

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
        Dim GrdArtPrincipal_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArtCodifComp))
        Dim GrdArtSecundario_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.PnlButtons = New Solmicro.Expertis.Engine.UI.Panel
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.FrmCantidades = New Solmicro.Expertis.Engine.UI.Frame
        Me.AdvDeposito = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblDeposito = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvTipoOperacion = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblTipoOperacion = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbDiferencia = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblDiferencia = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbCantidadAsignada = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblCantidadAsignada = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbCantidadAAsignar = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblCantidadAAsignar = New Solmicro.Expertis.Engine.UI.Label
        Me.SplMain = New System.Windows.Forms.SplitContainer
        Me.FrmPrincipal = New Solmicro.Expertis.Engine.UI.Frame
        Me.GrdArtPrincipal = New Solmicro.Expertis.Engine.UI.Grid
        Me.FrmSecundario = New Solmicro.Expertis.Engine.UI.Frame
        Me.GrdArtSecundario = New Solmicro.Expertis.Engine.UI.Grid
        Me.LblArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.FrmArticulo = New Solmicro.Expertis.Engine.UI.Frame
        Me.ULblUDExpedicion = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.LblUDExpedicion = New Solmicro.Expertis.Engine.UI.Label
        Me.ULblArticulo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ULblDescArticulo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulblUDMedidaArticulo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.PnlButtons.suspendlayout()
        Me.FrmCantidades.SuspendLayout()
        Me.SplMain.Panel1.SuspendLayout()
        Me.SplMain.Panel2.SuspendLayout()
        Me.SplMain.SuspendLayout()
        Me.FrmPrincipal.SuspendLayout()
        CType(Me.GrdArtPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrmSecundario.SuspendLayout()
        CType(Me.GrdArtSecundario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrmArticulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlButtons
        '
        Me.PnlButtons.Controls.Add(Me.BtnCancelar)
        Me.PnlButtons.Controls.Add(Me.BtnAceptar)
        Me.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlButtons.Location = New System.Drawing.Point(0, 438)
        Me.PnlButtons.Name = "PnlButtons"
        Me.PnlButtons.Size = New System.Drawing.Size(890, 57)
        Me.PnlButtons.TabIndex = 0
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(465, 12)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(86, 33)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(360, 12)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(86, 33)
        Me.BtnAceptar.TabIndex = 0
        Me.BtnAceptar.Text = "Aceptar"
        '
        'FrmCantidades
        '
        Me.FrmCantidades.Controls.Add(Me.ulblUDMedidaArticulo)
        Me.FrmCantidades.Controls.Add(Me.AdvDeposito)
        Me.FrmCantidades.Controls.Add(Me.LblDeposito)
        Me.FrmCantidades.Controls.Add(Me.AdvTipoOperacion)
        Me.FrmCantidades.Controls.Add(Me.LblTipoOperacion)
        Me.FrmCantidades.Controls.Add(Me.NtbDiferencia)
        Me.FrmCantidades.Controls.Add(Me.LblDiferencia)
        Me.FrmCantidades.Controls.Add(Me.NtbCantidadAsignada)
        Me.FrmCantidades.Controls.Add(Me.LblCantidadAsignada)
        Me.FrmCantidades.Controls.Add(Me.NtbCantidadAAsignar)
        Me.FrmCantidades.Controls.Add(Me.LblCantidadAAsignar)
        Me.FrmCantidades.Dock = System.Windows.Forms.DockStyle.Top
        Me.FrmCantidades.Location = New System.Drawing.Point(0, 61)
        Me.FrmCantidades.Name = "FrmCantidades"
        Me.FrmCantidades.Size = New System.Drawing.Size(890, 71)
        Me.FrmCantidades.TabIndex = 1
        Me.FrmCantidades.TabStop = False
        Me.FrmCantidades.Text = "Cantidades"
        '
        'AdvDeposito
        '
        Me.AdvDeposito.DisabledBackColor = System.Drawing.Color.White
        Me.AdvDeposito.EntityName = "BdgDeposito"
        Me.AdvDeposito.Location = New System.Drawing.Point(799, 39)
        Me.AdvDeposito.Name = "AdvDeposito"
        Me.AdvDeposito.SecondaryDataFields = "IDDeposito"
        Me.AdvDeposito.Size = New System.Drawing.Size(85, 23)
        Me.AdvDeposito.TabIndex = 9
        '
        'LblDeposito
        '
        Me.LblDeposito.Location = New System.Drawing.Point(700, 44)
        Me.LblDeposito.Name = "LblDeposito"
        Me.LblDeposito.Size = New System.Drawing.Size(57, 13)
        Me.LblDeposito.TabIndex = 8
        Me.LblDeposito.Text = "Depósito"
        '
        'AdvTipoOperacion
        '
        Me.AdvTipoOperacion.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTipoOperacion.EntityName = "BdgTipoOperacion"
        Me.AdvTipoOperacion.Location = New System.Drawing.Point(799, 13)
        Me.AdvTipoOperacion.Name = "AdvTipoOperacion"
        Me.AdvTipoOperacion.SecondaryDataFields = "IDTipoOperacion"
        Me.AdvTipoOperacion.Size = New System.Drawing.Size(85, 23)
        Me.AdvTipoOperacion.TabIndex = 7
        '
        'LblTipoOperacion
        '
        Me.LblTipoOperacion.Location = New System.Drawing.Point(700, 18)
        Me.LblTipoOperacion.Name = "LblTipoOperacion"
        Me.LblTipoOperacion.Size = New System.Drawing.Size(93, 13)
        Me.LblTipoOperacion.TabIndex = 6
        Me.LblTipoOperacion.Text = "Tipo Operación"
        '
        'NtbDiferencia
        '
        Me.NtbDiferencia.DisabledBackColor = System.Drawing.Color.White
        Me.NtbDiferencia.Location = New System.Drawing.Point(546, 36)
        Me.NtbDiferencia.Name = "NtbDiferencia"
        Me.NtbDiferencia.ReadOnly = True
        Me.NtbDiferencia.Size = New System.Drawing.Size(127, 21)
        Me.NtbDiferencia.TabIndex = 5
        '
        'LblDiferencia
        '
        Me.LblDiferencia.AutoSize = False
        Me.LblDiferencia.Location = New System.Drawing.Point(546, 13)
        Me.LblDiferencia.Name = "LblDiferencia"
        Me.LblDiferencia.Size = New System.Drawing.Size(127, 23)
        Me.LblDiferencia.TabIndex = 4
        Me.LblDiferencia.Text = "Diferencia"
        Me.LblDiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NtbCantidadAsignada
        '
        Me.NtbCantidadAsignada.DisabledBackColor = System.Drawing.Color.White
        Me.NtbCantidadAsignada.Location = New System.Drawing.Point(362, 36)
        Me.NtbCantidadAsignada.Name = "NtbCantidadAsignada"
        Me.NtbCantidadAsignada.ReadOnly = True
        Me.NtbCantidadAsignada.Size = New System.Drawing.Size(127, 21)
        Me.NtbCantidadAsignada.TabIndex = 3
        '
        'LblCantidadAsignada
        '
        Me.LblCantidadAsignada.AutoSize = False
        Me.LblCantidadAsignada.Location = New System.Drawing.Point(362, 13)
        Me.LblCantidadAsignada.Name = "LblCantidadAsignada"
        Me.LblCantidadAsignada.Size = New System.Drawing.Size(127, 23)
        Me.LblCantidadAsignada.TabIndex = 2
        Me.LblCantidadAsignada.Text = "Cantidad Asignada"
        Me.LblCantidadAsignada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NtbCantidadAAsignar
        '
        Me.NtbCantidadAAsignar.DisabledBackColor = System.Drawing.Color.White
        Me.NtbCantidadAAsignar.Location = New System.Drawing.Point(171, 36)
        Me.NtbCantidadAAsignar.Name = "NtbCantidadAAsignar"
        Me.NtbCantidadAAsignar.ReadOnly = True
        Me.NtbCantidadAAsignar.Size = New System.Drawing.Size(127, 21)
        Me.NtbCantidadAAsignar.TabIndex = 1
        '
        'LblCantidadAAsignar
        '
        Me.LblCantidadAAsignar.AutoSize = False
        Me.LblCantidadAAsignar.Location = New System.Drawing.Point(168, 13)
        Me.LblCantidadAAsignar.Name = "LblCantidadAAsignar"
        Me.LblCantidadAAsignar.Size = New System.Drawing.Size(130, 23)
        Me.LblCantidadAAsignar.TabIndex = 0
        Me.LblCantidadAAsignar.Text = "Cantidad A Asignar"
        Me.LblCantidadAAsignar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplMain
        '
        Me.SplMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplMain.Location = New System.Drawing.Point(0, 132)
        Me.SplMain.Name = "SplMain"
        Me.SplMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplMain.Panel1
        '
        Me.SplMain.Panel1.Controls.Add(Me.FrmPrincipal)
        '
        'SplMain.Panel2
        '
        Me.SplMain.Panel2.Controls.Add(Me.FrmSecundario)
        Me.SplMain.Size = New System.Drawing.Size(890, 306)
        Me.SplMain.SplitterDistance = 147
        Me.SplMain.TabIndex = 2
        '
        'FrmPrincipal
        '
        Me.FrmPrincipal.Controls.Add(Me.GrdArtPrincipal)
        Me.FrmPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.FrmPrincipal.Name = "FrmPrincipal"
        Me.FrmPrincipal.Size = New System.Drawing.Size(890, 147)
        Me.FrmPrincipal.TabIndex = 0
        Me.FrmPrincipal.TabStop = False
        Me.FrmPrincipal.Text = "Artículos compatibles Principales"
        '
        'GrdArtPrincipal
        '
        Me.GrdArtPrincipal.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GrdArtPrincipal.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        GrdArtPrincipal_DesignTimeLayout.LayoutString = resources.GetString("GrdArtPrincipal_DesignTimeLayout.LayoutString")
        Me.GrdArtPrincipal.DesignTimeLayout = GrdArtPrincipal_DesignTimeLayout
        Me.GrdArtPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdArtPrincipal.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdArtPrincipal.EntityName = Nothing
        Me.GrdArtPrincipal.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrdArtPrincipal.Location = New System.Drawing.Point(3, 17)
        Me.GrdArtPrincipal.Name = "GrdArtPrincipal"
        Me.GrdArtPrincipal.PrimaryDataFields = Nothing
        Me.GrdArtPrincipal.SecondaryDataFields = Nothing
        Me.GrdArtPrincipal.Size = New System.Drawing.Size(884, 127)
        Me.GrdArtPrincipal.TabIndex = 0
        Me.GrdArtPrincipal.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GrdArtPrincipal.UpdateOnLeave = False
        Me.GrdArtPrincipal.UseCheck = True
        Me.GrdArtPrincipal.ViewName = Nothing
        '
        'FrmSecundario
        '
        Me.FrmSecundario.Controls.Add(Me.GrdArtSecundario)
        Me.FrmSecundario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmSecundario.Location = New System.Drawing.Point(0, 0)
        Me.FrmSecundario.Name = "FrmSecundario"
        Me.FrmSecundario.Size = New System.Drawing.Size(890, 155)
        Me.FrmSecundario.TabIndex = 0
        Me.FrmSecundario.TabStop = False
        Me.FrmSecundario.Text = "Artículos compatibles Secundarios"
        '
        'GrdArtSecundario
        '
        Me.GrdArtSecundario.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GrdArtSecundario.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        GrdArtSecundario_DesignTimeLayout.LayoutString = resources.GetString("GrdArtSecundario_DesignTimeLayout.LayoutString")
        Me.GrdArtSecundario.DesignTimeLayout = GrdArtSecundario_DesignTimeLayout
        Me.GrdArtSecundario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdArtSecundario.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdArtSecundario.EntityName = Nothing
        Me.GrdArtSecundario.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrdArtSecundario.Location = New System.Drawing.Point(3, 17)
        Me.GrdArtSecundario.Name = "GrdArtSecundario"
        Me.GrdArtSecundario.PrimaryDataFields = Nothing
        Me.GrdArtSecundario.SecondaryDataFields = Nothing
        Me.GrdArtSecundario.Size = New System.Drawing.Size(884, 135)
        Me.GrdArtSecundario.TabIndex = 1
        Me.GrdArtSecundario.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GrdArtSecundario.UpdateOnLeave = False
        Me.GrdArtSecundario.UseCheck = True
        Me.GrdArtSecundario.ViewName = Nothing
        '
        'LblArticulo
        '
        Me.LblArticulo.Location = New System.Drawing.Point(12, 30)
        Me.LblArticulo.Name = "LblArticulo"
        Me.LblArticulo.Size = New System.Drawing.Size(50, 13)
        Me.LblArticulo.TabIndex = 6
        Me.LblArticulo.Text = "Artículo"
        '
        'FrmArticulo
        '
        Me.FrmArticulo.Controls.Add(Me.ULblUDExpedicion)
        Me.FrmArticulo.Controls.Add(Me.LblUDExpedicion)
        Me.FrmArticulo.Controls.Add(Me.ULblArticulo)
        Me.FrmArticulo.Controls.Add(Me.ULblDescArticulo)
        Me.FrmArticulo.Controls.Add(Me.LblArticulo)
        Me.FrmArticulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.FrmArticulo.Location = New System.Drawing.Point(0, 0)
        Me.FrmArticulo.Name = "FrmArticulo"
        Me.FrmArticulo.Size = New System.Drawing.Size(890, 61)
        Me.FrmArticulo.TabIndex = 3
        Me.FrmArticulo.TabStop = False
        Me.FrmArticulo.Text = "Datos Artículo"
        '
        'ULblUDExpedicion
        '
        Me.ULblUDExpedicion.Location = New System.Drawing.Point(727, 25)
        Me.ULblUDExpedicion.Name = "ULblUDExpedicion"
        Me.ULblUDExpedicion.Size = New System.Drawing.Size(100, 23)
        Me.ULblUDExpedicion.TabIndex = 11
        '
        'LblUDExpedicion
        '
        Me.LblUDExpedicion.Location = New System.Drawing.Point(628, 30)
        Me.LblUDExpedicion.Name = "LblUDExpedicion"
        Me.LblUDExpedicion.Size = New System.Drawing.Size(93, 13)
        Me.LblUDExpedicion.TabIndex = 10
        Me.LblUDExpedicion.Text = "UD. Expedición"
        '
        'ULblArticulo
        '
        Me.ULblArticulo.Location = New System.Drawing.Point(99, 25)
        Me.ULblArticulo.Name = "ULblArticulo"
        Me.ULblArticulo.Size = New System.Drawing.Size(127, 23)
        Me.ULblArticulo.TabIndex = 9
        '
        'ULblDescArticulo
        '
        Me.ULblDescArticulo.Location = New System.Drawing.Point(233, 25)
        Me.ULblDescArticulo.Name = "ULblDescArticulo"
        Me.ULblDescArticulo.Size = New System.Drawing.Size(389, 23)
        Me.ULblDescArticulo.TabIndex = 8
        '
        'ulblUDMedidaArticulo
        '
        Me.ulblUDMedidaArticulo.Location = New System.Drawing.Point(300, 35)
        Me.ulblUDMedidaArticulo.Name = "ulblUDMedidaArticulo"
        Me.ulblUDMedidaArticulo.Size = New System.Drawing.Size(58, 23)
        Me.ulblUDMedidaArticulo.TabIndex = 12
        '
        'frmArtCodifComp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 495)
        Me.Controls.Add(Me.SplMain)
        Me.Controls.Add(Me.FrmCantidades)
        Me.Controls.Add(Me.PnlButtons)
        Me.Controls.Add(Me.FrmArticulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmArtCodifComp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Artículos Compatibles"
        Me.PnlButtons.ResumeLayout(False)
        Me.FrmCantidades.ResumeLayout(False)
        Me.FrmCantidades.PerformLayout()
        Me.SplMain.Panel1.ResumeLayout(False)
        Me.SplMain.Panel2.ResumeLayout(False)
        Me.SplMain.ResumeLayout(False)
        Me.FrmPrincipal.ResumeLayout(False)
        CType(Me.GrdArtPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrmSecundario.ResumeLayout(False)
        CType(Me.GrdArtSecundario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrmArticulo.ResumeLayout(False)
        Me.FrmArticulo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents PnlButtons As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents FrmCantidades As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents SplMain As System.Windows.Forms.SplitContainer
    Public WithEvents FrmPrincipal As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents GrdArtPrincipal As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents FrmSecundario As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents NtbDiferencia As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents LblDiferencia As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents NtbCantidadAsignada As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents LblCantidadAsignada As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents NtbCantidadAAsignar As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents LblCantidadAAsignar As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents GrdArtSecundario As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents LblArticulo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FrmArticulo As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents ULblUDExpedicion As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents LblUDExpedicion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ULblArticulo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ULblDescArticulo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents LblTipoOperacion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvTipoOperacion As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents AdvDeposito As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents LblDeposito As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ulblUDMedidaArticulo As Solmicro.Expertis.Engine.UI.UnderLineLabel
End Class
