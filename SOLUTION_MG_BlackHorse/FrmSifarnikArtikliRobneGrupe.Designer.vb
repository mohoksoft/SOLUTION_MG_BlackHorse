<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSifarnikArtikliRobneGrupe
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
        Dim GrupaLabel As System.Windows.Forms.Label
        Dim NazivLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSifarnikArtikliRobneGrupe))
        Me.TxtSifraVrsteArtikla = New System.Windows.Forms.TextBox()
        Me.TxtSifraRobneGrupe = New System.Windows.Forms.TextBox()
        Me.cmbVrsta = New System.Windows.Forms.ComboBox()
        Me.TxtNazivRobneGrupe = New System.Windows.Forms.TextBox()
        Me.ChkPasivan = New System.Windows.Forms.CheckBox()
        Me.tmrDelay = New System.Windows.Forms.Timer(Me.components)
        Me.ttInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.TmrIndikatorGreske = New System.Windows.Forms.Timer(Me.components)
        Me.erpIndikatorGreske = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TxtNapomena = New System.Windows.Forms.TextBox()
        Me.CmdSnimi = New System.Windows.Forms.Button()
        Me.CmdNovi = New System.Windows.Forms.Button()
        GrupaLabel = New System.Windows.Forms.Label()
        NazivLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.erpIndikatorGreske, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrupaLabel
        '
        GrupaLabel.AutoSize = True
        GrupaLabel.BackColor = System.Drawing.Color.Transparent
        GrupaLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GrupaLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        GrupaLabel.Location = New System.Drawing.Point(30, 97)
        GrupaLabel.Name = "GrupaLabel"
        GrupaLabel.Size = New System.Drawing.Size(93, 16)
        GrupaLabel.TabIndex = 445
        GrupaLabel.Text = "Vrsta artikla:"
        '
        'NazivLabel
        '
        NazivLabel.AutoSize = True
        NazivLabel.BackColor = System.Drawing.Color.Transparent
        NazivLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NazivLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        NazivLabel.Location = New System.Drawing.Point(30, 165)
        NazivLabel.Name = "NazivLabel"
        NazivLabel.Size = New System.Drawing.Size(95, 16)
        NazivLabel.TabIndex = 444
        NazivLabel.Text = "Robna grupa:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Label2.Location = New System.Drawing.Point(30, 233)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(81, 16)
        Label2.TabIndex = 452
        Label2.Text = "Napomena:"
        '
        'TxtSifraVrsteArtikla
        '
        Me.TxtSifraVrsteArtikla.Enabled = False
        Me.TxtSifraVrsteArtikla.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSifraVrsteArtikla.Location = New System.Drawing.Point(276, 87)
        Me.TxtSifraVrsteArtikla.Name = "TxtSifraVrsteArtikla"
        Me.TxtSifraVrsteArtikla.ReadOnly = True
        Me.TxtSifraVrsteArtikla.Size = New System.Drawing.Size(57, 23)
        Me.TxtSifraVrsteArtikla.TabIndex = 448
        Me.TxtSifraVrsteArtikla.Tag = "2"
        Me.TxtSifraVrsteArtikla.Visible = False
        '
        'TxtSifraRobneGrupe
        '
        Me.TxtSifraRobneGrupe.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSifraRobneGrupe.Location = New System.Drawing.Point(244, 158)
        Me.TxtSifraRobneGrupe.Name = "TxtSifraRobneGrupe"
        Me.TxtSifraRobneGrupe.ReadOnly = True
        Me.TxtSifraRobneGrupe.Size = New System.Drawing.Size(89, 23)
        Me.TxtSifraRobneGrupe.TabIndex = 447
        Me.TxtSifraRobneGrupe.Tag = "2"
        '
        'cmbVrsta
        '
        Me.cmbVrsta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVrsta.FormattingEnabled = True
        Me.cmbVrsta.Location = New System.Drawing.Point(33, 116)
        Me.cmbVrsta.Name = "cmbVrsta"
        Me.cmbVrsta.Size = New System.Drawing.Size(300, 24)
        Me.cmbVrsta.TabIndex = 446
        '
        'TxtNazivRobneGrupe
        '
        Me.TxtNazivRobneGrupe.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNazivRobneGrupe.Location = New System.Drawing.Point(33, 190)
        Me.TxtNazivRobneGrupe.Name = "TxtNazivRobneGrupe"
        Me.TxtNazivRobneGrupe.Size = New System.Drawing.Size(300, 23)
        Me.TxtNazivRobneGrupe.TabIndex = 443
        Me.TxtNazivRobneGrupe.Tag = "2"
        '
        'ChkPasivan
        '
        Me.ChkPasivan.AutoSize = True
        Me.ChkPasivan.BackColor = System.Drawing.Color.Transparent
        Me.ChkPasivan.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkPasivan.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPasivan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ChkPasivan.Location = New System.Drawing.Point(257, 41)
        Me.ChkPasivan.Name = "ChkPasivan"
        Me.ChkPasivan.Size = New System.Drawing.Size(76, 20)
        Me.ChkPasivan.TabIndex = 449
        Me.ChkPasivan.Text = "Pasivan"
        Me.ChkPasivan.UseVisualStyleBackColor = False
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
        'TxtNapomena
        '
        Me.TxtNapomena.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNapomena.Location = New System.Drawing.Point(33, 252)
        Me.TxtNapomena.Multiline = True
        Me.TxtNapomena.Name = "TxtNapomena"
        Me.TxtNapomena.Size = New System.Drawing.Size(300, 65)
        Me.TxtNapomena.TabIndex = 451
        Me.TxtNapomena.Tag = "5"
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
        Me.CmdSnimi.Location = New System.Drawing.Point(228, 336)
        Me.CmdSnimi.Name = "CmdSnimi"
        Me.CmdSnimi.Size = New System.Drawing.Size(105, 40)
        Me.CmdSnimi.TabIndex = 461
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
        Me.CmdNovi.Location = New System.Drawing.Point(100, 336)
        Me.CmdNovi.Name = "CmdNovi"
        Me.CmdNovi.Size = New System.Drawing.Size(100, 40)
        Me.CmdNovi.TabIndex = 460
        Me.CmdNovi.Text = "Novi"
        Me.CmdNovi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdNovi.UseVisualStyleBackColor = False
        '
        'FrmSifarnikArtikliRobneGrupe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(375, 400)
        Me.Controls.Add(Me.CmdSnimi)
        Me.Controls.Add(Me.CmdNovi)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TxtNapomena)
        Me.Controls.Add(Me.ChkPasivan)
        Me.Controls.Add(Me.TxtSifraVrsteArtikla)
        Me.Controls.Add(Me.TxtSifraRobneGrupe)
        Me.Controls.Add(Me.cmbVrsta)
        Me.Controls.Add(GrupaLabel)
        Me.Controls.Add(NazivLabel)
        Me.Controls.Add(Me.TxtNazivRobneGrupe)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSifarnikArtikliRobneGrupe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ROBNE GRUPE"
        CType(Me.erpIndikatorGreske, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtSifraVrsteArtikla As TextBox
    Friend WithEvents TxtSifraRobneGrupe As TextBox
    Friend WithEvents cmbVrsta As ComboBox
    Friend WithEvents TxtNazivRobneGrupe As TextBox
    Friend WithEvents ChkPasivan As CheckBox
    Friend WithEvents tmrDelay As Timer
    Friend WithEvents ttInfo As ToolTip
    Friend WithEvents TmrIndikatorGreske As Timer
    Friend WithEvents erpIndikatorGreske As ErrorProvider
    Friend WithEvents TxtNapomena As TextBox
    Friend WithEvents CmdSnimi As Button
    Friend WithEvents CmdNovi As Button
End Class
