<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPopis
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPopis))
        Me.tmrDelay = New System.Windows.Forms.Timer(Me.components)
        Me.txtSifraMagacina = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNapomena = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBroj = New System.Windows.Forms.TextBox()
        Me.chkPrenosStanja = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.chkKnjizeno = New System.Windows.Forms.CheckBox()
        Me.lblDisp = New System.Windows.Forms.Label()
        Me.CmbMagacin = New System.Windows.Forms.ComboBox()
        Me.ChkPojedinacniUnos = New System.Windows.Forms.CheckBox()
        Me.ttForma = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkNaStanju = New System.Windows.Forms.CheckBox()
        Me.dtpDatum = New System.Windows.Forms.DateTimePicker()
        Me.TxtNazivArtikla = New System.Windows.Forms.TextBox()
        Me.txtSifraArtikla = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtNabavnaCena = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtNovoStanje = New System.Windows.Forms.TextBox()
        Me.txtStaroStanje = New System.Windows.Forms.TextBox()
        Me.txtJM = New System.Windows.Forms.TextBox()
        Me.GrdListaStavki = New System.Windows.Forms.DataGridView()
        Me.mnuPopis = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBrisanje = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSortiranjeAZ = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSortiranjeZA = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuAzurirajRbr = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtGrupaSifre = New System.Windows.Forms.TextBox()
        Me.grdStavke = New SOLUTION_MG_BlackHorse.myDataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChkPocetnoStanje = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ChkZavrsniPopis = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtProdajnaCena = New System.Windows.Forms.TextBox()
        Me.TxtProdajniIznos = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNabavniIznos = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CmdStampa = New System.Windows.Forms.Button()
        Me.CmdKnjizenje = New System.Windows.Forms.Button()
        Me.CmdSnimi = New System.Windows.Forms.Button()
        Me.CmdNovi = New System.Windows.Forms.Button()
        Me.cmdPopisnaLista = New System.Windows.Forms.Button()
        Me.CmdZavrsniPopis = New System.Windows.Forms.Button()
        Me.CmdPocetnoStanje = New System.Windows.Forms.Button()
        CType(Me.GrdListaStavki, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuPopis.SuspendLayout()
        CType(Me.grdStavke, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrDelay
        '
        Me.tmrDelay.Interval = 1000
        '
        'txtSifraMagacina
        '
        Me.txtSifraMagacina.Enabled = False
        Me.txtSifraMagacina.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSifraMagacina.Location = New System.Drawing.Point(230, 49)
        Me.txtSifraMagacina.Name = "txtSifraMagacina"
        Me.txtSifraMagacina.Size = New System.Drawing.Size(65, 26)
        Me.txtSifraMagacina.TabIndex = 322
        Me.txtSifraMagacina.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(30, 92)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 16)
        Me.Label12.TabIndex = 321
        Me.Label12.Text = "Napomena"
        '
        'txtNapomena
        '
        Me.txtNapomena.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtNapomena.Location = New System.Drawing.Point(30, 112)
        Me.txtNapomena.Name = "txtNapomena"
        Me.txtNapomena.ReadOnly = True
        Me.txtNapomena.Size = New System.Drawing.Size(1203, 23)
        Me.txtNapomena.TabIndex = 320
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(100, 32)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 310
        Me.Label4.Text = "Datum"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(30, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 308
        Me.Label2.Text = "Broj"
        '
        'txtBroj
        '
        Me.txtBroj.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtBroj.Location = New System.Drawing.Point(30, 52)
        Me.txtBroj.Name = "txtBroj"
        Me.txtBroj.Size = New System.Drawing.Size(65, 23)
        Me.txtBroj.TabIndex = 307
        '
        'chkPrenosStanja
        '
        Me.chkPrenosStanja.AutoSize = True
        Me.chkPrenosStanja.BackColor = System.Drawing.Color.Transparent
        Me.chkPrenosStanja.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.chkPrenosStanja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.chkPrenosStanja.Location = New System.Drawing.Point(1001, 58)
        Me.chkPrenosStanja.Name = "chkPrenosStanja"
        Me.chkPrenosStanja.Size = New System.Drawing.Size(116, 20)
        Me.chkPrenosStanja.TabIndex = 325
        Me.chkPrenosStanja.Text = "Prenos stanja"
        Me.chkPrenosStanja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttForma.SetToolTip(Me.chkPrenosStanja, "Popisano-novo stanje isto kao predhodno-staro stanje")
        Me.chkPrenosStanja.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(1018, 34)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 16)
        Me.Label18.TabIndex = 328
        Me.Label18.Text = "Knjiženo"
        '
        'chkKnjizeno
        '
        Me.chkKnjizeno.AutoSize = True
        Me.chkKnjizeno.BackColor = System.Drawing.Color.Transparent
        Me.chkKnjizeno.Enabled = False
        Me.chkKnjizeno.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkKnjizeno.ForeColor = System.Drawing.Color.SkyBlue
        Me.chkKnjizeno.Location = New System.Drawing.Point(1001, 36)
        Me.chkKnjizeno.Name = "chkKnjizeno"
        Me.chkKnjizeno.Size = New System.Drawing.Size(15, 14)
        Me.chkKnjizeno.TabIndex = 327
        Me.chkKnjizeno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkKnjizeno.UseVisualStyleBackColor = False
        '
        'lblDisp
        '
        Me.lblDisp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDisp.BackColor = System.Drawing.Color.Transparent
        Me.lblDisp.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.lblDisp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.lblDisp.Location = New System.Drawing.Point(701, 606)
        Me.lblDisp.Name = "lblDisp"
        Me.lblDisp.Size = New System.Drawing.Size(205, 19)
        Me.lblDisp.TabIndex = 331
        Me.lblDisp.Text = "0.00"
        Me.lblDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDisp.Visible = False
        '
        'CmbMagacin
        '
        Me.CmbMagacin.Enabled = False
        Me.CmbMagacin.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMagacin.FormattingEnabled = True
        Me.CmbMagacin.Location = New System.Drawing.Point(302, 49)
        Me.CmbMagacin.Name = "CmbMagacin"
        Me.CmbMagacin.Size = New System.Drawing.Size(288, 26)
        Me.CmbMagacin.TabIndex = 333
        Me.CmbMagacin.Visible = False
        '
        'ChkPojedinacniUnos
        '
        Me.ChkPojedinacniUnos.AutoSize = True
        Me.ChkPojedinacniUnos.BackColor = System.Drawing.Color.Transparent
        Me.ChkPojedinacniUnos.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.ChkPojedinacniUnos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ChkPojedinacniUnos.Location = New System.Drawing.Point(845, 32)
        Me.ChkPojedinacniUnos.Name = "ChkPojedinacniUnos"
        Me.ChkPojedinacniUnos.Size = New System.Drawing.Size(136, 20)
        Me.ChkPojedinacniUnos.TabIndex = 334
        Me.ChkPojedinacniUnos.Text = "Pojedinačni unos"
        Me.ChkPojedinacniUnos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttForma.SetToolTip(Me.ChkPojedinacniUnos, "Pojedinačan unos popisanih artikala")
        Me.ChkPojedinacniUnos.UseVisualStyleBackColor = False
        '
        'ttForma
        '
        Me.ttForma.IsBalloon = True
        '
        'chkNaStanju
        '
        Me.chkNaStanju.AutoSize = True
        Me.chkNaStanju.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.chkNaStanju.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.chkNaStanju.Location = New System.Drawing.Point(845, 59)
        Me.chkNaStanju.Name = "chkNaStanju"
        Me.chkNaStanju.Size = New System.Drawing.Size(123, 20)
        Me.chkNaStanju.TabIndex = 692
        Me.chkNaStanju.Text = "Na stanju (>0)"
        Me.chkNaStanju.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttForma.SetToolTip(Me.chkNaStanju, "Samo artikli koji su na stanju")
        Me.chkNaStanju.UseVisualStyleBackColor = True
        '
        'dtpDatum
        '
        Me.dtpDatum.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatum.Location = New System.Drawing.Point(100, 52)
        Me.dtpDatum.Name = "dtpDatum"
        Me.dtpDatum.Size = New System.Drawing.Size(120, 23)
        Me.dtpDatum.TabIndex = 532
        '
        'TxtNazivArtikla
        '
        Me.TxtNazivArtikla.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TxtNazivArtikla.Location = New System.Drawing.Point(127, 182)
        Me.TxtNazivArtikla.Name = "TxtNazivArtikla"
        Me.TxtNazivArtikla.Size = New System.Drawing.Size(420, 23)
        Me.TxtNazivArtikla.TabIndex = 685
        '
        'txtSifraArtikla
        '
        Me.txtSifraArtikla.Enabled = False
        Me.txtSifraArtikla.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtSifraArtikla.Location = New System.Drawing.Point(55, 182)
        Me.txtSifraArtikla.Name = "txtSifraArtikla"
        Me.txtSifraArtikla.Size = New System.Drawing.Size(66, 23)
        Me.txtSifraArtikla.TabIndex = 684
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(913, 158)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 16)
        Me.Label8.TabIndex = 161
        Me.Label8.Text = "Novo stanje"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(556, 158)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 16)
        Me.Label5.TabIndex = 164
        Me.Label5.Text = "J.M."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(130, 158)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 16)
        Me.Label6.TabIndex = 165
        Me.Label6.Text = "Naziv artikla"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(58, 158)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 16)
        Me.Label7.TabIndex = 169
        Me.Label7.Text = "Šifra"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(615, 158)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 16)
        Me.Label21.TabIndex = 164
        Me.Label21.Text = "Nab. cena"
        '
        'TxtNabavnaCena
        '
        Me.TxtNabavnaCena.Enabled = False
        Me.TxtNabavnaCena.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TxtNabavnaCena.Location = New System.Drawing.Point(604, 182)
        Me.TxtNabavnaCena.Name = "TxtNabavnaCena"
        Me.TxtNabavnaCena.Size = New System.Drawing.Size(100, 23)
        Me.TxtNabavnaCena.TabIndex = 675
        Me.TxtNabavnaCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(817, 158)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(89, 16)
        Me.Label20.TabIndex = 164
        Me.Label20.Text = "Staro stanje"
        '
        'txtNovoStanje
        '
        Me.txtNovoStanje.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtNovoStanje.Location = New System.Drawing.Point(912, 182)
        Me.txtNovoStanje.Name = "txtNovoStanje"
        Me.txtNovoStanje.Size = New System.Drawing.Size(90, 23)
        Me.txtNovoStanje.TabIndex = 672
        Me.txtNovoStanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtStaroStanje
        '
        Me.txtStaroStanje.Enabled = False
        Me.txtStaroStanje.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtStaroStanje.Location = New System.Drawing.Point(816, 182)
        Me.txtStaroStanje.Name = "txtStaroStanje"
        Me.txtStaroStanje.Size = New System.Drawing.Size(90, 23)
        Me.txtStaroStanje.TabIndex = 674
        Me.txtStaroStanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtJM
        '
        Me.txtJM.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtJM.Location = New System.Drawing.Point(553, 182)
        Me.txtJM.Name = "txtJM"
        Me.txtJM.Size = New System.Drawing.Size(45, 23)
        Me.txtJM.TabIndex = 673
        '
        'GrdListaStavki
        '
        Me.GrdListaStavki.AllowUserToAddRows = False
        Me.GrdListaStavki.AllowUserToDeleteRows = False
        Me.GrdListaStavki.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.GrdListaStavki.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdListaStavki.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GrdListaStavki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrdListaStavki.DefaultCellStyle = DataGridViewCellStyle2
        Me.GrdListaStavki.Location = New System.Drawing.Point(52, 211)
        Me.GrdListaStavki.Name = "GrdListaStavki"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdListaStavki.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.GrdListaStavki.RowHeadersWidth = 20
        Me.GrdListaStavki.Size = New System.Drawing.Size(654, 134)
        Me.GrdListaStavki.TabIndex = 689
        Me.GrdListaStavki.Visible = False
        '
        'mnuPopis
        '
        Me.mnuPopis.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.mnuBrisanje, Me.ToolStripSeparator2, Me.mnuSortiranjeAZ, Me.mnuSortiranjeZA, Me.ToolStripSeparator3, Me.mnuAzurirajRbr})
        Me.mnuPopis.Name = "mnuOtp"
        Me.mnuPopis.Size = New System.Drawing.Size(190, 110)
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
        Me.mnuAzurirajRbr.Enabled = False
        Me.mnuAzurirajRbr.Image = CType(resources.GetObject("mnuAzurirajRbr.Image"), System.Drawing.Image)
        Me.mnuAzurirajRbr.Name = "mnuAzurirajRbr"
        Me.mnuAzurirajRbr.Size = New System.Drawing.Size(189, 22)
        Me.mnuAzurirajRbr.Text = "Ažuriraj redne brojeve"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(642, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 16)
        Me.Label1.TabIndex = 691
        Me.Label1.Text = "Početni broj šifre"
        '
        'TxtGrupaSifre
        '
        Me.TxtGrupaSifre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtGrupaSifre.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TxtGrupaSifre.Location = New System.Drawing.Point(646, 52)
        Me.TxtGrupaSifre.Name = "TxtGrupaSifre"
        Me.TxtGrupaSifre.Size = New System.Drawing.Size(144, 23)
        Me.TxtGrupaSifre.TabIndex = 690
        '
        'grdStavke
        '
        Me.grdStavke.AllowUserToAddRows = False
        Me.grdStavke.AllowUserToDeleteRows = False
        Me.grdStavke.AllowUserToResizeRows = False
        Me.grdStavke.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdStavke.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.grdStavke.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdStavke.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdStavke.Location = New System.Drawing.Point(30, 211)
        Me.grdStavke.Name = "grdStavke"
        Me.grdStavke.PoslednjaKolona = CType(7, Short)
        Me.grdStavke.PrvaKolona = CType(4, Short)
        Me.grdStavke.RowHeadersWidth = 20
        Me.grdStavke.Size = New System.Drawing.Size(1250, 378)
        Me.grdStavke.TabIndex = 687
        Me.grdStavke.VertikalniSBUvekVidljiv = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(1141, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 16)
        Me.Label3.TabIndex = 694
        Me.Label3.Text = "Početno stanje"
        '
        'ChkPocetnoStanje
        '
        Me.ChkPocetnoStanje.AutoSize = True
        Me.ChkPocetnoStanje.BackColor = System.Drawing.Color.Transparent
        Me.ChkPocetnoStanje.Enabled = False
        Me.ChkPocetnoStanje.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPocetnoStanje.ForeColor = System.Drawing.Color.SkyBlue
        Me.ChkPocetnoStanje.Location = New System.Drawing.Point(1124, 36)
        Me.ChkPocetnoStanje.Name = "ChkPocetnoStanje"
        Me.ChkPocetnoStanje.Size = New System.Drawing.Size(15, 14)
        Me.ChkPocetnoStanje.TabIndex = 693
        Me.ChkPocetnoStanje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkPocetnoStanje.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(1141, 60)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 16)
        Me.Label10.TabIndex = 696
        Me.Label10.Text = "Završni popis"
        '
        'ChkZavrsniPopis
        '
        Me.ChkZavrsniPopis.AutoSize = True
        Me.ChkZavrsniPopis.BackColor = System.Drawing.Color.Transparent
        Me.ChkZavrsniPopis.Enabled = False
        Me.ChkZavrsniPopis.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkZavrsniPopis.ForeColor = System.Drawing.Color.SkyBlue
        Me.ChkZavrsniPopis.Location = New System.Drawing.Point(1124, 62)
        Me.ChkZavrsniPopis.Name = "ChkZavrsniPopis"
        Me.ChkZavrsniPopis.Size = New System.Drawing.Size(15, 14)
        Me.ChkZavrsniPopis.TabIndex = 695
        Me.ChkZavrsniPopis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkZavrsniPopis.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(722, 158)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 16)
        Me.Label11.TabIndex = 161
        Me.Label11.Text = "Prod. cena"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtProdajnaCena
        '
        Me.TxtProdajnaCena.Enabled = False
        Me.TxtProdajnaCena.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TxtProdajnaCena.Location = New System.Drawing.Point(710, 182)
        Me.TxtProdajnaCena.Name = "TxtProdajnaCena"
        Me.TxtProdajnaCena.Size = New System.Drawing.Size(100, 23)
        Me.TxtProdajnaCena.TabIndex = 697
        Me.TxtProdajnaCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtProdajniIznos
        '
        Me.TxtProdajniIznos.Enabled = False
        Me.TxtProdajniIznos.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TxtProdajniIznos.Location = New System.Drawing.Point(1124, 182)
        Me.TxtProdajniIznos.Name = "TxtProdajniIznos"
        Me.TxtProdajniIznos.Size = New System.Drawing.Size(110, 23)
        Me.TxtProdajniIznos.TabIndex = 702
        Me.TxtProdajniIznos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(1125, 158)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 16)
        Me.Label9.TabIndex = 161
        Me.Label9.Text = "Prodajni Iznos"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtNabavniIznos
        '
        Me.TxtNabavniIznos.Enabled = False
        Me.TxtNabavniIznos.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TxtNabavniIznos.Location = New System.Drawing.Point(1008, 182)
        Me.TxtNabavniIznos.Name = "TxtNabavniIznos"
        Me.TxtNabavniIznos.Size = New System.Drawing.Size(110, 23)
        Me.TxtNabavniIznos.TabIndex = 700
        Me.TxtNabavniIznos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(1015, 158)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 16)
        Me.Label13.TabIndex = 161
        Me.Label13.Text = "Nabavni Iznos"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmdStampa
        '
        Me.CmdStampa.BackColor = System.Drawing.Color.Transparent
        Me.CmdStampa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdStampa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdStampa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.CmdStampa.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CmdStampa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdStampa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdStampa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdStampa.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdStampa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.CmdStampa.Image = CType(resources.GetObject("CmdStampa.Image"), System.Drawing.Image)
        Me.CmdStampa.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.CmdStampa.Location = New System.Drawing.Point(208, 638)
        Me.CmdStampa.Name = "CmdStampa"
        Me.CmdStampa.Size = New System.Drawing.Size(130, 40)
        Me.CmdStampa.TabIndex = 708
        Me.CmdStampa.Text = "Štampa"
        Me.CmdStampa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdStampa.UseVisualStyleBackColor = False
        '
        'CmdKnjizenje
        '
        Me.CmdKnjizenje.BackColor = System.Drawing.Color.Transparent
        Me.CmdKnjizenje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdKnjizenje.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdKnjizenje.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.CmdKnjizenje.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CmdKnjizenje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdKnjizenje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdKnjizenje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdKnjizenje.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdKnjizenje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.CmdKnjizenje.Image = CType(resources.GetObject("CmdKnjizenje.Image"), System.Drawing.Image)
        Me.CmdKnjizenje.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.CmdKnjizenje.Location = New System.Drawing.Point(52, 638)
        Me.CmdKnjizenje.Name = "CmdKnjizenje"
        Me.CmdKnjizenje.Size = New System.Drawing.Size(130, 40)
        Me.CmdKnjizenje.TabIndex = 707
        Me.CmdKnjizenje.Text = "Knjiženje"
        Me.CmdKnjizenje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdKnjizenje.UseVisualStyleBackColor = False
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
        Me.CmdSnimi.Location = New System.Drawing.Point(1130, 638)
        Me.CmdSnimi.Name = "CmdSnimi"
        Me.CmdSnimi.Size = New System.Drawing.Size(105, 40)
        Me.CmdSnimi.TabIndex = 705
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
        Me.CmdNovi.Location = New System.Drawing.Point(1002, 638)
        Me.CmdNovi.Name = "CmdNovi"
        Me.CmdNovi.Size = New System.Drawing.Size(100, 40)
        Me.CmdNovi.TabIndex = 704
        Me.CmdNovi.Text = "Novi"
        Me.CmdNovi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdNovi.UseVisualStyleBackColor = False
        '
        'cmdPopisnaLista
        '
        Me.cmdPopisnaLista.BackColor = System.Drawing.Color.Transparent
        Me.cmdPopisnaLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdPopisnaLista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPopisnaLista.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.cmdPopisnaLista.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.cmdPopisnaLista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.cmdPopisnaLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.cmdPopisnaLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPopisnaLista.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPopisnaLista.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.cmdPopisnaLista.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.cmdPopisnaLista.Location = New System.Drawing.Point(758, 648)
        Me.cmdPopisnaLista.Name = "cmdPopisnaLista"
        Me.cmdPopisnaLista.Size = New System.Drawing.Size(130, 30)
        Me.cmdPopisnaLista.TabIndex = 711
        Me.cmdPopisnaLista.Text = "Popis. lista"
        Me.cmdPopisnaLista.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPopisnaLista.UseVisualStyleBackColor = False
        '
        'CmdZavrsniPopis
        '
        Me.CmdZavrsniPopis.BackColor = System.Drawing.Color.Transparent
        Me.CmdZavrsniPopis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdZavrsniPopis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdZavrsniPopis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.CmdZavrsniPopis.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CmdZavrsniPopis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdZavrsniPopis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdZavrsniPopis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdZavrsniPopis.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdZavrsniPopis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.CmdZavrsniPopis.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.CmdZavrsniPopis.Location = New System.Drawing.Point(618, 648)
        Me.CmdZavrsniPopis.Name = "CmdZavrsniPopis"
        Me.CmdZavrsniPopis.Size = New System.Drawing.Size(130, 30)
        Me.CmdZavrsniPopis.TabIndex = 710
        Me.CmdZavrsniPopis.Text = "Završ. pop."
        Me.CmdZavrsniPopis.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdZavrsniPopis.UseVisualStyleBackColor = False
        '
        'CmdPocetnoStanje
        '
        Me.CmdPocetnoStanje.BackColor = System.Drawing.Color.Transparent
        Me.CmdPocetnoStanje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdPocetnoStanje.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdPocetnoStanje.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.CmdPocetnoStanje.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CmdPocetnoStanje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.CmdPocetnoStanje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.CmdPocetnoStanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdPocetnoStanje.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPocetnoStanje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.CmdPocetnoStanje.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.CmdPocetnoStanje.Location = New System.Drawing.Point(477, 648)
        Me.CmdPocetnoStanje.Name = "CmdPocetnoStanje"
        Me.CmdPocetnoStanje.Size = New System.Drawing.Size(130, 30)
        Me.CmdPocetnoStanje.TabIndex = 709
        Me.CmdPocetnoStanje.Text = "Poč. stanje"
        Me.CmdPocetnoStanje.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdPocetnoStanje.UseVisualStyleBackColor = False
        '
        'frmPopis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1300, 715)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdPopisnaLista)
        Me.Controls.Add(Me.CmdZavrsniPopis)
        Me.Controls.Add(Me.CmdPocetnoStanje)
        Me.Controls.Add(Me.CmdStampa)
        Me.Controls.Add(Me.CmdKnjizenje)
        Me.Controls.Add(Me.CmdSnimi)
        Me.Controls.Add(Me.CmdNovi)
        Me.Controls.Add(Me.TxtProdajniIznos)
        Me.Controls.Add(Me.txtSifraMagacina)
        Me.Controls.Add(Me.CmbMagacin)
        Me.Controls.Add(Me.TxtNabavniIznos)
        Me.Controls.Add(Me.TxtProdajnaCena)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ChkZavrsniPopis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ChkPocetnoStanje)
        Me.Controls.Add(Me.chkNaStanju)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtGrupaSifre)
        Me.Controls.Add(Me.GrdListaStavki)
        Me.Controls.Add(Me.grdStavke)
        Me.Controls.Add(Me.TxtNazivArtikla)
        Me.Controls.Add(Me.txtSifraArtikla)
        Me.Controls.Add(Me.TxtNabavnaCena)
        Me.Controls.Add(Me.txtNovoStanje)
        Me.Controls.Add(Me.txtStaroStanje)
        Me.Controls.Add(Me.txtJM)
        Me.Controls.Add(Me.dtpDatum)
        Me.Controls.Add(Me.ChkPojedinacniUnos)
        Me.Controls.Add(Me.lblDisp)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.chkKnjizeno)
        Me.Controls.Add(Me.chkPrenosStanja)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNapomena)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBroj)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPopis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Popis"
        CType(Me.GrdListaStavki, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuPopis.ResumeLayout(False)
        CType(Me.grdStavke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrDelay As System.Windows.Forms.Timer
    Friend WithEvents txtSifraMagacina As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNapomena As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBroj As System.Windows.Forms.TextBox
    Friend WithEvents chkPrenosStanja As System.Windows.Forms.CheckBox
    Friend WithEvents Label18 As Label
    Friend WithEvents chkKnjizeno As CheckBox
    Friend WithEvents lblDisp As Label
    Friend WithEvents CmbMagacin As ComboBox
    Friend WithEvents ChkPojedinacniUnos As CheckBox
    Friend WithEvents ttForma As ToolTip
    Friend WithEvents dtpDatum As DateTimePicker
    Friend WithEvents TxtNazivArtikla As TextBox
    Friend WithEvents txtSifraArtikla As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TxtNabavnaCena As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtNovoStanje As TextBox
    Friend WithEvents txtStaroStanje As TextBox
    Friend WithEvents txtJM As TextBox
    Friend WithEvents grdStavke As myDataGridView
    Friend WithEvents GrdListaStavki As DataGridView
    Friend WithEvents mnuPopis As ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuBrisanje As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents mnuSortiranjeAZ As ToolStripMenuItem
    Friend WithEvents mnuSortiranjeZA As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents mnuAzurirajRbr As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtGrupaSifre As TextBox
    Friend WithEvents chkNaStanju As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ChkPocetnoStanje As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ChkZavrsniPopis As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtProdajnaCena As TextBox
    Friend WithEvents TxtProdajniIznos As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtNabavniIznos As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents CmdStampa As Button
    Friend WithEvents CmdKnjizenje As Button
    Friend WithEvents CmdSnimi As Button
    Friend WithEvents CmdNovi As Button
    Friend WithEvents cmdPopisnaLista As Button
    Friend WithEvents CmdZavrsniPopis As Button
    Friend WithEvents CmdPocetnoStanje As Button
End Class
