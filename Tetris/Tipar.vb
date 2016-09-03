Public Class Tipar
    Public Enum OrientarePiesa As Integer
        SUS
        STANGA
        JOS
        DREAPTA
    End Enum

    Public col, row As Integer
    Public piesaJoc(,) As Integer
    Public orientare As Integer
    Public cuburi As List(Of Cub)
    Public culoare As Pen

    Public Sub New(p As Integer(,), c As Integer, r As Integer, o As Integer, pp As Pen)
        piesaJoc = p
        col = c
        row = r
        orientare = o
        culoare = pp

        cuburi = New List(Of Cub)

        For j As Integer = 0 To col - 1
            For i As Integer = 0 To row - 1
                If piesaJoc(i, j) = 1 Then
                    Dim cube As Cub = New Cub(j, i, culoare)
                    cuburi.Add(cube)
                End If
            Next
        Next
    End Sub
End Class