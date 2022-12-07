Imports System.Buffers
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.VisualBasic.ApplicationServices
Imports perpustakaan.Users

Public Class Login

    Public Shared Users As Users
    Public Shared Perpustakaan As Perpustakaan
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Users = New Users()
        Perpustakaan = New Perpustakaan()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim plainUsername As String = TxtUser.Text
        Dim plainPassword As String = TxtPass.Text
        Dim chk = Users.CheckAuth(plainUsername, plainPassword)
        Dim count = chk.Count
        'MessageBox.Show(chk)

        If count > 0 Then
            Users.GSUserName = chk(0)(1)
            Perpustakaan.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong Password/Username")
        End If

        'Dim AuthStatus As Boolean

        'AuthStatus = Users.CheckAuth(plainUsername, plainPassword)
        'If AuthStatus Then
        '    Perpustakaan.Show()
        'Else
        '    MessageBox.Show("Wrong Password")
        'End If
    End Sub

    Private Sub BtnReg_Click(sender As Object, e As EventArgs) Handles BtnReg.Click
        regist.Show()
    End Sub

End Class