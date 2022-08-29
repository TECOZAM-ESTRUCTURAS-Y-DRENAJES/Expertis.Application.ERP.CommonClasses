Public Class frmActualizarPreciosEspecifico
    Inherits frmActualizarPreciosBase

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents lblPrecioVenta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblPrecioCoste As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbPrecioCoste As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents cbPrecioVenta As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents advTarifa As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblPresupCoste As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblTarifa As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblPresupVenta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvPresupCoste As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvPresupVenta As Solmicro.Expertis.Engine.UI.AdvSearch
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim cbPrecioCoste_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbPrecioVenta_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActualizarPreciosEspecifico))
        Me.lblPrecioVenta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPrecioCoste = New Solmicro.Expertis.Engine.UI.Label
        Me.cbPrecioCoste = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.cbPrecioVenta = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.advTarifa = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvPresupCoste = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblPresupCoste = New Solmicro.Expertis.Engine.UI.Label
        Me.LblTarifa = New Solmicro.Expertis.Engine.UI.Label
        Me.LblPresupVenta = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvPresupVenta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.pnlAcciones.SuspendLayout()
        Me.pnlValidar.SuspendLayout()
        Me.frmAcciones.SuspendLayout()
        CType(Me.cbPrecioCoste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbPrecioVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbCosteVenta
        '
        Me.rbCosteVenta.Checked = True
        Me.rbCosteVenta.TabStop = True
        Me.rbCosteVenta.Text = "Precio coste y recalcular precio venta"
        '
        'rbCosteMargen
        '
        Me.rbCosteMargen.Text = "Precio coste y recalcular margen"
        '
        'rbVentaMargen
        '
        Me.rbVentaMargen.Text = "Precio venta y recalcular margen"
        '
        'rbMargenVenta
        '
        Me.rbMargenVenta.Text = "Margen y recalcular precio venta"
        '
        'pnlActualizaciones
        '
        Me.pnlActualizaciones.Size = New System.Drawing.Size(656, 136)
        '
        'pnlAcciones
        '
        Me.pnlAcciones.Size = New System.Drawing.Size(656, 131)
        '
        'pnlValidar
        '
        Me.pnlValidar.Location = New System.Drawing.Point(0, 268)
        Me.pnlValidar.Size = New System.Drawing.Size(656, 48)
        '
        'frmAcciones
        '
        Me.frmAcciones.Controls.Add(Me.LblPresupVenta)
        Me.frmAcciones.Controls.Add(Me.AdvPresupVenta)
        Me.frmAcciones.Controls.Add(Me.LblTarifa)
        Me.frmAcciones.Controls.Add(Me.LblPresupCoste)
        Me.frmAcciones.Controls.Add(Me.AdvPresupCoste)
        Me.frmAcciones.Controls.Add(Me.advTarifa)
        Me.frmAcciones.Controls.Add(Me.cbPrecioVenta)
        Me.frmAcciones.Controls.Add(Me.cbPrecioCoste)
        Me.frmAcciones.Controls.Add(Me.lblPrecioVenta)
        Me.frmAcciones.Controls.Add(Me.lblPrecioCoste)
        Me.frmAcciones.Location = New System.Drawing.Point(8, 2)
        Me.frmAcciones.Size = New System.Drawing.Size(640, 127)
        Me.frmAcciones.Controls.SetChildIndex(Me.lblIncrementar, 0)
        Me.frmAcciones.Controls.SetChildIndex(Me.lblDecrementar, 0)
        Me.frmAcciones.Controls.SetChildIndex(Me.txtIncrementar, 0)
        Me.frmAcciones.Controls.SetChildIndex(Me.txtDecrementar, 0)
        Me.frmAcciones.Controls.SetChildIndex(Me.lblMargen, 0)
        Me.frmAcciones.Controls.SetChildIndex(Me.txtMargen, 0)
        Me.frmAcciones.Controls.SetChildIndex(Me.lblPrecioCoste, 0)
        Me.frmAcciones.Controls.SetChildIndex(Me.lblPrecioVenta, 0)
        Me.frmAcciones.Controls.SetChildIndex(Me.cbPrecioCoste, 0)
        Me.frmAcciones.Controls.SetChildIndex(Me.cbPrecioVenta, 0)
        Me.frmAcciones.Controls.SetChildIndex(Me.advTarifa, 0)
        Me.frmAcciones.Controls.SetChildIndex(Me.AdvPresupCoste, 0)
        Me.frmAcciones.Controls.SetChildIndex(Me.LblPresupCoste, 0)
        Me.frmAcciones.Controls.SetChildIndex(Me.LblTarifa, 0)
        Me.frmAcciones.Controls.SetChildIndex(Me.AdvPresupVenta, 0)
        Me.frmAcciones.Controls.SetChildIndex(Me.LblPresupVenta, 0)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(331, 8)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(211, 8)
        '
        'lblPrecioVenta
        '
        Me.lblPrecioVenta.Location = New System.Drawing.Point(16, 100)
        Me.lblPrecioVenta.Name = "lblPrecioVenta"
        Me.lblPrecioVenta.Size = New System.Drawing.Size(78, 13)
        Me.lblPrecioVenta.TabIndex = 19
        Me.lblPrecioVenta.Text = "Precio venta"
        '
        'lblPrecioCoste
        '
        Me.lblPrecioCoste.Location = New System.Drawing.Point(16, 75)
        Me.lblPrecioCoste.Name = "lblPrecioCoste"
        Me.lblPrecioCoste.Size = New System.Drawing.Size(76, 13)
        Me.lblPrecioCoste.TabIndex = 20
        Me.lblPrecioCoste.Text = "Precio coste"
        '
        'cbPrecioCoste
        '
        cbPrecioCoste_DesignTimeLayout.LayoutString = resources.GetString("cbPrecioCoste_DesignTimeLayout.LayoutString")
        Me.cbPrecioCoste.DesignTimeLayout = cbPrecioCoste_DesignTimeLayout
        Me.cbPrecioCoste.DisabledBackColor = System.Drawing.Color.White
        Me.cbPrecioCoste.Location = New System.Drawing.Point(117, 72)
        Me.cbPrecioCoste.Name = "cbPrecioCoste"
        Me.cbPrecioCoste.SelectedIndex = -1
        Me.cbPrecioCoste.SelectedItem = Nothing
        Me.cbPrecioCoste.Size = New System.Drawing.Size(176, 21)
        Me.cbPrecioCoste.TabIndex = 21
        '
        'cbPrecioVenta
        '
        cbPrecioVenta_DesignTimeLayout.LayoutString = resources.GetString("cbPrecioVenta_DesignTimeLayout.LayoutString")
        Me.cbPrecioVenta.DesignTimeLayout = cbPrecioVenta_DesignTimeLayout
        Me.cbPrecioVenta.DisabledBackColor = System.Drawing.Color.White
        Me.cbPrecioVenta.Location = New System.Drawing.Point(117, 96)
        Me.cbPrecioVenta.Name = "cbPrecioVenta"
        Me.cbPrecioVenta.SelectedIndex = -1
        Me.cbPrecioVenta.SelectedItem = Nothing
        Me.cbPrecioVenta.Size = New System.Drawing.Size(176, 21)
        Me.cbPrecioVenta.TabIndex = 22
        '
        'advTarifa
        '
        Me.advTarifa.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("IDTarifa", advTarifa)})
        Me.advTarifa.DisabledBackColor = System.Drawing.Color.White
        Me.advTarifa.EntityName = "Tarifa"
        Me.advTarifa.Location = New System.Drawing.Point(536, 96)
        Me.advTarifa.Name = "advTarifa"
        Me.advTarifa.SecondaryDataFields = "IDTarifa"
        Me.advTarifa.Size = New System.Drawing.Size(98, 23)
        Me.advTarifa.TabIndex = 23
        '
        'AdvPresupCoste
        '
        Me.AdvPresupCoste.DisabledBackColor = System.Drawing.Color.White
        Me.AdvPresupCoste.DisplayField = "NumPresup"
        Me.AdvPresupCoste.Enabled = False
        Me.AdvPresupCoste.EntityName = "ObraPresupCabecera"
        Me.AdvPresupCoste.Location = New System.Drawing.Point(379, 70)
        Me.AdvPresupCoste.Name = "AdvPresupCoste"
        Me.AdvPresupCoste.SecondaryDataFields = "IDPresup"
        Me.AdvPresupCoste.Size = New System.Drawing.Size(101, 23)
        Me.AdvPresupCoste.TabIndex = 24
        '
        'LblPresupCoste
        '
        Me.LblPresupCoste.Location = New System.Drawing.Point(298, 75)
        Me.LblPresupCoste.Name = "LblPresupCoste"
        Me.LblPresupCoste.Size = New System.Drawing.Size(77, 13)
        Me.LblPresupCoste.TabIndex = 25
        Me.LblPresupCoste.Text = "Presupuesto"
        Me.LblPresupCoste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTarifa
        '
        Me.LblTarifa.Location = New System.Drawing.Point(488, 101)
        Me.LblTarifa.Name = "LblTarifa"
        Me.LblTarifa.Size = New System.Drawing.Size(40, 13)
        Me.LblTarifa.TabIndex = 26
        Me.LblTarifa.Text = "Tarifa"
        Me.LblTarifa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblPresupVenta
        '
        Me.LblPresupVenta.Location = New System.Drawing.Point(298, 100)
        Me.LblPresupVenta.Name = "LblPresupVenta"
        Me.LblPresupVenta.Size = New System.Drawing.Size(77, 13)
        Me.LblPresupVenta.TabIndex = 28
        Me.LblPresupVenta.Text = "Presupuesto"
        Me.LblPresupVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvPresupVenta
        '
        Me.AdvPresupVenta.DisabledBackColor = System.Drawing.Color.White
        Me.AdvPresupVenta.DisplayField = "NumPresup"
        Me.AdvPresupVenta.Enabled = False
        Me.AdvPresupVenta.EntityName = "ObraPresupCabecera"
        Me.AdvPresupVenta.Location = New System.Drawing.Point(379, 96)
        Me.AdvPresupVenta.Name = "AdvPresupVenta"
        Me.AdvPresupVenta.SecondaryDataFields = "IDPresup"
        Me.AdvPresupVenta.Size = New System.Drawing.Size(101, 23)
        Me.AdvPresupVenta.TabIndex = 27
        '
        'frmActualizarPreciosEspecifico
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(656, 315)
        Me.Name = "frmActualizarPreciosEspecifico"
        Me.pnlAcciones.ResumeLayout(False)
        Me.pnlValidar.ResumeLayout(False)
        Me.frmAcciones.ResumeLayout(False)
        Me.frmAcciones.PerformLayout()
        CType(Me.cbPrecioCoste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbPrecioVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Function AbrirActualizarPrecios() As ActualizarPrecios.datosActualizacionPrecios
        Me.ShowDialog()
        If Me.DialogResult = Windows.Forms.DialogResult.OK Then
            minfoActualizacionPrecios = New ActualizarPrecios.datosActualizacionPrecios
            minfoActualizacionPrecios.TipoActualizacion = MyBase.CargarTipoActualizacion()
            minfoActualizacionPrecios.TipoAccion = CargarTipoAccion()
            Select Case minfoActualizacionPrecios.TipoAccion
                Case enumTipoAccionPreciosObras.IncrementarDecrementarPrecio
                    If txtIncrementar.Value > 0 Then
                        minfoActualizacionPrecios.Porcentaje = txtIncrementar.Value
                        minfoActualizacionPrecios.Incrementar = True
                    ElseIf txtDecrementar.Value > 0 Then
                        minfoActualizacionPrecios.Porcentaje = txtDecrementar.Value
                        minfoActualizacionPrecios.Incrementar = False
                    End If
                Case enumTipoAccionPreciosObras.RecuperarPrecioCoste
                    minfoActualizacionPrecios.Coste = CInt(cbPrecioCoste.Value)
                    minfoActualizacionPrecios.IDPresupCoste = AdvPresupCoste.Value
                Case enumTipoAccionPreciosObras.RecuperarPrecioVenta
                    minfoActualizacionPrecios.Venta = CInt(cbPrecioVenta.Value)
                    minfoActualizacionPrecios.IDPresupVenta = AdvPresupVenta.Value
                    minfoActualizacionPrecios.IDTarifa = advTarifa.Value
                Case enumTipoAccionPreciosObras.AplicarMargen
                    minfoActualizacionPrecios.Margen = txtMargen.Value
            End Select

            Return minfoActualizacionPrecios
        End If
        Return Nothing
    End Function

    Private Function CargarTipoAccion() As enumTipoAccionPreciosObras
        If txtIncrementar.Value > 0 Or txtDecrementar.Value > 0 Then
            Return enumTipoAccionPreciosObras.IncrementarDecrementarPrecio
        ElseIf Not cbPrecioCoste.SelectedIndex = -1 Then
            Return enumTipoAccionPreciosObras.RecuperarPrecioCoste
        ElseIf Not cbPrecioVenta.SelectedIndex = -1 Then
            Return enumTipoAccionPreciosObras.RecuperarPrecioVenta
        ElseIf txtMargen.Value >= 0 Then
            Return enumTipoAccionPreciosObras.AplicarMargen
        End If
    End Function

    Protected Overrides Function ValidarCampos() As Boolean
        If txtIncrementar.Value = 0 AndAlso txtDecrementar.Value = 0 AndAlso txtMargen.Value = 0 AndAlso cbPrecioCoste.SelectedIndex = -1 AndAlso cbPrecioVenta.SelectedIndex = -1 Then
            If ExpertisApp.GenerateMessage("El margen con el que actualizará los precios es cero. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Return True
            Else
                'ExpertisApp.GenerateMessage("Para la actualización de los precios se debe elegir una acción.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
        ElseIf txtIncrementar.Value <> 0 And (txtDecrementar.Value <> 0 Or txtMargen.Value <> 0 Or Not cbPrecioCoste.SelectedIndex = -1 Or Not cbPrecioCoste.SelectedIndex = -1 Or Not cbPrecioVenta.SelectedIndex = -1) Or txtDecrementar.Value <> 0 And (txtIncrementar.Value <> 0 Or txtMargen.Value <> 0 Or Not cbPrecioCoste.SelectedIndex = -1 Or Not cbPrecioVenta.SelectedIndex = -1) Or Not cbPrecioCoste.SelectedIndex = -1 And Not cbPrecioVenta.SelectedIndex = -1 Then
            ExpertisApp.GenerateMessage("La actualización deberá realizarse en base a un único criterio.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf Not cbPrecioVenta.SelectedIndex = -1 AndAlso cbPrecioVenta.SelectedItem(2).Equals(1) AndAlso Length(advTarifa.Text) = 0 Then
            ExpertisApp.GenerateMessage("Para que la actualización sea posible, deberá elegir un tipo de tarifa que determinará el precio de venta.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf Not cbPrecioCoste.SelectedIndex = -1 Then
            If rbVentaMargen.Checked Or rbMargenVenta.Checked Then
                ExpertisApp.GenerateMessage("Si la acción elegida es el 'Precio de coste' la actualización debera hacerse sobre esta misma.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            Else
                Return True
            End If
        ElseIf Not cbPrecioVenta.SelectedIndex = -1 Then
            If rbCosteVenta.Checked Or rbCosteMargen.Checked Or rbMargenVenta.Checked Then
                ExpertisApp.GenerateMessage("Si la acción elegida es el 'Precio de Venta' la actualización deberá hacerse sobre esta misma.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            Else
                Return True
            End If
        ElseIf txtIncrementar.Value < 0 Then
            ExpertisApp.GenerateMessage("El incremento deberá ser un número natural.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf txtDecrementar.Value < 0 Then
            ExpertisApp.GenerateMessage("El decremento deberá ser un número natural.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf txtMargen.Value < 0 Then
            ExpertisApp.GenerateMessage("El margen deberá ser un número natural.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf txtMargen.Value > 0 Then
            If Not rbMargenVenta.Checked Then
                ExpertisApp.GenerateMessage("Si la acción elegida es recalcular el precio venta sobre el margen establecido, deberá establecer un margen .", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function

#Region "Respuesta a eventos"

#Region "Respuesta a eventos del Formulario"

    Private Sub frmActualizarPrecios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarDatos()
        CargarEnumerados()
    End Sub

    Private Sub CargarEnumerados()
        cbPrecioCoste.DataSource = New EnumData("enumOMPrecioCoste")
        cbPrecioVenta.DataSource = New EnumData("enumOMPrecioVenta")
    End Sub

    Private Sub cbPrecioCoste_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPrecioCoste.ValueChanged
        If cbPrecioCoste.Value = CInt(enumOMPrecioCoste.pcPresup) Then
            AdvPresupCoste.Enabled = True
        Else
            AdvPresupCoste.Enabled = False
            AdvPresupCoste.Clear()
        End If
    End Sub

    Private Sub cbPrecioVenta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPrecioVenta.ValueChanged
        Select Case CType(cbPrecioVenta.Value, enumOMPrecioVenta)
            Case enumOMPrecioVenta.pvTarifa
                advTarifa.Enabled = True
                AdvPresupVenta.Enabled = False
                AdvPresupVenta.Clear()
            Case enumOMPrecioVenta.pvPresup
                AdvPresupVenta.Enabled = True
                advTarifa.Enabled = False
                advTarifa.Clear()
            Case Else
                AdvPresupVenta.Enabled = False : advTarifa.Enabled = False
                AdvPresupVenta.Clear() : advTarifa.Clear()
        End Select
    End Sub

#End Region

#End Region

    Private Sub rbCosteVenta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCosteVenta.CheckedChanged
        lblMargen.Enabled = False : txtMargen.Enabled = False
        Me.lblPrecioCoste.Enabled = True : Me.cbPrecioCoste.Enabled = True
        Me.lblPrecioVenta.Enabled = False : Me.cbPrecioVenta.Enabled = False
        Me.advTarifa.Enabled = False
    End Sub

    Private Sub rbVentaMargen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbVentaMargen.CheckedChanged
        lblMargen.Enabled = False : txtMargen.Enabled = False
        Me.lblPrecioCoste.Enabled = False : Me.cbPrecioCoste.Enabled = False
        Me.lblPrecioVenta.Enabled = True : Me.cbPrecioVenta.Enabled = True
        Me.advTarifa.Enabled = False : Me.AdvPresupCoste.Enabled = False
        Me.AdvPresupVenta.Enabled = False
    End Sub

    Private Sub rbCosteMargen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCosteMargen.CheckedChanged
        lblMargen.Enabled = False : txtMargen.Enabled = False
        Me.lblPrecioCoste.Enabled = True : Me.cbPrecioCoste.Enabled = True
        Me.lblPrecioVenta.Enabled = False : Me.cbPrecioVenta.Enabled = False
        Me.advTarifa.Enabled = False : Me.AdvPresupVenta.Enabled = False
        Me.AdvPresupCoste.Enabled = False
    End Sub

    Private Sub rbMargenVenta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMargenVenta.CheckedChanged
        lblMargen.Enabled = True : txtMargen.Enabled = True
        Me.lblPrecioCoste.Enabled = False : Me.cbPrecioCoste.Enabled = False
        Me.lblPrecioVenta.Enabled = False : Me.cbPrecioVenta.Enabled = False
        Me.advTarifa.Enabled = False : Me.AdvPresupCoste.Enabled = False
        Me.AdvPresupVenta.Enabled = False
    End Sub

End Class