Public Class SeriesForm

    Dim format As Integer = 0
    Dim strFileName() As String


    ' Clear Button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Clear()

    End Sub

    ' Load Button
    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim i As Integer

        fd.Title = "File Dialog"
        fd.InitialDirectory = "C:\User"
        fd.Filter = "Video Files (*.avi, *.mpg, *.mpeg, *.m1v, *.mpa, *.m4a, *.mp4, *.m4v, *.3gp, *.aac, *.adts, *.m2ts,*.mkv, *.flv)||All Files (*.*)|*.*"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.RestoreDirectory = True
        fd.Multiselect = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileNames
            PathText.Text = strFileName.First
            NumFSlctd.Text = strFileName.Length
            For i = 0 To strFileName.Length - 1
                ListBox1.Items.Add(My.Computer.FileSystem.GetName(strFileName(i)))
            Next i
        End If
        
        


    End Sub



    ' Set of Radio Buttons
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        format = 1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        format = 2
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        format = 3
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        format = 4
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        format = 5
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        format = 6
    End Sub

    ' Modify Button
    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles ModifyButton.Click
        If MsgBox("Are you sure you want to continue with the modifications?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            Modify()
        End If

    End Sub

    Public Sub Modify()
        Dim newname As String
        Dim title As String = ""
        Dim Sep As Integer
        Dim Eep As Integer
        Dim season As Integer
        Dim ep As Integer
        Dim bool As Boolean = True
        Dim dif As Integer
        Dim i As Integer = 0
        Dim change = New ModifyName()


        season = SeasonComboBox.SelectedIndex + 1


        If String.IsNullOrEmpty(strFileName(i)) Then
            bool = False
            Label8.Visible = True
        End If

        Try
            title = SeriesNameText.Text
        Catch ex As Exception
            bool = False
            Label7.Visible = True
        End Try

        If SeriesNameText.Text = "" Then
            bool = False
            Label7.Visible = True
        End If

        Try
            Sep = Integer.Parse(EpFromText.Text)
        Catch ex As Exception
            bool = False
            NumFSlctd.Visible = True
        End Try

        If strFileName.Length > 1 Then
            Label3.Visible = True
            EpToText.Visible = True
            Try
                Eep = Integer.Parse(EpToText.Text)
            Catch ex As Exception
                bool = False
                Label10.Visible = True
            End Try
            dif = Sep - Eep
            If dif = Not 0 Then
                bool = False
                i = 1
            End If

        End If

        ep = Sep

        If format = 0 Then
            bool = False
            Label11.Visible = True
        End If

        If bool = True Then
            For Each element As String In strFileName
                newname = change.ModifySeriesName(element, title, season, ep, format)
                Try
                    My.Computer.FileSystem.RenameFile(element, newname)
                Catch ex As Exception
                    bool = False
                End Try
                ep = ep + 1
            Next
        End If

        If bool = True Then
            MsgBox("Modification Was Successful", MsgBoxStyle.OkOnly, "Success")
            Clear()
        ElseIf bool = False Then
            MsgBox("Modification Was Unsuccessful", MsgBoxStyle.OkOnly, "Error")
            If i = 1 Then
                MsgBox("Ending Episode Was Less Than the Beginning", MsgBoxStyle.OkOnly, "Error")
            End If

        End If
    End Sub


    Public Sub Clear()
        PathText.Text = ""
        NumFSlctd.Text = "0"
        ListBox1.Items.Clear()
        SeriesNameText.Text = ""
        SeasonComboBox.SelectedIndex = 0
        EpFromText.Text = ""
        EpToText.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        format = 0
    End Sub



    


    Private Sub ClearListButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        ListBox1.Items.Clear()
        PathText.Text = ""
        NumFSlctd.Text = "0"
    End Sub

    Private Sub ModifyListButton_Click(sender As Object, e As EventArgs) Handles ModifyListButton.Click
        Dim box = New EditList()
        box.Show()
    End Sub

End Class