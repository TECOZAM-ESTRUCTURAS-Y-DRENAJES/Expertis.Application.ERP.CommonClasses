<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFechaCalcPrecioOptimo
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
        Me.PnlButtons = New Solmicro.Expertis.Engine.UI.Panel
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.FrmFecha = New Solmicro.Expertis.Engine.UI.Frame
        Me.ClbFechaPrecioOptimo = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.PnlButtons.suspendlayout()
        Me.FrmFecha.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlButtons
        '
        Me.PnlButtons.Controls.Add(Me.BtnCancelar)
        Me.PnlButtons.Controls.Add(Me.BtnAceptar)
        Me.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlButtons.Location = New System.Drawing.Point(0, 51)
        Me.PnlButtons.Name = "PnlButtons"
        Me.PnlButtons.Size = New System.Drawing.Size(200, 48)
        Me.PnlButtons.TabIndex = 2
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(12, 6)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(85, 33)
        Me.BtnAceptar.TabIndex = 3
        Me.BtnAceptar.Text = "Aceptar"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(103, 6)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(85, 33)
        Me.BtnCancelar.TabIndex = 4
        Me.BtnCancelar.Text = "Cancelar"
        '
        'FrmFecha
        '
        Me.FrmFecha.Controls.Add(Me.ClbFechaPrecioOptimo)
        Me.FrmFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmFecha.Location = New System.Drawing.Point(0, 0)
        Me.FrmFecha.Name = "FrmFecha"
        Me.FrmFecha.Size = New System.Drawing.Size(200, 51)
        Me.FrmFecha.TabIndex = 1
        Me.FrmFecha.TabStop = False
        Me.FrmFecha.Text = "Introduzca Fecha..."
        '
        'ClbFechaPrecioOptimo
        '
        Me.ClbFechaPrecioOptimo.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaPrecioOptimo.Location = New System.Drawing.Point(6, 20)
        Me.ClbFechaPrecioOptimo.Name = "ClbFechaPrecioOptimo"
        Me.ClbFechaPrecioOptimo.Size = New System.Drawing.Size(182, 21)
        Me.ClbFechaPrecioOptimo.TabIndex = 1
        '
        'frmFechaCalcPrecioOptimo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(200, 99)
        Me.Controls.Add(Me.FrmFecha)
        Me.Controls.Add(Me.PnlButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFechaCalcPrecioOptimo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Precio Óptimo"
        Me.PnlButtons.ResumeLayout(False)
        Me.FrmFecha.ResumeLayout(False)
        Me.FrmFecha.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlButtons As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents FrmFecha As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents ClbFechaPrecioOptimo As Solmicro.Expertis.Engine.UI.CalendarBox
End Class
