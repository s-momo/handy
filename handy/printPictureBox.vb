Imports System.Drawing
Public Class printPictureBox
    'ピクチャーボックスの画像表示
    Public Shared Sub show_imag(ByVal bmp As Bitmap, ByVal pi_box As PictureBox)
        Dim attr As New System.Drawing.Imaging.ImageAttributes
        attr.SetColorKey(bmp.GetPixel(0, 0), bmp.GetPixel(0, 0))
        Dim dstRect As New Rectangle(0, 0, bmp.Width, bmp.Height)
        Dim cg = pi_box.CreateGraphics
        cg.DrawImage(bmp, dstRect, 0, 0, bmp.Width, bmp.Height, _
          GraphicsUnit.Pixel, attr)
        attr.Dispose()
        cg.Dispose()
    End Sub

    Public Shared Sub showImagAndString(ByVal bmp As Bitmap, ByVal pi_box As PictureBox, ByVal str As String, ByVal bt As SolidBrush)
        Dim attr As New System.Drawing.Imaging.ImageAttributes
        attr.SetColorKey(bmp.GetPixel(0, 0), bmp.GetPixel(0, 0))
        Dim dstRect As New Rectangle(0, 0, bmp.Width, bmp.Height)
        Dim cg = pi_box.CreateGraphics
        cg.DrawImage(bmp, dstRect, 0, 0, bmp.Width, bmp.Height, _
          GraphicsUnit.Pixel, attr)
        Dim ft As New Font(FontFamily.GenericMonospace, 20, FontStyle.Regular)
        cg.DrawString(str, ft, bt, 5, 20)
        attr.Dispose()
        cg.Dispose()

    End Sub

    Public Shared Sub showImagAndStringDeff(ByVal bmp As Bitmap, ByVal pi_box As PictureBox, ByVal str As String, ByVal bt As SolidBrush, ByVal ft As Font, ByVal x As Integer, ByVal y As Integer)
        Dim attr As New System.Drawing.Imaging.ImageAttributes
        attr.SetColorKey(bmp.GetPixel(0, 0), bmp.GetPixel(0, 0))
        Dim dstRect As New Rectangle(0, 0, bmp.Width, bmp.Height)
        Dim cg = pi_box.CreateGraphics
        cg.DrawImage(bmp, dstRect, 0, 0, bmp.Width, bmp.Height, _
          GraphicsUnit.Pixel, attr)
        cg.DrawString(str, ft, bt, 5, 20)
        attr.Dispose()
        cg.Dispose()
    End Sub

    'F1キーイメージ表示
    Public Shared Sub get_F1_imag(ByVal pi_box As PictureBox, Optional ByVal fl As Boolean = True)
        If fl Then
            show_imag(LeftOnImg, pi_box)
        Else
            show_imag(LeftOffImg, pi_box)
        End If
    End Sub
    'F2キーイメージ表示
    Public Shared Sub get_F2_imag(ByVal pi_box As PictureBox, Optional ByVal fl As Boolean = True)
        If fl Then
            show_imag(RightOnImg, pi_box)
        Else
            show_imag(RightOffImg, pi_box)
        End If
    End Sub
    'F4キーイメージ表示
    Public Shared Sub get_F4_imag(ByVal pi_box As PictureBox, ByVal ImgNo As String, Optional ByVal fl As Boolean = True)
        Dim btm As Bitmap
        If fl Then
            Select Case ImgNo
                Case 0
                    btm = EndImg
                Case 1
                    btm = StaffImg
                Case 2
                    btm = MenuImg
                Case 3
                    btm = BarcodeImg
                Case Else
                    btm = EndImg
            End Select
            show_imag(btm, pi_box)
        Else
            show_imag(NoneImg, pi_box)
        End If
    End Sub

    Public Shared Sub Fkye_none(ByVal pi_box As PictureBox)
        show_imag(NoneImg, pi_box)
    End Sub
End Class
