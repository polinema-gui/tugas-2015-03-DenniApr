<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalMatrix
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.table2 = New System.Windows.Forms.TextBox()
        Me.table1 = New System.Windows.Forms.TextBox()
        Me.HasilBox = New System.Windows.Forms.TextBox()
        Me.operasi1 = New System.Windows.Forms.ComboBox()
        Me.Hitung1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'table2
        '
        Me.table2.Location = New System.Drawing.Point(77, 161)
        Me.table2.Multiline = True
        Me.table2.Name = "table2"
        Me.table2.Size = New System.Drawing.Size(351, 92)
        Me.table2.TabIndex = 1
        '
        'table1
        '
        Me.table1.Location = New System.Drawing.Point(77, 12)
        Me.table1.Multiline = True
        Me.table1.Name = "table1"
        Me.table1.Size = New System.Drawing.Size(351, 92)
        Me.table1.TabIndex = 2
        '
        'HasilBox
        '
        Me.HasilBox.Location = New System.Drawing.Point(77, 270)
        Me.HasilBox.Multiline = True
        Me.HasilBox.Name = "HasilBox"
        Me.HasilBox.ReadOnly = True
        Me.HasilBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.HasilBox.Size = New System.Drawing.Size(351, 92)
        Me.HasilBox.TabIndex = 3
        '
        'operasi1
        '
        Me.operasi1.FormattingEnabled = True
        Me.operasi1.Items.AddRange(New Object() {"Tambah", "Kurang"})
        Me.operasi1.Location = New System.Drawing.Point(77, 121)
        Me.operasi1.Name = "operasi1"
        Me.operasi1.Size = New System.Drawing.Size(352, 21)
        Me.operasi1.TabIndex = 4
        '
        'Hitung1
        '
        Me.Hitung1.Font = New System.Drawing.Font("Wide Latin", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hitung1.Location = New System.Drawing.Point(338, 367)
        Me.Hitung1.Name = "Hitung1"
        Me.Hitung1.Size = New System.Drawing.Size(90, 23)
        Me.Hitung1.TabIndex = 5
        Me.Hitung1.Text = "Hitung"
        Me.Hitung1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Matriks 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Operasi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Matriks 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Hasil"
        '
        'CalMatrix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 402)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Hitung1)
        Me.Controls.Add(Me.operasi1)
        Me.Controls.Add(Me.HasilBox)
        Me.Controls.Add(Me.table1)
        Me.Controls.Add(Me.table2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CalMatrix"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriks Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents table2 As System.Windows.Forms.TextBox
    Friend WithEvents table1 As System.Windows.Forms.TextBox
    Friend WithEvents HasilBox As System.Windows.Forms.TextBox
    Friend WithEvents operasi1 As System.Windows.Forms.ComboBox
    Friend WithEvents Hitung1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
