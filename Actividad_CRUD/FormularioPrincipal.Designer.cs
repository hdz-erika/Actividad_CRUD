﻿namespace Actividad_CRUD
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tienda = new System.Windows.Forms.TabControl();
            this.tcEpleado = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.gbCatergoria = new System.Windows.Forms.GroupBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.Inventario = new System.Windows.Forms.TabPage();
            this.Productos = new System.Windows.Forms.TabPage();
            this.gbInventario = new System.Windows.Forms.GroupBox();
            this.lblInventario = new System.Windows.Forms.Label();
            this.txtInventario = new System.Windows.Forms.TextBox();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.btnEliminarInventario = new System.Windows.Forms.Button();
            this.btnModificarInventario = new System.Windows.Forms.Button();
            this.btnAgregarInventario = new System.Windows.Forms.Button();
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.lblProductos = new System.Windows.Forms.Label();
            this.txtProductos = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnEliminarProductos = new System.Windows.Forms.Button();
            this.btnModificarProductos = new System.Windows.Forms.Button();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.Ventas = new System.Windows.Forms.TabPage();
            this.gbVentas = new System.Windows.Forms.GroupBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.btnEliminarVentas = new System.Windows.Forms.Button();
            this.btnModificarVentas = new System.Windows.Forms.Button();
            this.btnAgregarVentas = new System.Windows.Forms.Button();
            this.lblMontoVenta = new System.Windows.Forms.Label();
            this.txtMontoVenta = new System.Windows.Forms.TextBox();
            this.Tienda.SuspendLayout();
            this.tcEpleado.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbCatergoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Inventario.SuspendLayout();
            this.Productos.SuspendLayout();
            this.gbInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.gbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.Ventas.SuspendLayout();
            this.gbVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // Tienda
            // 
            this.Tienda.Controls.Add(this.tcEpleado);
            this.Tienda.Controls.Add(this.tabPage2);
            this.Tienda.Controls.Add(this.Inventario);
            this.Tienda.Controls.Add(this.Productos);
            this.Tienda.Controls.Add(this.Ventas);
            this.Tienda.Location = new System.Drawing.Point(22, 27);
            this.Tienda.Name = "Tienda";
            this.Tienda.SelectedIndex = 0;
            this.Tienda.Size = new System.Drawing.Size(966, 447);
            this.Tienda.TabIndex = 0;
            // 
            // tcEpleado
            // 
            this.tcEpleado.Controls.Add(this.lblCargo);
            this.tcEpleado.Controls.Add(this.txtCargo);
            this.tcEpleado.Controls.Add(this.lblNombreEmpleado);
            this.tcEpleado.Controls.Add(this.txtEmpleado);
            this.tcEpleado.Controls.Add(this.dataGridView1);
            this.tcEpleado.Controls.Add(this.btnEliminar);
            this.tcEpleado.Controls.Add(this.btnModificar);
            this.tcEpleado.Controls.Add(this.btnAgregar);
            this.tcEpleado.Location = new System.Drawing.Point(4, 29);
            this.tcEpleado.Name = "tcEpleado";
            this.tcEpleado.Padding = new System.Windows.Forms.Padding(3);
            this.tcEpleado.Size = new System.Drawing.Size(958, 414);
            this.tcEpleado.TabIndex = 0;
            this.tcEpleado.Text = "Empleado";
            this.tcEpleado.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbCatergoria);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(958, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Categoria";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(126, 329);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 47);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(255, 329);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 47);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(387, 329);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 47);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(528, 269);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(608, 64);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(270, 26);
            this.txtEmpleado.TabIndex = 4;
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(608, 38);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(139, 20);
            this.lblNombreEmpleado.TabIndex = 5;
            this.lblNombreEmpleado.Text = "Nombre empleado";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(608, 105);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(52, 20);
            this.lblCargo.TabIndex = 7;
            this.lblCargo.Text = "Cargo";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(608, 131);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(270, 26);
            this.txtCargo.TabIndex = 6;
            // 
            // gbCatergoria
            // 
            this.gbCatergoria.Controls.Add(this.lblCategoria);
            this.gbCatergoria.Controls.Add(this.txtcategoria);
            this.gbCatergoria.Controls.Add(this.dataGridView2);
            this.gbCatergoria.Controls.Add(this.btnEliminarCategoria);
            this.gbCatergoria.Controls.Add(this.btnModificarCategoria);
            this.gbCatergoria.Controls.Add(this.btnAgregarCategoria);
            this.gbCatergoria.Location = new System.Drawing.Point(22, 6);
            this.gbCatergoria.Name = "gbCatergoria";
            this.gbCatergoria.Size = new System.Drawing.Size(903, 402);
            this.gbCatergoria.TabIndex = 0;
            this.gbCatergoria.TabStop = false;
            this.gbCatergoria.Text = "Categoria";
            this.gbCatergoria.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(586, 42);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(135, 20);
            this.lblCategoria.TabIndex = 13;
            this.lblCategoria.Text = "Nombre categoria";
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(586, 68);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(270, 26);
            this.txtcategoria.TabIndex = 12;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(27, 37);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(528, 269);
            this.dataGridView2.TabIndex = 11;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Location = new System.Drawing.Point(390, 312);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(110, 47);
            this.btnEliminarCategoria.TabIndex = 10;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Location = new System.Drawing.Point(258, 312);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(110, 47);
            this.btnModificarCategoria.TabIndex = 9;
            this.btnModificarCategoria.Text = "Modificar";
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(129, 312);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(110, 47);
            this.btnAgregarCategoria.TabIndex = 8;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            // 
            // Inventario
            // 
            this.Inventario.Controls.Add(this.gbInventario);
            this.Inventario.Location = new System.Drawing.Point(4, 29);
            this.Inventario.Name = "Inventario";
            this.Inventario.Padding = new System.Windows.Forms.Padding(3);
            this.Inventario.Size = new System.Drawing.Size(958, 414);
            this.Inventario.TabIndex = 2;
            this.Inventario.Text = "Inventarios";
            this.Inventario.UseVisualStyleBackColor = true;
            // 
            // Productos
            // 
            this.Productos.Controls.Add(this.gbProductos);
            this.Productos.Location = new System.Drawing.Point(4, 29);
            this.Productos.Name = "Productos";
            this.Productos.Padding = new System.Windows.Forms.Padding(3);
            this.Productos.Size = new System.Drawing.Size(958, 414);
            this.Productos.TabIndex = 3;
            this.Productos.Text = "Productos";
            this.Productos.UseVisualStyleBackColor = true;
            // 
            // gbInventario
            // 
            this.gbInventario.Controls.Add(this.lblInventario);
            this.gbInventario.Controls.Add(this.txtInventario);
            this.gbInventario.Controls.Add(this.dgvCategoria);
            this.gbInventario.Controls.Add(this.btnEliminarInventario);
            this.gbInventario.Controls.Add(this.btnModificarInventario);
            this.gbInventario.Controls.Add(this.btnAgregarInventario);
            this.gbInventario.Location = new System.Drawing.Point(28, 6);
            this.gbInventario.Name = "gbInventario";
            this.gbInventario.Size = new System.Drawing.Size(903, 402);
            this.gbInventario.TabIndex = 1;
            this.gbInventario.TabStop = false;
            this.gbInventario.Text = "Inventario";
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Location = new System.Drawing.Point(586, 42);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(137, 20);
            this.lblInventario.TabIndex = 13;
            this.lblInventario.Text = "Cantidad en stock";
            // 
            // txtInventario
            // 
            this.txtInventario.Location = new System.Drawing.Point(586, 68);
            this.txtInventario.Name = "txtInventario";
            this.txtInventario.Size = new System.Drawing.Size(270, 26);
            this.txtInventario.TabIndex = 12;
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(27, 37);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.RowHeadersWidth = 62;
            this.dgvCategoria.RowTemplate.Height = 28;
            this.dgvCategoria.Size = new System.Drawing.Size(528, 269);
            this.dgvCategoria.TabIndex = 11;
            // 
            // btnEliminarInventario
            // 
            this.btnEliminarInventario.Location = new System.Drawing.Point(390, 312);
            this.btnEliminarInventario.Name = "btnEliminarInventario";
            this.btnEliminarInventario.Size = new System.Drawing.Size(110, 47);
            this.btnEliminarInventario.TabIndex = 10;
            this.btnEliminarInventario.Text = "Eliminar";
            this.btnEliminarInventario.UseVisualStyleBackColor = true;
            // 
            // btnModificarInventario
            // 
            this.btnModificarInventario.Location = new System.Drawing.Point(258, 312);
            this.btnModificarInventario.Name = "btnModificarInventario";
            this.btnModificarInventario.Size = new System.Drawing.Size(110, 47);
            this.btnModificarInventario.TabIndex = 9;
            this.btnModificarInventario.Text = "Modificar";
            this.btnModificarInventario.UseVisualStyleBackColor = true;
            // 
            // btnAgregarInventario
            // 
            this.btnAgregarInventario.Location = new System.Drawing.Point(129, 312);
            this.btnAgregarInventario.Name = "btnAgregarInventario";
            this.btnAgregarInventario.Size = new System.Drawing.Size(110, 47);
            this.btnAgregarInventario.TabIndex = 8;
            this.btnAgregarInventario.Text = "Agregar";
            this.btnAgregarInventario.UseVisualStyleBackColor = true;
            // 
            // gbProductos
            // 
            this.gbProductos.Controls.Add(this.lblPrecioUnitario);
            this.gbProductos.Controls.Add(this.txtPrecioUnitario);
            this.gbProductos.Controls.Add(this.lblProductos);
            this.gbProductos.Controls.Add(this.txtProductos);
            this.gbProductos.Controls.Add(this.dgvProductos);
            this.gbProductos.Controls.Add(this.btnEliminarProductos);
            this.gbProductos.Controls.Add(this.btnModificarProductos);
            this.gbProductos.Controls.Add(this.btnAgregarProductos);
            this.gbProductos.Location = new System.Drawing.Point(28, 6);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(903, 402);
            this.gbProductos.TabIndex = 2;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "Productos";
            this.gbProductos.Enter += new System.EventHandler(this.gbProductos_Enter);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(586, 42);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(132, 20);
            this.lblProductos.TabIndex = 13;
            this.lblProductos.Text = "Nombre producto";
            // 
            // txtProductos
            // 
            this.txtProductos.Location = new System.Drawing.Point(586, 68);
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.Size = new System.Drawing.Size(270, 26);
            this.txtProductos.TabIndex = 12;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(27, 37);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 62;
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.Size = new System.Drawing.Size(528, 269);
            this.dgvProductos.TabIndex = 11;
            // 
            // btnEliminarProductos
            // 
            this.btnEliminarProductos.Location = new System.Drawing.Point(390, 312);
            this.btnEliminarProductos.Name = "btnEliminarProductos";
            this.btnEliminarProductos.Size = new System.Drawing.Size(110, 47);
            this.btnEliminarProductos.TabIndex = 10;
            this.btnEliminarProductos.Text = "Eliminar";
            this.btnEliminarProductos.UseVisualStyleBackColor = true;
            // 
            // btnModificarProductos
            // 
            this.btnModificarProductos.Location = new System.Drawing.Point(258, 312);
            this.btnModificarProductos.Name = "btnModificarProductos";
            this.btnModificarProductos.Size = new System.Drawing.Size(110, 47);
            this.btnModificarProductos.TabIndex = 9;
            this.btnModificarProductos.Text = "Modificar";
            this.btnModificarProductos.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.Location = new System.Drawing.Point(129, 312);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(110, 47);
            this.btnAgregarProductos.TabIndex = 8;
            this.btnAgregarProductos.Text = "Agregar";
            this.btnAgregarProductos.UseVisualStyleBackColor = true;
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(590, 122);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(109, 20);
            this.lblPrecioUnitario.TabIndex = 15;
            this.lblPrecioUnitario.Text = "Precio unitario";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(590, 148);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(270, 26);
            this.txtPrecioUnitario.TabIndex = 14;
            // 
            // Ventas
            // 
            this.Ventas.Controls.Add(this.gbVentas);
            this.Ventas.Location = new System.Drawing.Point(4, 29);
            this.Ventas.Name = "Ventas";
            this.Ventas.Padding = new System.Windows.Forms.Padding(3);
            this.Ventas.Size = new System.Drawing.Size(958, 414);
            this.Ventas.TabIndex = 4;
            this.Ventas.Text = "tabPage1";
            this.Ventas.UseVisualStyleBackColor = true;
            // 
            // gbVentas
            // 
            this.gbVentas.Controls.Add(this.lblMontoVenta);
            this.gbVentas.Controls.Add(this.txtMontoVenta);
            this.gbVentas.Controls.Add(this.lblCantidad);
            this.gbVentas.Controls.Add(this.txtCantidad);
            this.gbVentas.Controls.Add(this.lblFechaVenta);
            this.gbVentas.Controls.Add(this.txtProducto);
            this.gbVentas.Controls.Add(this.dgvVentas);
            this.gbVentas.Controls.Add(this.btnEliminarVentas);
            this.gbVentas.Controls.Add(this.btnModificarVentas);
            this.gbVentas.Controls.Add(this.btnAgregarVentas);
            this.gbVentas.Location = new System.Drawing.Point(28, 6);
            this.gbVentas.Name = "gbVentas";
            this.gbVentas.Size = new System.Drawing.Size(903, 402);
            this.gbVentas.TabIndex = 3;
            this.gbVentas.TabStop = false;
            this.gbVentas.Text = "Productos";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(590, 122);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 20);
            this.lblCantidad.TabIndex = 15;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(590, 148);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(270, 26);
            this.txtCantidad.TabIndex = 14;
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Location = new System.Drawing.Point(586, 42);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(132, 20);
            this.lblFechaVenta.TabIndex = 13;
            this.lblFechaVenta.Text = "Nombre producto";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(586, 68);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(270, 26);
            this.txtProducto.TabIndex = 12;
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(27, 37);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersWidth = 62;
            this.dgvVentas.RowTemplate.Height = 28;
            this.dgvVentas.Size = new System.Drawing.Size(528, 269);
            this.dgvVentas.TabIndex = 11;
            // 
            // btnEliminarVentas
            // 
            this.btnEliminarVentas.Location = new System.Drawing.Point(390, 312);
            this.btnEliminarVentas.Name = "btnEliminarVentas";
            this.btnEliminarVentas.Size = new System.Drawing.Size(110, 47);
            this.btnEliminarVentas.TabIndex = 10;
            this.btnEliminarVentas.Text = "btnEliminarProducto";
            this.btnEliminarVentas.UseVisualStyleBackColor = true;
            // 
            // btnModificarVentas
            // 
            this.btnModificarVentas.Location = new System.Drawing.Point(258, 312);
            this.btnModificarVentas.Name = "btnModificarVentas";
            this.btnModificarVentas.Size = new System.Drawing.Size(110, 47);
            this.btnModificarVentas.TabIndex = 9;
            this.btnModificarVentas.Text = "btnModificarProducto";
            this.btnModificarVentas.UseVisualStyleBackColor = true;
            // 
            // btnAgregarVentas
            // 
            this.btnAgregarVentas.Location = new System.Drawing.Point(129, 312);
            this.btnAgregarVentas.Name = "btnAgregarVentas";
            this.btnAgregarVentas.Size = new System.Drawing.Size(110, 47);
            this.btnAgregarVentas.TabIndex = 8;
            this.btnAgregarVentas.Text = "btnAgregarProducto";
            this.btnAgregarVentas.UseVisualStyleBackColor = true;
            // 
            // lblMontoVenta
            // 
            this.lblMontoVenta.AutoSize = true;
            this.lblMontoVenta.Location = new System.Drawing.Point(586, 209);
            this.lblMontoVenta.Name = "lblMontoVenta";
            this.lblMontoVenta.Size = new System.Drawing.Size(97, 20);
            this.lblMontoVenta.TabIndex = 17;
            this.lblMontoVenta.Text = "Monto venta";
            // 
            // txtMontoVenta
            // 
            this.txtMontoVenta.Location = new System.Drawing.Point(586, 235);
            this.txtMontoVenta.Name = "txtMontoVenta";
            this.txtMontoVenta.Size = new System.Drawing.Size(270, 26);
            this.txtMontoVenta.TabIndex = 16;
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 486);
            this.Controls.Add(this.Tienda);
            this.Name = "FormularioPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioPrincipal";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.Tienda.ResumeLayout(false);
            this.tcEpleado.ResumeLayout(false);
            this.tcEpleado.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbCatergoria.ResumeLayout(false);
            this.gbCatergoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Inventario.ResumeLayout(false);
            this.Productos.ResumeLayout(false);
            this.gbInventario.ResumeLayout(false);
            this.gbInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.gbProductos.ResumeLayout(false);
            this.gbProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.Ventas.ResumeLayout(false);
            this.gbVentas.ResumeLayout(false);
            this.gbVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tienda;
        private System.Windows.Forms.TabPage tcEpleado;
        public System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox gbCatergoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.TabPage Inventario;
        private System.Windows.Forms.TabPage Productos;
        private System.Windows.Forms.GroupBox gbInventario;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.TextBox txtInventario;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Button btnEliminarInventario;
        private System.Windows.Forms.Button btnModificarInventario;
        private System.Windows.Forms.Button btnAgregarInventario;
        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.TextBox txtProductos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnEliminarProductos;
        private System.Windows.Forms.Button btnModificarProductos;
        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.TabPage Ventas;
        private System.Windows.Forms.GroupBox gbVentas;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnEliminarVentas;
        private System.Windows.Forms.Button btnModificarVentas;
        private System.Windows.Forms.Button btnAgregarVentas;
        private System.Windows.Forms.Label lblMontoVenta;
        private System.Windows.Forms.TextBox txtMontoVenta;
    }
}