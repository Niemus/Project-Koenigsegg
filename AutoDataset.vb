Public Class AutoDataset

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "_РегистрацияАвто1_1_DataSet.Регистрация_авто". При необходимости она может быть перемещена или удалена.
        Me.Регистрация_автоTableAdapter.Fill(Me._РегистрацияАвто1_1_DataSet.Регистрация_авто)

        Dim connection As New OleDb.OleDbConnection("Provider=Microsoft." & "Jet.OLEDB.4.0;Data Source=РегистрацияАвто1(1).mdb")
        connection.Open()
        'создание объекта и передача ему SQL-командымии
        Dim command As New System.Data.OleDb.OleDbCommand("Select [Регистрационный знак],[Идентификационный номер машины (VIN)], [Цвет авто], [ФИО владельца], [Адрес владельца], [Номер кузова], [Номер двигателя], [Мощность двигателя], [Год изготовления], [Марка и модель авто], [Экологический класс], [Тип двигателя], [Тип ТС] From [Регистрация авто]", connection)
        'Выполнение SQL-команды
        Dim datareader As OleDb.OleDbDataReader = command.ExecuteReader
        Dim datatable As New DataTable
        'Заполняем шапку таблицы
        datatable.Columns.Add(datareader.GetName(0))
        datatable.Columns.Add(datareader.GetName(1))
        datatable.Columns.Add(datareader.GetName(2))
        datatable.Columns.Add(datareader.GetName(3))
        datatable.Columns.Add(datareader.GetName(4))
        datatable.Columns.Add(datareader.GetName(5))
        datatable.Columns.Add(datareader.GetName(6))
        datatable.Columns.Add(datareader.GetName(7))
        datatable.Columns.Add(datareader.GetName(8))
        datatable.Columns.Add(datareader.GetName(9))
        datatable.Columns.Add(datareader.GetName(10))
        datatable.Columns.Add(datareader.GetName(11))
        datatable.Columns.Add(datareader.GetName(12))

        While datareader.Read() = True
            'Заполняем ячейки таблицы
            datatable.Rows.Add(New String() {datareader.GetValue(0), datareader.GetValue(1), datareader.GetValue(2), datareader.GetValue(3), datareader.GetValue(4), datareader.GetValue(5), datareader.GetValue(6), datareader.GetValue(7), datareader.GetValue(8), datareader.GetValue(9), datareader.GetValue(10), datareader.GetValue(11), datareader.GetValue(12)})
        End While
        datareader.Close() : connection.Close()
        DataGridView1.DataSource = datatable


    End Sub

    Private Sub ChromeButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton1.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub ChromeButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton2.Click
        Dim Con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=РегистрацияАвто1(1).mdb; ")
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM [Регистрация авто]", Con)
        da.Fill(ds, "Регистрация авто")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Регистрация авто"
    End Sub
End Class