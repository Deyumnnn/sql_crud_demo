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
        Me.ButtonConnect1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxHiddenId = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxAge = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.ButtonCreate = New System.Windows.Forms.Button()
        Me.ButtonRead = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonConnect1
        '
        Me.ButtonConnect1.Location = New System.Drawing.Point(24, 26)
        Me.ButtonConnect1.Name = "ButtonConnect1"
        Me.ButtonConnect1.Size = New System.Drawing.Size(196, 110)
        Me.ButtonConnect1.TabIndex = 0
        Me.ButtonConnect1.Text = "ConnectMySQL"
        Me.ButtonConnect1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Age:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Email:"
        '
        'TextBoxHiddenId
        '
        Me.TextBoxHiddenId.Location = New System.Drawing.Point(120, 151)
        Me.TextBoxHiddenId.Name = "TextBoxHiddenId"
        Me.TextBoxHiddenId.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHiddenId.TabIndex = 4
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(120, 187)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxName.TabIndex = 5
        '
        'TextBoxAge
        '
        Me.TextBoxAge.Location = New System.Drawing.Point(120, 222)
        Me.TextBoxAge.Name = "TextBoxAge"
        Me.TextBoxAge.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAge.TabIndex = 6
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(120, 260)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxEmail.TabIndex = 7
        '
        'ButtonCreate
        '
        Me.ButtonCreate.Location = New System.Drawing.Point(78, 297)
        Me.ButtonCreate.Name = "ButtonCreate"
        Me.ButtonCreate.Size = New System.Drawing.Size(75, 42)
        Me.ButtonCreate.TabIndex = 8
        Me.ButtonCreate.Text = "Button (Insert Data)"
        Me.ButtonCreate.UseVisualStyleBackColor = True
        '
        'ButtonRead
        '
        Me.ButtonRead.Location = New System.Drawing.Point(184, 297)
        Me.ButtonRead.Name = "ButtonRead"
        Me.ButtonRead.Size = New System.Drawing.Size(75, 42)
        Me.ButtonRead.TabIndex = 9
        Me.ButtonRead.Text = "Read (Get Data)"
        Me.ButtonRead.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(40, 356)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(259, 151)
        Me.DataGridView1.TabIndex = 10
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(389, 78)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUpdate.TabIndex = 11
        Me.ButtonUpdate.Text = "Button1"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 519)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonRead)
        Me.Controls.Add(Me.ButtonCreate)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.TextBoxAge)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.TextBoxHiddenId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonConnect1)
        Me.Name = "Form1"
        Me.Text = "Email:"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonConnect1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxHiddenId As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxAge As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents ButtonCreate As Button
    Friend WithEvents ButtonRead As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonUpdate As Button
End Class
