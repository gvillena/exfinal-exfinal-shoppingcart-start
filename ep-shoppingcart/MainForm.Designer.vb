<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.pbCover = New System.Windows.Forms.PictureBox()
        Me.ilFlechas = New System.Windows.Forms.ImageList(Me.components)
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pbProdL1 = New System.Windows.Forms.PictureBox()
        Me.pbProdL2 = New System.Windows.Forms.PictureBox()
        Me.pbProdL3 = New System.Windows.Forms.PictureBox()
        Me.pbProdL4 = New System.Windows.Forms.PictureBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblLorem = New System.Windows.Forms.Label()
        Me.lblTallaT = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.tblTitle = New System.Windows.Forms.TableLayoutPanel()
        Me.plLine2 = New System.Windows.Forms.Panel()
        Me.tblMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.btnHombres = New System.Windows.Forms.Button()
        Me.btnMujeres = New System.Windows.Forms.Button()
        Me.btnAccesorios = New System.Windows.Forms.Button()
        Me.btnCalzado = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.plLine1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.TblTallaLista = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTallaP1 = New System.Windows.Forms.Label()
        Me.lblTallaP2 = New System.Windows.Forms.Label()
        Me.lblTallaP3 = New System.Windows.Forms.Label()
        Me.lblTallaP4 = New System.Windows.Forms.Label()
        Me.lblTallaP5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.tblTalla = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCantidadT = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.ilProductosH = New System.Windows.Forms.ImageList(Me.components)
        Me.ilProductosM = New System.Windows.Forms.ImageList(Me.components)
        Me.ilProductosC = New System.Windows.Forms.ImageList(Me.components)
        Me.ilProductosA = New System.Windows.Forms.ImageList(Me.components)
        Me.ilProdH1small = New System.Windows.Forms.ImageList(Me.components)
        Me.pbProducto = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.pbProdL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProdL2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProdL3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProdL4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblTitle.SuspendLayout()
        Me.tblMenu.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TblTallaLista.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.tblTalla.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.pbProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbLogo)
        Me.Panel1.Controls.Add(Me.pbCover)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(721, 215)
        Me.Panel1.TabIndex = 2
        '
        'pbLogo
        '
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(541, 16)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(152, 80)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbLogo.TabIndex = 1
        Me.pbLogo.TabStop = False
        '
        'pbCover
        '
        Me.pbCover.Image = CType(resources.GetObject("pbCover.Image"), System.Drawing.Image)
        Me.pbCover.Location = New System.Drawing.Point(0, 0)
        Me.pbCover.Margin = New System.Windows.Forms.Padding(0)
        Me.pbCover.Name = "pbCover"
        Me.pbCover.Size = New System.Drawing.Size(720, 215)
        Me.pbCover.TabIndex = 0
        Me.pbCover.TabStop = False
        '
        'ilFlechas
        '
        Me.ilFlechas.ImageStream = CType(resources.GetObject("ilFlechas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilFlechas.TransparentColor = System.Drawing.Color.Transparent
        Me.ilFlechas.Images.SetKeyName(0, "left-arrow.png")
        Me.ilFlechas.Images.SetKeyName(1, "right-arrow.png")
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblTitulo.Location = New System.Drawing.Point(100, 4)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(489, 25)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "Lorem Ipsum"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pbProdL1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pbProdL2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.pbProdL3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.pbProdL4, 0, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 307)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(99, 506)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'pbProdL1
        '
        Me.pbProdL1.Location = New System.Drawing.Point(3, 3)
        Me.pbProdL1.Name = "pbProdL1"
        Me.pbProdL1.Size = New System.Drawing.Size(90, 120)
        Me.pbProdL1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbProdL1.TabIndex = 5
        Me.pbProdL1.TabStop = False
        '
        'pbProdL2
        '
        Me.pbProdL2.Location = New System.Drawing.Point(3, 129)
        Me.pbProdL2.Name = "pbProdL2"
        Me.pbProdL2.Size = New System.Drawing.Size(90, 120)
        Me.pbProdL2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbProdL2.TabIndex = 5
        Me.pbProdL2.TabStop = False
        '
        'pbProdL3
        '
        Me.pbProdL3.Location = New System.Drawing.Point(3, 255)
        Me.pbProdL3.Name = "pbProdL3"
        Me.pbProdL3.Size = New System.Drawing.Size(90, 120)
        Me.pbProdL3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbProdL3.TabIndex = 5
        Me.pbProdL3.TabStop = False
        '
        'pbProdL4
        '
        Me.pbProdL4.Location = New System.Drawing.Point(3, 381)
        Me.pbProdL4.Name = "pbProdL4"
        Me.pbProdL4.Size = New System.Drawing.Size(90, 120)
        Me.pbProdL4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbProdL4.TabIndex = 5
        Me.pbProdL4.TabStop = False
        '
        'lblPrecio
        '
        Me.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Segoe UI Semibold", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.ForeColor = System.Drawing.Color.Black
        Me.lblPrecio.Location = New System.Drawing.Point(68, 9)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(64, 51)
        Me.lblPrecio.TabIndex = 4
        Me.lblPrecio.Text = "$0"
        Me.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLorem
        '
        Me.lblLorem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLorem.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLorem.ForeColor = System.Drawing.Color.DimGray
        Me.lblLorem.Location = New System.Drawing.Point(3, 70)
        Me.lblLorem.Name = "lblLorem"
        Me.lblLorem.Size = New System.Drawing.Size(194, 77)
        Me.lblLorem.TabIndex = 4
        Me.lblLorem.Text = "Lorem ipsum dolor sit amet, eum aeque nonumy constituam ut, ei appetere convenire" &
    " ius, et eos iriure luptatum adipiscing."
        Me.lblLorem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTallaT
        '
        Me.lblTallaT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTallaT.AutoSize = True
        Me.lblTallaT.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTallaT.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTallaT.Location = New System.Drawing.Point(79, 4)
        Me.lblTallaT.Name = "lblTallaT"
        Me.lblTallaT.Size = New System.Drawing.Size(36, 13)
        Me.lblTallaT.TabIndex = 4
        Me.lblTallaT.Text = "TALLA"
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAgregar.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(3, 290)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(194, 24)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "LOREM IPSUM"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'tblTitle
        '
        Me.tblTitle.ColumnCount = 1
        Me.tblTitle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTitle.Controls.Add(Me.plLine2, 0, 3)
        Me.tblTitle.Controls.Add(Me.tblMenu, 0, 0)
        Me.tblTitle.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.tblTitle.Controls.Add(Me.plLine1, 0, 1)
        Me.tblTitle.Location = New System.Drawing.Point(12, 220)
        Me.tblTitle.Name = "tblTitle"
        Me.tblTitle.RowCount = 4
        Me.tblTitle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tblTitle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.tblTitle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTitle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.tblTitle.Size = New System.Drawing.Size(697, 81)
        Me.tblTitle.TabIndex = 7
        '
        'plLine2
        '
        Me.plLine2.BackColor = System.Drawing.Color.SteelBlue
        Me.plLine2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.plLine2.Location = New System.Drawing.Point(0, 80)
        Me.plLine2.Margin = New System.Windows.Forms.Padding(0)
        Me.plLine2.Name = "plLine2"
        Me.plLine2.Size = New System.Drawing.Size(697, 1)
        Me.plLine2.TabIndex = 3
        '
        'tblMenu
        '
        Me.tblMenu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblMenu.ColumnCount = 4
        Me.tblMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblMenu.Controls.Add(Me.btnHombres, 0, 0)
        Me.tblMenu.Controls.Add(Me.btnMujeres, 1, 0)
        Me.tblMenu.Controls.Add(Me.btnAccesorios, 3, 0)
        Me.tblMenu.Controls.Add(Me.btnCalzado, 2, 0)
        Me.tblMenu.Location = New System.Drawing.Point(149, 3)
        Me.tblMenu.Name = "tblMenu"
        Me.tblMenu.RowCount = 1
        Me.tblMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.tblMenu.Size = New System.Drawing.Size(399, 33)
        Me.tblMenu.TabIndex = 0
        '
        'btnHombres
        '
        Me.btnHombres.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHombres.FlatAppearance.BorderSize = 0
        Me.btnHombres.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnHombres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHombres.ForeColor = System.Drawing.Color.DimGray
        Me.btnHombres.Location = New System.Drawing.Point(3, 3)
        Me.btnHombres.Name = "btnHombres"
        Me.btnHombres.Size = New System.Drawing.Size(93, 27)
        Me.btnHombres.TabIndex = 2
        Me.btnHombres.Text = "HOMBRES"
        Me.btnHombres.UseVisualStyleBackColor = True
        '
        'btnMujeres
        '
        Me.btnMujeres.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMujeres.FlatAppearance.BorderSize = 0
        Me.btnMujeres.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnMujeres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMujeres.ForeColor = System.Drawing.Color.DimGray
        Me.btnMujeres.Location = New System.Drawing.Point(102, 3)
        Me.btnMujeres.Name = "btnMujeres"
        Me.btnMujeres.Size = New System.Drawing.Size(93, 27)
        Me.btnMujeres.TabIndex = 2
        Me.btnMujeres.Text = "MUJERES"
        Me.btnMujeres.UseVisualStyleBackColor = True
        '
        'btnAccesorios
        '
        Me.btnAccesorios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAccesorios.FlatAppearance.BorderSize = 0
        Me.btnAccesorios.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnAccesorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccesorios.ForeColor = System.Drawing.Color.DimGray
        Me.btnAccesorios.Location = New System.Drawing.Point(300, 3)
        Me.btnAccesorios.Name = "btnAccesorios"
        Me.btnAccesorios.Size = New System.Drawing.Size(96, 27)
        Me.btnAccesorios.TabIndex = 2
        Me.btnAccesorios.Text = "ACCESORIOS"
        Me.btnAccesorios.UseVisualStyleBackColor = True
        '
        'btnCalzado
        '
        Me.btnCalzado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalzado.FlatAppearance.BorderSize = 0
        Me.btnCalzado.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnCalzado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalzado.ForeColor = System.Drawing.Color.DimGray
        Me.btnCalzado.Location = New System.Drawing.Point(201, 3)
        Me.btnCalzado.Name = "btnCalzado"
        Me.btnCalzado.Size = New System.Drawing.Size(93, 27)
        Me.btnCalzado.TabIndex = 2
        Me.btnCalzado.Text = "CALZADO"
        Me.btnCalzado.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.15921!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.67904!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.16175!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnRight, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblTitulo, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnLeft, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 44)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(691, 33)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'btnRight
        '
        Me.btnRight.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnRight.FlatAppearance.BorderSize = 0
        Me.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRight.ImageKey = "right-arrow.png"
        Me.btnRight.ImageList = Me.ilFlechas
        Me.btnRight.Location = New System.Drawing.Point(669, 5)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(19, 23)
        Me.btnRight.TabIndex = 2
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnLeft.FlatAppearance.BorderSize = 0
        Me.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeft.ImageKey = "left-arrow.png"
        Me.btnLeft.ImageList = Me.ilFlechas
        Me.btnLeft.Location = New System.Drawing.Point(3, 5)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(18, 23)
        Me.btnLeft.TabIndex = 1
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'plLine1
        '
        Me.plLine1.BackColor = System.Drawing.Color.SteelBlue
        Me.plLine1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.plLine1.Location = New System.Drawing.Point(0, 40)
        Me.plLine1.Margin = New System.Windows.Forms.Padding(0)
        Me.plLine1.Name = "plLine1"
        Me.plLine1.Size = New System.Drawing.Size(697, 1)
        Me.plLine1.TabIndex = 2
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.lblCopyright, 0, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(12, 819)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(694, 31)
        Me.TableLayoutPanel6.TabIndex = 10
        '
        'lblCopyright
        '
        Me.lblCopyright.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.ForeColor = System.Drawing.Color.DimGray
        Me.lblCopyright.Location = New System.Drawing.Point(172, 9)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(349, 13)
        Me.lblCopyright.TabIndex = 4
        Me.lblCopyright.Text = "Copyright © 2016 Tommy Hilfiger Licensing, LLC. All rights reserved"
        '
        'TblTallaLista
        '
        Me.TblTallaLista.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TblTallaLista.ColumnCount = 5
        Me.TblTallaLista.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TblTallaLista.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TblTallaLista.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TblTallaLista.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TblTallaLista.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TblTallaLista.Controls.Add(Me.lblTallaP1, 0, 0)
        Me.TblTallaLista.Controls.Add(Me.lblTallaP2, 1, 0)
        Me.TblTallaLista.Controls.Add(Me.lblTallaP3, 2, 0)
        Me.TblTallaLista.Controls.Add(Me.lblTallaP4, 3, 0)
        Me.TblTallaLista.Controls.Add(Me.lblTallaP5, 4, 0)
        Me.TblTallaLista.Font = New System.Drawing.Font("Segoe UI Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TblTallaLista.Location = New System.Drawing.Point(30, 26)
        Me.TblTallaLista.Margin = New System.Windows.Forms.Padding(3, 2, 3, 3)
        Me.TblTallaLista.Name = "TblTallaLista"
        Me.TblTallaLista.RowCount = 1
        Me.TblTallaLista.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TblTallaLista.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TblTallaLista.Size = New System.Drawing.Size(134, 20)
        Me.TblTallaLista.TabIndex = 11
        '
        'lblTallaP1
        '
        Me.lblTallaP1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTallaP1.AutoSize = True
        Me.lblTallaP1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTallaP1.ForeColor = System.Drawing.Color.Silver
        Me.lblTallaP1.Location = New System.Drawing.Point(3, 3)
        Me.lblTallaP1.Name = "lblTallaP1"
        Me.lblTallaP1.Size = New System.Drawing.Size(20, 13)
        Me.lblTallaP1.TabIndex = 0
        Me.lblTallaP1.Text = "-"
        Me.lblTallaP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTallaP2
        '
        Me.lblTallaP2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTallaP2.AutoSize = True
        Me.lblTallaP2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTallaP2.ForeColor = System.Drawing.Color.Silver
        Me.lblTallaP2.Location = New System.Drawing.Point(29, 3)
        Me.lblTallaP2.Name = "lblTallaP2"
        Me.lblTallaP2.Size = New System.Drawing.Size(20, 13)
        Me.lblTallaP2.TabIndex = 1
        Me.lblTallaP2.Text = "-"
        Me.lblTallaP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTallaP3
        '
        Me.lblTallaP3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTallaP3.AutoSize = True
        Me.lblTallaP3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTallaP3.ForeColor = System.Drawing.Color.Silver
        Me.lblTallaP3.Location = New System.Drawing.Point(55, 3)
        Me.lblTallaP3.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblTallaP3.Name = "lblTallaP3"
        Me.lblTallaP3.Size = New System.Drawing.Size(23, 13)
        Me.lblTallaP3.TabIndex = 2
        Me.lblTallaP3.Text = "-"
        Me.lblTallaP3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTallaP4
        '
        Me.lblTallaP4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTallaP4.AutoSize = True
        Me.lblTallaP4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTallaP4.ForeColor = System.Drawing.Color.Silver
        Me.lblTallaP4.Location = New System.Drawing.Point(81, 3)
        Me.lblTallaP4.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblTallaP4.Name = "lblTallaP4"
        Me.lblTallaP4.Size = New System.Drawing.Size(23, 13)
        Me.lblTallaP4.TabIndex = 3
        Me.lblTallaP4.Text = "-"
        Me.lblTallaP4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTallaP5
        '
        Me.lblTallaP5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTallaP5.AutoSize = True
        Me.lblTallaP5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTallaP5.ForeColor = System.Drawing.Color.Silver
        Me.lblTallaP5.Location = New System.Drawing.Point(107, 3)
        Me.lblTallaP5.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblTallaP5.Name = "lblTallaP5"
        Me.lblTallaP5.Size = New System.Drawing.Size(27, 13)
        Me.lblTallaP5.TabIndex = 4
        Me.lblTallaP5.Text = "-"
        Me.lblTallaP5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.lblPrecio, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.lblLorem, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.tblTalla, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel9, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.btnAgregar, 0, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.btnComprar, 0, 5)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel2, 0, 6)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(505, 310)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 7
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(200, 503)
        Me.TableLayoutPanel5.TabIndex = 12
        '
        'tblTalla
        '
        Me.tblTalla.ColumnCount = 1
        Me.tblTalla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTalla.Controls.Add(Me.lblTallaT, 0, 0)
        Me.tblTalla.Controls.Add(Me.TblTallaLista, 0, 1)
        Me.tblTalla.Location = New System.Drawing.Point(3, 157)
        Me.tblTalla.Name = "tblTalla"
        Me.tblTalla.RowCount = 2
        Me.tblTalla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.13726!))
        Me.tblTalla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.86274!))
        Me.tblTalla.Size = New System.Drawing.Size(194, 51)
        Me.tblTalla.TabIndex = 5
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 1
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.lblCantidadT, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.txtCantidad, 0, 1)
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 219)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 2
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.13726!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.86274!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(194, 51)
        Me.TableLayoutPanel9.TabIndex = 5
        '
        'lblCantidadT
        '
        Me.lblCantidadT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCantidadT.AutoSize = True
        Me.lblCantidadT.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadT.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblCantidadT.Location = New System.Drawing.Point(66, 4)
        Me.lblCantidadT.Name = "lblCantidadT"
        Me.lblCantidadT.Size = New System.Drawing.Size(61, 13)
        Me.lblCantidadT.TabIndex = 4
        Me.lblCantidadT.Text = "CANTIDAD"
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(3, 25)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(188, 23)
        Me.txtCantidad.TabIndex = 0
        Me.txtCantidad.TabStop = False
        Me.txtCantidad.Text = "1"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnComprar
        '
        Me.btnComprar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnComprar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnComprar.FlatAppearance.BorderSize = 0
        Me.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComprar.ForeColor = System.Drawing.Color.White
        Me.btnComprar.Location = New System.Drawing.Point(3, 322)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(194, 24)
        Me.btnComprar.TabIndex = 6
        Me.btnComprar.Text = "LOREM IPSUM"
        Me.btnComprar.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtTotal, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 471)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(197, 32)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lorem Ipsum"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtTotal.AutoSize = True
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtTotal.Location = New System.Drawing.Point(160, 1)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(3, 1, 0, 0)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.txtTotal.Size = New System.Drawing.Size(37, 31)
        Me.txtTotal.TabIndex = 0
        Me.txtTotal.Text = "$0"
        '
        'ilProductosH
        '
        Me.ilProductosH.ImageStream = CType(resources.GetObject("ilProductosH.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilProductosH.TransparentColor = System.Drawing.Color.Transparent
        Me.ilProductosH.Images.SetKeyName(0, "hombres-01.jpg")
        Me.ilProductosH.Images.SetKeyName(1, "hombres-02.jpg")
        Me.ilProductosH.Images.SetKeyName(2, "hombres-03.jpg")
        Me.ilProductosH.Images.SetKeyName(3, "hombres-04.jpg")
        '
        'ilProductosM
        '
        Me.ilProductosM.ImageStream = CType(resources.GetObject("ilProductosM.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilProductosM.TransparentColor = System.Drawing.Color.Transparent
        Me.ilProductosM.Images.SetKeyName(0, "mujeres-01.jpg")
        Me.ilProductosM.Images.SetKeyName(1, "mujeres-02.jpg")
        Me.ilProductosM.Images.SetKeyName(2, "mujeres-03.jpg")
        Me.ilProductosM.Images.SetKeyName(3, "mujeres-04.jpg")
        '
        'ilProductosC
        '
        Me.ilProductosC.ImageStream = CType(resources.GetObject("ilProductosC.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilProductosC.TransparentColor = System.Drawing.Color.Transparent
        Me.ilProductosC.Images.SetKeyName(0, "calzado-01.jpg")
        Me.ilProductosC.Images.SetKeyName(1, "calzado-02.jpg")
        Me.ilProductosC.Images.SetKeyName(2, "calzado-03.jpg")
        Me.ilProductosC.Images.SetKeyName(3, "calzado-04.jpg")
        '
        'ilProductosA
        '
        Me.ilProductosA.ImageStream = CType(resources.GetObject("ilProductosA.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilProductosA.TransparentColor = System.Drawing.Color.Transparent
        Me.ilProductosA.Images.SetKeyName(0, "accesorios-01.jpg")
        Me.ilProductosA.Images.SetKeyName(1, "accesorios-02.jpg")
        Me.ilProductosA.Images.SetKeyName(2, "accesorios-03.jpg")
        Me.ilProductosA.Images.SetKeyName(3, "accesorios-04.jpg")
        '
        'ilProdH1small
        '
        Me.ilProdH1small.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ilProdH1small.ImageSize = New System.Drawing.Size(16, 16)
        Me.ilProdH1small.TransparentColor = System.Drawing.Color.Transparent
        '
        'pbProducto
        '
        Me.pbProducto.Location = New System.Drawing.Point(118, 310)
        Me.pbProducto.Name = "pbProducto"
        Me.pbProducto.Size = New System.Drawing.Size(381, 503)
        Me.pbProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProducto.TabIndex = 5
        Me.pbProducto.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(721, 854)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.Controls.Add(Me.TableLayoutPanel6)
        Me.Controls.Add(Me.tblTitle)
        Me.Controls.Add(Me.pbProducto)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.pbProdL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProdL2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProdL3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProdL4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblTitle.ResumeLayout(False)
        Me.tblMenu.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TblTallaLista.ResumeLayout(False)
        Me.TblTallaLista.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.tblTalla.ResumeLayout(False)
        Me.tblTalla.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.pbProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbCover As PictureBox
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRight As Button
    Friend WithEvents btnLeft As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents pbProdL1 As PictureBox
    Friend WithEvents pbProdL2 As PictureBox
    Friend WithEvents pbProdL3 As PictureBox
    Friend WithEvents pbProdL4 As PictureBox
    Friend WithEvents pbProducto As PictureBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblLorem As Label
    Friend WithEvents lblTallaT As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents tblTitle As TableLayoutPanel
    Friend WithEvents tblMenu As TableLayoutPanel
    Friend WithEvents btnHombres As Button
    Friend WithEvents btnMujeres As Button
    Friend WithEvents btnAccesorios As Button
    Friend WithEvents btnCalzado As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents lblCopyright As Label
    Friend WithEvents plLine2 As Panel
    Friend WithEvents plLine1 As Panel
    Friend WithEvents ilFlechas As ImageList
    Friend WithEvents TblTallaLista As TableLayoutPanel
    Friend WithEvents lblTallaP1 As Label
    Friend WithEvents lblTallaP2 As Label
    Friend WithEvents lblTallaP3 As Label
    Friend WithEvents lblTallaP4 As Label
    Friend WithEvents lblTallaP5 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents tblTalla As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents lblCantidadT As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents btnComprar As Button
    Friend WithEvents ilProductosH As ImageList
    Friend WithEvents ilProductosM As ImageList
    Friend WithEvents ilProductosC As ImageList
    Friend WithEvents ilProductosA As ImageList
    Friend WithEvents ilProdH1small As ImageList
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotal As Label
End Class
