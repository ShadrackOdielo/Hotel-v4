Public Class MainForm
    Private ReadOnly roleID As Integer

    Public Sub New(roleID As Integer)
        InitializeComponent()
        Me.roleID = roleID
        CustomizeForm()
    End Sub

    Private Sub CustomizeForm()
        If roleID = 1 Then ' Admin
            ' Show admin features (buttons, etc.)
            Dim adminDashboardForm As New AdminDashboardForm()
            adminDashboardForm.Show()
            Me.Hide()
        Else ' Guest
            ' Show guest features (buttons, etc.)
            ' Example: btnReserveRoom.Visible = True
        End If
    End Sub
End Class
