<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRadniNalog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRadniNalog))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tmrDelay = New System.Windows.Forms.Timer(Me.components)
        Me.mnuRadniNalog = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBrisanje = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAzurirajRbr = New System.Windows.Forms.ToolStripMenuItem()
        Me.TmrIndikatorGreske = New System.Windows.Forms.Timer(Me.components)
        Me.erpIndikatorGreske = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ttForma = New System.Windows.Forms.ToolTip(Me.components)
        Me.dtpDatum = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBroj = New System.Windows.Forms.TextBox()
        Me.CmbMagacinRN = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSifraMagacinaRN = New System.Windows.Forms.TextBox()
        Me.txtNazivProizvoda = New System.Windows.Forms.TextBox()
        Me.txtSifraProizvoda = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKolicinaProizvoda = New System.Windows.Forms.TextBox()
        Me.txtJedinicaMereProizvoda = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.chkKnjizeno = New System.Windows.Forms.CheckBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtBrojFinansijskogNaloga = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPredajnica = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtProizvedenaKolicina = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CmbMagacinStavkiRN = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNazivKomponenteRN = New System.Windows.Forms.TextBox()
        Me.TxtSifraKomponenteRN = New System.Windows.Forms.TextBox()
        Me.txtStanje = New System.Windows.Forms.TextBox()
        Me.txtJM = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNapomena = New System.Windows.Forms.TextBox()
        Me.grdListaGP = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ChkLansirano = New System.Windows.Forms.CheckBox()
        Me.GrdListaStavki = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblDisp = New System.Windows.Forms.Label()
        Me.lblUkupno = New System.Windows.Forms.Label()
        Me.lblJedinicnaVrednost = New System.Windows.Forms.Label()
        Me.TxtSifraMagacinaStavkiRN = New System.Windows.Forms.TextBox()
        Me.DtpDatumLansiranja = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.DtpDatumKnjizenja = New System.Windows.Forms.DateTimePicker()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.LblVrednostTrebovanja = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.MnuTrebovanje = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuOtvoriTrebovanje = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TxtNabavniIznos = New System.Windows.Forms.TextBox()
        Me.TxtNabavnaCena = New System.Windows.Forms.TextBox()
        Me.txtKolicina = New System.Windows.Forms.TextBox()
        Me.GrdTrebovanja = New SOLUTION_MG_BlackHorse.myDataGridView()
        Me.grdStavke = New SOLUTION_MG_BlackHorse.myDataGridView()
        Me.CmdSnimi = New System.Windows.Forms.Button()
        Me.CmdNovi = New System.Windows.Forms.Button()
        Me.cmdStampa = New System.Windows.Forms.Button()
        Me.cmdKnjizenje = New System.Windows.Forms.Button()
        Me.CmdLansiranje = New System.Windows.Forms.Button()
        Me.CmdPredajnica = New System.Windows.Forms.Button()
        Me.mnuRadniNalog.SuspendLayout()
        CType(Me.erpIndikatorGreske, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListaGP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdListaStavki, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MnuTrebovanje.SuspendLayout()
        CType(Me.GrdTrebovanja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdStavke, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrDelay
        '
        Me.tmrDelay.Interval = 1000
        '
        'mnuRadniNalog
        '
        Me.mnuRadniNalog.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuRadniNalog.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.mnuBrisanje, Me.mnuAzurirajRbr})
        Me.mnuRadniNalog.Name = "mnuUlaz"
        Me.mnuRadniNalog.Size = New System.Drawing.Size(194, 62)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(190, 6)
        '
        'mnuBrisanje
        '
        Me.mnuBrisanje.Image = CType(resources.GetObject("mnuBrisanje.Image"), System.Drawing.Image)
        Me.mnuBrisanje.Name = "mnuBrisanje"
        Me.mnuBrisanje.Size = New System.Drawing.Size(193, 26)
        Me.mnuBrisanje.Text = "Brisanje"
        '
        'mnuAzurirajRbr
        '
        Me.mnuAzurirajRbr.Enabled = False
        Me.mnuAzurirajRbr.Image = CType(resources.GetObject("mnuAzurirajRbr.Image"), System.Drawing.Image)
        Me.mnuAzurirajRbr.Name = "mnuAzurirajRbr"
        Me.mnuAzurirajRbr.Size = New System.Drawing.Size(193, 26)
        Me.mnuAzurirajRbr.Text = "Ažuriraj redne brojeve"
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
        'dtpDatum
        '
        Me.dtpDatum.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatum.Location = New System.Drawing.Point(87, 47)
        Me.dtpDatum.Name = "dtpDatum"
        Me.dtpDatum.Size = New System.Drawing.Size(120, 23)
        Me.dtpDatum.TabIndex = 516
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(86, 27)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 515
        Me.Label4.Text = "Datum"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(28, 27)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 514
        Me.Label2.Text = "Broj"
        '
        'txtBroj
        '
        Me.txtBroj.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtBroj.Location = New System.Drawing.Point(30, 47)
        Me.txtBroj.Name = "txtBroj"
        Me.txtBroj.ReadOnly = True
        Me.txtBroj.Size = New System.Drawing.Size(50, 23)
        Me.txtBroj.TabIndex = 513
        '
        'CmbMagacinRN
        '
        Me.CmbMagacinRN.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.CmbMagacinRN.FormattingEnabled = True
        Me.CmbMagacinRN.Location = New System.Drawing.Point(261, 46)
        Me.CmbMagacinRN.Name = "CmbMagacinRN"
        Me.CmbMagacinRN.Size = New System.Drawing.Size(251, 24)
        Me.CmbMagacinRN.TabIndex = 519
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(213, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 16)
        Me.Label1.TabIndex = 518
        Me.Label1.Text = "Magacin za koji se proizvodi"
        '
        'txtSifraMagacinaRN
        '
        Me.txtSifraMagacinaRN.Enabled = False
        Me.txtSifraMagacinaRN.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtSifraMagacinaRN.Location = New System.Drawing.Point(214, 47)
        Me.txtSifraMagacinaRN.Name = "txtSifraMagacinaRN"
        Me.txtSifraMagacinaRN.ReadOnly = True
        Me.txtSifraMagacinaRN.Size = New System.Drawing.Size(40, 23)
        Me.txtSifraMagacinaRN.TabIndex = 517
        '
        'txtNazivProizvoda
        '
        Me.txtNazivProizvoda.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtNazivProizvoda.Location = New System.Drawing.Point(591, 47)
        Me.txtNazivProizvoda.Name = "txtNazivProizvoda"
        Me.txtNazivProizvoda.Size = New System.Drawing.Size(412, 23)
        Me.txtNazivProizvoda.TabIndex = 602
        '
        'txtSifraProizvoda
        '
        Me.txtSifraProizvoda.Enabled = False
        Me.txtSifraProizvoda.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtSifraProizvoda.Location = New System.Drawing.Point(519, 47)
        Me.txtSifraProizvoda.Name = "txtSifraProizvoda"
        Me.txtSifraProizvoda.ReadOnly = True
        Me.txtSifraProizvoda.Size = New System.Drawing.Size(65, 23)
        Me.txtSifraProizvoda.TabIndex = 600
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(516, 27)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 16)
        Me.Label3.TabIndex = 601
        Me.Label3.Text = "Artikal koji se proizvodi"
        '
        'txtKolicinaProizvoda
        '
        Me.txtKolicinaProizvoda.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtKolicinaProizvoda.Location = New System.Drawing.Point(1077, 47)
        Me.txtKolicinaProizvoda.Name = "txtKolicinaProizvoda"
        Me.txtKolicinaProizvoda.Size = New System.Drawing.Size(85, 23)
        Me.txtKolicinaProizvoda.TabIndex = 603
        Me.txtKolicinaProizvoda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtJedinicaMereProizvoda
        '
        Me.txtJedinicaMereProizvoda.Enabled = False
        Me.txtJedinicaMereProizvoda.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtJedinicaMereProizvoda.Location = New System.Drawing.Point(1010, 47)
        Me.txtJedinicaMereProizvoda.Name = "txtJedinicaMereProizvoda"
        Me.txtJedinicaMereProizvoda.ReadOnly = True
        Me.txtJedinicaMereProizvoda.Size = New System.Drawing.Size(60, 23)
        Me.txtJedinicaMereProizvoda.TabIndex = 604
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(1284, 61)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(61, 16)
        Me.Label20.TabIndex = 606
        Me.Label20.Text = "Knjiženo"
        '
        'chkKnjizeno
        '
        Me.chkKnjizeno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkKnjizeno.AutoSize = True
        Me.chkKnjizeno.Enabled = False
        Me.chkKnjizeno.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkKnjizeno.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chkKnjizeno.Location = New System.Drawing.Point(1270, 64)
        Me.chkKnjizeno.Name = "chkKnjizeno"
        Me.chkKnjizeno.Size = New System.Drawing.Size(15, 14)
        Me.chkKnjizeno.TabIndex = 605
        Me.chkKnjizeno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkKnjizeno.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(883, 695)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(43, 16)
        Me.Label28.TabIndex = 614
        Me.Label28.Text = "Nalog"
        '
        'txtBrojFinansijskogNaloga
        '
        Me.txtBrojFinansijskogNaloga.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtBrojFinansijskogNaloga.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtBrojFinansijskogNaloga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBrojFinansijskogNaloga.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtBrojFinansijskogNaloga.Location = New System.Drawing.Point(887, 717)
        Me.txtBrojFinansijskogNaloga.Name = "txtBrojFinansijskogNaloga"
        Me.txtBrojFinansijskogNaloga.ReadOnly = True
        Me.txtBrojFinansijskogNaloga.Size = New System.Drawing.Size(109, 23)
        Me.txtBrojFinansijskogNaloga.TabIndex = 611
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(883, 746)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 16)
        Me.Label14.TabIndex = 610
        Me.Label14.Text = "Predajnica "
        '
        'txtPredajnica
        '
        Me.txtPredajnica.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPredajnica.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.txtPredajnica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPredajnica.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtPredajnica.Location = New System.Drawing.Point(887, 768)
        Me.txtPredajnica.Name = "txtPredajnica"
        Me.txtPredajnica.ReadOnly = True
        Me.txtPredajnica.Size = New System.Drawing.Size(113, 23)
        Me.txtPredajnica.TabIndex = 609
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(389, 550)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 19)
        Me.Label12.TabIndex = 608
        Me.Label12.Text = "Trebovanja"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(1132, 807)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 622
        Me.Label5.Text = "Ukupno"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(1101, 27)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 621
        Me.Label6.Text = "Količina"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtProizvedenaKolicina
        '
        Me.TxtProizvedenaKolicina.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtProizvedenaKolicina.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TxtProizvedenaKolicina.Location = New System.Drawing.Point(1169, 47)
        Me.TxtProizvedenaKolicina.Name = "TxtProizvedenaKolicina"
        Me.TxtProizvedenaKolicina.ReadOnly = True
        Me.TxtProizvedenaKolicina.Size = New System.Drawing.Size(85, 23)
        Me.TxtProizvedenaKolicina.TabIndex = 620
        Me.TxtProizvedenaKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(1091, 775)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 16)
        Me.Label7.TabIndex = 618
        Me.Label7.Text = "Vrednost/kom"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(1167, 27)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 16)
        Me.Label8.TabIndex = 616
        Me.Label8.Text = "Proizvedeno"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbMagacinStavkiRN
        '
        Me.CmbMagacinStavkiRN.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.CmbMagacinStavkiRN.FormattingEnabled = True
        Me.CmbMagacinStavkiRN.Location = New System.Drawing.Point(72, 167)
        Me.CmbMagacinStavkiRN.Name = "CmbMagacinStavkiRN"
        Me.CmbMagacinStavkiRN.Size = New System.Drawing.Size(230, 24)
        Me.CmbMagacinStavkiRN.TabIndex = 623
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(28, 147)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(203, 16)
        Me.Label9.TabIndex = 624
        Me.Label9.Text = "Magacin stavki radnog naloga"
        '
        'TxtNazivKomponenteRN
        '
        Me.TxtNazivKomponenteRN.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TxtNazivKomponenteRN.Location = New System.Drawing.Point(379, 167)
        Me.TxtNazivKomponenteRN.Name = "TxtNazivKomponenteRN"
        Me.TxtNazivKomponenteRN.Size = New System.Drawing.Size(405, 23)
        Me.TxtNazivKomponenteRN.TabIndex = 626
        '
        'TxtSifraKomponenteRN
        '
        Me.TxtSifraKomponenteRN.Enabled = False
        Me.TxtSifraKomponenteRN.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TxtSifraKomponenteRN.Location = New System.Drawing.Point(308, 167)
        Me.TxtSifraKomponenteRN.Name = "TxtSifraKomponenteRN"
        Me.TxtSifraKomponenteRN.ReadOnly = True
        Me.TxtSifraKomponenteRN.Size = New System.Drawing.Size(65, 23)
        Me.TxtSifraKomponenteRN.TabIndex = 625
        '
        'txtStanje
        '
        Me.txtStanje.Enabled = False
        Me.txtStanje.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtStanje.Location = New System.Drawing.Point(866, 167)
        Me.txtStanje.Name = "txtStanje"
        Me.txtStanje.ReadOnly = True
        Me.txtStanje.Size = New System.Drawing.Size(110, 23)
        Me.txtStanje.TabIndex = 629
        Me.txtStanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtJM
        '
        Me.txtJM.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtJM.Location = New System.Drawing.Point(790, 167)
        Me.txtJM.Name = "txtJM"
        Me.txtJM.Size = New System.Drawing.Size(70, 23)
        Me.txtJM.TabIndex = 628
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(28, 87)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 16)
        Me.Label10.TabIndex = 633
        Me.Label10.Text = "Napomena"
        '
        'txtNapomena
        '
        Me.txtNapomena.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtNapomena.Location = New System.Drawing.Point(30, 107)
        Me.txtNapomena.Name = "txtNapomena"
        Me.txtNapomena.Size = New System.Drawing.Size(946, 23)
        Me.txtNapomena.TabIndex = 632
        '
        'grdListaGP
        '
        Me.grdListaGP.AllowUserToAddRows = False
        Me.grdListaGP.AllowUserToDeleteRows = False
        Me.grdListaGP.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.grdListaGP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdListaGP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grdListaGP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdListaGP.DefaultCellStyle = DataGridViewCellStyle9
        Me.grdListaGP.Location = New System.Drawing.Point(506, 76)
        Me.grdListaGP.Name = "grdListaGP"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdListaGP.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.grdListaGP.RowHeadersWidth = 20
        Me.grdListaGP.Size = New System.Drawing.Size(642, 134)
        Me.grdListaGP.TabIndex = 634
        Me.grdListaGP.Visible = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(1284, 37)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 16)
        Me.Label11.TabIndex = 636
        Me.Label11.Text = "Lansirano"
        '
        'ChkLansirano
        '
        Me.ChkLansirano.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkLansirano.AutoSize = True
        Me.ChkLansirano.Enabled = False
        Me.ChkLansirano.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkLansirano.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ChkLansirano.Location = New System.Drawing.Point(1270, 40)
        Me.ChkLansirano.Name = "ChkLansirano"
        Me.ChkLansirano.Size = New System.Drawing.Size(15, 14)
        Me.ChkLansirano.TabIndex = 635
        Me.ChkLansirano.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkLansirano.UseVisualStyleBackColor = True
        '
        'GrdListaStavki
        '
        Me.GrdListaStavki.AllowUserToAddRows = False
        Me.GrdListaStavki.AllowUserToDeleteRows = False
        Me.GrdListaStavki.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.GrdListaStavki.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdListaStavki.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.GrdListaStavki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrdListaStavki.DefaultCellStyle = DataGridViewCellStyle13
        Me.GrdListaStavki.Location = New System.Drawing.Point(309, 196)
        Me.GrdListaStavki.Name = "GrdListaStavki"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdListaStavki.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.GrdListaStavki.RowHeadersWidth = 20
        Me.GrdListaStavki.Size = New System.Drawing.Size(620, 134)
        Me.GrdListaStavki.TabIndex = 637
        Me.GrdListaStavki.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(306, 147)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(238, 16)
        Me.Label13.TabIndex = 639
        Me.Label13.Text = "Artikli - komponente radnog naloga"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(1003, 27)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 16)
        Me.Label15.TabIndex = 640
        Me.Label15.Text = "Jed.mere"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(796, 146)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 16)
        Me.Label16.TabIndex = 641
        Me.Label16.Text = "Jed.mere"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(929, 146)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 16)
        Me.Label18.TabIndex = 642
        Me.Label18.Text = "Stanje"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(1150, 147)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 16)
        Me.Label19.TabIndex = 643
        Me.Label19.Text = "Količina"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(1052, 146)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 16)
        Me.Label21.TabIndex = 644
        Me.Label21.Text = "Cena"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(1290, 146)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(42, 16)
        Me.Label22.TabIndex = 645
        Me.Label22.Text = "Iznos"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDisp
        '
        Me.lblDisp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDisp.BackColor = System.Drawing.Color.Transparent
        Me.lblDisp.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.lblDisp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.lblDisp.Location = New System.Drawing.Point(1240, 718)
        Me.lblDisp.Name = "lblDisp"
        Me.lblDisp.Size = New System.Drawing.Size(111, 19)
        Me.lblDisp.TabIndex = 646
        Me.lblDisp.Text = "0.00"
        Me.lblDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDisp.Visible = False
        '
        'lblUkupno
        '
        Me.lblUkupno.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUkupno.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.lblUkupno.ForeColor = System.Drawing.Color.Black
        Me.lblUkupno.Location = New System.Drawing.Point(1220, 807)
        Me.lblUkupno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUkupno.Name = "lblUkupno"
        Me.lblUkupno.Size = New System.Drawing.Size(131, 16)
        Me.lblUkupno.TabIndex = 648
        Me.lblUkupno.Text = "0.00"
        Me.lblUkupno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblJedinicnaVrednost
        '
        Me.lblJedinicnaVrednost.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblJedinicnaVrednost.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.lblJedinicnaVrednost.ForeColor = System.Drawing.Color.Black
        Me.lblJedinicnaVrednost.Location = New System.Drawing.Point(1217, 776)
        Me.lblJedinicnaVrednost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJedinicnaVrednost.Name = "lblJedinicnaVrednost"
        Me.lblJedinicnaVrednost.Size = New System.Drawing.Size(134, 16)
        Me.lblJedinicnaVrednost.TabIndex = 647
        Me.lblJedinicnaVrednost.Text = "0.00"
        Me.lblJedinicnaVrednost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtSifraMagacinaStavkiRN
        '
        Me.TxtSifraMagacinaStavkiRN.Enabled = False
        Me.TxtSifraMagacinaStavkiRN.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TxtSifraMagacinaStavkiRN.Location = New System.Drawing.Point(30, 167)
        Me.TxtSifraMagacinaStavkiRN.Name = "TxtSifraMagacinaStavkiRN"
        Me.TxtSifraMagacinaStavkiRN.ReadOnly = True
        Me.TxtSifraMagacinaStavkiRN.Size = New System.Drawing.Size(40, 23)
        Me.TxtSifraMagacinaStavkiRN.TabIndex = 649
        '
        'DtpDatumLansiranja
        '
        Me.DtpDatumLansiranja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DtpDatumLansiranja.CalendarFont = New System.Drawing.Font("Verdana", 9.75!)
        Me.DtpDatumLansiranja.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.DtpDatumLansiranja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDatumLansiranja.Location = New System.Drawing.Point(30, 718)
        Me.DtpDatumLansiranja.Name = "DtpDatumLansiranja"
        Me.DtpDatumLansiranja.Size = New System.Drawing.Size(120, 23)
        Me.DtpDatumLansiranja.TabIndex = 652
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(26, 696)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(116, 16)
        Me.Label24.TabIndex = 651
        Me.Label24.Text = "Datum lansiranja"
        '
        'DtpDatumKnjizenja
        '
        Me.DtpDatumKnjizenja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DtpDatumKnjizenja.CalendarFont = New System.Drawing.Font("Verdana", 9.75!)
        Me.DtpDatumKnjizenja.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.DtpDatumKnjizenja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDatumKnjizenja.Location = New System.Drawing.Point(31, 769)
        Me.DtpDatumKnjizenja.Name = "DtpDatumKnjizenja"
        Me.DtpDatumKnjizenja.Size = New System.Drawing.Size(120, 23)
        Me.DtpDatumKnjizenja.TabIndex = 654
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(27, 747)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(111, 16)
        Me.Label25.TabIndex = 653
        Me.Label25.Text = "Datum knjizenja"
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(182, 696)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 16)
        Me.Label23.TabIndex = 656
        Me.Label23.Text = "Trebovanja"
        '
        'LblVrednostTrebovanja
        '
        Me.LblVrednostTrebovanja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblVrednostTrebovanja.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.LblVrednostTrebovanja.ForeColor = System.Drawing.Color.Black
        Me.LblVrednostTrebovanja.Location = New System.Drawing.Point(1214, 748)
        Me.LblVrednostTrebovanja.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblVrednostTrebovanja.Name = "LblVrednostTrebovanja"
        Me.LblVrednostTrebovanja.Size = New System.Drawing.Size(137, 16)
        Me.LblVrednostTrebovanja.TabIndex = 659
        Me.LblVrednostTrebovanja.Text = "0.00"
        Me.LblVrednostTrebovanja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(1050, 748)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(142, 16)
        Me.Label27.TabIndex = 658
        Me.Label27.Text = "Vrednost trebovanja"
        '
        'MnuTrebovanje
        '
        Me.MnuTrebovanje.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MnuTrebovanje.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.MnuOtvoriTrebovanje, Me.ToolStripSeparator3})
        Me.MnuTrebovanje.Name = "mnuUlaz"
        Me.MnuTrebovanje.Size = New System.Drawing.Size(171, 42)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(167, 6)
        '
        'MnuOtvoriTrebovanje
        '
        Me.MnuOtvoriTrebovanje.Image = CType(resources.GetObject("MnuOtvoriTrebovanje.Image"), System.Drawing.Image)
        Me.MnuOtvoriTrebovanje.Name = "MnuOtvoriTrebovanje"
        Me.MnuOtvoriTrebovanje.Size = New System.Drawing.Size(170, 26)
        Me.MnuOtvoriTrebovanje.Text = "Otvori trebovanje"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(167, 6)
        '
        'TxtNabavniIznos
        '
        Me.TxtNabavniIznos.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TxtNabavniIznos.Location = New System.Drawing.Point(1214, 167)
        Me.TxtNabavniIznos.Name = "TxtNabavniIznos"
        Me.TxtNabavniIznos.Size = New System.Drawing.Size(120, 23)
        Me.TxtNabavniIznos.TabIndex = 695
        Me.TxtNabavniIznos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNabavnaCena
        '
        Me.TxtNabavnaCena.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TxtNabavnaCena.Location = New System.Drawing.Point(982, 167)
        Me.TxtNabavnaCena.Name = "TxtNabavnaCena"
        Me.TxtNabavnaCena.Size = New System.Drawing.Size(110, 23)
        Me.TxtNabavnaCena.TabIndex = 694
        Me.TxtNabavnaCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKolicina
        '
        Me.txtKolicina.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtKolicina.Location = New System.Drawing.Point(1098, 167)
        Me.txtKolicina.Name = "txtKolicina"
        Me.txtKolicina.Size = New System.Drawing.Size(110, 23)
        Me.txtKolicina.TabIndex = 693
        Me.txtKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GrdTrebovanja
        '
        Me.GrdTrebovanja.AllowUserToAddRows = False
        Me.GrdTrebovanja.AllowUserToDeleteRows = False
        Me.GrdTrebovanja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrdTrebovanja.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.GrdTrebovanja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GrdTrebovanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrdTrebovanja.DefaultCellStyle = DataGridViewCellStyle11
        Me.GrdTrebovanja.Location = New System.Drawing.Point(185, 718)
        Me.GrdTrebovanja.Name = "GrdTrebovanja"
        Me.GrdTrebovanja.PoslednjaKolona = CType(5, Short)
        Me.GrdTrebovanja.PrvaKolona = CType(5, Short)
        Me.GrdTrebovanja.RowHeadersWidth = 20
        Me.GrdTrebovanja.Size = New System.Drawing.Size(675, 108)
        Me.GrdTrebovanja.TabIndex = 657
        Me.GrdTrebovanja.VertikalniSBUvekVidljiv = True
        '
        'grdStavke
        '
        Me.grdStavke.AllowUserToAddRows = False
        Me.grdStavke.AllowUserToDeleteRows = False
        Me.grdStavke.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdStavke.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.grdStavke.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdStavke.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdStavke.Location = New System.Drawing.Point(26, 204)
        Me.grdStavke.Name = "grdStavke"
        Me.grdStavke.PoslednjaKolona = CType(10, Short)
        Me.grdStavke.PrvaKolona = CType(8, Short)
        Me.grdStavke.RowHeadersWidth = 20
        Me.grdStavke.Size = New System.Drawing.Size(1325, 472)
        Me.grdStavke.TabIndex = 638
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
        Me.CmdSnimi.Location = New System.Drawing.Point(1247, 848)
        Me.CmdSnimi.Name = "CmdSnimi"
        Me.CmdSnimi.Size = New System.Drawing.Size(105, 40)
        Me.CmdSnimi.TabIndex = 673
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
        Me.CmdNovi.Location = New System.Drawing.Point(1119, 848)
        Me.CmdNovi.Name = "CmdNovi"
        Me.CmdNovi.Size = New System.Drawing.Size(100, 40)
        Me.CmdNovi.TabIndex = 672
        Me.CmdNovi.Text = "Novi"
        Me.CmdNovi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdNovi.UseVisualStyleBackColor = False
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
        Me.cmdStampa.Location = New System.Drawing.Point(486, 848)
        Me.cmdStampa.Name = "cmdStampa"
        Me.cmdStampa.Size = New System.Drawing.Size(130, 40)
        Me.cmdStampa.TabIndex = 698
        Me.cmdStampa.Text = "Štampa"
        Me.cmdStampa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdStampa.UseVisualStyleBackColor = False
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
        Me.cmdKnjizenje.Location = New System.Drawing.Point(177, 848)
        Me.cmdKnjizenje.Name = "cmdKnjizenje"
        Me.cmdKnjizenje.Size = New System.Drawing.Size(130, 40)
        Me.cmdKnjizenje.TabIndex = 697
        Me.cmdKnjizenje.Text = "Knjiženje"
        Me.cmdKnjizenje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdKnjizenje.UseVisualStyleBackColor = False
        '
        'CmdLansiranje
        '
        Me.CmdLansiranje.BackColor = System.Drawing.Color.Transparent
        Me.CmdLansiranje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdLansiranje.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdLansiranje.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.CmdLansiranje.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CmdLansiranje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdLansiranje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdLansiranje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdLansiranje.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdLansiranje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.CmdLansiranje.Image = CType(resources.GetObject("CmdLansiranje.Image"), System.Drawing.Image)
        Me.CmdLansiranje.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.CmdLansiranje.Location = New System.Drawing.Point(21, 848)
        Me.CmdLansiranje.Name = "CmdLansiranje"
        Me.CmdLansiranje.Size = New System.Drawing.Size(130, 40)
        Me.CmdLansiranje.TabIndex = 696
        Me.CmdLansiranje.Text = "Lansiranje"
        Me.CmdLansiranje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdLansiranje.UseVisualStyleBackColor = False
        '
        'CmdPredajnica
        '
        Me.CmdPredajnica.BackColor = System.Drawing.Color.Transparent
        Me.CmdPredajnica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdPredajnica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdPredajnica.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.CmdPredajnica.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CmdPredajnica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdPredajnica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdPredajnica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdPredajnica.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPredajnica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.CmdPredajnica.Image = CType(resources.GetObject("CmdPredajnica.Image"), System.Drawing.Image)
        Me.CmdPredajnica.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.CmdPredajnica.Location = New System.Drawing.Point(330, 848)
        Me.CmdPredajnica.Name = "CmdPredajnica"
        Me.CmdPredajnica.Size = New System.Drawing.Size(130, 40)
        Me.CmdPredajnica.TabIndex = 699
        Me.CmdPredajnica.Text = "Predajnica"
        Me.CmdPredajnica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdPredajnica.UseVisualStyleBackColor = False
        '
        'FrmRadniNalog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1380, 900)
        Me.Controls.Add(Me.CmdPredajnica)
        Me.Controls.Add(Me.cmdStampa)
        Me.Controls.Add(Me.cmdKnjizenje)
        Me.Controls.Add(Me.CmdLansiranje)
        Me.Controls.Add(Me.CmdSnimi)
        Me.Controls.Add(Me.CmdNovi)
        Me.Controls.Add(Me.grdListaGP)
        Me.Controls.Add(Me.TxtNabavniIznos)
        Me.Controls.Add(Me.TxtNabavnaCena)
        Me.Controls.Add(Me.txtKolicina)
        Me.Controls.Add(Me.LblVrednostTrebovanja)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.GrdTrebovanja)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.DtpDatumKnjizenja)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.DtpDatumLansiranja)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.TxtSifraMagacinaStavkiRN)
        Me.Controls.Add(Me.lblUkupno)
        Me.Controls.Add(Me.lblJedinicnaVrednost)
        Me.Controls.Add(Me.lblDisp)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GrdListaStavki)
        Me.Controls.Add(Me.grdStavke)
        Me.Controls.Add(Me.txtStanje)
        Me.Controls.Add(Me.txtJM)
        Me.Controls.Add(Me.TxtNazivKomponenteRN)
        Me.Controls.Add(Me.TxtSifraKomponenteRN)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ChkLansirano)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtNapomena)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CmbMagacinStavkiRN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtProizvedenaKolicina)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtBrojFinansijskogNaloga)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtPredajnica)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.chkKnjizeno)
        Me.Controls.Add(Me.txtKolicinaProizvoda)
        Me.Controls.Add(Me.txtJedinicaMereProizvoda)
        Me.Controls.Add(Me.txtNazivProizvoda)
        Me.Controls.Add(Me.txtSifraProizvoda)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbMagacinRN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSifraMagacinaRN)
        Me.Controls.Add(Me.dtpDatum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBroj)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRadniNalog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RADNI NALOG"
        Me.mnuRadniNalog.ResumeLayout(False)
        CType(Me.erpIndikatorGreske, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListaGP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdListaStavki, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MnuTrebovanje.ResumeLayout(False)
        CType(Me.GrdTrebovanja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdStavke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ttForma As ToolTip
    Friend WithEvents tmrDelay As Timer
    Friend WithEvents mnuRadniNalog As ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuBrisanje As ToolStripMenuItem
    Friend WithEvents mnuAzurirajRbr As ToolStripMenuItem
    Friend WithEvents TmrIndikatorGreske As Timer
    Friend WithEvents erpIndikatorGreske As ErrorProvider
    Friend WithEvents dtpDatum As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBroj As TextBox
    Friend WithEvents CmbMagacinRN As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSifraMagacinaRN As TextBox
    Friend WithEvents txtNazivProizvoda As TextBox
    Friend WithEvents txtSifraProizvoda As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKolicinaProizvoda As TextBox
    Friend WithEvents txtJedinicaMereProizvoda As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents chkKnjizeno As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtProizvedenaKolicina As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents txtBrojFinansijskogNaloga As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPredajnica As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CmbMagacinStavkiRN As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtNazivKomponenteRN As TextBox
    Friend WithEvents TxtSifraKomponenteRN As TextBox
    Friend WithEvents txtStanje As TextBox
    Friend WithEvents txtJM As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNapomena As TextBox
    Friend WithEvents GrdListaStavki As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents ChkLansirano As CheckBox
    Friend WithEvents grdListaGP As DataGridView
    Friend WithEvents grdStavke As myDataGridView
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblDisp As Label
    Friend WithEvents lblUkupno As Label
    Friend WithEvents lblJedinicnaVrednost As Label
    Friend WithEvents TxtSifraMagacinaStavkiRN As TextBox
    Friend WithEvents DtpDatumKnjizenja As DateTimePicker
    Friend WithEvents Label25 As Label
    Friend WithEvents DtpDatumLansiranja As DateTimePicker
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents GrdTrebovanja As myDataGridView
    Friend WithEvents LblVrednostTrebovanja As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents MnuTrebovanje As ContextMenuStrip
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents MnuOtvoriTrebovanje As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents TxtNabavniIznos As TextBox
    Friend WithEvents TxtNabavnaCena As TextBox
    Friend WithEvents txtKolicina As TextBox
    Friend WithEvents CmdSnimi As Button
    Friend WithEvents CmdNovi As Button
    Friend WithEvents CmdPredajnica As Button
    Friend WithEvents cmdStampa As Button
    Friend WithEvents cmdKnjizenje As Button
    Friend WithEvents CmdLansiranje As Button
End Class
