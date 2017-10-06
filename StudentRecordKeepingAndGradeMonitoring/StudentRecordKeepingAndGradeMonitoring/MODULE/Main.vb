Module Main
    Public Sub main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        With GLOBAL_VARS.db
            .server = "localhost"
            .user = "root"
            .password = ""
            .db = "lgu_loboc"
            .port = "3306"

            If .connect() Then
                Dim l As New frmLogin
                l.ShowDialog()
            End If

        End With
    End Sub
End Module
