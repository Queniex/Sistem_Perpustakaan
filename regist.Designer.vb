<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class regist
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
        Me.BtnRegist = New System.Windows.Forms.Button()
        Me.TxtPass2 = New System.Windows.Forms.TextBox()
        Me.TxtUser2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnRegist
        '
        Me.BtnRegist.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnRegist.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnRegist.Location = New System.Drawing.Point(221, 113)
        Me.BtnRegist.Name = "BtnRegist"
        Me.BtnRegist.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegist.TabIndex = 9
        Me.BtnRegist.Text = "Register"
        Me.BtnRegist.UseVisualStyleBackColor = False
        '
        'TxtPass2
        '
        Me.TxtPass2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtPass2.Location = New System.Drawing.Point(78, 64)
        Me.TxtPass2.Name = "TxtPass2"
        Me.TxtPass2.Size = New System.Drawing.Size(218, 23)
        Me.TxtPass2.TabIndex = 8
        '
        'TxtUser2
        '
        Me.TxtUser2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtUser2.Location = New System.Drawing.Point(78, 26)
        Me.TxtUser2.Name = "TxtUser2"
        Me.TxtUser2.Size = New System.Drawing.Size(218, 23)
        Me.TxtUser2.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password  :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Username :"
        '
        'regist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(317, 162)
        Me.Controls.Add(Me.BtnRegist)
        Me.Controls.Add(Me.TxtPass2)
        Me.Controls.Add(Me.TxtUser2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "regist"
        Me.Text = "regist"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRegist As Button
    Friend WithEvents TxtPass2 As TextBox
    Friend WithEvents TxtUser2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
