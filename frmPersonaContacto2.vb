Public Class frmPersonaContacto2
    Inherits Solmicro.Expertis.Engine.UI.FormBase
    Public Sub New()
        MyBase.New()
        'El Diseñador de Windows Forms requiere esta llamada.
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        InitializeComponent()

    End Sub

    Private Sub Grid1_AddingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Grid1.AddingRecord
        'Dim contador As String
        'Dim opc As New ObraPersonaContacto2
        'contador = opc.devuelveIDPersona()

        'Grid1.SetValue("IDPersona", contador)

        With Grid1
            If .Row = Grid.newTopRowPosition Then
                If Length(.Value("IDPersona")) = 0 AndAlso Length(.Value("Nombre")) = 0 Then
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("Debe indicar al menos el ID de la Persona,o el Nombre.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
        End With
        Grid1.AllowAddNew = InheritableBoolean.False
        Button1.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dt As New DataTable
        dt = Grid1.DataSource
        Dim dr As DataRow = dt.Rows(dt.Rows.Count - 1)

        Dim opc As New ObraPersonaContacto2
        opc.NuevaPersonaContacto(dr)
        Grid1.AllowAddNew = InheritableBoolean.True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Grid1_CellValueChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid1.CellValueChanged
        Dim contador As String
        Dim opc As New ObraPersonaContacto2
        contador = opc.devuelveIDPersona()

        Grid1.SetValue("IDPersona", contador)
    End Sub
End Class