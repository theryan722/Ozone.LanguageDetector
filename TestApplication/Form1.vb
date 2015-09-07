Public Class Form1
    
#Region "MenuStrip"

    Private Sub DetermineLanguageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetermineLanguageToolStripMenuItem.Click
        Dim bb As Ozone.LanguageDetector.Language.Language = Ozone.LanguageDetector.Detector.DetectLanguageFromSnippet(TextBox1.Text)
        Select Case bb
            Case Ozone.LanguageDetector.Language.Language.Ada
                MsgBox("Ada")
            Case Ozone.LanguageDetector.Language.Language.Assembly
                MsgBox("Assembly")
            Case Ozone.LanguageDetector.Language.Language.Batch
                MsgBox("Batch")
            Case Ozone.LanguageDetector.Language.Language.Cpp
                MsgBox("C++")
            Case Ozone.LanguageDetector.Language.Language.CSharp
                MsgBox("C#")
            Case Ozone.LanguageDetector.Language.Language.Css
                MsgBox("Css")
            Case Ozone.LanguageDetector.Language.Language.Fortran
                MsgBox("Fortran")
            Case Ozone.LanguageDetector.Language.Language.Html
                MsgBox("Html")
            Case Ozone.LanguageDetector.Language.Language.Java
                MsgBox("Java")
            Case Ozone.LanguageDetector.Language.Language.JavaScript
                MsgBox("JavaScript")
            Case Ozone.LanguageDetector.Language.Language.Lisp
                MsgBox("Lisp")
            Case Ozone.LanguageDetector.Language.Language.Lua
                MsgBox("Lua")
            Case Ozone.LanguageDetector.Language.Language.Pascal
                MsgBox("Pascal")
            Case Ozone.LanguageDetector.Language.Language.Perl
                MsgBox("Perl")
            Case Ozone.LanguageDetector.Language.Language.Php
                MsgBox("Php")
            Case Ozone.LanguageDetector.Language.Language.PlainText
                MsgBox("PlainText")
            Case Ozone.LanguageDetector.Language.Language.Python
                MsgBox("Python")
            Case Ozone.LanguageDetector.Language.Language.Ruby
                MsgBox("Ruby")
            Case Ozone.LanguageDetector.Language.Language.SmallTalk
                MsgBox("SmallTalk")
            Case Ozone.LanguageDetector.Language.Language.Sql
                MsgBox("Sql")
            Case Ozone.LanguageDetector.Language.Language.Unknown
                MsgBox("Unknown")
            Case Ozone.LanguageDetector.Language.Language.Vb
                MsgBox("Vb")
            Case Ozone.LanguageDetector.Language.Language.Xml
                MsgBox("Xml")
        End Select
    End Sub

#Region "File"

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

#End Region

#Region "Edit"

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        TextBox1.Undo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        TextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        TextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        TextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        TextBox1.SelectAll()
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        TextBox1.Clear()
    End Sub

#End Region

#Region "About"

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        MsgBox("Developed by Ryan O'Day © 2015")
    End Sub

    Private Sub GithubPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GithubPageToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.github.com/theryan722")
    End Sub

    Private Sub ProjectPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectPageToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.github.com/theryan722/Ozone.LanguageDetector")
    End Sub

#End Region

#End Region
    
End Class
