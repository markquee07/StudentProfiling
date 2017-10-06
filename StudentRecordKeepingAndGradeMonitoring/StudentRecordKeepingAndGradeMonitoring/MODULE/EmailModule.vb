Imports System.Net.Mail
Module EmailModule

    Public Sub sendMail(sender As String, reciever As String, subject As String, message As String, password As String)
        Dim EmailMessage As New MailMessage()
        Try
            EmailMessage.From = New MailAddress(sender)
            EmailMessage.To.Add(reciever)
            EmailMessage.Subject = subject
            EmailMessage.Body = message

            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential(sender, password)
            SMTP.Send(EmailMessage)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
