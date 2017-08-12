Imports System.ComponentModel
Imports System.IO
Imports AxZKFPEngXControl
Imports UsersRegister.Hook
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop

Public Class AccessForm
    Dim matchType As Integer = 0
    Dim sRegTemplate As String = String.Empty
    Dim sRegTemplate10 As String = String.Empty
    Dim MouseHook As New Hook
    Private Sub Bu_Exit_Click(sender As Object, e As EventArgs) Handles Bu_Exit.Click
        End
    End Sub

    Private Sub AccessForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IOUsersDataSet.InOutTable' table. You can move, or remove it, as needed.
        Me.InOutTableTableAdapter.FillBy_month(Me.IOUsersDataSet.InOutTable, Today.Year, Today.Month)
        'TODO: This line of code loads data into the 'IOUsersDataSet.UsersStamps' table. You can move, or remove it, as needed.
        Me.UsersStampsTableAdapter.Fill(Me.IOUsersDataSet.UsersStamps)


        MouseHook.HookMouse()

        If (AxZKFPEngX1.InitEngine = 0) Then
            AxZKFPEngX1.FPEngineVersion = "9"
            Dim fpcHandle As Integer = AxZKFPEngX1.CreateFPCacheDBEx()
            StatusLabel2.Text = StatusLabel2.Text + AxZKFPEngX1.SensorSN() + "   /   "
            StatusLabel1.Text = StatusLabel1.Text + AxZKFPEngX1.SensorCount().ToString + "  /   "
            StatusLabel3.Text = "Initial Succeed"
        Else
            AxZKFPEngX1.EndEngine()
            StatusLabel3.Text = "Initial Failed"
        End If
        Me.WindowState = FormWindowState.Maximized
        My.Computer.Audio.Play("sound\SystemLoad.wav", AudioPlayMode.Background)
    End Sub

    Private Sub AccessForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MouseHook.UnHookMouse()
        AxZKFPEngX1.EndEngine()
    End Sub

    Private Sub AxZKFPEngX1_OnImageReceived(sender As Object, e As IZKFPEngXEvents_OnImageReceivedEvent) Handles AxZKFPEngX1.OnImageReceived
        Dim HDC As Long = PB_Stamp.CreateGraphics.GetHdc.ToInt32
        If (e.aImageValid) Then
            AxZKFPEngX1.PrintImageAt(HDC, 0, 0, AxZKFPEngX1.ImageWidth / 2.5, AxZKFPEngX1.ImageHeight / 2.5)
        End If
    End Sub
    Private Sub AxZKFPEngX1_OnCapture(sender As Object, e As IZKFPEngXEvents_OnCaptureEvent) Handles AxZKFPEngX1.OnCapture
        Dim RegChanged As Boolean = False
        MouseHook.UnHookMouse()
        Select Case In_Out_Time
            Case 0

            Case 1  ' login 
                Dim sTemp As String = String.Empty
                Dim bTemp As String = String.Empty
                sTemp = AxZKFPEngX1.GetTemplateAsString()
                Try
                    Dim CheckifUserReg = From num In UsersStampsTableAdapter.GetData Where AxZKFPEngX1.VerFingerFromStr(num.Stamp1, sTemp, False, RegChanged) Or
                                                                                   AxZKFPEngX1.VerFingerFromStr(num.Stamp2, sTemp, False, RegChanged) Or
                                                                                   AxZKFPEngX1.VerFingerFromStr(num.Stamp3, sTemp, False, RegChanged) Or
                                                                                   AxZKFPEngX1.VerFingerFromStr(num.Stamp4, sTemp, False, RegChanged) Or
                                                                                    AxZKFPEngX1.VerFingerFromStr(num.Stamp5, sTemp, False, RegChanged) Or
                                                                                    AxZKFPEngX1.VerFingerFromStr(num.Stamp6, sTemp, False, RegChanged) Or
                                                                                    AxZKFPEngX1.VerFingerFromStr(num.Stamp7, sTemp, False, RegChanged) Or
                                                                                    AxZKFPEngX1.VerFingerFromStr(num.Stamp8, sTemp, False, RegChanged) Or
                                                                                    AxZKFPEngX1.VerFingerFromStr(num.Stamp9, sTemp, False, RegChanged) Or
                                                                                    AxZKFPEngX1.VerFingerFromStr(num.Stamp10, sTemp, False, RegChanged)

                    If (CheckifUserReg.Any) Then
                        'If (CheckifUserReg.First.UsersId <> 0) Then
                        Dim IsUserExit = InOutTableTableAdapter.GetDataBy_CheckUserIfGoOut(DateTime.MaxValue, CheckifUserReg.First.UsersId)
                            If (IsUserExit.Any) Then
                                My.Computer.Audio.Play("sound\LogOut.wav", AudioPlayMode.Background)
                            Else
                                InOutTableTableAdapter.Insert(CheckifUserReg.First.UsersId, CheckifUserReg.First.UserName, DateAndTime.Now, DateTime.MaxValue, 0)
                                My.Computer.Audio.Play("sound\Thankyou.wav", AudioPlayMode.Background)
                            End If
                        'Else
                        'My.Computer.Audio.Play("sound\Denine.wav", AudioPlayMode.Background)
                        'End If
                        Me.InOutTableTableAdapter.FillBy_month(Me.IOUsersDataSet.InOutTable, Today.Year, Today.Month)
                    Else
                        My.Computer.Audio.Play("sound\Denine.wav", AudioPlayMode.Background)
                    End If
                Catch ex As Exception
                    My.Computer.Audio.Play("sound\somethingworng.wav", AudioPlayMode.Background)
                End Try

            Case 2  'logout
                Dim sTemp As String = String.Empty
                Dim bTemp As String = String.Empty
                sTemp = AxZKFPEngX1.GetTemplateAsString()
                Try
                    Dim CheckifUserReg = From num In UsersStampsTableAdapter.GetData Where AxZKFPEngX1.VerFingerFromStr(num.Stamp1, sTemp, False, RegChanged) Or
                                                                                   AxZKFPEngX1.VerFingerFromStr(num.Stamp2, sTemp, False, RegChanged) Or
                                                                                   AxZKFPEngX1.VerFingerFromStr(num.Stamp3, sTemp, False, RegChanged) Or
                                                                                   AxZKFPEngX1.VerFingerFromStr(num.Stamp4, sTemp, False, RegChanged) Or
                                                                                    AxZKFPEngX1.VerFingerFromStr(num.Stamp5, sTemp, False, RegChanged) Or
                                                                                    AxZKFPEngX1.VerFingerFromStr(num.Stamp6, sTemp, False, RegChanged) Or
                                                                                    AxZKFPEngX1.VerFingerFromStr(num.Stamp7, sTemp, False, RegChanged) Or
                                                                                    AxZKFPEngX1.VerFingerFromStr(num.Stamp8, sTemp, False, RegChanged) Or
                                                                                    AxZKFPEngX1.VerFingerFromStr(num.Stamp9, sTemp, False, RegChanged) Or
                                                                                    AxZKFPEngX1.VerFingerFromStr(num.Stamp10, sTemp, False, RegChanged)
                    If (CheckifUserReg.Any) Then
                        'If (CheckifUserReg.First.UsersId <> 0) Then
                        Dim IsUserin = InOutTableTableAdapter.GetDataBy_CheckUserIfGoOut(DateTime.MaxValue, CheckifUserReg.First.UsersId)
                            If (IsUserin.Any) Then
                                Dim timeout As DateTime = DateAndTime.Now
                                Dim temp As TimeSpan = timeout.Subtract(IsUserin.First.TimeIn)
                                InOutTableTableAdapter.Update_TimeOutDiff(DateTime.Now, temp.TotalHours.ToString, IsUserin.First.InOutId)
                                My.Computer.Audio.Play("sound\Thankyou.wav", AudioPlayMode.Background)
                            Else
                                My.Computer.Audio.Play("sound\LogIn.wav", AudioPlayMode.Background)
                            End If
                        'Else
                        'My.Computer.Audio.Play("sound\Denine.wav", AudioPlayMode.Background)
                        'End If
                    Else
                        My.Computer.Audio.Play("sound\Denine.wav", AudioPlayMode.Background)
                    End If

                Catch ex1 As Exception
                    My.Computer.Audio.Play("sound\somethingworng.wav", AudioPlayMode.Background)
                End Try
                Me.InOutTableTableAdapter.FillBy_month(Me.IOUsersDataSet.InOutTable, Today.Year, Today.Month)

        End Select
        MouseHook.HookMouse()
    End Sub
    Private Sub ExportExcel()
        'Dim saveFileDialog1 As New SaveFileDialog()
        'SaveFileDialog1.Filter = "The default Office Excel 2007|*.xlsx|Excel 97-Excel 2003|*.xls"
        'SaveFileDialog1.Title = "Save an Excel File For:- " + UsernameComboBox.Text
        'SaveFileDialog1.ShowDialog()
        'If SaveFileDialog1.FileName <> "" Then
        MouseHook.UnHookMouse()
        My.Computer.Audio.Play("sound\BeginCopy.wav", AudioPlayMode.WaitToComplete)
        ' kill Excel
        Try
            For Each pro In Process.GetProcesses
                If pro.ProcessName.ToLower = "Excel".ToLower Or pro.ProcessName.ToLower = "Excel.exe".ToLower Then
                    Process.GetProcessById(pro.Id).Kill()
                End If
            Next
        Catch ex2 As Exception

        End Try
        '''''''''''''''''''''
        Dim d As DriveInfo = New DriveInfo("D:\")
        Dim s = d.DriveType()
        If (s <> 2) Then
            My.Computer.Audio.Play("sound\Insertflash.wav", AudioPlayMode.Background)
            MouseHook.HookMouse()
            Exit Sub
        End If

        Dim month_date As Date = Today
        Dim Prev_month As Date = month_date.AddMonths(-1)
        Dim suc As Boolean = False
        Dim file_path As String = "D:\" & month_date.Year & "-" & month_date.Month & "-" & month_date.Day & ".xlsx"
        suc = WriteexcelData(file_path, month_date)

        If (suc = False) Then
            My.Computer.Audio.Play("sound\somethingworng.wav", AudioPlayMode.Background)
            GoTo end_sub
        End If

        file_path = "D:\" & Prev_month.Year & "-" & Prev_month.Month & "-" & Prev_month.Day & ".xlsx"
        suc = WriteexcelData(file_path, Prev_month)

        If (suc = False) Then
            My.Computer.Audio.Play("sound\somethingworng.wav", AudioPlayMode.Background)
            GoTo end_sub
        End If

        My.Computer.Audio.Play("sound\Finish.wav", AudioPlayMode.Background)

end_sub:

        MouseHook.HookMouse()
    End Sub
    Private Function WriteexcelData(ByVal file_path As String, ByVal month_date As Date) As Boolean

        Dim alluser = UsersStampsTableAdapter.GetData()

        Dim xlApp As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Try
            If (File.Exists(file_path)) Then File.Delete(file_path)
            Dim misValue As Object = System.Reflection.Missing.Value
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            For i = 0 To alluser.Count - 1
                Dim IOTable = InOutTableTableAdapter.GetDataBy_YearMonth_UserId(month_date.Year, month_date.Month, alluser(i).UsersId)
                xlWorkSheet = xlWorkBook.Sheets("Sheet" & i + 1)
                xlWorkBook.Sheets("Sheet" & i + 1).Name = alluser(i).UserName
                Dim formatRangeDate As Microsoft.Office.Interop.Excel.Range
                formatRangeDate = xlWorkSheet.Range("A1:F1")
                formatRangeDate.Font.Name = "Arial"
                formatRangeDate.Font.Size = 14
                formatRangeDate.Font.Color = Color.Blue
                formatRangeDate.Columns.BorderAround2()
                formatRangeDate.ColumnWidth = 20
                formatRangeDate.HorizontalAlignment = Excel.Constants.xlCenter
                'formatRangeDate.NumberFormat = "mm/dd/yyyy"
                'formatRangeTime = xlWorkSheet.Range("c:f")
                'formatRangeTime.NumberFormat = "hh:mm:ss"
                xlWorkSheet.Cells(1, 1) = "UserID"
                xlWorkSheet.Cells(1, 2) = "User Code"
                xlWorkSheet.Cells(1, 3) = "User Name"
                xlWorkSheet.Cells(1, 4) = "Time In"
                xlWorkSheet.Cells(1, 5) = "Time Out"
                xlWorkSheet.Cells(1, 6) = "Sub Time"
                Dim DifSum As TimeSpan
                For k = 0 To IOTable.Count - 1
                    xlWorkSheet.Cells(k + 2, 1) = IOTable(k).UserId
                    xlWorkSheet.Cells(k + 2, 2) = alluser(i).Code
                    xlWorkSheet.Cells(k + 2, 3) = IOTable(k).UserName
                    xlWorkSheet.Cells(k + 2, 4) = IOTable(k).TimeIn.ToString
                    If (IOTable(k).TimeOut.ToString <> "12/31/9999 11:59:59 PM") Then
                        xlWorkSheet.Cells(k + 2, 5) = IOTable(k).TimeOut.ToString
                        xlWorkSheet.Cells(k + 2, 6) = IOTable(k).TimeOut.Subtract(IOTable(k).TimeIn).TotalHours.ToString  'IOTable(k).DifTime.TotalHours.ToString
                        DifSum = DifSum.Add(IOTable(k).TimeOut.Subtract(IOTable(k).TimeIn))
                    Else
                        xlWorkSheet.Cells(k + 2, 5) = IOTable(k).TimeIn.ToString
                        xlWorkSheet.Cells(k + 2, 6) = 0
                    End If



                    'DifSum = DifSum.Add(IOTable(k).TimeOut.Subtract(IOTable(k).TimeIn))
                    'DifSum = DifSum.Add(IOTable(k).DifTime)

                    formatRangeDate = xlWorkSheet.Range("A" & k + 2 & ":F" & k + 2)
                    formatRangeDate.Font.Name = "Arial"
                    formatRangeDate.Font.Size = 10
                    formatRangeDate.Columns.BorderAround2()
                    formatRangeDate.HorizontalAlignment = Excel.Constants.xlCenter

                Next k
                xlWorkSheet.Cells(IOTable.Count + 3, 6) = DifSum.TotalHours.ToString
                formatRangeDate = xlWorkSheet.Range("A" & IOTable.Count + 3 & ":F6")
                formatRangeDate.Font.Name = "Arial"
                formatRangeDate.Font.Color = Color.Red
                formatRangeDate.HorizontalAlignment = Excel.Constants.xlCenter
                DifSum = New TimeSpan(0, 0, 0)
                xlWorkSheet = xlWorkBook.Sheets.Add

            Next
            xlWorkSheet.SaveAs(file_path)
            xlWorkBook.Close()
            xlApp.Quit()
            ReleaseComObject(xlApp)
        Catch ex As Exception
            'MsgBox(ex.Message.ToString)
            xlWorkBook.Close()
            xlApp.Quit()
            ReleaseComObject(xlApp)
            Return False
        End Try
        Return True
    End Function
    Private Function check_calc_TimeValue(ByVal difTime As TimeSpan) As String
        If difTime.Days > 0 Then
            Return difTime.TotalHours
        ElseIf difTime.Days < 0 And difTime.Hours < 0 Then
            Return difTime.TotalMinutes.ToString & "Min"
        End If
    End Function


    Public Sub ReleaseComObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If In_Out_Time = 3 Then
            In_Out_Time = 0
            ExportExcel()
        End If
        If (TimeOfDay.Hour = 6 And TimeOfDay.Minute = 0 And TimeOfDay.Second = 20) Then
            In_Out_Time = 1
        ElseIf (TimeOfDay.Hour = 18 And TimeOfDay.Minute = 0 And TimeOfDay.Second = 20) Then
            In_Out_Time = 2
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub Bu_export_Click(sender As Object, e As EventArgs) Handles Bu_export.Click
        MouseHook.UnHookMouse()
        Dim file_path As String = String.Empty
        Dim temp As String = String.Empty
        My.Computer.Audio.Play("sound\BeginCopy.wav", AudioPlayMode.WaitToComplete)
        ' kill Excel
        Try
            For Each pro In Process.GetProcesses
                If pro.ProcessName.ToLower = "Excel".ToLower Or pro.ProcessName.ToLower = "Excel.exe".ToLower Then
                    Process.GetProcessById(pro.Id).Kill()
                End If
            Next
        Catch ex2 As Exception

        End Try
        '''''''''''''''''''''
        Dim FolderFileBrowser_ As FolderBrowserDialog = New FolderBrowserDialog
        'SaveFileDialog1.RestoreDirectory = True
        'SaveFileDialog1.InitialDirectory = "C:\"
        'SaveFileDialog1.Title = "Browse place to save Files"

        If (FolderFileBrowser_.ShowDialog() = DialogResult.OK) Then
            'file_path = SaveFileDialog1.FileName
            temp = FolderFileBrowser_.SelectedPath
        Else
            Exit Sub
        End If
        If Not (temp.EndsWith("\")) Then temp = temp + "\"
        'file_path = file_path.Substring(0, file_path.LastIndexOf("\"))
        'Dim d As DriveInfo = New DriveInfo("D:\")
        'Dim s = d.DriveType()
        'If (s <> 2) Then
        '    My.Computer.Audio.Play("sound\Insertflash.wav", AudioPlayMode.Background)
        '    MouseHook.HookMouse()
        '    Exit Sub
        'End If

        Dim month_date As Date = Today
        Dim Prev_month As Date = month_date.AddMonths(-1)
        Dim suc As Boolean = False
        file_path = temp & month_date.Year & "-" & month_date.Month & "-" & month_date.Day & ".xlsx"
        suc = WriteexcelData(file_path, month_date)

        If (suc = False) Then
            My.Computer.Audio.Play("sound\somethingworng.wav", AudioPlayMode.Background)
            GoTo end_sub
        End If

        file_path = temp & Prev_month.Year & "-" & Prev_month.Month & "-" & Prev_month.Day & ".xlsx"
        suc = WriteexcelData(file_path, Prev_month)

        If (suc = False) Then
            My.Computer.Audio.Play("sound\somethingworng.wav", AudioPlayMode.Background)
            GoTo end_sub
        End If

        My.Computer.Audio.Play("sound\Finish.wav", AudioPlayMode.Background)

end_sub:
        ' kill Excel
        Try
            For Each pro In Process.GetProcesses
                If pro.ProcessName.ToLower = "Excel".ToLower Or pro.ProcessName.ToLower = "Excel.exe".ToLower Then
                    Process.GetProcessById(pro.Id).Kill()
                End If
            Next
        Catch ex2 As Exception

        End Try
        '''''''''''''''''''''

        MouseHook.HookMouse()
    End Sub
End Class