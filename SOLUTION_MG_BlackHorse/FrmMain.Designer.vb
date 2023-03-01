<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.CmdProizvodnja = New System.Windows.Forms.Button()
        Me.CmdSifarnici = New System.Windows.Forms.Button()
        Me.CmdMagacin2D = New System.Windows.Forms.Button()
        Me.CmdIzvestaji = New System.Windows.Forms.Button()
        Me.CmdRezervacije = New System.Windows.Forms.Button()
        Me.CmdMagacinskiDokumenti = New System.Windows.Forms.Button()
        Me.PanelMagacinskaDokumentacija = New System.Windows.Forms.Panel()
        Me.CmdStanjeArtikala = New System.Windows.Forms.Button()
        Me.CmdLagerLista = New System.Windows.Forms.Button()
        Me.CmdRashod = New System.Windows.Forms.Button()
        Me.CmdPrenosnica = New System.Windows.Forms.Button()
        Me.CmdKarticaArtiklaMagacinska = New System.Windows.Forms.Button()
        Me.CmdPopis = New System.Windows.Forms.Button()
        Me.CmdPocetnoStanje = New System.Windows.Forms.Button()
        Me.CmdOtpremnica = New System.Windows.Forms.Button()
        Me.CmdPrijemnica = New System.Windows.Forms.Button()
        Me.PanelSifarnici = New System.Windows.Forms.Panel()
        Me.CmdKomitenti = New System.Windows.Forms.Button()
        Me.CmdMagacini = New System.Windows.Forms.Button()
        Me.CmdRobneGrupe = New System.Windows.Forms.Button()
        Me.CmdArtikli = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNadji = New System.Windows.Forms.TextBox()
        Me.LblGodina = New System.Windows.Forms.Label()
        Me.CmdPodesavanja = New System.Windows.Forms.Button()
        Me.CmdOperateri = New System.Windows.Forms.Button()
        Me.CmdNadji = New System.Windows.Forms.Button()
        Me.PanelMagacin = New System.Windows.Forms.Panel()
        Me.CmbMagacin = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.LblLista = New System.Windows.Forms.Label()
        Me.CmdNovi = New System.Windows.Forms.Button()
        Me.ImgMain = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel = New System.Windows.Forms.Panel()
        Me.PanelProizvodnja = New System.Windows.Forms.Panel()
        Me.cmdPredajnica = New System.Windows.Forms.Button()
        Me.cmdTrebovanje = New System.Windows.Forms.Button()
        Me.cmdRadniNalog = New System.Windows.Forms.Button()
        Me.cmdNormativ = New System.Windows.Forms.Button()
        Me.LblPanel = New System.Windows.Forms.Label()
        Me.PanelMohokSoft = New System.Windows.Forms.Panel()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.PanelBlackHorse = New System.Windows.Forms.Panel()
        Me.GrdMain = New System.Windows.Forms.DataGridView()
        Me.ttMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelMain.SuspendLayout()
        Me.PanelMagacinskaDokumentacija.SuspendLayout()
        Me.PanelSifarnici.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelMagacin.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.PanelProizvodnja.SuspendLayout()
        CType(Me.GrdMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMain
        '
        Me.PanelMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.PanelMain.Controls.Add(Me.CmdProizvodnja)
        Me.PanelMain.Controls.Add(Me.CmdSifarnici)
        Me.PanelMain.Controls.Add(Me.CmdMagacin2D)
        Me.PanelMain.Controls.Add(Me.CmdIzvestaji)
        Me.PanelMain.Controls.Add(Me.CmdRezervacije)
        Me.PanelMain.Controls.Add(Me.CmdMagacinskiDokumenti)
        Me.PanelMain.Location = New System.Drawing.Point(30, 140)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(250, 221)
        Me.PanelMain.TabIndex = 0
        '
        'CmdProizvodnja
        '
        Me.CmdProizvodnja.BackColor = System.Drawing.Color.Transparent
        Me.CmdProizvodnja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdProizvodnja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdProizvodnja.FlatAppearance.BorderSize = 0
        Me.CmdProizvodnja.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CmdProizvodnja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CmdProizvodnja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdProizvodnja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdProizvodnja.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.CmdProizvodnja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdProizvodnja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdProizvodnja.Location = New System.Drawing.Point(0, 145)
        Me.CmdProizvodnja.Name = "CmdProizvodnja"
        Me.CmdProizvodnja.Size = New System.Drawing.Size(250, 40)
        Me.CmdProizvodnja.TabIndex = 153
        Me.CmdProizvodnja.Text = "Proizvodnja"
        Me.CmdProizvodnja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdProizvodnja.UseVisualStyleBackColor = False
        '
        'CmdSifarnici
        '
        Me.CmdSifarnici.BackColor = System.Drawing.Color.Transparent
        Me.CmdSifarnici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdSifarnici.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdSifarnici.FlatAppearance.BorderSize = 0
        Me.CmdSifarnici.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CmdSifarnici.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CmdSifarnici.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdSifarnici.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdSifarnici.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSifarnici.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdSifarnici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSifarnici.Location = New System.Drawing.Point(0, 25)
        Me.CmdSifarnici.Name = "CmdSifarnici"
        Me.CmdSifarnici.Size = New System.Drawing.Size(250, 40)
        Me.CmdSifarnici.TabIndex = 148
        Me.CmdSifarnici.Text = "Šifarnici"
        Me.CmdSifarnici.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSifarnici.UseVisualStyleBackColor = False
        '
        'CmdMagacin2D
        '
        Me.CmdMagacin2D.BackColor = System.Drawing.Color.Transparent
        Me.CmdMagacin2D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdMagacin2D.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdMagacin2D.FlatAppearance.BorderSize = 0
        Me.CmdMagacin2D.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CmdMagacin2D.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CmdMagacin2D.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdMagacin2D.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdMagacin2D.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.CmdMagacin2D.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdMagacin2D.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdMagacin2D.Location = New System.Drawing.Point(0, 105)
        Me.CmdMagacin2D.Name = "CmdMagacin2D"
        Me.CmdMagacin2D.Size = New System.Drawing.Size(250, 40)
        Me.CmdMagacin2D.TabIndex = 150
        Me.CmdMagacin2D.Text = "Magacin 2D/3D"
        Me.CmdMagacin2D.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdMagacin2D.UseVisualStyleBackColor = False
        '
        'CmdIzvestaji
        '
        Me.CmdIzvestaji.BackColor = System.Drawing.Color.Transparent
        Me.CmdIzvestaji.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdIzvestaji.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdIzvestaji.FlatAppearance.BorderSize = 0
        Me.CmdIzvestaji.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CmdIzvestaji.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CmdIzvestaji.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdIzvestaji.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdIzvestaji.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.CmdIzvestaji.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdIzvestaji.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdIzvestaji.Location = New System.Drawing.Point(0, 225)
        Me.CmdIzvestaji.Name = "CmdIzvestaji"
        Me.CmdIzvestaji.Size = New System.Drawing.Size(250, 40)
        Me.CmdIzvestaji.TabIndex = 152
        Me.CmdIzvestaji.Text = "Izveštaji"
        Me.CmdIzvestaji.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdIzvestaji.UseVisualStyleBackColor = False
        '
        'CmdRezervacije
        '
        Me.CmdRezervacije.BackColor = System.Drawing.Color.Transparent
        Me.CmdRezervacije.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdRezervacije.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdRezervacije.FlatAppearance.BorderSize = 0
        Me.CmdRezervacije.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CmdRezervacije.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CmdRezervacije.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdRezervacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdRezervacije.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.CmdRezervacije.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdRezervacije.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdRezervacije.Location = New System.Drawing.Point(0, 185)
        Me.CmdRezervacije.Name = "CmdRezervacije"
        Me.CmdRezervacije.Size = New System.Drawing.Size(250, 40)
        Me.CmdRezervacije.TabIndex = 151
        Me.CmdRezervacije.Text = "Rezervacije"
        Me.CmdRezervacije.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdRezervacije.UseVisualStyleBackColor = False
        '
        'CmdMagacinskiDokumenti
        '
        Me.CmdMagacinskiDokumenti.BackColor = System.Drawing.Color.Transparent
        Me.CmdMagacinskiDokumenti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdMagacinskiDokumenti.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdMagacinskiDokumenti.FlatAppearance.BorderSize = 0
        Me.CmdMagacinskiDokumenti.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CmdMagacinskiDokumenti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CmdMagacinskiDokumenti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdMagacinskiDokumenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdMagacinskiDokumenti.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.CmdMagacinskiDokumenti.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdMagacinskiDokumenti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdMagacinskiDokumenti.Location = New System.Drawing.Point(0, 65)
        Me.CmdMagacinskiDokumenti.Name = "CmdMagacinskiDokumenti"
        Me.CmdMagacinskiDokumenti.Size = New System.Drawing.Size(250, 40)
        Me.CmdMagacinskiDokumenti.TabIndex = 149
        Me.CmdMagacinskiDokumenti.Text = "Magacinski dokumenti"
        Me.CmdMagacinskiDokumenti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdMagacinskiDokumenti.UseVisualStyleBackColor = False
        '
        'PanelMagacinskaDokumentacija
        '
        Me.PanelMagacinskaDokumentacija.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelMagacinskaDokumentacija.AutoScroll = True
        Me.PanelMagacinskaDokumentacija.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.PanelMagacinskaDokumentacija.Controls.Add(Me.CmdStanjeArtikala)
        Me.PanelMagacinskaDokumentacija.Controls.Add(Me.CmdLagerLista)
        Me.PanelMagacinskaDokumentacija.Controls.Add(Me.CmdRashod)
        Me.PanelMagacinskaDokumentacija.Controls.Add(Me.CmdPrenosnica)
        Me.PanelMagacinskaDokumentacija.Controls.Add(Me.CmdKarticaArtiklaMagacinska)
        Me.PanelMagacinskaDokumentacija.Controls.Add(Me.CmdPopis)
        Me.PanelMagacinskaDokumentacija.Controls.Add(Me.CmdPocetnoStanje)
        Me.PanelMagacinskaDokumentacija.Controls.Add(Me.CmdOtpremnica)
        Me.PanelMagacinskaDokumentacija.Controls.Add(Me.CmdPrijemnica)
        Me.PanelMagacinskaDokumentacija.Location = New System.Drawing.Point(22, 476)
        Me.PanelMagacinskaDokumentacija.Name = "PanelMagacinskaDokumentacija"
        Me.PanelMagacinskaDokumentacija.Size = New System.Drawing.Size(250, 128)
        Me.PanelMagacinskaDokumentacija.TabIndex = 60
        Me.PanelMagacinskaDokumentacija.Visible = False
        '
        'CmdStanjeArtikala
        '
        Me.CmdStanjeArtikala.BackColor = System.Drawing.Color.Transparent
        Me.CmdStanjeArtikala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdStanjeArtikala.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdStanjeArtikala.FlatAppearance.BorderSize = 0
        Me.CmdStanjeArtikala.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CmdStanjeArtikala.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdStanjeArtikala.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdStanjeArtikala.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.CmdStanjeArtikala.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdStanjeArtikala.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdStanjeArtikala.Location = New System.Drawing.Point(0, 305)
        Me.CmdStanjeArtikala.Name = "CmdStanjeArtikala"
        Me.CmdStanjeArtikala.Size = New System.Drawing.Size(250, 40)
        Me.CmdStanjeArtikala.TabIndex = 140
        Me.CmdStanjeArtikala.Text = "Pregled stanja artikala"
        Me.CmdStanjeArtikala.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdStanjeArtikala.UseVisualStyleBackColor = False
        '
        'CmdLagerLista
        '
        Me.CmdLagerLista.BackColor = System.Drawing.Color.Transparent
        Me.CmdLagerLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdLagerLista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdLagerLista.FlatAppearance.BorderSize = 0
        Me.CmdLagerLista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CmdLagerLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdLagerLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdLagerLista.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.CmdLagerLista.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdLagerLista.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdLagerLista.Location = New System.Drawing.Point(0, 345)
        Me.CmdLagerLista.Name = "CmdLagerLista"
        Me.CmdLagerLista.Size = New System.Drawing.Size(250, 40)
        Me.CmdLagerLista.TabIndex = 138
        Me.CmdLagerLista.Text = "Lager lista"
        Me.CmdLagerLista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdLagerLista.UseVisualStyleBackColor = False
        '
        'CmdRashod
        '
        Me.CmdRashod.BackColor = System.Drawing.Color.Transparent
        Me.CmdRashod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdRashod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdRashod.FlatAppearance.BorderSize = 0
        Me.CmdRashod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CmdRashod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdRashod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdRashod.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.CmdRashod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdRashod.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdRashod.Location = New System.Drawing.Point(0, 145)
        Me.CmdRashod.Name = "CmdRashod"
        Me.CmdRashod.Size = New System.Drawing.Size(250, 40)
        Me.CmdRashod.TabIndex = 134
        Me.CmdRashod.Text = "Rashod"
        Me.CmdRashod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdRashod.UseVisualStyleBackColor = False
        '
        'CmdPrenosnica
        '
        Me.CmdPrenosnica.BackColor = System.Drawing.Color.Transparent
        Me.CmdPrenosnica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdPrenosnica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdPrenosnica.FlatAppearance.BorderSize = 0
        Me.CmdPrenosnica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CmdPrenosnica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdPrenosnica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdPrenosnica.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.CmdPrenosnica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdPrenosnica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdPrenosnica.Location = New System.Drawing.Point(0, 105)
        Me.CmdPrenosnica.Name = "CmdPrenosnica"
        Me.CmdPrenosnica.Size = New System.Drawing.Size(250, 40)
        Me.CmdPrenosnica.TabIndex = 133
        Me.CmdPrenosnica.Text = "Prenosnica"
        Me.CmdPrenosnica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdPrenosnica.UseVisualStyleBackColor = False
        '
        'CmdKarticaArtiklaMagacinska
        '
        Me.CmdKarticaArtiklaMagacinska.BackColor = System.Drawing.Color.Transparent
        Me.CmdKarticaArtiklaMagacinska.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdKarticaArtiklaMagacinska.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdKarticaArtiklaMagacinska.FlatAppearance.BorderSize = 0
        Me.CmdKarticaArtiklaMagacinska.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CmdKarticaArtiklaMagacinska.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdKarticaArtiklaMagacinska.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdKarticaArtiklaMagacinska.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.CmdKarticaArtiklaMagacinska.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdKarticaArtiklaMagacinska.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdKarticaArtiklaMagacinska.Location = New System.Drawing.Point(0, 265)
        Me.CmdKarticaArtiklaMagacinska.Name = "CmdKarticaArtiklaMagacinska"
        Me.CmdKarticaArtiklaMagacinska.Size = New System.Drawing.Size(250, 40)
        Me.CmdKarticaArtiklaMagacinska.TabIndex = 132
        Me.CmdKarticaArtiklaMagacinska.Text = "Kartica artikla"
        Me.CmdKarticaArtiklaMagacinska.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdKarticaArtiklaMagacinska.UseVisualStyleBackColor = False
        '
        'CmdPopis
        '
        Me.CmdPopis.BackColor = System.Drawing.Color.Transparent
        Me.CmdPopis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdPopis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdPopis.FlatAppearance.BorderSize = 0
        Me.CmdPopis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CmdPopis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdPopis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdPopis.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.CmdPopis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdPopis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdPopis.Location = New System.Drawing.Point(0, 185)
        Me.CmdPopis.Name = "CmdPopis"
        Me.CmdPopis.Size = New System.Drawing.Size(250, 40)
        Me.CmdPopis.TabIndex = 131
        Me.CmdPopis.Text = "Popis"
        Me.CmdPopis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdPopis.UseVisualStyleBackColor = False
        '
        'CmdPocetnoStanje
        '
        Me.CmdPocetnoStanje.BackColor = System.Drawing.Color.Transparent
        Me.CmdPocetnoStanje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdPocetnoStanje.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdPocetnoStanje.FlatAppearance.BorderSize = 0
        Me.CmdPocetnoStanje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CmdPocetnoStanje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdPocetnoStanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdPocetnoStanje.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.CmdPocetnoStanje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdPocetnoStanje.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdPocetnoStanje.Location = New System.Drawing.Point(0, 225)
        Me.CmdPocetnoStanje.Name = "CmdPocetnoStanje"
        Me.CmdPocetnoStanje.Size = New System.Drawing.Size(250, 40)
        Me.CmdPocetnoStanje.TabIndex = 129
        Me.CmdPocetnoStanje.Text = "Početno stanje"
        Me.CmdPocetnoStanje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdPocetnoStanje.UseVisualStyleBackColor = False
        '
        'CmdOtpremnica
        '
        Me.CmdOtpremnica.BackColor = System.Drawing.Color.Transparent
        Me.CmdOtpremnica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdOtpremnica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdOtpremnica.FlatAppearance.BorderSize = 0
        Me.CmdOtpremnica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CmdOtpremnica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdOtpremnica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdOtpremnica.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.CmdOtpremnica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdOtpremnica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdOtpremnica.Location = New System.Drawing.Point(0, 65)
        Me.CmdOtpremnica.Name = "CmdOtpremnica"
        Me.CmdOtpremnica.Size = New System.Drawing.Size(250, 40)
        Me.CmdOtpremnica.TabIndex = 60
        Me.CmdOtpremnica.Text = "Otpremnica"
        Me.CmdOtpremnica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdOtpremnica.UseVisualStyleBackColor = False
        '
        'CmdPrijemnica
        '
        Me.CmdPrijemnica.BackColor = System.Drawing.Color.Transparent
        Me.CmdPrijemnica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdPrijemnica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdPrijemnica.FlatAppearance.BorderSize = 0
        Me.CmdPrijemnica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CmdPrijemnica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdPrijemnica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdPrijemnica.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.CmdPrijemnica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdPrijemnica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdPrijemnica.Location = New System.Drawing.Point(0, 25)
        Me.CmdPrijemnica.Name = "CmdPrijemnica"
        Me.CmdPrijemnica.Size = New System.Drawing.Size(250, 40)
        Me.CmdPrijemnica.TabIndex = 59
        Me.CmdPrijemnica.Text = "Prijemnica"
        Me.CmdPrijemnica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdPrijemnica.UseVisualStyleBackColor = False
        '
        'PanelSifarnici
        '
        Me.PanelSifarnici.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelSifarnici.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.PanelSifarnici.Controls.Add(Me.CmdKomitenti)
        Me.PanelSifarnici.Controls.Add(Me.CmdMagacini)
        Me.PanelSifarnici.Controls.Add(Me.CmdRobneGrupe)
        Me.PanelSifarnici.Controls.Add(Me.CmdArtikli)
        Me.PanelSifarnici.Location = New System.Drawing.Point(22, 361)
        Me.PanelSifarnici.Name = "PanelSifarnici"
        Me.PanelSifarnici.Size = New System.Drawing.Size(250, 109)
        Me.PanelSifarnici.TabIndex = 59
        Me.PanelSifarnici.Visible = False
        '
        'CmdKomitenti
        '
        Me.CmdKomitenti.BackColor = System.Drawing.Color.Transparent
        Me.CmdKomitenti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdKomitenti.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdKomitenti.FlatAppearance.BorderSize = 0
        Me.CmdKomitenti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CmdKomitenti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdKomitenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdKomitenti.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.CmdKomitenti.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdKomitenti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdKomitenti.Location = New System.Drawing.Point(0, 25)
        Me.CmdKomitenti.Name = "CmdKomitenti"
        Me.CmdKomitenti.Size = New System.Drawing.Size(250, 40)
        Me.CmdKomitenti.TabIndex = 67
        Me.CmdKomitenti.Text = "Komitenti"
        Me.CmdKomitenti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdKomitenti.UseVisualStyleBackColor = False
        '
        'CmdMagacini
        '
        Me.CmdMagacini.BackColor = System.Drawing.Color.Transparent
        Me.CmdMagacini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdMagacini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdMagacini.FlatAppearance.BorderSize = 0
        Me.CmdMagacini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CmdMagacini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdMagacini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdMagacini.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.CmdMagacini.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdMagacini.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdMagacini.Location = New System.Drawing.Point(0, 145)
        Me.CmdMagacini.Name = "CmdMagacini"
        Me.CmdMagacini.Size = New System.Drawing.Size(250, 40)
        Me.CmdMagacini.TabIndex = 66
        Me.CmdMagacini.Text = "Magacini"
        Me.CmdMagacini.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdMagacini.UseVisualStyleBackColor = False
        '
        'CmdRobneGrupe
        '
        Me.CmdRobneGrupe.BackColor = System.Drawing.Color.Transparent
        Me.CmdRobneGrupe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdRobneGrupe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdRobneGrupe.FlatAppearance.BorderSize = 0
        Me.CmdRobneGrupe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CmdRobneGrupe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdRobneGrupe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdRobneGrupe.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.CmdRobneGrupe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdRobneGrupe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdRobneGrupe.Location = New System.Drawing.Point(0, 105)
        Me.CmdRobneGrupe.Name = "CmdRobneGrupe"
        Me.CmdRobneGrupe.Size = New System.Drawing.Size(250, 40)
        Me.CmdRobneGrupe.TabIndex = 60
        Me.CmdRobneGrupe.Text = "Robne grupe artikala"
        Me.CmdRobneGrupe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdRobneGrupe.UseVisualStyleBackColor = False
        '
        'CmdArtikli
        '
        Me.CmdArtikli.BackColor = System.Drawing.Color.Transparent
        Me.CmdArtikli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdArtikli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdArtikli.FlatAppearance.BorderSize = 0
        Me.CmdArtikli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CmdArtikli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdArtikli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdArtikli.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.CmdArtikli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdArtikli.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdArtikli.Location = New System.Drawing.Point(0, 65)
        Me.CmdArtikli.Name = "CmdArtikli"
        Me.CmdArtikli.Size = New System.Drawing.Size(250, 40)
        Me.CmdArtikli.TabIndex = 59
        Me.CmdArtikli.Text = "Artikli"
        Me.CmdArtikli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdArtikli.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.TxtNadji)
        Me.Panel3.Controls.Add(Me.LblGodina)
        Me.Panel3.Controls.Add(Me.CmdPodesavanja)
        Me.Panel3.Controls.Add(Me.CmdOperateri)
        Me.Panel3.Controls.Add(Me.CmdNadji)
        Me.Panel3.Location = New System.Drawing.Point(299, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1123, 40)
        Me.Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 48)
        Me.Label1.TabIndex = 287
        Me.Label1.Text = "SOLUTION"
        '
        'TxtNadji
        '
        Me.TxtNadji.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNadji.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNadji.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNadji.Location = New System.Drawing.Point(689, 11)
        Me.TxtNadji.Name = "TxtNadji"
        Me.TxtNadji.Size = New System.Drawing.Size(300, 19)
        Me.TxtNadji.TabIndex = 113
        Me.TxtNadji.Visible = False
        '
        'LblGodina
        '
        Me.LblGodina.AutoSize = True
        Me.LblGodina.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGodina.ForeColor = System.Drawing.Color.IndianRed
        Me.LblGodina.Location = New System.Drawing.Point(15, 4)
        Me.LblGodina.Name = "LblGodina"
        Me.LblGodina.Size = New System.Drawing.Size(0, 23)
        Me.LblGodina.TabIndex = 286
        '
        'CmdPodesavanja
        '
        Me.CmdPodesavanja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdPodesavanja.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdPodesavanja.BackgroundImage = CType(resources.GetObject("CmdPodesavanja.BackgroundImage"), System.Drawing.Image)
        Me.CmdPodesavanja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdPodesavanja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdPodesavanja.FlatAppearance.BorderSize = 0
        Me.CmdPodesavanja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CmdPodesavanja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdPodesavanja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdPodesavanja.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPodesavanja.ForeColor = System.Drawing.Color.White
        Me.CmdPodesavanja.Location = New System.Drawing.Point(1040, 2)
        Me.CmdPodesavanja.Name = "CmdPodesavanja"
        Me.CmdPodesavanja.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmdPodesavanja.Size = New System.Drawing.Size(35, 35)
        Me.CmdPodesavanja.TabIndex = 142
        Me.CmdPodesavanja.UseVisualStyleBackColor = False
        '
        'CmdOperateri
        '
        Me.CmdOperateri.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOperateri.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdOperateri.BackgroundImage = CType(resources.GetObject("CmdOperateri.BackgroundImage"), System.Drawing.Image)
        Me.CmdOperateri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdOperateri.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdOperateri.FlatAppearance.BorderSize = 0
        Me.CmdOperateri.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CmdOperateri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CmdOperateri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdOperateri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdOperateri.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdOperateri.ForeColor = System.Drawing.Color.White
        Me.CmdOperateri.Location = New System.Drawing.Point(1085, 2)
        Me.CmdOperateri.Name = "CmdOperateri"
        Me.CmdOperateri.Size = New System.Drawing.Size(35, 35)
        Me.CmdOperateri.TabIndex = 141
        Me.CmdOperateri.UseVisualStyleBackColor = False
        '
        'CmdNadji
        '
        Me.CmdNadji.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdNadji.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdNadji.BackgroundImage = CType(resources.GetObject("CmdNadji.BackgroundImage"), System.Drawing.Image)
        Me.CmdNadji.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdNadji.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdNadji.FlatAppearance.BorderSize = 0
        Me.CmdNadji.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CmdNadji.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CmdNadji.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdNadji.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdNadji.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNadji.ForeColor = System.Drawing.Color.White
        Me.CmdNadji.Location = New System.Drawing.Point(995, 2)
        Me.CmdNadji.Name = "CmdNadji"
        Me.CmdNadji.Size = New System.Drawing.Size(35, 35)
        Me.CmdNadji.TabIndex = 115
        Me.CmdNadji.UseVisualStyleBackColor = False
        '
        'PanelMagacin
        '
        Me.PanelMagacin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMagacin.BackColor = System.Drawing.Color.Transparent
        Me.PanelMagacin.Controls.Add(Me.CmbMagacin)
        Me.PanelMagacin.Controls.Add(Me.Label4)
        Me.PanelMagacin.Enabled = False
        Me.PanelMagacin.Location = New System.Drawing.Point(653, 6)
        Me.PanelMagacin.Name = "PanelMagacin"
        Me.PanelMagacin.Size = New System.Drawing.Size(341, 29)
        Me.PanelMagacin.TabIndex = 149
        '
        'CmbMagacin
        '
        Me.CmbMagacin.BackColor = System.Drawing.Color.White
        Me.CmbMagacin.DropDownWidth = 250
        Me.CmbMagacin.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmbMagacin.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMagacin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CmbMagacin.FormattingEnabled = True
        Me.CmbMagacin.Location = New System.Drawing.Point(73, 3)
        Me.CmbMagacin.Name = "CmbMagacin"
        Me.CmbMagacin.Size = New System.Drawing.Size(260, 24)
        Me.CmbMagacin.TabIndex = 127
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(-5, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 26)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Magacin:"
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.LblLista)
        Me.Panel6.Controls.Add(Me.PanelMagacin)
        Me.Panel6.Controls.Add(Me.CmdNovi)
        Me.Panel6.Location = New System.Drawing.Point(301, 102)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1123, 40)
        Me.Panel6.TabIndex = 5
        '
        'LblLista
        '
        Me.LblLista.AutoSize = True
        Me.LblLista.BackColor = System.Drawing.Color.Transparent
        Me.LblLista.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLista.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.LblLista.Location = New System.Drawing.Point(15, 15)
        Me.LblLista.Name = "LblLista"
        Me.LblLista.Size = New System.Drawing.Size(0, 18)
        Me.LblLista.TabIndex = 150
        '
        'CmdNovi
        '
        Me.CmdNovi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.CmdNovi.Location = New System.Drawing.Point(1021, 0)
        Me.CmdNovi.Name = "CmdNovi"
        Me.CmdNovi.Size = New System.Drawing.Size(100, 40)
        Me.CmdNovi.TabIndex = 114
        Me.CmdNovi.Text = "Novi"
        Me.CmdNovi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdNovi.UseVisualStyleBackColor = False
        '
        'ImgMain
        '
        Me.ImgMain.ImageStream = CType(resources.GetObject("ImgMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgMain.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgMain.Images.SetKeyName(0, "Taster 120_40_Up.png")
        Me.ImgMain.Images.SetKeyName(1, "ZZooZZaZ12.png")
        '
        'Panel
        '
        Me.Panel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel.Controls.Add(Me.PanelProizvodnja)
        Me.Panel.Controls.Add(Me.LblPanel)
        Me.Panel.Controls.Add(Me.PanelMagacinskaDokumentacija)
        Me.Panel.Controls.Add(Me.PanelSifarnici)
        Me.Panel.Controls.Add(Me.PanelMohokSoft)
        Me.Panel.Controls.Add(Me.cmdBack)
        Me.Panel.Controls.Add(Me.PanelBlackHorse)
        Me.Panel.Controls.Add(Me.PanelMain)
        Me.Panel.Location = New System.Drawing.Point(10, 5)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(280, 800)
        Me.Panel.TabIndex = 1
        '
        'PanelProizvodnja
        '
        Me.PanelProizvodnja.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelProizvodnja.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.PanelProizvodnja.Controls.Add(Me.cmdPredajnica)
        Me.PanelProizvodnja.Controls.Add(Me.cmdTrebovanje)
        Me.PanelProizvodnja.Controls.Add(Me.cmdRadniNalog)
        Me.PanelProizvodnja.Controls.Add(Me.cmdNormativ)
        Me.PanelProizvodnja.Location = New System.Drawing.Point(22, 610)
        Me.PanelProizvodnja.Name = "PanelProizvodnja"
        Me.PanelProizvodnja.Size = New System.Drawing.Size(250, 109)
        Me.PanelProizvodnja.TabIndex = 149
        Me.PanelProizvodnja.Visible = False
        '
        'cmdPredajnica
        '
        Me.cmdPredajnica.BackColor = System.Drawing.Color.Transparent
        Me.cmdPredajnica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdPredajnica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPredajnica.FlatAppearance.BorderSize = 0
        Me.cmdPredajnica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.cmdPredajnica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.cmdPredajnica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPredajnica.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.cmdPredajnica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.cmdPredajnica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPredajnica.Location = New System.Drawing.Point(0, 145)
        Me.cmdPredajnica.Name = "cmdPredajnica"
        Me.cmdPredajnica.Size = New System.Drawing.Size(250, 40)
        Me.cmdPredajnica.TabIndex = 66
        Me.cmdPredajnica.Text = "Predajnica"
        Me.cmdPredajnica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttMain.SetToolTip(Me.cmdPredajnica, "Predajnica gotovih proizvoda iz proizvodnje")
        Me.cmdPredajnica.UseVisualStyleBackColor = False
        '
        'cmdTrebovanje
        '
        Me.cmdTrebovanje.BackColor = System.Drawing.Color.Transparent
        Me.cmdTrebovanje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdTrebovanje.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdTrebovanje.FlatAppearance.BorderSize = 0
        Me.cmdTrebovanje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.cmdTrebovanje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.cmdTrebovanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTrebovanje.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.cmdTrebovanje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.cmdTrebovanje.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdTrebovanje.Location = New System.Drawing.Point(0, 105)
        Me.cmdTrebovanje.Name = "cmdTrebovanje"
        Me.cmdTrebovanje.Size = New System.Drawing.Size(250, 40)
        Me.cmdTrebovanje.TabIndex = 65
        Me.cmdTrebovanje.Text = "Trebovanje"
        Me.cmdTrebovanje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttMain.SetToolTip(Me.cmdTrebovanje, "Trebovanje iz magacina na osnovu Radnog naloga" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.cmdTrebovanje.UseVisualStyleBackColor = False
        '
        'cmdRadniNalog
        '
        Me.cmdRadniNalog.BackColor = System.Drawing.Color.Transparent
        Me.cmdRadniNalog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdRadniNalog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdRadniNalog.FlatAppearance.BorderSize = 0
        Me.cmdRadniNalog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.cmdRadniNalog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.cmdRadniNalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRadniNalog.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.cmdRadniNalog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.cmdRadniNalog.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdRadniNalog.Location = New System.Drawing.Point(0, 65)
        Me.cmdRadniNalog.Name = "cmdRadniNalog"
        Me.cmdRadniNalog.Size = New System.Drawing.Size(250, 40)
        Me.cmdRadniNalog.TabIndex = 64
        Me.cmdRadniNalog.Text = "Radni nalog"
        Me.cmdRadniNalog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttMain.SetToolTip(Me.cmdRadniNalog, "Radni nalog za proizvodnju")
        Me.cmdRadniNalog.UseVisualStyleBackColor = False
        '
        'cmdNormativ
        '
        Me.cmdNormativ.BackColor = System.Drawing.Color.Transparent
        Me.cmdNormativ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdNormativ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdNormativ.FlatAppearance.BorderSize = 0
        Me.cmdNormativ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.cmdNormativ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.cmdNormativ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNormativ.Font = New System.Drawing.Font("Poppins", 11.25!)
        Me.cmdNormativ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.cmdNormativ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNormativ.Location = New System.Drawing.Point(0, 25)
        Me.cmdNormativ.Name = "cmdNormativ"
        Me.cmdNormativ.Size = New System.Drawing.Size(250, 40)
        Me.cmdNormativ.TabIndex = 63
        Me.cmdNormativ.Text = "Normativ"
        Me.cmdNormativ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttMain.SetToolTip(Me.cmdNormativ, "Normativ gotovog proizvoda")
        Me.cmdNormativ.UseVisualStyleBackColor = False
        '
        'LblPanel
        '
        Me.LblPanel.AutoSize = True
        Me.LblPanel.BackColor = System.Drawing.Color.Transparent
        Me.LblPanel.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.LblPanel.Location = New System.Drawing.Point(67, 108)
        Me.LblPanel.Name = "LblPanel"
        Me.LblPanel.Size = New System.Drawing.Size(38, 28)
        Me.LblPanel.TabIndex = 286
        Me.LblPanel.Text = "IME"
        '
        'PanelMohokSoft
        '
        Me.PanelMohokSoft.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelMohokSoft.AutoScroll = True
        Me.PanelMohokSoft.BackColor = System.Drawing.Color.Transparent
        Me.PanelMohokSoft.BackgroundImage = CType(resources.GetObject("PanelMohokSoft.BackgroundImage"), System.Drawing.Image)
        Me.PanelMohokSoft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelMohokSoft.Location = New System.Drawing.Point(0, 748)
        Me.PanelMohokSoft.Name = "PanelMohokSoft"
        Me.PanelMohokSoft.Size = New System.Drawing.Size(280, 50)
        Me.PanelMohokSoft.TabIndex = 120
        '
        'cmdBack
        '
        Me.cmdBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdBack.BackColor = System.Drawing.Color.Transparent
        Me.cmdBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdBack.FlatAppearance.BorderSize = 0
        Me.cmdBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.cmdBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBack.Font = New System.Drawing.Font("Wingdings 3", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.cmdBack.Location = New System.Drawing.Point(26, 102)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(35, 35)
        Me.cmdBack.TabIndex = 285
        Me.cmdBack.Text = "f"
        Me.ttMain.SetToolTip(Me.cmdBack, "Back")
        Me.cmdBack.UseVisualStyleBackColor = False
        '
        'PanelBlackHorse
        '
        Me.PanelBlackHorse.AutoScroll = True
        Me.PanelBlackHorse.BackColor = System.Drawing.Color.Transparent
        Me.PanelBlackHorse.BackgroundImage = CType(resources.GetObject("PanelBlackHorse.BackgroundImage"), System.Drawing.Image)
        Me.PanelBlackHorse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelBlackHorse.Location = New System.Drawing.Point(0, -1)
        Me.PanelBlackHorse.Name = "PanelBlackHorse"
        Me.PanelBlackHorse.Size = New System.Drawing.Size(280, 78)
        Me.PanelBlackHorse.TabIndex = 61
        '
        'GrdMain
        '
        Me.GrdMain.AllowUserToAddRows = False
        Me.GrdMain.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.GrdMain.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.GrdMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdMain.BackgroundColor = System.Drawing.Color.White
        Me.GrdMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GrdMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(130, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(130, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdMain.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.GrdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(130, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrdMain.DefaultCellStyle = DataGridViewCellStyle7
        Me.GrdMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GrdMain.GridColor = System.Drawing.Color.Black
        Me.GrdMain.Location = New System.Drawing.Point(300, 148)
        Me.GrdMain.Name = "GrdMain"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(130, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(130, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdMain.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.GrdMain.RowHeadersWidth = 25
        Me.GrdMain.Size = New System.Drawing.Size(1124, 651)
        Me.GrdMain.TabIndex = 119
        '
        'ttMain
        '
        Me.ttMain.IsBalloon = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1434, 811)
        Me.Controls.Add(Me.GrdMain)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMain"
        Me.Text = "SOLUTION_MG_BlackHorse"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMagacinskaDokumentacija.ResumeLayout(False)
        Me.PanelSifarnici.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PanelMagacin.ResumeLayout(False)
        Me.PanelMagacin.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.PanelProizvodnja.ResumeLayout(False)
        CType(Me.GrdMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMain As Panel
    Friend WithEvents CmdIzvestaji As Button
    Friend WithEvents CmdRezervacije As Button
    Friend WithEvents CmdMagacin2D As Button
    Friend WithEvents CmdMagacinskiDokumenti As Button
    Friend WithEvents CmdSifarnici As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PanelMagacinskaDokumentacija As Panel
    Friend WithEvents CmdStanjeArtikala As Button
    Friend WithEvents CmdLagerLista As Button
    Friend WithEvents CmdRashod As Button
    Friend WithEvents CmdPrenosnica As Button
    Friend WithEvents CmdKarticaArtiklaMagacinska As Button
    Friend WithEvents CmdPopis As Button
    Friend WithEvents CmdPocetnoStanje As Button
    Friend WithEvents CmdOtpremnica As Button
    Friend WithEvents CmdPrijemnica As Button
    Friend WithEvents PanelSifarnici As Panel
    Friend WithEvents CmdKomitenti As Button
    Friend WithEvents CmdMagacini As Button
    Friend WithEvents CmdRobneGrupe As Button
    Friend WithEvents CmdArtikli As Button
    Friend WithEvents CmdPodesavanja As Button
    Friend WithEvents CmdOperateri As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TxtNadji As TextBox
    Friend WithEvents CmdNovi As Button
    Friend WithEvents CmdNadji As Button
    Friend WithEvents LblGodina As Label
    Friend WithEvents PanelMagacin As Panel
    Friend WithEvents CmbMagacin As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LblLista As Label
    Friend WithEvents ImgMain As ImageList
    Friend WithEvents Panel As Panel
    Friend WithEvents PanelBlackHorse As Panel
    Friend WithEvents GrdMain As DataGridView
    Friend WithEvents cmdBack As Button
    Friend WithEvents CmdProizvodnja As Button
    Friend WithEvents PanelProizvodnja As Panel
    Friend WithEvents cmdPredajnica As Button
    Friend WithEvents ttMain As ToolTip
    Friend WithEvents cmdTrebovanje As Button
    Friend WithEvents cmdRadniNalog As Button
    Friend WithEvents cmdNormativ As Button
    Friend WithEvents PanelMohokSoft As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LblPanel As Label
End Class
