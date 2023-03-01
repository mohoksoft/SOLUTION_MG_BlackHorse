<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIzvestajStanja
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
        Dim Label17 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIzvestajStanja))
        Me.PanelNaslovni = New System.Windows.Forms.Panel()
        Me.cmdIzlaz = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grdStavke = New SOLUTION_MG_BlackHorse.myDataGridView()
        Label17 = New System.Windows.Forms.Label()
        Me.PanelNaslovni.SuspendLayout()
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
        Label17.Size = New System.Drawing.Size(198, 25)
        Label17.TabIndex = 283
        Label17.Text = "IZVEŠTAJ STANJA"
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
        Me.PanelNaslovni.Size = New System.Drawing.Size(700, 40)
        Me.PanelNaslovni.TabIndex = 518
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
        Me.cmdIzlaz.Location = New System.Drawing.Point(658, 5)
        Me.cmdIzlaz.Name = "cmdIzlaz"
        Me.cmdIzlaz.Size = New System.Drawing.Size(30, 30)
        Me.cmdIzlaz.TabIndex = 285
        Me.cmdIzlaz.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 459)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 40)
        Me.Panel1.TabIndex = 519
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
        Me.grdStavke.Location = New System.Drawing.Point(17, 53)
        Me.grdStavke.Name = "grdStavke"
        Me.grdStavke.PoslednjaKolona = CType(5, Short)
        Me.grdStavke.PrvaKolona = CType(5, Short)
        Me.grdStavke.RowHeadersWidth = 20
        Me.grdStavke.Size = New System.Drawing.Size(650, 400)
        Me.grdStavke.TabIndex = 549
        '
        'FrmIzvestajStanja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 500)
        Me.Controls.Add(Me.grdStavke)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelNaslovni)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmIzvestajStanja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmIzvestajStanja"
        Me.PanelNaslovni.ResumeLayout(False)
        Me.PanelNaslovni.PerformLayout()
        CType(Me.grdStavke, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelNaslovni As Panel
    Friend WithEvents cmdIzlaz As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents grdStavke As myDataGridView
End Class
