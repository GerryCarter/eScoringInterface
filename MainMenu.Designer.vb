<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.btnInfoCompID = New System.Windows.Forms.Button()
        Me.txtCompID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtWebsite = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCompName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUserForm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnInfoCompID
        '
        Me.btnInfoCompID.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnInfoCompID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnInfoCompID.Location = New System.Drawing.Point(541, 87)
        Me.btnInfoCompID.Name = "btnInfoCompID"
        Me.btnInfoCompID.Size = New System.Drawing.Size(28, 25)
        Me.btnInfoCompID.TabIndex = 14
        Me.btnInfoCompID.Text = "i"
        '
        'txtCompID
        '
        Me.txtCompID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompID.Location = New System.Drawing.Point(171, 86)
        Me.txtCompID.Name = "txtCompID"
        Me.txtCompID.Size = New System.Drawing.Size(188, 28)
        Me.txtCompID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "CompID"
        '
        'txtWebsite
        '
        Me.txtWebsite.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWebsite.Location = New System.Drawing.Point(172, 23)
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.ReadOnly = True
        Me.txtWebsite.Size = New System.Drawing.Size(397, 28)
        Me.txtWebsite.TabIndex = 11
        Me.txtWebsite.Text = "http://gliderscore.com/eScoring.aspx"
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Website"
        '
        'txtCompName
        '
        Me.txtCompName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompName.Location = New System.Drawing.Point(171, 54)
        Me.txtCompName.Name = "txtCompName"
        Me.txtCompName.Size = New System.Drawing.Size(398, 28)
        Me.txtCompName.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Comp Name"
        '
        'btnUserForm
        '
        Me.btnUserForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserForm.Location = New System.Drawing.Point(385, 132)
        Me.btnUserForm.Name = "btnUserForm"
        Me.btnUserForm.Size = New System.Drawing.Size(184, 42)
        Me.btnUserForm.TabIndex = 5
        Me.btnUserForm.Text = "Open User Form"
        Me.btnUserForm.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AcceptButton = Me.btnUserForm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 197)
        Me.Controls.Add(Me.btnUserForm)
        Me.Controls.Add(Me.txtCompName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnInfoCompID)
        Me.Controls.Add(Me.txtCompID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtWebsite)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInfoCompID As Button
    Friend WithEvents txtCompID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtWebsite As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCompName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnUserForm As Button
End Class
