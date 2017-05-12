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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSHA1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSHA256 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSHA384 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSHA512 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Text:"
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(15, 71)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(356, 20)
        Me.txtText.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SHA1:"
        '
        'txtSHA1
        '
        Me.txtSHA1.Location = New System.Drawing.Point(15, 110)
        Me.txtSHA1.Name = "txtSHA1"
        Me.txtSHA1.Size = New System.Drawing.Size(356, 20)
        Me.txtSHA1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "SHA256:"
        '
        'txtSHA256
        '
        Me.txtSHA256.Location = New System.Drawing.Point(15, 149)
        Me.txtSHA256.Name = "txtSHA256"
        Me.txtSHA256.Size = New System.Drawing.Size(356, 20)
        Me.txtSHA256.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "SHA384:"
        '
        'txtSHA384
        '
        Me.txtSHA384.Location = New System.Drawing.Point(15, 188)
        Me.txtSHA384.Name = "txtSHA384"
        Me.txtSHA384.Size = New System.Drawing.Size(356, 20)
        Me.txtSHA384.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "SHA512:"
        '
        'txtSHA512
        '
        Me.txtSHA512.Location = New System.Drawing.Point(15, 227)
        Me.txtSHA512.Name = "txtSHA512"
        Me.txtSHA512.Size = New System.Drawing.Size(356, 20)
        Me.txtSHA512.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "File:"
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(15, 32)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(275, 20)
        Me.txtFile.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(296, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 21)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "OPEN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 265)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSHA512)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSHA384)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSHA256)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSHA1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SHA Hash Generator by KRIPT4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtText As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSHA1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSHA256 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSHA384 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSHA512 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFile As TextBox
    Friend WithEvents Button1 As Button
End Class
