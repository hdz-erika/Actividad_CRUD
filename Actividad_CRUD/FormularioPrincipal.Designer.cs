namespace Actividad_CRUD
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
            this.components = new System.ComponentModel.Container();
            this.vistaInventarioConNombreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaDataSet3 = new Actividad_CRUD.tiendaDataSet3();
            this.vistaProductosConNombreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaDataSet4 = new Actividad_CRUD.tiendaDataSet4();
            this.vistaVentasConNombreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaDataSet2 = new Actividad_CRUD.tiendaDataSet2();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaDataSet5 = new Actividad_CRUD.tiendaDataSet5();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaDataSet = new Actividad_CRUD.tiendaDataSet();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaDataSet1 = new Actividad_CRUD.tiendaDataSet1();
            this.categoriasTableAdapter = new Actividad_CRUD.tiendaDataSetTableAdapters.CategoriasTableAdapter();
            this.ventasTableAdapter = new Actividad_CRUD.tiendaDataSet1TableAdapters.VentasTableAdapter();
            this.vistaVentasConNombreTableAdapter = new Actividad_CRUD.tiendaDataSet2TableAdapters.VistaVentasConNombreTableAdapter();
            this.vistaInventarioConNombreTableAdapter = new Actividad_CRUD.tiendaDataSet3TableAdapters.VistaInventarioConNombreTableAdapter();
            this.vistaProductosConNombreTableAdapter = new Actividad_CRUD.tiendaDataSet4TableAdapters.VistaProductosConNombreTableAdapter();
            this.usuariosTableAdapter = new Actividad_CRUD.tiendaDataSet5TableAdapters.UsuariosTableAdapter();
            this.tiendaDataSet6 = new Actividad_CRUD.tiendaDataSet6();
            this.vistaVentasConNombreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vistaVentasConNombreTableAdapter1 = new Actividad_CRUD.tiendaDataSet6TableAdapters.VistaVentasConNombreTableAdapter();
            this.tcUsuarios = new System.Windows.Forms.TabPage();
            this.gbUsuarios = new System.Windows.Forms.GroupBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.btnLimpiarUsuario = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTipoUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.Ventas = new System.Windows.Forms.TabPage();
            this.gbVentas = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpVenta = new System.Windows.Forms.DateTimePicker();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.btnLimpiarVentas = new System.Windows.Forms.Button();
            this.lblMontoVenta = new System.Windows.Forms.Label();
            this.txtMontoVenta = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.btnEliminarVentas = new System.Windows.Forms.Button();
            this.btnModificarVentas = new System.Windows.Forms.Button();
            this.btnAgregarVentas = new System.Windows.Forms.Button();
            this.Productos = new System.Windows.Forms.TabPage();
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.btnLimpiarProductos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbIDCategoria = new System.Windows.Forms.ComboBox();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.lblProductos = new System.Windows.Forms.Label();
            this.txtProductos = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnEliminarProductos = new System.Windows.Forms.Button();
            this.btnModificarProductos = new System.Windows.Forms.Button();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.Categoria = new System.Windows.Forms.TabPage();
            this.gbCatergoria = new System.Windows.Forms.GroupBox();
            this.btnLimpiarCategoria = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.Empleado = new System.Windows.Forms.TabPage();
            this.gbEmpleado = new System.Windows.Forms.GroupBox();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.btnLimpiarEmpleado = new System.Windows.Forms.Button();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.Tienda = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vistaInventarioConNombreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProductosConNombreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaVentasConNombreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaVentasConNombreBindingSource1)).BeginInit();
            this.tcUsuarios.SuspendLayout();
            this.gbUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.Ventas.SuspendLayout();
            this.gbVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.Productos.SuspendLayout();
            this.gbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.Categoria.SuspendLayout();
            this.gbCatergoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.Empleado.SuspendLayout();
            this.gbEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            this.Tienda.SuspendLayout();
            this.SuspendLayout();
            // 
            // vistaInventarioConNombreBindingSource
            // 
            this.vistaInventarioConNombreBindingSource.DataMember = "VistaInventarioConNombre";
            this.vistaInventarioConNombreBindingSource.DataSource = this.tiendaDataSet3;
            // 
            // tiendaDataSet3
            // 
            this.tiendaDataSet3.DataSetName = "tiendaDataSet3";
            this.tiendaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaProductosConNombreBindingSource
            // 
            this.vistaProductosConNombreBindingSource.DataMember = "VistaProductosConNombre";
            this.vistaProductosConNombreBindingSource.DataSource = this.tiendaDataSet4;
            // 
            // tiendaDataSet4
            // 
            this.tiendaDataSet4.DataSetName = "tiendaDataSet4";
            this.tiendaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaVentasConNombreBindingSource
            // 
            this.vistaVentasConNombreBindingSource.DataMember = "VistaVentasConNombre";
            this.vistaVentasConNombreBindingSource.DataSource = this.tiendaDataSet2;
            // 
            // tiendaDataSet2
            // 
            this.tiendaDataSet2.DataSetName = "tiendaDataSet2";
            this.tiendaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.tiendaDataSet5;
            // 
            // tiendaDataSet5
            // 
            this.tiendaDataSet5.DataSetName = "tiendaDataSet5";
            this.tiendaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "Categorias";
            this.categoriasBindingSource.DataSource = this.tiendaDataSet;
            // 
            // tiendaDataSet
            // 
            this.tiendaDataSet.DataSetName = "tiendaDataSet";
            this.tiendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "Ventas";
            this.ventasBindingSource.DataSource = this.tiendaDataSet1;
            // 
            // tiendaDataSet1
            // 
            this.tiendaDataSet1.DataSetName = "tiendaDataSet1";
            this.tiendaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // vistaVentasConNombreTableAdapter
            // 
            this.vistaVentasConNombreTableAdapter.ClearBeforeFill = true;
            // 
            // vistaInventarioConNombreTableAdapter
            // 
            this.vistaInventarioConNombreTableAdapter.ClearBeforeFill = true;
            // 
            // vistaProductosConNombreTableAdapter
            // 
            this.vistaProductosConNombreTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tiendaDataSet6
            // 
            this.tiendaDataSet6.DataSetName = "tiendaDataSet6";
            this.tiendaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaVentasConNombreBindingSource1
            // 
            this.vistaVentasConNombreBindingSource1.DataMember = "VistaVentasConNombre";
            this.vistaVentasConNombreBindingSource1.DataSource = this.tiendaDataSet6;
            // 
            // vistaVentasConNombreTableAdapter1
            // 
            this.vistaVentasConNombreTableAdapter1.ClearBeforeFill = true;
            // 
            // tcUsuarios
            // 
            this.tcUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tcUsuarios.Controls.Add(this.gbUsuarios);
            this.tcUsuarios.Location = new System.Drawing.Point(4, 37);
            this.tcUsuarios.Name = "tcUsuarios";
            this.tcUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tcUsuarios.Size = new System.Drawing.Size(948, 427);
            this.tcUsuarios.TabIndex = 5;
            this.tcUsuarios.Text = "Usuarios";
            // 
            // gbUsuarios
            // 
            this.gbUsuarios.Controls.Add(this.lblNombreUsuario);
            this.gbUsuarios.Controls.Add(this.txtNombreUsuario);
            this.gbUsuarios.Controls.Add(this.btnLimpiarUsuario);
            this.gbUsuarios.Controls.Add(this.label5);
            this.gbUsuarios.Controls.Add(this.txtTipoUsuario);
            this.gbUsuarios.Controls.Add(this.label6);
            this.gbUsuarios.Controls.Add(this.txtContrasena);
            this.gbUsuarios.Controls.Add(this.dgvUsuarios);
            this.gbUsuarios.Controls.Add(this.btnEliminarUsuario);
            this.gbUsuarios.Controls.Add(this.btnModificarUsuario);
            this.gbUsuarios.Controls.Add(this.btnAgregarUsuario);
            this.gbUsuarios.Font = new System.Drawing.Font("Ebrima", 10F);
            this.gbUsuarios.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbUsuarios.Location = new System.Drawing.Point(28, 6);
            this.gbUsuarios.Name = "gbUsuarios";
            this.gbUsuarios.Size = new System.Drawing.Size(903, 402);
            this.gbUsuarios.TabIndex = 4;
            this.gbUsuarios.TabStop = false;
            this.gbUsuarios.Text = "Usuarios";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(581, 198);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(157, 28);
            this.lblNombreUsuario.TabIndex = 23;
            this.lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreUsuario.ForeColor = System.Drawing.Color.Silver;
            this.txtNombreUsuario.Location = new System.Drawing.Point(586, 242);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(270, 35);
            this.txtNombreUsuario.TabIndex = 22;
            this.txtNombreUsuario.Click += new System.EventHandler(this.txtNombreUsuario_Click);
            // 
            // btnLimpiarUsuario
            // 
            this.btnLimpiarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnLimpiarUsuario.FlatAppearance.BorderSize = 0;
            this.btnLimpiarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarUsuario.Location = new System.Drawing.Point(586, 283);
            this.btnLimpiarUsuario.Name = "btnLimpiarUsuario";
            this.btnLimpiarUsuario.Size = new System.Drawing.Size(110, 48);
            this.btnLimpiarUsuario.TabIndex = 19;
            this.btnLimpiarUsuario.Text = "Limpiar";
            this.btnLimpiarUsuario.UseVisualStyleBackColor = false;
            this.btnLimpiarUsuario.Click += new System.EventHandler(this.btnLimpiarUsuario_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(581, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tipo Usuario";
            // 
            // txtTipoUsuario
            // 
            this.txtTipoUsuario.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTipoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTipoUsuario.ForeColor = System.Drawing.Color.Silver;
            this.txtTipoUsuario.Location = new System.Drawing.Point(586, 160);
            this.txtTipoUsuario.Name = "txtTipoUsuario";
            this.txtTipoUsuario.Size = new System.Drawing.Size(270, 35);
            this.txtTipoUsuario.TabIndex = 16;
            this.txtTipoUsuario.Click += new System.EventHandler(this.txtTipoUsuario_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(581, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Contaseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasena.ForeColor = System.Drawing.Color.Silver;
            this.txtContrasena.Location = new System.Drawing.Point(586, 67);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(270, 35);
            this.txtContrasena.TabIndex = 14;
            this.txtContrasena.Click += new System.EventHandler(this.txtContrasena_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(27, 37);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 62;
            this.dgvUsuarios.RowTemplate.Height = 28;
            this.dgvUsuarios.Size = new System.Drawing.Size(528, 269);
            this.dgvUsuarios.TabIndex = 11;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnEliminarUsuario.FlatAppearance.BorderSize = 0;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(288, 312);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(110, 48);
            this.btnEliminarUsuario.TabIndex = 10;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnModificarUsuario.FlatAppearance.BorderSize = 0;
            this.btnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarUsuario.Location = new System.Drawing.Point(156, 312);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(110, 48);
            this.btnModificarUsuario.TabIndex = 9;
            this.btnModificarUsuario.Text = "Modificar";
            this.btnModificarUsuario.UseVisualStyleBackColor = false;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnAgregarUsuario.FlatAppearance.BorderSize = 0;
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(27, 312);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(110, 48);
            this.btnAgregarUsuario.TabIndex = 8;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = false;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // Ventas
            // 
            this.Ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Ventas.Controls.Add(this.gbVentas);
            this.Ventas.Location = new System.Drawing.Point(4, 37);
            this.Ventas.Name = "Ventas";
            this.Ventas.Padding = new System.Windows.Forms.Padding(3);
            this.Ventas.Size = new System.Drawing.Size(948, 427);
            this.Ventas.TabIndex = 4;
            this.Ventas.Text = "Ventas";
            // 
            // gbVentas
            // 
            this.gbVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.gbVentas.Controls.Add(this.label2);
            this.gbVentas.Controls.Add(this.dtpVenta);
            this.gbVentas.Controls.Add(this.lblProducto);
            this.gbVentas.Controls.Add(this.cbProducto);
            this.gbVentas.Controls.Add(this.btnLimpiarVentas);
            this.gbVentas.Controls.Add(this.lblMontoVenta);
            this.gbVentas.Controls.Add(this.txtMontoVenta);
            this.gbVentas.Controls.Add(this.lblCantidad);
            this.gbVentas.Controls.Add(this.txtCantidad);
            this.gbVentas.Controls.Add(this.dgvVentas);
            this.gbVentas.Controls.Add(this.btnEliminarVentas);
            this.gbVentas.Controls.Add(this.btnModificarVentas);
            this.gbVentas.Controls.Add(this.btnAgregarVentas);
            this.gbVentas.Font = new System.Drawing.Font("Ebrima", 10F);
            this.gbVentas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbVentas.Location = new System.Drawing.Point(28, 6);
            this.gbVentas.Name = "gbVentas";
            this.gbVentas.Size = new System.Drawing.Size(903, 402);
            this.gbVentas.TabIndex = 3;
            this.gbVentas.TabStop = false;
            this.gbVentas.Text = "Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Fecha";
            // 
            // dtpVenta
            // 
            this.dtpVenta.CalendarTitleBackColor = System.Drawing.Color.MediumAquamarine;
            this.dtpVenta.Location = new System.Drawing.Point(586, 316);
            this.dtpVenta.Name = "dtpVenta";
            this.dtpVenta.Size = new System.Drawing.Size(266, 35);
            this.dtpVenta.TabIndex = 22;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(582, 20);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(93, 28);
            this.lblProducto.TabIndex = 21;
            this.lblProducto.Text = "Producto";
            // 
            // cbProducto
            // 
            this.cbProducto.DataSource = this.vistaVentasConNombreBindingSource1;
            this.cbProducto.DisplayMember = "NombreProducto";
            this.cbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(586, 56);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(266, 36);
            this.cbProducto.TabIndex = 20;
            this.cbProducto.ValueMember = "IDProducto";
            // 
            // btnLimpiarVentas
            // 
            this.btnLimpiarVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnLimpiarVentas.FlatAppearance.BorderSize = 0;
            this.btnLimpiarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarVentas.Location = new System.Drawing.Point(421, 330);
            this.btnLimpiarVentas.Name = "btnLimpiarVentas";
            this.btnLimpiarVentas.Size = new System.Drawing.Size(110, 48);
            this.btnLimpiarVentas.TabIndex = 19;
            this.btnLimpiarVentas.Text = "Limpiar";
            this.btnLimpiarVentas.UseVisualStyleBackColor = false;
            this.btnLimpiarVentas.Click += new System.EventHandler(this.btnLimpiarVentas_Click);
            // 
            // lblMontoVenta
            // 
            this.lblMontoVenta.AutoSize = true;
            this.lblMontoVenta.Location = new System.Drawing.Point(582, 185);
            this.lblMontoVenta.Name = "lblMontoVenta";
            this.lblMontoVenta.Size = new System.Drawing.Size(125, 28);
            this.lblMontoVenta.TabIndex = 17;
            this.lblMontoVenta.Text = "Monto venta";
            // 
            // txtMontoVenta
            // 
            this.txtMontoVenta.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMontoVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoVenta.ForeColor = System.Drawing.Color.Silver;
            this.txtMontoVenta.Location = new System.Drawing.Point(587, 226);
            this.txtMontoVenta.Name = "txtMontoVenta";
            this.txtMontoVenta.Size = new System.Drawing.Size(270, 35);
            this.txtMontoVenta.TabIndex = 16;
            this.txtMontoVenta.Click += new System.EventHandler(this.txtMontoVenta_Click);
            this.txtMontoVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoVenta_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(582, 100);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(91, 28);
            this.lblCantidad.TabIndex = 15;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.ForeColor = System.Drawing.Color.Silver;
            this.txtCantidad.Location = new System.Drawing.Point(587, 142);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(270, 35);
            this.txtCantidad.TabIndex = 14;
            this.txtCantidad.Click += new System.EventHandler(this.txtCantidad_Click);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
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
            this.dgvVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellClick);
            // 
            // btnEliminarVentas
            // 
            this.btnEliminarVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnEliminarVentas.FlatAppearance.BorderSize = 0;
            this.btnEliminarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarVentas.Location = new System.Drawing.Point(288, 330);
            this.btnEliminarVentas.Name = "btnEliminarVentas";
            this.btnEliminarVentas.Size = new System.Drawing.Size(110, 48);
            this.btnEliminarVentas.TabIndex = 10;
            this.btnEliminarVentas.Text = "Eliminar";
            this.btnEliminarVentas.UseVisualStyleBackColor = false;
            this.btnEliminarVentas.Click += new System.EventHandler(this.btnEliminarVentas_Click);
            // 
            // btnModificarVentas
            // 
            this.btnModificarVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnModificarVentas.FlatAppearance.BorderSize = 0;
            this.btnModificarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarVentas.Location = new System.Drawing.Point(156, 330);
            this.btnModificarVentas.Name = "btnModificarVentas";
            this.btnModificarVentas.Size = new System.Drawing.Size(110, 48);
            this.btnModificarVentas.TabIndex = 9;
            this.btnModificarVentas.Text = "Modificar";
            this.btnModificarVentas.UseVisualStyleBackColor = false;
            this.btnModificarVentas.Click += new System.EventHandler(this.btnModificarVentas_Click);
            // 
            // btnAgregarVentas
            // 
            this.btnAgregarVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnAgregarVentas.FlatAppearance.BorderSize = 0;
            this.btnAgregarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarVentas.Location = new System.Drawing.Point(27, 330);
            this.btnAgregarVentas.Name = "btnAgregarVentas";
            this.btnAgregarVentas.Size = new System.Drawing.Size(110, 48);
            this.btnAgregarVentas.TabIndex = 8;
            this.btnAgregarVentas.Text = "Agregar";
            this.btnAgregarVentas.UseVisualStyleBackColor = false;
            this.btnAgregarVentas.Click += new System.EventHandler(this.btnAgregarVentas_Click);
            // 
            // Productos
            // 
            this.Productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Productos.Controls.Add(this.gbProductos);
            this.Productos.Location = new System.Drawing.Point(4, 37);
            this.Productos.Name = "Productos";
            this.Productos.Padding = new System.Windows.Forms.Padding(3);
            this.Productos.Size = new System.Drawing.Size(948, 427);
            this.Productos.TabIndex = 3;
            this.Productos.Text = "Productos";
            // 
            // gbProductos
            // 
            this.gbProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.gbProductos.Controls.Add(this.btnLimpiarProductos);
            this.gbProductos.Controls.Add(this.label1);
            this.gbProductos.Controls.Add(this.cbIDCategoria);
            this.gbProductos.Controls.Add(this.lblPrecioUnitario);
            this.gbProductos.Controls.Add(this.txtPrecioUnitario);
            this.gbProductos.Controls.Add(this.lblProductos);
            this.gbProductos.Controls.Add(this.txtProductos);
            this.gbProductos.Controls.Add(this.dgvProductos);
            this.gbProductos.Controls.Add(this.btnEliminarProductos);
            this.gbProductos.Controls.Add(this.btnModificarProductos);
            this.gbProductos.Controls.Add(this.btnAgregarProductos);
            this.gbProductos.Font = new System.Drawing.Font("Ebrima", 10F);
            this.gbProductos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbProductos.Location = new System.Drawing.Point(28, 6);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(903, 402);
            this.gbProductos.TabIndex = 2;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "Productos";
            // 
            // btnLimpiarProductos
            // 
            this.btnLimpiarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnLimpiarProductos.FlatAppearance.BorderSize = 0;
            this.btnLimpiarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarProductos.Location = new System.Drawing.Point(586, 296);
            this.btnLimpiarProductos.Name = "btnLimpiarProductos";
            this.btnLimpiarProductos.Size = new System.Drawing.Size(110, 48);
            this.btnLimpiarProductos.TabIndex = 18;
            this.btnLimpiarProductos.Text = "Limpiar";
            this.btnLimpiarProductos.UseVisualStyleBackColor = false;
            this.btnLimpiarProductos.Click += new System.EventHandler(this.btnLimpiarProductos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Categoria";
            // 
            // cbIDCategoria
            // 
            this.cbIDCategoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbIDCategoria.DataSource = this.vistaProductosConNombreBindingSource;
            this.cbIDCategoria.DisplayMember = "NombreCategoria";
            this.cbIDCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIDCategoria.FormattingEnabled = true;
            this.cbIDCategoria.Location = new System.Drawing.Point(586, 245);
            this.cbIDCategoria.Name = "cbIDCategoria";
            this.cbIDCategoria.Size = new System.Drawing.Size(274, 36);
            this.cbIDCategoria.TabIndex = 16;
            this.cbIDCategoria.ValueMember = "IDCategoria";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(581, 122);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(139, 28);
            this.lblPrecioUnitario.TabIndex = 15;
            this.lblPrecioUnitario.Text = "Precio unitario";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.txtPrecioUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioUnitario.ForeColor = System.Drawing.Color.Silver;
            this.txtPrecioUnitario.Location = new System.Drawing.Point(586, 163);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(270, 35);
            this.txtPrecioUnitario.TabIndex = 14;
            this.txtPrecioUnitario.Click += new System.EventHandler(this.txtPrecioUnitario_Click);
            this.txtPrecioUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioUnitario_KeyPress);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(581, 37);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(172, 28);
            this.lblProductos.TabIndex = 13;
            this.lblProductos.Text = "Nombre producto";
            // 
            // txtProductos
            // 
            this.txtProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.txtProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductos.ForeColor = System.Drawing.Color.Silver;
            this.txtProductos.Location = new System.Drawing.Point(586, 73);
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.Size = new System.Drawing.Size(270, 35);
            this.txtProductos.TabIndex = 12;
            this.txtProductos.Click += new System.EventHandler(this.txtProductos_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(24, 37);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 62;
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.Size = new System.Drawing.Size(528, 269);
            this.dgvProductos.TabIndex = 11;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // btnEliminarProductos
            // 
            this.btnEliminarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnEliminarProductos.FlatAppearance.BorderSize = 0;
            this.btnEliminarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProductos.Location = new System.Drawing.Point(285, 330);
            this.btnEliminarProductos.Name = "btnEliminarProductos";
            this.btnEliminarProductos.Size = new System.Drawing.Size(110, 48);
            this.btnEliminarProductos.TabIndex = 10;
            this.btnEliminarProductos.Text = "Eliminar";
            this.btnEliminarProductos.UseVisualStyleBackColor = false;
            this.btnEliminarProductos.Click += new System.EventHandler(this.btnEliminarProductos_Click);
            // 
            // btnModificarProductos
            // 
            this.btnModificarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnModificarProductos.FlatAppearance.BorderSize = 0;
            this.btnModificarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProductos.Location = new System.Drawing.Point(153, 330);
            this.btnModificarProductos.Name = "btnModificarProductos";
            this.btnModificarProductos.Size = new System.Drawing.Size(110, 48);
            this.btnModificarProductos.TabIndex = 9;
            this.btnModificarProductos.Text = "Modificar";
            this.btnModificarProductos.UseVisualStyleBackColor = false;
            this.btnModificarProductos.Click += new System.EventHandler(this.btnModificarProductos_Click);
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnAgregarProductos.FlatAppearance.BorderSize = 0;
            this.btnAgregarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProductos.Location = new System.Drawing.Point(24, 330);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(110, 48);
            this.btnAgregarProductos.TabIndex = 8;
            this.btnAgregarProductos.Text = "Agregar";
            this.btnAgregarProductos.UseVisualStyleBackColor = false;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // Categoria
            // 
            this.Categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Categoria.Controls.Add(this.gbCatergoria);
            this.Categoria.Location = new System.Drawing.Point(4, 37);
            this.Categoria.Name = "Categoria";
            this.Categoria.Padding = new System.Windows.Forms.Padding(3);
            this.Categoria.Size = new System.Drawing.Size(948, 427);
            this.Categoria.TabIndex = 1;
            this.Categoria.Text = "Categoria";
            // 
            // gbCatergoria
            // 
            this.gbCatergoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.gbCatergoria.Controls.Add(this.btnLimpiarCategoria);
            this.gbCatergoria.Controls.Add(this.lblCategoria);
            this.gbCatergoria.Controls.Add(this.txtcategoria);
            this.gbCatergoria.Controls.Add(this.dgvCategoria);
            this.gbCatergoria.Controls.Add(this.btnEliminarCategoria);
            this.gbCatergoria.Controls.Add(this.btnModificarCategoria);
            this.gbCatergoria.Controls.Add(this.btnAgregarCategoria);
            this.gbCatergoria.Font = new System.Drawing.Font("Ebrima", 10F);
            this.gbCatergoria.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbCatergoria.Location = new System.Drawing.Point(22, 6);
            this.gbCatergoria.Name = "gbCatergoria";
            this.gbCatergoria.Size = new System.Drawing.Size(903, 403);
            this.gbCatergoria.TabIndex = 0;
            this.gbCatergoria.TabStop = false;
            this.gbCatergoria.Text = "Categoria";
            
            // 
            // btnLimpiarCategoria
            // 
            this.btnLimpiarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnLimpiarCategoria.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCategoria.Location = new System.Drawing.Point(591, 127);
            this.btnLimpiarCategoria.Name = "btnLimpiarCategoria";
            this.btnLimpiarCategoria.Size = new System.Drawing.Size(110, 48);
            this.btnLimpiarCategoria.TabIndex = 14;
            this.btnLimpiarCategoria.Text = "Limpiar";
            this.btnLimpiarCategoria.UseVisualStyleBackColor = false;
            this.btnLimpiarCategoria.Click += new System.EventHandler(this.btnLimpiarCategoria_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(586, 42);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(172, 28);
            this.lblCategoria.TabIndex = 13;
            this.lblCategoria.Text = "Nombre categoria";
            // 
            // txtcategoria
            // 
            this.txtcategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.txtcategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcategoria.ForeColor = System.Drawing.Color.Silver;
            this.txtcategoria.Location = new System.Drawing.Point(592, 74);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(281, 35);
            this.txtcategoria.TabIndex = 12;
            this.txtcategoria.Click += new System.EventHandler(this.txtcategoria_Click);
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
            this.dgvCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellClick);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnEliminarCategoria.FlatAppearance.BorderSize = 0;
            this.btnEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(288, 328);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(110, 48);
            this.btnEliminarCategoria.TabIndex = 10;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = false;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnModificarCategoria.FlatAppearance.BorderSize = 0;
            this.btnModificarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnModificarCategoria.Location = new System.Drawing.Point(156, 328);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(110, 48);
            this.btnModificarCategoria.TabIndex = 9;
            this.btnModificarCategoria.Text = "Modificar";
            this.btnModificarCategoria.UseVisualStyleBackColor = false;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnAgregarCategoria.FlatAppearance.BorderSize = 0;
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(27, 328);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(110, 48);
            this.btnAgregarCategoria.TabIndex = 8;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // Empleado
            // 
            this.Empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Empleado.Controls.Add(this.gbEmpleado);
            this.Empleado.Location = new System.Drawing.Point(4, 37);
            this.Empleado.Margin = new System.Windows.Forms.Padding(0);
            this.Empleado.Name = "Empleado";
            this.Empleado.Size = new System.Drawing.Size(948, 427);
            this.Empleado.TabIndex = 0;
            this.Empleado.Text = "Empleado";
            // 
            // gbEmpleado
            // 
            this.gbEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.gbEmpleado.Controls.Add(this.lblNombreEmpleado);
            this.gbEmpleado.Controls.Add(this.lblCargo);
            this.gbEmpleado.Controls.Add(this.btnLimpiarEmpleado);
            this.gbEmpleado.Controls.Add(this.txtCargo);
            this.gbEmpleado.Controls.Add(this.btnAgregar);
            this.gbEmpleado.Controls.Add(this.txtEmpleado);
            this.gbEmpleado.Controls.Add(this.btnEliminar);
            this.gbEmpleado.Controls.Add(this.btnModificar);
            this.gbEmpleado.Controls.Add(this.dgvEmpleado);
            this.gbEmpleado.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmpleado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbEmpleado.Location = new System.Drawing.Point(23, 10);
            this.gbEmpleado.Name = "gbEmpleado";
            this.gbEmpleado.Size = new System.Drawing.Size(913, 408);
            this.gbEmpleado.TabIndex = 8;
            this.gbEmpleado.TabStop = false;
            this.gbEmpleado.Text = "Empleado";
           
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(582, 49);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(178, 28);
            this.lblNombreEmpleado.TabIndex = 5;
            this.lblNombreEmpleado.Text = "Nombre empleado";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(582, 146);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(65, 28);
            this.lblCargo.TabIndex = 7;
            this.lblCargo.Text = "Cargo";
            // 
            // btnLimpiarEmpleado
            // 
            this.btnLimpiarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnLimpiarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnLimpiarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarEmpleado.Font = new System.Drawing.Font("Ebrima", 10F);
            this.btnLimpiarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarEmpleado.Location = new System.Drawing.Point(586, 246);
            this.btnLimpiarEmpleado.Name = "btnLimpiarEmpleado";
            this.btnLimpiarEmpleado.Size = new System.Drawing.Size(110, 48);
            this.btnLimpiarEmpleado.TabIndex = 3;
            this.btnLimpiarEmpleado.Text = "Limpiar";
            this.btnLimpiarEmpleado.UseVisualStyleBackColor = false;
            this.btnLimpiarEmpleado.Click += new System.EventHandler(this.btnLimpiarEmpleado_Click);
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCargo.ForeColor = System.Drawing.Color.Silver;
            this.txtCargo.Location = new System.Drawing.Point(586, 197);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(315, 34);
            this.txtCargo.TabIndex = 6;
            this.txtCargo.Click += new System.EventHandler(this.txtCargo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Ebrima", 10F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(20, 337);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 48);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.txtEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpleado.ForeColor = System.Drawing.Color.Silver;
            this.txtEmpleado.Location = new System.Drawing.Point(586, 92);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(315, 34);
            this.txtEmpleado.TabIndex = 4;
            this.txtEmpleado.Click += new System.EventHandler(this.txtEmpleado_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Ebrima", 10F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(298, 337);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 48);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Ebrima", 10F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(148, 337);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(129, 48);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvEmpleado.Location = new System.Drawing.Point(20, 46);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.RowHeadersWidth = 62;
            this.dgvEmpleado.RowTemplate.Height = 28;
            this.dgvEmpleado.Size = new System.Drawing.Size(528, 269);
            this.dgvEmpleado.TabIndex = 3;
            this.dgvEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleado_CellClick);
            // 
            // Tienda
            // 
            this.Tienda.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Tienda.Controls.Add(this.Empleado);
            this.Tienda.Controls.Add(this.Categoria);
            this.Tienda.Controls.Add(this.Productos);
            this.Tienda.Controls.Add(this.Ventas);
            this.Tienda.Controls.Add(this.tcUsuarios);
            this.Tienda.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tienda.Location = new System.Drawing.Point(-1, 42);
            this.Tienda.Margin = new System.Windows.Forms.Padding(2);
            this.Tienda.Name = "Tienda";
            this.Tienda.SelectedIndex = 0;
            this.Tienda.Size = new System.Drawing.Size(956, 468);
            this.Tienda.TabIndex = 0;
            this.Tienda.SelectedIndexChanged += new System.EventHandler(this.Tienda_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.Image = global::Actividad_CRUD.Properties.Resources.icons8_cerrar_ventana_48;
            this.button1.Location = new System.Drawing.Point(902, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 38);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(951, 509);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tienda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioPrincipal";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vistaInventarioConNombreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProductosConNombreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaVentasConNombreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaVentasConNombreBindingSource1)).EndInit();
            this.tcUsuarios.ResumeLayout(false);
            this.gbUsuarios.ResumeLayout(false);
            this.gbUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.Ventas.ResumeLayout(false);
            this.gbVentas.ResumeLayout(false);
            this.gbVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.Productos.ResumeLayout(false);
            this.gbProductos.ResumeLayout(false);
            this.gbProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.Categoria.ResumeLayout(false);
            this.gbCatergoria.ResumeLayout(false);
            this.gbCatergoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.Empleado.ResumeLayout(false);
            this.gbEmpleado.ResumeLayout(false);
            this.gbEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.Tienda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private tiendaDataSet tiendaDataSet;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private tiendaDataSetTableAdapters.CategoriasTableAdapter categoriasTableAdapter;
        private tiendaDataSet1 tiendaDataSet1;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private tiendaDataSet1TableAdapters.VentasTableAdapter ventasTableAdapter;
        private tiendaDataSet2 tiendaDataSet2;
        private System.Windows.Forms.BindingSource vistaVentasConNombreBindingSource;
        private tiendaDataSet2TableAdapters.VistaVentasConNombreTableAdapter vistaVentasConNombreTableAdapter;
        private tiendaDataSet3 tiendaDataSet3;
        private System.Windows.Forms.BindingSource vistaInventarioConNombreBindingSource;
        private tiendaDataSet3TableAdapters.VistaInventarioConNombreTableAdapter vistaInventarioConNombreTableAdapter;
        private tiendaDataSet4 tiendaDataSet4;
        private System.Windows.Forms.BindingSource vistaProductosConNombreBindingSource;
        private tiendaDataSet4TableAdapters.VistaProductosConNombreTableAdapter vistaProductosConNombreTableAdapter;
        private tiendaDataSet5 tiendaDataSet5;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private tiendaDataSet5TableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private tiendaDataSet6 tiendaDataSet6;
        private System.Windows.Forms.BindingSource vistaVentasConNombreBindingSource1;
        private tiendaDataSet6TableAdapters.VistaVentasConNombreTableAdapter vistaVentasConNombreTableAdapter1;
        private System.Windows.Forms.TabPage tcUsuarios;
        private System.Windows.Forms.GroupBox gbUsuarios;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Button btnLimpiarUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTipoUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.TabPage Ventas;
        private System.Windows.Forms.GroupBox gbVentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpVenta;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.Button btnLimpiarVentas;
        private System.Windows.Forms.Label lblMontoVenta;
        private System.Windows.Forms.TextBox txtMontoVenta;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnEliminarVentas;
        private System.Windows.Forms.Button btnModificarVentas;
        private System.Windows.Forms.Button btnAgregarVentas;
        private System.Windows.Forms.TabPage Productos;
        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.Button btnLimpiarProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbIDCategoria;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.TextBox txtProductos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnEliminarProductos;
        private System.Windows.Forms.Button btnModificarProductos;
        private System.Windows.Forms.Button btnAgregarProductos;
        public System.Windows.Forms.TabPage Categoria;
        private System.Windows.Forms.GroupBox gbCatergoria;
        private System.Windows.Forms.Button btnLimpiarCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.TabPage Empleado;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbEmpleado;
        private System.Windows.Forms.Button btnLimpiarEmpleado;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.TabControl Tienda;
        private System.Windows.Forms.Button button1;
    }
}