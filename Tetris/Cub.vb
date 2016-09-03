Public Class Cub
    Public x, y As Integer
    Public culoare As Pen

    Public Sub New(xx As Integer, yy As Integer, p As Pen)
        x = xx
        y = yy
        culoare = p
    End Sub

    Public Sub setColor(c As Pen)
        culoare = c
    End Sub

    Public Sub setPosition(xx As Integer, yy As Integer)
        x = xx
        y = yy
    End Sub

    Public Sub Draw(xpos As Integer, ypos As Integer, latura As Integer, e As PaintEventArgs)
        Dim brush = New SolidBrush(culoare.Color)
        e.Graphics.FillRectangle(brush, (xpos + x) * latura, (ypos + y) * latura, latura, latura)
        e.Graphics.DrawRectangle(Pens.Black, (xpos + x) * latura, (ypos + y) * latura, latura, latura)
    End Sub
End Class