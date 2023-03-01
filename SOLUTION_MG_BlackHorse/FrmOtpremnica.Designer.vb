<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOtpremnica
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOtpremnica))
        Me.erpIndikatorGreske = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TmrIndikatorGreske = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDelay = New System.Windows.Forms.Timer(Me.components)
        Me.ttForma = New System.Windows.Forms.ToolTip(Me.components)
        Me.CmbMagacin = New System.Windows.Forms.ComboBox()
        Me.TxtSifraMagacina = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtKolicina = New System.Windows.Forms.TextBox()
        Me.CmbPredhodniMagacin = New System.Windows.Forms.ComboBox()
        Me.txtSifraArtikla = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtBrojRacuna = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtJM = New System.Windows.Forms.TextBox()
        Me.lblDisp = New System.Windows.Forms.Label()
        Me.dtpDatum = New System.Windows.Forms.DateTimePicker()
        Me.chkRacunUradjen = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtVozilo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNapomena = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkKnjizeno = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBroj = New System.Windows.Forms.TextBox()
        Me.txtSifraPredhodnogMagacina = New System.Windows.Forms.TextBox()
        Me.TxtRobuIzdao = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtDestinacija = New System.Windows.Forms.TextBox()
        Me.txtStanje = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.mnuOtpremnica = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBrisanje = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSortiranjeAZ = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSortiranjeZA = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuAzurirajRbr = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ChkGratis = New System.Windows.Forms.CheckBox()
        Me.ChkIzvoz = New System.Windows.Forms.CheckBox()
        Me.CmbNacinIsporuke = New System.Windows.Forms.ComboBox()
        Me.CmbKurirskeSluzbe = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtNazivKupca = New System.Windows.Forms.TextBox()
        Me.txtSifraKupca = New System.Windows.Forms.TextBox()
        Me.grdLista = New System.Windows.Forms.DataGridView()
        Me.GrdListaStavki = New System.Windows.Forms.DataGridView()
        Me.TxtNazivArtikla = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.grdStavke = New SOLUTION_MG_BlackHorse.myDataGridView()
        Me.CmdSnimi = New System.Windows.Forms.Button()
        Me.CmdNovi = New System.Windows.Forms.Button()
        Me.cmdKnjizenje = New System.Windows.Forms.Button()
        Me.CmdPrenosnica = New System.Windows.Forms.Button()
        Me.cmdStampa = New System.Windows.Forms.Button()
        CType(Me.erpIndikatorGreske, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuOtpremnica.SuspendLayout()
        CType(Me.grdLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdListaStavki, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdStavke, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'erpIndikatorGreske
        '
        Me.erpIndikatorGreske.BlinkRate = 500
        Me.erpIndikatorGreske.ContainerControl = Me
        '
        'TmrIndikatorGreske
        '
        Me.TmrIndikatorGreske.Interval = 5000
        '
        'tmrDelay
        '
        Me.tmrDelay.Interval = 1000
        '
        'CmbMagacin
        '
        Me.CmbMagacin.BackColor = System.Drawing.SystemColors.Window
        Me.CmbMagacin.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMagacin.FormattingEnabled = True
        Me.CmbMagacin.Location = New System.Drawing.Point(311, 46)
        Me.CmbMagacin.Name = "CmbMagacin"
        Me.CmbMagacin.Size = New System.Drawing.Size(300, 26)
        Me.CmbMagacin.TabIndex = 498
        Me.CmbMagacin.Visible = False
        '
        'TxtSifraMagacina
        '
        Me.TxtSifraMagacina.BackColor = System.Drawing.SystemColors.Window
        Me.TxtSifraMagacina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSifraMagacina.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSifraMagacina.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtSifraMagacina.Location = New System.Drawing.Point(241, 47)
        Me.TxtSifraMagacina.Name = "TxtSifraMagacina"
        Me.TxtSifraMagacina.Size = New System.Drawing.Size(64, 26)
        Me.TxtSifraMagacina.TabIndex = 470
        Me.TxtSifraMagacina.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(1084, 206)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 19)
        Me.Label8.TabIndex = 161
        Me.Label8.Text = "Količina"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(910, 205)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 19)
        Me.Label5.TabIndex = 164
        Me.Label5.Text = "J.mere"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(69, 206)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(179, 19)
        Me.Label9.TabIndex = 166
        Me.Label9.Text = "Predhodni magacin stavki "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(563, 205)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 19)
        Me.Label6.TabIndex = 165
        Me.Label6.Text = "Naziv artikla"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(497, 205)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 19)
        Me.Label7.TabIndex = 169
        Me.Label7.Text = "Šifra"
        '
        'txtKolicina
        '
        Me.txtKolicina.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtKolicina.Location = New System.Drawing.Point(1067, 227)
        Me.txtKolicina.Name = "txtKolicina"
        Me.txtKolicina.Size = New System.Drawing.Size(80, 23)
        Me.txtKolicina.TabIndex = 464
        Me.txtKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CmbPredhodniMagacin
        '
        Me.CmbPredhodniMagacin.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.CmbPredhodniMagacin.FormattingEnabled = True
        Me.CmbPredhodniMagacin.Location = New System.Drawing.Point(104, 227)
        Me.CmbPredhodniMagacin.Name = "CmbPredhodniMagacin"
        Me.CmbPredhodniMagacin.Size = New System.Drawing.Size(250, 24)
        Me.CmbPredhodniMagacin.TabIndex = 496
        '
        'txtSifraArtikla
        '
        Me.txtSifraArtikla.Enabled = False
        Me.txtSifraArtikla.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtSifraArtikla.Location = New System.Drawing.Point(501, 227)
        Me.txtSifraArtikla.Name = "txtSifraArtikla"
        Me.txtSifraArtikla.Size = New System.Drawing.Size(70, 23)
        Me.txtSifraArtikla.TabIndex = 467
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(1057, 85)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 16)
        Me.Label18.TabIndex = 495
        Me.Label18.Text = "Broj računa"
        '
        'txtBrojRacuna
        '
        Me.txtBrojRacuna.Enabled = False
        Me.txtBrojRacuna.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtBrojRacuna.Location = New System.Drawing.Point(1059, 106)
        Me.txtBrojRacuna.Name = "txtBrojRacuna"
        Me.txtBrojRacuna.Size = New System.Drawing.Size(85, 23)
        Me.txtBrojRacuna.TabIndex = 494
        Me.txtBrojRacuna.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(1045, 49)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 16)
        Me.Label16.TabIndex = 493
        Me.Label16.Text = "Račun urađen"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(1045, 30)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 16)
        Me.Label15.TabIndex = 492
        Me.Label15.Text = "Knjiženo"
        '
        'txtJM
        '
        Me.txtJM.Enabled = False
        Me.txtJM.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtJM.Location = New System.Drawing.Point(919, 227)
        Me.txtJM.Name = "txtJM"
        Me.txtJM.Size = New System.Drawing.Size(60, 23)
        Me.txtJM.TabIndex = 466
        '
        'lblDisp
        '
        Me.lblDisp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDisp.BackColor = System.Drawing.Color.Transparent
        Me.lblDisp.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.lblDisp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.lblDisp.Location = New System.Drawing.Point(1033, 645)
        Me.lblDisp.Name = "lblDisp"
        Me.lblDisp.Size = New System.Drawing.Size(111, 19)
        Me.lblDisp.TabIndex = 490
        Me.lblDisp.Text = "0.00"
        Me.lblDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDisp.Visible = False
        '
        'dtpDatum
        '
        Me.dtpDatum.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatum.Location = New System.Drawing.Point(101, 51)
        Me.dtpDatum.Name = "dtpDatum"
        Me.dtpDatum.Size = New System.Drawing.Size(120, 23)
        Me.dtpDatum.TabIndex = 488
        '
        'chkRacunUradjen
        '
        Me.chkRacunUradjen.AutoSize = True
        Me.chkRacunUradjen.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.chkRacunUradjen.Enabled = False
        Me.chkRacunUradjen.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRacunUradjen.ForeColor = System.Drawing.Color.SkyBlue
        Me.chkRacunUradjen.Location = New System.Drawing.Point(1027, 53)
        Me.chkRacunUradjen.Name = "chkRacunUradjen"
        Me.chkRacunUradjen.Size = New System.Drawing.Size(15, 14)
        Me.chkRacunUradjen.TabIndex = 487
        Me.chkRacunUradjen.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(853, 85)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(189, 16)
        Me.Label14.TabIndex = 486
        Me.Label14.Text = "Vozilo - reg.oznaka - vozač"
        '
        'txtVozilo
        '
        Me.txtVozilo.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtVozilo.Location = New System.Drawing.Point(857, 106)
        Me.txtVozilo.Name = "txtVozilo"
        Me.txtVozilo.ReadOnly = True
        Me.txtVozilo.Size = New System.Drawing.Size(196, 23)
        Me.txtVozilo.TabIndex = 485
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(563, 138)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 19)
        Me.Label12.TabIndex = 482
        Me.Label12.Text = "Napomena"
        '
        'txtNapomena
        '
        Me.txtNapomena.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtNapomena.Location = New System.Drawing.Point(565, 161)
        Me.txtNapomena.Name = "txtNapomena"
        Me.txtNapomena.ReadOnly = True
        Me.txtNapomena.Size = New System.Drawing.Size(579, 23)
        Me.txtNapomena.TabIndex = 481
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(98, 85)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 476
        Me.Label3.Text = "Kupac"
        '
        'chkKnjizeno
        '
        Me.chkKnjizeno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkKnjizeno.AutoSize = True
        Me.chkKnjizeno.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.chkKnjizeno.Enabled = False
        Me.chkKnjizeno.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkKnjizeno.ForeColor = System.Drawing.Color.SkyBlue
        Me.chkKnjizeno.Location = New System.Drawing.Point(1027, 33)
        Me.chkKnjizeno.Name = "chkKnjizeno"
        Me.chkKnjizeno.Size = New System.Drawing.Size(15, 14)
        Me.chkKnjizeno.TabIndex = 474
        Me.chkKnjizeno.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(101, 29)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 473
        Me.Label4.Text = "Datum"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(29, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 472
        Me.Label2.Text = "Broj"
        '
        'txtBroj
        '
        Me.txtBroj.Enabled = False
        Me.txtBroj.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtBroj.Location = New System.Drawing.Point(30, 50)
        Me.txtBroj.Name = "txtBroj"
        Me.txtBroj.Size = New System.Drawing.Size(65, 23)
        Me.txtBroj.TabIndex = 471
        '
        'txtSifraPredhodnogMagacina
        '
        Me.txtSifraPredhodnogMagacina.Enabled = False
        Me.txtSifraPredhodnogMagacina.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtSifraPredhodnogMagacina.Location = New System.Drawing.Point(75, 227)
        Me.txtSifraPredhodnogMagacina.Name = "txtSifraPredhodnogMagacina"
        Me.txtSifraPredhodnogMagacina.Size = New System.Drawing.Size(25, 23)
        Me.txtSifraPredhodnogMagacina.TabIndex = 469
        '
        'TxtRobuIzdao
        '
        Me.TxtRobuIzdao.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TxtRobuIzdao.Location = New System.Drawing.Point(382, 161)
        Me.TxtRobuIzdao.Name = "TxtRobuIzdao"
        Me.TxtRobuIzdao.ReadOnly = True
        Me.TxtRobuIzdao.Size = New System.Drawing.Size(175, 23)
        Me.TxtRobuIzdao.TabIndex = 483
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(384, 138)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 19)
        Me.Label13.TabIndex = 484
        Me.Label13.Text = "Robu izdao"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(523, 85)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 16)
        Me.Label10.TabIndex = 505
        Me.Label10.Text = "Destinacija"
        '
        'TxtDestinacija
        '
        Me.TxtDestinacija.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TxtDestinacija.Location = New System.Drawing.Point(525, 106)
        Me.TxtDestinacija.Name = "TxtDestinacija"
        Me.TxtDestinacija.ReadOnly = True
        Me.TxtDestinacija.Size = New System.Drawing.Size(326, 23)
        Me.TxtDestinacija.TabIndex = 504
        '
        'txtStanje
        '
        Me.txtStanje.Enabled = False
        Me.txtStanje.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtStanje.Location = New System.Drawing.Point(983, 227)
        Me.txtStanje.Name = "txtStanje"
        Me.txtStanje.Size = New System.Drawing.Size(80, 23)
        Me.txtStanje.TabIndex = 506
        Me.txtStanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(979, 205)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 19)
        Me.Label20.TabIndex = 164
        Me.Label20.Text = "Stanje"
        '
        'mnuOtpremnica
        '
        Me.mnuOtpremnica.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.mnuBrisanje, Me.ToolStripSeparator2, Me.mnuSortiranjeAZ, Me.mnuSortiranjeZA, Me.ToolStripSeparator3, Me.mnuAzurirajRbr})
        Me.mnuOtpremnica.Name = "mnuUlaz"
        Me.mnuOtpremnica.Size = New System.Drawing.Size(190, 110)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(186, 6)
        '
        'mnuBrisanje
        '
        Me.mnuBrisanje.Image = CType(resources.GetObject("mnuBrisanje.Image"), System.Drawing.Image)
        Me.mnuBrisanje.Name = "mnuBrisanje"
        Me.mnuBrisanje.Size = New System.Drawing.Size(189, 22)
        Me.mnuBrisanje.Text = "Brisanje stavke"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(186, 6)
        '
        'mnuSortiranjeAZ
        '
        Me.mnuSortiranjeAZ.Image = CType(resources.GetObject("mnuSortiranjeAZ.Image"), System.Drawing.Image)
        Me.mnuSortiranjeAZ.Name = "mnuSortiranjeAZ"
        Me.mnuSortiranjeAZ.Size = New System.Drawing.Size(189, 22)
        Me.mnuSortiranjeAZ.Text = "Sortiranje A_Z"
        '
        'mnuSortiranjeZA
        '
        Me.mnuSortiranjeZA.Image = CType(resources.GetObject("mnuSortiranjeZA.Image"), System.Drawing.Image)
        Me.mnuSortiranjeZA.Name = "mnuSortiranjeZA"
        Me.mnuSortiranjeZA.Size = New System.Drawing.Size(189, 22)
        Me.mnuSortiranjeZA.Text = "Sortiranje Z_A"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(186, 6)
        '
        'mnuAzurirajRbr
        '
        Me.mnuAzurirajRbr.Image = CType(resources.GetObject("mnuAzurirajRbr.Image"), System.Drawing.Image)
        Me.mnuAzurirajRbr.Name = "mnuAzurirajRbr"
        Me.mnuAzurirajRbr.Size = New System.Drawing.Size(189, 22)
        Me.mnuAzurirajRbr.Text = "Ažuriraj redne brojeve"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(917, 48)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 16)
        Me.Label11.TabIndex = 512
        Me.Label11.Text = "Gratis račun"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(917, 29)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(42, 16)
        Me.Label21.TabIndex = 511
        Me.Label21.Text = "Izvoz"
        '
        'ChkGratis
        '
        Me.ChkGratis.AutoSize = True
        Me.ChkGratis.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ChkGratis.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkGratis.ForeColor = System.Drawing.Color.SkyBlue
        Me.ChkGratis.Location = New System.Drawing.Point(899, 52)
        Me.ChkGratis.Name = "ChkGratis"
        Me.ChkGratis.Size = New System.Drawing.Size(15, 14)
        Me.ChkGratis.TabIndex = 510
        Me.ChkGratis.UseVisualStyleBackColor = False
        '
        'ChkIzvoz
        '
        Me.ChkIzvoz.AutoSize = True
        Me.ChkIzvoz.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ChkIzvoz.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkIzvoz.ForeColor = System.Drawing.Color.SkyBlue
        Me.ChkIzvoz.Location = New System.Drawing.Point(899, 32)
        Me.ChkIzvoz.Name = "ChkIzvoz"
        Me.ChkIzvoz.Size = New System.Drawing.Size(15, 14)
        Me.ChkIzvoz.TabIndex = 509
        Me.ChkIzvoz.UseVisualStyleBackColor = False
        '
        'CmbNacinIsporuke
        '
        Me.CmbNacinIsporuke.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.CmbNacinIsporuke.FormattingEnabled = True
        Me.CmbNacinIsporuke.Location = New System.Drawing.Point(30, 161)
        Me.CmbNacinIsporuke.Name = "CmbNacinIsporuke"
        Me.CmbNacinIsporuke.Size = New System.Drawing.Size(161, 24)
        Me.CmbNacinIsporuke.TabIndex = 513
        '
        'CmbKurirskeSluzbe
        '
        Me.CmbKurirskeSluzbe.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.CmbKurirskeSluzbe.FormattingEnabled = True
        Me.CmbKurirskeSluzbe.Location = New System.Drawing.Point(199, 161)
        Me.CmbKurirskeSluzbe.Name = "CmbKurirskeSluzbe"
        Me.CmbKurirskeSluzbe.Size = New System.Drawing.Size(175, 24)
        Me.CmbKurirskeSluzbe.TabIndex = 514
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(30, 138)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(104, 19)
        Me.Label22.TabIndex = 515
        Me.Label22.Text = "Način isporuke"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(199, 138)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(106, 19)
        Me.Label23.TabIndex = 516
        Me.Label23.Text = "Kurirska služba"
        '
        'txtNazivKupca
        '
        Me.txtNazivKupca.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtNazivKupca.Location = New System.Drawing.Point(102, 106)
        Me.txtNazivKupca.Name = "txtNazivKupca"
        Me.txtNazivKupca.Size = New System.Drawing.Size(417, 23)
        Me.txtNazivKupca.TabIndex = 577
        '
        'txtSifraKupca
        '
        Me.txtSifraKupca.Enabled = False
        Me.txtSifraKupca.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtSifraKupca.Location = New System.Drawing.Point(30, 106)
        Me.txtSifraKupca.Name = "txtSifraKupca"
        Me.txtSifraKupca.Size = New System.Drawing.Size(65, 23)
        Me.txtSifraKupca.TabIndex = 575
        '
        'grdLista
        '
        Me.grdLista.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.grdLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdLista.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdLista.Location = New System.Drawing.Point(34, 135)
        Me.grdLista.Name = "grdLista"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdLista.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdLista.RowHeadersWidth = 20
        Me.grdLista.Size = New System.Drawing.Size(819, 127)
        Me.grdLista.TabIndex = 578
        Me.grdLista.Visible = False
        '
        'GrdListaStavki
        '
        Me.GrdListaStavki.AllowUserToAddRows = False
        Me.GrdListaStavki.AllowUserToDeleteRows = False
        Me.GrdListaStavki.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.GrdListaStavki.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdListaStavki.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GrdListaStavki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrdListaStavki.DefaultCellStyle = DataGridViewCellStyle5
        Me.GrdListaStavki.Location = New System.Drawing.Point(501, 256)
        Me.GrdListaStavki.Name = "GrdListaStavki"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdListaStavki.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.GrdListaStavki.RowHeadersWidth = 20
        Me.GrdListaStavki.Size = New System.Drawing.Size(620, 134)
        Me.GrdListaStavki.TabIndex = 638
        Me.GrdListaStavki.Visible = False
        '
        'TxtNazivArtikla
        '
        Me.TxtNazivArtikla.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TxtNazivArtikla.Location = New System.Drawing.Point(575, 227)
        Me.TxtNazivArtikla.Name = "TxtNazivArtikla"
        Me.TxtNazivArtikla.Size = New System.Drawing.Size(340, 23)
        Me.TxtNazivArtikla.TabIndex = 639
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(354, 206)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 19)
        Me.Label24.TabIndex = 164
        Me.Label24.Text = "Prenosnica"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TextBox1.Location = New System.Drawing.Point(422, 227)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(75, 23)
        Me.TextBox1.TabIndex = 642
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.SkyBlue
        Me.CheckBox1.Location = New System.Drawing.Point(380, 232)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 643
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TextBox2.Location = New System.Drawing.Point(358, 227)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(60, 23)
        Me.TextBox2.TabIndex = 644
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grdStavke
        '
        Me.grdStavke.AllowUserToAddRows = False
        Me.grdStavke.AllowUserToDeleteRows = False
        Me.grdStavke.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdStavke.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.grdStavke.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdStavke.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdStavke.Location = New System.Drawing.Point(26, 271)
        Me.grdStavke.Name = "grdStavke"
        Me.grdStavke.PoslednjaKolona = CType(8, Short)
        Me.grdStavke.PrvaKolona = CType(8, Short)
        Me.grdStavke.RowHeadersWidth = 20
        Me.grdStavke.Size = New System.Drawing.Size(1140, 371)
        Me.grdStavke.TabIndex = 497
        Me.grdStavke.VertikalniSBUvekVidljiv = False
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
        Me.CmdSnimi.Location = New System.Drawing.Point(1063, 675)
        Me.CmdSnimi.Name = "CmdSnimi"
        Me.CmdSnimi.Size = New System.Drawing.Size(105, 40)
        Me.CmdSnimi.TabIndex = 646
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
        Me.CmdNovi.Location = New System.Drawing.Point(935, 675)
        Me.CmdNovi.Name = "CmdNovi"
        Me.CmdNovi.Size = New System.Drawing.Size(100, 40)
        Me.CmdNovi.TabIndex = 645
        Me.CmdNovi.Text = "Novi"
        Me.CmdNovi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdNovi.UseVisualStyleBackColor = False
        '
        'cmdKnjizenje
        '
        Me.cmdKnjizenje.BackColor = System.Drawing.Color.Transparent
        Me.cmdKnjizenje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdKnjizenje.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdKnjizenje.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.cmdKnjizenje.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdKnjizenje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.cmdKnjizenje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.cmdKnjizenje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdKnjizenje.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdKnjizenje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.cmdKnjizenje.Image = CType(resources.GetObject("cmdKnjizenje.Image"), System.Drawing.Image)
        Me.cmdKnjizenje.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.cmdKnjizenje.Location = New System.Drawing.Point(184, 675)
        Me.cmdKnjizenje.Name = "cmdKnjizenje"
        Me.cmdKnjizenje.Size = New System.Drawing.Size(130, 40)
        Me.cmdKnjizenje.TabIndex = 648
        Me.cmdKnjizenje.Text = "Knjiženje"
        Me.cmdKnjizenje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdKnjizenje.UseVisualStyleBackColor = False
        '
        'CmdPrenosnica
        '
        Me.CmdPrenosnica.BackColor = System.Drawing.Color.Transparent
        Me.CmdPrenosnica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdPrenosnica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdPrenosnica.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.CmdPrenosnica.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CmdPrenosnica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdPrenosnica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdPrenosnica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdPrenosnica.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrenosnica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.CmdPrenosnica.Image = CType(resources.GetObject("CmdPrenosnica.Image"), System.Drawing.Image)
        Me.CmdPrenosnica.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.CmdPrenosnica.Location = New System.Drawing.Point(28, 675)
        Me.CmdPrenosnica.Name = "CmdPrenosnica"
        Me.CmdPrenosnica.Size = New System.Drawing.Size(130, 40)
        Me.CmdPrenosnica.TabIndex = 647
        Me.CmdPrenosnica.Text = "Prenos"
        Me.CmdPrenosnica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdPrenosnica.UseVisualStyleBackColor = False
        '
        'cmdStampa
        '
        Me.cmdStampa.BackColor = System.Drawing.Color.Transparent
        Me.cmdStampa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdStampa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdStampa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.cmdStampa.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdStampa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.cmdStampa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.cmdStampa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdStampa.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStampa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.cmdStampa.Image = CType(resources.GetObject("cmdStampa.Image"), System.Drawing.Image)
        Me.cmdStampa.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.cmdStampa.Location = New System.Drawing.Point(340, 675)
        Me.cmdStampa.Name = "cmdStampa"
        Me.cmdStampa.Size = New System.Drawing.Size(130, 40)
        Me.cmdStampa.TabIndex = 649
        Me.cmdStampa.Text = "Štampa"
        Me.cmdStampa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdStampa.UseVisualStyleBackColor = False
        '
        'FrmOtpremnica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 761)
        Me.Controls.Add(Me.grdLista)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdStampa)
        Me.Controls.Add(Me.cmdKnjizenje)
        Me.Controls.Add(Me.CmdPrenosnica)
        Me.Controls.Add(Me.CmdSnimi)
        Me.Controls.Add(Me.CmdNovi)
        Me.Controls.Add(Me.CmbMagacin)
        Me.Controls.Add(Me.TxtSifraMagacina)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TxtNazivArtikla)
        Me.Controls.Add(Me.GrdListaStavki)
        Me.Controls.Add(Me.txtNazivKupca)
        Me.Controls.Add(Me.txtSifraKupca)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.CmbKurirskeSluzbe)
        Me.Controls.Add(Me.CmbNacinIsporuke)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.ChkGratis)
        Me.Controls.Add(Me.ChkIzvoz)
        Me.Controls.Add(Me.txtStanje)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtDestinacija)
        Me.Controls.Add(Me.grdStavke)
        Me.Controls.Add(Me.txtKolicina)
        Me.Controls.Add(Me.CmbPredhodniMagacin)
        Me.Controls.Add(Me.txtSifraArtikla)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtBrojRacuna)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtJM)
        Me.Controls.Add(Me.lblDisp)
        Me.Controls.Add(Me.dtpDatum)
        Me.Controls.Add(Me.chkRacunUradjen)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtVozilo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtRobuIzdao)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNapomena)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkKnjizeno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBroj)
        Me.Controls.Add(Me.txtSifraPredhodnogMagacina)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOtpremnica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "OTPREMNICA"
        CType(Me.erpIndikatorGreske, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuOtpremnica.ResumeLayout(False)
        CType(Me.grdLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdListaStavki, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdStavke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents erpIndikatorGreske As ErrorProvider
    Friend WithEvents TmrIndikatorGreske As Timer
    Friend WithEvents tmrDelay As Timer
    Friend WithEvents ttForma As ToolTip
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtDestinacija As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents grdStavke As myDataGridView
    Friend WithEvents txtKolicina As TextBox
    Friend WithEvents CmbPredhodniMagacin As ComboBox
    Friend WithEvents txtSifraArtikla As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtBrojRacuna As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtJM As TextBox
    Friend WithEvents lblDisp As Label
    Friend WithEvents dtpDatum As DateTimePicker
    Friend WithEvents chkRacunUradjen As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtVozilo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtRobuIzdao As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNapomena As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkKnjizeno As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBroj As TextBox
    Friend WithEvents txtSifraPredhodnogMagacina As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtStanje As TextBox
    Friend WithEvents mnuOtpremnica As ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuBrisanje As ToolStripMenuItem
    Friend WithEvents mnuAzurirajRbr As ToolStripMenuItem
    Friend WithEvents Label11 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents ChkGratis As CheckBox
    Friend WithEvents ChkIzvoz As CheckBox
    Friend WithEvents TxtSifraMagacina As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents CmbKurirskeSluzbe As ComboBox
    Friend WithEvents CmbNacinIsporuke As ComboBox
    Friend WithEvents txtNazivKupca As TextBox
    Friend WithEvents txtSifraKupca As TextBox
    Friend WithEvents grdLista As DataGridView
    Friend WithEvents GrdListaStavki As DataGridView
    Friend WithEvents TxtNazivArtikla As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents mnuSortiranjeAZ As ToolStripMenuItem
    Friend WithEvents mnuSortiranjeZA As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CmbMagacin As ComboBox
    Friend WithEvents cmdStampa As Button
    Friend WithEvents cmdKnjizenje As Button
    Friend WithEvents CmdPrenosnica As Button
    Friend WithEvents CmdSnimi As Button
    Friend WithEvents CmdNovi As Button
End Class
