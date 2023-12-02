<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    Friend WithEvents btnReserveRoom As Button

    Private Sub InitializeComponent()
        Me.btnReserveRoom = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReserveRoom
        '
        Me.btnReserveRoom.Location = New System.Drawing.Point(80, 100)
        Me.btnReserveRoom.Name = "btnReserveRoom"
        Me.btnReserveRoom.Size = New System.Drawing.Size(120, 30)
        Me.btnReserveRoom.TabIndex = 0
        Me.btnReserveRoom.Text = "Reserve Room"
        Me.btnReserveRoom.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 261)
        Me.Controls.Add(Me.btnReserveRoom)
        Me.Name = "MainForm"
        Me.Text = "Main Form"
        Me.ResumeLayout(False)
    End Sub
End Class
