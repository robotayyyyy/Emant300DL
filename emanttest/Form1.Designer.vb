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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series11 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series12 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btConnect = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gbConnection = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lconnect = New System.Windows.Forms.Label()
        Me.cbPort = New System.Windows.Forms.ComboBox()
        Me.gbAin = New System.Windows.Forms.GroupBox()
        Me.bActiveAinF = New System.Windows.Forms.Button()
        Me.bActiveAinE = New System.Windows.Forms.Button()
        Me.gbAinF = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbAinF1 = New System.Windows.Forms.ComboBox()
        Me.cbAinF2 = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lAinValueF = New System.Windows.Forms.Label()
        Me.bActiveAinD = New System.Windows.Forms.Button()
        Me.bActiveAinC = New System.Windows.Forms.Button()
        Me.bActiveAinB = New System.Windows.Forms.Button()
        Me.bActiveAinA = New System.Windows.Forms.Button()
        Me.gbAinE = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbAinE1 = New System.Windows.Forms.ComboBox()
        Me.cbAinE2 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lAinValueE = New System.Windows.Forms.Label()
        Me.gbAinD = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbAinD1 = New System.Windows.Forms.ComboBox()
        Me.cbAinD2 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lAinValueD = New System.Windows.Forms.Label()
        Me.gbAinC = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbAinC1 = New System.Windows.Forms.ComboBox()
        Me.cbAinC2 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lAinValueC = New System.Windows.Forms.Label()
        Me.gbAinB = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbAinB1 = New System.Windows.Forms.ComboBox()
        Me.cbAinB2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lAinValueB = New System.Windows.Forms.Label()
        Me.gbAinA = New System.Windows.Forms.GroupBox()
        Me.cbAinA1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbAinA2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lAinValueA = New System.Windows.Forms.Label()
        Me.gbGraph = New System.Windows.Forms.GroupBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.rbGraph2 = New System.Windows.Forms.RadioButton()
        Me.rbGraph1 = New System.Windows.Forms.RadioButton()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.gbSetting = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbStart = New System.Windows.Forms.GroupBox()
        Me.lTimer = New System.Windows.Forms.Label()
        Me.bStartStop = New System.Windows.Forms.Button()
        Me.tbFileName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.bBrowse = New System.Windows.Forms.Button()
        Me.sfd1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.NumericUpDownPWNCircleDuty = New System.Windows.Forms.NumericUpDown()
        Me.btnPWM = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.NumericUpDownPWM = New System.Windows.Forms.NumericUpDown()
        Me.gbConnection.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAin.SuspendLayout()
        Me.gbAinF.SuspendLayout()
        Me.gbAinE.SuspendLayout()
        Me.gbAinD.SuspendLayout()
        Me.gbAinC.SuspendLayout()
        Me.gbAinB.SuspendLayout()
        Me.gbAinA.SuspendLayout()
        Me.gbGraph.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSetting.SuspendLayout()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbStart.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDownPWNCircleDuty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownPWM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btConnect
        '
        Me.btConnect.Location = New System.Drawing.Point(123, 26)
        Me.btConnect.Margin = New System.Windows.Forms.Padding(4)
        Me.btConnect.Name = "btConnect"
        Me.btConnect.Size = New System.Drawing.Size(129, 30)
        Me.btConnect.TabIndex = 0
        Me.btConnect.Text = "Connect"
        Me.btConnect.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'gbConnection
        '
        Me.gbConnection.Controls.Add(Me.PictureBox1)
        Me.gbConnection.Controls.Add(Me.lconnect)
        Me.gbConnection.Controls.Add(Me.cbPort)
        Me.gbConnection.Controls.Add(Me.btConnect)
        Me.gbConnection.Location = New System.Drawing.Point(9, 10)
        Me.gbConnection.Margin = New System.Windows.Forms.Padding(4)
        Me.gbConnection.Name = "gbConnection"
        Me.gbConnection.Padding = New System.Windows.Forms.Padding(4)
        Me.gbConnection.Size = New System.Drawing.Size(271, 185)
        Me.gbConnection.TabIndex = 5
        Me.gbConnection.TabStop = False
        Me.gbConnection.Text = "Connnection"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(97, 92)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 74)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lconnect
        '
        Me.lconnect.AutoSize = True
        Me.lconnect.Location = New System.Drawing.Point(67, 70)
        Me.lconnect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lconnect.Name = "lconnect"
        Me.lconnect.Size = New System.Drawing.Size(146, 17)
        Me.lconnect.TabIndex = 3
        Me.lconnect.Text = "Status : Disconnected"
        '
        'cbPort
        '
        Me.cbPort.FormattingEnabled = True
        Me.cbPort.Items.AddRange(New Object() {"COM0", "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10", "COM11", "COM12", "COM13", "COM14", "COM15", "COM16", "COM17", "COM18", "COM19", "COM20"})
        Me.cbPort.Location = New System.Drawing.Point(21, 26)
        Me.cbPort.Margin = New System.Windows.Forms.Padding(4)
        Me.cbPort.Name = "cbPort"
        Me.cbPort.Size = New System.Drawing.Size(92, 24)
        Me.cbPort.TabIndex = 2
        Me.cbPort.Text = "COM17"
        '
        'gbAin
        '
        Me.gbAin.Controls.Add(Me.bActiveAinF)
        Me.gbAin.Controls.Add(Me.bActiveAinE)
        Me.gbAin.Controls.Add(Me.gbAinF)
        Me.gbAin.Controls.Add(Me.bActiveAinD)
        Me.gbAin.Controls.Add(Me.bActiveAinC)
        Me.gbAin.Controls.Add(Me.bActiveAinB)
        Me.gbAin.Controls.Add(Me.bActiveAinA)
        Me.gbAin.Controls.Add(Me.gbAinE)
        Me.gbAin.Controls.Add(Me.gbAinD)
        Me.gbAin.Controls.Add(Me.gbAinC)
        Me.gbAin.Controls.Add(Me.gbAinB)
        Me.gbAin.Controls.Add(Me.gbAinA)
        Me.gbAin.Enabled = False
        Me.gbAin.Location = New System.Drawing.Point(288, 10)
        Me.gbAin.Margin = New System.Windows.Forms.Padding(4)
        Me.gbAin.Name = "gbAin"
        Me.gbAin.Padding = New System.Windows.Forms.Padding(4)
        Me.gbAin.Size = New System.Drawing.Size(1075, 196)
        Me.gbAin.TabIndex = 6
        Me.gbAin.TabStop = False
        Me.gbAin.Text = "Analog Input"
        '
        'bActiveAinF
        '
        Me.bActiveAinF.BackColor = System.Drawing.Color.Magenta
        Me.bActiveAinF.Location = New System.Drawing.Point(889, 21)
        Me.bActiveAinF.Margin = New System.Windows.Forms.Padding(4)
        Me.bActiveAinF.Name = "bActiveAinF"
        Me.bActiveAinF.Size = New System.Drawing.Size(168, 28)
        Me.bActiveAinF.TabIndex = 54
        Me.bActiveAinF.Text = "Active"
        Me.bActiveAinF.UseVisualStyleBackColor = False
        '
        'bActiveAinE
        '
        Me.bActiveAinE.BackColor = System.Drawing.Color.DarkViolet
        Me.bActiveAinE.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bActiveAinE.Location = New System.Drawing.Point(713, 23)
        Me.bActiveAinE.Margin = New System.Windows.Forms.Padding(4)
        Me.bActiveAinE.Name = "bActiveAinE"
        Me.bActiveAinE.Size = New System.Drawing.Size(168, 28)
        Me.bActiveAinE.TabIndex = 52
        Me.bActiveAinE.Text = "Active"
        Me.bActiveAinE.UseVisualStyleBackColor = False
        '
        'gbAinF
        '
        Me.gbAinF.Controls.Add(Me.Label14)
        Me.gbAinF.Controls.Add(Me.cbAinF1)
        Me.gbAinF.Controls.Add(Me.cbAinF2)
        Me.gbAinF.Controls.Add(Me.Label17)
        Me.gbAinF.Controls.Add(Me.lAinValueF)
        Me.gbAinF.Enabled = False
        Me.gbAinF.Location = New System.Drawing.Point(889, 62)
        Me.gbAinF.Margin = New System.Windows.Forms.Padding(4)
        Me.gbAinF.Name = "gbAinF"
        Me.gbAinF.Padding = New System.Windows.Forms.Padding(4)
        Me.gbAinF.Size = New System.Drawing.Size(168, 123)
        Me.gbAinF.TabIndex = 53
        Me.gbAinF.TabStop = False
        Me.gbAinF.Text = "Analog input F"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 30)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 17)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "AIN F+"
        '
        'cbAinF1
        '
        Me.cbAinF1.FormattingEnabled = True
        Me.cbAinF1.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8(COM)"})
        Me.cbAinF1.Location = New System.Drawing.Point(71, 26)
        Me.cbAinF1.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAinF1.Name = "cbAinF1"
        Me.cbAinF1.Size = New System.Drawing.Size(76, 24)
        Me.cbAinF1.TabIndex = 39
        Me.cbAinF1.Text = "5"
        '
        'cbAinF2
        '
        Me.cbAinF2.FormattingEnabled = True
        Me.cbAinF2.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8(COM)"})
        Me.cbAinF2.Location = New System.Drawing.Point(71, 57)
        Me.cbAinF2.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAinF2.Name = "cbAinF2"
        Me.cbAinF2.Size = New System.Drawing.Size(76, 24)
        Me.cbAinF2.TabIndex = 41
        Me.cbAinF2.Text = "8(COM)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 60)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 17)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "AIN F-"
        '
        'lAinValueF
        '
        Me.lAinValueF.AutoSize = True
        Me.lAinValueF.Location = New System.Drawing.Point(8, 85)
        Me.lAinValueF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lAinValueF.Name = "lAinValueF"
        Me.lAinValueF.Size = New System.Drawing.Size(16, 17)
        Me.lAinValueF.TabIndex = 43
        Me.lAinValueF.Text = "0"
        '
        'bActiveAinD
        '
        Me.bActiveAinD.BackColor = System.Drawing.Color.DodgerBlue
        Me.bActiveAinD.Location = New System.Drawing.Point(537, 23)
        Me.bActiveAinD.Margin = New System.Windows.Forms.Padding(4)
        Me.bActiveAinD.Name = "bActiveAinD"
        Me.bActiveAinD.Size = New System.Drawing.Size(168, 28)
        Me.bActiveAinD.TabIndex = 51
        Me.bActiveAinD.Text = "Active"
        Me.bActiveAinD.UseVisualStyleBackColor = False
        '
        'bActiveAinC
        '
        Me.bActiveAinC.BackColor = System.Drawing.Color.LimeGreen
        Me.bActiveAinC.Location = New System.Drawing.Point(361, 23)
        Me.bActiveAinC.Margin = New System.Windows.Forms.Padding(4)
        Me.bActiveAinC.Name = "bActiveAinC"
        Me.bActiveAinC.Size = New System.Drawing.Size(168, 28)
        Me.bActiveAinC.TabIndex = 50
        Me.bActiveAinC.Text = "Active"
        Me.bActiveAinC.UseVisualStyleBackColor = False
        '
        'bActiveAinB
        '
        Me.bActiveAinB.BackColor = System.Drawing.Color.Goldenrod
        Me.bActiveAinB.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bActiveAinB.Location = New System.Drawing.Point(185, 23)
        Me.bActiveAinB.Margin = New System.Windows.Forms.Padding(4)
        Me.bActiveAinB.Name = "bActiveAinB"
        Me.bActiveAinB.Size = New System.Drawing.Size(168, 28)
        Me.bActiveAinB.TabIndex = 49
        Me.bActiveAinB.Text = "Active"
        Me.bActiveAinB.UseVisualStyleBackColor = False
        '
        'bActiveAinA
        '
        Me.bActiveAinA.BackColor = System.Drawing.Color.Red
        Me.bActiveAinA.ForeColor = System.Drawing.Color.Yellow
        Me.bActiveAinA.Location = New System.Drawing.Point(8, 23)
        Me.bActiveAinA.Margin = New System.Windows.Forms.Padding(4)
        Me.bActiveAinA.Name = "bActiveAinA"
        Me.bActiveAinA.Size = New System.Drawing.Size(168, 28)
        Me.bActiveAinA.TabIndex = 48
        Me.bActiveAinA.Text = "Active"
        Me.bActiveAinA.UseVisualStyleBackColor = False
        '
        'gbAinE
        '
        Me.gbAinE.Controls.Add(Me.Label13)
        Me.gbAinE.Controls.Add(Me.cbAinE1)
        Me.gbAinE.Controls.Add(Me.cbAinE2)
        Me.gbAinE.Controls.Add(Me.Label12)
        Me.gbAinE.Controls.Add(Me.lAinValueE)
        Me.gbAinE.Enabled = False
        Me.gbAinE.Location = New System.Drawing.Point(713, 64)
        Me.gbAinE.Margin = New System.Windows.Forms.Padding(4)
        Me.gbAinE.Name = "gbAinE"
        Me.gbAinE.Padding = New System.Windows.Forms.Padding(4)
        Me.gbAinE.Size = New System.Drawing.Size(168, 123)
        Me.gbAinE.TabIndex = 47
        Me.gbAinE.TabStop = False
        Me.gbAinE.Text = "Analog input E"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 30)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 17)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "AIN E+"
        '
        'cbAinE1
        '
        Me.cbAinE1.FormattingEnabled = True
        Me.cbAinE1.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8(COM)"})
        Me.cbAinE1.Location = New System.Drawing.Point(71, 26)
        Me.cbAinE1.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAinE1.Name = "cbAinE1"
        Me.cbAinE1.Size = New System.Drawing.Size(76, 24)
        Me.cbAinE1.TabIndex = 39
        Me.cbAinE1.Text = "4"
        '
        'cbAinE2
        '
        Me.cbAinE2.FormattingEnabled = True
        Me.cbAinE2.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8(COM)"})
        Me.cbAinE2.Location = New System.Drawing.Point(71, 57)
        Me.cbAinE2.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAinE2.Name = "cbAinE2"
        Me.cbAinE2.Size = New System.Drawing.Size(76, 24)
        Me.cbAinE2.TabIndex = 41
        Me.cbAinE2.Text = "8(COM)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 60)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 17)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "AIN E-"
        '
        'lAinValueE
        '
        Me.lAinValueE.AutoSize = True
        Me.lAinValueE.Location = New System.Drawing.Point(8, 85)
        Me.lAinValueE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lAinValueE.Name = "lAinValueE"
        Me.lAinValueE.Size = New System.Drawing.Size(16, 17)
        Me.lAinValueE.TabIndex = 43
        Me.lAinValueE.Text = "0"
        '
        'gbAinD
        '
        Me.gbAinD.Controls.Add(Me.Label16)
        Me.gbAinD.Controls.Add(Me.cbAinD1)
        Me.gbAinD.Controls.Add(Me.cbAinD2)
        Me.gbAinD.Controls.Add(Me.Label15)
        Me.gbAinD.Controls.Add(Me.lAinValueD)
        Me.gbAinD.Enabled = False
        Me.gbAinD.Location = New System.Drawing.Point(537, 64)
        Me.gbAinD.Margin = New System.Windows.Forms.Padding(4)
        Me.gbAinD.Name = "gbAinD"
        Me.gbAinD.Padding = New System.Windows.Forms.Padding(4)
        Me.gbAinD.Size = New System.Drawing.Size(168, 123)
        Me.gbAinD.TabIndex = 46
        Me.gbAinD.TabStop = False
        Me.gbAinD.Text = "Analog input D"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 30)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 17)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "AIN D+"
        '
        'cbAinD1
        '
        Me.cbAinD1.FormattingEnabled = True
        Me.cbAinD1.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8(COM)"})
        Me.cbAinD1.Location = New System.Drawing.Point(71, 26)
        Me.cbAinD1.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAinD1.Name = "cbAinD1"
        Me.cbAinD1.Size = New System.Drawing.Size(76, 24)
        Me.cbAinD1.TabIndex = 34
        Me.cbAinD1.Text = "3"
        '
        'cbAinD2
        '
        Me.cbAinD2.FormattingEnabled = True
        Me.cbAinD2.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8(COM)"})
        Me.cbAinD2.Location = New System.Drawing.Point(71, 57)
        Me.cbAinD2.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAinD2.Name = "cbAinD2"
        Me.cbAinD2.Size = New System.Drawing.Size(76, 24)
        Me.cbAinD2.TabIndex = 36
        Me.cbAinD2.Text = "8(COM)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 60)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 17)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "AIN D-"
        '
        'lAinValueD
        '
        Me.lAinValueD.AutoSize = True
        Me.lAinValueD.Location = New System.Drawing.Point(8, 85)
        Me.lAinValueD.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lAinValueD.Name = "lAinValueD"
        Me.lAinValueD.Size = New System.Drawing.Size(16, 17)
        Me.lAinValueD.TabIndex = 38
        Me.lAinValueD.Text = "0"
        '
        'gbAinC
        '
        Me.gbAinC.Controls.Add(Me.Label8)
        Me.gbAinC.Controls.Add(Me.cbAinC1)
        Me.gbAinC.Controls.Add(Me.cbAinC2)
        Me.gbAinC.Controls.Add(Me.Label7)
        Me.gbAinC.Controls.Add(Me.lAinValueC)
        Me.gbAinC.Enabled = False
        Me.gbAinC.Location = New System.Drawing.Point(361, 64)
        Me.gbAinC.Margin = New System.Windows.Forms.Padding(4)
        Me.gbAinC.Name = "gbAinC"
        Me.gbAinC.Padding = New System.Windows.Forms.Padding(4)
        Me.gbAinC.Size = New System.Drawing.Size(168, 123)
        Me.gbAinC.TabIndex = 46
        Me.gbAinC.TabStop = False
        Me.gbAinC.Text = "Analog input C"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 30)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 17)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "AIN C+"
        '
        'cbAinC1
        '
        Me.cbAinC1.FormattingEnabled = True
        Me.cbAinC1.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8(COM)"})
        Me.cbAinC1.Location = New System.Drawing.Point(71, 26)
        Me.cbAinC1.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAinC1.Name = "cbAinC1"
        Me.cbAinC1.Size = New System.Drawing.Size(76, 24)
        Me.cbAinC1.TabIndex = 28
        Me.cbAinC1.Text = "2"
        '
        'cbAinC2
        '
        Me.cbAinC2.FormattingEnabled = True
        Me.cbAinC2.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8(COM)"})
        Me.cbAinC2.Location = New System.Drawing.Point(71, 57)
        Me.cbAinC2.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAinC2.Name = "cbAinC2"
        Me.cbAinC2.Size = New System.Drawing.Size(76, 24)
        Me.cbAinC2.TabIndex = 31
        Me.cbAinC2.Text = "8(COM)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 60)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 17)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "AIN C-"
        '
        'lAinValueC
        '
        Me.lAinValueC.AutoSize = True
        Me.lAinValueC.Location = New System.Drawing.Point(8, 85)
        Me.lAinValueC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lAinValueC.Name = "lAinValueC"
        Me.lAinValueC.Size = New System.Drawing.Size(16, 17)
        Me.lAinValueC.TabIndex = 33
        Me.lAinValueC.Text = "0"
        '
        'gbAinB
        '
        Me.gbAinB.Controls.Add(Me.Label5)
        Me.gbAinB.Controls.Add(Me.cbAinB1)
        Me.gbAinB.Controls.Add(Me.cbAinB2)
        Me.gbAinB.Controls.Add(Me.Label4)
        Me.gbAinB.Controls.Add(Me.lAinValueB)
        Me.gbAinB.Enabled = False
        Me.gbAinB.Location = New System.Drawing.Point(185, 62)
        Me.gbAinB.Margin = New System.Windows.Forms.Padding(4)
        Me.gbAinB.Name = "gbAinB"
        Me.gbAinB.Padding = New System.Windows.Forms.Padding(4)
        Me.gbAinB.Size = New System.Drawing.Size(168, 123)
        Me.gbAinB.TabIndex = 45
        Me.gbAinB.TabStop = False
        Me.gbAinB.Text = "Analog input B"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 32)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "AIN B+"
        '
        'cbAinB1
        '
        Me.cbAinB1.FormattingEnabled = True
        Me.cbAinB1.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8(COM)"})
        Me.cbAinB1.Location = New System.Drawing.Point(71, 28)
        Me.cbAinB1.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAinB1.Name = "cbAinB1"
        Me.cbAinB1.Size = New System.Drawing.Size(76, 24)
        Me.cbAinB1.TabIndex = 20
        Me.cbAinB1.Text = "1"
        '
        'cbAinB2
        '
        Me.cbAinB2.FormattingEnabled = True
        Me.cbAinB2.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8(COM)"})
        Me.cbAinB2.Location = New System.Drawing.Point(71, 59)
        Me.cbAinB2.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAinB2.Name = "cbAinB2"
        Me.cbAinB2.Size = New System.Drawing.Size(76, 24)
        Me.cbAinB2.TabIndex = 23
        Me.cbAinB2.Text = "8(COM)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 63)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "AIN B-"
        '
        'lAinValueB
        '
        Me.lAinValueB.AutoSize = True
        Me.lAinValueB.Location = New System.Drawing.Point(8, 87)
        Me.lAinValueB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lAinValueB.Name = "lAinValueB"
        Me.lAinValueB.Size = New System.Drawing.Size(16, 17)
        Me.lAinValueB.TabIndex = 25
        Me.lAinValueB.Text = "0"
        '
        'gbAinA
        '
        Me.gbAinA.Controls.Add(Me.cbAinA1)
        Me.gbAinA.Controls.Add(Me.Label1)
        Me.gbAinA.Controls.Add(Me.cbAinA2)
        Me.gbAinA.Controls.Add(Me.Label2)
        Me.gbAinA.Controls.Add(Me.lAinValueA)
        Me.gbAinA.Enabled = False
        Me.gbAinA.Location = New System.Drawing.Point(8, 64)
        Me.gbAinA.Margin = New System.Windows.Forms.Padding(4)
        Me.gbAinA.Name = "gbAinA"
        Me.gbAinA.Padding = New System.Windows.Forms.Padding(4)
        Me.gbAinA.Size = New System.Drawing.Size(168, 123)
        Me.gbAinA.TabIndex = 44
        Me.gbAinA.TabStop = False
        Me.gbAinA.Text = "Analog input A"
        '
        'cbAinA1
        '
        Me.cbAinA1.FormattingEnabled = True
        Me.cbAinA1.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8(COM)"})
        Me.cbAinA1.Location = New System.Drawing.Point(71, 26)
        Me.cbAinA1.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAinA1.Name = "cbAinA1"
        Me.cbAinA1.Size = New System.Drawing.Size(76, 24)
        Me.cbAinA1.TabIndex = 0
        Me.cbAinA1.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "AIN A+"
        '
        'cbAinA2
        '
        Me.cbAinA2.FormattingEnabled = True
        Me.cbAinA2.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8(COM)"})
        Me.cbAinA2.Location = New System.Drawing.Point(71, 57)
        Me.cbAinA2.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAinA2.Name = "cbAinA2"
        Me.cbAinA2.Size = New System.Drawing.Size(76, 24)
        Me.cbAinA2.TabIndex = 8
        Me.cbAinA2.Text = "8(COM)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "AIN A-"
        '
        'lAinValueA
        '
        Me.lAinValueA.AutoSize = True
        Me.lAinValueA.Location = New System.Drawing.Point(8, 85)
        Me.lAinValueA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lAinValueA.Name = "lAinValueA"
        Me.lAinValueA.Size = New System.Drawing.Size(16, 17)
        Me.lAinValueA.TabIndex = 5
        Me.lAinValueA.Text = "0"
        '
        'gbGraph
        '
        Me.gbGraph.Controls.Add(Me.Chart1)
        Me.gbGraph.Controls.Add(Me.rbGraph2)
        Me.gbGraph.Controls.Add(Me.rbGraph1)
        Me.gbGraph.Controls.Add(Me.NumericUpDown2)
        Me.gbGraph.Location = New System.Drawing.Point(288, 213)
        Me.gbGraph.Margin = New System.Windows.Forms.Padding(4)
        Me.gbGraph.Name = "gbGraph"
        Me.gbGraph.Padding = New System.Windows.Forms.Padding(4)
        Me.gbGraph.Size = New System.Drawing.Size(1075, 560)
        Me.gbGraph.TabIndex = 16
        Me.gbGraph.TabStop = False
        Me.gbGraph.Text = "Graph Analog Input Log"
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight
        Me.Chart1.BackImageTransparentColor = System.Drawing.SystemColors.Control
        Me.Chart1.BackSecondaryColor = System.Drawing.Color.White
        Me.Chart1.BorderlineColor = System.Drawing.Color.Navy
        Me.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.Chart1.BorderlineWidth = 5
        Me.Chart1.BorderSkin.BackColor = System.Drawing.Color.SaddleBrown
        Me.Chart1.BorderSkin.BackImageTransparentColor = System.Drawing.SystemColors.Control
        Me.Chart1.BorderSkin.BackSecondaryColor = System.Drawing.Color.White
        Me.Chart1.BorderSkin.BorderColor = System.Drawing.Color.White
        Me.Chart1.BorderSkin.BorderWidth = 5
        Me.Chart1.BorderSkin.PageColor = System.Drawing.SystemColors.Control
        Me.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss
        ChartArea2.AxisX.LabelAutoFitMaxFontSize = 8
        ChartArea2.AxisX.LabelAutoFitMinFontSize = 8
        ChartArea2.AxisX.MajorGrid.Enabled = False
        ChartArea2.AxisX.MajorTickMark.Enabled = False
        ChartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea2.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea2.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea2.AxisY.LabelAutoFitMaxFontSize = 8
        ChartArea2.AxisY.LabelAutoFitMinFontSize = 8
        ChartArea2.AxisY.LabelStyle.Interval = 0.0R
        ChartArea2.AxisY.LabelStyle.IntervalOffset = 0.0R
        ChartArea2.AxisY.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY.LabelStyle.TruncatedLabels = True
        ChartArea2.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea2.AxisY.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea2.AxisY.MaximumAutoSize = 100.0!
        ChartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea2.AxisY.ScrollBar.BackColor = System.Drawing.Color.White
        ChartArea2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        ChartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Legend2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(8, 23)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(4)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Chart1.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.Red, System.Drawing.Color.Goldenrod, System.Drawing.Color.LimeGreen, System.Drawing.Color.DodgerBlue, System.Drawing.Color.DarkViolet, System.Drawing.Color.Magenta, System.Drawing.Color.Black}
        Series7.BorderColor = System.Drawing.Color.White
        Series7.BorderWidth = 2
        Series7.ChartArea = "ChartArea1"
        Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series7.Legend = "Legend1"
        Series7.Name = "SeriesA"
        Series8.BorderWidth = 2
        Series8.ChartArea = "ChartArea1"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series8.Legend = "Legend1"
        Series8.Name = "SeriesB"
        Series9.BorderWidth = 2
        Series9.ChartArea = "ChartArea1"
        Series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series9.Legend = "Legend1"
        Series9.Name = "SeriesC"
        Series10.BorderWidth = 2
        Series10.ChartArea = "ChartArea1"
        Series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series10.Legend = "Legend1"
        Series10.Name = "SeriesD"
        Series11.BorderWidth = 2
        Series11.ChartArea = "ChartArea1"
        Series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series11.Legend = "Legend1"
        Series11.Name = "SeriesE"
        Series12.BorderWidth = 2
        Series12.ChartArea = "ChartArea1"
        Series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series12.Legend = "Legend1"
        Series12.Name = "SeriesF"
        Me.Chart1.Series.Add(Series7)
        Me.Chart1.Series.Add(Series8)
        Me.Chart1.Series.Add(Series9)
        Me.Chart1.Series.Add(Series10)
        Me.Chart1.Series.Add(Series11)
        Me.Chart1.Series.Add(Series12)
        Me.Chart1.Size = New System.Drawing.Size(1059, 537)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'rbGraph2
        '
        Me.rbGraph2.AutoSize = True
        Me.rbGraph2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.rbGraph2.Checked = True
        Me.rbGraph2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rbGraph2.Location = New System.Drawing.Point(903, 450)
        Me.rbGraph2.Margin = New System.Windows.Forms.Padding(4)
        Me.rbGraph2.Name = "rbGraph2"
        Me.rbGraph2.Size = New System.Drawing.Size(96, 29)
        Me.rbGraph2.TabIndex = 2
        Me.rbGraph2.TabStop = True
        Me.rbGraph2.Text = "Interval"
        Me.rbGraph2.UseVisualStyleBackColor = False
        '
        'rbGraph1
        '
        Me.rbGraph1.AutoSize = True
        Me.rbGraph1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.rbGraph1.Enabled = False
        Me.rbGraph1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rbGraph1.Location = New System.Drawing.Point(901, 414)
        Me.rbGraph1.Margin = New System.Windows.Forms.Padding(4)
        Me.rbGraph1.Name = "rbGraph1"
        Me.rbGraph1.Size = New System.Drawing.Size(100, 29)
        Me.rbGraph1.TabIndex = 1
        Me.rbGraph1.Text = "All         "
        Me.rbGraph1.UseVisualStyleBackColor = False
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(903, 487)
        Me.NumericUpDown2.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(124, 22)
        Me.NumericUpDown2.TabIndex = 3
        Me.NumericUpDown2.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'gbSetting
        '
        Me.gbSetting.Controls.Add(Me.Label18)
        Me.gbSetting.Controls.Add(Me.NumericUpDown4)
        Me.gbSetting.Controls.Add(Me.Label6)
        Me.gbSetting.Controls.Add(Me.NumericUpDown3)
        Me.gbSetting.Controls.Add(Me.Label10)
        Me.gbSetting.Controls.Add(Me.Label9)
        Me.gbSetting.Controls.Add(Me.NumericUpDown1)
        Me.gbSetting.Controls.Add(Me.Label3)
        Me.gbSetting.Enabled = False
        Me.gbSetting.Location = New System.Drawing.Point(9, 340)
        Me.gbSetting.Margin = New System.Windows.Forms.Padding(4)
        Me.gbSetting.Name = "gbSetting"
        Me.gbSetting.Padding = New System.Windows.Forms.Padding(4)
        Me.gbSetting.Size = New System.Drawing.Size(271, 142)
        Me.gbSetting.TabIndex = 17
        Me.gbSetting.TabStop = False
        Me.gbSetting.Text = "Setting"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(17, 113)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(132, 17)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "XAxis (for overview)"
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Location = New System.Drawing.Point(159, 111)
        Me.NumericUpDown4.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericUpDown4.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.NumericUpDown4.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(93, 22)
        Me.NumericUpDown4.TabIndex = 11
        Me.NumericUpDown4.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(180, 74)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "to 1 value"
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(81, 73)
        Me.NumericUpDown3.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(96, 22)
        Me.NumericUpDown3.TabIndex = 8
        Me.NumericUpDown3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 76)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 17)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Average"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(225, 36)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 17)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "ms"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(117, 33)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(99, 22)
        Me.NumericUpDown1.TabIndex = 2
        Me.NumericUpDown1.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 36)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Loop Interval"
        '
        'gbStart
        '
        Me.gbStart.Controls.Add(Me.lTimer)
        Me.gbStart.Controls.Add(Me.bStartStop)
        Me.gbStart.Controls.Add(Me.tbFileName)
        Me.gbStart.Controls.Add(Me.Label11)
        Me.gbStart.Controls.Add(Me.bBrowse)
        Me.gbStart.Enabled = False
        Me.gbStart.Location = New System.Drawing.Point(9, 490)
        Me.gbStart.Margin = New System.Windows.Forms.Padding(4)
        Me.gbStart.Name = "gbStart"
        Me.gbStart.Padding = New System.Windows.Forms.Padding(4)
        Me.gbStart.Size = New System.Drawing.Size(271, 283)
        Me.gbStart.TabIndex = 37
        Me.gbStart.TabStop = False
        Me.gbStart.Text = "Start/Stop reaction"
        '
        'lTimer
        '
        Me.lTimer.AutoSize = True
        Me.lTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lTimer.Location = New System.Drawing.Point(37, 122)
        Me.lTimer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lTimer.Name = "lTimer"
        Me.lTimer.Size = New System.Drawing.Size(207, 46)
        Me.lTimer.TabIndex = 5
        Me.lTimer.Text = "00:00:00.0"
        '
        'bStartStop
        '
        Me.bStartStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.bStartStop.Location = New System.Drawing.Point(26, 198)
        Me.bStartStop.Margin = New System.Windows.Forms.Padding(4)
        Me.bStartStop.Name = "bStartStop"
        Me.bStartStop.Size = New System.Drawing.Size(224, 63)
        Me.bStartStop.TabIndex = 4
        Me.bStartStop.Text = "Start!"
        Me.bStartStop.UseVisualStyleBackColor = True
        '
        'tbFileName
        '
        Me.tbFileName.Enabled = False
        Me.tbFileName.Location = New System.Drawing.Point(21, 52)
        Me.tbFileName.Margin = New System.Windows.Forms.Padding(4)
        Me.tbFileName.Name = "tbFileName"
        Me.tbFileName.Size = New System.Drawing.Size(223, 22)
        Me.tbFileName.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 32)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 17)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "File location"
        '
        'bBrowse
        '
        Me.bBrowse.Location = New System.Drawing.Point(21, 84)
        Me.bBrowse.Margin = New System.Windows.Forms.Padding(4)
        Me.bBrowse.Name = "bBrowse"
        Me.bBrowse.Size = New System.Drawing.Size(224, 27)
        Me.bBrowse.TabIndex = 0
        Me.bBrowse.Text = "browse"
        Me.bBrowse.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownPWNCircleDuty)
        Me.GroupBox1.Controls.Add(Me.btnPWM)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownPWM)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(9, 202)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 139)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PWM"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(239, 74)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(20, 17)
        Me.Label22.TabIndex = 17
        Me.Label22.Text = "%"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(18, 74)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 17)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "Circle duty"
        '
        'NumericUpDownPWNCircleDuty
        '
        Me.NumericUpDownPWNCircleDuty.Location = New System.Drawing.Point(100, 72)
        Me.NumericUpDownPWNCircleDuty.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericUpDownPWNCircleDuty.Name = "NumericUpDownPWNCircleDuty"
        Me.NumericUpDownPWNCircleDuty.Size = New System.Drawing.Size(131, 22)
        Me.NumericUpDownPWNCircleDuty.TabIndex = 15
        Me.NumericUpDownPWNCircleDuty.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'btnPWM
        '
        Me.btnPWM.Location = New System.Drawing.Point(7, 102)
        Me.btnPWM.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPWM.Name = "btnPWM"
        Me.btnPWM.Size = New System.Drawing.Size(257, 30)
        Me.btnPWM.TabIndex = 5
        Me.btnPWM.Text = "Generate PWM"
        Me.btnPWM.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(17, 30)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 17)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "fequency"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(239, 30)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(25, 17)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "Hz"
        '
        'NumericUpDownPWM
        '
        Me.NumericUpDownPWM.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDownPWM.Location = New System.Drawing.Point(100, 28)
        Me.NumericUpDownPWM.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericUpDownPWM.Maximum = New Decimal(New Integer() {70000, 0, 0, 0})
        Me.NumericUpDownPWM.Name = "NumericUpDownPWM"
        Me.NumericUpDownPWM.Size = New System.Drawing.Size(131, 22)
        Me.NumericUpDownPWM.TabIndex = 13
        Me.NumericUpDownPWM.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1377, 788)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbStart)
        Me.Controls.Add(Me.gbSetting)
        Me.Controls.Add(Me.gbGraph)
        Me.Controls.Add(Me.gbAin)
        Me.Controls.Add(Me.gbConnection)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Emant300  Analog Input"
        Me.gbConnection.ResumeLayout(False)
        Me.gbConnection.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAin.ResumeLayout(False)
        Me.gbAinF.ResumeLayout(False)
        Me.gbAinF.PerformLayout()
        Me.gbAinE.ResumeLayout(False)
        Me.gbAinE.PerformLayout()
        Me.gbAinD.ResumeLayout(False)
        Me.gbAinD.PerformLayout()
        Me.gbAinC.ResumeLayout(False)
        Me.gbAinC.PerformLayout()
        Me.gbAinB.ResumeLayout(False)
        Me.gbAinB.PerformLayout()
        Me.gbAinA.ResumeLayout(False)
        Me.gbAinA.PerformLayout()
        Me.gbGraph.ResumeLayout(False)
        Me.gbGraph.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSetting.ResumeLayout(False)
        Me.gbSetting.PerformLayout()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbStart.ResumeLayout(False)
        Me.gbStart.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDownPWNCircleDuty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownPWM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btConnect As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents gbConnection As System.Windows.Forms.GroupBox
    Friend WithEvents cbPort As System.Windows.Forms.ComboBox
    Friend WithEvents gbAin As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbAinA1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbAinA2 As System.Windows.Forms.ComboBox
    Friend WithEvents lAinValueC As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbAinC2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbAinC1 As System.Windows.Forms.ComboBox
    Friend WithEvents lAinValueB As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbAinB2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbAinB1 As System.Windows.Forms.ComboBox
    Friend WithEvents lAinValueA As System.Windows.Forms.Label
    Friend WithEvents gbGraph As System.Windows.Forms.GroupBox
    Friend WithEvents gbSetting As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lconnect As System.Windows.Forms.Label
    Friend WithEvents lAinValueE As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbAinE2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbAinE1 As System.Windows.Forms.ComboBox
    Friend WithEvents lAinValueD As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbAinD2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cbAinD1 As System.Windows.Forms.ComboBox
    Friend WithEvents bActiveAinE As System.Windows.Forms.Button
    Friend WithEvents bActiveAinD As System.Windows.Forms.Button
    Friend WithEvents bActiveAinC As System.Windows.Forms.Button
    Friend WithEvents bActiveAinB As System.Windows.Forms.Button
    Friend WithEvents bActiveAinA As System.Windows.Forms.Button
    Friend WithEvents gbAinE As System.Windows.Forms.GroupBox
    Friend WithEvents gbAinD As System.Windows.Forms.GroupBox
    Friend WithEvents gbAinC As System.Windows.Forms.GroupBox
    Friend WithEvents gbAinB As System.Windows.Forms.GroupBox
    Friend WithEvents gbAinA As System.Windows.Forms.GroupBox
    Friend WithEvents gbStart As System.Windows.Forms.GroupBox
    Friend WithEvents tbFileName As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents bBrowse As System.Windows.Forms.Button
    Friend WithEvents sfd1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents bStartStop As System.Windows.Forms.Button
    Friend WithEvents lTimer As System.Windows.Forms.Label
    Friend WithEvents bActiveAinF As System.Windows.Forms.Button
    Friend WithEvents gbAinF As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbAinF1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbAinF2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lAinValueF As System.Windows.Forms.Label

    Friend WithEvents rbGraph2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbGraph1 As System.Windows.Forms.RadioButton
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPWM As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownPWM As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownPWNCircleDuty As System.Windows.Forms.NumericUpDown


End Class
