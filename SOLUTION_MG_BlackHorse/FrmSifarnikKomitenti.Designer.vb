<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSifarnikKomitenti
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
        Dim Label9 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim AdresaLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim RabatLabel As System.Windows.Forms.Label
        Dim NadimakLabel As System.Windows.Forms.Label
        Dim ZiroRacunLabel As System.Windows.Forms.Label
        Dim LiceZaKontaktLabel As System.Windows.Forms.Label
        Dim PIBLabel As System.Windows.Forms.Label
        Dim E_MailLabel As System.Windows.Forms.Label
        Dim MestoLabel As System.Windows.Forms.Label
        Dim PTTLabel As System.Windows.Forms.Label
        Dim TelefonLabel As System.Windows.Forms.Label
        Dim NazivLabel As System.Windows.Forms.Label
        Dim SifraLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSifarnikKomitenti))
        Me.ttInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmrDelay = New System.Windows.Forms.Timer(Me.components)
        Me.TxtZiroRacun2 = New System.Windows.Forms.TextBox()
        Me.TxtSifraDelatnosti = New System.Windows.Forms.TextBox()
        Me.ChkPravnoLice = New System.Windows.Forms.CheckBox()
        Me.TxtPunNaziv = New System.Windows.Forms.TextBox()
        Me.ChkDobavljac = New System.Windows.Forms.CheckBox()
        Me.ChkKupac = New System.Windows.Forms.CheckBox()
        Me.TxtMaticniBroj = New System.Windows.Forms.TextBox()
        Me.TxtRegistarskiBroj = New System.Windows.Forms.TextBox()
        Me.TxtMobilni = New System.Windows.Forms.TextBox()
        Me.TxtAdresa = New System.Windows.Forms.TextBox()
        Me.TxtNapomena = New System.Windows.Forms.TextBox()
        Me.CmbDrzava = New System.Windows.Forms.ComboBox()
        Me.ChkPasivan = New System.Windows.Forms.CheckBox()
        Me.TxtRabat = New System.Windows.Forms.TextBox()
        Me.TxtValuta = New System.Windows.Forms.TextBox()
        Me.TxtZiroRacun1 = New System.Windows.Forms.TextBox()
        Me.TxtLiceZaKontakt = New System.Windows.Forms.TextBox()
        Me.TxtPIB = New System.Windows.Forms.TextBox()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.TxtMesto = New System.Windows.Forms.TextBox()
        Me.TxtPTT = New System.Windows.Forms.TextBox()
        Me.TxtTelefon = New System.Windows.Forms.TextBox()
        Me.TxtNaziv = New System.Windows.Forms.TextBox()
        Me.TxtSifra = New System.Windows.Forms.TextBox()
        Me.TmrIndikatorGreske = New System.Windows.Forms.Timer(Me.components)
        Me.erpIndikatorGreske = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmbReferent = New System.Windows.Forms.ComboBox()
        Me.CmbPodreferent = New System.Windows.Forms.ComboBox()
        Me.TxtKoeficijentProdajneCene = New System.Windows.Forms.TextBox()
        Me.TxtDestinacija = New System.Windows.Forms.TextBox()
        Me.CmdNovaDrzava = New System.Windows.Forms.Button()
        Me.CmdSnimi = New System.Windows.Forms.Button()
        Me.CmdNovi = New System.Windows.Forms.Button()
        Label9 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        AdresaLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        RabatLabel = New System.Windows.Forms.Label()
        NadimakLabel = New System.Windows.Forms.Label()
        ZiroRacunLabel = New System.Windows.Forms.Label()
        LiceZaKontaktLabel = New System.Windows.Forms.Label()
        PIBLabel = New System.Windows.Forms.Label()
        E_MailLabel = New System.Windows.Forms.Label()
        MestoLabel = New System.Windows.Forms.Label()
        PTTLabel = New System.Windows.Forms.Label()
        TelefonLabel = New System.Windows.Forms.Label()
        NazivLabel = New System.Windows.Forms.Label()
        SifraLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        CType(Me.erpIndikatorGreske, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.BackColor = System.Drawing.Color.Transparent
        Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Label9.Location = New System.Drawing.Point(503, 328)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(105, 16)
        Label9.TabIndex = 439
        Label9.Text = "Žiro račun (2):"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.BackColor = System.Drawing.Color.Transparent
        Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Label8.Location = New System.Drawing.Point(495, 246)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(113, 16)
        Label8.TabIndex = 438
        Label8.Text = "Šifra delatnosti:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.Transparent
        Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Label6.Location = New System.Drawing.Point(44, 93)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(76, 16)
        Label6.TabIndex = 435
        Label6.Text = "Pun naziv:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.Color.Transparent
        Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Label5.Location = New System.Drawing.Point(530, 170)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(78, 16)
        Label5.TabIndex = 432
        Label5.Text = "Matični br:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Label4.Location = New System.Drawing.Point(507, 210)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(101, 16)
        Label4.TabIndex = 431
        Label4.Text = "Registarski br:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Label3.Location = New System.Drawing.Point(63, 397)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(57, 16)
        Label3.TabIndex = 430
        Label3.Text = "Mobilni:"
        '
        'AdresaLabel
        '
        AdresaLabel.AutoSize = True
        AdresaLabel.BackColor = System.Drawing.Color.Transparent
        AdresaLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AdresaLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        AdresaLabel.Location = New System.Drawing.Point(62, 169)
        AdresaLabel.Name = "AdresaLabel"
        AdresaLabel.Size = New System.Drawing.Size(58, 16)
        AdresaLabel.TabIndex = 429
        AdresaLabel.Text = "Adresa:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Label2.Location = New System.Drawing.Point(527, 441)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(81, 16)
        Label2.TabIndex = 428
        Label2.Text = "Napomena:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Label1.Location = New System.Drawing.Point(62, 321)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(58, 16)
        Label1.TabIndex = 427
        Label1.Text = "Država:"
        '
        'RabatLabel
        '
        RabatLabel.AutoSize = True
        RabatLabel.BackColor = System.Drawing.Color.Transparent
        RabatLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RabatLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        RabatLabel.Location = New System.Drawing.Point(731, 362)
        RabatLabel.Name = "RabatLabel"
        RabatLabel.Size = New System.Drawing.Size(69, 16)
        RabatLabel.TabIndex = 424
        RabatLabel.Text = "Rabat %:"
        '
        'NadimakLabel
        '
        NadimakLabel.AutoSize = True
        NadimakLabel.BackColor = System.Drawing.Color.Transparent
        NadimakLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NadimakLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        NadimakLabel.Location = New System.Drawing.Point(554, 365)
        NadimakLabel.Name = "NadimakLabel"
        NadimakLabel.Size = New System.Drawing.Size(54, 16)
        NadimakLabel.TabIndex = 423
        NadimakLabel.Text = "Valuta:"
        '
        'ZiroRacunLabel
        '
        ZiroRacunLabel.AutoSize = True
        ZiroRacunLabel.BackColor = System.Drawing.Color.Transparent
        ZiroRacunLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ZiroRacunLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        ZiroRacunLabel.Location = New System.Drawing.Point(503, 287)
        ZiroRacunLabel.Name = "ZiroRacunLabel"
        ZiroRacunLabel.Size = New System.Drawing.Size(105, 16)
        ZiroRacunLabel.TabIndex = 422
        ZiroRacunLabel.Text = "Žiro račun (1):"
        '
        'LiceZaKontaktLabel
        '
        LiceZaKontaktLabel.AutoSize = True
        LiceZaKontaktLabel.BackColor = System.Drawing.Color.Transparent
        LiceZaKontaktLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LiceZaKontaktLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        LiceZaKontaktLabel.Location = New System.Drawing.Point(6, 475)
        LiceZaKontaktLabel.Name = "LiceZaKontaktLabel"
        LiceZaKontaktLabel.Size = New System.Drawing.Size(114, 16)
        LiceZaKontaktLabel.TabIndex = 421
        LiceZaKontaktLabel.Text = "Lice za kontakt:"
        '
        'PIBLabel
        '
        PIBLabel.AutoSize = True
        PIBLabel.BackColor = System.Drawing.Color.Transparent
        PIBLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PIBLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        PIBLabel.Location = New System.Drawing.Point(574, 131)
        PIBLabel.Name = "PIBLabel"
        PIBLabel.Size = New System.Drawing.Size(34, 16)
        PIBLabel.TabIndex = 420
        PIBLabel.Text = "PIB:"
        '
        'E_MailLabel
        '
        E_MailLabel.AutoSize = True
        E_MailLabel.BackColor = System.Drawing.Color.Transparent
        E_MailLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        E_MailLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        E_MailLabel.Location = New System.Drawing.Point(82, 435)
        E_MailLabel.Name = "E_MailLabel"
        E_MailLabel.Size = New System.Drawing.Size(38, 16)
        E_MailLabel.TabIndex = 419
        E_MailLabel.Text = "Mail:"
        '
        'MestoLabel
        '
        MestoLabel.AutoSize = True
        MestoLabel.BackColor = System.Drawing.Color.Transparent
        MestoLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MestoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        MestoLabel.Location = New System.Drawing.Point(67, 283)
        MestoLabel.Name = "MestoLabel"
        MestoLabel.Size = New System.Drawing.Size(53, 16)
        MestoLabel.TabIndex = 418
        MestoLabel.Text = "Mesto:"
        '
        'PTTLabel
        '
        PTTLabel.AutoSize = True
        PTTLabel.BackColor = System.Drawing.Color.Transparent
        PTTLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PTTLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        PTTLabel.Location = New System.Drawing.Point(82, 245)
        PTTLabel.Name = "PTTLabel"
        PTTLabel.Size = New System.Drawing.Size(38, 16)
        PTTLabel.TabIndex = 417
        PTTLabel.Text = "PTT:"
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.BackColor = System.Drawing.Color.Transparent
        TelefonLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        TelefonLabel.Location = New System.Drawing.Point(59, 359)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(61, 16)
        TelefonLabel.TabIndex = 416
        TelefonLabel.Text = "Telefon:"
        '
        'NazivLabel
        '
        NazivLabel.AutoSize = True
        NazivLabel.BackColor = System.Drawing.Color.Transparent
        NazivLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NazivLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        NazivLabel.Location = New System.Drawing.Point(72, 131)
        NazivLabel.Name = "NazivLabel"
        NazivLabel.Size = New System.Drawing.Size(48, 16)
        NazivLabel.TabIndex = 415
        NazivLabel.Text = "Naziv:"
        '
        'SifraLabel
        '
        SifraLabel.AutoSize = True
        SifraLabel.BackColor = System.Drawing.Color.Transparent
        SifraLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SifraLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        SifraLabel.Location = New System.Drawing.Point(77, 55)
        SifraLabel.Name = "SifraLabel"
        SifraLabel.Size = New System.Drawing.Size(43, 16)
        SifraLabel.TabIndex = 414
        SifraLabel.Text = "Šifra:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.BackColor = System.Drawing.Color.Transparent
        Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Label7.Location = New System.Drawing.Point(57, 514)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(63, 16)
        Label7.TabIndex = 455
        Label7.Text = "Referent"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.BackColor = System.Drawing.Color.Transparent
        Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Label10.Location = New System.Drawing.Point(36, 555)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(84, 16)
        Label10.TabIndex = 458
        Label10.Text = "Podreferent"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.BackColor = System.Drawing.Color.Transparent
        Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Label11.Location = New System.Drawing.Point(619, 400)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(181, 16)
        Label11.TabIndex = 460
        Label11.Text = "Koeficijent prodajne cene:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.BackColor = System.Drawing.Color.Transparent
        Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Label12.Location = New System.Drawing.Point(35, 207)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(85, 16)
        Label12.TabIndex = 462
        Label12.Text = "Destinacija:"
        '
        'tmrDelay
        '
        Me.tmrDelay.Interval = 1000
        '
        'TxtZiroRacun2
        '
        Me.TxtZiroRacun2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtZiroRacun2.Location = New System.Drawing.Point(615, 319)
        Me.TxtZiroRacun2.Name = "TxtZiroRacun2"
        Me.TxtZiroRacun2.Size = New System.Drawing.Size(285, 23)
        Me.TxtZiroRacun2.TabIndex = 17
        Me.TxtZiroRacun2.Tag = "17"
        '
        'TxtSifraDelatnosti
        '
        Me.TxtSifraDelatnosti.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSifraDelatnosti.Location = New System.Drawing.Point(615, 241)
        Me.TxtSifraDelatnosti.Name = "TxtSifraDelatnosti"
        Me.TxtSifraDelatnosti.Size = New System.Drawing.Size(285, 23)
        Me.TxtSifraDelatnosti.TabIndex = 15
        Me.TxtSifraDelatnosti.Tag = "15"
        '
        'ChkPravnoLice
        '
        Me.ChkPravnoLice.AutoSize = True
        Me.ChkPravnoLice.BackColor = System.Drawing.Color.Transparent
        Me.ChkPravnoLice.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkPravnoLice.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPravnoLice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ChkPravnoLice.Location = New System.Drawing.Point(522, 53)
        Me.ChkPravnoLice.Name = "ChkPravnoLice"
        Me.ChkPravnoLice.Size = New System.Drawing.Size(98, 20)
        Me.ChkPravnoLice.TabIndex = 437
        Me.ChkPravnoLice.Text = "Pravno lice"
        Me.ChkPravnoLice.UseVisualStyleBackColor = False
        Me.ChkPravnoLice.Visible = False
        '
        'TxtPunNaziv
        '
        Me.TxtPunNaziv.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPunNaziv.Location = New System.Drawing.Point(124, 91)
        Me.TxtPunNaziv.Name = "TxtPunNaziv"
        Me.TxtPunNaziv.Size = New System.Drawing.Size(776, 23)
        Me.TxtPunNaziv.TabIndex = 2
        Me.TxtPunNaziv.Tag = "2"
        '
        'ChkDobavljac
        '
        Me.ChkDobavljac.AutoSize = True
        Me.ChkDobavljac.BackColor = System.Drawing.Color.Transparent
        Me.ChkDobavljac.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkDobavljac.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDobavljac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ChkDobavljac.Location = New System.Drawing.Point(716, 53)
        Me.ChkDobavljac.Name = "ChkDobavljac"
        Me.ChkDobavljac.Size = New System.Drawing.Size(90, 20)
        Me.ChkDobavljac.TabIndex = 434
        Me.ChkDobavljac.Text = "Dobavljač"
        Me.ChkDobavljac.UseVisualStyleBackColor = False
        '
        'ChkKupac
        '
        Me.ChkKupac.AutoSize = True
        Me.ChkKupac.BackColor = System.Drawing.Color.Transparent
        Me.ChkKupac.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkKupac.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkKupac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ChkKupac.Location = New System.Drawing.Point(635, 53)
        Me.ChkKupac.Name = "ChkKupac"
        Me.ChkKupac.Size = New System.Drawing.Size(66, 20)
        Me.ChkKupac.TabIndex = 433
        Me.ChkKupac.Text = "Kupac"
        Me.ChkKupac.UseVisualStyleBackColor = False
        '
        'TxtMaticniBroj
        '
        Me.TxtMaticniBroj.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMaticniBroj.Location = New System.Drawing.Point(615, 163)
        Me.TxtMaticniBroj.Name = "TxtMaticniBroj"
        Me.TxtMaticniBroj.Size = New System.Drawing.Size(193, 23)
        Me.TxtMaticniBroj.TabIndex = 13
        Me.TxtMaticniBroj.Tag = "13"
        '
        'TxtRegistarskiBroj
        '
        Me.TxtRegistarskiBroj.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRegistarskiBroj.Location = New System.Drawing.Point(615, 202)
        Me.TxtRegistarskiBroj.Name = "TxtRegistarskiBroj"
        Me.TxtRegistarskiBroj.Size = New System.Drawing.Size(193, 23)
        Me.TxtRegistarskiBroj.TabIndex = 14
        Me.TxtRegistarskiBroj.Tag = "14"
        '
        'TxtMobilni
        '
        Me.TxtMobilni.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMobilni.Location = New System.Drawing.Point(124, 396)
        Me.TxtMobilni.Name = "TxtMobilni"
        Me.TxtMobilni.Size = New System.Drawing.Size(320, 23)
        Me.TxtMobilni.TabIndex = 9
        Me.TxtMobilni.Tag = "9"
        '
        'TxtAdresa
        '
        Me.TxtAdresa.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdresa.Location = New System.Drawing.Point(124, 167)
        Me.TxtAdresa.Name = "TxtAdresa"
        Me.TxtAdresa.Size = New System.Drawing.Size(320, 23)
        Me.TxtAdresa.TabIndex = 4
        Me.TxtAdresa.Tag = "4"
        '
        'TxtNapomena
        '
        Me.TxtNapomena.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNapomena.Location = New System.Drawing.Point(615, 435)
        Me.TxtNapomena.Multiline = True
        Me.TxtNapomena.Name = "TxtNapomena"
        Me.TxtNapomena.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtNapomena.Size = New System.Drawing.Size(285, 142)
        Me.TxtNapomena.TabIndex = 21
        Me.TxtNapomena.Tag = "21"
        '
        'CmbDrzava
        '
        Me.CmbDrzava.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbDrzava.FormattingEnabled = True
        Me.CmbDrzava.Location = New System.Drawing.Point(124, 319)
        Me.CmbDrzava.Name = "CmbDrzava"
        Me.CmbDrzava.Size = New System.Drawing.Size(320, 24)
        Me.CmbDrzava.TabIndex = 426
        '
        'ChkPasivan
        '
        Me.ChkPasivan.AutoSize = True
        Me.ChkPasivan.BackColor = System.Drawing.Color.Transparent
        Me.ChkPasivan.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkPasivan.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPasivan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ChkPasivan.Location = New System.Drawing.Point(822, 53)
        Me.ChkPasivan.Name = "ChkPasivan"
        Me.ChkPasivan.Size = New System.Drawing.Size(76, 20)
        Me.ChkPasivan.TabIndex = 425
        Me.ChkPasivan.Text = "Pasivan"
        Me.ChkPasivan.UseVisualStyleBackColor = False
        '
        'TxtRabat
        '
        Me.TxtRabat.Enabled = False
        Me.TxtRabat.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRabat.Location = New System.Drawing.Point(807, 359)
        Me.TxtRabat.Name = "TxtRabat"
        Me.TxtRabat.Size = New System.Drawing.Size(93, 23)
        Me.TxtRabat.TabIndex = 19
        Me.TxtRabat.Tag = "19"
        '
        'TxtValuta
        '
        Me.TxtValuta.Enabled = False
        Me.TxtValuta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValuta.Location = New System.Drawing.Point(615, 358)
        Me.TxtValuta.Name = "TxtValuta"
        Me.TxtValuta.Size = New System.Drawing.Size(92, 23)
        Me.TxtValuta.TabIndex = 18
        Me.TxtValuta.Tag = "18"
        '
        'TxtZiroRacun1
        '
        Me.TxtZiroRacun1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtZiroRacun1.Location = New System.Drawing.Point(615, 280)
        Me.TxtZiroRacun1.Name = "TxtZiroRacun1"
        Me.TxtZiroRacun1.Size = New System.Drawing.Size(285, 23)
        Me.TxtZiroRacun1.TabIndex = 16
        Me.TxtZiroRacun1.Tag = "16"
        '
        'TxtLiceZaKontakt
        '
        Me.TxtLiceZaKontakt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLiceZaKontakt.Location = New System.Drawing.Point(124, 472)
        Me.TxtLiceZaKontakt.Name = "TxtLiceZaKontakt"
        Me.TxtLiceZaKontakt.Size = New System.Drawing.Size(320, 23)
        Me.TxtLiceZaKontakt.TabIndex = 11
        Me.TxtLiceZaKontakt.Tag = "11"
        '
        'TxtPIB
        '
        Me.TxtPIB.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPIB.Location = New System.Drawing.Point(615, 124)
        Me.TxtPIB.Name = "TxtPIB"
        Me.TxtPIB.Size = New System.Drawing.Size(193, 23)
        Me.TxtPIB.TabIndex = 12
        Me.TxtPIB.Tag = "12"
        '
        'TxtMail
        '
        Me.TxtMail.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMail.Location = New System.Drawing.Point(124, 434)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(320, 23)
        Me.TxtMail.TabIndex = 10
        Me.TxtMail.Tag = "10"
        '
        'TxtMesto
        '
        Me.TxtMesto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMesto.Location = New System.Drawing.Point(124, 281)
        Me.TxtMesto.Name = "TxtMesto"
        Me.TxtMesto.Size = New System.Drawing.Size(320, 23)
        Me.TxtMesto.TabIndex = 7
        Me.TxtMesto.Tag = "7"
        '
        'TxtPTT
        '
        Me.TxtPTT.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPTT.Location = New System.Drawing.Point(124, 243)
        Me.TxtPTT.Name = "TxtPTT"
        Me.TxtPTT.Size = New System.Drawing.Size(112, 23)
        Me.TxtPTT.TabIndex = 6
        Me.TxtPTT.Tag = "6"
        '
        'TxtTelefon
        '
        Me.TxtTelefon.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefon.Location = New System.Drawing.Point(124, 358)
        Me.TxtTelefon.Name = "TxtTelefon"
        Me.TxtTelefon.Size = New System.Drawing.Size(320, 23)
        Me.TxtTelefon.TabIndex = 8
        Me.TxtTelefon.Tag = "8"
        '
        'TxtNaziv
        '
        Me.TxtNaziv.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNaziv.Location = New System.Drawing.Point(124, 129)
        Me.TxtNaziv.Name = "TxtNaziv"
        Me.TxtNaziv.Size = New System.Drawing.Size(320, 23)
        Me.TxtNaziv.TabIndex = 3
        Me.TxtNaziv.Tag = "3"
        '
        'TxtSifra
        '
        Me.TxtSifra.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSifra.Location = New System.Drawing.Point(124, 53)
        Me.TxtSifra.Name = "TxtSifra"
        Me.TxtSifra.Size = New System.Drawing.Size(112, 23)
        Me.TxtSifra.TabIndex = 1
        Me.TxtSifra.Tag = "1"
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
        'cmbReferent
        '
        Me.cmbReferent.Enabled = False
        Me.cmbReferent.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReferent.FormattingEnabled = True
        Me.cmbReferent.Location = New System.Drawing.Point(124, 510)
        Me.cmbReferent.Name = "cmbReferent"
        Me.cmbReferent.Size = New System.Drawing.Size(247, 26)
        Me.cmbReferent.TabIndex = 456
        '
        'CmbPodreferent
        '
        Me.CmbPodreferent.Enabled = False
        Me.CmbPodreferent.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPodreferent.FormattingEnabled = True
        Me.CmbPodreferent.Location = New System.Drawing.Point(124, 551)
        Me.CmbPodreferent.Name = "CmbPodreferent"
        Me.CmbPodreferent.Size = New System.Drawing.Size(247, 26)
        Me.CmbPodreferent.TabIndex = 457
        '
        'TxtKoeficijentProdajneCene
        '
        Me.TxtKoeficijentProdajneCene.Enabled = False
        Me.TxtKoeficijentProdajneCene.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKoeficijentProdajneCene.Location = New System.Drawing.Point(807, 397)
        Me.TxtKoeficijentProdajneCene.Name = "TxtKoeficijentProdajneCene"
        Me.TxtKoeficijentProdajneCene.Size = New System.Drawing.Size(92, 23)
        Me.TxtKoeficijentProdajneCene.TabIndex = 20
        Me.TxtKoeficijentProdajneCene.Tag = "20"
        '
        'TxtDestinacija
        '
        Me.TxtDestinacija.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDestinacija.Location = New System.Drawing.Point(124, 205)
        Me.TxtDestinacija.Name = "TxtDestinacija"
        Me.TxtDestinacija.Size = New System.Drawing.Size(320, 23)
        Me.TxtDestinacija.TabIndex = 5
        Me.TxtDestinacija.Tag = "5"
        '
        'CmdNovaDrzava
        '
        Me.CmdNovaDrzava.BackColor = System.Drawing.Color.Transparent
        Me.CmdNovaDrzava.BackgroundImage = CType(resources.GetObject("CmdNovaDrzava.BackgroundImage"), System.Drawing.Image)
        Me.CmdNovaDrzava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdNovaDrzava.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdNovaDrzava.FlatAppearance.BorderSize = 0
        Me.CmdNovaDrzava.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.CmdNovaDrzava.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.CmdNovaDrzava.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdNovaDrzava.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNovaDrzava.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.CmdNovaDrzava.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdNovaDrzava.Location = New System.Drawing.Point(450, 318)
        Me.CmdNovaDrzava.Name = "CmdNovaDrzava"
        Me.CmdNovaDrzava.Size = New System.Drawing.Size(25, 25)
        Me.CmdNovaDrzava.TabIndex = 463
        Me.ttInfo.SetToolTip(Me.CmdNovaDrzava, "Unos nove robne grupe")
        Me.CmdNovaDrzava.UseVisualStyleBackColor = False
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
        Me.CmdSnimi.Location = New System.Drawing.Point(795, 607)
        Me.CmdSnimi.Name = "CmdSnimi"
        Me.CmdSnimi.Size = New System.Drawing.Size(105, 40)
        Me.CmdSnimi.TabIndex = 465
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
        Me.CmdNovi.Location = New System.Drawing.Point(667, 607)
        Me.CmdNovi.Name = "CmdNovi"
        Me.CmdNovi.Size = New System.Drawing.Size(100, 40)
        Me.CmdNovi.TabIndex = 464
        Me.CmdNovi.Text = "Novi"
        Me.CmdNovi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdNovi.UseVisualStyleBackColor = False
        '
        'FrmSifarnikKomitenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(930, 681)
        Me.Controls.Add(Me.CmdSnimi)
        Me.Controls.Add(Me.CmdNovi)
        Me.Controls.Add(Me.CmdNovaDrzava)
        Me.Controls.Add(Label12)
        Me.Controls.Add(Me.TxtDestinacija)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Me.TxtKoeficijentProdajneCene)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Me.CmbPodreferent)
        Me.Controls.Add(Me.cmbReferent)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Me.TxtZiroRacun2)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Me.TxtSifraDelatnosti)
        Me.Controls.Add(Me.ChkPravnoLice)
        Me.Controls.Add(Me.TxtPunNaziv)
        Me.Controls.Add(Me.ChkDobavljac)
        Me.Controls.Add(Me.ChkKupac)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.TxtMaticniBroj)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.TxtRegistarskiBroj)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.TxtMobilni)
        Me.Controls.Add(AdresaLabel)
        Me.Controls.Add(Me.TxtAdresa)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TxtNapomena)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.CmbDrzava)
        Me.Controls.Add(Me.ChkPasivan)
        Me.Controls.Add(RabatLabel)
        Me.Controls.Add(Me.TxtRabat)
        Me.Controls.Add(NadimakLabel)
        Me.Controls.Add(Me.TxtValuta)
        Me.Controls.Add(ZiroRacunLabel)
        Me.Controls.Add(Me.TxtZiroRacun1)
        Me.Controls.Add(LiceZaKontaktLabel)
        Me.Controls.Add(Me.TxtLiceZaKontakt)
        Me.Controls.Add(PIBLabel)
        Me.Controls.Add(Me.TxtPIB)
        Me.Controls.Add(E_MailLabel)
        Me.Controls.Add(Me.TxtMail)
        Me.Controls.Add(Me.TxtMesto)
        Me.Controls.Add(Me.TxtPTT)
        Me.Controls.Add(Me.TxtTelefon)
        Me.Controls.Add(Me.TxtNaziv)
        Me.Controls.Add(Me.TxtSifra)
        Me.Controls.Add(MestoLabel)
        Me.Controls.Add(PTTLabel)
        Me.Controls.Add(TelefonLabel)
        Me.Controls.Add(NazivLabel)
        Me.Controls.Add(SifraLabel)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSifarnikKomitenti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "KOMITENTI"
        CType(Me.erpIndikatorGreske, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ttInfo As ToolTip
    Friend WithEvents tmrDelay As Timer
    Friend WithEvents TxtZiroRacun2 As TextBox
    Friend WithEvents TxtSifraDelatnosti As TextBox
    Friend WithEvents ChkPravnoLice As CheckBox
    Friend WithEvents TxtPunNaziv As TextBox
    Friend WithEvents ChkDobavljac As CheckBox
    Friend WithEvents ChkKupac As CheckBox
    Friend WithEvents TxtMaticniBroj As TextBox
    Friend WithEvents TxtRegistarskiBroj As TextBox
    Friend WithEvents TxtMobilni As TextBox
    Friend WithEvents TxtAdresa As TextBox
    Friend WithEvents TxtNapomena As TextBox
    Friend WithEvents CmbDrzava As ComboBox
    Friend WithEvents ChkPasivan As CheckBox
    Friend WithEvents TxtRabat As TextBox
    Friend WithEvents TxtValuta As TextBox
    Friend WithEvents TxtZiroRacun1 As TextBox
    Friend WithEvents TxtLiceZaKontakt As TextBox
    Friend WithEvents TxtPIB As TextBox
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents TxtMesto As TextBox
    Friend WithEvents TxtPTT As TextBox
    Friend WithEvents TxtTelefon As TextBox
    Friend WithEvents TxtNaziv As TextBox
    Friend WithEvents TxtSifra As TextBox
    Friend WithEvents TmrIndikatorGreske As Timer
    Friend WithEvents erpIndikatorGreske As ErrorProvider
    Friend WithEvents CmbPodreferent As ComboBox
    Friend WithEvents cmbReferent As ComboBox
    Friend WithEvents TxtKoeficijentProdajneCene As TextBox
    Friend WithEvents TxtDestinacija As TextBox
    Friend WithEvents CmdNovaDrzava As Button
    Friend WithEvents CmdSnimi As Button
    Friend WithEvents CmdNovi As Button
End Class
