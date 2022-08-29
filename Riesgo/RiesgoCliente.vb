Public Class RiesgoCliente

    Public Overridable Sub OpenForm(ByVal StrIdCliente As String)
        If Length(StrIdCliente) > 0 Then
            Dim ClsClie As New Cliente
            Dim DtClie As DataTable = ClsClie.SelOnPrimaryKey(StrIdCliente)
            If Not DtClie Is Nothing AndAlso DtClie.Rows.Count > 0 Then
                Dim FrmAnalisis As New FrmAnalisisRiesgo
                'Dim FrmAnalisisAlq As New FrmAnalisisRiesgoAlquiler
                'Dim ClsParam As New Parametro
                'If Not ClsParam.AplicacionGestionAlquiler Then
                FrmAnalisis.IdCliente = StrIdCliente
                FrmAnalisis.DescCliente = DtClie.Rows(0)("DescCliente")
                FrmAnalisis.RiesgoConcedido = DtClie.Rows(0)("RiesgoConcedido")
                FrmAnalisis.ShowDialog()
                FrmAnalisis.Dispose()
                'Else
                '    FrmAnalisisAlq.IdCliente = StrIdCliente
                '    FrmAnalisisAlq.DescCliente = DtClie.Rows(0)("DescCliente")
                '    FrmAnalisisAlq.RiesgoConcedido = DtClie.Rows(0)("RiesgoConcedido")
                '    FrmAnalisisAlq.ShowDialog()
                '    FrmAnalisisAlq.Dispose()
                'End If
            End If
        End If
    End Sub

    Public Function bTieneRiesgo(ByVal StrIdCliente As String) As Boolean
        If Length(StrIdCliente & String.Empty) > 0 Then
            Dim ClsClie As New Cliente
            Dim DtClie As DataTable = ClsClie.SelOnPrimaryKey(StrIdCliente)
            If Not DtClie Is Nothing AndAlso DtClie.Rows.Count > 0 Then
                bTieneRiesgo = DtClie.Rows(0)("Riesgo")
            End If
        End If
    End Function
    Public Function CompruebaRiesgo(ByVal strIDCliente As String, Optional ByVal Riesgo As Negocio.RiesgoCliente = Nothing) As Negocio.RiesgoCliente
        If bTieneRiesgo(strIDCliente) Then
            Dim StRiesgo As New Cliente.DataRiesgoCliente
            StRiesgo.IDCliente = strIDCliente
            If IsNothing(Riesgo) Then Riesgo = ExpertisApp.ExecuteTask(Of Cliente.DataRiesgoCliente, Negocio.RiesgoCliente)(AddressOf Cliente.ObtenerRiesgoCliente, StRiesgo)
            If Not IsNothing(Riesgo) Then
                If Riesgo.SuperaRiesgo Then
                    If ExpertisApp.GenerateMessage("El cliente ha superado su riesgo permitido, ¿Desea ver su desglose?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                        Dim frmRiesgo As New CommonClasses.FrmAnalisisRiesgo
                        frmRiesgo.IdCliente = Riesgo.IDCliente
                        frmRiesgo.DescCliente = Riesgo.DescCliente
                        frmRiesgo.RiesgoConcedido = Riesgo.RiesgoConcedido
                        frmRiesgo.ShowDialog()
                    End If
                End If
            End If
        End If
        Return Riesgo
    End Function

End Class