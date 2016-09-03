Public Class Piesa
    Public tipare As List(Of Tipar)
    Public piesa As Tipar
    Public rotatie As Integer
    Public Sub New(tiparSus As Tipar, tiparStanga As Tipar, tiparJos As Tipar, tiparDreapta As Tipar)
        tipare = New List(Of Tipar)
        tipare.Add(tiparSus)
        tipare.Add(tiparStanga)
        tipare.Add(tiparJos)
        tipare.Add(tiparDreapta)

        rotatie = Tipar.OrientarePiesa.SUS
        SetRotation(rotatie)
    End Sub

    ' Seteaza rotatia piesei
    Public Sub SetRotation(r As Integer)
        For i As Integer = 0 To tipare.Count - 1
            If tipare(i).orientare = r Then
                piesa = tipare(i)
                Return
            End If
        Next
    End Sub

    Public Function GetRotation(r As Integer) As Tipar
        For i As Integer = 0 To tipare.Count - 1
            If tipare(i).orientare = r Then
                Return tipare(i)
            End If
        Next

        Return Nothing
    End Function

    ' Efectueaza rotatia piesei
    Public Sub DoRotation()
        rotatie += 1
        If rotatie = 4 Then rotatie = 0
        Console.WriteLine("Rotatie = {0}", rotatie)
        SetRotation(rotatie)
    End Sub

    ' Testeaza rotatia
    Public Function CanRotate(matrice(,) As Integer, x As Integer, y As Integer, col As Integer, row As Integer) As Boolean
        Dim p As Tipar
        Dim r = rotatie
        r += 1
        If r = 4 Then r = 0
        For k As Integer = 0 To tipare.Count - 1
            If tipare(k).orientare = r Then
                p = tipare(k)
                If p.row + y - 1 >= row Or p.col + x - 1 >= col Then
                    Return False
                End If

                ' Verificam daca piesa rotita intra in coliziune cu ceva
                For i As Integer = 0 To p.row - 1
                    For j As Integer = 0 To p.col - 1
                        If p.piesaJoc(i, j) = 1 Then
                            If matrice(y + i, x + j) = 1 Then
                                Return False
                            End If
                        End If
                    Next
                Next
            End If
        Next
        Return True
    End Function

    Public Function CanMoveLeft(matrice(,) As Integer, x As Integer, y As Integer, col As Integer, row As Integer) As Boolean
        If x = 0 Then Return False

        ' Verificam daca am atins ceva in partea stanga
        For i As Integer = 0 To piesa.row - 1
            For j As Integer = 0 To piesa.col - 1
                If piesa.piesaJoc(i, j) = 1 Then
                    If matrice(y + i, x + j - 1) = 1 Then
                        Return False
                    End If
                End If
            Next
        Next

        Return True
    End Function

    Public Function CanMoveRight(matrice(,) As Integer, x As Integer, y As Integer, col As Integer, row As Integer) As Boolean
        If piesa.col + x >= col Then Return False

        ' Verificam daca am atins ceva in partea dreapta
        For i As Integer = 0 To piesa.row - 1
            For j As Integer = piesa.col - 1 To 0 Step -1
                If piesa.piesaJoc(i, j) = 1 Then
                    If matrice(y + i, x + j + 1) = 1 Then
                        Return False
                    End If
                End If
            Next
        Next

        Return True
    End Function

    Public Sub Draw(x As Integer, y As Integer, latura As Integer, e As PaintEventArgs)
        If IsNothing(piesa) Then Return
        For i As Integer = 0 To piesa.cuburi.Count - 1
            piesa.cuburi(i).Draw(x, y, latura, e)
        Next
    End Sub

    Public Sub DrawTipar(p As Tipar, x As Integer, y As Integer, latura As Integer, e As PaintEventArgs)
        If IsNothing(p) Then Return
        For i As Integer = 0 To p.cuburi.Count - 1
            p.cuburi(i).Draw(x, y, latura, e)
        Next
    End Sub

    Public Function Hit(matrice(,) As Integer, x As Integer, y As Integer, col As Integer, row As Integer) As Boolean
        ' Verificam daca am atins partea de jos a ecranului
        If y + piesa.row - 1 = row Then Return True

        ' Verificam daca am atins ceva de pe ecran
        For j As Integer = 0 To piesa.col - 1
            For i As Integer = 0 To piesa.row - 1
                If piesa.piesaJoc(i, j) = 1 Then
                    If matrice(y + i, x + j) = 1 Then
                        Return True
                    End If
                End If
            Next
        Next

        Return False
    End Function

    Public Sub Mark(matrice(,) As Integer, matriceCuburi(,) As Cub, x As Integer, y As Integer)
        For j As Integer = 0 To piesa.col - 1
            For i As Integer = 0 To piesa.row - 1
                If piesa.piesaJoc(i, j) = 1 Then
                    matrice(y + i, x + j) = 1
                    matriceCuburi(y + i, x + j) = New Cub(x + j, y + i, piesa.culoare)
                    Console.WriteLine("Marcam Pozitia {0},{1}", x + j, y + i)
                End If
            Next
        Next
    End Sub
End Class
