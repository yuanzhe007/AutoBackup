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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Stop1 = New Button()
        programConsole = New GroupBox()
        Start1 = New Button()
        Options = New GroupBox()
        Button6 = New Button()
        Button3 = New Button()
        NumericUpDown5 = New NumericUpDown()
        Button2 = New Button()
        ButtonSaveAs = New Button()
        GroupBox1 = New GroupBox()
        Button5 = New Button()
        Label14 = New Label()
        TextBox4 = New TextBox()
        Button4 = New Button()
        Label13 = New Label()
        Label8 = New Label()
        NumericUpDown4 = New NumericUpDown()
        NumericUpDown3 = New NumericUpDown()
        Label6 = New Label()
        NumericUpDown1 = New NumericUpDown()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        TextBox3 = New TextBox()
        Label9 = New Label()
        CheckBox1 = New CheckBox()
        ButtonSelectFile = New Button()
        Label7 = New Label()
        NumericUpDown2 = New NumericUpDown()
        Label5 = New Label()
        Label4 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        quit1 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label15 = New Label()
        programConsole.SuspendLayout()
        Options.SuspendLayout()
        CType(NumericUpDown5, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(NumericUpDown4, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Stop1
        ' 
        Stop1.Location = New Point(6, 22)
        Stop1.Name = "Stop1"
        Stop1.Size = New Size(90, 29)
        Stop1.TabIndex = 0
        Stop1.Text = "停止运行"
        Stop1.UseVisualStyleBackColor = True
        ' 
        ' programConsole
        ' 
        programConsole.Controls.Add(Start1)
        programConsole.Controls.Add(Stop1)
        programConsole.Location = New Point(12, 264)
        programConsole.Name = "programConsole"
        programConsole.Size = New Size(235, 64)
        programConsole.TabIndex = 1
        programConsole.TabStop = False
        programConsole.Text = "程序操作"
        ' 
        ' Start1
        ' 
        Start1.Location = New Point(139, 22)
        Start1.Name = "Start1"
        Start1.Size = New Size(90, 29)
        Start1.TabIndex = 1
        Start1.Text = "启动"
        Start1.UseVisualStyleBackColor = True
        ' 
        ' Options
        ' 
        Options.Controls.Add(Button6)
        Options.Controls.Add(Button3)
        Options.Controls.Add(NumericUpDown5)
        Options.Controls.Add(Button2)
        Options.Controls.Add(ButtonSaveAs)
        Options.Controls.Add(GroupBox1)
        Options.Controls.Add(Label12)
        Options.Controls.Add(Label11)
        Options.Controls.Add(Label10)
        Options.Controls.Add(TextBox3)
        Options.Controls.Add(Label9)
        Options.Controls.Add(CheckBox1)
        Options.Controls.Add(ButtonSelectFile)
        Options.Controls.Add(Label7)
        Options.Controls.Add(NumericUpDown2)
        Options.Controls.Add(Label5)
        Options.Controls.Add(Label4)
        Options.Controls.Add(TextBox2)
        Options.Controls.Add(TextBox1)
        Options.Controls.Add(Label3)
        Options.Location = New Point(12, 12)
        Options.Name = "Options"
        Options.Size = New Size(616, 246)
        Options.TabIndex = 2
        Options.TabStop = False
        Options.Text = "设置"
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(584, 62)
        Button6.Name = "Button6"
        Button6.Size = New Size(26, 26)
        Button6.TabIndex = 23
        Button6.Text = "..."
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(584, 23)
        Button3.Name = "Button3"
        Button3.Size = New Size(26, 26)
        Button3.TabIndex = 22
        Button3.Text = "..."
        Button3.UseVisualStyleBackColor = True
        ' 
        ' NumericUpDown5
        ' 
        NumericUpDown5.Location = New Point(370, 158)
        NumericUpDown5.Maximum = New Decimal(New Integer() {Integer.MaxValue, 0, 0, 0})
        NumericUpDown5.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown5.Name = "NumericUpDown5"
        NumericUpDown5.Size = New Size(39, 23)
        NumericUpDown5.TabIndex = 10
        NumericUpDown5.Value = New Decimal(New Integer() {3, 0, 0, 0})
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(501, 200)
        Button2.Name = "Button2"
        Button2.Size = New Size(109, 23)
        Button2.TabIndex = 21
        Button2.Text = "应用"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ButtonSaveAs
        ' 
        ButtonSaveAs.Location = New Point(241, 210)
        ButtonSaveAs.Name = "ButtonSaveAs"
        ButtonSaveAs.Size = New Size(89, 23)
        ButtonSaveAs.TabIndex = 20
        ButtonSaveAs.Text = "导出配置文件"
        ButtonSaveAs.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(Label14)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(NumericUpDown4)
        GroupBox1.Controls.Add(NumericUpDown3)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(NumericUpDown1)
        GroupBox1.Location = New Point(16, 131)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 109)
        GroupBox1.TabIndex = 19
        GroupBox1.TabStop = False
        GroupBox1.Text = "时间计算器"
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(7, 79)
        Button5.Name = "Button5"
        Button5.Size = New Size(180, 24)
        Button5.TabIndex = 9
        Button5.Text = "应用到备份间隔时间"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(174, 54)
        Label14.Name = "Label14"
        Label14.Size = New Size(20, 17)
        Label14.TabIndex = 8
        Label14.Text = "秒"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(72, 51)
        TextBox4.Name = "TextBox4"
        TextBox4.PlaceholderText = "0"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 7
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(6, 51)
        Button4.Name = "Button4"
        Button4.Size = New Size(60, 22)
        Button4.TabIndex = 6
        Button4.Text = "计算"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(174, 24)
        Label13.Name = "Label13"
        Label13.Size = New Size(20, 17)
        Label13.TabIndex = 5
        Label13.Text = "秒"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(112, 24)
        Label8.Name = "Label8"
        Label8.Size = New Size(20, 17)
        Label8.TabIndex = 4
        Label8.Text = "分"
        ' 
        ' NumericUpDown4
        ' 
        NumericUpDown4.Location = New Point(72, 22)
        NumericUpDown4.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        NumericUpDown4.Name = "NumericUpDown4"
        NumericUpDown4.Size = New Size(34, 23)
        NumericUpDown4.TabIndex = 3
        ' 
        ' NumericUpDown3
        ' 
        NumericUpDown3.Location = New Point(135, 22)
        NumericUpDown3.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        NumericUpDown3.Name = "NumericUpDown3"
        NumericUpDown3.Size = New Size(34, 23)
        NumericUpDown3.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(46, 24)
        Label6.Name = "Label6"
        Label6.Size = New Size(20, 17)
        Label6.TabIndex = 1
        Label6.Text = "时"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(6, 22)
        NumericUpDown1.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(34, 23)
        NumericUpDown1.TabIndex = 0
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.ForeColor = Color.Blue
        Label12.Location = New Point(342, 160)
        Label12.Name = "Label12"
        Label12.Size = New Size(22, 17)
        Label12.TabIndex = 18
        Label12.Text = "(?)"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(241, 160)
        Label11.Name = "Label11"
        Label11.Size = New Size(104, 17)
        Label11.TabIndex = 17
        Label11.Text = "最大备份文件数量"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = Color.Gray
        Label10.Location = New Point(473, 226)
        Label10.Name = "Label10"
        Label10.Size = New Size(131, 17)
        Label10.TabIndex = 16
        Label10.Text = "重启程序才能应用设置."
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(313, 121)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "explorer.exe"
        TextBox3.Size = New Size(291, 23)
        TextBox3.TabIndex = 15
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(241, 124)
        Label9.Name = "Label9"
        Label9.Size = New Size(71, 17)
        Label9.TabIndex = 14
        Label9.Text = "目标程序名:"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(241, 100)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(346, 21)
        CheckBox1.TabIndex = 13
        CheckBox1.Text = "检测目标程序退出/崩溃 并自动保存备份到 recovery 文件夹"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' ButtonSelectFile
        ' 
        ButtonSelectFile.Location = New Point(501, 171)
        ButtonSelectFile.Name = "ButtonSelectFile"
        ButtonSelectFile.Size = New Size(109, 23)
        ButtonSelectFile.TabIndex = 12
        ButtonSelectFile.Text = "从配置文件读取"
        ButtonSelectFile.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(191, 104)
        Label7.Name = "Label7"
        Label7.Size = New Size(20, 17)
        Label7.TabIndex = 9
        Label7.Text = "秒"
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.Location = New Point(103, 102)
        NumericUpDown2.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(82, 23)
        NumericUpDown2.TabIndex = 6
        NumericUpDown2.Value = New Decimal(New Integer() {1800, 0, 0, 0})
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(16, 104)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 17)
        Label5.TabIndex = 4
        Label5.Text = "备份间隔时间"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 67)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 17)
        Label4.TabIndex = 3
        Label4.Text = "存储备份文件夹"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(104, 64)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "%APPDATA%\yzworkstation\backups"
        TextBox2.Size = New Size(474, 23)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(104, 25)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(474, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 28)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 17)
        Label3.TabIndex = 0
        Label3.Text = "目标备份文件夹"
        ' 
        ' quit1
        ' 
        quit1.Location = New Point(535, 299)
        quit1.Name = "quit1"
        quit1.Size = New Size(87, 29)
        quit1.TabIndex = 3
        quit1.Text = "退出并关闭"
        quit1.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(535, 264)
        Button1.Name = "Button1"
        Button1.Size = New Size(87, 29)
        Button1.TabIndex = 4
        Button1.Text = "关于"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(334, 282)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 17)
        Label1.TabIndex = 5
        Label1.Text = "AutoBackup 自动备份"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label2.Location = New Point(262, 302)
        Label2.Name = "Label2"
        Label2.Size = New Size(258, 16)
        Label2.TabIndex = 6
        Label2.Text = "Copyright © 2024 yzworkstation All rights reserved."
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(346, 302)
        Label15.Name = "Label15"
        Label15.Size = New Size(0, 17)
        Label15.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(640, 340)
        Controls.Add(Label15)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(quit1)
        Controls.Add(Options)
        Controls.Add(programConsole)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(656, 379)
        MinimumSize = New Size(656, 379)
        Name = "Form1"
        Text = "[AutoBackup] 自动备份 | By yzworkstation"
        programConsole.ResumeLayout(False)
        Options.ResumeLayout(False)
        Options.PerformLayout()
        CType(NumericUpDown5, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(NumericUpDown4, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Stop1 As Button
    Friend WithEvents programConsole As GroupBox
    Friend WithEvents Start1 As Button
    Friend WithEvents Options As GroupBox
    Friend WithEvents quit1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ButtonSelectFile As Button
    Friend WithEvents SaveConfig As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Button5 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents NumericUpDown4 As NumericUpDown
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonSaveAs As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents NumericUpDown5 As NumericUpDown
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label15 As Label

End Class
