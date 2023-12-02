<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddRoomForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSaveRoom = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRoomNumber = New System.Windows.Forms.TextBox()
        Me.cmbStyle = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.txtBookingPrice = New System.Windows.Forms.TextBox()
        Me.chkIsSmoking = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnSaveRoom
        '
        Me.btnSaveRoom.Location = New System.Drawing.Point(94, 158)
        Me.btnSaveRoom.Name = "btnSaveRoom"
        Me.btnSaveRoom.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveRoom.TabIndex = 0
        Me.btnSaveRoom.Text = "Save Room"
        Me.btnSaveRoom.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Room Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Style"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Booking Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Is Smoking"
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.Location = New System.Drawing.Point(107, 20)
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtRoomNumber.TabIndex = 6
        '
        'cmbStyle
        '
        Me.cmbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStyle.FormattingEnabled = True
        Me.cmbStyle.Items.AddRange(New Object() {"Standard", "Deluxe", "Family Suite", "Business Suite"})
        Me.cmbStyle.Location = New System.Drawing.Point(107, 47)
        Me.cmbStyle.Name = "cmbStyle"
        Me.cmbStyle.Size = New System.Drawing.Size(121, 21)
        Me.cmbStyle.TabIndex = 7
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Unpaid", "Available", "Pending", "Reserved", "Completed", "Occupied", "Failed", "NotAvailable", "Declined", "BeingServiced", "Cancelled", "Other", "Abandoned", "Settling", "Settled", "Refunded"})
        Me.cmbStatus.Location = New System.Drawing.Point(107, 74)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(121, 21)
        Me.cmbStatus.TabIndex = 8
        '
        'txtBookingPrice
        '
        Me.txtBookingPrice.Location = New System.Drawing.Point(107, 101)
        Me.txtBookingPrice.Name = "txtBookingPrice"
        Me.txtBookingPrice.Size = New System.Drawing.Size(121, 20)
        Me.txtBookingPrice.TabIndex = 9
        '
        'chkIsSmoking
        '
        Me.chkIsSmoking.AutoSize = True
        Me.chkIsSmoking.Location = New System.Drawing.Point(107, 132)
        Me.chkIsSmoking.Name = "chkIsSmoking"
        Me.chkIsSmoking.Size = New System.Drawing.Size(15, 14)
        Me.chkIsSmoking.TabIndex = 10
        Me.chkIsSmoking.UseVisualStyleBackColor = True
        '
        'AddRoomForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 193)
        Me.Controls.Add(Me.chkIsSmoking)
        Me.Controls.Add(Me.txtBookingPrice)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.cmbStyle)
        Me.Controls.Add(Me.txtRoomNumber)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSaveRoom)
        Me.Name = "AddRoomForm"
        Me.Text = "Add Room"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSaveRoom As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRoomNumber As TextBox
    Friend WithEvents cmbStyle As ComboBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents txtBookingPrice As TextBox
    Friend WithEvents chkIsSmoking As CheckBox
End Class
