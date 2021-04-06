Module CheckPassword
    Public Function Proverka_NULL(ByVal TextField As TextBox) As Boolean
        If TextField.Text = "" Then
            Proverka_NULL = False
            MsgBox("Введите пароль!", vbCritical, "Ошибка")
            Exit Function
        End If
        Proverka_NULL = True
    End Function
End Module
