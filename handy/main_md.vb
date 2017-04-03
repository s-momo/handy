Imports System.Drawing

Module main_md
    Private appPath As [String]
    Private iconPath As [String]
    Public IdImg As Bitmap
    Public ClientImg As Bitmap
    Public StaffImg As Bitmap
    Public CodeImg As Bitmap
    Public BarcodeImg As Bitmap
    Public SearchImg As Bitmap
    Public MenuImg As Bitmap
    Public BoxImg As Bitmap
    Public DayImg As Bitmap
    Public Day48Img As Bitmap
    Public ChangeImg As Bitmap
    Public zaikoImg As Bitmap
    Public RightOnImg As Bitmap
    Public RightOffImg As Bitmap
    Public LeftOnImg As Bitmap
    Public LeftOffImg As Bitmap
    Public EndImg As Bitmap
    Public NoneImg As Bitmap
    Public MenuBarImg As Bitmap
    Public ZaikoMenuOnImg As Bitmap
    Public ZaikoMenuOffImg As Bitmap
    'キャプチャーフラグ-----------------
    Private CpFlg As Boolean = False
    '-------------------------------------
    Sub New()
        Try
            appPath = path()
            iconPath = appPath & "icon\"
            IdImg = New Bitmap(appPath & "1.png")
            ClientImg = New Bitmap(appPath & "2.png")
            StaffImg = New Bitmap(appPath & "3.png")
            CodeImg = New Bitmap(appPath & "code.png")
            BarcodeImg = New Bitmap(appPath & "barcode.png")
            SearchImg = New Bitmap(appPath & "search.png")
            MenuImg = New Bitmap(appPath & "menu.png")
            BoxImg = New Bitmap(appPath & "box.png")
            DayImg = (New Bitmap(appPath & "day.png"))
            Day48Img = New Bitmap(appPath & "day48.png")
            ChangeImg = New Bitmap(appPath & "change.png")
            zaikoImg = New Bitmap(appPath & "zaiko.png")
            RightOnImg = New Bitmap(iconPath & "right_on.png")
            RightOffImg = New Bitmap(iconPath & "right_off.png")
            LeftOnImg = New Bitmap(iconPath & "left_on.png")
            LeftOffImg = New Bitmap(iconPath & "left_off.png")
            EndImg = New Bitmap(iconPath & "end.png")
            NoneImg = New Bitmap(iconPath & "none.png")
            MenuBarImg = New Bitmap(iconPath & "menu.gif")
            ZaikoMenuOnImg = New Bitmap(iconPath & "menu_on.bmp")
            ZaikoMenuOffImg = New Bitmap(iconPath & "menu_off.bmp")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function path()
        'アプリ実行パスの取得
        Dim app As [String] = LoginForm.[GetType].Assembly.GetModules()(0).FullyQualifiedName
        Dim en As Int32 = app.LastIndexOf("\")
        Return app.Substring(0, en) & "\"
    End Function

    Public Sub LoadForm(ByVal form As Form)
        form.MaximizeBox = Not form.MaximizeBox
        form.MinimizeBox = Not form.MinimizeBox
        form.ControlBox = False
        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub cp(ByVal Name As String)
        If CpFlg Then
            If Not System.IO.Directory.Exists(appPath & "cp") Then
                System.IO.Directory.CreateDirectory(appPath & "cp")
            End If
            Dim FileName As String = appPath & "cp\" & Name
            Dim p As Process = Process.Start("\Windows\BtDisplayCapture.exe", "-f""" & FileName & """ -tj")
        End If
    End Sub

    Public Function GetUpdate() As Boolean
        Dim p As New System.Diagnostics.Process()
        p.StartInfo.FileName = appPath & "VersionCheck.exe"
        Return p.Start()
    End Function
End Module
