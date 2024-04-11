using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Actividad_CRUD
{
    public partial class FormularioPrincipal : Form

    {
        // Establece la cadena de conexión a tu base de datos
        string connectionString = @"Data Source =DESKTOP-RELURNF\SQLEXPRESS; Initial Catalog = tienda; Integrated Security = True;";
        Datos datos = new Datos();
        int id;
        string NombreCategoria;
        int idEmpleado;
        string NombreEmpleado;
        string Cargo;
        int IDProducto;
        string NombreProducto;
        decimal PrecioUnitario;
        int IDCategoria;
        int IDProductos;
        int CantidadStock;
        int IDInventario;
        int IDVenta;
        decimal MontoVenta;
        DateTime FechaVenta;
        int IDUsuario;
        string Contrasena;
        string TipoUsuario;
        string NombreUsuario;
        public FormularioPrincipal()
        {
            
            InitializeComponent();
            this.BackColor = Color.FromArgb(51, 62, 103);
            this.dgvEmpleado.DefaultCellStyle.Font = new Font("Black", 8);
            this.dgvEmpleado.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvCategoria.DefaultCellStyle.Font = new Font("Black", 8);
            this.dgvCategoria.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvProductos.DefaultCellStyle.Font = new Font("Black", 8);
            this.dgvProductos.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvUsuarios.DefaultCellStyle.Font = new Font("Black", 8);
            this.dgvUsuarios.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvVentas.DefaultCellStyle.Font = new Font("Black", 8);
            this.dgvVentas.DefaultCellStyle.ForeColor = Color.Black;

            dgvCategoria.CellClick += dgvCategoria_CellClick;
            txtPrecioUnitario.KeyPress += new KeyPressEventHandler(txtPrecioUnitario_KeyPress);
        }
   
        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(25, 25, 25);
            
            
            // TODO: This line of code loads data into the 'tiendaDataSet6.VistaVentasConNombre' table. You can move, or remove it, as needed.
            this.vistaVentasConNombreTableAdapter1.Fill(this.tiendaDataSet6.VistaVentasConNombre);
            // TODO: This line of code loads data into the 'tiendaDataSet5.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.tiendaDataSet5.Usuarios);
            // TODO: This line of code loads data into the 'tiendaDataSet4.VistaProductosConNombre' table. You can move, or remove it, as needed.
            this.vistaProductosConNombreTableAdapter.Fill(this.tiendaDataSet4.VistaProductosConNombre);
            // TODO: This line of code loads data into the 'tiendaDataSet3.VistaInventarioConNombre' table. You can move, or remove it, as needed.
            this.vistaInventarioConNombreTableAdapter.Fill(this.tiendaDataSet3.VistaInventarioConNombre);
            // TODO: This line of code loads data into the 'tiendaDataSet2.VistaVentasConNombre' table. You can move, or remove it, as needed.           
            // TODO: This line of code loads data into the 'tiendaDataSet1.Ventas' table. You can move, or remove it, as needed.
            this.ventasTableAdapter.Fill(this.tiendaDataSet1.Ventas);
            // TODO: This line of code loads data into the 'tiendaDataSet.Categorias' table. You can move, or remove it, as needed.
            this.categoriasTableAdapter.Fill(this.tiendaDataSet.Categorias);

            
            dgvEmpleado.DataSource = datos.Empleados();
        }
        private void Tienda_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Tienda.SelectedTab == Categoria)
            {
                dgvCategoria.DataSource = datos.Categorias();
            }
            if (Tienda.SelectedTab == Empleado)
            {
                dgvEmpleado.DataSource = datos.Empleados();
            }
            if (Tienda.SelectedTab == Productos)
            {
                dgvProductos.DataSource = datos.Productos();
            }
            if (Tienda.SelectedTab == Ventas)
            {
                dgvVentas.DataSource = datos.Ventas();
            }
            if (Tienda.SelectedTab == tcUsuarios)
            {
                dgvUsuarios.DataSource = datos.Usuarios();
            }

        }

        #region Categoria

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCategoria.Rows[e.RowIndex];

                // Verificar si alguna celda está vacía
                bool celdaVacia = false;
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (string.IsNullOrEmpty(celda.Value?.ToString()))
                    {
                        celdaVacia = true;
                        break;
                    }
                }

                // Si alguna celda está vacía, mostrar advertencia
                if (celdaVacia)
                {
                    MessageBox.Show("¡La fila seleccionada no contiene datos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
               
                id = Convert.ToInt32(fila.Cells["IDCategoria"].Value); // Reemplaza "IDColumna" con el nombre de tu columna de ID                                                   
                NombreCategoria = Convert.ToString(fila.Cells["NombreCategoria"].Value);
                txtcategoria.Text = NombreCategoria;
            }

        }
        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            // Crea la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abre la conexión
                connection.Open();
                // Crea el comando para el procedimiento almacenado
                using (SqlCommand command = new SqlCommand("AgregarCategoria", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    // Agrega parámetros si es necesario
                    command.Parameters.AddWithValue("@NombreCategoria", txtcategoria.Text);
                    // Ejecuta el procedimiento almacenado
                    command.ExecuteNonQuery();
                }
            }
            dgvCategoria.DataSource = datos.Categorias();
        }
        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            // Crea la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Crea el comando para el procedimiento almacenado
                using (SqlCommand command = new SqlCommand("ModificarCategoria", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    // Agrega parámetros si es necesario
                    command.Parameters.AddWithValue("@IDCategoria", id);
                    command.Parameters.AddWithValue("@NuevoNombreCategoria", txtcategoria.Text);
                    // Ejecuta el procedimiento almacenado
                    command.ExecuteNonQuery();
                }
                dgvCategoria.DataSource = datos.Categorias();

            }

        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {// Crea la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Crea el comando para el procedimiento almacenado
                using (SqlCommand command = new SqlCommand("EliminarCategoria", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    // Agrega parámetros si es necesario
                    command.Parameters.AddWithValue("@IDCategoria", id);
                    // Ejecuta el procedimiento almacenado
                    command.ExecuteNonQuery();
                }
            }
            dgvCategoria.DataSource = datos.Categorias();

        }

        #endregion

        #region Empleados
        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvEmpleado.Rows[e.RowIndex];

                // Verificar si alguna celda está vacía
                bool celdaVacia = false;
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (string.IsNullOrEmpty(celda.Value?.ToString()))
                    {
                        celdaVacia = true;
                        break;
                    }
                }

                // Si alguna celda está vacía, mostrar advertencia
                if (celdaVacia)
                {
                    MessageBox.Show("¡La fila seleccionada no contiene datos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
              
                idEmpleado = Convert.ToInt32(fila.Cells["IDEmpleado"].Value); // Reemplaza "IDColumna" con el nombre de tu columna de ID                                                   
                NombreEmpleado = Convert.ToString(fila.Cells["NombreEmpleado"].Value);
                Cargo = Convert.ToString(fila.Cells["Cargo"].Value);
                txtEmpleado.Text = NombreEmpleado;
                txtCargo.Text = Cargo;

            }

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreEmpleado = txtEmpleado.Text;
            string cargo = txtCargo.Text;

            // Verificar si alguno de los campos está vacío
            if (string.IsNullOrEmpty(nombreEmpleado) || string.IsNullOrEmpty(cargo))
            {
                // Mostrar un mensaje de advertencia si uno o más campos están vacíos
                MessageBox.Show("No hay datos que agregar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            // Crea la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abre la conexión
                connection.Open();
                // Crea el comando para el procedimiento almacenado
                using (SqlCommand command = new SqlCommand("AgregarEmpleado", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    // Agrega parámetros si es necesario
                    command.Parameters.AddWithValue("@NombreEmpleado", txtEmpleado.Text);
                    command.Parameters.AddWithValue("@Cargo", txtCargo.Text);
                    // Ejecuta el procedimiento almacenado
                    command.ExecuteNonQuery();
                }
            }
            dgvEmpleado.DataSource = datos.Empleados();

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Crea la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abre la conexión
                connection.Open();
                // Crea el comando para el procedimiento almacenado
                using (SqlCommand command = new SqlCommand("ModificarEmpleado", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    // Agrega parámetros si es necesario
                    command.Parameters.AddWithValue("@IDEmpleado", idEmpleado);
                    command.Parameters.AddWithValue("@NuevoNombreEmpleado", txtEmpleado.Text);
                    command.Parameters.AddWithValue("@NuevoCargo", txtCargo.Text);
                    // Ejecuta el procedimiento almacenado
                    command.ExecuteNonQuery();
                }
            }
            dgvEmpleado.DataSource = datos.Empleados();

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Crea la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abre la conexión
                connection.Open();
                // Crea el comando para el procedimiento almacenado
                using (SqlCommand command = new SqlCommand("EliminarEmpleado", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    // Agrega parámetros si es necesario
                    command.Parameters.AddWithValue("@IDEmpleado", idEmpleado);
                    // Ejecuta el procedimiento almacenado
                    command.ExecuteNonQuery();
                }
            }
            dgvEmpleado.DataSource = datos.Empleados();
        }




        #endregion

        #region Productos

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

                // Verificar si alguna celda está vacía
                bool celdaVacia = false;
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (string.IsNullOrEmpty(celda.Value?.ToString()))
                    {
                        celdaVacia = true;
                        break;
                    }
                }

                // Si alguna celda está vacía, mostrar advertencia
                if (celdaVacia)
                {
                    MessageBox.Show("¡La fila seleccionada no contiene datos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

              
                IDProducto = Convert.ToInt32(fila.Cells["IDProducto"].Value); // Reemplaza "IDColumna" con el nombre de tu columna de ID                                                   
                NombreProducto = Convert.ToString(fila.Cells["NombreProducto"].Value);
                IDCategoria = Convert.ToInt32(fila.Cells["IDCategoria"].Value);
                PrecioUnitario = Convert.ToDecimal(fila.Cells["PrecioUnitario"].Value);
                txtProductos.Text = NombreProducto;
                txtPrecioUnitario.Text = PrecioUnitario.ToString();
                cbIDCategoria.SelectedValue = IDCategoria;
            }
        }
        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            // Crea la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abre la conexión
                connection.Open();
                // Crea el comando para el procedimiento almacenado
                using (SqlCommand command = new SqlCommand("AgregarProducto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    // Agrega parámetros si es necesario
                    command.Parameters.AddWithValue("@NombreProducto", txtProductos.Text);
                    command.Parameters.AddWithValue("@IDCategoria", cbIDCategoria.SelectedValue);
                    command.Parameters.AddWithValue("@PrecioUnitario", txtPrecioUnitario.Text);

                    // Ejecuta el procedimiento almacenado
                    command.ExecuteNonQuery();
                }
            }
            dgvProductos.DataSource = datos.Productos();

        }
    
        private void btnModificarProductos_Click(object sender, EventArgs e)
        {
            // Crea la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abre la conexión
                connection.Open();
                // Crea el comando para el procedimiento almacenado
                using (SqlCommand command = new SqlCommand("ModificarProducto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    // Agrega parámetros si es necesario
                    command.Parameters.AddWithValue("@NuevoNombreProducto", txtProductos.Text);
                    command.Parameters.AddWithValue("@NuevoPrecioUnitario ", txtPrecioUnitario.Text);
                    command.Parameters.AddWithValue("@IDProducto", IDProducto);
                    command.Parameters.AddWithValue("@NuevaIDCategoria", cbIDCategoria.SelectedValue);
                    // Ejecuta el procedimiento almacenado
                    command.ExecuteNonQuery();
                }
            }
            dgvProductos.DataSource = datos.Productos();

        }
        private void btnEliminarProductos_Click(object sender, EventArgs e)
        {
            // Crea la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abre la conexión
                connection.Open();
                // Crea el comando para el procedimiento almacenado
                using (SqlCommand command = new SqlCommand("EliminarProducto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    // Agrega parámetros si es necesario
                    command.Parameters.AddWithValue("@IDProducto", IDProducto);

                    // Ejecuta el procedimiento almacenado
                    command.ExecuteNonQuery();
                }
            }
            dgvProductos.DataSource = datos.Productos();
        }


        private void txtPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número o la tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Cancela la entrada de caracteres no numéricos
                e.Handled = true;
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        #endregion

        #region Usuarios
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

                // Verificar si alguna celda está vacía
                bool celdaVacia = false;
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (string.IsNullOrEmpty(celda.Value?.ToString()))
                    {
                        celdaVacia = true;
                        break;
                    }
                }

                // Si alguna celda está vacía, mostrar advertencia
                if (celdaVacia)
                {
                    MessageBox.Show("¡La fila seleccionada no contiene datos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                NombreUsuario= Convert.ToString(fila.Cells["NombreUsuario"].Value); // Reemplaza "IDColumna" con el nombre de tu columna de ID                                                   
                Contrasena = Convert.ToString(fila.Cells["Contraseña"].Value);
                TipoUsuario = Convert.ToString(fila.Cells["TipoUsuario"].Value);
                IDUsuario = Convert.ToInt32(fila.Cells["IDUsuario"].Value);

                txtNombreUsuario.Text = NombreUsuario;
                txtContrasena.Text = Contrasena;   
                txtTipoUsuario.Text = TipoUsuario;  
            }

        }
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            // Crea la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abre la conexión
                connection.Open();
                // Crea el comando para el procedimiento almacenado
                using (SqlCommand command = new SqlCommand("AgregarUsuario", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    // Agrega parámetros si es necesario
                    command.Parameters.AddWithValue("@NombreUsuario", txtNombreUsuario.Text);
                    command.Parameters.AddWithValue("@Contraseña", txtContrasena.Text);
                    command.Parameters.AddWithValue("@TipoUsuario", txtTipoUsuario.Text);

                    // Ejecuta el procedimiento almacenado
                    command.ExecuteNonQuery();
                }
            }
            dgvUsuarios.DataSource = datos.Usuarios();

        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            // Crea la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abre la conexión
                connection.Open();
                // Crea el comando para el procedimiento almacenado
                using (SqlCommand command = new SqlCommand("ModificarUsuario", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    // Agrega parámetros si es necesario
                    command.Parameters.AddWithValue("@IDUsuario", IDUsuario);
                    command.Parameters.AddWithValue("@NuevoNombreUsuario", txtNombreUsuario.Text);
                    command.Parameters.AddWithValue("@NuevaContraseña", txtContrasena.Text);
                    command.Parameters.AddWithValue("@NuevoTipoUsuario", txtTipoUsuario.Text);

                    // Ejecuta el procedimiento almacenado
                    command.ExecuteNonQuery();
                }
            }
            dgvUsuarios.DataSource = datos.Usuarios();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            // Crea la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abre la conexión
                connection.Open();
                // Crea el comando para el procedimiento almacenado
                using (SqlCommand command = new SqlCommand("EliminarUsuario", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    // Agrega parámetros si es necesario
                    command.Parameters.AddWithValue("@IDUsuario", IDUsuario);
                    // Ejecuta el procedimiento almacenado
                    command.ExecuteNonQuery();
                }
            }
            dgvUsuarios.DataSource = datos.Usuarios();

        }

        #endregion

        #region Ventas
        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvVentas.Rows[e.RowIndex];

                // Verificar si alguna celda está vacía
                bool celdaVacia = false;
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (string.IsNullOrEmpty(celda.Value?.ToString()))
                    {
                        celdaVacia = true;
                        break;
                    }
                }

                // Si alguna celda está vacía, mostrar advertencia
                if (celdaVacia)
                {
                    MessageBox.Show("¡La fila seleccionada no contiene datos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Si todas las celdas tienen datos, obtener los valores de las celdas
                IDVenta = Convert.ToInt32(fila.Cells["IDVenta"].Value);
                CantidadStock = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                MontoVenta= Convert.ToDecimal(fila.Cells["MontoVenta"].Value);
                IDProducto = Convert.ToInt32(fila.Cells["IDProducto"].Value);
                FechaVenta = Convert.ToDateTime(fila.Cells["FechaVenta"].Value);
                txtCantidad.Text = CantidadStock.ToString();
                cbProducto.SelectedValue = IDProducto;
                txtMontoVenta.Text = MontoVenta.ToString();              
                dtpVenta.Value = FechaVenta;

            }
        }

        private void btnAgregarVentas_Click(object sender, EventArgs e)
        {
            // Crea la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abre la conexión
                connection.Open();
                // Crea el comando para el procedimiento almacenado
                using (SqlCommand command = new SqlCommand("AgregarVenta", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    // Agrega parámetros si es necesario
                    command.Parameters.AddWithValue("@IDProducto", cbProducto.SelectedValue);
                    command.Parameters.AddWithValue("@FechaVenta", dtpVenta.Value);
                    command.Parameters.AddWithValue("@Cantidad", txtCantidad.Text);
                    command.Parameters.AddWithValue("@MontoVenta", txtMontoVenta.Text);
                    SqlParameter StockRestante = new SqlParameter();
                    StockRestante.ParameterName = "@StockRestante";
                    StockRestante.SqlDbType = SqlDbType.Int;
                    StockRestante.Direction = ParameterDirection.Output;
                    command.Parameters.Add(StockRestante);
                    // Ejecuta el procedimiento almacenado
                    command.ExecuteNonQuery();
                    int totalStockRestante = (int)StockRestante.Value;
                    // Verificar si hay una advertencia
                    if (totalStockRestante <= 0)
                    {
                        MessageBox.Show("¡El producto ya no tiene existencias!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (totalStockRestante < 5)
                    {
                        MessageBox.Show("¡Quedan menos de 5 existencias en stock!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            dgvVentas.DataSource = datos.Ventas();

        }

        private void btnModificarVentas_Click(object sender, EventArgs e)
        {
            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abre la conexión
                connection.Open();
                // Crea el comando para el procedimiento almacenado
                using (SqlCommand command = new SqlCommand("ModificarVenta", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    // Agrega parámetros
                    command.Parameters.AddWithValue("@IDVenta", IDVenta); // ID de la venta a modificar
                    command.Parameters.AddWithValue("@IDProducto", cbProducto.SelectedValue);
                    command.Parameters.AddWithValue("@FechaVenta", dtpVenta.Value);
                    command.Parameters.AddWithValue("@Cantidad", txtCantidad.Text);
                    command.Parameters.AddWithValue("@MontoVenta", txtMontoVenta.Text);
                    SqlParameter stockRestanteParam = new SqlParameter();
                    stockRestanteParam.ParameterName = "@StockRestante";
                    stockRestanteParam.SqlDbType = SqlDbType.Int;
                    stockRestanteParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(stockRestanteParam);
                    // Ejecuta el procedimiento almacenado
                    command.ExecuteNonQuery();
                    int stockRestante = (int)stockRestanteParam.Value;

                    // Verificar si hay una advertencia
                    if (stockRestante <= 0)
                    {
                        MessageBox.Show("¡El producto ya no tiene existencias!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (stockRestante < 5)
                    {
                        MessageBox.Show("¡Quedan menos de 5 existencias en stock!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void btnEliminarVentas_Click(object sender, EventArgs e)
        {
            // Crea la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abre la conexión
                connection.Open();
                // Crea el comando para el procedimiento almacenado
                using (SqlCommand command = new SqlCommand("EliminarVenta", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    // Agrega parámetros si es necesario
                    command.Parameters.AddWithValue("@IDVenta", IDVenta);
                    // Ejecuta el procedimiento almacenado
                    command.ExecuteNonQuery();
                
                }
            }
            dgvVentas.DataSource = datos.Ventas();
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número o la tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Cancela la entrada de caracteres no numéricos
                e.Handled = true;
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtMontoVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número o la tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Cancela la entrada de caracteres no numéricos
                e.Handled = true;
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        

        #endregion

        #region SelectAll
        private void txtEmpleado_Click(object sender, EventArgs e)
        {
            txtEmpleado.SelectAll();
        }

        private void txtCargo_Click(object sender, EventArgs e)
        {
            txtCargo.SelectAll();
        }
        private void txtPrecioUnitario_Click(object sender, EventArgs e)
        {
            txtPrecioUnitario.SelectAll();
        }
        private void txtContrasena_Click(object sender, EventArgs e)
        {
            txtContrasena.SelectAll();
        }

        private void txtTipoUsuario_Click(object sender, EventArgs e)
        {
            txtTipoUsuario.SelectAll();
        }

        private void txtNombreUsuario_Click(object sender, EventArgs e)
        {
            txtNombreUsuario.SelectAll();
        }

        private void txtcategoria_Click(object sender, EventArgs e)
        {
            txtcategoria.SelectAll();
        }
        private void txtProductos_Click(object sender, EventArgs e)
        {
            txtProductos.SelectAll();
        }
        private void txtProducto_Click(object sender, EventArgs e)
        {
           txtProductos.SelectAll();    
        }

        private void txtCantidad_Click(object sender, EventArgs e)
        {
            txtCantidad.SelectAll();    
        }

        private void txtMontoVenta_Click(object sender, EventArgs e)
        {
            txtMontoVenta.SelectAll();  
        }
        #endregion //

        #region btnLimpiar
        private void LimpiarTextBoxes(System.Windows.Forms.GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)control;
                    textBox.Clear();
                }
            }
        }

        private void btnLimpiarEmpleado_Click(object sender, EventArgs e)
        {

            LimpiarTextBoxes(gbEmpleado);
        }

        private void btnLimpiarCategoria_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxes(gbCatergoria);
        }

        private void btnLimpiarProductos_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxes(gbProductos);
        }

        private void btnLimpiarVentas_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxes(gbVentas);
        }

        private void btnLimpiarUsuario_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxes(gbUsuarios);
        }



        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
