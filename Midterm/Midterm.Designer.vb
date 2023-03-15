<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Midterm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Midterm))
        Me.picBuilding = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConv = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tbxIn = New System.Windows.Forms.TextBox()
        Me.rdiItM = New System.Windows.Forms.RadioButton()
        Me.rdiMtI = New System.Windows.Forms.RadioButton()
        Me.lblInst2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblResult2 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBuilding
        '
        Me.picBuilding.Image = CType(resources.GetObject("picBuilding.Image"), System.Drawing.Image)
        Me.picBuilding.Location = New System.Drawing.Point(32, 12)
        Me.picBuilding.Name = "picBuilding"
        Me.picBuilding.Size = New System.Drawing.Size(274, 211)
        Me.picBuilding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picBuilding.TabIndex = 0
        Me.picBuilding.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(361, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(372, 38)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Measurement Converter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(364, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please enter the size:"
        '
        'btnConv
        '
        Me.btnConv.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.btnConv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConv.Enabled = False
        Me.btnConv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConv.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConv.ForeColor = System.Drawing.Color.White
        Me.btnConv.Location = New System.Drawing.Point(32, 253)
        Me.btnConv.Name = "btnConv"
        Me.btnConv.Size = New System.Drawing.Size(274, 30)
        Me.btnConv.TabIndex = 3
        Me.btnConv.Text = "Convert"
        Me.btnConv.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(32, 296)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(274, 30)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(32, 339)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(274, 30)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'tbxIn
        '
        Me.tbxIn.BackColor = System.Drawing.Color.White
        Me.tbxIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxIn.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.tbxIn.Location = New System.Drawing.Point(542, 101)
        Me.tbxIn.Name = "tbxIn"
        Me.tbxIn.Size = New System.Drawing.Size(182, 30)
        Me.tbxIn.TabIndex = 6
        '
        'rdiItM
        '
        Me.rdiItM.AutoSize = True
        Me.rdiItM.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.rdiItM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdiItM.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdiItM.ForeColor = System.Drawing.Color.White
        Me.rdiItM.Location = New System.Drawing.Point(542, 164)
        Me.rdiItM.Name = "rdiItM"
        Me.rdiItM.Size = New System.Drawing.Size(152, 23)
        Me.rdiItM.TabIndex = 7
        Me.rdiItM.TabStop = True
        Me.rdiItM.Text = "Inches to Meters"
        Me.rdiItM.UseVisualStyleBackColor = False
        '
        'rdiMtI
        '
        Me.rdiMtI.AutoSize = True
        Me.rdiMtI.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.rdiMtI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdiMtI.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdiMtI.ForeColor = System.Drawing.Color.White
        Me.rdiMtI.Location = New System.Drawing.Point(542, 193)
        Me.rdiMtI.Name = "rdiMtI"
        Me.rdiMtI.Size = New System.Drawing.Size(152, 23)
        Me.rdiMtI.TabIndex = 8
        Me.rdiMtI.TabStop = True
        Me.rdiMtI.Text = "Meters to Inches"
        Me.rdiMtI.UseVisualStyleBackColor = False
        '
        'lblInst2
        '
        Me.lblInst2.AutoSize = True
        Me.lblInst2.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.lblInst2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInst2.ForeColor = System.Drawing.Color.White
        Me.lblInst2.Location = New System.Drawing.Point(375, 179)
        Me.lblInst2.Name = "lblInst2"
        Me.lblInst2.Size = New System.Drawing.Size(145, 19)
        Me.lblInst2.TabIndex = 9
        Me.lblInst2.Text = "Converting from..."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(368, 159)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(356, 64)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'lblResult2
        '
        Me.lblResult2.AutoSize = True
        Me.lblResult2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult2.Location = New System.Drawing.Point(369, 302)
        Me.lblResult2.Name = "lblResult2"
        Me.lblResult2.Size = New System.Drawing.Size(178, 24)
        Me.lblResult2.TabIndex = 11
        Me.lblResult2.Text = "Converted value: "
        Me.lblResult2.Visible = False
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.lblResult.Location = New System.Drawing.Point(538, 302)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(65, 24)
        Me.lblResult.TabIndex = 12
        Me.lblResult.Text = "value"
        Me.lblResult.Visible = False
        '
        'Midterm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(804, 401)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblResult2)
        Me.Controls.Add(Me.lblInst2)
        Me.Controls.Add(Me.rdiMtI)
        Me.Controls.Add(Me.rdiItM)
        Me.Controls.Add(Me.tbxIn)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picBuilding)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Midterm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Building Plans Conversion"
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBuilding As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConv As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents tbxIn As TextBox
    Friend WithEvents rdiItM As RadioButton
    Friend WithEvents rdiMtI As RadioButton
    Friend WithEvents lblInst2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblResult2 As Label
    Friend WithEvents lblResult As Label
End Class
