<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        textboxuserid = New Guna.UI2.WinForms.Guna2TextBox()
        textboxpassword = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Guna2CheckBox1 = New Guna.UI2.WinForms.Guna2CheckBox()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges11
        Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), Image)
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(-6, -14)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2PictureBox1.Size = New Size(510, 660)
        Guna2PictureBox1.TabIndex = 0
        Guna2PictureBox1.TabStop = False
        ' 
        ' textboxuserid
        ' 
        textboxuserid.CustomizableEdges = CustomizableEdges13
        textboxuserid.DefaultText = ""
        textboxuserid.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        textboxuserid.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        textboxuserid.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        textboxuserid.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        textboxuserid.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        textboxuserid.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        textboxuserid.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        textboxuserid.Location = New Point(112, 239)
        textboxuserid.Name = "textboxuserid"
        textboxuserid.PasswordChar = ChrW(0)
        textboxuserid.PlaceholderText = "UserID"
        textboxuserid.SelectedText = ""
        textboxuserid.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        textboxuserid.Size = New Size(265, 45)
        textboxuserid.TabIndex = 3
        ' 
        ' textboxpassword
        ' 
        textboxpassword.CustomizableEdges = CustomizableEdges15
        textboxpassword.DefaultText = ""
        textboxpassword.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        textboxpassword.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        textboxpassword.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        textboxpassword.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        textboxpassword.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        textboxpassword.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        textboxpassword.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        textboxpassword.Location = New Point(112, 290)
        textboxpassword.Name = "textboxpassword"
        textboxpassword.PasswordChar = "●"c
        textboxpassword.PlaceholderText = "Password"
        textboxpassword.SelectedText = ""
        textboxpassword.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        textboxpassword.Size = New Size(265, 45)
        textboxpassword.TabIndex = 4
        textboxpassword.UseSystemPasswordChar = True
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.CustomBorderThickness = New Padding(2)
        Guna2Button1.CustomizableEdges = CustomizableEdges17
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Black
        Guna2Button1.Font = New Font("Trebuchet MS", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(112, 407)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        Guna2Button1.Size = New Size(265, 39)
        Guna2Button1.TabIndex = 5
        Guna2Button1.Text = "LOG IN"
        ' 
        ' Guna2CheckBox1
        ' 
        Guna2CheckBox1.AutoSize = True
        Guna2CheckBox1.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2CheckBox1.CheckedState.BorderRadius = 0
        Guna2CheckBox1.CheckedState.BorderThickness = 0
        Guna2CheckBox1.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2CheckBox1.Location = New Point(248, 341)
        Guna2CheckBox1.Name = "Guna2CheckBox1"
        Guna2CheckBox1.Size = New Size(129, 24)
        Guna2CheckBox1.TabIndex = 6
        Guna2CheckBox1.Text = "Remember me"
        Guna2CheckBox1.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2CheckBox1.UncheckedState.BorderRadius = 0
        Guna2CheckBox1.UncheckedState.BorderThickness = 0
        Guna2CheckBox1.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.CustomizableEdges = CustomizableEdges19
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = SystemColors.ControlDarkDark
        Guna2Button2.Font = New Font("Trebuchet MS", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2Button2.ForeColor = Color.White
        Guna2Button2.Location = New Point(112, 452)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        Guna2Button2.Size = New Size(265, 39)
        Guna2Button2.TabIndex = 7
        Guna2Button2.Text = "SIGN UP"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(482, 648)
        Controls.Add(Guna2Button2)
        Controls.Add(Guna2CheckBox1)
        Controls.Add(Guna2Button1)
        Controls.Add(textboxpassword)
        Controls.Add(textboxuserid)
        Controls.Add(Guna2PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        SizeGripStyle = SizeGripStyle.Show
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents textboxuserid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents textboxpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CheckBox1 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
End Class
