Friend Class LanguageTally

#Region "Languages"

    Property Ada As Integer
    Property Assembly As Integer
    Property Batch As Integer
    Property Css As Integer
    Property CSharp As Integer
    Property Cpp As Integer
    Property Fortran As Integer
    Property Html As Integer
    Property Java As Integer
    Property JavaScript As Integer
    Property Lisp As Integer
    Property Lua As Integer
    Property Php As Integer
    Property Pascal As Integer
    Property Perl As Integer
    Property PlainText As Integer
    Property Python As Integer
    Property Ruby As Integer
    Property Sql As Integer
    Property SmallTalk As Integer
    Property Unknown As Integer
    Property Vb As Integer
    Property Xml As Integer

#End Region

#Region "Methods"

    Public Sub ClearTallies()
        Ada = 0
        Css = 0
        CSharp = 0
        Cpp = 0
        Fortran = 0
        Html = 0
        Java = 0
        JavaScript = 0
        Lisp = 0
        Lua = 0
        Php = 0
        Pascal = 0
        Perl = 0
        PlainText = 0
        Python = 0
        Ruby = 0
        Sql = 0
        SmallTalk = 0
        Unknown = 0
        Vb = 0
        Xml = 0
    End Sub

    Public Function GetLanguageWithHighestTallies() As Language.Language
        Dim lang As Language.Language = Language.Language.Unknown
        Dim tallyarray As Integer() = {Ada, Assembly, Batch, Css, CSharp, Cpp, Fortran, Html, Java, JavaScript, Lisp, Lua, Php, Pascal, Perl, Python, Ruby, Sql, SmallTalk, Vb, Xml}
        lang = ConvertIndexToLanguage(GetHighestNumberIndex(tallyarray))
        Return lang
    End Function

    Private Function ConvertIndexToLanguage(ByVal index As Integer) As Language.Language
        Select Case index
            Case 0
                Return Language.Language.Ada
            Case 1
                Return Language.Language.Assembly
            Case 2
                Return Language.Language.Batch
            Case 3
                Return Language.Language.Css
            Case 4
                Return Language.Language.CSharp
            Case 5
                Return Language.Language.Cpp
            Case 6
                Return Language.Language.Fortran
            Case 7
                Return Language.Language.Html
            Case 8
                Return Language.Language.Java
            Case 9
                Return Language.Language.JavaScript
            Case 10
                Return Language.Language.Lisp
            Case 11
                Return Language.Language.Lua
            Case 12
                Return Language.Language.Php
            Case 13
                Return Language.Language.Pascal
            Case 14
                Return Language.Language.Perl
            Case 15
                Return Language.Language.Python
            Case 16
                Return Language.Language.Ruby
            Case 17
                Return Language.Language.Sql
            Case 18
                Return Language.Language.SmallTalk
            Case 19
                Return Language.Language.Vb
            Case 20
                Return Language.Language.Xml
            Case Else
                Return Language.Language.Unknown
        End Select
    End Function


    Private Function GetHighestNumberIndex(ByVal arr As Integer()) As Integer
        Dim h As Integer = 0
        Dim hind As Integer = 0
        '------
        Dim ztot As Integer = 0
        Dim cind As Integer = 0
        For Each item As Integer In arr
            If item > h Then
                h = item
                hind = cind
            End If
            If item = 0 Then
                ztot += 1
            End If
            cind += 1
        Next
        If ztot = 21 Then
            hind = -1
        Else
            For i As Integer = 0 To arr.Count - 1
                If i <> hind Then
                    If arr(i) = h Then
                        hind = -1
                        Exit For
                    End If
                End If
            Next
        End If
        Return hind
    End Function

#End Region

End Class
