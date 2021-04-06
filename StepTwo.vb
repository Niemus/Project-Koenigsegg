Public Class StepTwo
    Dim a, b, c, j, k, t, g, s As Integer

    Private Sub ChromeButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton2.Click

        Home.Show()
        Me.Hide()

    End Sub

    Private Sub ChromeButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton3.Click

        MessageBox.Show("Цена за одну деталь: 5000 + цена добавки (если выбрано)(руб.)", "Условия")

        MessageBox.Show("Время покраски одной детали: 2 (дн.)", "Условия")

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem = "Черный" Then
            TextBox1.ReadOnly = True
        End If
        If ComboBox2.SelectedItem = "Белый" Then
            TextBox1.ReadOnly = True
        End If
        If ComboBox2.SelectedItem = "Синий" Then
            TextBox1.ReadOnly = True
        End If
        If ComboBox2.SelectedItem = "Желтый" Then
            TextBox1.ReadOnly = True
        End If
        If ComboBox2.SelectedItem = "Красный" Then
            TextBox1.ReadOnly = True
        End If
        If ComboBox2.SelectedItem = "Розовый" Then
            TextBox1.ReadOnly = True
        End If
        If ComboBox2.SelectedItem = "Зеленый" Then
            TextBox1.ReadOnly = True
        End If
        If ComboBox2.SelectedItem = "Оранжевый" Then
            TextBox1.ReadOnly = True
        End If
        If ComboBox2.SelectedItem = "Другой (Ваш цвет)" Then
            TextBox1.ReadOnly = False
        End If
    End Sub

    Private Sub ChromeButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton1.Click

        MessageBox.Show("На этом шаге вы должны выбрать желаемые услуги для изменения вашего авто! Цену и кол-во дней на выполнение заказа вы увидите на следующей странице.", "Помощь")

    End Sub

    Private Sub ChromeRadioButton1_CheckedChanged(ByVal sender As System.Object) Handles ChromeRadioButton1.CheckedChanged
        j = 0
        a = 0
        If ChromeRadioButton1.Checked = True Then
            a = a + 5000
            j = j + 2
            TextBox2.Text = a
            TextBox5.Text = j
        End If

    End Sub

    Private Sub ChromeRadioButton2_CheckedChanged(ByVal sender As System.Object) Handles ChromeRadioButton2.CheckedChanged
        j = 0
        a = 0
        If ChromeRadioButton2.Checked = True Then
            a = a + 5000
            j = j + 2
            TextBox2.Text = a
            TextBox5.Text = j
        End If
    End Sub

    Private Sub ChromeRadioButton8_CheckedChanged(ByVal sender As System.Object) Handles ChromeRadioButton8.CheckedChanged
        b = 0
        If ChromeRadioButton8.Checked = True Then
            b = b + 1500
            TextBox2.Text = (b + a)
        End If
    End Sub

    Private Sub ChromeRadioButton7_CheckedChanged(ByVal sender As System.Object) Handles ChromeRadioButton7.CheckedChanged
        b = 0
        If ChromeRadioButton7.Checked = True Then
            b = b + 2000
            TextBox2.Text = (b + a)
        End If
    End Sub

    Private Sub ChromeRadioButton6_CheckedChanged(ByVal sender As System.Object) Handles ChromeRadioButton6.CheckedChanged
        b = 0
        If ChromeRadioButton6.Checked = True Then
            b = b + 2500
            TextBox2.Text = (b + a)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = 1 Then
            TextBox2.Text = TextBox2.Text * 1
        End If
        If ComboBox1.SelectedItem = 2 Then
            TextBox5.Text = TextBox5.Text * 2
            TextBox2.Text = TextBox2.Text * 2
        End If
        If ComboBox1.SelectedItem = 3 Then
            TextBox5.Text = TextBox5.Text * 3
            TextBox2.Text = TextBox2.Text * 3
        End If
        If ComboBox1.SelectedItem = 4 Then
            TextBox5.Text = TextBox5.Text * 4
            TextBox2.Text = TextBox2.Text * 4
        End If
        If ComboBox1.SelectedItem = 5 Then
            TextBox5.Text = TextBox5.Text * 5
            TextBox2.Text = TextBox2.Text * 5
        End If
        If ComboBox1.SelectedItem = 6 Then
            TextBox5.Text = TextBox5.Text * 6
            TextBox2.Text = TextBox2.Text * 6
        End If
        If ComboBox1.SelectedItem = 7 Then
            TextBox5.Text = TextBox5.Text * 7
            TextBox2.Text = TextBox2.Text * 7
        End If
        If ComboBox1.SelectedItem = 8 Then
            TextBox5.Text = TextBox5.Text * 8
            TextBox2.Text = TextBox2.Text * 8
        End If
        If ComboBox1.SelectedItem = 9 Then
            TextBox5.Text = TextBox5.Text * 9
            TextBox2.Text = TextBox2.Text * 9
        End If
        If ComboBox1.SelectedItem = 10 Then
            TextBox5.Text = TextBox5.Text * 10
            TextBox2.Text = TextBox2.Text * 10
        End If
        If ComboBox1.SelectedItem = 11 Then
            TextBox5.Text = TextBox5.Text * 11
            TextBox2.Text = TextBox2.Text * 11
        End If
        If ComboBox1.SelectedItem = 12 Then
            TextBox5.Text = TextBox5.Text * 12
            TextBox2.Text = TextBox2.Text * 12
        End If
        If ComboBox1.SelectedItem = 13 Then
            TextBox5.Text = TextBox5.Text * 13
            TextBox2.Text = TextBox2.Text * 13
        End If

    End Sub

    Private Sub ChromeRadioButton3_CheckedChanged(ByVal sender As System.Object) Handles ChromeRadioButton3.CheckedChanged
        j = 0
        a = 0
        If ChromeRadioButton3.Checked = True Then
            a = a + 5000
            j = j + 2
            TextBox2.Text = a
            TextBox5.Text = j
        End If
    End Sub

    Private Sub ChromeRadioButton4_CheckedChanged(ByVal sender As System.Object) Handles ChromeRadioButton4.CheckedChanged
        j = 0
        a = 0
        If ChromeRadioButton4.Checked = True Then
            a = a + 5000
            j = j + 2
            TextBox2.Text = a
            TextBox5.Text = j
        End If
    End Sub

    Private Sub ChromeRadioButton5_CheckedChanged(ByVal sender As System.Object) Handles ChromeRadioButton5.CheckedChanged

        If ChromeRadioButton5.Checked = True Then
            c = 0
            c = c + 700
            TextBox2.Text = (c + TextBox2.Text)
        End If
    End Sub

    Private Sub ChromeRadioButton9_CheckedChanged(ByVal sender As System.Object) Handles ChromeRadioButton9.CheckedChanged

        If ChromeRadioButton9.Checked = True Then
            c = 0
            c = c + 1000
            TextBox2.Text = (c + TextBox2.Text)
        End If
    End Sub

    Private Sub ChromeButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton4.Click
        MessageBox.Show("Цена локальной: 700 (руб.)", "Условия")
        MessageBox.Show("Цена глубокой: 1000 (руб.)", "Условия")
    End Sub

    Private Sub ChromeButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton5.Click
        If TextBox3.Text = "" Then
            TextBox3.Text = "0"
        End If
        k = 0
        k = TextBox3.Text
        TextBox2.Text = TextBox2.Text + k

    End Sub

    Private Sub ChromeButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton6.Click
        If TextBox4.Text = "" Then
            TextBox4.Text = "0"
        End If
        t = 0
        t = TextBox4.Text
        TextBox5.Text = TextBox5.Text + t
    End Sub

    Private Sub ChromeButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton7.Click
        MessageBox.Show("Замена деталей (1000 руб. + цена детали)")
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If TextBox2.Text = "" Then
            TextBox2.Text = "0"
            TextBox2.Text = 0
        End If

        If ComboBox3.SelectedItem = "Замена капота" Then
            g = 1000
            TextBox2.Text = TextBox2.Text + g
        End If
        If ComboBox3.SelectedItem = "Замена правой задней двери" Then
            g = 1000
            TextBox2.Text = TextBox2.Text + g
        End If
        If ComboBox3.SelectedItem = "Замена левой передней двери" Then
            g = 1000
            TextBox2.Text = TextBox2.Text + g
        End If
        If ComboBox3.SelectedItem = "Замена левой задней двери" Then
            g = 1000
            TextBox2.Text = TextBox2.Text + g
        End If
        If ComboBox3.SelectedItem = "Замена крышки багажника" Then
            g = 1000
            TextBox2.Text = TextBox2.Text + g
        End If
        If ComboBox3.SelectedItem = "Замена левого переднего крыла" Then
            g = 1000
            TextBox2.Text = TextBox2.Text + g
        End If
        If ComboBox3.SelectedItem = "Замена левого заднего крыла" Then
            g = 1000
            TextBox2.Text = TextBox2.Text + g
        End If
        If ComboBox3.SelectedItem = "Замена правого переднего крыла" Then
            g = 1000
            TextBox2.Text = TextBox2.Text + g
        End If
        If ComboBox3.SelectedItem = "Замена правого заднего крыла" Then
            g = 1000
            TextBox2.Text = TextBox2.Text + g
        End If
        If ComboBox3.SelectedItem = "Замена переднего бампера" Then
            g = 1000
            TextBox2.Text = TextBox2.Text + g
        End If
        If ComboBox3.SelectedItem = "Замена заднего бампера" Then
            g = 1000
            TextBox2.Text = TextBox2.Text + g
        End If

    End Sub

    Private Sub ChromeButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton8.Click
        s = 0
        s = s + TextBox6.Text
        TextBox2.Text = TextBox2.Text + s
    End Sub

    Private Sub ChromeButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton9.Click
        StepThree.Show()
        Me.Hide()
    End Sub
End Class