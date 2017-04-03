Imports System.Runtime.InteropServices
Public Class TextBoxImeClass
    Private Const ALPHANUMERIC As Int32 = &H0   '半角英数  
    Private Const NATIVE As Int32 = &H1         '直接入力  
    Private Const KATAKANA As Int32 = &H2       'カタカナ  
    Private Const FULLSHAPE As Int32 = &H8      '全角  
    Private Const ROMAN As Int32 = &H10

    Public Enum ImeMode
        NOCONTROL = 0
        OFF = 1
        [ON] = 2
        DISABLE = 3
        HIRAGANA = 4
        KATAKANA = 5
        KATAKANAHALF = 6
        ALPHAFULL = 7
        ALPHA = 8
    End Enum

    <DllImport("coredll")> _
    Private Shared Function ImmGetContext(ByVal hWnd As IntPtr) As IntPtr
    End Function

    <DllImport("coredll")> _
Private Shared Function ImmReleaseContext(ByVal hWnd As IntPtr) As Boolean
    End Function

    <DllImport("coredll")> _
    Private Shared Function ImmSetConversionStatus(ByVal hIMC As IntPtr, ByVal fdwConversion As Int32, ByVal fdwSentence As Int32) As Boolean
    End Function

    <DllImport("coredll")> _
    Private Shared Function ImmSetOpenStatus(ByVal hIMC As IntPtr, ByVal fOpen As Int32) As Boolean
    End Function

    <DllImport("coredll")> _
    Private Shared Function ImmAssociateContext(ByVal hWnd As IntPtr, ByVal hIMC As Int32) As Int32
    End Function


    Public Shared Sub SetImeMode(ByVal ctrl As Control, ByVal mode As ImeMode)
        Dim himc As IntPtr = ImmGetContext(ctrl.Handle)

        Try
            Select Case mode
                Case ImeMode.DISABLE
                    ImmAssociateContext(himc, 0)

                Case ImeMode.OFF
                    ImmAssociateContext(himc, 1)
                    ImmSetOpenStatus(himc, 0)

                Case ImeMode.ON
                    ImmAssociateContext(himc, 1)
                    ImmSetOpenStatus(himc, 1)

                Case Else

                    ImmAssociateContext(himc, 1)
                    ImmSetOpenStatus(himc, 1)

                    Dim dwConversion As Int32

                    Select Case mode
                        Case ImeMode.HIRAGANA
                            dwConversion = NATIVE Or FULLSHAPE Or ROMAN
                        Case ImeMode.KATAKANA
                            dwConversion = NATIVE Or FULLSHAPE Or KATAKANA Or ROMAN
                        Case ImeMode.KATAKANAHALF
                            dwConversion = NATIVE Or KATAKANA Or ROMAN
                        Case ImeMode.ALPHAFULL
                            dwConversion = FULLSHAPE Or ALPHANUMERIC
                        Case ImeMode.ALPHA
                            dwConversion = ALPHANUMERIC
                    End Select
                    ImmSetConversionStatus(himc, dwConversion, 0)



            End Select
        Finally
            ImmReleaseContext(ctrl.Handle)
        End Try

    End Sub
End Class
