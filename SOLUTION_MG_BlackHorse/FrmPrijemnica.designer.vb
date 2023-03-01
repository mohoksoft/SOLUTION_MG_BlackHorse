<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrijemnica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrijemnica))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkKnjizeno = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBroj = New System.Windows.Forms.TextBox()
        Me.txtJM = New System.Windows.Forms.TextBox()
        Me.txtKolicina = New System.Windows.Forms.TextBox()
        Me.mnuPrijemnica = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBrisanje = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSortiranjeAZ = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSortiranjeZA = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuAzurirajRbr = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttForma = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmrDelay = New System.Windows.Forms.Timer(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBrojUlaznogDokumenta = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNapomena = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPrevoznik = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtVozilo = New System.Windows.Forms.TextBox()
        Me.chkKalkulacija = New System.Windows.Forms.CheckBox()
        Me.dtpDatum = New System.Windows.Forms.DateTimePicker()
        Me.dtpDatumUlaza = New System.Windows.Forms.DateTimePicker()
        Me.lblDisp = New System.Windows.Forms.Label()
        Me.CmbMagacin = New System.Windows.Forms.ComboBox()
        Me.TxtSifraMagacina = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtBrojKalkulacije = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TmrIndikatorGreske = New System.Windows.Forms.Timer(Me.components)
        Me.erpIndikatorGreske = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ImgTasteri = New System.Windows.Forms.ImageList(Me.components)
        Me.ChkMaloprodaja = New System.Windows.Forms.CheckBox()
        Me.ChkUvoz = New System.Windows.Forms.CheckBox()
        Me.ChkVeleprodaja = New System.Windows.Forms.CheckBox()
        Me.txtNazivDobavljaca = New System.Windows.Forms.TextBox()
        Me.txtSifraDobavljaca = New System.Windows.Forms.TextBox()
        Me.TxtNazivArtikla = New System.Windows.Forms.TextBox()
        Me.txtSifraArtikla = New System.Windows.Forms.TextBox()
        Me.grdLista = New System.Windows.Forms.DataGridView()
        Me.GrdListaStavki = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdStampa = New System.Windows.Forms.Button()
        Me.cmdKnjizenje = New System.Windows.Forms.Button()
        Me.CmdSnimi = New System.Windows.Forms.Button()
        Me.CmdNovi = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdStavke = New SOLUTION_MG_BlackHorse.myDataGridView()
        Me.mnuPrijemnica.SuspendLayout()
        CType(Me.erpIndikatorGreske, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdListaStavki, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdStavke, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(27, 92)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 196
        Me.Label3.Text = "Dobavljač"
        '
        'chkKnjizeno
        '
        Me.chkKnjizeno.AutoSize = True
        Me.chkKnjizeno.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.chkKnjizeno.Enabled = False
        Me.chkKnjizeno.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkKnjizeno.ForeColor = System.Drawing.Color.SkyBlue
        Me.chkKnjizeno.Location = New System.Drawing.Point(822, 38)
        Me.chkKnjizeno.Name = "chkKnjizeno"
        Me.chkKnjizeno.Size = New System.Drawing.Size(15, 14)
        Me.chkKnjizeno.TabIndex = 194
        Me.chkKnjizeno.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(98, 32)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 193
        Me.Label4.Text = "Datum"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(28, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 191
        Me.Label2.Text = "Broj"
        '
        'txtBroj
        '
        Me.txtBroj.Enabled = False
        Me.txtBroj.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtBroj.Location = New System.Drawing.Point(30, 53)
        Me.txtBroj.Name = "txtBroj"
        Me.txtBroj.Size = New System.Drawing.Size(65, 23)
        Me.txtBroj.TabIndex = 190
        '
        'txtJM
        '
        Me.txtJM.Enabled = False
        Me.txtJM.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtJM.Location = New System.Drawing.Point(705, 245)
        Me.txtJM.Name = "txtJM"
        Me.txtJM.Size = New System.Drawing.Size(77, 23)
        Me.txtJM.TabIndex = 163
        '
        'txtKolicina
        '
        Me.txtKolicina.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtKolicina.Location = New System.Drawing.Point(788, 245)
        Me.txtKolicina.Name = "txtKolicina"
        Me.txtKolicina.Size = New System.Drawing.Size(109, 23)
        Me.txtKolicina.TabIndex = 160
        Me.txtKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mnuPrijemnica
        '
        Me.mnuPrijemnica.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.mnuBrisanje, Me.ToolStripSeparator2, Me.mnuSortiranjeAZ, Me.mnuSortiranjeZA, Me.ToolStripSeparator3, Me.mnuAzurirajRbr})
        Me.mnuPrijemnica.Name = "mnuUlaz"
        Me.mnuPrijemnica.Size = New System.Drawing.Size(190, 110)
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(535, 92)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 16)
        Me.Label10.TabIndex = 208
        Me.Label10.Text = "Br. ulaznog dok."
        '
        'txtBrojUlaznogDokumenta
        '
        Me.txtBrojUlaznogDokumenta.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtBrojUlaznogDokumenta.Location = New System.Drawing.Point(537, 112)
        Me.txtBrojUlaznogDokumenta.Name = "txtBrojUlaznogDokumenta"
        Me.txtBrojUlaznogDokumenta.Size = New System.Drawing.Size(150, 23)
        Me.txtBrojUlaznogDokumenta.TabIndex = 207
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(695, 92)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 19)
        Me.Label11.TabIndex = 210
        Me.Label11.Text = "Datum ulaz.dok."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(539, 145)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 16)
        Me.Label12.TabIndex = 212
        Me.Label12.Text = "Napomena"
        '
        'txtNapomena
        '
        Me.txtNapomena.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtNapomena.Location = New System.Drawing.Point(538, 166)
        Me.txtNapomena.Name = "txtNapomena"
        Me.txtNapomena.ReadOnly = True
        Me.txtNapomena.Size = New System.Drawing.Size(386, 23)
        Me.txtNapomena.TabIndex = 211
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(28, 145)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 16)
        Me.Label13.TabIndex = 215
        Me.Label13.Text = "Prevoznik"
        '
        'txtPrevoznik
        '
        Me.txtPrevoznik.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtPrevoznik.Location = New System.Drawing.Point(30, 166)
        Me.txtPrevoznik.Name = "txtPrevoznik"
        Me.txtPrevoznik.ReadOnly = True
        Me.txtPrevoznik.Size = New System.Drawing.Size(270, 23)
        Me.txtPrevoznik.TabIndex = 214
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(308, 145)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(138, 16)
        Me.Label14.TabIndex = 217
        Me.Label14.Text = "Vozilo - reg. oznaka"
        '
        'txtVozilo
        '
        Me.txtVozilo.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtVozilo.Location = New System.Drawing.Point(311, 166)
        Me.txtVozilo.Name = "txtVozilo"
        Me.txtVozilo.ReadOnly = True
        Me.txtVozilo.Size = New System.Drawing.Size(220, 23)
        Me.txtVozilo.TabIndex = 216
        '
        'chkKalkulacija
        '
        Me.chkKalkulacija.AutoSize = True
        Me.chkKalkulacija.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.chkKalkulacija.Enabled = False
        Me.chkKalkulacija.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkKalkulacija.ForeColor = System.Drawing.Color.SkyBlue
        Me.chkKalkulacija.Location = New System.Drawing.Point(822, 58)
        Me.chkKalkulacija.Name = "chkKalkulacija"
        Me.chkKalkulacija.Size = New System.Drawing.Size(15, 14)
        Me.chkKalkulacija.TabIndex = 218
        Me.chkKalkulacija.UseVisualStyleBackColor = False
        '
        'dtpDatum
        '
        Me.dtpDatum.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatum.Location = New System.Drawing.Point(101, 53)
        Me.dtpDatum.Name = "dtpDatum"
        Me.dtpDatum.Size = New System.Drawing.Size(120, 23)
        Me.dtpDatum.TabIndex = 219
        '
        'dtpDatumUlaza
        '
        Me.dtpDatumUlaza.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.dtpDatumUlaza.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatumUlaza.Location = New System.Drawing.Point(695, 112)
        Me.dtpDatumUlaza.Name = "dtpDatumUlaza"
        Me.dtpDatumUlaza.Size = New System.Drawing.Size(120, 23)
        Me.dtpDatumUlaza.TabIndex = 220
        '
        'lblDisp
        '
        Me.lblDisp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDisp.BackColor = System.Drawing.Color.Transparent
        Me.lblDisp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.lblDisp.Location = New System.Drawing.Point(813, 668)
        Me.lblDisp.Name = "lblDisp"
        Me.lblDisp.Size = New System.Drawing.Size(111, 19)
        Me.lblDisp.TabIndex = 282
        Me.lblDisp.Text = "0.00"
        Me.lblDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDisp.Visible = False
        '
        'CmbMagacin
        '
        Me.CmbMagacin.BackColor = System.Drawing.SystemColors.Window
        Me.CmbMagacin.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMagacin.FormattingEnabled = True
        Me.CmbMagacin.Location = New System.Drawing.Point(311, 52)
        Me.CmbMagacin.Name = "CmbMagacin"
        Me.CmbMagacin.Size = New System.Drawing.Size(300, 26)
        Me.CmbMagacin.TabIndex = 497
        '
        'TxtSifraMagacina
        '
        Me.TxtSifraMagacina.BackColor = System.Drawing.SystemColors.Window
        Me.TxtSifraMagacina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSifraMagacina.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.TxtSifraMagacina.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtSifraMagacina.Location = New System.Drawing.Point(236, 53)
        Me.TxtSifraMagacina.Name = "TxtSifraMagacina"
        Me.TxtSifraMagacina.Size = New System.Drawing.Size(64, 26)
        Me.TxtSifraMagacina.TabIndex = 471
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(840, 35)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 16)
        Me.Label15.TabIndex = 295
        Me.Label15.Text = "Knjiženo"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(840, 56)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 16)
        Me.Label16.TabIndex = 296
        Me.Label16.Text = "Kalkulacija"
        '
        'txtBrojKalkulacije
        '
        Me.txtBrojKalkulacije.Enabled = False
        Me.txtBrojKalkulacije.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtBrojKalkulacije.Location = New System.Drawing.Point(820, 112)
        Me.txtBrojKalkulacije.Name = "txtBrojKalkulacije"
        Me.txtBrojKalkulacije.Size = New System.Drawing.Size(104, 23)
        Me.txtBrojKalkulacije.TabIndex = 297
        Me.txtBrojKalkulacije.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(819, 92)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 16)
        Me.Label18.TabIndex = 298
        Me.Label18.Text = "Broj kalkulacije"
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
        'ImgTasteri
        '
        Me.ImgTasteri.ImageStream = CType(resources.GetObject("ImgTasteri.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgTasteri.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgTasteri.Images.SetKeyName(0, "Taster 115_40.png")
        Me.ImgTasteri.Images.SetKeyName(1, "Taster 115_40_DownS.png")
        '
        'ChkMaloprodaja
        '
        Me.ChkMaloprodaja.AutoSize = True
        Me.ChkMaloprodaja.BackColor = System.Drawing.Color.Transparent
        Me.ChkMaloprodaja.Enabled = False
        Me.ChkMaloprodaja.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkMaloprodaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ChkMaloprodaja.Location = New System.Drawing.Point(537, 34)
        Me.ChkMaloprodaja.Name = "ChkMaloprodaja"
        Me.ChkMaloprodaja.Size = New System.Drawing.Size(105, 20)
        Me.ChkMaloprodaja.TabIndex = 514
        Me.ChkMaloprodaja.Text = "Maloprodaja"
        Me.ChkMaloprodaja.UseVisualStyleBackColor = False
        Me.ChkMaloprodaja.Visible = False
        '
        'ChkUvoz
        '
        Me.ChkUvoz.AutoSize = True
        Me.ChkUvoz.BackColor = System.Drawing.Color.Transparent
        Me.ChkUvoz.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkUvoz.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ChkUvoz.Location = New System.Drawing.Point(695, 55)
        Me.ChkUvoz.Name = "ChkUvoz"
        Me.ChkUvoz.Size = New System.Drawing.Size(58, 20)
        Me.ChkUvoz.TabIndex = 513
        Me.ChkUvoz.Text = "Uvoz"
        Me.ChkUvoz.UseVisualStyleBackColor = False
        '
        'ChkVeleprodaja
        '
        Me.ChkVeleprodaja.AutoSize = True
        Me.ChkVeleprodaja.BackColor = System.Drawing.Color.Transparent
        Me.ChkVeleprodaja.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkVeleprodaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ChkVeleprodaja.Location = New System.Drawing.Point(695, 36)
        Me.ChkVeleprodaja.Name = "ChkVeleprodaja"
        Me.ChkVeleprodaja.Size = New System.Drawing.Size(102, 20)
        Me.ChkVeleprodaja.TabIndex = 517
        Me.ChkVeleprodaja.Text = "Veleprodaja"
        Me.ChkVeleprodaja.UseVisualStyleBackColor = False
        '
        'txtNazivDobavljaca
        '
        Me.txtNazivDobavljaca.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtNazivDobavljaca.Location = New System.Drawing.Point(98, 112)
        Me.txtNazivDobavljaca.Name = "txtNazivDobavljaca"
        Me.txtNazivDobavljaca.Size = New System.Drawing.Size(433, 23)
        Me.txtNazivDobavljaca.TabIndex = 579
        '
        'txtSifraDobavljaca
        '
        Me.txtSifraDobavljaca.Enabled = False
        Me.txtSifraDobavljaca.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtSifraDobavljaca.Location = New System.Drawing.Point(30, 112)
        Me.txtSifraDobavljaca.Name = "txtSifraDobavljaca"
        Me.txtSifraDobavljaca.Size = New System.Drawing.Size(65, 23)
        Me.txtSifraDobavljaca.TabIndex = 578
        '
        'TxtNazivArtikla
        '
        Me.TxtNazivArtikla.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TxtNazivArtikla.Location = New System.Drawing.Point(168, 245)
        Me.TxtNazivArtikla.Name = "TxtNazivArtikla"
        Me.TxtNazivArtikla.Size = New System.Drawing.Size(530, 23)
        Me.TxtNazivArtikla.TabIndex = 641
        '
        'txtSifraArtikla
        '
        Me.txtSifraArtikla.Enabled = False
        Me.txtSifraArtikla.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtSifraArtikla.Location = New System.Drawing.Point(98, 245)
        Me.txtSifraArtikla.Name = "txtSifraArtikla"
        Me.txtSifraArtikla.Size = New System.Drawing.Size(66, 23)
        Me.txtSifraArtikla.TabIndex = 640
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
        Me.grdLista.Location = New System.Drawing.Point(30, 141)
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
        Me.grdLista.Size = New System.Drawing.Size(646, 127)
        Me.grdLista.TabIndex = 579
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
        Me.GrdListaStavki.Location = New System.Drawing.Point(98, 274)
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
        Me.GrdListaStavki.Size = New System.Drawing.Size(799, 134)
        Me.GrdListaStavki.TabIndex = 648
        Me.GrdListaStavki.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(102, 223)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 19)
        Me.Label7.TabIndex = 169
        Me.Label7.Text = "Šifra"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(172, 223)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 19)
        Me.Label6.TabIndex = 165
        Me.Label6.Text = "Naziv artikla"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(727, 223)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 19)
        Me.Label5.TabIndex = 164
        Me.Label5.Text = "J.mere"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(837, 223)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 19)
        Me.Label8.TabIndex = 161
        Me.Label8.Text = "Količina"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.cmdStampa.Location = New System.Drawing.Point(181, 699)
        Me.cmdStampa.Name = "cmdStampa"
        Me.cmdStampa.Size = New System.Drawing.Size(130, 40)
        Me.cmdStampa.TabIndex = 669
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
        Me.cmdKnjizenje.Location = New System.Drawing.Point(25, 699)
        Me.cmdKnjizenje.Name = "cmdKnjizenje"
        Me.cmdKnjizenje.Size = New System.Drawing.Size(130, 40)
        Me.cmdKnjizenje.TabIndex = 668
        Me.cmdKnjizenje.Text = "Knjiženje"
        Me.cmdKnjizenje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdKnjizenje.UseVisualStyleBackColor = False
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
        Me.CmdSnimi.Location = New System.Drawing.Point(805, 699)
        Me.CmdSnimi.Name = "CmdSnimi"
        Me.CmdSnimi.Size = New System.Drawing.Size(105, 40)
        Me.CmdSnimi.TabIndex = 671
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
        Me.CmdNovi.Location = New System.Drawing.Point(677, 699)
        Me.CmdNovi.Name = "CmdNovi"
        Me.CmdNovi.Size = New System.Drawing.Size(100, 40)
        Me.CmdNovi.TabIndex = 670
        Me.CmdNovi.Text = "Novi"
        Me.CmdNovi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdNovi.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(308, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 672
        Me.Label1.Text = "Magacin"
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdStavke.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.grdStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdStavke.Location = New System.Drawing.Point(25, 274)
        Me.grdStavke.Name = "grdStavke"
        Me.grdStavke.PoslednjaKolona = CType(4, Short)
        Me.grdStavke.PrvaKolona = CType(4, Short)
        Me.grdStavke.RowHeadersWidth = 20
        Me.grdStavke.Size = New System.Drawing.Size(900, 391)
        Me.grdStavke.TabIndex = 451
        Me.grdStavke.VertikalniSBUvekVidljiv = False
        '
        'frmPrijemnica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(950, 761)
        Me.Controls.Add(Me.grdLista)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmdSnimi)
        Me.Controls.Add(Me.CmdNovi)
        Me.Controls.Add(Me.cmdStampa)
        Me.Controls.Add(Me.cmdKnjizenje)
        Me.Controls.Add(Me.CmbMagacin)
        Me.Controls.Add(Me.TxtSifraMagacina)
        Me.Controls.Add(Me.GrdListaStavki)
        Me.Controls.Add(Me.TxtNazivArtikla)
        Me.Controls.Add(Me.txtSifraArtikla)
        Me.Controls.Add(Me.txtNazivDobavljaca)
        Me.Controls.Add(Me.txtSifraDobavljaca)
        Me.Controls.Add(Me.ChkVeleprodaja)
        Me.Controls.Add(Me.ChkMaloprodaja)
        Me.Controls.Add(Me.ChkUvoz)
        Me.Controls.Add(Me.grdStavke)
        Me.Controls.Add(Me.txtKolicina)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtBrojKalkulacije)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtJM)
        Me.Controls.Add(Me.lblDisp)
        Me.Controls.Add(Me.dtpDatumUlaza)
        Me.Controls.Add(Me.dtpDatum)
        Me.Controls.Add(Me.chkKalkulacija)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtVozilo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtPrevoznik)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNapomena)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtBrojUlaznogDokumenta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkKnjizeno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBroj)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrijemnica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Prijemnica"
        Me.mnuPrijemnica.ResumeLayout(False)
        CType(Me.erpIndikatorGreske, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdListaStavki, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdStavke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkKnjizeno As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBroj As System.Windows.Forms.TextBox
    Friend WithEvents txtJM As System.Windows.Forms.TextBox
    Friend WithEvents txtKolicina As System.Windows.Forms.TextBox
    Friend WithEvents mnuPrijemnica As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ttForma As System.Windows.Forms.ToolTip
    Friend WithEvents tmrDelay As System.Windows.Forms.Timer
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBrojUlaznogDokumenta As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNapomena As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPrevoznik As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtVozilo As System.Windows.Forms.TextBox
    Friend WithEvents chkKalkulacija As System.Windows.Forms.CheckBox
    Friend WithEvents dtpDatum As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDatumUlaza As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDisp As System.Windows.Forms.Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtBrojKalkulacije As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents mnuAzurirajRbr As ToolStripMenuItem
    Friend WithEvents mnuBrisanje As ToolStripMenuItem
    Friend WithEvents TmrIndikatorGreske As Timer
    Friend WithEvents erpIndikatorGreske As ErrorProvider
    Friend WithEvents ImgTasteri As ImageList
    Friend WithEvents ChkVeleprodaja As CheckBox
    Friend WithEvents ChkMaloprodaja As CheckBox
    Friend WithEvents ChkUvoz As CheckBox
    Friend WithEvents grdStavke As myDataGridView
    Friend WithEvents TxtSifraMagacina As TextBox
    Friend WithEvents txtNazivDobavljaca As TextBox
    Friend WithEvents txtSifraDobavljaca As TextBox
    Friend WithEvents TxtNazivArtikla As TextBox
    Friend WithEvents txtSifraArtikla As TextBox
    Friend WithEvents CmbMagacin As ComboBox
    Friend WithEvents grdLista As DataGridView
    Friend WithEvents GrdListaStavki As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents mnuSortiranjeAZ As ToolStripMenuItem
    Friend WithEvents mnuSortiranjeZA As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents cmdStampa As Button
    Friend WithEvents cmdKnjizenje As Button
    Friend WithEvents CmdSnimi As Button
    Friend WithEvents CmdNovi As Button
    Friend WithEvents Label1 As Label
End Class
