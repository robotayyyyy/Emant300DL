'"new" problem
Imports Emant
Imports System.IO

Public Class Form1
    'ace
    Public pen2 As IO.StreamWriter
    Dim emant As Emant300 = New Emant300
    'buffer
    Public boxBuffer(5) As Double
    Public boxBuffer2(5) As Double
    'status
    Public connect As Boolean
    Public portActive(5) As Boolean
    Public activeDout As Boolean
    Public activeAll As Boolean
    'interval & average counter controller
    Public interval As TimeSpan
    Public startdate As Date
    Public first As Boolean
    Public break As Boolean
    'graph
    Public minValue As Double
    Public maxValue As Double
    Public minValueAll As Double
    Public maxValueAll As Double
    Public bigBox2(5) As List(Of Double)
    Public bigBox3(5) As List(Of Double)
    Public bigBox4(5) As List(Of Double)
    Public counter As UInteger  'beware not to coppy
    'port
    Public port1(5) As Integer
    Public port2(5) As Integer
    '/////////////////////////////////////////////
    '   initialize
    '/////////////////////////////////////////////
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        '////////graph///////////
        With Chart1.ChartAreas(0)
            .AxisX.Minimum = 0
            .AxisX.Maximum = 50
            .AxisY.Minimum = -5
            .AxisY.Maximum = 5
            .AxisY.Interval = 1
            .AxisX.Interval = 5
            .AxisX.Title = "Time"
            .AxisY.Title = "Volt"
        End With
        For a As Integer = 0 To 5
            bigBox2(a) = New List(Of Double)
            bigBox3(a) = New List(Of Double)
            bigBox4(a) = New List(Of Double)
            port1(a) = a
            port2(a) = 8
            portActive(a) = False
            boxBuffer2(a) = 0
        Next
        counter = 0
        connect = False
        activeDout = False
        activeAll = False
        first = True
        break = False
        maxValue = 0
        minValue = 0
        maxValueAll = 0
        minValueAll = 0
        Timer1.Interval = NumericUpDown1.Value
        PictureBox1.Image = My.Resources.cross2
        '//////////File///////////
        sfd1.InitialDirectory() = "E:\"
        sfd1.FileName = "E:\Untitled.csv"
        sfd1.Filter = "*.csv|*.csv|*.txt|*.txt"
        
    End Sub
    '/////////////////////////////////////////////
    '   connection
    '/////////////////////////////////////////////
    Private Sub btConnect_Click(sender As System.Object, e As System.EventArgs) Handles btConnect.Click
        If (connect = False) Then
            Try
                MessageBox.Show("Connecting")
                emant.Open(True, cbPort.Text)
                emant.ConfigAnalog(2.5, Emant300.POLARITY.Bipolar, 1000)
                emant.WriteDigitalPort(0)
                MessageBox.Show("Suscess")
                connect = True
                lconnect.Text = "Status : Connected"
                btConnect.Text = "Disconncet"
                PictureBox1.Image = My.Resources.check2
                gbSetting.Enabled = True
                gbAin.Enabled = True
                GroupBox1.Enabled = True
            Catch ex As Exception
                MessageBox.Show("Error" + ex.ToString())
            End Try
        Else
            Timer1.Enabled = False
            connect = False
            emant.Close()
            lconnect.Text = "Status : Disconnected"
            btConnect.Text = "Connect"
            PictureBox1.Image = My.Resources.cross2
            gbSetting.Enabled = False
            gbAin.Enabled = False
            gbStart.Enabled = False
            GroupBox1.Enabled = False
        End If

    End Sub
    '/////////////////////////////////////////////
    '   timer(Do frame)
    '/////////////////////////////////////////////
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If (portActive(0) = False And
            portActive(1) = False And
            portActive(2) = False And
            portActive(3) = False And
            portActive(4) = False And
            portActive(5) = False) Then
            StopAll()
            MessageBox.Show("None port actived")
            tbFileName.Text = ""
        Else
            interval = Date.Now - startdate
            lTimer.Text = interval.Hours.ToString() + ":" + interval.Minutes.ToString() + ":" + interval.Seconds.ToString() + ":" + interval.Milliseconds.ToString()
            '--------------------------------------------------------
            '****read****
            For a As Integer = 0 To 5
                readEmamt(a, portActive(a))
                boxBuffer2(a) += boxBuffer(a)
            Next
            '****wirte****
            If (counter Mod NumericUpDown3.Value = 0) Then
                Try
                    pen2.Write(lTimer.Text)
                Catch ex As Exception
                    StopAll()
                    MessageBox.Show(ex.ToString())
                End Try
                '-------------------------------------------------
                For b As Integer = 0 To 5
                    If (portActive(b)) Then
                        boxBuffer(b) = (boxBuffer2(b) / NumericUpDown3.Value)
                        boxBuffer2(b) = 0
                        writeEmant(b, portActive(b))
                    End If
                Next
                '------------------------------------------------
                Try
                    pen2.WriteLine()
                Catch ex As Exception
                    StopAll()
                    MessageBox.Show(ex.ToString())
                End Try
            End If
            counter += 1 '****important
            '****end****
            '-------------------------------------------------------
            If (counter / NumericUpDown3.Value >= NumericUpDown2.Value) Then
                rbGraph1.Enabled = True
                break = True
            End If
            If (rbGraph1.Checked) Then
                If (counter >= NumericUpDown4.Value) Then
                    Chart1.ChartAreas(0).AxisX.Maximum = NumericUpDown4.Value
                Else
                    Chart1.ChartAreas(0).AxisX.Maximum = counter
                End If
            End If
            If (counter = NumericUpDown2.Value) Then
                graphAutoscale(maxValue, minValue)
            ElseIf (counter Mod (NumericUpDown2.Value) = 0) Then
                graphAutoscale(maxValue, minValue)
                maxValue = ((maxValueAll - minValueAll) / 2) + minValueAll
                minValue = maxValue
            ElseIf (counter Mod 10 = 0) Then
                graphAutoscale(maxValue, minValue)

            End If
        End If
    End Sub
    '/////////////////////////////////////////////
    '   interface (IO)
    '/////////////////////////////////////////////
    Public Sub readEmamt(index As Integer, IO As Boolean)
        If (IO) Then
            Try
                boxBuffer(index) = emant.ReadAnalog(port1(index), port2(index))
            Catch ex As Exception
                StopAll()
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub
    Public Sub writeEmant(index As Integer, IO As Boolean)
        If (IO) Then
            If (index = 0) Then
                lAinValueA.Text = boxBuffer(index).ToString()
            ElseIf (index = 1) Then
                lAinValueB.Text = boxBuffer(index).ToString()
            ElseIf (index = 2) Then
                lAinValueC.Text = boxBuffer(index).ToString()
            ElseIf (index = 3) Then
                lAinValueD.Text = boxBuffer(index).ToString()
            ElseIf (index = 4) Then
                lAinValueE.Text = boxBuffer(index).ToString()
            ElseIf (index = 5) Then
                lAinValueF.Text = boxBuffer(index).ToString()
            End If
            Try
                pen2.Write(",")
                pen2.Write(boxBuffer(index).ToString())
                graphManager(index, boxBuffer(index))
            Catch ex As Exception
                StopAll()
                MessageBox.Show(ex.ToString())
            End Try
        Else
            Try
                pen2.Write(",")
            Catch ex As Exception
                StopAll()
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub
    '/////////////////////////////////////////////
    '   Setting interval(time) & x to 1
    '/////////////////////////////////////////////
    Private Sub NumericUpDown1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        Timer1.Interval = NumericUpDown1.Value
    End Sub
    '/////////////////////////////////////////////
    '   File
    '/////////////////////////////////////////////
    Private Sub bBrowse_Click(sender As System.Object, e As System.EventArgs) Handles bBrowse.Click
        sfd1.ShowDialog()
        sfd1.InitialDirectory = sfd1.RestoreDirectory
    End Sub
    Public Sub fileName()
        Dim filter As String
        Dim rec As String
        Dim lw As Integer
        Dim fw As Integer
        filter = ".csv"
        For a As Integer = 1 To sfd1.FileName.Length
            If (sfd1.FileName(sfd1.FileName.Length() - a).ToString() = ".") Then
                filter = sfd1.FileName.Substring(sfd1.FileName.Length() - a)
                fw = sfd1.FileName.Length() - a
                lw = sfd1.FileName.Length() - a
            ElseIf (sfd1.FileName(sfd1.FileName.Length() - a).ToString() = ")") Then
                lw = sfd1.FileName.Length() - a
            ElseIf (sfd1.FileName(sfd1.FileName.Length() - a).ToString() = "(") Then
                fw = sfd1.FileName.Length() - a
                a = sfd1.FileName.Length
            End If
        Next

        rec = ""
        If (fw = lw) Then
            sfd1.FileName = sfd1.FileName.Remove(fw)
            sfd1.FileName += "(2)" + filter
        Else
            For a As Integer = fw + 1 To lw - 1
                rec += sfd1.FileName(a)
            Next
            sfd1.FileName = sfd1.FileName.Remove(fw)
            sfd1.FileName += "(" + (Integer.Parse(rec) + 1).ToString() + ")" + filter
        End If
    End Sub
    '/////////////////////////////////////////////
    '   Start/stop
    '/////////////////////////////////////////////
    Private Sub bStartStop_Click(sender As System.Object, e As System.EventArgs) Handles bStartStop.Click
        activeAll = Not activeAll
        If (activeAll) Then
            counter = 0
            rbGraph1.Enabled = False
            rbGraph2.Select()
            For a As Integer = 0 To 5
                Chart1.Series(a).Points.Clear()
                bigBox2(a) = New List(Of Double)
                bigBox3(a) = New List(Of Double)
                bigBox4(a) = New List(Of Double)
                boxBuffer2(a) = 0
            Next
            If (sfd1.FileName = tbFileName.Text) Then
                fileName()
            End If
            tbFileName.Text = sfd1.FileName
            pen2 = New IO.StreamWriter(sfd1.FileName)
            Timer1.Enabled = True

            bStartStop.Text = "Stop"
            pen2.Write("Time,SeriesA,SeriesB,SeriesC,SeriesD,SeriesE,SeriesF,")
            startdate = Date.Now
            pen2.Write(startdate.Date.ToString() + startdate.TimeOfDay.ToString())
            pen2.WriteLine()
        Else
            StopAll()
        End If
    End Sub
    '/////////////////////////////////////////////
    '   graph
    '/////////////////////////////////////////////   
    Public Sub graphManager(index As Integer, value As Double)
        bigBox2(index).Add(value)
        maxminchecker(boxBuffer(index))
        If (bigBox2(index).Count > NumericUpDown4.Value) Then
            datachange(index)
        End If
        If (rbGraph2.Checked) Then '//case interval
            If (break) Then
                Chart1.Series(index).Points.RemoveAt(0)
            End If
            Chart1.Series(index).Points.Add(boxBuffer(index))
        Else '//case all graph
            If (bigBox2(index).Count <= NumericUpDown4.Value) Then
                Chart1.Series(index).Points.DataBindY(bigBox2(index).ToArray())
            Else
                Chart1.Series(index).Points.DataBindY(bigBox4(index).ToArray())
            End If
        End If
        If (first) Then
            maxValueAll = value
            minValueAll = value
            first = False
        End If
    End Sub
    Public Sub redatachange(index As Integer)
        Dim difference As Double
        Dim value As Double
        Dim x As Integer
        Dim y As Integer
        Dim z As Double
        bigBox4(index) = New List(Of Double)
        bigBox4(index).Add(bigBox3(index).Item(0))
        'For a As Integer = 1 To NumericUpDown4.Value - 2
        For a As Integer = 1 To bigBox3(index).Count - 2
            z = (bigBox3(index).Count - 1) / (bigBox3(index).Count - 2) * a
            x = Math.Floor(z)
            y = Math.Ceiling(z)
            difference = bigBox3(index).Item(y) - bigBox3(index).Item(x)
            value = difference * (z - x) + bigBox3(index).Item(x)
            bigBox4(index).Add(value)
        Next
    End Sub
    Public Sub datachange(index As Integer)
        Dim difference As Double
        Dim value As Double
        Dim x As Integer
        Dim y As Integer
        Dim z As Double
        bigBox3(index) = New List(Of Double)
        bigBox3(index).Add(bigBox2(index).Item(0))
        For a As Integer = 1 To NumericUpDown4.Value - 1
            z = ((bigBox2(index).Count - 1) / (NumericUpDown4.Value)) * a
            x = Math.Floor(z)
            y = Math.Ceiling(z)
            difference = bigBox2(index).Item(y) - bigBox2(index).Item(x)
            value = difference * (z - x) + bigBox2(index).Item(x)
            bigBox3(index).Add(value)
        Next
        redatachange(index)
        bigBox3(index) = New List(Of Double)
        For a As Integer = 0 To bigBox4(index).Count - 1
            bigBox3(index).Add(bigBox4(index).Item(a))
        Next
        redatachange(index)
    End Sub
    Public Sub graphAutoscale(Imax As Double, Imin As Double)
        If (rbGraph2.Checked) Then
            Chart1.ChartAreas(0).AxisY.Maximum = maxValue + 0.1 * (maxValue - minValue)
            Chart1.ChartAreas(0).AxisY.Minimum = minValue - 0.1 * (maxValue - minValue)
        Else
            Chart1.ChartAreas(0).AxisY.Maximum = maxValueAll + 0.1 * (maxValueAll - minValueAll)
            Chart1.ChartAreas(0).AxisY.Minimum = minValueAll - 0.1 * (maxValueAll - minValueAll)
        End If
    End Sub
    Public Sub maxminchecker(value As Double)
        If (value > maxValue) Then
            maxValue = value
        End If
        If (value < minValue) Then
            minValue = value
        End If
        If (value > maxValueAll) Then
            maxValueAll = value
        End If
        If (value < minValueAll) Then
            minValueAll = value
        End If
    End Sub
    Public Sub rbGraph2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbGraph2.CheckedChanged
        If (rbGraph2.Checked) Then 'case interval
            NumericUpDown2.Enabled = True
            dataBlindAll(True)
            Chart1.ChartAreas(0).AxisX.Maximum = NumericUpDown2.Value
        Else 'case all
            NumericUpDown2.Enabled = False
            dataBlindAll(False)
            Chart1.ChartAreas(0).AxisX.Maximum = NumericUpDown4.Value
        End If
    End Sub
    Public Sub NumericUpDown2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NumericUpDown2.ValueChanged 'for interval case
        dataBlindAll(True)
        Chart1.ChartAreas(0).AxisX.Maximum = NumericUpDown2.Value
        If (counter < NumericUpDown2.Value) Then
            break = False
        End If
    End Sub
    Public Sub dataBlindAll(isInterval As Boolean)
        Dim arr(NumericUpDown2.Value) As Double
        If (isInterval) Then 'case interval graph
            For index As Integer = 0 To 5
                If (portActive(index)) Then
                    If (counter > NumericUpDown2.Value) Then
                        For aa As Integer = 0 To NumericUpDown2.Value
                            arr(aa) = bigBox2(index).Item(bigBox2(index).Count - 1 - NumericUpDown2.Value + aa)
                        Next
                        Chart1.Series(index).Points.DataBindY(arr)
                    End If
                End If
            Next
        Else 'case all (overview graph)
            For index As Integer = 0 To 5
                If (portActive(index)) Then
                    If (bigBox2(index).Count <= NumericUpDown4.Value) Then
                        Chart1.Series(index).Points.DataBindY(bigBox2(index).ToArray())
                    Else
                        Chart1.Series(index).Points.DataBindY(bigBox4(index).ToArray())
                    End If
                End If
            Next
        End If
    End Sub
    '/////////////////////////////////////////////
    '   other
    '/////////////////////////////////////////////    
    Public Sub StopAll()
        Timer1.Enabled = False
        bStartStop.Text = "Start!"
        pen2.Close()
        activeDout = False
        activeAll = False
        first = True
        break = False
        maxValue = 0
        minValue = 0
        maxValueAll = 0
        minValueAll = 0
    End Sub
    '/////////////////////////////////////////////
    '   port status
    '/////////////////////////////////////////////
    Private Sub bActiveAinA_Click(sender As System.Object, e As System.EventArgs) Handles bActiveAinA.Click
        portActive(0) = Not portActive(0)
        If (portActive(0)) Then
            gbAinA.Enabled = True
            bActiveAinA.Text = "Deactive"
        Else
            gbAinA.Enabled = False
            bActiveAinA.Text = "Active"
        End If
        unlockStart()


    End Sub
    Private Sub bActiveAinB_Click(sender As System.Object, e As System.EventArgs) Handles bActiveAinB.Click
        portActive(1) = Not portActive(1)
        If (portActive(1)) Then
            gbAinB.Enabled = True
            bActiveAinB.Text = "Deactive"
        Else
            gbAinB.Enabled = False
            bActiveAinB.Text = "Active"
        End If
        unlockStart()
    End Sub
    Private Sub bActiveAinC_Click(sender As System.Object, e As System.EventArgs) Handles bActiveAinC.Click
        portActive(2) = Not portActive(2)
        If (portActive(2)) Then
            gbAinC.Enabled = True
            bActiveAinC.Text = "Deactive"
        Else
            gbAinC.Enabled = False
            bActiveAinC.Text = "Active"
        End If
        unlockStart()
    End Sub
    Private Sub bActiveAinD_Click(sender As System.Object, e As System.EventArgs) Handles bActiveAinD.Click
        portActive(3) = Not portActive(3)
        If (portActive(3)) Then
            gbAinD.Enabled = True
            bActiveAinD.Text = "Deactive"
        Else
            gbAinD.Enabled = False
            bActiveAinD.Text = "Active"
        End If
        unlockStart()
    End Sub
    Private Sub bActiveAinE_Click(sender As System.Object, e As System.EventArgs) Handles bActiveAinE.Click
        portActive(4) = Not portActive(4)
        If (portActive(4)) Then
            gbAinE.Enabled = True
            bActiveAinE.Text = "Deactive"
        Else
            gbAinE.Enabled = False
            bActiveAinE.Text = "Active"
        End If
        unlockStart()
    End Sub
    Private Sub bActiveAinF_Click(sender As System.Object, e As System.EventArgs) Handles bActiveAinF.Click
        portActive(5) = Not portActive(5)
        If (portActive(5)) Then
            gbAinF.Enabled = True
            bActiveAinF.Text = "Deactive"
        Else
            gbAinF.Enabled = False
            bActiveAinF.Text = "Active"
        End If
        unlockStart()
    End Sub
    Sub unlockStart()
        For a As Integer = 0 To 5
            If (portActive(a)) Then
                gbStart.Enabled = True
            End If
        Next
        If (portActive(0) = False And
             portActive(1) = False And
             portActive(2) = False And
             portActive(3) = False And
             portActive(4) = False And
             portActive(5) = False) Then
            gbStart.Enabled = False
        End If
    End Sub
    '/////////////////////////////////////////////
    '    Port set data
    '/////////////////////////////////////////////
    Private Sub cbAinA1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbAinA1.SelectedIndexChanged
        port1(0) = cbAinA1.SelectedIndex
    End Sub
    Private Sub cbAinB1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbAinB1.SelectedIndexChanged
        port1(1) = cbAinB1.SelectedIndex
    End Sub
    Private Sub cbAinC1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbAinC1.SelectedIndexChanged
        port1(2) = cbAinC1.SelectedIndex
    End Sub
    Private Sub cbAinD1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbAinD1.SelectedIndexChanged
        port1(3) = cbAinD1.SelectedIndex
    End Sub
    Private Sub cbAinE1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbAinE1.SelectedIndexChanged
        port1(4) = cbAinE1.SelectedIndex
    End Sub
    Private Sub cbAinF1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbAinF1.SelectedIndexChanged
        port1(5) = cbAinF1.SelectedIndex
    End Sub
    Private Sub cbAinA2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbAinA2.SelectedIndexChanged
        port2(0) = cbAinA2.SelectedIndex
    End Sub
    Private Sub cbAinB2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbAinB2.SelectedIndexChanged
        port2(1) = cbAinB2.SelectedIndex
    End Sub
    Private Sub cbAinC2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbAinC2.SelectedIndexChanged
        port2(2) = cbAinC2.SelectedIndex
    End Sub
    Private Sub cbAinD2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbAinD2.SelectedIndexChanged
        port2(3) = cbAinD2.SelectedIndex
    End Sub
    Private Sub cbAinE2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbAinE2.SelectedIndexChanged
        port2(4) = cbAinE2.SelectedIndex
    End Sub
    Private Sub cbAinF2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbAinF2.SelectedIndexChanged
        port2(5) = cbAinF2.SelectedIndex
    End Sub

    Private Sub btnPWM_Click(sender As Object, e As EventArgs) Handles btnPWM.Click
        If NumericUpDownPWM.Value = 0 Then
            NumericUpDownPWM.Value = 1
        End If
        Try
            emant.WritePWM(1 / NumericUpDownPWM.Value * 1000000, NumericUpDownPWNCircleDuty.Value)
        Catch ex As Exception
            MessageBox.Show("Error" + ex.ToString())
        End Try
    End Sub
End Class