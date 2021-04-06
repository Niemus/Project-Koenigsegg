Public Class AutoDataset2

    Private Sub AutoDataset2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "РегистрацияАвто2DataSet.РегистрацияАвто2". При необходимости она может быть перемещена или удалена.
        Me.РегистрацияАвто2TableAdapter.Fill(Me.РегистрацияАвто2DataSet.РегистрацияАвто2)

        Dim connection As New OleDb.OleDbConnection("Provider=Microsoft." & "Jet.OLEDB.4.0;Data Source=РегистрацияАвто2.mdb")
        connection.Open()
        'создание объекта и передача ему SQL-командымии
        Dim command As New System.Data.OleDb.OleDbCommand("Select [Регистрационный знак], [VIN], [Прежний цвет авто], [ФИО владельца], [Адрес владельца], [Номер кузова], [Номер двигателя], [Мощность двигателя], [Год изготовления], [Марка и модель авто], [Экологический класс], [Тип двигателя], [Тип ТС], [Новый цвет авто], [Отрихтованные детали], [Добавка в краску], [Отполированные детали], [Замененные детали] From [РегистрацияАвто2]", connection)
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
        datatable.Columns.Add(datareader.GetName(13))
        datatable.Columns.Add(datareader.GetName(14))
        datatable.Columns.Add(datareader.GetName(15))
        datatable.Columns.Add(datareader.GetName(16))
        datatable.Columns.Add(datareader.GetName(17))

        While datareader.Read() = True
            'Заполняем ячейки таблицы
            datatable.Rows.Add(New String() {datareader.GetValue(0), datareader.GetValue(1), datareader.GetValue(2), datareader.GetValue(3), datareader.GetValue(4), datareader.GetValue(5), datareader.GetValue(6), datareader.GetValue(7), datareader.GetValue(8), datareader.GetValue(9), datareader.GetValue(10), datareader.GetValue(11), datareader.GetValue(12), datareader.GetValue(13), datareader.GetValue(14), datareader.GetValue(15), datareader.GetValue(16), datareader.GetValue(17)})
        End While
        datareader.Close() : connection.Close()
        DataGridView1.DataSource = datatable

    End Sub

    Private Sub ChromeButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton1.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub ChromeButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeButton2.Click
        Dim Con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=РегистрацияАвто2.mdb; ")
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM [РегистрацияАвто2]", Con)
        da.Fill(ds, "РегистрацияАвто2")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "РегистрацияАвто2"
        'DataGridView1.Columns("Код").Visible = False
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class