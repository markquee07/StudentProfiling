Module generateValidationCode
    Public Function generatedCode() As String
        Dim len As Integer = 7
        Dim pool As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim rnd As New Random
        Dim result As String = ""

        Dim cc = 0
        While cc <= len
            result &= pool(rnd.Next(0, pool.Length))
            cc += 1
        End While

        Return result
    End Function

    Public Function generatedID() As String
        Dim len As Integer = 7
        Dim pool As String = "0123456789"
        Dim rnd As New Random
        Dim result As String = ""

        Dim cc = 0
        While cc <= len
            result &= pool(rnd.Next(0, pool.Length))
            cc += 1
        End While

        Return result
    End Function
End Module
