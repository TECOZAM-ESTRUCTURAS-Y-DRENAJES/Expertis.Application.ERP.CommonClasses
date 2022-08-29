Public Class frmActualizarPreciosGeneral
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
    Friend WithEvents AdvPresup As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblPresup As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.LblPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvPresup = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.pnlAcciones.SuspendLayout()
        Me.pnlValidar.SuspendLayout()
        Me.frmAcciones.SuspendLayout()
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
        'pnlAcciones
        '
        Me.pnlAcciones.Size = New System.Drawing.Size(520, 110)
        '
        'pnlValidar
        '
        Me.pnlValidar.Location = New System.Drawing.Point(0, 246)
        '
        'frmAcciones
        '
        Me.frmAcciones.Controls.Add(Me.AdvPresup)
        Me.frmAcciones.Controls.Add(Me.LblPresup)
        Me.frmAcciones.Size = New System.Drawing.Size(504, 104)
        Me.frmAcciones.Controls.SetChildIndex(Me.LblPresup, 0)
        Me.frmAcciones.Controls.SetChildIndex(Me.AdvPresup, 0)
        Me.frmAcciones.Controls.SetChildIndex(Me.lblIncrementar, 0)
        Me.frmAcciones.Controls.SetChildIndex(Me.lblDecrementar, 0)
        Me.frmAcciones.Controls.SetChildIndex(Me.txtIncrementar, 0)
        Me.frmAcciones.Controls.SetChildIndex(Me.txtDecrementar, 0)
        Me.frmAcciones.Controls.SetChildIndex(Me.lblMargen, 0)
        Me.frmAcciones.Controls.SetChildIndex(Me.txtMargen, 0)
        '
        'LblPresup
        '
        Me.LblPresup.Location = New System.Drawing.Point(16, 77)
        Me.LblPresup.Name = "LblPresup"
        Me.LblPresup.Size = New System.Drawing.Size(87, 13)
        Me.LblPresup.TabIndex = 19
        Me.LblPresup.Text = "Presup. Coste"
        Me.LblPresup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvPresup
        '
        Me.AdvPresup.DisabledBackColor = System.Drawing.Color.White
        Me.AdvPresup.DisplayField = "NumPresup"
        Me.AdvPresup.EntityName = "ObraPresupCabecera"
        Me.AdvPresup.Location = New System.Drawing.Point(117, 72)
        Me.AdvPresup.Name = "AdvPresup"
        Me.AdvPresup.SecondaryDataFields = "IDPresup"
        Me.AdvPresup.Size = New System.Drawing.Size(128, 23)
        Me.AdvPresup.TabIndex = 20
        '
        'frmActualizarPreciosGeneral
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(520, 294)
        Me.Name = "frmActualizarPreciosGeneral"
        Me.pnlAcciones.ResumeLayout(False)
        Me.pnlValidar.ResumeLayout(False)
        Me.frmAcciones.ResumeLayout(False)
        Me.frmAcciones.PerformLayout()
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
                    minfoActualizacionPrecios.IDPresupCoste = AdvPresup.Value
                Case enumTipoAccionPreciosObras.RecuperarPrecioVenta
                    minfoActualizacionPrecios.IDPresupVenta = AdvPresup.Value
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
        ElseIf Length(AdvPresup.Value) > 0 AndAlso (Me.rbCosteMargen.Checked OrElse Me.rbCosteVenta.Checked) Then
            Return enumTipoAccionPreciosObras.RecuperarPrecioCoste
        ElseIf Length(AdvPresup.Value) > 0 AndAlso (Me.rbMargenVenta.Checked OrElse Me.rbVentaMargen.Checked) Then
            Return enumTipoAccionPreciosObras.RecuperarPrecioVenta
        ElseIf txtMargen.Value >= 0 Then
            Return enumTipoAccionPreciosObras.AplicarMargen
        End If
    End Function

    Protected Overrides Function ValidarCampos() As Boolean
        If txtIncrementar.Value = 0 AndAlso txtDecrementar.Value = 0 AndAlso txtMargen.Value = 0 Then
            If ExpertisApp.GenerateMessage("El margen con el que actualizará los precios es cero. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Return True
            Else
                Return False
            End If
        ElseIf txtIncrementar.Value <> 0 And (txtDecrementar.Value <> 0 Or txtMargen.Value <> 0) Or txtDecrementar.Value <> 0 And (txtIncrementar.Value <> 0 Or txtMargen.Value <> 0) Then
            ExpertisApp.GenerateMessage("La actualización deberá realizarse en base a un único criterio.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
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
                ExpertisApp.GenerateMessage("Si la acción elegida es recalcular el precio venta sobre el margen establecido, deberá establecer un margen.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function

    Private Sub rbCosteVenta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCosteVenta.CheckedChanged, rbCosteMargen.CheckedChanged
        Me.LblPresup.Text = "Presup. Coste"
    End Sub

    Private Sub rbVentaMargen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbVentaMargen.CheckedChanged, rbMargenVenta.CheckedChanged
        Me.LblPresup.Text = "Presup. Venta"
    End Sub

End Class