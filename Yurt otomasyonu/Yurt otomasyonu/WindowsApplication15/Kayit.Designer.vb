<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kayit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtadsoyad = New System.Windows.Forms.TextBox()
        Me.txttelefon = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtvelitel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtadres = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.comboyatak = New System.Windows.Forms.ComboBox()
        Me.combooda = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtucret = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Öğrenci Adı Soyadı :"
        '
        'txtadsoyad
        '
        Me.txtadsoyad.Location = New System.Drawing.Point(162, 70)
        Me.txtadsoyad.Name = "txtadsoyad"
        Me.txtadsoyad.Size = New System.Drawing.Size(143, 20)
        Me.txtadsoyad.TabIndex = 1
        '
        'txttelefon
        '
        Me.txttelefon.Location = New System.Drawing.Point(162, 113)
        Me.txttelefon.MaxLength = 10
        Me.txttelefon.Name = "txttelefon"
        Me.txttelefon.Size = New System.Drawing.Size(143, 20)
        Me.txttelefon.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Telefon No :"
        '
        'txtvelitel
        '
        Me.txtvelitel.Location = New System.Drawing.Point(522, 31)
        Me.txtvelitel.MaxLength = 10
        Me.txtvelitel.Name = "txtvelitel"
        Me.txtvelitel.Size = New System.Drawing.Size(143, 20)
        Me.txtvelitel.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(402, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Veli Telefon No :"
        '
        'txtadres
        '
        Me.txtadres.Location = New System.Drawing.Point(162, 192)
        Me.txtadres.Multiline = True
        Me.txtadres.Name = "txtadres"
        Me.txtadres.Size = New System.Drawing.Size(217, 85)
        Me.txtadres.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Adres :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Doğum Tarihi :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(162, 155)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(402, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Oda No :"
        '
        'txttc
        '
        Me.txttc.Location = New System.Drawing.Point(162, 28)
        Me.txttc.MaxLength = 11
        Me.txttc.Name = "txttc"
        Me.txttc.Size = New System.Drawing.Size(143, 20)
        Me.txttc.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Tc Kimlik No :"
        '
        'comboyatak
        '
        Me.comboyatak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboyatak.FormattingEnabled = True
        Me.comboyatak.Location = New System.Drawing.Point(522, 130)
        Me.comboyatak.Name = "comboyatak"
        Me.comboyatak.Size = New System.Drawing.Size(143, 21)
        Me.comboyatak.TabIndex = 16
        '
        'combooda
        '
        Me.combooda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combooda.FormattingEnabled = True
        Me.combooda.Location = New System.Drawing.Point(522, 73)
        Me.combooda.Name = "combooda"
        Me.combooda.Size = New System.Drawing.Size(143, 21)
        Me.combooda.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(402, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Yatak No :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(405, 209)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 39)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Ekle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(498, 208)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 40)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Sil"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(588, 208)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(67, 39)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Güncelle"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 298)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(846, 194)
        Me.DataGridView1.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(402, 175)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Ücret :"
        '
        'txtucret
        '
        Me.txtucret.Location = New System.Drawing.Point(522, 172)
        Me.txtucret.Name = "txtucret"
        Me.txtucret.Size = New System.Drawing.Size(143, 20)
        Me.txtucret.TabIndex = 24
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(771, 209)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(76, 39)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "Ana Sayfaya Dön"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(685, 209)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(67, 39)
        Me.Button6.TabIndex = 28
        Me.Button6.Text = "Ara"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Kayit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(870, 504)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txtucret)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.combooda)
        Me.Controls.Add(Me.comboyatak)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txttc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtadres)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtvelitel)
        Me.Controls.Add(Me.txttelefon)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtadsoyad)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Kayit"
        Me.Text = "Öğrenci Kayıt"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtadsoyad As System.Windows.Forms.TextBox
    Friend WithEvents txttelefon As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtvelitel As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtadres As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txttc As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents comboyatak As System.Windows.Forms.ComboBox
    Friend WithEvents combooda As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtucret As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
