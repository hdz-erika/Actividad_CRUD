using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_CRUD
{
    internal class Datos
    {
        //Conección a la base de datos "tienda"
        public string Conexion()
        {
            string conectionString = @"Data Source =DESKTOP-RELURNF\SQLEXPRESS; Initial Catalog = tienda; Integrated Security = True;";
            return conectionString;
        }
        //Aquí van las tablas
        public DataTable Categorias()
        {
            string conectionString;
            string Query = "SELECT * FROM Categorias wihth(nolock)";

            conectionString = Conexion();

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                try
                {
                    dataAdapter.Fill(dataTable);

                    connection.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    return null;
                }
            }
        }

        public DataTable Productos()
        {
            string conectionString;
            string Query = "SELECT * FROM VistaProductosConNombre wihth(nolock)";

            conectionString = Conexion();

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                try
                {
                    dataAdapter.Fill(dataTable);

                    connection.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    return null;
                }
            }
        }
public DataTable Ventas()
{
    string conectionString;
    string Query = "SELECT * FROM VistaVentasConNombre wihth(nolock)";

    conectionString = Conexion();

    using (SqlConnection connection = new SqlConnection(conectionString))
    {
        connection.Open();
        SqlCommand command = new SqlCommand(Query, connection);
        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

        DataTable dataTable = new DataTable();

        try
        {
            // Llenar el DataTable con los datos de la consulta
            dataAdapter.Fill(dataTable);

            connection.Close();
            return dataTable;
        }
        catch (Exception ex)
        {
            // Manejar cualquier excepción que pueda ocurrir
            Console.WriteLine("Error: " + ex.Message);
            connection.Close();
            return null;
        }
    }
}

        public DataTable Empleados()
        {
            string conectionString;
            string Query = "SELECT * FROM Empleados wihth(nolock)";

            conectionString = Conexion();

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                try
                {
                    dataAdapter.Fill(dataTable);

                    connection.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    return null;
                }
            }
        }
        public DataTable Usuarios()
        {
            string conectionString;
            string Query = "SELECT * FROM Usuarios wihth(nolock)";

            conectionString = Conexion();

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                try
                {
                    dataAdapter.Fill(dataTable);

                    connection.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    return null;
                }
            }
        }
        public DataTable Inventario()
        {
            string conectionString;
            string Query = "SELECT * FROM Inventario wihth(nolock)";

            conectionString = Conexion();

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                try
                {
                    dataAdapter.Fill(dataTable);

                    connection.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    return null;
                }
            }
        }
    }
}


