Public Class LogProcesos

    Private Enum IconIndex
        ProcessOK = 0
        ProcessNotOK = 1
    End Enum

    Public Property DataSource() As DataTable
        Get
            Return Grid1.DataSource
        End Get
        Set(ByVal value As DataTable)
            Grid1.DataSource = value
        End Set
    End Property

    Private Sub Grid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.Click
        With Grid1
            Dim c As GridEXColumn = .ColumnFromPoint()
            If Not IsNothing(c) Then
                Dim hit As GridArea = .HitTest()
                If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                    Select Case c.Key
                        Case "LocationError", "Message"
                            Dim frm As New FormularioTexto
                            frm.Texto = .Value(c.Key) & String.Empty
                            frm.SoloLectura = True
                            frm.ShowDialog()
                    End Select
                End If
            End If
        End With
    End Sub

    Private Sub Grid1_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid1.FormattingRow
        If Length(e.Row.Cells("LocationError").Value) = 0 Then
            e.Row.Cells("Icon").ImageIndex = IconIndex.ProcessOK
        Else
            e.Row.Cells("Icon").ImageIndex = IconIndex.ProcessNotOK
        End If
    End Sub


    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.Close()
    End Sub

End Class