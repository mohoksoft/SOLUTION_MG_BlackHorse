<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPredajnica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPredajnica))
        Me.txtNapomena = New System.Windows.Forms.TextBox()
        Me.chkKnjizeno = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ttForma = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmrDelay = New System.Windows.Forms.Timer(Me.components)
        Me.TmrIndikatorGreske = New System.Windows.Forms.Timer(Me.components)
        Me.erpIndikatorGreske = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBroj = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtBrojFinansijskogNaloga = New System.Windows.Forms.TextBox()
        Me.DtpDatumKnjizenja = New System.Windows.Forms.DateTimePicker()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.DtpDatumRadnogNaloga = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSifraMagacina = New System.Windows.Forms.TextBox()
        Me.grdStavke = New SOLUTION_MG_BlackHorse.myDataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBrojRadnogNaloga = New System.Windows.Forms.TextBox()
        Me.dtpDatum = New System.Windows.Forms.DateTimePicker()
        Me.mnuOtpremnica = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBrisanje = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAzurirajRbr = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CmbMagacin = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblDisp = New System.Windows.Forms.Label()
        Me.cmdStampa = New System.Windows.Forms.Button()
        Me.cmdKnjizenje = New System.Windows.Forms.Button()
        Me.CmdSnimi = New System.Windows.Forms.Button()
        CType(Me.erpIndikatorGreske, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdStavke, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuOtpremnica.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNapomena
        '
        Me.txtNapomena.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNapomena.Location = New System.Drawing.Point(33, 153)
        Me.txtNapomena.Name = "txtNapomena"
        Me.txtNapomena.Size = New System.Drawing.Size(855, 26)
        Me.txtNapomena.TabIndex = 668
        '
        'chkKnjizeno
        '
        Me.chkKnjizeno.AutoSize = True
        Me.chkKnjizeno.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.chkKnjizeno.Enabled = False
        Me.chkKnjizeno.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkKnjizeno.ForeColor = System.Drawing.Color.SkyBlue
        Me.chkKnjizeno.Location = New System.Drawing.Point(790, 45)
        Me.chkKnjizeno.Name = "chkKnjizeno"
        Me.chkKnjizeno.Size = New System.Drawing.Size(15, 14)
        Me.chkKnjizeno.TabIndex = 667
        Me.chkKnjizeno.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(103, 83)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 19)
        Me.Label4.TabIndex = 666
        Me.Label4.Text = "Datum"
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
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(31, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 19)
        Me.Label2.TabIndex = 665
        Me.Label2.Text = "Broj"
        '
        'txtBroj
        '
        Me.txtBroj.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBroj.Location = New System.Drawing.Point(33, 103)
        Me.txtBroj.Name = "txtBroj"
        Me.txtBroj.ReadOnly = True
        Me.txtBroj.Size = New System.Drawing.Size(65, 26)
        Me.txtBroj.TabIndex = 664
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(31, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 19)
        Me.Label1.TabIndex = 663
        Me.Label1.Text = "Magacin"
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(549, 82)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(72, 19)
        Me.Label28.TabIndex = 690
        Me.Label28.Text = "Fin. nalog"
        '
        'txtBrojFinansijskogNaloga
        '
        Me.txtBrojFinansijskogNaloga.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBrojFinansijskogNaloga.BackColor = System.Drawing.SystemColors.Control
        Me.txtBrojFinansijskogNaloga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBrojFinansijskogNaloga.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrojFinansijskogNaloga.Location = New System.Drawing.Point(552, 103)
        Me.txtBrojFinansijskogNaloga.Name = "txtBrojFinansijskogNaloga"
        Me.txtBrojFinansijskogNaloga.ReadOnly = True
        Me.txtBrojFinansijskogNaloga.Size = New System.Drawing.Size(100, 26)
        Me.txtBrojFinansijskogNaloga.TabIndex = 689
        '
        'DtpDatumKnjizenja
        '
        Me.DtpDatumKnjizenja.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpDatumKnjizenja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDatumKnjizenja.Location = New System.Drawing.Point(779, 103)
        Me.DtpDatumKnjizenja.Name = "DtpDatumKnjizenja"
        Me.DtpDatumKnjizenja.Size = New System.Drawing.Size(109, 26)
        Me.DtpDatumKnjizenja.TabIndex = 688
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(775, 81)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(113, 19)
        Me.Label25.TabIndex = 687
        Me.Label25.Text = "Datum knjizenja"
        '
        'DtpDatumRadnogNaloga
        '
        Me.DtpDatumRadnogNaloga.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpDatumRadnogNaloga.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDatumRadnogNaloga.Location = New System.Drawing.Point(661, 103)
        Me.DtpDatumRadnogNaloga.Name = "DtpDatumRadnogNaloga"
        Me.DtpDatumRadnogNaloga.Size = New System.Drawing.Size(109, 26)
        Me.DtpDatumRadnogNaloga.TabIndex = 686
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(658, 83)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 19)
        Me.Label3.TabIndex = 685
        Me.Label3.Text = "Datum RN"
        '
        'txtSifraMagacina
        '
        Me.txtSifraMagacina.Enabled = False
        Me.txtSifraMagacina.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSifraMagacina.Location = New System.Drawing.Point(34, 43)
        Me.txtSifraMagacina.Name = "txtSifraMagacina"
        Me.txtSifraMagacina.Size = New System.Drawing.Size(64, 26)
        Me.txtSifraMagacina.TabIndex = 662
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
        Me.grdStavke.Location = New System.Drawing.Point(26, 208)
        Me.grdStavke.Name = "grdStavke"
        Me.grdStavke.PoslednjaKolona = CType(5, Short)
        Me.grdStavke.PrvaKolona = CType(5, Short)
        Me.grdStavke.RowHeadersWidth = 20
        Me.grdStavke.Size = New System.Drawing.Size(869, 191)
        Me.grdStavke.TabIndex = 677
        Me.grdStavke.VertikalniSBUvekVidljiv = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(31, 130)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 19)
        Me.Label12.TabIndex = 669
        Me.Label12.Text = "Napomena"
        '
        'txtBrojRadnogNaloga
        '
        Me.txtBrojRadnogNaloga.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrojRadnogNaloga.Location = New System.Drawing.Point(443, 103)
        Me.txtBrojRadnogNaloga.Name = "txtBrojRadnogNaloga"
        Me.txtBrojRadnogNaloga.ReadOnly = True
        Me.txtBrojRadnogNaloga.Size = New System.Drawing.Size(100, 26)
        Me.txtBrojRadnogNaloga.TabIndex = 674
        Me.txtBrojRadnogNaloga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpDatum
        '
        Me.dtpDatum.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatum.Location = New System.Drawing.Point(104, 103)
        Me.dtpDatum.Name = "dtpDatum"
        Me.dtpDatum.Size = New System.Drawing.Size(109, 26)
        Me.dtpDatum.TabIndex = 670
        '
        'mnuOtpremnica
        '
        Me.mnuOtpremnica.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.mnuBrisanje, Me.mnuAzurirajRbr})
        Me.mnuOtpremnica.Name = "mnuUlaz"
        Me.mnuOtpremnica.Size = New System.Drawing.Size(190, 54)
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
        Me.mnuAzurirajRbr.Image = CType(resources.GetObject("mnuAzurirajRbr.Image"), System.Drawing.Image)
        Me.mnuAzurirajRbr.Name = "mnuAzurirajRbr"
        Me.mnuAzurirajRbr.Size = New System.Drawing.Size(189, 22)
        Me.mnuAzurirajRbr.Text = "Ažuriraj redne brojeve"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(439, 81)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 19)
        Me.Label18.TabIndex = 675
        Me.Label18.Text = "Radni nalog"
        '
        'CmbMagacin
        '
        Me.CmbMagacin.Enabled = False
        Me.CmbMagacin.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMagacin.FormattingEnabled = True
        Me.CmbMagacin.Location = New System.Drawing.Point(107, 43)
        Me.CmbMagacin.Name = "CmbMagacin"
        Me.CmbMagacin.Size = New System.Drawing.Size(288, 26)
        Me.CmbMagacin.TabIndex = 676
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(808, 42)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 19)
        Me.Label15.TabIndex = 673
        Me.Label15.Text = "Knjiženo"
        '
        'lblDisp
        '
        Me.lblDisp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDisp.BackColor = System.Drawing.Color.Transparent
        Me.lblDisp.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.lblDisp.Location = New System.Drawing.Point(399, 651)
        Me.lblDisp.Name = "lblDisp"
        Me.lblDisp.Size = New System.Drawing.Size(111, 19)
        Me.lblDisp.TabIndex = 671
        Me.lblDisp.Text = "0.00"
        Me.lblDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDisp.Visible = False
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
        Me.cmdStampa.Location = New System.Drawing.Point(191, 434)
        Me.cmdStampa.Name = "cmdStampa"
        Me.cmdStampa.Size = New System.Drawing.Size(130, 40)
        Me.cmdStampa.TabIndex = 692
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
        Me.cmdKnjizenje.Location = New System.Drawing.Point(35, 434)
        Me.cmdKnjizenje.Name = "cmdKnjizenje"
        Me.cmdKnjizenje.Size = New System.Drawing.Size(130, 40)
        Me.cmdKnjizenje.TabIndex = 691
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
        Me.CmdSnimi.Location = New System.Drawing.Point(783, 434)
        Me.CmdSnimi.Name = "CmdSnimi"
        Me.CmdSnimi.Size = New System.Drawing.Size(105, 40)
        Me.CmdSnimi.TabIndex = 693
        Me.CmdSnimi.Text = "Snimi"
        Me.CmdSnimi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSnimi.UseVisualStyleBackColor = False
        '
        'FrmPredajnica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(920, 500)
        Me.Controls.Add(Me.CmdSnimi)
        Me.Controls.Add(Me.cmdStampa)
        Me.Controls.Add(Me.cmdKnjizenje)
        Me.Controls.Add(Me.txtNapomena)
        Me.Controls.Add(Me.chkKnjizeno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBroj)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtBrojFinansijskogNaloga)
        Me.Controls.Add(Me.DtpDatumKnjizenja)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.DtpDatumRadnogNaloga)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSifraMagacina)
        Me.Controls.Add(Me.grdStavke)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtBrojRadnogNaloga)
        Me.Controls.Add(Me.dtpDatum)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.CmbMagacin)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblDisp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPredajnica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PREDAJNICA"
        CType(Me.erpIndikatorGreske, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdStavke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuOtpremnica.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNapomena As TextBox
    Friend WithEvents chkKnjizeno As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ttForma As ToolTip
    Friend WithEvents tmrDelay As Timer
    Friend WithEvents TmrIndikatorGreske As Timer
    Friend WithEvents erpIndikatorGreske As ErrorProvider
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBroj As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents txtBrojFinansijskogNaloga As TextBox
    Friend WithEvents DtpDatumKnjizenja As DateTimePicker
    Friend WithEvents Label25 As Label
    Friend WithEvents DtpDatumRadnogNaloga As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSifraMagacina As TextBox
    Friend WithEvents grdStavke As myDataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBrojRadnogNaloga As TextBox
    Friend WithEvents dtpDatum As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents CmbMagacin As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents lblDisp As Label
    Friend WithEvents mnuOtpremnica As ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuBrisanje As ToolStripMenuItem
    Friend WithEvents mnuAzurirajRbr As ToolStripMenuItem
    Friend WithEvents cmdStampa As Button
    Friend WithEvents cmdKnjizenje As Button
    Friend WithEvents CmdSnimi As Button
End Class
