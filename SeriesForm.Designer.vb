<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeriesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SeriesForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SeriesNameText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SeasonComboBox = New System.Windows.Forms.ComboBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PathText = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumFSlctd = New System.Windows.Forms.Label()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ModifyListButton = New System.Windows.Forms.Button()
        Me.ClearListButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ModifyButton = New System.Windows.Forms.Button()
        Me.EpFromText = New System.Windows.Forms.MaskedTextBox()
        Me.EpToText = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Title:"
        '
        'SeriesNameText
        '
        Me.SeriesNameText.Location = New System.Drawing.Point(194, 122)
        Me.SeriesNameText.Name = "SeriesNameText"
        Me.SeriesNameText.Size = New System.Drawing.Size(184, 22)
        Me.SeriesNameText.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 354)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Episode:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(320, 354)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "To:"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(82, 414)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Format:"
        '
        'SeasonComboBox
        '
        Me.SeasonComboBox.FormattingEnabled = True
        Me.SeasonComboBox.Items.AddRange(New Object() {"Season 01", "Season 02", "Season 03", "Season 04", "Season 05", "Season 06", "Season 07", "Season 08", "Season 09", "Season 10", "Season 11", "Season 12", "Season 13", "Season 14", "Season 15", "Season 16", "Season 17", "Season 18", "Season 19", "Season 20"})
        Me.SeasonComboBox.Location = New System.Drawing.Point(85, 287)
        Me.SeasonComboBox.Name = "SeasonComboBox"
        Me.SeasonComboBox.Size = New System.Drawing.Size(121, 24)
        Me.SeasonComboBox.TabIndex = 7
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(87, 463)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(79, 21)
        Me.RadioButton1.TabIndex = 8
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "S01E02"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(87, 508)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(68, 21)
        Me.RadioButton2.TabIndex = 9
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "s1e02"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(85, 557)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(83, 21)
        Me.RadioButton3.TabIndex = 10
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "S01.E02"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(233, 463)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(87, 21)
        Me.RadioButton4.TabIndex = 11
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "S01_E02"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(233, 508)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(67, 21)
        Me.RadioButton5.TabIndex = 12
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "01x02"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(233, 557)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(61, 21)
        Me.RadioButton6.TabIndex = 13
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "0102"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(80, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Last File Selected:"
        '
        'PathText
        '
        Me.PathText.Location = New System.Drawing.Point(75, 204)
        Me.PathText.Name = "PathText"
        Me.PathText.Size = New System.Drawing.Size(529, 22)
        Me.PathText.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(80, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Number of Files Selected:"
        '
        'NumFSlctd
        '
        Me.NumFSlctd.AutoSize = True
        Me.NumFSlctd.Location = New System.Drawing.Point(295, 229)
        Me.NumFSlctd.Name = "NumFSlctd"
        Me.NumFSlctd.Size = New System.Drawing.Size(16, 17)
        Me.NumFSlctd.TabIndex = 17
        Me.NumFSlctd.Text = "0"
        '
        'LoadButton
        '
        Me.LoadButton.Location = New System.Drawing.Point(632, 204)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(90, 22)
        Me.LoadButton.TabIndex = 18
        Me.LoadButton.Text = "Load"
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(811, 125)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(252, 404)
        Me.ListBox1.TabIndex = 19
        '
        'ModifyListButton
        '
        Me.ModifyListButton.Location = New System.Drawing.Point(1084, 223)
        Me.ModifyListButton.Name = "ModifyListButton"
        Me.ModifyListButton.Size = New System.Drawing.Size(102, 48)
        Me.ModifyListButton.TabIndex = 20
        Me.ModifyListButton.Text = "Modify List"
        Me.ModifyListButton.UseVisualStyleBackColor = True
        '
        'ClearListButton
        '
        Me.ClearListButton.Location = New System.Drawing.Point(1084, 167)
        Me.ClearListButton.Name = "ClearListButton"
        Me.ClearListButton.Size = New System.Drawing.Size(102, 50)
        Me.ClearListButton.TabIndex = 21
        Me.ClearListButton.Text = "Clear List"
        Me.ClearListButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(571, 621)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 22
        Me.ClearButton.Text = "Clear All"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ModifyButton
        '
        Me.ModifyButton.Location = New System.Drawing.Point(688, 621)
        Me.ModifyButton.Name = "ModifyButton"
        Me.ModifyButton.Size = New System.Drawing.Size(75, 23)
        Me.ModifyButton.TabIndex = 23
        Me.ModifyButton.Text = "Finish"
        Me.ModifyButton.UseVisualStyleBackColor = True
        '
        'EpFromText
        '
        Me.EpFromText.Location = New System.Drawing.Point(196, 349)
        Me.EpFromText.Mask = "000"
        Me.EpFromText.Name = "EpFromText"
        Me.EpFromText.Size = New System.Drawing.Size(34, 22)
        Me.EpFromText.TabIndex = 24
        '
        'EpToText
        '
        Me.EpToText.Location = New System.Drawing.Point(384, 349)
        Me.EpToText.Mask = "000"
        Me.EpToText.Name = "EpToText"
        Me.EpToText.Size = New System.Drawing.Size(36, 22)
        Me.EpToText.TabIndex = 25
        Me.EpToText.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(209, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 17)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Please Enter Title"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(252, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(182, 17)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Please Select at least a File"
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(86, 329)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 17)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Please Enter Episode"
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(320, 329)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 17)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Please Enter Episode"
        Me.Label10.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(165, 414)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 17)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Please Enter Format"
        Me.Label11.Visible = False
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 71)
        Me.Button1.TabIndex = 31
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SeriesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1267, 682)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.EpToText)
        Me.Controls.Add(Me.EpFromText)
        Me.Controls.Add(Me.ModifyButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ClearListButton)
        Me.Controls.Add(Me.ModifyListButton)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.NumFSlctd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PathText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RadioButton6)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.SeasonComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SeriesNameText)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SeriesForm"
        Me.Text = "Socordia: Series File Name Modifier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SeriesNameText As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SeasonComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PathText As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NumFSlctd As System.Windows.Forms.Label
    Friend WithEvents LoadButton As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ModifyListButton As System.Windows.Forms.Button
    Friend WithEvents ClearListButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ModifyButton As System.Windows.Forms.Button
    Friend WithEvents EpFromText As System.Windows.Forms.MaskedTextBox
    Friend WithEvents EpToText As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
