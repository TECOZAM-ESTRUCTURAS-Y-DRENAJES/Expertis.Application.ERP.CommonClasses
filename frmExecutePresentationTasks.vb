Public Class frmExecutePresentationTasks

    Private Sub frmExecutePresentationTasks_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Hide()
        If IO.File.Exists(ExpertisApp.Path & "\Expertis.Tools.PresentationTasks.exe") Then
            Process.Start(ExpertisApp.Path & "\Expertis.Tools.PresentationTasks.exe")
        Else : ExpertisApp.GenerateMessage("No se ha encontrado el Programa Expertis.Tools.PresentationTasks.Exe en el directorio de Expertis.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        TimerClose.Enabled = True
    End Sub

    Private Sub TimerClose_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TimerClose.Tick
        Me.TimerClose.Enabled = False
        Me.Close()
    End Sub

End Class