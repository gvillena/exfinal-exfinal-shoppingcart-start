Imports System.IO
Imports Newtonsoft.Json

Public Class ProductoIO


#Region " Singleton Implementation "

    Private Shared _Instance As ProductoIO = Nothing

    ' Singleton Implementation
    Public Shared ReadOnly Property Instance() As ProductoIO
        Get
            If _Instance Is Nothing Then _Instance = New ProductoIO()
            Return _Instance
        End Get
    End Property

#End Region

#Region " Constructor"
    Private Sub New()
    End Sub

#End Region

#Region " Initialization "

    Public Shared Sub Init()

        ' Productos Hombres
        Dim ProdH1 As New Producto
        Dim ProdH2 As New Producto
        Dim ProdH3 As New Producto

        ' ProdH1
        With ProdH1
            .Codigo = "H0001"
            .Titulo = "Eng Poplin Shirt"
            .Precio = 85
            .ImgSmall.Add("../../img/hombres/h01/small/h-01-01-small.jpg")
            .ImgSmall.Add("../../img/hombres/h01/small/h-01-02-small.jpg")
            .ImgSmall.Add("../../img/hombres/h01/small/h-01-03-small.jpg")
            .ImgSmall.Add("../../img/hombres/h01/small/h-01-04-small.jpg")
            .ImgNormal.Add("../../img/hombres/h01/normal/h-01-01-normal.jpg")
            .ImgNormal.Add("../../img/hombres/h01/normal/h-01-02-normal.jpg")
            .ImgNormal.Add("../../img/hombres/h01/normal/h-01-03-normal.jpg")
            .ImgNormal.Add("../../img/hombres/h01/normal/h-01-04-normal.jpg")
        End With

        ' ProdH2
        With ProdH2
            .Codigo = "H0002"
            .Titulo = "Plaited Sub Cashmere Blend Jumper"
            .Precio = 110
            .ImgSmall.Add("../../img/hombres/h02/small/h-02-01-small.jpg")
            .ImgSmall.Add("../../img/hombres/h02/small/h-02-02-small.jpg")
            .ImgSmall.Add("../../img/hombres/h02/small/h-02-03-small.jpg")
            .ImgSmall.Add("../../img/hombres/h02/small/h-02-04-small.jpg")
            .ImgNormal.Add("../../img/hombres/h02/normal/h-02-01-normal.jpg")
            .ImgNormal.Add("../../img/hombres/h02/normal/h-02-02-normal.jpg")
            .ImgNormal.Add("../../img/hombres/h02/normal/h-02-03-normal.jpg")
            .ImgNormal.Add("../../img/hombres/h02/normal/h-02-04-normal.jpg")
        End With

        ' ProdH3
        With ProdH3
            .Codigo = "H0003"
            .Titulo = "Cotton Linen V-Neck Jumper"
            .Precio = 95
            .ImgSmall.Add("../../img/hombres/h03/small/h-03-01-small.jpg")
            .ImgSmall.Add("../../img/hombres/h03/small/h-03-02-small.jpg")
            .ImgSmall.Add("../../img/hombres/h03/small/h-03-03-small.jpg")
            .ImgSmall.Add("../../img/hombres/h03/small/h-03-04-small.jpg")
            .ImgNormal.Add("../../img/hombres/h03/normal/h-03-01-normal.jpg")
            .ImgNormal.Add("../../img/hombres/h03/normal/h-03-02-normal.jpg")
            .ImgNormal.Add("../../img/hombres/h03/normal/h-03-03-normal.jpg")
            .ImgNormal.Add("../../img/hombres/h03/normal/h-03-04-normal.jpg")
        End With

        ' Productos Mujeres
        Dim ProdM1 As New Producto
        Dim ProdM2 As New Producto
        Dim ProdM3 As New Producto

        ' ProdM1
        With ProdM1
            .Codigo = "M0001"
            .Titulo = "Nicola Blouse"
            .Precio = 120
            .ImgSmall.Add("../../img/mujeres/m01/small/m-01-01-small.jpg")
            .ImgSmall.Add("../../img/mujeres/m01/small/m-01-02-small.jpg")
            .ImgSmall.Add("../../img/mujeres/m01/small/m-01-03-small.jpg")
            .ImgSmall.Add("../../img/mujeres/m01/small/m-01-04-small.jpg")
            .ImgNormal.Add("../../img/mujeres/m01/normal/m-01-01-normal.jpg")
            .ImgNormal.Add("../../img/mujeres/m01/normal/m-01-02-normal.jpg")
            .ImgNormal.Add("../../img/mujeres/m01/normal/m-01-03-normal.jpg")
            .ImgNormal.Add("../../img/mujeres/m01/normal/m-01-04-normal.jpg")
        End With

        ' ProdM2
        With ProdM2
            .Codigo = "M0002"
            .Titulo = "Jezma Blazer"
            .Precio = 190
            .ImgSmall.Add("../../img/mujeres/m02/small/m-02-01-small.jpg")
            .ImgSmall.Add("../../img/mujeres/m02/small/m-02-02-small.jpg")
            .ImgSmall.Add("../../img/mujeres/m02/small/m-02-03-small.jpg")
            .ImgSmall.Add("../../img/mujeres/m02/small/m-02-04-small.jpg")
            .ImgNormal.Add("../../img/mujeres/m02/normal/m-02-01-normal.jpg")
            .ImgNormal.Add("../../img/mujeres/m02/normal/m-02-02-normal.jpg")
            .ImgNormal.Add("../../img/mujeres/m02/normal/m-02-03-normal.jpg")
            .ImgNormal.Add("../../img/mujeres/m02/normal/m-02-04-normal.jpg")
        End With

        ' ProdM3
        With ProdM3
            .Codigo = "M0003"
            .Titulo = "Neige Dress"
            .Precio = 125
            .ImgSmall.Add("../../img/mujeres/m03/small/m-03-01-small.jpg")
            .ImgSmall.Add("../../img/mujeres/m03/small/m-03-02-small.jpg")
            .ImgNormal.Add("../../img/mujeres/m03/normal/m-03-01-normal.jpg")
            .ImgNormal.Add("../../img/mujeres/m03/normal/m-03-02-normal.jpg")
        End With

        ' Productos Calzado
        Dim ProdC1 As New Producto
        Dim ProdC2 As New Producto
        Dim ProdC3 As New Producto

        ' ProdC1
        With ProdC1
            .Codigo = "C0001"
            .Titulo = "Philip 1d Trainers"
            .Precio = 55
            .ImgSmall.Add("../../img/calzado/c01/small/c-01-01-small.jpg")
            .ImgSmall.Add("../../img/calzado/c01/small/c-01-02-small.jpg")
            .ImgSmall.Add("../../img/calzado/c01/small/c-01-03-small.jpg")
            .ImgSmall.Add("../../img/calzado/c01/small/c-01-04-small.jpg")
            .ImgNormal.Add("../../img/calzado/c01/normal/c-01-01-normal.jpg")
            .ImgNormal.Add("../../img/calzado/c01/normal/c-01-02-normal.jpg")
            .ImgNormal.Add("../../img/calzado/c01/normal/c-01-03-normal.jpg")
            .ImgNormal.Add("../../img/calzado/c01/normal/c-01-04-normal.jpg")
        End With

        ' ProdC2
        With ProdC2
            .Codigo = "C0002"
            .Titulo = "Deck 4d Mixed"
            .Precio = 80
            .ImgSmall.Add("../../img/calzado/c02/small/c-02-01-small.jpg")
            .ImgSmall.Add("../../img/calzado/c02/small/c-02-02-small.jpg")
            .ImgSmall.Add("../../img/calzado/c02/small/c-02-03-small.jpg")
            .ImgSmall.Add("../../img/calzado/c02/small/c-02-04-small.jpg")
            .ImgNormal.Add("../../img/calzado/c02/normal/c-02-01-normal.jpg")
            .ImgNormal.Add("../../img/calzado/c02/normal/c-02-02-normal.jpg")
            .ImgNormal.Add("../../img/calzado/c02/normal/c-02-03-normal.jpg")
            .ImgNormal.Add("../../img/calzado/c02/normal/c-02-04-normal.jpg")
        End With

        ' ProdC3
        With ProdC3
            .Codigo = "C0003"
            .Titulo = "Parson 8n Mid Heel"
            .Precio = 155
            .ImgSmall.Add("../../img/calzado/c03/small/c-03-01-small.jpg")
            .ImgSmall.Add("../../img/calzado/c03/small/c-03-02-small.jpg")
            .ImgSmall.Add("../../img/calzado/c03/small/c-03-03-small.jpg")
            .ImgSmall.Add("../../img/calzado/c03/small/c-03-04-small.jpg")
            .ImgNormal.Add("../../img/calzado/c03/normal/c-03-01-normal.jpg")
            .ImgNormal.Add("../../img/calzado/c03/normal/c-03-02-normal.jpg")
            .ImgNormal.Add("../../img/calzado/c03/normal/c-03-03-normal.jpg")
            .ImgNormal.Add("../../img/calzado/c03/normal/c-03-04-normal.jpg")
        End With

        ' Productos Accesorios
        Dim ProdA1 As New Producto
        Dim ProdA2 As New Producto

        ' ProdA1
        With ProdA1
            .Codigo = "A0001"
            .Titulo = "Strap Watch 1791"
            .Precio = 175
            .ImgSmall.Add("../../img/accesorios/a01/small/a-01-01-small.jpg")
            .ImgNormal.Add("../../img/accesorios/a01/normal/a-01-01-normal.jpg")
        End With

        ' ProdA2
        With ProdA2
            .Codigo = "A0002"
            .Titulo = "Classic Logo Red Cap"
            .Precio = 25
            .ImgSmall.Add("../../img/accesorios/a02/small/a-02-01-small.jpg")
            .ImgNormal.Add("../../img/accesorios/a02/normal/a-02-01-normal.jpg")
        End With

        ' Lista Productos Hombres
        Dim prodHbrLst As New List(Of Producto)
        prodHbrLst.Add(ProdH1)
        prodHbrLst.Add(ProdH2)
        prodHbrLst.Add(ProdH3)

        ' Lista Productos Mujeres
        Dim prodMjrLst As New List(Of Producto)
        ' Agregando a lista Productos Mujeres
        prodMjrLst.Add(ProdM1)
        prodMjrLst.Add(ProdM2)
        prodMjrLst.Add(ProdM3)

        ' Lista Productos Calzado
        Dim prodCzdLst As New List(Of Producto)
        ' Agregando a lista Productos calzado
        prodCzdLst.Add(ProdC1)
        prodCzdLst.Add(ProdC2)
        prodCzdLst.Add(ProdC3)

        ' Lista Productos Accesorios
        Dim prodAcsLst As New List(Of Producto)
        ' Agregando a lista Productos Accesorios
        prodAcsLst.Add(ProdA1)
        prodAcsLst.Add(ProdA2)

        ' Escribiendo archivo json
        WriteProductListToJsonFile(prodHbrLst, "prod-hbr-json.txt")
        WriteProductListToJsonFile(prodMjrLst, "prod-mjr-json.txt")
        WriteProductListToJsonFile(prodCzdLst, "prod-czd-json.txt")
        WriteProductListToJsonFile(prodAcsLst, "prod-acs-json.txt")

    End Sub

#End Region

#Region " Sub & Functions "

    Public Shared Function GetProductos(fileName As String) As List(Of Producto)

        ' Declarando variable lista de productos
        Dim prodlst As List(Of Producto) = Nothing

        ' Obteniendo ruta y nombre completo de archivo json
        Dim path As String = IO.Path.Combine(My.Application.Info.DirectoryPath, fileName)

        ' Verificando si existe archivo de texto
        If IO.File.Exists(path) Then

            ' Declarando objeto serializador
            Dim serializer As New JsonSerializer() With {.Formatting = Formatting.Indented}

            ' Leyendo y desearializando desde archivo json 
            Using file As New StreamReader(path)
                prodlst = serializer.Deserialize(file, GetType(List(Of Producto)))
                If prodlst Is Nothing Then
                    Debug.WriteLine("Import from file " & path & " failed.")
                End If
            End Using

        Else ' En caso no existiera el archivo json

            ' Inicializando nueva lista de productos vacia
            prodlst = New List(Of Producto)

        End If

        ' Devolviendo lista de productos
        Return prodlst

    End Function

    Private Shared Sub WriteProductListToJsonFile(prodlst As List(Of Producto), fileName As String)

        ' Obteniendo ruta y nombre completo de archivo json
        Dim path As String = IO.Path.Combine(My.Application.Info.DirectoryPath, fileName)

        ' Declarando e Inicializando objeto JsonSerializer
        Dim serializer As New JsonSerializer() With {.Formatting = Formatting.Indented}

        ' Serializando y escribiendo objeto lista de productos en archivo json
        Using sw As New StreamWriter(path), writer As New JsonTextWriter(sw)
            serializer.Serialize(writer, prodlst)
        End Using

    End Sub

#End Region


End Class
