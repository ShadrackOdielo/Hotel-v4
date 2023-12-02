Imports MySql.Data.MySqlClient

Public Class Form1
    Dim connectionString As String = "Server=localhost;Database=HotelManagementSystem;Uid=root;Pwd="

    Private Sub btnRetrieveData_Click(sender As Object, e As EventArgs) Handles btnRetrieveData.Click
        RetrieveData()
    End Sub

    Private Sub RetrieveData()
        Try
            Using connection As MySqlConnection = New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM Room"
                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim ds As New DataSet()

                adapter.Fill(ds, "Room")

                DataGridView1.DataSource = ds.Tables("Room")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click
        Dim addRoomForm As New AddRoomForm()
        addRoomForm.ShowDialog()
        ' Optionally, you can refresh the DataGridView after adding a new room
        RetrieveData()
    End Sub
End Class
