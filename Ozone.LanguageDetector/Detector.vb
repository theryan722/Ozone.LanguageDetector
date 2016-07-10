Imports System.IO

Public Class Detector
    'Developed by Ryan O'Day

#Region "Identifiers"

    Private Shared ada As String() = My.Resources.Identifiers_Ada.Split(vbNewLine)
    Private Shared assembly As String() = My.Resources.Identifiers_Assembly.Split(vbNewLine)
    Private Shared batch As String() = My.Resources.Identifiers_Batch.Split(vbNewLine)
    Private Shared cpp As String() = My.Resources.Identifiers_Cpp.Split(vbNewLine)
    Private Shared csharp As String() = My.Resources.Identifiers_CSharp.Split(vbNewLine)
    Private Shared css As String() = My.Resources.Identifiers_Css.Split(vbNewLine)
    Private Shared fortran As String() = My.Resources.Identifiers_Fortran.Split(vbNewLine)
    Private Shared html As String() = My.Resources.Identifiers_Html.Split(vbNewLine)
    Private Shared java As String() = My.Resources.Identifiers_Java.Split(vbNewLine)
    Private Shared javascript As String() = My.Resources.Identifiers_JavaScript.Split(vbNewLine)
    Private Shared lisp As String() = My.Resources.Identifiers_Lisp.Split(vbNewLine)
    Private Shared lua As String() = My.Resources.Identifiers_Lua.Split(vbNewLine)
    Private Shared pascal As String() = My.Resources.Identifiers_Pascal.Split(vbNewLine)
    Private Shared perl As String() = My.Resources.Identifiers_Perl.Split(vbNewLine)
    Private Shared php As String() = My.Resources.Identifiers_Php.Split(vbNewLine)
    Private Shared python As String() = My.Resources.Identifiers_Python.Split(vbNewLine)
    Private Shared ruby As String() = My.Resources.Identifiers_Ruby.Split(vbNewLine)
    Private Shared smalltalk As String() = My.Resources.Identifiers_SmallTalk.Split(vbNewLine)
    Private Shared sql As String() = My.Resources.Identifiers_Sql.Split(vbNewLine)
    Private Shared vb As String() = My.Resources.Identifiers_Vb.Split(vbNewLine)
    Private Shared xml As String() = My.Resources.Identifiers_Xml.Split(vbNewLine)

#End Region

#Region "Public"

    ''' <summary>
    ''' Detects the language based on the file extension
    ''' </summary>
    ''' <param name="fileloc">The location of the file.</param>
    ''' <returns>The language of the file. Returns Language.Language</returns>
    ''' <remarks></remarks>
    Public Shared Function DetectLanguageFromFile(ByVal fileloc As String) As Language.Language
        Select Case Path.GetExtension(fileloc)
            Case ".adb", ".a", ".ads", ".ada"
                Return Language.Language.Ada
            Case ".asm", ".s", ".S"
                Return Language.Language.Assembly
            Case ".bat", ".cmd", ".nt"
                Return Language.Language.Batch
            Case ".cs"
                Return Language.Language.CSharp
            Case ".cpp", ".cc", ".cxx", ".cp", ".c++", ".hpp", ".hxx"
                Return Language.Language.Cpp
            Case ".css"
                Return Language.Language.Css
            Case ".f", ".f90", ".f95", ".f03", ".for", ".F", ".F90", ".f2k"
                Return Language.Language.Fortran
            Case ".html", ".htm", ".xhtml", ".jhtml", ".shtml", ".shtm", ".hta"
                Return Language.Language.Html
            Case ".java", ".jsp", ".jspx"
                Return Language.Language.Java
            Case ".js"
                Return Language.Language.JavaScript
            Case ".lisp", ".cl", ".el", ".lsp"
                Return Language.Language.Lisp
            Case ".lua", "."
                Return Language.Language.Lua
            Case ".pas", ".pp", ".pascal", ".inc"
                Return Language.Language.Pascal
            Case ".pl", ".pm", ".plx"
                Return Language.Language.Perl
            Case ".php", ".php4", ".php3", ".phtml"
                Return Language.Language.Php
            Case ".py", ".pyw"
                Return Language.Language.Python
            Case ".rb", ".rhtml", ".rbw"
                Return Language.Language.Ruby
            Case ".st"
                Return Language.Language.SmallTalk
            Case ".sql"
                Return Language.Language.Sql
            Case ".vb", ".vbs"
                Return Language.Language.Vb
            Case ".xml", ".rss", ".svg", ".xsml", ".xsl", ".xsd", ".kml", ".wsdl", ".xlf", ".xliff"
                Return Language.Language.Xml
            Case ".txt"
                Return Language.Language.PlainText
            Case Else
                Return Language.Language.Unknown
        End Select
    End Function

    ''' <summary>
    ''' Detects the language of a snippet of code
    ''' </summary>
    ''' <param name="snippet">The code snippet</param>
    ''' <returns>The language of the snippet. Returns Language.Language</returns>
    ''' <remarks></remarks>
    Public Shared Function DetectLanguageFromSnippet(ByVal snippet As String) As String
        Dim flang = Language.Language.Unknown
        Dim tally As New LanguageTally
        '-------------
        TallyLanguages(tally, snippet)
        flang = tally.GetLanguageWithHighestTallies()
        '-------------
        tally.ClearTallies()
        Return flang
    End Function

#End Region

#Region "Helper"

    Private Shared Sub TallyLanguages(ByRef langtally As LanguageTally, ByVal snippet As String)
        Dim arr(2) As String
        For Each item As String In ada
            arr = item.Split("|")
            If snippet.ToLower.Contains(arr(0)) Then
                If arr(1).Substring(0, 1) = "-" Then
                    langtally.Ada -= arr(1).Substring(1, arr(1).Length - 1)
                Else
                    langtally.Ada += CInt(arr(1))
                End If
            Else
                langtally.Ada += 1
            End If
        Next
        For Each item As String In assembly
            arr = item.Split("|")
            If snippet.ToLower.Contains(arr(0)) Then
                If arr(1).Substring(0, 1) = "-" Then
                    langtally.Assembly -= arr(1).Substring(1, arr(1).Length - 1)
                Else
                    langtally.Assembly += CInt(arr(1))
                End If
            Else
                langtally.Assembly += 1
            End If
        Next
        For Each item As String In batch
            arr = item.Split("|")
            If snippet.ToLower.Contains(arr(0)) Then
                If arr(1).Substring(0, 1) = "-" Then
                    langtally.Batch -= arr(1).Substring(1, arr(1).Length - 1)
                Else
                    langtally.Batch += CInt(arr(1))
                End If
            Else
                langtally.Batch += 1
            End If
        Next
        For Each item As String In cpp
            arr = item.Split("|")
            If snippet.ToLower.Contains(arr(0)) Then
                If arr(1).Substring(0, 1) = "-" Then
                    langtally.Cpp -= arr(1).Substring(1, arr(1).Length - 1)
                Else
                    langtally.Cpp += CInt(arr(1))
                End If
            Else
                langtally.Cpp += 1
            End If
        Next
        For Each item As String In csharp
            arr = item.Split("|")
            If snippet.ToLower.Contains(arr(0)) Then
                If arr(1).Substring(0, 1) = "-" Then
                    langtally.CSharp -= arr(1).Substring(1, arr(1).Length - 1)
                Else
                    langtally.CSharp += CInt(arr(1))
                End If
            Else
                langtally.CSharp += 1
            End If
        Next
        For Each item As String In css
            arr = item.Split("|")
            If snippet.ToLower.Contains(arr(0)) Then
                If arr(1).Substring(0, 1) = "-" Then
                    langtally.Css -= arr(1).Substring(1, arr(1).Length - 1)
                Else
                    langtally.Css += CInt(arr(1))
                End If
            Else
                langtally.Css += 1
            End If
        Next
        For Each item As String In fortran
            arr = item.Split("|")
            If snippet.ToLower.Contains(arr(0)) Then
                If arr(1).Substring(0, 1) = "-" Then
                    langtally.Fortran -= arr(1).Substring(1, arr(1).Length - 1)
                Else
                    langtally.Fortran += CInt(arr(1))
                End If
            Else
                langtally.Fortran += 1
            End If
        Next
        For Each item As String In html
            arr = item.Split("|")
            If snippet.ToLower.Contains(arr(0)) Then
                If arr(1).Substring(0, 1) = "-" Then
                    langtally.Html -= arr(1).Substring(1, arr(1).Length - 1)
                Else
                    langtally.Html += CInt(arr(1))
                End If
            Else
                langtally.Html += 1
            End If
        Next
        For Each item As String In java
            arr = item.Split("|")
            If snippet.ToLower.Contains(arr(0)) Then
                If arr(1).Substring(0, 1) = "-" Then
                    langtally.Java -= arr(1).Substring(1, arr(1).Length - 1)
                Else
                    langtally.Java += CInt(arr(1))
                End If
            Else
                langtally.Java += 1
            End If
        Next
        For Each item As String In javascript
            arr = item.Split("|")
            If snippet.ToLower.Contains(arr(0)) Then
                If arr(1).Substring(0, 1) = "-" Then
                    langtally.JavaScript -= arr(1).Substring(1, arr(1).Length - 1)
                Else
                    langtally.JavaScript += CInt(arr(1))
                End If
            Else
                langtally.JavaScript += 1
            End If
        Next
        For Each item As String In lisp
            arr = item.Split("|")
            If snippet.ToLower.Contains(arr(0)) Then
                If arr(1).Substring(0, 1) = "-" Then
                    langtally.Lisp -= arr(1).Substring(1, arr(1).Length - 1)
                Else
                    langtally.Lisp += CInt(arr(1))
                End If
            Else
                langtally.Lisp += 1
            End If
        Next
        For Each item As String In lua
            arr = item.Split("|")
            If snippet.ToLower.Contains(arr(0)) Then
                If arr(1).Substring(0, 1) = "-" Then
                    langtally.Lua -= arr(1).Substring(1, arr(1).Length - 1)
                Else
                    langtally.Lua += CInt(arr(1))
                End If
            Else
                langtally.Lua += 1
            End If
        Next
        For Each item As String In pascal
            arr = item.Split("|")
            If snippet.ToLower.Contains(arr(0)) Then
                If arr(1).Substring(0, 1) = "-" Then
                    langtally.Pascal -= arr(1).Substring(1, arr(1).Length - 1)
                Else
                    langtally.Pascal += CInt(arr(1))
                End If
            Else
                langtally.Pascal += 1
            End If
        Next
        For Each item As String In perl
            arr = item.Split("|")
            If snippet.ToLower.Contains(arr(0)) Then
                MsgBox(arr(1))
                If arr(1).Substring(0, 1) = "-" Then
                    langtally.Perl -= arr(1).Substring(1, arr(1).Length - 1)
                Else
                    langtally.Perl += CInt(arr(1))
                End If
            Else
                langtally.Perl += 1
            End If
        Next
        For Each item As String In php
            arr = item.Split("|")
            If snippet.ToLower.Contains(arr(0)) Then
                If arr(1).Substring(0, 1) = "-" Then
                    langtally.Php -= arr(1).Substring(1, arr(1).Length - 1)
                Else
                    langtally.Php += CInt(arr(1))
                End If
            Else
                langtally.Php += 1
            End If
        Next
        For Each item As String In python
            arr = item.Split("|")
            If snippet.ToLower.Contains(arr(0)) Then
                If arr(1).Substring(0, 1) = "-" Then
                    langtally.Python -= arr(1).Substring(1, arr(1).Length - 1)
                Else
                    langtally.Python += CInt(arr(1))
                End If
            Else
                langtally.Python += 1
            End If
        Next
        For Each item As String In ruby
            arr = item.Split("|")
            If snippet.ToLower.Contains(arr(0)) Then
                If arr(1).Substring(0, 1) = "-" Then
                    langtally.Ruby -= arr(1).Substring(1, arr(1).Length - 1)
                Else
                    langtally.Ruby += CInt(arr(1))
                End If
            Else
                langtally.Ruby += 1
            End If
        Next
        For Each item As String In smalltalk
            arr = item.Split("|")
            If snippet.ToLower.Contains(arr(0)) Then
                If arr(1).Substring(0, 1) = "-" Then
                    langtally.SmallTalk -= arr(1).Substring(1, arr(1).Length - 1)
                Else
                    langtally.SmallTalk += CInt(arr(1))
                End If
            Else
                langtally.SmallTalk += 1
            End If
        Next
        For Each item As String In sql
            arr = item.Split("|")
            If snippet.ToLower.Contains(arr(0)) Then
                If arr(1).Substring(0, 1) = "-" Then
                    langtally.Sql -= arr(1).Substring(1, arr(1).Length - 1)
                Else
                    langtally.Sql += CInt(arr(1))
                End If
            Else
                langtally.Sql += 1
            End If
        Next
        For Each item As String In vb
            arr = item.Split("|")
            If snippet.ToLower.Contains(arr(0)) Then
                If arr(1).Substring(0, 1) = "-" Then
                    langtally.Vb -= arr(1).Substring(1, arr(1).Length - 1)
                Else
                    langtally.Vb += CInt(arr(1))
                End If
            Else
                langtally.Vb += 1
            End If
        Next
        For Each item As String In xml
            arr = item.Split("|")
            If snippet.ToLower.Contains(arr(0)) Then
                If arr(1).Substring(0, 1) = "-" Then
                    langtally.Xml -= arr(1).Substring(1, arr(1).Length - 1)
                Else
                    langtally.Xml += CInt(arr(1))
                End If
            Else
                langtally.Xml += 1
            End If
        Next
        My.Computer.Clipboard.SetText(langtally.ToString())
    End Sub

#End Region
    
End Class
