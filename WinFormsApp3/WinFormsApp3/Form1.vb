Public Class Form1

    Dim firstValue, secondValue, result As Double
    Dim SeconValue As Single
    Dim Op As String
    Dim trigo As String

    Private Sub Num_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click, Button0.Click, BtnTitik.Click
        Dim Num As Button = sender

        If (Display.Text = "0") Then
            Display.Text = ""
            Display.Text = Num.Text
        ElseIf (Num.Text = ".") Then
            If (Not Display.Text.Contains(".")) Then
                Display.Text = Display.Text + Num.Text
            End If
        Else
            Display.Text = Display.Text + Num.Text
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSamaDengan_Click(sender As Object, e As EventArgs) Handles BtnSamaDengan.Click
        secondValue = Display.Text


        If Op = "+" Then
            result = firstValue + secondValue
            Display.Text = result
        ElseIf Op = "-" Then
            result = firstValue - secondValue
            Display.Text = result
        ElseIf Op = "*" Then
            result = firstValue * secondValue
            Display.Text = result
        ElseIf Op = "/" Then
            result = firstValue / secondValue
            Display.Text = result
        ElseIf Op = "X^Y" Then
            result = firstValue ^ secondValue
            Display.Text = result
        End If
    End Sub

    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles BtnC.Click
        Display.Text = "0"
    End Sub

    Private Sub BtnPlusMinus_Click(sender As Object, e As EventArgs) Handles BtnPlusMinus.Click
        If (Display.Text.Contains("-")) Then
            Display.Text = Display.Text.Remove(0, 1)
        Else
            Display.Text = "-" + Display.Text
        End If
    End Sub


    Private Sub BtnPhi_Click(sender As Object, e As EventArgs) Handles BtnPhi.Click
        Display.Text = "3.14159265358979323846"
    End Sub

    Private Sub BtnLog_Click(sender As Object, e As EventArgs) Handles BtnLog.Click
        Dim hasil As Single
        firstValue = CSng(Display.Text)
        hasil = Math.Log10(firstValue)
        Display.Text = hasil

    End Sub

    Private Sub BtnPangkat2_Click(sender As Object, e As EventArgs) Handles BtnPangkat2.Click
        Dim hasil As Single
        firstValue = CSng(Display.Text)
        hasil = Math.Pow(firstValue, 2)
        Display.Text = hasil
    End Sub

    Private Sub BtnPangkat3_Click(sender As Object, e As EventArgs) Handles BtnPangkat3.Click
        Dim hasil As Single
        firstValue = CSng(Display.Text)
        hasil = Math.Pow(firstValue, 3)
        Display.Text = hasil
    End Sub

    Private Sub Operator_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click, BtnPangkat.Click, BtnKurangi.Click, BtnKali.Click, BtnBagi.Click
        Dim Operat As Button = sender

        firstValue = Display.Text
        Op = Operat.Text
        Display.Text = ""
    End Sub

    Private Sub trigono_Click(sender As Object, e As EventArgs) Handles BtnTanh.Click, Btntan.Click, BtnSinh.Click, Btnsin.Click, BtnCosh.Click, Btncos.Click
        Dim hasil As Single
        Dim Tri As Button = sender
        firstValue = CSng(Display.Text)
        trigo = Tri.Text

        If trigo = "sin" Then
            hasil = Math.Sin(firstValue)
            Display.Text = hasil
        ElseIf trigo = "cos" Then
            hasil = Math.Cos(firstValue)
            Display.Text = hasil
        ElseIf trigo = "tan" Then
            hasil = Math.Tan(firstValue)
            Display.Text = hasil
        ElseIf trigo = "Sinh" Then
            hasil = Math.Sinh(firstValue)
            Display.Text = hasil
        ElseIf trigo = "Cosh" Then
            hasil = Math.Cosh(firstValue)
            Display.Text = hasil
        ElseIf trigo = "Tanh" Then
            hasil = Math.Tanh(firstValue)
            Display.Text = hasil
        End If


    End Sub

    Private Sub Num_Syst(sender As Object, e As EventArgs) Handles BtnOct.Click, BtnHex.Click, BtnDec.Click, BtnBin.Click
        Dim a As Integer = Integer.Parse(Display.Text)
        Dim NumSystem As Button = sender
        Dim num As String = NumSystem.Text

        If num = "Bin" Then
            Display.Text = System.Convert.ToString(a, 2)
        ElseIf num = "Hex" Then
            Display.Text = System.Convert.ToString(a, 16)
        ElseIf num = "Oct" Then
            Display.Text = System.Convert.ToString(a, 8)
        End If


    End Sub

    Private Sub Display_TextChanged(sender As Object, e As EventArgs) Handles Display.TextChanged

    End Sub

    Private Sub BtnSqrt_Click(sender As Object, e As EventArgs) Handles BtnSqrt.Click
        Dim hasil As Single
        firstValue = CSng(Display.Text)
        hasil = Math.Sqrt(firstValue)
        Display.Text = hasil
    End Sub

    Private Sub BtnExp_Click(sender As Object, e As EventArgs) Handles BtnExp.Click
        Dim hasil As Single
        firstValue = CSng(Display.Text)
        hasil = Math.Exp(firstValue)
        Display.Text = hasil
    End Sub



    Private Sub BtnCE_Click(sender As Object, e As EventArgs) Handles BtnCE.Click
        If (Display.Text.Length > 0) Then
            Display.Text = Display.Text.Remove(Display.Text.Length - 1, 1)
        End If
        If (Display.Text = "") Then
            Display.Text = "0"
        End If
    End Sub

    Private Sub Display_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Display.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
