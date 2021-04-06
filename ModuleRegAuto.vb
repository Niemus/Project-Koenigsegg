Imports System.Data.OleDb
Module ModuleRegAuto

    Public Function RegAuto()

        Dim FIO As String
        Dim Color As String
        Dim Power As String
        Dim NomDv As String
        Dim RegZnak As String
        Dim Adress As String
        Dim MarkMod As String
        Dim Year As String
        Dim VIN As String
        Dim NomKuz As String
        Dim EkClass As String
        Dim TypeDvig As String
        Dim TypeTC As String

        FIO = StepOne.TextBox1.Text
        Color = StepOne.TextBox4.Text
        Power = StepOne.TextBox8.Text
        NomDv = StepOne.TextBox7.Text
        RegZnak = StepOne.TextBox2.Text
        Adress = StepOne.TextBox5.Text
        MarkMod = StepOne.TextBox10.Text
        Year = StepOne.TextBox9.Text
        VIN = StepOne.TextBox3.Text
        NomKuz = StepOne.TextBox6.Text
        EkClass = StepOne.TextBox11.Text
        TypeDvig = StepOne.TextBox13.Text
        TypeTC = StepOne.TextBox12.Text

        Dim SozdOb As String
        'Создание объекта и передача ему строки соединения
        Dim Connection = New OleDbConnection("Provider=Microsoft." & "Jet.OLEDB.4.0;Data Source=РегистрацияАвто1(1).mdb")
        Connection.Open()
        'создание объекта и присваивание ему SQL запроса
        SozdOb = "insert into [Регистрация авто](" & " [Регистрационный знак],[Идентификационный номер машины (VIN)], [Цвет авто], [ФИО владельца], [Адрес владельца], [Номер кузова], [Номер двигателя], [Мощность двигателя], [Год изготовления], [Марка и модель авто], [Экологический класс], [Тип двигателя], [Тип ТС]) values ('" & RegZnak & "','" & VIN & "','" & Color & "','" & FIO & "','" & Adress & "','" & NomKuz & "','" & NomDv & "','" & Power & "','" & Year & "','" & MarkMod & "','" & EkClass & "','" & TypeDvig & "','" & TypeTC & "')"
        'создание объекта и передача ему SQL команды
        Dim command = New OleDbCommand(SozdOb)
        command.Connection = Connection
        Try
            'Выполнение SQL команды
            command.ExecuteNonQuery()
            MessageBox.Show("Данные занесены в базу!", "Запись добавленна.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Connection.Close()

    End Function


End Module