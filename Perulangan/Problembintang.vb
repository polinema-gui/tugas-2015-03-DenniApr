Public Class Problembintang
    Dim hasil As String = ""

    Private Sub Sub1_Click(sender As Object, e As EventArgs) Handles Sub1.Click
        Try
            Select Case polacombo1.Text
                Case "Pyramid"
                    pyramid(enter1.Text)
                Case "Hollow Pyramid"
                    hollowPyramid(enter1.Text)
                Case "Inverted Pyramid"
                    invertedPyramid(enter1.Text)
                Case "Hollow Inverted Pyramid"
                    hollowInvertedPyramid(enter1.Text)
            End Select
        Catch ex As Exception

        End Try
    End Sub
    Private Sub pyramid(max As Integer)
        Dim kolom1 As Integer = max
        Dim kolom2 As Integer = max
        For brs As Integer = 1 To max
            For klm As Integer = 1 To max * 2 - 1
                If (klm < kolom1 Or klm > kolom2) Then
                    Me.hasil &= "  "
                Else
                    Me.hasil &= "*"
                End If
            Next
            kolom1 -= 1
            kolom2 += 1
            Me.hasil &= vbCrLf
        Next
        hasil1.Text = hasil
        hasil = ""
    End Sub
    Private Sub hollowPyramid(max As Integer)
        Dim kolom1 As Integer = max
        Dim kolom2 As Integer = max
        For brs As Integer = 1 To max
            For klm As Integer = 1 To max * 2 - 1
                If (brs < max) Then
                    If (klm = kolom1 Or klm = kolom2) Then
                        Me.hasil &= "*"
                    Else
                        Me.hasil &= "  "
                    End If
                Else
                    Me.hasil &= "*"
                End If
            Next
            kolom1 -= 1
            kolom2 += 1
            Me.hasil &= vbCrLf
        Next
        hasil1.Text = hasil
        hasil = ""
    End Sub
    Private Sub invertedPyramid(max As Integer)
        Dim kolom1 As Integer = 0
        Dim kolom2 As Integer = max * 2
        For brs As Integer = 1 To max
            For klm As Integer = 1 To max * 2 - 1
                If (klm > kolom1 And klm < kolom2) Then
                    Me.hasil &= "*"
                Else
                    Me.hasil &= "  "
                End If
            Next
            Me.hasil &= vbCrLf
            kolom1 += 1
            kolom2 -= 1
        Next
        hasil1.Text = hasil
        Me.hasil = ""
    End Sub
    Private Sub hollowInvertedPyramid(max As Integer)
        Dim kolom1 As Integer = 1
        Dim kolom2 As Integer = max * 2 - 1
        For brs As Integer = 1 To max
            For klm As Integer = 1 To max * 2 - 1
                If (brs = 1) Then
                    Me.hasil &= "*"
                Else
                    If (klm = kolom1 Or klm = kolom2) Then
                        Me.hasil &= "*"
                    Else
                        Me.hasil &= "  "
                    End If
                End If
            Next
            kolom1 += 1
            kolom2 -= 1
            Me.hasil &= vbCrLf
        Next
        hasil1.Text = hasil
        Me.hasil = ""
    End Sub
End Class