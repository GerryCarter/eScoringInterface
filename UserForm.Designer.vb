<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserForm))
        Me.txtPilotNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.CompName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPilotNumber
        '
        Me.txtPilotNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPilotNumber.Location = New System.Drawing.Point(136, 61)
        Me.txtPilotNumber.Name = "txtPilotNumber"
        Me.txtPilotNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPilotNumber.Size = New System.Drawing.Size(75, 28)
        Me.txtPilotNumber.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Pilot Number"
        '
        'btnConnect
        '
        Me.btnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.Location = New System.Drawing.Point(239, 56)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(104, 38)
        Me.btnConnect.TabIndex = 1
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 119)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(580, 602)
        Me.WebBrowser1.TabIndex = 9
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(488, 56)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 38)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'CompName
        '
        Me.CompName.AutoEllipsis = True
        Me.CompName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompName.Location = New System.Drawing.Point(12, 9)
        Me.CompName.Name = "CompName"
        Me.CompName.Size = New System.Drawing.Size(580, 32)
        Me.CompName.TabIndex = 11
        Me.CompName.Text = "Competition Name"
        Me.CompName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserForm
        '
        Me.AcceptButton = Me.btnConnect
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 733)
        Me.Controls.Add(Me.CompName)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.txtPilotNumber)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UserForm"
        Me.Text = "eScoring Interface"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPilotNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnConnect As Button
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents btnClear As Button
    Friend WithEvents CompName As Label
End Class
