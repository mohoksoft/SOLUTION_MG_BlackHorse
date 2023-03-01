<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLagerLista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLagerLista))
        Me.PanelNaslovni = New System.Windows.Forms.Panel()
        Me.cmdIzlaz = New System.Windows.Forms.Button()
        Me.cmbMagacin = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSifraMagacina = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmdStampa = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtGrupa = New System.Windows.Forms.TextBox()
        Me.chkNaStanju = New System.Windows.Forms.CheckBox()
        Me.ChkSviArtikli = New System.Windows.Forms.CheckBox()
        Me.ChkSaCenom = New System.Windows.Forms.CheckBox()
        Me.lblDisp = New System.Windows.Forms.Label()
        Me.ttForma = New System.Windows.Forms.ToolTip(Me.components)
        Me.grdStavke = New SOLUTION_MG_BlackHorse.myDataGridView()
        Label17 = New System.Windows.Forms.Label()
        Me.PanelNaslovni.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.grdStavke, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Label17.Size = New System.Drawing.Size(149, 25)
        Label17.TabIndex = 283
        Label17.Text = "LAGER LISTA"
        '
        'PanelNaslovni
        '
        Me.PanelNaslovni.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelNaslovni.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.PanelNaslovni.Controls.Add(Me.cmdIzlaz)
        Me.PanelNaslovni.Controls.Add(Label17)
        Me.PanelNaslovni.Location = New System.Drawing.Point(0, 0)
        Me.PanelNaslovni.Name = "PanelNaslovni"
        Me.PanelNaslovni.Size = New System.Drawing.Size(1180, 40)
        Me.PanelNaslovni.TabIndex = 441
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
        Me.cmdIzlaz.Location = New System.Drawing.Point(1138, 5)
        Me.cmdIzlaz.Name = "cmdIzlaz"
        Me.cmdIzlaz.Size = New System.Drawing.Size(30, 30)
        Me.cmdIzlaz.TabIndex = 285
        Me.cmdIzlaz.UseVisualStyleBackColor = False
        '
        'cmbMagacin
        '
        Me.cmbMagacin.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMagacin.FormattingEnabled = True
        Me.cmbMagacin.Location = New System.Drawing.Point(92, 70)
        Me.cmbMagacin.Name = "cmbMagacin"
        Me.cmbMagacin.Size = New System.Drawing.Size(295, 26)
        Me.cmbMagacin.TabIndex = 440
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 19)
        Me.Label1.TabIndex = 439
        Me.Label1.Text = "Magacin"
        '
        'txtSifraMagacina
        '
        Me.txtSifraMagacina.Enabled = False
        Me.txtSifraMagacina.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSifraMagacina.Location = New System.Drawing.Point(16, 70)
        Me.txtSifraMagacina.Name = "txtSifraMagacina"
        Me.txtSifraMagacina.Size = New System.Drawing.Size(65, 26)
        Me.txtSifraMagacina.TabIndex = 438
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.cmdStampa)
        Me.Panel3.Location = New System.Drawing.Point(0, 675)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1180, 40)
        Me.Panel3.TabIndex = 679
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(525, 40)
        Me.Panel4.TabIndex = 297
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(655, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(525, 40)
        Me.Panel2.TabIndex = 296
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
        Me.cmdStampa.Location = New System.Drawing.Point(530, 0)
        Me.cmdStampa.Name = "cmdStampa"
        Me.cmdStampa.Size = New System.Drawing.Size(120, 40)
        Me.cmdStampa.TabIndex = 293
        Me.cmdStampa.Text = "Štampa"
        Me.cmdStampa.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(413, 47)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 19)
        Me.Label4.TabIndex = 681
        Me.Label4.Text = "Početni broj šifre"
        '
        'TxtGrupa
        '
        Me.TxtGrupa.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtGrupa.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGrupa.Location = New System.Drawing.Point(417, 69)
        Me.TxtGrupa.Name = "TxtGrupa"
        Me.TxtGrupa.Size = New System.Drawing.Size(128, 27)
        Me.TxtGrupa.TabIndex = 680
        '
        'chkNaStanju
        '
        Me.chkNaStanju.AutoSize = True
        Me.chkNaStanju.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNaStanju.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.chkNaStanju.Location = New System.Drawing.Point(872, 70)
        Me.chkNaStanju.Name = "chkNaStanju"
        Me.chkNaStanju.Size = New System.Drawing.Size(124, 20)
        Me.chkNaStanju.TabIndex = 682
        Me.chkNaStanju.Text = "Na stanju (>0)"
        Me.chkNaStanju.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttForma.SetToolTip(Me.chkNaStanju, "Samo artikli koji su na stanju")
        Me.chkNaStanju.UseVisualStyleBackColor = True
        '
        'ChkSviArtikli
        '
        Me.ChkSviArtikli.AutoSize = True
        Me.ChkSviArtikli.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSviArtikli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ChkSviArtikli.Location = New System.Drawing.Point(595, 70)
        Me.ChkSviArtikli.Name = "ChkSviArtikli"
        Me.ChkSviArtikli.Size = New System.Drawing.Size(87, 20)
        Me.ChkSviArtikli.TabIndex = 683
        Me.ChkSviArtikli.Text = "Svi artikli"
        Me.ChkSviArtikli.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttForma.SetToolTip(Me.ChkSviArtikli, "Svi artkli u izabranom magacinu")
        Me.ChkSviArtikli.UseVisualStyleBackColor = True
        '
        'ChkSaCenom
        '
        Me.ChkSaCenom.AutoSize = True
        Me.ChkSaCenom.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSaCenom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ChkSaCenom.Location = New System.Drawing.Point(727, 70)
        Me.ChkSaCenom.Name = "ChkSaCenom"
        Me.ChkSaCenom.Size = New System.Drawing.Size(100, 20)
        Me.ChkSaCenom.TabIndex = 684
        Me.ChkSaCenom.Text = "Sa cenama"
        Me.ChkSaCenom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttForma.SetToolTip(Me.ChkSaCenom, "Pregled sa cenama")
        Me.ChkSaCenom.UseVisualStyleBackColor = True
        '
        'lblDisp
        '
        Me.lblDisp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDisp.BackColor = System.Drawing.Color.Transparent
        Me.lblDisp.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.lblDisp.Location = New System.Drawing.Point(1044, 645)
        Me.lblDisp.Name = "lblDisp"
        Me.lblDisp.Size = New System.Drawing.Size(111, 19)
        Me.lblDisp.TabIndex = 685
        Me.lblDisp.Text = "0.00"
        Me.lblDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDisp.Visible = False
        '
        'ttForma
        '
        Me.ttForma.IsBalloon = True
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
        Me.grdStavke.Location = New System.Drawing.Point(16, 107)
        Me.grdStavke.Name = "grdStavke"
        Me.grdStavke.PoslednjaKolona = CType(5, Short)
        Me.grdStavke.PrvaKolona = CType(5, Short)
        Me.grdStavke.RowHeadersWidth = 20
        Me.grdStavke.Size = New System.Drawing.Size(1140, 528)
        Me.grdStavke.TabIndex = 678
        Me.grdStavke.VertikalniSBUvekVidljiv = False
        '
        'FrmLagerLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1180, 715)
        Me.Controls.Add(Me.lblDisp)
        Me.Controls.Add(Me.ChkSaCenom)
        Me.Controls.Add(Me.ChkSviArtikli)
        Me.Controls.Add(Me.chkNaStanju)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtGrupa)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.grdStavke)
        Me.Controls.Add(Me.PanelNaslovni)
        Me.Controls.Add(Me.cmbMagacin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSifraMagacina)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLagerLista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmLagerLista"
        Me.PanelNaslovni.ResumeLayout(False)
        Me.PanelNaslovni.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.grdStavke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelNaslovni As Panel
    Friend WithEvents cmdIzlaz As Button
    Friend WithEvents cmbMagacin As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSifraMagacina As TextBox
    Friend WithEvents grdStavke As myDataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmdStampa As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtGrupa As TextBox
    Friend WithEvents chkNaStanju As CheckBox
    Friend WithEvents ChkSviArtikli As CheckBox
    Friend WithEvents ChkSaCenom As CheckBox
    Friend WithEvents lblDisp As Label
    Friend WithEvents ttForma As ToolTip
End Class
