<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddInformacionCheque
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
        Me.lblNombreCheque = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNombreCheque = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDireccionCheque = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblDireccionCheque = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNumeroCheque = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblNumeroCheque = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNumCuentaCheque = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblNumCuentaCheque = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTelefCheque = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTelefCheque = New Solmicro.Expertis.Engine.UI.Label
        Me.lblBancoCheque = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDBancoCheque = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ulDescBancoCheque = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulDescBancoPropio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvIDBancoPropio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.FraDatosCheque = New Solmicro.Expertis.Engine.UI.Frame
        Me.FraDatosCaja = New Solmicro.Expertis.Engine.UI.Frame
        Me.cbxFecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1.suspendlayout()
        Me.FraDatosCheque.SuspendLayout()
        Me.FraDatosCaja.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 259)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(434, 47)
        Me.Panel1.TabIndex = 6
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(119, 8)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.cmbAceptar.TabIndex = 0
        Me.cmbAceptar.Text = "Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(219, 8)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 1
        Me.cmbCancelar.Text = "Cancelar"
        '
        'lblNombreCheque
        '
        Me.lblNombreCheque.Location = New System.Drawing.Point(30, 51)
        Me.lblNombreCheque.Name = "lblNombreCheque"
        Me.lblNombreCheque.Size = New System.Drawing.Size(52, 13)
        Me.lblNombreCheque.TabIndex = 18
        Me.lblNombreCheque.Text = "Nombre"
        '
        'txtNombreCheque
        '
        Me.txtNombreCheque.DisabledBackColor = System.Drawing.Color.White
        Me.txtNombreCheque.Location = New System.Drawing.Point(117, 47)
        Me.txtNombreCheque.Name = "txtNombreCheque"
        Me.txtNombreCheque.Size = New System.Drawing.Size(150, 21)
        Me.txtNombreCheque.TabIndex = 1
        '
        'txtDireccionCheque
        '
        Me.txtDireccionCheque.DisabledBackColor = System.Drawing.Color.White
        Me.txtDireccionCheque.Location = New System.Drawing.Point(117, 73)
        Me.txtDireccionCheque.Name = "txtDireccionCheque"
        Me.txtDireccionCheque.Size = New System.Drawing.Size(285, 21)
        Me.txtDireccionCheque.TabIndex = 2
        '
        'lblDireccionCheque
        '
        Me.lblDireccionCheque.Location = New System.Drawing.Point(30, 75)
        Me.lblDireccionCheque.Name = "lblDireccionCheque"
        Me.lblDireccionCheque.Size = New System.Drawing.Size(60, 13)
        Me.lblDireccionCheque.TabIndex = 20
        Me.lblDireccionCheque.Text = "Dirección"
        '
        'txtNumeroCheque
        '
        Me.txtNumeroCheque.DisabledBackColor = System.Drawing.Color.White
        Me.txtNumeroCheque.Location = New System.Drawing.Point(117, 21)
        Me.txtNumeroCheque.Name = "txtNumeroCheque"
        Me.txtNumeroCheque.Size = New System.Drawing.Size(150, 21)
        Me.txtNumeroCheque.TabIndex = 0
        '
        'lblNumeroCheque
        '
        Me.lblNumeroCheque.Location = New System.Drawing.Point(30, 25)
        Me.lblNumeroCheque.Name = "lblNumeroCheque"
        Me.lblNumeroCheque.Size = New System.Drawing.Size(52, 13)
        Me.lblNumeroCheque.TabIndex = 22
        Me.lblNumeroCheque.Text = "Número"
        '
        'txtNumCuentaCheque
        '
        Me.txtNumCuentaCheque.DisabledBackColor = System.Drawing.Color.White
        Me.txtNumCuentaCheque.Location = New System.Drawing.Point(117, 153)
        Me.txtNumCuentaCheque.Name = "txtNumCuentaCheque"
        Me.txtNumCuentaCheque.Size = New System.Drawing.Size(150, 21)
        Me.txtNumCuentaCheque.TabIndex = 5
        '
        'lblNumCuentaCheque
        '
        Me.lblNumCuentaCheque.Location = New System.Drawing.Point(30, 157)
        Me.lblNumCuentaCheque.Name = "lblNumCuentaCheque"
        Me.lblNumCuentaCheque.Size = New System.Drawing.Size(66, 13)
        Me.lblNumCuentaCheque.TabIndex = 26
        Me.lblNumCuentaCheque.Text = "Nº Cuenta"
        '
        'txtTelefCheque
        '
        Me.txtTelefCheque.DisabledBackColor = System.Drawing.Color.White
        Me.txtTelefCheque.Location = New System.Drawing.Point(117, 127)
        Me.txtTelefCheque.Name = "txtTelefCheque"
        Me.txtTelefCheque.Size = New System.Drawing.Size(150, 21)
        Me.txtTelefCheque.TabIndex = 4
        '
        'lblTelefCheque
        '
        Me.lblTelefCheque.Location = New System.Drawing.Point(30, 131)
        Me.lblTelefCheque.Name = "lblTelefCheque"
        Me.lblTelefCheque.Size = New System.Drawing.Size(83, 13)
        Me.lblTelefCheque.TabIndex = 24
        Me.lblTelefCheque.Text = "Tel. Contacto"
        '
        'lblBancoCheque
        '
        Me.lblBancoCheque.Location = New System.Drawing.Point(30, 104)
        Me.lblBancoCheque.Name = "lblBancoCheque"
        Me.lblBancoCheque.Size = New System.Drawing.Size(90, 13)
        Me.lblBancoCheque.TabIndex = 28
        Me.lblBancoCheque.Text = "Banco Cheque"
        '
        'advIDBancoCheque
        '
        Me.advIDBancoCheque.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescBanco", ulDescBancoCheque)})
        Me.advIDBancoCheque.DisabledBackColor = System.Drawing.Color.White
        Me.advIDBancoCheque.EntityName = "Banco"
        Me.advIDBancoCheque.Location = New System.Drawing.Point(117, 99)
        Me.advIDBancoCheque.Name = "advIDBancoCheque"
        Me.advIDBancoCheque.SecondaryDataFields = "IDBanco"
        Me.advIDBancoCheque.Size = New System.Drawing.Size(82, 23)
        Me.advIDBancoCheque.TabIndex = 3
        '
        'ulDescBancoCheque
        '
        Me.ulDescBancoCheque.Location = New System.Drawing.Point(203, 99)
        Me.ulDescBancoCheque.Name = "ulDescBancoCheque"
        Me.ulDescBancoCheque.Size = New System.Drawing.Size(199, 23)
        Me.ulDescBancoCheque.TabIndex = 30
        '
        'ulDescBancoPropio
        '
        Me.ulDescBancoPropio.Location = New System.Drawing.Point(205, 13)
        Me.ulDescBancoPropio.Name = "ulDescBancoPropio"
        Me.ulDescBancoPropio.Size = New System.Drawing.Size(199, 23)
        Me.ulDescBancoPropio.TabIndex = 33
        '
        'AdvIDBancoPropio
        '
        Me.AdvIDBancoPropio.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescBancoPropio", ulDescBancoPropio)})
        Me.AdvIDBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDBancoPropio.EntityName = "BancoPropio"
        Me.AdvIDBancoPropio.Location = New System.Drawing.Point(117, 13)
        Me.AdvIDBancoPropio.Name = "AdvIDBancoPropio"
        Me.AdvIDBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.AdvIDBancoPropio.Size = New System.Drawing.Size(82, 23)
        Me.AdvIDBancoPropio.TabIndex = 31
        '
        'lblBancoPropio
        '
        Me.lblBancoPropio.Location = New System.Drawing.Point(30, 18)
        Me.lblBancoPropio.Name = "lblBancoPropio"
        Me.lblBancoPropio.Size = New System.Drawing.Size(82, 13)
        Me.lblBancoPropio.TabIndex = 32
        Me.lblBancoPropio.Text = "Banco Propio"
        '
        'FraDatosCheque
        '
        Me.FraDatosCheque.Controls.Add(Me.advIDBancoCheque)
        Me.FraDatosCheque.Controls.Add(Me.lblNombreCheque)
        Me.FraDatosCheque.Controls.Add(Me.txtNombreCheque)
        Me.FraDatosCheque.Controls.Add(Me.lblDireccionCheque)
        Me.FraDatosCheque.Controls.Add(Me.ulDescBancoCheque)
        Me.FraDatosCheque.Controls.Add(Me.txtDireccionCheque)
        Me.FraDatosCheque.Controls.Add(Me.lblNumeroCheque)
        Me.FraDatosCheque.Controls.Add(Me.lblBancoCheque)
        Me.FraDatosCheque.Controls.Add(Me.txtNumeroCheque)
        Me.FraDatosCheque.Controls.Add(Me.txtNumCuentaCheque)
        Me.FraDatosCheque.Controls.Add(Me.lblTelefCheque)
        Me.FraDatosCheque.Controls.Add(Me.lblNumCuentaCheque)
        Me.FraDatosCheque.Controls.Add(Me.txtTelefCheque)
        Me.FraDatosCheque.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraDatosCheque.Location = New System.Drawing.Point(0, 0)
        Me.FraDatosCheque.Name = "FraDatosCheque"
        Me.FraDatosCheque.Size = New System.Drawing.Size(434, 184)
        Me.FraDatosCheque.TabIndex = 34
        Me.FraDatosCheque.TabStop = False
        Me.FraDatosCheque.Text = "Información del Cheque"
        '
        'FraDatosCaja
        '
        Me.FraDatosCaja.Controls.Add(Me.cbxFecha)
        Me.FraDatosCaja.Controls.Add(Me.lblFecha)
        Me.FraDatosCaja.Controls.Add(Me.lblBancoPropio)
        Me.FraDatosCaja.Controls.Add(Me.AdvIDBancoPropio)
        Me.FraDatosCaja.Controls.Add(Me.ulDescBancoPropio)
        Me.FraDatosCaja.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraDatosCaja.Location = New System.Drawing.Point(0, 184)
        Me.FraDatosCaja.Name = "FraDatosCaja"
        Me.FraDatosCaja.Size = New System.Drawing.Size(434, 69)
        Me.FraDatosCaja.TabIndex = 35
        Me.FraDatosCaja.TabStop = False
        '
        'cbxFecha
        '
        Me.cbxFecha.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFecha.Location = New System.Drawing.Point(117, 42)
        Me.cbxFecha.Name = "cbxFecha"
        Me.cbxFecha.Size = New System.Drawing.Size(107, 21)
        Me.cbxFecha.TabIndex = 37
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(30, 43)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 36
        Me.lblFecha.Text = "Fecha"
        '
        'frmAddInformacionCheque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 306)
        Me.Controls.Add(Me.FraDatosCaja)
        Me.Controls.Add(Me.FraDatosCheque)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddInformacionCheque"
        Me.Text = "Introduzca los datos del Cheque"
        Me.Panel1.ResumeLayout(False)
        Me.FraDatosCheque.ResumeLayout(False)
        Me.FraDatosCheque.PerformLayout()
        Me.FraDatosCaja.ResumeLayout(False)
        Me.FraDatosCaja.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents txtNombreCheque As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents txtDireccionCheque As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents txtNumeroCheque As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents txtNumCuentaCheque As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents txtTelefCheque As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents advIDBancoCheque As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents AdvIDBancoPropio As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents lblNombreCheque As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblDireccionCheque As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblNumeroCheque As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblNumCuentaCheque As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblTelefCheque As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblBancoCheque As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ulDescBancoCheque As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ulDescBancoPropio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents lblBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FraDatosCheque As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents FraDatosCaja As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents cbxFecha As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblFecha As Solmicro.Expertis.Engine.UI.Label
End Class
