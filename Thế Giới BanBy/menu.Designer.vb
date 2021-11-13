<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu2))
        Me.wmp = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.m1 = New System.Windows.Forms.PictureBox()
        Me.m2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.wmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'wmp
        '
        Me.wmp.Enabled = True
        Me.wmp.Location = New System.Drawing.Point(12, 643)
        Me.wmp.Name = "wmp"
        Me.wmp.OcxState = CType(resources.GetObject("wmp.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmp.Size = New System.Drawing.Size(10, 10)
        Me.wmp.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(129, 252)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(359, 120)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&Vào Games"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Aqua
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(216, 378)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(377, 109)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "&Thoát Games"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'm1
        '
        Me.m1.BackColor = System.Drawing.Color.Transparent
        Me.m1.BackgroundImage = CType(resources.GetObject("m1.BackgroundImage"), System.Drawing.Image)
        Me.m1.Location = New System.Drawing.Point(891, -20)
        Me.m1.Name = "m1"
        Me.m1.Size = New System.Drawing.Size(569, 241)
        Me.m1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.m1.TabIndex = 3
        Me.m1.TabStop = False
        '
        'm2
        '
        Me.m2.BackColor = System.Drawing.Color.Transparent
        Me.m2.BackgroundImage = CType(resources.GetObject("m2.BackgroundImage"), System.Drawing.Image)
        Me.m2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.m2.Cursor = System.Windows.Forms.Cursors.Default
        Me.m2.Location = New System.Drawing.Point(-193, 505)
        Me.m2.Name = "m2"
        Me.m2.Size = New System.Drawing.Size(489, 206)
        Me.m2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.m2.TabIndex = 4
        Me.m2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 200
        '
        'Timer2
        '
        Me.Timer2.Interval = 50000
        '
        'menu2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1219, 639)
        Me.Controls.Add(Me.m2)
        Me.Controls.Add(Me.m1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.wmp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "menu2"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thế Giới BanBy"
        CType(Me.wmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents wmp As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents m1 As System.Windows.Forms.PictureBox
    Friend WithEvents m2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
