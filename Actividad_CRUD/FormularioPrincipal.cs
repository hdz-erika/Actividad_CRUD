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

namespace Actividad_CRUD
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
            dgvCategoria.CellClick += dgvCategoria_CellClick;
        }
        // Establece la cadena de conexión a tu base de datos
        string connectionString = @"Data Source =DESKTOP-RELURNF\SQLEXPRESS; Initial Catalog = tienda; Integrated Security = True;";
        Datos datos = new Datos();
        int id;
        string NombreCategoria;

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
        
            //// Crea la conexión
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    // Abre la conexión
            //    connection.Open();

           
            //    // Crea el comando para el procedimiento almacenado
            //    using (SqlCommand command = new SqlCommand("AgregarEmpleado", connection))
            //    {
            //        command.CommandType = CommandType.StoredProcedure;
            //        // Agrega parámetros si es necesario
            //        command.Parameters.AddWithValue("@@NombreEmpleado", txtEmpleado);
            //        command.Parameters.AddWithValue("@Cargo", txtCargo);
            //        // Ejecuta el procedimiento almacenado
            //        command.ExecuteNonQuery();
            //    }

            //}

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gbProductos_Enter(object sender, EventArgs e)
        {

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
                    command.Parameters.AddWithValue("@NuevoNombreCategoria",txtcategoria.Text );
                    // Ejecuta el procedimiento almacenado
                    command.ExecuteNonQuery();
                }
                dgvCategoria.DataSource = datos.Categorias();

            }

        }

        private void Tienda_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void Tienda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tienda.SelectedTab == Categoria) 
            {
                dgvCategoria.DataSource = datos.Categorias();
            }
            if (Tienda.SelectedTab ==Empleado)
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
                    command.Parameters.AddWithValue("@Cargo",txtCargo.Text);
                    // Ejecuta el procedimiento almacenado
                    command.ExecuteNonQuery();
                }
            }
            dgvEmpleado.DataSource = datos.Empleados();

        }

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
                    command.Parameters.AddWithValue("@NombreProducto", txtProducto.Text);
                    command.Parameters.AddWithValue("@NombreProducto", txtcategoria.Text);
                    // Ejecuta el procedimiento almacenado
                    command.ExecuteNonQuery();
                }
            }
            dgvProductos.DataSource = datos.Categorias();

        }

        private void btnEliminarInventario_Click(object sender, EventArgs e)
        {

        }

        private void dgvCategoria_Click(object sender, EventArgs e)
        {

        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                // Verifica si la celda clickeada no es el encabezado de la fila
                if (e.RowIndex >= 0)
                {
                    // Obtén el valor de la celda que contiene el ID (supongamos que está en la primera columna)
                    DataGridViewRow fila = dgvCategoria.Rows[e.RowIndex];
                    id = Convert.ToInt32(fila.Cells["IDCategoria"].Value); // Reemplaza "IDColumna" con el nombre de tu columna de ID
                     // MessageBox.Show("El ID seleccionado es: " + id.ToString());
                    //NombreCategoria =Convert.ToString(fila.Cells["IDCategoria"].Value);
                 }

        }
    }
}
