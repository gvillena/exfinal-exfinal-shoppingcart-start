Public Class ComprarForm


    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click

        ' Declarando venta
        Dim venta As New Venta

        ' Inicializando venta
        ' venta.______ = _______

        ' Agregando venta a archivo json 
        VentaIO.AddVenta(venta)

    End Sub
End Class