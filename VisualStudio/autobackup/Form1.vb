Imports System.Configuration
Imports System.DirectoryServices.ActiveDirectory
Imports System.IO
Public Class Form1


    Private autobackuptime As Integer
    Private backupfolder As String
    Private traceprogram As String
    Private backupto As String
    Private delrange As Integer
    Private tracer As Boolean
    Private ConfigFileReadFolder As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadConfig("config.ini")
        If CheckBox1.Checked = False Then
            TextBox3.ReadOnly = True
        Else
            TextBox3.ReadOnly = False
        End If
        ShowConfigFile()
    End Sub

    Private Sub ShowConfigFile()
        TextBox1.Text = backupfolder
        TextBox2.Text = backupto
        NumericUpDown2.Value = autobackuptime
        CheckBox1.Checked = tracer
        TextBox3.Text = traceprogram
        If delrange = "0" Then
            delrange = 3
        End If
        NumericUpDown5.Value = delrange

    End Sub

    Private Sub ReadConfig(configFilePath As String)
        If File.Exists(configFilePath) Then
            Dim lines() As String = File.ReadAllLines(configFilePath)
            For Each line As String In lines
                Dim parts() As String = line.Split("="c)
                If parts.Length = 2 Then
                    Select Case parts(0).Trim().ToLower()
                        Case "autobackuptime"
                            Integer.TryParse(parts(1).Trim(), autobackuptime)
                        Case "backupfolder"
                            backupfolder = parts(1).Trim()
                        Case "traceprogram"
                            traceprogram = parts(1).Trim()
                        Case "backupto"
                            backupto = parts(1).Trim()
                        Case "delrange"
                            Integer.TryParse(parts(1).Trim(), delrange)
                        Case "tracer"
                            Boolean.TryParse(parts(1).Trim(), tracer)
                    End Select
                End If
            Next
        Else
            MessageBox.Show("配置文件未找到！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            TextBox3.ReadOnly = True
        End If
        If CheckBox1.Checked = True Then
            TextBox3.ReadOnly = False
        End If
        ApplyConfigFile()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        MsgBox("这个设定是保留的备份文件最大数量.如果设为5,则表明保存最近备份的5个文件,例如,现在已备份了第6次,那么首次备份的文件(第1次备份)将会被自动删除,以免导致备份文件过大. 此设置与 '检测目标程序‘ 不矛盾. '检测目标程序' 在发现程序退出后会自动保存最近的几次备份文件,但是保存的备份文件数量由此设置决定. 如果它设为5,那么它只会自动保存5个最近的备份文件.", 32, "帮助")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub ButtonSelectFile_Click(sender As Object, e As EventArgs) Handles ButtonSelectFile.Click
        Using openFileDialog As New OpenFileDialog
            openFileDialog.Filter = "INI files (*.ini)|*.ini|All files (*.*)|*.*"
            openFileDialog.Title = "选择配置文件"
            If openFileDialog.ShowDialog = DialogResult.OK Then
                ConfigFileReadFolder = openFileDialog.FileName
            End If
            ReadConfig(ConfigFileReadFolder)
        End Using
    End Sub

    Private Sub SaveConfigs()
        Dim configFilePath As String = "config.ini"
        Try
            Using writer As New StreamWriter(New FileStream(configFilePath, FileMode.Create, FileAccess.Write))
                writer.WriteLine("autobackuptime=" & autobackuptime)
                writer.WriteLine("backupfolder=" & backupfolder)
                writer.WriteLine("traceprogram=" & traceprogram)
                writer.WriteLine("backupto=" & backupto)
                writer.WriteLine("delrange=" & delrange)
                writer.WriteLine("tracer=" & tracer.ToString().ToLower())
            End Using
            MessageBox.Show("配置文件已保存！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("保存配置文件时出错: " & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ApplyConfigFile()
        SaveConfigs()
    End Sub

    Private Sub ButtonSaveAs_Click(sender As Object, e As EventArgs) Handles ButtonSaveAs.Click
        SaveConfigs()
        Using saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "INI files (*.ini)|*.ini|All files (*.*)|*.*"
            saveFileDialog.Title = "将配置文件另存为"
            saveFileDialog.DefaultExt = "ini"
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim sourceFilePath As String = Path.Combine(Directory.GetCurrentDirectory(), "config.ini")
                Dim destinationFilePath As String = saveFileDialog.FileName
                If File.Exists(sourceFilePath) Then
                    File.Copy(sourceFilePath, destinationFilePath, True)
                    MessageBox.Show("配置文件已成功另存为！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("运行目录下未找到 config.ini 文件！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Using
    End Sub

    Private Sub ApplyConfigFile()
        backupfolder = TextBox1.Text
        backupto = TextBox2.Text
        autobackuptime = NumericUpDown2.Value
        tracer = CheckBox1.Checked
        traceprogram = TextBox3.Text
        delrange = NumericUpDown5.Value

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox4.Text = NumericUpDown1.Value * 60 * 60 + NumericUpDown4.Value * 60 + NumericUpDown3.Value
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        NumericUpDown2.Value = TextBox4.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("AutoBackup by yzworkstation (20240812) ", 32, "关于")
    End Sub

    Private Sub quit1_Click(sender As Object, e As EventArgs) Handles quit1.Click
        Shell("stop.exe")
        Close()
    End Sub

    Private Sub Start1_Click(sender As Object, e As EventArgs) Handles Start1.Click
        Shell("autobackup-main.exe")
        MsgBox("程序已经启动.", 0, "信息")
    End Sub

    Private Sub Stop1_Click(sender As Object, e As EventArgs) Handles Stop1.Click
        Shell("stop.exe")
        MsgBox("程序已经停止.", 0, "信息")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using folderBrowserDialog As New FolderBrowserDialog()
            folderBrowserDialog.Description = "请选择一个文件夹"
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                TextBox1.Text = folderBrowserDialog.SelectedPath
            End If
        End Using
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Using folderBrowserDialog As New FolderBrowserDialog()
            folderBrowserDialog.Description = "请选择一个文件夹"
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                TextBox2.Text = folderBrowserDialog.SelectedPath
            End If
        End Using
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub NumericUpDown5_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown5.ValueChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

End Class
