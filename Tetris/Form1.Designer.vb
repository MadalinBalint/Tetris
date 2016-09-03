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
        Me.components = New System.ComponentModel.Container()
        Me.timerMove = New System.Windows.Forms.Timer(Me.components)
        Me.timerPaint = New System.Windows.Forms.Timer(Me.components)
        Me.panelInfo = New System.Windows.Forms.Panel()
        Me.lbNivel = New System.Windows.Forms.Label()
        Me.lbPiese = New System.Windows.Forms.Label()
        Me.lbScor = New System.Windows.Forms.Label()
        Me.lbLinii = New System.Windows.Forms.Label()
        Me.lbTimp = New System.Windows.Forms.Label()
        Me.lbUrmatoarea = New System.Windows.Forms.Label()
        Me.panelInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'timerMove
        '
        Me.timerMove.Enabled = True
        Me.timerMove.Interval = 500
        '
        'timerPaint
        '
        Me.timerPaint.Enabled = True
        Me.timerPaint.Interval = 50
        '
        'panelInfo
        '
        Me.panelInfo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.panelInfo.Controls.Add(Me.lbNivel)
        Me.panelInfo.Controls.Add(Me.lbPiese)
        Me.panelInfo.Controls.Add(Me.lbScor)
        Me.panelInfo.Controls.Add(Me.lbLinii)
        Me.panelInfo.Controls.Add(Me.lbTimp)
        Me.panelInfo.Controls.Add(Me.lbUrmatoarea)
        Me.panelInfo.Location = New System.Drawing.Point(566, 12)
        Me.panelInfo.Name = "panelInfo"
        Me.panelInfo.Size = New System.Drawing.Size(200, 625)
        Me.panelInfo.TabIndex = 0
        '
        'lbNivel
        '
        Me.lbNivel.AutoSize = True
        Me.lbNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNivel.Location = New System.Drawing.Point(63, 425)
        Me.lbNivel.Name = "lbNivel"
        Me.lbNivel.Size = New System.Drawing.Size(51, 20)
        Me.lbNivel.TabIndex = 5
        Me.lbNivel.Text = "Nivel"
        '
        'lbPiese
        '
        Me.lbPiese.AutoSize = True
        Me.lbPiese.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPiese.Location = New System.Drawing.Point(60, 230)
        Me.lbPiese.Name = "lbPiese"
        Me.lbPiese.Size = New System.Drawing.Size(56, 20)
        Me.lbPiese.TabIndex = 4
        Me.lbPiese.Text = "Piese"
        '
        'lbScor
        '
        Me.lbScor.AutoSize = True
        Me.lbScor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbScor.Location = New System.Drawing.Point(64, 360)
        Me.lbScor.Name = "lbScor"
        Me.lbScor.Size = New System.Drawing.Size(48, 20)
        Me.lbScor.TabIndex = 3
        Me.lbScor.Text = "Scor"
        '
        'lbLinii
        '
        Me.lbLinii.AutoSize = True
        Me.lbLinii.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLinii.Location = New System.Drawing.Point(66, 295)
        Me.lbLinii.Name = "lbLinii"
        Me.lbLinii.Size = New System.Drawing.Size(45, 20)
        Me.lbLinii.TabIndex = 2
        Me.lbLinii.Text = "Linii"
        '
        'lbTimp
        '
        Me.lbTimp.AutoSize = True
        Me.lbTimp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTimp.Location = New System.Drawing.Point(63, 165)
        Me.lbTimp.Name = "lbTimp"
        Me.lbTimp.Size = New System.Drawing.Size(50, 20)
        Me.lbTimp.TabIndex = 1
        Me.lbTimp.Text = "Timp"
        '
        'lbUrmatoarea
        '
        Me.lbUrmatoarea.AutoSize = True
        Me.lbUrmatoarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUrmatoarea.Location = New System.Drawing.Point(27, 26)
        Me.lbUrmatoarea.Name = "lbUrmatoarea"
        Me.lbUrmatoarea.Size = New System.Drawing.Size(147, 20)
        Me.lbUrmatoarea.TabIndex = 0
        Me.lbUrmatoarea.Text = "Piesa urmatoare"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 649)
        Me.Controls.Add(Me.panelInfo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Tetris"
        Me.panelInfo.ResumeLayout(False)
        Me.panelInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents timerMove As System.Windows.Forms.Timer
    Friend WithEvents timerPaint As Timer
    Friend WithEvents panelInfo As Panel
    Friend WithEvents lbLinii As Label
    Friend WithEvents lbTimp As Label
    Friend WithEvents lbUrmatoarea As Label
    Friend WithEvents lbNivel As Label
    Friend WithEvents lbPiese As Label
    Friend WithEvents lbScor As Label
End Class
