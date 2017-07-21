Imports System.ComponentModel
Imports AxZKFPEngXControl
Imports UsersRegister.Hook
Public Class AccessForm
    Dim matchType As Integer = 0
    Dim sRegTemplate As String = String.Empty
    Dim sRegTemplate10 As String = String.Empty
    Dim MouseHook As New Hook
    Private Sub Bu_Exit_Click(sender As Object, e As EventArgs) Handles Bu_Exit.Click
        End
    End Sub

    Private Sub AccessForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IOUsersDataSet.UsersStamps' table. You can move, or remove it, as needed.
        Me.UsersStampsTableAdapter.Fill(Me.IOUsersDataSet.UsersStamps)
        'TODO: This line of code loads data into the 'IOUsersDataSet.InOutTable' table. You can move, or remove it, as needed.
        Me.InOutTableTableAdapter.Fill(Me.IOUsersDataSet.InOutTable)
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
    End Sub

    Private Sub AccessForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MouseHook.UnHookMouse()
        AxZKFPEngX1.EndEngine()
    End Sub

    Private Sub InOutTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles InOutTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InOutTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IOUsersDataSet)
    End Sub
    Private Sub AxZKFPEngX1_OnImageReceived(sender As Object, e As IZKFPEngXEvents_OnImageReceivedEvent) Handles AxZKFPEngX1.OnImageReceived
        Dim HDC As Long = PB_Stamp.CreateGraphics.GetHdc.ToInt32
        If (e.aImageValid) Then
            AxZKFPEngX1.PrintImageAt(HDC, 0, 0, AxZKFPEngX1.ImageWidth / 2.5, AxZKFPEngX1.ImageHeight / 2.5)
        End If
    End Sub
    Private Sub AxZKFPEngX1_OnCapture(sender As Object, e As IZKFPEngXEvents_OnCaptureEvent) Handles AxZKFPEngX1.OnCapture
        Dim RegChanged As Boolean = False
        Select Case In_Out_Time
            Case 1
                Dim sTemp As String = String.Empty
                Dim bTemp As String = String.Empty
                sTemp = AxZKFPEngX1.GetTemplateAsString()
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


            Case 2
                Dim sTemp As String = String.Empty
                Dim bTemp As String = String.Empty
                sTemp = AxZKFPEngX1.GetTemplateAsString()
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

        End Select
    End Sub

End Class