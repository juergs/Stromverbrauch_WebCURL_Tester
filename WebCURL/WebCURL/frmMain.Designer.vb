<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebCURL
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtCurl = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.sbar = New System.Windows.Forms.StatusStrip()
        Me.sLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtIP = New System.Windows.Forms.MaskedTextBox()
        Me.btnIPEnter = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.sbar.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(221, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 20)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Run"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'txtCurl
        '
        Me.txtCurl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtCurl.BackColor = System.Drawing.SystemColors.Info
        Me.txtCurl.Location = New System.Drawing.Point(0, -1)
        Me.txtCurl.Multiline = true
        Me.txtCurl.Name = "txtCurl"
        Me.txtCurl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCurl.Size = New System.Drawing.Size(377, 232)
        Me.txtCurl.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'sbar
        '
        Me.sbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sLabel, Me.sLabel2, Me.ToolStripStatusLabel3})
        Me.sbar.Location = New System.Drawing.Point(0, 288)
        Me.sbar.Name = "sbar"
        Me.sbar.Size = New System.Drawing.Size(377, 22)
        Me.sbar.TabIndex = 2
        '
        'sLabel
        '
        Me.sLabel.Name = "sLabel"
        Me.sLabel.Size = New System.Drawing.Size(312, 17)
        Me.sLabel.Spring = true
        Me.sLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sLabel2
        '
        Me.sLabel2.AutoSize = false
        Me.sLabel2.Name = "sLabel2"
        Me.sLabel2.Size = New System.Drawing.Size(50, 17)
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(0, 17)
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(299, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 20)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "&End"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(13, 20)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(106, 20)
        Me.txtIP.TabIndex = 4
        '
        'btnIPEnter
        '
        Me.btnIPEnter.Font = New System.Drawing.Font("Webdings", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2,Byte))
        Me.btnIPEnter.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnIPEnter.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnIPEnter.Location = New System.Drawing.Point(125, 18)
        Me.btnIPEnter.Name = "btnIPEnter"
        Me.btnIPEnter.Size = New System.Drawing.Size(24, 21)
        Me.btnIPEnter.TabIndex = 5
        Me.btnIPEnter.Text = "a"
        Me.btnIPEnter.UseVisualStyleBackColor = true
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnIPEnter)
        Me.GroupBox1.Controls.Add(Me.txtIP)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 232)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(377, 56)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = false
        '
        'WebCURL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 310)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.sbar)
        Me.Controls.Add(Me.txtCurl)
        Me.Name = "WebCURL"
        Me.Text = "WebCurl"
        Me.sbar.ResumeLayout(false)
        Me.sbar.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtCurl As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents sbar As StatusStrip
    Friend WithEvents sLabel As ToolStripStatusLabel
    Friend WithEvents sLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents Button2 As Button
    Friend WithEvents txtIP As MaskedTextBox
    Friend WithEvents btnIPEnter As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
