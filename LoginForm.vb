Imports MySql.Data.MySqlClient

Public Class LoginForm
    Dim connectionString As String = "Server=localhost;Database=HotelManagementSystem;Uid=root;Pwd="

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' Validate the user credentials
        If AuthenticateUser(username, password) Then
            ' Open the main form based on the user's role
            Dim mainForm As New MainForm(GetUserRoleID(username))
            mainForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Try
            Using connection As MySqlConnection = New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM `users` WHERE username = @username AND password = @password"
                Dim command As MySqlCommand = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    Return reader.HasRows
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error authenticating user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function GetUserRoleID(username As String) As Integer
        ' Retrieve the roleID for the user
        ' You may want to add error handling and improve this method based on your actual database structure
        Dim roleID As Integer = 0
        Try
            Using connection As MySqlConnection = New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT roleID FROM `users` WHERE username = @username"
                Dim command As MySqlCommand = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)

                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing Then
                    roleID = Convert.ToInt32(result)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error getting user role: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return roleID
    End Function
End Class
