Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrillaVectorA.ColumnCount = 1
        GrillaVectorA.Rows.Add(8)
        GrillaVectorB.ColumnCount = 1
        GrillaVectorB.Rows.Add(8)
    End Sub
    Private Sub BtnEjecutar_Click(sender As Object, e As EventArgs) Handles BtnEjecutar.Click
        Dim vectorA(8), vectorB(8), contador As Integer
        For i = 0 To 7
            vectorA(i) = InputBox("Cargar 8 valores")
            GrillaVectorA.Rows(i).Cells(0).Value = vectorA(i)
        Next
        For i = 0 To 7
            If i < 4 Then
                contador = i + 4
                vectorB(i) = vectorA(contador)
            Else
                contador = i - 4
                vectorB(i) = vectorA(contador)
            End If
            GrillaVectorB.Rows(i).Cells(0).Value = vectorB(i)
        Next
    End Sub


End Class
