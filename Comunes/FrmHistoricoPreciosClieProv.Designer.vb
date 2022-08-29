<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHistoricoPreciosClieProv
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
        Dim GrdHistorico_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.PnlButtons = New Solmicro.Expertis.Engine.UI.Panel
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.FrmHistorico = New Solmicro.Expertis.Engine.UI.Frame
        Me.GrdHistorico = New Solmicro.Expertis.Engine.UI.Grid
        Me.FrmInfo = New Solmicro.Expertis.Engine.UI.Frame
        Me.ULblDescIdentity = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ULblDescArticulo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.TxtIDArticulo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblIDArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.TxtIdentity = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblIdentity = New Solmicro.Expertis.Engine.UI.Label
        Me.PnlButtons.suspendlayout()
        Me.FrmHistorico.SuspendLayout()
        CType(Me.GrdHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrmInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlButtons
        '
        Me.PnlButtons.Controls.Add(Me.BtnCancelar)
        Me.PnlButtons.Controls.Add(Me.BtnAceptar)
        Me.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlButtons.Location = New System.Drawing.Point(0, 369)
        Me.PnlButtons.Name = "PnlButtons"
        Me.PnlButtons.Size = New System.Drawing.Size(811, 49)
        Me.PnlButtons.TabIndex = 0
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(408, 6)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(92, 36)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(310, 6)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(92, 36)
        Me.BtnAceptar.TabIndex = 0
        Me.BtnAceptar.Text = "&Aceptar"
        '
        'FrmHistorico
        '
        Me.FrmHistorico.Controls.Add(Me.GrdHistorico)
        Me.FrmHistorico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmHistorico.Location = New System.Drawing.Point(0, 74)
        Me.FrmHistorico.Name = "FrmHistorico"
        Me.FrmHistorico.Size = New System.Drawing.Size(811, 295)
        Me.FrmHistorico.TabIndex = 1
        Me.FrmHistorico.TabStop = False
        Me.FrmHistorico.Text = "Histórico Precios"
        '
        'GrdHistorico
        '
        GrdHistorico_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /></RootTable></GridEXLayoutData>"
        Me.GrdHistorico.DesignTimeLayout = GrdHistorico_DesignTimeLayout
        Me.GrdHistorico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdHistorico.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdHistorico.EntityName = Nothing
        Me.GrdHistorico.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrdHistorico.Location = New System.Drawing.Point(3, 17)
        Me.GrdHistorico.Name = "GrdHistorico"
        Me.GrdHistorico.PrimaryDataFields = Nothing
        Me.GrdHistorico.SecondaryDataFields = Nothing
        Me.GrdHistorico.Size = New System.Drawing.Size(805, 275)
        Me.GrdHistorico.TabIndex = 0
        Me.GrdHistorico.ViewName = Nothing
        '
        'FrmInfo
        '
        Me.FrmInfo.Controls.Add(Me.ULblDescIdentity)
        Me.FrmInfo.Controls.Add(Me.ULblDescArticulo)
        Me.FrmInfo.Controls.Add(Me.TxtIDArticulo)
        Me.FrmInfo.Controls.Add(Me.LblIDArticulo)
        Me.FrmInfo.Controls.Add(Me.TxtIdentity)
        Me.FrmInfo.Controls.Add(Me.LblIdentity)
        Me.FrmInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.FrmInfo.Location = New System.Drawing.Point(0, 0)
        Me.FrmInfo.Name = "FrmInfo"
        Me.FrmInfo.Size = New System.Drawing.Size(811, 74)
        Me.FrmInfo.TabIndex = 2
        Me.FrmInfo.TabStop = False
        Me.FrmInfo.Text = "Info"
        '
        'ULblDescIdentity
        '
        Me.ULblDescIdentity.Location = New System.Drawing.Point(221, 16)
        Me.ULblDescIdentity.Name = "ULblDescIdentity"
        Me.ULblDescIdentity.Size = New System.Drawing.Size(584, 23)
        Me.ULblDescIdentity.TabIndex = 10
        '
        'ULblDescArticulo
        '
        Me.ULblDescArticulo.Location = New System.Drawing.Point(221, 43)
        Me.ULblDescArticulo.Name = "ULblDescArticulo"
        Me.ULblDescArticulo.Size = New System.Drawing.Size(584, 23)
        Me.ULblDescArticulo.TabIndex = 9
        '
        'TxtIDArticulo
        '
        Me.TxtIDArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.TxtIDArticulo.Enabled = False
        Me.TxtIDArticulo.Location = New System.Drawing.Point(74, 44)
        Me.TxtIDArticulo.Name = "TxtIDArticulo"
        Me.TxtIDArticulo.Size = New System.Drawing.Size(141, 21)
        Me.TxtIDArticulo.TabIndex = 8
        '
        'LblIDArticulo
        '
        Me.LblIDArticulo.Location = New System.Drawing.Point(6, 48)
        Me.LblIDArticulo.Name = "LblIDArticulo"
        Me.LblIDArticulo.Size = New System.Drawing.Size(50, 13)
        Me.LblIDArticulo.TabIndex = 7
        Me.LblIDArticulo.Text = "Artículo"
        '
        'TxtIdentity
        '
        Me.TxtIdentity.DisabledBackColor = System.Drawing.Color.White
        Me.TxtIdentity.Enabled = False
        Me.TxtIdentity.Location = New System.Drawing.Point(74, 17)
        Me.TxtIdentity.Name = "TxtIdentity"
        Me.TxtIdentity.Size = New System.Drawing.Size(141, 21)
        Me.TxtIdentity.TabIndex = 4
        '
        'LblIdentity
        '
        Me.LblIdentity.Location = New System.Drawing.Point(6, 21)
        Me.LblIdentity.Name = "LblIdentity"
        Me.LblIdentity.Size = New System.Drawing.Size(51, 13)
        Me.LblIdentity.TabIndex = 3
        Me.LblIdentity.Text = "Identity"
        '
        'FrmHistoricoPreciosClieProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 418)
        Me.Controls.Add(Me.FrmHistorico)
        Me.Controls.Add(Me.FrmInfo)
        Me.Controls.Add(Me.PnlButtons)
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmHistoricoPreciosClieProv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Histórico Precios"
        Me.PnlButtons.ResumeLayout(False)
        Me.FrmHistorico.ResumeLayout(False)
        CType(Me.GrdHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrmInfo.ResumeLayout(False)
        Me.FrmInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlButtons As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents FrmHistorico As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents GrdHistorico As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents FrmInfo As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents LblIdentity As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TxtIdentity As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents ULblDescIdentity As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ULblDescArticulo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents TxtIDArticulo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblIDArticulo As Solmicro.Expertis.Engine.UI.Label
End Class
