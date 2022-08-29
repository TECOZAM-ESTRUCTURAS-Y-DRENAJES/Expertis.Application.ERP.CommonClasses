Public Class GetQueryMultipleDB

    Public Function Execute(ByVal data As BEGetQueryMultipleDB.DataGetQueryMultipleDB) As DataTable

        Dim obj As New BEGetQueryMultipleDB
        Return obj.Execute(data)

    End Function

End Class