<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.tlp_game = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.nud_rows = New System.Windows.Forms.NumericUpDown()
        Me.nud_cols = New System.Windows.Forms.NumericUpDown()
        Me.btn_generate = New System.Windows.Forms.Button()
        Me.pcb_logo = New System.Windows.Forms.PictureBox()
        CType(Me.nud_rows, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_cols, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlp_game
        '
        Me.tlp_game.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlp_game.ColumnCount = 6
        Me.tlp_game.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlp_game.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlp_game.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlp_game.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlp_game.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlp_game.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlp_game.Location = New System.Drawing.Point(12, 69)
        Me.tlp_game.Name = "tlp_game"
        Me.tlp_game.RowCount = 6
        Me.tlp_game.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlp_game.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlp_game.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlp_game.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlp_game.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlp_game.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlp_game.Size = New System.Drawing.Size(460, 438)
        Me.tlp_game.TabIndex = 0
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.Location = New System.Drawing.Point(16, 513)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(75, 23)
        Me.btn_reset.TabIndex = 1
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'nud_rows
        '
        Me.nud_rows.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nud_rows.Location = New System.Drawing.Point(263, 516)
        Me.nud_rows.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.nud_rows.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_rows.Name = "nud_rows"
        Me.nud_rows.Size = New System.Drawing.Size(58, 20)
        Me.nud_rows.TabIndex = 2
        Me.nud_rows.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'nud_cols
        '
        Me.nud_cols.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nud_cols.Location = New System.Drawing.Point(327, 516)
        Me.nud_cols.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.nud_cols.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_cols.Name = "nud_cols"
        Me.nud_cols.Size = New System.Drawing.Size(58, 20)
        Me.nud_cols.TabIndex = 3
        Me.nud_cols.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'btn_generate
        '
        Me.btn_generate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_generate.Location = New System.Drawing.Point(391, 513)
        Me.btn_generate.Name = "btn_generate"
        Me.btn_generate.Size = New System.Drawing.Size(75, 23)
        Me.btn_generate.TabIndex = 4
        Me.btn_generate.Text = "Generate"
        Me.btn_generate.UseVisualStyleBackColor = True
        '
        'pcb_logo
        '
        Me.pcb_logo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcb_logo.Image = Global.CrossColoursVB.My.Resources.Resources.brainbashers
        Me.pcb_logo.Location = New System.Drawing.Point(12, 2)
        Me.pcb_logo.Name = "pcb_logo"
        Me.pcb_logo.Size = New System.Drawing.Size(460, 61)
        Me.pcb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcb_logo.TabIndex = 5
        Me.pcb_logo.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 548)
        Me.Controls.Add(Me.pcb_logo)
        Me.Controls.Add(Me.btn_generate)
        Me.Controls.Add(Me.nud_cols)
        Me.Controls.Add(Me.nud_rows)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.tlp_game)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(334, 405)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cross Colours VB"
        CType(Me.nud_rows, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_cols, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlp_game As TableLayoutPanel
    Friend WithEvents btn_reset As Button
    Friend WithEvents nud_rows As NumericUpDown
    Friend WithEvents nud_cols As NumericUpDown
    Friend WithEvents btn_generate As Button
    Friend WithEvents pcb_logo As PictureBox
End Class
