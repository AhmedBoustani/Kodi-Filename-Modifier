Public Class ModifyName

    Public Function ModifySeriesName(file As String, title As String, sn As Integer, ep As Integer, format As Integer)
        Dim newname As String
        Dim extension As String
        Dim episode As String
        Dim season As String
        extension = ExtensionOf(file)
        episode = GetEpisode(ep)
        season = GetSeason(sn)

        If format = 1 Then
            newname = title + "_" + "S" + season + "E" + episode + extension

        ElseIf format = 2 Then
            newname = title + "_" + "s" + season + "e" + episode + extension

        ElseIf format = 3 Then
            newname = title + "_" + "S" + season + ".E" + episode + extension

        ElseIf format = 4 Then
            newname = title + "_" + "S" + season + "_E" + episode + extension

        ElseIf format = 5 Then
            newname = title + "_" + season + "x" + episode + extension

        Else
            newname = title + "_" + season + episode + extension
        End If

        Return newname
    End Function

    Public Function ExtensionOf(file As String)
        Dim ext As String
        Dim fileR As String
        Dim extR As String
        fileR = StrReverse(file)
        extR = fileR.Substring(0, fileR.IndexOf("."))
        ext = StrReverse(extR)
        Return ext
    End Function

    Public Function GetEpisode(ep As Integer)
        Dim episode As String

        If ep < 10 Then
            episode = "0" + Str(ep)
            episode = episode.Replace(" ", "")
        Else
            episode = Str(ep)
            episode = episode.Replace(" ", "")
        End If

        Return episode
    End Function

    Public Function GetSeason(season As Integer)
        Dim seasonS As String

        If season < 10 Then
            seasonS = "0" + Str(season)
            seasonS = seasonS.Replace(" ", "")
        Else
            seasonS = Str(season)
            seasonS = seasonS.Replace(" ", "")
        End If

        Return seasonS
    End Function

End Class
