<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSifarnikMagacini
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
        Dim Label2 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim ImeLabel As System.Windows.Forms.Label
        Dim SifraLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSifarnikMagacini))
        Me.tmrDelay = New System.Windows.Forms.Timer(Me.components)
        Me.ttInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.TmrIndikatorGreske = New System.Windows.Forms.Timer(Me.components)
        Me.erpIndikatorGreske = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CmbVrstaArtikla = New System.Windows.Forms.ComboBox()
        Me.ChkPasivan = New System.Windows.Forms.CheckBox()
        Me.TxtNapomena = New System.Windows.Forms.TextBox()
        Me.TxtLokacija = New System.Windows.Forms.TextBox()
        Me.TxtSifra = New System.Windows.Forms.TextBox()
        Me.TxtNaziv = New System.Windows.Forms.TextBox()
        Me.CmbVrstaCenovnika = New System.Windows.Forms.ComboBox()
        Me.CmdSnimi = New System.Windows.Forms.Button()
        Me.CmdNovi = New System.Windows.Forms.Button()
        Label2 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        ImeLabel = New System.Windows.Forms.Label()
        SifraLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.erpIndikatorGreske, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(75, Byte), Integer))
        Label2.Location = New System.Drawing.Point(36, 158)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(93, 16)
        Label2.TabIndex = 454
        Label2.Text = "Vrsta artikla:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(75, Byte), Integer))
        Label4.Location = New System.Drawing.Point(36, 218)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(126, 16)
        Label4.TabIndex = 453
        Label4.Text = "Lokacija / adresa:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(75, Byte), Integer))
        Label1.Location = New System.Drawing.Point(36, 278)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(81, 16)
        Label1.TabIndex = 450
        Label1.Text = "Napomena:"
        '
        'ImeLabel
        '
        ImeLabel.AutoSize = True
        ImeLabel.BackColor = System.Drawing.Color.Transparent
        ImeLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ImeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(75, Byte), Integer))
        ImeLabel.Location = New System.Drawing.Point(36, 98)
        ImeLabel.Name = "ImeLabel"
        ImeLabel.Size = New System.Drawing.Size(48, 16)
        ImeLabel.TabIndex = 449
        ImeLabel.Text = "Naziv:"
        '
        'SifraLabel
        '
        SifraLabel.AutoSize = True
        SifraLabel.BackColor = System.Drawing.Color.Transparent
        SifraLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SifraLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(75, Byte), Integer))
        SifraLabel.Location = New System.Drawing.Point(36, 38)
        SifraLabel.Name = "SifraLabel"
        SifraLabel.Size = New System.Drawing.Size(43, 16)
        SifraLabel.TabIndex = 448
        SifraLabel.Text = "Šifra:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(75, Byte), Integer))
        Label3.Location = New System.Drawing.Point(315, 158)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(119, 16)
        Label3.TabIndex = 458
        Label3.Text = "Vrsta cenovnika:"
        '
        'tmrDelay
        '
        Me.tmrDelay.Interval = 1000
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
        'CmbVrstaArtikla
        '
        Me.CmbVrstaArtikla.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbVrstaArtikla.FormattingEnabled = True
        Me.CmbVrstaArtikla.Location = New System.Drawing.Point(37, 178)
        Me.CmbVrstaArtikla.Name = "CmbVrstaArtikla"
        Me.CmbVrstaArtikla.Size = New System.Drawing.Size(260, 24)
        Me.CmbVrstaArtikla.TabIndex = 445
        '
        'ChkPasivan
        '
        Me.ChkPasivan.AutoSize = True
        Me.ChkPasivan.BackColor = System.Drawing.Color.Transparent
        Me.ChkPasivan.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkPasivan.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPasivan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ChkPasivan.Location = New System.Drawing.Point(506, 44)
        Me.ChkPasivan.Name = "ChkPasivan"
        Me.ChkPasivan.Size = New System.Drawing.Size(76, 20)
        Me.ChkPasivan.TabIndex = 451
        Me.ChkPasivan.Text = "Pasivan"
        Me.ChkPasivan.UseVisualStyleBackColor = False
        '
        'TxtNapomena
        '
        Me.TxtNapomena.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNapomena.Location = New System.Drawing.Point(37, 298)
        Me.TxtNapomena.Multiline = True
        Me.TxtNapomena.Name = "TxtNapomena"
        Me.TxtNapomena.Size = New System.Drawing.Size(540, 61)
        Me.TxtNapomena.TabIndex = 447
        Me.TxtNapomena.Tag = "5"
        '
        'TxtLokacija
        '
        Me.TxtLokacija.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLokacija.Location = New System.Drawing.Point(37, 237)
        Me.TxtLokacija.Name = "TxtLokacija"
        Me.TxtLokacija.Size = New System.Drawing.Size(538, 23)
        Me.TxtLokacija.TabIndex = 446
        Me.TxtLokacija.Tag = "4"
        '
        'TxtSifra
        '
        Me.TxtSifra.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSifra.Location = New System.Drawing.Point(37, 58)
        Me.TxtSifra.Name = "TxtSifra"
        Me.TxtSifra.Size = New System.Drawing.Size(112, 23)
        Me.TxtSifra.TabIndex = 443
        Me.TxtSifra.Tag = "1"
        '
        'TxtNaziv
        '
        Me.TxtNaziv.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNaziv.Location = New System.Drawing.Point(37, 118)
        Me.TxtNaziv.Name = "TxtNaziv"
        Me.TxtNaziv.Size = New System.Drawing.Size(540, 23)
        Me.TxtNaziv.TabIndex = 444
        Me.TxtNaziv.Tag = "2"
        '
        'CmbVrstaCenovnika
        '
        Me.CmbVrstaCenovnika.Enabled = False
        Me.CmbVrstaCenovnika.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbVrstaCenovnika.FormattingEnabled = True
        Me.CmbVrstaCenovnika.Location = New System.Drawing.Point(315, 178)
        Me.CmbVrstaCenovnika.Name = "CmbVrstaCenovnika"
        Me.CmbVrstaCenovnika.Size = New System.Drawing.Size(260, 24)
        Me.CmbVrstaCenovnika.TabIndex = 457
        '
        'CmdSnimi
        '
        Me.CmdSnimi.BackColor = System.Drawing.Color.Transparent
        Me.CmdSnimi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdSnimi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdSnimi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.CmdSnimi.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CmdSnimi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdSnimi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdSnimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdSnimi.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSnimi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.CmdSnimi.Image = CType(resources.GetObject("CmdSnimi.Image"), System.Drawing.Image)
        Me.CmdSnimi.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.CmdSnimi.Location = New System.Drawing.Point(470, 389)
        Me.CmdSnimi.Name = "CmdSnimi"
        Me.CmdSnimi.Size = New System.Drawing.Size(105, 40)
        Me.CmdSnimi.TabIndex = 467
        Me.CmdSnimi.Text = "Snimi"
        Me.CmdSnimi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSnimi.UseVisualStyleBackColor = False
        '
        'CmdNovi
        '
        Me.CmdNovi.BackColor = System.Drawing.Color.Transparent
        Me.CmdNovi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdNovi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdNovi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.CmdNovi.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CmdNovi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdNovi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdNovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdNovi.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNovi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.CmdNovi.Image = CType(resources.GetObject("CmdNovi.Image"), System.Drawing.Image)
        Me.CmdNovi.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.CmdNovi.Location = New System.Drawing.Point(342, 389)
        Me.CmdNovi.Name = "CmdNovi"
        Me.CmdNovi.Size = New System.Drawing.Size(100, 40)
        Me.CmdNovi.TabIndex = 466
        Me.CmdNovi.Text = "Novi"
        Me.CmdNovi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdNovi.UseVisualStyleBackColor = False
        '
        'FrmSifarnikMagacini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(610, 461)
        Me.Controls.Add(Me.CmdSnimi)
        Me.Controls.Add(Me.CmdNovi)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.CmbVrstaCenovnika)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.CmbVrstaArtikla)
        Me.Controls.Add(Me.ChkPasivan)
        Me.Controls.Add(Me.TxtNapomena)
        Me.Controls.Add(Me.TxtLokacija)
        Me.Controls.Add(Me.TxtSifra)
        Me.Controls.Add(Me.TxtNaziv)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label1)
        Me.Controls.Add(ImeLabel)
        Me.Controls.Add(SifraLabel)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSifarnikMagacini"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MAGACINI"
        CType(Me.erpIndikatorGreske, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrDelay As Timer
    Friend WithEvents ttInfo As ToolTip
    Friend WithEvents TmrIndikatorGreske As Timer
    Friend WithEvents erpIndikatorGreske As ErrorProvider
    Friend WithEvents CmbVrstaArtikla As ComboBox
    Friend WithEvents ChkPasivan As CheckBox
    Friend WithEvents TxtNapomena As TextBox
    Friend WithEvents TxtLokacija As TextBox
    Friend WithEvents TxtSifra As TextBox
    Friend WithEvents TxtNaziv As TextBox
    Friend WithEvents CmbVrstaCenovnika As ComboBox
    Friend WithEvents CmdSnimi As Button
    Friend WithEvents CmdNovi As Button
End Class
