Public Class Form1
    Public attack As Integer
    Public defender As Integer
    Public tottalbutton = 3
    Public remainattack As Integer
    Public remaindefender As Integer
    Public arrayattack() As Integer
    Public arraydefender() As Integer
    Public a As Integer
    Public b As Integer
    Public c As Integer
    Public d As Integer
    Public l As Integer
    Public f As Integer
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        attack = Convert.ToInt32(TextBox1.Text)
        defender = Convert.ToInt32(TextBox2.Text)
        crlr()

        If defender <> 0 Then
            If attack >= tottalbutton Then
                createrandom()
                Button1.Text = CStr(a)
                Button2.Text = CStr(b)
                Button3.Text = CStr(c)

            ElseIf attack = 2 Then


                createrandom()
                Button1.Text = CStr(a)
                Button2.Text = CStr(b)
                Button3.Text = "0"

            ElseIf attack = 1 Then
                createrandom()
                Button1.Text = CStr(a)
                Button2.Text = "0"
                Button3.Text = "0"
            ElseIf attack = 0 Then
                Button1.Text = "0"
                Button2.Text = "0"
                Button3.Text = "0"
            End If
        End If
        If attack <> 0 Then
            If defender >= tottalbutton Then

                createrandom()
                Button4.Text = CStr(d)
                Button5.Text = CStr(l)
                Button6.Text = CStr(f)
            ElseIf defender = 2 Then
                createrandom()
                Button4.Text = CStr(d)
                Button5.Text = CStr(l)
                Button6.Text = "0"
            ElseIf defender = 1 Then
                createrandom()

                Button4.Text = CStr(d)
                Button5.Text = "0"
                Button6.Text = "0"
            ElseIf defender = 0 Then
                Button4.Text = "0"
                Button5.Text = "0"
                Button6.Text = "0"

            End If
        End If

        If (Convert.ToInt32(Button1.Text) <> 0 And Convert.ToInt32(Button4.Text) <> 0) Then
            If Convert.ToInt32(Button1.Text) > Convert.ToInt32(Button4.Text) Then
                defender = defender - 1
                Label4.Text = "Lost"
                Label1.Text = "Win"
            Else
                attack = attack - 1
                Label1.Text = "Lost"
                Label4.Text = "Win"
            End If
        End If
        If (Convert.ToInt32(Button2.Text) <> 0 And Convert.ToInt32(Button5.Text) <> 0) Then
            If Convert.ToInt32(Button2.Text) > Convert.ToInt32(Button5.Text) Then
                defender = defender - 1
                Label5.Text = "Lost"
                Label2.Text = "Win"
            Else
                attack = attack - 1
                Label2.Text = "Lost"
                Label5.Text = "win"
            End If
        End If
        If (Convert.ToInt32(Button3.Text) <> 0 And Convert.ToInt32(Button6.Text) <> 0) Then
            If Convert.ToInt32(Button3.Text) > Convert.ToInt32(Button6.Text) Then
                defender = defender - 1
                Label6.Text = "Lost"
                Label3.Text = "Win"
            Else
                attack = attack - 1
                Label3.Text = "Lost"
                Label6.Text = "Win"
            End If
        End If
        TextBox1.Text = CStr(attack)
        TextBox2.Text = CStr(defender)
        changecolr()
        win()
    End Sub

    Public Sub createrandom()

        a = Int((6 - 1 + 1) * Rnd() + 1)
        b = Int((6 - 1 + 1) * Rnd() + 1)
        c = Int((6 - 1 + 1) * Rnd() + 1)
        d = Int((6 - 1 + 1) * Rnd() + 1)
        l = Int((6 - 1 + 1) * Rnd() + 1)
        f = Int((6 - 1 + 1) * Rnd() + 1)
        Dim a1 = New Integer() {a, b, c}
        Dim a2 = New Integer() {d, l, f}
        Array.Sort(a1)
        a = a1(2)
        b = a1(1)
        c = a1(0)

        Array.Sort(a2)
        d = a2(2)
        l = a2(1)
        f = a2(0)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button1.Text = " "
        Button2.Text = " "
        Button3.Text = " "
        Button4.Text = " "
        Button5.Text = " "
        Button6.Text = " "
        Label1.Text = " "
        Label2.Text = " "
        Label4.Text = " "
        Label5.Text = " "
        Label3.Text = " "
        Label6.Text = " "
        TextBox1.Text = " "
        TextBox2.Text = " "
        Button1.BackColor = Color.Blue
        Button2.BackColor = Color.Blue
        Button3.BackColor = Color.Blue
        Button4.BackColor = Color.Blue
        Button5.BackColor = Color.Blue
        Button6.BackColor = Color.Blue


    End Sub
    Public Sub crlr()
        Label1.Text = " "
        Label2.Text = " "
        Label4.Text = " "
        Label5.Text = " "
        Label3.Text = " "
        Label6.Text = " "
        TextBox1.Text = " "
        TextBox2.Text = " "
        Label9.Text = "Who Win"

    End Sub
    Public Sub changecolr()
        If Convert.ToInt32(Button1.Text) = 0 Then
            Button1.BackColor = Color.Red
        Else
            Button1.BackColor = Color.Blue
        End If
        If Convert.ToInt32(Button2.Text) = 0 Then
            Button2.BackColor = Color.Red
        Else
            Button2.BackColor = Color.Blue
        End If
        If Convert.ToInt32(Button3.Text) = 0 Then
            Button3.BackColor = Color.Red
        Else
            Button3.BackColor = Color.Blue
        End If
        If Convert.ToInt32(Button4.Text) = 0 Then
            Button4.BackColor = Color.Red
        Else
            Button4.BackColor = Color.Blue
        End If
        If Convert.ToInt32(Button5.Text) = 0 Then
            Button5.BackColor = Color.Red
        Else
            Button5.BackColor = Color.Blue
        End If
        If Convert.ToInt32(Button6.Text) = 0 Then
            Button6.BackColor = Color.Red
        Else
            Button6.BackColor = Color.Blue
        End If
    End Sub
    Public Sub win()
        If (Convert.ToInt32(Button1.Text) = 0 And Convert.ToInt32(Button2.Text) = 0 And Convert.ToInt32(Button3.Text) = 0) Then
            Label9.Text = "Defender Win"
        End If
        If (Convert.ToInt32(Button4.Text) = 0 And Convert.ToInt32(Button5.Text) = 0 And Convert.ToInt32(Button6.Text) = 0) Then
            Label9.Text = "Attacker Win"
        End If
    End Sub


End Class
