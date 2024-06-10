Public Class Form1

    Dim y0, x0, g, v, av, it, taux, t, vx, vy, vvi, avi As Double
    Dim yRelativo, xRelativo, rebotes As Integer
    Dim v0X, v0Y, X, Y, Alt_Total, Desp_Total As Double
    Dim coordenadaInicialXPelota, coordenadaInicialYPelota As Integer
    Dim contador As Integer

    Private Sub ButtonReiniciar_Click(sender As Object, e As EventArgs) Handles ButtonReiniciar.Click
        PBPelota.Location = New Point(ParedIzquierda.Location.X + ParedIzquierda.Width, Piso.Location.Y - PBPelota.Height)
        TextBoxX0.Text = 0
        TextBoxY0.Text = 0
        Timer1.Enabled = False
        ButtonIniciar.Enabled = True
        Chart1.Series(0).Points.Clear()
        DataGridView1.Rows.Clear()
        DataGridView2.Rows.Clear()

    End Sub




    Private Sub IntervaloViento_TextChanged(sender As Object, e As EventArgs) Handles IntervaloViento.TextChanged
        If (Val(IntervaloViento.Text) < 0) Then
            IntervaloViento.Text = 0.1
        End If
    End Sub

    Private Sub Gravedad_TextChanged(sender As Object, e As EventArgs) Handles Gravedad.TextChanged
        If (Val(Gravedad.Text) < 0) Then
            Gravedad.Text = 0.1
        End If
    End Sub

    Private Sub AnguloVelocidad_TextChanged(sender As Object, e As EventArgs) Handles AnguloVelocidad.TextChanged

        If (Val(AnguloVelocidad.Text) < 0) Then
            AnguloVelocidad.Text += 360
        ElseIf (Val(AnguloVelocidad.Text) >= 360) Then
            AnguloVelocidad.Text = Val(AnguloVelocidad.Text) - 360
        End If
    End Sub

    Private Sub MagnitudVelocidad_TextChanged(sender As Object, e As EventArgs) Handles MagnitudVelocidad.TextChanged
        If (Val(MagnitudVelocidad.Text) < 0) Then
            MagnitudVelocidad.Text = 0
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Y = -0.5 * taux ^ 2 * g + v0Y * taux + y0
        X = v0X * taux + x0
        vx = v0X
        vy = -g * taux + v0Y


        PBPelota.Location = New Point(X + coordenadaInicialXPelota, coordenadaInicialYPelota - Y)

        Chart1.Series(0).Points.AddXY(PBPelota.Location.X, -PBPelota.Location.Y)

        DataGridView1.Rows.Add(contador, Math.Round(t, 1), Math.Round(PBPelota.Location.X, 2),
                                Math.Round(-PBPelota.Location.Y, 2),
                                "(" & Math.Round(PBPelota.Location.X, 2) & "," & Math.Round(-PBPelota.Location.Y, 2) & ")",
                                Math.Round(vx, 2), Math.Round(vy, 2), vvi)


        taux += 0.1
        contador += 1
        t += 0.1

        If PBPelota.Bounds.IntersectsWith(ParedDerecha.Bounds) Then
            DataGridView2.Rows.Add("Tiempo Vuelo Rebote " & rebotes, Math.Round(taux, 2))
            DataGridView2.Rows.Add("Altura Max Rebote " & rebotes, Math.Round((v0Y ^ 2 / (2 * g)), 2))
            DataGridView2.Rows.Add("Desplazamiento Rebote " & rebotes, Math.Round(Math.Abs(PBPelota.Location.X - coordenadaInicialXPelota), 2))
            Alt_Total += v0Y ^ 2 / (2 * g)
            Desp_Total += Math.Abs(PBPelota.Location.X - coordenadaInicialXPelota)
            v0X = vx * 0.5 * -1
            coordenadaInicialXPelota = ParedDerecha.Location.X - PBPelota.Width - 0.3
            coordenadaInicialYPelota = PBPelota.Location.Y - 0.05
            taux = 0
            taux += 0.1
            rebotes += 1
        End If

        If PBPelota.Bounds.IntersectsWith(ParedIzquierda.Bounds) Then
            DataGridView2.Rows.Add("Tiempo Vuelo Rebote " & rebotes, Math.Round(taux, 2))
            DataGridView2.Rows.Add("Altura Max Rebote " & rebotes, Math.Round((v0Y ^ 2 / (2 * g)), 2))
            DataGridView2.Rows.Add("Desplazamiento Rebote " & rebotes, Math.Round(Math.Abs(PBPelota.Location.X - coordenadaInicialXPelota), 2))
            Alt_Total += v0Y ^ 2 / (2 * g)
            Desp_Total += Math.Abs(PBPelota.Location.X - coordenadaInicialXPelota)
            v0X = vx * 0.5 * -1
            coordenadaInicialXPelota = ParedIzquierda.Location.X + ParedIzquierda.Width + 0.3
            coordenadaInicialYPelota = PBPelota.Location.Y - 0.05
            taux = 0
            taux += 0.1
            rebotes += 1
        End If

        If PBPelota.Bounds.IntersectsWith(Piso.Bounds) Then
            DataGridView2.Rows.Add("Tiempo Vuelo Rebote " & rebotes, Math.Round(taux, 2))
            DataGridView2.Rows.Add("Altura Max Rebote " & rebotes, Math.Round((v0Y ^ 2 / (2 * g)), 2))
            DataGridView2.Rows.Add("Desplazamiento Rebote " & rebotes, Math.Round(Math.Abs(PBPelota.Location.X - coordenadaInicialXPelota), 2))
            Alt_Total += v0Y ^ 2 / (2 * g)
            Desp_Total += Math.Abs(PBPelota.Location.X - coordenadaInicialXPelota)
            v0Y = Math.Abs(vy * 0.5)
            coordenadaInicialYPelota = Piso.Location.Y - PBPelota.Height - 0.3
            coordenadaInicialXPelota = PBPelota.Location.X - 0.05
            taux = 0
            taux += 0.1
            rebotes += 1
        End If

        If PBPelota.Bounds.IntersectsWith(Techo.Bounds) Then
            DataGridView2.Rows.Add("Tiempo Vuelo Rebote " & rebotes, Math.Round(taux, 2))
            DataGridView2.Rows.Add("Altura Max Rebote " & rebotes, Math.Round((v0Y ^ 2 / (2 * g)), 2))
            DataGridView2.Rows.Add("Desplazamiento Rebote " & rebotes, Math.Round(Math.Abs(PBPelota.Location.X - coordenadaInicialXPelota), 2))
            Alt_Total += v0Y ^ 2 / (2 * g)
            Desp_Total += Math.Abs(PBPelota.Location.X - coordenadaInicialXPelota)
            v0Y = -Math.Abs(vy * 0.5)
            coordenadaInicialYPelota = Techo.Location.Y + Techo.Height + 0.5
            coordenadaInicialXPelota = PBPelota.Location.X - 0.05
            taux = 0
            taux += 0.1
            rebotes += 1
        End If

        If rebotes > 2 Then
            DataGridView2.Rows.Add("Tiempo Vuelo Total", Math.Round(t, 2))
            DataGridView2.Rows.Add("Altura Maxima Total", Math.Round(Alt_Total, 2))
            DataGridView2.Rows.Add("Dezplazamiento Total", Math.Round(Desp_Total, 2))
            Timer1.Enabled = False
            Timer2.Enabled = False
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim vi0X, vi0Y As Double

        vi0X = vvi * (Math.Cos(avi))
        vi0Y = vvi * (Math.Sin(avi))

        v0X += vi0X
        v0Y += vi0Y

    End Sub


    Private Sub ButtonIniciar_Click(sender As Object, e As EventArgs) Handles ButtonIniciar.Click
        coordenadaInicialXPelota = PBPelota.Location.X
        coordenadaInicialYPelota = PBPelota.Location.Y
        y0 = 0
        x0 = 0
        g = Val(Gravedad.Text)
        v = Val(MagnitudVelocidad.Text)
        av = Val(AnguloVelocidad.Text) * Math.PI / 180
        it = Val(IntervaloViento.Text)
        taux = 0
        rebotes = 0
        t = 0
        contador = 0
        Alt_Total = 0
        Desp_Total = 0

        v0X = v * (Math.Cos(av))
        v0Y = v * (Math.Sin(av))

        Randomize()
        vvi = (Rnd() * (20 - 0) + 0)
        avi = (Rnd() * (360 - 0) + 0) * Math.PI / 180


        'MsgBox(Math.Cos(av) & " " & Math.Sin(av))
        Timer1.Enabled = True
        Timer2.Interval = 1000 * it
        Timer2.Enabled = True

        ButtonIniciar.Enabled = False
    End Sub




    Private Sub TextBoxX0_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX0.TextChanged
        PBPelota.Location = New Point(Val(TextBoxX0.Text) + xRelativo, PBPelota.Location.Y)
        If (Val(TextBoxX0.Text) < 0) Then
            TextBoxX0.Text = 0
        ElseIf (PBPelota.Location.X > (ParedDerecha.Location.X - PBPelota.Width)) Then
            TextBoxX0.Text = ParedDerecha.Location.X - PBPelota.Width
        End If
    End Sub



    Private Sub TextBoxY0_TextChanged(sender As Object, e As EventArgs) Handles TextBoxY0.TextChanged
        PBPelota.Location = New Point(PBPelota.Location.X, yRelativo -
                                      Val(TextBoxY0.Text) - PBPelota.Height)
        If (Val(TextBoxY0.Text) < 0) Then
            TextBoxY0.Text = 0
        ElseIf (PBPelota.Location.Y < (Techo.Location.Y + Techo.Height)) Then
            TextBoxY0.Text = yRelativo - PBPelota.Height - Techo.Location.Y - Techo.Height
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chart1.Series(0).Points.Clear()
        DataGridView1.Rows.Clear()
        DataGridView2.Rows.Clear()
        yRelativo = Piso.Location.Y
        xRelativo = ParedIzquierda.Location.X + ParedIzquierda.Width
    End Sub

End Class
