<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSifarnikArtikli
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
        Dim Label5 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim BarCodLabel As System.Windows.Forms.Label
        Dim JedinicaMereLabel As System.Windows.Forms.Label
        Dim NazivLabel As System.Windows.Forms.Label
        Dim SifraLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim GrupaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSifarnikArtikli))
        Me.cmbPoreskaStopa = New System.Windows.Forms.ComboBox()
        Me.txtPoreskaStopa = New System.Windows.Forms.TextBox()
        Me.txtNapomena = New System.Windows.Forms.TextBox()
        Me.txtMinimalnaKolicina = New System.Windows.Forms.TextBox()
        Me.txtBarCod = New System.Windows.Forms.TextBox()
        Me.txtJedinicaMere = New System.Windows.Forms.TextBox()
        Me.txtNaziv = New System.Windows.Forms.TextBox()
        Me.txtSifra = New System.Windows.Forms.TextBox()
        Me.tmrDelay = New System.Windows.Forms.Timer(Me.components)
        Me.ttInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.CmdNovaRobnaGrupa = New System.Windows.Forms.Button()
        Me.TmrIndikatorGreske = New System.Windows.Forms.Timer(Me.components)
        Me.erpIndikatorGreske = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ChkPasivan = New System.Windows.Forms.CheckBox()
        Me.FsFiskal = New System.IO.FileSystemWatcher()
        Me.ImgTasteri = New System.Windows.Forms.ImageList(Me.components)
        Me.TxtKataloskiBroj = New System.Windows.Forms.TextBox()
        Me.TxtOznaka = New System.Windows.Forms.TextBox()
        Me.CmbRobnaGrupa = New System.Windows.Forms.ComboBox()
        Me.cmbVrsta = New System.Windows.Forms.ComboBox()
        Me.CmdNovi = New System.Windows.Forms.Button()
        Me.CmdSnimi = New System.Windows.Forms.Button()
        Label5 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        BarCodLabel = New System.Windows.Forms.Label()
        JedinicaMereLabel = New System.Windows.Forms.Label()
        NazivLabel = New System.Windows.Forms.Label()
        SifraLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        GrupaLabel = New System.Windows.Forms.Label()
        CType(Me.erpIndikatorGreske, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FsFiskal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.Color.Transparent
        Label5.Enabled = False
        Label5.Font = New System.Drawing.Font("Verdana", 9.75!)
        Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Label5.Location = New System.Drawing.Point(341, 322)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(20, 16)
        Label5.TabIndex = 406
        Label5.Text = "%"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Enabled = False
        Label4.Font = New System.Drawing.Font("Verdana", 9.75!)
        Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Label4.Location = New System.Drawing.Point(134, 322)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(131, 16)
        Label4.TabIndex = 404
        Label4.Text = "Tip poreske stope:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Font = New System.Drawing.Font("Verdana", 9.75!)
        Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Label3.Location = New System.Drawing.Point(520, 322)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(129, 16)
        Label3.TabIndex = 400
        Label3.Text = "Minimalna količina:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Label2.Location = New System.Drawing.Point(32, 390)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(81, 16)
        Label2.TabIndex = 398
        Label2.Text = "Napomena:"
        '
        'BarCodLabel
        '
        BarCodLabel.AutoSize = True
        BarCodLabel.BackColor = System.Drawing.Color.Transparent
        BarCodLabel.Font = New System.Drawing.Font("Verdana", 9.75!)
        BarCodLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        BarCodLabel.Location = New System.Drawing.Point(476, 118)
        BarCodLabel.Name = "BarCodLabel"
        BarCodLabel.Size = New System.Drawing.Size(59, 16)
        BarCodLabel.TabIndex = 393
        BarCodLabel.Text = "BarCod:"
        '
        'JedinicaMereLabel
        '
        JedinicaMereLabel.AutoSize = True
        JedinicaMereLabel.BackColor = System.Drawing.Color.Transparent
        JedinicaMereLabel.Font = New System.Drawing.Font("Verdana", 9.75!)
        JedinicaMereLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        JedinicaMereLabel.Location = New System.Drawing.Point(32, 322)
        JedinicaMereLabel.Name = "JedinicaMereLabel"
        JedinicaMereLabel.Size = New System.Drawing.Size(77, 16)
        JedinicaMereLabel.TabIndex = 387
        JedinicaMereLabel.Text = "Jed. mere:"
        '
        'NazivLabel
        '
        NazivLabel.AutoSize = True
        NazivLabel.BackColor = System.Drawing.Color.Transparent
        NazivLabel.Font = New System.Drawing.Font("Verdana", 9.75!)
        NazivLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        NazivLabel.Location = New System.Drawing.Point(32, 186)
        NazivLabel.Name = "NazivLabel"
        NazivLabel.Size = New System.Drawing.Size(48, 16)
        NazivLabel.TabIndex = 385
        NazivLabel.Text = "Naziv:"
        '
        'SifraLabel
        '
        SifraLabel.AutoSize = True
        SifraLabel.BackColor = System.Drawing.Color.Transparent
        SifraLabel.Font = New System.Drawing.Font("Verdana", 9.75!)
        SifraLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        SifraLabel.Location = New System.Drawing.Point(32, 118)
        SifraLabel.Name = "SifraLabel"
        SifraLabel.Size = New System.Drawing.Size(43, 16)
        SifraLabel.TabIndex = 382
        SifraLabel.Text = "Šifra:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.Transparent
        Label6.Font = New System.Drawing.Font("Verdana", 9.75!)
        Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Label6.Location = New System.Drawing.Point(168, 118)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(101, 16)
        Label6.TabIndex = 446
        Label6.Text = "Kataloški broj:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.BackColor = System.Drawing.Color.Transparent
        Label8.Font = New System.Drawing.Font("Verdana", 9.75!)
        Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Label8.Location = New System.Drawing.Point(32, 254)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(105, 16)
        Label8.TabIndex = 450
        Label8.Text = "Oznaka / Opis:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Verdana", 9.75!)
        Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Label1.Location = New System.Drawing.Point(343, 56)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(95, 16)
        Label1.TabIndex = 453
        Label1.Text = "Robna grupa:"
        '
        'GrupaLabel
        '
        GrupaLabel.AutoSize = True
        GrupaLabel.BackColor = System.Drawing.Color.Transparent
        GrupaLabel.Font = New System.Drawing.Font("Verdana", 9.75!)
        GrupaLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        GrupaLabel.Location = New System.Drawing.Point(32, 56)
        GrupaLabel.Name = "GrupaLabel"
        GrupaLabel.Size = New System.Drawing.Size(93, 16)
        GrupaLabel.TabIndex = 451
        GrupaLabel.Text = "Vrsta artikla:"
        '
        'cmbPoreskaStopa
        '
        Me.cmbPoreskaStopa.Enabled = False
        Me.cmbPoreskaStopa.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPoreskaStopa.FormattingEnabled = True
        Me.cmbPoreskaStopa.Location = New System.Drawing.Point(137, 340)
        Me.cmbPoreskaStopa.Name = "cmbPoreskaStopa"
        Me.cmbPoreskaStopa.Size = New System.Drawing.Size(178, 24)
        Me.cmbPoreskaStopa.TabIndex = 405
        '
        'txtPoreskaStopa
        '
        Me.txtPoreskaStopa.Enabled = False
        Me.txtPoreskaStopa.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoreskaStopa.Location = New System.Drawing.Point(321, 341)
        Me.txtPoreskaStopa.Name = "txtPoreskaStopa"
        Me.txtPoreskaStopa.ReadOnly = True
        Me.txtPoreskaStopa.Size = New System.Drawing.Size(40, 23)
        Me.txtPoreskaStopa.TabIndex = 391
        Me.txtPoreskaStopa.Tag = "8"
        Me.txtPoreskaStopa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNapomena
        '
        Me.txtNapomena.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNapomena.Location = New System.Drawing.Point(32, 409)
        Me.txtNapomena.Multiline = True
        Me.txtNapomena.Name = "txtNapomena"
        Me.txtNapomena.Size = New System.Drawing.Size(614, 50)
        Me.txtNapomena.TabIndex = 8
        Me.txtNapomena.Tag = "8"
        '
        'txtMinimalnaKolicina
        '
        Me.txtMinimalnaKolicina.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinimalnaKolicina.Location = New System.Drawing.Point(511, 341)
        Me.txtMinimalnaKolicina.Name = "txtMinimalnaKolicina"
        Me.txtMinimalnaKolicina.Size = New System.Drawing.Size(135, 23)
        Me.txtMinimalnaKolicina.TabIndex = 7
        Me.txtMinimalnaKolicina.Tag = "7"
        Me.txtMinimalnaKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBarCod
        '
        Me.txtBarCod.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarCod.Location = New System.Drawing.Point(479, 137)
        Me.txtBarCod.Name = "txtBarCod"
        Me.txtBarCod.Size = New System.Drawing.Size(167, 23)
        Me.txtBarCod.TabIndex = 9
        Me.txtBarCod.Tag = "9"
        '
        'txtJedinicaMere
        '
        Me.txtJedinicaMere.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJedinicaMere.Location = New System.Drawing.Point(32, 341)
        Me.txtJedinicaMere.Name = "txtJedinicaMere"
        Me.txtJedinicaMere.Size = New System.Drawing.Size(77, 23)
        Me.txtJedinicaMere.TabIndex = 5
        Me.txtJedinicaMere.Tag = "5"
        '
        'txtNaziv
        '
        Me.txtNaziv.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNaziv.Location = New System.Drawing.Point(32, 205)
        Me.txtNaziv.Name = "txtNaziv"
        Me.txtNaziv.Size = New System.Drawing.Size(614, 23)
        Me.txtNaziv.TabIndex = 3
        Me.txtNaziv.Tag = "3"
        '
        'txtSifra
        '
        Me.txtSifra.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSifra.Location = New System.Drawing.Point(32, 137)
        Me.txtSifra.Name = "txtSifra"
        Me.txtSifra.Size = New System.Drawing.Size(119, 23)
        Me.txtSifra.TabIndex = 1
        Me.txtSifra.Tag = "1"
        '
        'tmrDelay
        '
        Me.tmrDelay.Interval = 1000
        '
        'CmdNovaRobnaGrupa
        '
        Me.CmdNovaRobnaGrupa.BackColor = System.Drawing.Color.Transparent
        Me.CmdNovaRobnaGrupa.BackgroundImage = CType(resources.GetObject("CmdNovaRobnaGrupa.BackgroundImage"), System.Drawing.Image)
        Me.CmdNovaRobnaGrupa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdNovaRobnaGrupa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdNovaRobnaGrupa.FlatAppearance.BorderSize = 0
        Me.CmdNovaRobnaGrupa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.CmdNovaRobnaGrupa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.CmdNovaRobnaGrupa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdNovaRobnaGrupa.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNovaRobnaGrupa.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.CmdNovaRobnaGrupa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdNovaRobnaGrupa.Location = New System.Drawing.Point(620, 48)
        Me.CmdNovaRobnaGrupa.Name = "CmdNovaRobnaGrupa"
        Me.CmdNovaRobnaGrupa.Size = New System.Drawing.Size(25, 25)
        Me.CmdNovaRobnaGrupa.TabIndex = 454
        Me.ttInfo.SetToolTip(Me.CmdNovaRobnaGrupa, "Unos nove robne grupe")
        Me.CmdNovaRobnaGrupa.UseVisualStyleBackColor = False
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
        'ChkPasivan
        '
        Me.ChkPasivan.AutoSize = True
        Me.ChkPasivan.BackColor = System.Drawing.Color.Transparent
        Me.ChkPasivan.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkPasivan.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.ChkPasivan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ChkPasivan.Location = New System.Drawing.Point(569, 12)
        Me.ChkPasivan.Name = "ChkPasivan"
        Me.ChkPasivan.Size = New System.Drawing.Size(76, 20)
        Me.ChkPasivan.TabIndex = 426
        Me.ChkPasivan.Text = "Pasivan"
        Me.ChkPasivan.UseVisualStyleBackColor = False
        '
        'FsFiskal
        '
        Me.FsFiskal.EnableRaisingEvents = True
        Me.FsFiskal.NotifyFilter = System.IO.NotifyFilters.FileName
        Me.FsFiskal.SynchronizingObject = Me
        '
        'ImgTasteri
        '
        Me.ImgTasteri.ImageStream = CType(resources.GetObject("ImgTasteri.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgTasteri.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgTasteri.Images.SetKeyName(0, "Taster 115_40.png")
        Me.ImgTasteri.Images.SetKeyName(1, "Taster 115_40_DownS.png")
        '
        'TxtKataloskiBroj
        '
        Me.TxtKataloskiBroj.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKataloskiBroj.Location = New System.Drawing.Point(171, 137)
        Me.TxtKataloskiBroj.Name = "TxtKataloskiBroj"
        Me.TxtKataloskiBroj.Size = New System.Drawing.Size(286, 23)
        Me.TxtKataloskiBroj.TabIndex = 2
        Me.TxtKataloskiBroj.Tag = "2"
        '
        'TxtOznaka
        '
        Me.TxtOznaka.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOznaka.Location = New System.Drawing.Point(32, 273)
        Me.TxtOznaka.Name = "TxtOznaka"
        Me.TxtOznaka.Size = New System.Drawing.Size(614, 23)
        Me.TxtOznaka.TabIndex = 4
        Me.TxtOznaka.Tag = "4"
        '
        'CmbRobnaGrupa
        '
        Me.CmbRobnaGrupa.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbRobnaGrupa.FormattingEnabled = True
        Me.CmbRobnaGrupa.Location = New System.Drawing.Point(346, 74)
        Me.CmbRobnaGrupa.Name = "CmbRobnaGrupa"
        Me.CmbRobnaGrupa.Size = New System.Drawing.Size(300, 24)
        Me.CmbRobnaGrupa.TabIndex = 455
        '
        'cmbVrsta
        '
        Me.cmbVrsta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVrsta.FormattingEnabled = True
        Me.cmbVrsta.Location = New System.Drawing.Point(32, 74)
        Me.cmbVrsta.Name = "cmbVrsta"
        Me.cmbVrsta.Size = New System.Drawing.Size(300, 24)
        Me.cmbVrsta.TabIndex = 452
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
        Me.CmdNovi.Location = New System.Drawing.Point(412, 508)
        Me.CmdNovi.Name = "CmdNovi"
        Me.CmdNovi.Size = New System.Drawing.Size(100, 40)
        Me.CmdNovi.TabIndex = 458
        Me.CmdNovi.Text = "Novi"
        Me.CmdNovi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdNovi.UseVisualStyleBackColor = False
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
        Me.CmdSnimi.Location = New System.Drawing.Point(540, 508)
        Me.CmdSnimi.Name = "CmdSnimi"
        Me.CmdSnimi.Size = New System.Drawing.Size(105, 40)
        Me.CmdSnimi.TabIndex = 459
        Me.CmdSnimi.Text = "Snimi"
        Me.CmdSnimi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSnimi.UseVisualStyleBackColor = False
        '
        'FrmSifarnikArtikli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(684, 581)
        Me.Controls.Add(Me.CmdSnimi)
        Me.Controls.Add(Me.CmdNovi)
        Me.Controls.Add(Me.CmbRobnaGrupa)
        Me.Controls.Add(Me.CmdNovaRobnaGrupa)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.cmbVrsta)
        Me.Controls.Add(GrupaLabel)
        Me.Controls.Add(Me.TxtOznaka)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Me.TxtKataloskiBroj)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.ChkPasivan)
        Me.Controls.Add(Me.cmbPoreskaStopa)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txtPoreskaStopa)
        Me.Controls.Add(Me.txtNapomena)
        Me.Controls.Add(Me.txtMinimalnaKolicina)
        Me.Controls.Add(Me.txtBarCod)
        Me.Controls.Add(Me.txtJedinicaMere)
        Me.Controls.Add(Me.txtNaziv)
        Me.Controls.Add(Me.txtSifra)
        Me.Controls.Add(BarCodLabel)
        Me.Controls.Add(JedinicaMereLabel)
        Me.Controls.Add(NazivLabel)
        Me.Controls.Add(SifraLabel)
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSifarnikArtikli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ARTIKLI"
        CType(Me.erpIndikatorGreske, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FsFiskal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbPoreskaStopa As ComboBox
    Friend WithEvents txtPoreskaStopa As TextBox
    Friend WithEvents txtNapomena As TextBox
    Friend WithEvents txtMinimalnaKolicina As TextBox
    Friend WithEvents txtBarCod As TextBox
    Friend WithEvents txtJedinicaMere As TextBox
    Friend WithEvents txtNaziv As TextBox
    Friend WithEvents txtSifra As TextBox
    Friend WithEvents tmrDelay As Timer
    Friend WithEvents ttInfo As ToolTip
    Friend WithEvents TmrIndikatorGreske As Timer
    Friend WithEvents erpIndikatorGreske As ErrorProvider
    Friend WithEvents ChkPasivan As CheckBox
    Friend WithEvents FsFiskal As IO.FileSystemWatcher
    Friend WithEvents ImgTasteri As ImageList
    Friend WithEvents TxtKataloskiBroj As TextBox
    Friend WithEvents TxtOznaka As TextBox
    Friend WithEvents CmbRobnaGrupa As ComboBox
    Friend WithEvents CmdNovaRobnaGrupa As Button
    Friend WithEvents cmbVrsta As ComboBox
    Friend WithEvents CmdSnimi As Button
    Friend WithEvents CmdNovi As Button
End Class
