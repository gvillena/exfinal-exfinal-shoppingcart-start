Public Class Venta

    Private _Codigo As Integer
    Private _ItemsVenta As List(Of VentaItem)
    Private _TotalVenta As Double

    Public Property Codigo() As Integer
        Get
            Return _Codigo
        End Get
        Set(ByVal value As Integer)
            _Codigo = value
        End Set
    End Property

    Public Property ItemsVenta() As List(Of VentaItem)
        Get
            Return _ItemsVenta
        End Get
        Set(ByVal value As List(Of VentaItem))
            _ItemsVenta = value
        End Set
    End Property

    Public Property TotalVenta() As Double
        Get
            Return _TotalVenta
        End Get
        Set(ByVal value As Double)
            _TotalVenta = value
        End Set
    End Property

    Public Sub New()
        _Codigo = 0
        _ItemsVenta = New List(Of VentaItem)
    End Sub

    Public Sub AgregarCarrito(prod As Producto, cant As Integer)

        ' Declarando ventaItem
        Dim ventaItem As New VentaItem

        ' Inicializando ventaItem
        ' ventaItem.______ = _______

        ' Agregando ventaItem a lista ItemsVenta
        _ItemsVenta.Add(ventaItem)

    End Sub

End Class
