<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    ' ... (Other auto-generated code)

    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnRetrieveData As System.Windows.Forms.Button

    ' ... (Other auto-generated code)

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' ... (Other auto-generated code)

    ' Initialize components
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnRetrieveData = New System.Windows.Forms.Button()
        Me.btnAddRoom = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(776, 270)
        Me.DataGridView1.TabIndex = 0
        '
        'btnRetrieveData
        '
        Me.btnRetrieveData.Location = New System.Drawing.Point(12, 12)
        Me.btnRetrieveData.Name = "btnRetrieveData"
        Me.btnRetrieveData.Size = New System.Drawing.Size(115, 23)
        Me.btnRetrieveData.TabIndex = 1
        Me.btnRetrieveData.Text = "Show rooms"
        '
        'btnAddRoom
        '
        Me.btnAddRoom.Location = New System.Drawing.Point(429, 12)
        Me.btnAddRoom.Name = "btnAddRoom"
        Me.btnAddRoom.Size = New System.Drawing.Size(75, 23)
        Me.btnAddRoom.TabIndex = 2
        Me.btnAddRoom.Text = "Add a Room"
        Me.btnAddRoom.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAddRoom)
        Me.Controls.Add(Me.btnRetrieveData)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddRoom As Button
End Class
