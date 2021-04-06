Public Class StepOne

    Private Sub ChromeButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton3.Click
        MessageBox.Show("На этой странице вы должны добавить свое авто в базу данных. Заполните поля и нажмите на кнопку <Добавить в базу!>", "Помощь")
    End Sub

    Private Sub ChromeButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton2.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub ChromeButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton1.Click
        ModuleRegAuto.RegAuto()
    End Sub

    Private Sub ChromeButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton4.Click
        StepTwo.Show()
        Me.Hide()
    End Sub

    Private Sub ChromeThemeContainer1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeThemeContainer1.Click

    End Sub
End Class