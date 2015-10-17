<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Problembintang
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
        Me.enter1 = New System.Windows.Forms.TextBox()
        Me.Sub1 = New System.Windows.Forms.Button()
        Me.polacombo1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.hasil1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'enter1
        '
        Me.enter1.Location = New System.Drawing.Point(78, 39)
        Me.enter1.Name = "enter1"
        Me.enter1.Size = New System.Drawing.Size(294, 20)
        Me.enter1.TabIndex = 0
        '
        'Sub1
        '
        Me.Sub1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sub1.ForeColor = System.Drawing.Color.Black
        Me.Sub1.Location = New System.Drawing.Point(378, 39)
        Me.Sub1.Name = "Sub1"
        Me.Sub1.Size = New System.Drawing.Size(75, 23)
        Me.Sub1.TabIndex = 1
        Me.Sub1.Text = "Submit"
        Me.Sub1.UseVisualStyleBackColor = True
        '
        'polacombo1
        '
        Me.polacombo1.FormattingEnabled = True
        Me.polacombo1.Items.AddRange(New Object() {"Pyramid", "Hollow Pyramid", "Inverted Pyramid", "Hollow Inverted Pyramid"})
        Me.polacombo1.Location = New System.Drawing.Point(78, 12)
        Me.polacombo1.Name = "polacombo1"
        Me.polacombo1.Size = New System.Drawing.Size(375, 21)
        Me.polacombo1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Wide Latin", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Pola"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Wide Latin", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Baris"
        '
        'hasil1
        '
        Me.hasil1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.hasil1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hasil1.Location = New System.Drawing.Point(12, 65)
        Me.hasil1.Multiline = True
        Me.hasil1.Name = "hasil1"
        Me.hasil1.ReadOnly = True
        Me.hasil1.Size = New System.Drawing.Size(441, 348)
        Me.hasil1.TabIndex = 5
        '
        'Problembintang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 425)
        Me.Controls.Add(Me.hasil1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.polacombo1)
        Me.Controls.Add(Me.Sub1)
        Me.Controls.Add(Me.enter1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Problembintang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Problem Bintang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents enter1 As System.Windows.Forms.TextBox
    Friend WithEvents Sub1 As System.Windows.Forms.Button
    Friend WithEvents polacombo1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents hasil1 As System.Windows.Forms.TextBox
End Class
