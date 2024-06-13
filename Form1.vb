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


        Next
    End Sub


End Class
