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
        }
        // Establece la cadena de conexión a tu base de datos
        string connectionString = @"Data Source =DESKTOP-RELURNF\SQLEXPRESS; Initial Catalog = tienda; Integrated Security = True;";
        Datos datos = new Datos();

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

                // Crea el comando para el procedimiento almacenado
                using (SqlCommand command = new SqlCommand("EliminarCategoria", connection))
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

                // Crea el comando para el procedimiento almacenado
                using (SqlCommand command = new SqlCommand("ModificarCategoria", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    // Agrega parámetros si es necesario
                    command.Parameters.AddWithValue("@NombreCategoria", txtcategoria.Text);
                    // Ejecuta el procedimiento almacenado
                    command.ExecuteNonQuery();
                }

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
                    command.Parameters.AddWithValue("@Cargo",txtCargo);
                    // Ejecuta el procedimiento almacenado
                    command.ExecuteNonQuery();
                }
            }
            dgvEmpleado.DataSource = datos.Categorias();

        }

        private void btnAgregarInventario_Click(object sender, EventArgs e)
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
            dgvInventario.DataSource = datos.Categorias();

        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            //// Crea la conexión
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    // Abre la conexión
            //    connection.Open();
            //    // Crea el comando para el procedimiento almacenado
            //    using (SqlCommand command = new SqlCommand("AgregarProducto", connection))
            //    {
            //        command.CommandType = CommandType.StoredProcedure;
            //        // Agrega parámetros si es necesario
            //        command.Parameters.AddWithValue("@NombreProducto", txtProducto.Text);
            //        command.Parameters.AddWithValue("@IDCategoria", txt);
            //        command.Parameters.AddWithValue("@NombreProducto", txtcategoria.Text);
            //        // Ejecuta el procedimiento almacenado
            //        command.ExecuteNonQuery();
            //    }
            //}
            //dgvProductos.DataSource = datos.Categorias();

        }
    }
}
