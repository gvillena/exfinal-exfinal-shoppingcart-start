Public Class MainForm

    Private SeccionHombres As Boolean = False
    Private SeccionMujeres As Boolean = False
    Private SeccionCalzado As Boolean = False
    Private SeccionAccesorios As Boolean = False

    Private IndiceLista As Integer = 0

    Private ProdH1 As Producto
    Private ProdH2 As Producto
    Private ProdH3 As Producto

    Private ProdM1 As Producto
    Private ProdM2 As Producto
    Private ProdM3 As Producto

    Private ProdC1 As Producto
    Private ProdC2 As Producto
    Private ProdC3 As Producto

    Private ProdA1 As Producto
    Private ProdA2 As Producto

    Private VentaActual As Venta

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Inicializando objeto VentaActual
        VentaActual = New Venta()

        ' Habilitando Seccion Hombres
        SeccionHombres = True
        SeccionMujeres = False
        SeccionCalzado = False
        SeccionAccesorios = False

        ' Inicializando Indice Lista
        IndiceLista = 1

        ' Actualizando Titulo Seccion
        btnHombres.ForeColor = Color.SteelBlue
        btnMujeres.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black

        ' Obteniendo Listas de Productos 
        Dim lstProdH As List(Of Producto) = ProductoIO.GetProductos("prod-hbr-json.txt")
        Dim lstProdM As List(Of Producto) = ProductoIO.GetProductos("prod-mjr-json.txt")
        Dim lstProdC As List(Of Producto) = ProductoIO.GetProductos("prod-czd-json.txt")
        Dim lstProdA As List(Of Producto) = ProductoIO.GetProductos("prod-acs-json.txt")

        ' Obteniendo Prod. Hombres 
        ProdH1 = lstProdH.Item(0)
        ProdH2 = lstProdH.Item(1)
        ProdH3 = lstProdH.Item(2)

        ' Obteniendo Prod. Mujeres
        ProdM1 = lstProdM.Item(0)
        ProdM2 = lstProdM.Item(1)
        ProdM3 = lstProdM.Item(2)

        ' Obteniendo Prod. Calzado
        ProdC1 = lstProdC.Item(0)
        ProdC2 = lstProdC.Item(1)
        ProdC3 = lstProdC.Item(2)

        ' Obteniendo Prod. Accesorios
        ProdA1 = lstProdA.Item(0)
        ProdA2 = lstProdA.Item(1)

        ' Actualizando Titulo y Precio
        lblTitulo.Text = ProdH1.Titulo
        lblPrecio.Text = String.Format("${0}", ProdH1.Precio)

        ' Actualizando Lista de Imagenes
        pbProdL1.Image = Image.FromFile(ProdH1.ImgSmall(0))
        pbProdL2.Image = Image.FromFile(ProdH1.ImgSmall(1))
        pbProdL3.Image = Image.FromFile(ProdH1.ImgSmall(2))
        pbProdL4.Image = Image.FromFile(ProdH1.ImgSmall(3))

        ' Actualizando Imagen Normal
        pbProducto.Image = Image.FromFile(ProdH1.ImgNormal(0))

        ' Actualizando Tallas
        lblTallaP1.Text = "XS"
        lblTallaP1.ForeColor = Color.Silver
        lblTallaP2.Text = "S"
        lblTallaP2.ForeColor = Color.Black
        lblTallaP3.Text = "M"
        lblTallaP3.ForeColor = Color.Black
        lblTallaP4.Text = "L"
        lblTallaP4.ForeColor = Color.Black
        lblTallaP5.Text = "XL"
        lblTallaP5.ForeColor = Color.Silver

        ' Reiniciando Cantidad
        txtCantidad.Text = "1"

        ' Deshabilitando btnLeft
        btnLeft.Enabled = False

        ' Habilitando btnTrue
        btnRight.Enabled = True


    End Sub

    Private Sub btnHombres_Click(sender As Object, e As EventArgs) Handles btnHombres.Click

        ' Habilitando Seccion Hombres
        SeccionHombres = True
        SeccionMujeres = False
        SeccionCalzado = False
        SeccionAccesorios = False

        ' Reiniciando Indice Lista
        IndiceLista = 1

        ' Actualizando Titulo Seccion
        btnHombres.ForeColor = Color.SteelBlue
        btnMujeres.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black

        ' Actualizando Titulo y Precio
        lblTitulo.Text = ProdH1.Titulo
        lblPrecio.Text = String.Format("${0}", ProdH1.Precio)

        ' Actualizando Lista de Imagenes
        pbProdL1.Image = Image.FromFile(ProdH1.ImgSmall(0))
        pbProdL2.Image = Image.FromFile(ProdH1.ImgSmall(1))
        pbProdL3.Image = Image.FromFile(ProdH1.ImgSmall(2))
        pbProdL4.Image = Image.FromFile(ProdH1.ImgSmall(3))

        ' Actualizando Imagen Normal
        pbProducto.Image = Image.FromFile(ProdH1.ImgNormal(0))

        ' Actualizando Tallas
        lblTallaP1.Text = "XS"
        lblTallaP1.ForeColor = Color.Silver
        lblTallaP2.Text = "S"
        lblTallaP2.ForeColor = Color.Black
        lblTallaP3.Text = "M"
        lblTallaP3.ForeColor = Color.Black
        lblTallaP4.Text = "L"
        lblTallaP4.ForeColor = Color.Black
        lblTallaP5.Text = "XL"
        lblTallaP5.ForeColor = Color.Silver

        ' Reiniciando Cantidad
        txtCantidad.Text = "1"

        ' Deshabilitando btnLeft
        btnLeft.Enabled = False

        ' Habilitando btnTrue
        btnRight.Enabled = True



    End Sub

    Private Sub btnMujeres_Click(sender As Object, e As EventArgs) Handles btnMujeres.Click

        ' Habilitando Seccion Hombres
        SeccionHombres = False
        SeccionMujeres = True
        SeccionCalzado = False
        SeccionAccesorios = False

        ' Reiniciando Indice Lista
        IndiceLista = 1

        ' Actualizando Titulo Seccion
        btnHombres.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.SteelBlue
        btnAccesorios.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black

        ' Actualizando Titulo y Precio
        lblTitulo.Text = ProdM1.Titulo
        lblPrecio.Text = String.Format("${0}", ProdM1.Precio)

        ' Actualizando Lista de Imagenes
        pbProdL1.Image = Image.FromFile(ProdM1.ImgSmall(0))
        pbProdL2.Image = Image.FromFile(ProdM1.ImgSmall(1))
        pbProdL3.Image = Image.FromFile(ProdM1.ImgSmall(2))
        pbProdL4.Image = Image.FromFile(ProdM1.ImgSmall(3))

        ' Actualizando Imagen Normal
        pbProducto.Image = Image.FromFile(ProdM1.ImgNormal(0))

        ' Actualizando Tallas
        lblTallaP1.Text = "XS"
        lblTallaP1.ForeColor = Color.Silver
        lblTallaP2.Text = "S"
        lblTallaP2.ForeColor = Color.Black
        lblTallaP3.Text = "M"
        lblTallaP3.ForeColor = Color.Black
        lblTallaP4.Text = "L"
        lblTallaP4.ForeColor = Color.Black
        lblTallaP5.Text = "XL"
        lblTallaP5.ForeColor = Color.Silver

        ' Reiniciando Cantidad
        txtCantidad.Text = "1"

        ' Deshabilitando btnLeft
        btnLeft.Enabled = False

        ' Habilitando btnTrue
        btnRight.Enabled = True

    End Sub

    Private Sub btnCalzado_Click(sender As Object, e As EventArgs) Handles btnCalzado.Click

        ' Habilitando Seccion Calzado
        SeccionHombres = False
        SeccionMujeres = False
        SeccionCalzado = True
        SeccionAccesorios = False

        ' Reiniciando Indice Lista
        IndiceLista = 1

        ' Actualizando Titulo Seccion
        btnHombres.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.SteelBlue
        btnAccesorios.ForeColor = Color.Black

        ' Actualizando Titulo y Precio
        lblTitulo.Text = ProdC1.Titulo
        lblPrecio.Text = String.Format("${0}", ProdC1.Precio)

        ' Actualizando Lista de Imagenes
        pbProdL1.Image = Image.FromFile(ProdC1.ImgSmall(0))
        pbProdL2.Image = Image.FromFile(ProdC1.ImgSmall(1))
        pbProdL3.Image = Image.FromFile(ProdC1.ImgSmall(2))
        pbProdL4.Image = Image.FromFile(ProdC1.ImgSmall(3))

        ' Actualizando Imagen Normal
        pbProducto.Image = Image.FromFile(ProdC1.ImgNormal(0))

        ' Actualizando Tallas
        lblTallaP1.Text = "37"
        lblTallaP1.ForeColor = Color.Silver
        lblTallaP2.Text = "38"
        lblTallaP2.ForeColor = Color.Black
        lblTallaP3.Text = "40"
        lblTallaP3.ForeColor = Color.Black
        lblTallaP4.Text = "41"
        lblTallaP4.ForeColor = Color.Black
        lblTallaP5.Text = "42"
        lblTallaP5.ForeColor = Color.Silver

        ' Reiniciando Cantidad
        txtCantidad.Text = "1"

        ' Deshabilitando btnLeft
        btnLeft.Enabled = False

        ' Habilitando btnTrue
        btnRight.Enabled = True

    End Sub

    Private Sub btnAccesorios_Click(sender As Object, e As EventArgs) Handles btnAccesorios.Click

        ' Habilitando Seccion Accesorios
        SeccionHombres = False
        SeccionMujeres = False
        SeccionCalzado = False
        SeccionAccesorios = True

        ' Reiniciando Indice Lista
        IndiceLista = 1

        ' Actualizando Titulo Seccion
        btnHombres.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.SteelBlue

        ' Actualizando Titulo y Precio
        lblTitulo.Text = ProdA1.Titulo
        lblPrecio.Text = String.Format("${0}", ProdA1.Precio)

        ' Actualizando Lista de Imagenes
        pbProdL1.Image = Image.FromFile(ProdA1.ImgSmall(0))
        pbProdL2.Image = Nothing
        pbProdL3.Image = Nothing
        pbProdL4.Image = Nothing

        ' Actualizando Imagen Normal
        pbProducto.Image = Image.FromFile(ProdA1.ImgNormal(0))

        ' Actualizando Tallas
        lblTallaP1.Text = "-"
        lblTallaP1.ForeColor = Color.Silver
        lblTallaP2.Text = "-"
        lblTallaP2.ForeColor = Color.Silver
        lblTallaP3.Text = "-"
        lblTallaP3.ForeColor = Color.Silver
        lblTallaP4.Text = "-"
        lblTallaP4.ForeColor = Color.Silver
        lblTallaP5.Text = "-"
        lblTallaP5.ForeColor = Color.Silver

        ' Reiniciando Cantidad
        txtCantidad.Text = "1"

        ' Deshabilitando btnLeft
        btnLeft.Enabled = False

        ' Habilitando btnTrue
        btnRight.Enabled = True

    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click

        ' Actualizando Indice Lista
        IndiceLista -= 1

        Select Case True

            Case SeccionHombres

                Select Case IndiceLista

                    Case 1

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = ProdH1.Titulo
                        lblPrecio.Text = String.Format("${0}", ProdH1.Precio)

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = Image.FromFile(ProdH1.ImgSmall(0))
                        pbProdL2.Image = Image.FromFile(ProdH1.ImgSmall(1))
                        pbProdL3.Image = Image.FromFile(ProdH1.ImgSmall(2))
                        pbProdL4.Image = Image.FromFile(ProdH1.ImgSmall(3))

                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdH1.ImgNormal(0))

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnLeft
                        btnLeft.Enabled = False

                    Case 2

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = ProdH2.Titulo
                        lblPrecio.Text = String.Format("${0}", ProdH2.Precio)

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = Image.FromFile(ProdH2.ImgSmall(0))
                        pbProdL2.Image = Image.FromFile(ProdH2.ImgSmall(1))
                        pbProdL3.Image = Image.FromFile(ProdH2.ImgSmall(2))
                        pbProdL4.Image = Image.FromFile(ProdH2.ImgSmall(3))

                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdH2.ImgNormal(0))

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Habilitando btnLeft y btnRight
                        btnLeft.Enabled = True
                        btnRight.Enabled = True

                    Case 3

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = ProdH3.Titulo
                        lblPrecio.Text = String.Format("${0}", ProdH3.Precio)

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = Image.FromFile(ProdH3.ImgSmall(0))
                        pbProdL2.Image = Image.FromFile(ProdH3.ImgSmall(1))
                        pbProdL3.Image = Image.FromFile(ProdH3.ImgSmall(2))
                        pbProdL4.Image = Image.FromFile(ProdH3.ImgSmall(3))

                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdH3.ImgNormal(0))

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnRight
                        btnRight.Enabled = False

                End Select

            Case SeccionMujeres

                Select Case IndiceLista

                    Case 1

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = ProdM1.Titulo
                        lblPrecio.Text = String.Format("${0}", ProdM1.Precio)

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = Image.FromFile(ProdM1.ImgSmall(0))
                        pbProdL2.Image = Image.FromFile(ProdM1.ImgSmall(1))
                        pbProdL3.Image = Image.FromFile(ProdM1.ImgSmall(2))
                        pbProdL4.Image = Image.FromFile(ProdM1.ImgSmall(3))

                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdM1.ImgNormal(0))

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnLeft
                        btnLeft.Enabled = False

                    Case 2

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = ProdM2.Titulo
                        lblPrecio.Text = String.Format("${0}", ProdM2.Precio)

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = Image.FromFile(ProdM2.ImgSmall(0))
                        pbProdL2.Image = Image.FromFile(ProdM2.ImgSmall(1))
                        pbProdL3.Image = Image.FromFile(ProdM2.ImgSmall(2))
                        pbProdL4.Image = Image.FromFile(ProdM2.ImgSmall(3))

                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdM2.ImgNormal(0))

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Habilitando btnLeft y btnRight
                        btnLeft.Enabled = True
                        btnRight.Enabled = True

                    Case 3

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = ProdM3.Titulo
                        lblPrecio.Text = String.Format("${0}", ProdM3.Precio)

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = Image.FromFile(ProdM3.ImgSmall(0))
                        pbProdL2.Image = Image.FromFile(ProdM3.ImgSmall(1))
                        pbProdL3.Image = Nothing
                        pbProdL4.Image = Nothing

                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdM3.ImgNormal(0))

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnRight
                        btnRight.Enabled = False

                End Select

            Case SeccionCalzado

                Select Case IndiceLista

                    Case 1

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = ProdC1.Titulo
                        lblPrecio.Text = String.Format("${0}", ProdC1.Precio)

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = Image.FromFile(ProdC1.ImgSmall(0))
                        pbProdL2.Image = Image.FromFile(ProdC1.ImgSmall(1))
                        pbProdL3.Image = Image.FromFile(ProdC1.ImgSmall(2))
                        pbProdL4.Image = Image.FromFile(ProdC1.ImgSmall(3))

                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdC1.ImgNormal(0))

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnLeft
                        btnLeft.Enabled = False

                    Case 2

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = ProdC2.Titulo
                        lblPrecio.Text = String.Format("${0}", ProdC2.Precio)

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = Image.FromFile(ProdC2.ImgSmall(0))
                        pbProdL2.Image = Image.FromFile(ProdC2.ImgSmall(1))
                        pbProdL3.Image = Image.FromFile(ProdC2.ImgSmall(2))
                        pbProdL4.Image = Image.FromFile(ProdC2.ImgSmall(3))

                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdC2.ImgNormal(0))

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Habilitando btnLeft y btnRight
                        btnLeft.Enabled = True
                        btnRight.Enabled = True

                    Case 3

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = ProdC3.Titulo
                        lblPrecio.Text = String.Format("${0}", ProdC3.Precio)

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = Image.FromFile(ProdC3.ImgSmall(0))
                        pbProdL2.Image = Image.FromFile(ProdC3.ImgSmall(1))
                        pbProdL3.Image = Image.FromFile(ProdC3.ImgSmall(2))
                        pbProdL4.Image = Image.FromFile(ProdC3.ImgSmall(3))

                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdC3.ImgNormal(0))

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnRight
                        btnRight.Enabled = False

                End Select

            Case SeccionAccesorios

                Select Case IndiceLista

                    Case 1

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = ProdA1.Titulo
                        lblPrecio.Text = String.Format("${0}", ProdA1.Precio)

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = Image.FromFile(ProdA1.ImgSmall(0))

                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdA1.ImgNormal(0))

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnLeft y Habilitando btnRight
                        btnLeft.Enabled = False
                        btnRight.Enabled = True

                    Case 2

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = ProdA2.Titulo
                        lblPrecio.Text = String.Format("${0}", ProdA2.Precio)

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = Image.FromFile(ProdA2.ImgSmall(0))

                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdA2.ImgNormal(0))

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Habilitando btnLeft y Deshabilitando btnRight
                        btnLeft.Enabled = True
                        btnRight.Enabled = False

                End Select
        End Select


    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click

        ' Actualizando Indice Lista
        IndiceLista += 1


        Select Case True

            Case SeccionHombres

                Select Case IndiceLista

                    Case 1

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = ProdH1.Titulo
                        lblPrecio.Text = String.Format("${0}", ProdH1.Precio)

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = Image.FromFile(ProdH1.ImgSmall(0))
                        pbProdL2.Image = Image.FromFile(ProdH1.ImgSmall(1))
                        pbProdL3.Image = Image.FromFile(ProdH1.ImgSmall(2))
                        pbProdL4.Image = Image.FromFile(ProdH1.ImgSmall(3))

                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdH1.ImgNormal(0))

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnLeft
                        btnLeft.Enabled = False

                    Case 2

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = ProdH2.Titulo
                        lblPrecio.Text = String.Format("${0}", ProdH2.Precio)

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = Image.FromFile(ProdH2.ImgSmall(0))
                        pbProdL2.Image = Image.FromFile(ProdH2.ImgSmall(1))
                        pbProdL3.Image = Image.FromFile(ProdH2.ImgSmall(2))
                        pbProdL4.Image = Image.FromFile(ProdH2.ImgSmall(3))

                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdH2.ImgNormal(0))

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Habilitando btnLeft y btnRight
                        btnLeft.Enabled = True
                        btnRight.Enabled = True

                    Case 3

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = ProdH3.Titulo
                        lblPrecio.Text = String.Format("${0}", ProdH3.Precio)

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = Image.FromFile(ProdH3.ImgSmall(0))
                        pbProdL2.Image = Image.FromFile(ProdH3.ImgSmall(1))
                        pbProdL3.Image = Image.FromFile(ProdH3.ImgSmall(2))
                        pbProdL4.Image = Image.FromFile(ProdH3.ImgSmall(3))

                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdH3.ImgNormal(0))

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnRight
                        btnRight.Enabled = False

                End Select

            Case SeccionMujeres

                Select Case IndiceLista

                    Case 1

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = ProdM1.Titulo
                        lblPrecio.Text = String.Format("${0}", ProdM1.Precio)

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = Image.FromFile(ProdM1.ImgSmall(0))
                        pbProdL2.Image = Image.FromFile(ProdM1.ImgSmall(1))
                        pbProdL3.Image = Image.FromFile(ProdM1.ImgSmall(2))
                        pbProdL4.Image = Image.FromFile(ProdM1.ImgSmall(3))

                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdM1.ImgNormal(0))

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnLeft
                        btnLeft.Enabled = False

                    Case 2

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = ProdM2.Titulo
                        lblPrecio.Text = String.Format("${0}", ProdM2.Precio)

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = Image.FromFile(ProdM2.ImgSmall(0))
                        pbProdL2.Image = Image.FromFile(ProdM2.ImgSmall(1))
                        pbProdL3.Image = Image.FromFile(ProdM2.ImgSmall(2))
                        pbProdL4.Image = Image.FromFile(ProdM2.ImgSmall(3))

                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdM2.ImgNormal(0))

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Habilitando btnLeft y btnRight
                        btnLeft.Enabled = True
                        btnRight.Enabled = True

                    Case 3

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = ProdM3.Titulo
                        lblPrecio.Text = String.Format("${0}", ProdM3.Precio)

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = Image.FromFile(ProdM3.ImgSmall(0))
                        pbProdL2.Image = Image.FromFile(ProdM3.ImgSmall(1))
                        pbProdL3.Image = Nothing
                        pbProdL4.Image = Nothing

                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdM3.ImgNormal(0))

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnRight
                        btnRight.Enabled = False

                End Select

            Case SeccionCalzado

                Select Case IndiceLista

                    Case 1

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = ProdC1.Titulo
                        lblPrecio.Text = String.Format("${0}", ProdC1.Precio)

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = Image.FromFile(ProdC1.ImgSmall(0))
                        pbProdL2.Image = Image.FromFile(ProdC1.ImgSmall(1))
                        pbProdL3.Image = Image.FromFile(ProdC1.ImgSmall(2))
                        pbProdL4.Image = Image.FromFile(ProdC1.ImgSmall(3))

                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdC1.ImgNormal(0))

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnLeft
                        btnLeft.Enabled = False

                    Case 2

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = ProdC2.Titulo
                        lblPrecio.Text = String.Format("${0}", ProdC2.Precio)

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = Image.FromFile(ProdC2.ImgSmall(0))
                        pbProdL2.Image = Image.FromFile(ProdC2.ImgSmall(1))
                        pbProdL3.Image = Image.FromFile(ProdC2.ImgSmall(2))
                        pbProdL4.Image = Image.FromFile(ProdC2.ImgSmall(3))

                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdC2.ImgNormal(0))

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Habilitando btnLeft y btnRight
                        btnLeft.Enabled = True
                        btnRight.Enabled = True

                    Case 3

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = ProdC3.Titulo
                        lblPrecio.Text = String.Format("${0}", ProdC3.Precio)

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = Image.FromFile(ProdC3.ImgSmall(0))
                        pbProdL2.Image = Image.FromFile(ProdC3.ImgSmall(1))
                        pbProdL3.Image = Image.FromFile(ProdC3.ImgSmall(2))
                        pbProdL4.Image = Image.FromFile(ProdC3.ImgSmall(3))

                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdC3.ImgNormal(0))

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnRight
                        btnRight.Enabled = False

                End Select

            Case SeccionAccesorios

                Select Case IndiceLista

                    Case 1

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = ProdA1.Titulo
                        lblPrecio.Text = String.Format("${0}", ProdA1.Precio)

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = Image.FromFile(ProdA1.ImgSmall(0))

                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdA1.ImgNormal(0))

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnLeft y Habilitando btnRight
                        btnLeft.Enabled = False
                        btnRight.Enabled = True

                    Case 2

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = ProdA2.Titulo
                        lblPrecio.Text = String.Format("${0}", ProdA2.Precio)

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = Image.FromFile(ProdA2.ImgSmall(0))

                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdA2.ImgNormal(0))

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Habilitando btnLeft y Deshabilitando btnRight
                        btnLeft.Enabled = True
                        btnRight.Enabled = False

                End Select
        End Select

    End Sub

    Private Sub pbProdL1_Click(sender As Object, e As EventArgs) Handles pbProdL1.Click

        Select Case True

            Case SeccionHombres

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdH1.ImgNormal(0))

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdH2.ImgNormal(0))

                    Case 3
                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdH3.ImgNormal(0))

                End Select

            Case SeccionMujeres

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdM1.ImgNormal(0))

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdM2.ImgNormal(0))

                    Case 3
                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdM3.ImgNormal(0))

                End Select

            Case SeccionCalzado

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdC1.ImgNormal(0))

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdC2.ImgNormal(0))

                    Case 3
                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdC3.ImgNormal(0))

                End Select

            Case SeccionAccesorios

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdA1.ImgNormal(0))

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdA2.ImgNormal(0))

                End Select
        End Select

    End Sub

    Private Sub pbProdL2_Click(sender As Object, e As EventArgs) Handles pbProdL2.Click

        Select Case True

            Case SeccionHombres

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdH1.ImgNormal(1))

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdH2.ImgNormal(1))

                    Case 3
                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdH3.ImgNormal(1))

                End Select

            Case SeccionMujeres

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdM1.ImgNormal(1))

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdM2.ImgNormal(1))

                    Case 3
                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdM3.ImgNormal(1))

                End Select

            Case SeccionCalzado

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdC1.ImgNormal(1))

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdC2.ImgNormal(1))

                    Case 3
                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdC3.ImgNormal(1))

                End Select

        End Select

    End Sub

    Private Sub pbProdL3_Click(sender As Object, e As EventArgs) Handles pbProdL3.Click

        Select Case True

            Case SeccionHombres

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdH1.ImgNormal(2))

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdH2.ImgNormal(2))

                    Case 3
                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdH3.ImgNormal(2))

                End Select

            Case SeccionMujeres

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdM1.ImgNormal(2))

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdM2.ImgNormal(2))

                End Select

            Case SeccionCalzado

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdC1.ImgNormal(2))

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdC2.ImgNormal(2))

                    Case 3
                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdC3.ImgNormal(2))

                End Select

        End Select

    End Sub

    Private Sub pbProdL4_Click(sender As Object, e As EventArgs) Handles pbProdL4.Click

        Select Case True

            Case SeccionHombres

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdH1.ImgNormal(3))

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdH2.ImgNormal(3))

                    Case 3
                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdH3.ImgNormal(3))

                End Select

            Case SeccionMujeres

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdM1.ImgNormal(3))

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdM2.ImgNormal(3))


                End Select

            Case SeccionCalzado

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdC1.ImgNormal(3))

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = Image.FromFile(ProdC2.ImgNormal(3))

                    Case 3
                        ' Actualizando Imagen Normal
                        pbProducto.Image = Image.FromFile(ProdC3.ImgNormal(3))

                End Select

        End Select

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Select Case True

            Case SeccionHombres

                Select Case IndiceLista
                    Case 1 ' H1
                        VentaActual.AgregarCarrito(Nothing, 0)
                    Case 2 ' H2
                        VentaActual.AgregarCarrito(Nothing, 0)
                    Case 3 ' H2
                        VentaActual.AgregarCarrito(Nothing, 0)
                End Select

            Case SeccionMujeres

                Select Case IndiceLista
                    Case 1 ' M1
                        VentaActual.AgregarCarrito(Nothing, 0)
                    Case 2 ' M2
                        VentaActual.AgregarCarrito(Nothing, 0)
                    Case 3 ' M3
                        VentaActual.AgregarCarrito(Nothing, 0)
                End Select

            Case SeccionCalzado

                Select Case IndiceLista
                    Case 1 ' C1
                        VentaActual.AgregarCarrito(Nothing, 0)
                    Case 2 ' C2
                        VentaActual.AgregarCarrito(Nothing, 0)
                    Case 3 ' C3
                        VentaActual.AgregarCarrito(Nothing, 0)
                End Select

            Case SeccionAccesorios

                Select Case IndiceLista
                    Case 1 ' A1
                        VentaActual.AgregarCarrito(Nothing, 0)
                    Case 2 ' A2
                        VentaActual.AgregarCarrito(Nothing, 0)
                End Select

        End Select

        ' Actualizando Total Venta
        VentaActual.TotalVenta = VentaActual.TotalVenta + 0

        ' Actualizando Total Venta TextBox
        txtTotal.Text = String.Format("${0}", VentaActual.TotalVenta)

    End Sub

End Class