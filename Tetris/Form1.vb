Public Class Form1
    Public latura As Integer = 20
    Dim x, y As Integer
    Dim col, row As Integer
    Dim matrice(,) As Integer
    Dim matriceCuburi(,) As Cub
    Dim listaPiese As List(Of Piesa)
    Dim nrPiese, k, urmatorul, rotatie As Integer
    Dim p, purm As Piesa
    Dim isGameStarted, isGamePaused As Boolean
    Dim score As Integer
    Dim level As Integer
    Dim puncteCub As Integer = 10
    Dim puncteLinie As Integer = 15
    Dim menuSize As Integer = 160
    Dim menuCol As Integer = menuSize / latura
    Dim linii, piese As Integer
    Dim timp As Integer = 0

    ' litera L 
    Dim type_l0(,) As Integer = {{1, 0}, {1, 0}, {1, 1}}
    Dim tipar_l0 As Tipar = New Tipar(type_l0, 2, 3, Tipar.OrientarePiesa.SUS, Pens.Yellow)
    Dim type_l1(,) As Integer = {{0, 0, 1}, {1, 1, 1}}
    Dim tipar_l1 As Tipar = New Tipar(type_l1, 3, 2, Tipar.OrientarePiesa.STANGA, Pens.Yellow)
    Dim type_l2(,) As Integer = {{1, 1}, {0, 1}, {0, 1}}
    Dim tipar_l2 As Tipar = New Tipar(type_l2, 2, 3, Tipar.OrientarePiesa.JOS, Pens.Yellow)
    Dim type_l3(,) As Integer = {{1, 1, 1}, {1, 0, 0}}
    Dim tipar_l3 As Tipar = New Tipar(type_l3, 3, 2, Tipar.OrientarePiesa.DREAPTA, Pens.Yellow)
    Dim piesa_l As Piesa = New Piesa(tipar_l0, tipar_l1, tipar_l2, tipar_l3)

    ' litera L inversat
    Dim type_li0(,) As Integer = {{0, 1}, {0, 1}, {1, 1}}
    Dim tipar_li0 As Tipar = New Tipar(type_li0, 2, 3, Tipar.OrientarePiesa.SUS, Pens.Yellow)
    Dim type_li1(,) As Integer = {{1, 1, 1}, {0, 0, 1}}
    Dim tipar_li1 As Tipar = New Tipar(type_li1, 3, 2, Tipar.OrientarePiesa.STANGA, Pens.Yellow)
    Dim type_li2(,) As Integer = {{1, 1}, {1, 0}, {1, 0}}
    Dim tipar_li2 As Tipar = New Tipar(type_li2, 2, 3, Tipar.OrientarePiesa.JOS, Pens.Yellow)
    Dim type_li3(,) As Integer = {{1, 0, 0}, {1, 1, 1}}
    Dim tipar_li3 As Tipar = New Tipar(type_li3, 3, 2, Tipar.OrientarePiesa.DREAPTA, Pens.Yellow)
    Dim piesa_li As Piesa = New Piesa(tipar_li0, tipar_li1, tipar_li2, tipar_li3)

    ' litera T
    Dim type_t0(,) As Integer = {{0, 1, 0}, {1, 1, 1}}
    Dim tipar_t0 As Tipar = New Tipar(type_t0, 3, 2, Tipar.OrientarePiesa.SUS, Pens.Red)
    Dim type_t1(,) As Integer = {{0, 1}, {1, 1}, {0, 1}}
    Dim tipar_t1 As Tipar = New Tipar(type_t1, 2, 3, Tipar.OrientarePiesa.STANGA, Pens.Red)
    Dim type_t2(,) As Integer = {{1, 1, 1}, {0, 1, 0}}
    Dim tipar_t2 As Tipar = New Tipar(type_t2, 3, 2, Tipar.OrientarePiesa.JOS, Pens.Red)
    Dim type_t3(,) As Integer = {{1, 0}, {1, 1}, {1, 0}}
    Dim tipar_t3 As Tipar = New Tipar(type_t3, 2, 3, Tipar.OrientarePiesa.DREAPTA, Pens.Red)
    Dim piesa_t As Piesa = New Piesa(tipar_t0, tipar_t1, tipar_t2, tipar_t3)

    ' patratul
    Dim type_p(,) As Integer = {{1, 1}, {1, 1}}
    Dim tipar_p0 As Tipar = New Tipar(type_p, 2, 2, Tipar.OrientarePiesa.SUS, Pens.Blue)
    Dim tipar_p1 As Tipar = New Tipar(type_p, 2, 2, Tipar.OrientarePiesa.STANGA, Pens.Blue)
    Dim tipar_p2 As Tipar = New Tipar(type_p, 2, 2, Tipar.OrientarePiesa.JOS, Pens.Blue)
    Dim tipar_p3 As Tipar = New Tipar(type_p, 2, 2, Tipar.OrientarePiesa.DREAPTA, Pens.Blue)
    Dim piesa_p As Piesa = New Piesa(tipar_p0, tipar_p1, tipar_p2, tipar_p3)

    ' litera s
    Dim type_s0(,) As Integer = {{0, 1, 1}, {1, 1, 0}}
    Dim tipar_s0 As Tipar = New Tipar(type_s0, 3, 2, Tipar.OrientarePiesa.SUS, Pens.Purple)
    Dim type_s1(,) As Integer = {{1, 0}, {1, 1}, {0, 1}}
    Dim tipar_s1 As Tipar = New Tipar(type_s1, 2, 3, Tipar.OrientarePiesa.STANGA, Pens.Purple)
    Dim tipar_s2 As Tipar = New Tipar(type_s0, 3, 2, Tipar.OrientarePiesa.JOS, Pens.Purple)
    Dim tipar_s3 As Tipar = New Tipar(type_s1, 2, 3, Tipar.OrientarePiesa.DREAPTA, Pens.Purple)
    Dim piesa_s As Piesa = New Piesa(tipar_s0, tipar_s1, tipar_s2, tipar_s3)

    ' litera z
    Dim type_z0(,) As Integer = {{1, 1, 0}, {0, 1, 1}}
    Dim tipar_z0 As Tipar = New Tipar(type_z0, 3, 2, Tipar.OrientarePiesa.SUS, Pens.Green)
    Dim type_z1(,) As Integer = {{0, 1}, {1, 1}, {1, 0}}
    Dim tipar_z1 As Tipar = New Tipar(type_z1, 2, 3, Tipar.OrientarePiesa.STANGA, Pens.Green)
    Dim tipar_z2 As Tipar = New Tipar(type_z0, 3, 2, Tipar.OrientarePiesa.JOS, Pens.Green)
    Dim tipar_z3 As Tipar = New Tipar(type_z1, 2, 3, Tipar.OrientarePiesa.DREAPTA, Pens.Green)
    Dim piesa_z As Piesa = New Piesa(tipar_z0, tipar_z1, tipar_z2, tipar_z3)

    ' litera I mare  
    Dim type_imare0(,) As Integer = {{1, 1, 1, 1}}
    Dim tipar_imare0 As Tipar = New Tipar(type_imare0, 4, 1, Tipar.OrientarePiesa.SUS, Pens.Cyan)
    Dim type_imare1(,) As Integer = {{1}, {1}, {1}, {1}}
    Dim tipar_imare1 As Tipar = New Tipar(type_imare1, 1, 4, Tipar.OrientarePiesa.STANGA, Pens.Cyan)
    Dim tipar_imare2 As Tipar = New Tipar(type_imare0, 4, 1, Tipar.OrientarePiesa.JOS, Pens.Cyan)
    Dim tipar_imare3 As Tipar = New Tipar(type_imare1, 1, 4, Tipar.OrientarePiesa.DREAPTA, Pens.Cyan)
    Dim piesa_imare As Piesa = New Piesa(tipar_imare0, tipar_imare1, tipar_imare2, tipar_imare3)

    ' Generarea de numere aleatorii
    Private Function rnd(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static staticRandomGenerator As New System.Random
        Return staticRandomGenerator.Next(Min, Max)
    End Function

    Public Function titluJoc() As String
        If isGameStarted = False Then Return "Tetris"
        Dim s = "Tetris - " & score & " puncte"
        If isGamePaused Then Return s & " - PAUZA" Else Return s
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timerMove.Tick
        If Not isGamePaused Then

            If Not HitTest(x, y + 1) Then y += 1
        End If
    End Sub

    Private Sub timerPaint_Tick(sender As Object, e As EventArgs) Handles timerPaint.Tick
        timp += timerPaint.Interval
        setTimp()
        Refresh()
    End Sub

    Private Sub panelInfo_Paint(sender As Object, e As PaintEventArgs) Handles panelInfo.Paint
        Dim t As Tipar = purm.GetRotation(Tipar.OrientarePiesa.SUS)
        purm.DrawTipar(t, (menuCol - t.col) / 2, 2, latura, e)
    End Sub

    Private Sub setScor()
        lbScor.Text = "Scor: " & score
    End Sub

    Private Sub setTimp()
        lbTimp.Text = "Timp: " & timp \ 1000
    End Sub

    Private Sub setLinii()
        lbLinii.Text = "Linii: " & linii
    End Sub

    Private Sub setPiese()
        lbPiese.Text = "Piese: " & piese
    End Sub

    Private Sub setNivel()
        lbNivel.Text = "Nivel: " & level
    End Sub

    Private Sub setInfo()
        setTimp()
        setPiese()
        setLinii()
        setScor()
        setNivel()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isGamePaused = False
        isGameStarted = True
        score = 0
        level = 1
        linii = 0
        piese = 0

        col = 15
        row = 30
        Me.ClientSize = New Size(col * latura + menuSize, row * latura)
        panelInfo.Size = New Size(menuSize, row * latura)
        panelInfo.Location = New Point(col * latura, 0)
        ReDim matrice(row, col)
        ReDim matriceCuburi(row, col)

        For j As Integer = 0 To col - 1
            For i As Integer = 0 To row - 1
                matrice(i, j) = 0
            Next
        Next

        listaPiese = New List(Of Piesa)
        listaPiese.Add(piesa_l)
        listaPiese.Add(piesa_li)
        listaPiese.Add(piesa_p)
        listaPiese.Add(piesa_s)
        listaPiese.Add(piesa_t)
        listaPiese.Add(piesa_z)
        listaPiese.Add(piesa_imare)
        nrPiese = listaPiese.Count

        k = rnd(0, nrPiese)
        p = listaPiese(k)

        urmatorul = rnd(0, nrPiese)
        purm = listaPiese(urmatorul)

        x = (col - p.piesa.col) \ 2
        y = 0

        piese += 1
        setInfo()

        Me.Text = titluJoc()
        panelInfo.Refresh()
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        DrawMatrice(e)

        p.Draw(x, y, latura, e)
    End Sub

    ' Testam piesa daca intra in coliziune pentru urmatoarea pozitie
    Private Function HitTest(xx As Integer, yy As Integer) As Boolean
        If p.Hit(matrice, xx, yy, col, row) Then
            ' Marcam in matricea noastra cu 1 locurile ocupate de piesa in pozitia ei actuala
            p.Mark(matrice, matriceCuburi, x, y)

            score += puncteCub * p.piesa.cuburi.Count

            Dim l = LiniiTetris()
            If l > 0 Then
                ' Dam bonus cate 50 puncte pt fiecare linie pt fiecare nivel de dificultate in plus fata de primul nivel
                score += l * puncteLinie * col + 50 * (level - 1)
                StergeLinii()
                linii += 1
            End If

            ' Generam o noua piesa
            k = urmatorul
            urmatorul = rnd(0, nrPiese)
            p = listaPiese(k)
            purm = listaPiese(urmatorul)
            piese += 1

            ' Dupa 50 de piese crestem nivelul si crestem viteza de miscare a piesei
            If piese > level * 50 Then
                If timerMove.Interval > 100 Then
                    ' Vom obtine 4*4 = 16 nivele maxime de joc
                    level += 1
                    timerMove.Interval -= 25
                End If
            End If

            x = (col - p.piesa.col) \ 2
            y = 0

            p.rotatie = Tipar.OrientarePiesa.SUS
            p.SetRotation(p.rotatie)

            If p.Hit(matrice, x, y, col, row) Then
                timerMove.Stop()
                timerPaint.Stop()
                MsgBox("Ati pierdut jocul", 0, "Final")
                Me.Close()
                Return True
            End If

            Me.Text = titluJoc()
            setInfo()
            panelInfo.Refresh()

            Return True
        End If

        Return False
    End Function

    Private Sub DrawMatrice(e As PaintEventArgs)
        For j As Integer = 0 To col - 1
            For i As Integer = 0 To row - 1
                If matrice(i, j) = 1 Then
                    matriceCuburi(i, j).Draw(0, 0, latura, e)
                End If
            Next
        Next
    End Sub

    Private Function LiniiTetris() As Integer
        Dim l As Integer
        Dim c As Integer

        For i As Integer = row - 1 To 0 Step -1
            c = 0

            ' cautam liniile in matricea noastra
            For j As Integer = 0 To col - 1
                If matrice(i, j) = 1 Then c += 1
            Next

            ' notam linia gasita cu 2
            If c = col Then
                For j As Integer = 0 To col - 1
                    matrice(i, j) = 2
                Next
                l += 1
            End If
        Next

        Return l
    End Function

    Private Sub StergeLinii()
        Dim fall As Integer = 0

        ' noua matrice
        Dim new_matrice(,) As Integer
        Dim new_matriceCuburi(,) As Cub

        ReDim new_matrice(row, col)
        ReDim new_matriceCuburi(row, col)

        For j As Integer = 0 To col - 1
            For i As Integer = 0 To row - 1
                new_matrice(i, j) = 0
            Next
        Next

        ' copiem datele din matricea veche fara linii, in matricea noua
        For i As Integer = row - 1 To 0 Step -1
            Dim setare As Boolean = False
            For j As Integer = 0 To col - 1
                If matrice(i, j) < 2 Then
                    If matrice(i, j) = 1 Then
                        new_matrice(i + fall, j) = matrice(i, j)
                        new_matriceCuburi(i + fall, j) = New Cub(j, i + fall, matriceCuburi(i, j).culoare)
                    End If
                Else
                    If Not setare Then
                        fall += 1
                        setare = True
                    End If
                End If
            Next
        Next

        matrice = new_matrice
        matriceCuburi = new_matriceCuburi
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Select Case keyData
            ' Mutam piesa la stanga
            Case Keys.Left

                If p.CanMoveLeft(matrice, x, y, col, row) Then
                    If Not HitTest(x - 1, y) Then x = x - 1
                End If
            ' Mutam piesa la dreapta
            Case Keys.Right
                If p.CanMoveRight(matrice, x, y, col, row) Then
                    If Not HitTest(x + 1, y) Then x = x + 1
                End If
            ' Mutam piesa in jos
            Case Keys.Down
                If y + p.piesa.row < row Then
                    If Not HitTest(x, y + 1) Then y = y + 1
                End If
            ' Mutam piesa brusc jos
            Case Keys.Space
                If y + p.piesa.row < row Then
                    While Not HitTest(x, y + 1)
                        y = y + 1
                    End While
                End If
            ' Rotim piesa in sens invers acelor de ceasornic
            Case Keys.Up
                If p.CanRotate(matrice, x, y, col, row) Then
                    If Not HitTest(x, y) Then p.DoRotation()
                End If
            ' Pauza
            Case Keys.P
                isGamePaused = Not isGamePaused
                Me.Text = titluJoc()
        End Select

        Return True
    End Function
End Class