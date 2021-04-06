<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutoDataset2
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.КодDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.РегистрационныйЗнакDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПрежнийЦветАвтоDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ФИОВладельцаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.АдресВладельцаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.НомерКузоваDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.НомерДвигателяDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.МощностьДвигателяDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ГодИзготовленияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.МаркаИМодельАвтоDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ЭкологическийКлассDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ТипДвигателяDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ТипТСDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.НовыйЦветАвтоDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ОтрихтованныеДеталиDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ДобавкаВКраскуDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ОтполированныеДеталиDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ЗамененныеДеталиDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.РегистрацияАвто2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.РегистрацияАвто2DataSet = New Project_Автосервис_zyzy.РегистрацияАвто2DataSet
        Me.РегистрацияАвто2TableAdapter = New Project_Автосервис_zyzy.РегистрацияАвто2DataSetTableAdapters.РегистрацияАвто2TableAdapter
        Me.ChromeButton2 = New Project_Автосервис_zyzy.ChromeButton
        Me.ChromeButton1 = New Project_Автосервис_zyzy.ChromeButton
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РегистрацияАвто2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РегистрацияАвто2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn, Me.РегистрационныйЗнакDataGridViewTextBoxColumn, Me.VINDataGridViewTextBoxColumn, Me.ПрежнийЦветАвтоDataGridViewTextBoxColumn, Me.ФИОВладельцаDataGridViewTextBoxColumn, Me.АдресВладельцаDataGridViewTextBoxColumn, Me.НомерКузоваDataGridViewTextBoxColumn, Me.НомерДвигателяDataGridViewTextBoxColumn, Me.МощностьДвигателяDataGridViewTextBoxColumn, Me.ГодИзготовленияDataGridViewTextBoxColumn, Me.МаркаИМодельАвтоDataGridViewTextBoxColumn, Me.ЭкологическийКлассDataGridViewTextBoxColumn, Me.ТипДвигателяDataGridViewTextBoxColumn, Me.ТипТСDataGridViewTextBoxColumn, Me.НовыйЦветАвтоDataGridViewTextBoxColumn, Me.ОтрихтованныеДеталиDataGridViewTextBoxColumn, Me.ДобавкаВКраскуDataGridViewTextBoxColumn, Me.ОтполированныеДеталиDataGridViewTextBoxColumn, Me.ЗамененныеДеталиDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.РегистрацияАвто2BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1348, 525)
        Me.DataGridView1.TabIndex = 0
        '
        'КодDataGridViewTextBoxColumn
        '
        Me.КодDataGridViewTextBoxColumn.DataPropertyName = "Код"
        Me.КодDataGridViewTextBoxColumn.HeaderText = "Код"
        Me.КодDataGridViewTextBoxColumn.Name = "КодDataGridViewTextBoxColumn"
        Me.КодDataGridViewTextBoxColumn.ReadOnly = True
        '
        'РегистрационныйЗнакDataGridViewTextBoxColumn
        '
        Me.РегистрационныйЗнакDataGridViewTextBoxColumn.DataPropertyName = "Регистрационный знак"
        Me.РегистрационныйЗнакDataGridViewTextBoxColumn.HeaderText = "Регистрационный знак"
        Me.РегистрационныйЗнакDataGridViewTextBoxColumn.Name = "РегистрационныйЗнакDataGridViewTextBoxColumn"
        Me.РегистрационныйЗнакDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VINDataGridViewTextBoxColumn
        '
        Me.VINDataGridViewTextBoxColumn.DataPropertyName = "VIN"
        Me.VINDataGridViewTextBoxColumn.HeaderText = "VIN"
        Me.VINDataGridViewTextBoxColumn.Name = "VINDataGridViewTextBoxColumn"
        Me.VINDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ПрежнийЦветАвтоDataGridViewTextBoxColumn
        '
        Me.ПрежнийЦветАвтоDataGridViewTextBoxColumn.DataPropertyName = "Прежний цвет авто"
        Me.ПрежнийЦветАвтоDataGridViewTextBoxColumn.HeaderText = "Прежний цвет авто"
        Me.ПрежнийЦветАвтоDataGridViewTextBoxColumn.Name = "ПрежнийЦветАвтоDataGridViewTextBoxColumn"
        Me.ПрежнийЦветАвтоDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ФИОВладельцаDataGridViewTextBoxColumn
        '
        Me.ФИОВладельцаDataGridViewTextBoxColumn.DataPropertyName = "ФИО владельца"
        Me.ФИОВладельцаDataGridViewTextBoxColumn.HeaderText = "ФИО владельца"
        Me.ФИОВладельцаDataGridViewTextBoxColumn.Name = "ФИОВладельцаDataGridViewTextBoxColumn"
        Me.ФИОВладельцаDataGridViewTextBoxColumn.ReadOnly = True
        '
        'АдресВладельцаDataGridViewTextBoxColumn
        '
        Me.АдресВладельцаDataGridViewTextBoxColumn.DataPropertyName = "Адрес владельца"
        Me.АдресВладельцаDataGridViewTextBoxColumn.HeaderText = "Адрес владельца"
        Me.АдресВладельцаDataGridViewTextBoxColumn.Name = "АдресВладельцаDataGridViewTextBoxColumn"
        Me.АдресВладельцаDataGridViewTextBoxColumn.ReadOnly = True
        '
        'НомерКузоваDataGridViewTextBoxColumn
        '
        Me.НомерКузоваDataGridViewTextBoxColumn.DataPropertyName = "Номер кузова"
        Me.НомерКузоваDataGridViewTextBoxColumn.HeaderText = "Номер кузова"
        Me.НомерКузоваDataGridViewTextBoxColumn.Name = "НомерКузоваDataGridViewTextBoxColumn"
        Me.НомерКузоваDataGridViewTextBoxColumn.ReadOnly = True
        '
        'НомерДвигателяDataGridViewTextBoxColumn
        '
        Me.НомерДвигателяDataGridViewTextBoxColumn.DataPropertyName = "Номер двигателя"
        Me.НомерДвигателяDataGridViewTextBoxColumn.HeaderText = "Номер двигателя"
        Me.НомерДвигателяDataGridViewTextBoxColumn.Name = "НомерДвигателяDataGridViewTextBoxColumn"
        Me.НомерДвигателяDataGridViewTextBoxColumn.ReadOnly = True
        '
        'МощностьДвигателяDataGridViewTextBoxColumn
        '
        Me.МощностьДвигателяDataGridViewTextBoxColumn.DataPropertyName = "Мощность двигателя"
        Me.МощностьДвигателяDataGridViewTextBoxColumn.HeaderText = "Мощность двигателя"
        Me.МощностьДвигателяDataGridViewTextBoxColumn.Name = "МощностьДвигателяDataGridViewTextBoxColumn"
        Me.МощностьДвигателяDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ГодИзготовленияDataGridViewTextBoxColumn
        '
        Me.ГодИзготовленияDataGridViewTextBoxColumn.DataPropertyName = "Год изготовления"
        Me.ГодИзготовленияDataGridViewTextBoxColumn.HeaderText = "Год изготовления"
        Me.ГодИзготовленияDataGridViewTextBoxColumn.Name = "ГодИзготовленияDataGridViewTextBoxColumn"
        Me.ГодИзготовленияDataGridViewTextBoxColumn.ReadOnly = True
        '
        'МаркаИМодельАвтоDataGridViewTextBoxColumn
        '
        Me.МаркаИМодельАвтоDataGridViewTextBoxColumn.DataPropertyName = "Марка и модель авто"
        Me.МаркаИМодельАвтоDataGridViewTextBoxColumn.HeaderText = "Марка и модель авто"
        Me.МаркаИМодельАвтоDataGridViewTextBoxColumn.Name = "МаркаИМодельАвтоDataGridViewTextBoxColumn"
        Me.МаркаИМодельАвтоDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ЭкологическийКлассDataGridViewTextBoxColumn
        '
        Me.ЭкологическийКлассDataGridViewTextBoxColumn.DataPropertyName = "Экологический класс"
        Me.ЭкологическийКлассDataGridViewTextBoxColumn.HeaderText = "Экологический класс"
        Me.ЭкологическийКлассDataGridViewTextBoxColumn.Name = "ЭкологическийКлассDataGridViewTextBoxColumn"
        Me.ЭкологическийКлассDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ТипДвигателяDataGridViewTextBoxColumn
        '
        Me.ТипДвигателяDataGridViewTextBoxColumn.DataPropertyName = "Тип двигателя"
        Me.ТипДвигателяDataGridViewTextBoxColumn.HeaderText = "Тип двигателя"
        Me.ТипДвигателяDataGridViewTextBoxColumn.Name = "ТипДвигателяDataGridViewTextBoxColumn"
        Me.ТипДвигателяDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ТипТСDataGridViewTextBoxColumn
        '
        Me.ТипТСDataGridViewTextBoxColumn.DataPropertyName = "Тип ТС"
        Me.ТипТСDataGridViewTextBoxColumn.HeaderText = "Тип ТС"
        Me.ТипТСDataGridViewTextBoxColumn.Name = "ТипТСDataGridViewTextBoxColumn"
        Me.ТипТСDataGridViewTextBoxColumn.ReadOnly = True
        '
        'НовыйЦветАвтоDataGridViewTextBoxColumn
        '
        Me.НовыйЦветАвтоDataGridViewTextBoxColumn.DataPropertyName = "Новый цвет авто"
        Me.НовыйЦветАвтоDataGridViewTextBoxColumn.HeaderText = "Новый цвет авто"
        Me.НовыйЦветАвтоDataGridViewTextBoxColumn.Name = "НовыйЦветАвтоDataGridViewTextBoxColumn"
        Me.НовыйЦветАвтоDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ОтрихтованныеДеталиDataGridViewTextBoxColumn
        '
        Me.ОтрихтованныеДеталиDataGridViewTextBoxColumn.DataPropertyName = "Отрихтованные детали"
        Me.ОтрихтованныеДеталиDataGridViewTextBoxColumn.HeaderText = "Отрихтованные детали"
        Me.ОтрихтованныеДеталиDataGridViewTextBoxColumn.Name = "ОтрихтованныеДеталиDataGridViewTextBoxColumn"
        Me.ОтрихтованныеДеталиDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ДобавкаВКраскуDataGridViewTextBoxColumn
        '
        Me.ДобавкаВКраскуDataGridViewTextBoxColumn.DataPropertyName = "Добавка в краску"
        Me.ДобавкаВКраскуDataGridViewTextBoxColumn.HeaderText = "Добавка в краску"
        Me.ДобавкаВКраскуDataGridViewTextBoxColumn.Name = "ДобавкаВКраскуDataGridViewTextBoxColumn"
        Me.ДобавкаВКраскуDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ОтполированныеДеталиDataGridViewTextBoxColumn
        '
        Me.ОтполированныеДеталиDataGridViewTextBoxColumn.DataPropertyName = "Отполированные детали"
        Me.ОтполированныеДеталиDataGridViewTextBoxColumn.HeaderText = "Отполированные детали"
        Me.ОтполированныеДеталиDataGridViewTextBoxColumn.Name = "ОтполированныеДеталиDataGridViewTextBoxColumn"
        Me.ОтполированныеДеталиDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ЗамененныеДеталиDataGridViewTextBoxColumn
        '
        Me.ЗамененныеДеталиDataGridViewTextBoxColumn.DataPropertyName = "Замененные детали"
        Me.ЗамененныеДеталиDataGridViewTextBoxColumn.HeaderText = "Замененные детали"
        Me.ЗамененныеДеталиDataGridViewTextBoxColumn.Name = "ЗамененныеДеталиDataGridViewTextBoxColumn"
        Me.ЗамененныеДеталиDataGridViewTextBoxColumn.ReadOnly = True
        '
        'РегистрацияАвто2BindingSource
        '
        Me.РегистрацияАвто2BindingSource.DataMember = "РегистрацияАвто2"
        Me.РегистрацияАвто2BindingSource.DataSource = Me.РегистрацияАвто2DataSet
        '
        'РегистрацияАвто2DataSet
        '
        Me.РегистрацияАвто2DataSet.DataSetName = "РегистрацияАвто2DataSet"
        Me.РегистрацияАвто2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'РегистрацияАвто2TableAdapter
        '
        Me.РегистрацияАвто2TableAdapter.ClearBeforeFill = True
        '
        'ChromeButton2
        '
        Me.ChromeButton2.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w=="
        Me.ChromeButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ChromeButton2.Image = Nothing
        Me.ChromeButton2.Location = New System.Drawing.Point(117, 550)
        Me.ChromeButton2.Name = "ChromeButton2"
        Me.ChromeButton2.NoRounding = False
        Me.ChromeButton2.Size = New System.Drawing.Size(75, 23)
        Me.ChromeButton2.TabIndex = 3
        Me.ChromeButton2.Text = "Обновить"
        Me.ChromeButton2.Transparent = False
        '
        'ChromeButton1
        '
        Me.ChromeButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w=="
        Me.ChromeButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ChromeButton1.Image = Nothing
        Me.ChromeButton1.Location = New System.Drawing.Point(12, 543)
        Me.ChromeButton1.Name = "ChromeButton1"
        Me.ChromeButton1.NoRounding = False
        Me.ChromeButton1.Size = New System.Drawing.Size(99, 30)
        Me.ChromeButton1.TabIndex = 2
        Me.ChromeButton1.Text = "Меню"
        Me.ChromeButton1.Transparent = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 554)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(579, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Пожалуйста, после добавления данных в базу - нажмите кнопку ""Обновить""!"
        '
        'AutoDataset2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1372, 584)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChromeButton2)
        Me.Controls.Add(Me.ChromeButton1)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AutoDataset2"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "База данных измененных авто"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РегистрацияАвто2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РегистрацияАвто2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents РегистрацияАвто2DataSet As Project_Автосервис_zyzy.РегистрацияАвто2DataSet
    Friend WithEvents РегистрацияАвто2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents РегистрацияАвто2TableAdapter As Project_Автосервис_zyzy.РегистрацияАвто2DataSetTableAdapters.РегистрацияАвто2TableAdapter
    Friend WithEvents КодDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents РегистрационныйЗнакDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VINDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПрежнийЦветАвтоDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ФИОВладельцаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents АдресВладельцаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents НомерКузоваDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents НомерДвигателяDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents МощностьДвигателяDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ГодИзготовленияDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents МаркаИМодельАвтоDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ЭкологическийКлассDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ТипДвигателяDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ТипТСDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents НовыйЦветАвтоDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ОтрихтованныеДеталиDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ДобавкаВКраскуDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ОтполированныеДеталиDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ЗамененныеДеталиDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChromeButton1 As Project_Автосервис_zyzy.ChromeButton
    Friend WithEvents ChromeButton2 As Project_Автосервис_zyzy.ChromeButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
