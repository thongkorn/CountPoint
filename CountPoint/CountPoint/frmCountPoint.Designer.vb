<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCountPoint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCountPoint))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnIncrement = New System.Windows.Forms.Button()
        Me.btnDecrement = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 256)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnRandom
        '
        Me.btnRandom.BackColor = System.Drawing.Color.ForestGreen
        Me.btnRandom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRandom.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRandom.ForeColor = System.Drawing.Color.White
        Me.btnRandom.Location = New System.Drawing.Point(291, 226)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(113, 42)
        Me.btnRandom.TabIndex = 1
        Me.btnRandom.Text = "สุ่มตัวเลข"
        Me.btnRandom.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnIncrement
        '
        Me.btnIncrement.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnIncrement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIncrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncrement.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnIncrement.ForeColor = System.Drawing.Color.White
        Me.btnIncrement.Location = New System.Drawing.Point(291, 79)
        Me.btnIncrement.Name = "btnIncrement"
        Me.btnIncrement.Size = New System.Drawing.Size(113, 42)
        Me.btnIncrement.TabIndex = 3
        Me.btnIncrement.Text = "เพิ่มคะแนน"
        Me.btnIncrement.UseVisualStyleBackColor = False
        '
        'btnDecrement
        '
        Me.btnDecrement.BackColor = System.Drawing.Color.Chocolate
        Me.btnDecrement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDecrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDecrement.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDecrement.ForeColor = System.Drawing.Color.White
        Me.btnDecrement.Location = New System.Drawing.Point(291, 127)
        Me.btnDecrement.Name = "btnDecrement"
        Me.btnDecrement.Size = New System.Drawing.Size(113, 42)
        Me.btnDecrement.TabIndex = 4
        Me.btnDecrement.Text = "ลดคะแนน"
        Me.btnDecrement.UseVisualStyleBackColor = False
        '
        'frmCountPoint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 285)
        Me.Controls.Add(Me.btnDecrement)
        Me.Controls.Add(Me.btnIncrement)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRandom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCountPoint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Counter Number with Images"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnRandom As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnIncrement As System.Windows.Forms.Button
    Friend WithEvents btnDecrement As System.Windows.Forms.Button

End Class
