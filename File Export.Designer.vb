<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.AddBox = New System.Windows.Forms.TextBox()
        Me.AgeBox = New System.Windows.Forms.TextBox()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.address = New System.Windows.Forms.Label()
        Me.age = New System.Windows.Forms.Label()
        Me.pangalan = New System.Windows.Forms.Label()
        Me.json_btn = New System.Windows.Forms.Button()
        Me.xml_btn = New System.Windows.Forms.Button()
        Me.text_btn = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.FileExporting = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AddBox
        '
        Me.AddBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBox.Location = New System.Drawing.Point(115, 122)
        Me.AddBox.Multiline = True
        Me.AddBox.Name = "AddBox"
        Me.AddBox.Size = New System.Drawing.Size(220, 58)
        Me.AddBox.TabIndex = 11
        '
        'AgeBox
        '
        Me.AgeBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeBox.Location = New System.Drawing.Point(115, 74)
        Me.AgeBox.Name = "AgeBox"
        Me.AgeBox.Size = New System.Drawing.Size(220, 23)
        Me.AgeBox.TabIndex = 10
        '
        'NameBox
        '
        Me.NameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameBox.Location = New System.Drawing.Point(115, 31)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(220, 23)
        Me.NameBox.TabIndex = 9
        '
        'address
        '
        Me.address.AutoSize = True
        Me.address.Font = New System.Drawing.Font("Monotype Corsiva", 15.0!)
        Me.address.Location = New System.Drawing.Point(22, 122)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(74, 24)
        Me.address.TabIndex = 8
        Me.address.Text = "Address :"
        '
        'age
        '
        Me.age.AutoSize = True
        Me.age.Font = New System.Drawing.Font("Monotype Corsiva", 15.0!)
        Me.age.Location = New System.Drawing.Point(22, 77)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(46, 24)
        Me.age.TabIndex = 7
        Me.age.Text = "Age :"
        '
        'pangalan
        '
        Me.pangalan.AutoSize = True
        Me.pangalan.Font = New System.Drawing.Font("Monotype Corsiva", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pangalan.Location = New System.Drawing.Point(22, 31)
        Me.pangalan.Name = "pangalan"
        Me.pangalan.Size = New System.Drawing.Size(60, 24)
        Me.pangalan.TabIndex = 6
        Me.pangalan.Text = "Name :"
        '
        'json_btn
        '
        Me.json_btn.AutoSize = True
        Me.json_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.json_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.json_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.json_btn.FlatAppearance.BorderSize = 0
        Me.json_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.json_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.json_btn.Location = New System.Drawing.Point(267, 200)
        Me.json_btn.Name = "json_btn"
        Me.json_btn.Size = New System.Drawing.Size(75, 35)
        Me.json_btn.TabIndex = 14
        Me.json_btn.Text = "JSON"
        Me.json_btn.UseVisualStyleBackColor = False
        '
        'xml_btn
        '
        Me.xml_btn.AutoSize = True
        Me.xml_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.xml_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.xml_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.xml_btn.FlatAppearance.BorderSize = 0
        Me.xml_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.xml_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.xml_btn.Location = New System.Drawing.Point(146, 201)
        Me.xml_btn.Name = "xml_btn"
        Me.xml_btn.Size = New System.Drawing.Size(75, 34)
        Me.xml_btn.TabIndex = 13
        Me.xml_btn.Text = "XML"
        Me.xml_btn.UseVisualStyleBackColor = False
        '
        'text_btn
        '
        Me.text_btn.AutoSize = True
        Me.text_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.text_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.text_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.text_btn.FlatAppearance.BorderSize = 0
        Me.text_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.text_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_btn.Location = New System.Drawing.Point(25, 200)
        Me.text_btn.Name = "text_btn"
        Me.text_btn.Size = New System.Drawing.Size(75, 35)
        Me.text_btn.TabIndex = 12
        Me.text_btn.Text = "Text"
        Me.text_btn.UseVisualStyleBackColor = False
        '
        'exit_btn
        '
        Me.exit_btn.FlatAppearance.BorderSize = 0
        Me.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exit_btn.ForeColor = System.Drawing.Color.Red
        Me.exit_btn.Location = New System.Drawing.Point(333, 2)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(24, 23)
        Me.exit_btn.TabIndex = 15
        Me.exit_btn.Text = "X"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'FileExporting
        '
        Me.FileExporting.AutoSize = True
        Me.FileExporting.Font = New System.Drawing.Font("Microsoft Yi Baiti", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileExporting.Location = New System.Drawing.Point(119, -1)
        Me.FileExporting.Name = "FileExporting"
        Me.FileExporting.Size = New System.Drawing.Size(130, 22)
        Me.FileExporting.TabIndex = 16
        Me.FileExporting.Text = "File Exporting"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(357, 251)
        Me.Controls.Add(Me.FileExporting)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.json_btn)
        Me.Controls.Add(Me.xml_btn)
        Me.Controls.Add(Me.text_btn)
        Me.Controls.Add(Me.AddBox)
        Me.Controls.Add(Me.AgeBox)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.pangalan)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Export"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddBox As TextBox
    Friend WithEvents AgeBox As TextBox
    Friend WithEvents NameBox As TextBox
    Friend WithEvents address As Label
    Friend WithEvents age As Label
    Friend WithEvents pangalan As Label
    Friend WithEvents json_btn As Button
    Friend WithEvents xml_btn As Button
    Friend WithEvents text_btn As Button
    Friend WithEvents exit_btn As Button
    Friend WithEvents FileExporting As Label
End Class
