Imports System.Windows.Forms

Public Class AdminDashboardForm
    Private Sub btnManageRooms_Click(sender As Object, e As EventArgs) Handles btnManageRooms.Click
        Form1.Show()
        MessageBox.Show("Opening room management page.", "Admin Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    ' Add other event handlers for additional buttons and functionality as needed
End Class
