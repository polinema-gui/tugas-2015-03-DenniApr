Public Class CalMatrix
    Dim kolom As Boolean = True

    Private Sub hitung1_Click(sender As Object, e As EventArgs) Handles Hitung1.Click
        Try
            Dim baris1 As Integer = table1.Lines.Count
            Dim kolom1 As Integer = table1.Lines.ElementAt(0).Split(" ").Length
            Dim baris2 As Integer = table2.Lines.Count
            Dim kolom2 As Integer = table2.Lines.ElementAt(0).Split(" ").Length
            Dim cp1(baris1, kolom1) As Integer
            Dim cp2(baris2, kolom2) As Integer
            cek(baris1, baris2, kolom1, kolom2)
            copyToArray(baris1, baris2, kolom1, kolom2, cp1, cp2)
            operasi(cp1, cp2, baris1, kolom2)
        Catch ex As Exception
            MsgBox("Bukan Angka")
        End Try

    End Sub

    Private Sub copyToArray(ByVal brs1 As Integer, brs2 As Integer, klm1 As Integer, klm2 As Integer, ByRef nilai1(,) As Integer, ByRef nilai2(,) As Integer)
        If (Me.kolom) Then
            For brs As Integer = 0 To brs1 - 1
                For klm As Integer = 0 To klm1 - 1
                    nilai1(brs, klm) = table1.Lines.ElementAt(brs).Split(" ").ElementAt(klm)
                    nilai2(brs, klm) = table2.Lines.ElementAt(brs).Split(" ").ElementAt(klm)
                Next
            Next
        End If
    End Sub

    Private Sub cek(ByVal brs1 As Integer, brs2 As Integer, klm1 As Integer, klm2 As Integer)
        Dim tmp As Boolean = True
        For brs = 0 To brs1 - 2
            If (table1.Lines.ElementAt(brs).Split(" ").Length <> table2.Lines.ElementAt(brs + 1).Split(" ").Length) Then
                tmp = False
            End If
        Next
        For brs = 0 To brs2 - 2
            If (table1.Lines.ElementAt(brs).Split(" ").Length <> table2.Lines.ElementAt(brs + 1).Split(" ").Length) Then
                tmp = False
            End If
        Next
        If (tmp = False) Then
            Me.kolom = False
            Convert.ToInt32(table1.Text)
            Convert.ToInt32(table2.Text)
            MsgBox("Tidak Valid")
        ElseIf (brs1 = brs2 And klm1 = klm2) Then
            Me.kolom = True
        Else
            Me.kolom = False
            MsgBox("Baris dan Kolom Matrix Harus Sama")
        End If
    End Sub

    Private Sub operasi(ByVal matriks1(,) As Integer, matriks2(,) As Integer, batasBaris As Integer, batasKolom As Integer)
        Dim hasil As String = ""
        If (Me.kolom) Then
            Select Case operasi1.Text
                Case "Tambah"
                    For brs As Integer = 0 To batasBaris - 1
                        For klm As Integer = 0 To batasKolom - 1
                            hasil &= (matriks1(brs, klm) + matriks2(brs, klm)).ToString & vbTab
                        Next
                        hasil &= vbCrLf
                    Next
                Case "Kurang"
                    For brs As Integer = 0 To batasBaris - 1
                        For klm As Integer = 0 To batasKolom - 1
                            hasil &= (matriks1(brs, klm) - matriks2(brs, klm)).ToString & vbTab
                        Next
                        hasil &= vbCrLf
                    Next
                Case Else
                    MsgBox("Anda Belum Memilih Operasi")
            End Select
            HasilBox.Text = hasil
        End If
    End Sub
End Class