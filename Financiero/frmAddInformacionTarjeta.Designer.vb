<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddInformacionTarjeta
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
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.FraDatosTarjeta = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtNumeroTarjeta = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblNumeroCheque = New Solmicro.Expertis.Engine.UI.Label
        Me.txtVoucher = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblNombreCheque = New Solmicro.Expertis.Engine.UI.Label
        Me.FraDatosCaja = New Solmicro.Expertis.Engine.UI.Frame
        Me.cbxFecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.lblBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDBancoPropio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ulDescBancoPropio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advIDBancoTarjeta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ulDescBancoTarjeta = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblBancoTarjeta = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1.suspendlayout()
        Me.FraDatosTarjeta.SuspendLayout()
        Me.FraDatosCaja.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 219)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(408, 47)
        Me.Panel1.TabIndex = 7
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(107, 9)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.cmbAceptar.TabIndex = 0
        Me.cmbAceptar.Text = "Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(207, 9)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 1
        Me.cmbCancelar.Text = "Cancelar"
        '
        'FraDatosTarjeta
        '
        Me.FraDatosTarjeta.Controls.Add(Me.advIDBancoTarjeta)
        Me.FraDatosTarjeta.Controls.Add(Me.ulDescBancoTarjeta)
        Me.FraDatosTarjeta.Controls.Add(Me.lblBancoTarjeta)
        Me.FraDatosTarjeta.Controls.Add(Me.txtNumeroTarjeta)
        Me.FraDatosTarjeta.Controls.Add(Me.lblNumeroCheque)
        Me.FraDatosTarjeta.Controls.Add(Me.txtVoucher)
        Me.FraDatosTarjeta.Controls.Add(Me.lblNombreCheque)
        Me.FraDatosTarjeta.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraDatosTarjeta.Location = New System.Drawing.Point(0, 0)
        Me.FraDatosTarjeta.Name = "FraDatosTarjeta"
        Me.FraDatosTarjeta.Size = New System.Drawing.Size(408, 126)
        Me.FraDatosTarjeta.TabIndex = 27
        Me.FraDatosTarjeta.TabStop = False
        Me.FraDatosTarjeta.Text = "Datos de la Tarjeta"
        '
        'txtNumeroTarjeta
        '
        Me.txtNumeroTarjeta.DisabledBackColor = System.Drawing.Color.White
        Me.txtNumeroTarjeta.Location = New System.Drawing.Point(103, 26)
        Me.txtNumeroTarjeta.Name = "txtNumeroTarjeta"
        Me.txtNumeroTarjeta.Size = New System.Drawing.Size(150, 21)
        Me.txtNumeroTarjeta.TabIndex = 27
        '
        'lblNumeroCheque
        '
        Me.lblNumeroCheque.Location = New System.Drawing.Point(18, 30)
        Me.lblNumeroCheque.Name = "lblNumeroCheque"
        Me.lblNumeroCheque.Size = New System.Drawing.Size(52, 13)
        Me.lblNumeroCheque.TabIndex = 30
        Me.lblNumeroCheque.Text = "Número"
        '
        'txtVoucher
        '
        Me.txtVoucher.DisabledBackColor = System.Drawing.Color.White
        Me.txtVoucher.Location = New System.Drawing.Point(103, 55)
        Me.txtVoucher.Name = "txtVoucher"
        Me.txtVoucher.Size = New System.Drawing.Size(150, 21)
        Me.txtVoucher.TabIndex = 28
        '
        'lblNombreCheque
        '
        Me.lblNombreCheque.Location = New System.Drawing.Point(18, 59)
        Me.lblNombreCheque.Name = "lblNombreCheque"
        Me.lblNombreCheque.Size = New System.Drawing.Size(45, 13)
        Me.lblNombreCheque.TabIndex = 29
        Me.lblNombreCheque.Text = "Recibo"
        '
        'FraDatosCaja
        '
        Me.FraDatosCaja.Controls.Add(Me.cbxFecha)
        Me.FraDatosCaja.Controls.Add(Me.lblFecha)
        Me.FraDatosCaja.Controls.Add(Me.lblBancoPropio)
        Me.FraDatosCaja.Controls.Add(Me.AdvIDBancoPropio)
        Me.FraDatosCaja.Controls.Add(Me.ulDescBancoPropio)
        Me.FraDatosCaja.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraDatosCaja.Location = New System.Drawing.Point(0, 126)
        Me.FraDatosCaja.Name = "FraDatosCaja"
        Me.FraDatosCaja.Size = New System.Drawing.Size(408, 83)
        Me.FraDatosCaja.TabIndex = 37
        Me.FraDatosCaja.TabStop = False
        '
        'cbxFecha
        '
        Me.cbxFecha.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFecha.Location = New System.Drawing.Point(102, 49)
        Me.cbxFecha.Name = "cbxFecha"
        Me.cbxFecha.Size = New System.Drawing.Size(107, 21)
        Me.cbxFecha.TabIndex = 35
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(18, 50)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 34
        Me.lblFecha.Text = "Fecha"
        '
        'lblBancoPropio
        '
        Me.lblBancoPropio.Location = New System.Drawing.Point(18, 18)
        Me.lblBancoPropio.Name = "lblBancoPropio"
        Me.lblBancoPropio.Size = New System.Drawing.Size(82, 13)
        Me.lblBancoPropio.TabIndex = 32
        Me.lblBancoPropio.Text = "Banco Propio"
        '
        'AdvIDBancoPropio
        '
        Me.AdvIDBancoPropio.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescBancoPropio", ulDescBancoPropio)})
        Me.AdvIDBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDBancoPropio.EntityName = "BancoPropio"
        Me.AdvIDBancoPropio.Location = New System.Drawing.Point(101, 13)
        Me.AdvIDBancoPropio.Name = "AdvIDBancoPropio"
        Me.AdvIDBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.AdvIDBancoPropio.Size = New System.Drawing.Size(82, 23)
        Me.AdvIDBancoPropio.TabIndex = 31
        '
        'ulDescBancoPropio
        '
        Me.ulDescBancoPropio.Location = New System.Drawing.Point(189, 13)
        Me.ulDescBancoPropio.Name = "ulDescBancoPropio"
        Me.ulDescBancoPropio.Size = New System.Drawing.Size(199, 23)
        Me.ulDescBancoPropio.TabIndex = 33
        '
        'advIDBancoTarjeta
        '
        Me.advIDBancoTarjeta.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescBanco", ulDescBancoTarjeta)})
        Me.advIDBancoTarjeta.DisabledBackColor = System.Drawing.Color.White
        Me.advIDBancoTarjeta.EntityName = "Banco"
        Me.advIDBancoTarjeta.Location = New System.Drawing.Point(104, 84)
        Me.advIDBancoTarjeta.Name = "advIDBancoTarjeta"
        Me.advIDBancoTarjeta.SecondaryDataFields = "IDBanco"
        Me.advIDBancoTarjeta.Size = New System.Drawing.Size(82, 23)
        Me.advIDBancoTarjeta.TabIndex = 31
        '
        'ulDescBancoTarjeta
        '
        Me.ulDescBancoTarjeta.Location = New System.Drawing.Point(190, 84)
        Me.ulDescBancoTarjeta.Name = "ulDescBancoTarjeta"
        Me.ulDescBancoTarjeta.Size = New System.Drawing.Size(199, 23)
        Me.ulDescBancoTarjeta.TabIndex = 33
        '
        'lblBancoTarjeta
        '
        Me.lblBancoTarjeta.Location = New System.Drawing.Point(17, 89)
        Me.lblBancoTarjeta.Name = "lblBancoTarjeta"
        Me.lblBancoTarjeta.Size = New System.Drawing.Size(87, 13)
        Me.lblBancoTarjeta.TabIndex = 32
        Me.lblBancoTarjeta.Text = "Banco Tarjeta"
        '
        'frmAddInformacionTarjeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 266)
        Me.Controls.Add(Me.FraDatosCaja)
        Me.Controls.Add(Me.FraDatosTarjeta)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmAddInformacionTarjeta"
        Me.Text = "Introduzca los datos de la tarjeta"
        Me.Panel1.ResumeLayout(False)
        Me.FraDatosTarjeta.ResumeLayout(False)
        Me.FraDatosTarjeta.PerformLayout()
        Me.FraDatosCaja.ResumeLayout(False)
        Me.FraDatosCaja.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents txtNumeroTarjeta As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents txtVoucher As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents AdvIDBancoPropio As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents FraDatosTarjeta As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblNumeroCheque As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblNombreCheque As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FraDatosCaja As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ulDescBancoPropio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents lblFecha As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFecha As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents advIDBancoTarjeta As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents ulDescBancoTarjeta As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents lblBancoTarjeta As Solmicro.Expertis.Engine.UI.Label
End Class
