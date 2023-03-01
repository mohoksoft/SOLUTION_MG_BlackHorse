<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSifarnikDrzava
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
        Me.components = New System.ComponentModel.Container()
        Dim Label1 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSifarnikDrzava))
        Me.TxtNaziv = New System.Windows.Forms.TextBox()
        Me.tmrDelay = New System.Windows.Forms.Timer(Me.components)
        Me.TxtSifra = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CmdNovi = New System.Windows.Forms.Button()
        Me.CmdSnimi = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PnlOK = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdIzlaz = New System.Windows.Forms.Button()
        Me.TxtNapomena = New System.Windows.Forms.TextBox()
        Me.ChkPasivan = New System.Windows.Forms.CheckBox()
        Me.TmrIndikatorGreske = New System.Windows.Forms.Timer(Me.components)
        Me.erpIndikatorGreske = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ttInfo = New System.Windows.Forms.ToolTip(Me.components)
        Label1 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.erpIndikatorGreske, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Label1.Location = New System.Drawing.Point(48, 126)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(59, 16)
        Label1.TabIndex = 291
        Label1.Text = "Država:"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.BackColor = System.Drawing.Color.Transparent
        Label15.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label15.ForeColor = System.Drawing.Color.White
        Label15.Location = New System.Drawing.Point(12, 7)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(97, 25)
        Label15.TabIndex = 283
        Label15.Text = "DRŽAVA"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Label2.Location = New System.Drawing.Point(48, 186)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(82, 16)
        Label2.TabIndex = 456
        Label2.Text = "Napomena:"
        '
        'TxtNaziv
        '
        Me.TxtNaziv.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNaziv.Location = New System.Drawing.Point(51, 145)
        Me.TxtNaziv.Name = "TxtNaziv"
        Me.TxtNaziv.Size = New System.Drawing.Size(300, 23)
        Me.TxtNaziv.TabIndex = 2
        Me.TxtNaziv.Tag = "2"
        '
        'tmrDelay
        '
        Me.tmrDelay.Interval = 1000
        '
        'TxtSifra
        '
        Me.TxtSifra.Enabled = False
        Me.TxtSifra.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSifra.Location = New System.Drawing.Point(294, 107)
        Me.TxtSifra.Name = "TxtSifra"
        Me.TxtSifra.ReadOnly = True
        Me.TxtSifra.Size = New System.Drawing.Size(57, 23)
        Me.TxtSifra.TabIndex = 1
        Me.TxtSifra.Tag = "1"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.CmdNovi)
        Me.Panel2.Controls.Add(Me.CmdSnimi)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Location = New System.Drawing.Point(0, 310)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(405, 40)
        Me.Panel2.TabIndex = 294
        '
        'CmdNovi
        '
        Me.CmdNovi.BackColor = System.Drawing.Color.Transparent
        Me.CmdNovi.BackgroundImage = CType(resources.GetObject("CmdNovi.BackgroundImage"), System.Drawing.Image)
        Me.CmdNovi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdNovi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdNovi.FlatAppearance.BorderSize = 0
        Me.CmdNovi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.CmdNovi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.CmdNovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdNovi.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNovi.ForeColor = System.Drawing.Color.White
        Me.CmdNovi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdNovi.Location = New System.Drawing.Point(80, 0)
        Me.CmdNovi.Name = "CmdNovi"
        Me.CmdNovi.Size = New System.Drawing.Size(120, 40)
        Me.CmdNovi.TabIndex = 216
        Me.CmdNovi.Text = "Novi"
        Me.ttInfo.SetToolTip(Me.CmdNovi, "Nova država")
        Me.CmdNovi.UseVisualStyleBackColor = False
        '
        'CmdSnimi
        '
        Me.CmdSnimi.BackColor = System.Drawing.Color.Transparent
        Me.CmdSnimi.BackgroundImage = CType(resources.GetObject("CmdSnimi.BackgroundImage"), System.Drawing.Image)
        Me.CmdSnimi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdSnimi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdSnimi.FlatAppearance.BorderSize = 0
        Me.CmdSnimi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.CmdSnimi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.CmdSnimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdSnimi.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSnimi.ForeColor = System.Drawing.Color.White
        Me.CmdSnimi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSnimi.Location = New System.Drawing.Point(205, 0)
        Me.CmdSnimi.Name = "CmdSnimi"
        Me.CmdSnimi.Size = New System.Drawing.Size(120, 40)
        Me.CmdSnimi.TabIndex = 215
        Me.CmdSnimi.Text = "Snimi"
        Me.ttInfo.SetToolTip(Me.CmdSnimi, "Snimi unete podatke")
        Me.CmdSnimi.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel3.Location = New System.Drawing.Point(330, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(75, 40)
        Me.Panel3.TabIndex = 214
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(75, 40)
        Me.Panel4.TabIndex = 213
        '
        'PnlOK
        '
        Me.PnlOK.BackColor = System.Drawing.Color.Transparent
        Me.PnlOK.BackgroundImage = CType(resources.GetObject("PnlOK.BackgroundImage"), System.Drawing.Image)
        Me.PnlOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlOK.Location = New System.Drawing.Point(148, 46)
        Me.PnlOK.Name = "PnlOK"
        Me.PnlOK.Size = New System.Drawing.Size(70, 60)
        Me.PnlOK.TabIndex = 377
        Me.PnlOK.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmdIzlaz)
        Me.Panel1.Controls.Add(Label15)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(405, 40)
        Me.Panel1.TabIndex = 454
        '
        'cmdIzlaz
        '
        Me.cmdIzlaz.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdIzlaz.BackColor = System.Drawing.Color.Transparent
        Me.cmdIzlaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdIzlaz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdIzlaz.FlatAppearance.BorderSize = 0
        Me.cmdIzlaz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.cmdIzlaz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.cmdIzlaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdIzlaz.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIzlaz.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.cmdIzlaz.Image = CType(resources.GetObject("cmdIzlaz.Image"), System.Drawing.Image)
        Me.cmdIzlaz.Location = New System.Drawing.Point(363, 4)
        Me.cmdIzlaz.Name = "cmdIzlaz"
        Me.cmdIzlaz.Size = New System.Drawing.Size(30, 30)
        Me.cmdIzlaz.TabIndex = 284
        Me.cmdIzlaz.UseVisualStyleBackColor = False
        '
        'TxtNapomena
        '
        Me.TxtNapomena.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNapomena.Location = New System.Drawing.Point(51, 208)
        Me.TxtNapomena.Multiline = True
        Me.TxtNapomena.Name = "TxtNapomena"
        Me.TxtNapomena.Size = New System.Drawing.Size(300, 65)
        Me.TxtNapomena.TabIndex = 3
        Me.TxtNapomena.Tag = "3"
        '
        'ChkPasivan
        '
        Me.ChkPasivan.AutoSize = True
        Me.ChkPasivan.BackColor = System.Drawing.Color.Transparent
        Me.ChkPasivan.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkPasivan.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPasivan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ChkPasivan.Location = New System.Drawing.Point(273, 63)
        Me.ChkPasivan.Name = "ChkPasivan"
        Me.ChkPasivan.Size = New System.Drawing.Size(78, 23)
        Me.ChkPasivan.TabIndex = 457
        Me.ChkPasivan.Text = "Pasivan"
        Me.ChkPasivan.UseVisualStyleBackColor = False
        '
        'TmrIndikatorGreske
        '
        Me.TmrIndikatorGreske.Interval = 5000
        '
        'erpIndikatorGreske
        '
        Me.erpIndikatorGreske.BlinkRate = 500
        Me.erpIndikatorGreske.ContainerControl = Me
        '
        'FrmSifarnikDrzava
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(405, 350)
        Me.Controls.Add(Me.ChkPasivan)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TxtNapomena)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PnlOK)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TxtNaziv)
        Me.Controls.Add(Me.TxtSifra)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSifarnikDrzava"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmSifarnikDrzava"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.erpIndikatorGreske, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNaziv As TextBox
    Friend WithEvents tmrDelay As Timer
    Friend WithEvents TxtSifra As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PnlOK As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdIzlaz As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents CmdSnimi As Button
    Friend WithEvents TxtNapomena As TextBox
    Friend WithEvents ChkPasivan As CheckBox
    Friend WithEvents CmdNovi As Button
    Friend WithEvents TmrIndikatorGreske As Timer
    Friend WithEvents erpIndikatorGreske As ErrorProvider
    Friend WithEvents ttInfo As ToolTip
End Class
