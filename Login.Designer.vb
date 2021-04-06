<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.ChromeThemeContainer1 = New Project_Автосервис_zyzy.ChromeThemeContainer
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ChromeButton1 = New Project_Автосервис_zyzy.ChromeButton
        Me.ChromeThemeContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChromeThemeContainer1
        '
        Me.ChromeThemeContainer1.BackColor = System.Drawing.Color.White
        Me.ChromeThemeContainer1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ChromeThemeContainer1.Controls.Add(Me.Label3)
        Me.ChromeThemeContainer1.Controls.Add(Me.Label2)
        Me.ChromeThemeContainer1.Controls.Add(Me.Label1)
        Me.ChromeThemeContainer1.Controls.Add(Me.TextBox2)
        Me.ChromeThemeContainer1.Controls.Add(Me.TextBox1)
        Me.ChromeThemeContainer1.Controls.Add(Me.ChromeButton1)
        Me.ChromeThemeContainer1.Customization = "AAAA/1paWv9ycnL/"
        Me.ChromeThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChromeThemeContainer1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ChromeThemeContainer1.Image = Nothing
        Me.ChromeThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ChromeThemeContainer1.Movable = True
        Me.ChromeThemeContainer1.Name = "ChromeThemeContainer1"
        Me.ChromeThemeContainer1.NoRounding = False
        Me.ChromeThemeContainer1.Sizable = True
        Me.ChromeThemeContainer1.Size = New System.Drawing.Size(475, 252)
        Me.ChromeThemeContainer1.SmartBounds = True
        Me.ChromeThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ChromeThemeContainer1.TabIndex = 0
        Me.ChromeThemeContainer1.Text = "Войдите в свою учетную запись"
        Me.ChromeThemeContainer1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ChromeThemeContainer1.Transparent = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Magneto", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(318, 58)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Koenigsegg"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Login:"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(186, 148)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(120, 23)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(186, 119)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 23)
        Me.TextBox1.TabIndex = 1
        '
        'ChromeButton1
        '
        Me.ChromeButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w=="
        Me.ChromeButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ChromeButton1.Image = Nothing
        Me.ChromeButton1.Location = New System.Drawing.Point(186, 197)
        Me.ChromeButton1.Name = "ChromeButton1"
        Me.ChromeButton1.NoRounding = False
        Me.ChromeButton1.Size = New System.Drawing.Size(120, 33)
        Me.ChromeButton1.TabIndex = 0
        Me.ChromeButton1.Text = "Войти"
        Me.ChromeButton1.Transparent = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 252)
        Me.Controls.Add(Me.ChromeThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ChromeThemeContainer1.ResumeLayout(False)
        Me.ChromeThemeContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChromeThemeContainer1 As Project_Автосервис_zyzy.ChromeThemeContainer
    Friend WithEvents ChromeButton1 As Project_Автосервис_zyzy.ChromeButton
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
