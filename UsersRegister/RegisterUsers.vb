﻿Imports AxZKFPEngXControl
Imports Microsoft.Office.Interop

Public Class RegisterUsers
    Dim matchType As Integer = 0
    Dim sRegTemplate As String = String.Empty
    Dim sRegTemplate10 As String = String.Empty
    Dim addUser As Boolean = False
    Private Sub RegisterUsers_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        AxZKFPEngX1.EndEngine()
    End Sub
    Private Sub RegisterUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UsersDataBaseDataSet2.UsersStamps' table. You can move, or remove it, as needed.
        Me.UsersStampsTableAdapter.Fill(Me.UsersDataBaseDataSet2.UsersStamps)
        If (AxZKFPEngX1.InitEngine = 0) Then
            AxZKFPEngX1.FPEngineVersion = "9"
            Dim fpcHandle As Integer = AxZKFPEngX1.CreateFPCacheDBEx()
            'If AxZKFPEngX1.SensorSN() <> "{CB273F0D-686A-4E17-8B2A-84C6D0DD68D4}" Then End
            StatusLabel2.Text = "Serial Number: " + AxZKFPEngX1.SensorSN() + "   /   "
            StatusLabel1.Text = "Sensor Number: " + AxZKFPEngX1.SensorCount().ToString + "  /   "
            StatusLabel3.Text = "Initial Succeed"
        Else
            AxZKFPEngX1.EndEngine()
            StatusLabel3.Text = "Initial Failed"
        End If
    End Sub

    Private Sub Bu_Reg_Click(sender As Object, e As EventArgs) Handles Bu_Reg.Click
        AxZKFPEngX1.CancelEnroll()
        AxZKFPEngX1.EnrollCount = 3
        AxZKFPEngX1.BeginEnroll()
        StatusLabel3.Text = "Start Register"
        Dim ll = From cont In GroupBox2.Controls Where cont.Name.Contains("TextBox") Order By cont.text, cont.name

        'For Each control As Control In GroupBox2.Controls
        For Each control As Control In ll
            If control.Name.Contains("Stamp") And TypeOf (control) Is TextBox Then
                If control.Text = "" Or control.Text = " " Then
                    control.Focus()
                    Exit For
                End If
            End If
        Next
    End Sub
    Private Sub AxZKFPEngX1_OnImageReceived(sender As Object, e As IZKFPEngXEvents_OnImageReceivedEvent) Handles AxZKFPEngX1.OnImageReceived
        Dim HDC As Long = PB_finger.CreateGraphics.GetHdc.ToInt32
        If (e.aImageValid) Then
            AxZKFPEngX1.PrintImageAt(HDC, 0, 0, AxZKFPEngX1.ImageWidth, AxZKFPEngX1.ImageHeight)
        End If
    End Sub
    Private Sub AxZKFPEngX1_OnFeatureInfo(sender As Object, e As IZKFPEngXEvents_OnFeatureInfoEvent) Handles AxZKFPEngX1.OnFeatureInfo
        Dim str As String = String.Empty
        Dim buffer As String = String.Empty
        Dim t As Integer
        If (AxZKFPEngX1.IsRegister()) Then
            t = AxZKFPEngX1.EnrollIndex()
            str = str + "still press finger " + t.ToString + " times"
        End If
        str += "Fingerprint quality"
        Dim Q As Integer = AxZKFPEngX1.LastQuality()
        If (Q < 50) Then
            str = str + " not good,quality=" + Q.ToString
        Else
            str = str + " good,quality=" + Q.ToString
        End If
        StatusLabel3.Text = str
    End Sub
    Private Sub AxZKFPEngX1_OnEnroll(sender As Object, e As IZKFPEngXEvents_OnEnrollEvent) Handles AxZKFPEngX1.OnEnroll
        Dim FPID As Integer
        Dim fpcHandle As Integer
        If (Not e.actionResult) Then
            MsgBox("Register Faild")
        Else
            sRegTemplate = AxZKFPEngX1.GetTemplateAsStringEx("9")
            If (UsersIdTextBox.Text <> "") Then
                'StampTextBox.Text = sRegTemplate
                setinText(sRegTemplate)
            End If
            sRegTemplate10 = AxZKFPEngX1.GetTemplateAsStringEx("10")
            If (sRegTemplate.Length > 0) Then
                If (sRegTemplate10.Length > 0) Then
                    AxZKFPEngX1.AddRegTemplateStrToFPCacheDBEx(fpcHandle, FPID, sRegTemplate, sRegTemplate10)
                Else
                    MsgBox("Register 10.0 Faild,Template length is Zero")
                End If
                e.aTemplate = AxZKFPEngX1.DecodeTemplate1(sRegTemplate)
                AxZKFPEngX1.SetTemplateLen(e.aTemplate, 602)
                AxZKFPEngX1.SaveTemplate("fingerprint.tpl", e.aTemplate)
                FPID = FPID + 1
                MsgBox("Register Succeed")
                StatusLabel3.Text = "Wait"
            Else
                MsgBox("Register Faild ,Template length is zero")
            End If
        End If
    End Sub
    Private Sub setinText(ByVal sRegTemplateX As String)
        If (Stamp1TextBox.Focused) Then
            Stamp1TextBox.Text = sRegTemplateX
        ElseIf (Stamp2TextBox.Focused) Then
            Stamp2TextBox.Text = sRegTemplateX
        ElseIf (Stamp3TextBox.Focused) Then
            Stamp3TextBox.Text = sRegTemplateX
        ElseIf (Stamp4TextBox.Focused) Then
            Stamp4TextBox.Text = sRegTemplateX
        ElseIf (Stamp5TextBox.Focused) Then
            Stamp5TextBox.Text = sRegTemplateX
        ElseIf (Stamp6TextBox.Focused) Then
            Stamp6TextBox.Text = sRegTemplateX
        ElseIf (Stamp7TextBox.Focused) Then
            Stamp7TextBox.Text = sRegTemplateX
        ElseIf (Stamp8TextBox.Focused) Then
            Stamp8TextBox.Text = sRegTemplateX
        ElseIf (Stamp9TextBox.Focused) Then
            Stamp9TextBox.Text = sRegTemplateX
        ElseIf (Stamp010TextBox.Focused) Then
            Stamp010TextBox.Text = sRegTemplateX
        End If
    End Sub
    Private Sub AxZKFPEngX1_OnCapture(sender As Object, e As IZKFPEngXEvents_OnCaptureEvent) Handles AxZKFPEngX1.OnCapture
        Dim id As Integer = 0
        Dim Score As Integer = 0
        Dim ProcessNum As Integer = 0
        Dim buffer(63) As SByte
        Dim sTemp As String = String.Empty
        Dim RegChanged As Boolean = False
        If (matchType = 1) Then
            Dim bTemp As String = String.Empty
            sTemp = AxZKFPEngX1.GetTemplateAsString()

            If (Stamp1TextBox.Focused) Then
                bTemp = Stamp1TextBox.Text
            ElseIf (Stamp2TextBox.Focused) Then
                bTemp = Stamp2TextBox.Text
            ElseIf (Stamp3TextBox.Focused) Then
                bTemp = Stamp3TextBox.Text
            End If

            'bTemp = StampTextBox.Text 'sRegTemplate ;here we get the save Templet of the Finger Print we will save it in the data base later 
            If (AxZKFPEngX1.VerFingerFromStr(bTemp, sTemp, False, RegChanged)) Then
                StatusLabel3.Text = "Verfiy Succeed"
            Else
                StatusLabel3.Text = "Verfiy Failed"
            End If
        End If
    End Sub
    Private Sub Bu_Ver_Click(sender As Object, e As EventArgs) Handles Bu_Ver.Click
        If (AxZKFPEngX1.IsRegister()) Then
            AxZKFPEngX1.CancelEnroll()
        End If
        StatusLabel3.Text = "Verify"
        matchType = 1

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If (addUser) Then MsgBox("Pls save current user first") : Exit Sub
        '        If UsersStampsBindingSource.Count = 0 Then GoTo SS

        '        If (UserNameTextBox.Text = "" And SectionTextBox.Text = "" And MobileTextBox.Text = "") Then
        '            MsgBox("Error adding recored before save the previus one")
        '            Exit Sub
        '        End If
        'SS:
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True

        UsersStampsBindingNavigator.BindingSource.AddNew()
        UsersStampsBindingNavigator.BindingSource.MoveLast()
        Stamp1TextBox.Text = " "
        Stamp2TextBox.Text = " "
        Stamp3TextBox.Text = " "
        Stamp4TextBox.Text = " "
        Stamp5TextBox.Text = " "
        Stamp6TextBox.Text = " "
        Stamp7TextBox.Text = " "
        Stamp8TextBox.Text = " "
        Stamp9TextBox.Text = " "
        Stamp010TextBox.Text = " "
        addUser = True
    End Sub
    Private Sub UsersStampsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsersStampsBindingNavigatorSaveItem.Click
        Dim msgval As Integer = MsgBox("are you sure ?", MsgBoxStyle.OkCancel, "confirm")
        If msgval = 2 Then Exit Sub
        If (UserNameTextBox.Text = "" Or SectionTextBox.Text = "" Or CodeTextBox.Text = "" Or DesignationComboBox.Text = "") Then
            MsgBox("please fill the basic info's ,mobile is option")
            Exit Sub
        End If
        Me.Validate()
        Me.UsersStampsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UsersDataBaseDataSet2)
        addUser = False
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        MsgBox("Done")
    End Sub

    Private Sub MobileTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MobileTextBox.KeyPress
        If Not IsNumeric(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim xlApp As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet

        Try
            xlWorkBook = xlApp.Workbooks.Open(Application.StartupPath & "\Salaries details.xlsx")
            xlWorkSheet = xlWorkBook.Worksheets("sheet1")
            Dim i As Integer = 1
            Do Until xlWorkSheet.Cells(i, 1).value = ""
                Dim section As String = xlWorkSheet.Cells(i, 1).value
                Dim UserCode As String = xlWorkSheet.Cells(i, 2).value
                Dim username As String = xlWorkSheet.Cells(i, 3).value
                Dim Designation As String = xlWorkSheet.Cells(i, 4).value
                UsersStampsTableAdapter.Insert(UserCode, username, Designation, 0, section, " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ")
                i += 1
            Loop


            'display the cells value B2
            'MsgBox(xlWorkSheet.Cells(2, 2).value)
            'edit the cell with new value

            xlWorkBook.Close()
            xlApp.Quit()



        Catch ex As Exception

        End Try

    End Sub

    Private Sub CB_Edit_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Edit.CheckedChanged
        If CB_Edit.Checked Then
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
        Else
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
        End If
    End Sub
End Class