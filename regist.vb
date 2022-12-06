
Public Class regist

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub BtnRegist_Click(sender As Object, e As EventArgs) Handles BtnRegist.Click

        If TxtUser2.Text.Length > 0 And TxtPass2.Text.Length > 0 Then
            Login.Users.AddUsers(TxtUser2.Text, TxtPass2.Text)
            Me.Close()
        Else
            MessageBox.Show("Lengkapi Data")
        End If

        'Dim plainUsername As String = TxtUser2.Text
        'Dim plainPassword As String = TxtPass2.Text
        'Login.Users.AddRegist(plainUsername, plainPassword)
        'MessageBox.Show("Register Successfully!")
        'Login.Show()
        'Me.Close()

        'Users.CheckAuth(plainUsername, plainPassword)
        'If Users.GetKoleksiAcc.Count > 0 Then
        '    MessageBox.Show(Users.GetKoleksiAcc.Count)
        'End If
    End Sub

    Private Sub TxtUser2_Leave(sender As Object, e As EventArgs) Handles TxtUser2.Leave
        If TxtUser2.Text.Length < 1 Then
            TxtUser2.Select()
            MessageBox.Show("Username tidak boleh kosong!")
        End If
    End Sub

    Private Sub TxtPass2_Leave(sender As Object, e As EventArgs) Handles TxtPass2.Leave
        If TxtPass2.Text.Length < 1 Then
            TxtPass2.Select()
            MessageBox.Show("Password tidak boleh kosong!")
        End If
    End Sub
End Class