Module General

    Public Sub GenerarExcepcion(ByVal Message As String)
        Dim filePath As String = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Log.txt")
        Using writer As New System.IO.StreamWriter(filePath, True)
            writer.WriteLine(Date.Now & Space(1) & Message)
        End Using
        Throw New Exception(Message)
    End Sub

End Module
