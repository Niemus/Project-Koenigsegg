Public Class Login

    Private Sub ChromeButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then                'Устанавливаем пароль для входа.
            Home.Show()                                                                                           'Показываем главную форму.
            Me.Hide()                                                                                                    'Закрываем текущую форму.                                           'Иначе устанавливаем текст, что пароль не правильный.
        End If
        Check.Universal_Proverka(TextBox1)
        CheckPassword.Proverka_NULL(TextBox2)
    End Sub
End Class