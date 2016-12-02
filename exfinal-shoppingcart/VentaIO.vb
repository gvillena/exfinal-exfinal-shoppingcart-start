Imports System.IO
Imports Newtonsoft.Json

Public Class VentaIO

#Region "Constructor"
    Private Sub New()
    End Sub
#End Region

#Region " Subs & Functions "

    Public Shared Sub AddVenta(venta As Venta)

        ' Obteniendo lista de tareas
        Dim ventalst As List(Of Venta) = VentaIO.GetVentas("venta-lst-json.txt")

        ' Estableciendo codigo de nueva venta
        venta.Codigo = ventalst.Last.Codigo + 1

        ' Agregando venta a la lista de ventas
        ventalst.Add(venta)

        ' Almacenando lista de ventas actualizada en el archivo json
        WriteVentaListToJsonFile(ventalst, "venta-lst-json.txt")

    End Sub

    Public Shared Function GetVentas(fileName As String) As List(Of Venta)

        ' Declarando variable lista de ventas
        Dim ventalst As List(Of Venta) = Nothing

        ' Obteniendo ruta y nombre completo de archivo json
        Dim path As String = IO.Path.Combine(My.Application.Info.DirectoryPath, fileName)

        ' Verificando si existe archivo de texto
        If IO.File.Exists(path) Then

            ' Declarando objeto serializador
            Dim serializer As New JsonSerializer() With {.Formatting = Formatting.Indented}

            ' Leyendo y desearializando desde archivo json 
            Using file As New StreamReader(path)
                ventalst = serializer.Deserialize(file, GetType(List(Of Venta)))
                If ventalst Is Nothing Then
                    Debug.WriteLine("Import from file " & path & " failed.")
                End If
            End Using

        Else ' En caso no existiera el archivo json

            ' Inicializando nueva lista de venta vacia
            ventalst = New List(Of Venta)

            ' Agregando tarea vacia a lista de tareas
            ventalst.Add(New Venta())

            ' Almacenando lista de tareas en archivo json
            WriteVentaListToJsonFile(ventalst, "venta-lst-json.txt")

        End If

        ' Devolviendo lista de ventas
        Return ventalst
    End Function

    Private Shared Sub WriteVentaListToJsonFile(ventalst As List(Of Venta), fileName As String)

        ' Obteniendo ruta y nombre completo de archivo json
        Dim path As String = IO.Path.Combine(My.Application.Info.DirectoryPath, fileName)

        ' Declarando e Inicializando objeto JsonSerializer
        Dim serializer As New JsonSerializer() With {.Formatting = Formatting.Indented}

        ' Serializando y escribiendo objeto lista de ventas en archivo json
        Using sw As New StreamWriter(path), writer As New JsonTextWriter(sw)
            serializer.Serialize(writer, ventalst)
        End Using

    End Sub

#End Region

End Class
