#Region "ABOUT"
' / --------------------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / eMail : thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: https://www.facebook.com/g2gnet (For Thailand)
' / Facebook: https://www.facebook.com/commonindy (Worldwide)
' / More Info: http://www.g2gnet.com/webboard
' /
' / Purpose: Counter number with images.
' / Microsoft Visual Basic .NET (2010)
' /
' / This is open source code under @CopyLeft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / --------------------------------------------------------------------------------
#End Region

Public Class frmCountPoint

    Private Sub btnRandom_Click(sender As System.Object, e As System.EventArgs) Handles btnRandom.Click
        Randomize()
        Dim rnd As New Random
        Label1.Text = rnd.Next(1, 499)
        Call CheckImage(Val(Label1.Text))
    End Sub

    Sub CheckImage(ByVal Num As Integer)
        '// Specified Path.
        Dim ImagePath As String = MyPath(Application.StartupPath) & "Images\"
        '//
        Select Case Val(Label1.Text) Mod 5
            Case 0  '// 5, 10, 15, 20 ... Mod 5 = 0
                PictureBox1.Image = Image.FromFile(ImagePath & "5.jpg")
            Case 1
                PictureBox1.Image = Image.FromFile(ImagePath & "1.jpg")
            Case 2
                PictureBox1.Image = Image.FromFile(ImagePath & "2.jpg")
            Case 3
                PictureBox1.Image = Image.FromFile(ImagePath & "3.jpg")
            Case 4
                PictureBox1.Image = Image.FromFile(ImagePath & "4.jpg")
        End Select
    End Sub

    Private Sub btnIncrement_Click(sender As System.Object, e As System.EventArgs) Handles btnIncrement.Click
        Label1.Text += 1
        Call CheckImage(Val(Label1.Text))
    End Sub

    Private Sub btnDecrement_Click(sender As System.Object, e As System.EventArgs) Handles btnDecrement.Click
        Label1.Text -= 1
        Call CheckImage(Val(Label1.Text))
    End Sub

    Private Sub frmCountPoint_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call btnRandom_Click(sender, e)
    End Sub

    Private Sub frmCountPoint_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        GC.SuppressFinalize(Me)
        Application.Exit()
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / Get my project path
    ' / AppPath = C:\My Project\bin\debug
    ' / Replace "\bin\debug" with "\"
    ' / Return : C:\My Project\
    Function MyPath(ByVal AppPath As String) As String
        '/ Return Value
        MyPath = AppPath.ToLower.Replace("\bin\debug", "\").Replace("\bin\release", "\").Replace("\bin\x86\debug", "\")
        '// If not found folder then put the \ (BackSlash) at the end.
        If Microsoft.VisualBasic.Right(MyPath, 1) <> Chr(92) Then MyPath = MyPath & Chr(92)
    End Function

End Class
