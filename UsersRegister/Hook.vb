﻿Imports System.Runtime.InteropServices

Public Class Hook
    Private Structure MSLLHOOKSTRUCT
        Public pt As Point
        Public mouseData As Int32
        Public flags As Int32
        Public time As Int32
        Public extra As IntPtr
    End Structure

    Private _mouseHook As IntPtr
    Private Const WH_MOUSE_LL As Int32 = 14

    Private Delegate Function MouseHookDelegate(ByVal nCode As Int32, ByVal wParam As IntPtr, ByRef lParam As MSLLHOOKSTRUCT) As Int32
    <MarshalAs(UnmanagedType.FunctionPtr)> Private _mouseProc As MouseHookDelegate
    Private Declare Function SetWindowsHookExW Lib "user32.dll" (ByVal idHook As Int32, ByVal HookProc As MouseHookDelegate, ByVal hInstance As IntPtr, ByVal wParam As Int32) As IntPtr
    Private Declare Function UnhookWindowsHookEx Lib "user32.dll" (ByVal hook As IntPtr) As Boolean
    Private Declare Function CallNextHookEx Lib "user32.dll" (ByVal idHook As Int32, ByVal nCode As Int32, ByVal wParam As IntPtr, ByRef lParam As MSLLHOOKSTRUCT) As Int32
    Private Declare Function GetCurrentThreadId Lib "kernel32.dll" () As Integer
    Private Declare Function GetModuleHandleW Lib "kernel32.dll" (ByVal fakezero As IntPtr) As IntPtr


    Public Function HookMouse() As Boolean
        'Debug.Print("Mouse Hooked")
        If _mouseHook = IntPtr.Zero Then
            _mouseProc = New MouseHookDelegate(AddressOf MouseHookProc)
            _mouseHook = SetWindowsHookExW(WH_MOUSE_LL, _mouseProc, GetModuleHandleW(IntPtr.Zero), 0)
        End If
        Return _mouseHook <> IntPtr.Zero
    End Function

    Public Sub UnHookMouse()
        'Debug.Print("Mouse UnHooked")
        If _mouseHook = IntPtr.Zero Then Return
        UnhookWindowsHookEx(_mouseHook)
        _mouseHook = IntPtr.Zero
    End Sub

    Private Function MouseHookProc(ByVal nCode As Int32, ByVal wParam As IntPtr, ByRef lParam As MSLLHOOKSTRUCT) As Int32
        'Debug.Print("Message = {0}, x={1}, y={2}", wParam.ToInt32, lParam.pt.X, lParam.pt.Y)
        If wParam.ToInt32 = 513 Then
            '' interrupt the left mouse button event here, but don't know what to return to do so.
            ' MsgBox("your mouse left clicked")
            In_Out_Time = 1
        ElseIf wParam.ToInt32 = 516 Then
            In_Out_Time = 2
        ElseIf wParam.ToInt32 = 519 Then
            In_Out_Time = 3
        End If
        Return CallNextHookEx(WH_MOUSE_LL, nCode, wParam, lParam)
    End Function
End Class
