Public Class StockDataManager
    Public Shared Sub Copy(ByVal sourceArray As StockData(), ByRef destinationArray As StockData())
        If sourceArray.Length > 0 Then
            ReDim Preserve destinationArray(UBound(destinationArray) + sourceArray.Length)
            Array.Copy(sourceArray, 0, destinationArray, destinationArray.Length - sourceArray.Length, sourceArray.Length)
        End If
    End Sub

    Public Shared Sub Copy(ByVal data As StockData, ByRef destinationArray As StockData())
        If Not data Is Nothing Then
            ReDim Preserve destinationArray(UBound(destinationArray) + 1)
            destinationArray(UBound(destinationArray)) = data
        End If
    End Sub

    Public Shared Sub Copy(ByVal sourceArray As StockUpdateData(), ByRef destinationArray As StockUpdateData())
        If sourceArray.Length > 0 Then
            ReDim Preserve destinationArray(UBound(destinationArray) + sourceArray.Length)
            Array.Copy(sourceArray, 0, destinationArray, destinationArray.Length - sourceArray.Length, sourceArray.Length)
        End If
    End Sub

    Public Shared Sub Copy(ByVal data As StockUpdateData, ByRef destinationArray As StockUpdateData())
        If Not data Is Nothing Then
            ReDim Preserve destinationArray(UBound(destinationArray) + 1)
            destinationArray(UBound(destinationArray)) = data
        End If
    End Sub
End Class
