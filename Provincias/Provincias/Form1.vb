Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbx_agregar.BackColor = Color.FromArgb(150, Color.Black)
        gbx_provincias.BackColor = Color.FromArgb(150, Color.Black)
    End Sub

    Private Sub Btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim provincia, codigo As String
        Dim poblacion As Integer
        provincia = txt_provincia.Text
        codigo = txt_codigo.Text
        poblacion = txt_poblacion.Text
        Dim li_definicion As New ListViewItem(provincia + " : " + codigo + " : " + poblacion.ToString)
        li_definicion.SubItems.AddRange(New String() {provincia, codigo, poblacion})
        lv_provincias.Items.Add(li_definicion)
    End Sub

    Private Sub Btn_mayor_Click(sender As Object, e As EventArgs) Handles btn_mayor.Click
        Dim mayor As Integer
        Dim provM As String
        mayor = 0
        provM = ""
        For Each item As ListViewItem In Me.lv_provincias.Items
            If (CInt(item.SubItems(3).Text) > mayor) Then
                mayor = CInt(item.SubItems(3).Text)
                provM = item.SubItems(1).Text
            End If
        Next
        MsgBox("LA PROVINCIA CON MAYOR POBLACION ES " + provM + " con " + mayor.ToString + " PERSONAS")
    End Sub

    Private Sub Btn_menor_Click(sender As Object, e As EventArgs) Handles btn_menor.Click
        Dim menor As Integer
        Dim provM As String
        menor = CInt(Me.lv_provincias.Items.Item(0).SubItems(3).Text)
        provM = ""
        For Each item As ListViewItem In Me.lv_provincias.Items
            If (CInt(item.SubItems(3).Text) < menor) Then
                menor = CInt(item.SubItems(3).Text)
                provM = item.SubItems(1).Text
            End If
        Next
        MsgBox("LA PROVINCIA CON MENOR POBLACION ES " + provM + " con " + menor.ToString + " PERSONAS")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_provincia.Text = ""
        txt_codigo.Text = ""
        txt_poblacion.Text = ""
    End Sub
End Class
