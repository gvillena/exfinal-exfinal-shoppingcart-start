Public Class Producto

    Private _Codigo As String
    Private _Titulo As String
    Private _Precio As Double
    Private _ImgSmall As List(Of String)
    Private _ImgNormal As List(Of String)

    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property

    Public Property Titulo() As String
        Get
            Return _Titulo
        End Get
        Set(ByVal value As String)
            _Titulo = value
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

    Public Property ImgSmall() As List(Of String)
        Get
            Return _ImgSmall
        End Get
        Set(ByVal value As List(Of String))
            _ImgSmall = value
        End Set
    End Property

    Public Property ImgNormal() As List(Of String)
        Get
            Return _ImgNormal
        End Get
        Set(ByVal value As List(Of String))
            _ImgNormal = value
        End Set
    End Property

    Public Sub New()
        _Codigo = 0
        _Titulo = String.Empty
        _Precio = 0
        _ImgSmall = New List(Of String)
        _ImgNormal = New List(Of String)
    End Sub

End Class
