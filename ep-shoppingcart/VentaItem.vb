Public Class VentaItem

    Private _CodProd As String
    Private _Cantidad As Integer
    Private _Precio As Double
    Private _Importe As Double

    Public Property CodProd() As String
        Get
            Return _CodProd
        End Get
        Set(ByVal value As String)
            _CodProd = value
        End Set
    End Property

    Public Property Cantidad() As Integer
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Integer)
            _Cantidad = value
        End Set
    End Property

    Public Property Precio() As Double
        Get
            Return _Precio
        End Get
        Set(ByVal value As Double)
            _Precio = value
        End Set
    End Property
    Public Property Importe() As Double
        Get
            Return _Importe
        End Get
        Set(ByVal value As Double)
            _Importe = value
        End Set
    End Property

    Public Sub New()
        _CodProd = ""
        _Cantidad = 0
        _Precio = 0
        _Importe = 0
    End Sub

End Class
