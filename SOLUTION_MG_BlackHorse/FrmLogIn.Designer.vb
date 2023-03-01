<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogIn))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbGodina = New System.Windows.Forms.ComboBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.PanelMohokSoft = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(217, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 24)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Godina"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbGodina
        '
        Me.CmbGodina.BackColor = System.Drawing.Color.White
        Me.CmbGodina.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.CmbGodina.FormattingEnabled = True
        Me.CmbGodina.Location = New System.Drawing.Point(217, 95)
        Me.CmbGodina.Name = "CmbGodina"
        Me.CmbGodina.Size = New System.Drawing.Size(88, 21)
        Me.CmbGodina.TabIndex = 14
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.Transparent
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ForeColor = System.Drawing.Color.Silver
        Me.Cancel.Location = New System.Drawing.Point(319, 140)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(100, 30)
        Me.Cancel.TabIndex = 13
        Me.Cancel.Text = "Odustani"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.Transparent
        Me.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.ForeColor = System.Drawing.Color.Silver
        Me.OK.Location = New System.Drawing.Point(217, 140)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(100, 30)
        Me.OK.TabIndex = 12
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = False
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.Color.White
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.TxtPassword.Location = New System.Drawing.Point(217, 41)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(197, 20)
        Me.TxtPassword.TabIndex = 11
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.White
        Me.PasswordLabel.Location = New System.Drawing.Point(217, 17)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(129, 22)
        Me.PasswordLabel.TabIndex = 10
        Me.PasswordLabel.Text = "Lozinka"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelMohokSoft
        '
        Me.PanelMohokSoft.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelMohokSoft.AutoScroll = True
        Me.PanelMohokSoft.BackColor = System.Drawing.Color.Transparent
        Me.PanelMohokSoft.BackgroundImage = CType(resources.GetObject("PanelMohokSoft.BackgroundImage"), System.Drawing.Image)
        Me.PanelMohokSoft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelMohokSoft.Location = New System.Drawing.Point(12, 11)
        Me.PanelMohokSoft.Name = "PanelMohokSoft"
        Me.PanelMohokSoft.Size = New System.Drawing.Size(111, 50)
        Me.PanelMohokSoft.TabIndex = 121
        '
        'FrmLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(450, 200)
        Me.Controls.Add(Me.PanelMohokSoft)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbGodina)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.PasswordLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLogIn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CmbGodina As ComboBox
    Friend WithEvents Cancel As Button
    Friend WithEvents OK As Button
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents PanelMohokSoft As Panel
End Class
