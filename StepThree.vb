Public Class StepThree

    Private Sub ChromeButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton2.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub ChromeButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton4.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub ChromeButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton5.Click
        StepTwo.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("Перечислите все детали, которые были заменены через запятую.", "Важно!")
    End Sub

    Private Sub ChromeButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton3.Click
        MessageBox.Show("Чтобы зарегистрировать авто после изменения, просто заполните соответствующие поля!", "Помощь")
    End Sub

    Private Sub ChromeButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton1.Click
        RegAuto2.RegAuto2Fun()
        AutoDataset2.Show()
        Me.Hide()
    End Sub
End Class