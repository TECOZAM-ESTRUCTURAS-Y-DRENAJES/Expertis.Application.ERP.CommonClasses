<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfigTimeLineObras
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
        Dim ComboBox1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfigTimeLineObras))
        Dim ComboBox2_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim ComboBox3_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim ComboBox4_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim ComboBox5_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim ComboBox6_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.PnlButtons = New Solmicro.Expertis.Engine.UI.Panel
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.FrmConfig = New Solmicro.Expertis.Engine.UI.Frame
        Me.ComboBox1 = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.ComboBox2 = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.ComboBox3 = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.Frame2 = New Solmicro.Expertis.Engine.UI.Frame
        Me.ComboBox4 = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.ComboBox5 = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.ComboBox6 = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.CheckBox1 = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.PnlButtons.suspendlayout()
        Me.FrmConfig.SuspendLayout()
        CType(Me.ComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        CType(Me.ComboBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlButtons
        '
        Me.PnlButtons.Controls.Add(Me.BtnCancelar)
        Me.PnlButtons.Controls.Add(Me.BtnAceptar)
        Me.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlButtons.Location = New System.Drawing.Point(0, 515)
        Me.PnlButtons.Name = "PnlButtons"
        Me.PnlButtons.Size = New System.Drawing.Size(636, 40)
        Me.PnlButtons.TabIndex = 0
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(321, 5)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(93, 30)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(222, 5)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(93, 30)
        Me.BtnAceptar.TabIndex = 0
        Me.BtnAceptar.Text = "&Aceptar"
        '
        'FrmConfig
        '
        Me.FrmConfig.Controls.Add(Me.Frame2)
        Me.FrmConfig.Controls.Add(Me.Frame1)
        Me.FrmConfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmConfig.Location = New System.Drawing.Point(0, 0)
        Me.FrmConfig.Name = "FrmConfig"
        Me.FrmConfig.Size = New System.Drawing.Size(636, 515)
        Me.FrmConfig.TabIndex = 1
        Me.FrmConfig.TabStop = False
        Me.FrmConfig.Text = "Configuración"
        '
        'ComboBox1
        '
        ComboBox1_DesignTimeLayout.LayoutString = resources.GetString("ComboBox1_DesignTimeLayout.LayoutString")
        Me.ComboBox1.DesignTimeLayout = ComboBox1_DesignTimeLayout
        Me.ComboBox1.DisabledBackColor = System.Drawing.Color.White
        Me.ComboBox1.Location = New System.Drawing.Point(44, 20)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.SelectedIndex = -1
        Me.ComboBox1.SelectedItem = Nothing
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'ComboBox2
        '
        ComboBox2_DesignTimeLayout.LayoutString = resources.GetString("ComboBox2_DesignTimeLayout.LayoutString")
        Me.ComboBox2.DesignTimeLayout = ComboBox2_DesignTimeLayout
        Me.ComboBox2.DisabledBackColor = System.Drawing.Color.White
        Me.ComboBox2.Location = New System.Drawing.Point(44, 59)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.SelectedIndex = -1
        Me.ComboBox2.SelectedItem = Nothing
        Me.ComboBox2.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox2.TabIndex = 1
        '
        'ComboBox3
        '
        ComboBox3_DesignTimeLayout.LayoutString = resources.GetString("ComboBox3_DesignTimeLayout.LayoutString")
        Me.ComboBox3.DesignTimeLayout = ComboBox3_DesignTimeLayout
        Me.ComboBox3.DisabledBackColor = System.Drawing.Color.White
        Me.ComboBox3.Location = New System.Drawing.Point(44, 97)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.SelectedIndex = -1
        Me.ComboBox3.SelectedItem = Nothing
        Me.ComboBox3.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox3.TabIndex = 2
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.CheckBox1)
        Me.Frame1.Controls.Add(Me.ComboBox4)
        Me.Frame1.Controls.Add(Me.ComboBox5)
        Me.Frame1.Controls.Add(Me.ComboBox6)
        Me.Frame1.Location = New System.Drawing.Point(12, 184)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(200, 175)
        Me.Frame1.TabIndex = 3
        Me.Frame1.TabStop = False
        '
        'Frame2
        '
        Me.Frame2.Controls.Add(Me.ComboBox1)
        Me.Frame2.Controls.Add(Me.ComboBox2)
        Me.Frame2.Controls.Add(Me.ComboBox3)
        Me.Frame2.Location = New System.Drawing.Point(247, 20)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = New System.Drawing.Size(200, 136)
        Me.Frame2.TabIndex = 4
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Frame2"
        '
        'ComboBox4
        '
        ComboBox4_DesignTimeLayout.LayoutString = resources.GetString("ComboBox4_DesignTimeLayout.LayoutString")
        Me.ComboBox4.DesignTimeLayout = ComboBox4_DesignTimeLayout
        Me.ComboBox4.DisabledBackColor = System.Drawing.Color.White
        Me.ComboBox4.Location = New System.Drawing.Point(15, 64)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.SelectedIndex = -1
        Me.ComboBox4.SelectedItem = Nothing
        Me.ComboBox4.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox4.TabIndex = 3
        '
        'ComboBox5
        '
        ComboBox5_DesignTimeLayout.LayoutString = resources.GetString("ComboBox5_DesignTimeLayout.LayoutString")
        Me.ComboBox5.DesignTimeLayout = ComboBox5_DesignTimeLayout
        Me.ComboBox5.DisabledBackColor = System.Drawing.Color.White
        Me.ComboBox5.Location = New System.Drawing.Point(15, 103)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.SelectedIndex = -1
        Me.ComboBox5.SelectedItem = Nothing
        Me.ComboBox5.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox5.TabIndex = 4
        '
        'ComboBox6
        '
        ComboBox6_DesignTimeLayout.LayoutString = resources.GetString("ComboBox6_DesignTimeLayout.LayoutString")
        Me.ComboBox6.DesignTimeLayout = ComboBox6_DesignTimeLayout
        Me.ComboBox6.DisabledBackColor = System.Drawing.Color.White
        Me.ComboBox6.Location = New System.Drawing.Point(15, 141)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.SelectedIndex = -1
        Me.ComboBox6.SelectedItem = Nothing
        Me.ComboBox6.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox6.TabIndex = 5
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(6, 0)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(74, 24)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "CheckBox1"
        '
        'FrmConfigTimeLineObras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 555)
        Me.Controls.Add(Me.FrmConfig)
        Me.Controls.Add(Me.PnlButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConfigTimeLineObras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurar Gráfico Obras"
        Me.PnlButtons.ResumeLayout(False)
        Me.FrmConfig.ResumeLayout(False)
        CType(Me.ComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        CType(Me.ComboBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlButtons As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents FrmConfig As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents Frame2 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents ComboBox1 As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents ComboBox2 As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents ComboBox3 As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents CheckBox1 As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents ComboBox4 As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents ComboBox5 As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents ComboBox6 As Solmicro.Expertis.Engine.UI.ComboBox
End Class
