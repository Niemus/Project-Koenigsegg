Public Class Home

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("Открываем ссылку...", "Сообщение")
        System.Diagnostics.Process.Start("http://niemus.tilda.ws/")
        LinkLabel1.LinkVisited = True
    End Sub

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub ChromeButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton4.Click
        StepOne.Show()
        Me.Hide()
    End Sub

    Private Sub ChromeButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton3.Click
        StepTwo.Show()
        Me.Hide()
    End Sub

    Private Sub ChromeButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton1.Click
        StepOne.Show()
        Me.Hide()
    End Sub

    Private Sub ChromeButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton2.Click
        AutoDataset.Show()
        Me.Hide()
    End Sub

    Private Sub ChromeButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton5.Click
        AutoDataset2.Show()
        Me.Hide()
    End Sub
End Class