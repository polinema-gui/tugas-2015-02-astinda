Public Class Form1
    Dim Bil1, Bil2, Hasil As Double
    Dim sharedoperator As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "1"
        Else
            TextBox1.Text = TextBox1.Text & "1"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "2"
        Else
            TextBox1.Text = TextBox1.Text & "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "3"
        Else
            TextBox1.Text = TextBox1.Text & "3"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "4"
        Else
            TextBox1.Text = TextBox1.Text & "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "5"
        Else
            TextBox1.Text = TextBox1.Text & "5"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "6"
        Else
            TextBox1.Text = TextBox1.Text & "6"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "7"
        Else
            TextBox1.Text = TextBox1.Text & "7"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "8"
        Else
            TextBox1.Text = TextBox1.Text & "8"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "9"
        Else
            TextBox1.Text = TextBox1.Text & "9"
        End If
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "0"
        Else
            TextBox1.Text = TextBox1.Text & "0"
        End If
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        TextBox1.Text = ""
        Bil1 = "0"
        sharedoperator = ""
    End Sub

    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        Bil1 = Val(TextBox1.Text)
        sharedoperator = "+"
        TextBox1.Text = ""
    End Sub

    Private Sub samadengan_Click(sender As Object, e As EventArgs) Handles samadengan.Click
        If sharedoperator = "+" Then
            Hasil = Bil1 + Val(TextBox1.Text)
            TextBox1.Text = Hasil
        ElseIf sharedoperator = "-" Then
            Hasil = Bil1 - TextBox1.Text
            TextBox1.Text = Hasil
        End If
    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        Bil1 = Val(TextBox1.Text)
        sharedoperator = "-"
        TextBox1.Text = ""
    End Sub
End Class
