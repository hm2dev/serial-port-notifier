<Serializable>
Public Structure CustomPortName
    Public Port As String
    Public CustomName As String

    Public Shared Function FromKVList(l As List(Of KeyValuePair(Of String, String))) As List(Of CustomPortName)
        Dim newList As New List(Of CustomPortName)

        For Each item In l
            newList.Add(New CustomPortName With {.Port = item.Key, .CustomName = item.Value})
        Next

        Return newList
    End Function
End Structure