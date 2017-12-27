<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.fd_open = New System.Windows.Forms.OpenFileDialog()
        Me.CarbonFiberTheme1 = New PlugIn_Manager.CarbonFiberTheme()
        Me.lv_methods = New PlugIn_Manager.CarbonFiberListBox()
        Me.CarbonFiberLabel3 = New PlugIn_Manager.CarbonFiberLabel()
        Me.CarbonFiberLabel2 = New PlugIn_Manager.CarbonFiberLabel()
        Me.lv_classes = New PlugIn_Manager.CarbonFiberListBox()
        Me.cmd_run = New PlugIn_Manager.CarbonFiberButton()
        Me.cmd_close = New PlugIn_Manager.CarbonFiberButton()
        Me.cmd_open = New PlugIn_Manager.CarbonFiberButton()
        Me.txt_path = New PlugIn_Manager.CarbonFiberTextBox()
        Me.CarbonFiberLabel1 = New PlugIn_Manager.CarbonFiberLabel()
        Me.chk_args = New PlugIn_Manager.CarbonFiberCheckbox()
        Me.txt_args = New PlugIn_Manager.CarbonFiberTextBox()
        Me.CarbonFiberTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fd_open
        '
        Me.fd_open.Filter = "Only DLL files (*.dll)|*.dll"
        '
        'CarbonFiberTheme1
        '
        Me.CarbonFiberTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.CarbonFiberTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.CarbonFiberTheme1.Colors = New PlugIn_Manager.Bloom(-1) {}
        Me.CarbonFiberTheme1.Controls.Add(Me.txt_args)
        Me.CarbonFiberTheme1.Controls.Add(Me.chk_args)
        Me.CarbonFiberTheme1.Controls.Add(Me.lv_methods)
        Me.CarbonFiberTheme1.Controls.Add(Me.CarbonFiberLabel3)
        Me.CarbonFiberTheme1.Controls.Add(Me.CarbonFiberLabel2)
        Me.CarbonFiberTheme1.Controls.Add(Me.lv_classes)
        Me.CarbonFiberTheme1.Controls.Add(Me.cmd_run)
        Me.CarbonFiberTheme1.Controls.Add(Me.cmd_close)
        Me.CarbonFiberTheme1.Controls.Add(Me.cmd_open)
        Me.CarbonFiberTheme1.Controls.Add(Me.txt_path)
        Me.CarbonFiberTheme1.Controls.Add(Me.CarbonFiberLabel1)
        Me.CarbonFiberTheme1.Customization = ""
        Me.CarbonFiberTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CarbonFiberTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CarbonFiberTheme1.Icon = Nothing
        Me.CarbonFiberTheme1.Image = Nothing
        Me.CarbonFiberTheme1.Location = New System.Drawing.Point(0, 0)
        Me.CarbonFiberTheme1.Movable = True
        Me.CarbonFiberTheme1.Name = "CarbonFiberTheme1"
        Me.CarbonFiberTheme1.NoRounding = False
        Me.CarbonFiberTheme1.ShowIcon = False
        Me.CarbonFiberTheme1.Sizable = True
        Me.CarbonFiberTheme1.Size = New System.Drawing.Size(466, 454)
        Me.CarbonFiberTheme1.SmartBounds = True
        Me.CarbonFiberTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.CarbonFiberTheme1.TabIndex = 0
        Me.CarbonFiberTheme1.Text = "PlugIn Manager"
        Me.CarbonFiberTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.CarbonFiberTheme1.Transparent = False
        '
        'lv_methods
        '
        Me.lv_methods.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.lv_methods.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lv_methods.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lv_methods.FormattingEnabled = True
        Me.lv_methods.ItemHeight = 15
        Me.lv_methods.Location = New System.Drawing.Point(189, 128)
        Me.lv_methods.Name = "lv_methods"
        Me.lv_methods.Size = New System.Drawing.Size(253, 210)
        Me.lv_methods.TabIndex = 7
        '
        'CarbonFiberLabel3
        '
        Me.CarbonFiberLabel3.BackColor = System.Drawing.Color.Transparent
        Me.CarbonFiberLabel3.Colors = New PlugIn_Manager.Bloom(-1) {}
        Me.CarbonFiberLabel3.Customization = ""
        Me.CarbonFiberLabel3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CarbonFiberLabel3.Image = Nothing
        Me.CarbonFiberLabel3.Location = New System.Drawing.Point(189, 108)
        Me.CarbonFiberLabel3.Name = "CarbonFiberLabel3"
        Me.CarbonFiberLabel3.NoRounding = False
        Me.CarbonFiberLabel3.Size = New System.Drawing.Size(55, 14)
        Me.CarbonFiberLabel3.TabIndex = 6
        Me.CarbonFiberLabel3.Text = "Methods"
        Me.CarbonFiberLabel3.Transparent = True
        '
        'CarbonFiberLabel2
        '
        Me.CarbonFiberLabel2.BackColor = System.Drawing.Color.Transparent
        Me.CarbonFiberLabel2.Colors = New PlugIn_Manager.Bloom(-1) {}
        Me.CarbonFiberLabel2.Customization = ""
        Me.CarbonFiberLabel2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CarbonFiberLabel2.Image = Nothing
        Me.CarbonFiberLabel2.Location = New System.Drawing.Point(20, 108)
        Me.CarbonFiberLabel2.Name = "CarbonFiberLabel2"
        Me.CarbonFiberLabel2.NoRounding = False
        Me.CarbonFiberLabel2.Size = New System.Drawing.Size(96, 14)
        Me.CarbonFiberLabel2.TabIndex = 6
        Me.CarbonFiberLabel2.Text = "Classes (public)"
        Me.CarbonFiberLabel2.Transparent = True
        '
        'lv_classes
        '
        Me.lv_classes.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.lv_classes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lv_classes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lv_classes.FormattingEnabled = True
        Me.lv_classes.ItemHeight = 15
        Me.lv_classes.Location = New System.Drawing.Point(20, 128)
        Me.lv_classes.Name = "lv_classes"
        Me.lv_classes.Size = New System.Drawing.Size(151, 210)
        Me.lv_classes.TabIndex = 4
        '
        'cmd_run
        '
        Me.cmd_run.Colors = New PlugIn_Manager.Bloom(-1) {}
        Me.cmd_run.Customization = ""
        Me.cmd_run.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cmd_run.Image = Nothing
        Me.cmd_run.Location = New System.Drawing.Point(20, 396)
        Me.cmd_run.Name = "cmd_run"
        Me.cmd_run.NoRounding = False
        Me.cmd_run.Size = New System.Drawing.Size(422, 30)
        Me.cmd_run.TabIndex = 3
        Me.cmd_run.Text = "Run PlugIn"
        Me.cmd_run.Transparent = False
        '
        'cmd_close
        '
        Me.cmd_close.Colors = New PlugIn_Manager.Bloom(-1) {}
        Me.cmd_close.Customization = ""
        Me.cmd_close.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cmd_close.Image = Nothing
        Me.cmd_close.Location = New System.Drawing.Point(442, 4)
        Me.cmd_close.Name = "cmd_close"
        Me.cmd_close.NoRounding = False
        Me.cmd_close.Size = New System.Drawing.Size(18, 18)
        Me.cmd_close.TabIndex = 2
        Me.cmd_close.Text = "X"
        Me.cmd_close.Transparent = False
        '
        'cmd_open
        '
        Me.cmd_open.Colors = New PlugIn_Manager.Bloom(-1) {}
        Me.cmd_open.Customization = ""
        Me.cmd_open.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cmd_open.Image = Nothing
        Me.cmd_open.Location = New System.Drawing.Point(407, 64)
        Me.cmd_open.Name = "cmd_open"
        Me.cmd_open.NoRounding = False
        Me.cmd_open.Size = New System.Drawing.Size(35, 23)
        Me.cmd_open.TabIndex = 2
        Me.cmd_open.Text = "..."
        Me.cmd_open.Transparent = False
        '
        'txt_path
        '
        Me.txt_path.Colors = New PlugIn_Manager.Bloom(-1) {}
        Me.txt_path.Customization = ""
        Me.txt_path.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txt_path.Image = Nothing
        Me.txt_path.Location = New System.Drawing.Point(20, 63)
        Me.txt_path.MaxLength = 32767
        Me.txt_path.Multiline = False
        Me.txt_path.Name = "txt_path"
        Me.txt_path.NoRounding = False
        Me.txt_path.ReadOnly = False
        Me.txt_path.Size = New System.Drawing.Size(381, 24)
        Me.txt_path.TabIndex = 1
        Me.txt_path.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_path.Transparent = False
        Me.txt_path.UseSystemPasswordChar = False
        '
        'CarbonFiberLabel1
        '
        Me.CarbonFiberLabel1.BackColor = System.Drawing.Color.Transparent
        Me.CarbonFiberLabel1.Colors = New PlugIn_Manager.Bloom(-1) {}
        Me.CarbonFiberLabel1.Customization = ""
        Me.CarbonFiberLabel1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CarbonFiberLabel1.Image = Nothing
        Me.CarbonFiberLabel1.Location = New System.Drawing.Point(20, 43)
        Me.CarbonFiberLabel1.Name = "CarbonFiberLabel1"
        Me.CarbonFiberLabel1.NoRounding = False
        Me.CarbonFiberLabel1.Size = New System.Drawing.Size(136, 14)
        Me.CarbonFiberLabel1.TabIndex = 0
        Me.CarbonFiberLabel1.Text = "Path to managed DLL :"
        Me.CarbonFiberLabel1.Transparent = True
        '
        'chk_args
        '
        Me.chk_args.Checked = False
        Me.chk_args.Colors = New PlugIn_Manager.Bloom(-1) {}
        Me.chk_args.Customization = ""
        Me.chk_args.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.chk_args.Image = Nothing
        Me.chk_args.Location = New System.Drawing.Point(20, 353)
        Me.chk_args.MaximumSize = New System.Drawing.Size(600, 16)
        Me.chk_args.MinimumSize = New System.Drawing.Size(50, 16)
        Me.chk_args.Name = "chk_args"
        Me.chk_args.NoRounding = False
        Me.chk_args.Size = New System.Drawing.Size(107, 16)
        Me.chk_args.TabIndex = 8
        Me.chk_args.Text = "Use arguments"
        Me.chk_args.Transparent = False
        '
        'txt_args
        '
        Me.txt_args.Colors = New PlugIn_Manager.Bloom(-1) {}
        Me.txt_args.Customization = ""
        Me.txt_args.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txt_args.Image = Nothing
        Me.txt_args.Location = New System.Drawing.Point(20, 370)
        Me.txt_args.MaxLength = 32767
        Me.txt_args.Multiline = False
        Me.txt_args.Name = "txt_args"
        Me.txt_args.NoRounding = False
        Me.txt_args.ReadOnly = False
        Me.txt_args.Size = New System.Drawing.Size(422, 24)
        Me.txt_args.TabIndex = 9
        Me.txt_args.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_args.Transparent = False
        Me.txt_args.UseSystemPasswordChar = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 454)
        Me.Controls.Add(Me.CarbonFiberTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.CarbonFiberTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CarbonFiberTheme1 As CarbonFiberTheme
    Friend WithEvents cmd_run As CarbonFiberButton
    Friend WithEvents cmd_open As CarbonFiberButton
    Friend WithEvents txt_path As CarbonFiberTextBox
    Friend WithEvents CarbonFiberLabel1 As CarbonFiberLabel
    Friend WithEvents cmd_close As CarbonFiberButton
    Friend WithEvents fd_open As OpenFileDialog
    Friend WithEvents lv_classes As CarbonFiberListBox
    Friend WithEvents lv_methods As CarbonFiberListBox
    Friend WithEvents CarbonFiberLabel3 As CarbonFiberLabel
    Friend WithEvents CarbonFiberLabel2 As CarbonFiberLabel
    Friend WithEvents txt_args As CarbonFiberTextBox
    Friend WithEvents chk_args As CarbonFiberCheckbox
End Class
