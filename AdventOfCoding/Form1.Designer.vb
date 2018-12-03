<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.tlpFull = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdDay11 = New System.Windows.Forms.Button()
        Me.lbDay11 = New System.Windows.Forms.Label()
        Me.tlpFull.SuspendLayout()
        Me.tlpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpFull
        '
        Me.tlpFull.ColumnCount = 1
        Me.tlpFull.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpFull.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpFull.Controls.Add(Me.tlpMain, 0, 0)
        Me.tlpFull.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFull.Location = New System.Drawing.Point(0, 0)
        Me.tlpFull.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpFull.Name = "tlpFull"
        Me.tlpFull.RowCount = 1
        Me.tlpFull.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpFull.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpFull.Size = New System.Drawing.Size(800, 450)
        Me.tlpFull.TabIndex = 0
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 2
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.Controls.Add(Me.cmdDay11, 0, 0)
        Me.tlpMain.Controls.Add(Me.lbDay11, 1, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 10
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpMain.Size = New System.Drawing.Size(800, 450)
        Me.tlpMain.TabIndex = 0
        '
        'cmdDay11
        '
        Me.cmdDay11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdDay11.Location = New System.Drawing.Point(3, 3)
        Me.cmdDay11.Name = "cmdDay11"
        Me.cmdDay11.Size = New System.Drawing.Size(394, 39)
        Me.cmdDay11.TabIndex = 0
        Me.cmdDay11.Text = "Day 1.1"
        Me.cmdDay11.UseVisualStyleBackColor = True
        '
        'lbDay11
        '
        Me.lbDay11.AutoSize = True
        Me.lbDay11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbDay11.Location = New System.Drawing.Point(403, 0)
        Me.lbDay11.Name = "lbDay11"
        Me.lbDay11.Size = New System.Drawing.Size(394, 45)
        Me.lbDay11.TabIndex = 1
        Me.lbDay11.Text = "Answer 1"
        Me.lbDay11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tlpFull)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.tlpFull.ResumeLayout(False)
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpFull As TableLayoutPanel
    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents cmdDay11 As Button
    Friend WithEvents lbDay11 As Label
End Class
