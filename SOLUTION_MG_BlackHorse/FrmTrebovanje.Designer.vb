<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTrebovanje
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
        Dim Label17 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTrebovanje))
        Me.PnlStanje = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PnlRbr = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PnlKil = New System.Windows.Forms.Panel()
        Me.LblKolicina = New System.Windows.Forms.Label()
        Me.PnlBarCod = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PnlNaziv = New System.Windows.Forms.Panel()
        Me.LblNaziv = New System.Windows.Forms.Label()
        Me.PnlSifra = New System.Windows.Forms.Panel()
        Me.LblSifra = New System.Windows.Forms.Label()
        Me.txtBrojRadnogNaloga = New System.Windows.Forms.TextBox()
        Me.mnuTrebovanje = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBrisanje = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAzurirajRbr = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CmbMagacin = New System.Windows.Forms.ComboBox()
        Me.grdStavke = New SOLUTION_MG_BlackHorse.myDataGridView()
        Me.cmdKnjizenje = New System.Windows.Forms.Button()
        Me.cmdSnimi = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.pnlOK = New System.Windows.Forms.Panel()
        Me.lblDisp = New System.Windows.Forms.Label()
        Me.dtpDatum = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNapomena = New System.Windows.Forms.TextBox()
        Me.chkKnjizeno = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ttForma = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdStampa = New System.Windows.Forms.Button()
        Me.tmrDelay = New System.Windows.Forms.Timer(Me.components)
        Me.TmrIndikatorGreske = New System.Windows.Forms.Timer(Me.components)
        Me.erpIndikatorGreske = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblMagacin = New System.Windows.Forms.Label()
        Me.txtBroj = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelNaslovni = New System.Windows.Forms.Panel()
        Me.cmdIzlaz = New System.Windows.Forms.Button()
        Me.DtpDatumRadnogNaloga = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpDatumKnjizenja = New System.Windows.Forms.DateTimePicker()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtBrojFinansijskogNaloga = New System.Windows.Forms.TextBox()
        Me.txtSifraMagacina = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblVrednost = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Me.PnlStanje.SuspendLayout()
        Me.PnlRbr.SuspendLayout()
        Me.PnlKil.SuspendLayout()
        Me.PnlBarCod.SuspendLayout()
        Me.PnlNaziv.SuspendLayout()
        Me.PnlSifra.SuspendLayout()
        Me.mnuTrebovanje.SuspendLayout()
        CType(Me.grdStavke, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpIndikatorGreske, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.PanelNaslovni.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.BackColor = System.Drawing.Color.Transparent
        Label17.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label17.ForeColor = System.Drawing.Color.White
        Label17.Location = New System.Drawing.Point(12, 6)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(174, 25)
        Label17.TabIndex = 283
        Label17.Text = "TREBOVANJE - "
        '
        'PnlStanje
        '
        Me.PnlStanje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlStanje.Controls.Add(Me.Label20)
        Me.PnlStanje.Location = New System.Drawing.Point(719, 208)
        Me.PnlStanje.Name = "PnlStanje"
        Me.PnlStanje.Size = New System.Drawing.Size(120, 25)
        Me.PnlStanje.TabIndex = 558
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(76, 4)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(40, 16)
        Me.Label20.TabIndex = 164
        Me.Label20.Text = "Cena"
        '
        'PnlRbr
        '
        Me.PnlRbr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlRbr.Controls.Add(Me.Label19)
        Me.PnlRbr.Location = New System.Drawing.Point(33, 208)
        Me.PnlRbr.Name = "PnlRbr"
        Me.PnlRbr.Size = New System.Drawing.Size(45, 25)
        Me.PnlRbr.TabIndex = 554
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(10, 4)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(28, 16)
        Me.Label19.TabIndex = 169
        Me.Label19.Text = "Rbr"
        '
        'PnlKil
        '
        Me.PnlKil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlKil.Controls.Add(Me.LblKolicina)
        Me.PnlKil.Location = New System.Drawing.Point(624, 208)
        Me.PnlKil.Name = "PnlKil"
        Me.PnlKil.Size = New System.Drawing.Size(90, 25)
        Me.PnlKil.TabIndex = 553
        '
        'LblKolicina
        '
        Me.LblKolicina.AutoSize = True
        Me.LblKolicina.BackColor = System.Drawing.Color.Transparent
        Me.LblKolicina.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.LblKolicina.ForeColor = System.Drawing.Color.White
        Me.LblKolicina.Location = New System.Drawing.Point(30, 4)
        Me.LblKolicina.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblKolicina.Name = "LblKolicina"
        Me.LblKolicina.Size = New System.Drawing.Size(56, 16)
        Me.LblKolicina.TabIndex = 161
        Me.LblKolicina.Text = "Količina"
        Me.LblKolicina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlBarCod
        '
        Me.PnlBarCod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlBarCod.Controls.Add(Me.Label9)
        Me.PnlBarCod.Location = New System.Drawing.Point(844, 208)
        Me.PnlBarCod.Name = "PnlBarCod"
        Me.PnlBarCod.Size = New System.Drawing.Size(120, 25)
        Me.PnlBarCod.TabIndex = 551
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(74, 4)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 16)
        Me.Label9.TabIndex = 166
        Me.Label9.Text = "Iznos"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlNaziv
        '
        Me.PnlNaziv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlNaziv.Controls.Add(Me.LblNaziv)
        Me.PnlNaziv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlNaziv.Location = New System.Drawing.Point(168, 208)
        Me.PnlNaziv.Name = "PnlNaziv"
        Me.PnlNaziv.Size = New System.Drawing.Size(380, 25)
        Me.PnlNaziv.TabIndex = 550
        '
        'LblNaziv
        '
        Me.LblNaziv.AutoSize = True
        Me.LblNaziv.BackColor = System.Drawing.Color.Transparent
        Me.LblNaziv.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.LblNaziv.ForeColor = System.Drawing.Color.White
        Me.LblNaziv.Location = New System.Drawing.Point(4, 4)
        Me.LblNaziv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNaziv.Name = "LblNaziv"
        Me.LblNaziv.Size = New System.Drawing.Size(87, 16)
        Me.LblNaziv.TabIndex = 165
        Me.LblNaziv.Text = "Naziv artikla"
        Me.LblNaziv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlSifra
        '
        Me.PnlSifra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlSifra.Controls.Add(Me.LblSifra)
        Me.PnlSifra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PnlSifra.Location = New System.Drawing.Point(84, 208)
        Me.PnlSifra.Name = "PnlSifra"
        Me.PnlSifra.Size = New System.Drawing.Size(80, 25)
        Me.PnlSifra.TabIndex = 549
        '
        'LblSifra
        '
        Me.LblSifra.AutoSize = True
        Me.LblSifra.BackColor = System.Drawing.Color.Transparent
        Me.LblSifra.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.LblSifra.ForeColor = System.Drawing.Color.White
        Me.LblSifra.Location = New System.Drawing.Point(10, 4)
        Me.LblSifra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSifra.Name = "LblSifra"
        Me.LblSifra.Size = New System.Drawing.Size(37, 16)
        Me.LblSifra.TabIndex = 169
        Me.LblSifra.Text = "Šifra"
        '
        'txtBrojRadnogNaloga
        '
        Me.txtBrojRadnogNaloga.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtBrojRadnogNaloga.Location = New System.Drawing.Point(605, 125)
        Me.txtBrojRadnogNaloga.Name = "txtBrojRadnogNaloga"
        Me.txtBrojRadnogNaloga.ReadOnly = True
        Me.txtBrojRadnogNaloga.Size = New System.Drawing.Size(100, 23)
        Me.txtBrojRadnogNaloga.TabIndex = 545
        Me.txtBrojRadnogNaloga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mnuTrebovanje
        '
        Me.mnuTrebovanje.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.mnuBrisanje, Me.mnuAzurirajRbr})
        Me.mnuTrebovanje.Name = "mnuUlaz"
        Me.mnuTrebovanje.Size = New System.Drawing.Size(190, 54)
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
        Me.mnuBrisanje.Text = "Brisanje"
        '
        'mnuAzurirajRbr
        '
        Me.mnuAzurirajRbr.Enabled = False
        Me.mnuAzurirajRbr.Image = CType(resources.GetObject("mnuAzurirajRbr.Image"), System.Drawing.Image)
        Me.mnuAzurirajRbr.Name = "mnuAzurirajRbr"
        Me.mnuAzurirajRbr.Size = New System.Drawing.Size(189, 22)
        Me.mnuAzurirajRbr.Text = "Ažuriraj redne brojeve"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(620, 105)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 16)
        Me.Label18.TabIndex = 546
        Me.Label18.Text = "Radni nalog"
        '
        'CmbMagacin
        '
        Me.CmbMagacin.Enabled = False
        Me.CmbMagacin.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.CmbMagacin.FormattingEnabled = True
        Me.CmbMagacin.Location = New System.Drawing.Point(105, 70)
        Me.CmbMagacin.Name = "CmbMagacin"
        Me.CmbMagacin.Size = New System.Drawing.Size(288, 24)
        Me.CmbMagacin.TabIndex = 547
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
        Me.grdStavke.ColumnHeadersVisible = False
        Me.grdStavke.Location = New System.Drawing.Point(26, 239)
        Me.grdStavke.Name = "grdStavke"
        Me.grdStavke.PoslednjaKolona = CType(6, Short)
        Me.grdStavke.PrvaKolona = CType(4, Short)
        Me.grdStavke.RowHeadersWidth = 20
        Me.grdStavke.Size = New System.Drawing.Size(950, 400)
        Me.grdStavke.TabIndex = 548
        Me.grdStavke.VertikalniSBUvekVidljiv = False
        '
        'cmdKnjizenje
        '
        Me.cmdKnjizenje.BackColor = System.Drawing.Color.Transparent
        Me.cmdKnjizenje.BackgroundImage = CType(resources.GetObject("cmdKnjizenje.BackgroundImage"), System.Drawing.Image)
        Me.cmdKnjizenje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdKnjizenje.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdKnjizenje.FlatAppearance.BorderSize = 0
        Me.cmdKnjizenje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.cmdKnjizenje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.cmdKnjizenje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdKnjizenje.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdKnjizenje.ForeColor = System.Drawing.Color.White
        Me.cmdKnjizenje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdKnjizenje.Location = New System.Drawing.Point(440, 0)
        Me.cmdKnjizenje.Name = "cmdKnjizenje"
        Me.cmdKnjizenje.Size = New System.Drawing.Size(120, 40)
        Me.cmdKnjizenje.TabIndex = 292
        Me.cmdKnjizenje.Text = "Knjiženje"
        Me.ttForma.SetToolTip(Me.cmdKnjizenje, "Knjiženje sa stanja iz magacina")
        Me.cmdKnjizenje.UseVisualStyleBackColor = False
        '
        'cmdSnimi
        '
        Me.cmdSnimi.BackColor = System.Drawing.Color.Transparent
        Me.cmdSnimi.BackgroundImage = CType(resources.GetObject("cmdSnimi.BackgroundImage"), System.Drawing.Image)
        Me.cmdSnimi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdSnimi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSnimi.FlatAppearance.BorderSize = 0
        Me.cmdSnimi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.cmdSnimi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.cmdSnimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSnimi.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSnimi.ForeColor = System.Drawing.Color.White
        Me.cmdSnimi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSnimi.Location = New System.Drawing.Point(315, 0)
        Me.cmdSnimi.Name = "cmdSnimi"
        Me.cmdSnimi.Size = New System.Drawing.Size(120, 40)
        Me.cmdSnimi.TabIndex = 209
        Me.cmdSnimi.Text = "Snimi"
        Me.ttForma.SetToolTip(Me.cmdSnimi, "Snimanje unetih vrednosti")
        Me.cmdSnimi.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(897, 68)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 16)
        Me.Label15.TabIndex = 543
        Me.Label15.Text = "Knjiženo"
        '
        'pnlOK
        '
        Me.pnlOK.BackColor = System.Drawing.Color.Transparent
        Me.pnlOK.BackgroundImage = CType(resources.GetObject("pnlOK.BackgroundImage"), System.Drawing.Image)
        Me.pnlOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlOK.Location = New System.Drawing.Point(399, 65)
        Me.pnlOK.Name = "pnlOK"
        Me.pnlOK.Size = New System.Drawing.Size(65, 55)
        Me.pnlOK.TabIndex = 542
        Me.pnlOK.Visible = False
        '
        'lblDisp
        '
        Me.lblDisp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDisp.BackColor = System.Drawing.Color.Transparent
        Me.lblDisp.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.lblDisp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.lblDisp.Location = New System.Drawing.Point(477, 656)
        Me.lblDisp.Name = "lblDisp"
        Me.lblDisp.Size = New System.Drawing.Size(111, 19)
        Me.lblDisp.TabIndex = 541
        Me.lblDisp.Text = "0.00"
        Me.lblDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDisp.Visible = False
        '
        'dtpDatum
        '
        Me.dtpDatum.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatum.Location = New System.Drawing.Point(102, 125)
        Me.dtpDatum.Name = "dtpDatum"
        Me.dtpDatum.Size = New System.Drawing.Size(120, 23)
        Me.dtpDatum.TabIndex = 540
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(29, 159)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 16)
        Me.Label12.TabIndex = 534
        Me.Label12.Text = "Napomena"
        '
        'txtNapomena
        '
        Me.txtNapomena.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtNapomena.Location = New System.Drawing.Point(31, 176)
        Me.txtNapomena.Name = "txtNapomena"
        Me.txtNapomena.Size = New System.Drawing.Size(929, 23)
        Me.txtNapomena.TabIndex = 533
        '
        'chkKnjizeno
        '
        Me.chkKnjizeno.AutoSize = True
        Me.chkKnjizeno.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.chkKnjizeno.Enabled = False
        Me.chkKnjizeno.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkKnjizeno.ForeColor = System.Drawing.Color.SkyBlue
        Me.chkKnjizeno.Location = New System.Drawing.Point(879, 71)
        Me.chkKnjizeno.Name = "chkKnjizeno"
        Me.chkKnjizeno.Size = New System.Drawing.Size(15, 14)
        Me.chkKnjizeno.TabIndex = 529
        Me.chkKnjizeno.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(100, 105)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 528
        Me.Label4.Text = "Datum"
        '
        'cmdStampa
        '
        Me.cmdStampa.BackColor = System.Drawing.Color.Transparent
        Me.cmdStampa.BackgroundImage = CType(resources.GetObject("cmdStampa.BackgroundImage"), System.Drawing.Image)
        Me.cmdStampa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdStampa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdStampa.FlatAppearance.BorderSize = 0
        Me.cmdStampa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.cmdStampa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.cmdStampa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdStampa.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStampa.ForeColor = System.Drawing.Color.White
        Me.cmdStampa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdStampa.Location = New System.Drawing.Point(565, 0)
        Me.cmdStampa.Name = "cmdStampa"
        Me.cmdStampa.Size = New System.Drawing.Size(120, 40)
        Me.cmdStampa.TabIndex = 293
        Me.cmdStampa.Text = "Štampa"
        Me.ttForma.SetToolTip(Me.cmdStampa, "Štampanje dokumenta")
        Me.cmdStampa.UseVisualStyleBackColor = False
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(30, 105)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 527
        Me.Label2.Text = "Broj"
        '
        'LblMagacin
        '
        Me.LblMagacin.AutoSize = True
        Me.LblMagacin.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMagacin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.LblMagacin.Location = New System.Drawing.Point(179, 6)
        Me.LblMagacin.Name = "LblMagacin"
        Me.LblMagacin.Size = New System.Drawing.Size(101, 25)
        Me.LblMagacin.TabIndex = 284
        Me.LblMagacin.Text = "magacin"
        '
        'txtBroj
        '
        Me.txtBroj.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtBroj.Location = New System.Drawing.Point(30, 125)
        Me.txtBroj.Name = "txtBroj"
        Me.txtBroj.ReadOnly = True
        Me.txtBroj.Size = New System.Drawing.Size(65, 23)
        Me.txtBroj.TabIndex = 526
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(30, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 525
        Me.Label1.Text = "Magacin"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.cmdStampa)
        Me.Panel3.Controls.Add(Me.cmdKnjizenje)
        Me.Panel3.Controls.Add(Me.cmdSnimi)
        Me.Panel3.Location = New System.Drawing.Point(0, 690)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1000, 40)
        Me.Panel3.TabIndex = 518
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(310, 40)
        Me.Panel4.TabIndex = 297
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(690, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(310, 40)
        Me.Panel2.TabIndex = 296
        '
        'PanelNaslovni
        '
        Me.PanelNaslovni.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelNaslovni.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.PanelNaslovni.Controls.Add(Me.cmdIzlaz)
        Me.PanelNaslovni.Controls.Add(Me.LblMagacin)
        Me.PanelNaslovni.Controls.Add(Label17)
        Me.PanelNaslovni.Location = New System.Drawing.Point(0, 0)
        Me.PanelNaslovni.Name = "PanelNaslovni"
        Me.PanelNaslovni.Size = New System.Drawing.Size(1000, 40)
        Me.PanelNaslovni.TabIndex = 517
        '
        'cmdIzlaz
        '
        Me.cmdIzlaz.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdIzlaz.BackColor = System.Drawing.Color.Transparent
        Me.cmdIzlaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdIzlaz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdIzlaz.FlatAppearance.BorderSize = 0
        Me.cmdIzlaz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cmdIzlaz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdIzlaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdIzlaz.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIzlaz.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.cmdIzlaz.Image = CType(resources.GetObject("cmdIzlaz.Image"), System.Drawing.Image)
        Me.cmdIzlaz.Location = New System.Drawing.Point(958, 5)
        Me.cmdIzlaz.Name = "cmdIzlaz"
        Me.cmdIzlaz.Size = New System.Drawing.Size(30, 30)
        Me.cmdIzlaz.TabIndex = 285
        Me.cmdIzlaz.UseVisualStyleBackColor = False
        '
        'DtpDatumRadnogNaloga
        '
        Me.DtpDatumRadnogNaloga.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.DtpDatumRadnogNaloga.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDatumRadnogNaloga.Location = New System.Drawing.Point(711, 125)
        Me.DtpDatumRadnogNaloga.Name = "DtpDatumRadnogNaloga"
        Me.DtpDatumRadnogNaloga.Size = New System.Drawing.Size(120, 23)
        Me.DtpDatumRadnogNaloga.TabIndex = 560
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(760, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 559
        Me.Label3.Text = "Datum RN"
        '
        'DtpDatumKnjizenja
        '
        Me.DtpDatumKnjizenja.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.DtpDatumKnjizenja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDatumKnjizenja.Location = New System.Drawing.Point(837, 125)
        Me.DtpDatumKnjizenja.Name = "DtpDatumKnjizenja"
        Me.DtpDatumKnjizenja.Size = New System.Drawing.Size(120, 23)
        Me.DtpDatumKnjizenja.TabIndex = 656
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(847, 105)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(111, 16)
        Me.Label25.TabIndex = 655
        Me.Label25.Text = "Datum knjizenja"
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(517, 105)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(71, 16)
        Me.Label28.TabIndex = 658
        Me.Label28.Text = "Fin. nalog"
        Me.Label28.Visible = False
        '
        'txtBrojFinansijskogNaloga
        '
        Me.txtBrojFinansijskogNaloga.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBrojFinansijskogNaloga.BackColor = System.Drawing.SystemColors.Control
        Me.txtBrojFinansijskogNaloga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBrojFinansijskogNaloga.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtBrojFinansijskogNaloga.Location = New System.Drawing.Point(499, 125)
        Me.txtBrojFinansijskogNaloga.Name = "txtBrojFinansijskogNaloga"
        Me.txtBrojFinansijskogNaloga.ReadOnly = True
        Me.txtBrojFinansijskogNaloga.Size = New System.Drawing.Size(100, 23)
        Me.txtBrojFinansijskogNaloga.TabIndex = 657
        Me.txtBrojFinansijskogNaloga.Visible = False
        '
        'txtSifraMagacina
        '
        Me.txtSifraMagacina.Enabled = False
        Me.txtSifraMagacina.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtSifraMagacina.Location = New System.Drawing.Point(30, 70)
        Me.txtSifraMagacina.Name = "txtSifraMagacina"
        Me.txtSifraMagacina.Size = New System.Drawing.Size(64, 23)
        Me.txtSifraMagacina.TabIndex = 524
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.lblVrednost)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Location = New System.Drawing.Point(615, 644)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 41)
        Me.GroupBox1.TabIndex = 659
        Me.GroupBox1.TabStop = False
        '
        'lblVrednost
        '
        Me.lblVrednost.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVrednost.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVrednost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblVrednost.Location = New System.Drawing.Point(230, 15)
        Me.lblVrednost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVrednost.Name = "lblVrednost"
        Me.lblVrednost.Size = New System.Drawing.Size(126, 16)
        Me.lblVrednost.TabIndex = 242
        Me.lblVrednost.Text = "0.00"
        Me.lblVrednost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(2, 15)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(217, 16)
        Me.Label24.TabIndex = 238
        Me.Label24.Text = "Finansijska vrednost trebovanja"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(553, 208)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(65, 25)
        Me.Panel1.TabIndex = 552
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 4)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 164
        Me.Label6.Text = "J.mere"
        '
        'FrmTrebovanje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 730)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtBrojFinansijskogNaloga)
        Me.Controls.Add(Me.DtpDatumKnjizenja)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.DtpDatumRadnogNaloga)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PnlStanje)
        Me.Controls.Add(Me.PnlRbr)
        Me.Controls.Add(Me.PnlKil)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PnlBarCod)
        Me.Controls.Add(Me.PnlNaziv)
        Me.Controls.Add(Me.PnlSifra)
        Me.Controls.Add(Me.txtBrojRadnogNaloga)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.CmbMagacin)
        Me.Controls.Add(Me.grdStavke)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.pnlOK)
        Me.Controls.Add(Me.lblDisp)
        Me.Controls.Add(Me.dtpDatum)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNapomena)
        Me.Controls.Add(Me.chkKnjizeno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBroj)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSifraMagacina)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelNaslovni)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTrebovanje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmTrebovanje"
        Me.PnlStanje.ResumeLayout(False)
        Me.PnlStanje.PerformLayout()
        Me.PnlRbr.ResumeLayout(False)
        Me.PnlRbr.PerformLayout()
        Me.PnlKil.ResumeLayout(False)
        Me.PnlKil.PerformLayout()
        Me.PnlBarCod.ResumeLayout(False)
        Me.PnlBarCod.PerformLayout()
        Me.PnlNaziv.ResumeLayout(False)
        Me.PnlNaziv.PerformLayout()
        Me.PnlSifra.ResumeLayout(False)
        Me.PnlSifra.PerformLayout()
        Me.mnuTrebovanje.ResumeLayout(False)
        CType(Me.grdStavke, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpIndikatorGreske, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.PanelNaslovni.ResumeLayout(False)
        Me.PanelNaslovni.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlStanje As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents PnlRbr As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents PnlKil As Panel
    Friend WithEvents LblKolicina As Label
    Friend WithEvents PnlBarCod As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents PnlNaziv As Panel
    Friend WithEvents LblNaziv As Label
    Friend WithEvents PnlSifra As Panel
    Friend WithEvents LblSifra As Label
    Friend WithEvents txtBrojRadnogNaloga As TextBox
    Friend WithEvents mnuTrebovanje As ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuBrisanje As ToolStripMenuItem
    Friend WithEvents mnuAzurirajRbr As ToolStripMenuItem
    Friend WithEvents Label18 As Label
    Friend WithEvents CmbMagacin As ComboBox
    Friend WithEvents grdStavke As myDataGridView
    Friend WithEvents ttForma As ToolTip
    Friend WithEvents cmdKnjizenje As Button
    Friend WithEvents cmdSnimi As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents pnlOK As Panel
    Friend WithEvents lblDisp As Label
    Friend WithEvents dtpDatum As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNapomena As TextBox
    Friend WithEvents chkKnjizeno As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdStampa As Button
    Friend WithEvents tmrDelay As Timer
    Friend WithEvents TmrIndikatorGreske As Timer
    Friend WithEvents erpIndikatorGreske As ErrorProvider
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBroj As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelNaslovni As Panel
    Friend WithEvents cmdIzlaz As Button
    Friend WithEvents LblMagacin As Label
    Friend WithEvents DtpDatumRadnogNaloga As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DtpDatumKnjizenja As DateTimePicker
    Friend WithEvents Label25 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents txtBrojFinansijskogNaloga As TextBox
    Friend WithEvents txtSifraMagacina As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblVrednost As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
End Class
