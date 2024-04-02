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
        public FormularioPrincipal()
        {
            InitializeComponent();
            dgvCategoria.CellClick += dgvCategoria_CellClick;
            txtPrecioUnitario.KeyPress += new KeyPressEventHandler(txtPrecioUnitario_KeyPress);
        }
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


        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
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
            if (Tienda.SelectedTab == Inventario)
            {
                dgvInventario.DataSource = datos.Inventario();
            }
            if (Tienda.SelectedTab == Productos)
            {
                dgvProductos.DataSource = datos.Productos();
            }
            if (Tienda.SelectedTab == Ventas)
            {
                dgvVentas.DataSource = datos.Ventas();
            }
        }

        #region Categoria

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si la celda clickeada no es el encabezado de la fila
            if (e.RowIndex >= 0)
            {
                // Obtén el valor de la celda que contiene el ID (supongamos que está en la primera columna)
                DataGridViewRow fila = dgvCategoria.Rows[e.RowIndex];
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
                // Obtén el valor de la celda que contiene el ID (supongamos que está en la primera columna)
                DataGridViewRow fila = dgvEmpleado.Rows[e.RowIndex];
                idEmpleado = Convert.ToInt32(fila.Cells["IDEmpleado"].Value); // Reemplaza "IDColumna" con el nombre de tu columna de ID                                                   
                NombreEmpleado = Convert.ToString(fila.Cells["NombreEmpleado"].Value);
                Cargo = Convert.ToString(fila.Cells["Cargo"].Value);
                txtEmpleado.Text = NombreEmpleado;
                txtCargo.Text = Cargo;

            }

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
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

        #region Inventario
        private void btnAgregarInventario_Click(object sender, EventArgs e)
        {
            // Crea la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abre la conexión
                connection.Open();
                // Crea el comando para el procedimiento almacenado
                using (SqlCommand command = new SqlCommand("AgregarInventario", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    // Agrega parámetros si es necesario
                    command.Parameters.AddWithValue("@CantidadEnStock", txtCantidad.Text);
                    // Ejecuta el procedimiento almacenado
                    command.ExecuteNonQuery();
                }
            }
            dgvInventario.DataSource = datos.Categorias();

        }
        private void btnModificarInventario_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarInventario_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Productos

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtén el valor de la celda que contiene el ID (supongamos que está en la primera columna)
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
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
            }
        }


        #endregion

        #region Usuarios

        #endregion

        #region Ventas

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
        private void txtcategoria_Click(object sender, EventArgs e)
        {
            txtcategoria.SelectAll();
        }

        private void txtInventario_Click(object sender, EventArgs e)
        {
            txtIDProducto.SelectAll();
        }

        private void txtIDProducto_Click(object sender, EventArgs e)
        {
            txtIDProducto.SelectAll();
        }

        private void txtProductos_Click(object sender, EventArgs e)
        {
            txtProducto.SelectAll();
        }

        private void txtPrecioUnitario_Click(object sender, EventArgs e)
        {
            txtPrecioUnitario.SelectAll();
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

        private void btnLimpiarInventario_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxes(gbInventario);
        }

        private void btnLimpiarProductos_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxes(gbProductos);
        }

        private void btnLimpiarVentas_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxes(gbVentas);
        }
        #endregion
      
    }
}
