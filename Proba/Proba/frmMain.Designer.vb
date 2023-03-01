<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.CmdHello = New System.Windows.Forms.Button()
        Me.ChkOK = New System.Windows.Forms.CheckBox()
        Me.TxtA = New System.Windows.Forms.TextBox()
        Me.TxtB = New System.Windows.Forms.TextBox()
        Me.CmdSabiranje = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblDisplej = New System.Windows.Forms.Label()
        Me.TxtDisplej = New System.Windows.Forms.TextBox()
        Me.CmdIzlaz = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.SuspendLayout()
        '
        'CmdHello
        '
        Me.CmdHello.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdHello.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdHello.ForeColor = System.Drawing.Color.Blue
        Me.CmdHello.Location = New System.Drawing.Point(630, 49)
        Me.CmdHello.Name = "CmdHello"
        Me.CmdHello.Size = New System.Drawing.Size(143, 59)
        Me.CmdHello.TabIndex = 0
        Me.CmdHello.Text = "Hello"
        Me.CmdHello.UseVisualStyleBackColor = False
        '
        'ChkOK
        '
        Me.ChkOK.AutoSize = True
        Me.ChkOK.Location = New System.Drawing.Point(539, 76)
        Me.ChkOK.Name = "ChkOK"
        Me.ChkOK.Size = New System.Drawing.Size(41, 17)
        Me.ChkOK.TabIndex = 2
        Me.ChkOK.Text = "OK"
        Me.ChkOK.UseVisualStyleBackColor = True
        '
        'TxtA
        '
        Me.TxtA.Location = New System.Drawing.Point(317, 88)
        Me.TxtA.Name = "TxtA"
        Me.TxtA.Size = New System.Drawing.Size(100, 20)
        Me.TxtA.TabIndex = 3
        '
        'TxtB
        '
        Me.TxtB.Location = New System.Drawing.Point(317, 148)
        Me.TxtB.Name = "TxtB"
        Me.TxtB.Size = New System.Drawing.Size(100, 20)
        Me.TxtB.TabIndex = 4
        '
        'CmdSabiranje
        '
        Me.CmdSabiranje.Location = New System.Drawing.Point(527, 144)
        Me.CmdSabiranje.Name = "CmdSabiranje"
        Me.CmdSabiranje.Size = New System.Drawing.Size(75, 23)
        Me.CmdSabiranje.TabIndex = 5
        Me.CmdSabiranje.Text = "A + B"
        Me.CmdSabiranje.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(317, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Sabirak A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(317, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Sabirak B"
        '
        'LblDisplej
        '
        Me.LblDisplej.AutoSize = True
        Me.LblDisplej.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDisplej.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDisplej.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblDisplej.Location = New System.Drawing.Point(419, 264)
        Me.LblDisplej.Name = "LblDisplej"
        Me.LblDisplej.Size = New System.Drawing.Size(2, 57)
        Me.LblDisplej.TabIndex = 8
        '
        'TxtDisplej
        '
        Me.TxtDisplej.Location = New System.Drawing.Point(419, 364)
        Me.TxtDisplej.Name = "TxtDisplej"
        Me.TxtDisplej.Size = New System.Drawing.Size(100, 20)
        Me.TxtDisplej.TabIndex = 9
        '
        'CmdIzlaz
        '
        Me.CmdIzlaz.Location = New System.Drawing.Point(672, 389)
        Me.CmdIzlaz.Name = "CmdIzlaz"
        Me.CmdIzlaz.Size = New System.Drawing.Size(75, 23)
        Me.CmdIzlaz.TabIndex = 10
        Me.CmdIzlaz.Text = "Izlaz"
        Me.CmdIzlaz.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(90, 206)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 11
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(76, 250)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 12
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.CmdIzlaz)
        Me.Controls.Add(Me.TxtDisplej)
        Me.Controls.Add(Me.LblDisplej)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmdSabiranje)
        Me.Controls.Add(Me.TxtB)
        Me.Controls.Add(Me.TxtA)
        Me.Controls.Add(Me.ChkOK)
        Me.Controls.Add(Me.CmdHello)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.Text = "Proba"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmdHello As Button
    Friend WithEvents ChkOK As CheckBox
    Friend WithEvents TxtA As TextBox
    Friend WithEvents TxtB As TextBox
    Friend WithEvents CmdSabiranje As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblDisplej As Label
    Friend WithEvents TxtDisplej As TextBox
    Friend WithEvents CmdIzlaz As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents MonthCalendar1 As MonthCalendar
End Class
