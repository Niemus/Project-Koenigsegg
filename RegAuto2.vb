Imports System.Data.OleDb

Module RegAuto2

    Public Function RegAuto2Fun()  'Функция для добавления в базу

        Dim FIO2 As String
        Dim Color2 As String
        Dim Power2 As String
        Dim NomDv2 As String
        Dim RegZnak2 As String
        Dim Adress2 As String
        Dim MarkMod2 As String
        Dim Year2 As String
        Dim VIN2 As String                    'Добавляем нужные переменные
        Dim NomKuz2 As String
        Dim EkClass2 As String
        Dim TypeDvig2 As String
        Dim TypeTC2 As String
        Dim ZamDet As String
        Dim OtpDet As String
        Dim OtrDet As String
        Dim NewColor As String
        Dim Dobavka As String

        FIO2 = StepThree.TextBox1.Text
        Color2 = StepThree.TextBox4.Text
        Power2 = StepThree.TextBox8.Text
        NomDv2 = StepThree.TextBox7.Text
        RegZnak2 = StepThree.TextBox2.Text
        Adress2 = StepThree.TextBox5.Text
        MarkMod2 = StepThree.TextBox10.Text
        Year2 = StepThree.TextBox9.Text
        VIN2 = StepThree.TextBox3.Text
        NomKuz2 = StepThree.TextBox6.Text              'Присваиваем переменным значения из текстовых полей
        EkClass2 = StepThree.TextBox11.Text
        TypeDvig2 = StepThree.TextBox13.Text
        TypeTC2 = StepThree.TextBox12.Text
        ZamDet = StepThree.TextBox18.Text
        OtpDet = StepThree.TextBox15.Text
        OtrDet = StepThree.TextBox16.Text
        NewColor = StepThree.TextBox14.Text
        Dobavka = StepThree.TextBox17.Text

        Dim SozdOb As String
        'Создание объекта и передача ему строки соединения
        Dim Connection = New OleDbConnection("Provider=Microsoft." & "Jet.OLEDB.4.0;Data Source=РегистрацияАвто2.mdb")
        Connection.Open()
        'создание объекта и присваивание ему SQL запроса
        SozdOb = "insert into [РегистрацияАвто2](" & " [Регистрационный знак], [VIN], [Прежний цвет авто], [ФИО владельца], [Адрес владельца], [Номер кузова], [Номер двигателя], [Мощность двигателя], [Год изготовления], [Марка и модель авто], [Экологический класс], [Тип двигателя], [Тип ТС], [Новый цвет авто], [Отрихтованные детали], [Добавка в краску], [Отполированные детали], [Замененные детали]) values ('" & RegZnak2 & "','" & VIN2 & "','" & Color2 & "','" & FIO2 & "','" & Adress2 & "','" & NomKuz2 & "','" & NomDv2 & "','" & Power2 & "','" & Year2 & "','" & MarkMod2 & "','" & EkClass2 & "','" & TypeDvig2 & "','" & TypeTC2 & "','" & NewColor & "','" & OtrDet & "','" & Dobavka & "','" & OtpDet & "','" & ZamDet & "')"
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
