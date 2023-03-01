<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRashod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRashod))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mnuForme = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBrisanje = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSortiranjeAZ = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSortiranjeZA = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuAzurirajRbr = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrDelay = New System.Windows.Forms.Timer(Me.components)
        Me.CmbMagacin = New System.Windows.Forms.ComboBox()
        Me.txtSifraMagacina = New System.Windows.Forms.TextBox()
        Me.dtpDatum = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDisp = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNapomena = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBroj = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.chkKnjizeno = New System.Windows.Forms.CheckBox()
        Me.ttForma = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtBrojFinansijskogNaloga = New System.Windows.Forms.TextBox()
        Me.GrdListaStavki = New System.Windows.Forms.DataGridView()
        Me.TxtProdajniIznos = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtProdajnaCena = New System.Windows.Forms.TextBox()
        Me.TxtNabavniIznos = New System.Windows.Forms.TextBox()
        Me.TxtNazivArtikla = New System.Windows.Forms.TextBox()
        Me.txtSifraArtikla = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtNabavnaCena = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtKolicina = New System.Windows.Forms.TextBox()
        Me.txtStanje = New System.Windows.Forms.TextBox()
        Me.txtJM = New System.Windows.Forms.TextBox()
        Me.grdStavke = New SOLUTION_MG_BlackHorse.myDataGridView()
        Me.CmdSnimi = New System.Windows.Forms.Button()
        Me.CmdNovi = New System.Windows.Forms.Button()
        Me.cmdStampa = New System.Windows.Forms.Button()
        Me.cmdKnjizenje = New System.Windows.Forms.Button()
        Me.mnuForme.SuspendLayout()
        CType(Me.GrdListaStavki, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdStavke, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuForme
        '
        Me.mnuForme.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.mnuBrisanje, Me.ToolStripSeparator2, Me.mnuSortiranjeAZ, Me.mnuSortiranjeZA, Me.ToolStripSeparator3, Me.mnuAzurirajRbr})
        Me.mnuForme.Name = "mnuOtp"
        Me.mnuForme.Size = New System.Drawing.Size(190, 110)
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
        'tmrDelay
        '
        Me.tmrDelay.Interval = 1000
        '
        'CmbMagacin
        '
        Me.CmbMagacin.Enabled = False
        Me.CmbMagacin.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMagacin.FormattingEnabled = True
        Me.CmbMagacin.Location = New System.Drawing.Point(423, 38)
        Me.CmbMagacin.Name = "CmbMagacin"
        Me.CmbMagacin.Size = New System.Drawing.Size(300, 26)
        Me.CmbMagacin.TabIndex = 305
        Me.CmbMagacin.Visible = False
        '
        'txtSifraMagacina
        '
        Me.txtSifraMagacina.Enabled = False
        Me.txtSifraMagacina.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSifraMagacina.Location = New System.Drawing.Point(350, 38)
        Me.txtSifraMagacina.Name = "txtSifraMagacina"
        Me.txtSifraMagacina.Size = New System.Drawing.Size(64, 26)
        Me.txtSifraMagacina.TabIndex = 303
        Me.txtSifraMagacina.Visible = False
        '
        'dtpDatum
        '
        Me.dtpDatum.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatum.Location = New System.Drawing.Point(100, 42)
        Me.dtpDatum.Name = "dtpDatum"
        Me.dtpDatum.Size = New System.Drawing.Size(120, 23)
        Me.dtpDatum.TabIndex = 314
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(97, 22)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 313
        Me.Label4.Text = "Datum"
        '
        'lblDisp
        '
        Me.lblDisp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDisp.BackColor = System.Drawing.Color.Transparent
        Me.lblDisp.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.lblDisp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.lblDisp.Location = New System.Drawing.Point(1165, 605)
        Me.lblDisp.Name = "lblDisp"
        Me.lblDisp.Size = New System.Drawing.Size(111, 19)
        Me.lblDisp.TabIndex = 312
        Me.lblDisp.Text = "0.00"
        Me.lblDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDisp.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(30, 82)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 16)
        Me.Label12.TabIndex = 310
        Me.Label12.Text = "Napomena"
        '
        'txtNapomena
        '
        Me.txtNapomena.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtNapomena.Location = New System.Drawing.Point(30, 102)
        Me.txtNapomena.Name = "txtNapomena"
        Me.txtNapomena.ReadOnly = True
        Me.txtNapomena.Size = New System.Drawing.Size(1081, 23)
        Me.txtNapomena.TabIndex = 309
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(30, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 307
        Me.Label2.Text = "Broj"
        '
        'txtBroj
        '
        Me.txtBroj.Enabled = False
        Me.txtBroj.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtBroj.Location = New System.Drawing.Point(30, 42)
        Me.txtBroj.Name = "txtBroj"
        Me.txtBroj.Size = New System.Drawing.Size(65, 23)
        Me.txtBroj.TabIndex = 306
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(1169, 48)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 16)
        Me.Label18.TabIndex = 318
        Me.Label18.Text = "Knjiženo"
        '
        'chkKnjizeno
        '
        Me.chkKnjizeno.AutoSize = True
        Me.chkKnjizeno.BackColor = System.Drawing.Color.Transparent
        Me.chkKnjizeno.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkKnjizeno.Enabled = False
        Me.chkKnjizeno.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkKnjizeno.ForeColor = System.Drawing.Color.SkyBlue
        Me.chkKnjizeno.Location = New System.Drawing.Point(1147, 51)
        Me.chkKnjizeno.Name = "chkKnjizeno"
        Me.chkKnjizeno.Size = New System.Drawing.Size(15, 14)
        Me.chkKnjizeno.TabIndex = 317
        Me.chkKnjizeno.UseVisualStyleBackColor = False
        '
        'ttForma
        '
        Me.ttForma.IsBalloon = True
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(1153, 79)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(82, 16)
        Me.Label28.TabIndex = 571
        Me.Label28.Text = "Nalog RS - "
        '
        'txtBrojFinansijskogNaloga
        '
        Me.txtBrojFinansijskogNaloga.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBrojFinansijskogNaloga.Enabled = False
        Me.txtBrojFinansijskogNaloga.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtBrojFinansijskogNaloga.Location = New System.Drawing.Point(1124, 102)
        Me.txtBrojFinansijskogNaloga.Name = "txtBrojFinansijskogNaloga"
        Me.txtBrojFinansijskogNaloga.Size = New System.Drawing.Size(102, 23)
        Me.txtBrojFinansijskogNaloga.TabIndex = 570
        Me.txtBrojFinansijskogNaloga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.GrdListaStavki.Location = New System.Drawing.Point(100, 201)
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
        Me.GrdListaStavki.Size = New System.Drawing.Size(626, 134)
        Me.GrdListaStavki.TabIndex = 672
        Me.GrdListaStavki.Visible = False
        '
        'TxtProdajniIznos
        '
        Me.TxtProdajniIznos.Enabled = False
        Me.TxtProdajniIznos.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TxtProdajniIznos.Location = New System.Drawing.Point(1115, 172)
        Me.TxtProdajniIznos.Name = "TxtProdajniIznos"
        Me.TxtProdajniIznos.Size = New System.Drawing.Size(110, 23)
        Me.TxtProdajniIznos.TabIndex = 692
        Me.TxtProdajniIznos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(1123, 153)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 16)
        Me.Label11.TabIndex = 161
        Me.Label11.Text = "Prodajni Iznos"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(823, 153)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 16)
        Me.Label10.TabIndex = 161
        Me.Label10.Text = "Prod. cena"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtProdajnaCena
        '
        Me.TxtProdajnaCena.Enabled = False
        Me.TxtProdajnaCena.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TxtProdajnaCena.Location = New System.Drawing.Point(810, 172)
        Me.TxtProdajnaCena.Name = "TxtProdajnaCena"
        Me.TxtProdajnaCena.Size = New System.Drawing.Size(90, 23)
        Me.TxtProdajnaCena.TabIndex = 689
        Me.TxtProdajnaCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNabavniIznos
        '
        Me.TxtNabavniIznos.Enabled = False
        Me.TxtNabavniIznos.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TxtNabavniIznos.Location = New System.Drawing.Point(1000, 172)
        Me.TxtNabavniIznos.Name = "TxtNabavniIznos"
        Me.TxtNabavniIznos.Size = New System.Drawing.Size(110, 23)
        Me.TxtNabavniIznos.TabIndex = 688
        Me.TxtNabavniIznos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNazivArtikla
        '
        Me.TxtNazivArtikla.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TxtNazivArtikla.Location = New System.Drawing.Point(175, 172)
        Me.TxtNazivArtikla.Name = "TxtNazivArtikla"
        Me.TxtNazivArtikla.Size = New System.Drawing.Size(390, 23)
        Me.TxtNazivArtikla.TabIndex = 687
        '
        'txtSifraArtikla
        '
        Me.txtSifraArtikla.Enabled = False
        Me.txtSifraArtikla.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtSifraArtikla.Location = New System.Drawing.Point(104, 172)
        Me.txtSifraArtikla.Name = "txtSifraArtikla"
        Me.txtSifraArtikla.Size = New System.Drawing.Size(66, 23)
        Me.txtSifraArtikla.TabIndex = 686
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(1009, 153)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 16)
        Me.Label9.TabIndex = 161
        Me.Label9.Text = "Nabavni Iznos"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(60, 153)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(28, 16)
        Me.Label19.TabIndex = 169
        Me.Label19.Text = "Rbr"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(925, 153)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 161
        Me.Label8.Text = "Količina"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(568, 153)
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
        Me.Label6.Location = New System.Drawing.Point(181, 153)
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
        Me.Label7.Location = New System.Drawing.Point(109, 153)
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
        Me.Label21.Location = New System.Drawing.Point(729, 153)
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
        Me.TxtNabavnaCena.Location = New System.Drawing.Point(715, 172)
        Me.TxtNabavnaCena.Name = "TxtNabavnaCena"
        Me.TxtNabavnaCena.Size = New System.Drawing.Size(90, 23)
        Me.TxtNabavnaCena.TabIndex = 677
        Me.TxtNabavnaCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(660, 153)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 16)
        Me.Label20.TabIndex = 164
        Me.Label20.Text = "Stanje"
        '
        'txtKolicina
        '
        Me.txtKolicina.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtKolicina.Location = New System.Drawing.Point(905, 172)
        Me.txtKolicina.Name = "txtKolicina"
        Me.txtKolicina.Size = New System.Drawing.Size(90, 23)
        Me.txtKolicina.TabIndex = 674
        Me.txtKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtStanje
        '
        Me.txtStanje.Enabled = False
        Me.txtStanje.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtStanje.Location = New System.Drawing.Point(620, 172)
        Me.txtStanje.Name = "txtStanje"
        Me.txtStanje.Size = New System.Drawing.Size(90, 23)
        Me.txtStanje.TabIndex = 676
        Me.txtStanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtJM
        '
        Me.txtJM.Enabled = False
        Me.txtJM.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtJM.Location = New System.Drawing.Point(570, 172)
        Me.txtJM.Name = "txtJM"
        Me.txtJM.Size = New System.Drawing.Size(45, 23)
        Me.txtJM.TabIndex = 675
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
        Me.grdStavke.ColumnHeadersVisible = False
        Me.grdStavke.Location = New System.Drawing.Point(29, 207)
        Me.grdStavke.Name = "grdStavke"
        Me.grdStavke.PoslednjaKolona = CType(7, Short)
        Me.grdStavke.PrvaKolona = CType(5, Short)
        Me.grdStavke.RowHeadersWidth = 20
        Me.grdStavke.Size = New System.Drawing.Size(1250, 395)
        Me.grdStavke.TabIndex = 673
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
        Me.CmdSnimi.Location = New System.Drawing.Point(1171, 638)
        Me.CmdSnimi.Name = "CmdSnimi"
        Me.CmdSnimi.Size = New System.Drawing.Size(105, 40)
        Me.CmdSnimi.TabIndex = 696
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
        Me.CmdNovi.Location = New System.Drawing.Point(1043, 638)
        Me.CmdNovi.Name = "CmdNovi"
        Me.CmdNovi.Size = New System.Drawing.Size(100, 40)
        Me.CmdNovi.TabIndex = 695
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
        Me.cmdStampa.Location = New System.Drawing.Point(185, 638)
        Me.cmdStampa.Name = "cmdStampa"
        Me.cmdStampa.Size = New System.Drawing.Size(130, 40)
        Me.cmdStampa.TabIndex = 694
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
        Me.cmdKnjizenje.Location = New System.Drawing.Point(29, 638)
        Me.cmdKnjizenje.Name = "cmdKnjizenje"
        Me.cmdKnjizenje.Size = New System.Drawing.Size(130, 40)
        Me.cmdKnjizenje.TabIndex = 693
        Me.cmdKnjizenje.Text = "Knjiženje"
        Me.cmdKnjizenje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdKnjizenje.UseVisualStyleBackColor = False
        '
        'frmRashod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1300, 715)
        Me.Controls.Add(Me.CmdSnimi)
        Me.Controls.Add(Me.CmdNovi)
        Me.Controls.Add(Me.cmdStampa)
        Me.Controls.Add(Me.cmdKnjizenje)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TxtProdajniIznos)
        Me.Controls.Add(Me.CmbMagacin)
        Me.Controls.Add(Me.txtSifraMagacina)
        Me.Controls.Add(Me.TxtProdajnaCena)
        Me.Controls.Add(Me.TxtNabavniIznos)
        Me.Controls.Add(Me.TxtNazivArtikla)
        Me.Controls.Add(Me.txtSifraArtikla)
        Me.Controls.Add(Me.TxtNabavnaCena)
        Me.Controls.Add(Me.txtKolicina)
        Me.Controls.Add(Me.txtStanje)
        Me.Controls.Add(Me.txtJM)
        Me.Controls.Add(Me.GrdListaStavki)
        Me.Controls.Add(Me.grdStavke)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtBrojFinansijskogNaloga)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.chkKnjizeno)
        Me.Controls.Add(Me.dtpDatum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDisp)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNapomena)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBroj)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRashod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Rashod"
        Me.mnuForme.ResumeLayout(False)
        CType(Me.GrdListaStavki, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdStavke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuForme As ContextMenuStrip
    Friend WithEvents mnuBrisanje As ToolStripMenuItem
    Friend WithEvents tmrDelay As Timer
    Friend WithEvents CmbMagacin As ComboBox
    Friend WithEvents txtSifraMagacina As TextBox
    Friend WithEvents dtpDatum As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDisp As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNapomena As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBroj As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents chkKnjizeno As CheckBox
    Friend WithEvents ttForma As ToolTip
    Friend WithEvents Label28 As Label
    Friend WithEvents txtBrojFinansijskogNaloga As TextBox
    Friend WithEvents GrdListaStavki As DataGridView
    Friend WithEvents grdStavke As myDataGridView
    Friend WithEvents mnuAzurirajRbr As ToolStripMenuItem
    Friend WithEvents mnuSortiranjeAZ As ToolStripMenuItem
    Friend WithEvents mnuSortiranjeZA As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents TxtProdajniIznos As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtProdajnaCena As TextBox
    Friend WithEvents TxtNabavniIznos As TextBox
    Friend WithEvents TxtNazivArtikla As TextBox
    Friend WithEvents txtSifraArtikla As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TxtNabavnaCena As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtKolicina As TextBox
    Friend WithEvents txtStanje As TextBox
    Friend WithEvents txtJM As TextBox
    Friend WithEvents CmdSnimi As Button
    Friend WithEvents CmdNovi As Button
    Friend WithEvents cmdStampa As Button
    Friend WithEvents cmdKnjizenje As Button
End Class
