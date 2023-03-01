<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSplash))
        Me.DetailsLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Version = New System.Windows.Forms.Label()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.MainLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.ApplicationTitle = New System.Windows.Forms.Label()
        Me.PanelMohokSoft = New System.Windows.Forms.Panel()
        Me.DetailsLayoutPanel.SuspendLayout()
        Me.MainLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'DetailsLayoutPanel
        '
        Me.DetailsLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DetailsLayoutPanel.BackColor = System.Drawing.Color.Transparent
        Me.DetailsLayoutPanel.ColumnCount = 1
        Me.DetailsLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247.0!))
        Me.DetailsLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
        Me.DetailsLayoutPanel.Controls.Add(Me.Version, 0, 0)
        Me.DetailsLayoutPanel.Controls.Add(Me.Copyright, 0, 1)
        Me.DetailsLayoutPanel.Location = New System.Drawing.Point(213, 221)
        Me.DetailsLayoutPanel.Name = "DetailsLayoutPanel"
        Me.DetailsLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.DetailsLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.DetailsLayoutPanel.Size = New System.Drawing.Size(271, 79)
        Me.DetailsLayoutPanel.TabIndex = 1
        '
        'Version
        '
        Me.Version.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.ForeColor = System.Drawing.Color.DarkGray
        Me.Version.Location = New System.Drawing.Point(16, 9)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(239, 20)
        Me.Version.TabIndex = 1
        Me.Version.Text = "Version {0}.{1:00}"
        Me.Version.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Copyright
        '
        Me.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.ForeColor = System.Drawing.Color.DarkGray
        Me.Copyright.Location = New System.Drawing.Point(16, 39)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(239, 40)
        Me.Copyright.TabIndex = 2
        Me.Copyright.Text = "Copyright"
        Me.Copyright.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MainLayoutPanel
        '
        Me.MainLayoutPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.MainLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainLayoutPanel.ColumnCount = 2
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202.0!))
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 294.0!))
        Me.MainLayoutPanel.Controls.Add(Me.DetailsLayoutPanel, 1, 1)
        Me.MainLayoutPanel.Controls.Add(Me.ApplicationTitle, 1, 0)
        Me.MainLayoutPanel.Controls.Add(Me.PanelMohokSoft, 0, 0)
        Me.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainLayoutPanel.Name = "MainLayoutPanel"
        Me.MainLayoutPanel.RowCount = 2
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218.0!))
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.MainLayoutPanel.Size = New System.Drawing.Size(496, 303)
        Me.MainLayoutPanel.TabIndex = 0
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
        Me.ApplicationTitle.Font = New System.Drawing.Font("Poppins Medium", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ApplicationTitle.Location = New System.Drawing.Point(211, 3)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New System.Drawing.Size(276, 212)
        Me.ApplicationTitle.TabIndex = 2
        Me.ApplicationTitle.Text = "Application Title"
        Me.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'PanelMohokSoft
        '
        Me.PanelMohokSoft.AutoScroll = True
        Me.PanelMohokSoft.BackColor = System.Drawing.Color.Transparent
        Me.PanelMohokSoft.BackgroundImage = CType(resources.GetObject("PanelMohokSoft.BackgroundImage"), System.Drawing.Image)
        Me.PanelMohokSoft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelMohokSoft.Location = New System.Drawing.Point(3, 3)
        Me.PanelMohokSoft.Name = "PanelMohokSoft"
        Me.PanelMohokSoft.Size = New System.Drawing.Size(111, 50)
        Me.PanelMohokSoft.TabIndex = 122
        '
        'FrmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 303)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSplash"
        Me.Opacity = 0.95R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.DetailsLayoutPanel.ResumeLayout(False)
        Me.MainLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DetailsLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents Copyright As System.Windows.Forms.Label
    Friend WithEvents MainLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ApplicationTitle As Label
    Friend WithEvents PanelMohokSoft As Panel
End Class
