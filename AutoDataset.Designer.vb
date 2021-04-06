<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutoDataset
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
        Me.ИдентификационныйНомерМашиныVINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ЦветАвтоDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.РегистрацияАвтоBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._РегистрацияАвто1_1_DataSet = New Project_Автосервис_zyzy._РегистрацияАвто1_1_DataSet
        Me.Регистрация_автоTableAdapter = New Project_Автосервис_zyzy._РегистрацияАвто1_1_DataSetTableAdapters.Регистрация_автоTableAdapter
        Me.ChromeButton1 = New Project_Автосервис_zyzy.ChromeButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.ChromeButton2 = New Project_Автосервис_zyzy.ChromeButton
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РегистрацияАвтоBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._РегистрацияАвто1_1_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn, Me.РегистрационныйЗнакDataGridViewTextBoxColumn, Me.ИдентификационныйНомерМашиныVINDataGridViewTextBoxColumn, Me.ЦветАвтоDataGridViewTextBoxColumn, Me.ФИОВладельцаDataGridViewTextBoxColumn, Me.АдресВладельцаDataGridViewTextBoxColumn, Me.НомерКузоваDataGridViewTextBoxColumn, Me.НомерДвигателяDataGridViewTextBoxColumn, Me.МощностьДвигателяDataGridViewTextBoxColumn, Me.ГодИзготовленияDataGridViewTextBoxColumn, Me.МаркаИМодельАвтоDataGridViewTextBoxColumn, Me.ЭкологическийКлассDataGridViewTextBoxColumn, Me.ТипДвигателяDataGridViewTextBoxColumn, Me.ТипТСDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.РегистрацияАвтоBindingSource
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
        'ИдентификационныйНомерМашиныVINDataGridViewTextBoxColumn
        '
        Me.ИдентификационныйНомерМашиныVINDataGridViewTextBoxColumn.DataPropertyName = "Идентификационный номер машины (VIN)"
        Me.ИдентификационныйНомерМашиныVINDataGridViewTextBoxColumn.HeaderText = "Идентификационный номер машины (VIN)"
        Me.ИдентификационныйНомерМашиныVINDataGridViewTextBoxColumn.Name = "ИдентификационныйНомерМашиныVINDataGridViewTextBoxColumn"
        Me.ИдентификационныйНомерМашиныVINDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ЦветАвтоDataGridViewTextBoxColumn
        '
        Me.ЦветАвтоDataGridViewTextBoxColumn.DataPropertyName = "Цвет авто"
        Me.ЦветАвтоDataGridViewTextBoxColumn.HeaderText = "Цвет авто"
        Me.ЦветАвтоDataGridViewTextBoxColumn.Name = "ЦветАвтоDataGridViewTextBoxColumn"
        Me.ЦветАвтоDataGridViewTextBoxColumn.ReadOnly = True
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
        'РегистрацияАвтоBindingSource
        '
        Me.РегистрацияАвтоBindingSource.DataMember = "Регистрация авто"
        Me.РегистрацияАвтоBindingSource.DataSource = Me._РегистрацияАвто1_1_DataSet
        '
        '_РегистрацияАвто1_1_DataSet
        '
        Me._РегистрацияАвто1_1_DataSet.DataSetName = "_РегистрацияАвто1_1_DataSet"
        Me._РегистрацияАвто1_1_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Регистрация_автоTableAdapter
        '
        Me.Регистрация_автоTableAdapter.ClearBeforeFill = True
        '
        'ChromeButton1
        '
        Me.ChromeButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w=="
        Me.ChromeButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ChromeButton1.Image = Nothing
        Me.ChromeButton1.Location = New System.Drawing.Point(12, 545)
        Me.ChromeButton1.Name = "ChromeButton1"
        Me.ChromeButton1.NoRounding = False
        Me.ChromeButton1.Size = New System.Drawing.Size(99, 30)
        Me.ChromeButton1.TabIndex = 1
        Me.ChromeButton1.Text = "Меню"
        Me.ChromeButton1.Transparent = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(196, 556)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(579, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Пожалуйста, после добавления данных в базу - нажмите кнопку ""Обновить""!"
        '
        'ChromeButton2
        '
        Me.ChromeButton2.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w=="
        Me.ChromeButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ChromeButton2.Image = Nothing
        Me.ChromeButton2.Location = New System.Drawing.Point(115, 552)
        Me.ChromeButton2.Name = "ChromeButton2"
        Me.ChromeButton2.NoRounding = False
        Me.ChromeButton2.Size = New System.Drawing.Size(75, 23)
        Me.ChromeButton2.TabIndex = 5
        Me.ChromeButton2.Text = "Обновить"
        Me.ChromeButton2.Transparent = False
        '
        'AutoDataset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1372, 584)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChromeButton2)
        Me.Controls.Add(Me.ChromeButton1)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AutoDataset"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "База данных"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РегистрацияАвтоBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._РегистрацияАвто1_1_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents _РегистрацияАвто1_1_DataSet As Project_Автосервис_zyzy._РегистрацияАвто1_1_DataSet
    Friend WithEvents РегистрацияАвтоBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Регистрация_автоTableAdapter As Project_Автосервис_zyzy._РегистрацияАвто1_1_DataSetTableAdapters.Регистрация_автоTableAdapter
    Friend WithEvents КодDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents РегистрационныйЗнакDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ИдентификационныйНомерМашиныVINDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ЦветАвтоDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents ChromeButton1 As Project_Автосервис_zyzy.ChromeButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChromeButton2 As Project_Автосервис_zyzy.ChromeButton
End Class
