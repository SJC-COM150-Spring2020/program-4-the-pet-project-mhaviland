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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblVote = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDog = New System.Windows.Forms.Label()
        Me.lblCat = New System.Windows.Forms.Label()
        Me.lblBird = New System.Windows.Forms.Label()
        Me.lblFish = New System.Windows.Forms.Label()
        Me.lstOut = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.picDog = New System.Windows.Forms.PictureBox()
        Me.picCat = New System.Windows.Forms.PictureBox()
        Me.picFish = New System.Windows.Forms.PictureBox()
        Me.picBird = New System.Windows.Forms.PictureBox()
        Me.lblDirections = New System.Windows.Forms.Label()
        Me.lblPointsdog = New System.Windows.Forms.Label()
        Me.lblPointscat = New System.Windows.Forms.Label()
        Me.lblPointsfish = New System.Windows.Forms.Label()
        Me.lblPointsbird = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.picDog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVote
        '
        Me.lblVote.AutoSize = True
        Me.lblVote.Font = New System.Drawing.Font("Ravie", 32.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVote.ForeColor = System.Drawing.Color.Cyan
        Me.lblVote.Location = New System.Drawing.Point(2, 9)
        Me.lblVote.Name = "lblVote"
        Me.lblVote.Size = New System.Drawing.Size(850, 57)
        Me.lblVote.TabIndex = 0
        Me.lblVote.Text = "Vote for your favorite pet!"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Fuchsia
        Me.btnExit.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(37, 469)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(109, 52)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblDog
        '
        Me.lblDog.AutoSize = True
        Me.lblDog.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDog.Location = New System.Drawing.Point(6, 93)
        Me.lblDog.Name = "lblDog"
        Me.lblDog.Size = New System.Drawing.Size(73, 39)
        Me.lblDog.TabIndex = 6
        Me.lblDog.Text = "Dog"
        '
        'lblCat
        '
        Me.lblCat.AutoSize = True
        Me.lblCat.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCat.Location = New System.Drawing.Point(6, 191)
        Me.lblCat.Name = "lblCat"
        Me.lblCat.Size = New System.Drawing.Size(63, 39)
        Me.lblCat.TabIndex = 7
        Me.lblCat.Text = "Cat"
        '
        'lblBird
        '
        Me.lblBird.AutoSize = True
        Me.lblBird.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBird.Location = New System.Drawing.Point(3, 383)
        Me.lblBird.Name = "lblBird"
        Me.lblBird.Size = New System.Drawing.Size(75, 39)
        Me.lblBird.TabIndex = 8
        Me.lblBird.Text = "Bird"
        '
        'lblFish
        '
        Me.lblFish.AutoSize = True
        Me.lblFish.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFish.Location = New System.Drawing.Point(6, 290)
        Me.lblFish.Name = "lblFish"
        Me.lblFish.Size = New System.Drawing.Size(72, 39)
        Me.lblFish.TabIndex = 9
        Me.lblFish.Text = "Fish"
        '
        'lstOut
        '
        Me.lstOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOut.FormattingEnabled = True
        Me.lstOut.ItemHeight = 29
        Me.lstOut.Location = New System.Drawing.Point(360, 189)
        Me.lstOut.Name = "lstOut"
        Me.lstOut.Size = New System.Drawing.Size(148, 294)
        Me.lstOut.TabIndex = 14
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Aquamarine
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(195, 469)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 52)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Aquamarine
        Me.btnSubmit.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(545, 191)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(164, 131)
        Me.btnSubmit.TabIndex = 16
        Me.btnSubmit.Text = "Click to Vote Here!"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'picDog
        '
        Me.picDog.Image = CType(resources.GetObject("picDog.Image"), System.Drawing.Image)
        Me.picDog.Location = New System.Drawing.Point(145, 59)
        Me.picDog.Name = "picDog"
        Me.picDog.Size = New System.Drawing.Size(166, 93)
        Me.picDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDog.TabIndex = 17
        Me.picDog.TabStop = False
        '
        'picCat
        '
        Me.picCat.Image = CType(resources.GetObject("picCat.Image"), System.Drawing.Image)
        Me.picCat.Location = New System.Drawing.Point(164, 158)
        Me.picCat.Name = "picCat"
        Me.picCat.Size = New System.Drawing.Size(133, 98)
        Me.picCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCat.TabIndex = 18
        Me.picCat.TabStop = False
        '
        'picFish
        '
        Me.picFish.Image = CType(resources.GetObject("picFish.Image"), System.Drawing.Image)
        Me.picFish.Location = New System.Drawing.Point(142, 262)
        Me.picFish.Name = "picFish"
        Me.picFish.Size = New System.Drawing.Size(180, 92)
        Me.picFish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFish.TabIndex = 19
        Me.picFish.TabStop = False
        '
        'picBird
        '
        Me.picBird.Image = CType(resources.GetObject("picBird.Image"), System.Drawing.Image)
        Me.picBird.Location = New System.Drawing.Point(131, 360)
        Me.picBird.Name = "picBird"
        Me.picBird.Size = New System.Drawing.Size(191, 74)
        Me.picBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBird.TabIndex = 20
        Me.picBird.TabStop = False
        '
        'lblDirections
        '
        Me.lblDirections.AutoSize = True
        Me.lblDirections.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirections.ForeColor = System.Drawing.Color.MintCream
        Me.lblDirections.Location = New System.Drawing.Point(410, 78)
        Me.lblDirections.Name = "lblDirections"
        Me.lblDirections.Size = New System.Drawing.Size(458, 93)
        Me.lblDirections.TabIndex = 21
        Me.lblDirections.Text = "Directions:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Vote for your favorite pet by clicking " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the ""Click to Vote Here!"" " &
    "button."
        '
        'lblPointsdog
        '
        Me.lblPointsdog.AutoSize = True
        Me.lblPointsdog.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointsdog.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblPointsdog.Location = New System.Drawing.Point(85, 104)
        Me.lblPointsdog.Name = "lblPointsdog"
        Me.lblPointsdog.Size = New System.Drawing.Size(21, 24)
        Me.lblPointsdog.TabIndex = 22
        Me.lblPointsdog.Text = "0"
        '
        'lblPointscat
        '
        Me.lblPointscat.AutoSize = True
        Me.lblPointscat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointscat.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblPointscat.Location = New System.Drawing.Point(85, 202)
        Me.lblPointscat.Name = "lblPointscat"
        Me.lblPointscat.Size = New System.Drawing.Size(21, 24)
        Me.lblPointscat.TabIndex = 23
        Me.lblPointscat.Text = "0"
        '
        'lblPointsfish
        '
        Me.lblPointsfish.AutoSize = True
        Me.lblPointsfish.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointsfish.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblPointsfish.Location = New System.Drawing.Point(84, 301)
        Me.lblPointsfish.Name = "lblPointsfish"
        Me.lblPointsfish.Size = New System.Drawing.Size(21, 24)
        Me.lblPointsfish.TabIndex = 24
        Me.lblPointsfish.Text = "0"
        '
        'lblPointsbird
        '
        Me.lblPointsbird.AutoSize = True
        Me.lblPointsbird.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointsbird.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblPointsbird.Location = New System.Drawing.Point(84, 392)
        Me.lblPointsbird.Name = "lblPointsbird"
        Me.lblPointsbird.Size = New System.Drawing.Size(21, 24)
        Me.lblPointsbird.TabIndex = 25
        Me.lblPointsbird.Text = "0"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(545, 328)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(262, 205)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(871, 545)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblPointsbird)
        Me.Controls.Add(Me.lblPointsfish)
        Me.Controls.Add(Me.lblPointscat)
        Me.Controls.Add(Me.lblPointsdog)
        Me.Controls.Add(Me.lblDirections)
        Me.Controls.Add(Me.picBird)
        Me.Controls.Add(Me.picFish)
        Me.Controls.Add(Me.picCat)
        Me.Controls.Add(Me.picDog)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstOut)
        Me.Controls.Add(Me.lblFish)
        Me.Controls.Add(Me.lblBird)
        Me.Controls.Add(Me.lblCat)
        Me.Controls.Add(Me.lblDog)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblVote)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.Text = "Petproject"
        CType(Me.picDog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVote As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDog As Label
    Friend WithEvents lblCat As Label
    Friend WithEvents lblBird As Label
    Friend WithEvents lblFish As Label
    Friend WithEvents lstOut As ListBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents picDog As PictureBox
    Friend WithEvents picCat As PictureBox
    Friend WithEvents picFish As PictureBox
    Friend WithEvents picBird As PictureBox
    Friend WithEvents lblDirections As Label
    Friend WithEvents lblPointsdog As Label
    Friend WithEvents lblPointscat As Label
    Friend WithEvents lblPointsfish As Label
    Friend WithEvents lblPointsbird As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
