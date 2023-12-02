Imports MySql.Data.MySqlClient

Public Class AddRoomForm
    Dim connectionString As String = "Server=localhost;Database=HotelManagementSystem;Uid=root;Pwd="

    Private Sub btnSaveRoom_Click(sender As Object, e As EventArgs) Handles btnSaveRoom.Click
        AddNewRoom()
    End Sub

    Private Sub AddNewRoom()
        Try
            Using connection As MySqlConnection = New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO Room (roomNumber, styleID, statusID, bookingPrice, isSmoking) VALUES (@roomNumber, @styleID, @statusID, @bookingPrice, @isSmoking)"

                Dim command As MySqlCommand = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@roomNumber", txtRoomNumber.Text)
                command.Parameters.AddWithValue("@styleID", Convert.ToInt32(cmbStyle.SelectedValue))
                command.Parameters.AddWithValue("@statusID", Convert.ToInt32(cmbStatus.SelectedValue))
                command.Parameters.AddWithValue("@bookingPrice", Convert.ToDouble(txtBookingPrice.Text))
                command.Parameters.AddWithValue("@isSmoking", Convert.ToInt32(chkIsSmoking.Checked))

                command.ExecuteNonQuery()

                MessageBox.Show("Room added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding room: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
